using Exception_Sealed_Practice.Services;
using Exception_Sealed_Practice.Services.Interfaces;

ITransportService transportService = new TransportService();

while (true)
{
    transportService.CreateTransport("", "", 0, "");

    Console.WriteLine("\nDo you want to add another transport? (y/n)");
    string response = Console.ReadLine();

    if (response?.ToLower() != "y")
    {
        break;
    }
}

transportService.GetAllTransports();
