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
    /// Parser for XdsEntry2 instances
    /// </summary>
    internal static partial class XdsEntry2Parser
    {
        /// <summary>
        /// Parse XdsEntry2
        /// </summary>
        public static XdsEntry2 ParseXdsEntry2(IFhirReader reader, ErrorList errors, XdsEntry2 existingInstance = null )
        {
            XdsEntry2 result = existingInstance != null ? existingInstance : new XdsEntry2();
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
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                        result.Id = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element information
                    else if( ParserUtils.IsAtFhirElement(reader, "information") )
                        result.Information = DocumentInformationParser.ParseDocumentInformation(reader, errors);
                    
                    // Parse element format
                    else if( ParserUtils.IsAtFhirElement(reader, "format") )
                        result.Format = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element availability
                    else if( ParserUtils.IsAtFhirElement(reader, "availability") )
                        result.Availability = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element folder
                    else if( ParserUtils.IsAtFhirElement(reader, "folder") )
                    {
                        result.Folder = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "folder") )
                            result.Folder.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element content
                    else if( ParserUtils.IsAtFhirElement(reader, "content") )
                        result.Content = AttachmentParser.ParseAttachment(reader, errors);
                    
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
