﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleEF.MyServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Kategori", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Kategori : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int id_katField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nama_katField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id_kat {
            get {
                return this.id_katField;
            }
            set {
                if ((this.id_katField.Equals(value) != true)) {
                    this.id_katField = value;
                    this.RaisePropertyChanged("id_kat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nama_kat {
            get {
                return this.nama_katField;
            }
            set {
                if ((object.ReferenceEquals(this.nama_katField, value) != true)) {
                    this.nama_katField = value;
                    this.RaisePropertyChanged("nama_kat");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServices.SampleSOAPSoap")]
    public interface SampleSOAPSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        SampleEF.MyServices.HelloWorldResponse HelloWorld(SampleEF.MyServices.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<SampleEF.MyServices.HelloWorldResponse> HelloWorldAsync(SampleEF.MyServices.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        SampleEF.MyServices.GetAllResponse GetAll(SampleEF.MyServices.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<SampleEF.MyServices.GetAllResponse> GetAllAsync(SampleEF.MyServices.GetAllRequest request);
        
        // CODEGEN: Generating message contract since element name nama_kat from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        SampleEF.MyServices.InsertResponse Insert(SampleEF.MyServices.InsertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<SampleEF.MyServices.InsertResponse> InsertAsync(SampleEF.MyServices.InsertRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public SampleEF.MyServices.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(SampleEF.MyServices.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public SampleEF.MyServices.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(SampleEF.MyServices.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public SampleEF.MyServices.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(SampleEF.MyServices.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody {
        
        public GetAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public SampleEF.MyServices.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(SampleEF.MyServices.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public SampleEF.MyServices.Kategori[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(SampleEF.MyServices.Kategori[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert", Namespace="http://tempuri.org/", Order=0)]
        public SampleEF.MyServices.InsertRequestBody Body;
        
        public InsertRequest() {
        }
        
        public InsertRequest(SampleEF.MyServices.InsertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nama_kat;
        
        public InsertRequestBody() {
        }
        
        public InsertRequestBody(string nama_kat) {
            this.nama_kat = nama_kat;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertResponse", Namespace="http://tempuri.org/", Order=0)]
        public SampleEF.MyServices.InsertResponseBody Body;
        
        public InsertResponse() {
        }
        
        public InsertResponse(SampleEF.MyServices.InsertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class InsertResponseBody {
        
        public InsertResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SampleSOAPSoapChannel : SampleEF.MyServices.SampleSOAPSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleSOAPSoapClient : System.ServiceModel.ClientBase<SampleEF.MyServices.SampleSOAPSoap>, SampleEF.MyServices.SampleSOAPSoap {
        
        public SampleSOAPSoapClient() {
        }
        
        public SampleSOAPSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleSOAPSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleSOAPSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleSOAPSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SampleEF.MyServices.HelloWorldResponse SampleEF.MyServices.SampleSOAPSoap.HelloWorld(SampleEF.MyServices.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            SampleEF.MyServices.HelloWorldRequest inValue = new SampleEF.MyServices.HelloWorldRequest();
            inValue.Body = new SampleEF.MyServices.HelloWorldRequestBody();
            SampleEF.MyServices.HelloWorldResponse retVal = ((SampleEF.MyServices.SampleSOAPSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SampleEF.MyServices.HelloWorldResponse> SampleEF.MyServices.SampleSOAPSoap.HelloWorldAsync(SampleEF.MyServices.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<SampleEF.MyServices.HelloWorldResponse> HelloWorldAsync() {
            SampleEF.MyServices.HelloWorldRequest inValue = new SampleEF.MyServices.HelloWorldRequest();
            inValue.Body = new SampleEF.MyServices.HelloWorldRequestBody();
            return ((SampleEF.MyServices.SampleSOAPSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SampleEF.MyServices.GetAllResponse SampleEF.MyServices.SampleSOAPSoap.GetAll(SampleEF.MyServices.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public SampleEF.MyServices.Kategori[] GetAll() {
            SampleEF.MyServices.GetAllRequest inValue = new SampleEF.MyServices.GetAllRequest();
            inValue.Body = new SampleEF.MyServices.GetAllRequestBody();
            SampleEF.MyServices.GetAllResponse retVal = ((SampleEF.MyServices.SampleSOAPSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SampleEF.MyServices.GetAllResponse> SampleEF.MyServices.SampleSOAPSoap.GetAllAsync(SampleEF.MyServices.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<SampleEF.MyServices.GetAllResponse> GetAllAsync() {
            SampleEF.MyServices.GetAllRequest inValue = new SampleEF.MyServices.GetAllRequest();
            inValue.Body = new SampleEF.MyServices.GetAllRequestBody();
            return ((SampleEF.MyServices.SampleSOAPSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SampleEF.MyServices.InsertResponse SampleEF.MyServices.SampleSOAPSoap.Insert(SampleEF.MyServices.InsertRequest request) {
            return base.Channel.Insert(request);
        }
        
        public void Insert(string nama_kat) {
            SampleEF.MyServices.InsertRequest inValue = new SampleEF.MyServices.InsertRequest();
            inValue.Body = new SampleEF.MyServices.InsertRequestBody();
            inValue.Body.nama_kat = nama_kat;
            SampleEF.MyServices.InsertResponse retVal = ((SampleEF.MyServices.SampleSOAPSoap)(this)).Insert(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SampleEF.MyServices.InsertResponse> SampleEF.MyServices.SampleSOAPSoap.InsertAsync(SampleEF.MyServices.InsertRequest request) {
            return base.Channel.InsertAsync(request);
        }
        
        public System.Threading.Tasks.Task<SampleEF.MyServices.InsertResponse> InsertAsync(string nama_kat) {
            SampleEF.MyServices.InsertRequest inValue = new SampleEF.MyServices.InsertRequest();
            inValue.Body = new SampleEF.MyServices.InsertRequestBody();
            inValue.Body.nama_kat = nama_kat;
            return ((SampleEF.MyServices.SampleSOAPSoap)(this)).InsertAsync(inValue);
        }
    }
}
