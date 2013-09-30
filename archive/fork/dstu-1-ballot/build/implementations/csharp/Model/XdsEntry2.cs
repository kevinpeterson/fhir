using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

/*
  Copyright (c) 2011-2012, HL7, Inc.
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
// Generated on Wed, Apr 3, 2013 07:11+1100 for FHIR v0.07
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// An Entry in an XDS Registry
    /// </summary>
    [FhirResource("XdsEntry2")]
    public partial class XdsEntry2 : Resource
    {
        /// <summary>
        /// Version specific document identifier (uri or urn)
        /// </summary>
        public Identifier Id { get; set; }
        
        /// <summary>
        /// Searchable document metadata
        /// </summary>
        public DocumentInformation Information { get; set; }
        
        /// <summary>
        /// Format (urn:.. following rules)
        /// </summary>
        public Coding Format { get; set; }
        
        /// <summary>
        /// Approved | Deprecated
        /// </summary>
        public Code Availability { get; set; }
        
        /// <summary>
        /// Folders this document is in
        /// </summary>
        public List<ResourceReference> Folder { get; set; }
        
        /// <summary>
        /// Current subject of care
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Reference to the content
        /// </summary>
        public Attachment Content { get; set; }
        
    }
    
}
