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
    * Serializer for DiagnosticOrder instances
    */
    internal static partial class DiagnosticOrderSerializer
    {
        public static void SerializeDiagnosticOrder(Hl7.Fhir.Model.DiagnosticOrder value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("DiagnosticOrder");
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
            
            // Serialize element orderer
            if(value.Orderer != null && !summary)
            {
                writer.WriteStartElement("orderer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Orderer, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element identifier
            if(value.Identifier != null && !summary && value.Identifier.Count > 0)
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
            
            // Serialize element encounter
            if(value.Encounter != null && !summary)
            {
                writer.WriteStartElement("encounter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Encounter, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element clinicalNotes
            if(value.ClinicalNotesElement != null && !summary)
            {
                writer.WriteStartElement("clinicalNotes");
                FhirStringSerializer.SerializeFhirString(value.ClinicalNotesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element specimen
            if(value.Specimen != null && !summary && value.Specimen.Count > 0)
            {
                writer.WriteStartArrayElement("specimen");
                foreach(var item in value.Specimen)
                {
                    writer.WriteStartArrayMember("specimen");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null && !summary)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element priority
            if(value.PriorityElement != null && !summary)
            {
                writer.WriteStartElement("priority");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriority>(value.PriorityElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element event
            if(value.Event != null && !summary && value.Event.Count > 0)
            {
                writer.WriteStartArrayElement("event");
                foreach(var item in value.Event)
                {
                    writer.WriteStartArrayMember("event");
                    DiagnosticOrderSerializer.SerializeDiagnosticOrderEventComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element item
            if(value.Item != null && !summary && value.Item.Count > 0)
            {
                writer.WriteStartArrayElement("item");
                foreach(var item in value.Item)
                {
                    writer.WriteStartArrayMember("item");
                    DiagnosticOrderSerializer.SerializeDiagnosticOrderItemComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeDiagnosticOrderItemComponent(Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderItemComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element specimen
            if(value.Specimen != null && value.Specimen.Count > 0)
            {
                writer.WriteStartArrayElement("specimen");
                foreach(var item in value.Specimen)
                {
                    writer.WriteStartArrayMember("specimen");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element bodySite
            if(value.BodySite != null)
            {
                writer.WriteStartElement("bodySite");
                CodeableConceptSerializer.SerializeCodeableConcept(value.BodySite, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element event
            if(value.Event != null && value.Event.Count > 0)
            {
                writer.WriteStartArrayElement("event");
                foreach(var item in value.Event)
                {
                    writer.WriteStartArrayMember("event");
                    DiagnosticOrderSerializer.SerializeDiagnosticOrderEventComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDiagnosticOrderEventComponent(Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderEventComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element status
            if(value.StatusElement != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element date
            if(value.DateElement != null)
            {
                writer.WriteStartElement("date");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element actor
            if(value.Actor != null)
            {
                writer.WriteStartElement("actor");
                ResourceReferenceSerializer.SerializeResourceReference(value.Actor, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
