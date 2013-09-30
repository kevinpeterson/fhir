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
// Generated on Fri, Jul 5, 2013 15:14+1000 for FHIR v0.09
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Description of an individual
    /// </summary>
    [FhirComposite("Demographics")]
    public partial class Demographics : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DemographicsLanguageComponent")]
        public partial class DemographicsLanguageComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Language with optional region
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Language { get; set; }
            
            /// <summary>
            /// Method of expression (e.g,expressed written, received spoken)
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Mode { get; set; }
            
            /// <summary>
            /// How well understood/expressed
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept ProficiencyLevel { get; set; }
            
            /// <summary>
            /// Language preference indicator
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean Preference { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Language != null )
                    result.AddRange(Language.Validate());
                if(Mode != null )
                    Mode.ForEach(elem => result.AddRange(elem.Validate()));
                if(ProficiencyLevel != null )
                    result.AddRange(ProficiencyLevel.Validate());
                if(Preference != null )
                    result.AddRange(Preference.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// An identifier for this individual
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// A name associated with the individual
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
        public Hl7.Fhir.Model.FhirDateTime BirthDate { get; set; }
        
        /// <summary>
        /// Indicates if the individual is deceased or not
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean Deceased { get; set; }
        
        /// <summary>
        /// Addresses for the individual
        /// </summary>
        public List<Hl7.Fhir.Model.Address> Address { get; set; }
        
        /// <summary>
        /// Image of the person
        /// </summary>
        public List<Hl7.Fhir.Model.Attachment> Photo { get; set; }
        
        /// <summary>
        /// Marital (civil) status of a person
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept MaritalStatus { get; set; }
        
        /// <summary>
        /// The person's  proficiency level of a language
        /// </summary>
        public List<Hl7.Fhir.Model.Demographics.DemographicsLanguageComponent> Language { get; set; }
        
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
            if(BirthDate != null )
                result.AddRange(BirthDate.Validate());
            if(Deceased != null )
                result.AddRange(Deceased.Validate());
            if(Address != null )
                Address.ForEach(elem => result.AddRange(elem.Validate()));
            if(Photo != null )
                Photo.ForEach(elem => result.AddRange(elem.Validate()));
            if(MaritalStatus != null )
                result.AddRange(MaritalStatus.Validate());
            if(Language != null )
                Language.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
