using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

/*
  Copyright (c) 2011-2012, HL7, Inc.
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
// Generated on Wed, Apr 3, 2013 07:11+1100 for FHIR v0.07
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// An Entry in an XDS Registry
    /// </summary>
    [FhirResource("XdsEntry")]
    public partial class XdsEntry : Resource
    {
        /// <summary>
        /// The availability status of document
        /// </summary>
        public enum XdsEntryAvailability
        {
            Approved,
            Deprecated,
        }
        
        /// <summary>
        /// Conversion of XdsEntryAvailabilityfrom and into string
        /// <summary>
        public static class XdsEntryAvailabilityHandling
        {
            public static bool TryParse(string value, out XdsEntryAvailability result)
            {
                result = default(XdsEntryAvailability);
                
                if( value=="Approved")
                    result = XdsEntryAvailability.Approved;
                else if( value=="Deprecated")
                    result = XdsEntryAvailability.Deprecated;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(XdsEntryAvailability value)
            {
                if( value==XdsEntryAvailability.Approved )
                    return "Approved";
                else if( value==XdsEntryAvailability.Deprecated )
                    return "Deprecated";
                else
                    throw new ArgumentException("Unrecognized XdsEntryAvailability value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("XdsEntryServiceComponent")]
        public partial class XdsEntryServiceComponent : Element
        {
            /// <summary>
            /// Start time
            /// </summary>
            public FhirDateTime Start { get; set; }
            
            /// <summary>
            /// Stop time
            /// </summary>
            public FhirDateTime Stop { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("XdsEntryAuthorComponent")]
        public partial class XdsEntryAuthorComponent : Element
        {
            /// <summary>
            /// Name of human/machine
            /// </summary>
            public HumanName Name { get; set; }
            
            /// <summary>
            /// Id of human/machine
            /// </summary>
            public Identifier Id { get; set; }
            
            /// <summary>
            /// Role of author wrt to the patient
            /// </summary>
            public List<FhirString> Role { get; set; }
            
            /// <summary>
            /// Speciality of facility per affinity domain
            /// </summary>
            public List<FhirString> Specialty { get; set; }
            
            /// <summary>
            /// Facilty under which document authored
            /// </summary>
            public List<XdsEntryAuthorInstitutionComponent> Institution { get; set; }
            
            /// <summary>
            /// Contact details for author
            /// </summary>
            public List<Contact> Contact { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("XdsEntryAuthorInstitutionComponent")]
        public partial class XdsEntryAuthorInstitutionComponent : Element
        {
            /// <summary>
            /// Id of facility
            /// </summary>
            public Identifier Id { get; set; }
            
            /// <summary>
            /// Name of facility
            /// </summary>
            public FhirString Name { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("XdsEntryAuthenticatorComponent")]
        public partial class XdsEntryAuthenticatorComponent : Element
        {
            /// <summary>
            /// Id of authenticator
            /// </summary>
            public Identifier Id { get; set; }
            
            /// <summary>
            /// Name of authenticator
            /// </summary>
            public HumanName Name { get; set; }
            
        }
        
        
        /// <summary>
        /// Direct URL to retrieve the actual document
        /// </summary>
        public FhirUri Url { get; set; }
        
        /// <summary>
        /// Repository - logical or literal url
        /// </summary>
        public FhirUri RepositoryId { get; set; }
        
        /// <summary>
        /// Mime type of document
        /// </summary>
        public FhirString MimeType { get; set; }
        
        /// <summary>
        /// Format (urn:.. Following rules)
        /// </summary>
        public Coding Format { get; set; }
        
        /// <summary>
        /// Particular kind of document
        /// </summary>
        public Coding Class { get; set; }
        
        /// <summary>
        /// Precise kind of document
        /// </summary>
        public Coding Type { get; set; }
        
        /// <summary>
        /// Title of the document
        /// </summary>
        public FhirString Title { get; set; }
        
        /// <summary>
        /// Document id - logical or literal url
        /// </summary>
        public FhirUri DocumentId { get; set; }
        
        /// <summary>
        /// Approved | Deprecated
        /// </summary>
        public Code<XdsEntry.XdsEntryAvailability> Availability { get; set; }
        
        /// <summary>
        /// As defined by Affinty Domain
        /// </summary>
        public Coding ConfidentialityCode { get; set; }
        
        /// <summary>
        /// Time author created document
        /// </summary>
        public Instant Created { get; set; }
        
        /// <summary>
        /// Main clinical act(s)
        /// </summary>
        public List<Coding> Event { get; set; }
        
        /// <summary>
        /// HexBinary representation of SHA1
        /// </summary>
        public FhirString Hash { get; set; }
        
        /// <summary>
        /// Size in bytes
        /// </summary>
        public FhirString Size { get; set; }
        
        /// <summary>
        /// Human language (RFC 3066)
        /// </summary>
        public FhirString Lang { get; set; }
        
        /// <summary>
        /// Folders this document is in
        /// </summary>
        public List<ResourceReference> Folder { get; set; }
        
        /// <summary>
        /// Subject of care of the document
        /// </summary>
        public Identifier PatientId { get; set; }
        
        /// <summary>
        /// Subject of care in the document
        /// </summary>
        public Identifier SourcePatientId { get; set; }
        
        /// <summary>
        /// Demographic details
        /// </summary>
        public ResourceReference PatientInfo { get; set; }
        
        /// <summary>
        /// Human/machine that authored document
        /// </summary>
        public List<XdsEntryAuthorComponent> Author { get; set; }
        
        /// <summary>
        /// Legal authenticator/attestor
        /// </summary>
        public XdsEntryAuthenticatorComponent Authenticator { get; set; }
        
        /// <summary>
        /// Type of organizational setting
        /// </summary>
        public Coding FacilityType { get; set; }
        
        /// <summary>
        /// Clinical speciality of the act
        /// </summary>
        public Coding PracticeSetting { get; set; }
        
        /// <summary>
        /// Globally unique community id
        /// </summary>
        public FhirUri HomeCommunity { get; set; }
        
        /// <summary>
        /// When service being document happened
        /// </summary>
        public XdsEntryServiceComponent Service { get; set; }
        
        /// <summary>
        /// Comments as specified by affinity domain
        /// </summary>
        public FhirString Comments { get; set; }
        
    }
    
}
