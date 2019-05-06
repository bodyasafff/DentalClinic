using System.ServiceModel;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void CountClient();
    }
}
