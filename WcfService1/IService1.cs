using System.ServiceModel;
using WcfService1.Models;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int CountClient();
        [OperationContract]
        bool AddClient(Client c);
        [OperationContract]
        Client[] GetAllClients();
        [OperationContract]
        Adress[] GetAllAdresses();
        [OperationContract]
        void AddAdress(Adress a);
        [OperationContract]
        void AddCity(City c);
        [OperationContract]
        City[] GetAllCityes();
    }
}
