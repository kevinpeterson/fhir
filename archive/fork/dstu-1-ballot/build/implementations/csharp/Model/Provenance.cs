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
    /// Who, What, When for a set of resources
    /// </summary>
    [FhirResource("Provenance")]
    [Serializable]
    public partial class Provenance : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// How an entity was used in an activity
        /// </summary>
        public enum ProvenanceEntityRole
        {
            Derivation, // A transformation of an entity into another, an update of an entity resulting in a new one, or the construction of a new entity based on a preexisting entity.
            Revision, // A derivation for which the resulting entity is a revised version of some original.
            Quotation, // The repeat of (some or all of) an entity, such as text or image, by someone who may or may not be its original author.
            Source, // A primary source for a topic refers to something produced by some agent with direct experience and knowledge about the topic, at the time of the topic's study, without benefit from hindsight.
        }
        
        /// <summary>
        /// Conversion of ProvenanceEntityRolefrom and into string
        /// <summary>
        public static class ProvenanceEntityRoleHandling
        {
            public static bool TryParse(string value, out ProvenanceEntityRole result)
            {
                result = default(ProvenanceEntityRole);
                
                if( value=="derivation")
                    result = ProvenanceEntityRole.Derivation;
                else if( value=="revision")
                    result = ProvenanceEntityRole.Revision;
                else if( value=="quotation")
                    result = ProvenanceEntityRole.Quotation;
                else if( value=="source")
                    result = ProvenanceEntityRole.Source;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ProvenanceEntityRole value)
            {
                if( value==ProvenanceEntityRole.Derivation )
                    return "derivation";
                else if( value==ProvenanceEntityRole.Revision )
                    return "revision";
                else if( value==ProvenanceEntityRole.Quotation )
                    return "quotation";
                else if( value==ProvenanceEntityRole.Source )
                    return "source";
                else
                    throw new ArgumentException("Unrecognized ProvenanceEntityRole value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProvenanceAgentComponent")]
        [Serializable]
        public partial class ProvenanceAgentComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// author | overseer | enterer | attester | source | cc: +
            /// </summary>
            public Hl7.Fhir.Model.Coding Role { get; set; }
            
            /// <summary>
            /// Resource | Person | Application | Record | Document +
            /// </summary>
            public Hl7.Fhir.Model.Coding Type { get; set; }
            
            /// <summary>
            /// Identity of agent (urn or url)
            /// </summary>
            public Hl7.Fhir.Model.FhirUri ReferenceElement { get; set; }
            
            public System.Uri Reference
            {
                get { return ReferenceElement != null ? ReferenceElement.Value : null; }
                set
                {
                    if(value == null)
                      ReferenceElement = null; 
                    else
                      ReferenceElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// Human description of participant
            /// </summary>
            public Hl7.Fhir.Model.FhirString DisplayElement { get; set; }
            
            public string Display
            {
                get { return DisplayElement != null ? DisplayElement.Value : null; }
                set
                {
                    if(value == null)
                      DisplayElement = null; 
                    else
                      DisplayElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Role != null )
                    result.AddRange(Role.Validate());
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(ReferenceElement != null )
                    result.AddRange(ReferenceElement.Validate());
                if(DisplayElement != null )
                    result.AddRange(DisplayElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProvenanceEntityComponent")]
        [Serializable]
        public partial class ProvenanceEntityComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// derivation | revision | quotation | source
            /// </summary>
            public Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole> RoleElement { get; set; }
            
            public Hl7.Fhir.Model.Provenance.ProvenanceEntityRole? Role
            {
                get { return RoleElement != null ? RoleElement.Value : null; }
                set
                {
                    if(value == null)
                      RoleElement = null; 
                    else
                      RoleElement = new Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>(value);
                }
            }
            
            /// <summary>
            /// Resource Type, or something else
            /// </summary>
            public Hl7.Fhir.Model.Coding Type { get; set; }
            
            /// <summary>
            /// Identity of participant (urn or url)
            /// </summary>
            public Hl7.Fhir.Model.FhirUri ReferenceElement { get; set; }
            
            public System.Uri Reference
            {
                get { return ReferenceElement != null ? ReferenceElement.Value : null; }
                set
                {
                    if(value == null)
                      ReferenceElement = null; 
                    else
                      ReferenceElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// Human description of participant
            /// </summary>
            public Hl7.Fhir.Model.FhirString DisplayElement { get; set; }
            
            public string Display
            {
                get { return DisplayElement != null ? DisplayElement.Value : null; }
                set
                {
                    if(value == null)
                      DisplayElement = null; 
                    else
                      DisplayElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Entity is attributed to this agent
            /// </summary>
            public Hl7.Fhir.Model.Provenance.ProvenanceAgentComponent Agent { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(RoleElement != null )
                    result.AddRange(RoleElement.Validate());
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(ReferenceElement != null )
                    result.AddRange(ReferenceElement.Validate());
                if(DisplayElement != null )
                    result.AddRange(DisplayElement.Validate());
                if(Agent != null )
                    result.AddRange(Agent.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Target resource(s) (usually version specific)
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Target { get; set; }
        
        /// <summary>
        /// When the activity occurred
        /// </summary>
        public Hl7.Fhir.Model.Period Period { get; set; }
        
        /// <summary>
        /// When the activity was recorded / updated
        /// </summary>
        public Hl7.Fhir.Model.Instant RecordedElement { get; set; }
        
        public DateTimeOffset? Recorded
        {
            get { return RecordedElement != null ? RecordedElement.Value : null; }
            set
            {
                if(value == null)
                  RecordedElement = null; 
                else
                  RecordedElement = new Hl7.Fhir.Model.Instant(value);
            }
        }
        
        /// <summary>
        /// Reason the activity is occurring
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Reason { get; set; }
        
        /// <summary>
        /// Where the activity occurred, if relevant
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Location { get; set; }
        
        /// <summary>
        /// Policy or plan the activity was defined by
        /// </summary>
        public List<Hl7.Fhir.Model.FhirUri> PolicyElement { get; set; }
        
        public IEnumerable<System.Uri> Policy
        {
            get { return PolicyElement != null ? PolicyElement.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  PolicyElement = null; 
                else
                  PolicyElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
            }
        }
        
        /// <summary>
        /// Person, organization, records, etc. involved in creating resource
        /// </summary>
        public List<Hl7.Fhir.Model.Provenance.ProvenanceAgentComponent> Agent { get; set; }
        
        /// <summary>
        /// An entity used in this activity
        /// </summary>
        public List<Hl7.Fhir.Model.Provenance.ProvenanceEntityComponent> Entity { get; set; }
        
        /// <summary>
        /// Base64 Cryptographic signature of resource (DigSig)
        /// </summary>
        public Hl7.Fhir.Model.FhirString SignatureElement { get; set; }
        
        public string Signature
        {
            get { return SignatureElement != null ? SignatureElement.Value : null; }
            set
            {
                if(value == null)
                  SignatureElement = null; 
                else
                  SignatureElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Target != null )
                Target.ForEach(elem => result.AddRange(elem.Validate()));
            if(Period != null )
                result.AddRange(Period.Validate());
            if(RecordedElement != null )
                result.AddRange(RecordedElement.Validate());
            if(Reason != null )
                result.AddRange(Reason.Validate());
            if(Location != null )
                result.AddRange(Location.Validate());
            if(PolicyElement != null )
                PolicyElement.ForEach(elem => result.AddRange(elem.Validate()));
            if(Agent != null )
                Agent.ForEach(elem => result.AddRange(elem.Validate()));
            if(Entity != null )
                Entity.ForEach(elem => result.AddRange(elem.Validate()));
            if(SignatureElement != null )
                result.AddRange(SignatureElement.Validate());
            
            return result;
        }
    }
    
}
