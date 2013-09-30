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
// Generated on Fri, Jun 21, 2013 22:44+1000 for FHIR v0.09
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A series of measurements taken by a device
    /// </summary>
    [FhirComposite("Array")]
    public partial class Array : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// Zero value and units
        /// </summary>
        public Hl7.Fhir.Model.Quantity Origin { get; set; }
        
        /// <summary>
        /// Number of milliseconds between samples
        /// </summary>
        public Hl7.Fhir.Model.FhirDecimal Period { get; set; }
        
        /// <summary>
        /// Multiply data by this before adding to origin
        /// </summary>
        public Hl7.Fhir.Model.FhirDecimal Factor { get; set; }
        
        /// <summary>
        /// Lower limit of detection
        /// </summary>
        public Hl7.Fhir.Model.FhirDecimal LowerLimit { get; set; }
        
        /// <summary>
        /// Upper limit of detection
        /// </summary>
        public Hl7.Fhir.Model.FhirDecimal UpperLimit { get; set; }
        
        /// <summary>
        /// Number of sample points at each time point
        /// </summary>
        public Hl7.Fhir.Model.Integer Dimensions { get; set; }
        
        /// <summary>
        /// Decimal values with spaces, or "E" | "U" | "L"
        /// </summary>
        public Hl7.Fhir.Model.FhirString Data { get; set; }
        
    }
    
}
