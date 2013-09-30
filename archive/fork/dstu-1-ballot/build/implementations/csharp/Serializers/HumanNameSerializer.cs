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
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for HumanName instances
    */
    internal static partial class HumanNameSerializer
    {
        public static void SerializeHumanName(Hl7.Fhir.Model.HumanName value, IFhirWriter writer, bool summary)
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
            
            // Serialize element use
            if(value.UseElement != null)
            {
                writer.WriteStartElement("use");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.HumanName.NameUse>(value.UseElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.TextElement != null)
            {
                writer.WriteStartElement("text");
                FhirStringSerializer.SerializeFhirString(value.TextElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element family
            if(value.FamilyElement != null && value.FamilyElement.Count > 0)
            {
                writer.WriteStartArrayElement("family");
                foreach(var item in value.FamilyElement)
                {
                    writer.WriteStartArrayMember("family");
                    FhirStringSerializer.SerializeFhirString(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element given
            if(value.GivenElement != null && value.GivenElement.Count > 0)
            {
                writer.WriteStartArrayElement("given");
                foreach(var item in value.GivenElement)
                {
                    writer.WriteStartArrayMember("given");
                    FhirStringSerializer.SerializeFhirString(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element prefix
            if(value.PrefixElement != null && value.PrefixElement.Count > 0)
            {
                writer.WriteStartArrayElement("prefix");
                foreach(var item in value.PrefixElement)
                {
                    writer.WriteStartArrayMember("prefix");
                    FhirStringSerializer.SerializeFhirString(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element suffix
            if(value.SuffixElement != null && value.SuffixElement.Count > 0)
            {
                writer.WriteStartArrayElement("suffix");
                foreach(var item in value.SuffixElement)
                {
                    writer.WriteStartArrayMember("suffix");
                    FhirStringSerializer.SerializeFhirString(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element period
            if(value.Period != null)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
