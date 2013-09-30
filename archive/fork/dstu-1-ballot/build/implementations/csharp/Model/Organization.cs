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
    /// A grouping of people or organizations with a common purpose
    /// </summary>
    [FhirResource("Organization")]
    [Serializable]
    public partial class Organization : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("OrganizationContactComponent")]
        [Serializable]
        public partial class OrganizationContactComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The type of contact
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Purpose { get; set; }
            
            /// <summary>
            /// A name associated with the contact
            /// </summary>
            public Hl7.Fhir.Model.HumanName Name { get; set; }
            
            /// <summary>
            /// Contact details (telephone, email, etc)  for a contact
            /// </summary>
            public List<Hl7.Fhir.Model.Contact> Telecom { get; set; }
            
            /// <summary>
            /// Visiting or postal addresses for the contact
            /// </summary>
            public Hl7.Fhir.Model.Address Address { get; set; }
            
            /// <summary>
            /// Gender for administrative purposes
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Gender { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Purpose != null )
                    result.AddRange(Purpose.Validate());
                if(Name != null )
                    result.AddRange(Name.Validate());
                if(Telecom != null )
                    Telecom.ForEach(elem => result.AddRange(elem.Validate()));
                if(Address != null )
                    result.AddRange(Address.Validate());
                if(Gender != null )
                    result.AddRange(Gender.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Identifier for this organization
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// Name used for the organization
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
        /// Kind of organization
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
        
        /// <summary>
        /// A contact detail for the organization
        /// </summary>
        public List<Hl7.Fhir.Model.Contact> Telecom { get; set; }
        
        /// <summary>
        /// An address for the organization
        /// </summary>
        public List<Hl7.Fhir.Model.Address> Address { get; set; }
        
        /// <summary>
        /// The organization of which this organization forms a part
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference PartOf { get; set; }
        
        /// <summary>
        /// Contact for the organization
        /// </summary>
        public List<Hl7.Fhir.Model.Organization.OrganizationContactComponent> Contact { get; set; }
        
        /// <summary>
        /// Whether the organization's record is still in active use
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean ActiveElement { get; set; }
        
        public bool? Active
        {
            get { return ActiveElement != null ? ActiveElement.Value : null; }
            set
            {
                if(value == null)
                  ActiveElement = null; 
                else
                  ActiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(NameElement != null )
                result.AddRange(NameElement.Validate());
            if(Type != null )
                result.AddRange(Type.Validate());
            if(Telecom != null )
                Telecom.ForEach(elem => result.AddRange(elem.Validate()));
            if(Address != null )
                Address.ForEach(elem => result.AddRange(elem.Validate()));
            if(PartOf != null )
                result.AddRange(PartOf.Validate());
            if(Contact != null )
                Contact.ForEach(elem => result.AddRange(elem.Validate()));
            if(ActiveElement != null )
                result.AddRange(ActiveElement.Validate());
            
            return result;
        }
    }
    
}
