﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineHotelManagementSystemWebApplication.BookNowServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookNowServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BookNow", ReplyAction="http://tempuri.org/IService1/BookNowResponse")]
        int BookNow(EntityLayers.Booking _bObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BookNowDDLWCF", ReplyAction="http://tempuri.org/IService1/BookNowDDLWCFResponse")]
        EntityLayers.RoomType[] BookNowDDLWCF();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : OnlineHotelManagementSystemWebApplication.BookNowServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<OnlineHotelManagementSystemWebApplication.BookNowServiceReference.IService1>, OnlineHotelManagementSystemWebApplication.BookNowServiceReference.IService1 {
        
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
        
        public int BookNow(EntityLayers.Booking _bObj) {
            return base.Channel.BookNow(_bObj);
        }
        
        public EntityLayers.RoomType[] BookNowDDLWCF() {
            return base.Channel.BookNowDDLWCF();
        }
    }
}
