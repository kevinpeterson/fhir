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
    /// A series of measurements taken by a device
    /// </summary>
    [FhirComposite("SampledData")]
    [Serializable]
    public partial class SampledData : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// Zero value and units
        /// </summary>
        public Hl7.Fhir.Model.Quantity Origin { get; set; }
        
        /// <summary>
        /// Number of milliseconds between samples
        /// </summary>
        public Hl7.Fhir.Model.FhirDecimal PeriodElement { get; set; }
        
        public decimal? Period
        {
            get { return PeriodElement != null ? PeriodElement.Value : null; }
            set
            {
                if(value == null)
                  PeriodElement = null; 
                else
                  PeriodElement = new Hl7.Fhir.Model.FhirDecimal(value);
            }
        }
        
        /// <summary>
        /// Multiply data by this before adding to origin
        /// </summary>
        public Hl7.Fhir.Model.FhirDecimal FactorElement { get; set; }
        
        public decimal? Factor
        {
            get { return FactorElement != null ? FactorElement.Value : null; }
            set
            {
                if(value == null)
                  FactorElement = null; 
                else
                  FactorElement = new Hl7.Fhir.Model.FhirDecimal(value);
            }
        }
        
        /// <summary>
        /// Lower limit of detection
        /// </summary>
        public Hl7.Fhir.Model.FhirDecimal LowerLimitElement { get; set; }
        
        public decimal? LowerLimit
        {
            get { return LowerLimitElement != null ? LowerLimitElement.Value : null; }
            set
            {
                if(value == null)
                  LowerLimitElement = null; 
                else
                  LowerLimitElement = new Hl7.Fhir.Model.FhirDecimal(value);
            }
        }
        
        /// <summary>
        /// Upper limit of detection
        /// </summary>
        public Hl7.Fhir.Model.FhirDecimal UpperLimitElement { get; set; }
        
        public decimal? UpperLimit
        {
            get { return UpperLimitElement != null ? UpperLimitElement.Value : null; }
            set
            {
                if(value == null)
                  UpperLimitElement = null; 
                else
                  UpperLimitElement = new Hl7.Fhir.Model.FhirDecimal(value);
            }
        }
        
        /// <summary>
        /// Number of sample points at each time point
        /// </summary>
        public Hl7.Fhir.Model.Integer DimensionsElement { get; set; }
        
        public int? Dimensions
        {
            get { return DimensionsElement != null ? DimensionsElement.Value : null; }
            set
            {
                if(value == null)
                  DimensionsElement = null; 
                else
                  DimensionsElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Decimal values with spaces, or "E" | "U" | "L"
        /// </summary>
        public Hl7.Fhir.Model.FhirString DataElement { get; set; }
        
        public string Data
        {
            get { return DataElement != null ? DataElement.Value : null; }
            set
            {
                if(value == null)
                  DataElement = null; 
                else
                  DataElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Origin != null )
                result.AddRange(Origin.Validate());
            if(PeriodElement != null )
                result.AddRange(PeriodElement.Validate());
            if(FactorElement != null )
                result.AddRange(FactorElement.Validate());
            if(LowerLimitElement != null )
                result.AddRange(LowerLimitElement.Validate());
            if(UpperLimitElement != null )
                result.AddRange(UpperLimitElement.Validate());
            if(DimensionsElement != null )
                result.AddRange(DimensionsElement.Validate());
            if(DataElement != null )
                result.AddRange(DataElement.Validate());
            
            return result;
        }
    }
    
}
