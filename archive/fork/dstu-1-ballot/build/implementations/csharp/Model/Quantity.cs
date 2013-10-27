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
    /// A measured or measurable amount
    /// </summary>
    [FhirComposite("Quantity")]
    [Serializable]
    public partial class Quantity : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// How the Quantity should be understood and represented
        /// </summary>
        public enum QuantityCompararator
        {
            LessThan, // The actual value is less than the given value.
            LessOrEqual, // The actual value is less than or equal to the given value.
            GreaterOrEqual, // The actual value is greater than or equal to the given value.
            GreaterThan, // The actual value is greater than the given value.
        }
        
        /// <summary>
        /// Conversion of QuantityCompararatorfrom and into string
        /// <summary>
        public static class QuantityCompararatorHandling
        {
            public static bool TryParse(string value, out QuantityCompararator result)
            {
                result = default(QuantityCompararator);
                
                if( value=="<")
                    result = QuantityCompararator.LessThan;
                else if( value=="<=")
                    result = QuantityCompararator.LessOrEqual;
                else if( value==">=")
                    result = QuantityCompararator.GreaterOrEqual;
                else if( value==">")
                    result = QuantityCompararator.GreaterThan;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(QuantityCompararator value)
            {
                if( value==QuantityCompararator.LessThan )
                    return "<";
                else if( value==QuantityCompararator.LessOrEqual )
                    return "<=";
                else if( value==QuantityCompararator.GreaterOrEqual )
                    return ">=";
                else if( value==QuantityCompararator.GreaterThan )
                    return ">";
                else
                    throw new ArgumentException("Unrecognized QuantityCompararator value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Numerical value (with implicit precision)
        /// </summary>
        public Hl7.Fhir.Model.FhirDecimal ValueElement { get; set; }
        
        public decimal? Value
        {
            get { return ValueElement != null ? ValueElement.Value : null; }
            set
            {
                if(value == null)
                  ValueElement = null; 
                else
                  ValueElement = new Hl7.Fhir.Model.FhirDecimal(value);
            }
        }
        
        /// <summary>
        /// Relationship of stated value to actual value
        /// </summary>
        public Code<Hl7.Fhir.Model.Quantity.QuantityCompararator> ComparatorElement { get; set; }
        
        public Hl7.Fhir.Model.Quantity.QuantityCompararator? Comparator
        {
            get { return ComparatorElement != null ? ComparatorElement.Value : null; }
            set
            {
                if(value == null)
                  ComparatorElement = null; 
                else
                  ComparatorElement = new Code<Hl7.Fhir.Model.Quantity.QuantityCompararator>(value);
            }
        }
        
        /// <summary>
        /// Unit representation
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
        /// System that defines coded unit form
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
        
        /// <summary>
        /// Coded form of the unit
        /// </summary>
        public Hl7.Fhir.Model.Code CodeElement { get; set; }
        
        public string Code
        {
            get { return CodeElement != null ? CodeElement.Value : null; }
            set
            {
                if(value == null)
                  CodeElement = null; 
                else
                  CodeElement = new Hl7.Fhir.Model.Code(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(ValueElement != null )
                result.AddRange(ValueElement.Validate());
            if(ComparatorElement != null )
                result.AddRange(ComparatorElement.Validate());
            if(UnitsElement != null )
                result.AddRange(UnitsElement.Validate());
            if(SystemElement != null )
                result.AddRange(SystemElement.Validate());
            if(CodeElement != null )
                result.AddRange(CodeElement.Validate());
            
            return result;
        }
    }
    
}
