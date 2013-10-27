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
    /// An interaction during which services are provided to the patient
    /// </summary>
    [FhirResource("Encounter")]
    [Serializable]
    public partial class Encounter : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Classification of the encounter
        /// </summary>
        public enum EncounterClass
        {
            Inpatient, // An encounter during which the patient is hospitalized and stays overnight.
            Outpatient, // An encounter during which the patient is not hospitalized overnight.
            Ambulatory, // An encounter where the patient visits the practitioner in his/her office, e.g. a G.P. visit.
            Emergency, // An encounter where the patient needs urgent care.
            Home, // An encounter where the practitioner visits the patient at his/her home.
            Field, // An encounter taking place outside the regular environment for giving care.
            Daytime, // An encounter where the patient needs more prolonged treatment or investigations than outpatients, but who do not need to stay in the hospital overnight.
            Virtual, // An encounter that takes place where the patient and practitioner do not physically meet but use electronic means for contact.
        }
        
        /// <summary>
        /// Conversion of EncounterClassfrom and into string
        /// <summary>
        public static class EncounterClassHandling
        {
            public static bool TryParse(string value, out EncounterClass result)
            {
                result = default(EncounterClass);
                
                if( value=="inpatient")
                    result = EncounterClass.Inpatient;
                else if( value=="outpatient")
                    result = EncounterClass.Outpatient;
                else if( value=="ambulatory")
                    result = EncounterClass.Ambulatory;
                else if( value=="emergency")
                    result = EncounterClass.Emergency;
                else if( value=="home")
                    result = EncounterClass.Home;
                else if( value=="field")
                    result = EncounterClass.Field;
                else if( value=="daytime")
                    result = EncounterClass.Daytime;
                else if( value=="virtual")
                    result = EncounterClass.Virtual;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(EncounterClass value)
            {
                if( value==EncounterClass.Inpatient )
                    return "inpatient";
                else if( value==EncounterClass.Outpatient )
                    return "outpatient";
                else if( value==EncounterClass.Ambulatory )
                    return "ambulatory";
                else if( value==EncounterClass.Emergency )
                    return "emergency";
                else if( value==EncounterClass.Home )
                    return "home";
                else if( value==EncounterClass.Field )
                    return "field";
                else if( value==EncounterClass.Daytime )
                    return "daytime";
                else if( value==EncounterClass.Virtual )
                    return "virtual";
                else
                    throw new ArgumentException("Unrecognized EncounterClass value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Role of participant in encounter
        /// </summary>
        public enum ParticipantType
        {
            Admitter, // The practitioner responsible for admitting a patient to a hospital or other inpatient health facility.
            Discharger, // The practitioner responsible for discharging the patient from a hospital or other inpatient health facility.
            Responsible, // The practitioner responsible for overseeing a patient's care during a patient encounter.
            Attending, // The practitioner responsible for overseeing a patient's care during a patient encounter.
            Consulting, // An advisor participating in the service by performing evaluations and making recommendations.
            Referrer, // The practitioner that referred the patient to another practitioner.
        }
        
        /// <summary>
        /// Conversion of ParticipantTypefrom and into string
        /// <summary>
        public static class ParticipantTypeHandling
        {
            public static bool TryParse(string value, out ParticipantType result)
            {
                result = default(ParticipantType);
                
                if( value=="admitter")
                    result = ParticipantType.Admitter;
                else if( value=="discharger")
                    result = ParticipantType.Discharger;
                else if( value=="responsible")
                    result = ParticipantType.Responsible;
                else if( value=="attending")
                    result = ParticipantType.Attending;
                else if( value=="consulting")
                    result = ParticipantType.Consulting;
                else if( value=="referrer")
                    result = ParticipantType.Referrer;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ParticipantType value)
            {
                if( value==ParticipantType.Admitter )
                    return "admitter";
                else if( value==ParticipantType.Discharger )
                    return "discharger";
                else if( value==ParticipantType.Responsible )
                    return "responsible";
                else if( value==ParticipantType.Attending )
                    return "attending";
                else if( value==ParticipantType.Consulting )
                    return "consulting";
                else if( value==ParticipantType.Referrer )
                    return "referrer";
                else
                    throw new ArgumentException("Unrecognized ParticipantType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Current state of the encounter
        /// </summary>
        public enum EncounterState
        {
            Planned, // The Encounter has not yet started.
            Current, // The Encounter has begun and the patient is present / the practitioner and the patient are meeting.
            Onleave, // The Encounter has begun, but the patient is temporarily on leave.
            Finished, // The Encounter has ended.
            Cancelled, // The Encounter has ended before it has begun.
        }
        
        /// <summary>
        /// Conversion of EncounterStatefrom and into string
        /// <summary>
        public static class EncounterStateHandling
        {
            public static bool TryParse(string value, out EncounterState result)
            {
                result = default(EncounterState);
                
                if( value=="planned")
                    result = EncounterState.Planned;
                else if( value=="current")
                    result = EncounterState.Current;
                else if( value=="onleave")
                    result = EncounterState.Onleave;
                else if( value=="finished")
                    result = EncounterState.Finished;
                else if( value=="cancelled")
                    result = EncounterState.Cancelled;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(EncounterState value)
            {
                if( value==EncounterState.Planned )
                    return "planned";
                else if( value==EncounterState.Current )
                    return "current";
                else if( value==EncounterState.Onleave )
                    return "onleave";
                else if( value==EncounterState.Finished )
                    return "finished";
                else if( value==EncounterState.Cancelled )
                    return "cancelled";
                else
                    throw new ArgumentException("Unrecognized EncounterState value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("EncounterHospitalizationComponent")]
        [Serializable]
        public partial class EncounterHospitalizationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Pre-admission identifier
            /// </summary>
            public Hl7.Fhir.Model.Identifier PreAdmissionIdentifier { get; set; }
            
            /// <summary>
            /// The location the patient came from before admission
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Origin { get; set; }
            
            /// <summary>
            /// Where patient was admitted from (physician referral, transfer)
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept AdmitSource { get; set; }
            
            /// <summary>
            /// Period of hospitalization
            /// </summary>
            public Hl7.Fhir.Model.Period Period { get; set; }
            
            /// <summary>
            /// Where the patient stays during this encounter
            /// </summary>
            public List<Hl7.Fhir.Model.Encounter.EncounterHospitalizationAccomodationComponent> Accomodation { get; set; }
            
            /// <summary>
            /// Dietary restrictions for the patient
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Diet { get; set; }
            
            /// <summary>
            /// Special courtesies (VIP, board member)
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> SpecialCourtesy { get; set; }
            
            /// <summary>
            /// Wheelchair, translator, stretcher, etc
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> SpecialArrangement { get; set; }
            
            /// <summary>
            /// Location the patient is discharged to
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Destination { get; set; }
            
            /// <summary>
            /// Disposition patient released to
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept DischargeDisposition { get; set; }
            
            /// <summary>
            /// Is readmission?
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean ReAdmissionElement { get; set; }
            
            public bool? ReAdmission
            {
                get { return ReAdmissionElement != null ? ReAdmissionElement.Value : null; }
                set
                {
                    if(value == null)
                      ReAdmissionElement = null; 
                    else
                      ReAdmissionElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(PreAdmissionIdentifier != null )
                    result.AddRange(PreAdmissionIdentifier.Validate());
                if(Origin != null )
                    result.AddRange(Origin.Validate());
                if(AdmitSource != null )
                    result.AddRange(AdmitSource.Validate());
                if(Period != null )
                    result.AddRange(Period.Validate());
                if(Accomodation != null )
                    Accomodation.ForEach(elem => result.AddRange(elem.Validate()));
                if(Diet != null )
                    result.AddRange(Diet.Validate());
                if(SpecialCourtesy != null )
                    SpecialCourtesy.ForEach(elem => result.AddRange(elem.Validate()));
                if(SpecialArrangement != null )
                    SpecialArrangement.ForEach(elem => result.AddRange(elem.Validate()));
                if(Destination != null )
                    result.AddRange(Destination.Validate());
                if(DischargeDisposition != null )
                    result.AddRange(DischargeDisposition.Validate());
                if(ReAdmissionElement != null )
                    result.AddRange(ReAdmissionElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("EncounterHospitalizationAccomodationComponent")]
        [Serializable]
        public partial class EncounterHospitalizationAccomodationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Bed
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Bed { get; set; }
            
            /// <summary>
            /// Period during which the patient was assigned the bed
            /// </summary>
            public Hl7.Fhir.Model.Period Period { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Bed != null )
                    result.AddRange(Bed.Validate());
                if(Period != null )
                    result.AddRange(Period.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("EncounterLocationComponent")]
        [Serializable]
        public partial class EncounterLocationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The location the encounter takes place
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Location { get; set; }
            
            /// <summary>
            /// Time period during which the patient was present at the location
            /// </summary>
            public Hl7.Fhir.Model.Period Period { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Location != null )
                    result.AddRange(Location.Validate());
                if(Period != null )
                    result.AddRange(Period.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("EncounterParticipantComponent")]
        [Serializable]
        public partial class EncounterParticipantComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Role of participant in encounter
            /// </summary>
            public List<Code<Hl7.Fhir.Model.Encounter.ParticipantType>> TypeElement { get; set; }
            
            public IEnumerable<Hl7.Fhir.Model.Encounter.ParticipantType?> Type
            {
                get { return TypeElement != null ? TypeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new List<Code<Hl7.Fhir.Model.Encounter.ParticipantType>>(value.Select(elem=>new Code<Hl7.Fhir.Model.Encounter.ParticipantType>(elem)));
                }
            }
            
            /// <summary>
            /// The practitioner that is involved
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Practitioner { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(TypeElement != null )
                    TypeElement.ForEach(elem => result.AddRange(elem.Validate()));
                if(Practitioner != null )
                    result.AddRange(Practitioner.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Identifier(s) by which this encounter is known
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// E.g. active, aborted, finished
        /// </summary>
        public Code<Hl7.Fhir.Model.Encounter.EncounterState> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.Encounter.EncounterState? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Encounter.EncounterState>(value);
            }
        }
        
        /// <summary>
        /// Inpatient | Outpatient etc
        /// </summary>
        public Code<Hl7.Fhir.Model.Encounter.EncounterClass> ClassElement { get; set; }
        
        public Hl7.Fhir.Model.Encounter.EncounterClass? Class
        {
            get { return ClassElement != null ? ClassElement.Value : null; }
            set
            {
                if(value == null)
                  ClassElement = null; 
                else
                  ClassElement = new Code<Hl7.Fhir.Model.Encounter.EncounterClass>(value);
            }
        }
        
        /// <summary>
        /// Specific type of encounter
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> Type { get; set; }
        
        /// <summary>
        /// The patient present at the encounter
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// List of participants involved in the encounter
        /// </summary>
        public List<Hl7.Fhir.Model.Encounter.EncounterParticipantComponent> Participant { get; set; }
        
        /// <summary>
        /// The appointment that scheduled this encounter
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Fulfills { get; set; }
        
        /// <summary>
        /// The date and time the encounter starts
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime StartElement { get; set; }
        
        public string Start
        {
            get { return StartElement != null ? StartElement.Value : null; }
            set
            {
                if(value == null)
                  StartElement = null; 
                else
                  StartElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// Quantity of time the encounter lasted
        /// </summary>
        public Hl7.Fhir.Model.Duration Length { get; set; }
        
        /// <summary>
        /// Reason the encounter takes place
        /// </summary>
        public Hl7.Fhir.Model.Element Reason { get; set; }
        
        /// <summary>
        /// Reason the encounter takes place
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Indication { get; set; }
        
        /// <summary>
        /// Indicates the urgency of the encounter
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Priority { get; set; }
        
        /// <summary>
        /// Details about an admission to a clinic
        /// </summary>
        public Hl7.Fhir.Model.Encounter.EncounterHospitalizationComponent Hospitalization { get; set; }
        
        /// <summary>
        /// List of locations the patient has been at
        /// </summary>
        public List<Hl7.Fhir.Model.Encounter.EncounterLocationComponent> Location { get; set; }
        
        /// <summary>
        /// Department or team providing care
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference ServiceProvider { get; set; }
        
        /// <summary>
        /// Another Encounter this encounter is part of
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference PartOf { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(ClassElement != null )
                result.AddRange(ClassElement.Validate());
            if(Type != null )
                Type.ForEach(elem => result.AddRange(elem.Validate()));
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Participant != null )
                Participant.ForEach(elem => result.AddRange(elem.Validate()));
            if(Fulfills != null )
                result.AddRange(Fulfills.Validate());
            if(StartElement != null )
                result.AddRange(StartElement.Validate());
            if(Length != null )
                result.AddRange(Length.Validate());
            if(Reason != null )
                result.AddRange(Reason.Validate());
            if(Indication != null )
                result.AddRange(Indication.Validate());
            if(Priority != null )
                result.AddRange(Priority.Validate());
            if(Hospitalization != null )
                result.AddRange(Hospitalization.Validate());
            if(Location != null )
                Location.ForEach(elem => result.AddRange(elem.Validate()));
            if(ServiceProvider != null )
                result.AddRange(ServiceProvider.Validate());
            if(PartOf != null )
                result.AddRange(PartOf.Validate());
            
            return result;
        }
    }
    
}
