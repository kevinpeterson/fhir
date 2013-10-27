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
    /// Code from list of choices
    /// </summary>
    [FhirComposite("Choice")]
    [Serializable]
    public partial class Choice : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ChoiceOptionComponent")]
        [Serializable]
        public partial class ChoiceOptionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Possible code
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
            
            /// <summary>
            /// Display for the code
            /// </summary>
            public Hl7.Fhir.Model.FhirString DisplayElement { get; set; }
            
            public string Display
            {
                get { return DisplayElement != null ? DisplayElement.Value : null; }
                set
                {
                    if(value == null)
                      DisplayElement = null; 
                    else
                      DisplayElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(CodeElement != null )
                    result.AddRange(CodeElement.Validate());
                if(DisplayElement != null )
                    result.AddRange(DisplayElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Selected code
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
        
        /// <summary>
        /// List of possible code values
        /// </summary>
        public List<Hl7.Fhir.Model.Choice.ChoiceOptionComponent> Option { get; set; }
        
        /// <summary>
        /// If order of the values has meaning
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean IsOrderedElement { get; set; }
        
        public bool? IsOrdered
        {
            get { return IsOrderedElement != null ? IsOrderedElement.Value : null; }
            set
            {
                if(value == null)
                  IsOrderedElement = null; 
                else
                  IsOrderedElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(CodeElement != null )
                result.AddRange(CodeElement.Validate());
            if(Option != null )
                Option.ForEach(elem => result.AddRange(elem.Validate()));
            if(IsOrderedElement != null )
                result.AddRange(IsOrderedElement.Validate());
            
            return result;
        }
    }
    
}
