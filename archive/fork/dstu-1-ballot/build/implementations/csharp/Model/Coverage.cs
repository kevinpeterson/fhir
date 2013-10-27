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
    /// Insurance or medical plan
    /// </summary>
    [FhirResource("Coverage")]
    [Serializable]
    public partial class Coverage : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("CoverageSubscriberComponent")]
        [Serializable]
        public partial class CoverageSubscriberComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// PolicyHolder name
            /// </summary>
            public Hl7.Fhir.Model.HumanName Name { get; set; }
            
            /// <summary>
            /// PolicyHolder address
            /// </summary>
            public Hl7.Fhir.Model.Address Address { get; set; }
            
            /// <summary>
            /// PolicyHolder date of birth
            /// </summary>
            public Hl7.Fhir.Model.Date BirthdateElement { get; set; }
            
            public string Birthdate
            {
                get { return BirthdateElement != null ? BirthdateElement.Value : null; }
                set
                {
                    if(value == null)
                      BirthdateElement = null; 
                    else
                      BirthdateElement = new Hl7.Fhir.Model.Date(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Name != null )
                    result.AddRange(Name.Validate());
                if(Address != null )
                    result.AddRange(Address.Validate());
                if(BirthdateElement != null )
                    result.AddRange(BirthdateElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// An identifier for the plan issuer
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Issuer { get; set; }
        
        /// <summary>
        /// Coverage start and end dates
        /// </summary>
        public Hl7.Fhir.Model.Period Period { get; set; }
        
        /// <summary>
        /// Type of coverage
        /// </summary>
        public Hl7.Fhir.Model.Coding Type { get; set; }
        
        /// <summary>
        /// The primary coverage ID
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// An identifier for the group
        /// </summary>
        public Hl7.Fhir.Model.Identifier Group { get; set; }
        
        /// <summary>
        /// An identifier for the plan
        /// </summary>
        public Hl7.Fhir.Model.Identifier Plan { get; set; }
        
        /// <summary>
        /// An identifier for the subsection of the plan
        /// </summary>
        public Hl7.Fhir.Model.Identifier Subplan { get; set; }
        
        /// <summary>
        /// The dependent number
        /// </summary>
        public Hl7.Fhir.Model.Integer DependentElement { get; set; }
        
        public int? Dependent
        {
            get { return DependentElement != null ? DependentElement.Value : null; }
            set
            {
                if(value == null)
                  DependentElement = null; 
                else
                  DependentElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// The plan instance or sequence counter
        /// </summary>
        public Hl7.Fhir.Model.Integer SequenceElement { get; set; }
        
        public int? Sequence
        {
            get { return SequenceElement != null ? SequenceElement.Value : null; }
            set
            {
                if(value == null)
                  SequenceElement = null; 
                else
                  SequenceElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Planholder information
        /// </summary>
        public Hl7.Fhir.Model.Coverage.CoverageSubscriberComponent Subscriber { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Issuer != null )
                result.AddRange(Issuer.Validate());
            if(Period != null )
                result.AddRange(Period.Validate());
            if(Type != null )
                result.AddRange(Type.Validate());
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(Group != null )
                result.AddRange(Group.Validate());
            if(Plan != null )
                result.AddRange(Plan.Validate());
            if(Subplan != null )
                result.AddRange(Subplan.Validate());
            if(DependentElement != null )
                result.AddRange(DependentElement.Validate());
            if(SequenceElement != null )
                result.AddRange(SequenceElement.Validate());
            if(Subscriber != null )
                result.AddRange(Subscriber.Validate());
            
            return result;
        }
    }
    
}
