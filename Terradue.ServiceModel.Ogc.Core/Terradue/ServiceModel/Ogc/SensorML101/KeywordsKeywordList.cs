using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class KeywordsKeywordList
    {
        private Collection<string> _keywords = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keyword", DataType = "token")]
        public Collection<string> Keywords
        {
            get
            {
                return this._keywords;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType = "ID")]
        public string Id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("codeSpace", DataType = "anyURI")]
        public string CodeSpace { get; set; }
    }
}
