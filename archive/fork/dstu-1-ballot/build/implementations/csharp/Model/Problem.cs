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
// Generated on Fri, Jun 21, 2013 15:52+1000 for FHIR v0.09
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Detailed information about problems or diagnoses
    /// </summary>
    [FhirResource("Problem")]
    public partial class Problem : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The clinical status of the problem or diagnosis
        /// </summary>
        public enum ProblemStatus
        {
            Provisional, // This is a tentative diagnosis - still a candidate that is under consideration
            Working, // The patient is being treated on the basis that this is the problem, but it is still not confirmed
            Confirmed, // There is sufficient diagnostic and/or clinical evidence to treat this as a confirmed problem
            Refuted, // This problem has been ruled out by diagnostic and clinical evidence
        }
        
        /// <summary>
        /// Conversion of ProblemStatusfrom and into string
        /// <summary>
        public static class ProblemStatusHandling
        {
            public static bool TryParse(string value, out ProblemStatus result)
            {
                result = default(ProblemStatus);
                
                if( value=="provisional")
                    result = ProblemStatus.Provisional;
                else if( value=="working")
                    result = ProblemStatus.Working;
                else if( value=="confirmed")
                    result = ProblemStatus.Confirmed;
                else if( value=="refuted")
                    result = ProblemStatus.Refuted;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ProblemStatus value)
            {
                if( value==ProblemStatus.Provisional )
                    return "provisional";
                else if( value==ProblemStatus.Working )
                    return "working";
                else if( value==ProblemStatus.Confirmed )
                    return "confirmed";
                else if( value==ProblemStatus.Refuted )
                    return "refuted";
                else
                    throw new ArgumentException("Unrecognized ProblemStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The type of relationship between a problem/diagnosis and it's related item
        /// </summary>
        public enum ProblemRelationshipType
        {
            DueTo, // this problem/diagnosis is a consequence of the identified problem/procedure/substance
            Following, // this problem/diagnosis follows the identified problem/procedure/substance, but it is not known whether they are causually linked
        }
        
        /// <summary>
        /// Conversion of ProblemRelationshipTypefrom and into string
        /// <summary>
        public static class ProblemRelationshipTypeHandling
        {
            public static bool TryParse(string value, out ProblemRelationshipType result)
            {
                result = default(ProblemRelationshipType);
                
                if( value=="due-to")
                    result = ProblemRelationshipType.DueTo;
                else if( value=="following")
                    result = ProblemRelationshipType.Following;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ProblemRelationshipType value)
            {
                if( value==ProblemRelationshipType.DueTo )
                    return "due-to";
                else if( value==ProblemRelationshipType.Following )
                    return "following";
                else
                    throw new ArgumentException("Unrecognized ProblemRelationshipType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProblemStageComponent")]
        public partial class ProblemStageComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Simple summary (disease specific)
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Summary { get; set; }
            
            /// <summary>
            /// Formal record of assessment
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Assessment { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProblemLocationComponent")]
        public partial class ProblemLocationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Location - may include laterality
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Precise location details
            /// </summary>
            public Hl7.Fhir.Model.FhirString Details { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProblemEvidenceComponent")]
        public partial class ProblemEvidenceComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Manifestation/symptom
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Supporting information found elsewhere
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Details { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProblemRelatedItemComponent")]
        public partial class ProblemRelatedItemComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// due-to | follows
            /// </summary>
            public Code<Hl7.Fhir.Model.Problem.ProblemRelationshipType> Type { get; set; }
            
            /// <summary>
            /// Relationship target by means of a predefined code
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Relationship target resource
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Target { get; set; }
            
        }
        
        
        /// <summary>
        /// Subject of this problem
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Visit during which the problem was first asserted
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Visit { get; set; }
        
        /// <summary>
        /// Person who asserts this problem
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Asserter { get; set; }
        
        /// <summary>
        /// When the first detected/suspected/entered
        /// </summary>
        public Hl7.Fhir.Model.Date DateAsserted { get; set; }
        
        /// <summary>
        /// Identification of the problem or diagnosis
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
        
        /// <summary>
        /// E.g. complaint | symptom | finding | diagnosis
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Category { get; set; }
        
        /// <summary>
        /// provisional | working | confirmed | refuted
        /// </summary>
        public Code<Hl7.Fhir.Model.Problem.ProblemStatus> Status { get; set; }
        
        /// <summary>
        /// Degree of confidence
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Certainty { get; set; }
        
        /// <summary>
        /// Subjective severity of problem/diagnosis
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
        public Hl7.Fhir.Model.Problem.ProblemStageComponent Stage { get; set; }
        
        /// <summary>
        /// Supporting evidence
        /// </summary>
        public List<Hl7.Fhir.Model.Problem.ProblemEvidenceComponent> Evidence { get; set; }
        
        /// <summary>
        /// Snatomical location, if relevant
        /// </summary>
        public List<Hl7.Fhir.Model.Problem.ProblemLocationComponent> Location { get; set; }
        
        /// <summary>
        /// Causes or precedents for this problem
        /// </summary>
        public List<Hl7.Fhir.Model.Problem.ProblemRelatedItemComponent> RelatedItem { get; set; }
        
        /// <summary>
        /// Additional information about the problem
        /// </summary>
        public Hl7.Fhir.Model.FhirString Notes { get; set; }
        
    }
    
}
