namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsBetween", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class PropertyIsBetweenType : ComparisonOpsType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expression")]
        public ExpressionType Expression { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LowerBoundary")]
        public LowerBoundaryType LowerBoundary { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UpperBoundary")]
        public UpperBoundaryType UpperBoundary { get; set; }
    }
}
