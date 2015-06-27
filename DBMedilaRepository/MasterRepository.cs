using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMedilaRepository
{
    public  class MasterRepository
    {
        protected readonly DBMedilaSystemContext _context;

        public MasterRepository()
        {
            if (_context == null)
                _context = new DBMedilaSystemContext();
        }
    }
}
