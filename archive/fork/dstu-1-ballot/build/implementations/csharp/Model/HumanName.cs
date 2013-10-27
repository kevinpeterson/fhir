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
    /// Name of a human
    /// </summary>
    [FhirComposite("HumanName")]
    [Serializable]
    public partial class HumanName : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// The use of a human name
        /// </summary>
        public enum NameUse
        {
            Usual, // Known as/conventional/the one you normally use.
            Official, // The formal name as registered in an official (government) registry, but which name might not be commonly used. May be called "legal name".
            Temp, // A temporary name. Name.period can provide more detailed information. This may also be used for temporary names assigned at birth or in emergency situations.
            Nickname, // A name that is used to address the person in an informal manner, but is not part of their formal or usual name.
            Anonymous, // Anonymous assigned name, alias, or pseudonym (used to protect a person's identity for privacy reasons).
            Old, // This name is no longer in use (or was never correct, but retained for records).
            Maiden, // A name used prior to marriage. Marriage naming customs vary greatly around the world. This name use is for use by applications that collect and store "maiden" names. Though the concept of maiden name is often gender specific, the use of this term is not gender specific. The use of this term does not imply any particular history for a person's name, nor should the maiden name be determined algorithmically.
        }
        
        /// <summary>
        /// Conversion of NameUsefrom and into string
        /// <summary>
        public static class NameUseHandling
        {
            public static bool TryParse(string value, out NameUse result)
            {
                result = default(NameUse);
                
                if( value=="usual")
                    result = NameUse.Usual;
                else if( value=="official")
                    result = NameUse.Official;
                else if( value=="temp")
                    result = NameUse.Temp;
                else if( value=="nickname")
                    result = NameUse.Nickname;
                else if( value=="anonymous")
                    result = NameUse.Anonymous;
                else if( value=="old")
                    result = NameUse.Old;
                else if( value=="maiden")
                    result = NameUse.Maiden;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(NameUse value)
            {
                if( value==NameUse.Usual )
                    return "usual";
                else if( value==NameUse.Official )
                    return "official";
                else if( value==NameUse.Temp )
                    return "temp";
                else if( value==NameUse.Nickname )
                    return "nickname";
                else if( value==NameUse.Anonymous )
                    return "anonymous";
                else if( value==NameUse.Old )
                    return "old";
                else if( value==NameUse.Maiden )
                    return "maiden";
                else
                    throw new ArgumentException("Unrecognized NameUse value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The use of this name
        /// </summary>
        public Code<Hl7.Fhir.Model.HumanName.NameUse> UseElement { get; set; }
        
        public Hl7.Fhir.Model.HumanName.NameUse? Use
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if(value == null)
                  UseElement = null; 
                else
                  UseElement = new Code<Hl7.Fhir.Model.HumanName.NameUse>(value);
            }
        }
        
        /// <summary>
        /// Text representation of the full name
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
        /// Family name (often called 'Surname')
        /// </summary>
        public List<Hl7.Fhir.Model.FhirString> FamilyElement { get; set; }
        
        public IEnumerable<string> Family
        {
            get { return FamilyElement != null ? FamilyElement.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  FamilyElement = null; 
                else
                  FamilyElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
            }
        }
        
        /// <summary>
        /// Given names (not always 'first'). Includes middle names
        /// </summary>
        public List<Hl7.Fhir.Model.FhirString> GivenElement { get; set; }
        
        public IEnumerable<string> Given
        {
            get { return GivenElement != null ? GivenElement.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  GivenElement = null; 
                else
                  GivenElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
            }
        }
        
        /// <summary>
        /// Parts that come before the name
        /// </summary>
        public List<Hl7.Fhir.Model.FhirString> PrefixElement { get; set; }
        
        public IEnumerable<string> Prefix
        {
            get { return PrefixElement != null ? PrefixElement.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  PrefixElement = null; 
                else
                  PrefixElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
            }
        }
        
        /// <summary>
        /// Parts that come after the name
        /// </summary>
        public List<Hl7.Fhir.Model.FhirString> SuffixElement { get; set; }
        
        public IEnumerable<string> Suffix
        {
            get { return SuffixElement != null ? SuffixElement.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  SuffixElement = null; 
                else
                  SuffixElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
            }
        }
        
        /// <summary>
        /// Time period when name was/is in use
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
            if(FamilyElement != null )
                FamilyElement.ForEach(elem => result.AddRange(elem.Validate()));
            if(GivenElement != null )
                GivenElement.ForEach(elem => result.AddRange(elem.Validate()));
            if(PrefixElement != null )
                PrefixElement.ForEach(elem => result.AddRange(elem.Validate()));
            if(SuffixElement != null )
                SuffixElement.ForEach(elem => result.AddRange(elem.Validate()));
            if(Period != null )
                result.AddRange(Period.Validate());
            
            return result;
        }
    }
    
}
