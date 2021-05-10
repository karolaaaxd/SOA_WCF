using System;
using System.ServiceModel;



namespace HelloWCF
{      
    class Server
    {        
        static void Main()
        {
            Console.Title = "SERVER";

            
            Uri address = new Uri("http://localhost:4000/IContract"); 

            BasicHttpBinding binding = new BasicHttpBinding();        

        
            Type contract = typeof(IContract);                       

          
            ServiceHost host = new ServiceHost(typeof(Service));

    
            host.AddServiceEndpoint(contract, binding, address);

           
            host.Open();


            Console.WriteLine("Aplikacja jest gotowa do odbierania wiadomości.");
            Console.ReadKey();


            host.Close();
        }
    }
}
