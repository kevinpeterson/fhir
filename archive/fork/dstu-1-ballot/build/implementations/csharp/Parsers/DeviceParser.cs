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
    /// Parser for Device instances
    /// </summary>
    internal static partial class DeviceParser
    {
        /// <summary>
        /// Parse Device
        /// </summary>
        public static Hl7.Fhir.Model.Device ParseDevice(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Device existingInstance = null )
        {
            Hl7.Fhir.Model.Device result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Device();
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
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element manufacturer
                else if( atName == "manufacturer" )
                    result.ManufacturerElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element model
                else if( atName == "model" )
                    result.ModelElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element version
                else if( atName == "version" )
                    result.VersionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element expiry
                else if( atName == "expiry" )
                    result.ExpiryElement = DateParser.ParseDate(reader, errors);
                
                // Parse element identity
                else if( atName == "identity" )
                    result.Identity = DeviceParser.ParseDeviceIdentityComponent(reader, errors);
                
                // Parse element owner
                else if( atName == "owner" )
                    result.Owner = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element assignedId
                else if( atName == "assignedId" )
                {
                    result.AssignedId = new List<Hl7.Fhir.Model.Identifier>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "assignedId") )
                        result.AssignedId.Add(IdentifierParser.ParseIdentifier(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element location
                else if( atName == "location" )
                    result.Location = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element patient
                else if( atName == "patient" )
                    result.Patient = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element contact
                else if( atName == "contact" )
                {
                    result.Contact = new List<Hl7.Fhir.Model.Contact>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "contact") )
                        result.Contact.Add(ContactParser.ParseContact(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element url
                else if( atName == "url" )
                    result.UrlElement = FhirUriParser.ParseFhirUri(reader, errors);
                
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
        /// Parse DeviceIdentityComponent
        /// </summary>
        public static Hl7.Fhir.Model.Device.DeviceIdentityComponent ParseDeviceIdentityComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Device.DeviceIdentityComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Device.DeviceIdentityComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Device.DeviceIdentityComponent();
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
                
                // Parse element gtin
                else if( atName == "gtin" )
                    result.GtinElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element lot
                else if( atName == "lot" )
                    result.LotElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element serialNumber
                else if( atName == "serialNumber" )
                    result.SerialNumberElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
