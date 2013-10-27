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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Describes the set of data produced by a device
    /// </summary>
    [FhirResource("DeviceCapabilities")]
    [Serializable]
    public partial class DeviceCapabilities : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The type of data produced by a device
        /// </summary>
        public enum DeviceDataType
        {
            Quantity, // The data item is a quantity. The string value should be merged with the units, and the ucum value if provided, to create a valid quantity.
            Range, // The data item is a range. The string value should be split about the " - " into low and high, with the units and ucum (if provided) filling out the low and high quantities.
            Coding, // The data item is a code (i.e. true/false etc). The value should be built into a valid coding by filling out the system element provided.
            Array, // The data item is an Array (a sequence of sample measures, which must be merged with the Array template).
            String, // The data item is a simple string.
        }
        
        /// <summary>
        /// Conversion of DeviceDataTypefrom and into string
        /// <summary>
        public static class DeviceDataTypeHandling
        {
            public static bool TryParse(string value, out DeviceDataType result)
            {
                result = default(DeviceDataType);
                
                if( value=="Quantity")
                    result = DeviceDataType.Quantity;
                else if( value=="Range")
                    result = DeviceDataType.Range;
                else if( value=="Coding")
                    result = DeviceDataType.Coding;
                else if( value=="Array")
                    result = DeviceDataType.Array;
                else if( value=="string")
                    result = DeviceDataType.String;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DeviceDataType value)
            {
                if( value==DeviceDataType.Quantity )
                    return "Quantity";
                else if( value==DeviceDataType.Range )
                    return "Range";
                else if( value==DeviceDataType.Coding )
                    return "Coding";
                else if( value==DeviceDataType.Array )
                    return "Array";
                else if( value==DeviceDataType.String )
                    return "string";
                else
                    throw new ArgumentException("Unrecognized DeviceDataType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceCapabilitiesVirtualDeviceChannelMetricComponent")]
        [Serializable]
        public partial class DeviceCapabilitiesVirtualDeviceChannelMetricComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Describes the metrics
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Used to link to data in device log
            /// </summary>
            public Hl7.Fhir.Model.FhirString KeyElement { get; set; }
            
            public string Key
            {
                get { return KeyElement != null ? KeyElement.Value : null; }
                set
                {
                    if(value == null)
                      KeyElement = null; 
                    else
                      KeyElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// How to interpret this metric value
            /// </summary>
            public Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent Info { get; set; }
            
            /// <summary>
            /// Additional clarifying or qualifiying data
            /// </summary>
            public List<Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent> Facet { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(KeyElement != null )
                    result.AddRange(KeyElement.Validate());
                if(Info != null )
                    result.AddRange(Info.Validate());
                if(Facet != null )
                    Facet.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceCapabilitiesVirtualDeviceComponent")]
        [Serializable]
        public partial class DeviceCapabilitiesVirtualDeviceComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Describes the compartment
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Groups related data items
            /// </summary>
            public List<Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelComponent> Channel { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(Channel != null )
                    Channel.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent")]
        [Serializable]
        public partial class DeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Quantity | Coding | Array | string
            /// </summary>
            public Code<Hl7.Fhir.Model.DeviceCapabilities.DeviceDataType> TypeElement { get; set; }
            
            public Hl7.Fhir.Model.DeviceCapabilities.DeviceDataType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Code<Hl7.Fhir.Model.DeviceCapabilities.DeviceDataType>(value);
                }
            }
            
            /// <summary>
            /// Human Readable units of data value
            /// </summary>
            public Hl7.Fhir.Model.FhirString UnitsElement { get; set; }
            
            public string Units
            {
                get { return UnitsElement != null ? UnitsElement.Value : null; }
                set
                {
                    if(value == null)
                      UnitsElement = null; 
                    else
                      UnitsElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// UCUM units for data value
            /// </summary>
            public Hl7.Fhir.Model.Code UcumElement { get; set; }
            
            public string Ucum
            {
                get { return UcumElement != null ? UcumElement.Value : null; }
                set
                {
                    if(value == null)
                      UcumElement = null; 
                    else
                      UcumElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            /// <summary>
            /// Array template (fixed values)
            /// </summary>
            public Hl7.Fhir.Model.SampledData Template { get; set; }
            
            /// <summary>
            /// System for coding
            /// </summary>
            public Hl7.Fhir.Model.FhirUri SystemElement { get; set; }
            
            public System.Uri System
            {
                get { return SystemElement != null ? SystemElement.Value : null; }
                set
                {
                    if(value == null)
                      SystemElement = null; 
                    else
                      SystemElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                if(UnitsElement != null )
                    result.AddRange(UnitsElement.Validate());
                if(UcumElement != null )
                    result.AddRange(UcumElement.Validate());
                if(Template != null )
                    result.AddRange(Template.Validate());
                if(SystemElement != null )
                    result.AddRange(SystemElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent")]
        [Serializable]
        public partial class DeviceCapabilitiesVirtualDeviceChannelMetricFacetComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Describes the facet
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Factor to apply to raw values (default = 1)
            /// </summary>
            public Hl7.Fhir.Model.FhirDecimal ScaleElement { get; set; }
            
            public decimal? Scale
            {
                get { return ScaleElement != null ? ScaleElement.Value : null; }
                set
                {
                    if(value == null)
                      ScaleElement = null; 
                    else
                      ScaleElement = new Hl7.Fhir.Model.FhirDecimal(value);
                }
            }
            
            /// <summary>
            /// Used to link to data in device log
            /// </summary>
            public Hl7.Fhir.Model.FhirString KeyElement { get; set; }
            
            public string Key
            {
                get { return KeyElement != null ? KeyElement.Value : null; }
                set
                {
                    if(value == null)
                      KeyElement = null; 
                    else
                      KeyElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// How to interpret this facet value
            /// </summary>
            public Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricInfoComponent Info { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(ScaleElement != null )
                    result.AddRange(ScaleElement.Validate());
                if(KeyElement != null )
                    result.AddRange(KeyElement.Validate());
                if(Info != null )
                    result.AddRange(Info.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceCapabilitiesVirtualDeviceChannelComponent")]
        [Serializable]
        public partial class DeviceCapabilitiesVirtualDeviceChannelComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Describes the channel
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Piece of data reported by device
            /// </summary>
            public List<Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceChannelMetricComponent> Metric { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(Metric != null )
                    Metric.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// The name of this device
        /// </summary>
        public Hl7.Fhir.Model.FhirString NameElement { get; set; }
        
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if(value == null)
                  NameElement = null; 
                else
                  NameElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// The type of device
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
        
        /// <summary>
        /// Company that built the device
        /// </summary>
        public Hl7.Fhir.Model.FhirString ManufacturerElement { get; set; }
        
        public string Manufacturer
        {
            get { return ManufacturerElement != null ? ManufacturerElement.Value : null; }
            set
            {
                if(value == null)
                  ManufacturerElement = null; 
                else
                  ManufacturerElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Identifies this particular device uniquely
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Identity { get; set; }
        
        /// <summary>
        /// A medical-related subsystem of a medical device
        /// </summary>
        public List<Hl7.Fhir.Model.DeviceCapabilities.DeviceCapabilitiesVirtualDeviceComponent> VirtualDevice { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(NameElement != null )
                result.AddRange(NameElement.Validate());
            if(Type != null )
                result.AddRange(Type.Validate());
            if(ManufacturerElement != null )
                result.AddRange(ManufacturerElement.Validate());
            if(Identity != null )
                result.AddRange(Identity.Validate());
            if(VirtualDevice != null )
                VirtualDevice.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
