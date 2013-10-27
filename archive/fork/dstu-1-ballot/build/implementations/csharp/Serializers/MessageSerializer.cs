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
    * Serializer for Message instances
    */
    internal static partial class MessageSerializer
    {
        public static void SerializeMessage(Hl7.Fhir.Model.Message value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Message");
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
            if(value.IdentifierElement != null && !summary)
            {
                writer.WriteStartElement("identifier");
                IdSerializer.SerializeId(value.IdentifierElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element timestamp
            if(value.TimestampElement != null && !summary)
            {
                writer.WriteStartElement("timestamp");
                InstantSerializer.SerializeInstant(value.TimestampElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element event
            if(value.EventElement != null && !summary)
            {
                writer.WriteStartElement("event");
                CodeSerializer.SerializeCode(value.EventElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element response
            if(value.Response != null && !summary)
            {
                writer.WriteStartElement("response");
                MessageSerializer.SerializeMessageResponseComponent(value.Response, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element source
            if(value.Source != null && !summary)
            {
                writer.WriteStartElement("source");
                MessageSerializer.SerializeMessageSourceComponent(value.Source, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element destination
            if(value.Destination != null && !summary)
            {
                writer.WriteStartElement("destination");
                MessageSerializer.SerializeMessageDestinationComponent(value.Destination, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element enterer
            if(value.Enterer != null && !summary)
            {
                writer.WriteStartElement("enterer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Enterer, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element author
            if(value.Author != null && !summary)
            {
                writer.WriteStartElement("author");
                ResourceReferenceSerializer.SerializeResourceReference(value.Author, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element receiver
            if(value.Receiver != null && !summary)
            {
                writer.WriteStartElement("receiver");
                ResourceReferenceSerializer.SerializeResourceReference(value.Receiver, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element responsible
            if(value.Responsible != null && !summary)
            {
                writer.WriteStartElement("responsible");
                ResourceReferenceSerializer.SerializeResourceReference(value.Responsible, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element effective
            if(value.Effective != null && !summary)
            {
                writer.WriteStartElement("effective");
                PeriodSerializer.SerializePeriod(value.Effective, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reason
            if(value.Reason != null && !summary)
            {
                writer.WriteStartElement("reason");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Reason, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element data
            if(value.Data != null && !summary && value.Data.Count > 0)
            {
                writer.WriteStartArrayElement("data");
                foreach(var item in value.Data)
                {
                    writer.WriteStartArrayMember("data");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeMessageDestinationComponent(Hl7.Fhir.Model.Message.MessageDestinationComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element name
            if(value.NameElement != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element target
            if(value.Target != null)
            {
                writer.WriteStartElement("target");
                ResourceReferenceSerializer.SerializeResourceReference(value.Target, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element endpoint
            if(value.EndpointElement != null)
            {
                writer.WriteStartElement("endpoint");
                FhirUriSerializer.SerializeFhirUri(value.EndpointElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeMessageSourceComponent(Hl7.Fhir.Model.Message.MessageSourceComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element name
            if(value.NameElement != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element software
            if(value.SoftwareElement != null)
            {
                writer.WriteStartElement("software");
                FhirStringSerializer.SerializeFhirString(value.SoftwareElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element version
            if(value.VersionElement != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.VersionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element contact
            if(value.Contact != null)
            {
                writer.WriteStartElement("contact");
                ContactSerializer.SerializeContact(value.Contact, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element endpoint
            if(value.EndpointElement != null)
            {
                writer.WriteStartElement("endpoint");
                FhirUriSerializer.SerializeFhirUri(value.EndpointElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeMessageResponseComponent(Hl7.Fhir.Model.Message.MessageResponseComponent value, IFhirWriter writer, bool summary)
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
                IdSerializer.SerializeId(value.IdentifierElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.CodeElement != null)
            {
                writer.WriteStartElement("code");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Message.ResponseCode>(value.CodeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element details
            if(value.Details != null)
            {
                writer.WriteStartElement("details");
                ResourceReferenceSerializer.SerializeResourceReference(value.Details, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
