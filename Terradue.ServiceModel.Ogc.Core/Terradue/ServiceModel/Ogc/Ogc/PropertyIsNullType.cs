namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsNull", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class PropertyIsNullType : ComparisonOpsType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyName")]
        public PropertyNameType PropertyName { get; set; }
    }
}
