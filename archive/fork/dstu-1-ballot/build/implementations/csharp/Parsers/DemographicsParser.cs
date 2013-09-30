using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

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
// Generated on Fri, Jul 5, 2013 15:14+1000 for FHIR v0.09
//

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Demographics instances
    /// </summary>
    internal static partial class DemographicsParser
    {
        /// <summary>
        /// Parse Demographics
        /// </summary>
        public static Hl7.Fhir.Model.Demographics ParseDemographics(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Demographics existingInstance = null )
        {
            Hl7.Fhir.Model.Demographics result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Demographics();
            try
            {
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
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                    
                    // Parse element identifier
                    else if( atName == "identifier" )
                    {
                        result.Identifier = new List<Hl7.Fhir.Model.Identifier>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                            result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element name
                    else if( atName == "name" )
                    {
                        result.Name = new List<Hl7.Fhir.Model.HumanName>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "name") )
                            result.Name.Add(HumanNameParser.ParseHumanName(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
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
                    
                    // Parse element birthDate
                    else if( atName == "birthDate" )
                        result.BirthDate = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element deceased
                    else if( atName == "deceased" )
                        result.Deceased = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element address
                    else if( atName == "address" )
                    {
                        result.Address = new List<Hl7.Fhir.Model.Address>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "address") )
                            result.Address.Add(AddressParser.ParseAddress(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element photo
                    else if( atName == "photo" )
                    {
                        result.Photo = new List<Hl7.Fhir.Model.Attachment>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "photo") )
                            result.Photo.Add(AttachmentParser.ParseAttachment(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element maritalStatus
                    else if( atName == "maritalStatus" )
                        result.MaritalStatus = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element language
                    else if( atName == "language" )
                    {
                        result.Language = new List<Hl7.Fhir.Model.Demographics.DemographicsLanguageComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "language") )
                            result.Language.Add(DemographicsParser.ParseDemographicsLanguageComponent(reader, errors));
                        
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
        /// Parse DemographicsLanguageComponent
        /// </summary>
        public static Hl7.Fhir.Model.Demographics.DemographicsLanguageComponent ParseDemographicsLanguageComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Demographics.DemographicsLanguageComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Demographics.DemographicsLanguageComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Demographics.DemographicsLanguageComponent();
            try
            {
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
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                    
                    // Parse element language
                    else if( atName == "language" )
                        result.Language = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element mode
                    else if( atName == "mode" )
                    {
                        result.Mode = new List<Hl7.Fhir.Model.CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "mode") )
                            result.Mode.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element proficiencyLevel
                    else if( atName == "proficiencyLevel" )
                        result.ProficiencyLevel = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element preference
                    else if( atName == "preference" )
                        result.Preference = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
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
