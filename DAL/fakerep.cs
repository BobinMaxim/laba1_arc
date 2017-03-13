using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using model;

namespace DAL
{
    public class fakerep:IReposetory
    {
        public List<Prisoner> GetALL()
        {
            return new List<Prisoner> 
        {
            new Prisoner
            {
                Name = "Pr1",
                Number = "123",
                Detention = new TimeSpan(5, 0, 0, 0),
                StartDetention = DateTime.Now - new TimeSpan(5, 0, 0, 0)
            },
            new Prisoner
            {
                Name = "Pr2",
                Number = "1234",
                Detention = new TimeSpan(5, 0, 0, 0),
                StartDetention = DateTime.Now - new TimeSpan(6, 0, 0, 0)

            },
             new Prisoner
            {
                Name = "Pr3",
                Number = "12345",
                Detention = new TimeSpan(10, 0, 0, 0),
                StartDetention = DateTime.Now - new TimeSpan(7, 0, 0, 0)
            }
        };

        }
    }
}
