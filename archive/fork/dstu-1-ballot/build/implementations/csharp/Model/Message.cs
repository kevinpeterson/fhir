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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A message that contains resources
    /// </summary>
    [FhirResource("Message")]
    [Serializable]
    public partial class Message : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The kind of response to a message
        /// </summary>
        public enum ResponseCode
        {
            Ok, // The message was accepted and processed without error.
            Error, // Some internal unexpected error occurred - wait and try again. Note - this is usually used for things like database unavailable, which may be expected to resolve, though human intervention may be required.
            Rejection, // The message was rejected because of some content in it. There is no point in re-sending without change. The response narrative must describe what the issue is.
            Rules, // The message was rejected because of some event-specific business rules, and it may be possible to modify the request and re-submit (as a different request). The response must include an Issue report that describes what problem is.
            Undeliverable, // A middleware agent was unable to deliver the message to its intended destination.
        }
        
        /// <summary>
        /// Conversion of ResponseCodefrom and into string
        /// <summary>
        public static class ResponseCodeHandling
        {
            public static bool TryParse(string value, out ResponseCode result)
            {
                result = default(ResponseCode);
                
                if( value=="ok")
                    result = ResponseCode.Ok;
                else if( value=="error")
                    result = ResponseCode.Error;
                else if( value=="rejection")
                    result = ResponseCode.Rejection;
                else if( value=="rules")
                    result = ResponseCode.Rules;
                else if( value=="undeliverable")
                    result = ResponseCode.Undeliverable;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ResponseCode value)
            {
                if( value==ResponseCode.Ok )
                    return "ok";
                else if( value==ResponseCode.Error )
                    return "error";
                else if( value==ResponseCode.Rejection )
                    return "rejection";
                else if( value==ResponseCode.Rules )
                    return "rules";
                else if( value==ResponseCode.Undeliverable )
                    return "undeliverable";
                else
                    throw new ArgumentException("Unrecognized ResponseCode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MessageDestinationComponent")]
        [Serializable]
        public partial class MessageDestinationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Name of system
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
            /// Particular delivery destination within the destination
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Target { get; set; }
            
            /// <summary>
            /// Actual destination address or id
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
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(Target != null )
                    result.AddRange(Target.Validate());
                if(EndpointElement != null )
                    result.AddRange(EndpointElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MessageSourceComponent")]
        [Serializable]
        public partial class MessageSourceComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Name of system
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
            /// Name of software running the system
            /// </summary>
            public Hl7.Fhir.Model.FhirString SoftwareElement { get; set; }
            
            public string Software
            {
                get { return SoftwareElement != null ? SoftwareElement.Value : null; }
                set
                {
                    if(value == null)
                      SoftwareElement = null; 
                    else
                      SoftwareElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Version of software running
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
            /// Human contact for problems
            /// </summary>
            public Hl7.Fhir.Model.Contact Contact { get; set; }
            
            /// <summary>
            /// Actual message source address or id
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
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(SoftwareElement != null )
                    result.AddRange(SoftwareElement.Validate());
                if(VersionElement != null )
                    result.AddRange(VersionElement.Validate());
                if(Contact != null )
                    result.AddRange(Contact.Validate());
                if(EndpointElement != null )
                    result.AddRange(EndpointElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MessageResponseComponent")]
        [Serializable]
        public partial class MessageResponseComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Id of original message
            /// </summary>
            public Hl7.Fhir.Model.Id IdentifierElement { get; set; }
            
            public string Identifier
            {
                get { return IdentifierElement != null ? IdentifierElement.Value : null; }
                set
                {
                    if(value == null)
                      IdentifierElement = null; 
                    else
                      IdentifierElement = new Hl7.Fhir.Model.Id(value);
                }
            }
            
            /// <summary>
            /// Type of response to the message
            /// </summary>
            public Code<Hl7.Fhir.Model.Message.ResponseCode> CodeElement { get; set; }
            
            public Hl7.Fhir.Model.Message.ResponseCode? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeElement = null; 
                    else
                      CodeElement = new Code<Hl7.Fhir.Model.Message.ResponseCode>(value);
                }
            }
            
            /// <summary>
            /// Specific list of hints/warnings/errors
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Details { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(IdentifierElement != null )
                    result.AddRange(IdentifierElement.Validate());
                if(CodeElement != null )
                    result.AddRange(CodeElement.Validate());
                if(Details != null )
                    result.AddRange(Details.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Id of this message
        /// </summary>
        public Hl7.Fhir.Model.Id IdentifierElement { get; set; }
        
        public string Identifier
        {
            get { return IdentifierElement != null ? IdentifierElement.Value : null; }
            set
            {
                if(value == null)
                  IdentifierElement = null; 
                else
                  IdentifierElement = new Hl7.Fhir.Model.Id(value);
            }
        }
        
        /// <summary>
        /// Time that the message was sent
        /// </summary>
        public Hl7.Fhir.Model.Instant TimestampElement { get; set; }
        
        public DateTimeOffset? Timestamp
        {
            get { return TimestampElement != null ? TimestampElement.Value : null; }
            set
            {
                if(value == null)
                  TimestampElement = null; 
                else
                  TimestampElement = new Hl7.Fhir.Model.Instant(value);
            }
        }
        
        /// <summary>
        /// Code for the event this message represents
        /// </summary>
        public Hl7.Fhir.Model.Code EventElement { get; set; }
        
        public string Event
        {
            get { return EventElement != null ? EventElement.Value : null; }
            set
            {
                if(value == null)
                  EventElement = null; 
                else
                  EventElement = new Hl7.Fhir.Model.Code(value);
            }
        }
        
        /// <summary>
        /// If this is a reply to prior message
        /// </summary>
        public Hl7.Fhir.Model.Message.MessageResponseComponent Response { get; set; }
        
        /// <summary>
        /// Message Source Application
        /// </summary>
        public Hl7.Fhir.Model.Message.MessageSourceComponent Source { get; set; }
        
        /// <summary>
        /// Message Destination Application
        /// </summary>
        public Hl7.Fhir.Model.Message.MessageDestinationComponent Destination { get; set; }
        
        /// <summary>
        /// The source of the data entry
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Enterer { get; set; }
        
        /// <summary>
        /// The source of the decision
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Author { get; set; }
        
        /// <summary>
        /// Intended "real-world" recipient for the data
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Receiver { get; set; }
        
        /// <summary>
        /// Final responsibility for event
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Responsible { get; set; }
        
        /// <summary>
        /// Time of effect
        /// </summary>
        public Hl7.Fhir.Model.Period Effective { get; set; }
        
        /// <summary>
        /// Cause of event
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Reason { get; set; }
        
        /// <summary>
        /// The actual content of the message
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Data { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(IdentifierElement != null )
                result.AddRange(IdentifierElement.Validate());
            if(TimestampElement != null )
                result.AddRange(TimestampElement.Validate());
            if(EventElement != null )
                result.AddRange(EventElement.Validate());
            if(Response != null )
                result.AddRange(Response.Validate());
            if(Source != null )
                result.AddRange(Source.Validate());
            if(Destination != null )
                result.AddRange(Destination.Validate());
            if(Enterer != null )
                result.AddRange(Enterer.Validate());
            if(Author != null )
                result.AddRange(Author.Validate());
            if(Receiver != null )
                result.AddRange(Receiver.Validate());
            if(Responsible != null )
                result.AddRange(Responsible.Validate());
            if(Effective != null )
                result.AddRange(Effective.Validate());
            if(Reason != null )
                result.AddRange(Reason.Validate());
            if(Data != null )
                Data.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
