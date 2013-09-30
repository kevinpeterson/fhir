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
    /// Prescription of medication to for patient
    /// </summary>
    [FhirResource("MedicationPrescription")]
    [Serializable]
    public partial class MedicationPrescription : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// A code specifying the state of the prescribing event. Describes the lifecycle of the prescription.
        /// </summary>
        public enum MedicationPrescriptionStatus
        {
            Active, // The prescription is 'actionable', but not all actions that are implied by it have occurred yet.
            Suspended, // Actions implied by the prescription have been temporarily halted, but are expected to continue later.  May also be called "held".
            Completed, // All actions that are implied by the prescription have occurred (this will rarely be made explicit).
            EnteredInError, // The prescription was entered in error and therefore nullified.
            Stopped, // Actions implied by the prescription have been permanently halted, before all of them occurred.
            Obsolete, // The prescription was replaced by a newer one, which encompasses all the information in the previous one.
        }
        
        /// <summary>
        /// Conversion of MedicationPrescriptionStatusfrom and into string
        /// <summary>
        public static class MedicationPrescriptionStatusHandling
        {
            public static bool TryParse(string value, out MedicationPrescriptionStatus result)
            {
                result = default(MedicationPrescriptionStatus);
                
                if( value=="active")
                    result = MedicationPrescriptionStatus.Active;
                else if( value=="suspended")
                    result = MedicationPrescriptionStatus.Suspended;
                else if( value=="completed")
                    result = MedicationPrescriptionStatus.Completed;
                else if( value=="entered in error")
                    result = MedicationPrescriptionStatus.EnteredInError;
                else if( value=="stopped")
                    result = MedicationPrescriptionStatus.Stopped;
                else if( value=="obsolete")
                    result = MedicationPrescriptionStatus.Obsolete;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(MedicationPrescriptionStatus value)
            {
                if( value==MedicationPrescriptionStatus.Active )
                    return "active";
                else if( value==MedicationPrescriptionStatus.Suspended )
                    return "suspended";
                else if( value==MedicationPrescriptionStatus.Completed )
                    return "completed";
                else if( value==MedicationPrescriptionStatus.EnteredInError )
                    return "entered in error";
                else if( value==MedicationPrescriptionStatus.Stopped )
                    return "stopped";
                else if( value==MedicationPrescriptionStatus.Obsolete )
                    return "obsolete";
                else
                    throw new ArgumentException("Unrecognized MedicationPrescriptionStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationPrescriptionDosageInstructionComponent")]
        [Serializable]
        public partial class MedicationPrescriptionDosageInstructionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Dosage text
            /// </summary>
            public Hl7.Fhir.Model.FhirString DosageInstructionsTextElement { get; set; }
            
            public string DosageInstructionsText
            {
                get { return DosageInstructionsTextElement != null ? DosageInstructionsTextElement.Value : null; }
                set
                {
                    if(value == null)
                      DosageInstructionsTextElement = null; 
                    else
                      DosageInstructionsTextElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Additional dosage instructions
            /// </summary>
            public Hl7.Fhir.Model.Element AdditionalInstructions { get; set; }
            
            /// <summary>
            /// Medication timing
            /// </summary>
            public Hl7.Fhir.Model.Element Timing { get; set; }
            
            /// <summary>
            /// Entry site
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Site { get; set; }
            
            /// <summary>
            /// Route of administration
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Route { get; set; }
            
            /// <summary>
            /// Administration method
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Method { get; set; }
            
            /// <summary>
            /// Dose quantity per dose
            /// </summary>
            public Hl7.Fhir.Model.Quantity DoseQuantity { get; set; }
            
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
                
                if(DosageInstructionsTextElement != null )
                    result.AddRange(DosageInstructionsTextElement.Validate());
                if(AdditionalInstructions != null )
                    result.AddRange(AdditionalInstructions.Validate());
                if(Timing != null )
                    result.AddRange(Timing.Validate());
                if(Site != null )
                    result.AddRange(Site.Validate());
                if(Route != null )
                    result.AddRange(Route.Validate());
                if(Method != null )
                    result.AddRange(Method.Validate());
                if(DoseQuantity != null )
                    result.AddRange(DoseQuantity.Validate());
                if(Rate != null )
                    result.AddRange(Rate.Validate());
                if(MaxDosePerPeriod != null )
                    result.AddRange(MaxDosePerPeriod.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationPrescriptionSubstitutionComponent")]
        [Serializable]
        public partial class MedicationPrescriptionSubstitutionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Type of substitiution
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Why should substitution (not) be made
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Reason { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(Reason != null )
                    result.AddRange(Reason.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationPrescriptionDispenseComponent")]
        [Serializable]
        public partial class MedicationPrescriptionDispenseComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Medication to be dispensed
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Medication { get; set; }
            
            /// <summary>
            /// Validity period
            /// </summary>
            public Hl7.Fhir.Model.Period ValidityPeriod { get; set; }
            
            /// <summary>
            /// Number of repeats allowed
            /// </summary>
            public Hl7.Fhir.Model.Integer NumberOfRepeatsAllowedElement { get; set; }
            
            public int? NumberOfRepeatsAllowed
            {
                get { return NumberOfRepeatsAllowedElement != null ? NumberOfRepeatsAllowedElement.Value : null; }
                set
                {
                    if(value == null)
                      NumberOfRepeatsAllowedElement = null; 
                    else
                      NumberOfRepeatsAllowedElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Quanity
            /// </summary>
            public Hl7.Fhir.Model.Quantity Quantity { get; set; }
            
            /// <summary>
            /// Expected supply duration
            /// </summary>
            public Hl7.Fhir.Model.Duration ExpectedSupplyDuration { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Medication != null )
                    result.AddRange(Medication.Validate());
                if(ValidityPeriod != null )
                    result.AddRange(ValidityPeriod.Validate());
                if(NumberOfRepeatsAllowedElement != null )
                    result.AddRange(NumberOfRepeatsAllowedElement.Validate());
                if(Quantity != null )
                    result.AddRange(Quantity.Validate());
                if(ExpectedSupplyDuration != null )
                    result.AddRange(ExpectedSupplyDuration.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// External identifier
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// Prescription date
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime DateWrittenElement { get; set; }
        
        public string DateWritten
        {
            get { return DateWrittenElement != null ? DateWrittenElement.Value : null; }
            set
            {
                if(value == null)
                  DateWrittenElement = null; 
                else
                  DateWrittenElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// active | paused | completed | nullified
        /// </summary>
        public Code<Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatus>(value);
            }
        }
        
        /// <summary>
        /// Patient
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Patient { get; set; }
        
        /// <summary>
        /// Prescriber
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Prescriber { get; set; }
        
        /// <summary>
        /// Encounter / Admission / Stay
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Encounter { get; set; }
        
        /// <summary>
        /// Reason or indication for writing the prescription
        /// </summary>
        public Hl7.Fhir.Model.Element ReasonForPrescribing { get; set; }
        
        /// <summary>
        /// Medication to be taken
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Medication { get; set; }
        
        /// <summary>
        /// Dosage instructions
        /// </summary>
        public List<Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDosageInstructionComponent> DosageInstruction { get; set; }
        
        /// <summary>
        /// Dispense request
        /// </summary>
        public Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDispenseComponent Dispense { get; set; }
        
        /// <summary>
        /// Deals with substitution of one medicine for another
        /// </summary>
        public Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionSubstitutionComponent Substitution { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(DateWrittenElement != null )
                result.AddRange(DateWrittenElement.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(Patient != null )
                result.AddRange(Patient.Validate());
            if(Prescriber != null )
                result.AddRange(Prescriber.Validate());
            if(Encounter != null )
                result.AddRange(Encounter.Validate());
            if(ReasonForPrescribing != null )
                result.AddRange(ReasonForPrescribing.Validate());
            if(Medication != null )
                result.AddRange(Medication.Validate());
            if(DosageInstruction != null )
                DosageInstruction.ForEach(elem => result.AddRange(elem.Validate()));
            if(Dispense != null )
                result.AddRange(Dispense.Validate());
            if(Substitution != null )
                result.AddRange(Substitution.Validate());
            
            return result;
        }
    }
    
}
