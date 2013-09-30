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
    * Serializer for Location instances
    */
    internal static partial class LocationSerializer
    {
        public static void SerializeLocation(Hl7.Fhir.Model.Location value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Location");
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
            
            // Serialize element name
            if(value.NameElement != null && !summary)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.DescriptionElement != null && !summary)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null && !summary && value.Type.Count > 0)
            {
                writer.WriteStartArrayElement("type");
                foreach(var item in value.Type)
                {
                    writer.WriteStartArrayMember("type");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element telecom
            if(value.Telecom != null && !summary)
            {
                writer.WriteStartElement("telecom");
                ContactSerializer.SerializeContact(value.Telecom, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element address
            if(value.Address != null && !summary)
            {
                writer.WriteStartElement("address");
                AddressSerializer.SerializeAddress(value.Address, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element position
            if(value.Position != null && !summary)
            {
                writer.WriteStartElement("position");
                LocationSerializer.SerializeLocationPositionComponent(value.Position, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element provider
            if(value.Provider != null && !summary)
            {
                writer.WriteStartElement("provider");
                ResourceReferenceSerializer.SerializeResourceReference(value.Provider, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element active
            if(value.ActiveElement != null && !summary)
            {
                writer.WriteStartElement("active");
                FhirBooleanSerializer.SerializeFhirBoolean(value.ActiveElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element partOf
            if(value.PartOf != null && !summary)
            {
                writer.WriteStartElement("partOf");
                ResourceReferenceSerializer.SerializeResourceReference(value.PartOf, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeLocationPositionComponent(Hl7.Fhir.Model.Location.LocationPositionComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element longitude
            if(value.LongitudeElement != null)
            {
                writer.WriteStartElement("longitude");
                FhirDecimalSerializer.SerializeFhirDecimal(value.LongitudeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element latitude
            if(value.LatitudeElement != null)
            {
                writer.WriteStartElement("latitude");
                FhirDecimalSerializer.SerializeFhirDecimal(value.LatitudeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element altitude
            if(value.AltitudeElement != null)
            {
                writer.WriteStartElement("altitude");
                FhirDecimalSerializer.SerializeFhirDecimal(value.AltitudeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
