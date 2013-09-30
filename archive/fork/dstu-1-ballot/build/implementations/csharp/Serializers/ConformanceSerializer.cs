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
    * Serializer for Conformance instances
    */
    internal static partial class ConformanceSerializer
    {
        public static void SerializeConformance(Hl7.Fhir.Model.Conformance value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Conformance");
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
            if(value.IdentifierElement != null)
            {
                writer.WriteStartElement("identifier");
                FhirStringSerializer.SerializeFhirString(value.IdentifierElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element version
            if(value.VersionElement != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.VersionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.NameElement != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element publisher
            if(value.PublisherElement != null)
            {
                writer.WriteStartElement("publisher");
                FhirStringSerializer.SerializeFhirString(value.PublisherElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element telecom
            if(value.Telecom != null && value.Telecom.Count > 0)
            {
                writer.WriteStartArrayElement("telecom");
                foreach(var item in value.Telecom)
                {
                    writer.WriteStartArrayMember("telecom");
                    ContactSerializer.SerializeContact(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element description
            if(value.DescriptionElement != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Conformance.ConformanceStatementStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element experimental
            if(value.ExperimentalElement != null)
            {
                writer.WriteStartElement("experimental");
                FhirBooleanSerializer.SerializeFhirBoolean(value.ExperimentalElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element date
            if(value.DateElement != null)
            {
                writer.WriteStartElement("date");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element software
            if(value.Software != null)
            {
                writer.WriteStartElement("software");
                ConformanceSerializer.SerializeConformanceSoftwareComponent(value.Software, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element implementation
            if(value.Implementation != null)
            {
                writer.WriteStartElement("implementation");
                ConformanceSerializer.SerializeConformanceImplementationComponent(value.Implementation, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element fhirVersion
            if(value.FhirVersionElement != null)
            {
                writer.WriteStartElement("fhirVersion");
                IdSerializer.SerializeId(value.FhirVersionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element acceptUnknown
            if(value.AcceptUnknownElement != null && !summary)
            {
                writer.WriteStartElement("acceptUnknown");
                FhirBooleanSerializer.SerializeFhirBoolean(value.AcceptUnknownElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element format
            if(value.FormatElement != null && !summary && value.FormatElement.Count > 0)
            {
                writer.WriteStartArrayElement("format");
                foreach(var item in value.FormatElement)
                {
                    writer.WriteStartArrayMember("format");
                    CodeSerializer.SerializeCode(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element rest
            if(value.Rest != null && !summary && value.Rest.Count > 0)
            {
                writer.WriteStartArrayElement("rest");
                foreach(var item in value.Rest)
                {
                    writer.WriteStartArrayMember("rest");
                    ConformanceSerializer.SerializeConformanceRestComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element messaging
            if(value.Messaging != null && !summary && value.Messaging.Count > 0)
            {
                writer.WriteStartArrayElement("messaging");
                foreach(var item in value.Messaging)
                {
                    writer.WriteStartArrayMember("messaging");
                    ConformanceSerializer.SerializeConformanceMessagingComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element document
            if(value.Document != null && !summary && value.Document.Count > 0)
            {
                writer.WriteStartArrayElement("document");
                foreach(var item in value.Document)
                {
                    writer.WriteStartArrayMember("document");
                    ConformanceSerializer.SerializeConformanceDocumentComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeConformanceRestQueryComponent(Hl7.Fhir.Model.Conformance.ConformanceRestQueryComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element documentation
            if(value.DocumentationElement != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.DocumentationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element parameter
            if(value.Parameter != null && value.Parameter.Count > 0)
            {
                writer.WriteStartArrayElement("parameter");
                foreach(var item in value.Parameter)
                {
                    writer.WriteStartArrayMember("parameter");
                    ConformanceSerializer.SerializeConformanceRestResourceSearchParamComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestComponent(Hl7.Fhir.Model.Conformance.ConformanceRestComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element mode
            if(value.ModeElement != null)
            {
                writer.WriteStartElement("mode");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Conformance.RestfulConformanceMode>(value.ModeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.DocumentationElement != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.DocumentationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element security
            if(value.Security != null)
            {
                writer.WriteStartElement("security");
                ConformanceSerializer.SerializeConformanceRestSecurityComponent(value.Security, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element resource
            if(value.Resource != null && value.Resource.Count > 0)
            {
                writer.WriteStartArrayElement("resource");
                foreach(var item in value.Resource)
                {
                    writer.WriteStartArrayMember("resource");
                    ConformanceSerializer.SerializeConformanceRestResourceComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element batch
            if(value.BatchElement != null)
            {
                writer.WriteStartElement("batch");
                FhirBooleanSerializer.SerializeFhirBoolean(value.BatchElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element history
            if(value.HistoryElement != null)
            {
                writer.WriteStartElement("history");
                FhirBooleanSerializer.SerializeFhirBoolean(value.HistoryElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element query
            if(value.Query != null && value.Query.Count > 0)
            {
                writer.WriteStartArrayElement("query");
                foreach(var item in value.Query)
                {
                    writer.WriteStartArrayMember("query");
                    ConformanceSerializer.SerializeConformanceRestQueryComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceSoftwareComponent(Hl7.Fhir.Model.Conformance.ConformanceSoftwareComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element version
            if(value.VersionElement != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.VersionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element releaseDate
            if(value.ReleaseDateElement != null)
            {
                writer.WriteStartElement("releaseDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.ReleaseDateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceMessagingComponent(Hl7.Fhir.Model.Conformance.ConformanceMessagingComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element endpoint
            if(value.EndpointElement != null)
            {
                writer.WriteStartElement("endpoint");
                FhirUriSerializer.SerializeFhirUri(value.EndpointElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reliableCache
            if(value.ReliableCacheElement != null)
            {
                writer.WriteStartElement("reliableCache");
                IntegerSerializer.SerializeInteger(value.ReliableCacheElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.DocumentationElement != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.DocumentationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element event
            if(value.Event != null && value.Event.Count > 0)
            {
                writer.WriteStartArrayElement("event");
                foreach(var item in value.Event)
                {
                    writer.WriteStartArrayMember("event");
                    ConformanceSerializer.SerializeConformanceMessagingEventComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceDocumentComponent(Hl7.Fhir.Model.Conformance.ConformanceDocumentComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element mode
            if(value.ModeElement != null)
            {
                writer.WriteStartElement("mode");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Conformance.DocumentMode>(value.ModeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.DocumentationElement != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.DocumentationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element profile
            if(value.Profile != null)
            {
                writer.WriteStartElement("profile");
                ResourceReferenceSerializer.SerializeResourceReference(value.Profile, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestResourceComponent(Hl7.Fhir.Model.Conformance.ConformanceRestResourceComponent value, IFhirWriter writer, bool summary)
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
                CodeSerializer.SerializeCode(value.TypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element profile
            if(value.Profile != null)
            {
                writer.WriteStartElement("profile");
                ResourceReferenceSerializer.SerializeResourceReference(value.Profile, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element operation
            if(value.Operation != null && value.Operation.Count > 0)
            {
                writer.WriteStartArrayElement("operation");
                foreach(var item in value.Operation)
                {
                    writer.WriteStartArrayMember("operation");
                    ConformanceSerializer.SerializeConformanceRestResourceOperationComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element readHistory
            if(value.ReadHistoryElement != null)
            {
                writer.WriteStartElement("readHistory");
                FhirBooleanSerializer.SerializeFhirBoolean(value.ReadHistoryElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element searchInclude
            if(value.SearchIncludeElement != null && value.SearchIncludeElement.Count > 0)
            {
                writer.WriteStartArrayElement("searchInclude");
                foreach(var item in value.SearchIncludeElement)
                {
                    writer.WriteStartArrayMember("searchInclude");
                    FhirStringSerializer.SerializeFhirString(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element searchParam
            if(value.SearchParam != null && value.SearchParam.Count > 0)
            {
                writer.WriteStartArrayElement("searchParam");
                foreach(var item in value.SearchParam)
                {
                    writer.WriteStartArrayMember("searchParam");
                    ConformanceSerializer.SerializeConformanceRestResourceSearchParamComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceImplementationComponent(Hl7.Fhir.Model.Conformance.ConformanceImplementationComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element description
            if(value.DescriptionElement != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element url
            if(value.UrlElement != null)
            {
                writer.WriteStartElement("url");
                FhirUriSerializer.SerializeFhirUri(value.UrlElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestResourceOperationComponent(Hl7.Fhir.Model.Conformance.ConformanceRestResourceOperationComponent value, IFhirWriter writer, bool summary)
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
            if(value.CodeElement != null)
            {
                writer.WriteStartElement("code");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Conformance.RestfulOperation>(value.CodeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.DocumentationElement != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.DocumentationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceMessagingEventComponent(Hl7.Fhir.Model.Conformance.ConformanceMessagingEventComponent value, IFhirWriter writer, bool summary)
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
            if(value.CodeElement != null)
            {
                writer.WriteStartElement("code");
                CodeSerializer.SerializeCode(value.CodeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element mode
            if(value.ModeElement != null)
            {
                writer.WriteStartElement("mode");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Conformance.ConformanceEventMode>(value.ModeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element protocol
            if(value.Protocol != null && value.Protocol.Count > 0)
            {
                writer.WriteStartArrayElement("protocol");
                foreach(var item in value.Protocol)
                {
                    writer.WriteStartArrayMember("protocol");
                    CodingSerializer.SerializeCoding(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element focus
            if(value.FocusElement != null)
            {
                writer.WriteStartElement("focus");
                CodeSerializer.SerializeCode(value.FocusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element request
            if(value.Request != null)
            {
                writer.WriteStartElement("request");
                ResourceReferenceSerializer.SerializeResourceReference(value.Request, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element response
            if(value.Response != null)
            {
                writer.WriteStartElement("response");
                ResourceReferenceSerializer.SerializeResourceReference(value.Response, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.DocumentationElement != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.DocumentationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestSecurityComponent(Hl7.Fhir.Model.Conformance.ConformanceRestSecurityComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element service
            if(value.Service != null && value.Service.Count > 0)
            {
                writer.WriteStartArrayElement("service");
                foreach(var item in value.Service)
                {
                    writer.WriteStartArrayMember("service");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element description
            if(value.DescriptionElement != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element certificate
            if(value.Certificate != null && value.Certificate.Count > 0)
            {
                writer.WriteStartArrayElement("certificate");
                foreach(var item in value.Certificate)
                {
                    writer.WriteStartArrayMember("certificate");
                    ConformanceSerializer.SerializeConformanceRestSecurityCertificateComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestSecurityCertificateComponent(Hl7.Fhir.Model.Conformance.ConformanceRestSecurityCertificateComponent value, IFhirWriter writer, bool summary)
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
                CodeSerializer.SerializeCode(value.TypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element blob
            if(value.BlobElement != null)
            {
                writer.WriteStartElement("blob");
                Base64BinarySerializer.SerializeBase64Binary(value.BlobElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestResourceSearchParamComponent(Hl7.Fhir.Model.Conformance.ConformanceRestResourceSearchParamComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element source
            if(value.SourceElement != null)
            {
                writer.WriteStartElement("source");
                FhirUriSerializer.SerializeFhirUri(value.SourceElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.TypeElement != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Conformance.SearchParamType>(value.TypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.DocumentationElement != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.DocumentationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element xpath
            if(value.XpathElement != null)
            {
                writer.WriteStartElement("xpath");
                FhirStringSerializer.SerializeFhirString(value.XpathElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element target
            if(value.TargetElement != null && value.TargetElement.Count > 0)
            {
                writer.WriteStartArrayElement("target");
                foreach(var item in value.TargetElement)
                {
                    writer.WriteStartArrayMember("target");
                    CodeSerializer.SerializeCode(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element chain
            if(value.ChainElement != null && value.ChainElement.Count > 0)
            {
                writer.WriteStartArrayElement("chain");
                foreach(var item in value.ChainElement)
                {
                    writer.WriteStartArrayMember("chain");
                    FhirStringSerializer.SerializeFhirString(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
