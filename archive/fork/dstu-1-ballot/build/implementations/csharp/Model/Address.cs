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
    /// A postal address
    /// </summary>
    [FhirComposite("Address")]
    [Serializable]
    public partial class Address : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// The use of an address
        /// </summary>
        public enum AddressUse
        {
            Home, // A communication address at a home.
            Work, // An office address. First choice for business related contacts during business hours.
            Temp, // A temporary address. The period can provide more detailed information.
            Old, // This address is no longer in use (or was never correct, but retained for records).
        }
        
        /// <summary>
        /// Conversion of AddressUsefrom and into string
        /// <summary>
        public static class AddressUseHandling
        {
            public static bool TryParse(string value, out AddressUse result)
            {
                result = default(AddressUse);
                
                if( value=="home")
                    result = AddressUse.Home;
                else if( value=="work")
                    result = AddressUse.Work;
                else if( value=="temp")
                    result = AddressUse.Temp;
                else if( value=="old")
                    result = AddressUse.Old;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(AddressUse value)
            {
                if( value==AddressUse.Home )
                    return "home";
                else if( value==AddressUse.Work )
                    return "work";
                else if( value==AddressUse.Temp )
                    return "temp";
                else if( value==AddressUse.Old )
                    return "old";
                else
                    throw new ArgumentException("Unrecognized AddressUse value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The use of this address
        /// </summary>
        public Code<Hl7.Fhir.Model.Address.AddressUse> UseElement { get; set; }
        
        public Hl7.Fhir.Model.Address.AddressUse? Use
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if(value == null)
                  UseElement = null; 
                else
                  UseElement = new Code<Hl7.Fhir.Model.Address.AddressUse>(value);
            }
        }
        
        /// <summary>
        /// Text representation of the address
        /// </summary>
        public Hl7.Fhir.Model.FhirString TextElement { get; set; }
        
        public string Text
        {
            get { return TextElement != null ? TextElement.Value : null; }
            set
            {
                if(value == null)
                  TextElement = null; 
                else
                  TextElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Line of an address
        /// </summary>
        public List<Hl7.Fhir.Model.FhirString> LineElement { get; set; }
        
        public IEnumerable<string> Line
        {
            get { return LineElement != null ? LineElement.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  LineElement = null; 
                else
                  LineElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
            }
        }
        
        /// <summary>
        /// Name of city, town etc.
        /// </summary>
        public Hl7.Fhir.Model.FhirString CityElement { get; set; }
        
        public string City
        {
            get { return CityElement != null ? CityElement.Value : null; }
            set
            {
                if(value == null)
                  CityElement = null; 
                else
                  CityElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Sub-unit of country (abreviations ok)
        /// </summary>
        public Hl7.Fhir.Model.FhirString StateElement { get; set; }
        
        public string State
        {
            get { return StateElement != null ? StateElement.Value : null; }
            set
            {
                if(value == null)
                  StateElement = null; 
                else
                  StateElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Post code for area
        /// </summary>
        public Hl7.Fhir.Model.FhirString ZipElement { get; set; }
        
        public string Zip
        {
            get { return ZipElement != null ? ZipElement.Value : null; }
            set
            {
                if(value == null)
                  ZipElement = null; 
                else
                  ZipElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Country (can be ISO 3166 3 letter code)
        /// </summary>
        public Hl7.Fhir.Model.FhirString CountryElement { get; set; }
        
        public string Country
        {
            get { return CountryElement != null ? CountryElement.Value : null; }
            set
            {
                if(value == null)
                  CountryElement = null; 
                else
                  CountryElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Time period when address was/is in use
        /// </summary>
        public Hl7.Fhir.Model.Period Period { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(UseElement != null )
                result.AddRange(UseElement.Validate());
            if(TextElement != null )
                result.AddRange(TextElement.Validate());
            if(LineElement != null )
                LineElement.ForEach(elem => result.AddRange(elem.Validate()));
            if(CityElement != null )
                result.AddRange(CityElement.Validate());
            if(StateElement != null )
                result.AddRange(StateElement.Validate());
            if(ZipElement != null )
                result.AddRange(ZipElement.Validate());
            if(CountryElement != null )
                result.AddRange(CountryElement.Validate());
            if(Period != null )
                result.AddRange(Period.Validate());
            
            return result;
        }
    }
    
}
