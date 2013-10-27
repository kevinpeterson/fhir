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
    /// An identifier intended for computation
    /// </summary>
    [FhirComposite("Identifier")]
    [Serializable]
    public partial class Identifier : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// Identifies the use for this identifier, if known
        /// </summary>
        public enum IdentifierUse
        {
            Usual, // the identifier recommended for display and use in real-world interactions.
            Official, // the identifier considered to be most trusted for the identification of this item.
            Temp, // A temporary identifier.
        }
        
        /// <summary>
        /// Conversion of IdentifierUsefrom and into string
        /// <summary>
        public static class IdentifierUseHandling
        {
            public static bool TryParse(string value, out IdentifierUse result)
            {
                result = default(IdentifierUse);
                
                if( value=="usual")
                    result = IdentifierUse.Usual;
                else if( value=="official")
                    result = IdentifierUse.Official;
                else if( value=="temp")
                    result = IdentifierUse.Temp;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(IdentifierUse value)
            {
                if( value==IdentifierUse.Usual )
                    return "usual";
                else if( value==IdentifierUse.Official )
                    return "official";
                else if( value==IdentifierUse.Temp )
                    return "temp";
                else
                    throw new ArgumentException("Unrecognized IdentifierUse value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The use of this identifier
        /// </summary>
        public Code<Hl7.Fhir.Model.Identifier.IdentifierUse> UseElement { get; set; }
        
        public Hl7.Fhir.Model.Identifier.IdentifierUse? Use
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if(value == null)
                  UseElement = null; 
                else
                  UseElement = new Code<Hl7.Fhir.Model.Identifier.IdentifierUse>(value);
            }
        }
        
        /// <summary>
        /// Description of identifier
        /// </summary>
        public Hl7.Fhir.Model.FhirString LabelElement { get; set; }
        
        public string Label
        {
            get { return LabelElement != null ? LabelElement.Value : null; }
            set
            {
                if(value == null)
                  LabelElement = null; 
                else
                  LabelElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// The namespace for the identifier
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
        /// The value that is unique
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
        /// Time period when id was valid for use
        /// </summary>
        public Hl7.Fhir.Model.Period Period { get; set; }
        
        /// <summary>
        /// Organization that issued id (may be just text)
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Assigner { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(UseElement != null )
                result.AddRange(UseElement.Validate());
            if(LabelElement != null )
                result.AddRange(LabelElement.Validate());
            if(SystemElement != null )
                result.AddRange(SystemElement.Validate());
            if(KeyElement != null )
                result.AddRange(KeyElement.Validate());
            if(Period != null )
                result.AddRange(Period.Validate());
            if(Assigner != null )
                result.AddRange(Assigner.Validate());
            
            return result;
        }
    }
    
}
