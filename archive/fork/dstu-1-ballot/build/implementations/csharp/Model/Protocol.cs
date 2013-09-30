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
// Generated on Wed, Jun 19, 2013 01:55+1000 for FHIR v0.09
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A definition of behaviors to be taken in particular circumstnaces, often including conditions, options and other decision points
    /// </summary>
    [FhirResource("Protocol")]
    public partial class Protocol : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// High-level categorization of the protocol
        /// </summary>
        public enum ProtocolType
        {
            Condition, // The protocol describes the steps to manage a particular health condition including monitoring, treatment, mitigation and/or follow-up
            Device, // The protocol describes the appropriate use of a particular device (medical device, software, etc.)
            Drug, // The protocol describes the appropriate use of a particular medication including indications for use, dosages, treatment cycles, etc.
            Study, // The protocol describes the set of steps to occur for study subjects enrolled in an interventional study
        }
        
        /// <summary>
        /// Conversion of ProtocolTypefrom and into string
        /// <summary>
        public static class ProtocolTypeHandling
        {
            public static bool TryParse(string value, out ProtocolType result)
            {
                result = default(ProtocolType);
                
                if( value=="condition")
                    result = ProtocolType.Condition;
                else if( value=="device")
                    result = ProtocolType.Device;
                else if( value=="drug")
                    result = ProtocolType.Drug;
                else if( value=="study")
                    result = ProtocolType.Study;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ProtocolType value)
            {
                if( value==ProtocolType.Condition )
                    return "condition";
                else if( value==ProtocolType.Device )
                    return "device";
                else if( value==ProtocolType.Drug )
                    return "drug";
                else if( value==ProtocolType.Study )
                    return "study";
                else
                    throw new ArgumentException("Unrecognized ProtocolType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The lifecycle status of a Protocol
        /// </summary>
        public enum ProtocolStatus
        {
            Draft, // This protocol is still under development
            Testing, // This protocol was authored for testing purposes (or education/evaluation/marketing)
            Review, // This protocol is undergoing review to check that it is ready for production use
            Production, // This protocol is ready for use in production systems
            Withdrawn, // This protocol has been withdrawn and should no longer be used
            Superseded, // This protocol has been replaced and a different protocol should be used in its place
        }
        
        /// <summary>
        /// Conversion of ProtocolStatusfrom and into string
        /// <summary>
        public static class ProtocolStatusHandling
        {
            public static bool TryParse(string value, out ProtocolStatus result)
            {
                result = default(ProtocolStatus);
                
                if( value=="draft")
                    result = ProtocolStatus.Draft;
                else if( value=="testing")
                    result = ProtocolStatus.Testing;
                else if( value=="review")
                    result = ProtocolStatus.Review;
                else if( value=="production")
                    result = ProtocolStatus.Production;
                else if( value=="withdrawn")
                    result = ProtocolStatus.Withdrawn;
                else if( value=="superseded")
                    result = ProtocolStatus.Superseded;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ProtocolStatus value)
            {
                if( value==ProtocolStatus.Draft )
                    return "draft";
                else if( value==ProtocolStatus.Testing )
                    return "testing";
                else if( value==ProtocolStatus.Review )
                    return "review";
                else if( value==ProtocolStatus.Production )
                    return "production";
                else if( value==ProtocolStatus.Withdrawn )
                    return "withdrawn";
                else if( value==ProtocolStatus.Superseded )
                    return "superseded";
                else
                    throw new ArgumentException("Unrecognized ProtocolStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProtocolStepPreconditionComponent")]
        public partial class ProtocolStepPreconditionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Description of condition
            /// </summary>
            public Hl7.Fhir.Model.FhirString Description { get; set; }
            
            /// <summary>
            /// Condition evaluated
            /// </summary>
            public Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionConditionComponent Condition { get; set; }
            
            /// <summary>
            /// And conditions
            /// </summary>
            public List<Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent> Intersection { get; set; }
            
            /// <summary>
            /// Or conditions
            /// </summary>
            public List<Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent> Union { get; set; }
            
            /// <summary>
            /// Not conditions
            /// </summary>
            public List<Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent> Exclude { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProtocolStepActivityComponentComponent")]
        public partial class ProtocolStepActivityComponentComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Order of occurrence
            /// </summary>
            public Hl7.Fhir.Model.Integer Sequence { get; set; }
            
            /// <summary>
            /// Component activity
            /// </summary>
            public Hl7.Fhir.Model.IdRef Activity { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProtocolStepPreconditionConditionComponent")]
        public partial class ProtocolStepPreconditionConditionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Observation / test / assertion
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Value needed to satisfy condition
            /// </summary>
            public Hl7.Fhir.Model.Element Value { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProtocolStepActivityComponent")]
        public partial class ProtocolStepActivityComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// What can be done instead?
            /// </summary>
            public List<Hl7.Fhir.Model.IdRef> Alternative { get; set; }
            
            /// <summary>
            /// Activities that are part of this activity
            /// </summary>
            public List<Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponentComponent> Component { get; set; }
            
            /// <summary>
            /// What happens next
            /// </summary>
            public List<Hl7.Fhir.Model.IdRef> Following { get; set; }
            
            /// <summary>
            /// Pause before start
            /// </summary>
            public Hl7.Fhir.Model.Duration Wait { get; set; }
            
            /// <summary>
            /// Details of activity
            /// </summary>
            public Hl7.Fhir.Model.ActivityDefinition Detail { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProtocolStepComponent")]
        public partial class ProtocolStepComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Label for step
            /// </summary>
            public Hl7.Fhir.Model.FhirString Name { get; set; }
            
            /// <summary>
            /// Human description of activity
            /// </summary>
            public Hl7.Fhir.Model.FhirString Description { get; set; }
            
            /// <summary>
            /// How long does step last?
            /// </summary>
            public Hl7.Fhir.Model.Duration Duration { get; set; }
            
            /// <summary>
            /// Rules prior to execution
            /// </summary>
            public Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent Precondition { get; set; }
            
            /// <summary>
            /// Rules prior to completion
            /// </summary>
            public Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent Exit { get; set; }
            
            /// <summary>
            /// First activity within timepoint
            /// </summary>
            public Hl7.Fhir.Model.IdRef FirstActivity { get; set; }
            
            /// <summary>
            /// Activities that occur within timepoint
            /// </summary>
            public List<Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponent> Activity { get; set; }
            
            /// <summary>
            /// What happens next?
            /// </summary>
            public List<Hl7.Fhir.Model.Protocol.ProtocolStepNextComponent> Next { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProtocolStepNextComponent")]
        public partial class ProtocolStepNextComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Description of what happens next
            /// </summary>
            public Hl7.Fhir.Model.FhirString Description { get; set; }
            
            /// <summary>
            /// Id of following step
            /// </summary>
            public Hl7.Fhir.Model.IdRef Id { get; set; }
            
            /// <summary>
            /// Condition in which next step is executed
            /// </summary>
            public Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent Condition { get; set; }
            
        }
        
        
        /// <summary>
        /// Name of protocol
        /// </summary>
        public Hl7.Fhir.Model.FhirString Title { get; set; }
        
        /// <summary>
        /// condition | device | drug | study
        /// </summary>
        public Code<Hl7.Fhir.Model.Protocol.ProtocolType> Type { get; set; }
        
        /// <summary>
        /// Current status
        /// </summary>
        public Code<Hl7.Fhir.Model.Protocol.ProtocolStatus> Status { get; set; }
        
        /// <summary>
        /// Who wrote protocol?
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Author { get; set; }
        
        /// <summary>
        /// When is protocol to be used?
        /// </summary>
        public Hl7.Fhir.Model.FhirString Purpose { get; set; }
        
        /// <summary>
        /// What does protocol deal with?
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// To whom does Protocol apply?
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Group { get; set; }
        
        /// <summary>
        /// What's done as part of protocol
        /// </summary>
        public List<Hl7.Fhir.Model.Protocol.ProtocolStepComponent> Step { get; set; }
        
    }
    
}
