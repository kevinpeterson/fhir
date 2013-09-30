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
    /// Administration of medication to a patient
    /// </summary>
    [FhirResource("MedicationStatement")]
    [Serializable]
    public partial class MedicationStatement : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationStatementDosageComponent")]
        [Serializable]
        public partial class MedicationStatementDosageComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Medication timing
            /// </summary>
            public Hl7.Fhir.Model.Schedule Timing { get; set; }
            
            /// <summary>
            /// Entry site
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Site { get; set; }
            
            /// <summary>
            /// Rout of administration
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Route { get; set; }
            
            /// <summary>
            /// Administration method
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Method { get; set; }
            
            /// <summary>
            /// Dose quantity per dose
            /// </summary>
            public Hl7.Fhir.Model.Quantity Quantity { get; set; }
            
            /// <summary>
            /// Dose quantity per unit of time
            /// </summary>
            public Hl7.Fhir.Model.Ratio Rate { get; set; }
            
            /// <summary>
            /// Total dose that should be consumed per unit of time
            /// </summary>
            public Hl7.Fhir.Model.Ratio MaxDosePerPeriod { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Timing != null )
                    result.AddRange(Timing.Validate());
                if(Site != null )
                    result.AddRange(Site.Validate());
                if(Route != null )
                    result.AddRange(Route.Validate());
                if(Method != null )
                    result.AddRange(Method.Validate());
                if(Quantity != null )
                    result.AddRange(Quantity.Validate());
                if(Rate != null )
                    result.AddRange(Rate.Validate());
                if(MaxDosePerPeriod != null )
                    result.AddRange(MaxDosePerPeriod.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// External Identifier
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// Patient
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Patient { get; set; }
        
        /// <summary>
        /// True if asserting medication was not given
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean WasNotGivenElement { get; set; }
        
        public bool? WasNotGiven
        {
            get { return WasNotGivenElement != null ? WasNotGivenElement.Value : null; }
            set
            {
                if(value == null)
                  WasNotGivenElement = null; 
                else
                  WasNotGivenElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        /// <summary>
        /// True if asserting medication was not given
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> ReasonNotGiven { get; set; }
        
        /// <summary>
        /// Effective time
        /// </summary>
        public Hl7.Fhir.Model.Period WhenGiven { get; set; }
        
        /// <summary>
        /// Medication
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Medication { get; set; }
        
        /// <summary>
        /// Administration device
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> AdministrationDevice { get; set; }
        
        /// <summary>
        /// Medicine administration instructions to the patient/carer
        /// </summary>
        public List<Hl7.Fhir.Model.MedicationStatement.MedicationStatementDosageComponent> Dosage { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(Patient != null )
                result.AddRange(Patient.Validate());
            if(WasNotGivenElement != null )
                result.AddRange(WasNotGivenElement.Validate());
            if(ReasonNotGiven != null )
                ReasonNotGiven.ForEach(elem => result.AddRange(elem.Validate()));
            if(WhenGiven != null )
                result.AddRange(WhenGiven.Validate());
            if(Medication != null )
                result.AddRange(Medication.Validate());
            if(AdministrationDevice != null )
                AdministrationDevice.ForEach(elem => result.AddRange(elem.Validate()));
            if(Dosage != null )
                Dosage.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
