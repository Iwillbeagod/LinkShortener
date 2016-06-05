using LinkShortenService.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortenService.Core.Services
{
    public abstract class BaseService
    {
        private LinkShortenDBEntities _context;
        public LinkShortenDBEntities Context { get { return _context; } private set { _context = value; } }

        public BaseService(LinkShortenDBEntities context)
        {
            _context = context;
        }
    }
}
