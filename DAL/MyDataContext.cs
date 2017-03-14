using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace DAL
{
    public class MyDataContext:DbContext
    {
        public DbSet<Prisoner> Prisoners { get; set; }
        public DbSet<IK> Iks { get; set; }
    }
}
