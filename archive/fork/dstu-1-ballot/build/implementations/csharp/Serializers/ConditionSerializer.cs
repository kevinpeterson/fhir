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
    * Serializer for Condition instances
    */
    internal static partial class ConditionSerializer
    {
        public static void SerializeCondition(Hl7.Fhir.Model.Condition value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Condition");
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
            
            // Serialize element encounter
            if(value.Encounter != null && !summary)
            {
                writer.WriteStartElement("encounter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Encounter, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element asserter
            if(value.Asserter != null && !summary)
            {
                writer.WriteStartElement("asserter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Asserter, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element dateAsserted
            if(value.DateAssertedElement != null && !summary)
            {
                writer.WriteStartElement("dateAsserted");
                DateSerializer.SerializeDate(value.DateAssertedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null && !summary)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element category
            if(value.Category != null && !summary)
            {
                writer.WriteStartElement("category");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Category, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null && !summary)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Condition.ConditionStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element certainty
            if(value.Certainty != null && !summary)
            {
                writer.WriteStartElement("certainty");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Certainty, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element severity
            if(value.Severity != null && !summary)
            {
                writer.WriteStartElement("severity");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Severity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element onset
            if(value.Onset != null && !summary)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("onset", value.Onset.GetType()) );
                FhirSerializer.SerializeElement(value.Onset, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element abatement
            if(value.Abatement != null && !summary)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("abatement", value.Abatement.GetType()) );
                FhirSerializer.SerializeElement(value.Abatement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element stage
            if(value.Stage != null && !summary)
            {
                writer.WriteStartElement("stage");
                ConditionSerializer.SerializeConditionStageComponent(value.Stage, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element evidence
            if(value.Evidence != null && !summary && value.Evidence.Count > 0)
            {
                writer.WriteStartArrayElement("evidence");
                foreach(var item in value.Evidence)
                {
                    writer.WriteStartArrayMember("evidence");
                    ConditionSerializer.SerializeConditionEvidenceComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element location
            if(value.Location != null && !summary && value.Location.Count > 0)
            {
                writer.WriteStartArrayElement("location");
                foreach(var item in value.Location)
                {
                    writer.WriteStartArrayMember("location");
                    ConditionSerializer.SerializeConditionLocationComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element relatedItem
            if(value.RelatedItem != null && !summary && value.RelatedItem.Count > 0)
            {
                writer.WriteStartArrayElement("relatedItem");
                foreach(var item in value.RelatedItem)
                {
                    writer.WriteStartArrayMember("relatedItem");
                    ConditionSerializer.SerializeConditionRelatedItemComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element notes
            if(value.NotesElement != null && !summary)
            {
                writer.WriteStartElement("notes");
                FhirStringSerializer.SerializeFhirString(value.NotesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeConditionRelatedItemComponent(Hl7.Fhir.Model.Condition.ConditionRelatedItemComponent value, IFhirWriter writer, bool summary)
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
            if(value.TypeElement != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Condition.ConditionRelationshipType>(value.TypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element target
            if(value.Target != null)
            {
                writer.WriteStartElement("target");
                ResourceReferenceSerializer.SerializeResourceReference(value.Target, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConditionEvidenceComponent(Hl7.Fhir.Model.Condition.ConditionEvidenceComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element detail
            if(value.Detail != null && value.Detail.Count > 0)
            {
                writer.WriteStartArrayElement("detail");
                foreach(var item in value.Detail)
                {
                    writer.WriteStartArrayMember("detail");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConditionStageComponent(Hl7.Fhir.Model.Condition.ConditionStageComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element summary
            if(value.Summary != null)
            {
                writer.WriteStartElement("summary");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Summary, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element assessment
            if(value.Assessment != null && value.Assessment.Count > 0)
            {
                writer.WriteStartArrayElement("assessment");
                foreach(var item in value.Assessment)
                {
                    writer.WriteStartArrayMember("assessment");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConditionLocationComponent(Hl7.Fhir.Model.Condition.ConditionLocationComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element detail
            if(value.DetailElement != null)
            {
                writer.WriteStartElement("detail");
                FhirStringSerializer.SerializeFhirString(value.DetailElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
