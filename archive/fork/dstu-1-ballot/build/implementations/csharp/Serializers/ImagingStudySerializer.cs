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
    * Serializer for ImagingStudy instances
    */
    internal static partial class ImagingStudySerializer
    {
        public static void SerializeImagingStudy(Hl7.Fhir.Model.ImagingStudy value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("ImagingStudy");
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
            
            // Serialize element dateTime
            if(value.DateTimeElement != null && !summary)
            {
                writer.WriteStartElement("dateTime");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateTimeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null && !summary)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element uid
            if(value.UidElement != null && !summary)
            {
                writer.WriteStartElement("uid");
                OidSerializer.SerializeOid(value.UidElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element accessionNo
            if(value.AccessionNo != null && !summary)
            {
                writer.WriteStartElement("accessionNo");
                IdentifierSerializer.SerializeIdentifier(value.AccessionNo, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element identifier
            if(value.Identifier != null && !summary && value.Identifier.Count > 0)
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
            
            // Serialize element modality
            if(value.Modality_Element != null && !summary && value.Modality_Element.Count > 0)
            {
                writer.WriteStartArrayElement("modality");
                foreach(var item in value.Modality_Element)
                {
                    writer.WriteStartArrayMember("modality");
                    CodeSerializer.SerializeCode<Hl7.Fhir.Model.ImagingStudy.ImagingModality>(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element referrer
            if(value.Referrer != null && !summary)
            {
                writer.WriteStartElement("referrer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Referrer, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element availability
            if(value.AvailabilityElement != null && !summary)
            {
                writer.WriteStartElement("availability");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.ImagingStudy.InstanceAvailability>(value.AvailabilityElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element url
            if(value.UrlElement != null && !summary)
            {
                writer.WriteStartElement("url");
                FhirUriSerializer.SerializeFhirUri(value.UrlElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element numberOfSeries
            if(value.NumberOfSeriesElement != null && !summary)
            {
                writer.WriteStartElement("numberOfSeries");
                IntegerSerializer.SerializeInteger(value.NumberOfSeriesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element numberOfInstances
            if(value.NumberOfInstancesElement != null && !summary)
            {
                writer.WriteStartElement("numberOfInstances");
                IntegerSerializer.SerializeInteger(value.NumberOfInstancesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element clinicalInformation
            if(value.ClinicalInformationElement != null && !summary)
            {
                writer.WriteStartElement("clinicalInformation");
                FhirStringSerializer.SerializeFhirString(value.ClinicalInformationElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element procedure
            if(value.Procedure != null && !summary && value.Procedure.Count > 0)
            {
                writer.WriteStartArrayElement("procedure");
                foreach(var item in value.Procedure)
                {
                    writer.WriteStartArrayMember("procedure");
                    CodingSerializer.SerializeCoding(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element interpreter
            if(value.Interpreter != null && !summary)
            {
                writer.WriteStartElement("interpreter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Interpreter, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.DescriptionElement != null && !summary)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element series
            if(value.Series != null && !summary && value.Series.Count > 0)
            {
                writer.WriteStartArrayElement("series");
                foreach(var item in value.Series)
                {
                    writer.WriteStartArrayMember("series");
                    ImagingStudySerializer.SerializeImagingStudySeriesComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeImagingStudySeriesComponent(Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element number
            if(value.NumberElement != null)
            {
                writer.WriteStartElement("number");
                IntegerSerializer.SerializeInteger(value.NumberElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element modality
            if(value.ModalityElement != null)
            {
                writer.WriteStartElement("modality");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.ImagingStudy.Modality>(value.ModalityElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element uid
            if(value.UidElement != null)
            {
                writer.WriteStartElement("uid");
                OidSerializer.SerializeOid(value.UidElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.DescriptionElement != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element numberOfInstances
            if(value.NumberOfInstancesElement != null)
            {
                writer.WriteStartElement("numberOfInstances");
                IntegerSerializer.SerializeInteger(value.NumberOfInstancesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element availability
            if(value.AvailabilityElement != null)
            {
                writer.WriteStartElement("availability");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.ImagingStudy.InstanceAvailability>(value.AvailabilityElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element url
            if(value.UrlElement != null)
            {
                writer.WriteStartElement("url");
                FhirUriSerializer.SerializeFhirUri(value.UrlElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element bodySite
            if(value.BodySite != null)
            {
                writer.WriteStartElement("bodySite");
                CodingSerializer.SerializeCoding(value.BodySite, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element dateTime
            if(value.DateTimeElement != null)
            {
                writer.WriteStartElement("dateTime");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateTimeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element instance
            if(value.Instance != null && value.Instance.Count > 0)
            {
                writer.WriteStartArrayElement("instance");
                foreach(var item in value.Instance)
                {
                    writer.WriteStartArrayMember("instance");
                    ImagingStudySerializer.SerializeImagingStudySeriesInstanceComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImagingStudySeriesInstanceComponent(Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesInstanceComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element number
            if(value.NumberElement != null)
            {
                writer.WriteStartElement("number");
                IntegerSerializer.SerializeInteger(value.NumberElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element uid
            if(value.UidElement != null)
            {
                writer.WriteStartElement("uid");
                OidSerializer.SerializeOid(value.UidElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element sopclass
            if(value.SopclassElement != null)
            {
                writer.WriteStartElement("sopclass");
                OidSerializer.SerializeOid(value.SopclassElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.TypeElement != null)
            {
                writer.WriteStartElement("type");
                FhirStringSerializer.SerializeFhirString(value.TypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element title
            if(value.TitleElement != null)
            {
                writer.WriteStartElement("title");
                FhirStringSerializer.SerializeFhirString(value.TitleElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element url
            if(value.UrlElement != null)
            {
                writer.WriteStartElement("url");
                FhirUriSerializer.SerializeFhirUri(value.UrlElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element attachment
            if(value.Attachment != null)
            {
                writer.WriteStartElement("attachment");
                ResourceReferenceSerializer.SerializeResourceReference(value.Attachment, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
