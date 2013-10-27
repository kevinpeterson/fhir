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
    /// Detailed information about conditions, problems or diagnoses
    /// </summary>
    [FhirResource("Condition")]
    [Serializable]
    public partial class Condition : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The clinical status of the Condition or diagnosis
        /// </summary>
        public enum ConditionStatus
        {
            Provisional, // This is a tentative diagnosis - still a candidate that is under consideration.
            Working, // The patient is being treated on the basis that this is the condition, but it is still not confirmed.
            Confirmed, // There is sufficient diagnostic and/or clinical evidence to treat this as a confirmed condition.
            Refuted, // This condition has been ruled out by diagnostic and clinical evidence.
        }
        
        /// <summary>
        /// Conversion of ConditionStatusfrom and into string
        /// <summary>
        public static class ConditionStatusHandling
        {
            public static bool TryParse(string value, out ConditionStatus result)
            {
                result = default(ConditionStatus);
                
                if( value=="provisional")
                    result = ConditionStatus.Provisional;
                else if( value=="working")
                    result = ConditionStatus.Working;
                else if( value=="confirmed")
                    result = ConditionStatus.Confirmed;
                else if( value=="refuted")
                    result = ConditionStatus.Refuted;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ConditionStatus value)
            {
                if( value==ConditionStatus.Provisional )
                    return "provisional";
                else if( value==ConditionStatus.Working )
                    return "working";
                else if( value==ConditionStatus.Confirmed )
                    return "confirmed";
                else if( value==ConditionStatus.Refuted )
                    return "refuted";
                else
                    throw new ArgumentException("Unrecognized ConditionStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The type of relationship between a condition and its related item
        /// </summary>
        public enum ConditionRelationshipType
        {
            DueTo, // this condition is a consequence of the identified condition/procedure/substance.
            Following, // this condition follows the identified condition/procedure/substance, but it is not known whether they are causually linked.
        }
        
        /// <summary>
        /// Conversion of ConditionRelationshipTypefrom and into string
        /// <summary>
        public static class ConditionRelationshipTypeHandling
        {
            public static bool TryParse(string value, out ConditionRelationshipType result)
            {
                result = default(ConditionRelationshipType);
                
                if( value=="due-to")
                    result = ConditionRelationshipType.DueTo;
                else if( value=="following")
                    result = ConditionRelationshipType.Following;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ConditionRelationshipType value)
            {
                if( value==ConditionRelationshipType.DueTo )
                    return "due-to";
                else if( value==ConditionRelationshipType.Following )
                    return "following";
                else
                    throw new ArgumentException("Unrecognized ConditionRelationshipType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConditionRelatedItemComponent")]
        [Serializable]
        public partial class ConditionRelatedItemComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// due-to | follows
            /// </summary>
            public Code<Hl7.Fhir.Model.Condition.ConditionRelationshipType> TypeElement { get; set; }
            
            public Hl7.Fhir.Model.Condition.ConditionRelationshipType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Code<Hl7.Fhir.Model.Condition.ConditionRelationshipType>(value);
                }
            }
            
            /// <summary>
            /// Relationship target by means of a predefined code
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Relationship target resource
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Target { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(Target != null )
                    result.AddRange(Target.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConditionEvidenceComponent")]
        [Serializable]
        public partial class ConditionEvidenceComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Manifestation/symptom
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Supporting information found elsewhere
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Detail { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(Detail != null )
                    Detail.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConditionStageComponent")]
        [Serializable]
        public partial class ConditionStageComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Simple summary (disease specific)
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Summary { get; set; }
            
            /// <summary>
            /// Formal record of assessment
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Assessment { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Summary != null )
                    result.AddRange(Summary.Validate());
                if(Assessment != null )
                    Assessment.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConditionLocationComponent")]
        [Serializable]
        public partial class ConditionLocationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Location - may include laterality
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Precise location details
            /// </summary>
            public Hl7.Fhir.Model.FhirString DetailElement { get; set; }
            
            public string Detail
            {
                get { return DetailElement != null ? DetailElement.Value : null; }
                set
                {
                    if(value == null)
                      DetailElement = null; 
                    else
                      DetailElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(DetailElement != null )
                    result.AddRange(DetailElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Subject of this condition
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Encounter during which the condition was first asserted
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Encounter { get; set; }
        
        /// <summary>
        /// Person who asserts this condition
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Asserter { get; set; }
        
        /// <summary>
        /// When first detected/suspected/entered
        /// </summary>
        public Hl7.Fhir.Model.Date DateAssertedElement { get; set; }
        
        public string DateAsserted
        {
            get { return DateAssertedElement != null ? DateAssertedElement.Value : null; }
            set
            {
                if(value == null)
                  DateAssertedElement = null; 
                else
                  DateAssertedElement = new Hl7.Fhir.Model.Date(value);
            }
        }
        
        /// <summary>
        /// Identification of the condition, problem or diagnosis
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
        
        /// <summary>
        /// E.g. complaint | symptom | finding | diagnosis
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Category { get; set; }
        
        /// <summary>
        /// provisional | working | confirmed | refuted
        /// </summary>
        public Code<Hl7.Fhir.Model.Condition.ConditionStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.Condition.ConditionStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Condition.ConditionStatus>(value);
            }
        }
        
        /// <summary>
        /// Degree of confidence
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Certainty { get; set; }
        
        /// <summary>
        /// Subjective severity of condition
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Severity { get; set; }
        
        /// <summary>
        /// Estimated or actual date, or age
        /// </summary>
        public Hl7.Fhir.Model.Element Onset { get; set; }
        
        /// <summary>
        /// If/when in resolution/remission
        /// </summary>
        public Hl7.Fhir.Model.Element Abatement { get; set; }
        
        /// <summary>
        /// Stage/grade, usually assessed formally
        /// </summary>
        public Hl7.Fhir.Model.Condition.ConditionStageComponent Stage { get; set; }
        
        /// <summary>
        /// Supporting evidence
        /// </summary>
        public List<Hl7.Fhir.Model.Condition.ConditionEvidenceComponent> Evidence { get; set; }
        
        /// <summary>
        /// Anatomical location, if relevant
        /// </summary>
        public List<Hl7.Fhir.Model.Condition.ConditionLocationComponent> Location { get; set; }
        
        /// <summary>
        /// Causes or precedents for this Condition
        /// </summary>
        public List<Hl7.Fhir.Model.Condition.ConditionRelatedItemComponent> RelatedItem { get; set; }
        
        /// <summary>
        /// Additional information about the Condition
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
            
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Encounter != null )
                result.AddRange(Encounter.Validate());
            if(Asserter != null )
                result.AddRange(Asserter.Validate());
            if(DateAssertedElement != null )
                result.AddRange(DateAssertedElement.Validate());
            if(Code != null )
                result.AddRange(Code.Validate());
            if(Category != null )
                result.AddRange(Category.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(Certainty != null )
                result.AddRange(Certainty.Validate());
            if(Severity != null )
                result.AddRange(Severity.Validate());
            if(Onset != null )
                result.AddRange(Onset.Validate());
            if(Abatement != null )
                result.AddRange(Abatement.Validate());
            if(Stage != null )
                result.AddRange(Stage.Validate());
            if(Evidence != null )
                Evidence.ForEach(elem => result.AddRange(elem.Validate()));
            if(Location != null )
                Location.ForEach(elem => result.AddRange(elem.Validate()));
            if(RelatedItem != null )
                RelatedItem.ForEach(elem => result.AddRange(elem.Validate()));
            if(NotesElement != null )
                result.AddRange(NotesElement.Validate());
            
            return result;
        }
    }
    
}
