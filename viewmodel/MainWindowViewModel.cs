using DAL;
using model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace viewmodel
{
    public class MainWindowViewModel
    {
        public List<Prisoner> Prisoners { get; set; } 


        // public List<Prisoner> IsPrisoners { get; set; }
        public List<Prisoner> IsPrisoners { get; set; }//= new List<Prisoner> (Prisoners.Where(p => p.IsPrisoner).ToList());
        public List<Prisoner> IsnotPrisoners{ get; set; }

        public MainWindowViewModel()
        {
            var rep = new fakerep();
            Prisoners = rep.GetALL();
            IsPrisoners = Prisoners
                .Where(p => p.IsPrisoner)
                .ToList();
            IsnotPrisoners = Prisoners
                .Where(p =>! p.IsPrisoner)
                .ToList();
        }

    }
}