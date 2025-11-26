using System;
using System.ServiceModel;

namespace DemoSoapService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dirección base del servicio (puerto cambiado a 8888)
            Uri baseAddress = new Uri("http://localhost:8888/GreetingService");

            using (ServiceHost host = new ServiceHost(typeof(GreetingService), baseAddress))
            {
                try
                {
                    host.Open();

                    Console.WriteLine("Servicio SOAP levantado.");
                    Console.WriteLine("Endpoints:");
                    foreach (var endpoint in host.Description.Endpoints)
                    {
                        Console.WriteLine($"  - {endpoint.Address} ({endpoint.Binding.Name})");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Prueba en el navegador:");
                    Console.WriteLine("  http://localhost:8888/GreetingService?wsdl");
                    Console.WriteLine();
                    Console.WriteLine("Pulsa ENTER para detener el servicio...");
                    Console.ReadLine();

                    host.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al iniciar el servicio:");
                    Console.WriteLine(ex);
                    Console.ReadLine();
                }
            }
        }
    }
}
