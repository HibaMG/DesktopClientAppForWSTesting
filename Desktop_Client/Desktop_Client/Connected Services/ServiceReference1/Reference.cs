﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desktop_Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PayUserBills", ReplyAction="http://tempuri.org/IService1/PayUserBillsResponse")]
        bool PayUserBills(string userIdentityNumber, string userBankAccount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PayUserBills", ReplyAction="http://tempuri.org/IService1/PayUserBillsResponse")]
        System.Threading.Tasks.Task<bool> PayUserBillsAsync(string userIdentityNumber, string userBankAccount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Desktop_Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Desktop_Client.ServiceReference1.IService1>, Desktop_Client.ServiceReference1.IService1 {
        
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
        
        public bool PayUserBills(string userIdentityNumber, string userBankAccount) {
            return base.Channel.PayUserBills(userIdentityNumber, userBankAccount);
        }
        
        public System.Threading.Tasks.Task<bool> PayUserBillsAsync(string userIdentityNumber, string userBankAccount) {
            return base.Channel.PayUserBillsAsync(userIdentityNumber, userBankAccount);
        }
    }
}
