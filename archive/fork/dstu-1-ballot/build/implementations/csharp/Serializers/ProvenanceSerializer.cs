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
    * Serializer for Provenance instances
    */
    internal static partial class ProvenanceSerializer
    {
        public static void SerializeProvenance(Hl7.Fhir.Model.Provenance value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Provenance");
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
            
            // Serialize element target
            if(value.Target != null && !summary && value.Target.Count > 0)
            {
                writer.WriteStartArrayElement("target");
                foreach(var item in value.Target)
                {
                    writer.WriteStartArrayMember("target");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element period
            if(value.Period != null && !summary)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element recorded
            if(value.RecordedElement != null && !summary)
            {
                writer.WriteStartElement("recorded");
                InstantSerializer.SerializeInstant(value.RecordedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reason
            if(value.Reason != null && !summary)
            {
                writer.WriteStartElement("reason");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Reason, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element location
            if(value.Location != null && !summary)
            {
                writer.WriteStartElement("location");
                ResourceReferenceSerializer.SerializeResourceReference(value.Location, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element policy
            if(value.PolicyElement != null && !summary && value.PolicyElement.Count > 0)
            {
                writer.WriteStartArrayElement("policy");
                foreach(var item in value.PolicyElement)
                {
                    writer.WriteStartArrayMember("policy");
                    FhirUriSerializer.SerializeFhirUri(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element agent
            if(value.Agent != null && !summary && value.Agent.Count > 0)
            {
                writer.WriteStartArrayElement("agent");
                foreach(var item in value.Agent)
                {
                    writer.WriteStartArrayMember("agent");
                    ProvenanceSerializer.SerializeProvenanceAgentComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element entity
            if(value.Entity != null && !summary && value.Entity.Count > 0)
            {
                writer.WriteStartArrayElement("entity");
                foreach(var item in value.Entity)
                {
                    writer.WriteStartArrayMember("entity");
                    ProvenanceSerializer.SerializeProvenanceEntityComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element signature
            if(value.SignatureElement != null && !summary)
            {
                writer.WriteStartElement("signature");
                FhirStringSerializer.SerializeFhirString(value.SignatureElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeProvenanceAgentComponent(Hl7.Fhir.Model.Provenance.ProvenanceAgentComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element role
            if(value.Role != null)
            {
                writer.WriteStartElement("role");
                CodingSerializer.SerializeCoding(value.Role, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodingSerializer.SerializeCoding(value.Type, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reference
            if(value.ReferenceElement != null)
            {
                writer.WriteStartElement("reference");
                FhirUriSerializer.SerializeFhirUri(value.ReferenceElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element display
            if(value.DisplayElement != null)
            {
                writer.WriteStartElement("display");
                FhirStringSerializer.SerializeFhirString(value.DisplayElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProvenanceEntityComponent(Hl7.Fhir.Model.Provenance.ProvenanceEntityComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element role
            if(value.RoleElement != null)
            {
                writer.WriteStartElement("role");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>(value.RoleElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodingSerializer.SerializeCoding(value.Type, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reference
            if(value.ReferenceElement != null)
            {
                writer.WriteStartElement("reference");
                FhirUriSerializer.SerializeFhirUri(value.ReferenceElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element display
            if(value.DisplayElement != null)
            {
                writer.WriteStartElement("display");
                FhirStringSerializer.SerializeFhirString(value.DisplayElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element agent
            if(value.Agent != null)
            {
                writer.WriteStartElement("agent");
                ProvenanceSerializer.SerializeProvenanceAgentComponent(value.Agent, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
