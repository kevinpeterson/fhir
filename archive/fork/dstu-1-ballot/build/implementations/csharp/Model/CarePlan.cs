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
    /// Healthcare plan for patient
    /// </summary>
    [FhirResource("CarePlan")]
    [Serializable]
    public partial class CarePlan : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Indicates whether the plan is currently being acted upon, represents future intentions or is now just historical record.
        /// </summary>
        public enum CarePlanStatus
        {
            Planned, // The plan is in development or awaiting use but is not yet intended to be acted upon.
            Active, // The plan is intended to be followed and used as part of patient care.
            Ended, // The plan is no longer in use and is not expected to be followed or used in patient care.
        }
        
        /// <summary>
        /// Conversion of CarePlanStatusfrom and into string
        /// <summary>
        public static class CarePlanStatusHandling
        {
            public static bool TryParse(string value, out CarePlanStatus result)
            {
                result = default(CarePlanStatus);
                
                if( value=="planned")
                    result = CarePlanStatus.Planned;
                else if( value=="active")
                    result = CarePlanStatus.Active;
                else if( value=="ended")
                    result = CarePlanStatus.Ended;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CarePlanStatus value)
            {
                if( value==CarePlanStatus.Planned )
                    return "planned";
                else if( value==CarePlanStatus.Active )
                    return "active";
                else if( value==CarePlanStatus.Ended )
                    return "ended";
                else
                    throw new ArgumentException("Unrecognized CarePlanStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// High-level categorization of the type of activity in a care plan.
        /// </summary>
        public enum CarePlanActivityCategory
        {
            Diet, // Plan for the patient to consume food of a specified nature.
            Drug, // Plan for the patient to consume/receive a drug, vaccine or other product.
            Encounter, // Plan to meet or communicate with the patient (in-patient, out-patient, phone call, etc.).
            Observation, // Plan to capture information about a patient (vitals, labs, diagnostic images, etc.).
            Procedure, // Plan to modify the patient in some way (surgery, physiotherapy, education, counseling, etc.).
            Supply, // Plan to provide something to the patient (medication, medical supply, etc.).
            Other, // Some other form of action.
        }
        
        /// <summary>
        /// Conversion of CarePlanActivityCategoryfrom and into string
        /// <summary>
        public static class CarePlanActivityCategoryHandling
        {
            public static bool TryParse(string value, out CarePlanActivityCategory result)
            {
                result = default(CarePlanActivityCategory);
                
                if( value=="diet")
                    result = CarePlanActivityCategory.Diet;
                else if( value=="drug")
                    result = CarePlanActivityCategory.Drug;
                else if( value=="encounter")
                    result = CarePlanActivityCategory.Encounter;
                else if( value=="observation")
                    result = CarePlanActivityCategory.Observation;
                else if( value=="procedure")
                    result = CarePlanActivityCategory.Procedure;
                else if( value=="supply")
                    result = CarePlanActivityCategory.Supply;
                else if( value=="other")
                    result = CarePlanActivityCategory.Other;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CarePlanActivityCategory value)
            {
                if( value==CarePlanActivityCategory.Diet )
                    return "diet";
                else if( value==CarePlanActivityCategory.Drug )
                    return "drug";
                else if( value==CarePlanActivityCategory.Encounter )
                    return "encounter";
                else if( value==CarePlanActivityCategory.Observation )
                    return "observation";
                else if( value==CarePlanActivityCategory.Procedure )
                    return "procedure";
                else if( value==CarePlanActivityCategory.Supply )
                    return "supply";
                else if( value==CarePlanActivityCategory.Other )
                    return "other";
                else
                    throw new ArgumentException("Unrecognized CarePlanActivityCategory value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Indicates whether the goal has been met and is still being targeted
        /// </summary>
        public enum CarePlanGoalStatus
        {
            InProgress, // The goal is being sought but has not yet been reached.  (Also applies if goal was reached in the past but there has been regression and goal is being sought again).
            Achieved, // The goal has been met and no further action is needed.
            Sustaining, // The goal has been met, but ongoing activity is needed to sustain the goal objective.
            Abandoned, // The goal is no longer being sought.
        }
        
        /// <summary>
        /// Conversion of CarePlanGoalStatusfrom and into string
        /// <summary>
        public static class CarePlanGoalStatusHandling
        {
            public static bool TryParse(string value, out CarePlanGoalStatus result)
            {
                result = default(CarePlanGoalStatus);
                
                if( value=="in progress")
                    result = CarePlanGoalStatus.InProgress;
                else if( value=="achieved")
                    result = CarePlanGoalStatus.Achieved;
                else if( value=="sustaining")
                    result = CarePlanGoalStatus.Sustaining;
                else if( value=="abandoned")
                    result = CarePlanGoalStatus.Abandoned;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CarePlanGoalStatus value)
            {
                if( value==CarePlanGoalStatus.InProgress )
                    return "in progress";
                else if( value==CarePlanGoalStatus.Achieved )
                    return "achieved";
                else if( value==CarePlanGoalStatus.Sustaining )
                    return "sustaining";
                else if( value==CarePlanGoalStatus.Abandoned )
                    return "abandoned";
                else
                    throw new ArgumentException("Unrecognized CarePlanGoalStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Indicates where the activity is at in its overall life cycle
        /// </summary>
        public enum CarePlanActivityStatus
        {
            NotStarted, // Activity is planned but no action has yet been taken.
            Scheduled, // Appointment or other booking has occurred but activity has not yet begun.
            Ongoing, // Activity has been started but is not yet complete.
            OnHold, // Activity was started but has temporarily ceased with an expectation of resumption at a future time.
            Completed, // The activities have been completed (more or less) as planned.
            Discontinued, // The activities have been ended prior to completion (perhaps even before they were started).
        }
        
        /// <summary>
        /// Conversion of CarePlanActivityStatusfrom and into string
        /// <summary>
        public static class CarePlanActivityStatusHandling
        {
            public static bool TryParse(string value, out CarePlanActivityStatus result)
            {
                result = default(CarePlanActivityStatus);
                
                if( value=="not started")
                    result = CarePlanActivityStatus.NotStarted;
                else if( value=="scheduled")
                    result = CarePlanActivityStatus.Scheduled;
                else if( value=="ongoing")
                    result = CarePlanActivityStatus.Ongoing;
                else if( value=="on hold")
                    result = CarePlanActivityStatus.OnHold;
                else if( value=="completed")
                    result = CarePlanActivityStatus.Completed;
                else if( value=="discontinued")
                    result = CarePlanActivityStatus.Discontinued;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CarePlanActivityStatus value)
            {
                if( value==CarePlanActivityStatus.NotStarted )
                    return "not started";
                else if( value==CarePlanActivityStatus.Scheduled )
                    return "scheduled";
                else if( value==CarePlanActivityStatus.Ongoing )
                    return "ongoing";
                else if( value==CarePlanActivityStatus.OnHold )
                    return "on hold";
                else if( value==CarePlanActivityStatus.Completed )
                    return "completed";
                else if( value==CarePlanActivityStatus.Discontinued )
                    return "discontinued";
                else
                    throw new ArgumentException("Unrecognized CarePlanActivityStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("CarePlanGoalComponent")]
        [Serializable]
        public partial class CarePlanGoalComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// What's the desired outcome?
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
            /// in progress | achieved | sustaining | abandoned
            /// </summary>
            public Code<Hl7.Fhir.Model.CarePlan.CarePlanGoalStatus> StatusElement { get; set; }
            
            public Hl7.Fhir.Model.CarePlan.CarePlanGoalStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if(value == null)
                      StatusElement = null; 
                    else
                      StatusElement = new Code<Hl7.Fhir.Model.CarePlan.CarePlanGoalStatus>(value);
                }
            }
            
            /// <summary>
            /// Comments about the goal
            /// </summary>
            public Hl7.Fhir.Model.FhirString NotesElement { get; set; }
            
            public string Notes
            {
                get { return NotesElement != null ? NotesElement.Value : null; }
                set
                {
                    if(value == null)
                      NotesElement = null; 
                    else
                      NotesElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(DescriptionElement != null )
                    result.AddRange(DescriptionElement.Validate());
                if(StatusElement != null )
                    result.AddRange(StatusElement.Validate());
                if(NotesElement != null )
                    result.AddRange(NotesElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("CarePlanParticipantComponent")]
        [Serializable]
        public partial class CarePlanParticipantComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Type of involvement
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Role { get; set; }
            
            /// <summary>
            /// Who is involved
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Member { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Role != null )
                    result.AddRange(Role.Validate());
                if(Member != null )
                    result.AddRange(Member.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("CarePlanActivityComponent")]
        [Serializable]
        public partial class CarePlanActivityComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// encounter | procedure | observation | +
            /// </summary>
            public Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityCategory> CategoryElement { get; set; }
            
            public Hl7.Fhir.Model.CarePlan.CarePlanActivityCategory? Category
            {
                get { return CategoryElement != null ? CategoryElement.Value : null; }
                set
                {
                    if(value == null)
                      CategoryElement = null; 
                    else
                      CategoryElement = new Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityCategory>(value);
                }
            }
            
            /// <summary>
            /// Detail type of activity
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// not started | ongoing | suspended | completed | abandoned
            /// </summary>
            public Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus> StatusElement { get; set; }
            
            public Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if(value == null)
                      StatusElement = null; 
                    else
                      StatusElement = new Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus>(value);
                }
            }
            
            /// <summary>
            /// Do NOT do
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean ProhibitedElement { get; set; }
            
            public bool? Prohibited
            {
                get { return ProhibitedElement != null ? ProhibitedElement.Value : null; }
                set
                {
                    if(value == null)
                      ProhibitedElement = null; 
                    else
                      ProhibitedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
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
            /// How much consumed/day?
            /// </summary>
            public Hl7.Fhir.Model.Quantity DailyAmount { get; set; }
            
            /// <summary>
            /// How much is administered/supplied/consumed
            /// </summary>
            public Hl7.Fhir.Model.Quantity Quantity { get; set; }
            
            /// <summary>
            /// Extra info on activity occurrence
            /// </summary>
            public Hl7.Fhir.Model.FhirString DetailsElement { get; set; }
            
            public string Details
            {
                get { return DetailsElement != null ? DetailsElement.Value : null; }
                set
                {
                    if(value == null)
                      DetailsElement = null; 
                    else
                      DetailsElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Appointments, orders, etc.
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> ActionTaken { get; set; }
            
            /// <summary>
            /// Comments about the activity
            /// </summary>
            public Hl7.Fhir.Model.FhirString NotesElement { get; set; }
            
            public string Notes
            {
                get { return NotesElement != null ? NotesElement.Value : null; }
                set
                {
                    if(value == null)
                      NotesElement = null; 
                    else
                      NotesElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(CategoryElement != null )
                    result.AddRange(CategoryElement.Validate());
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(StatusElement != null )
                    result.AddRange(StatusElement.Validate());
                if(ProhibitedElement != null )
                    result.AddRange(ProhibitedElement.Validate());
                if(Timing != null )
                    result.AddRange(Timing.Validate());
                if(Location != null )
                    result.AddRange(Location.Validate());
                if(Performer != null )
                    Performer.ForEach(elem => result.AddRange(elem.Validate()));
                if(Product != null )
                    result.AddRange(Product.Validate());
                if(DailyAmount != null )
                    result.AddRange(DailyAmount.Validate());
                if(Quantity != null )
                    result.AddRange(Quantity.Validate());
                if(DetailsElement != null )
                    result.AddRange(DetailsElement.Validate());
                if(ActionTaken != null )
                    ActionTaken.ForEach(elem => result.AddRange(elem.Validate()));
                if(NotesElement != null )
                    result.AddRange(NotesElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// ID for plan
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// Who care plan is for
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Patient { get; set; }
        
        /// <summary>
        /// planned | active | ended
        /// </summary>
        public Code<Hl7.Fhir.Model.CarePlan.CarePlanStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.CarePlan.CarePlanStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.CarePlan.CarePlanStatus>(value);
            }
        }
        
        /// <summary>
        /// Time period plan covers
        /// </summary>
        public Hl7.Fhir.Model.Period Period { get; set; }
        
        /// <summary>
        /// When last updated
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime ModifiedElement { get; set; }
        
        public string Modified
        {
            get { return ModifiedElement != null ? ModifiedElement.Value : null; }
            set
            {
                if(value == null)
                  ModifiedElement = null; 
                else
                  ModifiedElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// Health issues plan addresses
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Concern { get; set; }
        
        /// <summary>
        /// Who's involved in plan?
        /// </summary>
        public List<Hl7.Fhir.Model.CarePlan.CarePlanParticipantComponent> Participant { get; set; }
        
        /// <summary>
        /// Desired outcome of plan
        /// </summary>
        public List<Hl7.Fhir.Model.CarePlan.CarePlanGoalComponent> Goal { get; set; }
        
        /// <summary>
        /// Action to occur as part of plan
        /// </summary>
        public List<Hl7.Fhir.Model.CarePlan.CarePlanActivityComponent> Activity { get; set; }
        
        /// <summary>
        /// Comments about the plan
        /// </summary>
        public Hl7.Fhir.Model.FhirString NotesElement { get; set; }
        
        public string Notes
        {
            get { return NotesElement != null ? NotesElement.Value : null; }
            set
            {
                if(value == null)
                  NotesElement = null; 
                else
                  NotesElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(Patient != null )
                result.AddRange(Patient.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(Period != null )
                result.AddRange(Period.Validate());
            if(ModifiedElement != null )
                result.AddRange(ModifiedElement.Validate());
            if(Concern != null )
                Concern.ForEach(elem => result.AddRange(elem.Validate()));
            if(Participant != null )
                Participant.ForEach(elem => result.AddRange(elem.Validate()));
            if(Goal != null )
                Goal.ForEach(elem => result.AddRange(elem.Validate()));
            if(Activity != null )
                Activity.ForEach(elem => result.AddRange(elem.Validate()));
            if(NotesElement != null )
                result.AddRange(NotesElement.Validate());
            
            return result;
        }
    }
    
}
