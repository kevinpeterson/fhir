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
    /// A supply -  request and provision
    /// </summary>
    [FhirResource("Supply")]
    [Serializable]
    public partial class Supply : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SupplyDispenseComponent")]
        [Serializable]
        public partial class SupplyDispenseComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// External identifier
            /// </summary>
            public Hl7.Fhir.Model.Identifier Identifier { get; set; }
            
            /// <summary>
            /// Active/Completed/Aborted
            /// </summary>
            public Hl7.Fhir.Model.Code StatusElement { get; set; }
            
            public string Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if(value == null)
                      StatusElement = null; 
                    else
                      StatusElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            /// <summary>
            /// Type of dispense
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Amount dispensed
            /// </summary>
            public Hl7.Fhir.Model.Quantity Quantity { get; set; }
            
            /// <summary>
            /// Medication, Substance, or Device being supplied
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference SuppliedItem { get; set; }
            
            /// <summary>
            /// Dispenser
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Supplier { get; set; }
            
            /// <summary>
            /// Dispensing time
            /// </summary>
            public Hl7.Fhir.Model.Period WhenPrepared { get; set; }
            
            /// <summary>
            /// Handover time
            /// </summary>
            public Hl7.Fhir.Model.Period WhenHandedOver { get; set; }
            
            /// <summary>
            /// Where the Supply was sent
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Destination { get; set; }
            
            /// <summary>
            /// Who collected the Supply
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Receiver { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Identifier != null )
                    result.AddRange(Identifier.Validate());
                if(StatusElement != null )
                    result.AddRange(StatusElement.Validate());
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(Quantity != null )
                    result.AddRange(Quantity.Validate());
                if(SuppliedItem != null )
                    result.AddRange(SuppliedItem.Validate());
                if(Supplier != null )
                    result.AddRange(Supplier.Validate());
                if(WhenPrepared != null )
                    result.AddRange(WhenPrepared.Validate());
                if(WhenHandedOver != null )
                    result.AddRange(WhenHandedOver.Validate());
                if(Destination != null )
                    result.AddRange(Destination.Validate());
                if(Receiver != null )
                    Receiver.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// The kind of supply (central, non-stock, etc)
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Name { get; set; }
        
        /// <summary>
        /// Unique identifier
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// Dispensed|Received|Requested
        /// </summary>
        public Hl7.Fhir.Model.Code StatusElement { get; set; }
        
        public string Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Hl7.Fhir.Model.Code(value);
            }
        }
        
        /// <summary>
        /// Medication, Substance, or Device requested to be supplied
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference OrderedItem { get; set; }
        
        /// <summary>
        /// Patient
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Patient { get; set; }
        
        /// <summary>
        /// Supply details
        /// </summary>
        public List<Hl7.Fhir.Model.Supply.SupplyDispenseComponent> Dispense { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Name != null )
                result.AddRange(Name.Validate());
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(OrderedItem != null )
                result.AddRange(OrderedItem.Validate());
            if(Patient != null )
                result.AddRange(Patient.Validate());
            if(Dispense != null )
                Dispense.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
