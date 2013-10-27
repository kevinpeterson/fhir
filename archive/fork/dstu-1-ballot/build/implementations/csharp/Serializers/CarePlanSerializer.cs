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
    * Serializer for CarePlan instances
    */
    internal static partial class CarePlanSerializer
    {
        public static void SerializeCarePlan(Hl7.Fhir.Model.CarePlan value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("CarePlan");
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
            
            // Serialize element patient
            if(value.Patient != null && !summary)
            {
                writer.WriteStartElement("patient");
                ResourceReferenceSerializer.SerializeResourceReference(value.Patient, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null && !summary)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.CarePlan.CarePlanStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element period
            if(value.Period != null && !summary)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element modified
            if(value.ModifiedElement != null && !summary)
            {
                writer.WriteStartElement("modified");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.ModifiedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element concern
            if(value.Concern != null && !summary && value.Concern.Count > 0)
            {
                writer.WriteStartArrayElement("concern");
                foreach(var item in value.Concern)
                {
                    writer.WriteStartArrayMember("concern");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element participant
            if(value.Participant != null && !summary && value.Participant.Count > 0)
            {
                writer.WriteStartArrayElement("participant");
                foreach(var item in value.Participant)
                {
                    writer.WriteStartArrayMember("participant");
                    CarePlanSerializer.SerializeCarePlanParticipantComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element goal
            if(value.Goal != null && !summary && value.Goal.Count > 0)
            {
                writer.WriteStartArrayElement("goal");
                foreach(var item in value.Goal)
                {
                    writer.WriteStartArrayMember("goal");
                    CarePlanSerializer.SerializeCarePlanGoalComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element activity
            if(value.Activity != null && !summary && value.Activity.Count > 0)
            {
                writer.WriteStartArrayElement("activity");
                foreach(var item in value.Activity)
                {
                    writer.WriteStartArrayMember("activity");
                    CarePlanSerializer.SerializeCarePlanActivityComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element notes
            if(value.NotesElement != null && !summary)
            {
                writer.WriteStartElement("notes");
                FhirStringSerializer.SerializeFhirString(value.NotesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeCarePlanGoalComponent(Hl7.Fhir.Model.CarePlan.CarePlanGoalComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element status
            if(value.StatusElement != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.CarePlan.CarePlanGoalStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element notes
            if(value.NotesElement != null)
            {
                writer.WriteStartElement("notes");
                FhirStringSerializer.SerializeFhirString(value.NotesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeCarePlanParticipantComponent(Hl7.Fhir.Model.CarePlan.CarePlanParticipantComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element role
            if(value.Role != null)
            {
                writer.WriteStartElement("role");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Role, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element member
            if(value.Member != null)
            {
                writer.WriteStartElement("member");
                ResourceReferenceSerializer.SerializeResourceReference(value.Member, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeCarePlanActivityComponent(Hl7.Fhir.Model.CarePlan.CarePlanActivityComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element category
            if(value.CategoryElement != null)
            {
                writer.WriteStartElement("category");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.CarePlan.CarePlanActivityCategory>(value.CategoryElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element prohibited
            if(value.ProhibitedElement != null)
            {
                writer.WriteStartElement("prohibited");
                FhirBooleanSerializer.SerializeFhirBoolean(value.ProhibitedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element timing
            if(value.Timing != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("timing", value.Timing.GetType()) );
                FhirSerializer.SerializeElement(value.Timing, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element location
            if(value.Location != null)
            {
                writer.WriteStartElement("location");
                ResourceReferenceSerializer.SerializeResourceReference(value.Location, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element performer
            if(value.Performer != null && value.Performer.Count > 0)
            {
                writer.WriteStartArrayElement("performer");
                foreach(var item in value.Performer)
                {
                    writer.WriteStartArrayMember("performer");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element product
            if(value.Product != null)
            {
                writer.WriteStartElement("product");
                ResourceReferenceSerializer.SerializeResourceReference(value.Product, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element dailyAmount
            if(value.DailyAmount != null)
            {
                writer.WriteStartElement("dailyAmount");
                QuantitySerializer.SerializeQuantity(value.DailyAmount, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element quantity
            if(value.Quantity != null)
            {
                writer.WriteStartElement("quantity");
                QuantitySerializer.SerializeQuantity(value.Quantity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element details
            if(value.DetailsElement != null)
            {
                writer.WriteStartElement("details");
                FhirStringSerializer.SerializeFhirString(value.DetailsElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element actionTaken
            if(value.ActionTaken != null && value.ActionTaken.Count > 0)
            {
                writer.WriteStartArrayElement("actionTaken");
                foreach(var item in value.ActionTaken)
                {
                    writer.WriteStartArrayMember("actionTaken");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element notes
            if(value.NotesElement != null)
            {
                writer.WriteStartElement("notes");
                FhirStringSerializer.SerializeFhirString(value.NotesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
