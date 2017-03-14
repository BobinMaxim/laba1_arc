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
            string[] names = System.IO.File.ReadAllLines(@"names.txt");

            IEnumerable<Prisoner> queryNames =
                from nameLine in names
                let splitName = nameLine.Split(';')

                select new Prisoner()
                {
                    Name = splitName[0],
                    Number = splitName[1],
                    Detention = TimeSpan.Parse(splitName[2]),
                    StartDetention = Convert.ToDateTime(splitName[3])
                };
            List<Prisoner> Prisoners = queryNames.ToList();

            return Prisoners;

          
        }
    }
}