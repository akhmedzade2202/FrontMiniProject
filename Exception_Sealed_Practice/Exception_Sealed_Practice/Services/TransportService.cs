using Exception_Sealed_Practice.CustomExceptions;
using Exception_Sealed_Practice.Model;
using Exception_Sealed_Practice.Services.Interfaces;
using System;

namespace Exception_Sealed_Practice.Services
{
    public class TransportService : ITransportService
    {
        private Transport[] _transports = new Transport[0];

        public void CreateTransport(string model, string brand, int year, string title)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter car model: ");
                    model = Console.ReadLine();
                    if (string.IsNullOrEmpty(model))
                        throw new NullorException("Model cannot be empty!");
                    break;
                }
                catch (NullorException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter car brand: ");
                    brand = Console.ReadLine();
                    if (string.IsNullOrEmpty(brand) || brand.Length < 3)
                        throw new LengthException("Brand must contain at least 3 characters!");
                    break;
                }
                catch (LengthException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter car year: ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                        throw new YearException("Year cannot be empty!");
                    year = Convert.ToInt32(input);
                    if (year < 1900)
                        throw new YearException("Cars did not exist before 1900!");
                    break;
                }
                catch (YearException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Year must be a number!");
                }
            }

            Console.Write("Enter car title: ");
            title = Console.ReadLine();

            Transport transport = new Transport
            {
                ID = _transports.Length + 1,
                Model = model,
                Brand = brand,
                Year = year,
                title = title
            };

            Array.Resize(ref _transports, _transports.Length + 1);
            _transports[^1] = transport;

            Console.WriteLine("Transport successfully created!\n");
        }

        public void GetAllTransports()
        {
            if (_transports.Length == 0)
            {
                Console.WriteLine("No transports have been created yet.");
                return;
            }

            Console.WriteLine("\nAll transports:");
            foreach (var t in _transports)
            {
                Console.WriteLine($"ID: {t.ID} | Model: {t.Model} | Brand: {t.Brand} | Year: {t.Year} | Title: {t.title}");
            }
        }
    }
}
