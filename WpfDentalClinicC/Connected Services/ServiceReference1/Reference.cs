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
        bool AddClient(WcfService1.Models.Client c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllClients", ReplyAction="http://tempuri.org/IService1/GetAllClientsResponse")]
        WcfService1.Models.Client[] GetAllClients();
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
        
        public bool AddClient(WcfService1.Models.Client c) {
            return base.Channel.AddClient(c);
        }
        
        public WcfService1.Models.Client[] GetAllClients() {
            return base.Channel.GetAllClients();
        }
    }
}
