﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI.Services.Interfaces.Services.TransactionManagerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Transaction", Namespace="http://schemas.datacontract.org/2004/07/Services.TransactionManager.External")]
    [System.SerializableAttribute()]
    public partial class Transaction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CounterpartyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecurityField;
        
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
        public string Counterparty {
            get {
                return this.CounterpartyField;
            }
            set {
                if ((object.ReferenceEquals(this.CounterpartyField, value) != true)) {
                    this.CounterpartyField = value;
                    this.RaisePropertyChanged("Counterparty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Security {
            get {
                return this.SecurityField;
            }
            set {
                if ((object.ReferenceEquals(this.SecurityField, value) != true)) {
                    this.SecurityField = value;
                    this.RaisePropertyChanged("Security");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionStatus", Namespace="http://schemas.datacontract.org/2004/07/Services.TransactionManager.External")]
    [System.SerializableAttribute()]
    public partial class TransactionStatus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UI.Services.Interfaces.Services.TransactionManagerService.Status transactionStatusField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UI.Services.Interfaces.Services.TransactionManagerService.Status transactionStatus {
            get {
                return this.transactionStatusField;
            }
            set {
                if ((this.transactionStatusField.Equals(value) != true)) {
                    this.transactionStatusField = value;
                    this.RaisePropertyChanged("transactionStatus");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://schemas.datacontract.org/2004/07/Services.TransactionManager.External")]
    public enum Status : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Failed = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Services.TransactionManagerService.ITransactionManager")]
    public interface ITransactionManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionManager/BookTrade", ReplyAction="http://tempuri.org/ITransactionManager/BookTradeResponse")]
        UI.Services.Interfaces.Services.TransactionManagerService.TransactionStatus[] BookTrade(UI.Services.Interfaces.Services.TransactionManagerService.Transaction[] transactions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransactionManager/BookTrade", ReplyAction="http://tempuri.org/ITransactionManager/BookTradeResponse")]
        System.Threading.Tasks.Task<UI.Services.Interfaces.Services.TransactionManagerService.TransactionStatus[]> BookTradeAsync(UI.Services.Interfaces.Services.TransactionManagerService.Transaction[] transactions);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITransactionManagerChannel : UI.Services.Interfaces.Services.TransactionManagerService.ITransactionManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransactionManagerClient : System.ServiceModel.ClientBase<UI.Services.Interfaces.Services.TransactionManagerService.ITransactionManager>, UI.Services.Interfaces.Services.TransactionManagerService.ITransactionManager {
        
        public TransactionManagerClient() {
        }
        
        public TransactionManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TransactionManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransactionManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransactionManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UI.Services.Interfaces.Services.TransactionManagerService.TransactionStatus[] BookTrade(UI.Services.Interfaces.Services.TransactionManagerService.Transaction[] transactions) {
            return base.Channel.BookTrade(transactions);
        }
        
        public System.Threading.Tasks.Task<UI.Services.Interfaces.Services.TransactionManagerService.TransactionStatus[]> BookTradeAsync(UI.Services.Interfaces.Services.TransactionManagerService.Transaction[] transactions) {
            return base.Channel.BookTradeAsync(transactions);
        }
    }
}
