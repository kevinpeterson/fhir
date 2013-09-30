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
    /// Immunization event information
    /// </summary>
    [FhirResource("Immunization")]
    [Serializable]
    public partial class Immunization : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationVaccinationProtocolComponent")]
        [Serializable]
        public partial class ImmunizationVaccinationProtocolComponent : Hl7.Fhir.Model.Element
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
            
            /// <summary>
            /// Dose Number Recommendation
            /// </summary>
            public Hl7.Fhir.Model.Integer SeriesDosesElement { get; set; }
            
            public int? SeriesDoses
            {
                get { return SeriesDosesElement != null ? SeriesDosesElement.Value : null; }
                set
                {
                    if(value == null)
                      SeriesDosesElement = null; 
                    else
                      SeriesDosesElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Targeted Disease
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept DoseTarget { get; set; }
            
            /// <summary>
            /// Dose Status
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept DoseStatus { get; set; }
            
            /// <summary>
            /// Dose Status Reason
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept DoseStatusReason { get; set; }
            
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
                if(SeriesDosesElement != null )
                    result.AddRange(SeriesDosesElement.Validate());
                if(DoseTarget != null )
                    result.AddRange(DoseTarget.Validate());
                if(DoseStatus != null )
                    result.AddRange(DoseStatus.Validate());
                if(DoseStatusReason != null )
                    result.AddRange(DoseStatusReason.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationExplanationComponent")]
        [Serializable]
        public partial class ImmunizationExplanationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Administration Reasons
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Reason { get; set; }
            
            /// <summary>
            /// Explanation of refusal / exemption
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> RefusalReason { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Reason != null )
                    Reason.ForEach(elem => result.AddRange(elem.Validate()));
                if(RefusalReason != null )
                    RefusalReason.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationReactionComponent")]
        [Serializable]
        public partial class ImmunizationReactionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Reaction Date
            /// </summary>
            public Hl7.Fhir.Model.FhirDateTime DateElement { get; set; }
            
            public string Date
            {
                get { return DateElement != null ? DateElement.Value : null; }
                set
                {
                    if(value == null)
                      DateElement = null; 
                    else
                      DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                }
            }
            
            /// <summary>
            /// Details of the reaction
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Detail { get; set; }
            
            /// <summary>
            /// Self-reported indicator
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean ReportedElement { get; set; }
            
            public bool? Reported
            {
                get { return ReportedElement != null ? ReportedElement.Value : null; }
                set
                {
                    if(value == null)
                      ReportedElement = null; 
                    else
                      ReportedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(DateElement != null )
                    result.AddRange(DateElement.Validate());
                if(Detail != null )
                    result.AddRange(Detail.Validate());
                if(ReportedElement != null )
                    result.AddRange(ReportedElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Vaccination  Administration Date
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime DateElement { get; set; }
        
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// Vaccine Product Administered
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept VaccineType { get; set; }
        
        /// <summary>
        /// Who this immunization was adminstered to
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Resual Indicator
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean RefusedIndicatorElement { get; set; }
        
        public bool? RefusedIndicator
        {
            get { return RefusedIndicatorElement != null ? RefusedIndicatorElement.Value : null; }
            set
            {
                if(value == null)
                  RefusedIndicatorElement = null; 
                else
                  RefusedIndicatorElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        /// <summary>
        /// If self-reported
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean ReportedElement { get; set; }
        
        public bool? Reported
        {
            get { return ReportedElement != null ? ReportedElement.Value : null; }
            set
            {
                if(value == null)
                  ReportedElement = null; 
                else
                  ReportedElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        /// <summary>
        /// Vaccine Administering Provider Name
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Performer { get; set; }
        
        /// <summary>
        /// Vaccine Ordering Provider Name
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Requester { get; set; }
        
        /// <summary>
        /// Vaccine Manufacturer
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Manufacturer { get; set; }
        
        /// <summary>
        /// Vaccine Administration Facility
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Location { get; set; }
        
        /// <summary>
        /// Vaccine Lot Number
        /// </summary>
        public Hl7.Fhir.Model.FhirString LotNumberElement { get; set; }
        
        public string LotNumber
        {
            get { return LotNumberElement != null ? LotNumberElement.Value : null; }
            set
            {
                if(value == null)
                  LotNumberElement = null; 
                else
                  LotNumberElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Vaccine Expiration Date
        /// </summary>
        public Hl7.Fhir.Model.Date ExpirationDateElement { get; set; }
        
        public string ExpirationDate
        {
            get { return ExpirationDateElement != null ? ExpirationDateElement.Value : null; }
            set
            {
                if(value == null)
                  ExpirationDateElement = null; 
                else
                  ExpirationDateElement = new Hl7.Fhir.Model.Date(value);
            }
        }
        
        /// <summary>
        /// Vaccine  Site of Administration
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Site { get; set; }
        
        /// <summary>
        /// Vaccine Route of Administration
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Route { get; set; }
        
        /// <summary>
        /// Vaccine dosage
        /// </summary>
        public Hl7.Fhir.Model.Quantity DoseQuantity { get; set; }
        
        /// <summary>
        /// Administration / Refusal Reasons
        /// </summary>
        public Hl7.Fhir.Model.Immunization.ImmunizationExplanationComponent Explanation { get; set; }
        
        /// <summary>
        /// Details of a reaction that follows immunization
        /// </summary>
        public List<Hl7.Fhir.Model.Immunization.ImmunizationReactionComponent> Reaction { get; set; }
        
        /// <summary>
        /// Vaccine Administration Protocol
        /// </summary>
        public Hl7.Fhir.Model.Immunization.ImmunizationVaccinationProtocolComponent VaccinationProtocol { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(DateElement != null )
                result.AddRange(DateElement.Validate());
            if(VaccineType != null )
                result.AddRange(VaccineType.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(RefusedIndicatorElement != null )
                result.AddRange(RefusedIndicatorElement.Validate());
            if(ReportedElement != null )
                result.AddRange(ReportedElement.Validate());
            if(Performer != null )
                result.AddRange(Performer.Validate());
            if(Requester != null )
                result.AddRange(Requester.Validate());
            if(Manufacturer != null )
                result.AddRange(Manufacturer.Validate());
            if(Location != null )
                result.AddRange(Location.Validate());
            if(LotNumberElement != null )
                result.AddRange(LotNumberElement.Validate());
            if(ExpirationDateElement != null )
                result.AddRange(ExpirationDateElement.Validate());
            if(Site != null )
                result.AddRange(Site.Validate());
            if(Route != null )
                result.AddRange(Route.Validate());
            if(DoseQuantity != null )
                result.AddRange(DoseQuantity.Validate());
            if(Explanation != null )
                result.AddRange(Explanation.Validate());
            if(Reaction != null )
                Reaction.ForEach(elem => result.AddRange(elem.Validate()));
            if(VaccinationProtocol != null )
                result.AddRange(VaccinationProtocol.Validate());
            
            return result;
        }
    }
    
}
