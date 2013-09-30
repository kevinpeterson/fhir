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
    * Serializer for AdverseReaction instances
    */
    internal static partial class AdverseReactionSerializer
    {
        public static void SerializeAdverseReaction(Hl7.Fhir.Model.AdverseReaction value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("AdverseReaction");
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
            
            // Serialize element reactionDate
            if(value.ReactionDateElement != null && !summary)
            {
                writer.WriteStartElement("reactionDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.ReactionDateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null && !summary)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element didNotOccurFlag
            if(value.DidNotOccurFlagElement != null && !summary)
            {
                writer.WriteStartElement("didNotOccurFlag");
                FhirBooleanSerializer.SerializeFhirBoolean(value.DidNotOccurFlagElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element recorder
            if(value.Recorder != null && !summary)
            {
                writer.WriteStartElement("recorder");
                ResourceReferenceSerializer.SerializeResourceReference(value.Recorder, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element symptom
            if(value.Symptom != null && !summary && value.Symptom.Count > 0)
            {
                writer.WriteStartArrayElement("symptom");
                foreach(var item in value.Symptom)
                {
                    writer.WriteStartArrayMember("symptom");
                    AdverseReactionSerializer.SerializeAdverseReactionSymptomComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element exposure
            if(value.Exposure != null && !summary && value.Exposure.Count > 0)
            {
                writer.WriteStartArrayElement("exposure");
                foreach(var item in value.Exposure)
                {
                    writer.WriteStartArrayMember("exposure");
                    AdverseReactionSerializer.SerializeAdverseReactionExposureComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeAdverseReactionSymptomComponent(Hl7.Fhir.Model.AdverseReaction.AdverseReactionSymptomComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element severity
            if(value.SeverityElement != null)
            {
                writer.WriteStartElement("severity");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.AdverseReaction.ReactionSeverity>(value.SeverityElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeAdverseReactionExposureComponent(Hl7.Fhir.Model.AdverseReaction.AdverseReactionExposureComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element exposureDate
            if(value.ExposureDateElement != null)
            {
                writer.WriteStartElement("exposureDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.ExposureDateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element exposureType
            if(value.ExposureTypeElement != null)
            {
                writer.WriteStartElement("exposureType");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.AdverseReaction.ExposureType>(value.ExposureTypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element causalityExpectation
            if(value.CausalityExpectationElement != null)
            {
                writer.WriteStartElement("causalityExpectation");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.AdverseReaction.CausalityExpectation>(value.CausalityExpectationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element substance
            if(value.Substance != null)
            {
                writer.WriteStartElement("substance");
                ResourceReferenceSerializer.SerializeResourceReference(value.Substance, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
