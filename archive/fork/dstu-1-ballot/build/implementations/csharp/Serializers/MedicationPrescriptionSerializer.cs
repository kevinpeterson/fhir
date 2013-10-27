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
    * Serializer for MedicationPrescription instances
    */
    internal static partial class MedicationPrescriptionSerializer
    {
        public static void SerializeMedicationPrescription(Hl7.Fhir.Model.MedicationPrescription value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("MedicationPrescription");
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
            
            // Serialize element dateWritten
            if(value.DateWrittenElement != null && !summary)
            {
                writer.WriteStartElement("dateWritten");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateWrittenElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null && !summary)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element patient
            if(value.Patient != null && !summary)
            {
                writer.WriteStartElement("patient");
                ResourceReferenceSerializer.SerializeResourceReference(value.Patient, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element prescriber
            if(value.Prescriber != null && !summary)
            {
                writer.WriteStartElement("prescriber");
                ResourceReferenceSerializer.SerializeResourceReference(value.Prescriber, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element encounter
            if(value.Encounter != null && !summary)
            {
                writer.WriteStartElement("encounter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Encounter, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reasonForPrescribing
            if(value.ReasonForPrescribing != null && !summary)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("reasonForPrescribing", value.ReasonForPrescribing.GetType()) );
                FhirSerializer.SerializeElement(value.ReasonForPrescribing, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element medication
            if(value.Medication != null && !summary)
            {
                writer.WriteStartElement("medication");
                ResourceReferenceSerializer.SerializeResourceReference(value.Medication, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element dosageInstruction
            if(value.DosageInstruction != null && !summary && value.DosageInstruction.Count > 0)
            {
                writer.WriteStartArrayElement("dosageInstruction");
                foreach(var item in value.DosageInstruction)
                {
                    writer.WriteStartArrayMember("dosageInstruction");
                    MedicationPrescriptionSerializer.SerializeMedicationPrescriptionDosageInstructionComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element dispense
            if(value.Dispense != null && !summary)
            {
                writer.WriteStartElement("dispense");
                MedicationPrescriptionSerializer.SerializeMedicationPrescriptionDispenseComponent(value.Dispense, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element substitution
            if(value.Substitution != null && !summary)
            {
                writer.WriteStartElement("substitution");
                MedicationPrescriptionSerializer.SerializeMedicationPrescriptionSubstitutionComponent(value.Substitution, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeMedicationPrescriptionDosageInstructionComponent(Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDosageInstructionComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element dosageInstructionsText
            if(value.DosageInstructionsTextElement != null)
            {
                writer.WriteStartElement("dosageInstructionsText");
                FhirStringSerializer.SerializeFhirString(value.DosageInstructionsTextElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element additionalInstructions
            if(value.AdditionalInstructions != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("additionalInstructions", value.AdditionalInstructions.GetType()) );
                FhirSerializer.SerializeElement(value.AdditionalInstructions, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element timing
            if(value.Timing != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("timing", value.Timing.GetType()) );
                FhirSerializer.SerializeElement(value.Timing, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element site
            if(value.Site != null)
            {
                writer.WriteStartElement("site");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Site, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element route
            if(value.Route != null)
            {
                writer.WriteStartElement("route");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Route, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element method
            if(value.Method != null)
            {
                writer.WriteStartElement("method");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Method, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element doseQuantity
            if(value.DoseQuantity != null)
            {
                writer.WriteStartElement("doseQuantity");
                QuantitySerializer.SerializeQuantity(value.DoseQuantity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element rate
            if(value.Rate != null)
            {
                writer.WriteStartElement("rate");
                RatioSerializer.SerializeRatio(value.Rate, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element maxDosePerPeriod
            if(value.MaxDosePerPeriod != null)
            {
                writer.WriteStartElement("maxDosePerPeriod");
                RatioSerializer.SerializeRatio(value.MaxDosePerPeriod, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeMedicationPrescriptionSubstitutionComponent(Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionSubstitutionComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reason
            if(value.Reason != null)
            {
                writer.WriteStartElement("reason");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Reason, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeMedicationPrescriptionDispenseComponent(Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDispenseComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element medication
            if(value.Medication != null)
            {
                writer.WriteStartElement("medication");
                ResourceReferenceSerializer.SerializeResourceReference(value.Medication, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element validityPeriod
            if(value.ValidityPeriod != null)
            {
                writer.WriteStartElement("validityPeriod");
                PeriodSerializer.SerializePeriod(value.ValidityPeriod, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element numberOfRepeatsAllowed
            if(value.NumberOfRepeatsAllowedElement != null)
            {
                writer.WriteStartElement("numberOfRepeatsAllowed");
                IntegerSerializer.SerializeInteger(value.NumberOfRepeatsAllowedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element quantity
            if(value.Quantity != null)
            {
                writer.WriteStartElement("quantity");
                QuantitySerializer.SerializeQuantity(value.Quantity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element expectedSupplyDuration
            if(value.ExpectedSupplyDuration != null)
            {
                writer.WriteStartElement("expectedSupplyDuration");
                QuantitySerializer.SerializeQuantity(value.ExpectedSupplyDuration, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
