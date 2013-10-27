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
    /// Information about a person or animal receiving health care services
    /// </summary>
    [FhirResource("Patient")]
    [Serializable]
    public partial class Patient : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ContactComponent")]
        [Serializable]
        public partial class ContactComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The kind of relationship
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Relationship { get; set; }
            
            /// <summary>
            /// A name associated with the person
            /// </summary>
            public Hl7.Fhir.Model.HumanName Name { get; set; }
            
            /// <summary>
            /// A contact detail for the person
            /// </summary>
            public List<Hl7.Fhir.Model.Contact> Telecom { get; set; }
            
            /// <summary>
            /// Address for the contact person
            /// </summary>
            public Hl7.Fhir.Model.Address Address { get; set; }
            
            /// <summary>
            /// Gender for administrative purposes
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Gender { get; set; }
            
            /// <summary>
            /// Organization that is associated with the contact
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Organization { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Relationship != null )
                    Relationship.ForEach(elem => result.AddRange(elem.Validate()));
                if(Name != null )
                    result.AddRange(Name.Validate());
                if(Telecom != null )
                    Telecom.ForEach(elem => result.AddRange(elem.Validate()));
                if(Address != null )
                    result.AddRange(Address.Validate());
                if(Gender != null )
                    result.AddRange(Gender.Validate());
                if(Organization != null )
                    result.AddRange(Organization.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("AnimalComponent")]
        [Serializable]
        public partial class AnimalComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// E.g. Dog, Cow
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Species { get; set; }
            
            /// <summary>
            /// E.g. Poodle, Angus
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Breed { get; set; }
            
            /// <summary>
            /// E.g. Neutered, Intact
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept GenderStatus { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Species != null )
                    result.AddRange(Species.Validate());
                if(Breed != null )
                    result.AddRange(Breed.Validate());
                if(GenderStatus != null )
                    result.AddRange(GenderStatus.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// An identifier for the person as this patient
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// A name associated with the patient
        /// </summary>
        public List<Hl7.Fhir.Model.HumanName> Name { get; set; }
        
        /// <summary>
        /// A contact detail for the individual
        /// </summary>
        public List<Hl7.Fhir.Model.Contact> Telecom { get; set; }
        
        /// <summary>
        /// Gender for administrative purposes
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Gender { get; set; }
        
        /// <summary>
        /// The date and time of birth for the individual
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime BirthDateElement { get; set; }
        
        public string BirthDate
        {
            get { return BirthDateElement != null ? BirthDateElement.Value : null; }
            set
            {
                if(value == null)
                  BirthDateElement = null; 
                else
                  BirthDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// Indicates if the individual is deceased or not
        /// </summary>
        public Hl7.Fhir.Model.Element Deceased { get; set; }
        
        /// <summary>
        /// Addresses for the individual
        /// </summary>
        public List<Hl7.Fhir.Model.Address> Address { get; set; }
        
        /// <summary>
        /// Marital (civil) status of a person
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept MaritalStatus { get; set; }
        
        /// <summary>
        /// Whether patient is part of a multiple birth
        /// </summary>
        public Hl7.Fhir.Model.Element MultipleBirth { get; set; }
        
        /// <summary>
        /// Image of the person
        /// </summary>
        public List<Hl7.Fhir.Model.Attachment> Photo { get; set; }
        
        /// <summary>
        /// A contact party (e.g. guardian, partner, friend) for the patient
        /// </summary>
        public List<Hl7.Fhir.Model.Patient.ContactComponent> Contact { get; set; }
        
        /// <summary>
        /// If this patient is an animal (non-human)
        /// </summary>
        public Hl7.Fhir.Model.Patient.AnimalComponent Animal { get; set; }
        
        /// <summary>
        /// Languages which may be used to communicate with the patient
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> Communication { get; set; }
        
        /// <summary>
        /// Organization managing the patient
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Provider { get; set; }
        
        /// <summary>
        /// Other patient resources linked to this resource
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Link { get; set; }
        
        /// <summary>
        /// Whether this patient's record is in active use
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
            if(Name != null )
                Name.ForEach(elem => result.AddRange(elem.Validate()));
            if(Telecom != null )
                Telecom.ForEach(elem => result.AddRange(elem.Validate()));
            if(Gender != null )
                result.AddRange(Gender.Validate());
            if(BirthDateElement != null )
                result.AddRange(BirthDateElement.Validate());
            if(Deceased != null )
                result.AddRange(Deceased.Validate());
            if(Address != null )
                Address.ForEach(elem => result.AddRange(elem.Validate()));
            if(MaritalStatus != null )
                result.AddRange(MaritalStatus.Validate());
            if(MultipleBirth != null )
                result.AddRange(MultipleBirth.Validate());
            if(Photo != null )
                Photo.ForEach(elem => result.AddRange(elem.Validate()));
            if(Contact != null )
                Contact.ForEach(elem => result.AddRange(elem.Validate()));
            if(Animal != null )
                result.AddRange(Animal.Validate());
            if(Communication != null )
                Communication.ForEach(elem => result.AddRange(elem.Validate()));
            if(Provider != null )
                result.AddRange(Provider.Validate());
            if(Link != null )
                Link.ForEach(elem => result.AddRange(elem.Validate()));
            if(ActiveElement != null )
                result.AddRange(ActiveElement.Validate());
            
            return result;
        }
    }
    
}
