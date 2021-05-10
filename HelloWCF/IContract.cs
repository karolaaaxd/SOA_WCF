using System.ServiceModel;


namespace HelloWCF
{    
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        void Say(string input);
    }
}


