using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus05
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var r = new PersonNuGetPackage.PersonRepositoryRandom();

            var people = r.GetPeople(100);

            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
            }

            var res = people.OrderBy(i => i.Name);

            Console.WriteLine("Sorteret af navn");

            foreach (var item in res)
            {
                
                Console.WriteLine(item.Gender);
                Console.WriteLine(item.Name);
            }

            var res2 = people.Where(i => i.Height < 170).Where(i => i.IsHealthy);

            foreach (var item in res2)
            {
                Console.WriteLine(item.Height);
                Console.WriteLine(item.IsHealthy);
            }

            var res3 = people.GroupBy(i => i.Gender);

            foreach (var gender in res3)
            {
                foreach (var person in gender)
                {
                    Console.WriteLine(person.Gender);
                }
            }

            Console.ReadLine();
        }
    }
}
