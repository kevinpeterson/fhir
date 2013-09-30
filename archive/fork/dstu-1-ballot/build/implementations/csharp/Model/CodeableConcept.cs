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
    /// Concept - reference to a terminology or just  text
    /// </summary>
    [FhirComposite("CodeableConcept")]
    [Serializable]
    public partial class CodeableConcept : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// Code defined by a terminology system
        /// </summary>
        public List<Hl7.Fhir.Model.Coding> Coding { get; set; }
        
        /// <summary>
        /// Plain text representation of the concept
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
        /// Which code was chosen directly by the user
        /// </summary>
        public Hl7.Fhir.Model.IdRef PrimaryElement { get; set; }
        
        public string Primary
        {
            get { return PrimaryElement != null ? PrimaryElement.Value : null; }
            set
            {
                if(value == null)
                  PrimaryElement = null; 
                else
                  PrimaryElement = new Hl7.Fhir.Model.IdRef(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Coding != null )
                Coding.ForEach(elem => result.AddRange(elem.Validate()));
            if(TextElement != null )
                result.AddRange(TextElement.Validate());
            if(PrimaryElement != null )
                result.AddRange(PrimaryElement.Validate());
            
            return result;
        }
    }
    
}
