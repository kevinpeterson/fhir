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
    /// A description of a query with a set of parameters
    /// </summary>
    [FhirResource("Query")]
    [Serializable]
    public partial class Query : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The outcome of processing a query request
        /// </summary>
        public enum QueryOutcome
        {
            Ok, // The query was processed successfully.
            Limited, // The query was processed successfully, but some additional limitations were added.
            Refused, // The server refused to process the query.
            Error, // The server tried to process the query, but some error occurred.
        }
        
        /// <summary>
        /// Conversion of QueryOutcomefrom and into string
        /// <summary>
        public static class QueryOutcomeHandling
        {
            public static bool TryParse(string value, out QueryOutcome result)
            {
                result = default(QueryOutcome);
                
                if( value=="ok")
                    result = QueryOutcome.Ok;
                else if( value=="limited")
                    result = QueryOutcome.Limited;
                else if( value=="refused")
                    result = QueryOutcome.Refused;
                else if( value=="error")
                    result = QueryOutcome.Error;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(QueryOutcome value)
            {
                if( value==QueryOutcome.Ok )
                    return "ok";
                else if( value==QueryOutcome.Limited )
                    return "limited";
                else if( value==QueryOutcome.Refused )
                    return "refused";
                else if( value==QueryOutcome.Error )
                    return "error";
                else
                    throw new ArgumentException("Unrecognized QueryOutcome value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("QueryResponseComponent")]
        [Serializable]
        public partial class QueryResponseComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Links response to source query
            /// </summary>
            public Hl7.Fhir.Model.FhirUri IdentifierElement { get; set; }
            
            public System.Uri Identifier
            {
                get { return IdentifierElement != null ? IdentifierElement.Value : null; }
                set
                {
                    if(value == null)
                      IdentifierElement = null; 
                    else
                      IdentifierElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// Outcome of processing the query
            /// </summary>
            public Code<Hl7.Fhir.Model.Query.QueryOutcome> OutcomeElement { get; set; }
            
            public Hl7.Fhir.Model.Query.QueryOutcome? Outcome
            {
                get { return OutcomeElement != null ? OutcomeElement.Value : null; }
                set
                {
                    if(value == null)
                      OutcomeElement = null; 
                    else
                      OutcomeElement = new Code<Hl7.Fhir.Model.Query.QueryOutcome>(value);
                }
            }
            
            /// <summary>
            /// Total number of matching records
            /// </summary>
            public Hl7.Fhir.Model.Integer TotalElement { get; set; }
            
            public int? Total
            {
                get { return TotalElement != null ? TotalElement.Value : null; }
                set
                {
                    if(value == null)
                      TotalElement = null; 
                    else
                      TotalElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Parameters server used
            /// </summary>
            public List<Hl7.Fhir.Model.Extension> Parameter { get; set; }
            
            /// <summary>
            /// To get first page (if paged)
            /// </summary>
            public List<Hl7.Fhir.Model.Extension> First { get; set; }
            
            /// <summary>
            /// To get previous page (if paged)
            /// </summary>
            public List<Hl7.Fhir.Model.Extension> Previous { get; set; }
            
            /// <summary>
            /// To get next page (if paged)
            /// </summary>
            public List<Hl7.Fhir.Model.Extension> Next { get; set; }
            
            /// <summary>
            /// To get last page (if paged)
            /// </summary>
            public List<Hl7.Fhir.Model.Extension> Last { get; set; }
            
            /// <summary>
            /// Resources that are the results of the search
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Reference { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(IdentifierElement != null )
                    result.AddRange(IdentifierElement.Validate());
                if(OutcomeElement != null )
                    result.AddRange(OutcomeElement.Validate());
                if(TotalElement != null )
                    result.AddRange(TotalElement.Validate());
                if(Parameter != null )
                    Parameter.ForEach(elem => result.AddRange(elem.Validate()));
                if(First != null )
                    First.ForEach(elem => result.AddRange(elem.Validate()));
                if(Previous != null )
                    Previous.ForEach(elem => result.AddRange(elem.Validate()));
                if(Next != null )
                    Next.ForEach(elem => result.AddRange(elem.Validate()));
                if(Last != null )
                    Last.ForEach(elem => result.AddRange(elem.Validate()));
                if(Reference != null )
                    Reference.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Links query and its response(s)
        /// </summary>
        public Hl7.Fhir.Model.FhirUri IdentifierElement { get; set; }
        
        public System.Uri Identifier
        {
            get { return IdentifierElement != null ? IdentifierElement.Value : null; }
            set
            {
                if(value == null)
                  IdentifierElement = null; 
                else
                  IdentifierElement = new Hl7.Fhir.Model.FhirUri(value);
            }
        }
        
        /// <summary>
        /// Set of query parameters with values
        /// </summary>
        public List<Hl7.Fhir.Model.Extension> Parameter { get; set; }
        
        /// <summary>
        /// If this is a response to a query
        /// </summary>
        public Hl7.Fhir.Model.Query.QueryResponseComponent Response { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(IdentifierElement != null )
                result.AddRange(IdentifierElement.Validate());
            if(Parameter != null )
                Parameter.ForEach(elem => result.AddRange(elem.Validate()));
            if(Response != null )
                result.AddRange(Response.Validate());
            
            return result;
        }
    }
    
}
