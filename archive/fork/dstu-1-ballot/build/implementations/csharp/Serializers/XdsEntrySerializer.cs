using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

/*
  Copyright (c) 2011-2012, HL7, Inc.
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
// Generated on Wed, Apr 3, 2013 07:11+1100 for FHIR v0.07
//

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for XdsEntry instances
    */
    internal static partial class XdsEntrySerializer
    {
        public static void SerializeXdsEntry(XdsEntry value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("XdsEntry");
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element language
            if(value.Language != null)
            {
                writer.WriteStartElement("language");
                CodeSerializer.SerializeCode(value.Language, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.Text != null)
            {
                writer.WriteStartElement("text");
                NarrativeSerializer.SerializeNarrative(value.Text, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element contained
            if(value.Contained != null && value.Contained.Count > 0)
            {
                writer.WriteStartArrayElement("contained");
                foreach(var item in value.Contained)
                {
                    writer.WriteStartArrayMember("contained");
                    FhirSerializer.SerializeResource(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element url
            if(value.Url != null)
            {
                writer.WriteStartElement("url");
                FhirUriSerializer.SerializeFhirUri(value.Url, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element repositoryId
            if(value.RepositoryId != null)
            {
                writer.WriteStartElement("repositoryId");
                FhirUriSerializer.SerializeFhirUri(value.RepositoryId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element mimeType
            if(value.MimeType != null)
            {
                writer.WriteStartElement("mimeType");
                FhirStringSerializer.SerializeFhirString(value.MimeType, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element format
            if(value.Format != null)
            {
                writer.WriteStartElement("format");
                CodingSerializer.SerializeCoding(value.Format, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element class
            if(value.Class != null)
            {
                writer.WriteStartElement("class");
                CodingSerializer.SerializeCoding(value.Class, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodingSerializer.SerializeCoding(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element title
            if(value.Title != null)
            {
                writer.WriteStartElement("title");
                FhirStringSerializer.SerializeFhirString(value.Title, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element documentId
            if(value.DocumentId != null)
            {
                writer.WriteStartElement("documentId");
                FhirUriSerializer.SerializeFhirUri(value.DocumentId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element availability
            if(value.Availability != null)
            {
                writer.WriteStartElement("availability");
                CodeSerializer.SerializeCode<XdsEntry.XdsEntryAvailability>(value.Availability, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element confidentialityCode
            if(value.ConfidentialityCode != null)
            {
                writer.WriteStartElement("confidentialityCode");
                CodingSerializer.SerializeCoding(value.ConfidentialityCode, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element created
            if(value.Created != null)
            {
                writer.WriteStartElement("created");
                InstantSerializer.SerializeInstant(value.Created, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element event
            if(value.Event != null && value.Event.Count > 0)
            {
                writer.WriteStartArrayElement("event");
                foreach(var item in value.Event)
                {
                    writer.WriteStartArrayMember("event");
                    CodingSerializer.SerializeCoding(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element hash
            if(value.Hash != null)
            {
                writer.WriteStartElement("hash");
                FhirStringSerializer.SerializeFhirString(value.Hash, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element size
            if(value.Size != null)
            {
                writer.WriteStartElement("size");
                FhirStringSerializer.SerializeFhirString(value.Size, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element lang
            if(value.Lang != null)
            {
                writer.WriteStartElement("lang");
                FhirStringSerializer.SerializeFhirString(value.Lang, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element folder
            if(value.Folder != null && value.Folder.Count > 0)
            {
                writer.WriteStartArrayElement("folder");
                foreach(var item in value.Folder)
                {
                    writer.WriteStartArrayMember("folder");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element patientId
            if(value.PatientId != null)
            {
                writer.WriteStartElement("patientId");
                IdentifierSerializer.SerializeIdentifier(value.PatientId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element sourcePatientId
            if(value.SourcePatientId != null)
            {
                writer.WriteStartElement("sourcePatientId");
                IdentifierSerializer.SerializeIdentifier(value.SourcePatientId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element patientInfo
            if(value.PatientInfo != null)
            {
                writer.WriteStartElement("patientInfo");
                ResourceReferenceSerializer.SerializeResourceReference(value.PatientInfo, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element author
            if(value.Author != null && value.Author.Count > 0)
            {
                writer.WriteStartArrayElement("author");
                foreach(var item in value.Author)
                {
                    writer.WriteStartArrayMember("author");
                    XdsEntrySerializer.SerializeXdsEntryAuthorComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element authenticator
            if(value.Authenticator != null)
            {
                writer.WriteStartElement("authenticator");
                XdsEntrySerializer.SerializeXdsEntryAuthenticatorComponent(value.Authenticator, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element facilityType
            if(value.FacilityType != null)
            {
                writer.WriteStartElement("facilityType");
                CodingSerializer.SerializeCoding(value.FacilityType, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element practiceSetting
            if(value.PracticeSetting != null)
            {
                writer.WriteStartElement("practiceSetting");
                CodingSerializer.SerializeCoding(value.PracticeSetting, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element homeCommunity
            if(value.HomeCommunity != null)
            {
                writer.WriteStartElement("homeCommunity");
                FhirUriSerializer.SerializeFhirUri(value.HomeCommunity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element service
            if(value.Service != null)
            {
                writer.WriteStartElement("service");
                XdsEntrySerializer.SerializeXdsEntryServiceComponent(value.Service, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element comments
            if(value.Comments != null)
            {
                writer.WriteStartElement("comments");
                FhirStringSerializer.SerializeFhirString(value.Comments, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeXdsEntryServiceComponent(XdsEntry.XdsEntryServiceComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element start
            if(value.Start != null)
            {
                writer.WriteStartElement("start");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Start, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element stop
            if(value.Stop != null)
            {
                writer.WriteStartElement("stop");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Stop, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeXdsEntryAuthorComponent(XdsEntry.XdsEntryAuthorComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                HumanNameSerializer.SerializeHumanName(value.Name, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element id
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                IdentifierSerializer.SerializeIdentifier(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element role
            if(value.Role != null && value.Role.Count > 0)
            {
                writer.WriteStartArrayElement("role");
                foreach(var item in value.Role)
                {
                    writer.WriteStartArrayMember("role");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element specialty
            if(value.Specialty != null && value.Specialty.Count > 0)
            {
                writer.WriteStartArrayElement("specialty");
                foreach(var item in value.Specialty)
                {
                    writer.WriteStartArrayMember("specialty");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element institution
            if(value.Institution != null && value.Institution.Count > 0)
            {
                writer.WriteStartArrayElement("institution");
                foreach(var item in value.Institution)
                {
                    writer.WriteStartArrayMember("institution");
                    XdsEntrySerializer.SerializeXdsEntryAuthorInstitutionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element contact
            if(value.Contact != null && value.Contact.Count > 0)
            {
                writer.WriteStartArrayElement("contact");
                foreach(var item in value.Contact)
                {
                    writer.WriteStartArrayMember("contact");
                    ContactSerializer.SerializeContact(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeXdsEntryAuthorInstitutionComponent(XdsEntry.XdsEntryAuthorInstitutionComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element id
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                IdentifierSerializer.SerializeIdentifier(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.Name, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeXdsEntryAuthenticatorComponent(XdsEntry.XdsEntryAuthenticatorComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element id
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                IdentifierSerializer.SerializeIdentifier(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                HumanNameSerializer.SerializeHumanName(value.Name, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
