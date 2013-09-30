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
    /// Dispensing a medication to a named patient
    /// </summary>
    [FhirResource("MedicationDispense")]
    [Serializable]
    public partial class MedicationDispense : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// A code specifying the state of the dispense event.
        /// </summary>
        public enum MedicationDispenseStatus
        {
            Active, // The dispense has started but has not yet completed.
            Suspended, // Actions implied by the administration have been temporarily halted, but are expected to continue later. May also be called "held".
            Completed, // All actions that are implied by the dispense have occurred.
            EnteredInError, // The dispense was entered in error and therefore nullified.
            Stopped, // Actions implied by the dispense have been permanently halted, before all of them occurred.
        }
        
        /// <summary>
        /// Conversion of MedicationDispenseStatusfrom and into string
        /// <summary>
        public static class MedicationDispenseStatusHandling
        {
            public static bool TryParse(string value, out MedicationDispenseStatus result)
            {
                result = default(MedicationDispenseStatus);
                
                if( value=="active")
                    result = MedicationDispenseStatus.Active;
                else if( value=="suspended")
                    result = MedicationDispenseStatus.Suspended;
                else if( value=="completed")
                    result = MedicationDispenseStatus.Completed;
                else if( value=="entered in error")
                    result = MedicationDispenseStatus.EnteredInError;
                else if( value=="stopped")
                    result = MedicationDispenseStatus.Stopped;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(MedicationDispenseStatus value)
            {
                if( value==MedicationDispenseStatus.Active )
                    return "active";
                else if( value==MedicationDispenseStatus.Suspended )
                    return "suspended";
                else if( value==MedicationDispenseStatus.Completed )
                    return "completed";
                else if( value==MedicationDispenseStatus.EnteredInError )
                    return "entered in error";
                else if( value==MedicationDispenseStatus.Stopped )
                    return "stopped";
                else
                    throw new ArgumentException("Unrecognized MedicationDispenseStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationDispenseDispenseDosageComponent")]
        [Serializable]
        public partial class MedicationDispenseDispenseDosageComponent : Hl7.Fhir.Model.Element
        {
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
        /// null
        /// </summary>
        [FhirComposite("MedicationDispenseSubstitutionComponent")]
        [Serializable]
        public partial class MedicationDispenseSubstitutionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Type of substitiution
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Why was substitution made
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Reason { get; set; }
            
            /// <summary>
            /// Who is responsible for the substitution
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> ResponsibleParty { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(Reason != null )
                    Reason.ForEach(elem => result.AddRange(elem.Validate()));
                if(ResponsibleParty != null )
                    ResponsibleParty.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationDispenseDispenseComponent")]
        [Serializable]
        public partial class MedicationDispenseDispenseComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// External identifier
            /// </summary>
            public Hl7.Fhir.Model.Identifier Identifier { get; set; }
            
            /// <summary>
            /// Active/Completed/Aborted
            /// </summary>
            public Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus> StatusElement { get; set; }
            
            public Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if(value == null)
                      StatusElement = null; 
                    else
                      StatusElement = new Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus>(value);
                }
            }
            
            /// <summary>
            /// Type of dispense
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Amount dispensed
            /// </summary>
            public Hl7.Fhir.Model.Quantity Quantity { get; set; }
            
            /// <summary>
            /// Medication
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Medication { get; set; }
            
            /// <summary>
            /// Dispensing time
            /// </summary>
            public Hl7.Fhir.Model.Period WhenPrepared { get; set; }
            
            /// <summary>
            /// Handover time
            /// </summary>
            public Hl7.Fhir.Model.Period WhenHandedOver { get; set; }
            
            /// <summary>
            /// Where the medication was sent
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Destination { get; set; }
            
            /// <summary>
            /// Who collected the medication
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Receiver { get; set; }
            
            /// <summary>
            /// Medicine administration instructions to the patient/carer
            /// </summary>
            public List<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseDosageComponent> Dosage { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Identifier != null )
                    result.AddRange(Identifier.Validate());
                if(StatusElement != null )
                    result.AddRange(StatusElement.Validate());
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(Quantity != null )
                    result.AddRange(Quantity.Validate());
                if(Medication != null )
                    result.AddRange(Medication.Validate());
                if(WhenPrepared != null )
                    result.AddRange(WhenPrepared.Validate());
                if(WhenHandedOver != null )
                    result.AddRange(WhenHandedOver.Validate());
                if(Destination != null )
                    result.AddRange(Destination.Validate());
                if(Receiver != null )
                    Receiver.ForEach(elem => result.AddRange(elem.Validate()));
                if(Dosage != null )
                    Dosage.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// External identifier
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// active | paused | completed | nullified
        /// </summary>
        public Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus>(value);
            }
        }
        
        /// <summary>
        /// Patient
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Patient { get; set; }
        
        /// <summary>
        /// Dispenser
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Dispenser { get; set; }
        
        /// <summary>
        /// Medication order that authorises the dispense
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> AuthorizingPrescription { get; set; }
        
        /// <summary>
        /// Medicine supply details
        /// </summary>
        public List<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseComponent> Dispense { get; set; }
        
        /// <summary>
        /// Deals with substitution of one medicine for another
        /// </summary>
        public Hl7.Fhir.Model.MedicationDispense.MedicationDispenseSubstitutionComponent Substitution { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(Patient != null )
                result.AddRange(Patient.Validate());
            if(Dispenser != null )
                result.AddRange(Dispenser.Validate());
            if(AuthorizingPrescription != null )
                AuthorizingPrescription.ForEach(elem => result.AddRange(elem.Validate()));
            if(Dispense != null )
                Dispense.ForEach(elem => result.AddRange(elem.Validate()));
            if(Substitution != null )
                result.AddRange(Substitution.Validate());
            
            return result;
        }
    }
    
}
