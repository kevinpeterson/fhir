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
    /// A document that contains resources
    /// </summary>
    [FhirResource("Document")]
    [Serializable]
    public partial class Document : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The way in which a person authenticated a document
        /// </summary>
        public enum DocumentAttestationMode
        {
            Personal, // The person authenticated the document in their personal capacity.
            Professional, // The person authenticated the document in their professional capacity.
            Legal, // The person authenticated the document and accepted legal responsibility for its content.
            Official, // The organization authenticated the document as consistent with their policies and procedures.
        }
        
        /// <summary>
        /// Conversion of DocumentAttestationModefrom and into string
        /// <summary>
        public static class DocumentAttestationModeHandling
        {
            public static bool TryParse(string value, out DocumentAttestationMode result)
            {
                result = default(DocumentAttestationMode);
                
                if( value=="personal")
                    result = DocumentAttestationMode.Personal;
                else if( value=="professional")
                    result = DocumentAttestationMode.Professional;
                else if( value=="legal")
                    result = DocumentAttestationMode.Legal;
                else if( value=="official")
                    result = DocumentAttestationMode.Official;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DocumentAttestationMode value)
            {
                if( value==DocumentAttestationMode.Personal )
                    return "personal";
                else if( value==DocumentAttestationMode.Professional )
                    return "professional";
                else if( value==DocumentAttestationMode.Legal )
                    return "legal";
                else if( value==DocumentAttestationMode.Official )
                    return "official";
                else
                    throw new ArgumentException("Unrecognized DocumentAttestationMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The workflow/clinical status of this document
        /// </summary>
        public enum DocumentStatus
        {
            Interim, // This is an initial or interim document. The content may be incomplete or unverified.
            Final, // The document is complete and verified by an appropriate person.
            Amended, // The document has been modified subsequent to being released as "final", and is complete and verified by an authorised person.
            Withdrawn, // The document has been withdrawn following prior release.
        }
        
        /// <summary>
        /// Conversion of DocumentStatusfrom and into string
        /// <summary>
        public static class DocumentStatusHandling
        {
            public static bool TryParse(string value, out DocumentStatus result)
            {
                result = default(DocumentStatus);
                
                if( value=="interim")
                    result = DocumentStatus.Interim;
                else if( value=="final")
                    result = DocumentStatus.Final;
                else if( value=="amended")
                    result = DocumentStatus.Amended;
                else if( value=="withdrawn")
                    result = DocumentStatus.Withdrawn;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DocumentStatus value)
            {
                if( value==DocumentStatus.Interim )
                    return "interim";
                else if( value==DocumentStatus.Final )
                    return "final";
                else if( value==DocumentStatus.Amended )
                    return "amended";
                else if( value==DocumentStatus.Withdrawn )
                    return "withdrawn";
                else
                    throw new ArgumentException("Unrecognized DocumentStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SectionComponent")]
        [Serializable]
        public partial class SectionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Classification of section (recommended)
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// If section different to document
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
            
            /// <summary>
            /// The actual data for the section
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Content { get; set; }
            
            /// <summary>
            /// Nested Section
            /// </summary>
            public List<Hl7.Fhir.Model.Document.SectionComponent> Section { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(Subject != null )
                    result.AddRange(Subject.Validate());
                if(Content != null )
                    result.AddRange(Content.Validate());
                if(Section != null )
                    Section.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DocumentAttesterComponent")]
        [Serializable]
        public partial class DocumentAttesterComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// personal | professional | legal | official
            /// </summary>
            public Code<Hl7.Fhir.Model.Document.DocumentAttestationMode> ModeElement { get; set; }
            
            public Hl7.Fhir.Model.Document.DocumentAttestationMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if(value == null)
                      ModeElement = null; 
                    else
                      ModeElement = new Code<Hl7.Fhir.Model.Document.DocumentAttestationMode>(value);
                }
            }
            
            /// <summary>
            /// When document attested
            /// </summary>
            public Hl7.Fhir.Model.FhirDateTime TimeElement { get; set; }
            
            public string Time
            {
                get { return TimeElement != null ? TimeElement.Value : null; }
                set
                {
                    if(value == null)
                      TimeElement = null; 
                    else
                      TimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
                }
            }
            
            /// <summary>
            /// Who attested the document
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Party { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(ModeElement != null )
                    result.AddRange(ModeElement.Validate());
                if(TimeElement != null )
                    result.AddRange(TimeElement.Validate());
                if(Party != null )
                    result.AddRange(Party.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DocumentEventComponent")]
        [Serializable]
        public partial class DocumentEventComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Code(s) that apply to the event being documented
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Code { get; set; }
            
            /// <summary>
            /// The period covered by the document
            /// </summary>
            public Hl7.Fhir.Model.Period Period { get; set; }
            
            /// <summary>
            /// Full details for the event(s) the document concents
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Detail { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    Code.ForEach(elem => result.AddRange(elem.Validate()));
                if(Period != null )
                    result.AddRange(Period.Validate());
                if(Detail != null )
                    Detail.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Logical identifier for document (version-independent)
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// Version-specific identifier for document
        /// </summary>
        public Hl7.Fhir.Model.Identifier VersionIdentifier { get; set; }
        
        /// <summary>
        /// Document creation time
        /// </summary>
        public Hl7.Fhir.Model.Instant CreatedElement { get; set; }
        
        public DateTimeOffset? Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if(value == null)
                  CreatedElement = null; 
                else
                  CreatedElement = new Hl7.Fhir.Model.Instant(value);
            }
        }
        
        /// <summary>
        /// Kind of document (LOINC if possible)
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
        
        /// <summary>
        /// More detail about the document type
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Subtype { get; set; }
        
        /// <summary>
        /// Document title
        /// </summary>
        public Hl7.Fhir.Model.FhirString TitleElement { get; set; }
        
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if(value == null)
                  TitleElement = null; 
                else
                  TitleElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Status of this document
        /// </summary>
        public Code<Hl7.Fhir.Model.Document.DocumentStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.Document.DocumentStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Document.DocumentStatus>(value);
            }
        }
        
        /// <summary>
        /// As defined by affinity domain
        /// </summary>
        public Hl7.Fhir.Model.Coding Confidentiality { get; set; }
        
        /// <summary>
        /// Who/what the document is about
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Who/what authored the final document
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Author { get; set; }
        
        /// <summary>
        /// Attests to accuracy of document
        /// </summary>
        public List<Hl7.Fhir.Model.Document.DocumentAttesterComponent> Attester { get; set; }
        
        /// <summary>
        /// Org which maintains the document
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Custodian { get; set; }
        
        /// <summary>
        /// The clinical event/act/item being documented
        /// </summary>
        public Hl7.Fhir.Model.Document.DocumentEventComponent Event { get; set; }
        
        /// <summary>
        /// Context of the document
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Encounter { get; set; }
        
        /// <summary>
        /// If this document replaces another
        /// </summary>
        public Hl7.Fhir.Model.Id ReplacesElement { get; set; }
        
        public string Replaces
        {
            get { return ReplacesElement != null ? ReplacesElement.Value : null; }
            set
            {
                if(value == null)
                  ReplacesElement = null; 
                else
                  ReplacesElement = new Hl7.Fhir.Model.Id(value);
            }
        }
        
        /// <summary>
        /// Additional provenance about the document and its parts
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Provenance { get; set; }
        
        /// <summary>
        /// Stylesheet to use when rendering the document
        /// </summary>
        public Hl7.Fhir.Model.Attachment Stylesheet { get; set; }
        
        /// <summary>
        /// Alternative representation of the document
        /// </summary>
        public Hl7.Fhir.Model.Attachment Representation { get; set; }
        
        /// <summary>
        /// Document is broken into sections
        /// </summary>
        public List<Hl7.Fhir.Model.Document.SectionComponent> Section { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(VersionIdentifier != null )
                result.AddRange(VersionIdentifier.Validate());
            if(CreatedElement != null )
                result.AddRange(CreatedElement.Validate());
            if(Type != null )
                result.AddRange(Type.Validate());
            if(Subtype != null )
                result.AddRange(Subtype.Validate());
            if(TitleElement != null )
                result.AddRange(TitleElement.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(Confidentiality != null )
                result.AddRange(Confidentiality.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Author != null )
                Author.ForEach(elem => result.AddRange(elem.Validate()));
            if(Attester != null )
                Attester.ForEach(elem => result.AddRange(elem.Validate()));
            if(Custodian != null )
                result.AddRange(Custodian.Validate());
            if(Event != null )
                result.AddRange(Event.Validate());
            if(Encounter != null )
                result.AddRange(Encounter.Validate());
            if(ReplacesElement != null )
                result.AddRange(ReplacesElement.Validate());
            if(Provenance != null )
                Provenance.ForEach(elem => result.AddRange(elem.Validate()));
            if(Stylesheet != null )
                result.AddRange(Stylesheet.Validate());
            if(Representation != null )
                result.AddRange(Representation.Validate());
            if(Section != null )
                Section.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
