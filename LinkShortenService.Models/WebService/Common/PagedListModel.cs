using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortenService.Models.WebService.Common
{
    public class PagedListModel<T>
    {
        public int Total { get; set; }
        public List<T> Items { get; set; }
    }
}
