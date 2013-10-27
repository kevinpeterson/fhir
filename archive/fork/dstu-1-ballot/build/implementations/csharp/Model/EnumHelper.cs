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
namespace Hl7.Fhir.Model
{
    public static class EnumHelper
    {
        public static bool TryParseEnum(string value, Type enumType, out object result)
        {
            if(enumType == typeof(Hl7.Fhir.Model.DataAbsentReason))
            {
                Hl7.Fhir.Model.DataAbsentReason res;
                bool success = Hl7.Fhir.Model.DataAbsentReasonHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.ObservationStatus))
            {
                Hl7.Fhir.Model.ObservationStatus res;
                bool success = Hl7.Fhir.Model.ObservationStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.SpecialValues))
            {
                Hl7.Fhir.Model.SpecialValues res;
                bool success = Hl7.Fhir.Model.SpecialValuesHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.ResourceType))
            {
                Hl7.Fhir.Model.ResourceType res;
                bool success = Hl7.Fhir.Model.ResourceTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Address.AddressUse))
            {
                Hl7.Fhir.Model.Address.AddressUse res;
                bool success = Hl7.Fhir.Model.Address.AddressUseHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Contact.ContactSystem))
            {
                Hl7.Fhir.Model.Contact.ContactSystem res;
                bool success = Hl7.Fhir.Model.Contact.ContactSystemHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Contact.ContactUse))
            {
                Hl7.Fhir.Model.Contact.ContactUse res;
                bool success = Hl7.Fhir.Model.Contact.ContactUseHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.HumanName.NameUse))
            {
                Hl7.Fhir.Model.HumanName.NameUse res;
                bool success = Hl7.Fhir.Model.HumanName.NameUseHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Identifier.IdentifierUse))
            {
                Hl7.Fhir.Model.Identifier.IdentifierUse res;
                bool success = Hl7.Fhir.Model.Identifier.IdentifierUseHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Narrative.NarrativeStatus))
            {
                Hl7.Fhir.Model.Narrative.NarrativeStatus res;
                bool success = Hl7.Fhir.Model.Narrative.NarrativeStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Quantity.QuantityCompararator))
            {
                Hl7.Fhir.Model.Quantity.QuantityCompararator res;
                bool success = Hl7.Fhir.Model.Quantity.QuantityCompararatorHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Schedule.UnitsOfTime))
            {
                Hl7.Fhir.Model.Schedule.UnitsOfTime res;
                bool success = Hl7.Fhir.Model.Schedule.UnitsOfTimeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Schedule.EventTiming))
            {
                Hl7.Fhir.Model.Schedule.EventTiming res;
                bool success = Hl7.Fhir.Model.Schedule.EventTimingHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.AdverseReaction.ReactionSeverity))
            {
                Hl7.Fhir.Model.AdverseReaction.ReactionSeverity res;
                bool success = Hl7.Fhir.Model.AdverseReaction.ReactionSeverityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.AdverseReaction.ExposureType))
            {
                Hl7.Fhir.Model.AdverseReaction.ExposureType res;
                bool success = Hl7.Fhir.Model.AdverseReaction.ExposureTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.AdverseReaction.CausalityExpectation))
            {
                Hl7.Fhir.Model.AdverseReaction.CausalityExpectation res;
                bool success = Hl7.Fhir.Model.AdverseReaction.CausalityExpectationHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Alert.AlertStatus))
            {
                Hl7.Fhir.Model.Alert.AlertStatus res;
                bool success = Hl7.Fhir.Model.Alert.AlertStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.AllergyIntolerance.SensitivityStatus))
            {
                Hl7.Fhir.Model.AllergyIntolerance.SensitivityStatus res;
                bool success = Hl7.Fhir.Model.AllergyIntolerance.SensitivityStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.AllergyIntolerance.Criticality))
            {
                Hl7.Fhir.Model.AllergyIntolerance.Criticality res;
                bool success = Hl7.Fhir.Model.AllergyIntolerance.CriticalityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.AllergyIntolerance.SensitivityType))
            {
                Hl7.Fhir.Model.AllergyIntolerance.SensitivityType res;
                bool success = Hl7.Fhir.Model.AllergyIntolerance.SensitivityTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.CarePlan.CarePlanStatus))
            {
                Hl7.Fhir.Model.CarePlan.CarePlanStatus res;
                bool success = Hl7.Fhir.Model.CarePlan.CarePlanStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.CarePlan.CarePlanActivityCategory))
            {
                Hl7.Fhir.Model.CarePlan.CarePlanActivityCategory res;
                bool success = Hl7.Fhir.Model.CarePlan.CarePlanActivityCategoryHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.CarePlan.CarePlanGoalStatus))
            {
                Hl7.Fhir.Model.CarePlan.CarePlanGoalStatus res;
                bool success = Hl7.Fhir.Model.CarePlan.CarePlanGoalStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus))
            {
                Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus res;
                bool success = Hl7.Fhir.Model.CarePlan.CarePlanActivityStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Condition.ConditionStatus))
            {
                Hl7.Fhir.Model.Condition.ConditionStatus res;
                bool success = Hl7.Fhir.Model.Condition.ConditionStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Condition.ConditionRelationshipType))
            {
                Hl7.Fhir.Model.Condition.ConditionRelationshipType res;
                bool success = Hl7.Fhir.Model.Condition.ConditionRelationshipTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.RestfulOperation))
            {
                Hl7.Fhir.Model.Conformance.RestfulOperation res;
                bool success = Hl7.Fhir.Model.Conformance.RestfulOperationHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.DocumentMode))
            {
                Hl7.Fhir.Model.Conformance.DocumentMode res;
                bool success = Hl7.Fhir.Model.Conformance.DocumentModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.RestfulConformanceMode))
            {
                Hl7.Fhir.Model.Conformance.RestfulConformanceMode res;
                bool success = Hl7.Fhir.Model.Conformance.RestfulConformanceModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.MessageTransport))
            {
                Hl7.Fhir.Model.Conformance.MessageTransport res;
                bool success = Hl7.Fhir.Model.Conformance.MessageTransportHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.ConformanceEventMode))
            {
                Hl7.Fhir.Model.Conformance.ConformanceEventMode res;
                bool success = Hl7.Fhir.Model.Conformance.ConformanceEventModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.ConformanceStatementStatus))
            {
                Hl7.Fhir.Model.Conformance.ConformanceStatementStatus res;
                bool success = Hl7.Fhir.Model.Conformance.ConformanceStatementStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.SearchParamType))
            {
                Hl7.Fhir.Model.Conformance.SearchParamType res;
                bool success = Hl7.Fhir.Model.Conformance.SearchParamTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.RestfulSecurityService))
            {
                Hl7.Fhir.Model.Conformance.RestfulSecurityService res;
                bool success = Hl7.Fhir.Model.Conformance.RestfulSecurityServiceHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.DeviceCapabilities.DeviceDataType))
            {
                Hl7.Fhir.Model.DeviceCapabilities.DeviceDataType res;
                bool success = Hl7.Fhir.Model.DeviceCapabilities.DeviceDataTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.DeviceLog.DeviceValueFlag))
            {
                Hl7.Fhir.Model.DeviceLog.DeviceValueFlag res;
                bool success = Hl7.Fhir.Model.DeviceLog.DeviceValueFlagHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus))
            {
                Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus res;
                bool success = Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriority))
            {
                Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriority res;
                bool success = Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriorityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Document.DocumentAttestationMode))
            {
                Hl7.Fhir.Model.Document.DocumentAttestationMode res;
                bool success = Hl7.Fhir.Model.Document.DocumentAttestationModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Document.DocumentStatus))
            {
                Hl7.Fhir.Model.Document.DocumentStatus res;
                bool success = Hl7.Fhir.Model.Document.DocumentStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatus))
            {
                Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatus res;
                bool success = Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Encounter.EncounterClass))
            {
                Hl7.Fhir.Model.Encounter.EncounterClass res;
                bool success = Hl7.Fhir.Model.Encounter.EncounterClassHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Encounter.ParticipantType))
            {
                Hl7.Fhir.Model.Encounter.ParticipantType res;
                bool success = Hl7.Fhir.Model.Encounter.ParticipantTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Encounter.EncounterState))
            {
                Hl7.Fhir.Model.Encounter.EncounterState res;
                bool success = Hl7.Fhir.Model.Encounter.EncounterStateHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.FamilyHistory.FamilialRelationship))
            {
                Hl7.Fhir.Model.FamilyHistory.FamilialRelationship res;
                bool success = Hl7.Fhir.Model.FamilyHistory.FamilialRelationshipHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Group.GroupType))
            {
                Hl7.Fhir.Model.Group.GroupType res;
                bool success = Hl7.Fhir.Model.Group.GroupTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.ImagingStudy.ImagingModality))
            {
                Hl7.Fhir.Model.ImagingStudy.ImagingModality res;
                bool success = Hl7.Fhir.Model.ImagingStudy.ImagingModalityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.ImagingStudy.InstanceAvailability))
            {
                Hl7.Fhir.Model.ImagingStudy.InstanceAvailability res;
                bool success = Hl7.Fhir.Model.ImagingStudy.InstanceAvailabilityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.ImagingStudy.Modality))
            {
                Hl7.Fhir.Model.ImagingStudy.Modality res;
                bool success = Hl7.Fhir.Model.ImagingStudy.ModalityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatus))
            {
                Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatus res;
                bool success = Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.List.ListMode))
            {
                Hl7.Fhir.Model.List.ListMode res;
                bool success = Hl7.Fhir.Model.List.ListModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Media.MediaType))
            {
                Hl7.Fhir.Model.Media.MediaType res;
                bool success = Hl7.Fhir.Model.Media.MediaTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Medication.MedicationKind))
            {
                Hl7.Fhir.Model.Medication.MedicationKind res;
                bool success = Hl7.Fhir.Model.Medication.MedicationKindHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatus))
            {
                Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatus res;
                bool success = Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus))
            {
                Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus res;
                bool success = Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatus))
            {
                Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatus res;
                bool success = Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Message.ResponseCode))
            {
                Hl7.Fhir.Model.Message.ResponseCode res;
                bool success = Hl7.Fhir.Model.Message.ResponseCodeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Observation.ObservationReliability))
            {
                Hl7.Fhir.Model.Observation.ObservationReliability res;
                bool success = Hl7.Fhir.Model.Observation.ObservationReliabilityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.OperationOutcome.IssueType))
            {
                Hl7.Fhir.Model.OperationOutcome.IssueType res;
                bool success = Hl7.Fhir.Model.OperationOutcome.IssueTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.OperationOutcome.IssueSeverity))
            {
                Hl7.Fhir.Model.OperationOutcome.IssueSeverity res;
                bool success = Hl7.Fhir.Model.OperationOutcome.IssueSeverityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.OrderResponse.OrderOutcomeCode))
            {
                Hl7.Fhir.Model.OrderResponse.OrderOutcomeCode res;
                bool success = Hl7.Fhir.Model.OrderResponse.OrderOutcomeCodeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Procedure.ProcedureRelationshipType))
            {
                Hl7.Fhir.Model.Procedure.ProcedureRelationshipType res;
                bool success = Hl7.Fhir.Model.Procedure.ProcedureRelationshipTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Profile.BindingConformance))
            {
                Hl7.Fhir.Model.Profile.BindingConformance res;
                bool success = Hl7.Fhir.Model.Profile.BindingConformanceHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Profile.ConstraintSeverity))
            {
                Hl7.Fhir.Model.Profile.ConstraintSeverity res;
                bool success = Hl7.Fhir.Model.Profile.ConstraintSeverityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Profile.ResourceProfileStatus))
            {
                Hl7.Fhir.Model.Profile.ResourceProfileStatus res;
                bool success = Hl7.Fhir.Model.Profile.ResourceProfileStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Profile.ExtensionContext))
            {
                Hl7.Fhir.Model.Profile.ExtensionContext res;
                bool success = Hl7.Fhir.Model.Profile.ExtensionContextHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Profile.SlicingRules))
            {
                Hl7.Fhir.Model.Profile.SlicingRules res;
                bool success = Hl7.Fhir.Model.Profile.SlicingRulesHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Provenance.ProvenanceEntityRole))
            {
                Hl7.Fhir.Model.Provenance.ProvenanceEntityRole res;
                bool success = Hl7.Fhir.Model.Provenance.ProvenanceEntityRoleHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Query.QueryOutcome))
            {
                Hl7.Fhir.Model.Query.QueryOutcome res;
                bool success = Hl7.Fhir.Model.Query.QueryOutcomeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventAction))
            {
                Hl7.Fhir.Model.SecurityEvent.SecurityEventAction res;
                bool success = Hl7.Fhir.Model.SecurityEvent.SecurityEventActionHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkType))
            {
                Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkType res;
                bool success = Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRole))
            {
                Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRole res;
                bool success = Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRoleHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectType))
            {
                Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectType res;
                bool success = Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycle))
            {
                Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycle res;
                bool success = Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycleHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcome))
            {
                Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcome res;
                bool success = Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcomeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.Specimen.HierarchicalRelationshipType))
            {
                Hl7.Fhir.Model.Specimen.HierarchicalRelationshipType res;
                bool success = Hl7.Fhir.Model.Specimen.HierarchicalRelationshipTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.ValueSet.CodeSelectionMode))
            {
                Hl7.Fhir.Model.ValueSet.CodeSelectionMode res;
                bool success = Hl7.Fhir.Model.ValueSet.CodeSelectionModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.ValueSet.ValueSetStatus))
            {
                Hl7.Fhir.Model.ValueSet.ValueSetStatus res;
                bool success = Hl7.Fhir.Model.ValueSet.ValueSetStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Hl7.Fhir.Model.ValueSet.FilterOperator))
            {
                Hl7.Fhir.Model.ValueSet.FilterOperator res;
                bool success = Hl7.Fhir.Model.ValueSet.FilterOperatorHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else
            {
                result = null;
                return false;
            }
            
        }
        
        public static string EnumToString(object value, Type enumType)
        {
            if(enumType == typeof(Hl7.Fhir.Model.DataAbsentReason))
                return Hl7.Fhir.Model.DataAbsentReasonHandling.ToString((Hl7.Fhir.Model.DataAbsentReason)value);
            else if(enumType == typeof(Hl7.Fhir.Model.ObservationStatus))
                return Hl7.Fhir.Model.ObservationStatusHandling.ToString((Hl7.Fhir.Model.ObservationStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.SpecialValues))
                return Hl7.Fhir.Model.SpecialValuesHandling.ToString((Hl7.Fhir.Model.SpecialValues)value);
            else if(enumType == typeof(Hl7.Fhir.Model.ResourceType))
                return Hl7.Fhir.Model.ResourceTypeHandling.ToString((Hl7.Fhir.Model.ResourceType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Address.AddressUse))
                return Hl7.Fhir.Model.Address.AddressUseHandling.ToString((Hl7.Fhir.Model.Address.AddressUse)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Contact.ContactSystem))
                return Hl7.Fhir.Model.Contact.ContactSystemHandling.ToString((Hl7.Fhir.Model.Contact.ContactSystem)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Contact.ContactUse))
                return Hl7.Fhir.Model.Contact.ContactUseHandling.ToString((Hl7.Fhir.Model.Contact.ContactUse)value);
            else if(enumType == typeof(Hl7.Fhir.Model.HumanName.NameUse))
                return Hl7.Fhir.Model.HumanName.NameUseHandling.ToString((Hl7.Fhir.Model.HumanName.NameUse)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Identifier.IdentifierUse))
                return Hl7.Fhir.Model.Identifier.IdentifierUseHandling.ToString((Hl7.Fhir.Model.Identifier.IdentifierUse)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Narrative.NarrativeStatus))
                return Hl7.Fhir.Model.Narrative.NarrativeStatusHandling.ToString((Hl7.Fhir.Model.Narrative.NarrativeStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Quantity.QuantityCompararator))
                return Hl7.Fhir.Model.Quantity.QuantityCompararatorHandling.ToString((Hl7.Fhir.Model.Quantity.QuantityCompararator)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Schedule.UnitsOfTime))
                return Hl7.Fhir.Model.Schedule.UnitsOfTimeHandling.ToString((Hl7.Fhir.Model.Schedule.UnitsOfTime)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Schedule.EventTiming))
                return Hl7.Fhir.Model.Schedule.EventTimingHandling.ToString((Hl7.Fhir.Model.Schedule.EventTiming)value);
            else if(enumType == typeof(Hl7.Fhir.Model.AdverseReaction.ReactionSeverity))
                return Hl7.Fhir.Model.AdverseReaction.ReactionSeverityHandling.ToString((Hl7.Fhir.Model.AdverseReaction.ReactionSeverity)value);
            else if(enumType == typeof(Hl7.Fhir.Model.AdverseReaction.ExposureType))
                return Hl7.Fhir.Model.AdverseReaction.ExposureTypeHandling.ToString((Hl7.Fhir.Model.AdverseReaction.ExposureType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.AdverseReaction.CausalityExpectation))
                return Hl7.Fhir.Model.AdverseReaction.CausalityExpectationHandling.ToString((Hl7.Fhir.Model.AdverseReaction.CausalityExpectation)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Alert.AlertStatus))
                return Hl7.Fhir.Model.Alert.AlertStatusHandling.ToString((Hl7.Fhir.Model.Alert.AlertStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.AllergyIntolerance.SensitivityStatus))
                return Hl7.Fhir.Model.AllergyIntolerance.SensitivityStatusHandling.ToString((Hl7.Fhir.Model.AllergyIntolerance.SensitivityStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.AllergyIntolerance.Criticality))
                return Hl7.Fhir.Model.AllergyIntolerance.CriticalityHandling.ToString((Hl7.Fhir.Model.AllergyIntolerance.Criticality)value);
            else if(enumType == typeof(Hl7.Fhir.Model.AllergyIntolerance.SensitivityType))
                return Hl7.Fhir.Model.AllergyIntolerance.SensitivityTypeHandling.ToString((Hl7.Fhir.Model.AllergyIntolerance.SensitivityType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.CarePlan.CarePlanStatus))
                return Hl7.Fhir.Model.CarePlan.CarePlanStatusHandling.ToString((Hl7.Fhir.Model.CarePlan.CarePlanStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.CarePlan.CarePlanActivityCategory))
                return Hl7.Fhir.Model.CarePlan.CarePlanActivityCategoryHandling.ToString((Hl7.Fhir.Model.CarePlan.CarePlanActivityCategory)value);
            else if(enumType == typeof(Hl7.Fhir.Model.CarePlan.CarePlanGoalStatus))
                return Hl7.Fhir.Model.CarePlan.CarePlanGoalStatusHandling.ToString((Hl7.Fhir.Model.CarePlan.CarePlanGoalStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus))
                return Hl7.Fhir.Model.CarePlan.CarePlanActivityStatusHandling.ToString((Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Condition.ConditionStatus))
                return Hl7.Fhir.Model.Condition.ConditionStatusHandling.ToString((Hl7.Fhir.Model.Condition.ConditionStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Condition.ConditionRelationshipType))
                return Hl7.Fhir.Model.Condition.ConditionRelationshipTypeHandling.ToString((Hl7.Fhir.Model.Condition.ConditionRelationshipType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.RestfulOperation))
                return Hl7.Fhir.Model.Conformance.RestfulOperationHandling.ToString((Hl7.Fhir.Model.Conformance.RestfulOperation)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.DocumentMode))
                return Hl7.Fhir.Model.Conformance.DocumentModeHandling.ToString((Hl7.Fhir.Model.Conformance.DocumentMode)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.RestfulConformanceMode))
                return Hl7.Fhir.Model.Conformance.RestfulConformanceModeHandling.ToString((Hl7.Fhir.Model.Conformance.RestfulConformanceMode)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.MessageTransport))
                return Hl7.Fhir.Model.Conformance.MessageTransportHandling.ToString((Hl7.Fhir.Model.Conformance.MessageTransport)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.ConformanceEventMode))
                return Hl7.Fhir.Model.Conformance.ConformanceEventModeHandling.ToString((Hl7.Fhir.Model.Conformance.ConformanceEventMode)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.ConformanceStatementStatus))
                return Hl7.Fhir.Model.Conformance.ConformanceStatementStatusHandling.ToString((Hl7.Fhir.Model.Conformance.ConformanceStatementStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.SearchParamType))
                return Hl7.Fhir.Model.Conformance.SearchParamTypeHandling.ToString((Hl7.Fhir.Model.Conformance.SearchParamType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Conformance.RestfulSecurityService))
                return Hl7.Fhir.Model.Conformance.RestfulSecurityServiceHandling.ToString((Hl7.Fhir.Model.Conformance.RestfulSecurityService)value);
            else if(enumType == typeof(Hl7.Fhir.Model.DeviceCapabilities.DeviceDataType))
                return Hl7.Fhir.Model.DeviceCapabilities.DeviceDataTypeHandling.ToString((Hl7.Fhir.Model.DeviceCapabilities.DeviceDataType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.DeviceLog.DeviceValueFlag))
                return Hl7.Fhir.Model.DeviceLog.DeviceValueFlagHandling.ToString((Hl7.Fhir.Model.DeviceLog.DeviceValueFlag)value);
            else if(enumType == typeof(Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus))
                return Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatusHandling.ToString((Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriority))
                return Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriorityHandling.ToString((Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriority)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Document.DocumentAttestationMode))
                return Hl7.Fhir.Model.Document.DocumentAttestationModeHandling.ToString((Hl7.Fhir.Model.Document.DocumentAttestationMode)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Document.DocumentStatus))
                return Hl7.Fhir.Model.Document.DocumentStatusHandling.ToString((Hl7.Fhir.Model.Document.DocumentStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatus))
                return Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatusHandling.ToString((Hl7.Fhir.Model.DocumentReference.DocumentReferenceStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Encounter.EncounterClass))
                return Hl7.Fhir.Model.Encounter.EncounterClassHandling.ToString((Hl7.Fhir.Model.Encounter.EncounterClass)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Encounter.ParticipantType))
                return Hl7.Fhir.Model.Encounter.ParticipantTypeHandling.ToString((Hl7.Fhir.Model.Encounter.ParticipantType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Encounter.EncounterState))
                return Hl7.Fhir.Model.Encounter.EncounterStateHandling.ToString((Hl7.Fhir.Model.Encounter.EncounterState)value);
            else if(enumType == typeof(Hl7.Fhir.Model.FamilyHistory.FamilialRelationship))
                return Hl7.Fhir.Model.FamilyHistory.FamilialRelationshipHandling.ToString((Hl7.Fhir.Model.FamilyHistory.FamilialRelationship)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Group.GroupType))
                return Hl7.Fhir.Model.Group.GroupTypeHandling.ToString((Hl7.Fhir.Model.Group.GroupType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.ImagingStudy.ImagingModality))
                return Hl7.Fhir.Model.ImagingStudy.ImagingModalityHandling.ToString((Hl7.Fhir.Model.ImagingStudy.ImagingModality)value);
            else if(enumType == typeof(Hl7.Fhir.Model.ImagingStudy.InstanceAvailability))
                return Hl7.Fhir.Model.ImagingStudy.InstanceAvailabilityHandling.ToString((Hl7.Fhir.Model.ImagingStudy.InstanceAvailability)value);
            else if(enumType == typeof(Hl7.Fhir.Model.ImagingStudy.Modality))
                return Hl7.Fhir.Model.ImagingStudy.ModalityHandling.ToString((Hl7.Fhir.Model.ImagingStudy.Modality)value);
            else if(enumType == typeof(Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatus))
                return Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatusHandling.ToString((Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.List.ListMode))
                return Hl7.Fhir.Model.List.ListModeHandling.ToString((Hl7.Fhir.Model.List.ListMode)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Media.MediaType))
                return Hl7.Fhir.Model.Media.MediaTypeHandling.ToString((Hl7.Fhir.Model.Media.MediaType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Medication.MedicationKind))
                return Hl7.Fhir.Model.Medication.MedicationKindHandling.ToString((Hl7.Fhir.Model.Medication.MedicationKind)value);
            else if(enumType == typeof(Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatus))
                return Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatusHandling.ToString((Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus))
                return Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatusHandling.ToString((Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatus))
                return Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatusHandling.ToString((Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Message.ResponseCode))
                return Hl7.Fhir.Model.Message.ResponseCodeHandling.ToString((Hl7.Fhir.Model.Message.ResponseCode)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Observation.ObservationReliability))
                return Hl7.Fhir.Model.Observation.ObservationReliabilityHandling.ToString((Hl7.Fhir.Model.Observation.ObservationReliability)value);
            else if(enumType == typeof(Hl7.Fhir.Model.OperationOutcome.IssueType))
                return Hl7.Fhir.Model.OperationOutcome.IssueTypeHandling.ToString((Hl7.Fhir.Model.OperationOutcome.IssueType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.OperationOutcome.IssueSeverity))
                return Hl7.Fhir.Model.OperationOutcome.IssueSeverityHandling.ToString((Hl7.Fhir.Model.OperationOutcome.IssueSeverity)value);
            else if(enumType == typeof(Hl7.Fhir.Model.OrderResponse.OrderOutcomeCode))
                return Hl7.Fhir.Model.OrderResponse.OrderOutcomeCodeHandling.ToString((Hl7.Fhir.Model.OrderResponse.OrderOutcomeCode)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Procedure.ProcedureRelationshipType))
                return Hl7.Fhir.Model.Procedure.ProcedureRelationshipTypeHandling.ToString((Hl7.Fhir.Model.Procedure.ProcedureRelationshipType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Profile.BindingConformance))
                return Hl7.Fhir.Model.Profile.BindingConformanceHandling.ToString((Hl7.Fhir.Model.Profile.BindingConformance)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Profile.ConstraintSeverity))
                return Hl7.Fhir.Model.Profile.ConstraintSeverityHandling.ToString((Hl7.Fhir.Model.Profile.ConstraintSeverity)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Profile.ResourceProfileStatus))
                return Hl7.Fhir.Model.Profile.ResourceProfileStatusHandling.ToString((Hl7.Fhir.Model.Profile.ResourceProfileStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Profile.ExtensionContext))
                return Hl7.Fhir.Model.Profile.ExtensionContextHandling.ToString((Hl7.Fhir.Model.Profile.ExtensionContext)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Profile.SlicingRules))
                return Hl7.Fhir.Model.Profile.SlicingRulesHandling.ToString((Hl7.Fhir.Model.Profile.SlicingRules)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Provenance.ProvenanceEntityRole))
                return Hl7.Fhir.Model.Provenance.ProvenanceEntityRoleHandling.ToString((Hl7.Fhir.Model.Provenance.ProvenanceEntityRole)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Query.QueryOutcome))
                return Hl7.Fhir.Model.Query.QueryOutcomeHandling.ToString((Hl7.Fhir.Model.Query.QueryOutcome)value);
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventAction))
                return Hl7.Fhir.Model.SecurityEvent.SecurityEventActionHandling.ToString((Hl7.Fhir.Model.SecurityEvent.SecurityEventAction)value);
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkType))
                return Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkTypeHandling.ToString((Hl7.Fhir.Model.SecurityEvent.SecurityEventParticipantNetworkType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRole))
                return Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRoleHandling.ToString((Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectRole)value);
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectType))
                return Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectTypeHandling.ToString((Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycle))
                return Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycleHandling.ToString((Hl7.Fhir.Model.SecurityEvent.SecurityEventObjectLifecycle)value);
            else if(enumType == typeof(Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcome))
                return Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcomeHandling.ToString((Hl7.Fhir.Model.SecurityEvent.SecurityEventOutcome)value);
            else if(enumType == typeof(Hl7.Fhir.Model.Specimen.HierarchicalRelationshipType))
                return Hl7.Fhir.Model.Specimen.HierarchicalRelationshipTypeHandling.ToString((Hl7.Fhir.Model.Specimen.HierarchicalRelationshipType)value);
            else if(enumType == typeof(Hl7.Fhir.Model.ValueSet.CodeSelectionMode))
                return Hl7.Fhir.Model.ValueSet.CodeSelectionModeHandling.ToString((Hl7.Fhir.Model.ValueSet.CodeSelectionMode)value);
            else if(enumType == typeof(Hl7.Fhir.Model.ValueSet.ValueSetStatus))
                return Hl7.Fhir.Model.ValueSet.ValueSetStatusHandling.ToString((Hl7.Fhir.Model.ValueSet.ValueSetStatus)value);
            else if(enumType == typeof(Hl7.Fhir.Model.ValueSet.FilterOperator))
                return Hl7.Fhir.Model.ValueSet.FilterOperatorHandling.ToString((Hl7.Fhir.Model.ValueSet.FilterOperator)value);
            else
                throw new ArgumentException("Unrecognized enumeration " + enumType.Name);
            
        }
    }
}
