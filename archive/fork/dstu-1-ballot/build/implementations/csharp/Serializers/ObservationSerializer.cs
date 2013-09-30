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
    * Serializer for Observation instances
    */
    internal static partial class ObservationSerializer
    {
        public static void SerializeObservation(Hl7.Fhir.Model.Observation value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Observation");
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
            
            // Serialize element name
            if(value.Name != null && !summary)
            {
                writer.WriteStartElement("name");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Name, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element value
            if(value.Value != null && !summary)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("value", value.Value.GetType()) );
                FhirSerializer.SerializeElement(value.Value, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element interpretation
            if(value.Interpretation != null && !summary)
            {
                writer.WriteStartElement("interpretation");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Interpretation, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element comments
            if(value.CommentsElement != null && !summary)
            {
                writer.WriteStartElement("comments");
                FhirStringSerializer.SerializeFhirString(value.CommentsElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element applies
            if(value.Applies != null && !summary)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("applies", value.Applies.GetType()) );
                FhirSerializer.SerializeElement(value.Applies, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element issued
            if(value.IssuedElement != null && !summary)
            {
                writer.WriteStartElement("issued");
                InstantSerializer.SerializeInstant(value.IssuedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null && !summary)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.ObservationStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reliability
            if(value.ReliabilityElement != null && !summary)
            {
                writer.WriteStartElement("reliability");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Observation.ObservationReliability>(value.ReliabilityElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element bodySite
            if(value.BodySite != null && !summary)
            {
                writer.WriteStartElement("bodySite");
                CodeableConceptSerializer.SerializeCodeableConcept(value.BodySite, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element method
            if(value.Method != null && !summary)
            {
                writer.WriteStartElement("method");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Method, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element identifier
            if(value.Identifier != null && !summary)
            {
                writer.WriteStartElement("identifier");
                IdentifierSerializer.SerializeIdentifier(value.Identifier, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null && !summary)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element performer
            if(value.Performer != null && !summary)
            {
                writer.WriteStartElement("performer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Performer, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element referenceRange
            if(value.ReferenceRange != null && !summary && value.ReferenceRange.Count > 0)
            {
                writer.WriteStartArrayElement("referenceRange");
                foreach(var item in value.ReferenceRange)
                {
                    writer.WriteStartArrayMember("referenceRange");
                    ObservationSerializer.SerializeObservationReferenceRangeComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element component
            if(value.Component != null && !summary && value.Component.Count > 0)
            {
                writer.WriteStartArrayElement("component");
                foreach(var item in value.Component)
                {
                    writer.WriteStartArrayMember("component");
                    ObservationSerializer.SerializeObservationComponentComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeObservationComponentComponent(Hl7.Fhir.Model.Observation.ObservationComponentComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element value
            if(value.Value != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("value", value.Value.GetType()) );
                FhirSerializer.SerializeElement(value.Value, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeObservationReferenceRangeComponent(Hl7.Fhir.Model.Observation.ObservationReferenceRangeComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element meaning
            if(value.Meaning != null)
            {
                writer.WriteStartElement("meaning");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Meaning, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element range
            if(value.Range != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("range", value.Range.GetType()) );
                FhirSerializer.SerializeElement(value.Range, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
