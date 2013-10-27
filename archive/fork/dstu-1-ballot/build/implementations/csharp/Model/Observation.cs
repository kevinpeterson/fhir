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
    /// Simple observations
    /// </summary>
    [FhirResource("Observation")]
    [Serializable]
    public partial class Observation : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Codes that provide reliability information about an observation
        /// </summary>
        public enum ObservationReliability
        {
            Ok, // The result has no reliability concerns.
            Ongoing, // An early estimate of value; measurement is still occurring.
            Early, // An early estimate of value; processing is still occurring.
            Questionable, // The observation value should be treated with care.
            Calibrating, // The result has been generated while calibration is occurring.
            Error, // The observation could not be completed because of an error.
            Unknown, // No observation value was available.
        }
        
        /// <summary>
        /// Conversion of ObservationReliabilityfrom and into string
        /// <summary>
        public static class ObservationReliabilityHandling
        {
            public static bool TryParse(string value, out ObservationReliability result)
            {
                result = default(ObservationReliability);
                
                if( value=="ok")
                    result = ObservationReliability.Ok;
                else if( value=="ongoing")
                    result = ObservationReliability.Ongoing;
                else if( value=="early")
                    result = ObservationReliability.Early;
                else if( value=="questionable")
                    result = ObservationReliability.Questionable;
                else if( value=="calibrating")
                    result = ObservationReliability.Calibrating;
                else if( value=="error")
                    result = ObservationReliability.Error;
                else if( value=="unknown")
                    result = ObservationReliability.Unknown;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ObservationReliability value)
            {
                if( value==ObservationReliability.Ok )
                    return "ok";
                else if( value==ObservationReliability.Ongoing )
                    return "ongoing";
                else if( value==ObservationReliability.Early )
                    return "early";
                else if( value==ObservationReliability.Questionable )
                    return "questionable";
                else if( value==ObservationReliability.Calibrating )
                    return "calibrating";
                else if( value==ObservationReliability.Error )
                    return "error";
                else if( value==ObservationReliability.Unknown )
                    return "unknown";
                else
                    throw new ArgumentException("Unrecognized ObservationReliability value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ObservationComponentComponent")]
        [Serializable]
        public partial class ObservationComponentComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Kind of component observation
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Name { get; set; }
            
            /// <summary>
            /// Actual component result
            /// </summary>
            public Hl7.Fhir.Model.Element Value { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Name != null )
                    result.AddRange(Name.Validate());
                if(Value != null )
                    result.AddRange(Value.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ObservationReferenceRangeComponent")]
        [Serializable]
        public partial class ObservationReferenceRangeComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The meaning of this range
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Meaning { get; set; }
            
            /// <summary>
            /// Reference
            /// </summary>
            public Hl7.Fhir.Model.Element Range { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Meaning != null )
                    result.AddRange(Meaning.Validate());
                if(Range != null )
                    result.AddRange(Range.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Kind of observation
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Name { get; set; }
        
        /// <summary>
        /// Actual result
        /// </summary>
        public Hl7.Fhir.Model.Element Value { get; set; }
        
        /// <summary>
        /// High, low, normal, etc.
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Interpretation { get; set; }
        
        /// <summary>
        /// Comments about result
        /// </summary>
        public Hl7.Fhir.Model.FhirString CommentsElement { get; set; }
        
        public string Comments
        {
            get { return CommentsElement != null ? CommentsElement.Value : null; }
            set
            {
                if(value == null)
                  CommentsElement = null; 
                else
                  CommentsElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Relevant time/time-period
        /// </summary>
        public Hl7.Fhir.Model.Element Applies { get; set; }
        
        /// <summary>
        /// Date/Time this was made available
        /// </summary>
        public Hl7.Fhir.Model.Instant IssuedElement { get; set; }
        
        public DateTimeOffset? Issued
        {
            get { return IssuedElement != null ? IssuedElement.Value : null; }
            set
            {
                if(value == null)
                  IssuedElement = null; 
                else
                  IssuedElement = new Hl7.Fhir.Model.Instant(value);
            }
        }
        
        /// <summary>
        /// Registered|Interim|Final|Amended|Cancelled|Withdrawn
        /// </summary>
        public Code<Hl7.Fhir.Model.ObservationStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.ObservationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.ObservationStatus>(value);
            }
        }
        
        /// <summary>
        /// If quality issues exist (mostly devices)
        /// </summary>
        public Code<Hl7.Fhir.Model.Observation.ObservationReliability> ReliabilityElement { get; set; }
        
        public Hl7.Fhir.Model.Observation.ObservationReliability? Reliability
        {
            get { return ReliabilityElement != null ? ReliabilityElement.Value : null; }
            set
            {
                if(value == null)
                  ReliabilityElement = null; 
                else
                  ReliabilityElement = new Code<Hl7.Fhir.Model.Observation.ObservationReliability>(value);
            }
        }
        
        /// <summary>
        /// Observed body part
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept BodySite { get; set; }
        
        /// <summary>
        /// How it was done
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Method { get; set; }
        
        /// <summary>
        /// Observation id
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// Who/what this is about
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Who did the observation
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Performer { get; set; }
        
        /// <summary>
        /// Provides guide for interpretation
        /// </summary>
        public List<Hl7.Fhir.Model.Observation.ObservationReferenceRangeComponent> ReferenceRange { get; set; }
        
        /// <summary>
        /// Component observation
        /// </summary>
        public List<Hl7.Fhir.Model.Observation.ObservationComponentComponent> Component { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Name != null )
                result.AddRange(Name.Validate());
            if(Value != null )
                result.AddRange(Value.Validate());
            if(Interpretation != null )
                result.AddRange(Interpretation.Validate());
            if(CommentsElement != null )
                result.AddRange(CommentsElement.Validate());
            if(Applies != null )
                result.AddRange(Applies.Validate());
            if(IssuedElement != null )
                result.AddRange(IssuedElement.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(ReliabilityElement != null )
                result.AddRange(ReliabilityElement.Validate());
            if(BodySite != null )
                result.AddRange(BodySite.Validate());
            if(Method != null )
                result.AddRange(Method.Validate());
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Performer != null )
                result.AddRange(Performer.Validate());
            if(ReferenceRange != null )
                ReferenceRange.ForEach(elem => result.AddRange(elem.Validate()));
            if(Component != null )
                Component.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
