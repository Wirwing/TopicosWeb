﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentWebApp.GetCarsServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://j2ee.netbeans.org/wsdl/CarRentalBPEL/src/GetCarsWSDL", ConfigurationName="GetCarsServiceReference.GetCarsWSDLPortType")]
    public interface GetCarsWSDLPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CarRentWebApp.GetCarsServiceReference.output1 GetCarsWSDLOperation(CarRentWebApp.GetCarsServiceReference.input1 request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<CarRentWebApp.GetCarsServiceReference.output1> GetCarsWSDLOperationAsync(CarRentWebApp.GetCarsServiceReference.input1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WS.BechCarRental/")]
    public partial class car : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string brandField;
        
        private int idField;
        
        private bool isAvailableField;
        
        private int numberBaggageField;
        
        private int numberPeopleField;
        
        private double pricePerDayField;
        
        private string transmissionField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string brand {
            get {
                return this.brandField;
            }
            set {
                this.brandField = value;
                this.RaisePropertyChanged("brand");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool isAvailable {
            get {
                return this.isAvailableField;
            }
            set {
                this.isAvailableField = value;
                this.RaisePropertyChanged("isAvailable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int numberBaggage {
            get {
                return this.numberBaggageField;
            }
            set {
                this.numberBaggageField = value;
                this.RaisePropertyChanged("numberBaggage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int numberPeople {
            get {
                return this.numberPeopleField;
            }
            set {
                this.numberPeopleField = value;
                this.RaisePropertyChanged("numberPeople");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public double pricePerDay {
            get {
                return this.pricePerDayField;
            }
            set {
                this.pricePerDayField = value;
                this.RaisePropertyChanged("pricePerDay");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string transmission {
            get {
                return this.transmissionField;
            }
            set {
                this.transmissionField = value;
                this.RaisePropertyChanged("transmission");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="car", Namespace="http://WS.KutzCarRental/")]
    public partial class car1 : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string brandField;
        
        private int idField;
        
        private bool isAvailableField;
        
        private int numberBaggageField;
        
        private int numberPeopleField;
        
        private double pricePerDayField;
        
        private string transmissionField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string brand {
            get {
                return this.brandField;
            }
            set {
                this.brandField = value;
                this.RaisePropertyChanged("brand");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool isAvailable {
            get {
                return this.isAvailableField;
            }
            set {
                this.isAvailableField = value;
                this.RaisePropertyChanged("isAvailable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int numberBaggage {
            get {
                return this.numberBaggageField;
            }
            set {
                this.numberBaggageField = value;
                this.RaisePropertyChanged("numberBaggage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int numberPeople {
            get {
                return this.numberPeopleField;
            }
            set {
                this.numberPeopleField = value;
                this.RaisePropertyChanged("numberPeople");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public double pricePerDay {
            get {
                return this.pricePerDayField;
            }
            set {
                this.pricePerDayField = value;
                this.RaisePropertyChanged("pricePerDay");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string transmission {
            get {
                return this.transmissionField;
            }
            set {
                this.transmissionField = value;
                this.RaisePropertyChanged("transmission");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCarsWSDLOperation", WrapperNamespace="http://j2ee.netbeans.org/wsdl/CarRentalBPEL/src/GetCarsWSDL", IsWrapped=true)]
    public partial class input1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string dunno;
        
        public input1() {
        }
        
        public input1(string dunno) {
            this.dunno = dunno;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCarsWSDLOperationResponse", WrapperNamespace="http://j2ee.netbeans.org/wsdl/CarRentalBPEL/src/GetCarsWSDL", IsWrapped=true)]
    public partial class output1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public CarRentWebApp.GetCarsServiceReference.car[] bech;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public CarRentWebApp.GetCarsServiceReference.car1[] kutz;
        
        public output1() {
        }
        
        public output1(CarRentWebApp.GetCarsServiceReference.car[] bech, CarRentWebApp.GetCarsServiceReference.car1[] kutz) {
            this.bech = bech;
            this.kutz = kutz;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GetCarsWSDLPortTypeChannel : CarRentWebApp.GetCarsServiceReference.GetCarsWSDLPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCarsWSDLPortTypeClient : System.ServiceModel.ClientBase<CarRentWebApp.GetCarsServiceReference.GetCarsWSDLPortType>, CarRentWebApp.GetCarsServiceReference.GetCarsWSDLPortType {
        
        public GetCarsWSDLPortTypeClient() {
        }
        
        public GetCarsWSDLPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetCarsWSDLPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetCarsWSDLPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetCarsWSDLPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CarRentWebApp.GetCarsServiceReference.output1 CarRentWebApp.GetCarsServiceReference.GetCarsWSDLPortType.GetCarsWSDLOperation(CarRentWebApp.GetCarsServiceReference.input1 request) {
            return base.Channel.GetCarsWSDLOperation(request);
        }
        
        public CarRentWebApp.GetCarsServiceReference.car[] GetCarsWSDLOperation(string dunno, out CarRentWebApp.GetCarsServiceReference.car1[] kutz) {
            CarRentWebApp.GetCarsServiceReference.input1 inValue = new CarRentWebApp.GetCarsServiceReference.input1();
            inValue.dunno = dunno;
            CarRentWebApp.GetCarsServiceReference.output1 retVal = ((CarRentWebApp.GetCarsServiceReference.GetCarsWSDLPortType)(this)).GetCarsWSDLOperation(inValue);
            kutz = retVal.kutz;
            return retVal.bech;
        }
        
        public System.Threading.Tasks.Task<CarRentWebApp.GetCarsServiceReference.output1> GetCarsWSDLOperationAsync(CarRentWebApp.GetCarsServiceReference.input1 request) {
            return base.Channel.GetCarsWSDLOperationAsync(request);
        }
    }
}
