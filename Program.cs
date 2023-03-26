namespace Klinika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*/  Console.WriteLine("Hello, World!");
              Klient client = new Klient();
              client.SetDisease(Disease.Stomachache, true);
              client.SetDisease(Disease.Headache, true);

              // создаем адрес клиента
              Console.Write("Введите имя клиента: ");
              string firstName = Console.ReadLine();
              Console.Write("Введите фамилию клиента: ");
              string lastName = Console.ReadLine();
              Console.Write("Введите адрес клиента: ");
              string address = Console.ReadLine();
              Adres Klientaddress = new Adres(firstName, lastName, address);
              // Adres address = new Adres(firstName, lastName, address);
              Console.Clear();
              // создаем врача
              Dentysta doctor = new Dentysta();
              doctor.SelectServices(client);


              Console.WriteLine($"{firstName}\n{lastName}\n{address}");
              // создаем чек
              Faktura receipt = new Faktura();// client, address, doctor.SelectedServices);
              Console.WriteLine(receipt);
              receipt.PrintReceipt(client, Klientaddress, doctor );
              /*/

            static void Main(string[] args)
            {
                Console.Write("Введите имя клиента: ");
                string firstName = Console.ReadLine();

                Console.Write("Введите фамилию клиента: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("Выберите болезни, от которых страдает клиент (чтобы закончить выбор, введите 'end'):");

                List<Disease> diseases = new List<Disease>();

                while (true)
                {
                    Console.Write("Болезнь: ");
                    string diseaseName = Console.ReadLine();

                    if (diseaseName == "end")
                    {
                        break;
                    }

                    Console.Write("Уровень услуги (от 1 до 4): ");
                    int serviceLevel = int.Parse(Console.ReadLine());

                    Disease disease = new Disease
                    {
                        Name = diseaseName,
                        Level = serviceLevel
                    };

                    diseases.Add(disease);
                }

                Console.WriteLine("Выберите услуги для клиента (чтобы закончить выбор, введите 'end'):");

                List<SelectedService> services = new List<SelectedService>();

                while (true)
                {
                    Console.Write("Услуга (1 - Консультация, 2 - Обследование, 3 - Лечение, 4 - Операция): ");
                    int serviceChoice = int.Parse(Console.ReadLine());

                    if (serviceChoice == 0)
                    {
                        break;
                    }

                    Console.Write("Уровень услуги (от 1 до 4): ");
                    int serviceLevel = int.Parse(Console.ReadLine());

                    Service service = (Service)serviceChoice;
                    SelectedService selectedService = new SelectedService
                    {
                        Service = service,
                        Level = serviceLevel
                    };

                    services.Add(selectedService);
                }

                Client client = new Client
                {
                    FirstName = firstName,
                    LastName = lastName,
                    SelectedDiseases = diseases,
                    SelectedServices = services
                };

                Adres address = new Adres();
                address.ReadAddressFromConsole();

                Doctor doctor = new Doctor();
                doctor.SelectServices(client.SelectedDiseases);

                Faktura receipt = new Faktura();
                receipt.PrintReceipt(client, address, doctor);

                Console.ReadKey();
            }

        }
    }
}