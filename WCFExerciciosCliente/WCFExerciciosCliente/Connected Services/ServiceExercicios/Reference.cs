﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFExerciciosCliente.ServiceExercicios {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Exercicio", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Exercicio : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idExercicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string observacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string repeticoesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipoField;
        
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
        public int idExercicio {
            get {
                return this.idExercicioField;
            }
            set {
                if ((this.idExercicioField.Equals(value) != true)) {
                    this.idExercicioField = value;
                    this.RaisePropertyChanged("idExercicio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string observacao {
            get {
                return this.observacaoField;
            }
            set {
                if ((object.ReferenceEquals(this.observacaoField, value) != true)) {
                    this.observacaoField = value;
                    this.RaisePropertyChanged("observacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string repeticoes {
            get {
                return this.repeticoesField;
            }
            set {
                if ((object.ReferenceEquals(this.repeticoesField, value) != true)) {
                    this.repeticoesField = value;
                    this.RaisePropertyChanged("repeticoes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tipo {
            get {
                return this.tipoField;
            }
            set {
                if ((object.ReferenceEquals(this.tipoField, value) != true)) {
                    this.tipoField = value;
                    this.RaisePropertyChanged("tipo");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceExercicios.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectExercicios", ReplyAction="http://tempuri.org/IService/SelectExerciciosResponse")]
        WCFExerciciosCliente.ServiceExercicios.Exercicio[] SelectExercicios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectExercicios", ReplyAction="http://tempuri.org/IService/SelectExerciciosResponse")]
        System.Threading.Tasks.Task<WCFExerciciosCliente.ServiceExercicios.Exercicio[]> SelectExerciciosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertExercicios", ReplyAction="http://tempuri.org/IService/InsertExerciciosResponse")]
        void InsertExercicios(WCFExerciciosCliente.ServiceExercicios.Exercicio exercicio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertExercicios", ReplyAction="http://tempuri.org/IService/InsertExerciciosResponse")]
        System.Threading.Tasks.Task InsertExerciciosAsync(WCFExerciciosCliente.ServiceExercicios.Exercicio exercicio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateExercicios", ReplyAction="http://tempuri.org/IService/UpdateExerciciosResponse")]
        void UpdateExercicios(WCFExerciciosCliente.ServiceExercicios.Exercicio exercicio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateExercicios", ReplyAction="http://tempuri.org/IService/UpdateExerciciosResponse")]
        System.Threading.Tasks.Task UpdateExerciciosAsync(WCFExerciciosCliente.ServiceExercicios.Exercicio exercicio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteExercicios", ReplyAction="http://tempuri.org/IService/DeleteExerciciosResponse")]
        void DeleteExercicios(int idExercicio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteExercicios", ReplyAction="http://tempuri.org/IService/DeleteExerciciosResponse")]
        System.Threading.Tasks.Task DeleteExerciciosAsync(int idExercicio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WCFExerciciosCliente.ServiceExercicios.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WCFExerciciosCliente.ServiceExercicios.IService>, WCFExerciciosCliente.ServiceExercicios.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFExerciciosCliente.ServiceExercicios.Exercicio[] SelectExercicios() {
            return base.Channel.SelectExercicios();
        }
        
        public System.Threading.Tasks.Task<WCFExerciciosCliente.ServiceExercicios.Exercicio[]> SelectExerciciosAsync() {
            return base.Channel.SelectExerciciosAsync();
        }
        
        public void InsertExercicios(WCFExerciciosCliente.ServiceExercicios.Exercicio exercicio) {
            base.Channel.InsertExercicios(exercicio);
        }
        
        public System.Threading.Tasks.Task InsertExerciciosAsync(WCFExerciciosCliente.ServiceExercicios.Exercicio exercicio) {
            return base.Channel.InsertExerciciosAsync(exercicio);
        }
        
        public void UpdateExercicios(WCFExerciciosCliente.ServiceExercicios.Exercicio exercicio) {
            base.Channel.UpdateExercicios(exercicio);
        }
        
        public System.Threading.Tasks.Task UpdateExerciciosAsync(WCFExerciciosCliente.ServiceExercicios.Exercicio exercicio) {
            return base.Channel.UpdateExerciciosAsync(exercicio);
        }
        
        public void DeleteExercicios(int idExercicio) {
            base.Channel.DeleteExercicios(idExercicio);
        }
        
        public System.Threading.Tasks.Task DeleteExerciciosAsync(int idExercicio) {
            return base.Channel.DeleteExerciciosAsync(idExercicio);
        }
    }
}