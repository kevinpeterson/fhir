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
    /// Parser for DocumentReference instances
    /// </summary>
    internal static partial class DocumentReferenceParser
    {
        /// <summary>
        /// Parse DocumentReference
        /// </summary>
        public static Hl7.Fhir.Model.DocumentReference ParseDocumentReference(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DocumentReference existingInstance = null )
        {
            Hl7.Fhir.Model.DocumentReference result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DocumentReference();
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
                
                // Parse element masterIdentifier
                else if( atName == "masterIdentifier" )
                    result.MasterIdentifier = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element identifier
                else if( atName == "identifier" )
                {
                    result.Identifier = new List<Hl7.Fhir.Model.Identifier>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                        result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element subtype
                else if( atName == "subtype" )
                    result.Subtype = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element author
                else if( atName == "author" )
                {
                    result.Author = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "author") )
                        result.Author.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element custodian
                else if( atName == "custodian" )
                    result.Custodian = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element authenticator
                else if( atName == "authenticator" )
                    result.Authenticator = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element created
                else if( atName == "created" )
                    result.CreatedElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element indexed
                else if( atName == "indexed" )
                    result.IndexedElement = InstantParser.ParseInstant(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatus>(reader, errors);
                
                // Parse element docStatus
                else if( atName == "docStatus" )
                    result.DocStatus = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element supercedes
                else if( atName == "supercedes" )
                    result.Supercedes = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element confidentiality
                else if( atName == "confidentiality" )
                    result.Confidentiality = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element primaryLanguage
                else if( atName == "primaryLanguage" )
                    result.PrimaryLanguageElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element mimeType
                else if( atName == "mimeType" )
                    result.MimeTypeElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element format
                else if( atName == "format" )
                    result.Format = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element size
                else if( atName == "size" )
                    result.SizeElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element hash
                else if( atName == "hash" )
                    result.HashElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element location
                else if( atName == "location" )
                    result.LocationElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element service
                else if( atName == "service" )
                    result.Service = DocumentReferenceParser.ParseDocumentReferenceServiceComponent(reader, errors);
                
                // Parse element context
                else if( atName == "context" )
                    result.Context = DocumentReferenceParser.ParseDocumentReferenceContextComponent(reader, errors);
                
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
        /// Parse DocumentReferenceContextComponent
        /// </summary>
        public static Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextComponent ParseDocumentReferenceContextComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DocumentReference.DocumentReferenceContextComponent();
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
                
                // Parse element facilityType
                else if( atName == "facilityType" )
                    result.FacilityType = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
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
        /// Parse DocumentReferenceServiceParameterComponent
        /// </summary>
        public static Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceParameterComponent ParseDocumentReferenceServiceParameterComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceParameterComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceParameterComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceParameterComponent();
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
                
                // Parse element name
                else if( atName == "name" )
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element value
                else if( atName == "value" )
                    result.ValueElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse DocumentReferenceServiceComponent
        /// </summary>
        public static Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceComponent ParseDocumentReferenceServiceComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceComponent();
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
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element address
                else if( atName == "address" )
                    result.AddressElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element parameter
                else if( atName == "parameter" )
                {
                    result.Parameter = new List<Hl7.Fhir.Model.DocumentReference.DocumentReferenceServiceParameterComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "parameter") )
                        result.Parameter.Add(DocumentReferenceParser.ParseDocumentReferenceServiceParameterComponent(reader, errors));
                    
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
