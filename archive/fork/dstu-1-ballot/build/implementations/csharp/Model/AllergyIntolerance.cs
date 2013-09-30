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
    /// Allergy/Intolerance
    /// </summary>
    [FhirResource("AllergyIntolerance")]
    [Serializable]
    public partial class AllergyIntolerance : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The status of the adverse sensitivity
        /// </summary>
        public enum SensitivityStatus
        {
            Suspected, // A suspected sensitivity to a substance.
            Confirmed, // The sensitivity has been confirmed and is active.
            Refuted, // The sensitivity has been shown to never have existed.
            Resolved, // The sensitivity used to exist but no longer does.
        }
        
        /// <summary>
        /// Conversion of SensitivityStatusfrom and into string
        /// <summary>
        public static class SensitivityStatusHandling
        {
            public static bool TryParse(string value, out SensitivityStatus result)
            {
                result = default(SensitivityStatus);
                
                if( value=="suspected")
                    result = SensitivityStatus.Suspected;
                else if( value=="confirmed")
                    result = SensitivityStatus.Confirmed;
                else if( value=="refuted")
                    result = SensitivityStatus.Refuted;
                else if( value=="resolved")
                    result = SensitivityStatus.Resolved;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SensitivityStatus value)
            {
                if( value==SensitivityStatus.Suspected )
                    return "suspected";
                else if( value==SensitivityStatus.Confirmed )
                    return "confirmed";
                else if( value==SensitivityStatus.Refuted )
                    return "refuted";
                else if( value==SensitivityStatus.Resolved )
                    return "resolved";
                else
                    throw new ArgumentException("Unrecognized SensitivityStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The criticality of an adverse sensitivity
        /// </summary>
        public enum Criticality
        {
            Fatal, // Likely to result in death if re-exposed.
            High, // Likely to result in reactions that will need to be treated if re-exposed.
            Medium, // Likely to result in reactions that will inconvenience the subject.
            Low, // Not likely to result in any inconveniences for the subject.
        }
        
        /// <summary>
        /// Conversion of Criticalityfrom and into string
        /// <summary>
        public static class CriticalityHandling
        {
            public static bool TryParse(string value, out Criticality result)
            {
                result = default(Criticality);
                
                if( value=="fatal")
                    result = Criticality.Fatal;
                else if( value=="high")
                    result = Criticality.High;
                else if( value=="medium")
                    result = Criticality.Medium;
                else if( value=="low")
                    result = Criticality.Low;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(Criticality value)
            {
                if( value==Criticality.Fatal )
                    return "fatal";
                else if( value==Criticality.High )
                    return "high";
                else if( value==Criticality.Medium )
                    return "medium";
                else if( value==Criticality.Low )
                    return "low";
                else
                    throw new ArgumentException("Unrecognized Criticality value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The type of an adverse sensitivity
        /// </summary>
        public enum SensitivityType
        {
            Allergy, // Allergic Reaction.
            Intolerance, // Non-Allergic Reaction.
            Unknown, // Unknown type.
        }
        
        /// <summary>
        /// Conversion of SensitivityTypefrom and into string
        /// <summary>
        public static class SensitivityTypeHandling
        {
            public static bool TryParse(string value, out SensitivityType result)
            {
                result = default(SensitivityType);
                
                if( value=="allergy")
                    result = SensitivityType.Allergy;
                else if( value=="intolerance")
                    result = SensitivityType.Intolerance;
                else if( value=="unknown")
                    result = SensitivityType.Unknown;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SensitivityType value)
            {
                if( value==SensitivityType.Allergy )
                    return "allergy";
                else if( value==SensitivityType.Intolerance )
                    return "intolerance";
                else if( value==SensitivityType.Unknown )
                    return "unknown";
                else
                    throw new ArgumentException("Unrecognized SensitivityType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// An external identifier for the sensitivity
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// Criticality of the sensitivity
        /// </summary>
        public Code<Hl7.Fhir.Model.AllergyIntolerance.Criticality> Criticality_Element { get; set; }
        
        public Hl7.Fhir.Model.AllergyIntolerance.Criticality? Criticality_
        {
            get { return Criticality_Element != null ? Criticality_Element.Value : null; }
            set
            {
                if(value == null)
                  Criticality_Element = null; 
                else
                  Criticality_Element = new Code<Hl7.Fhir.Model.AllergyIntolerance.Criticality>(value);
            }
        }
        
        /// <summary>
        /// Type of the sensitivity
        /// </summary>
        public Code<Hl7.Fhir.Model.AllergyIntolerance.SensitivityType> SensitivityType_Element { get; set; }
        
        public Hl7.Fhir.Model.AllergyIntolerance.SensitivityType? SensitivityType_
        {
            get { return SensitivityType_Element != null ? SensitivityType_Element.Value : null; }
            set
            {
                if(value == null)
                  SensitivityType_Element = null; 
                else
                  SensitivityType_Element = new Code<Hl7.Fhir.Model.AllergyIntolerance.SensitivityType>(value);
            }
        }
        
        /// <summary>
        /// Date when the sensitivity was recorded
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime RecordedDateElement { get; set; }
        
        public string RecordedDate
        {
            get { return RecordedDateElement != null ? RecordedDateElement.Value : null; }
            set
            {
                if(value == null)
                  RecordedDateElement = null; 
                else
                  RecordedDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// Status of the sensitivity
        /// </summary>
        public Code<Hl7.Fhir.Model.AllergyIntolerance.SensitivityStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.AllergyIntolerance.SensitivityStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.AllergyIntolerance.SensitivityStatus>(value);
            }
        }
        
        /// <summary>
        /// Who the sensitivity is for
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Who recorded the sensitivity
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Recorder { get; set; }
        
        /// <summary>
        /// The substance that causes the sensitivity
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Substance { get; set; }
        
        /// <summary>
        /// Reactions associated with the sensitivity
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Reaction { get; set; }
        
        /// <summary>
        /// Observations that confirm or refute the sensitivity
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> SensitivityTest { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(Criticality_Element != null )
                result.AddRange(Criticality_Element.Validate());
            if(SensitivityType_Element != null )
                result.AddRange(SensitivityType_Element.Validate());
            if(RecordedDateElement != null )
                result.AddRange(RecordedDateElement.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Recorder != null )
                result.AddRange(Recorder.Validate());
            if(Substance != null )
                result.AddRange(Substance.Validate());
            if(Reaction != null )
                Reaction.ForEach(elem => result.AddRange(elem.Validate()));
            if(SensitivityTest != null )
                SensitivityTest.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
