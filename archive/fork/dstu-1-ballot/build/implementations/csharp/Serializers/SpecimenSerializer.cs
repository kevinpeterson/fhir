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
    * Serializer for Specimen instances
    */
    internal static partial class SpecimenSerializer
    {
        public static void SerializeSpecimen(Hl7.Fhir.Model.Specimen value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Specimen");
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
            
            // Serialize element type
            if(value.Type != null && !summary)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element source
            if(value.Source != null && !summary && value.Source.Count > 0)
            {
                writer.WriteStartArrayElement("source");
                foreach(var item in value.Source)
                {
                    writer.WriteStartArrayMember("source");
                    SpecimenSerializer.SerializeSpecimenSourceComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element subject
            if(value.Subject != null && !summary)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element accessionIdentifier
            if(value.AccessionIdentifier != null && !summary && value.AccessionIdentifier.Count > 0)
            {
                writer.WriteStartArrayElement("accessionIdentifier");
                foreach(var item in value.AccessionIdentifier)
                {
                    writer.WriteStartArrayMember("accessionIdentifier");
                    IdentifierSerializer.SerializeIdentifier(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element receivedTime
            if(value.ReceivedTimeElement != null && !summary)
            {
                writer.WriteStartElement("receivedTime");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.ReceivedTimeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element collection
            if(value.Collection != null && !summary)
            {
                writer.WriteStartElement("collection");
                SpecimenSerializer.SerializeSpecimenCollectionComponent(value.Collection, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element treatment
            if(value.Treatment != null && !summary && value.Treatment.Count > 0)
            {
                writer.WriteStartArrayElement("treatment");
                foreach(var item in value.Treatment)
                {
                    writer.WriteStartArrayMember("treatment");
                    SpecimenSerializer.SerializeSpecimenTreatmentComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element container
            if(value.Container != null && !summary && value.Container.Count > 0)
            {
                writer.WriteStartArrayElement("container");
                foreach(var item in value.Container)
                {
                    writer.WriteStartArrayMember("container");
                    SpecimenSerializer.SerializeSpecimenContainerComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeSpecimenCollectionComponent(Hl7.Fhir.Model.Specimen.SpecimenCollectionComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element collector
            if(value.Collector != null)
            {
                writer.WriteStartElement("collector");
                ResourceReferenceSerializer.SerializeResourceReference(value.Collector, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element comment
            if(value.CommentElement != null && value.CommentElement.Count > 0)
            {
                writer.WriteStartArrayElement("comment");
                foreach(var item in value.CommentElement)
                {
                    writer.WriteStartArrayMember("comment");
                    FhirStringSerializer.SerializeFhirString(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element collectedTime
            if(value.CollectedTimeElement != null)
            {
                writer.WriteStartElement("collectedTime");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.CollectedTimeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element quantity
            if(value.Quantity != null)
            {
                writer.WriteStartElement("quantity");
                QuantitySerializer.SerializeQuantity(value.Quantity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element method
            if(value.Method != null)
            {
                writer.WriteStartElement("method");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Method, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element sourceSite
            if(value.SourceSite != null)
            {
                writer.WriteStartElement("sourceSite");
                CodeableConceptSerializer.SerializeCodeableConcept(value.SourceSite, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSpecimenSourceComponent(Hl7.Fhir.Model.Specimen.SpecimenSourceComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element relationship
            if(value.RelationshipElement != null)
            {
                writer.WriteStartElement("relationship");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Specimen.HierarchicalRelationshipType>(value.RelationshipElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element target
            if(value.Target != null && value.Target.Count > 0)
            {
                writer.WriteStartArrayElement("target");
                foreach(var item in value.Target)
                {
                    writer.WriteStartArrayMember("target");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSpecimenTreatmentComponent(Hl7.Fhir.Model.Specimen.SpecimenTreatmentComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element description
            if(value.DescriptionElement != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element procedure
            if(value.Procedure != null)
            {
                writer.WriteStartElement("procedure");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Procedure, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element additive
            if(value.Additive != null && value.Additive.Count > 0)
            {
                writer.WriteStartArrayElement("additive");
                foreach(var item in value.Additive)
                {
                    writer.WriteStartArrayMember("additive");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSpecimenContainerComponent(Hl7.Fhir.Model.Specimen.SpecimenContainerComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element identifier
            if(value.Identifier != null && value.Identifier.Count > 0)
            {
                writer.WriteStartArrayElement("identifier");
                foreach(var item in value.Identifier)
                {
                    writer.WriteStartArrayMember("identifier");
                    IdentifierSerializer.SerializeIdentifier(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element description
            if(value.DescriptionElement != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element capacity
            if(value.Capacity != null)
            {
                writer.WriteStartElement("capacity");
                QuantitySerializer.SerializeQuantity(value.Capacity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element specimenQuantity
            if(value.SpecimenQuantity != null)
            {
                writer.WriteStartElement("specimenQuantity");
                QuantitySerializer.SerializeQuantity(value.SpecimenQuantity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element additive
            if(value.Additive != null)
            {
                writer.WriteStartElement("additive");
                ResourceReferenceSerializer.SerializeResourceReference(value.Additive, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
