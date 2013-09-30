using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

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
// Generated on Wed, Jun 19, 2013 01:55+1000 for FHIR v0.09
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Test's Resource
    /// </summary>
    [FhirResource("Test")]
    public partial class Test : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Strings with invalid content
        /// </summary>
        public List<Hl7.Fhir.Model.FhirString> StringErr { get; set; }
        
        /// <summary>
        /// Strings with correct content
        /// </summary>
        public List<Hl7.Fhir.Model.FhirString> StringCorr { get; set; }
        
        /// <summary>
        /// Booleans with invalid content
        /// </summary>
        public List<Hl7.Fhir.Model.FhirBoolean> BooleanErr { get; set; }
        
        /// <summary>
        /// Booleans with correct content
        /// </summary>
        public List<Hl7.Fhir.Model.FhirBoolean> BooleanCorr { get; set; }
        
        /// <summary>
        /// Integers with invalid content
        /// </summary>
        public List<Hl7.Fhir.Model.Integer> IntegerErr { get; set; }
        
        /// <summary>
        /// Integers with correct content
        /// </summary>
        public List<Hl7.Fhir.Model.Integer> IntegerCorr { get; set; }
        
        /// <summary>
        /// Decimals with invalid content
        /// </summary>
        public List<Hl7.Fhir.Model.FhirDecimal> DecimalErr { get; set; }
        
        /// <summary>
        /// Decimals with correct content
        /// </summary>
        public List<Hl7.Fhir.Model.FhirDecimal> DecimalCorr { get; set; }
        
        /// <summary>
        /// Binaries with invalid content
        /// </summary>
        public List<Hl7.Fhir.Model.Base64Binary> B64Err { get; set; }
        
        /// <summary>
        /// Binaries with correct content
        /// </summary>
        public List<Hl7.Fhir.Model.Base64Binary> B64Corr { get; set; }
        
        /// <summary>
        /// Instants with invalid content
        /// </summary>
        public List<Hl7.Fhir.Model.Instant> InstantErr { get; set; }
        
        /// <summary>
        /// Instants with correct content
        /// </summary>
        public List<Hl7.Fhir.Model.Instant> InstantCorr { get; set; }
        
        /// <summary>
        /// Uri's with invalid content
        /// </summary>
        public List<Hl7.Fhir.Model.FhirUri> UriErr { get; set; }
        
        /// <summary>
        /// Uri's with correct content
        /// </summary>
        public List<Hl7.Fhir.Model.FhirUri> UriCorr { get; set; }
        
        /// <summary>
        /// Test idref
        /// </summary>
        public Hl7.Fhir.Model.IdRef IdrefSingle { get; set; }
        
    }
    
}
