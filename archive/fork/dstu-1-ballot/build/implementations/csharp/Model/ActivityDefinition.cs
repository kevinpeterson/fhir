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
    /// Information about a type of activity that can be performed
    /// </summary>
    [FhirComposite("ActivityDefinition")]
    public partial class ActivityDefinition : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// High-level categorization of the type of activity in a protocol.
        /// </summary>
        public enum ActivityDefinitionCategory
        {
            Diet, // To consume food of a specified nature
            Drug, // To consume/receive a drug, vaccine or other product
            Visit, // To meet or communicate with the patient (in-patient, out-patient, phone call, etc.)
            Observation, // To capture information about a patient (vitals, labs, diagnostic images, etc.)
            Procedure, // To modify the patient in some way (surgery, physio-therapy, education, counselling, etc.)
            Supply, // To provide something to the patient (medication, medical supply, etc.)
            Other, // Some other form of action
        }
        
        /// <summary>
        /// Conversion of ActivityDefinitionCategoryfrom and into string
        /// <summary>
        public static class ActivityDefinitionCategoryHandling
        {
            public static bool TryParse(string value, out ActivityDefinitionCategory result)
            {
                result = default(ActivityDefinitionCategory);
                
                if( value=="diet")
                    result = ActivityDefinitionCategory.Diet;
                else if( value=="drug")
                    result = ActivityDefinitionCategory.Drug;
                else if( value=="visit")
                    result = ActivityDefinitionCategory.Visit;
                else if( value=="observation")
                    result = ActivityDefinitionCategory.Observation;
                else if( value=="procedure")
                    result = ActivityDefinitionCategory.Procedure;
                else if( value=="supply")
                    result = ActivityDefinitionCategory.Supply;
                else if( value=="other")
                    result = ActivityDefinitionCategory.Other;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ActivityDefinitionCategory value)
            {
                if( value==ActivityDefinitionCategory.Diet )
                    return "diet";
                else if( value==ActivityDefinitionCategory.Drug )
                    return "drug";
                else if( value==ActivityDefinitionCategory.Visit )
                    return "visit";
                else if( value==ActivityDefinitionCategory.Observation )
                    return "observation";
                else if( value==ActivityDefinitionCategory.Procedure )
                    return "procedure";
                else if( value==ActivityDefinitionCategory.Supply )
                    return "supply";
                else if( value==ActivityDefinitionCategory.Other )
                    return "other";
                else
                    throw new ArgumentException("Unrecognized ActivityDefinitionCategory value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// encounter | procedure | observation | +
        /// </summary>
        public Code<Hl7.Fhir.Model.ActivityDefinition.ActivityDefinitionCategory> Category { get; set; }
        
        /// <summary>
        /// Detail type of activity
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
        
        /// <summary>
        /// When activity is to occur
        /// </summary>
        public Hl7.Fhir.Model.Element Timing { get; set; }
        
        /// <summary>
        /// Where it should happen
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Location { get; set; }
        
        /// <summary>
        /// Who's responsible?
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Performer { get; set; }
        
        /// <summary>
        /// What's administered/supplied
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Product { get; set; }
        
        /// <summary>
        /// How much is administered/consumed/supplied
        /// </summary>
        public Hl7.Fhir.Model.Quantity Quantity { get; set; }
        
        /// <summary>
        /// Extra info on activity occurrence
        /// </summary>
        public Hl7.Fhir.Model.FhirString Details { get; set; }
        
    }
    
}
