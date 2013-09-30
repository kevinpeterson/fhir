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

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Address instances
    /// </summary>
    internal static partial class AddressParser
    {
        /// <summary>
        /// Parse Address
        /// </summary>
        public static Hl7.Fhir.Model.Address ParseAddress(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Address existingInstance = null )
        {
            Hl7.Fhir.Model.Address result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Address();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element use
                else if( atName == "use" )
                    result.UseElement = CodeParser.ParseCode<Hl7.Fhir.Model.Address.AddressUse>(reader, errors);
                
                // Parse element text
                else if( atName == "text" )
                    result.TextElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element line
                else if( atName == "line" )
                {
                    result.LineElement = new List<Hl7.Fhir.Model.FhirString>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "line") )
                        result.LineElement.Add(FhirStringParser.ParseFhirString(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element city
                else if( atName == "city" )
                    result.CityElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element state
                else if( atName == "state" )
                    result.StateElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element zip
                else if( atName == "zip" )
                    result.ZipElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element country
                else if( atName == "country" )
                    result.CountryElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element period
                else if( atName == "period" )
                    result.Period = PeriodParser.ParsePeriod(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
    }
}
