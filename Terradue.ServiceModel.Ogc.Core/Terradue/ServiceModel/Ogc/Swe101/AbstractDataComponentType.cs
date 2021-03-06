using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDataArrayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataArrayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDataRecordType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractConditionalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConditionalValueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConditionalDataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleDataRecordType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataRecordType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    public abstract class AbstractDataComponentType : AbstractGMLType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("fixed")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Fixed
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("definition", DataType = "anyURI")]
        public string Definition
        {
            get;
            set;
        }
    }
}
