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
    * Serializer for Questionnaire instances
    */
    internal static partial class QuestionnaireSerializer
    {
        public static void SerializeQuestionnaire(Hl7.Fhir.Model.Questionnaire value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Questionnaire");
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
            
            // Serialize element status
            if(value.StatusElement != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.ObservationStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element authored
            if(value.AuthoredElement != null)
            {
                writer.WriteStartElement("authored");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.AuthoredElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element author
            if(value.Author != null)
            {
                writer.WriteStartElement("author");
                ResourceReferenceSerializer.SerializeResourceReference(value.Author, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element source
            if(value.Source != null)
            {
                writer.WriteStartElement("source");
                ResourceReferenceSerializer.SerializeResourceReference(value.Source, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Name, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element identifier
            if(value.Identifier != null)
            {
                writer.WriteStartElement("identifier");
                IdentifierSerializer.SerializeIdentifier(value.Identifier, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element encounter
            if(value.Encounter != null)
            {
                writer.WriteStartElement("encounter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Encounter, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element question
            if(value.Question != null && !summary && value.Question.Count > 0)
            {
                writer.WriteStartArrayElement("question");
                foreach(var item in value.Question)
                {
                    writer.WriteStartArrayMember("question");
                    QuestionnaireSerializer.SerializeQuestionComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element group
            if(value.Group != null && !summary && value.Group.Count > 0)
            {
                writer.WriteStartArrayElement("group");
                foreach(var item in value.Group)
                {
                    writer.WriteStartArrayMember("group");
                    QuestionnaireSerializer.SerializeGroupComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeQuestionComponent(Hl7.Fhir.Model.Questionnaire.QuestionComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Name, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.TextElement != null)
            {
                writer.WriteStartElement("text");
                FhirStringSerializer.SerializeFhirString(value.TextElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element answer
            if(value.Answer != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("answer", value.Answer.GetType()) );
                FhirSerializer.SerializeElement(value.Answer, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element choice
            if(value.Choice != null && value.Choice.Count > 0)
            {
                writer.WriteStartArrayElement("choice");
                foreach(var item in value.Choice)
                {
                    writer.WriteStartArrayMember("choice");
                    CodingSerializer.SerializeCoding(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element options
            if(value.Options != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("options", value.Options.GetType()) );
                FhirSerializer.SerializeElement(value.Options, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element data
            if(value.Data != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("data", value.Data.GetType()) );
                FhirSerializer.SerializeElement(value.Data, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element remarks
            if(value.RemarksElement != null)
            {
                writer.WriteStartElement("remarks");
                FhirStringSerializer.SerializeFhirString(value.RemarksElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeGroupComponent(Hl7.Fhir.Model.Questionnaire.GroupComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Name, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element header
            if(value.HeaderElement != null)
            {
                writer.WriteStartElement("header");
                FhirStringSerializer.SerializeFhirString(value.HeaderElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.TextElement != null)
            {
                writer.WriteStartElement("text");
                FhirStringSerializer.SerializeFhirString(value.TextElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element question
            if(value.Question != null && value.Question.Count > 0)
            {
                writer.WriteStartArrayElement("question");
                foreach(var item in value.Question)
                {
                    writer.WriteStartArrayMember("question");
                    QuestionnaireSerializer.SerializeQuestionComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element group
            if(value.Group != null && value.Group.Count > 0)
            {
                writer.WriteStartArrayElement("group");
                foreach(var item in value.Group)
                {
                    writer.WriteStartArrayMember("group");
                    QuestionnaireSerializer.SerializeGroupComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
