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
    * Serializer for Device instances
    */
    internal static partial class DeviceSerializer
    {
        public static void SerializeDevice(Hl7.Fhir.Model.Device value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Device");
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
            
            // Serialize element type
            if(value.Type != null && !summary)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element manufacturer
            if(value.ManufacturerElement != null && !summary)
            {
                writer.WriteStartElement("manufacturer");
                FhirStringSerializer.SerializeFhirString(value.ManufacturerElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element model
            if(value.ModelElement != null && !summary)
            {
                writer.WriteStartElement("model");
                FhirStringSerializer.SerializeFhirString(value.ModelElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element version
            if(value.VersionElement != null && !summary)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.VersionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element expiry
            if(value.ExpiryElement != null && !summary)
            {
                writer.WriteStartElement("expiry");
                DateSerializer.SerializeDate(value.ExpiryElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element identity
            if(value.Identity != null && !summary)
            {
                writer.WriteStartElement("identity");
                DeviceSerializer.SerializeDeviceIdentityComponent(value.Identity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element owner
            if(value.Owner != null && !summary)
            {
                writer.WriteStartElement("owner");
                ResourceReferenceSerializer.SerializeResourceReference(value.Owner, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element assignedId
            if(value.AssignedId != null && !summary && value.AssignedId.Count > 0)
            {
                writer.WriteStartArrayElement("assignedId");
                foreach(var item in value.AssignedId)
                {
                    writer.WriteStartArrayMember("assignedId");
                    IdentifierSerializer.SerializeIdentifier(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element location
            if(value.Location != null && !summary)
            {
                writer.WriteStartElement("location");
                ResourceReferenceSerializer.SerializeResourceReference(value.Location, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element patient
            if(value.Patient != null && !summary)
            {
                writer.WriteStartElement("patient");
                ResourceReferenceSerializer.SerializeResourceReference(value.Patient, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element contact
            if(value.Contact != null && !summary && value.Contact.Count > 0)
            {
                writer.WriteStartArrayElement("contact");
                foreach(var item in value.Contact)
                {
                    writer.WriteStartArrayMember("contact");
                    ContactSerializer.SerializeContact(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element url
            if(value.UrlElement != null && !summary)
            {
                writer.WriteStartElement("url");
                FhirUriSerializer.SerializeFhirUri(value.UrlElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeDeviceIdentityComponent(Hl7.Fhir.Model.Device.DeviceIdentityComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element gtin
            if(value.GtinElement != null)
            {
                writer.WriteStartElement("gtin");
                FhirStringSerializer.SerializeFhirString(value.GtinElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element lot
            if(value.LotElement != null)
            {
                writer.WriteStartElement("lot");
                FhirStringSerializer.SerializeFhirString(value.LotElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element serialNumber
            if(value.SerialNumberElement != null)
            {
                writer.WriteStartElement("serialNumber");
                FhirStringSerializer.SerializeFhirString(value.SerialNumberElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
