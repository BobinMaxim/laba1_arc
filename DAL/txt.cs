using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using model;


namespace DAL
{
    public class txt : IReposetory
    {
        public List<Prisoner> GetALL()
        {
            return new List<Prisoner>
        {
            new Prisoner
            {
                Name = File.ReadLines("input.txt").Skip(1).First(),
                Number = "123",
                Detention = new TimeSpan(5, 0, 0, 0),
                StartDetention = DateTime.Now - new TimeSpan(5, 0, 0, 0)
            }   
          
          
        };

        }
    }
}