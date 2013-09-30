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
// Generated on Mon, Jul 8, 2013 22:38+1000 for FHIR v0.09
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// An interaction during which services are provided to the patient
    /// </summary>
    [FhirResource("Visit")]
    public partial class Visit : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Classification of the encounter
        /// </summary>
        public enum EncounterClass
        {
            Inpatient, // A patient that stays overnight
            Outpatient,
            Ambulatory,
            Emergency,
            Home,
            Field,
            Acute,
            NonAcute,
            Daytime,
            Virtual,
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
                else if( value=="acute")
                    result = EncounterClass.Acute;
                else if( value=="non-acute")
                    result = EncounterClass.NonAcute;
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
                else if( value==EncounterClass.Acute )
                    return "acute";
                else if( value==EncounterClass.NonAcute )
                    return "non-acute";
                else if( value==EncounterClass.Daytime )
                    return "daytime";
                else if( value==EncounterClass.Virtual )
                    return "virtual";
                else
                    throw new ArgumentException("Unrecognized EncounterClass value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Medical, cultural or ethical food preferences to help with catering requirements
        /// </summary>
        public enum PatientDiet
        {
            Vegetarian, // food without meat, poultry or seafood
            DiaryFree, // exludes dairy  products
            NutFree, // excluded ingredients containing nuts
            GlutenFree, // excludes ingredients containing gluten
            Vegan, // food without meat, poulry, seafood,  eggs, dairy products and other animal-derived substances
            Halal, // foods that conform to Islamic law 
            Kosher, // foods that conform to Jewish dietary law 
        }
        
        /// <summary>
        /// Conversion of PatientDietfrom and into string
        /// <summary>
        public static class PatientDietHandling
        {
            public static bool TryParse(string value, out PatientDiet result)
            {
                result = default(PatientDiet);
                
                if( value=="vegetarian")
                    result = PatientDiet.Vegetarian;
                else if( value=="diary-free")
                    result = PatientDiet.DiaryFree;
                else if( value=="nut-free")
                    result = PatientDiet.NutFree;
                else if( value=="gluten-free")
                    result = PatientDiet.GlutenFree;
                else if( value=="vegan")
                    result = PatientDiet.Vegan;
                else if( value=="halal")
                    result = PatientDiet.Halal;
                else if( value=="kosher")
                    result = PatientDiet.Kosher;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(PatientDiet value)
            {
                if( value==PatientDiet.Vegetarian )
                    return "vegetarian";
                else if( value==PatientDiet.DiaryFree )
                    return "diary-free";
                else if( value==PatientDiet.NutFree )
                    return "nut-free";
                else if( value==PatientDiet.GlutenFree )
                    return "gluten-free";
                else if( value==PatientDiet.Vegan )
                    return "vegan";
                else if( value==PatientDiet.Halal )
                    return "halal";
                else if( value==PatientDiet.Kosher )
                    return "kosher";
                else
                    throw new ArgumentException("Unrecognized PatientDiet value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Kind of participation
        /// </summary>
        public enum ParticipantType
        {
            Admitter,
            Discharger,
            Responsible,
            Attending,
            Consulting,
            EmergencyContact,
            DischargeContact,
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
                else if( value=="emergency-contact")
                    result = ParticipantType.EmergencyContact;
                else if( value=="discharge-contact")
                    result = ParticipantType.DischargeContact;
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
                else if( value==ParticipantType.EmergencyContact )
                    return "emergency-contact";
                else if( value==ParticipantType.DischargeContact )
                    return "discharge-contact";
                else
                    throw new ArgumentException("Unrecognized ParticipantType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Current state of the encounter
        /// </summary>
        public enum EncounterState
        {
            Planned,
            Current,
            Onleave,
            Finished,
            Cancelled,
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
        [FhirComposite("VisitParticipantComponent")]
        public partial class VisitParticipantComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Kind of involvement of the participant
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Type { get; set; }
            
            /// <summary>
            /// The practitioner that is involved
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Practitioner { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Type != null )
                    Type.ForEach(elem => result.AddRange(elem.Validate()));
                if(Practitioner != null )
                    result.AddRange(Practitioner.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("VisitLocationComponent")]
        public partial class VisitLocationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The location the visit takes place
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
        [FhirComposite("VisitHospitalizationAccomodationComponent")]
        public partial class VisitHospitalizationAccomodationComponent : Hl7.Fhir.Model.Element
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
        [FhirComposite("VisitHospitalizationComponent")]
        public partial class VisitHospitalizationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Pre-admission identifier
            /// </summary>
            public Hl7.Fhir.Model.Identifier PreAdmissionIdentifier { get; set; }
            
            /// <summary>
            /// Tests to be done before admission
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept PreAdmissionTest { get; set; }
            
            /// <summary>
            /// The location the patient came from before admission
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Origin { get; set; }
            
            /// <summary>
            /// Where the patient was admitted from (physician referral, transfer)
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept AdmitSource { get; set; }
            
            /// <summary>
            /// Priod of hospitalization
            /// </summary>
            public Hl7.Fhir.Model.Period Period { get; set; }
            
            /// <summary>
            /// Where the
            /// </summary>
            public List<Hl7.Fhir.Model.Visit.VisitHospitalizationAccomodationComponent> Accomodation { get; set; }
            
            /// <summary>
            /// Dietary restrictions for the patient
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Diet { get; set; }
            
            /// <summary>
            /// Special courtesies (vip, hospital board member)
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> SpecialCourtesy { get; set; }
            
            /// <summary>
            /// Special arrangements (wheelchair, translator, stretcher)
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> SpecialArrangement { get; set; }
            
            /// <summary>
            /// Location the patient is discharged to
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Destination { get; set; }
            
            /// <summary>
            /// Disposition a patient was released into
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept DischargeDisposition { get; set; }
            
            /// <summary>
            /// Is readmission?
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean ReAdmission { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(PreAdmissionIdentifier != null )
                    result.AddRange(PreAdmissionIdentifier.Validate());
                if(PreAdmissionTest != null )
                    result.AddRange(PreAdmissionTest.Validate());
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
                if(ReAdmission != null )
                    result.AddRange(ReAdmission.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Identifier(s) by which this visit is known
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// E.g. active, aborted, finished
        /// </summary>
        public Code<Hl7.Fhir.Model.Visit.EncounterState> Status { get; set; }
        
        /// <summary>
        /// Inpatient | Outpatient etc
        /// </summary>
        public Code<Hl7.Fhir.Model.Visit.EncounterClass> Class { get; set; }
        
        /// <summary>
        /// Specific type of encounter
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
        
        /// <summary>
        /// The patient present at the visit
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// List of participants involved in the encounter
        /// </summary>
        public List<Hl7.Fhir.Model.Visit.VisitParticipantComponent> Participant { get; set; }
        
        /// <summary>
        /// The appointment that scheduled this visit
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Fulfills { get; set; }
        
        /// <summary>
        /// Quantity of time the visit lasted
        /// </summary>
        public Hl7.Fhir.Model.Duration Length { get; set; }
        
        /// <summary>
        /// Reason the visit takes place
        /// </summary>
        public Hl7.Fhir.Model.Element Reason { get; set; }
        
        /// <summary>
        /// Reason the visit takes place
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Indication { get; set; }
        
        /// <summary>
        /// Indicates the urgency of the encounter
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Priority { get; set; }
        
        /// <summary>
        /// Details about an admission to a clinic
        /// </summary>
        public Hl7.Fhir.Model.Visit.VisitHospitalizationComponent Hospitalization { get; set; }
        
        /// <summary>
        /// List of locations the patient has been at
        /// </summary>
        public List<Hl7.Fhir.Model.Visit.VisitLocationComponent> Location { get; set; }
        
        /// <summary>
        /// The department or team that is providing care
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference ServiceProvider { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(Status != null )
                result.AddRange(Status.Validate());
            if(Class != null )
                result.AddRange(Class.Validate());
            if(Type != null )
                result.AddRange(Type.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Participant != null )
                Participant.ForEach(elem => result.AddRange(elem.Validate()));
            if(Fulfills != null )
                result.AddRange(Fulfills.Validate());
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
            
            return result;
        }
    }
    
}
