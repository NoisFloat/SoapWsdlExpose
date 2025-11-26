using System;

namespace DemoSoapService
{
    public class GreetingService : IGreetingService
    {
        public string GetAsciiGreeting(string name)
        {
            var banner = @"
  _   _      _ _        
 | | | | ___| | | ___   
 | |_| |/ _ \ | |/ _ \  
 |  _  |  __/ | | (_) | 
 |_| |_|\___|_|_|\___/  
";
            return banner + Environment.NewLine + "Hola " + name;
        }

        public string SayHola()
        {
            return "Hola desde el servicio SOAP";
        }
    }
}
