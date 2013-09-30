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
    /// An action that is performed on a patient
    /// </summary>
    [FhirResource("Procedure")]
    [Serializable]
    public partial class Procedure : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The nature of the relationship with this procedure
        /// </summary>
        public enum ProcedureRelationshipType
        {
            CausedBy, // This procedure had to be performed because of the related one.
            Caused, // This procedure caused the related one to be performed.
        }
        
        /// <summary>
        /// Conversion of ProcedureRelationshipTypefrom and into string
        /// <summary>
        public static class ProcedureRelationshipTypeHandling
        {
            public static bool TryParse(string value, out ProcedureRelationshipType result)
            {
                result = default(ProcedureRelationshipType);
                
                if( value=="caused-by")
                    result = ProcedureRelationshipType.CausedBy;
                else if( value=="caused")
                    result = ProcedureRelationshipType.Caused;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ProcedureRelationshipType value)
            {
                if( value==ProcedureRelationshipType.CausedBy )
                    return "caused-by";
                else if( value==ProcedureRelationshipType.Caused )
                    return "caused";
                else
                    throw new ArgumentException("Unrecognized ProcedureRelationshipType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProcedureRelatedItemComponent")]
        [Serializable]
        public partial class ProcedureRelatedItemComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// caused-by | caused
            /// </summary>
            public Code<Hl7.Fhir.Model.Procedure.ProcedureRelationshipType> TypeElement { get; set; }
            
            public Hl7.Fhir.Model.Procedure.ProcedureRelationshipType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Code<Hl7.Fhir.Model.Procedure.ProcedureRelationshipType>(value);
                }
            }
            
            /// <summary>
            /// The related item - e.g. a procedure
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Target { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                if(Target != null )
                    result.AddRange(Target.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProcedurePerformerComponent")]
        [Serializable]
        public partial class ProcedurePerformerComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The reference to the practitioner
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Person { get; set; }
            
            /// <summary>
            /// The role the person was in
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Role { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Person != null )
                    result.AddRange(Person.Validate());
                if(Role != null )
                    result.AddRange(Role.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Subject of this procedure
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Identification of the procedure
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
        
        /// <summary>
        /// Precise location details
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> BodySite { get; set; }
        
        /// <summary>
        /// Indications for the procedure
        /// </summary>
        public Hl7.Fhir.Model.FhirString IndicationElement { get; set; }
        
        public string Indication
        {
            get { return IndicationElement != null ? IndicationElement.Value : null; }
            set
            {
                if(value == null)
                  IndicationElement = null; 
                else
                  IndicationElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// The people who performed the procedure
        /// </summary>
        public List<Hl7.Fhir.Model.Procedure.ProcedurePerformerComponent> Performer { get; set; }
        
        /// <summary>
        /// The date the procedure was performed
        /// </summary>
        public Hl7.Fhir.Model.Period Date { get; set; }
        
        /// <summary>
        /// The encounter during which the procedure was performed
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Encounter { get; set; }
        
        /// <summary>
        /// Outcome of the procedure
        /// </summary>
        public Hl7.Fhir.Model.FhirString OutcomeElement { get; set; }
        
        public string Outcome
        {
            get { return OutcomeElement != null ? OutcomeElement.Value : null; }
            set
            {
                if(value == null)
                  OutcomeElement = null; 
                else
                  OutcomeElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Any report that results from the procedure
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Report { get; set; }
        
        /// <summary>
        /// Complications
        /// </summary>
        public Hl7.Fhir.Model.FhirString ComplicationElement { get; set; }
        
        public string Complication
        {
            get { return ComplicationElement != null ? ComplicationElement.Value : null; }
            set
            {
                if(value == null)
                  ComplicationElement = null; 
                else
                  ComplicationElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Instructions for follow up
        /// </summary>
        public Hl7.Fhir.Model.FhirString FollowUpElement { get; set; }
        
        public string FollowUp
        {
            get { return FollowUpElement != null ? FollowUpElement.Value : null; }
            set
            {
                if(value == null)
                  FollowUpElement = null; 
                else
                  FollowUpElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// A procedure that is related to this one
        /// </summary>
        public List<Hl7.Fhir.Model.Procedure.ProcedureRelatedItemComponent> RelatedItem { get; set; }
        
        /// <summary>
        /// Procedure notes
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
            if(Type != null )
                result.AddRange(Type.Validate());
            if(BodySite != null )
                BodySite.ForEach(elem => result.AddRange(elem.Validate()));
            if(IndicationElement != null )
                result.AddRange(IndicationElement.Validate());
            if(Performer != null )
                Performer.ForEach(elem => result.AddRange(elem.Validate()));
            if(Date != null )
                result.AddRange(Date.Validate());
            if(Encounter != null )
                result.AddRange(Encounter.Validate());
            if(OutcomeElement != null )
                result.AddRange(OutcomeElement.Validate());
            if(Report != null )
                Report.ForEach(elem => result.AddRange(elem.Validate()));
            if(ComplicationElement != null )
                result.AddRange(ComplicationElement.Validate());
            if(FollowUpElement != null )
                result.AddRange(FollowUpElement.Validate());
            if(RelatedItem != null )
                RelatedItem.ForEach(elem => result.AddRange(elem.Validate()));
            if(NotesElement != null )
                result.AddRange(NotesElement.Validate());
            
            return result;
        }
    }
    
}
