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
    /// A Diagnostic report - a combination of request information, atomic results, images, interpretation, and formatted reports
    /// </summary>
    [FhirResource("DiagnosticReport")]
    [Serializable]
    public partial class DiagnosticReport : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DiagnosticReportRequestDetailComponent")]
        [Serializable]
        public partial class DiagnosticReportRequestDetailComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Context where request was made
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Encounter { get; set; }
            
            /// <summary>
            /// Id assigned by requester
            /// </summary>
            public Hl7.Fhir.Model.Identifier RequestOrderId { get; set; }
            
            /// <summary>
            /// Receiver's Id for the request
            /// </summary>
            public Hl7.Fhir.Model.Identifier ReceiverOrderId { get; set; }
            
            /// <summary>
            /// Test Requested
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> RequestTest { get; set; }
            
            /// <summary>
            /// Location of requested test (if applicable)
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept BodySite { get; set; }
            
            /// <summary>
            /// Responsible for request
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Requester { get; set; }
            
            /// <summary>
            /// Clinical information provided
            /// </summary>
            public Hl7.Fhir.Model.FhirString ClinicalInfoElement { get; set; }
            
            public string ClinicalInfo
            {
                get { return ClinicalInfoElement != null ? ClinicalInfoElement.Value : null; }
                set
                {
                    if(value == null)
                      ClinicalInfoElement = null; 
                    else
                      ClinicalInfoElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Encounter != null )
                    result.AddRange(Encounter.Validate());
                if(RequestOrderId != null )
                    result.AddRange(RequestOrderId.Validate());
                if(ReceiverOrderId != null )
                    result.AddRange(ReceiverOrderId.Validate());
                if(RequestTest != null )
                    RequestTest.ForEach(elem => result.AddRange(elem.Validate()));
                if(BodySite != null )
                    result.AddRange(BodySite.Validate());
                if(Requester != null )
                    result.AddRange(Requester.Validate());
                if(ClinicalInfoElement != null )
                    result.AddRange(ClinicalInfoElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ResultGroupComponent")]
        [Serializable]
        public partial class ResultGroupComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Name/Code for this group of results
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Name { get; set; }
            
            /// <summary>
            /// Specimen details for this group
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Specimen { get; set; }
            
            /// <summary>
            /// Nested Report Group
            /// </summary>
            public List<Hl7.Fhir.Model.DiagnosticReport.ResultGroupComponent> Group { get; set; }
            
            /// <summary>
            /// An atomic data result
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Result { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Name != null )
                    result.AddRange(Name.Validate());
                if(Specimen != null )
                    result.AddRange(Specimen.Validate());
                if(Group != null )
                    Group.ForEach(elem => result.AddRange(elem.Validate()));
                if(Result != null )
                    Result.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// registered|interim|final|amended|cancelled|withdrawn
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
        /// Date this version was released
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime IssuedElement { get; set; }
        
        public string Issued
        {
            get { return IssuedElement != null ? IssuedElement.Value : null; }
            set
            {
                if(value == null)
                  IssuedElement = null; 
                else
                  IssuedElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// The subject of the report
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Responsible Diagnostic Service
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Performer { get; set; }
        
        /// <summary>
        /// Id for external references to this report
        /// </summary>
        public Hl7.Fhir.Model.Identifier ReportId { get; set; }
        
        /// <summary>
        /// What was requested
        /// </summary>
        public List<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportRequestDetailComponent> RequestDetail { get; set; }
        
        /// <summary>
        /// Biochemistry, Haematology etc.
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept ServiceCategory { get; set; }
        
        /// <summary>
        /// Effective time of diagnostic report
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime DiagnosticTimeElement { get; set; }
        
        public string DiagnosticTime
        {
            get { return DiagnosticTimeElement != null ? DiagnosticTimeElement.Value : null; }
            set
            {
                if(value == null)
                  DiagnosticTimeElement = null; 
                else
                  DiagnosticTimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// Results grouped by specimen/kind/category
        /// </summary>
        public Hl7.Fhir.Model.DiagnosticReport.ResultGroupComponent Results { get; set; }
        
        /// <summary>
        /// Key images associated with this report
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Image { get; set; }
        
        /// <summary>
        /// Clinical Interpretation of test results
        /// </summary>
        public Hl7.Fhir.Model.FhirString ConclusionElement { get; set; }
        
        public string Conclusion
        {
            get { return ConclusionElement != null ? ConclusionElement.Value : null; }
            set
            {
                if(value == null)
                  ConclusionElement = null; 
                else
                  ConclusionElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Codes for the conclusion
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> CodedDiagnosis { get; set; }
        
        /// <summary>
        /// Entire Report as issued
        /// </summary>
        public List<Hl7.Fhir.Model.Attachment> Representation { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(IssuedElement != null )
                result.AddRange(IssuedElement.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Performer != null )
                result.AddRange(Performer.Validate());
            if(ReportId != null )
                result.AddRange(ReportId.Validate());
            if(RequestDetail != null )
                RequestDetail.ForEach(elem => result.AddRange(elem.Validate()));
            if(ServiceCategory != null )
                result.AddRange(ServiceCategory.Validate());
            if(DiagnosticTimeElement != null )
                result.AddRange(DiagnosticTimeElement.Validate());
            if(Results != null )
                result.AddRange(Results.Validate());
            if(Image != null )
                Image.ForEach(elem => result.AddRange(elem.Validate()));
            if(ConclusionElement != null )
                result.AddRange(ConclusionElement.Validate());
            if(CodedDiagnosis != null )
                CodedDiagnosis.ForEach(elem => result.AddRange(elem.Validate()));
            if(Representation != null )
                Representation.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
