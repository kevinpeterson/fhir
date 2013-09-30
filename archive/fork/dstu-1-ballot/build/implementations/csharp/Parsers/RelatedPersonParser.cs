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

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for RelatedPerson instances
    /// </summary>
    internal static partial class RelatedPersonParser
    {
        /// <summary>
        /// Parse RelatedPerson
        /// </summary>
        public static Hl7.Fhir.Model.RelatedPerson ParseRelatedPerson(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.RelatedPerson existingInstance = null )
        {
            Hl7.Fhir.Model.RelatedPerson result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.RelatedPerson();
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
                {
                    result.Identifier = new List<Hl7.Fhir.Model.Identifier>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                        result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element patient
                else if( atName == "patient" )
                    result.Patient = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element relationship
                else if( atName == "relationship" )
                    result.Relationship = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element name
                else if( atName == "name" )
                    result.Name = HumanNameParser.ParseHumanName(reader, errors);
                
                // Parse element telecom
                else if( atName == "telecom" )
                {
                    result.Telecom = new List<Hl7.Fhir.Model.Contact>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "telecom") )
                        result.Telecom.Add(ContactParser.ParseContact(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element gender
                else if( atName == "gender" )
                    result.Gender = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element address
                else if( atName == "address" )
                    result.Address = AddressParser.ParseAddress(reader, errors);
                
                // Parse element photo
                else if( atName == "photo" )
                {
                    result.Photo = new List<Hl7.Fhir.Model.Attachment>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "photo") )
                        result.Photo.Add(AttachmentParser.ParseAttachment(reader, errors));
                    
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
