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
    /// An instance of a manufactured thing that is used in the provision of healthcare
    /// </summary>
    [FhirResource("Device")]
    [Serializable]
    public partial class Device : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceIdentityComponent")]
        [Serializable]
        public partial class DeviceIdentityComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Global Trade Identification Number
            /// </summary>
            public Hl7.Fhir.Model.FhirString GtinElement { get; set; }
            
            public string Gtin
            {
                get { return GtinElement != null ? GtinElement.Value : null; }
                set
                {
                    if(value == null)
                      GtinElement = null; 
                    else
                      GtinElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Lot number of manufacture
            /// </summary>
            public Hl7.Fhir.Model.FhirString LotElement { get; set; }
            
            public string Lot
            {
                get { return LotElement != null ? LotElement.Value : null; }
                set
                {
                    if(value == null)
                      LotElement = null; 
                    else
                      LotElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Serial number assigned by the manufacturer
            /// </summary>
            public Hl7.Fhir.Model.FhirString SerialNumberElement { get; set; }
            
            public string SerialNumber
            {
                get { return SerialNumberElement != null ? SerialNumberElement.Value : null; }
                set
                {
                    if(value == null)
                      SerialNumberElement = null; 
                    else
                      SerialNumberElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(GtinElement != null )
                    result.AddRange(GtinElement.Validate());
                if(LotElement != null )
                    result.AddRange(LotElement.Validate());
                if(SerialNumberElement != null )
                    result.AddRange(SerialNumberElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// What kind of device this is
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
        
        /// <summary>
        /// Name of device manufacturer
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
        /// Model id assigned by the manufacturer
        /// </summary>
        public Hl7.Fhir.Model.FhirString ModelElement { get; set; }
        
        public string Model
        {
            get { return ModelElement != null ? ModelElement.Value : null; }
            set
            {
                if(value == null)
                  ModelElement = null; 
                else
                  ModelElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Version number (i.e. software)
        /// </summary>
        public Hl7.Fhir.Model.FhirString VersionElement { get; set; }
        
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if(value == null)
                  VersionElement = null; 
                else
                  VersionElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Date of expiry of this device (if applicable)
        /// </summary>
        public Hl7.Fhir.Model.Date ExpiryElement { get; set; }
        
        public string Expiry
        {
            get { return ExpiryElement != null ? ExpiryElement.Value : null; }
            set
            {
                if(value == null)
                  ExpiryElement = null; 
                else
                  ExpiryElement = new Hl7.Fhir.Model.Date(value);
            }
        }
        
        /// <summary>
        /// Universal Device Id fields
        /// </summary>
        public Hl7.Fhir.Model.Device.DeviceIdentityComponent Identity { get; set; }
        
        /// <summary>
        /// Organization responsible for device
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Owner { get; set; }
        
        /// <summary>
        /// Identifier assigned by various organizations
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> AssignedId { get; set; }
        
        /// <summary>
        /// Where the resource is found
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Location { get; set; }
        
        /// <summary>
        /// If the resource is affixed to a person
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Patient { get; set; }
        
        /// <summary>
        /// Details for human/organization for support
        /// </summary>
        public List<Hl7.Fhir.Model.Contact> Contact { get; set; }
        
        /// <summary>
        /// Network address to contact device
        /// </summary>
        public Hl7.Fhir.Model.FhirUri UrlElement { get; set; }
        
        public System.Uri Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if(value == null)
                  UrlElement = null; 
                else
                  UrlElement = new Hl7.Fhir.Model.FhirUri(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Type != null )
                result.AddRange(Type.Validate());
            if(ManufacturerElement != null )
                result.AddRange(ManufacturerElement.Validate());
            if(ModelElement != null )
                result.AddRange(ModelElement.Validate());
            if(VersionElement != null )
                result.AddRange(VersionElement.Validate());
            if(ExpiryElement != null )
                result.AddRange(ExpiryElement.Validate());
            if(Identity != null )
                result.AddRange(Identity.Validate());
            if(Owner != null )
                result.AddRange(Owner.Validate());
            if(AssignedId != null )
                AssignedId.ForEach(elem => result.AddRange(elem.Validate()));
            if(Location != null )
                result.AddRange(Location.Validate());
            if(Patient != null )
                result.AddRange(Patient.Validate());
            if(Contact != null )
                Contact.ForEach(elem => result.AddRange(elem.Validate()));
            if(UrlElement != null )
                result.AddRange(UrlElement.Validate());
            
            return result;
        }
    }
    
}
