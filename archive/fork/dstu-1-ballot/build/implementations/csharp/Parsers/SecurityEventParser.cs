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
    /// Parser for SecurityEvent instances
    /// </summary>
    internal static partial class SecurityEventParser
    {
        /// <summary>
        /// Parse SecurityEvent
        /// </summary>
        public static Hl7.Fhir.Model.SecurityEvent ParseSecurityEvent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.SecurityEvent existingInstance = null )
        {
            Hl7.Fhir.Model.SecurityEvent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.SecurityEvent();
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
                
                // Parse element event
                else if( atName == "event" )
                    result.Event = SecurityEventParser.ParseSecurityEventEventComponent(reader, errors);
                
                // Parse element participant
                else if( atName == "participant" )
                {
                    result.Participant = new List<Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "participant") )
                        result.Participant.Add(SecurityEventParser.ParseSecurityEventParticipantComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element source
                else if( atName == "source" )
                    result.Source = SecurityEventParser.ParseSecurityEventSourceComponent(reader, errors);
                
                // Parse element object
                else if( atName == "object" )
                {
                    result.Object = new List<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "object") )
                        result.Object.Add(SecurityEventParser.ParseSecurityEventObjectComponent(reader, errors));
                    
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
        /// Parse SecurityEventObjectDetailComponent
        /// </summary>
        public static Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectDetailComponent ParseSecurityEventObjectDetailComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectDetailComponent existingInstance = null )
        {
            Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectDetailComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectDetailComponent();
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
                    result.TypeElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element value
                else if( atName == "value" )
                    result.ValueElement = Base64BinaryParser.ParseBase64Binary(reader, errors);
                
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
        /// Parse SecurityEventObjectComponent
        /// </summary>
        public static Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectComponent ParseSecurityEventObjectComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectComponent existingInstance = null )
        {
            Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectComponent();
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
                    result.Identifier = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element reference
                else if( atName == "reference" )
                    result.Reference = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.TypeElement = CodeParser.ParseCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectType>(reader, errors);
                
                // Parse element role
                else if( atName == "role" )
                    result.RoleElement = CodeParser.ParseCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRole>(reader, errors);
                
                // Parse element lifecycle
                else if( atName == "lifecycle" )
                    result.LifecycleElement = CodeParser.ParseCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycle>(reader, errors);
                
                // Parse element sensitivity
                else if( atName == "sensitivity" )
                    result.Sensitivity = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element name
                else if( atName == "name" )
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element query
                else if( atName == "query" )
                    result.QueryElement = Base64BinaryParser.ParseBase64Binary(reader, errors);
                
                // Parse element detail
                else if( atName == "detail" )
                {
                    result.Detail = new List<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectDetailComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "detail") )
                        result.Detail.Add(SecurityEventParser.ParseSecurityEventObjectDetailComponent(reader, errors));
                    
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
        /// Parse SecurityEventSourceComponent
        /// </summary>
        public static Hl7.Fhir.Model.SecurityEvent.SecurityEventSourceComponent ParseSecurityEventSourceComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.SecurityEvent.SecurityEventSourceComponent existingInstance = null )
        {
            Hl7.Fhir.Model.SecurityEvent.SecurityEventSourceComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.SecurityEvent.SecurityEventSourceComponent();
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
                
                // Parse element site
                else if( atName == "site" )
                    result.SiteElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element identifier
                else if( atName == "identifier" )
                    result.IdentifierElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                {
                    result.Type = new List<Hl7.Fhir.Model.Coding>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "type") )
                        result.Type.Add(CodingParser.ParseCoding(reader, errors));
                    
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
        /// Parse SecurityEventEventComponent
        /// </summary>
        public static Hl7.Fhir.Model.SecurityEvent.SecurityEventEventComponent ParseSecurityEventEventComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.SecurityEvent.SecurityEventEventComponent existingInstance = null )
        {
            Hl7.Fhir.Model.SecurityEvent.SecurityEventEventComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.SecurityEvent.SecurityEventEventComponent();
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
                
                // Parse element subtype
                else if( atName == "subtype" )
                {
                    result.Subtype = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "subtype") )
                        result.Subtype.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element action
                else if( atName == "action" )
                    result.ActionElement = CodeParser.ParseCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventAction>(reader, errors);
                
                // Parse element dateTime
                else if( atName == "dateTime" )
                    result.DateTimeElement = InstantParser.ParseInstant(reader, errors);
                
                // Parse element outcome
                else if( atName == "outcome" )
                    result.OutcomeElement = CodeParser.ParseCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcome>(reader, errors);
                
                // Parse element outcomeDesc
                else if( atName == "outcomeDesc" )
                    result.OutcomeDescElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse SecurityEventParticipantNetworkComponent
        /// </summary>
        public static Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkComponent ParseSecurityEventParticipantNetworkComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkComponent existingInstance = null )
        {
            Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkComponent();
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
                    result.IdentifierElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.TypeElement = CodeParser.ParseCode<Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkType>(reader, errors);
                
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
        /// Parse SecurityEventParticipantComponent
        /// </summary>
        public static Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantComponent ParseSecurityEventParticipantComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantComponent existingInstance = null )
        {
            Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantComponent();
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
                
                // Parse element role
                else if( atName == "role" )
                {
                    result.Role = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "role") )
                        result.Role.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element reference
                else if( atName == "reference" )
                    result.Reference = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element userId
                else if( atName == "userId" )
                    result.UserIdElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element authId
                else if( atName == "authId" )
                    result.AuthIdElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element name
                else if( atName == "name" )
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element requestor
                else if( atName == "requestor" )
                    result.RequestorElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element media
                else if( atName == "media" )
                    result.Media = CodingParser.ParseCoding(reader, errors);
                
                // Parse element network
                else if( atName == "network" )
                    result.Network = SecurityEventParser.ParseSecurityEventParticipantNetworkComponent(reader, errors);
                
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
