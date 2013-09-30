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
// Generated on Fri, Jun 21, 2013 22:44+1000 for FHIR v0.09
//

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Array instances
    /// </summary>
    internal static partial class ArrayParser
    {
        /// <summary>
        /// Parse Array
        /// </summary>
        public static Hl7.Fhir.Model.Array ParseArray(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Array existingInstance = null )
        {
            Hl7.Fhir.Model.Array result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Array();
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
                    
                    // Parse element origin
                    else if( ParserUtils.IsAtFhirElement(reader, "origin") )
                        result.Origin = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element period
                    else if( ParserUtils.IsAtFhirElement(reader, "period") )
                        result.Period = FhirDecimalParser.ParseFhirDecimal(reader, errors);
                    
                    // Parse element factor
                    else if( ParserUtils.IsAtFhirElement(reader, "factor") )
                        result.Factor = FhirDecimalParser.ParseFhirDecimal(reader, errors);
                    
                    // Parse element lowerLimit
                    else if( ParserUtils.IsAtFhirElement(reader, "lowerLimit") )
                        result.LowerLimit = FhirDecimalParser.ParseFhirDecimal(reader, errors);
                    
                    // Parse element upperLimit
                    else if( ParserUtils.IsAtFhirElement(reader, "upperLimit") )
                        result.UpperLimit = FhirDecimalParser.ParseFhirDecimal(reader, errors);
                    
                    // Parse element dimensions
                    else if( ParserUtils.IsAtFhirElement(reader, "dimensions") )
                        result.Dimensions = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element data
                    else if( ParserUtils.IsAtFhirElement(reader, "data") )
                        result.Data = FhirStringParser.ParseFhirString(reader, errors);
                    
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
