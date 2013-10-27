using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;
using System.Linq;

/*
  Copyright (c) 2011-2013, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Wed, Oct 2, 2013 07:37+1000 for FHIR v0.11
//

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for ImmunizationProfile instances
    */
    internal static partial class ImmunizationProfileSerializer
    {
        public static void SerializeImmunizationProfile(Hl7.Fhir.Model.ImmunizationProfile value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("ImmunizationProfile");
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element language
            if(value.LanguageElement != null && !summary)
            {
                writer.WriteStartElement("language");
                CodeSerializer.SerializeCode(value.LanguageElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.Text != null && !summary)
            {
                writer.WriteStartElement("text");
                NarrativeSerializer.SerializeNarrative(value.Text, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element contained
            if(value.Contained != null && !summary && value.Contained.Count > 0)
            {
                writer.WriteStartArrayElement("contained");
                foreach(var item in value.Contained)
                {
                    writer.WriteStartArrayMember("contained");
                    FhirSerializer.SerializeResource(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element subject
            if(value.Subject != null && !summary)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element recommendation
            if(value.Recommendation != null && !summary && value.Recommendation.Count > 0)
            {
                writer.WriteStartArrayElement("recommendation");
                foreach(var item in value.Recommendation)
                {
                    writer.WriteStartArrayMember("recommendation");
                    ImmunizationProfileSerializer.SerializeImmunizationProfileRecommendationComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeImmunizationProfileRecommendationProtocolComponent(Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element doseSequence
            if(value.DoseSequenceElement != null)
            {
                writer.WriteStartElement("doseSequence");
                IntegerSerializer.SerializeInteger(value.DoseSequenceElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.DescriptionElement != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element authority
            if(value.Authority != null)
            {
                writer.WriteStartElement("authority");
                ResourceReferenceSerializer.SerializeResourceReference(value.Authority, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element series
            if(value.SeriesElement != null)
            {
                writer.WriteStartElement("series");
                FhirStringSerializer.SerializeFhirString(value.SeriesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImmunizationProfileRecommendationDateCriterionComponent(Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element value
            if(value.ValueElement != null)
            {
                writer.WriteStartElement("value");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.ValueElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImmunizationProfileRecommendationSupportingAdverseEventReportComponent(Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element identifier
            if(value.IdentifierElement != null && value.IdentifierElement.Count > 0)
            {
                writer.WriteStartArrayElement("identifier");
                foreach(var item in value.IdentifierElement)
                {
                    writer.WriteStartArrayMember("identifier");
                    IdSerializer.SerializeId(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element reportType
            if(value.ReportType != null)
            {
                writer.WriteStartElement("reportType");
                CodeableConceptSerializer.SerializeCodeableConcept(value.ReportType, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reportDate
            if(value.ReportDateElement != null)
            {
                writer.WriteStartElement("reportDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.ReportDateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.TextElement != null)
            {
                writer.WriteStartElement("text");
                FhirStringSerializer.SerializeFhirString(value.TextElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reaction
            if(value.Reaction != null && value.Reaction.Count > 0)
            {
                writer.WriteStartArrayElement("reaction");
                foreach(var item in value.Reaction)
                {
                    writer.WriteStartArrayMember("reaction");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImmunizationProfileRecommendationComponent(Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element recommendationDate
            if(value.RecommendationDateElement != null)
            {
                writer.WriteStartElement("recommendationDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.RecommendationDateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element vaccineType
            if(value.VaccineType != null)
            {
                writer.WriteStartElement("vaccineType");
                CodeableConceptSerializer.SerializeCodeableConcept(value.VaccineType, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element doseNumber
            if(value.DoseNumberElement != null)
            {
                writer.WriteStartElement("doseNumber");
                IntegerSerializer.SerializeInteger(value.DoseNumberElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element forecastStatus
            if(value.ForecastStatusElement != null)
            {
                writer.WriteStartElement("forecastStatus");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatus>(value.ForecastStatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element dateCriterion
            if(value.DateCriterion != null && value.DateCriterion.Count > 0)
            {
                writer.WriteStartArrayElement("dateCriterion");
                foreach(var item in value.DateCriterion)
                {
                    writer.WriteStartArrayMember("dateCriterion");
                    ImmunizationProfileSerializer.SerializeImmunizationProfileRecommendationDateCriterionComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element protocol
            if(value.Protocol != null)
            {
                writer.WriteStartElement("protocol");
                ImmunizationProfileSerializer.SerializeImmunizationProfileRecommendationProtocolComponent(value.Protocol, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element supportingImmunization
            if(value.SupportingImmunization != null && value.SupportingImmunization.Count > 0)
            {
                writer.WriteStartArrayElement("supportingImmunization");
                foreach(var item in value.SupportingImmunization)
                {
                    writer.WriteStartArrayMember("supportingImmunization");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element supportingAdverseEventReport
            if(value.SupportingAdverseEventReport != null && value.SupportingAdverseEventReport.Count > 0)
            {
                writer.WriteStartArrayElement("supportingAdverseEventReport");
                foreach(var item in value.SupportingAdverseEventReport)
                {
                    writer.WriteStartArrayMember("supportingAdverseEventReport");
                    ImmunizationProfileSerializer.SerializeImmunizationProfileRecommendationSupportingAdverseEventReportComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element supportingPatientObservation
            if(value.SupportingPatientObservation != null && value.SupportingPatientObservation.Count > 0)
            {
                writer.WriteStartArrayElement("supportingPatientObservation");
                foreach(var item in value.SupportingPatientObservation)
                {
                    writer.WriteStartArrayMember("supportingPatientObservation");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
