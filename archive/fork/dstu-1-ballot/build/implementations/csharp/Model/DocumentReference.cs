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
    /// A reference to a document
    /// </summary>
    [FhirResource("DocumentReference")]
    [Serializable]
    public partial class DocumentReference : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The status of the document reference
        /// </summary>
        public enum DocumentReferenceStatus
        {
            Current, // This is the current reference for this document.
            Superseded, // This reference has been superseded by another reference.
            Error, // This reference was created in error.
        }
        
        /// <summary>
        /// Conversion of DocumentReferenceStatusfrom and into string
        /// <summary>
        public static class DocumentReferenceStatusHandling
        {
            public static bool TryParse(string value, out DocumentReferenceStatus result)
            {
                result = default(DocumentReferenceStatus);
                
                if( value=="current")
                    result = DocumentReferenceStatus.Current;
                else if( value=="superseded")
                    result = DocumentReferenceStatus.Superseded;
                else if( value=="error")
                    result = DocumentReferenceStatus.Error;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DocumentReferenceStatus value)
            {
                if( value==DocumentReferenceStatus.Current )
                    return "current";
                else if( value==DocumentReferenceStatus.Superseded )
                    return "superseded";
                else if( value==DocumentReferenceStatus.Error )
                    return "error";
                else
                    throw new ArgumentException("Unrecognized DocumentReferenceStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DocumentReferenceContextComponent")]
        [Serializable]
        public partial class DocumentReferenceContextComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Type of context (i.e. type of event)
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Code { get; set; }
            
            /// <summary>
            /// Time described by the document
            /// </summary>
            public Hl7.Fhir.Model.Period Period { get; set; }
            
            /// <summary>
            /// Kind of facility where patient was seen
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept FacilityType { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    Code.ForEach(elem => result.AddRange(elem.Validate()));
                if(Period != null )
                    result.AddRange(Period.Validate());
                if(FacilityType != null )
                    result.AddRange(FacilityType.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DocumentReferenceServiceParameterComponent")]
        [Serializable]
        public partial class DocumentReferenceServiceParameterComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Name of parameter
            /// </summary>
            public Hl7.Fhir.Model.FhirString NameElement { get; set; }
            
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Parameter value
            /// </summary>
            public Hl7.Fhir.Model.FhirString ValueElement { get; set; }
            
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if(value == null)
                      ValueElement = null; 
                    else
                      ValueElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(ValueElement != null )
                    result.AddRange(ValueElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DocumentReferenceServiceComponent")]
        [Serializable]
        public partial class DocumentReferenceServiceComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Type of service (i.e. XDS.b)
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Where service is located (usually a URL)
            /// </summary>
            public Hl7.Fhir.Model.FhirString AddressElement { get; set; }
            
            public string Address
            {
                get { return AddressElement != null ? AddressElement.Value : null; }
                set
                {
                    if(value == null)
                      AddressElement = null; 
                    else
                      AddressElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Service call parameters
            /// </summary>
            public List<Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceParameterComponent> Parameter { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(AddressElement != null )
                    result.AddRange(AddressElement.Validate());
                if(Parameter != null )
                    Parameter.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Master Version Specific Identifier
        /// </summary>
        public Hl7.Fhir.Model.Identifier MasterIdentifier { get; set; }
        
        /// <summary>
        /// Other identifiers for the document
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// The subject of the document
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// What kind of document this is (LOINC if possible)
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
        
        /// <summary>
        /// More detail about the document type
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Subtype { get; set; }
        
        /// <summary>
        /// Who/what authored the document
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Author { get; set; }
        
        /// <summary>
        /// Org which maintains the document
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Custodian { get; set; }
        
        /// <summary>
        /// Who authenticated the document
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Authenticator { get; set; }
        
        /// <summary>
        /// Document creation time
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime CreatedElement { get; set; }
        
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if(value == null)
                  CreatedElement = null; 
                else
                  CreatedElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// When this document reference created
        /// </summary>
        public Hl7.Fhir.Model.Instant IndexedElement { get; set; }
        
        public DateTimeOffset? Indexed
        {
            get { return IndexedElement != null ? IndexedElement.Value : null; }
            set
            {
                if(value == null)
                  IndexedElement = null; 
                else
                  IndexedElement = new Hl7.Fhir.Model.Instant(value);
            }
        }
        
        /// <summary>
        /// current | superseded | error
        /// </summary>
        public Code<Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatus>(value);
            }
        }
        
        /// <summary>
        /// Status of the underlying document
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept DocStatus { get; set; }
        
        /// <summary>
        /// If this document replaces another
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Supercedes { get; set; }
        
        /// <summary>
        /// Human Readable description (title)
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
        /// Sensitivity of source document
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Confidentiality { get; set; }
        
        /// <summary>
        /// Primary language of the document
        /// </summary>
        public Hl7.Fhir.Model.Code PrimaryLanguageElement { get; set; }
        
        public string PrimaryLanguage
        {
            get { return PrimaryLanguageElement != null ? PrimaryLanguageElement.Value : null; }
            set
            {
                if(value == null)
                  PrimaryLanguageElement = null; 
                else
                  PrimaryLanguageElement = new Hl7.Fhir.Model.Code(value);
            }
        }
        
        /// <summary>
        /// Mime type of the document
        /// </summary>
        public Hl7.Fhir.Model.Code MimeTypeElement { get; set; }
        
        public string MimeType
        {
            get { return MimeTypeElement != null ? MimeTypeElement.Value : null; }
            set
            {
                if(value == null)
                  MimeTypeElement = null; 
                else
                  MimeTypeElement = new Hl7.Fhir.Model.Code(value);
            }
        }
        
        /// <summary>
        /// Format of the document
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Format { get; set; }
        
        /// <summary>
        /// Size of the document in bytes
        /// </summary>
        public Hl7.Fhir.Model.Integer SizeElement { get; set; }
        
        public int? Size
        {
            get { return SizeElement != null ? SizeElement.Value : null; }
            set
            {
                if(value == null)
                  SizeElement = null; 
                else
                  SizeElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// HexBinary representation of SHA1
        /// </summary>
        public Hl7.Fhir.Model.FhirString HashElement { get; set; }
        
        public string Hash
        {
            get { return HashElement != null ? HashElement.Value : null; }
            set
            {
                if(value == null)
                  HashElement = null; 
                else
                  HashElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Where to access the document
        /// </summary>
        public Hl7.Fhir.Model.FhirUri LocationElement { get; set; }
        
        public System.Uri Location
        {
            get { return LocationElement != null ? LocationElement.Value : null; }
            set
            {
                if(value == null)
                  LocationElement = null; 
                else
                  LocationElement = new Hl7.Fhir.Model.FhirUri(value);
            }
        }
        
        /// <summary>
        /// If access is not fully described by location
        /// </summary>
        public Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceComponent Service { get; set; }
        
        /// <summary>
        /// Clinical context of document
        /// </summary>
        public Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextComponent Context { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(MasterIdentifier != null )
                result.AddRange(MasterIdentifier.Validate());
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Type != null )
                result.AddRange(Type.Validate());
            if(Subtype != null )
                result.AddRange(Subtype.Validate());
            if(Author != null )
                Author.ForEach(elem => result.AddRange(elem.Validate()));
            if(Custodian != null )
                result.AddRange(Custodian.Validate());
            if(Authenticator != null )
                result.AddRange(Authenticator.Validate());
            if(CreatedElement != null )
                result.AddRange(CreatedElement.Validate());
            if(IndexedElement != null )
                result.AddRange(IndexedElement.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(DocStatus != null )
                result.AddRange(DocStatus.Validate());
            if(Supercedes != null )
                result.AddRange(Supercedes.Validate());
            if(DescriptionElement != null )
                result.AddRange(DescriptionElement.Validate());
            if(Confidentiality != null )
                result.AddRange(Confidentiality.Validate());
            if(PrimaryLanguageElement != null )
                result.AddRange(PrimaryLanguageElement.Validate());
            if(MimeTypeElement != null )
                result.AddRange(MimeTypeElement.Validate());
            if(Format != null )
                result.AddRange(Format.Validate());
            if(SizeElement != null )
                result.AddRange(SizeElement.Validate());
            if(HashElement != null )
                result.AddRange(HashElement.Validate());
            if(LocationElement != null )
                result.AddRange(LocationElement.Validate());
            if(Service != null )
                result.AddRange(Service.Validate());
            if(Context != null )
                result.AddRange(Context.Validate());
            
            return result;
        }
    }
    
}
