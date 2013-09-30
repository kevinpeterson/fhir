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
    /// A request for a diagnostic service
    /// </summary>
    [FhirResource("DiagnosticOrder")]
    [Serializable]
    public partial class DiagnosticOrder : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The status of a diagnostic order
        /// </summary>
        public enum DiagnosticOrderStatus
        {
            Requested, // The request has been placed.
            Received, // The receiving system has received the order, but not yet decided whether it will be performed.
            Accepted, // The receiving system has accepted the order, but work has not yet commenced.
            Inprogress, // The work to fulfill the order is happening.
            Review, // The work is complete, and the outcomes are being reviewed for approval.
            Complete, // The work has been complete, the report(s) released, and no further work is planned.
            Suspended, // The request has been held by originating system/user request.
            Rejected, // The receiving system has declined to fulfill the request.
            Failed, // The diagnostic investigation was attempted, but due to some procedural error, it could not be completed.
        }
        
        /// <summary>
        /// Conversion of DiagnosticOrderStatusfrom and into string
        /// <summary>
        public static class DiagnosticOrderStatusHandling
        {
            public static bool TryParse(string value, out DiagnosticOrderStatus result)
            {
                result = default(DiagnosticOrderStatus);
                
                if( value=="requested")
                    result = DiagnosticOrderStatus.Requested;
                else if( value=="received")
                    result = DiagnosticOrderStatus.Received;
                else if( value=="accepted")
                    result = DiagnosticOrderStatus.Accepted;
                else if( value=="inprogress")
                    result = DiagnosticOrderStatus.Inprogress;
                else if( value=="review")
                    result = DiagnosticOrderStatus.Review;
                else if( value=="complete")
                    result = DiagnosticOrderStatus.Complete;
                else if( value=="suspended")
                    result = DiagnosticOrderStatus.Suspended;
                else if( value=="rejected")
                    result = DiagnosticOrderStatus.Rejected;
                else if( value=="failed")
                    result = DiagnosticOrderStatus.Failed;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DiagnosticOrderStatus value)
            {
                if( value==DiagnosticOrderStatus.Requested )
                    return "requested";
                else if( value==DiagnosticOrderStatus.Received )
                    return "received";
                else if( value==DiagnosticOrderStatus.Accepted )
                    return "accepted";
                else if( value==DiagnosticOrderStatus.Inprogress )
                    return "inprogress";
                else if( value==DiagnosticOrderStatus.Review )
                    return "review";
                else if( value==DiagnosticOrderStatus.Complete )
                    return "complete";
                else if( value==DiagnosticOrderStatus.Suspended )
                    return "suspended";
                else if( value==DiagnosticOrderStatus.Rejected )
                    return "rejected";
                else if( value==DiagnosticOrderStatus.Failed )
                    return "failed";
                else
                    throw new ArgumentException("Unrecognized DiagnosticOrderStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The clinical priority of a diagnostic order
        /// </summary>
        public enum DiagnosticOrderPriority
        {
            Normal, // The order has no particular priority with it.
            Urgent, // The order should be urgently.
            Stat, // The order is time-critical.
        }
        
        /// <summary>
        /// Conversion of DiagnosticOrderPriorityfrom and into string
        /// <summary>
        public static class DiagnosticOrderPriorityHandling
        {
            public static bool TryParse(string value, out DiagnosticOrderPriority result)
            {
                result = default(DiagnosticOrderPriority);
                
                if( value=="normal")
                    result = DiagnosticOrderPriority.Normal;
                else if( value=="urgent")
                    result = DiagnosticOrderPriority.Urgent;
                else if( value=="stat")
                    result = DiagnosticOrderPriority.Stat;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DiagnosticOrderPriority value)
            {
                if( value==DiagnosticOrderPriority.Normal )
                    return "normal";
                else if( value==DiagnosticOrderPriority.Urgent )
                    return "urgent";
                else if( value==DiagnosticOrderPriority.Stat )
                    return "stat";
                else
                    throw new ArgumentException("Unrecognized DiagnosticOrderPriority value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DiagnosticOrderItemComponent")]
        [Serializable]
        public partial class DiagnosticOrderItemComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Code for this item
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// If this item relates to specific specimens
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Specimen { get; set; }
            
            /// <summary>
            /// Location of requested test (if applicable)
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept BodySite { get; set; }
            
            /// <summary>
            /// requested | received | accepted | inprogress | review | complete | suspended | rejected | failed
            /// </summary>
            public Code<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus> StatusElement { get; set; }
            
            public Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if(value == null)
                      StatusElement = null; 
                    else
                      StatusElement = new Code<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus>(value);
                }
            }
            
            /// <summary>
            /// Events specific to this item
            /// </summary>
            public List<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderEventComponent> Event { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(Specimen != null )
                    Specimen.ForEach(elem => result.AddRange(elem.Validate()));
                if(BodySite != null )
                    result.AddRange(BodySite.Validate());
                if(StatusElement != null )
                    result.AddRange(StatusElement.Validate());
                if(Event != null )
                    Event.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DiagnosticOrderEventComponent")]
        [Serializable]
        public partial class DiagnosticOrderEventComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// requested | received | accepted | inprogress | review | complete | suspended | rejected | failed
            /// </summary>
            public Code<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus> StatusElement { get; set; }
            
            public Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if(value == null)
                      StatusElement = null; 
                    else
                      StatusElement = new Code<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus>(value);
                }
            }
            
            /// <summary>
            /// The date at which the event happened
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
            /// Who recorded or did this
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Actor { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(StatusElement != null )
                    result.AddRange(StatusElement.Validate());
                if(DateElement != null )
                    result.AddRange(DateElement.Validate());
                if(Actor != null )
                    result.AddRange(Actor.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Who/what test is about
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Who ordered the test
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Orderer { get; set; }
        
        /// <summary>
        /// Identifiers assigned to this order
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// The encounter that this diagnostic order is associated with
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Encounter { get; set; }
        
        /// <summary>
        /// Explanation/Justification for test
        /// </summary>
        public Hl7.Fhir.Model.FhirString ClinicalNotesElement { get; set; }
        
        public string ClinicalNotes
        {
            get { return ClinicalNotesElement != null ? ClinicalNotesElement.Value : null; }
            set
            {
                if(value == null)
                  ClinicalNotesElement = null; 
                else
                  ClinicalNotesElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// If the whole order relates to specific specimens
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Specimen { get; set; }
        
        /// <summary>
        /// requested | received | accepted | inprogress | review | complete | suspended | rejected | failed
        /// </summary>
        public Code<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus>(value);
            }
        }
        
        /// <summary>
        /// normal | urgent | stat
        /// </summary>
        public Code<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriority> PriorityElement { get; set; }
        
        public Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriority? Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if(value == null)
                  PriorityElement = null; 
                else
                  PriorityElement = new Code<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriority>(value);
            }
        }
        
        /// <summary>
        /// A list of events of interest in the lifecycle
        /// </summary>
        public List<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderEventComponent> Event { get; set; }
        
        /// <summary>
        /// The items the orderer requested
        /// </summary>
        public List<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderItemComponent> Item { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Orderer != null )
                result.AddRange(Orderer.Validate());
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(Encounter != null )
                result.AddRange(Encounter.Validate());
            if(ClinicalNotesElement != null )
                result.AddRange(ClinicalNotesElement.Validate());
            if(Specimen != null )
                Specimen.ForEach(elem => result.AddRange(elem.Validate()));
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(PriorityElement != null )
                result.AddRange(PriorityElement.Validate());
            if(Event != null )
                Event.ForEach(elem => result.AddRange(elem.Validate()));
            if(Item != null )
                Item.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
