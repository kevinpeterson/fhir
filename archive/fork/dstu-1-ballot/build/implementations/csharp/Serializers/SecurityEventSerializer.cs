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
    * Serializer for SecurityEvent instances
    */
    internal static partial class SecurityEventSerializer
    {
        public static void SerializeSecurityEvent(Hl7.Fhir.Model.SecurityEvent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("SecurityEvent");
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
            
            // Serialize element event
            if(value.Event != null && !summary)
            {
                writer.WriteStartElement("event");
                SecurityEventSerializer.SerializeSecurityEventEventComponent(value.Event, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element participant
            if(value.Participant != null && !summary && value.Participant.Count > 0)
            {
                writer.WriteStartArrayElement("participant");
                foreach(var item in value.Participant)
                {
                    writer.WriteStartArrayMember("participant");
                    SecurityEventSerializer.SerializeSecurityEventParticipantComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element source
            if(value.Source != null && !summary)
            {
                writer.WriteStartElement("source");
                SecurityEventSerializer.SerializeSecurityEventSourceComponent(value.Source, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element object
            if(value.Object != null && !summary && value.Object.Count > 0)
            {
                writer.WriteStartArrayElement("object");
                foreach(var item in value.Object)
                {
                    writer.WriteStartArrayMember("object");
                    SecurityEventSerializer.SerializeSecurityEventObjectComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeSecurityEventObjectDetailComponent(Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectDetailComponent value, IFhirWriter writer, bool summary)
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
                FhirStringSerializer.SerializeFhirString(value.TypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element value
            if(value.ValueElement != null)
            {
                writer.WriteStartElement("value");
                Base64BinarySerializer.SerializeBase64Binary(value.ValueElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSecurityEventObjectComponent(Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectComponent value, IFhirWriter writer, bool summary)
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
            if(value.Identifier != null)
            {
                writer.WriteStartElement("identifier");
                IdentifierSerializer.SerializeIdentifier(value.Identifier, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reference
            if(value.Reference != null)
            {
                writer.WriteStartElement("reference");
                ResourceReferenceSerializer.SerializeResourceReference(value.Reference, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.TypeElement != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectType>(value.TypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element role
            if(value.RoleElement != null)
            {
                writer.WriteStartElement("role");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRole>(value.RoleElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element lifecycle
            if(value.LifecycleElement != null)
            {
                writer.WriteStartElement("lifecycle");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycle>(value.LifecycleElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element sensitivity
            if(value.Sensitivity != null)
            {
                writer.WriteStartElement("sensitivity");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Sensitivity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.NameElement != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element query
            if(value.QueryElement != null)
            {
                writer.WriteStartElement("query");
                Base64BinarySerializer.SerializeBase64Binary(value.QueryElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element detail
            if(value.Detail != null && value.Detail.Count > 0)
            {
                writer.WriteStartArrayElement("detail");
                foreach(var item in value.Detail)
                {
                    writer.WriteStartArrayMember("detail");
                    SecurityEventSerializer.SerializeSecurityEventObjectDetailComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSecurityEventSourceComponent(Hl7.Fhir.Model.SecurityEvent.SecurityEventSourceComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element site
            if(value.SiteElement != null)
            {
                writer.WriteStartElement("site");
                FhirStringSerializer.SerializeFhirString(value.SiteElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element identifier
            if(value.IdentifierElement != null)
            {
                writer.WriteStartElement("identifier");
                FhirStringSerializer.SerializeFhirString(value.IdentifierElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null && value.Type.Count > 0)
            {
                writer.WriteStartArrayElement("type");
                foreach(var item in value.Type)
                {
                    writer.WriteStartArrayMember("type");
                    CodingSerializer.SerializeCoding(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSecurityEventEventComponent(Hl7.Fhir.Model.SecurityEvent.SecurityEventEventComponent value, IFhirWriter writer, bool summary)
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
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element subtype
            if(value.Subtype != null && value.Subtype.Count > 0)
            {
                writer.WriteStartArrayElement("subtype");
                foreach(var item in value.Subtype)
                {
                    writer.WriteStartArrayMember("subtype");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element action
            if(value.ActionElement != null)
            {
                writer.WriteStartElement("action");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventAction>(value.ActionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element dateTime
            if(value.DateTimeElement != null)
            {
                writer.WriteStartElement("dateTime");
                InstantSerializer.SerializeInstant(value.DateTimeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element outcome
            if(value.OutcomeElement != null)
            {
                writer.WriteStartElement("outcome");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcome>(value.OutcomeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element outcomeDesc
            if(value.OutcomeDescElement != null)
            {
                writer.WriteStartElement("outcomeDesc");
                FhirStringSerializer.SerializeFhirString(value.OutcomeDescElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSecurityEventParticipantNetworkComponent(Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkComponent value, IFhirWriter writer, bool summary)
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
            if(value.IdentifierElement != null)
            {
                writer.WriteStartElement("identifier");
                FhirStringSerializer.SerializeFhirString(value.IdentifierElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.TypeElement != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkType>(value.TypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSecurityEventParticipantComponent(Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantComponent value, IFhirWriter writer, bool summary)
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
            if(value.Role != null && value.Role.Count > 0)
            {
                writer.WriteStartArrayElement("role");
                foreach(var item in value.Role)
                {
                    writer.WriteStartArrayMember("role");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element reference
            if(value.Reference != null)
            {
                writer.WriteStartElement("reference");
                ResourceReferenceSerializer.SerializeResourceReference(value.Reference, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element userId
            if(value.UserIdElement != null)
            {
                writer.WriteStartElement("userId");
                FhirStringSerializer.SerializeFhirString(value.UserIdElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element authId
            if(value.AuthIdElement != null)
            {
                writer.WriteStartElement("authId");
                FhirStringSerializer.SerializeFhirString(value.AuthIdElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.NameElement != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element requestor
            if(value.RequestorElement != null)
            {
                writer.WriteStartElement("requestor");
                FhirBooleanSerializer.SerializeFhirBoolean(value.RequestorElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element media
            if(value.Media != null)
            {
                writer.WriteStartElement("media");
                CodingSerializer.SerializeCoding(value.Media, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element network
            if(value.Network != null)
            {
                writer.WriteStartElement("network");
                SecurityEventSerializer.SerializeSecurityEventParticipantNetworkComponent(value.Network, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
