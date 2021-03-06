// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Terradue.ServiceModel.Ogc.Observation</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Gmd;


namespace Terradue.ServiceModel.Ogc.Om20
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;


    

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/om/2.0", IsNullable = true)]
    public partial class ObservationContextPropertyType
    {

        private ObservationContextType observationContextField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public ObservationContextType ObservationContext
        {
            get
            {
                return this.observationContextField;
            }
            set
            {
                this.observationContextField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ObservationContext", Namespace = "http://www.opengis.net/om/2.0", IsNullable = false)]
    public partial class ObservationContextType
    {

        private ReferenceType roleField;

        private ReferenceType relatedObservationField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public ReferenceType role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public ReferenceType relatedObservation
        {
            get
            {
                return this.relatedObservationField;
            }
            set
            {
                this.relatedObservationField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/om/2.0", IsNullable = true)]
    public partial class TimeObjectPropertyType
    {

        private AbstractTimeObjectType abstractTimeObjectField;

        private string nilReasonField;

        private string remoteSchemaField;

        [System.Xml.Serialization.XmlElementAttribute("TimePeriod", Type=typeof(TimePeriodType), Namespace = "http://www.opengis.net/gml/3.2")]
        public AbstractTimeObjectType AbstractTimeObject
        {
            get
            {
                return this.abstractTimeObjectField;
            }
            set
            {
                this.abstractTimeObjectField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/om/2.0", IsNullable = true)]
    public partial class OM_ResultPropertyType
    {

        private System.Xml.XmlElement anyField;

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/om/2.0", IsNullable = true)]
    public partial class NamedValuePropertyType
    {

        private NamedValueType namedValueField;

        private string nilReasonField;

        private string remoteSchemaField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public NamedValueType NamedValue
        {
            get
            {
                return this.namedValueField;
            }
            set
            {
                this.namedValueField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("NamedValue", Namespace = "http://www.opengis.net/om/2.0", IsNullable = false)]
    public partial class NamedValueType
    {

        private ReferenceType nameField;

        private object valueField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public ReferenceType name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public object value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    
}
