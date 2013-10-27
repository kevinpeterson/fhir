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
    * Serializer for AllergyIntolerance instances
    */
    internal static partial class AllergyIntoleranceSerializer
    {
        public static void SerializeAllergyIntolerance(Hl7.Fhir.Model.AllergyIntolerance value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("AllergyIntolerance");
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
            
            // Serialize element language
            if(value.LanguageElement != null && !summary)
            {
                writer.WriteStartElement("language");
                CodeSerializer.SerializeCode(value.LanguageElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.Text != null && !summary)
            {
                writer.WriteStartElement("text");
                NarrativeSerializer.SerializeNarrative(value.Text, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element contained
            if(value.Contained != null && !summary && value.Contained.Count > 0)
            {
                writer.WriteStartArrayElement("contained");
                foreach(var item in value.Contained)
                {
                    writer.WriteStartArrayMember("contained");
                    FhirSerializer.SerializeResource(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element identifier
            if(value.Identifier != null && !summary)
            {
                writer.WriteStartElement("identifier");
                IdentifierSerializer.SerializeIdentifier(value.Identifier, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element criticality
            if(value.Criticality_Element != null && !summary)
            {
                writer.WriteStartElement("criticality");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.AllergyIntolerance.Criticality>(value.Criticality_Element, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element sensitivityType
            if(value.SensitivityType_Element != null && !summary)
            {
                writer.WriteStartElement("sensitivityType");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.AllergyIntolerance.SensitivityType>(value.SensitivityType_Element, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element recordedDate
            if(value.RecordedDateElement != null && !summary)
            {
                writer.WriteStartElement("recordedDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.RecordedDateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null && !summary)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.AllergyIntolerance.SensitivityStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null && !summary)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element recorder
            if(value.Recorder != null && !summary)
            {
                writer.WriteStartElement("recorder");
                ResourceReferenceSerializer.SerializeResourceReference(value.Recorder, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element substance
            if(value.Substance != null && !summary)
            {
                writer.WriteStartElement("substance");
                ResourceReferenceSerializer.SerializeResourceReference(value.Substance, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reaction
            if(value.Reaction != null && !summary && value.Reaction.Count > 0)
            {
                writer.WriteStartArrayElement("reaction");
                foreach(var item in value.Reaction)
                {
                    writer.WriteStartArrayMember("reaction");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element sensitivityTest
            if(value.SensitivityTest != null && !summary && value.SensitivityTest.Count > 0)
            {
                writer.WriteStartArrayElement("sensitivityTest");
                foreach(var item in value.SensitivityTest)
                {
                    writer.WriteStartArrayMember("sensitivityTest");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
    }
}
