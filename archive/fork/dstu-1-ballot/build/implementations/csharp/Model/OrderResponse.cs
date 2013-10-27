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
    /// A response to an order
    /// </summary>
    [FhirResource("OrderResponse")]
    [Serializable]
    public partial class OrderResponse : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The status of the response to an order
        /// </summary>
        public enum OrderOutcomeCode
        {
            Pending, // The order is known, but no processing has occurred at this time.
            Review, // The order is undergoing initial processing to determine whether it will be accepted (usually this involves human review).
            Rejected, // The order was rejected because of a workflow/business logic reason.
            Error, // The order was unable to be processed because of a technical error (i.e. unexpected error).
            Accepted, // The order has been accepted, and work is in progress.
            Cancelled, // Processing the order was halted at the initiators request.
            Aborted, // Processing the order was stopped because of some workflow/business logic reason.
            Complete, // The order has been completed.
        }
        
        /// <summary>
        /// Conversion of OrderOutcomeCodefrom and into string
        /// <summary>
        public static class OrderOutcomeCodeHandling
        {
            public static bool TryParse(string value, out OrderOutcomeCode result)
            {
                result = default(OrderOutcomeCode);
                
                if( value=="pending")
                    result = OrderOutcomeCode.Pending;
                else if( value=="review")
                    result = OrderOutcomeCode.Review;
                else if( value=="rejected")
                    result = OrderOutcomeCode.Rejected;
                else if( value=="error")
                    result = OrderOutcomeCode.Error;
                else if( value=="accepted")
                    result = OrderOutcomeCode.Accepted;
                else if( value=="cancelled")
                    result = OrderOutcomeCode.Cancelled;
                else if( value=="aborted")
                    result = OrderOutcomeCode.Aborted;
                else if( value=="complete")
                    result = OrderOutcomeCode.Complete;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(OrderOutcomeCode value)
            {
                if( value==OrderOutcomeCode.Pending )
                    return "pending";
                else if( value==OrderOutcomeCode.Review )
                    return "review";
                else if( value==OrderOutcomeCode.Rejected )
                    return "rejected";
                else if( value==OrderOutcomeCode.Error )
                    return "error";
                else if( value==OrderOutcomeCode.Accepted )
                    return "accepted";
                else if( value==OrderOutcomeCode.Cancelled )
                    return "cancelled";
                else if( value==OrderOutcomeCode.Aborted )
                    return "aborted";
                else if( value==OrderOutcomeCode.Complete )
                    return "complete";
                else
                    throw new ArgumentException("Unrecognized OrderOutcomeCode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The order that this is a response to
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Request { get; set; }
        
        /// <summary>
        /// When the response was made
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
        /// Who made the response
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Who { get; set; }
        
        /// <summary>
        /// If required by policy
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Authority { get; set; }
        
        /// <summary>
        /// How much the request will/did cost
        /// </summary>
        public Hl7.Fhir.Model.Money Cost { get; set; }
        
        /// <summary>
        /// The status of the response
        /// </summary>
        public Code<Hl7.Fhir.Model.OrderResponse.OrderOutcomeCode> CodeElement { get; set; }
        
        public Hl7.Fhir.Model.OrderResponse.OrderOutcomeCode? Code
        {
            get { return CodeElement != null ? CodeElement.Value : null; }
            set
            {
                if(value == null)
                  CodeElement = null; 
                else
                  CodeElement = new Code<Hl7.Fhir.Model.OrderResponse.OrderOutcomeCode>(value);
            }
        }
        
        /// <summary>
        /// Additional description of the response
        /// </summary>
        public Hl7.Fhir.Model.FhirString DescriptionElement { get; set; }
        
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Details of the outcome of performing the order
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Fulfillment { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Request != null )
                result.AddRange(Request.Validate());
            if(DateElement != null )
                result.AddRange(DateElement.Validate());
            if(Who != null )
                result.AddRange(Who.Validate());
            if(Authority != null )
                result.AddRange(Authority.Validate());
            if(Cost != null )
                result.AddRange(Cost.Validate());
            if(CodeElement != null )
                result.AddRange(CodeElement.Validate());
            if(DescriptionElement != null )
                result.AddRange(DescriptionElement.Validate());
            if(Fulfillment != null )
                Fulfillment.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
