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
// Generated on Wed, Jun 19, 2013 01:55+1000 for FHIR v0.09
//

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for ActivityDefinition instances
    /// </summary>
    internal static partial class ActivityDefinitionParser
    {
        /// <summary>
        /// Parse ActivityDefinition
        /// </summary>
        public static Hl7.Fhir.Model.ActivityDefinition ParseActivityDefinition(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ActivityDefinition existingInstance = null )
        {
            Hl7.Fhir.Model.ActivityDefinition result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ActivityDefinition();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element category
                    else if( ParserUtils.IsAtFhirElement(reader, "category") )
                        result.Category = CodeParser.ParseCode<Hl7.Fhir.Model.ActivityDefinition.ActivityDefinitionCategory>(reader, errors);
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element timing
                    else if( ParserUtils.IsAtFhirElement(reader, "timing", true) )
                        result.Timing = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element location
                    else if( ParserUtils.IsAtFhirElement(reader, "location") )
                        result.Location = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element performer
                    else if( ParserUtils.IsAtFhirElement(reader, "performer") )
                    {
                        result.Performer = new List<Hl7.Fhir.Model.ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "performer") )
                            result.Performer.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element product
                    else if( ParserUtils.IsAtFhirElement(reader, "product") )
                        result.Product = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element quantity
                    else if( ParserUtils.IsAtFhirElement(reader, "quantity") )
                        result.Quantity = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element details
                    else if( ParserUtils.IsAtFhirElement(reader, "details") )
                        result.Details = FhirStringParser.ParseFhirString(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
    }
}
