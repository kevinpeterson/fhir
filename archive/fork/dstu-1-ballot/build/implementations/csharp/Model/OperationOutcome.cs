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
    /// Information about the success/failure of an action
    /// </summary>
    [FhirResource("OperationOutcome")]
    [Serializable]
    public partial class OperationOutcome : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// A coded expression of the type of issue
        /// </summary>
        public enum IssueType
        {
            Invalid, // Content invalid against Specification or Profile.
            Structure, // content structural issue.
            Required, // required element missing.
            Value, // element value invalid.
            Invariant, // schematron rule.
            Security, // authorization/permissions issue.
            Login, // the client needs to initiate the authentication process ().
            Unknown, // user/system not able to be authenticated.
            Expired, // user session expired.
            Forbidden, // user rights failure.
            Processing, // processing issues.
            NotSupported, // resource not supported.
            Duplicate, // duplicate resource.
            NotFound, // reference not found.
            TooLong, // existing content too long.
            CodeUnknown, // code could not be understood.
            Extension, // extension not recognised.
            TooCostly, // operation denied to protect server resources.
            BusinessRule, // content failed to pass some business rule.
            Conflict, // content could not be accepted because of an edit conflict (i.e. version aware updates).
            Transient, // transient processing issues.
            LockError, // resource/record locking failure.
            NoStore, // persistent store unavailable.
            Exception, // unexpected internal error.
            Timeout, // internal timeout.
            Throttled, // The system is not prepared to handle this request due to load management.
        }
        
        /// <summary>
        /// Conversion of IssueTypefrom and into string
        /// <summary>
        public static class IssueTypeHandling
        {
            public static bool TryParse(string value, out IssueType result)
            {
                result = default(IssueType);
                
                if( value=="invalid")
                    result = IssueType.Invalid;
                else if( value=="structure")
                    result = IssueType.Structure;
                else if( value=="required")
                    result = IssueType.Required;
                else if( value=="value")
                    result = IssueType.Value;
                else if( value=="invariant")
                    result = IssueType.Invariant;
                else if( value=="security")
                    result = IssueType.Security;
                else if( value=="login")
                    result = IssueType.Login;
                else if( value=="unknown")
                    result = IssueType.Unknown;
                else if( value=="expired")
                    result = IssueType.Expired;
                else if( value=="forbidden")
                    result = IssueType.Forbidden;
                else if( value=="processing")
                    result = IssueType.Processing;
                else if( value=="not-supported")
                    result = IssueType.NotSupported;
                else if( value=="duplicate")
                    result = IssueType.Duplicate;
                else if( value=="not-found")
                    result = IssueType.NotFound;
                else if( value=="too-long")
                    result = IssueType.TooLong;
                else if( value=="code-unknown")
                    result = IssueType.CodeUnknown;
                else if( value=="extension")
                    result = IssueType.Extension;
                else if( value=="too-costly")
                    result = IssueType.TooCostly;
                else if( value=="business-rule")
                    result = IssueType.BusinessRule;
                else if( value=="conflict")
                    result = IssueType.Conflict;
                else if( value=="transient")
                    result = IssueType.Transient;
                else if( value=="lock-error")
                    result = IssueType.LockError;
                else if( value=="no-store")
                    result = IssueType.NoStore;
                else if( value=="exception")
                    result = IssueType.Exception;
                else if( value=="timeout")
                    result = IssueType.Timeout;
                else if( value=="throttled")
                    result = IssueType.Throttled;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(IssueType value)
            {
                if( value==IssueType.Invalid )
                    return "invalid";
                else if( value==IssueType.Structure )
                    return "structure";
                else if( value==IssueType.Required )
                    return "required";
                else if( value==IssueType.Value )
                    return "value";
                else if( value==IssueType.Invariant )
                    return "invariant";
                else if( value==IssueType.Security )
                    return "security";
                else if( value==IssueType.Login )
                    return "login";
                else if( value==IssueType.Unknown )
                    return "unknown";
                else if( value==IssueType.Expired )
                    return "expired";
                else if( value==IssueType.Forbidden )
                    return "forbidden";
                else if( value==IssueType.Processing )
                    return "processing";
                else if( value==IssueType.NotSupported )
                    return "not-supported";
                else if( value==IssueType.Duplicate )
                    return "duplicate";
                else if( value==IssueType.NotFound )
                    return "not-found";
                else if( value==IssueType.TooLong )
                    return "too-long";
                else if( value==IssueType.CodeUnknown )
                    return "code-unknown";
                else if( value==IssueType.Extension )
                    return "extension";
                else if( value==IssueType.TooCostly )
                    return "too-costly";
                else if( value==IssueType.BusinessRule )
                    return "business-rule";
                else if( value==IssueType.Conflict )
                    return "conflict";
                else if( value==IssueType.Transient )
                    return "transient";
                else if( value==IssueType.LockError )
                    return "lock-error";
                else if( value==IssueType.NoStore )
                    return "no-store";
                else if( value==IssueType.Exception )
                    return "exception";
                else if( value==IssueType.Timeout )
                    return "timeout";
                else if( value==IssueType.Throttled )
                    return "throttled";
                else
                    throw new ArgumentException("Unrecognized IssueType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// How the issue affects the success of the action
        /// </summary>
        public enum IssueSeverity
        {
            Fatal, // The issue caused the action to fail, and no further checking could be performed.
            Error, // The issue is sufficiently important to cause the action to fail.
            Warning, // The issue is not important enough to cause the action to fail, but may cause it to be performed suboptimally or in a way that is not as desired.
            Information, // The issue has no relation to the degree of success of the action.
        }
        
        /// <summary>
        /// Conversion of IssueSeverityfrom and into string
        /// <summary>
        public static class IssueSeverityHandling
        {
            public static bool TryParse(string value, out IssueSeverity result)
            {
                result = default(IssueSeverity);
                
                if( value=="fatal")
                    result = IssueSeverity.Fatal;
                else if( value=="error")
                    result = IssueSeverity.Error;
                else if( value=="warning")
                    result = IssueSeverity.Warning;
                else if( value=="information")
                    result = IssueSeverity.Information;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(IssueSeverity value)
            {
                if( value==IssueSeverity.Fatal )
                    return "fatal";
                else if( value==IssueSeverity.Error )
                    return "error";
                else if( value==IssueSeverity.Warning )
                    return "warning";
                else if( value==IssueSeverity.Information )
                    return "information";
                else
                    throw new ArgumentException("Unrecognized IssueSeverity value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("OperationOutcomeIssueComponent")]
        [Serializable]
        public partial class OperationOutcomeIssueComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// error | warning | information
            /// </summary>
            public Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity> SeverityElement { get; set; }
            
            public Hl7.Fhir.Model.OperationOutcome.IssueSeverity? Severity
            {
                get { return SeverityElement != null ? SeverityElement.Value : null; }
                set
                {
                    if(value == null)
                      SeverityElement = null; 
                    else
                      SeverityElement = new Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity>(value);
                }
            }
            
            /// <summary>
            /// Error or warning code
            /// </summary>
            public Hl7.Fhir.Model.Coding Type { get; set; }
            
            /// <summary>
            /// Additional description of the issue
            /// </summary>
            public Hl7.Fhir.Model.FhirString DetailsElement { get; set; }
            
            public string Details
            {
                get { return DetailsElement != null ? DetailsElement.Value : null; }
                set
                {
                    if(value == null)
                      DetailsElement = null; 
                    else
                      DetailsElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// XPath of element(s) related to issue
            /// </summary>
            public List<Hl7.Fhir.Model.FhirString> LocationElement { get; set; }
            
            public IEnumerable<string> Location
            {
                get { return LocationElement != null ? LocationElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      LocationElement = null; 
                    else
                      LocationElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(SeverityElement != null )
                    result.AddRange(SeverityElement.Validate());
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(DetailsElement != null )
                    result.AddRange(DetailsElement.Validate());
                if(LocationElement != null )
                    LocationElement.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// A single issue associated with the action
        /// </summary>
        public List<Hl7.Fhir.Model.OperationOutcome.OperationOutcomeIssueComponent> Issue { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Issue != null )
                Issue.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
