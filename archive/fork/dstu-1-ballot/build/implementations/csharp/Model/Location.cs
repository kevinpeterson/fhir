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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Contact details and position information for a physical place
    /// </summary>
    [FhirResource("Location")]
    [Serializable]
    public partial class Location : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("LocationPositionComponent")]
        [Serializable]
        public partial class LocationPositionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Longitude
            /// </summary>
            public Hl7.Fhir.Model.FhirDecimal LongitudeElement { get; set; }
            
            public decimal? Longitude
            {
                get { return LongitudeElement != null ? LongitudeElement.Value : null; }
                set
                {
                    if(value == null)
                      LongitudeElement = null; 
                    else
                      LongitudeElement = new Hl7.Fhir.Model.FhirDecimal(value);
                }
            }
            
            /// <summary>
            /// Latitude
            /// </summary>
            public Hl7.Fhir.Model.FhirDecimal LatitudeElement { get; set; }
            
            public decimal? Latitude
            {
                get { return LatitudeElement != null ? LatitudeElement.Value : null; }
                set
                {
                    if(value == null)
                      LatitudeElement = null; 
                    else
                      LatitudeElement = new Hl7.Fhir.Model.FhirDecimal(value);
                }
            }
            
            /// <summary>
            /// Altitude
            /// </summary>
            public Hl7.Fhir.Model.FhirDecimal AltitudeElement { get; set; }
            
            public decimal? Altitude
            {
                get { return AltitudeElement != null ? AltitudeElement.Value : null; }
                set
                {
                    if(value == null)
                      AltitudeElement = null; 
                    else
                      AltitudeElement = new Hl7.Fhir.Model.FhirDecimal(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(LongitudeElement != null )
                    result.AddRange(LongitudeElement.Validate());
                if(LatitudeElement != null )
                    result.AddRange(LatitudeElement.Validate());
                if(AltitudeElement != null )
                    result.AddRange(AltitudeElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Name of the location
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
        /// Description of the Location
        /// </summary>
        public Hl7.Fhir.Model.FhirString DescriptionElement { get; set; }
        
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Classification of the location
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> Type { get; set; }
        
        /// <summary>
        /// Contact details of the location
        /// </summary>
        public Hl7.Fhir.Model.Contact Telecom { get; set; }
        
        /// <summary>
        /// Physical location
        /// </summary>
        public Hl7.Fhir.Model.Address Address { get; set; }
        
        /// <summary>
        /// The absolute geographic location
        /// </summary>
        public Hl7.Fhir.Model.Location.LocationPositionComponent Position { get; set; }
        
        /// <summary>
        /// The organization that provides services at the location
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Provider { get; set; }
        
        /// <summary>
        /// Whether the location is still used to provide services
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean ActiveElement { get; set; }
        
        public bool? Active
        {
            get { return ActiveElement != null ? ActiveElement.Value : null; }
            set
            {
                if(value == null)
                  ActiveElement = null; 
                else
                  ActiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        /// <summary>
        /// Another Location which this Location is physically inside of
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference PartOf { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(NameElement != null )
                result.AddRange(NameElement.Validate());
            if(DescriptionElement != null )
                result.AddRange(DescriptionElement.Validate());
            if(Type != null )
                Type.ForEach(elem => result.AddRange(elem.Validate()));
            if(Telecom != null )
                result.AddRange(Telecom.Validate());
            if(Address != null )
                result.AddRange(Address.Validate());
            if(Position != null )
                result.AddRange(Position.Validate());
            if(Provider != null )
                result.AddRange(Provider.Validate());
            if(ActiveElement != null )
                result.AddRange(ActiveElement.Validate());
            if(PartOf != null )
                result.AddRange(PartOf.Validate());
            
            return result;
        }
    }
    
}
