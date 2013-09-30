using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

/*
  Copyright (c) 2011-2012, HL7, Inc.
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
// Generated on Wed, Apr 3, 2013 07:59+1100 for FHIR v0.07
//

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for DocumentInformation instances
    /// </summary>
    internal static partial class DocumentInformationParser
    {
        /// <summary>
        /// Parse DocumentInformation
        /// </summary>
        public static DocumentInformation ParseDocumentInformation(IFhirReader reader, ErrorList errors, DocumentInformation existingInstance = null )
        {
            DocumentInformation result = existingInstance != null ? existingInstance : new DocumentInformation();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                        result.Id = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element versionId
                    else if( ParserUtils.IsAtFhirElement(reader, "versionId") )
                        result.VersionId = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element created
                    else if( ParserUtils.IsAtFhirElement(reader, "created") )
                        result.Created = InstantParser.ParseInstant(reader, errors);
                    
                    // Parse element class
                    else if( ParserUtils.IsAtFhirElement(reader, "class") )
                        result.Class = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element title
                    else if( ParserUtils.IsAtFhirElement(reader, "title") )
                        result.Title = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element confidentiality
                    else if( ParserUtils.IsAtFhirElement(reader, "confidentiality") )
                        result.Confidentiality = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element author
                    else if( ParserUtils.IsAtFhirElement(reader, "author") )
                    {
                        result.Author = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "author") )
                            result.Author.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element attester
                    else if( ParserUtils.IsAtFhirElement(reader, "attester") )
                    {
                        result.Attester = new List<DocumentInformation.DocumentInformationAttesterComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "attester") )
                            result.Attester.Add(DocumentInformationParser.ParseDocumentInformationAttesterComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element custodian
                    else if( ParserUtils.IsAtFhirElement(reader, "custodian") )
                        result.Custodian = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element event
                    else if( ParserUtils.IsAtFhirElement(reader, "event") )
                        result.Event = DocumentInformationParser.ParseDocumentInformationEventComponent(reader, errors);
                    
                    // Parse element encounter
                    else if( ParserUtils.IsAtFhirElement(reader, "encounter") )
                        result.Encounter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element facilityType
                    else if( ParserUtils.IsAtFhirElement(reader, "facilityType") )
                        result.FacilityType = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element practiceSetting
                    else if( ParserUtils.IsAtFhirElement(reader, "practiceSetting") )
                        result.PracticeSetting = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse DocumentInformationAttesterComponent
        /// </summary>
        public static DocumentInformation.DocumentInformationAttesterComponent ParseDocumentInformationAttesterComponent(IFhirReader reader, ErrorList errors, DocumentInformation.DocumentInformationAttesterComponent existingInstance = null )
        {
            DocumentInformation.DocumentInformationAttesterComponent result = existingInstance != null ? existingInstance : new DocumentInformation.DocumentInformationAttesterComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element mode
                    else if( ParserUtils.IsAtFhirElement(reader, "mode") )
                        result.Mode = CodeParser.ParseCode<DocumentInformation.DocumentAttestationMode>(reader, errors);
                    
                    // Parse element time
                    else if( ParserUtils.IsAtFhirElement(reader, "time") )
                        result.Time = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element party
                    else if( ParserUtils.IsAtFhirElement(reader, "party") )
                        result.Party = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse DocumentInformationEventComponent
        /// </summary>
        public static DocumentInformation.DocumentInformationEventComponent ParseDocumentInformationEventComponent(IFhirReader reader, ErrorList errors, DocumentInformation.DocumentInformationEventComponent existingInstance = null )
        {
            DocumentInformation.DocumentInformationEventComponent result = existingInstance != null ? existingInstance : new DocumentInformation.DocumentInformationEventComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                    {
                        result.Code = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "code") )
                            result.Code.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element period
                    else if( ParserUtils.IsAtFhirElement(reader, "period") )
                        result.Period = PeriodParser.ParsePeriod(reader, errors);
                    
                    // Parse element detail
                    else if( ParserUtils.IsAtFhirElement(reader, "detail") )
                    {
                        result.Detail = new List<ResourceReference>();
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
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
    }
}
