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
    /// Parser for Patient instances
    /// </summary>
    internal static partial class PatientParser
    {
        /// <summary>
        /// Parse Patient
        /// </summary>
        public static Hl7.Fhir.Model.Patient ParsePatient(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Patient existingInstance = null )
        {
            Hl7.Fhir.Model.Patient result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Patient();
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
                    result.BirthDateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element deceased
                else if( atName.StartsWith("deceased") )
                    result.Deceased = FhirParser.ParseElement(reader, errors);
                
                // Parse element address
                else if( atName == "address" )
                {
                    result.Address = new List<Hl7.Fhir.Model.Address>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "address") )
                        result.Address.Add(AddressParser.ParseAddress(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element maritalStatus
                else if( atName == "maritalStatus" )
                    result.MaritalStatus = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element multipleBirth
                else if( atName.StartsWith("multipleBirth") )
                    result.MultipleBirth = FhirParser.ParseElement(reader, errors);
                
                // Parse element photo
                else if( atName == "photo" )
                {
                    result.Photo = new List<Hl7.Fhir.Model.Attachment>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "photo") )
                        result.Photo.Add(AttachmentParser.ParseAttachment(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element contact
                else if( atName == "contact" )
                {
                    result.Contact = new List<Hl7.Fhir.Model.Patient.ContactComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "contact") )
                        result.Contact.Add(PatientParser.ParseContactComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element animal
                else if( atName == "animal" )
                    result.Animal = PatientParser.ParseAnimalComponent(reader, errors);
                
                // Parse element communication
                else if( atName == "communication" )
                {
                    result.Communication = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "communication") )
                        result.Communication.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element provider
                else if( atName == "provider" )
                    result.Provider = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element link
                else if( atName == "link" )
                {
                    result.Link = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "link") )
                        result.Link.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element active
                else if( atName == "active" )
                    result.ActiveElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
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
        /// Parse ContactComponent
        /// </summary>
        public static Hl7.Fhir.Model.Patient.ContactComponent ParseContactComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Patient.ContactComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Patient.ContactComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Patient.ContactComponent();
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
                
                // Parse element relationship
                else if( atName == "relationship" )
                {
                    result.Relationship = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "relationship") )
                        result.Relationship.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
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
                
                // Parse element address
                else if( atName == "address" )
                    result.Address = AddressParser.ParseAddress(reader, errors);
                
                // Parse element gender
                else if( atName == "gender" )
                    result.Gender = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element organization
                else if( atName == "organization" )
                    result.Organization = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
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
        /// Parse AnimalComponent
        /// </summary>
        public static Hl7.Fhir.Model.Patient.AnimalComponent ParseAnimalComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Patient.AnimalComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Patient.AnimalComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Patient.AnimalComponent();
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
                
                // Parse element species
                else if( atName == "species" )
                    result.Species = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element breed
                else if( atName == "breed" )
                    result.Breed = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element genderStatus
                else if( atName == "genderStatus" )
                    result.GenderStatus = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
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
