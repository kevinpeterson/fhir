using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

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
// Generated on Fri, Jul 5, 2013 15:14+1000 for FHIR v0.09
//

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Demographics instances
    */
    internal static partial class DemographicsSerializer
    {
        public static void SerializeDemographics(Hl7.Fhir.Model.Demographics value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalId != null)
                writer.WritePrimitiveContents("_id", value.LocalId, XmlSerializationHint.Attribute);
            
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
            
            // Serialize element identifier
            if(value.Identifier != null && value.Identifier.Count > 0)
            {
                writer.WriteStartArrayElement("identifier");
                foreach(var item in value.Identifier)
                {
                    writer.WriteStartArrayMember("identifier");
                    IdentifierSerializer.SerializeIdentifier(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element name
            if(value.Name != null && value.Name.Count > 0)
            {
                writer.WriteStartArrayElement("name");
                foreach(var item in value.Name)
                {
                    writer.WriteStartArrayMember("name");
                    HumanNameSerializer.SerializeHumanName(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element telecom
            if(value.Telecom != null && value.Telecom.Count > 0)
            {
                writer.WriteStartArrayElement("telecom");
                foreach(var item in value.Telecom)
                {
                    writer.WriteStartArrayMember("telecom");
                    ContactSerializer.SerializeContact(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element gender
            if(value.Gender != null)
            {
                writer.WriteStartElement("gender");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Gender, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element birthDate
            if(value.BirthDate != null)
            {
                writer.WriteStartElement("birthDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.BirthDate, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element deceased
            if(value.Deceased != null)
            {
                writer.WriteStartElement("deceased");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Deceased, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element address
            if(value.Address != null && value.Address.Count > 0)
            {
                writer.WriteStartArrayElement("address");
                foreach(var item in value.Address)
                {
                    writer.WriteStartArrayMember("address");
                    AddressSerializer.SerializeAddress(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element photo
            if(value.Photo != null && value.Photo.Count > 0)
            {
                writer.WriteStartArrayElement("photo");
                foreach(var item in value.Photo)
                {
                    writer.WriteStartArrayMember("photo");
                    AttachmentSerializer.SerializeAttachment(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element maritalStatus
            if(value.MaritalStatus != null)
            {
                writer.WriteStartElement("maritalStatus");
                CodeableConceptSerializer.SerializeCodeableConcept(value.MaritalStatus, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element language
            if(value.Language != null && value.Language.Count > 0)
            {
                writer.WriteStartArrayElement("language");
                foreach(var item in value.Language)
                {
                    writer.WriteStartArrayMember("language");
                    DemographicsSerializer.SerializeDemographicsLanguageComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDemographicsLanguageComponent(Hl7.Fhir.Model.Demographics.DemographicsLanguageComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalId != null)
                writer.WritePrimitiveContents("_id", value.LocalId, XmlSerializationHint.Attribute);
            
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
                CodeableConceptSerializer.SerializeCodeableConcept(value.Language, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element mode
            if(value.Mode != null && value.Mode.Count > 0)
            {
                writer.WriteStartArrayElement("mode");
                foreach(var item in value.Mode)
                {
                    writer.WriteStartArrayMember("mode");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element proficiencyLevel
            if(value.ProficiencyLevel != null)
            {
                writer.WriteStartElement("proficiencyLevel");
                CodeableConceptSerializer.SerializeCodeableConcept(value.ProficiencyLevel, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element preference
            if(value.Preference != null)
            {
                writer.WriteStartElement("preference");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Preference, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
