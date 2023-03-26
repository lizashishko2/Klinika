using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Faktura
    {

        /*/ public void PrintReceipt(Klient client, Adres address, Dentysta doctor)
         {
             Console.WriteLine($"Name: {address.FirstName} {address.LastName}");
             Console.WriteLine($"Address: {address.Street}");
             Console.Write("Diseases: ");
             foreach (Disease disease in Enum.GetValues(typeof(Disease)))
             {
                 if (client.HasDisease(disease))
                 {
                     Console.Write($"{disease}, ");
                 }
             }
             Console.WriteLine();

             Console.Write("Services: ");
             foreach (Uslugi service in doctor.SelectedServices)
             {
                 Console.Write($"{service}, ");
             }
             Console.WriteLine();
         }/*/
        public void PrintReceipt(Klient client, Adres address, Doctor doctor)
        {
            Console.WriteLine("Receipt:");
            Console.WriteLine($"Client: {client.FirstName} {client.LastName}");
            Console.WriteLine($"Address: {address.City}, {address.Street}, {address.Building}");
            Console.WriteLine("Diseases:");
            foreach (Disease d in client.Disease)
            {
                Console.WriteLine($"- {d}");
            }
            Console.WriteLine("Services:");
            foreach (Service s in doctor.SelectedServices)
            {
                Console.WriteLine($"- {s.ServiceName} ({s.ServiceLevel})");
            }
            Console.WriteLine($"Total: {doctor.CalculateCost():C}");
        }


    }
}
