using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Keywords", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class KeywordsType
    {
        private Collection<LanguageStringType> _keywords = new Collection<LanguageStringType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public Collection<LanguageStringType> Keywords
        {
            get
            {
                return this._keywords;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Type")]
        public CodeType Type
        {
            get;
            set;
        }
    }
}
