﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationExportExcel.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name firstname from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebApplicationExportExcel.ServiceReference1.HelloWorldResponse HelloWorld(WebApplicationExportExcel.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplicationExportExcel.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WebApplicationExportExcel.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name operation from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Calculator", ReplyAction="*")]
        WebApplicationExportExcel.ServiceReference1.CalculatorResponse Calculator(WebApplicationExportExcel.ServiceReference1.CalculatorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Calculator", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplicationExportExcel.ServiceReference1.CalculatorResponse> CalculatorAsync(WebApplicationExportExcel.ServiceReference1.CalculatorRequest request);
        
        // CODEGEN: Generating message contract since element name gender from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Products", ReplyAction="*")]
        WebApplicationExportExcel.ServiceReference1.ProductsResponse Products(WebApplicationExportExcel.ServiceReference1.ProductsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Products", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplicationExportExcel.ServiceReference1.ProductsResponse> ProductsAsync(WebApplicationExportExcel.ServiceReference1.ProductsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationExportExcel.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebApplicationExportExcel.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string firstname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string lastname;
        
        public HelloWorldRequestBody() {
        }
        
        public HelloWorldRequestBody(string firstname, string lastname) {
            this.firstname = firstname;
            this.lastname = lastname;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationExportExcel.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebApplicationExportExcel.ServiceReference1.HelloWorldResponseBody Body) {
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
    public partial class CalculatorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Calculator", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationExportExcel.ServiceReference1.CalculatorRequestBody Body;
        
        public CalculatorRequest() {
        }
        
        public CalculatorRequest(WebApplicationExportExcel.ServiceReference1.CalculatorRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculatorRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int firstvalue;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int secondvalue;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string operation;
        
        public CalculatorRequestBody() {
        }
        
        public CalculatorRequestBody(int firstvalue, int secondvalue, string operation) {
            this.firstvalue = firstvalue;
            this.secondvalue = secondvalue;
            this.operation = operation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculatorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculatorResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationExportExcel.ServiceReference1.CalculatorResponseBody Body;
        
        public CalculatorResponse() {
        }
        
        public CalculatorResponse(WebApplicationExportExcel.ServiceReference1.CalculatorResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculatorResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CalculatorResult;
        
        public CalculatorResponseBody() {
        }
        
        public CalculatorResponseBody(string CalculatorResult) {
            this.CalculatorResult = CalculatorResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ProductsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Products", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationExportExcel.ServiceReference1.ProductsRequestBody Body;
        
        public ProductsRequest() {
        }
        
        public ProductsRequest(WebApplicationExportExcel.ServiceReference1.ProductsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string gender;
        
        public ProductsRequestBody() {
        }
        
        public ProductsRequestBody(string gender) {
            this.gender = gender;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ProductsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ProductsResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationExportExcel.ServiceReference1.ProductsResponseBody Body;
        
        public ProductsResponse() {
        }
        
        public ProductsResponse(WebApplicationExportExcel.ServiceReference1.ProductsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApplicationExportExcel.ServiceReference1.Product[] ProductsResult;
        
        public ProductsResponseBody() {
        }
        
        public ProductsResponseBody(WebApplicationExportExcel.ServiceReference1.Product[] ProductsResult) {
            this.ProductsResult = ProductsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebApplicationExportExcel.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebApplicationExportExcel.ServiceReference1.WebService1Soap>, WebApplicationExportExcel.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplicationExportExcel.ServiceReference1.HelloWorldResponse WebApplicationExportExcel.ServiceReference1.WebService1Soap.HelloWorld(WebApplicationExportExcel.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld(string firstname, string lastname) {
            WebApplicationExportExcel.ServiceReference1.HelloWorldRequest inValue = new WebApplicationExportExcel.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplicationExportExcel.ServiceReference1.HelloWorldRequestBody();
            inValue.Body.firstname = firstname;
            inValue.Body.lastname = lastname;
            WebApplicationExportExcel.ServiceReference1.HelloWorldResponse retVal = ((WebApplicationExportExcel.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplicationExportExcel.ServiceReference1.HelloWorldResponse> WebApplicationExportExcel.ServiceReference1.WebService1Soap.HelloWorldAsync(WebApplicationExportExcel.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplicationExportExcel.ServiceReference1.HelloWorldResponse> HelloWorldAsync(string firstname, string lastname) {
            WebApplicationExportExcel.ServiceReference1.HelloWorldRequest inValue = new WebApplicationExportExcel.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplicationExportExcel.ServiceReference1.HelloWorldRequestBody();
            inValue.Body.firstname = firstname;
            inValue.Body.lastname = lastname;
            return ((WebApplicationExportExcel.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplicationExportExcel.ServiceReference1.CalculatorResponse WebApplicationExportExcel.ServiceReference1.WebService1Soap.Calculator(WebApplicationExportExcel.ServiceReference1.CalculatorRequest request) {
            return base.Channel.Calculator(request);
        }
        
        public string Calculator(int firstvalue, int secondvalue, string operation) {
            WebApplicationExportExcel.ServiceReference1.CalculatorRequest inValue = new WebApplicationExportExcel.ServiceReference1.CalculatorRequest();
            inValue.Body = new WebApplicationExportExcel.ServiceReference1.CalculatorRequestBody();
            inValue.Body.firstvalue = firstvalue;
            inValue.Body.secondvalue = secondvalue;
            inValue.Body.operation = operation;
            WebApplicationExportExcel.ServiceReference1.CalculatorResponse retVal = ((WebApplicationExportExcel.ServiceReference1.WebService1Soap)(this)).Calculator(inValue);
            return retVal.Body.CalculatorResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplicationExportExcel.ServiceReference1.CalculatorResponse> WebApplicationExportExcel.ServiceReference1.WebService1Soap.CalculatorAsync(WebApplicationExportExcel.ServiceReference1.CalculatorRequest request) {
            return base.Channel.CalculatorAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplicationExportExcel.ServiceReference1.CalculatorResponse> CalculatorAsync(int firstvalue, int secondvalue, string operation) {
            WebApplicationExportExcel.ServiceReference1.CalculatorRequest inValue = new WebApplicationExportExcel.ServiceReference1.CalculatorRequest();
            inValue.Body = new WebApplicationExportExcel.ServiceReference1.CalculatorRequestBody();
            inValue.Body.firstvalue = firstvalue;
            inValue.Body.secondvalue = secondvalue;
            inValue.Body.operation = operation;
            return ((WebApplicationExportExcel.ServiceReference1.WebService1Soap)(this)).CalculatorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplicationExportExcel.ServiceReference1.ProductsResponse WebApplicationExportExcel.ServiceReference1.WebService1Soap.Products(WebApplicationExportExcel.ServiceReference1.ProductsRequest request) {
            return base.Channel.Products(request);
        }
        
        public WebApplicationExportExcel.ServiceReference1.Product[] Products(string gender) {
            WebApplicationExportExcel.ServiceReference1.ProductsRequest inValue = new WebApplicationExportExcel.ServiceReference1.ProductsRequest();
            inValue.Body = new WebApplicationExportExcel.ServiceReference1.ProductsRequestBody();
            inValue.Body.gender = gender;
            WebApplicationExportExcel.ServiceReference1.ProductsResponse retVal = ((WebApplicationExportExcel.ServiceReference1.WebService1Soap)(this)).Products(inValue);
            return retVal.Body.ProductsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplicationExportExcel.ServiceReference1.ProductsResponse> WebApplicationExportExcel.ServiceReference1.WebService1Soap.ProductsAsync(WebApplicationExportExcel.ServiceReference1.ProductsRequest request) {
            return base.Channel.ProductsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplicationExportExcel.ServiceReference1.ProductsResponse> ProductsAsync(string gender) {
            WebApplicationExportExcel.ServiceReference1.ProductsRequest inValue = new WebApplicationExportExcel.ServiceReference1.ProductsRequest();
            inValue.Body = new WebApplicationExportExcel.ServiceReference1.ProductsRequestBody();
            inValue.Body.gender = gender;
            return ((WebApplicationExportExcel.ServiceReference1.WebService1Soap)(this)).ProductsAsync(inValue);
        }
    }
}
