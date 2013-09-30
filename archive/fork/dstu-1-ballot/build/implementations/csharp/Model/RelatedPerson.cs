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
    /// An person that is related to a patient, but who is not a direct target of care
    /// </summary>
    [FhirResource("RelatedPerson")]
    [Serializable]
    public partial class RelatedPerson : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// A Human identifier for this person
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// The patient this person is related to
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Patient { get; set; }
        
        /// <summary>
        /// The nature of the relationship
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Relationship { get; set; }
        
        /// <summary>
        /// A name associated with the person
        /// </summary>
        public Hl7.Fhir.Model.HumanName Name { get; set; }
        
        /// <summary>
        /// A contact detail for the person
        /// </summary>
        public List<Hl7.Fhir.Model.Contact> Telecom { get; set; }
        
        /// <summary>
        /// Gender for administrative purposes
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Gender { get; set; }
        
        /// <summary>
        /// Address where the related person can be contacted or visited
        /// </summary>
        public Hl7.Fhir.Model.Address Address { get; set; }
        
        /// <summary>
        /// Image of the person
        /// </summary>
        public List<Hl7.Fhir.Model.Attachment> Photo { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(Patient != null )
                result.AddRange(Patient.Validate());
            if(Relationship != null )
                result.AddRange(Relationship.Validate());
            if(Name != null )
                result.AddRange(Name.Validate());
            if(Telecom != null )
                Telecom.ForEach(elem => result.AddRange(elem.Validate()));
            if(Gender != null )
                result.AddRange(Gender.Validate());
            if(Address != null )
                result.AddRange(Address.Validate());
            if(Photo != null )
                Photo.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
