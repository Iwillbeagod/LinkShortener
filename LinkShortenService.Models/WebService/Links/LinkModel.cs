using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortenService.Models.WebService.Links
{
    public class LinkModel : ILinkModel
    {
        public string OriginUrl { get; set; }
        public string ShortcutUrl { get; set; }

        public int LinkId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int FollowingCount { get; set; }
    }
}
