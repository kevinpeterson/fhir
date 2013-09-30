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
    /// Parser for Message instances
    /// </summary>
    internal static partial class MessageParser
    {
        /// <summary>
        /// Parse Message
        /// </summary>
        public static Hl7.Fhir.Model.Message ParseMessage(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Message existingInstance = null )
        {
            Hl7.Fhir.Model.Message result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Message();
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
                    result.IdentifierElement = IdParser.ParseId(reader, errors);
                
                // Parse element timestamp
                else if( atName == "timestamp" )
                    result.TimestampElement = InstantParser.ParseInstant(reader, errors);
                
                // Parse element event
                else if( atName == "event" )
                    result.EventElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element response
                else if( atName == "response" )
                    result.Response = MessageParser.ParseMessageResponseComponent(reader, errors);
                
                // Parse element source
                else if( atName == "source" )
                    result.Source = MessageParser.ParseMessageSourceComponent(reader, errors);
                
                // Parse element destination
                else if( atName == "destination" )
                    result.Destination = MessageParser.ParseMessageDestinationComponent(reader, errors);
                
                // Parse element enterer
                else if( atName == "enterer" )
                    result.Enterer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element author
                else if( atName == "author" )
                    result.Author = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element receiver
                else if( atName == "receiver" )
                    result.Receiver = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element responsible
                else if( atName == "responsible" )
                    result.Responsible = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element effective
                else if( atName == "effective" )
                    result.Effective = PeriodParser.ParsePeriod(reader, errors);
                
                // Parse element reason
                else if( atName == "reason" )
                    result.Reason = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element data
                else if( atName == "data" )
                {
                    result.Data = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "data") )
                        result.Data.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
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
        /// Parse MessageDestinationComponent
        /// </summary>
        public static Hl7.Fhir.Model.Message.MessageDestinationComponent ParseMessageDestinationComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Message.MessageDestinationComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Message.MessageDestinationComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Message.MessageDestinationComponent();
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
                
                // Parse element target
                else if( atName == "target" )
                    result.Target = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element endpoint
                else if( atName == "endpoint" )
                    result.EndpointElement = FhirUriParser.ParseFhirUri(reader, errors);
                
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
        /// Parse MessageSourceComponent
        /// </summary>
        public static Hl7.Fhir.Model.Message.MessageSourceComponent ParseMessageSourceComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Message.MessageSourceComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Message.MessageSourceComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Message.MessageSourceComponent();
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
                
                // Parse element software
                else if( atName == "software" )
                    result.SoftwareElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element version
                else if( atName == "version" )
                    result.VersionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element contact
                else if( atName == "contact" )
                    result.Contact = ContactParser.ParseContact(reader, errors);
                
                // Parse element endpoint
                else if( atName == "endpoint" )
                    result.EndpointElement = FhirUriParser.ParseFhirUri(reader, errors);
                
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
        /// Parse MessageResponseComponent
        /// </summary>
        public static Hl7.Fhir.Model.Message.MessageResponseComponent ParseMessageResponseComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Message.MessageResponseComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Message.MessageResponseComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Message.MessageResponseComponent();
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
                
                // Parse element identifier
                else if( atName == "identifier" )
                    result.IdentifierElement = IdParser.ParseId(reader, errors);
                
                // Parse element code
                else if( atName == "code" )
                    result.CodeElement = CodeParser.ParseCode<Hl7.Fhir.Model.Message.ResponseCode>(reader, errors);
                
                // Parse element details
                else if( atName == "details" )
                    result.Details = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
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
