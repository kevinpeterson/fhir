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

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Document instances
    /// </summary>
    internal static partial class DocumentParser
    {
        /// <summary>
        /// Parse Document
        /// </summary>
        public static Hl7.Fhir.Model.Document ParseDocument(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Document existingInstance = null )
        {
            Hl7.Fhir.Model.Document result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Document();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element language
                else if( atName == "language" )
                    result.LanguageElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element text
                else if( atName == "text" )
                    result.Text = NarrativeParser.ParseNarrative(reader, errors);
                
                // Parse element contained
                else if( atName == "contained" )
                {
                    result.Contained = new List<Hl7.Fhir.Model.Resource>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "contained") )
                        result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element identifier
                else if( atName == "identifier" )
                    result.Identifier = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element versionIdentifier
                else if( atName == "versionIdentifier" )
                    result.VersionIdentifier = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element created
                else if( atName == "created" )
                    result.CreatedElement = InstantParser.ParseInstant(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element subtype
                else if( atName == "subtype" )
                    result.Subtype = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element title
                else if( atName == "title" )
                    result.TitleElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.Document.DocumentStatus>(reader, errors);
                
                // Parse element confidentiality
                else if( atName == "confidentiality" )
                    result.Confidentiality = CodingParser.ParseCoding(reader, errors);
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element author
                else if( atName == "author" )
                {
                    result.Author = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "author") )
                        result.Author.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element attester
                else if( atName == "attester" )
                {
                    result.Attester = new List<Hl7.Fhir.Model.Document.DocumentAttesterComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "attester") )
                        result.Attester.Add(DocumentParser.ParseDocumentAttesterComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element custodian
                else if( atName == "custodian" )
                    result.Custodian = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element event
                else if( atName == "event" )
                    result.Event = DocumentParser.ParseDocumentEventComponent(reader, errors);
                
                // Parse element encounter
                else if( atName == "encounter" )
                    result.Encounter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element replaces
                else if( atName == "replaces" )
                    result.ReplacesElement = IdParser.ParseId(reader, errors);
                
                // Parse element provenance
                else if( atName == "provenance" )
                {
                    result.Provenance = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "provenance") )
                        result.Provenance.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element stylesheet
                else if( atName == "stylesheet" )
                    result.Stylesheet = AttachmentParser.ParseAttachment(reader, errors);
                
                // Parse element representation
                else if( atName == "representation" )
                    result.Representation = AttachmentParser.ParseAttachment(reader, errors);
                
                // Parse element section
                else if( atName == "section" )
                {
                    result.Section = new List<Hl7.Fhir.Model.Document.SectionComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "section") )
                        result.Section.Add(DocumentParser.ParseSectionComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse SectionComponent
        /// </summary>
        public static Hl7.Fhir.Model.Document.SectionComponent ParseSectionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Document.SectionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Document.SectionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Document.SectionComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element code
                else if( atName == "code" )
                    result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element content
                else if( atName == "content" )
                    result.Content = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element section
                else if( atName == "section" )
                {
                    result.Section = new List<Hl7.Fhir.Model.Document.SectionComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "section") )
                        result.Section.Add(DocumentParser.ParseSectionComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse DocumentAttesterComponent
        /// </summary>
        public static Hl7.Fhir.Model.Document.DocumentAttesterComponent ParseDocumentAttesterComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Document.DocumentAttesterComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Document.DocumentAttesterComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Document.DocumentAttesterComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element mode
                else if( atName == "mode" )
                    result.ModeElement = CodeParser.ParseCode<Hl7.Fhir.Model.Document.DocumentAttestationMode>(reader, errors);
                
                // Parse element time
                else if( atName == "time" )
                    result.TimeElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element party
                else if( atName == "party" )
                    result.Party = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse DocumentEventComponent
        /// </summary>
        public static Hl7.Fhir.Model.Document.DocumentEventComponent ParseDocumentEventComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Document.DocumentEventComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Document.DocumentEventComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Document.DocumentEventComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element code
                else if( atName == "code" )
                {
                    result.Code = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "code") )
                        result.Code.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element period
                else if( atName == "period" )
                    result.Period = PeriodParser.ParsePeriod(reader, errors);
                
                // Parse element detail
                else if( atName == "detail" )
                {
                    result.Detail = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "detail") )
                        result.Detail.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
    }
}
