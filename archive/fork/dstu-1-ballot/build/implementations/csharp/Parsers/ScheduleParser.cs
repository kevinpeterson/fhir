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

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Schedule instances
    /// </summary>
    internal static partial class ScheduleParser
    {
        /// <summary>
        /// Parse Schedule
        /// </summary>
        public static Hl7.Fhir.Model.Schedule ParseSchedule(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Schedule existingInstance = null )
        {
            Hl7.Fhir.Model.Schedule result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Schedule();
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
                
                // Parse element event
                else if( atName == "event" )
                {
                    result.Event = new List<Hl7.Fhir.Model.Period>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "event") )
                        result.Event.Add(PeriodParser.ParsePeriod(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element repeat
                else if( atName == "repeat" )
                    result.Repeat = ScheduleParser.ParseScheduleRepeatComponent(reader, errors);
                
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
        
        /// <summary>
        /// Parse ScheduleRepeatComponent
        /// </summary>
        public static Hl7.Fhir.Model.Schedule.ScheduleRepeatComponent ParseScheduleRepeatComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Schedule.ScheduleRepeatComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Schedule.ScheduleRepeatComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Schedule.ScheduleRepeatComponent();
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
                
                // Parse element frequency
                else if( atName == "frequency" )
                    result.FrequencyElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element when
                else if( atName == "when" )
                    result.WhenElement = CodeParser.ParseCode<Hl7.Fhir.Model.Schedule.EventTiming>(reader, errors);
                
                // Parse element duration
                else if( atName == "duration" )
                    result.DurationElement = FhirDecimalParser.ParseFhirDecimal(reader, errors);
                
                // Parse element units
                else if( atName == "units" )
                    result.UnitsElement = CodeParser.ParseCode<Hl7.Fhir.Model.Schedule.UnitsOfTime>(reader, errors);
                
                // Parse element count
                else if( atName == "count" )
                    result.CountElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element end
                else if( atName == "end" )
                    result.EndElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
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
