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
    /// A human readable formatted text, including images
    /// </summary>
    [FhirComposite("Narrative")]
    [Serializable]
    public partial class Narrative : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// The status of a resource narrative
        /// </summary>
        public enum NarrativeStatus
        {
            Generated, // The contents of the narrative are entirely generated from the structured data in the resource.
            Extensions, // The contents of the narrative are entirely generated from the structured data in the resource and some of the content is generated from extensions.
            Additional, // The contents of the narrative contain additional information not found in the structured data.
            Empty, // the contents of the narrative are some equivalent of "No human readable text provided for this resource".
        }
        
        /// <summary>
        /// Conversion of NarrativeStatusfrom and into string
        /// <summary>
        public static class NarrativeStatusHandling
        {
            public static bool TryParse(string value, out NarrativeStatus result)
            {
                result = default(NarrativeStatus);
                
                if( value=="generated")
                    result = NarrativeStatus.Generated;
                else if( value=="extensions")
                    result = NarrativeStatus.Extensions;
                else if( value=="additional")
                    result = NarrativeStatus.Additional;
                else if( value=="empty")
                    result = NarrativeStatus.Empty;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(NarrativeStatus value)
            {
                if( value==NarrativeStatus.Generated )
                    return "generated";
                else if( value==NarrativeStatus.Extensions )
                    return "extensions";
                else if( value==NarrativeStatus.Additional )
                    return "additional";
                else if( value==NarrativeStatus.Empty )
                    return "empty";
                else
                    throw new ArgumentException("Unrecognized NarrativeStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// generated | extensions | additional
        /// </summary>
        public Code<Hl7.Fhir.Model.Narrative.NarrativeStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.Narrative.NarrativeStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Narrative.NarrativeStatus>(value);
            }
        }
        
        /// <summary>
        /// Limited xhtml content
        /// </summary>
        public Hl7.Fhir.Model.XHtml DivElement { get; set; }
        
        public string Div
        {
            get { return DivElement != null ? DivElement.Value : null; }
            set
            {
                if(value == null)
                  DivElement = null; 
                else
                  DivElement = new Hl7.Fhir.Model.XHtml(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(DivElement != null )
                result.AddRange(DivElement.Validate());
            
            return result;
        }
    }
    
}
