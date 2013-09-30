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
// Generated on Wed, Jun 19, 2013 01:55+1000 for FHIR v0.09
//

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Study instances
    */
    internal static partial class StudySerializer
    {
        public static void SerializeStudy(Hl7.Fhir.Model.Study value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Study");
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
            
            // Serialize element identifier
            if(value.Identifier != null && value.Identifier.Count > 0)
            {
                writer.WriteStartArrayElement("identifier");
                foreach(var item in value.Identifier)
                {
                    writer.WriteStartArrayMember("identifier");
                    IdentifierSerializer.SerializeIdentifier(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element sponsor
            if(value.Sponsor != null)
            {
                writer.WriteStartElement("sponsor");
                FhirStringSerializer.SerializeFhirString(value.Sponsor, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element title
            if(value.Title != null)
            {
                writer.WriteStartElement("title");
                FhirStringSerializer.SerializeFhirString(value.Title, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element condition
            if(value.Condition != null && value.Condition.Count > 0)
            {
                writer.WriteStartArrayElement("condition");
                foreach(var item in value.Condition)
                {
                    writer.WriteStartArrayMember("condition");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element treatment
            if(value.Treatment != null && value.Treatment.Count > 0)
            {
                writer.WriteStartArrayElement("treatment");
                foreach(var item in value.Treatment)
                {
                    writer.WriteStartArrayMember("treatment");
                    StudySerializer.SerializeStudyTreatmentComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element controlType
            if(value.ControlType != null && value.ControlType.Count > 0)
            {
                writer.WriteStartArrayElement("controlType");
                foreach(var item in value.ControlType)
                {
                    writer.WriteStartArrayMember("controlType");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element objective
            if(value.Objective != null && value.Objective.Count > 0)
            {
                writer.WriteStartArrayElement("objective");
                foreach(var item in value.Objective)
                {
                    writer.WriteStartArrayMember("objective");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element outcomeMeasure
            if(value.OutcomeMeasure != null && value.OutcomeMeasure.Count > 0)
            {
                writer.WriteStartArrayElement("outcomeMeasure");
                foreach(var item in value.OutcomeMeasure)
                {
                    writer.WriteStartArrayMember("outcomeMeasure");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element eligibility
            if(value.Eligibility != null && value.Eligibility.Count > 0)
            {
                writer.WriteStartArrayElement("eligibility");
                foreach(var item in value.Eligibility)
                {
                    writer.WriteStartArrayMember("eligibility");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element period
            if(value.Period != null)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element duration
            if(value.Duration != null)
            {
                writer.WriteStartElement("duration");
                QuantitySerializer.SerializeQuantity(value.Duration, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element plannedEnrollment
            if(value.PlannedEnrollment != null)
            {
                writer.WriteStartElement("plannedEnrollment");
                IntegerSerializer.SerializeInteger(value.PlannedEnrollment, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element intervention
            if(value.Intervention != null)
            {
                writer.WriteStartElement("intervention");
                StudySerializer.SerializeStudyInterventionComponent(value.Intervention, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element protocol
            if(value.Protocol != null && value.Protocol.Count > 0)
            {
                writer.WriteStartArrayElement("protocol");
                foreach(var item in value.Protocol)
                {
                    writer.WriteStartArrayMember("protocol");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element dataStructure
            if(value.DataStructure != null)
            {
                writer.WriteStartElement("dataStructure");
                ResourceReferenceSerializer.SerializeResourceReference(value.DataStructure, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element data
            if(value.Data != null && value.Data.Count > 0)
            {
                writer.WriteStartArrayElement("data");
                foreach(var item in value.Data)
                {
                    writer.WriteStartArrayMember("data");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeStudyInterventionComponent(Hl7.Fhir.Model.Study.StudyInterventionComponent value, IFhirWriter writer)
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
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element model
            if(value.Model != null)
            {
                writer.WriteStartElement("model");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Model, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element randomized
            if(value.Randomized != null)
            {
                writer.WriteStartElement("randomized");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Randomized, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element blindingScheme
            if(value.BlindingScheme != null)
            {
                writer.WriteStartElement("blindingScheme");
                CodeableConceptSerializer.SerializeCodeableConcept(value.BlindingScheme, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element randomizationQuotient
            if(value.RandomizationQuotient != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("randomizationQuotient", value.RandomizationQuotient.GetType()) );
                FhirSerializer.SerializeElement(value.RandomizationQuotient, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeStudyTreatmentComponent(Hl7.Fhir.Model.Study.StudyTreatmentComponent value, IFhirWriter writer)
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
            
            // Serialize element role
            if(value.Role != null)
            {
                writer.WriteStartElement("role");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Study.StudyTreatmentRole>(value.Role, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element detail
            if(value.Detail != null)
            {
                writer.WriteStartElement("detail");
                ActivityDefinitionSerializer.SerializeActivityDefinition(value.Detail, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
