// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Terradue.ServiceModel.Ogc.Ssp20</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
using Terradue.ServiceModel.Ogc.Eop20;
using Terradue.ServiceModel.Ogc.Om20;
using Terradue.ServiceModel.Ogc.Gml321;

namespace Terradue.ServiceModel.Ogc.Ssp20
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EarthObservationType", Namespace = "http://www.opengis.net/ssp/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("EarthObservation", Namespace = "http://www.opengis.net/ssp/2.0", IsNullable = false)]
    public partial class SspEarthObservationType : EarthObservationType
    {

    }



    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FootprintType", Namespace = "http://www.opengis.net/ssp/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Footprint", Namespace = "http://www.opengis.net/ssp/2.0", IsNullable = false)]
    public partial class SspFootprintType : FootprintType
    {

        private CodeType locationNameField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public CodeType locationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;
            }
        }
    }



    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EarthObservationMetaDataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/eop/2.0")]
    public partial class SspEarthObservationMetaDataType : EarthObservationMetaDataType
    {


        private EarthObservationPropertyType[] derivedFromField;

        private DateTime nominalDateField;


        [System.Xml.Serialization.XmlElementAttribute("derivedFrom")]
        public EarthObservationPropertyType[] derivedFrom
        {
            get
            {
                return this.derivedFromField;
            }
            set
            {
                this.derivedFromField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("nominalDate")]
        public DateTime nominalDate
        {
            get
            {
                return this.nominalDateField;
            }
            set
            {
                this.nominalDateField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ssp/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ssp/2.0", IsNullable = false)]
    public partial class SspEarthObservationResultType : EarthObservationResultType
    {

        private MeasureType cloudCoverPercentageField;

        private MeasureType cloudCoverPercentageAssessmentConfidenceField;

        private string cloudCoverPercentageQuotationModeField;

        private MeasureType snowCoverPercentageField;

        private MeasureType snowCoverPercentageAssessmentConfidenceField;

        private string snowCoverPercentageQuotationModeField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public MeasureType cloudCoverPercentage
        {
            get
            {
                return this.cloudCoverPercentageField;
            }
            set
            {
                this.cloudCoverPercentageField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public MeasureType cloudCoverPercentageAssessmentConfidence
        {
            get
            {
                return this.cloudCoverPercentageAssessmentConfidenceField;
            }
            set
            {
                this.cloudCoverPercentageAssessmentConfidenceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public string cloudCoverPercentageQuotationMode
        {
            get
            {
                return this.cloudCoverPercentageQuotationModeField;
            }
            set
            {
                this.cloudCoverPercentageQuotationModeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public MeasureType snowCoverPercentage
        {
            get
            {
                return this.snowCoverPercentageField;
            }
            set
            {
                this.snowCoverPercentageField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public MeasureType snowCoverPercentageAssessmentConfidence
        {
            get
            {
                return this.snowCoverPercentageAssessmentConfidenceField;
            }
            set
            {
                this.snowCoverPercentageAssessmentConfidenceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public string snowCoverPercentageQuotationMode
        {
            get
            {
                return this.snowCoverPercentageQuotationModeField;
            }
            set
            {
                this.snowCoverPercentageQuotationModeField = value;
            }
        }
    }
   
}
