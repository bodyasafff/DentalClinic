using System.ServiceModel;
using WcfService1.Models;
using WcfService1.ModelsToMap;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int CountClient();
        [OperationContract]
        bool AddClient(ModelClient c,string city, string street, string country);
        [OperationContract]
        bool LogIn(string login,string password);
        [OperationContract]
        bool ChakLoginAddNewClient(string login);
        [OperationContract]
        ModelClient GetClient(string login, string password);
        [OperationContract]
        void AddDiagnosis(int IdClient,string name,string description);
        [OperationContract]
        ModelClient MapClient(Client c);
      
    }
}
