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
    * Serializer for DiagnosticReport instances
    */
    internal static partial class DiagnosticReportSerializer
    {
        public static void SerializeDiagnosticReport(Hl7.Fhir.Model.DiagnosticReport value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("DiagnosticReport");
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
            
            // Serialize element issued
            if(value.IssuedElement != null)
            {
                writer.WriteStartElement("issued");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.IssuedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element performer
            if(value.Performer != null)
            {
                writer.WriteStartElement("performer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Performer, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reportId
            if(value.ReportId != null)
            {
                writer.WriteStartElement("reportId");
                IdentifierSerializer.SerializeIdentifier(value.ReportId, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element requestDetail
            if(value.RequestDetail != null && !summary && value.RequestDetail.Count > 0)
            {
                writer.WriteStartArrayElement("requestDetail");
                foreach(var item in value.RequestDetail)
                {
                    writer.WriteStartArrayMember("requestDetail");
                    DiagnosticReportSerializer.SerializeDiagnosticReportRequestDetailComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element serviceCategory
            if(value.ServiceCategory != null)
            {
                writer.WriteStartElement("serviceCategory");
                CodeableConceptSerializer.SerializeCodeableConcept(value.ServiceCategory, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element diagnosticTime
            if(value.DiagnosticTimeElement != null)
            {
                writer.WriteStartElement("diagnosticTime");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DiagnosticTimeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element results
            if(value.Results != null && !summary)
            {
                writer.WriteStartElement("results");
                DiagnosticReportSerializer.SerializeResultGroupComponent(value.Results, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element image
            if(value.Image != null && !summary && value.Image.Count > 0)
            {
                writer.WriteStartArrayElement("image");
                foreach(var item in value.Image)
                {
                    writer.WriteStartArrayMember("image");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element conclusion
            if(value.ConclusionElement != null && !summary)
            {
                writer.WriteStartElement("conclusion");
                FhirStringSerializer.SerializeFhirString(value.ConclusionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element codedDiagnosis
            if(value.CodedDiagnosis != null && !summary && value.CodedDiagnosis.Count > 0)
            {
                writer.WriteStartArrayElement("codedDiagnosis");
                foreach(var item in value.CodedDiagnosis)
                {
                    writer.WriteStartArrayMember("codedDiagnosis");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element representation
            if(value.Representation != null && !summary && value.Representation.Count > 0)
            {
                writer.WriteStartArrayElement("representation");
                foreach(var item in value.Representation)
                {
                    writer.WriteStartArrayMember("representation");
                    AttachmentSerializer.SerializeAttachment(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeDiagnosticReportRequestDetailComponent(Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportRequestDetailComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element encounter
            if(value.Encounter != null)
            {
                writer.WriteStartElement("encounter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Encounter, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element requestOrderId
            if(value.RequestOrderId != null)
            {
                writer.WriteStartElement("requestOrderId");
                IdentifierSerializer.SerializeIdentifier(value.RequestOrderId, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element receiverOrderId
            if(value.ReceiverOrderId != null)
            {
                writer.WriteStartElement("receiverOrderId");
                IdentifierSerializer.SerializeIdentifier(value.ReceiverOrderId, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element requestTest
            if(value.RequestTest != null && value.RequestTest.Count > 0)
            {
                writer.WriteStartArrayElement("requestTest");
                foreach(var item in value.RequestTest)
                {
                    writer.WriteStartArrayMember("requestTest");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element bodySite
            if(value.BodySite != null)
            {
                writer.WriteStartElement("bodySite");
                CodeableConceptSerializer.SerializeCodeableConcept(value.BodySite, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element requester
            if(value.Requester != null)
            {
                writer.WriteStartElement("requester");
                ResourceReferenceSerializer.SerializeResourceReference(value.Requester, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element clinicalInfo
            if(value.ClinicalInfoElement != null)
            {
                writer.WriteStartElement("clinicalInfo");
                FhirStringSerializer.SerializeFhirString(value.ClinicalInfoElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeResultGroupComponent(Hl7.Fhir.Model.DiagnosticReport.ResultGroupComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element specimen
            if(value.Specimen != null)
            {
                writer.WriteStartElement("specimen");
                ResourceReferenceSerializer.SerializeResourceReference(value.Specimen, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element group
            if(value.Group != null && value.Group.Count > 0)
            {
                writer.WriteStartArrayElement("group");
                foreach(var item in value.Group)
                {
                    writer.WriteStartArrayMember("group");
                    DiagnosticReportSerializer.SerializeResultGroupComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element result
            if(value.Result != null && value.Result.Count > 0)
            {
                writer.WriteStartArrayElement("result");
                foreach(var item in value.Result)
                {
                    writer.WriteStartArrayMember("result");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
