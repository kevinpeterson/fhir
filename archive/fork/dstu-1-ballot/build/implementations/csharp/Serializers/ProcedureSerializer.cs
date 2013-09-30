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
    * Serializer for Procedure instances
    */
    internal static partial class ProcedureSerializer
    {
        public static void SerializeProcedure(Hl7.Fhir.Model.Procedure value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Procedure");
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
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element bodySite
            if(value.BodySite != null && value.BodySite.Count > 0)
            {
                writer.WriteStartArrayElement("bodySite");
                foreach(var item in value.BodySite)
                {
                    writer.WriteStartArrayMember("bodySite");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element indication
            if(value.IndicationElement != null)
            {
                writer.WriteStartElement("indication");
                FhirStringSerializer.SerializeFhirString(value.IndicationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element performer
            if(value.Performer != null && value.Performer.Count > 0)
            {
                writer.WriteStartArrayElement("performer");
                foreach(var item in value.Performer)
                {
                    writer.WriteStartArrayMember("performer");
                    ProcedureSerializer.SerializeProcedurePerformerComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element date
            if(value.Date != null)
            {
                writer.WriteStartElement("date");
                PeriodSerializer.SerializePeriod(value.Date, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element encounter
            if(value.Encounter != null)
            {
                writer.WriteStartElement("encounter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Encounter, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element outcome
            if(value.OutcomeElement != null)
            {
                writer.WriteStartElement("outcome");
                FhirStringSerializer.SerializeFhirString(value.OutcomeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element report
            if(value.Report != null && !summary && value.Report.Count > 0)
            {
                writer.WriteStartArrayElement("report");
                foreach(var item in value.Report)
                {
                    writer.WriteStartArrayMember("report");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element complication
            if(value.ComplicationElement != null && !summary)
            {
                writer.WriteStartElement("complication");
                FhirStringSerializer.SerializeFhirString(value.ComplicationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element followUp
            if(value.FollowUpElement != null && !summary)
            {
                writer.WriteStartElement("followUp");
                FhirStringSerializer.SerializeFhirString(value.FollowUpElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element relatedItem
            if(value.RelatedItem != null && !summary && value.RelatedItem.Count > 0)
            {
                writer.WriteStartArrayElement("relatedItem");
                foreach(var item in value.RelatedItem)
                {
                    writer.WriteStartArrayMember("relatedItem");
                    ProcedureSerializer.SerializeProcedureRelatedItemComponent(item, writer, summary);
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
        
        public static void SerializeProcedureRelatedItemComponent(Hl7.Fhir.Model.Procedure.ProcedureRelatedItemComponent value, IFhirWriter writer, bool summary)
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
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Procedure.ProcedureRelationshipType>(value.TypeElement, writer, summary);
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
        
        public static void SerializeProcedurePerformerComponent(Hl7.Fhir.Model.Procedure.ProcedurePerformerComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element person
            if(value.Person != null)
            {
                writer.WriteStartElement("person");
                ResourceReferenceSerializer.SerializeResourceReference(value.Person, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element role
            if(value.Role != null)
            {
                writer.WriteStartElement("role");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Role, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
