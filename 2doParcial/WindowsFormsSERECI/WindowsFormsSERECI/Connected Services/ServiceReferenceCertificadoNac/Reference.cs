﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsSERECI.ServiceReferenceCertificadoNac {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Persona : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string carnetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string primer_apeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string segundo_apeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fecha_nacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estado_civilField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string carnet {
            get {
                return this.carnetField;
            }
            set {
                if ((object.ReferenceEquals(this.carnetField, value) != true)) {
                    this.carnetField = value;
                    this.RaisePropertyChanged("carnet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nombres {
            get {
                return this.nombresField;
            }
            set {
                if ((object.ReferenceEquals(this.nombresField, value) != true)) {
                    this.nombresField = value;
                    this.RaisePropertyChanged("nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string primer_ape {
            get {
                return this.primer_apeField;
            }
            set {
                if ((object.ReferenceEquals(this.primer_apeField, value) != true)) {
                    this.primer_apeField = value;
                    this.RaisePropertyChanged("primer_ape");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string segundo_ape {
            get {
                return this.segundo_apeField;
            }
            set {
                if ((object.ReferenceEquals(this.segundo_apeField, value) != true)) {
                    this.segundo_apeField = value;
                    this.RaisePropertyChanged("segundo_ape");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string fecha_nac {
            get {
                return this.fecha_nacField;
            }
            set {
                if ((object.ReferenceEquals(this.fecha_nacField, value) != true)) {
                    this.fecha_nacField = value;
                    this.RaisePropertyChanged("fecha_nac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string sexo {
            get {
                return this.sexoField;
            }
            set {
                if ((object.ReferenceEquals(this.sexoField, value) != true)) {
                    this.sexoField = value;
                    this.RaisePropertyChanged("sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string estado_civil {
            get {
                return this.estado_civilField;
            }
            set {
                if ((object.ReferenceEquals(this.estado_civilField, value) != true)) {
                    this.estado_civilField = value;
                    this.RaisePropertyChanged("estado_civil");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CertificadoNacimiento", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CertificadoNacimiento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string carnetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string primer_apeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string segundo_apeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fecha_nacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string padreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string madreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string carnet {
            get {
                return this.carnetField;
            }
            set {
                if ((object.ReferenceEquals(this.carnetField, value) != true)) {
                    this.carnetField = value;
                    this.RaisePropertyChanged("carnet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nombres {
            get {
                return this.nombresField;
            }
            set {
                if ((object.ReferenceEquals(this.nombresField, value) != true)) {
                    this.nombresField = value;
                    this.RaisePropertyChanged("nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string primer_ape {
            get {
                return this.primer_apeField;
            }
            set {
                if ((object.ReferenceEquals(this.primer_apeField, value) != true)) {
                    this.primer_apeField = value;
                    this.RaisePropertyChanged("primer_ape");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string segundo_ape {
            get {
                return this.segundo_apeField;
            }
            set {
                if ((object.ReferenceEquals(this.segundo_apeField, value) != true)) {
                    this.segundo_apeField = value;
                    this.RaisePropertyChanged("segundo_ape");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string fecha_nac {
            get {
                return this.fecha_nacField;
            }
            set {
                if ((object.ReferenceEquals(this.fecha_nacField, value) != true)) {
                    this.fecha_nacField = value;
                    this.RaisePropertyChanged("fecha_nac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string padre {
            get {
                return this.padreField;
            }
            set {
                if ((object.ReferenceEquals(this.padreField, value) != true)) {
                    this.padreField = value;
                    this.RaisePropertyChanged("padre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string madre {
            get {
                return this.madreField;
            }
            set {
                if ((object.ReferenceEquals(this.madreField, value) != true)) {
                    this.madreField = value;
                    this.RaisePropertyChanged("madre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCertificadoNac.SWSEGIPSoap")]
    public interface SWSEGIPSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento CI del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerDatos", ReplyAction="*")]
        WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosResponse ObtenerDatos(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerDatos", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosResponse> ObtenerDatosAsync(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento CI del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerCertificadoNacimiento", ReplyAction="*")]
        WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoResponse ObtenerCertificadoNacimiento(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerCertificadoNacimiento", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoResponse> ObtenerCertificadoNacimientoAsync(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerDatosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerDatos", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequestBody Body;
        
        public ObtenerDatosRequest() {
        }
        
        public ObtenerDatosRequest(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerDatosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CI;
        
        public ObtenerDatosRequestBody() {
        }
        
        public ObtenerDatosRequestBody(string CI) {
            this.CI = CI;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerDatosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerDatosResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosResponseBody Body;
        
        public ObtenerDatosResponse() {
        }
        
        public ObtenerDatosResponse(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerDatosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsSERECI.ServiceReferenceCertificadoNac.Persona ObtenerDatosResult;
        
        public ObtenerDatosResponseBody() {
        }
        
        public ObtenerDatosResponseBody(WindowsFormsSERECI.ServiceReferenceCertificadoNac.Persona ObtenerDatosResult) {
            this.ObtenerDatosResult = ObtenerDatosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerCertificadoNacimientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerCertificadoNacimiento", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequestBody Body;
        
        public ObtenerCertificadoNacimientoRequest() {
        }
        
        public ObtenerCertificadoNacimientoRequest(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerCertificadoNacimientoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CI;
        
        public ObtenerCertificadoNacimientoRequestBody() {
        }
        
        public ObtenerCertificadoNacimientoRequestBody(string CI) {
            this.CI = CI;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerCertificadoNacimientoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerCertificadoNacimientoResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoResponseBody Body;
        
        public ObtenerCertificadoNacimientoResponse() {
        }
        
        public ObtenerCertificadoNacimientoResponse(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerCertificadoNacimientoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsSERECI.ServiceReferenceCertificadoNac.CertificadoNacimiento ObtenerCertificadoNacimientoResult;
        
        public ObtenerCertificadoNacimientoResponseBody() {
        }
        
        public ObtenerCertificadoNacimientoResponseBody(WindowsFormsSERECI.ServiceReferenceCertificadoNac.CertificadoNacimiento ObtenerCertificadoNacimientoResult) {
            this.ObtenerCertificadoNacimientoResult = ObtenerCertificadoNacimientoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SWSEGIPSoapChannel : WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SWSEGIPSoapClient : System.ServiceModel.ClientBase<WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap>, WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap {
        
        public SWSEGIPSoapClient() {
        }
        
        public SWSEGIPSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SWSEGIPSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SWSEGIPSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SWSEGIPSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosResponse WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap.ObtenerDatos(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequest request) {
            return base.Channel.ObtenerDatos(request);
        }
        
        public WindowsFormsSERECI.ServiceReferenceCertificadoNac.Persona ObtenerDatos(string CI) {
            WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequest inValue = new WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequest();
            inValue.Body = new WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequestBody();
            inValue.Body.CI = CI;
            WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosResponse retVal = ((WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap)(this)).ObtenerDatos(inValue);
            return retVal.Body.ObtenerDatosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosResponse> WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap.ObtenerDatosAsync(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequest request) {
            return base.Channel.ObtenerDatosAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosResponse> ObtenerDatosAsync(string CI) {
            WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequest inValue = new WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequest();
            inValue.Body = new WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerDatosRequestBody();
            inValue.Body.CI = CI;
            return ((WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap)(this)).ObtenerDatosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoResponse WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap.ObtenerCertificadoNacimiento(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequest request) {
            return base.Channel.ObtenerCertificadoNacimiento(request);
        }
        
        public WindowsFormsSERECI.ServiceReferenceCertificadoNac.CertificadoNacimiento ObtenerCertificadoNacimiento(string CI) {
            WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequest inValue = new WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequest();
            inValue.Body = new WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequestBody();
            inValue.Body.CI = CI;
            WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoResponse retVal = ((WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap)(this)).ObtenerCertificadoNacimiento(inValue);
            return retVal.Body.ObtenerCertificadoNacimientoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoResponse> WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap.ObtenerCertificadoNacimientoAsync(WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequest request) {
            return base.Channel.ObtenerCertificadoNacimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoResponse> ObtenerCertificadoNacimientoAsync(string CI) {
            WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequest inValue = new WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequest();
            inValue.Body = new WindowsFormsSERECI.ServiceReferenceCertificadoNac.ObtenerCertificadoNacimientoRequestBody();
            inValue.Body.CI = CI;
            return ((WindowsFormsSERECI.ServiceReferenceCertificadoNac.SWSEGIPSoap)(this)).ObtenerCertificadoNacimientoAsync(inValue);
        }
    }
}
