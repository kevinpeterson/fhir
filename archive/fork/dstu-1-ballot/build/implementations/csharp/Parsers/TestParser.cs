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
    /// Parser for Test instances
    /// </summary>
    internal static partial class TestParser
    {
        /// <summary>
        /// Parse Test
        /// </summary>
        public static Hl7.Fhir.Model.Test ParseTest(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Test existingInstance = null )
        {
            Hl7.Fhir.Model.Test result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Test();
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
                    
                    // Parse element language
                    else if( ParserUtils.IsAtFhirElement(reader, "language") )
                        result.Language = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element text
                    else if( ParserUtils.IsAtFhirElement(reader, "text") )
                        result.Text = NarrativeParser.ParseNarrative(reader, errors);
                    
                    // Parse element contained
                    else if( ParserUtils.IsAtFhirElement(reader, "contained") )
                    {
                        result.Contained = new List<Hl7.Fhir.Model.Resource>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "contained") )
                            result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element stringErr
                    else if( ParserUtils.IsAtFhirElement(reader, "stringErr") )
                    {
                        result.StringErr = new List<Hl7.Fhir.Model.FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "stringErr") )
                            result.StringErr.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element stringCorr
                    else if( ParserUtils.IsAtFhirElement(reader, "stringCorr") )
                    {
                        result.StringCorr = new List<Hl7.Fhir.Model.FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "stringCorr") )
                            result.StringCorr.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element booleanErr
                    else if( ParserUtils.IsAtFhirElement(reader, "booleanErr") )
                    {
                        result.BooleanErr = new List<Hl7.Fhir.Model.FhirBoolean>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "booleanErr") )
                            result.BooleanErr.Add(FhirBooleanParser.ParseFhirBoolean(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element booleanCorr
                    else if( ParserUtils.IsAtFhirElement(reader, "booleanCorr") )
                    {
                        result.BooleanCorr = new List<Hl7.Fhir.Model.FhirBoolean>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "booleanCorr") )
                            result.BooleanCorr.Add(FhirBooleanParser.ParseFhirBoolean(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element integerErr
                    else if( ParserUtils.IsAtFhirElement(reader, "integerErr") )
                    {
                        result.IntegerErr = new List<Hl7.Fhir.Model.Integer>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "integerErr") )
                            result.IntegerErr.Add(IntegerParser.ParseInteger(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element integerCorr
                    else if( ParserUtils.IsAtFhirElement(reader, "integerCorr") )
                    {
                        result.IntegerCorr = new List<Hl7.Fhir.Model.Integer>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "integerCorr") )
                            result.IntegerCorr.Add(IntegerParser.ParseInteger(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element decimalErr
                    else if( ParserUtils.IsAtFhirElement(reader, "decimalErr") )
                    {
                        result.DecimalErr = new List<Hl7.Fhir.Model.FhirDecimal>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "decimalErr") )
                            result.DecimalErr.Add(FhirDecimalParser.ParseFhirDecimal(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element decimalCorr
                    else if( ParserUtils.IsAtFhirElement(reader, "decimalCorr") )
                    {
                        result.DecimalCorr = new List<Hl7.Fhir.Model.FhirDecimal>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "decimalCorr") )
                            result.DecimalCorr.Add(FhirDecimalParser.ParseFhirDecimal(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element b64Err
                    else if( ParserUtils.IsAtFhirElement(reader, "b64Err") )
                    {
                        result.B64Err = new List<Hl7.Fhir.Model.Base64Binary>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "b64Err") )
                            result.B64Err.Add(Base64BinaryParser.ParseBase64Binary(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element b64Corr
                    else if( ParserUtils.IsAtFhirElement(reader, "b64Corr") )
                    {
                        result.B64Corr = new List<Hl7.Fhir.Model.Base64Binary>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "b64Corr") )
                            result.B64Corr.Add(Base64BinaryParser.ParseBase64Binary(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element instantErr
                    else if( ParserUtils.IsAtFhirElement(reader, "instantErr") )
                    {
                        result.InstantErr = new List<Hl7.Fhir.Model.Instant>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "instantErr") )
                            result.InstantErr.Add(InstantParser.ParseInstant(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element instantCorr
                    else if( ParserUtils.IsAtFhirElement(reader, "instantCorr") )
                    {
                        result.InstantCorr = new List<Hl7.Fhir.Model.Instant>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "instantCorr") )
                            result.InstantCorr.Add(InstantParser.ParseInstant(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element uriErr
                    else if( ParserUtils.IsAtFhirElement(reader, "uriErr") )
                    {
                        result.UriErr = new List<Hl7.Fhir.Model.FhirUri>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "uriErr") )
                            result.UriErr.Add(FhirUriParser.ParseFhirUri(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element uriCorr
                    else if( ParserUtils.IsAtFhirElement(reader, "uriCorr") )
                    {
                        result.UriCorr = new List<Hl7.Fhir.Model.FhirUri>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "uriCorr") )
                            result.UriCorr.Add(FhirUriParser.ParseFhirUri(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element idrefSingle
                    else if( ParserUtils.IsAtFhirElement(reader, "idrefSingle") )
                        result.IdrefSingle = IdRefParser.ParseIdRef(reader, errors);
                    
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
