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
    /// An immunization profile
    /// </summary>
    [FhirResource("ImmunizationProfile")]
    [Serializable]
    public partial class ImmunizationProfile : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The patient's status with respect to a vaccination protocol
        /// </summary>
        public enum ImmunizationForecastStatus
        {
            DUE, // This immunization is due to be given now.
        }
        
        /// <summary>
        /// Conversion of ImmunizationForecastStatusfrom and into string
        /// <summary>
        public static class ImmunizationForecastStatusHandling
        {
            public static bool TryParse(string value, out ImmunizationForecastStatus result)
            {
                result = default(ImmunizationForecastStatus);
                
                if( value=="DUE")
                    result = ImmunizationForecastStatus.DUE;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ImmunizationForecastStatus value)
            {
                if( value==ImmunizationForecastStatus.DUE )
                    return "DUE";
                else
                    throw new ArgumentException("Unrecognized ImmunizationForecastStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationProfileRecommendationProtocolComponent")]
        [Serializable]
        public partial class ImmunizationProfileRecommendationProtocolComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Dose Number
            /// </summary>
            public Hl7.Fhir.Model.Integer DoseSequenceElement { get; set; }
            
            public int? DoseSequence
            {
                get { return DoseSequenceElement != null ? DoseSequenceElement.Value : null; }
                set
                {
                    if(value == null)
                      DoseSequenceElement = null; 
                    else
                      DoseSequenceElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Vaccine Administration Protocol Description
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
            /// Vaccine Administration Protocol Authority
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Authority { get; set; }
            
            /// <summary>
            /// Vaccine Series
            /// </summary>
            public Hl7.Fhir.Model.FhirString SeriesElement { get; set; }
            
            public string Series
            {
                get { return SeriesElement != null ? SeriesElement.Value : null; }
                set
                {
                    if(value == null)
                      SeriesElement = null; 
                    else
                      SeriesElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(DoseSequenceElement != null )
                    result.AddRange(DoseSequenceElement.Validate());
                if(DescriptionElement != null )
                    result.AddRange(DescriptionElement.Validate());
                if(Authority != null )
                    result.AddRange(Authority.Validate());
                if(SeriesElement != null )
                    result.AddRange(SeriesElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationProfileRecommendationDateCriterionComponent")]
        [Serializable]
        public partial class ImmunizationProfileRecommendationDateCriterionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Date classification of recommendation
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Date recommendation
            /// </summary>
            public Hl7.Fhir.Model.FhirDateTime ValueElement { get; set; }
            
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if(value == null)
                      ValueElement = null; 
                    else
                      ValueElement = new Hl7.Fhir.Model.FhirDateTime(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(ValueElement != null )
                    result.AddRange(ValueElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationProfileRecommendationSupportingAdverseEventReportComponent")]
        [Serializable]
        public partial class ImmunizationProfileRecommendationSupportingAdverseEventReportComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Adverse event report identifier
            /// </summary>
            public List<Hl7.Fhir.Model.Id> IdentifierElement { get; set; }
            
            public IEnumerable<string> Identifier
            {
                get { return IdentifierElement != null ? IdentifierElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      IdentifierElement = null; 
                    else
                      IdentifierElement = new List<Hl7.Fhir.Model.Id>(value.Select(elem=>new Hl7.Fhir.Model.Id(elem)));
                }
            }
            
            /// <summary>
            /// Adverse event report classification
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept ReportType { get; set; }
            
            /// <summary>
            /// Adverse event report date
            /// </summary>
            public Hl7.Fhir.Model.FhirDateTime ReportDateElement { get; set; }
            
            public string ReportDate
            {
                get { return ReportDateElement != null ? ReportDateElement.Value : null; }
                set
                {
                    if(value == null)
                      ReportDateElement = null; 
                    else
                      ReportDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                }
            }
            
            /// <summary>
            /// Adverse event report text
            /// </summary>
            public Hl7.Fhir.Model.FhirString TextElement { get; set; }
            
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if(value == null)
                      TextElement = null; 
                    else
                      TextElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Documented reaction
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Reaction { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(IdentifierElement != null )
                    IdentifierElement.ForEach(elem => result.AddRange(elem.Validate()));
                if(ReportType != null )
                    result.AddRange(ReportType.Validate());
                if(ReportDateElement != null )
                    result.AddRange(ReportDateElement.Validate());
                if(TextElement != null )
                    result.AddRange(TextElement.Validate());
                if(Reaction != null )
                    Reaction.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationProfileRecommendationComponent")]
        [Serializable]
        public partial class ImmunizationProfileRecommendationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Recommendation date
            /// </summary>
            public Hl7.Fhir.Model.FhirDateTime RecommendationDateElement { get; set; }
            
            public string RecommendationDate
            {
                get { return RecommendationDateElement != null ? RecommendationDateElement.Value : null; }
                set
                {
                    if(value == null)
                      RecommendationDateElement = null; 
                    else
                      RecommendationDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                }
            }
            
            /// <summary>
            /// Vaccine that pertains to the recommendation
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept VaccineType { get; set; }
            
            /// <summary>
            /// Recommended dose number
            /// </summary>
            public Hl7.Fhir.Model.Integer DoseNumberElement { get; set; }
            
            public int? DoseNumber
            {
                get { return DoseNumberElement != null ? DoseNumberElement.Value : null; }
                set
                {
                    if(value == null)
                      DoseNumberElement = null; 
                    else
                      DoseNumberElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Vaccine administration status
            /// </summary>
            public Code<Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatus> ForecastStatusElement { get; set; }
            
            public Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatus? ForecastStatus
            {
                get { return ForecastStatusElement != null ? ForecastStatusElement.Value : null; }
                set
                {
                    if(value == null)
                      ForecastStatusElement = null; 
                    else
                      ForecastStatusElement = new Code<Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatus>(value);
                }
            }
            
            /// <summary>
            /// Pertinent dates
            /// </summary>
            public List<Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent> DateCriterion { get; set; }
            
            /// <summary>
            /// Vaccine Administration Protocol
            /// </summary>
            public Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent Protocol { get; set; }
            
            /// <summary>
            /// Supporting Immunization
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> SupportingImmunization { get; set; }
            
            /// <summary>
            /// Supporting adverse event report
            /// </summary>
            public List<Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent> SupportingAdverseEventReport { get; set; }
            
            /// <summary>
            /// Supporting Patient Observation
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> SupportingPatientObservation { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(RecommendationDateElement != null )
                    result.AddRange(RecommendationDateElement.Validate());
                if(VaccineType != null )
                    result.AddRange(VaccineType.Validate());
                if(DoseNumberElement != null )
                    result.AddRange(DoseNumberElement.Validate());
                if(ForecastStatusElement != null )
                    result.AddRange(ForecastStatusElement.Validate());
                if(DateCriterion != null )
                    DateCriterion.ForEach(elem => result.AddRange(elem.Validate()));
                if(Protocol != null )
                    result.AddRange(Protocol.Validate());
                if(SupportingImmunization != null )
                    SupportingImmunization.ForEach(elem => result.AddRange(elem.Validate()));
                if(SupportingAdverseEventReport != null )
                    SupportingAdverseEventReport.ForEach(elem => result.AddRange(elem.Validate()));
                if(SupportingPatientObservation != null )
                    SupportingPatientObservation.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Who this profile is for
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Vaccine administration recommendations
        /// </summary>
        public List<Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationComponent> Recommendation { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Recommendation != null )
                Recommendation.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
