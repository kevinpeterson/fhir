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
    /// A request to perform an action
    /// </summary>
    [FhirResource("Order")]
    [Serializable]
    public partial class Order : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("OrderWhenComponent")]
        [Serializable]
        public partial class OrderWhenComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Code specifies when request should be done. The code may simply be a priority code
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
            
            /// <summary>
            /// A formal schedule
            /// </summary>
            public Hl7.Fhir.Model.Schedule Schedule { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Code != null )
                    result.AddRange(Code.Validate());
                if(Schedule != null )
                    result.AddRange(Schedule.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// When the order was made
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime DateElement { get; set; }
        
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// Patient this order is about
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Who initiated the order
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Source { get; set; }
        
        /// <summary>
        /// Who is intended to fulfill the order
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Target { get; set; }
        
        /// <summary>
        /// Text - why the order was made
        /// </summary>
        public Hl7.Fhir.Model.FhirString ReasonElement { get; set; }
        
        public string Reason
        {
            get { return ReasonElement != null ? ReasonElement.Value : null; }
            set
            {
                if(value == null)
                  ReasonElement = null; 
                else
                  ReasonElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// If required by policy
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Authority { get; set; }
        
        /// <summary>
        /// When order should be fulfilled
        /// </summary>
        public Hl7.Fhir.Model.Order.OrderWhenComponent When { get; set; }
        
        /// <summary>
        /// What action is being ordered
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Detail { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(DateElement != null )
                result.AddRange(DateElement.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Source != null )
                result.AddRange(Source.Validate());
            if(Target != null )
                result.AddRange(Target.Validate());
            if(ReasonElement != null )
                result.AddRange(ReasonElement.Validate());
            if(Authority != null )
                result.AddRange(Authority.Validate());
            if(When != null )
                result.AddRange(When.Validate());
            if(Detail != null )
                Detail.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
