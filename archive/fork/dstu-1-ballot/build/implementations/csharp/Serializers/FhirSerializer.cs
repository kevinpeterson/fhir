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
    * Starting point for serializing resources
    */
    public static partial class FhirSerializer
    {
        internal static void SerializeResource(Resource value, IFhirWriter writer, bool summary)
        {
            if(value.GetType() == typeof(Hl7.Fhir.Model.AdverseReaction))
                AdverseReactionSerializer.SerializeAdverseReaction((Hl7.Fhir.Model.AdverseReaction)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Alert))
                AlertSerializer.SerializeAlert((Hl7.Fhir.Model.Alert)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.AllergyIntolerance))
                AllergyIntoleranceSerializer.SerializeAllergyIntolerance((Hl7.Fhir.Model.AllergyIntolerance)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.CarePlan))
                CarePlanSerializer.SerializeCarePlan((Hl7.Fhir.Model.CarePlan)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Condition))
                ConditionSerializer.SerializeCondition((Hl7.Fhir.Model.Condition)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Conformance))
                ConformanceSerializer.SerializeConformance((Hl7.Fhir.Model.Conformance)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Coverage))
                CoverageSerializer.SerializeCoverage((Hl7.Fhir.Model.Coverage)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Device))
                DeviceSerializer.SerializeDevice((Hl7.Fhir.Model.Device)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.DeviceCapabilities))
                DeviceCapabilitiesSerializer.SerializeDeviceCapabilities((Hl7.Fhir.Model.DeviceCapabilities)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.DeviceLog))
                DeviceLogSerializer.SerializeDeviceLog((Hl7.Fhir.Model.DeviceLog)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.DeviceObservation))
                DeviceObservationSerializer.SerializeDeviceObservation((Hl7.Fhir.Model.DeviceObservation)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.DiagnosticOrder))
                DiagnosticOrderSerializer.SerializeDiagnosticOrder((Hl7.Fhir.Model.DiagnosticOrder)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.DiagnosticReport))
                DiagnosticReportSerializer.SerializeDiagnosticReport((Hl7.Fhir.Model.DiagnosticReport)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Document))
                DocumentSerializer.SerializeDocument((Hl7.Fhir.Model.Document)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.DocumentReference))
                DocumentReferenceSerializer.SerializeDocumentReference((Hl7.Fhir.Model.DocumentReference)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Encounter))
                EncounterSerializer.SerializeEncounter((Hl7.Fhir.Model.Encounter)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.FamilyHistory))
                FamilyHistorySerializer.SerializeFamilyHistory((Hl7.Fhir.Model.FamilyHistory)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Group))
                GroupSerializer.SerializeGroup((Hl7.Fhir.Model.Group)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.ImagingStudy))
                ImagingStudySerializer.SerializeImagingStudy((Hl7.Fhir.Model.ImagingStudy)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Immunization))
                ImmunizationSerializer.SerializeImmunization((Hl7.Fhir.Model.Immunization)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.ImmunizationProfile))
                ImmunizationProfileSerializer.SerializeImmunizationProfile((Hl7.Fhir.Model.ImmunizationProfile)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.List))
                ListSerializer.SerializeList((Hl7.Fhir.Model.List)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Location))
                LocationSerializer.SerializeLocation((Hl7.Fhir.Model.Location)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Media))
                MediaSerializer.SerializeMedia((Hl7.Fhir.Model.Media)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Medication))
                MedicationSerializer.SerializeMedication((Hl7.Fhir.Model.Medication)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.MedicationAdministration))
                MedicationAdministrationSerializer.SerializeMedicationAdministration((Hl7.Fhir.Model.MedicationAdministration)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.MedicationDispense))
                MedicationDispenseSerializer.SerializeMedicationDispense((Hl7.Fhir.Model.MedicationDispense)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.MedicationPrescription))
                MedicationPrescriptionSerializer.SerializeMedicationPrescription((Hl7.Fhir.Model.MedicationPrescription)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.MedicationStatement))
                MedicationStatementSerializer.SerializeMedicationStatement((Hl7.Fhir.Model.MedicationStatement)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Message))
                MessageSerializer.SerializeMessage((Hl7.Fhir.Model.Message)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Observation))
                ObservationSerializer.SerializeObservation((Hl7.Fhir.Model.Observation)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.OperationOutcome))
                OperationOutcomeSerializer.SerializeOperationOutcome((Hl7.Fhir.Model.OperationOutcome)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Order))
                OrderSerializer.SerializeOrder((Hl7.Fhir.Model.Order)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.OrderResponse))
                OrderResponseSerializer.SerializeOrderResponse((Hl7.Fhir.Model.OrderResponse)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Organization))
                OrganizationSerializer.SerializeOrganization((Hl7.Fhir.Model.Organization)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Other))
                OtherSerializer.SerializeOther((Hl7.Fhir.Model.Other)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Patient))
                PatientSerializer.SerializePatient((Hl7.Fhir.Model.Patient)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Practitioner))
                PractitionerSerializer.SerializePractitioner((Hl7.Fhir.Model.Practitioner)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Procedure))
                ProcedureSerializer.SerializeProcedure((Hl7.Fhir.Model.Procedure)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Profile))
                ProfileSerializer.SerializeProfile((Hl7.Fhir.Model.Profile)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Provenance))
                ProvenanceSerializer.SerializeProvenance((Hl7.Fhir.Model.Provenance)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Query))
                QuerySerializer.SerializeQuery((Hl7.Fhir.Model.Query)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Questionnaire))
                QuestionnaireSerializer.SerializeQuestionnaire((Hl7.Fhir.Model.Questionnaire)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.RelatedPerson))
                RelatedPersonSerializer.SerializeRelatedPerson((Hl7.Fhir.Model.RelatedPerson)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.SecurityEvent))
                SecurityEventSerializer.SerializeSecurityEvent((Hl7.Fhir.Model.SecurityEvent)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Specimen))
                SpecimenSerializer.SerializeSpecimen((Hl7.Fhir.Model.Specimen)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Substance))
                SubstanceSerializer.SerializeSubstance((Hl7.Fhir.Model.Substance)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Supply))
                SupplySerializer.SerializeSupply((Hl7.Fhir.Model.Supply)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.ValueSet))
                ValueSetSerializer.SerializeValueSet((Hl7.Fhir.Model.ValueSet)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Binary))
                BinarySerializer.SerializeBinary((Hl7.Fhir.Model.Binary)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Appointment))
                AppointmentSerializer.SerializeAppointment((Hl7.Fhir.Model.Appointment)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.InterestOfCare))
                InterestOfCareSerializer.SerializeInterestOfCare((Hl7.Fhir.Model.InterestOfCare)value, writer, summary);
            else
                throw new Exception("Encountered unknown type " + value.GetType().Name);
        }
        
        
        internal static void SerializeElement(Element value, IFhirWriter writer, bool summary)
        {
            if(value.GetType() == typeof(Hl7.Fhir.Model.Address))
                AddressSerializer.SerializeAddress((Hl7.Fhir.Model.Address)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Attachment))
                AttachmentSerializer.SerializeAttachment((Hl7.Fhir.Model.Attachment)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Choice))
                ChoiceSerializer.SerializeChoice((Hl7.Fhir.Model.Choice)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.CodeableConcept))
                CodeableConceptSerializer.SerializeCodeableConcept((Hl7.Fhir.Model.CodeableConcept)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Coding))
                CodingSerializer.SerializeCoding((Hl7.Fhir.Model.Coding)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Contact))
                ContactSerializer.SerializeContact((Hl7.Fhir.Model.Contact)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Extension))
                ExtensionSerializer.SerializeExtension((Hl7.Fhir.Model.Extension)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.HumanName))
                HumanNameSerializer.SerializeHumanName((Hl7.Fhir.Model.HumanName)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Identifier))
                IdentifierSerializer.SerializeIdentifier((Hl7.Fhir.Model.Identifier)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Narrative))
                NarrativeSerializer.SerializeNarrative((Hl7.Fhir.Model.Narrative)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Period))
                PeriodSerializer.SerializePeriod((Hl7.Fhir.Model.Period)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Quantity))
                QuantitySerializer.SerializeQuantity((Hl7.Fhir.Model.Quantity)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Range))
                RangeSerializer.SerializeRange((Hl7.Fhir.Model.Range)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Ratio))
                RatioSerializer.SerializeRatio((Hl7.Fhir.Model.Ratio)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.ResourceReference))
                ResourceReferenceSerializer.SerializeResourceReference((Hl7.Fhir.Model.ResourceReference)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.SampledData))
                SampledDataSerializer.SerializeSampledData((Hl7.Fhir.Model.SampledData)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Schedule))
                ScheduleSerializer.SerializeSchedule((Hl7.Fhir.Model.Schedule)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Base64Binary))
                Base64BinarySerializer.SerializeBase64Binary((Hl7.Fhir.Model.Base64Binary)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.FhirBoolean))
                FhirBooleanSerializer.SerializeFhirBoolean((Hl7.Fhir.Model.FhirBoolean)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Code))
                CodeSerializer.SerializeCode((Hl7.Fhir.Model.Code)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Date))
                DateSerializer.SerializeDate((Hl7.Fhir.Model.Date)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.FhirDateTime))
                FhirDateTimeSerializer.SerializeFhirDateTime((Hl7.Fhir.Model.FhirDateTime)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.FhirDecimal))
                FhirDecimalSerializer.SerializeFhirDecimal((Hl7.Fhir.Model.FhirDecimal)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Id))
                IdSerializer.SerializeId((Hl7.Fhir.Model.Id)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.IdRef))
                IdRefSerializer.SerializeIdRef((Hl7.Fhir.Model.IdRef)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Instant))
                InstantSerializer.SerializeInstant((Hl7.Fhir.Model.Instant)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Integer))
                IntegerSerializer.SerializeInteger((Hl7.Fhir.Model.Integer)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Oid))
                OidSerializer.SerializeOid((Hl7.Fhir.Model.Oid)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.FhirString))
                FhirStringSerializer.SerializeFhirString((Hl7.Fhir.Model.FhirString)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.FhirUri))
                FhirUriSerializer.SerializeFhirUri((Hl7.Fhir.Model.FhirUri)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Uuid))
                UuidSerializer.SerializeUuid((Hl7.Fhir.Model.Uuid)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.XHtml))
                XHtmlSerializer.SerializeXHtml((Hl7.Fhir.Model.XHtml)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Age))
                QuantitySerializer.SerializeQuantity((Hl7.Fhir.Model.Age)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Count))
                QuantitySerializer.SerializeQuantity((Hl7.Fhir.Model.Count)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Distance))
                QuantitySerializer.SerializeQuantity((Hl7.Fhir.Model.Distance)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Duration))
                QuantitySerializer.SerializeQuantity((Hl7.Fhir.Model.Duration)value, writer, summary);
            else if(value.GetType() == typeof(Hl7.Fhir.Model.Money))
                QuantitySerializer.SerializeQuantity((Hl7.Fhir.Model.Money)value, writer, summary);
            else
                throw new Exception("Encountered unknown type " + value.GetType().Name);
        }
        
    }
}
