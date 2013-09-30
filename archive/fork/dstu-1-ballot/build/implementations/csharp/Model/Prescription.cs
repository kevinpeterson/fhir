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
// Generated on Tue, May 7, 2013 02:15+1000 for FHIR v0.09
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Instruction to administer (and supply?) medication
    /// </summary>
    [FhirResource("Prescription")]
    public partial class Prescription : Resource
    {
        /// <summary>
        /// The status of a prescription
        /// </summary>
        public enum PrescriptionStatus
        {
            Active, // Patient is using the prescribed medicine
            Completed, // Prescription is no longer current
        }
        
        /// <summary>
        /// Conversion of PrescriptionStatusfrom and into string
        /// <summary>
        public static class PrescriptionStatusHandling
        {
            public static bool TryParse(string value, out PrescriptionStatus result)
            {
                result = default(PrescriptionStatus);
                
                if( value=="active")
                    result = PrescriptionStatus.Active;
                else if( value=="completed")
                    result = PrescriptionStatus.Completed;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(PrescriptionStatus value)
            {
                if( value==PrescriptionStatus.Active )
                    return "active";
                else if( value==PrescriptionStatus.Completed )
                    return "completed";
                else
                    throw new ArgumentException("Unrecognized PrescriptionStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("PrescriptionDispenseComponent")]
        public partial class PrescriptionDispenseComponent : Element
        {
            /// <summary>
            /// Number of repeats
            /// </summary>
            public Integer Repeats { get; set; }
            
            /// <summary>
            /// Quantity per repeat
            /// </summary>
            public Quantity Quantity { get; set; }
            
            /// <summary>
            /// Person to fulfill the requested dispense
            /// </summary>
            public ResourceReference Dispenser { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("PrescriptionMedicineActiveIngredientComponent")]
        public partial class PrescriptionMedicineActiveIngredientComponent : Element
        {
            /// <summary>
            /// Text and/or Code(s) for active ingredient
            /// </summary>
            public CodeableConcept Identification { get; set; }
            
            /// <summary>
            /// Relative quantity of active ingredient
            /// </summary>
            public Element Quantity { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("PrescriptionAdministrationRequestComponent")]
        public partial class PrescriptionAdministrationRequestComponent : Element
        {
            /// <summary>
            /// Textual instructions for use
            /// </summary>
            public FhirString Description { get; set; }
            
            /// <summary>
            /// Total periodic dose
            /// </summary>
            public Ratio TotalPeriodicDose { get; set; }
            
            /// <summary>
            /// Start date for administration
            /// </summary>
            public FhirDateTime Start { get; set; }
            
            /// <summary>
            /// End date for administration
            /// </summary>
            public FhirDateTime End { get; set; }
            
            /// <summary>
            /// Total duration of administration
            /// </summary>
            public Quantity Duration { get; set; }
            
            /// <summary>
            /// Maximum number of separate administrations
            /// </summary>
            public Integer NumberOfAdministrations { get; set; }
            
            /// <summary>
            /// Dosage instruction
            /// </summary>
            public List<PrescriptionAdministrationRequestDosageInstructionComponent> DosageInstruction { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("PrescriptionMedicineComponent")]
        public partial class PrescriptionMedicineComponent : Element
        {
            /// <summary>
            /// Text and/or code(s) for medicine
            /// </summary>
            public CodeableConcept Identification { get; set; }
            
            /// <summary>
            /// Active substance
            /// </summary>
            public List<PrescriptionMedicineActiveIngredientComponent> ActiveIngredient { get; set; }
            
            /// <summary>
            /// Inactive substance
            /// </summary>
            public List<PrescriptionMedicineInactiveIngredientComponent> InactiveIngredient { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("PrescriptionMedicineInactiveIngredientComponent")]
        public partial class PrescriptionMedicineInactiveIngredientComponent : Element
        {
            /// <summary>
            /// Text and/or Code(s) for inactive ingredient
            /// </summary>
            public CodeableConcept Identification { get; set; }
            
            /// <summary>
            /// Relative quantity of inactive ingredient
            /// </summary>
            public Element Quantity { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("PrescriptionAdministrationRequestDosageInstructionComponent")]
        public partial class PrescriptionAdministrationRequestDosageInstructionComponent : Element
        {
            /// <summary>
            /// Precondition for starting administration
            /// </summary>
            public List<CodeableConcept> Precondition { get; set; }
            
            /// <summary>
            /// As required : Yes|No
            /// </summary>
            public FhirBoolean Prn { get; set; }
            
            /// <summary>
            /// Additional instructions
            /// </summary>
            public List<CodeableConcept> AdditionalInstruction { get; set; }
            
            /// <summary>
            /// Route of administration
            /// </summary>
            public CodeableConcept Route { get; set; }
            
            /// <summary>
            /// Dose per administration
            /// </summary>
            public Element Dose { get; set; }
            
            /// <summary>
            /// Flow-rate for IV
            /// </summary>
            public Quantity Rate { get; set; }
            
            /// <summary>
            /// Schedule for administration
            /// </summary>
            public List<Schedule> Schedule { get; set; }
            
        }
        
        
        /// <summary>
        /// Prescription identification
        /// </summary>
        public List<Identifier> Identifier { get; set; }
        
        /// <summary>
        /// Status: Active|Completed
        /// </summary>
        public Code<Prescription.PrescriptionStatus> Status { get; set; }
        
        /// <summary>
        /// Patient receiving medicine
        /// </summary>
        public ResourceReference Patient { get; set; }
        
        /// <summary>
        /// Prescribing doctor
        /// </summary>
        public ResourceReference Prescriber { get; set; }
        
        /// <summary>
        /// Date/time prescribed
        /// </summary>
        public FhirDateTime Prescribed { get; set; }
        
        /// <summary>
        /// Details of included dispense request
        /// </summary>
        public PrescriptionDispenseComponent Dispense { get; set; }
        
        /// <summary>
        /// Prescribed medicine
        /// </summary>
        public PrescriptionMedicineComponent Medicine { get; set; }
        
        /// <summary>
        /// Instructions for use
        /// </summary>
        public PrescriptionAdministrationRequestComponent AdministrationRequest { get; set; }
        
        /// <summary>
        /// Reason for prescription
        /// </summary>
        public CodeableConcept Reason { get; set; }
        
    }
    
}
