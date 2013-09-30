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
    /// Event record kept for security purposes
    /// </summary>
    [FhirResource("SecurityEvent")]
    [Serializable]
    public partial class SecurityEvent : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Indicator for type of action performed during the event that generated the audit.
        /// </summary>
        public enum SecurityEventAction
        {
            C, // Create a new database object, such as Placing an Order.
            R, // Display or print data, such as a Doctor Census.
            U, // Update data, such as Revise Patient Information.
            D, // Delete items, such as a doctor master file record.
            E, // Perform a system or application function such as log-on, program execution or use of an object's method, or perform a query/search operation.
        }
        
        /// <summary>
        /// Conversion of SecurityEventActionfrom and into string
        /// <summary>
        public static class SecurityEventActionHandling
        {
            public static bool TryParse(string value, out SecurityEventAction result)
            {
                result = default(SecurityEventAction);
                
                if( value=="C")
                    result = SecurityEventAction.C;
                else if( value=="R")
                    result = SecurityEventAction.R;
                else if( value=="U")
                    result = SecurityEventAction.U;
                else if( value=="D")
                    result = SecurityEventAction.D;
                else if( value=="E")
                    result = SecurityEventAction.E;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventAction value)
            {
                if( value==SecurityEventAction.C )
                    return "C";
                else if( value==SecurityEventAction.R )
                    return "R";
                else if( value==SecurityEventAction.U )
                    return "U";
                else if( value==SecurityEventAction.D )
                    return "D";
                else if( value==SecurityEventAction.E )
                    return "E";
                else
                    throw new ArgumentException("Unrecognized SecurityEventAction value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The type of network access point that originated the audit event
        /// </summary>
        public enum SecurityEventParticipantNetworkType
        {
            Name, // Machine Name, including DNS name.
            Ip, // IP Address.
            Phone, // Telephone Number.
            Email, // Email address.
            Uri, // URI (User directory, HTTP-PUT, ftp, etc.).
        }
        
        /// <summary>
        /// Conversion of SecurityEventParticipantNetworkTypefrom and into string
        /// <summary>
        public static class SecurityEventParticipantNetworkTypeHandling
        {
            public static bool TryParse(string value, out SecurityEventParticipantNetworkType result)
            {
                result = default(SecurityEventParticipantNetworkType);
                
                if( value=="name")
                    result = SecurityEventParticipantNetworkType.Name;
                else if( value=="ip")
                    result = SecurityEventParticipantNetworkType.Ip;
                else if( value=="phone")
                    result = SecurityEventParticipantNetworkType.Phone;
                else if( value=="email")
                    result = SecurityEventParticipantNetworkType.Email;
                else if( value=="uri")
                    result = SecurityEventParticipantNetworkType.Uri;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventParticipantNetworkType value)
            {
                if( value==SecurityEventParticipantNetworkType.Name )
                    return "name";
                else if( value==SecurityEventParticipantNetworkType.Ip )
                    return "ip";
                else if( value==SecurityEventParticipantNetworkType.Phone )
                    return "phone";
                else if( value==SecurityEventParticipantNetworkType.Email )
                    return "email";
                else if( value==SecurityEventParticipantNetworkType.Uri )
                    return "uri";
                else
                    throw new ArgumentException("Unrecognized SecurityEventParticipantNetworkType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Code representing the functional application role of Participant Object being audited
        /// </summary>
        public enum SecurityEventObjectRole
        {
            N1, // This object is the patient that is the subject of care related to this event.  It is identifiable by patient ID or equivalent.  The patient may be either human or animal.
            N2, // This is a location identified as related to the event.  This is usually the location where the event took place.  Note that for shipping, the usual events are arrival at a location or departure from a location.
            N3, // This object is any kind of persistent document created as a result of the event.  This could be a paper report, film, electronic report, DICOM Study, etc.  Issues related to medical records life cycle management are conveyed elsewhere.
            N4, // A logical object related to the event.  (Deprecated).
            N5, // This is any configurable file used to control creation of documents.  Examples include the objects maintained by the HL7 Master File transactions, Value Sets, etc.
            N6, // A human participant not otherwise identified by some other category.
            N7, // (deprecated).
            N8, // Typically a licensed person who is providing or performing care related to the event, generally a physician.   The key distinction between doctor and practitioner is with regards to their role, not the licensing.  The doctor is the human who actually performed the work.  The practitioner is the human or organization that is responsible for the work.
            N9, // A person or system that is being notified as part of the event.  This is relevant in situations where automated systems provide notifications to other parties when an event took place.
            N10, // Insurance company, or any other organization who accepts responsibility for paying for the healthcare event.
            N11, // A person or active system object involved in the event with a security role.
            N12, // A person or system object involved in the event with the authority to modify security roles of other objects.
            N13, // A passive object, such as a role table, that is relevant to the event.
            N14, // (deprecated)  Relevant to certain RBAC security methodologies.
            N15, // Any person or organization responsible for providing care.  This encompasses all forms of care, licensed or otherwise, and all sorts of teams and care groups. Note, the distinction between practitioners and the doctor that actually provided the care to the patient.
            N16, // The source or destination for data transfer, when it does not match some other role.
            N17, // A source or destination for data transfer, that acts as an archive, database, or similar role.
            N18, // An object that holds schedule information.  This could be an appointment book, availability information, etc.
            N19, // An organization or person that is the recipient of services.  This could be an organization that is buying services for a patient, or a person that is buying services for an animal.
            N20, // An order, task, work item, procedure step, or other description of work to be performed.  E.g., a particular instance of an MPPS.
            N21, // A list of jobs or a system that provides lists of jobs.  E.g., an MWL SCP.
            N22, // (Deprecated).
            N23, // An object that specifies or controls the routing or delivery of items.  For example, a distribution list is the routing criteria for mail.  The items delivered may be documents, jobs, or other objects.
            N24, // The contents of a query.  This is used to capture the contents of any kind of query.  For security surveillance purposes knowing the queries being made is very important.
        }
        
        /// <summary>
        /// Conversion of SecurityEventObjectRolefrom and into string
        /// <summary>
        public static class SecurityEventObjectRoleHandling
        {
            public static bool TryParse(string value, out SecurityEventObjectRole result)
            {
                result = default(SecurityEventObjectRole);
                
                if( value=="1")
                    result = SecurityEventObjectRole.N1;
                else if( value=="2")
                    result = SecurityEventObjectRole.N2;
                else if( value=="3")
                    result = SecurityEventObjectRole.N3;
                else if( value=="4")
                    result = SecurityEventObjectRole.N4;
                else if( value=="5")
                    result = SecurityEventObjectRole.N5;
                else if( value=="6")
                    result = SecurityEventObjectRole.N6;
                else if( value=="7")
                    result = SecurityEventObjectRole.N7;
                else if( value=="8")
                    result = SecurityEventObjectRole.N8;
                else if( value=="9")
                    result = SecurityEventObjectRole.N9;
                else if( value=="10")
                    result = SecurityEventObjectRole.N10;
                else if( value=="11")
                    result = SecurityEventObjectRole.N11;
                else if( value=="12")
                    result = SecurityEventObjectRole.N12;
                else if( value=="13")
                    result = SecurityEventObjectRole.N13;
                else if( value=="14")
                    result = SecurityEventObjectRole.N14;
                else if( value=="15")
                    result = SecurityEventObjectRole.N15;
                else if( value=="16")
                    result = SecurityEventObjectRole.N16;
                else if( value=="17")
                    result = SecurityEventObjectRole.N17;
                else if( value=="18")
                    result = SecurityEventObjectRole.N18;
                else if( value=="19")
                    result = SecurityEventObjectRole.N19;
                else if( value=="20")
                    result = SecurityEventObjectRole.N20;
                else if( value=="21")
                    result = SecurityEventObjectRole.N21;
                else if( value=="22")
                    result = SecurityEventObjectRole.N22;
                else if( value=="23")
                    result = SecurityEventObjectRole.N23;
                else if( value=="24")
                    result = SecurityEventObjectRole.N24;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventObjectRole value)
            {
                if( value==SecurityEventObjectRole.N1 )
                    return "1";
                else if( value==SecurityEventObjectRole.N2 )
                    return "2";
                else if( value==SecurityEventObjectRole.N3 )
                    return "3";
                else if( value==SecurityEventObjectRole.N4 )
                    return "4";
                else if( value==SecurityEventObjectRole.N5 )
                    return "5";
                else if( value==SecurityEventObjectRole.N6 )
                    return "6";
                else if( value==SecurityEventObjectRole.N7 )
                    return "7";
                else if( value==SecurityEventObjectRole.N8 )
                    return "8";
                else if( value==SecurityEventObjectRole.N9 )
                    return "9";
                else if( value==SecurityEventObjectRole.N10 )
                    return "10";
                else if( value==SecurityEventObjectRole.N11 )
                    return "11";
                else if( value==SecurityEventObjectRole.N12 )
                    return "12";
                else if( value==SecurityEventObjectRole.N13 )
                    return "13";
                else if( value==SecurityEventObjectRole.N14 )
                    return "14";
                else if( value==SecurityEventObjectRole.N15 )
                    return "15";
                else if( value==SecurityEventObjectRole.N16 )
                    return "16";
                else if( value==SecurityEventObjectRole.N17 )
                    return "17";
                else if( value==SecurityEventObjectRole.N18 )
                    return "18";
                else if( value==SecurityEventObjectRole.N19 )
                    return "19";
                else if( value==SecurityEventObjectRole.N20 )
                    return "20";
                else if( value==SecurityEventObjectRole.N21 )
                    return "21";
                else if( value==SecurityEventObjectRole.N22 )
                    return "22";
                else if( value==SecurityEventObjectRole.N23 )
                    return "23";
                else if( value==SecurityEventObjectRole.N24 )
                    return "24";
                else
                    throw new ArgumentException("Unrecognized SecurityEventObjectRole value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Code for the participant object type being audited
        /// </summary>
        public enum SecurityEventObjectType
        {
            N1, // Person.
            N2, // System Object.
            N3, // Organization.
            N4, // Other.
        }
        
        /// <summary>
        /// Conversion of SecurityEventObjectTypefrom and into string
        /// <summary>
        public static class SecurityEventObjectTypeHandling
        {
            public static bool TryParse(string value, out SecurityEventObjectType result)
            {
                result = default(SecurityEventObjectType);
                
                if( value=="1")
                    result = SecurityEventObjectType.N1;
                else if( value=="2")
                    result = SecurityEventObjectType.N2;
                else if( value=="3")
                    result = SecurityEventObjectType.N3;
                else if( value=="4")
                    result = SecurityEventObjectType.N4;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventObjectType value)
            {
                if( value==SecurityEventObjectType.N1 )
                    return "1";
                else if( value==SecurityEventObjectType.N2 )
                    return "2";
                else if( value==SecurityEventObjectType.N3 )
                    return "3";
                else if( value==SecurityEventObjectType.N4 )
                    return "4";
                else
                    throw new ArgumentException("Unrecognized SecurityEventObjectType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Identifier for the data life-cycle stage for the participant object
        /// </summary>
        public enum SecurityEventObjectLifecycle
        {
            N1, // Origination / Creation.
            N2, // Import / Copy from original.
            N3, // Amendment.
            N4, // Verification.
            N5, // Translation.
            N6, // Access / Use.
            N7, // De-identification.
            N8, // Aggregation, summarization, derivation.
            N9, // Report.
            N10, // Export / Copy to target.
            N11, // Disclosure.
            N12, // Receipt of disclosure.
            N13, // Archiving.
            N14, // Logical deletion.
            N15, // Permanent erasure / Physical destruction.
        }
        
        /// <summary>
        /// Conversion of SecurityEventObjectLifecyclefrom and into string
        /// <summary>
        public static class SecurityEventObjectLifecycleHandling
        {
            public static bool TryParse(string value, out SecurityEventObjectLifecycle result)
            {
                result = default(SecurityEventObjectLifecycle);
                
                if( value=="1")
                    result = SecurityEventObjectLifecycle.N1;
                else if( value=="2")
                    result = SecurityEventObjectLifecycle.N2;
                else if( value=="3")
                    result = SecurityEventObjectLifecycle.N3;
                else if( value=="4")
                    result = SecurityEventObjectLifecycle.N4;
                else if( value=="5")
                    result = SecurityEventObjectLifecycle.N5;
                else if( value=="6")
                    result = SecurityEventObjectLifecycle.N6;
                else if( value=="7")
                    result = SecurityEventObjectLifecycle.N7;
                else if( value=="8")
                    result = SecurityEventObjectLifecycle.N8;
                else if( value=="9")
                    result = SecurityEventObjectLifecycle.N9;
                else if( value=="10")
                    result = SecurityEventObjectLifecycle.N10;
                else if( value=="11")
                    result = SecurityEventObjectLifecycle.N11;
                else if( value=="12")
                    result = SecurityEventObjectLifecycle.N12;
                else if( value=="13")
                    result = SecurityEventObjectLifecycle.N13;
                else if( value=="14")
                    result = SecurityEventObjectLifecycle.N14;
                else if( value=="15")
                    result = SecurityEventObjectLifecycle.N15;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventObjectLifecycle value)
            {
                if( value==SecurityEventObjectLifecycle.N1 )
                    return "1";
                else if( value==SecurityEventObjectLifecycle.N2 )
                    return "2";
                else if( value==SecurityEventObjectLifecycle.N3 )
                    return "3";
                else if( value==SecurityEventObjectLifecycle.N4 )
                    return "4";
                else if( value==SecurityEventObjectLifecycle.N5 )
                    return "5";
                else if( value==SecurityEventObjectLifecycle.N6 )
                    return "6";
                else if( value==SecurityEventObjectLifecycle.N7 )
                    return "7";
                else if( value==SecurityEventObjectLifecycle.N8 )
                    return "8";
                else if( value==SecurityEventObjectLifecycle.N9 )
                    return "9";
                else if( value==SecurityEventObjectLifecycle.N10 )
                    return "10";
                else if( value==SecurityEventObjectLifecycle.N11 )
                    return "11";
                else if( value==SecurityEventObjectLifecycle.N12 )
                    return "12";
                else if( value==SecurityEventObjectLifecycle.N13 )
                    return "13";
                else if( value==SecurityEventObjectLifecycle.N14 )
                    return "14";
                else if( value==SecurityEventObjectLifecycle.N15 )
                    return "15";
                else
                    throw new ArgumentException("Unrecognized SecurityEventObjectLifecycle value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Indicates whether the event succeeded or failed
        /// </summary>
        public enum SecurityEventOutcome
        {
            N0, // The operation completed successfully (whether with warnings or not).
            N4, // The action was not successful due to some kind of catered for error (often equivalent to an HTTP 400 response).
            N8, // The action was not successful due to some kind of unexpected error (often equivalent to an HTTP 500 response).
            N12, // An error of such magnitude occurred that the system is not longer available for use (i.e. the system died).
        }
        
        /// <summary>
        /// Conversion of SecurityEventOutcomefrom and into string
        /// <summary>
        public static class SecurityEventOutcomeHandling
        {
            public static bool TryParse(string value, out SecurityEventOutcome result)
            {
                result = default(SecurityEventOutcome);
                
                if( value=="0")
                    result = SecurityEventOutcome.N0;
                else if( value=="4")
                    result = SecurityEventOutcome.N4;
                else if( value=="8")
                    result = SecurityEventOutcome.N8;
                else if( value=="12")
                    result = SecurityEventOutcome.N12;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventOutcome value)
            {
                if( value==SecurityEventOutcome.N0 )
                    return "0";
                else if( value==SecurityEventOutcome.N4 )
                    return "4";
                else if( value==SecurityEventOutcome.N8 )
                    return "8";
                else if( value==SecurityEventOutcome.N12 )
                    return "12";
                else
                    throw new ArgumentException("Unrecognized SecurityEventOutcome value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventObjectDetailComponent")]
        [Serializable]
        public partial class SecurityEventObjectDetailComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Name of the property
            /// </summary>
            public Hl7.Fhir.Model.FhirString TypeElement { get; set; }
            
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Property value
            /// </summary>
            public Hl7.Fhir.Model.Base64Binary ValueElement { get; set; }
            
            public byte[] Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if(value == null)
                      ValueElement = null; 
                    else
                      ValueElement = new Hl7.Fhir.Model.Base64Binary(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                if(ValueElement != null )
                    result.AddRange(ValueElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventObjectComponent")]
        [Serializable]
        public partial class SecurityEventObjectComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Specific instance of object (e.g. versioned)
            /// </summary>
            public Hl7.Fhir.Model.Identifier Identifier { get; set; }
            
            /// <summary>
            /// Specific instance of resource (e.g. versioned)
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Reference { get; set; }
            
            /// <summary>
            /// Object type being audited
            /// </summary>
            public Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectType> TypeElement { get; set; }
            
            public Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectType>(value);
                }
            }
            
            /// <summary>
            /// Functional application role of Object
            /// </summary>
            public Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRole> RoleElement { get; set; }
            
            public Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRole? Role
            {
                get { return RoleElement != null ? RoleElement.Value : null; }
                set
                {
                    if(value == null)
                      RoleElement = null; 
                    else
                      RoleElement = new Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRole>(value);
                }
            }
            
            /// <summary>
            /// Life-cycle stage for the object
            /// </summary>
            public Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycle> LifecycleElement { get; set; }
            
            public Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycle? Lifecycle
            {
                get { return LifecycleElement != null ? LifecycleElement.Value : null; }
                set
                {
                    if(value == null)
                      LifecycleElement = null; 
                    else
                      LifecycleElement = new Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycle>(value);
                }
            }
            
            /// <summary>
            /// Policy-defined sensitivity for the object
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Sensitivity { get; set; }
            
            /// <summary>
            /// Instance-specific descriptor for Object
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
            /// Actual query for object
            /// </summary>
            public Hl7.Fhir.Model.Base64Binary QueryElement { get; set; }
            
            public byte[] Query
            {
                get { return QueryElement != null ? QueryElement.Value : null; }
                set
                {
                    if(value == null)
                      QueryElement = null; 
                    else
                      QueryElement = new Hl7.Fhir.Model.Base64Binary(value);
                }
            }
            
            /// <summary>
            /// Additional Information about the Object
            /// </summary>
            public List<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectDetailComponent> Detail { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Identifier != null )
                    result.AddRange(Identifier.Validate());
                if(Reference != null )
                    result.AddRange(Reference.Validate());
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                if(RoleElement != null )
                    result.AddRange(RoleElement.Validate());
                if(LifecycleElement != null )
                    result.AddRange(LifecycleElement.Validate());
                if(Sensitivity != null )
                    result.AddRange(Sensitivity.Validate());
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(QueryElement != null )
                    result.AddRange(QueryElement.Validate());
                if(Detail != null )
                    Detail.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventSourceComponent")]
        [Serializable]
        public partial class SecurityEventSourceComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Logical source location within the enterprise
            /// </summary>
            public Hl7.Fhir.Model.FhirString SiteElement { get; set; }
            
            public string Site
            {
                get { return SiteElement != null ? SiteElement.Value : null; }
                set
                {
                    if(value == null)
                      SiteElement = null; 
                    else
                      SiteElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// The id of source where event originated
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
            /// The type of source where event originated
            /// </summary>
            public List<Hl7.Fhir.Model.Coding> Type { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(SiteElement != null )
                    result.AddRange(SiteElement.Validate());
                if(IdentifierElement != null )
                    result.AddRange(IdentifierElement.Validate());
                if(Type != null )
                    Type.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventEventComponent")]
        [Serializable]
        public partial class SecurityEventEventComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Type of event
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Sub-type of event
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Subtype { get; set; }
            
            /// <summary>
            /// Type of action performed during the event
            /// </summary>
            public Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventAction> ActionElement { get; set; }
            
            public Hl7.Fhir.Model.SecurityEvent.SecurityEventAction? Action
            {
                get { return ActionElement != null ? ActionElement.Value : null; }
                set
                {
                    if(value == null)
                      ActionElement = null; 
                    else
                      ActionElement = new Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventAction>(value);
                }
            }
            
            /// <summary>
            /// Time when the event occurred on source
            /// </summary>
            public Hl7.Fhir.Model.Instant DateTimeElement { get; set; }
            
            public DateTimeOffset? DateTime
            {
                get { return DateTimeElement != null ? DateTimeElement.Value : null; }
                set
                {
                    if(value == null)
                      DateTimeElement = null; 
                    else
                      DateTimeElement = new Hl7.Fhir.Model.Instant(value);
                }
            }
            
            /// <summary>
            /// Whether the event succeeded or failed
            /// </summary>
            public Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcome> OutcomeElement { get; set; }
            
            public Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcome? Outcome
            {
                get { return OutcomeElement != null ? OutcomeElement.Value : null; }
                set
                {
                    if(value == null)
                      OutcomeElement = null; 
                    else
                      OutcomeElement = new Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcome>(value);
                }
            }
            
            /// <summary>
            /// Description of the event outcome
            /// </summary>
            public Hl7.Fhir.Model.FhirString OutcomeDescElement { get; set; }
            
            public string OutcomeDesc
            {
                get { return OutcomeDescElement != null ? OutcomeDescElement.Value : null; }
                set
                {
                    if(value == null)
                      OutcomeDescElement = null; 
                    else
                      OutcomeDescElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(Subtype != null )
                    Subtype.ForEach(elem => result.AddRange(elem.Validate()));
                if(ActionElement != null )
                    result.AddRange(ActionElement.Validate());
                if(DateTimeElement != null )
                    result.AddRange(DateTimeElement.Validate());
                if(OutcomeElement != null )
                    result.AddRange(OutcomeElement.Validate());
                if(OutcomeDescElement != null )
                    result.AddRange(OutcomeDescElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventParticipantNetworkComponent")]
        [Serializable]
        public partial class SecurityEventParticipantNetworkComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Identifier for the network access point of the user device
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
            /// The type of network access point
            /// </summary>
            public Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkType> TypeElement { get; set; }
            
            public Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Code<Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkType>(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(IdentifierElement != null )
                    result.AddRange(IdentifierElement.Validate());
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventParticipantComponent")]
        [Serializable]
        public partial class SecurityEventParticipantComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// User roles (e.g. local RBAC codes)
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Role { get; set; }
            
            /// <summary>
            /// Direct reference to resource
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Reference { get; set; }
            
            /// <summary>
            /// Unique identifier for the user
            /// </summary>
            public Hl7.Fhir.Model.FhirString UserIdElement { get; set; }
            
            public string UserId
            {
                get { return UserIdElement != null ? UserIdElement.Value : null; }
                set
                {
                    if(value == null)
                      UserIdElement = null; 
                    else
                      UserIdElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// User id used by authentication system
            /// </summary>
            public Hl7.Fhir.Model.FhirString AuthIdElement { get; set; }
            
            public string AuthId
            {
                get { return AuthIdElement != null ? AuthIdElement.Value : null; }
                set
                {
                    if(value == null)
                      AuthIdElement = null; 
                    else
                      AuthIdElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Human-meaningful name for the user
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
            /// Whether user is initiator
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean RequestorElement { get; set; }
            
            public bool? Requestor
            {
                get { return RequestorElement != null ? RequestorElement.Value : null; }
                set
                {
                    if(value == null)
                      RequestorElement = null; 
                    else
                      RequestorElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// Type of media
            /// </summary>
            public Hl7.Fhir.Model.Coding Media { get; set; }
            
            /// <summary>
            /// Logical network location for application activity
            /// </summary>
            public Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkComponent Network { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Role != null )
                    Role.ForEach(elem => result.AddRange(elem.Validate()));
                if(Reference != null )
                    result.AddRange(Reference.Validate());
                if(UserIdElement != null )
                    result.AddRange(UserIdElement.Validate());
                if(AuthIdElement != null )
                    result.AddRange(AuthIdElement.Validate());
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(RequestorElement != null )
                    result.AddRange(RequestorElement.Validate());
                if(Media != null )
                    result.AddRange(Media.Validate());
                if(Network != null )
                    result.AddRange(Network.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// What was done
        /// </summary>
        public Hl7.Fhir.Model.SecurityEvent.SecurityEventEventComponent Event { get; set; }
        
        /// <summary>
        /// A person, a hardware device or software process
        /// </summary>
        public List<Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantComponent> Participant { get; set; }
        
        /// <summary>
        /// Application systems and processes
        /// </summary>
        public Hl7.Fhir.Model.SecurityEvent.SecurityEventSourceComponent Source { get; set; }
        
        /// <summary>
        /// Specific instances of data or objects that have been accessed
        /// </summary>
        public List<Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectComponent> Object { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Event != null )
                result.AddRange(Event.Validate());
            if(Participant != null )
                Participant.ForEach(elem => result.AddRange(elem.Validate()));
            if(Source != null )
                result.AddRange(Source.Validate());
            if(Object != null )
                Object.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
