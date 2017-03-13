using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Prisoner
    {
        public string Name { get; set; }
        public string Number{ get; set; }
        public TimeSpan Detention { get; set; }
        public DateTime StartDetention { get; set; }
        public DateTime StartDetention1 { get; set; }
        public bool IsPrisoner
        {
            get { return DateTime.Now > StartDetention.Add(Detention); }
        }

    }
}
