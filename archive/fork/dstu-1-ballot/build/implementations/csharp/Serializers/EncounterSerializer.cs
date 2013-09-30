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
// Generated on Mon, Sep 30, 2013 03:15+1000 for FHIR v0.11
//

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Encounter instances
    */
    internal static partial class EncounterSerializer
    {
        public static void SerializeEncounter(Hl7.Fhir.Model.Encounter value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Encounter");
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
            
            // Serialize element identifier
            if(value.Identifier != null && value.Identifier.Count > 0)
            {
                writer.WriteStartArrayElement("identifier");
                foreach(var item in value.Identifier)
                {
                    writer.WriteStartArrayMember("identifier");
                    IdentifierSerializer.SerializeIdentifier(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Encounter.EncounterState>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element class
            if(value.ClassElement != null)
            {
                writer.WriteStartElement("class");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Encounter.EncounterClass>(value.ClassElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null && value.Type.Count > 0)
            {
                writer.WriteStartArrayElement("type");
                foreach(var item in value.Type)
                {
                    writer.WriteStartArrayMember("type");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element participant
            if(value.Participant != null && value.Participant.Count > 0)
            {
                writer.WriteStartArrayElement("participant");
                foreach(var item in value.Participant)
                {
                    writer.WriteStartArrayMember("participant");
                    EncounterSerializer.SerializeEncounterParticipantComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element fulfills
            if(value.Fulfills != null)
            {
                writer.WriteStartElement("fulfills");
                ResourceReferenceSerializer.SerializeResourceReference(value.Fulfills, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element start
            if(value.StartElement != null && !summary)
            {
                writer.WriteStartElement("start");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.StartElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element length
            if(value.Length != null && !summary)
            {
                writer.WriteStartElement("length");
                QuantitySerializer.SerializeQuantity(value.Length, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reason
            if(value.Reason != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("reason", value.Reason.GetType()) );
                FhirSerializer.SerializeElement(value.Reason, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element indication
            if(value.Indication != null && !summary)
            {
                writer.WriteStartElement("indication");
                ResourceReferenceSerializer.SerializeResourceReference(value.Indication, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element priority
            if(value.Priority != null && !summary)
            {
                writer.WriteStartElement("priority");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Priority, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element hospitalization
            if(value.Hospitalization != null && !summary)
            {
                writer.WriteStartElement("hospitalization");
                EncounterSerializer.SerializeEncounterHospitalizationComponent(value.Hospitalization, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element location
            if(value.Location != null && !summary && value.Location.Count > 0)
            {
                writer.WriteStartArrayElement("location");
                foreach(var item in value.Location)
                {
                    writer.WriteStartArrayMember("location");
                    EncounterSerializer.SerializeEncounterLocationComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element serviceProvider
            if(value.ServiceProvider != null && !summary)
            {
                writer.WriteStartElement("serviceProvider");
                ResourceReferenceSerializer.SerializeResourceReference(value.ServiceProvider, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element partOf
            if(value.PartOf != null && !summary)
            {
                writer.WriteStartElement("partOf");
                ResourceReferenceSerializer.SerializeResourceReference(value.PartOf, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeEncounterHospitalizationComponent(Hl7.Fhir.Model.Encounter.EncounterHospitalizationComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element preAdmissionIdentifier
            if(value.PreAdmissionIdentifier != null)
            {
                writer.WriteStartElement("preAdmissionIdentifier");
                IdentifierSerializer.SerializeIdentifier(value.PreAdmissionIdentifier, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element origin
            if(value.Origin != null)
            {
                writer.WriteStartElement("origin");
                ResourceReferenceSerializer.SerializeResourceReference(value.Origin, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element admitSource
            if(value.AdmitSource != null)
            {
                writer.WriteStartElement("admitSource");
                CodeableConceptSerializer.SerializeCodeableConcept(value.AdmitSource, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element period
            if(value.Period != null)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element accomodation
            if(value.Accomodation != null && value.Accomodation.Count > 0)
            {
                writer.WriteStartArrayElement("accomodation");
                foreach(var item in value.Accomodation)
                {
                    writer.WriteStartArrayMember("accomodation");
                    EncounterSerializer.SerializeEncounterHospitalizationAccomodationComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element diet
            if(value.Diet != null)
            {
                writer.WriteStartElement("diet");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Diet, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element specialCourtesy
            if(value.SpecialCourtesy != null && value.SpecialCourtesy.Count > 0)
            {
                writer.WriteStartArrayElement("specialCourtesy");
                foreach(var item in value.SpecialCourtesy)
                {
                    writer.WriteStartArrayMember("specialCourtesy");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element specialArrangement
            if(value.SpecialArrangement != null && value.SpecialArrangement.Count > 0)
            {
                writer.WriteStartArrayElement("specialArrangement");
                foreach(var item in value.SpecialArrangement)
                {
                    writer.WriteStartArrayMember("specialArrangement");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element destination
            if(value.Destination != null)
            {
                writer.WriteStartElement("destination");
                ResourceReferenceSerializer.SerializeResourceReference(value.Destination, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element dischargeDisposition
            if(value.DischargeDisposition != null)
            {
                writer.WriteStartElement("dischargeDisposition");
                CodeableConceptSerializer.SerializeCodeableConcept(value.DischargeDisposition, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reAdmission
            if(value.ReAdmissionElement != null)
            {
                writer.WriteStartElement("reAdmission");
                FhirBooleanSerializer.SerializeFhirBoolean(value.ReAdmissionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeEncounterHospitalizationAccomodationComponent(Hl7.Fhir.Model.Encounter.EncounterHospitalizationAccomodationComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element bed
            if(value.Bed != null)
            {
                writer.WriteStartElement("bed");
                ResourceReferenceSerializer.SerializeResourceReference(value.Bed, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element period
            if(value.Period != null)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeEncounterLocationComponent(Hl7.Fhir.Model.Encounter.EncounterLocationComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element location
            if(value.Location != null)
            {
                writer.WriteStartElement("location");
                ResourceReferenceSerializer.SerializeResourceReference(value.Location, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element period
            if(value.Period != null)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeEncounterParticipantComponent(Hl7.Fhir.Model.Encounter.EncounterParticipantComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element type
            if(value.TypeElement != null && value.TypeElement.Count > 0)
            {
                writer.WriteStartArrayElement("type");
                foreach(var item in value.TypeElement)
                {
                    writer.WriteStartArrayMember("type");
                    CodeSerializer.SerializeCode<Hl7.Fhir.Model.Encounter.ParticipantType>(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element practitioner
            if(value.Practitioner != null)
            {
                writer.WriteStartElement("practitioner");
                ResourceReferenceSerializer.SerializeResourceReference(value.Practitioner, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
