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
// Generated on Tue, May 7, 2013 02:15+1000 for FHIR v0.09
//

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Prescription instances
    */
    internal static partial class PrescriptionSerializer
    {
        public static void SerializePrescription(Prescription value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Prescription");
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
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
            
            // Serialize element status
            if(value.Status != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Prescription.PrescriptionStatus>(value.Status, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element patient
            if(value.Patient != null)
            {
                writer.WriteStartElement("patient");
                ResourceReferenceSerializer.SerializeResourceReference(value.Patient, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element prescriber
            if(value.Prescriber != null)
            {
                writer.WriteStartElement("prescriber");
                ResourceReferenceSerializer.SerializeResourceReference(value.Prescriber, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element prescribed
            if(value.Prescribed != null)
            {
                writer.WriteStartElement("prescribed");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Prescribed, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dispense
            if(value.Dispense != null)
            {
                writer.WriteStartElement("dispense");
                PrescriptionSerializer.SerializePrescriptionDispenseComponent(value.Dispense, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element medicine
            if(value.Medicine != null)
            {
                writer.WriteStartElement("medicine");
                PrescriptionSerializer.SerializePrescriptionMedicineComponent(value.Medicine, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element administrationRequest
            if(value.AdministrationRequest != null)
            {
                writer.WriteStartElement("administrationRequest");
                PrescriptionSerializer.SerializePrescriptionAdministrationRequestComponent(value.AdministrationRequest, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element reason
            if(value.Reason != null)
            {
                writer.WriteStartElement("reason");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Reason, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializePrescriptionDispenseComponent(Prescription.PrescriptionDispenseComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
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
            
            // Serialize element repeats
            if(value.Repeats != null)
            {
                writer.WriteStartElement("repeats");
                IntegerSerializer.SerializeInteger(value.Repeats, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element quantity
            if(value.Quantity != null)
            {
                writer.WriteStartElement("quantity");
                QuantitySerializer.SerializeQuantity(value.Quantity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dispenser
            if(value.Dispenser != null)
            {
                writer.WriteStartElement("dispenser");
                ResourceReferenceSerializer.SerializeResourceReference(value.Dispenser, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializePrescriptionMedicineActiveIngredientComponent(Prescription.PrescriptionMedicineActiveIngredientComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
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
            
            // Serialize element identification
            if(value.Identification != null)
            {
                writer.WriteStartElement("identification");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Identification, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element quantity
            if(value.Quantity != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("quantity", value.Quantity.GetType()) );
                FhirSerializer.SerializeElement(value.Quantity, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializePrescriptionAdministrationRequestComponent(Prescription.PrescriptionAdministrationRequestComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
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
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element totalPeriodicDose
            if(value.TotalPeriodicDose != null)
            {
                writer.WriteStartElement("totalPeriodicDose");
                RatioSerializer.SerializeRatio(value.TotalPeriodicDose, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element start
            if(value.Start != null)
            {
                writer.WriteStartElement("start");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Start, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element end
            if(value.End != null)
            {
                writer.WriteStartElement("end");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.End, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element duration
            if(value.Duration != null)
            {
                writer.WriteStartElement("duration");
                QuantitySerializer.SerializeQuantity(value.Duration, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element numberOfAdministrations
            if(value.NumberOfAdministrations != null)
            {
                writer.WriteStartElement("numberOfAdministrations");
                IntegerSerializer.SerializeInteger(value.NumberOfAdministrations, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dosageInstruction
            if(value.DosageInstruction != null && value.DosageInstruction.Count > 0)
            {
                writer.WriteStartArrayElement("dosageInstruction");
                foreach(var item in value.DosageInstruction)
                {
                    writer.WriteStartArrayMember("dosageInstruction");
                    PrescriptionSerializer.SerializePrescriptionAdministrationRequestDosageInstructionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializePrescriptionMedicineComponent(Prescription.PrescriptionMedicineComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
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
            
            // Serialize element identification
            if(value.Identification != null)
            {
                writer.WriteStartElement("identification");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Identification, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element activeIngredient
            if(value.ActiveIngredient != null && value.ActiveIngredient.Count > 0)
            {
                writer.WriteStartArrayElement("activeIngredient");
                foreach(var item in value.ActiveIngredient)
                {
                    writer.WriteStartArrayMember("activeIngredient");
                    PrescriptionSerializer.SerializePrescriptionMedicineActiveIngredientComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element inactiveIngredient
            if(value.InactiveIngredient != null && value.InactiveIngredient.Count > 0)
            {
                writer.WriteStartArrayElement("inactiveIngredient");
                foreach(var item in value.InactiveIngredient)
                {
                    writer.WriteStartArrayMember("inactiveIngredient");
                    PrescriptionSerializer.SerializePrescriptionMedicineInactiveIngredientComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializePrescriptionMedicineInactiveIngredientComponent(Prescription.PrescriptionMedicineInactiveIngredientComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
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
            
            // Serialize element identification
            if(value.Identification != null)
            {
                writer.WriteStartElement("identification");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Identification, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element quantity
            if(value.Quantity != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("quantity", value.Quantity.GetType()) );
                FhirSerializer.SerializeElement(value.Quantity, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializePrescriptionAdministrationRequestDosageInstructionComponent(Prescription.PrescriptionAdministrationRequestDosageInstructionComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
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
            
            // Serialize element precondition
            if(value.Precondition != null && value.Precondition.Count > 0)
            {
                writer.WriteStartArrayElement("precondition");
                foreach(var item in value.Precondition)
                {
                    writer.WriteStartArrayMember("precondition");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element prn
            if(value.Prn != null)
            {
                writer.WriteStartElement("prn");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Prn, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element additionalInstruction
            if(value.AdditionalInstruction != null && value.AdditionalInstruction.Count > 0)
            {
                writer.WriteStartArrayElement("additionalInstruction");
                foreach(var item in value.AdditionalInstruction)
                {
                    writer.WriteStartArrayMember("additionalInstruction");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element route
            if(value.Route != null)
            {
                writer.WriteStartElement("route");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Route, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dose
            if(value.Dose != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("dose", value.Dose.GetType()) );
                FhirSerializer.SerializeElement(value.Dose, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element rate
            if(value.Rate != null)
            {
                writer.WriteStartElement("rate");
                QuantitySerializer.SerializeQuantity(value.Rate, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element schedule
            if(value.Schedule != null && value.Schedule.Count > 0)
            {
                writer.WriteStartArrayElement("schedule");
                foreach(var item in value.Schedule)
                {
                    writer.WriteStartArrayMember("schedule");
                    ScheduleSerializer.SerializeSchedule(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
