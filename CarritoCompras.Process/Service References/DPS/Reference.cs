﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarritoCompras.Process.DPS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetallePedidoEntidad", Namespace="http://schemas.datacontract.org/2004/07/CarritoCompras.Entidad")]
    [System.SerializableAttribute()]
    public partial class DetallePedidoEntidad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Cod_DetallePedidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Cod_PedidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CarritoCompras.Process.DPS.ProductoEntidad ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SubTotalField;
        
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
        public int Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cod_DetallePedido {
            get {
                return this.Cod_DetallePedidoField;
            }
            set {
                if ((this.Cod_DetallePedidoField.Equals(value) != true)) {
                    this.Cod_DetallePedidoField = value;
                    this.RaisePropertyChanged("Cod_DetallePedido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cod_Pedido {
            get {
                return this.Cod_PedidoField;
            }
            set {
                if ((this.Cod_PedidoField.Equals(value) != true)) {
                    this.Cod_PedidoField = value;
                    this.RaisePropertyChanged("Cod_Pedido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarritoCompras.Process.DPS.ProductoEntidad Producto {
            get {
                return this.ProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductoField, value) != true)) {
                    this.ProductoField = value;
                    this.RaisePropertyChanged("Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SubTotal {
            get {
                return this.SubTotalField;
            }
            set {
                if ((this.SubTotalField.Equals(value) != true)) {
                    this.SubTotalField = value;
                    this.RaisePropertyChanged("SubTotal");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductoEntidad", Namespace="http://schemas.datacontract.org/2004/07/CarritoCompras.Entidad")]
    [System.SerializableAttribute()]
    public partial class ProductoEntidad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CarritoCompras.Process.DPS.CategoriaEntidad CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Cod_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nom_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CarritoCompras.Process.DPS.UnidadMedidaEntidad UnidadMedidaField;
        
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
        public int Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarritoCompras.Process.DPS.CategoriaEntidad Categoria {
            get {
                return this.CategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriaField, value) != true)) {
                    this.CategoriaField = value;
                    this.RaisePropertyChanged("Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cod_Producto {
            get {
                return this.Cod_ProductoField;
            }
            set {
                if ((this.Cod_ProductoField.Equals(value) != true)) {
                    this.Cod_ProductoField = value;
                    this.RaisePropertyChanged("Cod_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Foto {
            get {
                return this.FotoField;
            }
            set {
                if ((object.ReferenceEquals(this.FotoField, value) != true)) {
                    this.FotoField = value;
                    this.RaisePropertyChanged("Foto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_Producto {
            get {
                return this.Nom_ProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.Nom_ProductoField, value) != true)) {
                    this.Nom_ProductoField = value;
                    this.RaisePropertyChanged("Nom_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarritoCompras.Process.DPS.UnidadMedidaEntidad UnidadMedida {
            get {
                return this.UnidadMedidaField;
            }
            set {
                if ((object.ReferenceEquals(this.UnidadMedidaField, value) != true)) {
                    this.UnidadMedidaField = value;
                    this.RaisePropertyChanged("UnidadMedida");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoriaEntidad", Namespace="http://schemas.datacontract.org/2004/07/CarritoCompras.Entidad")]
    [System.SerializableAttribute()]
    public partial class CategoriaEntidad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Cod_CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nom_CategoriaField;
        
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
        public int Cod_Categoria {
            get {
                return this.Cod_CategoriaField;
            }
            set {
                if ((this.Cod_CategoriaField.Equals(value) != true)) {
                    this.Cod_CategoriaField = value;
                    this.RaisePropertyChanged("Cod_Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_Categoria {
            get {
                return this.Nom_CategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.Nom_CategoriaField, value) != true)) {
                    this.Nom_CategoriaField = value;
                    this.RaisePropertyChanged("Nom_Categoria");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UnidadMedidaEntidad", Namespace="http://schemas.datacontract.org/2004/07/CarritoCompras.Entidad")]
    [System.SerializableAttribute()]
    public partial class UnidadMedidaEntidad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Cod_UnidadMedidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nom_UnidadMedidaField;
        
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
        public int Cod_UnidadMedida {
            get {
                return this.Cod_UnidadMedidaField;
            }
            set {
                if ((this.Cod_UnidadMedidaField.Equals(value) != true)) {
                    this.Cod_UnidadMedidaField = value;
                    this.RaisePropertyChanged("Cod_UnidadMedida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_UnidadMedida {
            get {
                return this.Nom_UnidadMedidaField;
            }
            set {
                if ((object.ReferenceEquals(this.Nom_UnidadMedidaField, value) != true)) {
                    this.Nom_UnidadMedidaField = value;
                    this.RaisePropertyChanged("Nom_UnidadMedida");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DPS.IDetallePedidoService")]
    public interface IDetallePedidoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedidoService/BuscarDetallePedido", ReplyAction="http://tempuri.org/IDetallePedidoService/BuscarDetallePedidoResponse")]
        System.Collections.Generic.List<CarritoCompras.Process.DPS.DetallePedidoEntidad> BuscarDetallePedido();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedidoService/BuscarDetallePedido", ReplyAction="http://tempuri.org/IDetallePedidoService/BuscarDetallePedidoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CarritoCompras.Process.DPS.DetallePedidoEntidad>> BuscarDetallePedidoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDetallePedidoServiceChannel : CarritoCompras.Process.DPS.IDetallePedidoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DetallePedidoServiceClient : System.ServiceModel.ClientBase<CarritoCompras.Process.DPS.IDetallePedidoService>, CarritoCompras.Process.DPS.IDetallePedidoService {
        
        public DetallePedidoServiceClient() {
        }
        
        public DetallePedidoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DetallePedidoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DetallePedidoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DetallePedidoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<CarritoCompras.Process.DPS.DetallePedidoEntidad> BuscarDetallePedido() {
            return base.Channel.BuscarDetallePedido();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CarritoCompras.Process.DPS.DetallePedidoEntidad>> BuscarDetallePedidoAsync() {
            return base.Channel.BuscarDetallePedidoAsync();
        }
    }
}
