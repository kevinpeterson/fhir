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
    /// A set of answers to predefined lists of questions
    /// </summary>
    [FhirResource("Questionnaire")]
    [Serializable]
    public partial class Questionnaire : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("QuestionComponent")]
        [Serializable]
        public partial class QuestionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Code or name of the question
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Name { get; set; }
            
            /// <summary>
            /// Text of the question
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
            /// Single-valued answer to the question
            /// </summary>
            public Hl7.Fhir.Model.Element Answer { get; set; }
            
            /// <summary>
            /// Selected options
            /// </summary>
            public List<Hl7.Fhir.Model.Coding> Choice { get; set; }
            
            /// <summary>
            /// Valueset containing the possible options
            /// </summary>
            public Hl7.Fhir.Model.Element Options { get; set; }
            
            /// <summary>
            /// Structured answer
            /// </summary>
            public Hl7.Fhir.Model.Element Data { get; set; }
            
            /// <summary>
            /// Remarks about the answer given
            /// </summary>
            public Hl7.Fhir.Model.FhirString RemarksElement { get; set; }
            
            public string Remarks
            {
                get { return RemarksElement != null ? RemarksElement.Value : null; }
                set
                {
                    if(value == null)
                      RemarksElement = null; 
                    else
                      RemarksElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Name != null )
                    result.AddRange(Name.Validate());
                if(TextElement != null )
                    result.AddRange(TextElement.Validate());
                if(Answer != null )
                    result.AddRange(Answer.Validate());
                if(Choice != null )
                    Choice.ForEach(elem => result.AddRange(elem.Validate()));
                if(Options != null )
                    result.AddRange(Options.Validate());
                if(Data != null )
                    result.AddRange(Data.Validate());
                if(RemarksElement != null )
                    result.AddRange(RemarksElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("GroupComponent")]
        [Serializable]
        public partial class GroupComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Code or name of the section on a questionnaire
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Name { get; set; }
            
            /// <summary>
            /// Header for the group
            /// </summary>
            public Hl7.Fhir.Model.FhirString HeaderElement { get; set; }
            
            public string Header
            {
                get { return HeaderElement != null ? HeaderElement.Value : null; }
                set
                {
                    if(value == null)
                      HeaderElement = null; 
                    else
                      HeaderElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Additional text for the group
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
            /// The subject this group's answers are about
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
            
            /// <summary>
            /// Questions belonging to this group
            /// </summary>
            public List<Hl7.Fhir.Model.Questionnaire.QuestionComponent> Question { get; set; }
            
            /// <summary>
            /// Nested questionnaire group
            /// </summary>
            public List<Hl7.Fhir.Model.Questionnaire.GroupComponent> Group { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Name != null )
                    result.AddRange(Name.Validate());
                if(HeaderElement != null )
                    result.AddRange(HeaderElement.Validate());
                if(TextElement != null )
                    result.AddRange(TextElement.Validate());
                if(Subject != null )
                    result.AddRange(Subject.Validate());
                if(Question != null )
                    Question.ForEach(elem => result.AddRange(elem.Validate()));
                if(Group != null )
                    Group.ForEach(elem => result.AddRange(elem.Validate()));
                
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
        /// Date this version was authored
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime AuthoredElement { get; set; }
        
        public string Authored
        {
            get { return AuthoredElement != null ? AuthoredElement.Value : null; }
            set
            {
                if(value == null)
                  AuthoredElement = null; 
                else
                  AuthoredElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// The subject of the questionnaires
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Person that collected the answers
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Author { get; set; }
        
        /// <summary>
        /// The person that answered the questions
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Source { get; set; }
        
        /// <summary>
        /// Name/code for a predefined list of questions
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Name { get; set; }
        
        /// <summary>
        /// Identification of this questionnaire
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// Primary encounter during which the answers were collected
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Encounter { get; set; }
        
        /// <summary>
        /// Answers to questions
        /// </summary>
        public List<Hl7.Fhir.Model.Questionnaire.QuestionComponent> Question { get; set; }
        
        /// <summary>
        /// Grouped answers
        /// </summary>
        public List<Hl7.Fhir.Model.Questionnaire.GroupComponent> Group { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(AuthoredElement != null )
                result.AddRange(AuthoredElement.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Author != null )
                result.AddRange(Author.Validate());
            if(Source != null )
                result.AddRange(Source.Validate());
            if(Name != null )
                result.AddRange(Name.Validate());
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(Encounter != null )
                result.AddRange(Encounter.Validate());
            if(Question != null )
                Question.ForEach(elem => result.AddRange(elem.Validate()));
            if(Group != null )
                Group.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
