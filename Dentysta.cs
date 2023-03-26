using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Doktor
    {
        /*/ public List<Uslugi> SelectedServices { get; set; }
         public void SelectServices(Klient client)
         {

             Console.WriteLine("Select services:");
             foreach (Uslugi service in Enum.GetValues(typeof(Uslugi)))
             {
                 Console.WriteLine($"{(int)service}. {service}");
             }

             List<Uslugi> selectedServices = new List<Uslugi>();
             while (true)
             {
                 Console.Write("Choice (9 to finish): ");
                 int choice = int.Parse(Console.ReadLine());
                 if (choice == 9)
                 {
                     break;
                 }
                 selectedServices.Add((Uslugi)choice);
             }

             Console.WriteLine("Selected services:");
             foreach (Uslugi service in selectedServices)
             {
                 Console.WriteLine(service);
             }

         }
        /*/

        public Service[] Services { get; set; }

        public void PrintAvailableServices()
        {
            Console.WriteLine("Available services:");
            foreach (Service service in Enum.GetValues(typeof(Service)))
            {
                Console.WriteLine($"{(int)service}: {service}");
            }
        }


    }
}
