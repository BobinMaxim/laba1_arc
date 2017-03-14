using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlRep:IReposetory
    {
        private MyDataContext _context =new MyDataContext();

        public List<Prisoner> GetALL()
        {
            return _context.Set<Prisoner>().ToList();

        }
        public void Save() { _context.SaveChanges(); }
        public void Add(Prisoner p)
        { _context.Prisoners.Add(p); }

    }
}
