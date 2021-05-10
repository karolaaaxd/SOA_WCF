using System;
using System.ServiceModel;



namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.Title = "CLIENT";

           
            Uri address = new Uri("http://localhost:4000/IContract"); 
          

            BasicHttpBinding binding = new BasicHttpBinding();         

            
            EndpointAddress endpoint = new EndpointAddress(address);

            
            ChannelFactory<IContract> factory = new ChannelFactory<IContract>(binding, endpoint);  

            
            IContract channel = factory.CreateChannel();

            
            channel.Say("Hello wcf informatyka!");

            
            Console.ReadKey();
        }
    }
}
