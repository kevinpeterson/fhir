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
    * Serializer for Patient instances
    */
    internal static partial class PatientSerializer
    {
        public static void SerializePatient(Hl7.Fhir.Model.Patient value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Patient");
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
            if(value.Identifier != null && value.Identifier.Count > 0)
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
            
            // Serialize element name
            if(value.Name != null && value.Name.Count > 0)
            {
                writer.WriteStartArrayElement("name");
                foreach(var item in value.Name)
                {
                    writer.WriteStartArrayMember("name");
                    HumanNameSerializer.SerializeHumanName(item, writer, summary);
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
                    ContactSerializer.SerializeContact(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element gender
            if(value.Gender != null)
            {
                writer.WriteStartElement("gender");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Gender, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element birthDate
            if(value.BirthDateElement != null)
            {
                writer.WriteStartElement("birthDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.BirthDateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element deceased
            if(value.Deceased != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("deceased", value.Deceased.GetType()) );
                FhirSerializer.SerializeElement(value.Deceased, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element address
            if(value.Address != null && value.Address.Count > 0)
            {
                writer.WriteStartArrayElement("address");
                foreach(var item in value.Address)
                {
                    writer.WriteStartArrayMember("address");
                    AddressSerializer.SerializeAddress(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element maritalStatus
            if(value.MaritalStatus != null)
            {
                writer.WriteStartElement("maritalStatus");
                CodeableConceptSerializer.SerializeCodeableConcept(value.MaritalStatus, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element multipleBirth
            if(value.MultipleBirth != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("multipleBirth", value.MultipleBirth.GetType()) );
                FhirSerializer.SerializeElement(value.MultipleBirth, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element photo
            if(value.Photo != null && !summary && value.Photo.Count > 0)
            {
                writer.WriteStartArrayElement("photo");
                foreach(var item in value.Photo)
                {
                    writer.WriteStartArrayMember("photo");
                    AttachmentSerializer.SerializeAttachment(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element contact
            if(value.Contact != null && !summary && value.Contact.Count > 0)
            {
                writer.WriteStartArrayElement("contact");
                foreach(var item in value.Contact)
                {
                    writer.WriteStartArrayMember("contact");
                    PatientSerializer.SerializeContactComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element animal
            if(value.Animal != null)
            {
                writer.WriteStartElement("animal");
                PatientSerializer.SerializeAnimalComponent(value.Animal, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element communication
            if(value.Communication != null && !summary && value.Communication.Count > 0)
            {
                writer.WriteStartArrayElement("communication");
                foreach(var item in value.Communication)
                {
                    writer.WriteStartArrayMember("communication");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element provider
            if(value.Provider != null)
            {
                writer.WriteStartElement("provider");
                ResourceReferenceSerializer.SerializeResourceReference(value.Provider, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element link
            if(value.Link != null && value.Link.Count > 0)
            {
                writer.WriteStartArrayElement("link");
                foreach(var item in value.Link)
                {
                    writer.WriteStartArrayMember("link");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element active
            if(value.ActiveElement != null)
            {
                writer.WriteStartElement("active");
                FhirBooleanSerializer.SerializeFhirBoolean(value.ActiveElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeContactComponent(Hl7.Fhir.Model.Patient.ContactComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element relationship
            if(value.Relationship != null && value.Relationship.Count > 0)
            {
                writer.WriteStartArrayElement("relationship");
                foreach(var item in value.Relationship)
                {
                    writer.WriteStartArrayMember("relationship");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                HumanNameSerializer.SerializeHumanName(value.Name, writer, summary);
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
            
            // Serialize element address
            if(value.Address != null)
            {
                writer.WriteStartElement("address");
                AddressSerializer.SerializeAddress(value.Address, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element gender
            if(value.Gender != null)
            {
                writer.WriteStartElement("gender");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Gender, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element organization
            if(value.Organization != null)
            {
                writer.WriteStartElement("organization");
                ResourceReferenceSerializer.SerializeResourceReference(value.Organization, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeAnimalComponent(Hl7.Fhir.Model.Patient.AnimalComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element species
            if(value.Species != null)
            {
                writer.WriteStartElement("species");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Species, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element breed
            if(value.Breed != null)
            {
                writer.WriteStartElement("breed");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Breed, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element genderStatus
            if(value.GenderStatus != null)
            {
                writer.WriteStartElement("genderStatus");
                CodeableConceptSerializer.SerializeCodeableConcept(value.GenderStatus, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
