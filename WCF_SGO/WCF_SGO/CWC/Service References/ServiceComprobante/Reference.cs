﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CWC.ServiceComprobante {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="usp_LisComprobanteCliente_Result", Namespace="http://schemas.datacontract.org/2004/07/Persistence.domain")]
    [System.SerializableAttribute()]
    public partial class usp_LisComprobanteCliente_Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorrelativoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaOperacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdComprobanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdEstadoProcesoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ImporteSubtotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ImporteTotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ImpuestoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RAZONSOCIAL_PRODELSURField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RUC_PRODELSURField;
        
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
        public string Correlativo {
            get {
                return this.CorrelativoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorrelativoField, value) != true)) {
                    this.CorrelativoField = value;
                    this.RaisePropertyChanged("Correlativo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaOperacion {
            get {
                return this.FechaOperacionField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaOperacionField, value) != true)) {
                    this.FechaOperacionField = value;
                    this.RaisePropertyChanged("FechaOperacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdComprobante {
            get {
                return this.IdComprobanteField;
            }
            set {
                if ((this.IdComprobanteField.Equals(value) != true)) {
                    this.IdComprobanteField = value;
                    this.RaisePropertyChanged("IdComprobante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdEstadoProceso {
            get {
                return this.IdEstadoProcesoField;
            }
            set {
                if ((this.IdEstadoProcesoField.Equals(value) != true)) {
                    this.IdEstadoProcesoField = value;
                    this.RaisePropertyChanged("IdEstadoProceso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> ImporteSubtotal {
            get {
                return this.ImporteSubtotalField;
            }
            set {
                if ((this.ImporteSubtotalField.Equals(value) != true)) {
                    this.ImporteSubtotalField = value;
                    this.RaisePropertyChanged("ImporteSubtotal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> ImporteTotal {
            get {
                return this.ImporteTotalField;
            }
            set {
                if ((this.ImporteTotalField.Equals(value) != true)) {
                    this.ImporteTotalField = value;
                    this.RaisePropertyChanged("ImporteTotal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Impuesto {
            get {
                return this.ImpuestoField;
            }
            set {
                if ((this.ImpuestoField.Equals(value) != true)) {
                    this.ImpuestoField = value;
                    this.RaisePropertyChanged("Impuesto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RAZONSOCIAL_PRODELSUR {
            get {
                return this.RAZONSOCIAL_PRODELSURField;
            }
            set {
                if ((object.ReferenceEquals(this.RAZONSOCIAL_PRODELSURField, value) != true)) {
                    this.RAZONSOCIAL_PRODELSURField = value;
                    this.RaisePropertyChanged("RAZONSOCIAL_PRODELSUR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RUC_PRODELSUR {
            get {
                return this.RUC_PRODELSURField;
            }
            set {
                if ((object.ReferenceEquals(this.RUC_PRODELSURField, value) != true)) {
                    this.RUC_PRODELSURField = value;
                    this.RaisePropertyChanged("RUC_PRODELSUR");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceComprobante.IServiceComprobanteVenta")]
    public interface IServiceComprobanteVenta {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceComprobanteVenta/GetLisComprobanteCliente", ReplyAction="http://tempuri.org/IServiceComprobanteVenta/GetLisComprobanteClienteResponse")]
        CWC.ServiceComprobante.usp_LisComprobanteCliente_Result[] GetLisComprobanteCliente(string nroDocumentoCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceComprobanteVenta/GetLisComprobanteCliente", ReplyAction="http://tempuri.org/IServiceComprobanteVenta/GetLisComprobanteClienteResponse")]
        System.Threading.Tasks.Task<CWC.ServiceComprobante.usp_LisComprobanteCliente_Result[]> GetLisComprobanteClienteAsync(string nroDocumentoCliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceComprobanteVentaChannel : CWC.ServiceComprobante.IServiceComprobanteVenta, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceComprobanteVentaClient : System.ServiceModel.ClientBase<CWC.ServiceComprobante.IServiceComprobanteVenta>, CWC.ServiceComprobante.IServiceComprobanteVenta {
        
        public ServiceComprobanteVentaClient() {
        }
        
        public ServiceComprobanteVentaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceComprobanteVentaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceComprobanteVentaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceComprobanteVentaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CWC.ServiceComprobante.usp_LisComprobanteCliente_Result[] GetLisComprobanteCliente(string nroDocumentoCliente) {
            return base.Channel.GetLisComprobanteCliente(nroDocumentoCliente);
        }
        
        public System.Threading.Tasks.Task<CWC.ServiceComprobante.usp_LisComprobanteCliente_Result[]> GetLisComprobanteClienteAsync(string nroDocumentoCliente) {
            return base.Channel.GetLisComprobanteClienteAsync(nroDocumentoCliente);
        }
    }
}