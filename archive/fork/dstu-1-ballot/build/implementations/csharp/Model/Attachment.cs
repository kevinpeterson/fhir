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
    /// Content in a format defined elsewhere
    /// </summary>
    [FhirComposite("Attachment")]
    [Serializable]
    public partial class Attachment : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// Mime type of the content, with charset etc.
        /// </summary>
        public Hl7.Fhir.Model.Code ContentTypeElement { get; set; }
        
        public string ContentType
        {
            get { return ContentTypeElement != null ? ContentTypeElement.Value : null; }
            set
            {
                if(value == null)
                  ContentTypeElement = null; 
                else
                  ContentTypeElement = new Hl7.Fhir.Model.Code(value);
            }
        }
        
        /// <summary>
        /// Human language of the content (BCP-47)
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
        /// Data inline, base64ed
        /// </summary>
        public Hl7.Fhir.Model.Base64Binary DataElement { get; set; }
        
        public byte[] Data
        {
            get { return DataElement != null ? DataElement.Value : null; }
            set
            {
                if(value == null)
                  DataElement = null; 
                else
                  DataElement = new Hl7.Fhir.Model.Base64Binary(value);
            }
        }
        
        /// <summary>
        /// Uri where the data can be found
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
        
        /// <summary>
        /// Number of bytes of content (if url provided)
        /// </summary>
        public Hl7.Fhir.Model.Integer SizeElement { get; set; }
        
        public int? Size
        {
            get { return SizeElement != null ? SizeElement.Value : null; }
            set
            {
                if(value == null)
                  SizeElement = null; 
                else
                  SizeElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Hash of the data (sha-1, base64ed )
        /// </summary>
        public Hl7.Fhir.Model.Base64Binary HashElement { get; set; }
        
        public byte[] Hash
        {
            get { return HashElement != null ? HashElement.Value : null; }
            set
            {
                if(value == null)
                  HashElement = null; 
                else
                  HashElement = new Hl7.Fhir.Model.Base64Binary(value);
            }
        }
        
        /// <summary>
        /// Label to display in place of the data
        /// </summary>
        public Hl7.Fhir.Model.FhirString TitleElement { get; set; }
        
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if(value == null)
                  TitleElement = null; 
                else
                  TitleElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(ContentTypeElement != null )
                result.AddRange(ContentTypeElement.Validate());
            if(LanguageElement != null )
                result.AddRange(LanguageElement.Validate());
            if(DataElement != null )
                result.AddRange(DataElement.Validate());
            if(UrlElement != null )
                result.AddRange(UrlElement.Validate());
            if(SizeElement != null )
                result.AddRange(SizeElement.Validate());
            if(HashElement != null )
                result.AddRange(HashElement.Validate());
            if(TitleElement != null )
                result.AddRange(TitleElement.Validate());
            
            return result;
        }
    }
    
}
