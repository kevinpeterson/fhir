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
    /// Administration of medication to a patient
    /// </summary>
    [FhirResource("MedicationAdministration")]
    [Serializable]
    public partial class MedicationAdministration : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// A set of codes indicating the current status of a MedicationAdministration
        /// </summary>
        public enum MedicationAdministrationStatus
        {
            Active, // The administration has started but has not yet completed.
            Held, // Actions implied by the administration have been temporarily halted, but are expected to continue later. May also be called "held".
            Completed, // All actions that are implied by the administration have occurred.
            EnteredInError, // The administration was entered in error and therefore nullified.
            Stopped, // Actions implied by the administration have been permanently halted, before all of them occurred.
        }
        
        /// <summary>
        /// Conversion of MedicationAdministrationStatusfrom and into string
        /// <summary>
        public static class MedicationAdministrationStatusHandling
        {
            public static bool TryParse(string value, out MedicationAdministrationStatus result)
            {
                result = default(MedicationAdministrationStatus);
                
                if( value=="active")
                    result = MedicationAdministrationStatus.Active;
                else if( value=="held")
                    result = MedicationAdministrationStatus.Held;
                else if( value=="completed")
                    result = MedicationAdministrationStatus.Completed;
                else if( value=="entered in error")
                    result = MedicationAdministrationStatus.EnteredInError;
                else if( value=="stopped")
                    result = MedicationAdministrationStatus.Stopped;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(MedicationAdministrationStatus value)
            {
                if( value==MedicationAdministrationStatus.Active )
                    return "active";
                else if( value==MedicationAdministrationStatus.Held )
                    return "held";
                else if( value==MedicationAdministrationStatus.Completed )
                    return "completed";
                else if( value==MedicationAdministrationStatus.EnteredInError )
                    return "entered in error";
                else if( value==MedicationAdministrationStatus.Stopped )
                    return "stopped";
                else
                    throw new ArgumentException("Unrecognized MedicationAdministrationStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationAdministrationDosageComponent")]
        [Serializable]
        public partial class MedicationAdministrationDosageComponent : Hl7.Fhir.Model.Element
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
        /// Status of the administration - active | paused | completed | nullified
        /// </summary>
        public Code<Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatus>(value);
            }
        }
        
        /// <summary>
        /// Patient
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Patient { get; set; }
        
        /// <summary>
        /// Practitioner (responsible Health Care professional)
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Practitioner { get; set; }
        
        /// <summary>
        /// Current Encounter / Admission
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Encounter { get; set; }
        
        /// <summary>
        /// Prescription
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Prescription { get; set; }
        
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
        /// Reason event is negated
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
        public List<Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationDosageComponent> Dosage { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(Patient != null )
                result.AddRange(Patient.Validate());
            if(Practitioner != null )
                result.AddRange(Practitioner.Validate());
            if(Encounter != null )
                result.AddRange(Encounter.Validate());
            if(Prescription != null )
                result.AddRange(Prescription.Validate());
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
