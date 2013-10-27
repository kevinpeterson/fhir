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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A conformance statement
    /// </summary>
    [FhirResource("Conformance")]
    [Serializable]
    public partial class Conformance : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Operations supported by REST
        /// </summary>
        public enum RestfulOperation
        {
            Read, // Read the current state of the resource.
            Vread, // Read the state of a specific version of the resource.
            Update, // Update an existing resource by its id (or create it if it is new).
            Delete, // Delete a resource.
            HistoryInstance, // Retrieve the update history for a resource instance.
            Validate, // Check that the content would be acceptable as an update.
            HistoryType, // Get a list of updates to resources of this type.
            Create, // Create a new resource with a server assigned id.
            Search, // Supports search operations using the parameters described in the profile.
            Transaction, // Transaction performed on multiple resources.
            HistorySystem, // Get a list of updates to all resources on the system.
        }
        
        /// <summary>
        /// Conversion of RestfulOperationfrom and into string
        /// <summary>
        public static class RestfulOperationHandling
        {
            public static bool TryParse(string value, out RestfulOperation result)
            {
                result = default(RestfulOperation);
                
                if( value=="read")
                    result = RestfulOperation.Read;
                else if( value=="vread")
                    result = RestfulOperation.Vread;
                else if( value=="update")
                    result = RestfulOperation.Update;
                else if( value=="delete")
                    result = RestfulOperation.Delete;
                else if( value=="history-instance")
                    result = RestfulOperation.HistoryInstance;
                else if( value=="validate")
                    result = RestfulOperation.Validate;
                else if( value=="history-type")
                    result = RestfulOperation.HistoryType;
                else if( value=="create")
                    result = RestfulOperation.Create;
                else if( value=="search")
                    result = RestfulOperation.Search;
                else if( value=="transaction")
                    result = RestfulOperation.Transaction;
                else if( value=="history-system")
                    result = RestfulOperation.HistorySystem;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(RestfulOperation value)
            {
                if( value==RestfulOperation.Read )
                    return "read";
                else if( value==RestfulOperation.Vread )
                    return "vread";
                else if( value==RestfulOperation.Update )
                    return "update";
                else if( value==RestfulOperation.Delete )
                    return "delete";
                else if( value==RestfulOperation.HistoryInstance )
                    return "history-instance";
                else if( value==RestfulOperation.Validate )
                    return "validate";
                else if( value==RestfulOperation.HistoryType )
                    return "history-type";
                else if( value==RestfulOperation.Create )
                    return "create";
                else if( value==RestfulOperation.Search )
                    return "search";
                else if( value==RestfulOperation.Transaction )
                    return "transaction";
                else if( value==RestfulOperation.HistorySystem )
                    return "history-system";
                else
                    throw new ArgumentException("Unrecognized RestfulOperation value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Whether the application produces or consumes documents
        /// </summary>
        public enum DocumentMode
        {
            Producer, // The application produces documents of the specified type.
            Consumer, // The application consumes documents of the specified type.
        }
        
        /// <summary>
        /// Conversion of DocumentModefrom and into string
        /// <summary>
        public static class DocumentModeHandling
        {
            public static bool TryParse(string value, out DocumentMode result)
            {
                result = default(DocumentMode);
                
                if( value=="producer")
                    result = DocumentMode.Producer;
                else if( value=="consumer")
                    result = DocumentMode.Consumer;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DocumentMode value)
            {
                if( value==DocumentMode.Producer )
                    return "producer";
                else if( value==DocumentMode.Consumer )
                    return "consumer";
                else
                    throw new ArgumentException("Unrecognized DocumentMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The mode of a RESTful conformance statement
        /// </summary>
        public enum RestfulConformanceMode
        {
            Client, // The application acts as a server for this resource.
            Server, // The application acts as a client for this resource.
        }
        
        /// <summary>
        /// Conversion of RestfulConformanceModefrom and into string
        /// <summary>
        public static class RestfulConformanceModeHandling
        {
            public static bool TryParse(string value, out RestfulConformanceMode result)
            {
                result = default(RestfulConformanceMode);
                
                if( value=="client")
                    result = RestfulConformanceMode.Client;
                else if( value=="server")
                    result = RestfulConformanceMode.Server;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(RestfulConformanceMode value)
            {
                if( value==RestfulConformanceMode.Client )
                    return "client";
                else if( value==RestfulConformanceMode.Server )
                    return "server";
                else
                    throw new ArgumentException("Unrecognized RestfulConformanceMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The protocol used for message transport
        /// </summary>
        public enum MessageTransport
        {
            Http, // The application sends or receives messages using HTTP POST (may be over http or https).
            Ftp, // The application sends or receives messages using File Transfer Protocol.
            Mllp, // The application sends or receivers messages using HL7's Minimal Lower Level Protocol.
        }
        
        /// <summary>
        /// Conversion of MessageTransportfrom and into string
        /// <summary>
        public static class MessageTransportHandling
        {
            public static bool TryParse(string value, out MessageTransport result)
            {
                result = default(MessageTransport);
                
                if( value=="http")
                    result = MessageTransport.Http;
                else if( value=="ftp")
                    result = MessageTransport.Ftp;
                else if( value=="mllp")
                    result = MessageTransport.Mllp;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(MessageTransport value)
            {
                if( value==MessageTransport.Http )
                    return "http";
                else if( value==MessageTransport.Ftp )
                    return "ftp";
                else if( value==MessageTransport.Mllp )
                    return "mllp";
                else
                    throw new ArgumentException("Unrecognized MessageTransport value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The mode of a message conformance statement
        /// </summary>
        public enum ConformanceEventMode
        {
            Sender, // The application sends requests and receives responses.
            Receiver, // The application receives requests and sends responses.
        }
        
        /// <summary>
        /// Conversion of ConformanceEventModefrom and into string
        /// <summary>
        public static class ConformanceEventModeHandling
        {
            public static bool TryParse(string value, out ConformanceEventMode result)
            {
                result = default(ConformanceEventMode);
                
                if( value=="sender")
                    result = ConformanceEventMode.Sender;
                else if( value=="receiver")
                    result = ConformanceEventMode.Receiver;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ConformanceEventMode value)
            {
                if( value==ConformanceEventMode.Sender )
                    return "sender";
                else if( value==ConformanceEventMode.Receiver )
                    return "receiver";
                else
                    throw new ArgumentException("Unrecognized ConformanceEventMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The status of this conformance statement
        /// </summary>
        public enum ConformanceStatementStatus
        {
            Draft, // This conformance statement is still under development.
            Active, // This conformance statement is ready for use in production systems.
            Retired, // This conformance statement has been withdrawn or superceded and should no longer be used.
        }
        
        /// <summary>
        /// Conversion of ConformanceStatementStatusfrom and into string
        /// <summary>
        public static class ConformanceStatementStatusHandling
        {
            public static bool TryParse(string value, out ConformanceStatementStatus result)
            {
                result = default(ConformanceStatementStatus);
                
                if( value=="draft")
                    result = ConformanceStatementStatus.Draft;
                else if( value=="active")
                    result = ConformanceStatementStatus.Active;
                else if( value=="retired")
                    result = ConformanceStatementStatus.Retired;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ConformanceStatementStatus value)
            {
                if( value==ConformanceStatementStatus.Draft )
                    return "draft";
                else if( value==ConformanceStatementStatus.Active )
                    return "active";
                else if( value==ConformanceStatementStatus.Retired )
                    return "retired";
                else
                    throw new ArgumentException("Unrecognized ConformanceStatementStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Data types allowed to be used for search parameters
        /// </summary>
        public enum SearchParamType
        {
            Integer, // Search parameter must be a simple whole number.
            String, // Search parameter is a simple string, like a name part. Search is case-insensitive and accent-insensitive. May match just the start of a string. String parameters may contain spaces and are delineated by double quotes, e.g. "van Zanten".
            Text, // Search parameter is on a long string. Used for text filter type search: it functions on searches within a body of text and may contain spaces to separate words. May match even if the separate words are found out of order. Text parameters are delineated by double quotes.
            Date, // Search parameter is on a date (and should support :before and :after modifiers). The date format is the standard XML format, though other formats may be supported.
            Token, // Search parameter on a coded element or identifier. May be used to search through the text, displayname, code and code/codesystem (for codes) and label, system and key (for identifier). Its value is either a string or a pair of namespace and value, separated by a "/", depending on the modifier used.
            Reference, // A pair of resource type and resource id, separated by "/". Matches when the resource reference resolves to a resource of the given type and id. The resource type may be omitted to search all types if used with the modifier :any.
            Composite, // A composite search parameter that combines other search parameters together.
        }
        
        /// <summary>
        /// Conversion of SearchParamTypefrom and into string
        /// <summary>
        public static class SearchParamTypeHandling
        {
            public static bool TryParse(string value, out SearchParamType result)
            {
                result = default(SearchParamType);
                
                if( value=="integer")
                    result = SearchParamType.Integer;
                else if( value=="string")
                    result = SearchParamType.String;
                else if( value=="text")
                    result = SearchParamType.Text;
                else if( value=="date")
                    result = SearchParamType.Date;
                else if( value=="token")
                    result = SearchParamType.Token;
                else if( value=="reference")
                    result = SearchParamType.Reference;
                else if( value=="composite")
                    result = SearchParamType.Composite;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SearchParamType value)
            {
                if( value==SearchParamType.Integer )
                    return "integer";
                else if( value==SearchParamType.String )
                    return "string";
                else if( value==SearchParamType.Text )
                    return "text";
                else if( value==SearchParamType.Date )
                    return "date";
                else if( value==SearchParamType.Token )
                    return "token";
                else if( value==SearchParamType.Reference )
                    return "reference";
                else if( value==SearchParamType.Composite )
                    return "composite";
                else
                    throw new ArgumentException("Unrecognized SearchParamType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Types of security services used with FHIR
        /// </summary>
        public enum RestfulSecurityService
        {
            OAuth, // OAuth (see oauth.net).
            OAuth2, // OAuth version 2 (see oauth.net).
            NTLM, // Microsoft NTLM Authentication.
            Basic, // Basic authentication defined in HTTP specification.
            Kerberos, // see http://www.ietf.org/rfc/rfc4120.txt.
        }
        
        /// <summary>
        /// Conversion of RestfulSecurityServicefrom and into string
        /// <summary>
        public static class RestfulSecurityServiceHandling
        {
            public static bool TryParse(string value, out RestfulSecurityService result)
            {
                result = default(RestfulSecurityService);
                
                if( value=="OAuth")
                    result = RestfulSecurityService.OAuth;
                else if( value=="OAuth2")
                    result = RestfulSecurityService.OAuth2;
                else if( value=="NTLM")
                    result = RestfulSecurityService.NTLM;
                else if( value=="Basic")
                    result = RestfulSecurityService.Basic;
                else if( value=="Kerberos")
                    result = RestfulSecurityService.Kerberos;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(RestfulSecurityService value)
            {
                if( value==RestfulSecurityService.OAuth )
                    return "OAuth";
                else if( value==RestfulSecurityService.OAuth2 )
                    return "OAuth2";
                else if( value==RestfulSecurityService.NTLM )
                    return "NTLM";
                else if( value==RestfulSecurityService.Basic )
                    return "Basic";
                else if( value==RestfulSecurityService.Kerberos )
                    return "Kerberos";
                else
                    throw new ArgumentException("Unrecognized RestfulSecurityService value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestQueryComponent")]
        [Serializable]
        public partial class ConformanceRestQueryComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Name of the query (_query=)
            /// </summary>
            public Hl7.Fhir.Model.FhirString NameElement { get; set; }
            
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Describes the named query
            /// </summary>
            public Hl7.Fhir.Model.FhirString DocumentationElement { get; set; }
            
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if(value == null)
                      DocumentationElement = null; 
                    else
                      DocumentationElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Parameter for the named query
            /// </summary>
            public List<Hl7.Fhir.Model.Conformance.ConformanceRestResourceSearchParamComponent> Parameter { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(DocumentationElement != null )
                    result.AddRange(DocumentationElement.Validate());
                if(Parameter != null )
                    Parameter.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestComponent")]
        [Serializable]
        public partial class ConformanceRestComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// client | server
            /// </summary>
            public Code<Hl7.Fhir.Model.Conformance.RestfulConformanceMode> ModeElement { get; set; }
            
            public Hl7.Fhir.Model.Conformance.RestfulConformanceMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if(value == null)
                      ModeElement = null; 
                    else
                      ModeElement = new Code<Hl7.Fhir.Model.Conformance.RestfulConformanceMode>(value);
                }
            }
            
            /// <summary>
            /// General description of implementation
            /// </summary>
            public Hl7.Fhir.Model.FhirString DocumentationElement { get; set; }
            
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if(value == null)
                      DocumentationElement = null; 
                    else
                      DocumentationElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Information about security of implementation
            /// </summary>
            public Hl7.Fhir.Model.Conformance.ConformanceRestSecurityComponent Security { get; set; }
            
            /// <summary>
            /// Resource served on the REST interface
            /// </summary>
            public List<Hl7.Fhir.Model.Conformance.ConformanceRestResourceComponent> Resource { get; set; }
            
            /// <summary>
            /// If batches are supported
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean BatchElement { get; set; }
            
            public bool? Batch
            {
                get { return BatchElement != null ? BatchElement.Value : null; }
                set
                {
                    if(value == null)
                      BatchElement = null; 
                    else
                      BatchElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// If a system wide history list is supported
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean HistoryElement { get; set; }
            
            public bool? History
            {
                get { return HistoryElement != null ? HistoryElement.Value : null; }
                set
                {
                    if(value == null)
                      HistoryElement = null; 
                    else
                      HistoryElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// Definition of a named query
            /// </summary>
            public List<Hl7.Fhir.Model.Conformance.ConformanceRestQueryComponent> Query { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(ModeElement != null )
                    result.AddRange(ModeElement.Validate());
                if(DocumentationElement != null )
                    result.AddRange(DocumentationElement.Validate());
                if(Security != null )
                    result.AddRange(Security.Validate());
                if(Resource != null )
                    Resource.ForEach(elem => result.AddRange(elem.Validate()));
                if(BatchElement != null )
                    result.AddRange(BatchElement.Validate());
                if(HistoryElement != null )
                    result.AddRange(HistoryElement.Validate());
                if(Query != null )
                    Query.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceSoftwareComponent")]
        [Serializable]
        public partial class ConformanceSoftwareComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Name software is known by
            /// </summary>
            public Hl7.Fhir.Model.FhirString NameElement { get; set; }
            
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Version covered by this statement
            /// </summary>
            public Hl7.Fhir.Model.FhirString VersionElement { get; set; }
            
            public string Version
            {
                get { return VersionElement != null ? VersionElement.Value : null; }
                set
                {
                    if(value == null)
                      VersionElement = null; 
                    else
                      VersionElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Date this version released
            /// </summary>
            public Hl7.Fhir.Model.FhirDateTime ReleaseDateElement { get; set; }
            
            public string ReleaseDate
            {
                get { return ReleaseDateElement != null ? ReleaseDateElement.Value : null; }
                set
                {
                    if(value == null)
                      ReleaseDateElement = null; 
                    else
                      ReleaseDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(VersionElement != null )
                    result.AddRange(VersionElement.Validate());
                if(ReleaseDateElement != null )
                    result.AddRange(ReleaseDateElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceMessagingComponent")]
        [Serializable]
        public partial class ConformanceMessagingComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Actual endpoint being described
            /// </summary>
            public Hl7.Fhir.Model.FhirUri EndpointElement { get; set; }
            
            public System.Uri Endpoint
            {
                get { return EndpointElement != null ? EndpointElement.Value : null; }
                set
                {
                    if(value == null)
                      EndpointElement = null; 
                    else
                      EndpointElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// Reliable Message Cache Length
            /// </summary>
            public Hl7.Fhir.Model.Integer ReliableCacheElement { get; set; }
            
            public int? ReliableCache
            {
                get { return ReliableCacheElement != null ? ReliableCacheElement.Value : null; }
                set
                {
                    if(value == null)
                      ReliableCacheElement = null; 
                    else
                      ReliableCacheElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Messaging interface behavior details
            /// </summary>
            public Hl7.Fhir.Model.FhirString DocumentationElement { get; set; }
            
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if(value == null)
                      DocumentationElement = null; 
                    else
                      DocumentationElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Declare support for this event
            /// </summary>
            public List<Hl7.Fhir.Model.Conformance.ConformanceMessagingEventComponent> Event { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(EndpointElement != null )
                    result.AddRange(EndpointElement.Validate());
                if(ReliableCacheElement != null )
                    result.AddRange(ReliableCacheElement.Validate());
                if(DocumentationElement != null )
                    result.AddRange(DocumentationElement.Validate());
                if(Event != null )
                    Event.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceDocumentComponent")]
        [Serializable]
        public partial class ConformanceDocumentComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// producer | consumer
            /// </summary>
            public Code<Hl7.Fhir.Model.Conformance.DocumentMode> ModeElement { get; set; }
            
            public Hl7.Fhir.Model.Conformance.DocumentMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if(value == null)
                      ModeElement = null; 
                    else
                      ModeElement = new Code<Hl7.Fhir.Model.Conformance.DocumentMode>(value);
                }
            }
            
            /// <summary>
            /// Description of document support
            /// </summary>
            public Hl7.Fhir.Model.FhirString DocumentationElement { get; set; }
            
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if(value == null)
                      DocumentationElement = null; 
                    else
                      DocumentationElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Constraint on a resource used in the document
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Profile { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(ModeElement != null )
                    result.AddRange(ModeElement.Validate());
                if(DocumentationElement != null )
                    result.AddRange(DocumentationElement.Validate());
                if(Profile != null )
                    result.AddRange(Profile.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestResourceComponent")]
        [Serializable]
        public partial class ConformanceRestResourceComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Resource type
            /// </summary>
            public Hl7.Fhir.Model.Code TypeElement { get; set; }
            
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            /// <summary>
            /// Resource Profiles supported
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Profile { get; set; }
            
            /// <summary>
            /// What operations are supported?
            /// </summary>
            public List<Hl7.Fhir.Model.Conformance.ConformanceRestResourceOperationComponent> Operation { get; set; }
            
            /// <summary>
            /// Whether vRead can return past versions
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean ReadHistoryElement { get; set; }
            
            public bool? ReadHistory
            {
                get { return ReadHistoryElement != null ? ReadHistoryElement.Value : null; }
                set
                {
                    if(value == null)
                      ReadHistoryElement = null; 
                    else
                      ReadHistoryElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// _include values supported by the server
            /// </summary>
            public List<Hl7.Fhir.Model.FhirString> SearchIncludeElement { get; set; }
            
            public IEnumerable<string> SearchInclude
            {
                get { return SearchIncludeElement != null ? SearchIncludeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      SearchIncludeElement = null; 
                    else
                      SearchIncludeElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                }
            }
            
            /// <summary>
            /// Additional search params defined
            /// </summary>
            public List<Hl7.Fhir.Model.Conformance.ConformanceRestResourceSearchParamComponent> SearchParam { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                if(Profile != null )
                    result.AddRange(Profile.Validate());
                if(Operation != null )
                    Operation.ForEach(elem => result.AddRange(elem.Validate()));
                if(ReadHistoryElement != null )
                    result.AddRange(ReadHistoryElement.Validate());
                if(SearchIncludeElement != null )
                    SearchIncludeElement.ForEach(elem => result.AddRange(elem.Validate()));
                if(SearchParam != null )
                    SearchParam.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceImplementationComponent")]
        [Serializable]
        public partial class ConformanceImplementationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Describes this specific instance
            /// </summary>
            public Hl7.Fhir.Model.FhirString DescriptionElement { get; set; }
            
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Base URL for the installation
            /// </summary>
            public Hl7.Fhir.Model.FhirUri UrlElement { get; set; }
            
            public System.Uri Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if(value == null)
                      UrlElement = null; 
                    else
                      UrlElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(DescriptionElement != null )
                    result.AddRange(DescriptionElement.Validate());
                if(UrlElement != null )
                    result.AddRange(UrlElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestResourceOperationComponent")]
        [Serializable]
        public partial class ConformanceRestResourceOperationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// read | vread | update | etc.
            /// </summary>
            public Code<Hl7.Fhir.Model.Conformance.RestfulOperation> CodeElement { get; set; }
            
            public Hl7.Fhir.Model.Conformance.RestfulOperation? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeElement = null; 
                    else
                      CodeElement = new Code<Hl7.Fhir.Model.Conformance.RestfulOperation>(value);
                }
            }
            
            /// <summary>
            /// Anything special about operation behavior
            /// </summary>
            public Hl7.Fhir.Model.FhirString DocumentationElement { get; set; }
            
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if(value == null)
                      DocumentationElement = null; 
                    else
                      DocumentationElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(CodeElement != null )
                    result.AddRange(CodeElement.Validate());
                if(DocumentationElement != null )
                    result.AddRange(DocumentationElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceMessagingEventComponent")]
        [Serializable]
        public partial class ConformanceMessagingEventComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Event type
            /// </summary>
            public Hl7.Fhir.Model.Code CodeElement { get; set; }
            
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeElement = null; 
                    else
                      CodeElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            /// <summary>
            /// sender | receiver
            /// </summary>
            public Code<Hl7.Fhir.Model.Conformance.ConformanceEventMode> ModeElement { get; set; }
            
            public Hl7.Fhir.Model.Conformance.ConformanceEventMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if(value == null)
                      ModeElement = null; 
                    else
                      ModeElement = new Code<Hl7.Fhir.Model.Conformance.ConformanceEventMode>(value);
                }
            }
            
            /// <summary>
            /// http | ftp |MLLP | etc.
            /// </summary>
            public List<Hl7.Fhir.Model.Coding> Protocol { get; set; }
            
            /// <summary>
            /// Resource that's focus of message
            /// </summary>
            public Hl7.Fhir.Model.Code FocusElement { get; set; }
            
            public string Focus
            {
                get { return FocusElement != null ? FocusElement.Value : null; }
                set
                {
                    if(value == null)
                      FocusElement = null; 
                    else
                      FocusElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            /// <summary>
            /// Profile that describes the request
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Request { get; set; }
            
            /// <summary>
            /// Profile that describes the response
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Response { get; set; }
            
            /// <summary>
            /// Endpoint-specific event documentation
            /// </summary>
            public Hl7.Fhir.Model.FhirString DocumentationElement { get; set; }
            
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if(value == null)
                      DocumentationElement = null; 
                    else
                      DocumentationElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(CodeElement != null )
                    result.AddRange(CodeElement.Validate());
                if(ModeElement != null )
                    result.AddRange(ModeElement.Validate());
                if(Protocol != null )
                    Protocol.ForEach(elem => result.AddRange(elem.Validate()));
                if(FocusElement != null )
                    result.AddRange(FocusElement.Validate());
                if(Request != null )
                    result.AddRange(Request.Validate());
                if(Response != null )
                    result.AddRange(Response.Validate());
                if(DocumentationElement != null )
                    result.AddRange(DocumentationElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestSecurityComponent")]
        [Serializable]
        public partial class ConformanceRestSecurityComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// What type of security services are supported/required
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Service { get; set; }
            
            /// <summary>
            /// General description of how security works
            /// </summary>
            public Hl7.Fhir.Model.FhirString DescriptionElement { get; set; }
            
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Certificates associated with security profiles
            /// </summary>
            public List<Hl7.Fhir.Model.Conformance.ConformanceRestSecurityCertificateComponent> Certificate { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Service != null )
                    Service.ForEach(elem => result.AddRange(elem.Validate()));
                if(DescriptionElement != null )
                    result.AddRange(DescriptionElement.Validate());
                if(Certificate != null )
                    Certificate.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestSecurityCertificateComponent")]
        [Serializable]
        public partial class ConformanceRestSecurityCertificateComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Mime type for certificate
            /// </summary>
            public Hl7.Fhir.Model.Code TypeElement { get; set; }
            
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            /// <summary>
            /// Actual certificate
            /// </summary>
            public Hl7.Fhir.Model.Base64Binary BlobElement { get; set; }
            
            public byte[] Blob
            {
                get { return BlobElement != null ? BlobElement.Value : null; }
                set
                {
                    if(value == null)
                      BlobElement = null; 
                    else
                      BlobElement = new Hl7.Fhir.Model.Base64Binary(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                if(BlobElement != null )
                    result.AddRange(BlobElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestResourceSearchParamComponent")]
        [Serializable]
        public partial class ConformanceRestResourceSearchParamComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Name of search parameter
            /// </summary>
            public Hl7.Fhir.Model.FhirString NameElement { get; set; }
            
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Source of definition
            /// </summary>
            public Hl7.Fhir.Model.FhirUri SourceElement { get; set; }
            
            public System.Uri Source
            {
                get { return SourceElement != null ? SourceElement.Value : null; }
                set
                {
                    if(value == null)
                      SourceElement = null; 
                    else
                      SourceElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// Type of search parameter
            /// </summary>
            public Code<Hl7.Fhir.Model.Conformance.SearchParamType> TypeElement { get; set; }
            
            public Hl7.Fhir.Model.Conformance.SearchParamType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Code<Hl7.Fhir.Model.Conformance.SearchParamType>(value);
                }
            }
            
            /// <summary>
            /// Contents and meaning of search parameter
            /// </summary>
            public Hl7.Fhir.Model.FhirString DocumentationElement { get; set; }
            
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if(value == null)
                      DocumentationElement = null; 
                    else
                      DocumentationElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// XPath that extracts the parameter set
            /// </summary>
            public Hl7.Fhir.Model.FhirString XpathElement { get; set; }
            
            public string Xpath
            {
                get { return XpathElement != null ? XpathElement.Value : null; }
                set
                {
                    if(value == null)
                      XpathElement = null; 
                    else
                      XpathElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Types of resource (if a resource reference)
            /// </summary>
            public List<Hl7.Fhir.Model.Code> TargetElement { get; set; }
            
            public IEnumerable<string> Target
            {
                get { return TargetElement != null ? TargetElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      TargetElement = null; 
                    else
                      TargetElement = new List<Hl7.Fhir.Model.Code>(value.Select(elem=>new Hl7.Fhir.Model.Code(elem)));
                }
            }
            
            /// <summary>
            /// Chained names supported
            /// </summary>
            public List<Hl7.Fhir.Model.FhirString> ChainElement { get; set; }
            
            public IEnumerable<string> Chain
            {
                get { return ChainElement != null ? ChainElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      ChainElement = null; 
                    else
                      ChainElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(SourceElement != null )
                    result.AddRange(SourceElement.Validate());
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                if(DocumentationElement != null )
                    result.AddRange(DocumentationElement.Validate());
                if(XpathElement != null )
                    result.AddRange(XpathElement.Validate());
                if(TargetElement != null )
                    TargetElement.ForEach(elem => result.AddRange(elem.Validate()));
                if(ChainElement != null )
                    ChainElement.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Logical id to reference this statement
        /// </summary>
        public Hl7.Fhir.Model.FhirString IdentifierElement { get; set; }
        
        public string Identifier
        {
            get { return IdentifierElement != null ? IdentifierElement.Value : null; }
            set
            {
                if(value == null)
                  IdentifierElement = null; 
                else
                  IdentifierElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Logical id for this version of the statement
        /// </summary>
        public Hl7.Fhir.Model.FhirString VersionElement { get; set; }
        
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if(value == null)
                  VersionElement = null; 
                else
                  VersionElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Informal name for this conformance statement
        /// </summary>
        public Hl7.Fhir.Model.FhirString NameElement { get; set; }
        
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if(value == null)
                  NameElement = null; 
                else
                  NameElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Publishing Organization
        /// </summary>
        public Hl7.Fhir.Model.FhirString PublisherElement { get; set; }
        
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if(value == null)
                  PublisherElement = null; 
                else
                  PublisherElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Contacts for Organization
        /// </summary>
        public List<Hl7.Fhir.Model.Contact> Telecom { get; set; }
        
        /// <summary>
        /// Human description of the conformance statement
        /// </summary>
        public Hl7.Fhir.Model.FhirString DescriptionElement { get; set; }
        
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// draft | experimental | review | production | withdrawn | superseded
        /// </summary>
        public Code<Hl7.Fhir.Model.Conformance.ConformanceStatementStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.Conformance.ConformanceStatementStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Conformance.ConformanceStatementStatus>(value);
            }
        }
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean ExperimentalElement { get; set; }
        
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if(value == null)
                  ExperimentalElement = null; 
                else
                  ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        /// <summary>
        /// Publication Date
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime DateElement { get; set; }
        
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// Software that is covered by this conformance statement
        /// </summary>
        public Hl7.Fhir.Model.Conformance.ConformanceSoftwareComponent Software { get; set; }
        
        /// <summary>
        /// If this describes a specific instance
        /// </summary>
        public Hl7.Fhir.Model.Conformance.ConformanceImplementationComponent Implementation { get; set; }
        
        /// <summary>
        /// FHIR Version
        /// </summary>
        public Hl7.Fhir.Model.Id FhirVersionElement { get; set; }
        
        public string FhirVersion
        {
            get { return FhirVersionElement != null ? FhirVersionElement.Value : null; }
            set
            {
                if(value == null)
                  FhirVersionElement = null; 
                else
                  FhirVersionElement = new Hl7.Fhir.Model.Id(value);
            }
        }
        
        /// <summary>
        /// True if application accepts unknown elements
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean AcceptUnknownElement { get; set; }
        
        public bool? AcceptUnknown
        {
            get { return AcceptUnknownElement != null ? AcceptUnknownElement.Value : null; }
            set
            {
                if(value == null)
                  AcceptUnknownElement = null; 
                else
                  AcceptUnknownElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        /// <summary>
        /// formats supported (xml | json | mime type)
        /// </summary>
        public List<Hl7.Fhir.Model.Code> FormatElement { get; set; }
        
        public IEnumerable<string> Format
        {
            get { return FormatElement != null ? FormatElement.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  FormatElement = null; 
                else
                  FormatElement = new List<Hl7.Fhir.Model.Code>(value.Select(elem=>new Hl7.Fhir.Model.Code(elem)));
            }
        }
        
        /// <summary>
        /// If the endpoint is a RESTful one
        /// </summary>
        public List<Hl7.Fhir.Model.Conformance.ConformanceRestComponent> Rest { get; set; }
        
        /// <summary>
        /// If messaging is supported
        /// </summary>
        public List<Hl7.Fhir.Model.Conformance.ConformanceMessagingComponent> Messaging { get; set; }
        
        /// <summary>
        /// Document definition
        /// </summary>
        public List<Hl7.Fhir.Model.Conformance.ConformanceDocumentComponent> Document { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(IdentifierElement != null )
                result.AddRange(IdentifierElement.Validate());
            if(VersionElement != null )
                result.AddRange(VersionElement.Validate());
            if(NameElement != null )
                result.AddRange(NameElement.Validate());
            if(PublisherElement != null )
                result.AddRange(PublisherElement.Validate());
            if(Telecom != null )
                Telecom.ForEach(elem => result.AddRange(elem.Validate()));
            if(DescriptionElement != null )
                result.AddRange(DescriptionElement.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(ExperimentalElement != null )
                result.AddRange(ExperimentalElement.Validate());
            if(DateElement != null )
                result.AddRange(DateElement.Validate());
            if(Software != null )
                result.AddRange(Software.Validate());
            if(Implementation != null )
                result.AddRange(Implementation.Validate());
            if(FhirVersionElement != null )
                result.AddRange(FhirVersionElement.Validate());
            if(AcceptUnknownElement != null )
                result.AddRange(AcceptUnknownElement.Validate());
            if(FormatElement != null )
                FormatElement.ForEach(elem => result.AddRange(elem.Validate()));
            if(Rest != null )
                Rest.ForEach(elem => result.AddRange(elem.Validate()));
            if(Messaging != null )
                Messaging.ForEach(elem => result.AddRange(elem.Validate()));
            if(Document != null )
                Document.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
