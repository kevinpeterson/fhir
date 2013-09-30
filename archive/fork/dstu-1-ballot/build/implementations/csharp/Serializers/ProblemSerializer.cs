using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

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
// Generated on Fri, Jun 21, 2013 15:52+1000 for FHIR v0.09
//

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Problem instances
    */
    internal static partial class ProblemSerializer
    {
        public static void SerializeProblem(Hl7.Fhir.Model.Problem value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Problem");
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element language
            if(value.Language != null)
            {
                writer.WriteStartElement("language");
                CodeSerializer.SerializeCode(value.Language, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.Text != null)
            {
                writer.WriteStartElement("text");
                NarrativeSerializer.SerializeNarrative(value.Text, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element contained
            if(value.Contained != null && value.Contained.Count > 0)
            {
                writer.WriteStartArrayElement("contained");
                foreach(var item in value.Contained)
                {
                    writer.WriteStartArrayMember("contained");
                    FhirSerializer.SerializeResource(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element visit
            if(value.Visit != null)
            {
                writer.WriteStartElement("visit");
                ResourceReferenceSerializer.SerializeResourceReference(value.Visit, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element asserter
            if(value.Asserter != null)
            {
                writer.WriteStartElement("asserter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Asserter, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dateAsserted
            if(value.DateAsserted != null)
            {
                writer.WriteStartElement("dateAsserted");
                DateSerializer.SerializeDate(value.DateAsserted, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element category
            if(value.Category != null)
            {
                writer.WriteStartElement("category");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Category, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.Status != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Problem.ProblemStatus>(value.Status, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element certainty
            if(value.Certainty != null)
            {
                writer.WriteStartElement("certainty");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Certainty, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element severity
            if(value.Severity != null)
            {
                writer.WriteStartElement("severity");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Severity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element onset
            if(value.Onset != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("onset", value.Onset.GetType()) );
                FhirSerializer.SerializeElement(value.Onset, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element abatement
            if(value.Abatement != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("abatement", value.Abatement.GetType()) );
                FhirSerializer.SerializeElement(value.Abatement, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element stage
            if(value.Stage != null)
            {
                writer.WriteStartElement("stage");
                ProblemSerializer.SerializeProblemStageComponent(value.Stage, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element evidence
            if(value.Evidence != null && value.Evidence.Count > 0)
            {
                writer.WriteStartArrayElement("evidence");
                foreach(var item in value.Evidence)
                {
                    writer.WriteStartArrayMember("evidence");
                    ProblemSerializer.SerializeProblemEvidenceComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element location
            if(value.Location != null && value.Location.Count > 0)
            {
                writer.WriteStartArrayElement("location");
                foreach(var item in value.Location)
                {
                    writer.WriteStartArrayMember("location");
                    ProblemSerializer.SerializeProblemLocationComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element relatedItem
            if(value.RelatedItem != null && value.RelatedItem.Count > 0)
            {
                writer.WriteStartArrayElement("relatedItem");
                foreach(var item in value.RelatedItem)
                {
                    writer.WriteStartArrayMember("relatedItem");
                    ProblemSerializer.SerializeProblemRelatedItemComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element notes
            if(value.Notes != null)
            {
                writer.WriteStartElement("notes");
                FhirStringSerializer.SerializeFhirString(value.Notes, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeProblemStageComponent(Hl7.Fhir.Model.Problem.ProblemStageComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element summary
            if(value.Summary != null)
            {
                writer.WriteStartElement("summary");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Summary, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element assessment
            if(value.Assessment != null && value.Assessment.Count > 0)
            {
                writer.WriteStartArrayElement("assessment");
                foreach(var item in value.Assessment)
                {
                    writer.WriteStartArrayMember("assessment");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProblemLocationComponent(Hl7.Fhir.Model.Problem.ProblemLocationComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element details
            if(value.Details != null)
            {
                writer.WriteStartElement("details");
                FhirStringSerializer.SerializeFhirString(value.Details, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProblemEvidenceComponent(Hl7.Fhir.Model.Problem.ProblemEvidenceComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element details
            if(value.Details != null && value.Details.Count > 0)
            {
                writer.WriteStartArrayElement("details");
                foreach(var item in value.Details)
                {
                    writer.WriteStartArrayMember("details");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProblemRelatedItemComponent(Hl7.Fhir.Model.Problem.ProblemRelatedItemComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Problem.ProblemRelationshipType>(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element target
            if(value.Target != null)
            {
                writer.WriteStartElement("target");
                ResourceReferenceSerializer.SerializeResourceReference(value.Target, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
