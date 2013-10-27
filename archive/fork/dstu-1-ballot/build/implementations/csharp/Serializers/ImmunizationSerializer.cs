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
    * Serializer for Immunization instances
    */
    internal static partial class ImmunizationSerializer
    {
        public static void SerializeImmunization(Hl7.Fhir.Model.Immunization value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Immunization");
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
            
            // Serialize element date
            if(value.DateElement != null && !summary)
            {
                writer.WriteStartElement("date");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element vaccineType
            if(value.VaccineType != null && !summary)
            {
                writer.WriteStartElement("vaccineType");
                CodeableConceptSerializer.SerializeCodeableConcept(value.VaccineType, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null && !summary)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element refusedIndicator
            if(value.RefusedIndicatorElement != null && !summary)
            {
                writer.WriteStartElement("refusedIndicator");
                FhirBooleanSerializer.SerializeFhirBoolean(value.RefusedIndicatorElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reported
            if(value.ReportedElement != null && !summary)
            {
                writer.WriteStartElement("reported");
                FhirBooleanSerializer.SerializeFhirBoolean(value.ReportedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element performer
            if(value.Performer != null && !summary)
            {
                writer.WriteStartElement("performer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Performer, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element requester
            if(value.Requester != null && !summary)
            {
                writer.WriteStartElement("requester");
                ResourceReferenceSerializer.SerializeResourceReference(value.Requester, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element manufacturer
            if(value.Manufacturer != null && !summary)
            {
                writer.WriteStartElement("manufacturer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Manufacturer, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element location
            if(value.Location != null && !summary)
            {
                writer.WriteStartElement("location");
                ResourceReferenceSerializer.SerializeResourceReference(value.Location, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element lotNumber
            if(value.LotNumberElement != null && !summary)
            {
                writer.WriteStartElement("lotNumber");
                FhirStringSerializer.SerializeFhirString(value.LotNumberElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element expirationDate
            if(value.ExpirationDateElement != null && !summary)
            {
                writer.WriteStartElement("expirationDate");
                DateSerializer.SerializeDate(value.ExpirationDateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element site
            if(value.Site != null && !summary)
            {
                writer.WriteStartElement("site");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Site, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element route
            if(value.Route != null && !summary)
            {
                writer.WriteStartElement("route");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Route, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element doseQuantity
            if(value.DoseQuantity != null && !summary)
            {
                writer.WriteStartElement("doseQuantity");
                QuantitySerializer.SerializeQuantity(value.DoseQuantity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element explanation
            if(value.Explanation != null && !summary)
            {
                writer.WriteStartElement("explanation");
                ImmunizationSerializer.SerializeImmunizationExplanationComponent(value.Explanation, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reaction
            if(value.Reaction != null && !summary && value.Reaction.Count > 0)
            {
                writer.WriteStartArrayElement("reaction");
                foreach(var item in value.Reaction)
                {
                    writer.WriteStartArrayMember("reaction");
                    ImmunizationSerializer.SerializeImmunizationReactionComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element vaccinationProtocol
            if(value.VaccinationProtocol != null && !summary)
            {
                writer.WriteStartElement("vaccinationProtocol");
                ImmunizationSerializer.SerializeImmunizationVaccinationProtocolComponent(value.VaccinationProtocol, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeImmunizationVaccinationProtocolComponent(Hl7.Fhir.Model.Immunization.ImmunizationVaccinationProtocolComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element seriesDoses
            if(value.SeriesDosesElement != null)
            {
                writer.WriteStartElement("seriesDoses");
                IntegerSerializer.SerializeInteger(value.SeriesDosesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element doseTarget
            if(value.DoseTarget != null)
            {
                writer.WriteStartElement("doseTarget");
                CodeableConceptSerializer.SerializeCodeableConcept(value.DoseTarget, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element doseStatus
            if(value.DoseStatus != null)
            {
                writer.WriteStartElement("doseStatus");
                CodeableConceptSerializer.SerializeCodeableConcept(value.DoseStatus, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element doseStatusReason
            if(value.DoseStatusReason != null)
            {
                writer.WriteStartElement("doseStatusReason");
                CodeableConceptSerializer.SerializeCodeableConcept(value.DoseStatusReason, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImmunizationExplanationComponent(Hl7.Fhir.Model.Immunization.ImmunizationExplanationComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element reason
            if(value.Reason != null && value.Reason.Count > 0)
            {
                writer.WriteStartArrayElement("reason");
                foreach(var item in value.Reason)
                {
                    writer.WriteStartArrayMember("reason");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element refusalReason
            if(value.RefusalReason != null && value.RefusalReason.Count > 0)
            {
                writer.WriteStartArrayElement("refusalReason");
                foreach(var item in value.RefusalReason)
                {
                    writer.WriteStartArrayMember("refusalReason");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImmunizationReactionComponent(Hl7.Fhir.Model.Immunization.ImmunizationReactionComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element date
            if(value.DateElement != null)
            {
                writer.WriteStartElement("date");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element detail
            if(value.Detail != null)
            {
                writer.WriteStartElement("detail");
                ResourceReferenceSerializer.SerializeResourceReference(value.Detail, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reported
            if(value.ReportedElement != null)
            {
                writer.WriteStartElement("reported");
                FhirBooleanSerializer.SerializeFhirBoolean(value.ReportedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
