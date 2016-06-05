using LinkShortenService.Data.Tables;
using LinkShortenService.Models.WebService.Common;
using LinkShortenService.Models.WebService.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortenService.Core.Services.Links
{
    public class LinksService : BaseService
    {
        public LinksService(LinkShortenDBEntities context) : base(context)
        {
            //will become deprecated soon
            AutoMapper.Mapper.CreateMap<Link, LinkModel>();
        }

        public PagedListModel<LinkModel> GetLinks(int page = 0, int pageSize = 20)
        {
            var result = Context.Links.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var total = Context.Links.Count();

            return new PagedListModel<LinkModel>()
            {
                Items = result.Select(x => AutoMapper.Mapper.Map<Link, LinkModel>(x)).ToList(),
                Total = total
            };
        }

        public Link CreateLink(string originUrl)
        {
            var link = new Link()
            {
                OriginUrl = originUrl
            };

            link.ShortсutUrl = UrlShorteningService.GetShortenUrl(originUrl);

            Context.Links.Add(link);

            Context.SaveChanges();

            return link;
        }

        public string LinkFollowed(string shortcutUrl)
        {
            var link = Context.Links.FirstOrDefault(x => x.ShortсutUrl == shortcutUrl);

            if (link != null)
            {
                link.FollowingCount++;
            }

            Context.SaveChanges();

            return link.OriginUrl;
        }
    }
}
