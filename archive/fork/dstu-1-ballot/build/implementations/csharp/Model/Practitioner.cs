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
    /// A person with a  formal responsibility in the provisioning of healthcare or related services
    /// </summary>
    [FhirResource("Practitioner")]
    [Serializable]
    public partial class Practitioner : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("PractitionerQualificationComponent")]
        [Serializable]
        public partial class PractitionerQualificationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Qualification
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Period during which the qualification is valid
            /// </summary>
            public Hl7.Fhir.Model.Period Period { get; set; }
            
            /// <summary>
            /// Organization that regulates and issues the qualification
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Issuer { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(Period != null )
                    result.AddRange(Period.Validate());
                if(Issuer != null )
                    result.AddRange(Issuer.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// A identifier for the person as this agent
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// A name associated with the person
        /// </summary>
        public Hl7.Fhir.Model.HumanName Name { get; set; }
        
        /// <summary>
        /// A contact detail for the practitioner
        /// </summary>
        public List<Hl7.Fhir.Model.Contact> Telecom { get; set; }
        
        /// <summary>
        /// One or more addresses for the practitioner
        /// </summary>
        public Hl7.Fhir.Model.Address Address { get; set; }
        
        /// <summary>
        /// Gender for administrative purposes
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Gender { get; set; }
        
        /// <summary>
        /// The date and time of birth for the practitioner
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
        /// Image of the person
        /// </summary>
        public List<Hl7.Fhir.Model.Attachment> Photo { get; set; }
        
        /// <summary>
        /// The represented organization
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Organization { get; set; }
        
        /// <summary>
        /// A role the practitioner has
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> Role { get; set; }
        
        /// <summary>
        /// Specific specialty of the practitioner
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> Specialty { get; set; }
        
        /// <summary>
        /// The period during which the person is authorized to perform the service
        /// </summary>
        public Hl7.Fhir.Model.Period Period { get; set; }
        
        /// <summary>
        /// Qualifications relevant to the provided service
        /// </summary>
        public List<Hl7.Fhir.Model.Practitioner.PractitionerQualificationComponent> Qualification { get; set; }
        
        /// <summary>
        /// A language the practitioner is able to use in patient communication
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> Communication { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(Name != null )
                result.AddRange(Name.Validate());
            if(Telecom != null )
                Telecom.ForEach(elem => result.AddRange(elem.Validate()));
            if(Address != null )
                result.AddRange(Address.Validate());
            if(Gender != null )
                result.AddRange(Gender.Validate());
            if(BirthDateElement != null )
                result.AddRange(BirthDateElement.Validate());
            if(Photo != null )
                Photo.ForEach(elem => result.AddRange(elem.Validate()));
            if(Organization != null )
                result.AddRange(Organization.Validate());
            if(Role != null )
                Role.ForEach(elem => result.AddRange(elem.Validate()));
            if(Specialty != null )
                Specialty.ForEach(elem => result.AddRange(elem.Validate()));
            if(Period != null )
                result.AddRange(Period.Validate());
            if(Qualification != null )
                Qualification.ForEach(elem => result.AddRange(elem.Validate()));
            if(Communication != null )
                Communication.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
