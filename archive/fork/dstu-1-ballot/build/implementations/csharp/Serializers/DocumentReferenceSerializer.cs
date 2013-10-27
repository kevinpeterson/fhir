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
    * Serializer for DocumentReference instances
    */
    internal static partial class DocumentReferenceSerializer
    {
        public static void SerializeDocumentReference(Hl7.Fhir.Model.DocumentReference value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("DocumentReference");
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
            
            // Serialize element masterIdentifier
            if(value.MasterIdentifier != null && !summary)
            {
                writer.WriteStartElement("masterIdentifier");
                IdentifierSerializer.SerializeIdentifier(value.MasterIdentifier, writer, summary);
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
            
            // Serialize element subject
            if(value.Subject != null && !summary)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null && !summary)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element subtype
            if(value.Subtype != null && !summary)
            {
                writer.WriteStartElement("subtype");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Subtype, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element author
            if(value.Author != null && !summary && value.Author.Count > 0)
            {
                writer.WriteStartArrayElement("author");
                foreach(var item in value.Author)
                {
                    writer.WriteStartArrayMember("author");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element custodian
            if(value.Custodian != null && !summary)
            {
                writer.WriteStartElement("custodian");
                ResourceReferenceSerializer.SerializeResourceReference(value.Custodian, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element authenticator
            if(value.Authenticator != null && !summary)
            {
                writer.WriteStartElement("authenticator");
                ResourceReferenceSerializer.SerializeResourceReference(value.Authenticator, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element created
            if(value.CreatedElement != null && !summary)
            {
                writer.WriteStartElement("created");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.CreatedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element indexed
            if(value.IndexedElement != null && !summary)
            {
                writer.WriteStartElement("indexed");
                InstantSerializer.SerializeInstant(value.IndexedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null && !summary)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element docStatus
            if(value.DocStatus != null && !summary)
            {
                writer.WriteStartElement("docStatus");
                CodeableConceptSerializer.SerializeCodeableConcept(value.DocStatus, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element supercedes
            if(value.Supercedes != null && !summary)
            {
                writer.WriteStartElement("supercedes");
                ResourceReferenceSerializer.SerializeResourceReference(value.Supercedes, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.DescriptionElement != null && !summary)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element confidentiality
            if(value.Confidentiality != null && !summary)
            {
                writer.WriteStartElement("confidentiality");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Confidentiality, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element primaryLanguage
            if(value.PrimaryLanguageElement != null && !summary)
            {
                writer.WriteStartElement("primaryLanguage");
                CodeSerializer.SerializeCode(value.PrimaryLanguageElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element mimeType
            if(value.MimeTypeElement != null && !summary)
            {
                writer.WriteStartElement("mimeType");
                CodeSerializer.SerializeCode(value.MimeTypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element format
            if(value.Format != null && !summary)
            {
                writer.WriteStartElement("format");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Format, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element size
            if(value.SizeElement != null && !summary)
            {
                writer.WriteStartElement("size");
                IntegerSerializer.SerializeInteger(value.SizeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element hash
            if(value.HashElement != null && !summary)
            {
                writer.WriteStartElement("hash");
                FhirStringSerializer.SerializeFhirString(value.HashElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element location
            if(value.LocationElement != null && !summary)
            {
                writer.WriteStartElement("location");
                FhirUriSerializer.SerializeFhirUri(value.LocationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element service
            if(value.Service != null && !summary)
            {
                writer.WriteStartElement("service");
                DocumentReferenceSerializer.SerializeDocumentReferenceServiceComponent(value.Service, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element context
            if(value.Context != null && !summary)
            {
                writer.WriteStartElement("context");
                DocumentReferenceSerializer.SerializeDocumentReferenceContextComponent(value.Context, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeDocumentReferenceContextComponent(Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextComponent value, IFhirWriter writer, bool summary)
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
            if(value.Code != null && value.Code.Count > 0)
            {
                writer.WriteStartArrayElement("code");
                foreach(var item in value.Code)
                {
                    writer.WriteStartArrayMember("code");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element period
            if(value.Period != null)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element facilityType
            if(value.FacilityType != null)
            {
                writer.WriteStartElement("facilityType");
                CodeableConceptSerializer.SerializeCodeableConcept(value.FacilityType, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDocumentReferenceServiceParameterComponent(Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceParameterComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element value
            if(value.ValueElement != null)
            {
                writer.WriteStartElement("value");
                FhirStringSerializer.SerializeFhirString(value.ValueElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDocumentReferenceServiceComponent(Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element address
            if(value.AddressElement != null)
            {
                writer.WriteStartElement("address");
                FhirStringSerializer.SerializeFhirString(value.AddressElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element parameter
            if(value.Parameter != null && value.Parameter.Count > 0)
            {
                writer.WriteStartArrayElement("parameter");
                foreach(var item in value.Parameter)
                {
                    writer.WriteStartArrayMember("parameter");
                    DocumentReferenceSerializer.SerializeDocumentReferenceServiceParameterComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
