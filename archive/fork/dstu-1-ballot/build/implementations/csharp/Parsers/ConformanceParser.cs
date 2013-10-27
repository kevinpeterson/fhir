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
    /// Parser for Conformance instances
    /// </summary>
    internal static partial class ConformanceParser
    {
        /// <summary>
        /// Parse Conformance
        /// </summary>
        public static Hl7.Fhir.Model.Conformance ParseConformance(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance();
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
                    result.IdentifierElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element version
                else if( atName == "version" )
                    result.VersionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element name
                else if( atName == "name" )
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element publisher
                else if( atName == "publisher" )
                    result.PublisherElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element telecom
                else if( atName == "telecom" )
                {
                    result.Telecom = new List<Hl7.Fhir.Model.Contact>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "telecom") )
                        result.Telecom.Add(ContactParser.ParseContact(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.Conformance.ConformanceStatementStatus>(reader, errors);
                
                // Parse element experimental
                else if( atName == "experimental" )
                    result.ExperimentalElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element date
                else if( atName == "date" )
                    result.DateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element software
                else if( atName == "software" )
                    result.Software = ConformanceParser.ParseConformanceSoftwareComponent(reader, errors);
                
                // Parse element implementation
                else if( atName == "implementation" )
                    result.Implementation = ConformanceParser.ParseConformanceImplementationComponent(reader, errors);
                
                // Parse element fhirVersion
                else if( atName == "fhirVersion" )
                    result.FhirVersionElement = IdParser.ParseId(reader, errors);
                
                // Parse element acceptUnknown
                else if( atName == "acceptUnknown" )
                    result.AcceptUnknownElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element format
                else if( atName == "format" )
                {
                    result.FormatElement = new List<Hl7.Fhir.Model.Code>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "format") )
                        result.FormatElement.Add(CodeParser.ParseCode(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element rest
                else if( atName == "rest" )
                {
                    result.Rest = new List<Hl7.Fhir.Model.Conformance.ConformanceRestComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "rest") )
                        result.Rest.Add(ConformanceParser.ParseConformanceRestComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element messaging
                else if( atName == "messaging" )
                {
                    result.Messaging = new List<Hl7.Fhir.Model.Conformance.ConformanceMessagingComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "messaging") )
                        result.Messaging.Add(ConformanceParser.ParseConformanceMessagingComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element document
                else if( atName == "document" )
                {
                    result.Document = new List<Hl7.Fhir.Model.Conformance.ConformanceDocumentComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "document") )
                        result.Document.Add(ConformanceParser.ParseConformanceDocumentComponent(reader, errors));
                    
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
        /// Parse ConformanceRestQueryComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceRestQueryComponent ParseConformanceRestQueryComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceRestQueryComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceRestQueryComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceRestQueryComponent();
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
                
                // Parse element documentation
                else if( atName == "documentation" )
                    result.DocumentationElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element parameter
                else if( atName == "parameter" )
                {
                    result.Parameter = new List<Hl7.Fhir.Model.Conformance.ConformanceRestResourceSearchParamComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "parameter") )
                        result.Parameter.Add(ConformanceParser.ParseConformanceRestResourceSearchParamComponent(reader, errors));
                    
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
        /// Parse ConformanceRestComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceRestComponent ParseConformanceRestComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceRestComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceRestComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceRestComponent();
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
                
                // Parse element mode
                else if( atName == "mode" )
                    result.ModeElement = CodeParser.ParseCode<Hl7.Fhir.Model.Conformance.RestfulConformanceMode>(reader, errors);
                
                // Parse element documentation
                else if( atName == "documentation" )
                    result.DocumentationElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element security
                else if( atName == "security" )
                    result.Security = ConformanceParser.ParseConformanceRestSecurityComponent(reader, errors);
                
                // Parse element resource
                else if( atName == "resource" )
                {
                    result.Resource = new List<Hl7.Fhir.Model.Conformance.ConformanceRestResourceComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "resource") )
                        result.Resource.Add(ConformanceParser.ParseConformanceRestResourceComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element batch
                else if( atName == "batch" )
                    result.BatchElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element history
                else if( atName == "history" )
                    result.HistoryElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element query
                else if( atName == "query" )
                {
                    result.Query = new List<Hl7.Fhir.Model.Conformance.ConformanceRestQueryComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "query") )
                        result.Query.Add(ConformanceParser.ParseConformanceRestQueryComponent(reader, errors));
                    
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
        /// Parse ConformanceSoftwareComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceSoftwareComponent ParseConformanceSoftwareComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceSoftwareComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceSoftwareComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceSoftwareComponent();
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
                
                // Parse element version
                else if( atName == "version" )
                    result.VersionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element releaseDate
                else if( atName == "releaseDate" )
                    result.ReleaseDateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
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
        /// Parse ConformanceMessagingComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceMessagingComponent ParseConformanceMessagingComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceMessagingComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceMessagingComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceMessagingComponent();
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
                
                // Parse element endpoint
                else if( atName == "endpoint" )
                    result.EndpointElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element reliableCache
                else if( atName == "reliableCache" )
                    result.ReliableCacheElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element documentation
                else if( atName == "documentation" )
                    result.DocumentationElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element event
                else if( atName == "event" )
                {
                    result.Event = new List<Hl7.Fhir.Model.Conformance.ConformanceMessagingEventComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "event") )
                        result.Event.Add(ConformanceParser.ParseConformanceMessagingEventComponent(reader, errors));
                    
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
        /// Parse ConformanceDocumentComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceDocumentComponent ParseConformanceDocumentComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceDocumentComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceDocumentComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceDocumentComponent();
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
                
                // Parse element mode
                else if( atName == "mode" )
                    result.ModeElement = CodeParser.ParseCode<Hl7.Fhir.Model.Conformance.DocumentMode>(reader, errors);
                
                // Parse element documentation
                else if( atName == "documentation" )
                    result.DocumentationElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element profile
                else if( atName == "profile" )
                    result.Profile = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
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
        /// Parse ConformanceRestResourceComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceRestResourceComponent ParseConformanceRestResourceComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceRestResourceComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceRestResourceComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceRestResourceComponent();
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
                    result.TypeElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element profile
                else if( atName == "profile" )
                    result.Profile = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element operation
                else if( atName == "operation" )
                {
                    result.Operation = new List<Hl7.Fhir.Model.Conformance.ConformanceRestResourceOperationComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "operation") )
                        result.Operation.Add(ConformanceParser.ParseConformanceRestResourceOperationComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element readHistory
                else if( atName == "readHistory" )
                    result.ReadHistoryElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element searchInclude
                else if( atName == "searchInclude" )
                {
                    result.SearchIncludeElement = new List<Hl7.Fhir.Model.FhirString>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "searchInclude") )
                        result.SearchIncludeElement.Add(FhirStringParser.ParseFhirString(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element searchParam
                else if( atName == "searchParam" )
                {
                    result.SearchParam = new List<Hl7.Fhir.Model.Conformance.ConformanceRestResourceSearchParamComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "searchParam") )
                        result.SearchParam.Add(ConformanceParser.ParseConformanceRestResourceSearchParamComponent(reader, errors));
                    
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
        /// Parse ConformanceImplementationComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceImplementationComponent ParseConformanceImplementationComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceImplementationComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceImplementationComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceImplementationComponent();
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
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse ConformanceRestResourceOperationComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceRestResourceOperationComponent ParseConformanceRestResourceOperationComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceRestResourceOperationComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceRestResourceOperationComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceRestResourceOperationComponent();
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
                    result.CodeElement = CodeParser.ParseCode<Hl7.Fhir.Model.Conformance.RestfulOperation>(reader, errors);
                
                // Parse element documentation
                else if( atName == "documentation" )
                    result.DocumentationElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse ConformanceMessagingEventComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceMessagingEventComponent ParseConformanceMessagingEventComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceMessagingEventComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceMessagingEventComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceMessagingEventComponent();
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
                    result.CodeElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element mode
                else if( atName == "mode" )
                    result.ModeElement = CodeParser.ParseCode<Hl7.Fhir.Model.Conformance.ConformanceEventMode>(reader, errors);
                
                // Parse element protocol
                else if( atName == "protocol" )
                {
                    result.Protocol = new List<Hl7.Fhir.Model.Coding>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "protocol") )
                        result.Protocol.Add(CodingParser.ParseCoding(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element focus
                else if( atName == "focus" )
                    result.FocusElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element request
                else if( atName == "request" )
                    result.Request = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element response
                else if( atName == "response" )
                    result.Response = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element documentation
                else if( atName == "documentation" )
                    result.DocumentationElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse ConformanceRestSecurityComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceRestSecurityComponent ParseConformanceRestSecurityComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceRestSecurityComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceRestSecurityComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceRestSecurityComponent();
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
                
                // Parse element service
                else if( atName == "service" )
                {
                    result.Service = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "service") )
                        result.Service.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element certificate
                else if( atName == "certificate" )
                {
                    result.Certificate = new List<Hl7.Fhir.Model.Conformance.ConformanceRestSecurityCertificateComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "certificate") )
                        result.Certificate.Add(ConformanceParser.ParseConformanceRestSecurityCertificateComponent(reader, errors));
                    
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
        /// Parse ConformanceRestSecurityCertificateComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceRestSecurityCertificateComponent ParseConformanceRestSecurityCertificateComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceRestSecurityCertificateComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceRestSecurityCertificateComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceRestSecurityCertificateComponent();
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
                    result.TypeElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element blob
                else if( atName == "blob" )
                    result.BlobElement = Base64BinaryParser.ParseBase64Binary(reader, errors);
                
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
        /// Parse ConformanceRestResourceSearchParamComponent
        /// </summary>
        public static Hl7.Fhir.Model.Conformance.ConformanceRestResourceSearchParamComponent ParseConformanceRestResourceSearchParamComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Conformance.ConformanceRestResourceSearchParamComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Conformance.ConformanceRestResourceSearchParamComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Conformance.ConformanceRestResourceSearchParamComponent();
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
                
                // Parse element source
                else if( atName == "source" )
                    result.SourceElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.TypeElement = CodeParser.ParseCode<Hl7.Fhir.Model.Conformance.SearchParamType>(reader, errors);
                
                // Parse element documentation
                else if( atName == "documentation" )
                    result.DocumentationElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element xpath
                else if( atName == "xpath" )
                    result.XpathElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element target
                else if( atName == "target" )
                {
                    result.TargetElement = new List<Hl7.Fhir.Model.Code>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "target") )
                        result.TargetElement.Add(CodeParser.ParseCode(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element chain
                else if( atName == "chain" )
                {
                    result.ChainElement = new List<Hl7.Fhir.Model.FhirString>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "chain") )
                        result.ChainElement.Add(FhirStringParser.ParseFhirString(reader, errors));
                    
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
