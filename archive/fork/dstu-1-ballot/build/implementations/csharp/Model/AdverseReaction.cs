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
    /// Specific reactions to a substance
    /// </summary>
    [FhirResource("AdverseReaction")]
    [Serializable]
    public partial class AdverseReaction : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The severity of an adverse reaction.
        /// </summary>
        public enum ReactionSeverity
        {
            Severe, // Severe complications arose due to the reaction.
            Serious, // Serious inconvenience to the subject.
            Moderate, // Moderate inconvenience to the subject.
            Minor, // Minor inconvenience to the subject.
        }
        
        /// <summary>
        /// Conversion of ReactionSeverityfrom and into string
        /// <summary>
        public static class ReactionSeverityHandling
        {
            public static bool TryParse(string value, out ReactionSeverity result)
            {
                result = default(ReactionSeverity);
                
                if( value=="severe")
                    result = ReactionSeverity.Severe;
                else if( value=="serious")
                    result = ReactionSeverity.Serious;
                else if( value=="moderate")
                    result = ReactionSeverity.Moderate;
                else if( value=="minor")
                    result = ReactionSeverity.Minor;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ReactionSeverity value)
            {
                if( value==ReactionSeverity.Severe )
                    return "severe";
                else if( value==ReactionSeverity.Serious )
                    return "serious";
                else if( value==ReactionSeverity.Moderate )
                    return "moderate";
                else if( value==ReactionSeverity.Minor )
                    return "minor";
                else
                    throw new ArgumentException("Unrecognized ReactionSeverity value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The type of exposure that resulted in an adverse reaction
        /// </summary>
        public enum ExposureType
        {
            Drugadmin, // Drug Administration.
            Immuniz, // Immunization.
            Coincidental, // In the same area as the substance.
        }
        
        /// <summary>
        /// Conversion of ExposureTypefrom and into string
        /// <summary>
        public static class ExposureTypeHandling
        {
            public static bool TryParse(string value, out ExposureType result)
            {
                result = default(ExposureType);
                
                if( value=="drugadmin")
                    result = ExposureType.Drugadmin;
                else if( value=="immuniz")
                    result = ExposureType.Immuniz;
                else if( value=="coincidental")
                    result = ExposureType.Coincidental;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ExposureType value)
            {
                if( value==ExposureType.Drugadmin )
                    return "drugadmin";
                else if( value==ExposureType.Immuniz )
                    return "immuniz";
                else if( value==ExposureType.Coincidental )
                    return "coincidental";
                else
                    throw new ArgumentException("Unrecognized ExposureType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// How likely is it that the given exposure caused a reaction
        /// </summary>
        public enum CausalityExpectation
        {
            Likely, // Likely that this specific exposure caused the reaction.
            Unlikely, // Unlikely that this specific exposure caused the reaction - the exposure is being linked to for information purposes.
            Confirmed, // It has been confirmed that this exposure was one of the causes of the reaction.
            Unknown, // It is unknown whether this exposure had anything to do with the reaction.
        }
        
        /// <summary>
        /// Conversion of CausalityExpectationfrom and into string
        /// <summary>
        public static class CausalityExpectationHandling
        {
            public static bool TryParse(string value, out CausalityExpectation result)
            {
                result = default(CausalityExpectation);
                
                if( value=="likely")
                    result = CausalityExpectation.Likely;
                else if( value=="unlikely")
                    result = CausalityExpectation.Unlikely;
                else if( value=="confirmed")
                    result = CausalityExpectation.Confirmed;
                else if( value=="unknown")
                    result = CausalityExpectation.Unknown;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CausalityExpectation value)
            {
                if( value==CausalityExpectation.Likely )
                    return "likely";
                else if( value==CausalityExpectation.Unlikely )
                    return "unlikely";
                else if( value==CausalityExpectation.Confirmed )
                    return "confirmed";
                else if( value==CausalityExpectation.Unknown )
                    return "unknown";
                else
                    throw new ArgumentException("Unrecognized CausalityExpectation value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("AdverseReactionSymptomComponent")]
        [Serializable]
        public partial class AdverseReactionSymptomComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Indicates the specific sign or symptom that was observed
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// The severity of the sign or symptom
            /// </summary>
            public Code<Hl7.Fhir.Model.AdverseReaction.ReactionSeverity> SeverityElement { get; set; }
            
            public Hl7.Fhir.Model.AdverseReaction.ReactionSeverity? Severity
            {
                get { return SeverityElement != null ? SeverityElement.Value : null; }
                set
                {
                    if(value == null)
                      SeverityElement = null; 
                    else
                      SeverityElement = new Code<Hl7.Fhir.Model.AdverseReaction.ReactionSeverity>(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(SeverityElement != null )
                    result.AddRange(SeverityElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("AdverseReactionExposureComponent")]
        [Serializable]
        public partial class AdverseReactionExposureComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// When the exposure occurred
            /// </summary>
            public Hl7.Fhir.Model.FhirDateTime ExposureDateElement { get; set; }
            
            public string ExposureDate
            {
                get { return ExposureDateElement != null ? ExposureDateElement.Value : null; }
                set
                {
                    if(value == null)
                      ExposureDateElement = null; 
                    else
                      ExposureDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                }
            }
            
            /// <summary>
            /// The type of exposure
            /// </summary>
            public Code<Hl7.Fhir.Model.AdverseReaction.ExposureType> ExposureTypeElement { get; set; }
            
            public Hl7.Fhir.Model.AdverseReaction.ExposureType? ExposureType
            {
                get { return ExposureTypeElement != null ? ExposureTypeElement.Value : null; }
                set
                {
                    if(value == null)
                      ExposureTypeElement = null; 
                    else
                      ExposureTypeElement = new Code<Hl7.Fhir.Model.AdverseReaction.ExposureType>(value);
                }
            }
            
            /// <summary>
            /// A statement of how confident that the recorder was that this exposure caused the reaction
            /// </summary>
            public Code<Hl7.Fhir.Model.AdverseReaction.CausalityExpectation> CausalityExpectationElement { get; set; }
            
            public Hl7.Fhir.Model.AdverseReaction.CausalityExpectation? CausalityExpectation
            {
                get { return CausalityExpectationElement != null ? CausalityExpectationElement.Value : null; }
                set
                {
                    if(value == null)
                      CausalityExpectationElement = null; 
                    else
                      CausalityExpectationElement = new Code<Hl7.Fhir.Model.AdverseReaction.CausalityExpectation>(value);
                }
            }
            
            /// <summary>
            /// Substance(s) that is presumed to have caused the adverse reaction
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Substance { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(ExposureDateElement != null )
                    result.AddRange(ExposureDateElement.Validate());
                if(ExposureTypeElement != null )
                    result.AddRange(ExposureTypeElement.Validate());
                if(CausalityExpectationElement != null )
                    result.AddRange(CausalityExpectationElement.Validate());
                if(Substance != null )
                    result.AddRange(Substance.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// When the reaction occurred
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime ReactionDateElement { get; set; }
        
        public string ReactionDate
        {
            get { return ReactionDateElement != null ? ReactionDateElement.Value : null; }
            set
            {
                if(value == null)
                  ReactionDateElement = null; 
                else
                  ReactionDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// The subject of the adverse reaction
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// To say that a reaction to substance did not occur
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean DidNotOccurFlagElement { get; set; }
        
        public bool? DidNotOccurFlag
        {
            get { return DidNotOccurFlagElement != null ? DidNotOccurFlagElement.Value : null; }
            set
            {
                if(value == null)
                  DidNotOccurFlagElement = null; 
                else
                  DidNotOccurFlagElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        /// <summary>
        /// Who recorded the reaction
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Recorder { get; set; }
        
        /// <summary>
        /// The signs and symptoms that were observed as part of the reaction
        /// </summary>
        public List<Hl7.Fhir.Model.AdverseReaction.AdverseReactionSymptomComponent> Symptom { get; set; }
        
        /// <summary>
        /// An exposure to a substance that preceded a reaction occurrence
        /// </summary>
        public List<Hl7.Fhir.Model.AdverseReaction.AdverseReactionExposureComponent> Exposure { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(ReactionDateElement != null )
                result.AddRange(ReactionDateElement.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(DidNotOccurFlagElement != null )
                result.AddRange(DidNotOccurFlagElement.Validate());
            if(Recorder != null )
                result.AddRange(Recorder.Validate());
            if(Symptom != null )
                Symptom.ForEach(elem => result.AddRange(elem.Validate()));
            if(Exposure != null )
                Exposure.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
