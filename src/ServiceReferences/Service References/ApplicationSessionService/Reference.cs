﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferences.ApplicationSessionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientApplication", Namespace="http://schemas.datacontract.org/2004/07/CGeers.Wcf.Server.ApplicationSessionServi" +
        "ceLibrary")]
    [System.SerializableAttribute()]
    public partial class ClientApplication : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PetNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PetName {
            get {
                return this.PetNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PetNameField, value) != true)) {
                    this.PetNameField = value;
                    this.RaisePropertyChanged("PetName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageUrgency", Namespace="http://schemas.datacontract.org/2004/07/CGeers.Wcf.Server.ApplicationSessionServi" +
        "ceLibrary")]
    public enum MessageUrgency : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Low = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Guarded = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Elevated = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        High = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Severe = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="cgeers.wordpress.com", ConfigurationName="ApplicationSessionService.IApplicationSession", CallbackContract=typeof(ServiceReferences.ApplicationSessionService.IApplicationSessionCallback))]
    public interface IApplicationSession {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="cgeers.wordpress.com/IApplicationSession/RegisterApplication")]
        void RegisterApplication(System.Guid applicationId, string petName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="cgeers.wordpress.com/IApplicationSession/UnregisterApplication")]
        void UnregisterApplication(System.Guid applicationId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="cgeers.wordpress.com/IApplicationSession/RegisterWindow")]
        void RegisterWindow(System.Guid windowId, System.Guid applicationId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="cgeers.wordpress.com/IApplicationSession/UnregisterWindow")]
        void UnregisterWindow(System.Guid windowId);
        
        [System.ServiceModel.OperationContractAttribute(Action="cgeers.wordpress.com/IApplicationSession/RegisteredClients", ReplyAction="cgeers.wordpress.com/IApplicationSession/RegisteredClientsResponse")]
        ServiceReferences.ApplicationSessionService.ClientApplication[] RegisteredClients();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="cgeers.wordpress.com/IApplicationSession/MulticastMessage")]
        void MulticastMessage(System.Guid applicationId, ServiceReferences.ApplicationSessionService.MessageUrgency urgency, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IApplicationSessionCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="cgeers.wordpress.com/IApplicationSession/MessageReceived")]
        void MessageReceived(ServiceReferences.ApplicationSessionService.MessageUrgency urgency, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IApplicationSessionChannel : ServiceReferences.ApplicationSessionService.IApplicationSession, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ApplicationSessionClient : System.ServiceModel.DuplexClientBase<ServiceReferences.ApplicationSessionService.IApplicationSession>, ServiceReferences.ApplicationSessionService.IApplicationSession {
        
        public ApplicationSessionClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ApplicationSessionClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ApplicationSessionClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationSessionClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationSessionClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void RegisterApplication(System.Guid applicationId, string petName) {
            base.Channel.RegisterApplication(applicationId, petName);
        }
        
        public void UnregisterApplication(System.Guid applicationId) {
            base.Channel.UnregisterApplication(applicationId);
        }
        
        public void RegisterWindow(System.Guid windowId, System.Guid applicationId) {
            base.Channel.RegisterWindow(windowId, applicationId);
        }
        
        public void UnregisterWindow(System.Guid windowId) {
            base.Channel.UnregisterWindow(windowId);
        }
        
        public ServiceReferences.ApplicationSessionService.ClientApplication[] RegisteredClients() {
            return base.Channel.RegisteredClients();
        }
        
        public void MulticastMessage(System.Guid applicationId, ServiceReferences.ApplicationSessionService.MessageUrgency urgency, string message) {
            base.Channel.MulticastMessage(applicationId, urgency, message);
        }
    }
}
