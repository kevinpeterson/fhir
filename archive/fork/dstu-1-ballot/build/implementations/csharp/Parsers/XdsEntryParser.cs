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
// Generated on Wed, Apr 3, 2013 07:11+1100 for FHIR v0.07
//

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for XdsEntry instances
    /// </summary>
    internal static partial class XdsEntryParser
    {
        /// <summary>
        /// Parse XdsEntry
        /// </summary>
        public static XdsEntry ParseXdsEntry(IFhirReader reader, ErrorList errors, XdsEntry existingInstance = null )
        {
            XdsEntry result = existingInstance != null ? existingInstance : new XdsEntry();
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
                    
                    // Parse element language
                    else if( ParserUtils.IsAtFhirElement(reader, "language") )
                        result.Language = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element text
                    else if( ParserUtils.IsAtFhirElement(reader, "text") )
                        result.Text = NarrativeParser.ParseNarrative(reader, errors);
                    
                    // Parse element contained
                    else if( ParserUtils.IsAtFhirElement(reader, "contained") )
                    {
                        result.Contained = new List<Resource>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "contained") )
                            result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element url
                    else if( ParserUtils.IsAtFhirElement(reader, "url") )
                        result.Url = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element repositoryId
                    else if( ParserUtils.IsAtFhirElement(reader, "repositoryId") )
                        result.RepositoryId = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element mimeType
                    else if( ParserUtils.IsAtFhirElement(reader, "mimeType") )
                        result.MimeType = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element format
                    else if( ParserUtils.IsAtFhirElement(reader, "format") )
                        result.Format = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element class
                    else if( ParserUtils.IsAtFhirElement(reader, "class") )
                        result.Class = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element title
                    else if( ParserUtils.IsAtFhirElement(reader, "title") )
                        result.Title = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element documentId
                    else if( ParserUtils.IsAtFhirElement(reader, "documentId") )
                        result.DocumentId = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element availability
                    else if( ParserUtils.IsAtFhirElement(reader, "availability") )
                        result.Availability = CodeParser.ParseCode<XdsEntry.XdsEntryAvailability>(reader, errors);
                    
                    // Parse element confidentialityCode
                    else if( ParserUtils.IsAtFhirElement(reader, "confidentialityCode") )
                        result.ConfidentialityCode = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element created
                    else if( ParserUtils.IsAtFhirElement(reader, "created") )
                        result.Created = InstantParser.ParseInstant(reader, errors);
                    
                    // Parse element event
                    else if( ParserUtils.IsAtFhirElement(reader, "event") )
                    {
                        result.Event = new List<Coding>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "event") )
                            result.Event.Add(CodingParser.ParseCoding(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element hash
                    else if( ParserUtils.IsAtFhirElement(reader, "hash") )
                        result.Hash = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element size
                    else if( ParserUtils.IsAtFhirElement(reader, "size") )
                        result.Size = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element lang
                    else if( ParserUtils.IsAtFhirElement(reader, "lang") )
                        result.Lang = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element folder
                    else if( ParserUtils.IsAtFhirElement(reader, "folder") )
                    {
                        result.Folder = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "folder") )
                            result.Folder.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element patientId
                    else if( ParserUtils.IsAtFhirElement(reader, "patientId") )
                        result.PatientId = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element sourcePatientId
                    else if( ParserUtils.IsAtFhirElement(reader, "sourcePatientId") )
                        result.SourcePatientId = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element patientInfo
                    else if( ParserUtils.IsAtFhirElement(reader, "patientInfo") )
                        result.PatientInfo = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element author
                    else if( ParserUtils.IsAtFhirElement(reader, "author") )
                    {
                        result.Author = new List<XdsEntry.XdsEntryAuthorComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "author") )
                            result.Author.Add(XdsEntryParser.ParseXdsEntryAuthorComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element authenticator
                    else if( ParserUtils.IsAtFhirElement(reader, "authenticator") )
                        result.Authenticator = XdsEntryParser.ParseXdsEntryAuthenticatorComponent(reader, errors);
                    
                    // Parse element facilityType
                    else if( ParserUtils.IsAtFhirElement(reader, "facilityType") )
                        result.FacilityType = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element practiceSetting
                    else if( ParserUtils.IsAtFhirElement(reader, "practiceSetting") )
                        result.PracticeSetting = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element homeCommunity
                    else if( ParserUtils.IsAtFhirElement(reader, "homeCommunity") )
                        result.HomeCommunity = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element service
                    else if( ParserUtils.IsAtFhirElement(reader, "service") )
                        result.Service = XdsEntryParser.ParseXdsEntryServiceComponent(reader, errors);
                    
                    // Parse element comments
                    else if( ParserUtils.IsAtFhirElement(reader, "comments") )
                        result.Comments = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse XdsEntryServiceComponent
        /// </summary>
        public static XdsEntry.XdsEntryServiceComponent ParseXdsEntryServiceComponent(IFhirReader reader, ErrorList errors, XdsEntry.XdsEntryServiceComponent existingInstance = null )
        {
            XdsEntry.XdsEntryServiceComponent result = existingInstance != null ? existingInstance : new XdsEntry.XdsEntryServiceComponent();
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
                    
                    // Parse element start
                    else if( ParserUtils.IsAtFhirElement(reader, "start") )
                        result.Start = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element stop
                    else if( ParserUtils.IsAtFhirElement(reader, "stop") )
                        result.Stop = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
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
        /// Parse XdsEntryAuthorComponent
        /// </summary>
        public static XdsEntry.XdsEntryAuthorComponent ParseXdsEntryAuthorComponent(IFhirReader reader, ErrorList errors, XdsEntry.XdsEntryAuthorComponent existingInstance = null )
        {
            XdsEntry.XdsEntryAuthorComponent result = existingInstance != null ? existingInstance : new XdsEntry.XdsEntryAuthorComponent();
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
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = HumanNameParser.ParseHumanName(reader, errors);
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                        result.Id = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element role
                    else if( ParserUtils.IsAtFhirElement(reader, "role") )
                    {
                        result.Role = new List<FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "role") )
                            result.Role.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element specialty
                    else if( ParserUtils.IsAtFhirElement(reader, "specialty") )
                    {
                        result.Specialty = new List<FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "specialty") )
                            result.Specialty.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element institution
                    else if( ParserUtils.IsAtFhirElement(reader, "institution") )
                    {
                        result.Institution = new List<XdsEntry.XdsEntryAuthorInstitutionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "institution") )
                            result.Institution.Add(XdsEntryParser.ParseXdsEntryAuthorInstitutionComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element contact
                    else if( ParserUtils.IsAtFhirElement(reader, "contact") )
                    {
                        result.Contact = new List<Contact>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "contact") )
                            result.Contact.Add(ContactParser.ParseContact(reader, errors));
                        
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
        
        /// <summary>
        /// Parse XdsEntryAuthorInstitutionComponent
        /// </summary>
        public static XdsEntry.XdsEntryAuthorInstitutionComponent ParseXdsEntryAuthorInstitutionComponent(IFhirReader reader, ErrorList errors, XdsEntry.XdsEntryAuthorInstitutionComponent existingInstance = null )
        {
            XdsEntry.XdsEntryAuthorInstitutionComponent result = existingInstance != null ? existingInstance : new XdsEntry.XdsEntryAuthorInstitutionComponent();
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
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse XdsEntryAuthenticatorComponent
        /// </summary>
        public static XdsEntry.XdsEntryAuthenticatorComponent ParseXdsEntryAuthenticatorComponent(IFhirReader reader, ErrorList errors, XdsEntry.XdsEntryAuthenticatorComponent existingInstance = null )
        {
            XdsEntry.XdsEntryAuthenticatorComponent result = existingInstance != null ? existingInstance : new XdsEntry.XdsEntryAuthenticatorComponent();
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
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = HumanNameParser.ParseHumanName(reader, errors);
                    
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
