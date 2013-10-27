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
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Schedule instances
    */
    internal static partial class ScheduleSerializer
    {
        public static void SerializeSchedule(Hl7.Fhir.Model.Schedule value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element event
            if(value.Event != null && value.Event.Count > 0)
            {
                writer.WriteStartArrayElement("event");
                foreach(var item in value.Event)
                {
                    writer.WriteStartArrayMember("event");
                    PeriodSerializer.SerializePeriod(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element repeat
            if(value.Repeat != null)
            {
                writer.WriteStartElement("repeat");
                ScheduleSerializer.SerializeScheduleRepeatComponent(value.Repeat, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeScheduleRepeatComponent(Hl7.Fhir.Model.Schedule.ScheduleRepeatComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element frequency
            if(value.FrequencyElement != null)
            {
                writer.WriteStartElement("frequency");
                IntegerSerializer.SerializeInteger(value.FrequencyElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element when
            if(value.WhenElement != null)
            {
                writer.WriteStartElement("when");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Schedule.EventTiming>(value.WhenElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element duration
            if(value.DurationElement != null)
            {
                writer.WriteStartElement("duration");
                FhirDecimalSerializer.SerializeFhirDecimal(value.DurationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element units
            if(value.UnitsElement != null)
            {
                writer.WriteStartElement("units");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Schedule.UnitsOfTime>(value.UnitsElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element count
            if(value.CountElement != null)
            {
                writer.WriteStartElement("count");
                IntegerSerializer.SerializeInteger(value.CountElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element end
            if(value.EndElement != null)
            {
                writer.WriteStartElement("end");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.EndElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
