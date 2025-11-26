using System.ServiceModel;

namespace DemoSoapService
{
    [ServiceContract(Namespace = "http://localhost:8888/")]
    public interface IGreetingService
    {
        [OperationContract]
        string GetAsciiGreeting(string name);

        [OperationContract]
        string SayHola();
    }
}
