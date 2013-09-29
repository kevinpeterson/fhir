{!Wrapper uses FHIRBase, FHIRBase_Wrapper, FHIRTypes, FHIRTypes_Wrapper, FHIRComponents, FHIRComponents_Wrapper, FHIRResources, FHIRResources_Wrapper, MSSEWrap, MSSEWrap_Wrapper}
{!ignore ALL_RESOURCE_TYPES}

unit FHIRConstants;

{
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
  
}

interface

// FHIR v0.11 generated Fri, Sep 6, 2013 23:03+1000

uses
  SysUtils, Classes, StringSupport, DecimalSupport, AdvBuffers, MSSEWrap, FHIRBase, FHIRTypes, FHIRComponents, FHIRResources;

Const
  CODES_TFhirResourceType : Array[TFhirResourceType] of String = ('', 'AdverseReaction', 'Alert', 'AllergyIntolerance', 'CarePlan', 'Condition', 'Conformance', 'Coverage', 'Device', 'DeviceCapabilities', 'DeviceLog', 'DeviceObservation', 'DiagnosticOrder', 'DiagnosticReport', 'Document', 'DocumentReference', 'Encounter', 'FamilyHistory', 'Group', 'ImagingStudy', 'Immunization', 'ImmunizationProfile', 'List', 'Location', 'Media', 'Medication', 'MedicationAdministration', 'MedicationDispense', 'MedicationPrescription', 'MedicationStatement', 'Message', 'Observation', 'OperationOutcome', 'Order', 'OrderResponse', 'Organization', 'Other', 'Patient', 'Practitioner', 'Procedure', 'Profile', 'Provenance', 'Query', 'Questionnaire', 'RelatedPerson', 'SecurityEvent', 'Specimen', 'Substance', 'Supply', 'ValueSet', 'Binary');
  PLURAL_CODES_TFhirResourceType : Array[TFhirResourceType] of String = ('', 'adversereactions', 'alerts', 'allergyintolerances', 'careplans', 'conditions', 'conformances', 'coverages', 'devices', 'devicecapabilities', 'devicelogs', 'deviceobservations', 'diagnosticorders', 'diagnosticreports', 'documents', 'documentreferences', 'encounters', 'familyhistories', 'groups', 'imagingstudies', 'immunizations', 'immunizationprofiles', 'lists', 'locations', 'media', 'medications', 'medicationadministrations', 'medicationdispenses', 'medicationprescriptions', 'medicationstatements', 'messages', 'observations', 'operationoutcomes', 'orders', 'orderresponses', 'organizations', 'others', 'patients', 'practitioners', 'procedures', 'profiles', 'provenances', 'queries', 'questionnaires', 'relatedpeople', 'securityevents', 'specimen', 'substances', 'supplies', 'valuesets', 'binaries');
  LOWERCASE_CODES_TFhirResourceType : Array[TFhirResourceType] of String = ('', 'adversereaction', 'alert', 'allergyintolerance', 'careplan', 'condition', 'conformance', 'coverage', 'device', 'devicecapabilities', 'devicelog', 'deviceobservation', 'diagnosticorder', 'diagnosticreport', 'document', 'documentreference', 'encounter', 'familyhistory', 'group', 'imagingstudy', 'immunization', 'immunizationprofile', 'list', 'location', 'media', 'medication', 'medicationadministration', 'medicationdispense', 'medicationprescription', 'medicationstatement', 'message', 'observation', 'operationoutcome', 'order', 'orderresponse', 'organization', 'other', 'patient', 'practitioner', 'procedure', 'profile', 'provenance', 'query', 'questionnaire', 'relatedperson', 'securityevent', 'specimen', 'substance', 'supply', 'valueset', 'binary');
  CLASSES_TFhirResourceType : Array[TFhirResourceType] of TFhirResourceClass = (nil, TFhirAdverseReaction, TFhirAlert, TFhirAllergyIntolerance, TFhirCarePlan, TFhirCondition, TFhirConformance, TFhirCoverage, TFhirDevice, TFhirDeviceCapabilities, TFhirDeviceLog, TFhirDeviceObservation, TFhirDiagnosticOrder, TFhirDiagnosticReport, TFhirDocument, TFhirDocumentReference, TFhirEncounter, TFhirFamilyHistory, TFhirGroup, TFhirImagingStudy, TFhirImmunization, TFhirImmunizationProfile, TFhirList, TFhirLocation, TFhirMedia, TFhirMedication, TFhirMedicationAdministration, TFhirMedicationDispense, TFhirMedicationPrescription, TFhirMedicationStatement, TFhirMessage, TFhirObservation, TFhirOperationOutcome, TFhirOrder, TFhirOrderResponse, TFhirOrganization, TFhirOther, TFhirPatient, TFhirPractitioner, TFhirProcedure, TFhirProfile, TFhirProvenance, TFhirQuery, TFhirQuestionnaire, TFhirRelatedPerson, TFhirSecurityEvent, TFhirSpecimen, TFhirSubstance, TFhirSupply, TFhirValueSet, TFhirBinary);
  ALL_RESOURCE_TYPES = [frtAdverseReaction, frtAlert, frtAllergyIntolerance, frtCarePlan, frtCondition, frtConformance, frtCoverage, frtDevice, frtDeviceCapabilities, frtDeviceLog, frtDeviceObservation, frtDiagnosticOrder, frtDiagnosticReport, frtDocument, frtDocumentReference, frtEncounter, frtFamilyHistory, frtGroup, frtImagingStudy, frtImmunization, frtImmunizationProfile, frtList, frtLocation, frtMedia, frtMedication, frtMedicationAdministration, frtMedicationDispense, frtMedicationPrescription, frtMedicationStatement, frtMessage, frtObservation, frtOperationOutcome, frtOrder, frtOrderResponse, frtOrganization, frtOther, frtPatient, frtPractitioner, frtProcedure, frtProfile, frtProvenance, frtQuery, frtQuestionnaire, frtRelatedPerson, frtSecurityEvent, frtSpecimen, frtSubstance, frtSupply, frtValueSet, frtBinary];


  COMPARTMENT_PARAM_NAMES : Array[TFhirResourceType, TFhirResourceType] of String = (('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', 'subject', 'subject', 'subject', 'subject', 'subject', '', 'subject', '', '', 'subject', 'subject', 'subject', 'subject', 'subject', 'subject', 'subject', 'subject', '', 'subject', 'subject', 'subject', 'item.subject | item.patient', '', 'subject', '', 'patient', 'patient', 'patient', 'patient', '', 'subject', '', 'subject', 'request.subject', '', 'patient', '{def}', '', 'subject', '', 'target.subject | target.patient', '', 'subject', 'patient', 'reference.subject | reference.patient', 'subject', '', 'patient', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''),
     ('', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''));

  CODES_TSearchParamsAdverseReaction : Array[TSearchParamsAdverseReaction] of String = ('_id', 'date', 'subject', 'substance', 'symptom');
  TYPES_TSearchParamsAdverseReaction : Array[TSearchParamsAdverseReaction] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsAdverseReaction : Array[TSearchParamsAdverseReaction] of TSearchParamsAdverseReaction = ( spAdverseReaction__id,  spAdverseReaction_Date,  spAdverseReaction_Subject,  spAdverseReaction_Substance,  spAdverseReaction_Symptom);
  PATHS_TSearchParamsAdverseReaction : Array[TSearchParamsAdverseReaction] of String = ('_id: []',
     'date: []',
     'subject: [frtPatient]',
     'substance: [frtSubstance]',
     'symptom: []');
  TARGETS_TSearchParamsAdverseReaction : Array[TSearchParamsAdverseReaction] of TFhirResourceTypeSet = ([], [], [frtPatient], [frtSubstance], []);
  CODES_TSearchParamsAlert : Array[TSearchParamsAlert] of String = ('_id', 'subject');
  TYPES_TSearchParamsAlert : Array[TSearchParamsAlert] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference);
//  CHECK_TSearchParamsAlert : Array[TSearchParamsAlert] of TSearchParamsAlert = ( spAlert__id,  spAlert_Subject);
  PATHS_TSearchParamsAlert : Array[TSearchParamsAlert] of String = ('_id: []',
     'subject: [frtPatient]');
  TARGETS_TSearchParamsAlert : Array[TSearchParamsAlert] of TFhirResourceTypeSet = ([], [frtPatient]);
  CODES_TSearchParamsAllergyIntolerance : Array[TSearchParamsAllergyIntolerance] of String = ('_id', 'date', 'recorder', 'status', 'subject', 'substance', 'type');
  TYPES_TSearchParamsAllergyIntolerance : Array[TSearchParamsAllergyIntolerance] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsAllergyIntolerance : Array[TSearchParamsAllergyIntolerance] of TSearchParamsAllergyIntolerance = ( spAllergyIntolerance__id,  spAllergyIntolerance_Date,  spAllergyIntolerance_Recorder,  spAllergyIntolerance_Status,  spAllergyIntolerance_Subject,  spAllergyIntolerance_Substance,  spAllergyIntolerance_Type);
  PATHS_TSearchParamsAllergyIntolerance : Array[TSearchParamsAllergyIntolerance] of String = ('_id: []',
     'date: []',
     'recorder: [frtPractitioner, frtPatient]',
     'status: []',
     'subject: [frtPatient]',
     'substance: [frtSubstance]',
     'type: []');
  TARGETS_TSearchParamsAllergyIntolerance : Array[TSearchParamsAllergyIntolerance] of TFhirResourceTypeSet = ([], [], [frtPractitioner, frtPatient], [], [frtPatient], [frtSubstance], []);
  CODES_TSearchParamsCarePlan : Array[TSearchParamsCarePlan] of String = ('_id', 'activity', 'activitydate', 'condition', 'date', 'participant', 'patient');
  TYPES_TSearchParamsCarePlan : Array[TSearchParamsCarePlan] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeReference);
//  CHECK_TSearchParamsCarePlan : Array[TSearchParamsCarePlan] of TSearchParamsCarePlan = ( spCarePlan__id,  spCarePlan_Activity,  spCarePlan_Activitydate,  spCarePlan_Condition,  spCarePlan_Date,  spCarePlan_Participant,  spCarePlan_Patient);
  PATHS_TSearchParamsCarePlan : Array[TSearchParamsCarePlan] of String = ('_id: []',
     'activity: []',
     'activitydate: []',
     'condition: [frtCondition]',
     'date: []',
     'participant: [frtPractitioner, frtRelatedPerson, frtPatient, frtOrganization]',
     'patient: [frtPatient]');
  TARGETS_TSearchParamsCarePlan : Array[TSearchParamsCarePlan] of TFhirResourceTypeSet = ([], [], [], [frtCondition], [], [frtPractitioner, frtRelatedPerson, frtPatient, frtOrganization], [frtPatient]);
  CODES_TSearchParamsCondition : Array[TSearchParamsCondition] of String = ('_id', 'asserter', 'category', 'code', 'date-asserted', 'encounter', 'evidence', 'location', 'onset', 'related-code', 'related-item', 'severity', 'stage', 'status', 'subject');
  TYPES_TSearchParamsCondition : Array[TSearchParamsCondition] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference);
//  CHECK_TSearchParamsCondition : Array[TSearchParamsCondition] of TSearchParamsCondition = ( spCondition__id,  spCondition_Asserter,  spCondition_Category,  spCondition_Code,  spCondition_Date_asserted,  spCondition_Encounter,  spCondition_Evidence,  spCondition_Location,  spCondition_Onset,  spCondition_Related_code,  spCondition_Related_item,  spCondition_Severity,  spCondition_Stage,  spCondition_Status,  spCondition_Subject);
  PATHS_TSearchParamsCondition : Array[TSearchParamsCondition] of String = ('_id: []',
     'asserter: [frtPractitioner, frtPatient]',
     'category: []',
     'code: []',
     'date-asserted: []',
     'encounter: [frtEncounter]',
     'evidence: []',
     'location: []',
     'onset: []',
     'related-code: []',
     'related-item: [frtCondition, frtProcedure, frtSubstance]',
     'severity: []',
     'stage: []',
     'status: []',
     'subject: [frtPatient]');
  TARGETS_TSearchParamsCondition : Array[TSearchParamsCondition] of TFhirResourceTypeSet = ([], [frtPractitioner, frtPatient], [], [], [], [frtEncounter], [], [], [], [], [frtCondition, frtProcedure, frtSubstance], [], [], [], [frtPatient]);
  CODES_TSearchParamsConformance : Array[TSearchParamsConformance] of String = ('_id', 'date', 'event', 'format', 'mode', 'profile', 'publisher', 'resource', 'security', 'software', 'version');
  TYPES_TSearchParamsConformance : Array[TSearchParamsConformance] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken);
//  CHECK_TSearchParamsConformance : Array[TSearchParamsConformance] of TSearchParamsConformance = ( spConformance__id,  spConformance_Date,  spConformance_Event,  spConformance_Format,  spConformance_Mode,  spConformance_Profile,  spConformance_Publisher,  spConformance_Resource,  spConformance_Security,  spConformance_Software,  spConformance_Version);
  PATHS_TSearchParamsConformance : Array[TSearchParamsConformance] of String = ('_id: []',
     'date: []',
     'event: []',
     'format: []',
     'mode: []',
     'profile: [frtProfile]',
     'publisher: []',
     'resource: []',
     'security: []',
     'software: []',
     'version: []');
  TARGETS_TSearchParamsConformance : Array[TSearchParamsConformance] of TFhirResourceTypeSet = ([], [], [], [], [], [frtProfile], [], [], [], [], []);
  CODES_TSearchParamsCoverage : Array[TSearchParamsCoverage] of String = ('_id', 'dependent', 'group', 'identifier', 'issuer', 'name', 'plan', 'sequence', 'subplan', 'type');
  TYPES_TSearchParamsCoverage : Array[TSearchParamsCoverage] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken);
//  CHECK_TSearchParamsCoverage : Array[TSearchParamsCoverage] of TSearchParamsCoverage = ( spCoverage__id,  spCoverage_Dependent,  spCoverage_Group,  spCoverage_Identifier,  spCoverage_Issuer,  spCoverage_Name,  spCoverage_Plan,  spCoverage_Sequence,  spCoverage_Subplan,  spCoverage_Type);
  PATHS_TSearchParamsCoverage : Array[TSearchParamsCoverage] of String = ('_id: []',
     'dependent: []',
     'group: []',
     'identifier: []',
     'issuer: [frtOrganization]',
     'name: []',
     'plan: []',
     'sequence: []',
     'subplan: []',
     'type: []');
  TARGETS_TSearchParamsCoverage : Array[TSearchParamsCoverage] of TFhirResourceTypeSet = ([], [], [], [], [frtOrganization], [], [], [], [], []);
  CODES_TSearchParamsDevice : Array[TSearchParamsDevice] of String = ('_id', 'assigned-id', 'location', 'manufacturer', 'model', 'organization', 'patient', 'serial', 'type');
  TYPES_TSearchParamsDevice : Array[TSearchParamsDevice] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeString,  SearchParamTypeString,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeString,  SearchParamTypeToken);
//  CHECK_TSearchParamsDevice : Array[TSearchParamsDevice] of TSearchParamsDevice = ( spDevice__id,  spDevice_Assigned_id,  spDevice_Location,  spDevice_Manufacturer,  spDevice_Model,  spDevice_Organization,  spDevice_Patient,  spDevice_Serial,  spDevice_Type);
  PATHS_TSearchParamsDevice : Array[TSearchParamsDevice] of String = ('_id: []',
     'assigned-id: []',
     'location: [frtLocation]',
     'manufacturer: []',
     'model: []',
     'organization: [frtOrganization]',
     'patient: [frtPatient]',
     'serial: []',
     'type: []');
  TARGETS_TSearchParamsDevice : Array[TSearchParamsDevice] of TFhirResourceTypeSet = ([], [], [frtLocation], [], [], [frtOrganization], [frtPatient], [], []);
  CODES_TSearchParamsDeviceCapabilities : Array[TSearchParamsDeviceCapabilities] of String = ('_id', 'channel', 'code', 'datatype', 'facet', 'identity', 'manufacturer', 'metric', 'name', 'type');
  TYPES_TSearchParamsDeviceCapabilities : Array[TSearchParamsDeviceCapabilities] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken);
//  CHECK_TSearchParamsDeviceCapabilities : Array[TSearchParamsDeviceCapabilities] of TSearchParamsDeviceCapabilities = ( spDeviceCapabilities__id,  spDeviceCapabilities_Channel,  spDeviceCapabilities_Code,  spDeviceCapabilities_Datatype,  spDeviceCapabilities_Facet,  spDeviceCapabilities_Identity,  spDeviceCapabilities_Manufacturer,  spDeviceCapabilities_Metric,  spDeviceCapabilities_Name,  spDeviceCapabilities_Type);
  PATHS_TSearchParamsDeviceCapabilities : Array[TSearchParamsDeviceCapabilities] of String = ('_id: []',
     'channel: []',
     'code: []',
     'datatype: []',
     'facet: []',
     'identity: [frtDevice]',
     'manufacturer: []',
     'metric: []',
     'name: []',
     'type: []');
  TARGETS_TSearchParamsDeviceCapabilities : Array[TSearchParamsDeviceCapabilities] of TFhirResourceTypeSet = ([], [], [], [], [], [frtDevice], [], [], [], []);
  CODES_TSearchParamsDeviceLog : Array[TSearchParamsDeviceLog] of String = ('_id', 'capabilities', 'flag', 'instant', 'key', 'subject', 'value');
  TYPES_TSearchParamsDeviceLog : Array[TSearchParamsDeviceLog] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsDeviceLog : Array[TSearchParamsDeviceLog] of TSearchParamsDeviceLog = ( spDeviceLog__id,  spDeviceLog_Capabilities,  spDeviceLog_Flag,  spDeviceLog_Instant,  spDeviceLog_Key,  spDeviceLog_Subject,  spDeviceLog_Value);
  PATHS_TSearchParamsDeviceLog : Array[TSearchParamsDeviceLog] of String = ('_id: []',
     'capabilities: [frtDeviceCapabilities]',
     'flag: []',
     'instant: []',
     'key: []',
     'subject: [frtPatient, frtGroup, frtDevice]',
     'value: []');
  TARGETS_TSearchParamsDeviceLog : Array[TSearchParamsDeviceLog] of TFhirResourceTypeSet = ([], [frtDeviceCapabilities], [], [], [], [frtPatient, frtGroup, frtDevice], []);
  CODES_TSearchParamsDeviceObservation : Array[TSearchParamsDeviceObservation] of String = ('_id', 'code', 'device', 'identifier', 'issued', 'measurement', 'subject');
  TYPES_TSearchParamsDeviceObservation : Array[TSearchParamsDeviceObservation] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeReference);
//  CHECK_TSearchParamsDeviceObservation : Array[TSearchParamsDeviceObservation] of TSearchParamsDeviceObservation = ( spDeviceObservation__id,  spDeviceObservation_Code,  spDeviceObservation_Device,  spDeviceObservation_Identifier,  spDeviceObservation_Issued,  spDeviceObservation_Measurement,  spDeviceObservation_Subject);
  PATHS_TSearchParamsDeviceObservation : Array[TSearchParamsDeviceObservation] of String = ('_id: []',
     'code: []',
     'device: [frtDevice]',
     'identifier: []',
     'issued: []',
     'measurement: [frtObservation]',
     'subject: [frtPatient, frtGroup, frtDevice]');
  TARGETS_TSearchParamsDeviceObservation : Array[TSearchParamsDeviceObservation] of TFhirResourceTypeSet = ([], [], [frtDevice], [], [], [frtObservation], [frtPatient, frtGroup, frtDevice]);
  CODES_TSearchParamsDiagnosticOrder : Array[TSearchParamsDiagnosticOrder] of String = ('_id', 'actor', 'bodysite', 'code', 'date', 'encounter', 'identifier', 'item-date', 'item-past-status', 'item-status', 'item-status-date', 'orderer', 'past-status', 'specimen', 'status', 'status-date', 'subject');
  TYPES_TSearchParamsDiagnosticOrder : Array[TSearchParamsDiagnosticOrder] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeComposite,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeComposite,  SearchParamTypeReference);
//  CHECK_TSearchParamsDiagnosticOrder : Array[TSearchParamsDiagnosticOrder] of TSearchParamsDiagnosticOrder = ( spDiagnosticOrder__id,  spDiagnosticOrder_Actor,  spDiagnosticOrder_Bodysite,  spDiagnosticOrder_Code,  spDiagnosticOrder_Date,  spDiagnosticOrder_Encounter,  spDiagnosticOrder_Identifier,  spDiagnosticOrder_Item_date,  spDiagnosticOrder_Item_past_status,  spDiagnosticOrder_Item_status,  spDiagnosticOrder_Item_status_date,  spDiagnosticOrder_Orderer,  spDiagnosticOrder_Past_status,  spDiagnosticOrder_Specimen,  spDiagnosticOrder_Status,  spDiagnosticOrder_Status_date,  spDiagnosticOrder_Subject);
  PATHS_TSearchParamsDiagnosticOrder : Array[TSearchParamsDiagnosticOrder] of String = ('_id: []',
     'actor: []',
     'bodysite: []',
     'code: []',
     'date: []',
     'encounter: [frtEncounter]',
     'identifier: []',
     'item-date: []',
     'item-past-status: []',
     'item-status: []',
     'item-status-date: []',
     'orderer: [frtPractitioner]',
     'past-status: []',
     'specimen: []',
     'status: []',
     'status-date: []',
     'subject: [frtPatient, frtGroup, frtLocation, frtDevice]');
  TARGETS_TSearchParamsDiagnosticOrder : Array[TSearchParamsDiagnosticOrder] of TFhirResourceTypeSet = ([], [], [], [], [], [frtEncounter], [], [], [], [], [], [frtPractitioner], [], [], [], [], [frtPatient, frtGroup, frtLocation, frtDevice]);
  CODES_TSearchParamsDiagnosticReport : Array[TSearchParamsDiagnosticReport] of String = ('_id', 'code', 'date', 'group', 'identifier', 'issued', 'name', 'performer', 'requester', 'result', 'service', 'specimen', 'status', 'subject', 'test');
  TYPES_TSearchParamsDiagnosticReport : Array[TSearchParamsDiagnosticReport] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsDiagnosticReport : Array[TSearchParamsDiagnosticReport] of TSearchParamsDiagnosticReport = ( spDiagnosticReport__id,  spDiagnosticReport_Code,  spDiagnosticReport_Date,  spDiagnosticReport_Group,  spDiagnosticReport_Identifier,  spDiagnosticReport_Issued,  spDiagnosticReport_Name,  spDiagnosticReport_Performer,  spDiagnosticReport_Requester,  spDiagnosticReport_Result,  spDiagnosticReport_Service,  spDiagnosticReport_Specimen,  spDiagnosticReport_Status,  spDiagnosticReport_Subject,  spDiagnosticReport_Test);
  PATHS_TSearchParamsDiagnosticReport : Array[TSearchParamsDiagnosticReport] of String = ('_id: []',
     'code: []',
     'date: []',
     'group: []',
     'identifier: []',
     'issued: []',
     'name: []',
     'performer: [frtOrganization]',
     'requester: [frtOrganization, frtPractitioner]',
     'result: [frtObservation]',
     'service: []',
     'specimen: [frtSpecimen]',
     'status: []',
     'subject: [frtPatient, frtGroup, frtDevice]',
     'test: []');
  TARGETS_TSearchParamsDiagnosticReport : Array[TSearchParamsDiagnosticReport] of TFhirResourceTypeSet = ([], [], [], [], [], [], [], [frtOrganization], [frtOrganization, frtPractitioner], [frtObservation], [], [frtSpecimen], [], [frtPatient, frtGroup, frtDevice], []);
  CODES_TSearchParamsDocument : Array[TSearchParamsDocument] of String = ('_id', 'attester', 'author', 'context', 'date', 'identifier', 'section-content', 'section-type', 'subject', 'type', 'version');
  TYPES_TSearchParamsDocument : Array[TSearchParamsDocument] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken);
//  CHECK_TSearchParamsDocument : Array[TSearchParamsDocument] of TSearchParamsDocument = ( spDocument__id,  spDocument_Attester,  spDocument_Author,  spDocument_Context,  spDocument_Date,  spDocument_Identifier,  spDocument_Section_content,  spDocument_Section_type,  spDocument_Subject,  spDocument_Type,  spDocument_Version);
  PATHS_TSearchParamsDocument : Array[TSearchParamsDocument] of String = ('_id: []',
     'attester: [frtPatient, frtPractitioner, frtOrganization]',
     'author: [frtPractitioner, frtDevice]',
     'context: []',
     'date: []',
     'identifier: []',
     'section-content: ALL_RESOURCE_TYPES',
     'section-type: []',
     'subject: [frtPatient, frtPractitioner, frtGroup, frtDevice]',
     'type: []',
     'version: []');
  TARGETS_TSearchParamsDocument : Array[TSearchParamsDocument] of TFhirResourceTypeSet = ([], [frtPatient, frtPractitioner, frtOrganization], [frtPractitioner, frtDevice], [], [], [], ALL_RESOURCE_TYPES, [], [frtPatient, frtPractitioner, frtGroup, frtDevice], [], []);
  CODES_TSearchParamsDocumentReference : Array[TSearchParamsDocumentReference] of String = ('_id', 'authenticator', 'author', 'confidentiality', 'created', 'custodian', 'description', 'event', 'facility', 'format', 'identifier', 'indexed', 'language', 'location', 'period', 'size', 'status', 'subject', 'subtype', 'supersedes', 'type');
  TYPES_TSearchParamsDocumentReference : Array[TSearchParamsDocumentReference] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeText,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeDate,  SearchParamTypeInteger,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsDocumentReference : Array[TSearchParamsDocumentReference] of TSearchParamsDocumentReference = ( spDocumentReference__id,  spDocumentReference_Authenticator,  spDocumentReference_Author,  spDocumentReference_Confidentiality,  spDocumentReference_Created,  spDocumentReference_Custodian,  spDocumentReference_Description,  spDocumentReference_Event,  spDocumentReference_Facility,  spDocumentReference_Format,  spDocumentReference_Identifier,  spDocumentReference_Indexed,  spDocumentReference_Language,  spDocumentReference_Location,  spDocumentReference_Period,  spDocumentReference_Size,  spDocumentReference_Status,  spDocumentReference_Subject,  spDocumentReference_Subtype,  spDocumentReference_Supersedes,  spDocumentReference_Type);
  PATHS_TSearchParamsDocumentReference : Array[TSearchParamsDocumentReference] of String = ('_id: []',
     'authenticator: [frtPractitioner, frtOrganization]',
     'author: [frtPractitioner, frtDevice]',
     'confidentiality: []',
     'created: []',
     'custodian: [frtOrganization]',
     'description: []',
     'event: []',
     'facility: []',
     'format: []',
     'identifier: []',
     'indexed: []',
     'language: []',
     'location: []',
     'period: []',
     'size: []',
     'status: []',
     'subject: [frtPatient, frtPractitioner, frtGroup, frtDevice]',
     'subtype: []',
     'supersedes: [frtDocumentReference]',
     'type: []');
  TARGETS_TSearchParamsDocumentReference : Array[TSearchParamsDocumentReference] of TFhirResourceTypeSet = ([], [frtPractitioner, frtOrganization], [frtPractitioner, frtDevice], [], [], [frtOrganization], [], [], [], [], [], [], [], [], [], [], [], [frtPatient, frtPractitioner, frtGroup, frtDevice], [], [frtDocumentReference], []);
  CODES_TSearchParamsEncounter : Array[TSearchParamsEncounter] of String = ('_id', 'fulfills', 'identifier', 'indication', 'length', 'start', 'status', 'subject');
  TYPES_TSearchParamsEncounter : Array[TSearchParamsEncounter] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeInteger,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeReference);
//  CHECK_TSearchParamsEncounter : Array[TSearchParamsEncounter] of TSearchParamsEncounter = ( spEncounter__id,  spEncounter_Fulfills,  spEncounter_Identifier,  spEncounter_Indication,  spEncounter_Length,  spEncounter_Start,  spEncounter_Status,  spEncounter_Subject);
  PATHS_TSearchParamsEncounter : Array[TSearchParamsEncounter] of String = ('_id: []',
     'fulfills: []',
     'identifier: []',
     'indication: ALL_RESOURCE_TYPES',
     'length: []',
     'start: []',
     'status: []',
     'subject: [frtPatient]');
  TARGETS_TSearchParamsEncounter : Array[TSearchParamsEncounter] of TFhirResourceTypeSet = ([], [], [], ALL_RESOURCE_TYPES, [], [], [], [frtPatient]);
  CODES_TSearchParamsFamilyHistory : Array[TSearchParamsFamilyHistory] of String = ('_id', 'subject');
  TYPES_TSearchParamsFamilyHistory : Array[TSearchParamsFamilyHistory] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference);
//  CHECK_TSearchParamsFamilyHistory : Array[TSearchParamsFamilyHistory] of TSearchParamsFamilyHistory = ( spFamilyHistory__id,  spFamilyHistory_Subject);
  PATHS_TSearchParamsFamilyHistory : Array[TSearchParamsFamilyHistory] of String = ('_id: []',
     'subject: [frtPatient]');
  TARGETS_TSearchParamsFamilyHistory : Array[TSearchParamsFamilyHistory] of TFhirResourceTypeSet = ([], [frtPatient]);
  CODES_TSearchParamsGroup : Array[TSearchParamsGroup] of String = ('_id', 'actual', 'code', 'exclude', 'group-type', 'identifier', 'member', 'type', 'type-value', 'value');
  TYPES_TSearchParamsGroup : Array[TSearchParamsGroup] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeComposite,  SearchParamTypeToken);
//  CHECK_TSearchParamsGroup : Array[TSearchParamsGroup] of TSearchParamsGroup = ( spGroup__id,  spGroup_Actual,  spGroup_Code,  spGroup_Exclude,  spGroup_Group_type,  spGroup_Identifier,  spGroup_Member,  spGroup_Type,  spGroup_Type_value,  spGroup_Value);
  PATHS_TSearchParamsGroup : Array[TSearchParamsGroup] of String = ('_id: []',
     'actual: []',
     'code: []',
     'exclude: []',
     'group-type: []',
     'identifier: []',
     'member: [frtPatient, frtPractitioner, frtDevice, frtMedication]',
     'type: []',
     'type-value: []',
     'value: []');
  TARGETS_TSearchParamsGroup : Array[TSearchParamsGroup] of TFhirResourceTypeSet = ([], [], [], [], [], [], [frtPatient, frtPractitioner, frtDevice, frtMedication], [], [], []);
  CODES_TSearchParamsImagingStudy : Array[TSearchParamsImagingStudy] of String = ('_id', 'accession', 'bodysite', 'date', 'dicom-class', 'modality', 'series', 'size', 'study', 'subject', 'uid');
  TYPES_TSearchParamsImagingStudy : Array[TSearchParamsImagingStudy] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeInteger,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsImagingStudy : Array[TSearchParamsImagingStudy] of TSearchParamsImagingStudy = ( spImagingStudy__id,  spImagingStudy_Accession,  spImagingStudy_Bodysite,  spImagingStudy_Date,  spImagingStudy_Dicom_class,  spImagingStudy_Modality,  spImagingStudy_Series,  spImagingStudy_Size,  spImagingStudy_Study,  spImagingStudy_Subject,  spImagingStudy_Uid);
  PATHS_TSearchParamsImagingStudy : Array[TSearchParamsImagingStudy] of String = ('_id: []',
     'accession: []',
     'bodysite: []',
     'date: []',
     'dicom-class: []',
     'modality: []',
     'series: []',
     'size: []',
     'study: []',
     'subject: [frtPatient]',
     'uid: []');
  TARGETS_TSearchParamsImagingStudy : Array[TSearchParamsImagingStudy] of TFhirResourceTypeSet = ([], [], [], [], [], [], [], [], [], [frtPatient], []);
  CODES_TSearchParamsImmunization : Array[TSearchParamsImmunization] of String = ('_id', 'date', 'location', 'lot-number', 'manufacturer', 'performer', 'refusal-reason', 'requester', 'subject', 'vaccine-type');
  TYPES_TSearchParamsImmunization : Array[TSearchParamsImmunization] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeString,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsImmunization : Array[TSearchParamsImmunization] of TSearchParamsImmunization = ( spImmunization__id,  spImmunization_Date,  spImmunization_Location,  spImmunization_Lot_number,  spImmunization_Manufacturer,  spImmunization_Performer,  spImmunization_Refusal_reason,  spImmunization_Requester,  spImmunization_Subject,  spImmunization_Vaccine_type);
  PATHS_TSearchParamsImmunization : Array[TSearchParamsImmunization] of String = ('_id: []',
     'date: []',
     'location: [frtLocation]',
     'lot-number: []',
     'manufacturer: [frtOrganization]',
     'performer: [frtPractitioner]',
     'refusal-reason: []',
     'requester: [frtPractitioner]',
     'subject: [frtPatient]',
     'vaccine-type: []');
  TARGETS_TSearchParamsImmunization : Array[TSearchParamsImmunization] of TFhirResourceTypeSet = ([], [], [frtLocation], [], [frtOrganization], [frtPractitioner], [], [frtPractitioner], [frtPatient], []);
  CODES_TSearchParamsImmunizationProfile : Array[TSearchParamsImmunizationProfile] of String = ('_id', 'subject', 'vaccine-type');
  TYPES_TSearchParamsImmunizationProfile : Array[TSearchParamsImmunizationProfile] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsImmunizationProfile : Array[TSearchParamsImmunizationProfile] of TSearchParamsImmunizationProfile = ( spImmunizationProfile__id,  spImmunizationProfile_Subject,  spImmunizationProfile_Vaccine_type);
  PATHS_TSearchParamsImmunizationProfile : Array[TSearchParamsImmunizationProfile] of String = ('_id: []',
     'subject: [frtPatient]',
     'vaccine-type: []');
  TARGETS_TSearchParamsImmunizationProfile : Array[TSearchParamsImmunizationProfile] of TFhirResourceTypeSet = ([], [frtPatient], []);
  CODES_TSearchParamsList : Array[TSearchParamsList] of String = ('_id', 'code', 'date', 'empty-reason', 'item', 'source');
  TYPES_TSearchParamsList : Array[TSearchParamsList] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference);
//  CHECK_TSearchParamsList : Array[TSearchParamsList] of TSearchParamsList = ( spList__id,  spList_Code,  spList_Date,  spList_Empty_reason,  spList_Item,  spList_Source);
  PATHS_TSearchParamsList : Array[TSearchParamsList] of String = ('_id: []',
     'code: []',
     'date: []',
     'empty-reason: []',
     'item: ALL_RESOURCE_TYPES',
     'source: [frtPractitioner, frtPatient, frtDevice]');
  TARGETS_TSearchParamsList : Array[TSearchParamsList] of TFhirResourceTypeSet = ([], [], [], [], ALL_RESOURCE_TYPES, [frtPractitioner, frtPatient, frtDevice]);
  CODES_TSearchParamsLocation : Array[TSearchParamsLocation] of String = ('_id', 'active', 'address', 'name', 'near', 'near-distance', 'partof', 'type');
  TYPES_TSearchParamsLocation : Array[TSearchParamsLocation] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsLocation : Array[TSearchParamsLocation] of TSearchParamsLocation = ( spLocation__id,  spLocation_Active,  spLocation_Address,  spLocation_Name,  spLocation_Near,  spLocation_Near_distance,  spLocation_Partof,  spLocation_Type);
  PATHS_TSearchParamsLocation : Array[TSearchParamsLocation] of String = ('_id: []',
     'active: []',
     'address: []',
     'name: []',
     'near: []',
     'near-distance: []',
     'partof: [frtLocation]',
     'type: []');
  TARGETS_TSearchParamsLocation : Array[TSearchParamsLocation] of TFhirResourceTypeSet = ([], [], [], [], [], [], [frtLocation], []);
  CODES_TSearchParamsMedia : Array[TSearchParamsMedia] of String = ('_id', 'date', 'identifier', 'operator', 'subject', 'subtype', 'type', 'view');
  TYPES_TSearchParamsMedia : Array[TSearchParamsMedia] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken);
//  CHECK_TSearchParamsMedia : Array[TSearchParamsMedia] of TSearchParamsMedia = ( spMedia__id,  spMedia_Date,  spMedia_Identifier,  spMedia_Operator,  spMedia_Subject,  spMedia_Subtype,  spMedia_Type,  spMedia_View);
  PATHS_TSearchParamsMedia : Array[TSearchParamsMedia] of String = ('_id: []',
     'date: []',
     'identifier: []',
     'operator: [frtPractitioner]',
     'subject: [frtPatient, frtPractitioner, frtGroup, frtDevice, frtSpecimen]',
     'subtype: []',
     'type: []',
     'view: []');
  TARGETS_TSearchParamsMedia : Array[TSearchParamsMedia] of TFhirResourceTypeSet = ([], [], [], [frtPractitioner], [frtPatient, frtPractitioner, frtGroup, frtDevice, frtSpecimen], [], [], []);
  CODES_TSearchParamsMedication : Array[TSearchParamsMedication] of String = ('_id', 'code', 'container', 'content', 'form', 'ingredient', 'manufacturer', 'name');
  TYPES_TSearchParamsMedication : Array[TSearchParamsMedication] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeString);
//  CHECK_TSearchParamsMedication : Array[TSearchParamsMedication] of TSearchParamsMedication = ( spMedication__id,  spMedication_Code,  spMedication_Container,  spMedication_Content,  spMedication_Form,  spMedication_Ingredient,  spMedication_Manufacturer,  spMedication_Name);
  PATHS_TSearchParamsMedication : Array[TSearchParamsMedication] of String = ('_id: []',
     'code: []',
     'container: []',
     'content: [frtMedication]',
     'form: []',
     'ingredient: [frtSubstance, frtMedication]',
     'manufacturer: [frtOrganization]',
     'name: []');
  TARGETS_TSearchParamsMedication : Array[TSearchParamsMedication] of TFhirResourceTypeSet = ([], [], [], [frtMedication], [], [frtSubstance, frtMedication], [frtOrganization], []);
  CODES_TSearchParamsMedicationAdministration : Array[TSearchParamsMedicationAdministration] of String = ('_id', 'administrationdevice', 'encounter', 'identifier', 'medication', 'notgiven', 'patient', 'prescription', 'status', 'whengiven');
  TYPES_TSearchParamsMedicationAdministration : Array[TSearchParamsMedicationAdministration] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeDate);
//  CHECK_TSearchParamsMedicationAdministration : Array[TSearchParamsMedicationAdministration] of TSearchParamsMedicationAdministration = ( spMedicationAdministration__id,  spMedicationAdministration_Administrationdevice,  spMedicationAdministration_Encounter,  spMedicationAdministration_Identifier,  spMedicationAdministration_Medication,  spMedicationAdministration_Notgiven,  spMedicationAdministration_Patient,  spMedicationAdministration_Prescription,  spMedicationAdministration_Status,  spMedicationAdministration_Whengiven);
  PATHS_TSearchParamsMedicationAdministration : Array[TSearchParamsMedicationAdministration] of String = ('_id: []',
     'administrationdevice: [frtDevice]',
     'encounter: [frtEncounter]',
     'identifier: []',
     'medication: [frtMedication]',
     'notgiven: []',
     'patient: [frtPatient]',
     'prescription: [frtMedicationPrescription]',
     'status: []',
     'whengiven: []');
  TARGETS_TSearchParamsMedicationAdministration : Array[TSearchParamsMedicationAdministration] of TFhirResourceTypeSet = ([], [frtDevice], [frtEncounter], [], [frtMedication], [], [frtPatient], [frtMedicationPrescription], [], []);
  CODES_TSearchParamsMedicationDispense : Array[TSearchParamsMedicationDispense] of String = ('_id', 'destination', 'dispenser', 'identifier', 'medication', 'patient', 'prescription', 'responsibleparty', 'status', 'type', 'whenhandedover', 'whenprepared');
  TYPES_TSearchParamsMedicationDispense : Array[TSearchParamsMedicationDispense] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeDate);
//  CHECK_TSearchParamsMedicationDispense : Array[TSearchParamsMedicationDispense] of TSearchParamsMedicationDispense = ( spMedicationDispense__id,  spMedicationDispense_Destination,  spMedicationDispense_Dispenser,  spMedicationDispense_Identifier,  spMedicationDispense_Medication,  spMedicationDispense_Patient,  spMedicationDispense_Prescription,  spMedicationDispense_Responsibleparty,  spMedicationDispense_Status,  spMedicationDispense_Type,  spMedicationDispense_Whenhandedover,  spMedicationDispense_Whenprepared);
  PATHS_TSearchParamsMedicationDispense : Array[TSearchParamsMedicationDispense] of String = ('_id: []',
     'destination: [frtLocation]',
     'dispenser: [frtPractitioner]',
     'identifier: []',
     'medication: [frtMedication]',
     'patient: [frtPatient]',
     'prescription: [frtMedicationPrescription]',
     'responsibleparty: [frtPractitioner]',
     'status: []',
     'type: []',
     'whenhandedover: []',
     'whenprepared: []');
  TARGETS_TSearchParamsMedicationDispense : Array[TSearchParamsMedicationDispense] of TFhirResourceTypeSet = ([], [frtLocation], [frtPractitioner], [], [frtMedication], [frtPatient], [frtMedicationPrescription], [frtPractitioner], [], [], [], []);
  CODES_TSearchParamsMedicationPrescription : Array[TSearchParamsMedicationPrescription] of String = ('_id', 'datewritten', 'encounter', 'identifier', 'medication', 'patient', 'status');
  TYPES_TSearchParamsMedicationPrescription : Array[TSearchParamsMedicationPrescription] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsMedicationPrescription : Array[TSearchParamsMedicationPrescription] of TSearchParamsMedicationPrescription = ( spMedicationPrescription__id,  spMedicationPrescription_Datewritten,  spMedicationPrescription_Encounter,  spMedicationPrescription_Identifier,  spMedicationPrescription_Medication,  spMedicationPrescription_Patient,  spMedicationPrescription_Status);
  PATHS_TSearchParamsMedicationPrescription : Array[TSearchParamsMedicationPrescription] of String = ('_id: []',
     'datewritten: []',
     'encounter: [frtEncounter]',
     'identifier: []',
     'medication: [frtMedication]',
     'patient: [frtPatient]',
     'status: []');
  TARGETS_TSearchParamsMedicationPrescription : Array[TSearchParamsMedicationPrescription] of TFhirResourceTypeSet = ([], [], [frtEncounter], [], [frtMedication], [frtPatient], []);
  CODES_TSearchParamsMedicationStatement : Array[TSearchParamsMedicationStatement] of String = ('_id', 'administrationdevice', 'identifier', 'medication', 'patient', 'when-given');
  TYPES_TSearchParamsMedicationStatement : Array[TSearchParamsMedicationStatement] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeDate);
//  CHECK_TSearchParamsMedicationStatement : Array[TSearchParamsMedicationStatement] of TSearchParamsMedicationStatement = ( spMedicationStatement__id,  spMedicationStatement_Administrationdevice,  spMedicationStatement_Identifier,  spMedicationStatement_Medication,  spMedicationStatement_Patient,  spMedicationStatement_When_given);
  PATHS_TSearchParamsMedicationStatement : Array[TSearchParamsMedicationStatement] of String = ('_id: []',
     'administrationdevice: [frtDevice]',
     'identifier: []',
     'medication: [frtMedication]',
     'patient: [frtPatient]',
     'when-given: []');
  TARGETS_TSearchParamsMedicationStatement : Array[TSearchParamsMedicationStatement] of TFhirResourceTypeSet = ([], [frtDevice], [], [frtMedication], [frtPatient], []);
  CODES_TSearchParamsMessage : Array[TSearchParamsMessage] of String = ('_id');
  TYPES_TSearchParamsMessage : Array[TSearchParamsMessage] of TFhirSearchParamType = ( SearchParamTypeToken);
//  CHECK_TSearchParamsMessage : Array[TSearchParamsMessage] of TSearchParamsMessage = ( spMessage__id);
  PATHS_TSearchParamsMessage : Array[TSearchParamsMessage] of String = ('_id: []');
  TARGETS_TSearchParamsMessage : Array[TSearchParamsMessage] of TFhirResourceTypeSet = ([]);
  CODES_TSearchParamsObservation : Array[TSearchParamsObservation] of String = ('_id', 'date', 'name', 'name-value', 'performer', 'reliability', 'status', 'subject', 'value');
  TYPES_TSearchParamsObservation : Array[TSearchParamsObservation] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeComposite,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsObservation : Array[TSearchParamsObservation] of TSearchParamsObservation = ( spObservation__id,  spObservation_Date,  spObservation_Name,  spObservation_Name_value,  spObservation_Performer,  spObservation_Reliability,  spObservation_Status,  spObservation_Subject,  spObservation_Value);
  PATHS_TSearchParamsObservation : Array[TSearchParamsObservation] of String = ('_id: []',
     'date: []',
     'name: []',
     'name-value: []',
     'performer: [frtPractitioner, frtDevice, frtOrganization]',
     'reliability: []',
     'status: []',
     'subject: [frtPatient, frtGroup, frtDevice]',
     'value: []');
  TARGETS_TSearchParamsObservation : Array[TSearchParamsObservation] of TFhirResourceTypeSet = ([], [], [], [], [frtPractitioner, frtDevice, frtOrganization], [], [], [frtPatient, frtGroup, frtDevice], []);
  CODES_TSearchParamsOperationOutcome : Array[TSearchParamsOperationOutcome] of String = ('_id');
  TYPES_TSearchParamsOperationOutcome : Array[TSearchParamsOperationOutcome] of TFhirSearchParamType = ( SearchParamTypeToken);
//  CHECK_TSearchParamsOperationOutcome : Array[TSearchParamsOperationOutcome] of TSearchParamsOperationOutcome = ( spOperationOutcome__id);
  PATHS_TSearchParamsOperationOutcome : Array[TSearchParamsOperationOutcome] of String = ('_id: []');
  TARGETS_TSearchParamsOperationOutcome : Array[TSearchParamsOperationOutcome] of TFhirResourceTypeSet = ([]);
  CODES_TSearchParamsOrder : Array[TSearchParamsOrder] of String = ('_id', 'authority', 'date', 'detail', 'source', 'subject', 'target', 'when', 'when_code');
  TYPES_TSearchParamsOrder : Array[TSearchParamsOrder] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeDate,  SearchParamTypeToken);
//  CHECK_TSearchParamsOrder : Array[TSearchParamsOrder] of TSearchParamsOrder = ( spOrder__id,  spOrder_Authority,  spOrder_Date,  spOrder_Detail,  spOrder_Source,  spOrder_Subject,  spOrder_Target,  spOrder_When,  spOrder_When_code);
  PATHS_TSearchParamsOrder : Array[TSearchParamsOrder] of String = ('_id: []',
     'authority: ALL_RESOURCE_TYPES',
     'date: []',
     'detail: ALL_RESOURCE_TYPES',
     'source: [frtPractitioner]',
     'subject: [frtPatient]',
     'target: [frtOrganization, frtDevice]',
     'when: []',
     'when_code: []');
  TARGETS_TSearchParamsOrder : Array[TSearchParamsOrder] of TFhirResourceTypeSet = ([], ALL_RESOURCE_TYPES, [], ALL_RESOURCE_TYPES, [frtPractitioner], [frtPatient], [frtOrganization, frtDevice], [], []);
  CODES_TSearchParamsOrderResponse : Array[TSearchParamsOrderResponse] of String = ('_id', 'authority', 'code', 'cost', 'date', 'fulfillment', 'request', 'who');
  TYPES_TSearchParamsOrderResponse : Array[TSearchParamsOrderResponse] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeInteger,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeReference,  SearchParamTypeReference);
//  CHECK_TSearchParamsOrderResponse : Array[TSearchParamsOrderResponse] of TSearchParamsOrderResponse = ( spOrderResponse__id,  spOrderResponse_Authority,  spOrderResponse_Code,  spOrderResponse_Cost,  spOrderResponse_Date,  spOrderResponse_Fulfillment,  spOrderResponse_Request,  spOrderResponse_Who);
  PATHS_TSearchParamsOrderResponse : Array[TSearchParamsOrderResponse] of String = ('_id: []',
     'authority: ALL_RESOURCE_TYPES',
     'code: []',
     'cost: []',
     'date: []',
     'fulfillment: ALL_RESOURCE_TYPES',
     'request: [frtOrder]',
     'who: [frtPractitioner, frtOrganization]');
  TARGETS_TSearchParamsOrderResponse : Array[TSearchParamsOrderResponse] of TFhirResourceTypeSet = ([], ALL_RESOURCE_TYPES, [], [], [], ALL_RESOURCE_TYPES, [frtOrder], [frtPractitioner, frtOrganization]);
  CODES_TSearchParamsOrganization : Array[TSearchParamsOrganization] of String = ('_id', 'active', 'identifier', 'name', 'partof', 'phonetic', 'type');
  TYPES_TSearchParamsOrganization : Array[TSearchParamsOrganization] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeReference,  SearchParamTypeString,  SearchParamTypeToken);
//  CHECK_TSearchParamsOrganization : Array[TSearchParamsOrganization] of TSearchParamsOrganization = ( spOrganization__id,  spOrganization_Active,  spOrganization_Identifier,  spOrganization_Name,  spOrganization_Partof,  spOrganization_Phonetic,  spOrganization_Type);
  PATHS_TSearchParamsOrganization : Array[TSearchParamsOrganization] of String = ('_id: []',
     'active: []',
     'identifier: []',
     'name: []',
     'partof: [frtOrganization]',
     'phonetic: []',
     'type: []');
  TARGETS_TSearchParamsOrganization : Array[TSearchParamsOrganization] of TFhirResourceTypeSet = ([], [], [], [], [frtOrganization], [], []);
  CODES_TSearchParamsOther : Array[TSearchParamsOther] of String = ('_id', 'created', 'subject');
  TYPES_TSearchParamsOther : Array[TSearchParamsOther] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference);
//  CHECK_TSearchParamsOther : Array[TSearchParamsOther] of TSearchParamsOther = ( spOther__id,  spOther_Created,  spOther_Subject);
  PATHS_TSearchParamsOther : Array[TSearchParamsOther] of String = ('_id: []',
     'created: []',
     'subject: ALL_RESOURCE_TYPES');
  TARGETS_TSearchParamsOther : Array[TSearchParamsOther] of TFhirResourceTypeSet = ([], [], ALL_RESOURCE_TYPES);
  CODES_TSearchParamsPatient : Array[TSearchParamsPatient] of String = ('_id', 'active', 'address', 'animal-breed', 'animal-species', 'birthdate', 'family', 'gender', 'given', 'identifier', 'language', 'name', 'phonetic', 'provider', 'telecom');
  TYPES_TSearchParamsPatient : Array[TSearchParamsPatient] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeString,  SearchParamTypeReference,  SearchParamTypeString);
//  CHECK_TSearchParamsPatient : Array[TSearchParamsPatient] of TSearchParamsPatient = ( spPatient__id,  spPatient_Active,  spPatient_Address,  spPatient_Animal_breed,  spPatient_Animal_species,  spPatient_Birthdate,  spPatient_Family,  spPatient_Gender,  spPatient_Given,  spPatient_Identifier,  spPatient_Language,  spPatient_Name,  spPatient_Phonetic,  spPatient_Provider,  spPatient_Telecom);
  PATHS_TSearchParamsPatient : Array[TSearchParamsPatient] of String = ('_id: []',
     'active: []',
     'address: []',
     'animal-breed: []',
     'animal-species: []',
     'birthdate: []',
     'family: []',
     'gender: []',
     'given: []',
     'identifier: []',
     'language: []',
     'name: []',
     'phonetic: []',
     'provider: [frtOrganization]',
     'telecom: []');
  TARGETS_TSearchParamsPatient : Array[TSearchParamsPatient] of TFhirResourceTypeSet = ([], [], [], [], [], [], [], [], [], [], [], [], [], [frtOrganization], []);
  CODES_TSearchParamsPractitioner : Array[TSearchParamsPractitioner] of String = ('_id', 'address', 'family', 'gender', 'given', 'identifier', 'name', 'organization', 'phonetic', 'telecom');
  TYPES_TSearchParamsPractitioner : Array[TSearchParamsPractitioner] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeReference,  SearchParamTypeString,  SearchParamTypeString);
//  CHECK_TSearchParamsPractitioner : Array[TSearchParamsPractitioner] of TSearchParamsPractitioner = ( spPractitioner__id,  spPractitioner_Address,  spPractitioner_Family,  spPractitioner_Gender,  spPractitioner_Given,  spPractitioner_Identifier,  spPractitioner_Name,  spPractitioner_Organization,  spPractitioner_Phonetic,  spPractitioner_Telecom);
  PATHS_TSearchParamsPractitioner : Array[TSearchParamsPractitioner] of String = ('_id: []',
     'address: []',
     'family: []',
     'gender: []',
     'given: []',
     'identifier: []',
     'name: []',
     'organization: [frtOrganization]',
     'phonetic: []',
     'telecom: []');
  TARGETS_TSearchParamsPractitioner : Array[TSearchParamsPractitioner] of TFhirResourceTypeSet = ([], [], [], [], [], [], [], [frtOrganization], [], []);
  CODES_TSearchParamsProcedure : Array[TSearchParamsProcedure] of String = ('_id', 'date', 'subject', 'type');
  TYPES_TSearchParamsProcedure : Array[TSearchParamsProcedure] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeToken);
//  CHECK_TSearchParamsProcedure : Array[TSearchParamsProcedure] of TSearchParamsProcedure = ( spProcedure__id,  spProcedure_Date,  spProcedure_Subject,  spProcedure_Type);
  PATHS_TSearchParamsProcedure : Array[TSearchParamsProcedure] of String = ('_id: []',
     'date: []',
     'subject: [frtPatient]',
     'type: []');
  TARGETS_TSearchParamsProcedure : Array[TSearchParamsProcedure] of TFhirResourceTypeSet = ([], [], [frtPatient], []);
  CODES_TSearchParamsProfile : Array[TSearchParamsProfile] of String = ('_id', 'author', 'binding', 'code', 'date', 'extension', 'name', 'reference', 'resource', 'status', 'type', 'word');
  TYPES_TSearchParamsProfile : Array[TSearchParamsProfile] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeText);
//  CHECK_TSearchParamsProfile : Array[TSearchParamsProfile] of TSearchParamsProfile = ( spProfile__id,  spProfile_Author,  spProfile_Binding,  spProfile_Code,  spProfile_Date,  spProfile_Extension,  spProfile_Name,  spProfile_Reference,  spProfile_Resource,  spProfile_Status,  spProfile_Type,  spProfile_Word);
  PATHS_TSearchParamsProfile : Array[TSearchParamsProfile] of String = ('_id: []',
     'author: []',
     'binding: []',
     'code: []',
     'date: []',
     'extension: []',
     'name: []',
     'reference: []',
     'resource: []',
     'status: []',
     'type: []',
     'word: []');
  TARGETS_TSearchParamsProfile : Array[TSearchParamsProfile] of TFhirResourceTypeSet = ([], [], [], [], [], [], [], [], [], [], [], []);
  CODES_TSearchParamsProvenance : Array[TSearchParamsProvenance] of String = ('_id', 'end', 'location', 'party', 'partytype', 'start', 'target');
  TYPES_TSearchParamsProvenance : Array[TSearchParamsProvenance] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeReference);
//  CHECK_TSearchParamsProvenance : Array[TSearchParamsProvenance] of TSearchParamsProvenance = ( spProvenance__id,  spProvenance_End,  spProvenance_Location,  spProvenance_Party,  spProvenance_Partytype,  spProvenance_Start,  spProvenance_Target);
  PATHS_TSearchParamsProvenance : Array[TSearchParamsProvenance] of String = ('_id: []',
     'end: []',
     'location: [frtLocation]',
     'party: []',
     'partytype: []',
     'start: []',
     'target: ALL_RESOURCE_TYPES');
  TARGETS_TSearchParamsProvenance : Array[TSearchParamsProvenance] of TFhirResourceTypeSet = ([], [], [frtLocation], [], [], [], ALL_RESOURCE_TYPES);
  CODES_TSearchParamsQuery : Array[TSearchParamsQuery] of String = ('_id', 'identifier', 'response');
  TYPES_TSearchParamsQuery : Array[TSearchParamsQuery] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken);
//  CHECK_TSearchParamsQuery : Array[TSearchParamsQuery] of TSearchParamsQuery = ( spQuery__id,  spQuery_Identifier,  spQuery_Response);
  PATHS_TSearchParamsQuery : Array[TSearchParamsQuery] of String = ('_id: []',
     'identifier: []',
     'response: []');
  TARGETS_TSearchParamsQuery : Array[TSearchParamsQuery] of TFhirResourceTypeSet = ([], [], []);
  CODES_TSearchParamsQuestionnaire : Array[TSearchParamsQuestionnaire] of String = ('_id', 'author', 'authored', 'encounter', 'identifier', 'name', 'status', 'subject');
  TYPES_TSearchParamsQuestionnaire : Array[TSearchParamsQuestionnaire] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeDate,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference);
//  CHECK_TSearchParamsQuestionnaire : Array[TSearchParamsQuestionnaire] of TSearchParamsQuestionnaire = ( spQuestionnaire__id,  spQuestionnaire_Author,  spQuestionnaire_Authored,  spQuestionnaire_Encounter,  spQuestionnaire_Identifier,  spQuestionnaire_Name,  spQuestionnaire_Status,  spQuestionnaire_Subject);
  PATHS_TSearchParamsQuestionnaire : Array[TSearchParamsQuestionnaire] of String = ('_id: []',
     'author: [frtPractitioner, frtPatient, frtRelatedPerson]',
     'authored: []',
     'encounter: [frtEncounter]',
     'identifier: []',
     'name: []',
     'status: []',
     'subject: [frtPatient, frtRelatedPerson]');
  TARGETS_TSearchParamsQuestionnaire : Array[TSearchParamsQuestionnaire] of TFhirResourceTypeSet = ([], [frtPractitioner, frtPatient, frtRelatedPerson], [], [frtEncounter], [], [], [], [frtPatient, frtRelatedPerson]);
  CODES_TSearchParamsRelatedPerson : Array[TSearchParamsRelatedPerson] of String = ('_id', 'address', 'gender', 'identifier', 'name', 'patient', 'phonetic', 'telecom');
  TYPES_TSearchParamsRelatedPerson : Array[TSearchParamsRelatedPerson] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeReference,  SearchParamTypeString,  SearchParamTypeString);
//  CHECK_TSearchParamsRelatedPerson : Array[TSearchParamsRelatedPerson] of TSearchParamsRelatedPerson = ( spRelatedPerson__id,  spRelatedPerson_Address,  spRelatedPerson_Gender,  spRelatedPerson_Identifier,  spRelatedPerson_Name,  spRelatedPerson_Patient,  spRelatedPerson_Phonetic,  spRelatedPerson_Telecom);
  PATHS_TSearchParamsRelatedPerson : Array[TSearchParamsRelatedPerson] of String = ('_id: []',
     'address: []',
     'gender: []',
     'identifier: []',
     'name: []',
     'patient: [frtPatient]',
     'phonetic: []',
     'telecom: []');
  TARGETS_TSearchParamsRelatedPerson : Array[TSearchParamsRelatedPerson] of TFhirResourceTypeSet = ([], [], [], [], [], [frtPatient], [], []);
  CODES_TSearchParamsSecurityEvent : Array[TSearchParamsSecurityEvent] of String = ('_id', 'action', 'address', 'authid', 'date', 'desc', 'identity', 'name', 'object-type', 'patientid', 'reference', 'site', 'source', 'subtype', 'type', 'user');
  TYPES_TSearchParamsSecurityEvent : Array[TSearchParamsSecurityEvent] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeDate,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken);
//  CHECK_TSearchParamsSecurityEvent : Array[TSearchParamsSecurityEvent] of TSearchParamsSecurityEvent = ( spSecurityEvent__id,  spSecurityEvent_Action,  spSecurityEvent_Address,  spSecurityEvent_Authid,  spSecurityEvent_Date,  spSecurityEvent_Desc,  spSecurityEvent_Identity,  spSecurityEvent_Name,  spSecurityEvent_Object_type,  spSecurityEvent_Patientid,  spSecurityEvent_Reference,  spSecurityEvent_Site,  spSecurityEvent_Source,  spSecurityEvent_Subtype,  spSecurityEvent_Type,  spSecurityEvent_User);
  PATHS_TSearchParamsSecurityEvent : Array[TSearchParamsSecurityEvent] of String = ('_id: []',
     'action: []',
     'address: []',
     'authid: []',
     'date: []',
     'desc: []',
     'identity: []',
     'name: []',
     'object-type: []',
     'patientid: []',
     'reference: ALL_RESOURCE_TYPES',
     'site: []',
     'source: []',
     'subtype: []',
     'type: []',
     'user: []');
  TARGETS_TSearchParamsSecurityEvent : Array[TSearchParamsSecurityEvent] of TFhirResourceTypeSet = ([], [], [], [], [], [], [], [], [], [], ALL_RESOURCE_TYPES, [], [], [], [], []);
  CODES_TSearchParamsSpecimen : Array[TSearchParamsSpecimen] of String = ('_id', 'subject');
  TYPES_TSearchParamsSpecimen : Array[TSearchParamsSpecimen] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeReference);
//  CHECK_TSearchParamsSpecimen : Array[TSearchParamsSpecimen] of TSearchParamsSpecimen = ( spSpecimen__id,  spSpecimen_Subject);
  PATHS_TSearchParamsSpecimen : Array[TSearchParamsSpecimen] of String = ('_id: []',
     'subject: [frtPatient, frtGroup, frtDevice, frtSubstance]');
  TARGETS_TSearchParamsSpecimen : Array[TSearchParamsSpecimen] of TFhirResourceTypeSet = ([], [frtPatient, frtGroup, frtDevice, frtSubstance]);
  CODES_TSearchParamsSubstance : Array[TSearchParamsSubstance] of String = ('_id', 'name', 'type');
  TYPES_TSearchParamsSubstance : Array[TSearchParamsSubstance] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken);
//  CHECK_TSearchParamsSubstance : Array[TSearchParamsSubstance] of TSearchParamsSubstance = ( spSubstance__id,  spSubstance_Name,  spSubstance_Type);
  PATHS_TSearchParamsSubstance : Array[TSearchParamsSubstance] of String = ('_id: []',
     'name: []',
     'type: []');
  TARGETS_TSearchParamsSubstance : Array[TSearchParamsSubstance] of TFhirResourceTypeSet = ([], [], []);
  CODES_TSearchParamsSupply : Array[TSearchParamsSupply] of String = ('_id', 'dispenseid', 'dispensestatus', 'identifier', 'name', 'patient', 'status', 'supplier');
  TYPES_TSearchParamsSupply : Array[TSearchParamsSupply] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeReference,  SearchParamTypeToken,  SearchParamTypeReference);
//  CHECK_TSearchParamsSupply : Array[TSearchParamsSupply] of TSearchParamsSupply = ( spSupply__id,  spSupply_Dispenseid,  spSupply_Dispensestatus,  spSupply_Identifier,  spSupply_Name,  spSupply_Patient,  spSupply_Status,  spSupply_Supplier);
  PATHS_TSearchParamsSupply : Array[TSearchParamsSupply] of String = ('_id: []',
     'dispenseid: []',
     'dispensestatus: []',
     'identifier: []',
     'name: []',
     'patient: [frtPatient]',
     'status: []',
     'supplier: [frtPractitioner]');
  TARGETS_TSearchParamsSupply : Array[TSearchParamsSupply] of TFhirResourceTypeSet = ([], [], [], [], [], [frtPatient], [], [frtPractitioner]);
  CODES_TSearchParamsValueSet : Array[TSearchParamsValueSet] of String = ('_id', 'code', 'description', 'identifier', 'name', 'reference', 'status', 'system', 'version');
  TYPES_TSearchParamsValueSet : Array[TSearchParamsValueSet] of TFhirSearchParamType = ( SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeString,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken,  SearchParamTypeToken);
//  CHECK_TSearchParamsValueSet : Array[TSearchParamsValueSet] of TSearchParamsValueSet = ( spValueSet__id,  spValueSet_Code,  spValueSet_Description,  spValueSet_Identifier,  spValueSet_Name,  spValueSet_Reference,  spValueSet_Status,  spValueSet_System,  spValueSet_Version);
  PATHS_TSearchParamsValueSet : Array[TSearchParamsValueSet] of String = ('_id: []',
     'code: []',
     'description: []',
     'identifier: []',
     'name: []',
     'reference: []',
     'status: []',
     'system: []',
     'version: []');
  TARGETS_TSearchParamsValueSet : Array[TSearchParamsValueSet] of TFhirResourceTypeSet = ([], [], [], [], [], [], [], [], []);
  FHIR_GENERATED_VERSION = '0.11';

  FHIR_GENERATED_REVISION = '1712';

  FHIR_GENERATED_DATE = '20130906230305';



implementation

end.

