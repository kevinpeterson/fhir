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
    * Serializer for DeviceCapabilities instances
    */
    internal static partial class DeviceCapabilitiesSerializer
    {
        public static void SerializeDeviceCapabilities(Hl7.Fhir.Model.DeviceCapabilities value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("DeviceCapabilities");
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
            
            // Serialize element identity
            if(value.Identity != null && !summary)
            {
                writer.WriteStartElement("identity");
                ResourceReferenceSerializer.SerializeResourceReference(value.Identity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element virtualDevice
            if(value.VirtualDevice != null && !summary && value.VirtualDevice.Count > 0)
            {
                writer.WriteStartArrayElement("virtualDevice");
                foreach(var item in value.VirtualDevice)
                {
                    writer.WriteStartArrayMember("virtualDevice");
                    DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesVirtualDeviceComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeDeviceCapabilitiesVirtualDeviceChannelMetricComponent(Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricComponent value, IFhirWriter writer, bool summary)
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
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element key
            if(value.KeyElement != null)
            {
                writer.WriteStartElement("key");
                FhirStringSerializer.SerializeFhirString(value.KeyElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element info
            if(value.Info != null)
            {
                writer.WriteStartElement("info");
                DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent(value.Info, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element facet
            if(value.Facet != null && value.Facet.Count > 0)
            {
                writer.WriteStartArrayElement("facet");
                foreach(var item in value.Facet)
                {
                    writer.WriteStartArrayMember("facet");
                    DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDeviceCapabilitiesVirtualDeviceComponent(Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceComponent value, IFhirWriter writer, bool summary)
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
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element channel
            if(value.Channel != null && value.Channel.Count > 0)
            {
                writer.WriteStartArrayElement("channel");
                foreach(var item in value.Channel)
                {
                    writer.WriteStartArrayMember("channel");
                    DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesVirtualDeviceChannelComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent(Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent value, IFhirWriter writer, bool summary)
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
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.DeviceCapabilities.DeviceDataType>(value.TypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element units
            if(value.UnitsElement != null)
            {
                writer.WriteStartElement("units");
                FhirStringSerializer.SerializeFhirString(value.UnitsElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element ucum
            if(value.UcumElement != null)
            {
                writer.WriteStartElement("ucum");
                CodeSerializer.SerializeCode(value.UcumElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element template
            if(value.Template != null)
            {
                writer.WriteStartElement("template");
                SampledDataSerializer.SerializeSampledData(value.Template, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element system
            if(value.SystemElement != null)
            {
                writer.WriteStartElement("system");
                FhirUriSerializer.SerializeFhirUri(value.SystemElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent(Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent value, IFhirWriter writer, bool summary)
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
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element scale
            if(value.ScaleElement != null)
            {
                writer.WriteStartElement("scale");
                FhirDecimalSerializer.SerializeFhirDecimal(value.ScaleElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element key
            if(value.KeyElement != null)
            {
                writer.WriteStartElement("key");
                FhirStringSerializer.SerializeFhirString(value.KeyElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element info
            if(value.Info != null)
            {
                writer.WriteStartElement("info");
                DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent(value.Info, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDeviceCapabilitiesVirtualDeviceChannelComponent(Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelComponent value, IFhirWriter writer, bool summary)
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
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element metric
            if(value.Metric != null && value.Metric.Count > 0)
            {
                writer.WriteStartArrayElement("metric");
                foreach(var item in value.Metric)
                {
                    writer.WriteStartArrayMember("metric");
                    DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesVirtualDeviceChannelMetricComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
