namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("DCP", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class Dcp
    {
        private Http _http = new Http();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HTTP")]
        public Http Http
        {
            get
            {
                return this._http;
            }
            set
            {
                this._http = value;
            }
        }
    }
}
