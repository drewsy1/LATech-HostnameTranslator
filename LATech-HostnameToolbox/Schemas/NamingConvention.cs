//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Schemas {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:naming-convention")]
    [System.Xml.Serialization.XmlRootAttribute("NamingConvention", Namespace="urn:naming-convention", IsNullable=false)]
    public partial class NamingConventionType {
        
        private string nameField;
        
        private System.DateTime dateField;
        
        private OrderedFormatStringType orderedFormatStringField;
        
        private PredefinedUnitsType predefinedUnitsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime Date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OrderedFormatStringType OrderedFormatString {
            get {
                return this.orderedFormatStringField;
            }
            set {
                this.orderedFormatStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PredefinedUnitsType PredefinedUnits {
            get {
                return this.predefinedUnitsField;
            }
            set {
                this.predefinedUnitsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:naming-convention")]
    public partial class OrderedFormatStringType {
        
        private string[] stringComponentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StringComponent", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] StringComponent {
            get {
                return this.stringComponentField;
            }
            set {
                this.stringComponentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:naming-convention")]
    public partial class ItemType {
        
        private string codeField;
        
        private string definitionField;
        
        private string classificationField;
        
        private string buildingField;
        
        private string floorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Definition {
            get {
                return this.definitionField;
            }
            set {
                this.definitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Classification {
            get {
                return this.classificationField;
            }
            set {
                this.classificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Building {
            get {
                return this.buildingField;
            }
            set {
                this.buildingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Floor {
            get {
                return this.floorField;
            }
            set {
                this.floorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:naming-convention")]
    public partial class PredefinedUnitsType {
        
        private PredefinedUnitsTypePredefinedUnit[] predefinedUnitField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PredefinedUnit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PredefinedUnitsTypePredefinedUnit[] PredefinedUnit {
            get {
                return this.predefinedUnitField;
            }
            set {
                this.predefinedUnitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:naming-convention")]
    public partial class PredefinedUnitsTypePredefinedUnit {
        
        private PredefinedUnitsTypePredefinedUnitItem[] itemField;
        
        private string nameField;
        
        private string classificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PredefinedUnitsTypePredefinedUnitItem[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Classification {
            get {
                return this.classificationField;
            }
            set {
                this.classificationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:naming-convention")]
    public partial class PredefinedUnitsTypePredefinedUnitItem : ItemType {
    }
}
