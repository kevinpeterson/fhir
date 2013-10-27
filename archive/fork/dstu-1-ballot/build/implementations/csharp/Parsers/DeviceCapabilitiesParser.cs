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

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for DeviceCapabilities instances
    /// </summary>
    internal static partial class DeviceCapabilitiesParser
    {
        /// <summary>
        /// Parse DeviceCapabilities
        /// </summary>
        public static Hl7.Fhir.Model.DeviceCapabilities ParseDeviceCapabilities(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DeviceCapabilities existingInstance = null )
        {
            Hl7.Fhir.Model.DeviceCapabilities result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DeviceCapabilities();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element language
                else if( atName == "language" )
                    result.LanguageElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element text
                else if( atName == "text" )
                    result.Text = NarrativeParser.ParseNarrative(reader, errors);
                
                // Parse element contained
                else if( atName == "contained" )
                {
                    result.Contained = new List<Hl7.Fhir.Model.Resource>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "contained") )
                        result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element name
                else if( atName == "name" )
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element manufacturer
                else if( atName == "manufacturer" )
                    result.ManufacturerElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element identity
                else if( atName == "identity" )
                    result.Identity = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element virtualDevice
                else if( atName == "virtualDevice" )
                {
                    result.VirtualDevice = new List<Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "virtualDevice") )
                        result.VirtualDevice.Add(DeviceCapabilitiesParser.ParseDeviceCapabilitiesVirtualDeviceComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse DeviceCapabilitiesVirtualDeviceChannelMetricComponent
        /// </summary>
        public static Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricComponent ParseDeviceCapabilitiesVirtualDeviceChannelMetricComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element code
                else if( atName == "code" )
                    result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element key
                else if( atName == "key" )
                    result.KeyElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element info
                else if( atName == "info" )
                    result.Info = DeviceCapabilitiesParser.ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent(reader, errors);
                
                // Parse element facet
                else if( atName == "facet" )
                {
                    result.Facet = new List<Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "facet") )
                        result.Facet.Add(DeviceCapabilitiesParser.ParseDeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse DeviceCapabilitiesVirtualDeviceComponent
        /// </summary>
        public static Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceComponent ParseDeviceCapabilitiesVirtualDeviceComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element code
                else if( atName == "code" )
                    result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element channel
                else if( atName == "channel" )
                {
                    result.Channel = new List<Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "channel") )
                        result.Channel.Add(DeviceCapabilitiesParser.ParseDeviceCapabilitiesVirtualDeviceChannelComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse DeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent
        /// </summary>
        public static Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element type
                else if( atName == "type" )
                    result.TypeElement = CodeParser.ParseCode<Hl7.Fhir.Model.DeviceCapabilities.DeviceDataType>(reader, errors);
                
                // Parse element units
                else if( atName == "units" )
                    result.UnitsElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element ucum
                else if( atName == "ucum" )
                    result.UcumElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element template
                else if( atName == "template" )
                    result.Template = SampledDataParser.ParseSampledData(reader, errors);
                
                // Parse element system
                else if( atName == "system" )
                    result.SystemElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse DeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent
        /// </summary>
        public static Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent ParseDeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element code
                else if( atName == "code" )
                    result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element scale
                else if( atName == "scale" )
                    result.ScaleElement = FhirDecimalParser.ParseFhirDecimal(reader, errors);
                
                // Parse element key
                else if( atName == "key" )
                    result.KeyElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element info
                else if( atName == "info" )
                    result.Info = DeviceCapabilitiesParser.ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse DeviceCapabilitiesVirtualDeviceChannelComponent
        /// </summary>
        public static Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelComponent ParseDeviceCapabilitiesVirtualDeviceChannelComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element code
                else if( atName == "code" )
                    result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element metric
                else if( atName == "metric" )
                {
                    result.Metric = new List<Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "metric") )
                        result.Metric.Add(DeviceCapabilitiesParser.ParseDeviceCapabilitiesVirtualDeviceChannelMetricComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
    }
}
