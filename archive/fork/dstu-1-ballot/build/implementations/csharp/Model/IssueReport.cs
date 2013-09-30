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
// Generated on Thu, May 9, 2013 10:28+1000 for FHIR v0.09
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Information about the success/failure of an action
    /// </summary>
    [FhirResource("IssueReport")]
    public partial class IssueReport : Resource
    {
        /// <summary>
        /// How the issue affects the success of the action
        /// </summary>
        public enum IssueSeverity
        {
            Error, // The issue is sufficiently important to cause the action to fail
            Warning, // The issue is not important enough to cause the action to fail, but may cause it to be performed suboptimally or in a way that is not as desired
            Information, // The issue has no relation to the degree of success of the action
        }
        
        /// <summary>
        /// Conversion of IssueSeverityfrom and into string
        /// <summary>
        public static class IssueSeverityHandling
        {
            public static bool TryParse(string value, out IssueSeverity result)
            {
                result = default(IssueSeverity);
                
                if( value=="error")
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
                if( value==IssueSeverity.Error )
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
        [FhirComposite("IssueReportIssueComponent")]
        public partial class IssueReportIssueComponent : Element
        {
            /// <summary>
            /// error | warning | information
            /// </summary>
            public Code<IssueReport.IssueSeverity> Severity { get; set; }
            
            /// <summary>
            /// Error or warning code
            /// </summary>
            public CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Additional description of the issue
            /// </summary>
            public FhirString Details { get; set; }
            
            /// <summary>
            /// XPath of element(s) related to issue
            /// </summary>
            public List<FhirString> Location { get; set; }
            
        }
        
        
        /// <summary>
        /// A single issue associated with the action
        /// </summary>
        public List<IssueReportIssueComponent> Issue { get; set; }
        
    }
    
}
