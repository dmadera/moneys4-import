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
namespace S0_Seznamy {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class S5Data {
        
        private S5DataAdresniKlic[] adresniKlicListField;
        
        private S5DataDruhArtiklu[] druhArtikluListField;
        
        private S5DataFunkceOsoby[] funkceOsobyListField;
        
        private S5DataJednotka[] jednotkaListField;
        
        private S5DataProduktovyKlic[] produktovyKlicListField;
        
        private S5DataTypSpojeni[] typSpojeniListField;
        
        private S5DataZpusobPlatby[] zpusobPlatbyListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AdresniKlic", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public S5DataAdresniKlic[] AdresniKlicList {
            get {
                return this.adresniKlicListField;
            }
            set {
                this.adresniKlicListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DruhArtiklu", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public S5DataDruhArtiklu[] DruhArtikluList {
            get {
                return this.druhArtikluListField;
            }
            set {
                this.druhArtikluListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FunkceOsoby", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public S5DataFunkceOsoby[] FunkceOsobyList {
            get {
                return this.funkceOsobyListField;
            }
            set {
                this.funkceOsobyListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Jednotka", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public S5DataJednotka[] JednotkaList {
            get {
                return this.jednotkaListField;
            }
            set {
                this.jednotkaListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProduktovyKlic", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public S5DataProduktovyKlic[] ProduktovyKlicList {
            get {
                return this.produktovyKlicListField;
            }
            set {
                this.produktovyKlicListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TypSpojeni", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public S5DataTypSpojeni[] TypSpojeniList {
            get {
                return this.typSpojeniListField;
            }
            set {
                this.typSpojeniListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ZpusobPlatby", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public S5DataZpusobPlatby[] ZpusobPlatbyList {
            get {
                return this.zpusobPlatbyListField;
            }
            set {
                this.zpusobPlatbyListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataAdresniKlic {
        
        private string kodField;
        
        private string nazevField;
        
        private string poznamkaField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataAdresniKlic() {
            this.objectNameField = "AdresniKlic";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kod {
            get {
                return this.kodField;
            }
            set {
                this.kodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Nazev {
            get {
                return this.nazevField;
            }
            set {
                this.nazevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Poznamka {
            get {
                return this.poznamkaField;
            }
            set {
                this.poznamkaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enum_DruhSpojeni {
        
        private enum_DruhSpojeniEnumValueName enumValueNameField;
        
        private bool enumValueNameFieldSpecified;
        
        private enum_DruhSpojeni_value valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public enum_DruhSpojeniEnumValueName EnumValueName {
            get {
                return this.enumValueNameField;
            }
            set {
                this.enumValueNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnumValueNameSpecified {
            get {
                return this.enumValueNameFieldSpecified;
            }
            set {
                this.enumValueNameFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public enum_DruhSpojeni_value Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum enum_DruhSpojeniEnumValueName {
        
        /// <remarks/>
        Telefon,
        
        /// <remarks/>
        Fax,
        
        /// <remarks/>
        Email,
        
        /// <remarks/>
        WWW,
        
        /// <remarks/>
        DatovaSchranka,
        
        /// <remarks/>
        Ostatni,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    public enum enum_DruhSpojeni_value {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enum_TypJednotky {
        
        private enum_TypJednotkyEnumValueName enumValueNameField;
        
        private bool enumValueNameFieldSpecified;
        
        private enum_TypJednotky_value valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public enum_TypJednotkyEnumValueName EnumValueName {
            get {
                return this.enumValueNameField;
            }
            set {
                this.enumValueNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnumValueNameSpecified {
            get {
                return this.enumValueNameFieldSpecified;
            }
            set {
                this.enumValueNameFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public enum_TypJednotky_value Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum enum_TypJednotkyEnumValueName {
        
        /// <remarks/>
        Nespecifikovano,
        
        /// <remarks/>
        JednotkaCasu,
        
        /// <remarks/>
        Mena,
        
        /// <remarks/>
        FyziJednotka,
        
        /// <remarks/>
        LogiJednotka,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    public enum enum_TypJednotky_value {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class group {
        
        private string idField;
        
        private string kodField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Kod {
            get {
                return this.kodField;
            }
            set {
                this.kodField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataDruhArtiklu {
        
        private string kodField;
        
        private string nazevField;
        
        private string poznamkaField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataDruhArtiklu() {
            this.objectNameField = "DruhArtiklu";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kod {
            get {
                return this.kodField;
            }
            set {
                this.kodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Nazev {
            get {
                return this.nazevField;
            }
            set {
                this.nazevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Poznamka {
            get {
                return this.poznamkaField;
            }
            set {
                this.poznamkaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataFunkceOsoby {
        
        private string codeField;
        
        private string nameField;
        
        private string noteField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataFunkceOsoby() {
            this.objectNameField = "FunkceOsoby";
            this.objectTypeField = "Object";
        }
        
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
        public string Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataJednotka {
        
        private group groupField;
        
        private string desMistoField;
        
        private string kodField;
        
        private string nazevField;
        
        private string poznamkaField;
        
        private enum_TypJednotky typJednotkyField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataJednotka() {
            this.objectNameField = "Jednotka";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public group Group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DesMisto {
            get {
                return this.desMistoField;
            }
            set {
                this.desMistoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kod {
            get {
                return this.kodField;
            }
            set {
                this.kodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Nazev {
            get {
                return this.nazevField;
            }
            set {
                this.nazevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Poznamka {
            get {
                return this.poznamkaField;
            }
            set {
                this.poznamkaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public enum_TypJednotky TypJednotky {
            get {
                return this.typJednotkyField;
            }
            set {
                this.typJednotkyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataProduktovyKlic {
        
        private group groupField;
        
        private string kodField;
        
        private string nazevField;
        
        private string poznamkaField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataProduktovyKlic() {
            this.objectNameField = "ProduktovyKlic";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public group Group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kod {
            get {
                return this.kodField;
            }
            set {
                this.kodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Nazev {
            get {
                return this.nazevField;
            }
            set {
                this.nazevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Poznamka {
            get {
                return this.poznamkaField;
            }
            set {
                this.poznamkaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataTypSpojeni {
        
        private enum_DruhSpojeni druhSpojeniField;
        
        private string isUserField;
        
        private string kodField;
        
        private string nazevField;
        
        private string poznamkaField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataTypSpojeni() {
            this.objectNameField = "TypSpojeni";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public enum_DruhSpojeni DruhSpojeni {
            get {
                return this.druhSpojeniField;
            }
            set {
                this.druhSpojeniField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IsUser {
            get {
                return this.isUserField;
            }
            set {
                this.isUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kod {
            get {
                return this.kodField;
            }
            set {
                this.kodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Nazev {
            get {
                return this.nazevField;
            }
            set {
                this.nazevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Poznamka {
            get {
                return this.poznamkaField;
            }
            set {
                this.poznamkaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class S5DataZpusobPlatby {
        
        private string eETEvidovatTrzbuField;
        
        private string ekasaEvidovatTrzbuField;
        
        private string kodField;
        
        private string nazevField;
        
        private string poznamkaField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string idField;
        
        public S5DataZpusobPlatby() {
            this.objectNameField = "ZpusobPlatby";
            this.objectTypeField = "Object";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EETEvidovatTrzbu {
            get {
                return this.eETEvidovatTrzbuField;
            }
            set {
                this.eETEvidovatTrzbuField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EkasaEvidovatTrzbu {
            get {
                return this.ekasaEvidovatTrzbuField;
            }
            set {
                this.ekasaEvidovatTrzbuField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Kod {
            get {
                return this.kodField;
            }
            set {
                this.kodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Nazev {
            get {
                return this.nazevField;
            }
            set {
                this.nazevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Poznamka {
            get {
                return this.poznamkaField;
            }
            set {
                this.poznamkaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}
