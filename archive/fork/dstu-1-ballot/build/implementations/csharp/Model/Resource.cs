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
    /// null
    /// </summary>
    [FhirResource("Resource")]
    [Serializable]
    public abstract partial class Resource
    {
        /// <summary>
        /// Additional Content defined by implementations
        /// </summary>
        public List<Hl7.Fhir.Model.Extension> Extension { get; set; }
        
        /// <summary>
        /// Language of the resource content
        /// </summary>
        public Hl7.Fhir.Model.Code LanguageElement { get; set; }
        
        public string Language
        {
            get { return LanguageElement != null ? LanguageElement.Value : null; }
            set
            {
                if(value == null)
                  LanguageElement = null; 
                else
                  LanguageElement = new Hl7.Fhir.Model.Code(value);
            }
        }
        
        /// <summary>
        /// Text summary of the resource, for human interpretation
        /// </summary>
        public Hl7.Fhir.Model.Narrative Text { get; set; }
        
        /// <summary>
        /// Contained, inline Resources
        /// </summary>
        public List<Hl7.Fhir.Model.Resource> Contained { get; set; }
        
        /// <summary>
        /// Local id for element
        /// </summary>
        public Hl7.Fhir.Model.Id LocalIdElement { get; set; }
        
        public string LocalId
        {
            get { return LocalIdElement != null ? LocalIdElement.Value : null; }
            set
            {
                if(value == null)
                  LocalIdElement = null; 
                else
                  LocalIdElement = new Hl7.Fhir.Model.Id(value);
            }
        }
        
        public virtual ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(ValidateRules());
            
            if(Extension != null )
                Extension.ForEach(elem => result.AddRange(elem.Validate()));
            if(LanguageElement != null )
                result.AddRange(LanguageElement.Validate());
            if(Text != null )
                result.AddRange(Text.Validate());
            if(Contained != null )
                Contained.ForEach(elem => result.AddRange(elem.Validate()));
            if(LocalIdElement != null )
                result.AddRange(LocalIdElement.Validate());
            
            return result;
        }
    }
    
}
