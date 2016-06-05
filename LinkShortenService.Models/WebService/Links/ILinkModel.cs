using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortenService.Models.WebService.Links
{
    public interface ILinkModel
    {
        string OriginUrl { get; set; }
        string ShortcutUrl { get; set; }
    }
}
