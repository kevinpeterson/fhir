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
    /// A homogeneous material with a definite composition used in healthcare
    /// </summary>
    [FhirResource("Substance")]
    [Serializable]
    public partial class Substance : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Identifier of the substance
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// Name of the substance
        /// </summary>
        public Hl7.Fhir.Model.FhirString NameElement { get; set; }
        
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if(value == null)
                  NameElement = null; 
                else
                  NameElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Type of the substance
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
        
        /// <summary>
        /// Description of the substance
        /// </summary>
        public Hl7.Fhir.Model.FhirString DescriptionElement { get; set; }
        
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Substance status
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Status { get; set; }
        
        /// <summary>
        /// Substance effective period
        /// </summary>
        public Hl7.Fhir.Model.Period EffectiveTime { get; set; }
        
        /// <summary>
        /// Substance amount
        /// </summary>
        public Hl7.Fhir.Model.Quantity Quantity { get; set; }
        
        /// <summary>
        /// Substance composition
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Ingredient { get; set; }
        
        /// <summary>
        /// Absolute | Relative
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept QuantityMode { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(NameElement != null )
                result.AddRange(NameElement.Validate());
            if(Type != null )
                result.AddRange(Type.Validate());
            if(DescriptionElement != null )
                result.AddRange(DescriptionElement.Validate());
            if(Status != null )
                result.AddRange(Status.Validate());
            if(EffectiveTime != null )
                result.AddRange(EffectiveTime.Validate());
            if(Quantity != null )
                result.AddRange(Quantity.Validate());
            if(Ingredient != null )
                Ingredient.ForEach(elem => result.AddRange(elem.Validate()));
            if(QuantityMode != null )
                result.AddRange(QuantityMode.Validate());
            
            return result;
        }
    }
    
}
