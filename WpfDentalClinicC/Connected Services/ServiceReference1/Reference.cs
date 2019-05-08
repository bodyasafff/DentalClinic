﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfDentalClinicC.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CountClient", ReplyAction="http://tempuri.org/IService1/CountClientResponse")]
        int CountClient();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddClient", ReplyAction="http://tempuri.org/IService1/AddClientResponse")]
        bool AddClient(WcfService1.Models.Client c, string city, string street, string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllClients", ReplyAction="http://tempuri.org/IService1/GetAllClientsResponse")]
        WcfService1.Models.Client[] GetAllClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAdresses", ReplyAction="http://tempuri.org/IService1/GetAllAdressesResponse")]
        WcfService1.Models.Adress[] GetAllAdresses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAdress", ReplyAction="http://tempuri.org/IService1/AddAdressResponse")]
        void AddAdress(WcfService1.Models.Adress a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCity", ReplyAction="http://tempuri.org/IService1/AddCityResponse")]
        void AddCity(WcfService1.Models.City c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCityes", ReplyAction="http://tempuri.org/IService1/GetAllCityesResponse")]
        WcfService1.Models.City[] GetAllCityes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LogIn", ReplyAction="http://tempuri.org/IService1/LogInResponse")]
        bool LogIn([System.ServiceModel.MessageParameterAttribute(Name="login")] string login1, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChakLoginAddNewClient", ReplyAction="http://tempuri.org/IService1/ChakLoginAddNewClientResponse")]
        bool ChakLoginAddNewClient(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClient", ReplyAction="http://tempuri.org/IService1/GetClientResponse")]
        WcfService1.Models.Client GetClient(string login, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfDentalClinicC.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfDentalClinicC.ServiceReference1.IService1>, WpfDentalClinicC.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CountClient() {
            return base.Channel.CountClient();
        }
        
        public bool AddClient(WcfService1.Models.Client c, string city, string street, string country) {
            return base.Channel.AddClient(c, city, street, country);
        }
        
        public WcfService1.Models.Client[] GetAllClients() {
            return base.Channel.GetAllClients();
        }
        
        public WcfService1.Models.Adress[] GetAllAdresses() {
            return base.Channel.GetAllAdresses();
        }
        
        public void AddAdress(WcfService1.Models.Adress a) {
            base.Channel.AddAdress(a);
        }
        
        public void AddCity(WcfService1.Models.City c) {
            base.Channel.AddCity(c);
        }
        
        public WcfService1.Models.City[] GetAllCityes() {
            return base.Channel.GetAllCityes();
        }
        
        public bool LogIn(string login1, string password) {
            return base.Channel.LogIn(login1, password);
        }
        
        public bool ChakLoginAddNewClient(string login) {
            return base.Channel.ChakLoginAddNewClient(login);
        }
        
        public WcfService1.Models.Client GetClient(string login, string password) {
            return base.Channel.GetClient(login, password);
        }
    }
}
