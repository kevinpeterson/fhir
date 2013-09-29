unit FHIRParser;

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

// FHIR v0.11 generated Mon, Sep 30, 2013 03:15+1000

uses
  SysUtils, Classes, ActiveX, StringSupport, DateSupport, IdSoapMsXml, FHIRParserBase, MSSEWrap, FHIRBase, FHIRResources, FHIRComponents, FHIRTypes, MsXmlParser, XmlBuilder, JSON;

Type

  TFHIRXmlParser = class (TFHIRXmlParserBase)
  protected
    Procedure ParseElementAttributes(value : TFhirElement; element : IXmlDomElement);
    Function ParseElementChild(element : TFhirElement; child : IXmlDomElement) : boolean;

    function ParseEnum(Const aNames : Array Of String; element : IXmlDomElement) : TFhirEnum;
    function ParseInteger(element : IXmlDomElement) : TFhirInteger;
    function ParseDateTime(element : IXmlDomElement) : TFhirDateTime;
    function ParseDate(element : IXmlDomElement) : TFhirDate;
    function ParseDecimal(element : IXmlDomElement) : TFhirDecimal;
    function ParseUri(element : IXmlDomElement) : TFhirUri;
    function ParseBase64Binary(element : IXmlDomElement) : TFhirBase64Binary;
    function ParseString(element : IXmlDomElement) : TFhirString;
    function ParseBoolean(element : IXmlDomElement) : TFhirBoolean;
    function ParseInstant(element : IXmlDomElement) : TFhirInstant;
    function ParseCode(element : IXmlDomElement) : TFhirCode;
    function ParseId(element : IXmlDomElement) : TFhirId;
    function ParseOid(element : IXmlDomElement) : TFhirOid;
    function ParseUuid(element : IXmlDomElement) : TFhirUuid;

    Procedure ParseResourceAttributes(resource : TFhirResource; element : IXmlDomElement);
    Function ParseResourceChild(resource : TFhirResource; child : IXmlDomElement) : boolean;

    function ParseExtension(element : IXmlDomElement) : TFhirExtension;
    function ParseNarrative(element : IXmlDomElement) : TFhirNarrative;
    function ParsePeriod(element : IXmlDomElement) : TFhirPeriod;
    function ParseCoding(element : IXmlDomElement) : TFhirCoding;
    function ParseRange(element : IXmlDomElement) : TFhirRange;
    function ParseQuantity(element : IXmlDomElement) : TFhirQuantity;
    function ParseChoiceOption(element : IXmlDomElement) : TFhirChoiceOption;
    function ParseChoice(element : IXmlDomElement) : TFhirChoice;
    function ParseAttachment(element : IXmlDomElement) : TFhirAttachment;
    function ParseRatio(element : IXmlDomElement) : TFhirRatio;
    function ParseSampledData(element : IXmlDomElement) : TFhirSampledData;
    function ParseResourceReference(element : IXmlDomElement) : TFhirResourceReference;
    function ParseCodeableConcept(element : IXmlDomElement) : TFhirCodeableConcept;
    function ParseIdentifier(element : IXmlDomElement) : TFhirIdentifier;
    function ParseScheduleRepeat(element : IXmlDomElement) : TFhirScheduleRepeat;
    function ParseSchedule(element : IXmlDomElement) : TFhirSchedule;
    function ParseContact(element : IXmlDomElement) : TFhirContact;
    function ParseAddress(element : IXmlDomElement) : TFhirAddress;
    function ParseHumanName(element : IXmlDomElement) : TFhirHumanName;
    function ParseAge(element : IXmlDomElement) : TFhirAge;
    function ParseCount(element : IXmlDomElement) : TFhirCount;
    function ParseMoney(element : IXmlDomElement) : TFhirMoney;
    function ParseDistance(element : IXmlDomElement) : TFhirDistance;
    function ParseDuration(element : IXmlDomElement) : TFhirDuration;

    function ParseAdverseReactionSymptom(element : IXmlDomElement) : TFhirAdverseReactionSymptom;
    function ParseAdverseReactionExposure(element : IXmlDomElement) : TFhirAdverseReactionExposure;
    function ParseAdverseReaction(element : IXmlDomElement) : TFhirAdverseReaction;
    function ParseAlert(element : IXmlDomElement) : TFhirAlert;
    function ParseAllergyIntolerance(element : IXmlDomElement) : TFhirAllergyIntolerance;
    function ParseCarePlanParticipant(element : IXmlDomElement) : TFhirCarePlanParticipant;
    function ParseCarePlanGoal(element : IXmlDomElement) : TFhirCarePlanGoal;
    function ParseCarePlanActivity(element : IXmlDomElement) : TFhirCarePlanActivity;
    function ParseCarePlan(element : IXmlDomElement) : TFhirCarePlan;
    function ParseConditionStage(element : IXmlDomElement) : TFhirConditionStage;
    function ParseConditionEvidence(element : IXmlDomElement) : TFhirConditionEvidence;
    function ParseConditionLocation(element : IXmlDomElement) : TFhirConditionLocation;
    function ParseConditionRelatedItem(element : IXmlDomElement) : TFhirConditionRelatedItem;
    function ParseCondition(element : IXmlDomElement) : TFhirCondition;
    function ParseConformanceSoftware(element : IXmlDomElement) : TFhirConformanceSoftware;
    function ParseConformanceImplementation(element : IXmlDomElement) : TFhirConformanceImplementation;
    function ParseConformanceRest(element : IXmlDomElement) : TFhirConformanceRest;
    function ParseConformanceRestSecurity(element : IXmlDomElement) : TFhirConformanceRestSecurity;
    function ParseConformanceRestSecurityCertificate(element : IXmlDomElement) : TFhirConformanceRestSecurityCertificate;
    function ParseConformanceRestResource(element : IXmlDomElement) : TFhirConformanceRestResource;
    function ParseConformanceRestResourceOperation(element : IXmlDomElement) : TFhirConformanceRestResourceOperation;
    function ParseConformanceRestResourceSearchParam(element : IXmlDomElement) : TFhirConformanceRestResourceSearchParam;
    function ParseConformanceRestQuery(element : IXmlDomElement) : TFhirConformanceRestQuery;
    function ParseConformanceMessaging(element : IXmlDomElement) : TFhirConformanceMessaging;
    function ParseConformanceMessagingEvent(element : IXmlDomElement) : TFhirConformanceMessagingEvent;
    function ParseConformanceDocument(element : IXmlDomElement) : TFhirConformanceDocument;
    function ParseConformance(element : IXmlDomElement) : TFhirConformance;
    function ParseCoverageSubscriber(element : IXmlDomElement) : TFhirCoverageSubscriber;
    function ParseCoverage(element : IXmlDomElement) : TFhirCoverage;
    function ParseDeviceIdentity(element : IXmlDomElement) : TFhirDeviceIdentity;
    function ParseDevice(element : IXmlDomElement) : TFhirDevice;
    function ParseDeviceCapabilitiesVirtualDevice(element : IXmlDomElement) : TFhirDeviceCapabilitiesVirtualDevice;
    function ParseDeviceCapabilitiesVirtualDeviceChannel(element : IXmlDomElement) : TFhirDeviceCapabilitiesVirtualDeviceChannel;
    function ParseDeviceCapabilitiesVirtualDeviceChannelMetric(element : IXmlDomElement) : TFhirDeviceCapabilitiesVirtualDeviceChannelMetric;
    function ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfo(element : IXmlDomElement) : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo;
    function ParseDeviceCapabilitiesVirtualDeviceChannelMetricFacet(element : IXmlDomElement) : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet;
    function ParseDeviceCapabilities(element : IXmlDomElement) : TFhirDeviceCapabilities;
    function ParseDeviceLogItem(element : IXmlDomElement) : TFhirDeviceLogItem;
    function ParseDeviceLog(element : IXmlDomElement) : TFhirDeviceLog;
    function ParseDeviceObservation(element : IXmlDomElement) : TFhirDeviceObservation;
    function ParseDiagnosticOrderEvent(element : IXmlDomElement) : TFhirDiagnosticOrderEvent;
    function ParseDiagnosticOrderItem(element : IXmlDomElement) : TFhirDiagnosticOrderItem;
    function ParseDiagnosticOrder(element : IXmlDomElement) : TFhirDiagnosticOrder;
    function ParseDiagnosticReportRequestDetail(element : IXmlDomElement) : TFhirDiagnosticReportRequestDetail;
    function ParseDiagnosticReportResults(element : IXmlDomElement) : TFhirDiagnosticReportResults;
    function ParseDiagnosticReport(element : IXmlDomElement) : TFhirDiagnosticReport;
    function ParseDocumentAttester(element : IXmlDomElement) : TFhirDocumentAttester;
    function ParseDocumentEvent(element : IXmlDomElement) : TFhirDocumentEvent;
    function ParseDocumentSection(element : IXmlDomElement) : TFhirDocumentSection;
    function ParseDocument(element : IXmlDomElement) : TFhirDocument;
    function ParseDocumentReferenceService(element : IXmlDomElement) : TFhirDocumentReferenceService;
    function ParseDocumentReferenceServiceParameter(element : IXmlDomElement) : TFhirDocumentReferenceServiceParameter;
    function ParseDocumentReferenceContext(element : IXmlDomElement) : TFhirDocumentReferenceContext;
    function ParseDocumentReference(element : IXmlDomElement) : TFhirDocumentReference;
    function ParseEncounterParticipant(element : IXmlDomElement) : TFhirEncounterParticipant;
    function ParseEncounterHospitalization(element : IXmlDomElement) : TFhirEncounterHospitalization;
    function ParseEncounterHospitalizationAccomodation(element : IXmlDomElement) : TFhirEncounterHospitalizationAccomodation;
    function ParseEncounterLocation(element : IXmlDomElement) : TFhirEncounterLocation;
    function ParseEncounter(element : IXmlDomElement) : TFhirEncounter;
    function ParseFamilyHistoryRelation(element : IXmlDomElement) : TFhirFamilyHistoryRelation;
    function ParseFamilyHistoryRelationCondition(element : IXmlDomElement) : TFhirFamilyHistoryRelationCondition;
    function ParseFamilyHistory(element : IXmlDomElement) : TFhirFamilyHistory;
    function ParseGroupCharacteristic(element : IXmlDomElement) : TFhirGroupCharacteristic;
    function ParseGroup(element : IXmlDomElement) : TFhirGroup;
    function ParseImagingStudySeries(element : IXmlDomElement) : TFhirImagingStudySeries;
    function ParseImagingStudySeriesInstance(element : IXmlDomElement) : TFhirImagingStudySeriesInstance;
    function ParseImagingStudy(element : IXmlDomElement) : TFhirImagingStudy;
    function ParseImmunizationExplanation(element : IXmlDomElement) : TFhirImmunizationExplanation;
    function ParseImmunizationReaction(element : IXmlDomElement) : TFhirImmunizationReaction;
    function ParseImmunizationVaccinationProtocol(element : IXmlDomElement) : TFhirImmunizationVaccinationProtocol;
    function ParseImmunization(element : IXmlDomElement) : TFhirImmunization;
    function ParseImmunizationProfileRecommendation(element : IXmlDomElement) : TFhirImmunizationProfileRecommendation;
    function ParseImmunizationProfileRecommendationDateCriterion(element : IXmlDomElement) : TFhirImmunizationProfileRecommendationDateCriterion;
    function ParseImmunizationProfileRecommendationProtocol(element : IXmlDomElement) : TFhirImmunizationProfileRecommendationProtocol;
    function ParseImmunizationProfileRecommendationSupportingAdverseEventReport(element : IXmlDomElement) : TFhirImmunizationProfileRecommendationSupportingAdverseEventReport;
    function ParseImmunizationProfile(element : IXmlDomElement) : TFhirImmunizationProfile;
    function ParseListEntry(element : IXmlDomElement) : TFhirListEntry;
    function ParseList(element : IXmlDomElement) : TFhirList;
    function ParseLocationPosition(element : IXmlDomElement) : TFhirLocationPosition;
    function ParseLocation(element : IXmlDomElement) : TFhirLocation;
    function ParseMedia(element : IXmlDomElement) : TFhirMedia;
    function ParseMedicationProduct(element : IXmlDomElement) : TFhirMedicationProduct;
    function ParseMedicationProductIngredient(element : IXmlDomElement) : TFhirMedicationProductIngredient;
    function ParseMedicationPackage(element : IXmlDomElement) : TFhirMedicationPackage;
    function ParseMedicationPackageContent(element : IXmlDomElement) : TFhirMedicationPackageContent;
    function ParseMedication(element : IXmlDomElement) : TFhirMedication;
    function ParseMedicationAdministrationDosage(element : IXmlDomElement) : TFhirMedicationAdministrationDosage;
    function ParseMedicationAdministration(element : IXmlDomElement) : TFhirMedicationAdministration;
    function ParseMedicationDispenseDispense(element : IXmlDomElement) : TFhirMedicationDispenseDispense;
    function ParseMedicationDispenseDispenseDosage(element : IXmlDomElement) : TFhirMedicationDispenseDispenseDosage;
    function ParseMedicationDispenseSubstitution(element : IXmlDomElement) : TFhirMedicationDispenseSubstitution;
    function ParseMedicationDispense(element : IXmlDomElement) : TFhirMedicationDispense;
    function ParseMedicationPrescriptionDosageInstruction(element : IXmlDomElement) : TFhirMedicationPrescriptionDosageInstruction;
    function ParseMedicationPrescriptionDispense(element : IXmlDomElement) : TFhirMedicationPrescriptionDispense;
    function ParseMedicationPrescriptionSubstitution(element : IXmlDomElement) : TFhirMedicationPrescriptionSubstitution;
    function ParseMedicationPrescription(element : IXmlDomElement) : TFhirMedicationPrescription;
    function ParseMedicationStatementDosage(element : IXmlDomElement) : TFhirMedicationStatementDosage;
    function ParseMedicationStatement(element : IXmlDomElement) : TFhirMedicationStatement;
    function ParseMessageResponse(element : IXmlDomElement) : TFhirMessageResponse;
    function ParseMessageSource(element : IXmlDomElement) : TFhirMessageSource;
    function ParseMessageDestination(element : IXmlDomElement) : TFhirMessageDestination;
    function ParseMessage(element : IXmlDomElement) : TFhirMessage;
    function ParseObservationReferenceRange(element : IXmlDomElement) : TFhirObservationReferenceRange;
    function ParseObservationComponent(element : IXmlDomElement) : TFhirObservationComponent;
    function ParseObservation(element : IXmlDomElement) : TFhirObservation;
    function ParseOperationOutcomeIssue(element : IXmlDomElement) : TFhirOperationOutcomeIssue;
    function ParseOperationOutcome(element : IXmlDomElement) : TFhirOperationOutcome;
    function ParseOrderWhen(element : IXmlDomElement) : TFhirOrderWhen;
    function ParseOrder(element : IXmlDomElement) : TFhirOrder;
    function ParseOrderResponse(element : IXmlDomElement) : TFhirOrderResponse;
    function ParseOrganizationContact(element : IXmlDomElement) : TFhirOrganizationContact;
    function ParseOrganization(element : IXmlDomElement) : TFhirOrganization;
    function ParseOther(element : IXmlDomElement) : TFhirOther;
    function ParsePatientContact(element : IXmlDomElement) : TFhirPatientContact;
    function ParsePatientAnimal(element : IXmlDomElement) : TFhirPatientAnimal;
    function ParsePatient(element : IXmlDomElement) : TFhirPatient;
    function ParsePractitionerQualification(element : IXmlDomElement) : TFhirPractitionerQualification;
    function ParsePractitioner(element : IXmlDomElement) : TFhirPractitioner;
    function ParseProcedurePerformer(element : IXmlDomElement) : TFhirProcedurePerformer;
    function ParseProcedureRelatedItem(element : IXmlDomElement) : TFhirProcedureRelatedItem;
    function ParseProcedure(element : IXmlDomElement) : TFhirProcedure;
    function ParseProfileStructure(element : IXmlDomElement) : TFhirProfileStructure;
    function ParseProfileStructureElement(element : IXmlDomElement) : TFhirProfileStructureElement;
    function ParseProfileStructureElementSlicing(element : IXmlDomElement) : TFhirProfileStructureElementSlicing;
    function ParseProfileStructureElementDefinition(element : IXmlDomElement) : TFhirProfileStructureElementDefinition;
    function ParseProfileStructureElementDefinitionType(element : IXmlDomElement) : TFhirProfileStructureElementDefinitionType;
    function ParseProfileStructureElementDefinitionConstraint(element : IXmlDomElement) : TFhirProfileStructureElementDefinitionConstraint;
    function ParseProfileStructureElementDefinitionMapping(element : IXmlDomElement) : TFhirProfileStructureElementDefinitionMapping;
    function ParseProfileExtensionDefn(element : IXmlDomElement) : TFhirProfileExtensionDefn;
    function ParseProfileBinding(element : IXmlDomElement) : TFhirProfileBinding;
    function ParseProfile(element : IXmlDomElement) : TFhirProfile;
    function ParseProvenanceAgent(element : IXmlDomElement) : TFhirProvenanceAgent;
    function ParseProvenanceEntity(element : IXmlDomElement) : TFhirProvenanceEntity;
    function ParseProvenance(element : IXmlDomElement) : TFhirProvenance;
    function ParseQueryResponse(element : IXmlDomElement) : TFhirQueryResponse;
    function ParseQuery(element : IXmlDomElement) : TFhirQuery;
    function ParseQuestionnaireQuestion(element : IXmlDomElement) : TFhirQuestionnaireQuestion;
    function ParseQuestionnaireGroup(element : IXmlDomElement) : TFhirQuestionnaireGroup;
    function ParseQuestionnaire(element : IXmlDomElement) : TFhirQuestionnaire;
    function ParseRelatedPerson(element : IXmlDomElement) : TFhirRelatedPerson;
    function ParseSecurityEventEvent(element : IXmlDomElement) : TFhirSecurityEventEvent;
    function ParseSecurityEventParticipant(element : IXmlDomElement) : TFhirSecurityEventParticipant;
    function ParseSecurityEventParticipantNetwork(element : IXmlDomElement) : TFhirSecurityEventParticipantNetwork;
    function ParseSecurityEventSource(element : IXmlDomElement) : TFhirSecurityEventSource;
    function ParseSecurityEventObject(element : IXmlDomElement) : TFhirSecurityEventObject;
    function ParseSecurityEventObjectDetail(element : IXmlDomElement) : TFhirSecurityEventObjectDetail;
    function ParseSecurityEvent(element : IXmlDomElement) : TFhirSecurityEvent;
    function ParseSpecimenSource(element : IXmlDomElement) : TFhirSpecimenSource;
    function ParseSpecimenCollection(element : IXmlDomElement) : TFhirSpecimenCollection;
    function ParseSpecimenTreatment(element : IXmlDomElement) : TFhirSpecimenTreatment;
    function ParseSpecimenContainer(element : IXmlDomElement) : TFhirSpecimenContainer;
    function ParseSpecimen(element : IXmlDomElement) : TFhirSpecimen;
    function ParseSubstance(element : IXmlDomElement) : TFhirSubstance;
    function ParseSupplyDispense(element : IXmlDomElement) : TFhirSupplyDispense;
    function ParseSupply(element : IXmlDomElement) : TFhirSupply;
    function ParseValueSetDefine(element : IXmlDomElement) : TFhirValueSetDefine;
    function ParseValueSetDefineConcept(element : IXmlDomElement) : TFhirValueSetDefineConcept;
    function ParseValueSetCompose(element : IXmlDomElement) : TFhirValueSetCompose;
    function ParseValueSetComposeInclude(element : IXmlDomElement) : TFhirValueSetComposeInclude;
    function ParseValueSetComposeIncludeFilter(element : IXmlDomElement) : TFhirValueSetComposeIncludeFilter;
    function ParseValueSetExpansion(element : IXmlDomElement) : TFhirValueSetExpansion;
    function ParseValueSetExpansionContains(element : IXmlDomElement) : TFhirValueSetExpansionContains;
    function ParseValueSet(element : IXmlDomElement) : TFhirValueSet;
    function ParseResource(element : IxmlDomElement) : TFhirResource; override;
  end;

  TFHIRXmlComposer = class (TFHIRXmlComposerBase)
  protected
    Procedure ComposeElementAttributes(xml : TXmlBuilder; element : TFhirElement);
    Procedure ComposeElementChildren(xml : TXmlBuilder; element : TFhirElement);

    Procedure ComposeEnum(xml : TXmlBuilder; name : String; value : TFhirEnum; Const aNames : Array Of String);
    Procedure ComposeInteger(xml : TXmlBuilder; name : String; value : TFhirInteger);
    Procedure ComposeDateTime(xml : TXmlBuilder; name : String; value : TFhirDateTime);
    Procedure ComposeDate(xml : TXmlBuilder; name : String; value : TFhirDate);
    Procedure ComposeDecimal(xml : TXmlBuilder; name : String; value : TFhirDecimal);
    Procedure ComposeUri(xml : TXmlBuilder; name : String; value : TFhirUri);
    Procedure ComposeBase64Binary(xml : TXmlBuilder; name : String; value : TFhirBase64Binary);
    Procedure ComposeString(xml : TXmlBuilder; name : String; value : TFhirString);
    Procedure ComposeBoolean(xml : TXmlBuilder; name : String; value : TFhirBoolean);
    Procedure ComposeInstant(xml : TXmlBuilder; name : String; value : TFhirInstant);
    Procedure ComposeCode(xml : TXmlBuilder; name : String; value : TFhirCode);
    Procedure ComposeId(xml : TXmlBuilder; name : String; value : TFhirId);
    Procedure ComposeOid(xml : TXmlBuilder; name : String; value : TFhirOid);
    Procedure ComposeUuid(xml : TXmlBuilder; name : String; value : TFhirUuid);

    Procedure ComposeResourceAttributes(xml : TXmlBuilder; resource : TFhirResource);
    Procedure ComposeResourceChildren(xml : TXmlBuilder; resource : TFhirResource);

    procedure ComposeExtension(xml : TXmlBuilder; name : string; elem : TFhirExtension);
    procedure ComposeNarrative(xml : TXmlBuilder; name : string; elem : TFhirNarrative);
    procedure ComposePeriod(xml : TXmlBuilder; name : string; elem : TFhirPeriod);
    procedure ComposeCoding(xml : TXmlBuilder; name : string; elem : TFhirCoding);
    procedure ComposeRange(xml : TXmlBuilder; name : string; elem : TFhirRange);
    procedure ComposeQuantity(xml : TXmlBuilder; name : string; elem : TFhirQuantity);
    procedure ComposeChoiceOption(xml : TXmlBuilder; name : string; elem : TFhirChoiceOption);
    procedure ComposeChoice(xml : TXmlBuilder; name : string; elem : TFhirChoice);
    procedure ComposeAttachment(xml : TXmlBuilder; name : string; elem : TFhirAttachment);
    procedure ComposeRatio(xml : TXmlBuilder; name : string; elem : TFhirRatio);
    procedure ComposeSampledData(xml : TXmlBuilder; name : string; elem : TFhirSampledData);
    procedure ComposeResourceReference(xml : TXmlBuilder; name : string; elem : TFhirResourceReference);
    procedure ComposeCodeableConcept(xml : TXmlBuilder; name : string; elem : TFhirCodeableConcept);
    procedure ComposeIdentifier(xml : TXmlBuilder; name : string; elem : TFhirIdentifier);
    procedure ComposeScheduleRepeat(xml : TXmlBuilder; name : string; elem : TFhirScheduleRepeat);
    procedure ComposeSchedule(xml : TXmlBuilder; name : string; elem : TFhirSchedule);
    procedure ComposeContact(xml : TXmlBuilder; name : string; elem : TFhirContact);
    procedure ComposeAddress(xml : TXmlBuilder; name : string; elem : TFhirAddress);
    procedure ComposeHumanName(xml : TXmlBuilder; name : string; elem : TFhirHumanName);
    procedure ComposeAge(xml : TXmlBuilder; name : string; elem : TFhirAge);
    procedure ComposeCount(xml : TXmlBuilder; name : string; elem : TFhirCount);
    procedure ComposeMoney(xml : TXmlBuilder; name : string; elem : TFhirMoney);
    procedure ComposeDistance(xml : TXmlBuilder; name : string; elem : TFhirDistance);
    procedure ComposeDuration(xml : TXmlBuilder; name : string; elem : TFhirDuration);

    procedure ComposeAdverseReactionSymptom(xml : TXmlBuilder; name : string; elem : TFhirAdverseReactionSymptom);
    procedure ComposeAdverseReactionExposure(xml : TXmlBuilder; name : string; elem : TFhirAdverseReactionExposure);
    procedure ComposeAdverseReaction(xml : TXmlBuilder; name : string; elem : TFhirAdverseReaction);
    procedure ComposeAlert(xml : TXmlBuilder; name : string; elem : TFhirAlert);
    procedure ComposeAllergyIntolerance(xml : TXmlBuilder; name : string; elem : TFhirAllergyIntolerance);
    procedure ComposeCarePlanParticipant(xml : TXmlBuilder; name : string; elem : TFhirCarePlanParticipant);
    procedure ComposeCarePlanGoal(xml : TXmlBuilder; name : string; elem : TFhirCarePlanGoal);
    procedure ComposeCarePlanActivity(xml : TXmlBuilder; name : string; elem : TFhirCarePlanActivity);
    procedure ComposeCarePlan(xml : TXmlBuilder; name : string; elem : TFhirCarePlan);
    procedure ComposeConditionStage(xml : TXmlBuilder; name : string; elem : TFhirConditionStage);
    procedure ComposeConditionEvidence(xml : TXmlBuilder; name : string; elem : TFhirConditionEvidence);
    procedure ComposeConditionLocation(xml : TXmlBuilder; name : string; elem : TFhirConditionLocation);
    procedure ComposeConditionRelatedItem(xml : TXmlBuilder; name : string; elem : TFhirConditionRelatedItem);
    procedure ComposeCondition(xml : TXmlBuilder; name : string; elem : TFhirCondition);
    procedure ComposeConformanceSoftware(xml : TXmlBuilder; name : string; elem : TFhirConformanceSoftware);
    procedure ComposeConformanceImplementation(xml : TXmlBuilder; name : string; elem : TFhirConformanceImplementation);
    procedure ComposeConformanceRest(xml : TXmlBuilder; name : string; elem : TFhirConformanceRest);
    procedure ComposeConformanceRestSecurity(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestSecurity);
    procedure ComposeConformanceRestSecurityCertificate(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestSecurityCertificate);
    procedure ComposeConformanceRestResource(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestResource);
    procedure ComposeConformanceRestResourceOperation(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestResourceOperation);
    procedure ComposeConformanceRestResourceSearchParam(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestResourceSearchParam);
    procedure ComposeConformanceRestQuery(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestQuery);
    procedure ComposeConformanceMessaging(xml : TXmlBuilder; name : string; elem : TFhirConformanceMessaging);
    procedure ComposeConformanceMessagingEvent(xml : TXmlBuilder; name : string; elem : TFhirConformanceMessagingEvent);
    procedure ComposeConformanceDocument(xml : TXmlBuilder; name : string; elem : TFhirConformanceDocument);
    procedure ComposeConformance(xml : TXmlBuilder; name : string; elem : TFhirConformance);
    procedure ComposeCoverageSubscriber(xml : TXmlBuilder; name : string; elem : TFhirCoverageSubscriber);
    procedure ComposeCoverage(xml : TXmlBuilder; name : string; elem : TFhirCoverage);
    procedure ComposeDeviceIdentity(xml : TXmlBuilder; name : string; elem : TFhirDeviceIdentity);
    procedure ComposeDevice(xml : TXmlBuilder; name : string; elem : TFhirDevice);
    procedure ComposeDeviceCapabilitiesVirtualDevice(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilitiesVirtualDevice);
    procedure ComposeDeviceCapabilitiesVirtualDeviceChannel(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannel);
    procedure ComposeDeviceCapabilitiesVirtualDeviceChannelMetric(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetric);
    procedure ComposeDeviceCapabilitiesVirtualDeviceChannelMetricInfo(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo);
    procedure ComposeDeviceCapabilitiesVirtualDeviceChannelMetricFacet(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet);
    procedure ComposeDeviceCapabilities(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilities);
    procedure ComposeDeviceLogItem(xml : TXmlBuilder; name : string; elem : TFhirDeviceLogItem);
    procedure ComposeDeviceLog(xml : TXmlBuilder; name : string; elem : TFhirDeviceLog);
    procedure ComposeDeviceObservation(xml : TXmlBuilder; name : string; elem : TFhirDeviceObservation);
    procedure ComposeDiagnosticOrderEvent(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticOrderEvent);
    procedure ComposeDiagnosticOrderItem(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticOrderItem);
    procedure ComposeDiagnosticOrder(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticOrder);
    procedure ComposeDiagnosticReportRequestDetail(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticReportRequestDetail);
    procedure ComposeDiagnosticReportResults(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticReportResults);
    procedure ComposeDiagnosticReport(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticReport);
    procedure ComposeDocumentAttester(xml : TXmlBuilder; name : string; elem : TFhirDocumentAttester);
    procedure ComposeDocumentEvent(xml : TXmlBuilder; name : string; elem : TFhirDocumentEvent);
    procedure ComposeDocumentSection(xml : TXmlBuilder; name : string; elem : TFhirDocumentSection);
    procedure ComposeDocument(xml : TXmlBuilder; name : string; elem : TFhirDocument);
    procedure ComposeDocumentReferenceService(xml : TXmlBuilder; name : string; elem : TFhirDocumentReferenceService);
    procedure ComposeDocumentReferenceServiceParameter(xml : TXmlBuilder; name : string; elem : TFhirDocumentReferenceServiceParameter);
    procedure ComposeDocumentReferenceContext(xml : TXmlBuilder; name : string; elem : TFhirDocumentReferenceContext);
    procedure ComposeDocumentReference(xml : TXmlBuilder; name : string; elem : TFhirDocumentReference);
    procedure ComposeEncounterParticipant(xml : TXmlBuilder; name : string; elem : TFhirEncounterParticipant);
    procedure ComposeEncounterHospitalization(xml : TXmlBuilder; name : string; elem : TFhirEncounterHospitalization);
    procedure ComposeEncounterHospitalizationAccomodation(xml : TXmlBuilder; name : string; elem : TFhirEncounterHospitalizationAccomodation);
    procedure ComposeEncounterLocation(xml : TXmlBuilder; name : string; elem : TFhirEncounterLocation);
    procedure ComposeEncounter(xml : TXmlBuilder; name : string; elem : TFhirEncounter);
    procedure ComposeFamilyHistoryRelation(xml : TXmlBuilder; name : string; elem : TFhirFamilyHistoryRelation);
    procedure ComposeFamilyHistoryRelationCondition(xml : TXmlBuilder; name : string; elem : TFhirFamilyHistoryRelationCondition);
    procedure ComposeFamilyHistory(xml : TXmlBuilder; name : string; elem : TFhirFamilyHistory);
    procedure ComposeGroupCharacteristic(xml : TXmlBuilder; name : string; elem : TFhirGroupCharacteristic);
    procedure ComposeGroup(xml : TXmlBuilder; name : string; elem : TFhirGroup);
    procedure ComposeImagingStudySeries(xml : TXmlBuilder; name : string; elem : TFhirImagingStudySeries);
    procedure ComposeImagingStudySeriesInstance(xml : TXmlBuilder; name : string; elem : TFhirImagingStudySeriesInstance);
    procedure ComposeImagingStudy(xml : TXmlBuilder; name : string; elem : TFhirImagingStudy);
    procedure ComposeImmunizationExplanation(xml : TXmlBuilder; name : string; elem : TFhirImmunizationExplanation);
    procedure ComposeImmunizationReaction(xml : TXmlBuilder; name : string; elem : TFhirImmunizationReaction);
    procedure ComposeImmunizationVaccinationProtocol(xml : TXmlBuilder; name : string; elem : TFhirImmunizationVaccinationProtocol);
    procedure ComposeImmunization(xml : TXmlBuilder; name : string; elem : TFhirImmunization);
    procedure ComposeImmunizationProfileRecommendation(xml : TXmlBuilder; name : string; elem : TFhirImmunizationProfileRecommendation);
    procedure ComposeImmunizationProfileRecommendationDateCriterion(xml : TXmlBuilder; name : string; elem : TFhirImmunizationProfileRecommendationDateCriterion);
    procedure ComposeImmunizationProfileRecommendationProtocol(xml : TXmlBuilder; name : string; elem : TFhirImmunizationProfileRecommendationProtocol);
    procedure ComposeImmunizationProfileRecommendationSupportingAdverseEventReport(xml : TXmlBuilder; name : string; elem : TFhirImmunizationProfileRecommendationSupportingAdverseEventReport);
    procedure ComposeImmunizationProfile(xml : TXmlBuilder; name : string; elem : TFhirImmunizationProfile);
    procedure ComposeListEntry(xml : TXmlBuilder; name : string; elem : TFhirListEntry);
    procedure ComposeList(xml : TXmlBuilder; name : string; elem : TFhirList);
    procedure ComposeLocationPosition(xml : TXmlBuilder; name : string; elem : TFhirLocationPosition);
    procedure ComposeLocation(xml : TXmlBuilder; name : string; elem : TFhirLocation);
    procedure ComposeMedia(xml : TXmlBuilder; name : string; elem : TFhirMedia);
    procedure ComposeMedicationProduct(xml : TXmlBuilder; name : string; elem : TFhirMedicationProduct);
    procedure ComposeMedicationProductIngredient(xml : TXmlBuilder; name : string; elem : TFhirMedicationProductIngredient);
    procedure ComposeMedicationPackage(xml : TXmlBuilder; name : string; elem : TFhirMedicationPackage);
    procedure ComposeMedicationPackageContent(xml : TXmlBuilder; name : string; elem : TFhirMedicationPackageContent);
    procedure ComposeMedication(xml : TXmlBuilder; name : string; elem : TFhirMedication);
    procedure ComposeMedicationAdministrationDosage(xml : TXmlBuilder; name : string; elem : TFhirMedicationAdministrationDosage);
    procedure ComposeMedicationAdministration(xml : TXmlBuilder; name : string; elem : TFhirMedicationAdministration);
    procedure ComposeMedicationDispenseDispense(xml : TXmlBuilder; name : string; elem : TFhirMedicationDispenseDispense);
    procedure ComposeMedicationDispenseDispenseDosage(xml : TXmlBuilder; name : string; elem : TFhirMedicationDispenseDispenseDosage);
    procedure ComposeMedicationDispenseSubstitution(xml : TXmlBuilder; name : string; elem : TFhirMedicationDispenseSubstitution);
    procedure ComposeMedicationDispense(xml : TXmlBuilder; name : string; elem : TFhirMedicationDispense);
    procedure ComposeMedicationPrescriptionDosageInstruction(xml : TXmlBuilder; name : string; elem : TFhirMedicationPrescriptionDosageInstruction);
    procedure ComposeMedicationPrescriptionDispense(xml : TXmlBuilder; name : string; elem : TFhirMedicationPrescriptionDispense);
    procedure ComposeMedicationPrescriptionSubstitution(xml : TXmlBuilder; name : string; elem : TFhirMedicationPrescriptionSubstitution);
    procedure ComposeMedicationPrescription(xml : TXmlBuilder; name : string; elem : TFhirMedicationPrescription);
    procedure ComposeMedicationStatementDosage(xml : TXmlBuilder; name : string; elem : TFhirMedicationStatementDosage);
    procedure ComposeMedicationStatement(xml : TXmlBuilder; name : string; elem : TFhirMedicationStatement);
    procedure ComposeMessageResponse(xml : TXmlBuilder; name : string; elem : TFhirMessageResponse);
    procedure ComposeMessageSource(xml : TXmlBuilder; name : string; elem : TFhirMessageSource);
    procedure ComposeMessageDestination(xml : TXmlBuilder; name : string; elem : TFhirMessageDestination);
    procedure ComposeMessage(xml : TXmlBuilder; name : string; elem : TFhirMessage);
    procedure ComposeObservationReferenceRange(xml : TXmlBuilder; name : string; elem : TFhirObservationReferenceRange);
    procedure ComposeObservationComponent(xml : TXmlBuilder; name : string; elem : TFhirObservationComponent);
    procedure ComposeObservation(xml : TXmlBuilder; name : string; elem : TFhirObservation);
    procedure ComposeOperationOutcomeIssue(xml : TXmlBuilder; name : string; elem : TFhirOperationOutcomeIssue);
    procedure ComposeOperationOutcome(xml : TXmlBuilder; name : string; elem : TFhirOperationOutcome);
    procedure ComposeOrderWhen(xml : TXmlBuilder; name : string; elem : TFhirOrderWhen);
    procedure ComposeOrder(xml : TXmlBuilder; name : string; elem : TFhirOrder);
    procedure ComposeOrderResponse(xml : TXmlBuilder; name : string; elem : TFhirOrderResponse);
    procedure ComposeOrganizationContact(xml : TXmlBuilder; name : string; elem : TFhirOrganizationContact);
    procedure ComposeOrganization(xml : TXmlBuilder; name : string; elem : TFhirOrganization);
    procedure ComposeOther(xml : TXmlBuilder; name : string; elem : TFhirOther);
    procedure ComposePatientContact(xml : TXmlBuilder; name : string; elem : TFhirPatientContact);
    procedure ComposePatientAnimal(xml : TXmlBuilder; name : string; elem : TFhirPatientAnimal);
    procedure ComposePatient(xml : TXmlBuilder; name : string; elem : TFhirPatient);
    procedure ComposePractitionerQualification(xml : TXmlBuilder; name : string; elem : TFhirPractitionerQualification);
    procedure ComposePractitioner(xml : TXmlBuilder; name : string; elem : TFhirPractitioner);
    procedure ComposeProcedurePerformer(xml : TXmlBuilder; name : string; elem : TFhirProcedurePerformer);
    procedure ComposeProcedureRelatedItem(xml : TXmlBuilder; name : string; elem : TFhirProcedureRelatedItem);
    procedure ComposeProcedure(xml : TXmlBuilder; name : string; elem : TFhirProcedure);
    procedure ComposeProfileStructure(xml : TXmlBuilder; name : string; elem : TFhirProfileStructure);
    procedure ComposeProfileStructureElement(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElement);
    procedure ComposeProfileStructureElementSlicing(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElementSlicing);
    procedure ComposeProfileStructureElementDefinition(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElementDefinition);
    procedure ComposeProfileStructureElementDefinitionType(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElementDefinitionType);
    procedure ComposeProfileStructureElementDefinitionConstraint(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElementDefinitionConstraint);
    procedure ComposeProfileStructureElementDefinitionMapping(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElementDefinitionMapping);
    procedure ComposeProfileExtensionDefn(xml : TXmlBuilder; name : string; elem : TFhirProfileExtensionDefn);
    procedure ComposeProfileBinding(xml : TXmlBuilder; name : string; elem : TFhirProfileBinding);
    procedure ComposeProfile(xml : TXmlBuilder; name : string; elem : TFhirProfile);
    procedure ComposeProvenanceAgent(xml : TXmlBuilder; name : string; elem : TFhirProvenanceAgent);
    procedure ComposeProvenanceEntity(xml : TXmlBuilder; name : string; elem : TFhirProvenanceEntity);
    procedure ComposeProvenance(xml : TXmlBuilder; name : string; elem : TFhirProvenance);
    procedure ComposeQueryResponse(xml : TXmlBuilder; name : string; elem : TFhirQueryResponse);
    procedure ComposeQuery(xml : TXmlBuilder; name : string; elem : TFhirQuery);
    procedure ComposeQuestionnaireQuestion(xml : TXmlBuilder; name : string; elem : TFhirQuestionnaireQuestion);
    procedure ComposeQuestionnaireGroup(xml : TXmlBuilder; name : string; elem : TFhirQuestionnaireGroup);
    procedure ComposeQuestionnaire(xml : TXmlBuilder; name : string; elem : TFhirQuestionnaire);
    procedure ComposeRelatedPerson(xml : TXmlBuilder; name : string; elem : TFhirRelatedPerson);
    procedure ComposeSecurityEventEvent(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventEvent);
    procedure ComposeSecurityEventParticipant(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventParticipant);
    procedure ComposeSecurityEventParticipantNetwork(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventParticipantNetwork);
    procedure ComposeSecurityEventSource(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventSource);
    procedure ComposeSecurityEventObject(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventObject);
    procedure ComposeSecurityEventObjectDetail(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventObjectDetail);
    procedure ComposeSecurityEvent(xml : TXmlBuilder; name : string; elem : TFhirSecurityEvent);
    procedure ComposeSpecimenSource(xml : TXmlBuilder; name : string; elem : TFhirSpecimenSource);
    procedure ComposeSpecimenCollection(xml : TXmlBuilder; name : string; elem : TFhirSpecimenCollection);
    procedure ComposeSpecimenTreatment(xml : TXmlBuilder; name : string; elem : TFhirSpecimenTreatment);
    procedure ComposeSpecimenContainer(xml : TXmlBuilder; name : string; elem : TFhirSpecimenContainer);
    procedure ComposeSpecimen(xml : TXmlBuilder; name : string; elem : TFhirSpecimen);
    procedure ComposeSubstance(xml : TXmlBuilder; name : string; elem : TFhirSubstance);
    procedure ComposeSupplyDispense(xml : TXmlBuilder; name : string; elem : TFhirSupplyDispense);
    procedure ComposeSupply(xml : TXmlBuilder; name : string; elem : TFhirSupply);
    procedure ComposeValueSetDefine(xml : TXmlBuilder; name : string; elem : TFhirValueSetDefine);
    procedure ComposeValueSetDefineConcept(xml : TXmlBuilder; name : string; elem : TFhirValueSetDefineConcept);
    procedure ComposeValueSetCompose(xml : TXmlBuilder; name : string; elem : TFhirValueSetCompose);
    procedure ComposeValueSetComposeInclude(xml : TXmlBuilder; name : string; elem : TFhirValueSetComposeInclude);
    procedure ComposeValueSetComposeIncludeFilter(xml : TXmlBuilder; name : string; elem : TFhirValueSetComposeIncludeFilter);
    procedure ComposeValueSetExpansion(xml : TXmlBuilder; name : string; elem : TFhirValueSetExpansion);
    procedure ComposeValueSetExpansionContains(xml : TXmlBuilder; name : string; elem : TFhirValueSetExpansionContains);
    procedure ComposeValueSet(xml : TXmlBuilder; name : string; elem : TFhirValueSet);
    procedure ComposeResource(xml : TXmlBuilder; id, ver : String; resource : TFhirResource); override;
  end;

  TFHIRJsonParser = class (TFHIRJsonParserBase)
  protected
    Function ParseElementProperty(element : TFhirElement) : boolean;

    Function ParseEnum(Const aNames : Array Of String) : TFhirEnum;
    Function ParseInteger : TFhirInteger;
    Function ParseDateTime : TFhirDateTime;
    Function ParseDate : TFhirDate;
    Function ParseDecimal : TFhirDecimal;
    Function ParseUri : TFhirUri;
    Function ParseBase64Binary : TFhirBase64Binary;
    Function ParseString : TFhirString;
    Function ParseBoolean : TFhirBoolean;
    Function ParseInstant : TFhirInstant;
    Function ParseCode : TFhirCode;
    Function ParseId : TFhirId;
    Function ParseOid : TFhirOid;
    Function ParseUuid : TFhirUuid;

    Function ParseResourceProperty(resource : TFhirResource) : boolean;

    function ParseExtension : TFhirExtension;
    function ParseNarrative : TFhirNarrative;
    function ParsePeriod : TFhirPeriod;
    function ParseCoding : TFhirCoding;
    function ParseRange : TFhirRange;
    function ParseQuantity : TFhirQuantity;
    function ParseChoiceOption : TFhirChoiceOption;
    function ParseChoice : TFhirChoice;
    function ParseAttachment : TFhirAttachment;
    function ParseRatio : TFhirRatio;
    function ParseSampledData : TFhirSampledData;
    function ParseResourceReference : TFhirResourceReference;
    function ParseCodeableConcept : TFhirCodeableConcept;
    function ParseIdentifier : TFhirIdentifier;
    function ParseScheduleRepeat : TFhirScheduleRepeat;
    function ParseSchedule : TFhirSchedule;
    function ParseContact : TFhirContact;
    function ParseAddress : TFhirAddress;
    function ParseHumanName : TFhirHumanName;
    function ParseAge : TFhirAge;
    function ParseCount : TFhirCount;
    function ParseMoney : TFhirMoney;
    function ParseDistance : TFhirDistance;
    function ParseDuration : TFhirDuration;

    function ParseAdverseReactionSymptom : TFhirAdverseReactionSymptom;
    function ParseAdverseReactionExposure : TFhirAdverseReactionExposure;
    function ParseAdverseReaction : TFhirAdverseReaction;
    function ParseAlert : TFhirAlert;
    function ParseAllergyIntolerance : TFhirAllergyIntolerance;
    function ParseCarePlanParticipant : TFhirCarePlanParticipant;
    function ParseCarePlanGoal : TFhirCarePlanGoal;
    function ParseCarePlanActivity : TFhirCarePlanActivity;
    function ParseCarePlan : TFhirCarePlan;
    function ParseConditionStage : TFhirConditionStage;
    function ParseConditionEvidence : TFhirConditionEvidence;
    function ParseConditionLocation : TFhirConditionLocation;
    function ParseConditionRelatedItem : TFhirConditionRelatedItem;
    function ParseCondition : TFhirCondition;
    function ParseConformanceSoftware : TFhirConformanceSoftware;
    function ParseConformanceImplementation : TFhirConformanceImplementation;
    function ParseConformanceRest : TFhirConformanceRest;
    function ParseConformanceRestSecurity : TFhirConformanceRestSecurity;
    function ParseConformanceRestSecurityCertificate : TFhirConformanceRestSecurityCertificate;
    function ParseConformanceRestResource : TFhirConformanceRestResource;
    function ParseConformanceRestResourceOperation : TFhirConformanceRestResourceOperation;
    function ParseConformanceRestResourceSearchParam : TFhirConformanceRestResourceSearchParam;
    function ParseConformanceRestQuery : TFhirConformanceRestQuery;
    function ParseConformanceMessaging : TFhirConformanceMessaging;
    function ParseConformanceMessagingEvent : TFhirConformanceMessagingEvent;
    function ParseConformanceDocument : TFhirConformanceDocument;
    function ParseConformance : TFhirConformance;
    function ParseCoverageSubscriber : TFhirCoverageSubscriber;
    function ParseCoverage : TFhirCoverage;
    function ParseDeviceIdentity : TFhirDeviceIdentity;
    function ParseDevice : TFhirDevice;
    function ParseDeviceCapabilitiesVirtualDevice : TFhirDeviceCapabilitiesVirtualDevice;
    function ParseDeviceCapabilitiesVirtualDeviceChannel : TFhirDeviceCapabilitiesVirtualDeviceChannel;
    function ParseDeviceCapabilitiesVirtualDeviceChannelMetric : TFhirDeviceCapabilitiesVirtualDeviceChannelMetric;
    function ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfo : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo;
    function ParseDeviceCapabilitiesVirtualDeviceChannelMetricFacet : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet;
    function ParseDeviceCapabilities : TFhirDeviceCapabilities;
    function ParseDeviceLogItem : TFhirDeviceLogItem;
    function ParseDeviceLog : TFhirDeviceLog;
    function ParseDeviceObservation : TFhirDeviceObservation;
    function ParseDiagnosticOrderEvent : TFhirDiagnosticOrderEvent;
    function ParseDiagnosticOrderItem : TFhirDiagnosticOrderItem;
    function ParseDiagnosticOrder : TFhirDiagnosticOrder;
    function ParseDiagnosticReportRequestDetail : TFhirDiagnosticReportRequestDetail;
    function ParseDiagnosticReportResults : TFhirDiagnosticReportResults;
    function ParseDiagnosticReport : TFhirDiagnosticReport;
    function ParseDocumentAttester : TFhirDocumentAttester;
    function ParseDocumentEvent : TFhirDocumentEvent;
    function ParseDocumentSection : TFhirDocumentSection;
    function ParseDocument : TFhirDocument;
    function ParseDocumentReferenceService : TFhirDocumentReferenceService;
    function ParseDocumentReferenceServiceParameter : TFhirDocumentReferenceServiceParameter;
    function ParseDocumentReferenceContext : TFhirDocumentReferenceContext;
    function ParseDocumentReference : TFhirDocumentReference;
    function ParseEncounterParticipant : TFhirEncounterParticipant;
    function ParseEncounterHospitalization : TFhirEncounterHospitalization;
    function ParseEncounterHospitalizationAccomodation : TFhirEncounterHospitalizationAccomodation;
    function ParseEncounterLocation : TFhirEncounterLocation;
    function ParseEncounter : TFhirEncounter;
    function ParseFamilyHistoryRelation : TFhirFamilyHistoryRelation;
    function ParseFamilyHistoryRelationCondition : TFhirFamilyHistoryRelationCondition;
    function ParseFamilyHistory : TFhirFamilyHistory;
    function ParseGroupCharacteristic : TFhirGroupCharacteristic;
    function ParseGroup : TFhirGroup;
    function ParseImagingStudySeries : TFhirImagingStudySeries;
    function ParseImagingStudySeriesInstance : TFhirImagingStudySeriesInstance;
    function ParseImagingStudy : TFhirImagingStudy;
    function ParseImmunizationExplanation : TFhirImmunizationExplanation;
    function ParseImmunizationReaction : TFhirImmunizationReaction;
    function ParseImmunizationVaccinationProtocol : TFhirImmunizationVaccinationProtocol;
    function ParseImmunization : TFhirImmunization;
    function ParseImmunizationProfileRecommendation : TFhirImmunizationProfileRecommendation;
    function ParseImmunizationProfileRecommendationDateCriterion : TFhirImmunizationProfileRecommendationDateCriterion;
    function ParseImmunizationProfileRecommendationProtocol : TFhirImmunizationProfileRecommendationProtocol;
    function ParseImmunizationProfileRecommendationSupportingAdverseEventReport : TFhirImmunizationProfileRecommendationSupportingAdverseEventReport;
    function ParseImmunizationProfile : TFhirImmunizationProfile;
    function ParseListEntry : TFhirListEntry;
    function ParseList : TFhirList;
    function ParseLocationPosition : TFhirLocationPosition;
    function ParseLocation : TFhirLocation;
    function ParseMedia : TFhirMedia;
    function ParseMedicationProduct : TFhirMedicationProduct;
    function ParseMedicationProductIngredient : TFhirMedicationProductIngredient;
    function ParseMedicationPackage : TFhirMedicationPackage;
    function ParseMedicationPackageContent : TFhirMedicationPackageContent;
    function ParseMedication : TFhirMedication;
    function ParseMedicationAdministrationDosage : TFhirMedicationAdministrationDosage;
    function ParseMedicationAdministration : TFhirMedicationAdministration;
    function ParseMedicationDispenseDispense : TFhirMedicationDispenseDispense;
    function ParseMedicationDispenseDispenseDosage : TFhirMedicationDispenseDispenseDosage;
    function ParseMedicationDispenseSubstitution : TFhirMedicationDispenseSubstitution;
    function ParseMedicationDispense : TFhirMedicationDispense;
    function ParseMedicationPrescriptionDosageInstruction : TFhirMedicationPrescriptionDosageInstruction;
    function ParseMedicationPrescriptionDispense : TFhirMedicationPrescriptionDispense;
    function ParseMedicationPrescriptionSubstitution : TFhirMedicationPrescriptionSubstitution;
    function ParseMedicationPrescription : TFhirMedicationPrescription;
    function ParseMedicationStatementDosage : TFhirMedicationStatementDosage;
    function ParseMedicationStatement : TFhirMedicationStatement;
    function ParseMessageResponse : TFhirMessageResponse;
    function ParseMessageSource : TFhirMessageSource;
    function ParseMessageDestination : TFhirMessageDestination;
    function ParseMessage : TFhirMessage;
    function ParseObservationReferenceRange : TFhirObservationReferenceRange;
    function ParseObservationComponent : TFhirObservationComponent;
    function ParseObservation : TFhirObservation;
    function ParseOperationOutcomeIssue : TFhirOperationOutcomeIssue;
    function ParseOperationOutcome : TFhirOperationOutcome;
    function ParseOrderWhen : TFhirOrderWhen;
    function ParseOrder : TFhirOrder;
    function ParseOrderResponse : TFhirOrderResponse;
    function ParseOrganizationContact : TFhirOrganizationContact;
    function ParseOrganization : TFhirOrganization;
    function ParseOther : TFhirOther;
    function ParsePatientContact : TFhirPatientContact;
    function ParsePatientAnimal : TFhirPatientAnimal;
    function ParsePatient : TFhirPatient;
    function ParsePractitionerQualification : TFhirPractitionerQualification;
    function ParsePractitioner : TFhirPractitioner;
    function ParseProcedurePerformer : TFhirProcedurePerformer;
    function ParseProcedureRelatedItem : TFhirProcedureRelatedItem;
    function ParseProcedure : TFhirProcedure;
    function ParseProfileStructure : TFhirProfileStructure;
    function ParseProfileStructureElement : TFhirProfileStructureElement;
    function ParseProfileStructureElementSlicing : TFhirProfileStructureElementSlicing;
    function ParseProfileStructureElementDefinition : TFhirProfileStructureElementDefinition;
    function ParseProfileStructureElementDefinitionType : TFhirProfileStructureElementDefinitionType;
    function ParseProfileStructureElementDefinitionConstraint : TFhirProfileStructureElementDefinitionConstraint;
    function ParseProfileStructureElementDefinitionMapping : TFhirProfileStructureElementDefinitionMapping;
    function ParseProfileExtensionDefn : TFhirProfileExtensionDefn;
    function ParseProfileBinding : TFhirProfileBinding;
    function ParseProfile : TFhirProfile;
    function ParseProvenanceAgent : TFhirProvenanceAgent;
    function ParseProvenanceEntity : TFhirProvenanceEntity;
    function ParseProvenance : TFhirProvenance;
    function ParseQueryResponse : TFhirQueryResponse;
    function ParseQuery : TFhirQuery;
    function ParseQuestionnaireQuestion : TFhirQuestionnaireQuestion;
    function ParseQuestionnaireGroup : TFhirQuestionnaireGroup;
    function ParseQuestionnaire : TFhirQuestionnaire;
    function ParseRelatedPerson : TFhirRelatedPerson;
    function ParseSecurityEventEvent : TFhirSecurityEventEvent;
    function ParseSecurityEventParticipant : TFhirSecurityEventParticipant;
    function ParseSecurityEventParticipantNetwork : TFhirSecurityEventParticipantNetwork;
    function ParseSecurityEventSource : TFhirSecurityEventSource;
    function ParseSecurityEventObject : TFhirSecurityEventObject;
    function ParseSecurityEventObjectDetail : TFhirSecurityEventObjectDetail;
    function ParseSecurityEvent : TFhirSecurityEvent;
    function ParseSpecimenSource : TFhirSpecimenSource;
    function ParseSpecimenCollection : TFhirSpecimenCollection;
    function ParseSpecimenTreatment : TFhirSpecimenTreatment;
    function ParseSpecimenContainer : TFhirSpecimenContainer;
    function ParseSpecimen : TFhirSpecimen;
    function ParseSubstance : TFhirSubstance;
    function ParseSupplyDispense : TFhirSupplyDispense;
    function ParseSupply : TFhirSupply;
    function ParseValueSetDefine : TFhirValueSetDefine;
    function ParseValueSetDefineConcept : TFhirValueSetDefineConcept;
    function ParseValueSetCompose : TFhirValueSetCompose;
    function ParseValueSetComposeInclude : TFhirValueSetComposeInclude;
    function ParseValueSetComposeIncludeFilter : TFhirValueSetComposeIncludeFilter;
    function ParseValueSetExpansion : TFhirValueSetExpansion;
    function ParseValueSetExpansionContains : TFhirValueSetExpansionContains;
    function ParseValueSet : TFhirValueSet;
    function ParseResource : TFhirResource; override;
  end;

  TFHIRJsonComposer = class (TFHIRJsonComposerBase)
  protected
    Procedure ComposeElementProperties(json : TJSONWriter; elem : TFhirElement);

    Procedure ComposeEnum(json : TJSONWriter; name : String; value : TFhirEnum; Const aNames : Array Of String);
    Procedure ComposeInteger(json : TJSONWriter; name : String; value : TFhirInteger);
    Procedure ComposeDateTime(json : TJSONWriter; name : String; value : TFhirDateTime);
    Procedure ComposeDate(json : TJSONWriter; name : String; value : TFhirDate);
    Procedure ComposeDecimal(json : TJSONWriter; name : String; value : TFhirDecimal);
    Procedure ComposeUri(json : TJSONWriter; name : String; value : TFhirUri);
    Procedure ComposeBase64Binary(json : TJSONWriter; name : String; value : TFhirBase64Binary);
    Procedure ComposeString(json : TJSONWriter; name : String; value : TFhirString);
    Procedure ComposeBoolean(json : TJSONWriter; name : String; value : TFhirBoolean);
    Procedure ComposeInstant(json : TJSONWriter; name : String; value : TFhirInstant);
    Procedure ComposeCode(json : TJSONWriter; name : String; value : TFhirCode);
    Procedure ComposeId(json : TJSONWriter; name : String; value : TFhirId);
    Procedure ComposeOid(json : TJSONWriter; name : String; value : TFhirOid);
    Procedure ComposeUuid(json : TJSONWriter; name : String; value : TFhirUuid);

    Procedure ComposeResourceProperties(json : TJSONWriter; resource : TFhirResource);

    procedure ComposeExtension(json : TJSONWriter; name : string; elem : TFhirExtension);
    procedure ComposeNarrative(json : TJSONWriter; name : string; elem : TFhirNarrative);
    procedure ComposePeriod(json : TJSONWriter; name : string; elem : TFhirPeriod);
    procedure ComposeCoding(json : TJSONWriter; name : string; elem : TFhirCoding);
    procedure ComposeRange(json : TJSONWriter; name : string; elem : TFhirRange);
    procedure ComposeQuantity(json : TJSONWriter; name : string; elem : TFhirQuantity);
    procedure ComposeChoiceOption(json : TJSONWriter; name : string; elem : TFhirChoiceOption);
    procedure ComposeChoice(json : TJSONWriter; name : string; elem : TFhirChoice);
    procedure ComposeAttachment(json : TJSONWriter; name : string; elem : TFhirAttachment);
    procedure ComposeRatio(json : TJSONWriter; name : string; elem : TFhirRatio);
    procedure ComposeSampledData(json : TJSONWriter; name : string; elem : TFhirSampledData);
    procedure ComposeResourceReference(json : TJSONWriter; name : string; elem : TFhirResourceReference);
    procedure ComposeCodeableConcept(json : TJSONWriter; name : string; elem : TFhirCodeableConcept);
    procedure ComposeIdentifier(json : TJSONWriter; name : string; elem : TFhirIdentifier);
    procedure ComposeScheduleRepeat(json : TJSONWriter; name : string; elem : TFhirScheduleRepeat);
    procedure ComposeSchedule(json : TJSONWriter; name : string; elem : TFhirSchedule);
    procedure ComposeContact(json : TJSONWriter; name : string; elem : TFhirContact);
    procedure ComposeAddress(json : TJSONWriter; name : string; elem : TFhirAddress);
    procedure ComposeHumanName(json : TJSONWriter; name : string; elem : TFhirHumanName);
    procedure ComposeAge(json : TJSONWriter; name : string; elem : TFhirAge);
    procedure ComposeCount(json : TJSONWriter; name : string; elem : TFhirCount);
    procedure ComposeMoney(json : TJSONWriter; name : string; elem : TFhirMoney);
    procedure ComposeDistance(json : TJSONWriter; name : string; elem : TFhirDistance);
    procedure ComposeDuration(json : TJSONWriter; name : string; elem : TFhirDuration);

    procedure ComposeAdverseReactionSymptom(json : TJSONWriter; name : string; elem : TFhirAdverseReactionSymptom);
    procedure ComposeAdverseReactionExposure(json : TJSONWriter; name : string; elem : TFhirAdverseReactionExposure);
    procedure ComposeAdverseReaction(json : TJSONWriter; name : string; elem : TFhirAdverseReaction);
    procedure ComposeAlert(json : TJSONWriter; name : string; elem : TFhirAlert);
    procedure ComposeAllergyIntolerance(json : TJSONWriter; name : string; elem : TFhirAllergyIntolerance);
    procedure ComposeCarePlanParticipant(json : TJSONWriter; name : string; elem : TFhirCarePlanParticipant);
    procedure ComposeCarePlanGoal(json : TJSONWriter; name : string; elem : TFhirCarePlanGoal);
    procedure ComposeCarePlanActivity(json : TJSONWriter; name : string; elem : TFhirCarePlanActivity);
    procedure ComposeCarePlan(json : TJSONWriter; name : string; elem : TFhirCarePlan);
    procedure ComposeConditionStage(json : TJSONWriter; name : string; elem : TFhirConditionStage);
    procedure ComposeConditionEvidence(json : TJSONWriter; name : string; elem : TFhirConditionEvidence);
    procedure ComposeConditionLocation(json : TJSONWriter; name : string; elem : TFhirConditionLocation);
    procedure ComposeConditionRelatedItem(json : TJSONWriter; name : string; elem : TFhirConditionRelatedItem);
    procedure ComposeCondition(json : TJSONWriter; name : string; elem : TFhirCondition);
    procedure ComposeConformanceSoftware(json : TJSONWriter; name : string; elem : TFhirConformanceSoftware);
    procedure ComposeConformanceImplementation(json : TJSONWriter; name : string; elem : TFhirConformanceImplementation);
    procedure ComposeConformanceRest(json : TJSONWriter; name : string; elem : TFhirConformanceRest);
    procedure ComposeConformanceRestSecurity(json : TJSONWriter; name : string; elem : TFhirConformanceRestSecurity);
    procedure ComposeConformanceRestSecurityCertificate(json : TJSONWriter; name : string; elem : TFhirConformanceRestSecurityCertificate);
    procedure ComposeConformanceRestResource(json : TJSONWriter; name : string; elem : TFhirConformanceRestResource);
    procedure ComposeConformanceRestResourceOperation(json : TJSONWriter; name : string; elem : TFhirConformanceRestResourceOperation);
    procedure ComposeConformanceRestResourceSearchParam(json : TJSONWriter; name : string; elem : TFhirConformanceRestResourceSearchParam);
    procedure ComposeConformanceRestQuery(json : TJSONWriter; name : string; elem : TFhirConformanceRestQuery);
    procedure ComposeConformanceMessaging(json : TJSONWriter; name : string; elem : TFhirConformanceMessaging);
    procedure ComposeConformanceMessagingEvent(json : TJSONWriter; name : string; elem : TFhirConformanceMessagingEvent);
    procedure ComposeConformanceDocument(json : TJSONWriter; name : string; elem : TFhirConformanceDocument);
    procedure ComposeConformance(json : TJSONWriter; name : string; elem : TFhirConformance);
    procedure ComposeCoverageSubscriber(json : TJSONWriter; name : string; elem : TFhirCoverageSubscriber);
    procedure ComposeCoverage(json : TJSONWriter; name : string; elem : TFhirCoverage);
    procedure ComposeDeviceIdentity(json : TJSONWriter; name : string; elem : TFhirDeviceIdentity);
    procedure ComposeDevice(json : TJSONWriter; name : string; elem : TFhirDevice);
    procedure ComposeDeviceCapabilitiesVirtualDevice(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilitiesVirtualDevice);
    procedure ComposeDeviceCapabilitiesVirtualDeviceChannel(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannel);
    procedure ComposeDeviceCapabilitiesVirtualDeviceChannelMetric(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetric);
    procedure ComposeDeviceCapabilitiesVirtualDeviceChannelMetricInfo(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo);
    procedure ComposeDeviceCapabilitiesVirtualDeviceChannelMetricFacet(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet);
    procedure ComposeDeviceCapabilities(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilities);
    procedure ComposeDeviceLogItem(json : TJSONWriter; name : string; elem : TFhirDeviceLogItem);
    procedure ComposeDeviceLog(json : TJSONWriter; name : string; elem : TFhirDeviceLog);
    procedure ComposeDeviceObservation(json : TJSONWriter; name : string; elem : TFhirDeviceObservation);
    procedure ComposeDiagnosticOrderEvent(json : TJSONWriter; name : string; elem : TFhirDiagnosticOrderEvent);
    procedure ComposeDiagnosticOrderItem(json : TJSONWriter; name : string; elem : TFhirDiagnosticOrderItem);
    procedure ComposeDiagnosticOrder(json : TJSONWriter; name : string; elem : TFhirDiagnosticOrder);
    procedure ComposeDiagnosticReportRequestDetail(json : TJSONWriter; name : string; elem : TFhirDiagnosticReportRequestDetail);
    procedure ComposeDiagnosticReportResults(json : TJSONWriter; name : string; elem : TFhirDiagnosticReportResults);
    procedure ComposeDiagnosticReport(json : TJSONWriter; name : string; elem : TFhirDiagnosticReport);
    procedure ComposeDocumentAttester(json : TJSONWriter; name : string; elem : TFhirDocumentAttester);
    procedure ComposeDocumentEvent(json : TJSONWriter; name : string; elem : TFhirDocumentEvent);
    procedure ComposeDocumentSection(json : TJSONWriter; name : string; elem : TFhirDocumentSection);
    procedure ComposeDocument(json : TJSONWriter; name : string; elem : TFhirDocument);
    procedure ComposeDocumentReferenceService(json : TJSONWriter; name : string; elem : TFhirDocumentReferenceService);
    procedure ComposeDocumentReferenceServiceParameter(json : TJSONWriter; name : string; elem : TFhirDocumentReferenceServiceParameter);
    procedure ComposeDocumentReferenceContext(json : TJSONWriter; name : string; elem : TFhirDocumentReferenceContext);
    procedure ComposeDocumentReference(json : TJSONWriter; name : string; elem : TFhirDocumentReference);
    procedure ComposeEncounterParticipant(json : TJSONWriter; name : string; elem : TFhirEncounterParticipant);
    procedure ComposeEncounterHospitalization(json : TJSONWriter; name : string; elem : TFhirEncounterHospitalization);
    procedure ComposeEncounterHospitalizationAccomodation(json : TJSONWriter; name : string; elem : TFhirEncounterHospitalizationAccomodation);
    procedure ComposeEncounterLocation(json : TJSONWriter; name : string; elem : TFhirEncounterLocation);
    procedure ComposeEncounter(json : TJSONWriter; name : string; elem : TFhirEncounter);
    procedure ComposeFamilyHistoryRelation(json : TJSONWriter; name : string; elem : TFhirFamilyHistoryRelation);
    procedure ComposeFamilyHistoryRelationCondition(json : TJSONWriter; name : string; elem : TFhirFamilyHistoryRelationCondition);
    procedure ComposeFamilyHistory(json : TJSONWriter; name : string; elem : TFhirFamilyHistory);
    procedure ComposeGroupCharacteristic(json : TJSONWriter; name : string; elem : TFhirGroupCharacteristic);
    procedure ComposeGroup(json : TJSONWriter; name : string; elem : TFhirGroup);
    procedure ComposeImagingStudySeries(json : TJSONWriter; name : string; elem : TFhirImagingStudySeries);
    procedure ComposeImagingStudySeriesInstance(json : TJSONWriter; name : string; elem : TFhirImagingStudySeriesInstance);
    procedure ComposeImagingStudy(json : TJSONWriter; name : string; elem : TFhirImagingStudy);
    procedure ComposeImmunizationExplanation(json : TJSONWriter; name : string; elem : TFhirImmunizationExplanation);
    procedure ComposeImmunizationReaction(json : TJSONWriter; name : string; elem : TFhirImmunizationReaction);
    procedure ComposeImmunizationVaccinationProtocol(json : TJSONWriter; name : string; elem : TFhirImmunizationVaccinationProtocol);
    procedure ComposeImmunization(json : TJSONWriter; name : string; elem : TFhirImmunization);
    procedure ComposeImmunizationProfileRecommendation(json : TJSONWriter; name : string; elem : TFhirImmunizationProfileRecommendation);
    procedure ComposeImmunizationProfileRecommendationDateCriterion(json : TJSONWriter; name : string; elem : TFhirImmunizationProfileRecommendationDateCriterion);
    procedure ComposeImmunizationProfileRecommendationProtocol(json : TJSONWriter; name : string; elem : TFhirImmunizationProfileRecommendationProtocol);
    procedure ComposeImmunizationProfileRecommendationSupportingAdverseEventReport(json : TJSONWriter; name : string; elem : TFhirImmunizationProfileRecommendationSupportingAdverseEventReport);
    procedure ComposeImmunizationProfile(json : TJSONWriter; name : string; elem : TFhirImmunizationProfile);
    procedure ComposeListEntry(json : TJSONWriter; name : string; elem : TFhirListEntry);
    procedure ComposeList(json : TJSONWriter; name : string; elem : TFhirList);
    procedure ComposeLocationPosition(json : TJSONWriter; name : string; elem : TFhirLocationPosition);
    procedure ComposeLocation(json : TJSONWriter; name : string; elem : TFhirLocation);
    procedure ComposeMedia(json : TJSONWriter; name : string; elem : TFhirMedia);
    procedure ComposeMedicationProduct(json : TJSONWriter; name : string; elem : TFhirMedicationProduct);
    procedure ComposeMedicationProductIngredient(json : TJSONWriter; name : string; elem : TFhirMedicationProductIngredient);
    procedure ComposeMedicationPackage(json : TJSONWriter; name : string; elem : TFhirMedicationPackage);
    procedure ComposeMedicationPackageContent(json : TJSONWriter; name : string; elem : TFhirMedicationPackageContent);
    procedure ComposeMedication(json : TJSONWriter; name : string; elem : TFhirMedication);
    procedure ComposeMedicationAdministrationDosage(json : TJSONWriter; name : string; elem : TFhirMedicationAdministrationDosage);
    procedure ComposeMedicationAdministration(json : TJSONWriter; name : string; elem : TFhirMedicationAdministration);
    procedure ComposeMedicationDispenseDispense(json : TJSONWriter; name : string; elem : TFhirMedicationDispenseDispense);
    procedure ComposeMedicationDispenseDispenseDosage(json : TJSONWriter; name : string; elem : TFhirMedicationDispenseDispenseDosage);
    procedure ComposeMedicationDispenseSubstitution(json : TJSONWriter; name : string; elem : TFhirMedicationDispenseSubstitution);
    procedure ComposeMedicationDispense(json : TJSONWriter; name : string; elem : TFhirMedicationDispense);
    procedure ComposeMedicationPrescriptionDosageInstruction(json : TJSONWriter; name : string; elem : TFhirMedicationPrescriptionDosageInstruction);
    procedure ComposeMedicationPrescriptionDispense(json : TJSONWriter; name : string; elem : TFhirMedicationPrescriptionDispense);
    procedure ComposeMedicationPrescriptionSubstitution(json : TJSONWriter; name : string; elem : TFhirMedicationPrescriptionSubstitution);
    procedure ComposeMedicationPrescription(json : TJSONWriter; name : string; elem : TFhirMedicationPrescription);
    procedure ComposeMedicationStatementDosage(json : TJSONWriter; name : string; elem : TFhirMedicationStatementDosage);
    procedure ComposeMedicationStatement(json : TJSONWriter; name : string; elem : TFhirMedicationStatement);
    procedure ComposeMessageResponse(json : TJSONWriter; name : string; elem : TFhirMessageResponse);
    procedure ComposeMessageSource(json : TJSONWriter; name : string; elem : TFhirMessageSource);
    procedure ComposeMessageDestination(json : TJSONWriter; name : string; elem : TFhirMessageDestination);
    procedure ComposeMessage(json : TJSONWriter; name : string; elem : TFhirMessage);
    procedure ComposeObservationReferenceRange(json : TJSONWriter; name : string; elem : TFhirObservationReferenceRange);
    procedure ComposeObservationComponent(json : TJSONWriter; name : string; elem : TFhirObservationComponent);
    procedure ComposeObservation(json : TJSONWriter; name : string; elem : TFhirObservation);
    procedure ComposeOperationOutcomeIssue(json : TJSONWriter; name : string; elem : TFhirOperationOutcomeIssue);
    procedure ComposeOperationOutcome(json : TJSONWriter; name : string; elem : TFhirOperationOutcome);
    procedure ComposeOrderWhen(json : TJSONWriter; name : string; elem : TFhirOrderWhen);
    procedure ComposeOrder(json : TJSONWriter; name : string; elem : TFhirOrder);
    procedure ComposeOrderResponse(json : TJSONWriter; name : string; elem : TFhirOrderResponse);
    procedure ComposeOrganizationContact(json : TJSONWriter; name : string; elem : TFhirOrganizationContact);
    procedure ComposeOrganization(json : TJSONWriter; name : string; elem : TFhirOrganization);
    procedure ComposeOther(json : TJSONWriter; name : string; elem : TFhirOther);
    procedure ComposePatientContact(json : TJSONWriter; name : string; elem : TFhirPatientContact);
    procedure ComposePatientAnimal(json : TJSONWriter; name : string; elem : TFhirPatientAnimal);
    procedure ComposePatient(json : TJSONWriter; name : string; elem : TFhirPatient);
    procedure ComposePractitionerQualification(json : TJSONWriter; name : string; elem : TFhirPractitionerQualification);
    procedure ComposePractitioner(json : TJSONWriter; name : string; elem : TFhirPractitioner);
    procedure ComposeProcedurePerformer(json : TJSONWriter; name : string; elem : TFhirProcedurePerformer);
    procedure ComposeProcedureRelatedItem(json : TJSONWriter; name : string; elem : TFhirProcedureRelatedItem);
    procedure ComposeProcedure(json : TJSONWriter; name : string; elem : TFhirProcedure);
    procedure ComposeProfileStructure(json : TJSONWriter; name : string; elem : TFhirProfileStructure);
    procedure ComposeProfileStructureElement(json : TJSONWriter; name : string; elem : TFhirProfileStructureElement);
    procedure ComposeProfileStructureElementSlicing(json : TJSONWriter; name : string; elem : TFhirProfileStructureElementSlicing);
    procedure ComposeProfileStructureElementDefinition(json : TJSONWriter; name : string; elem : TFhirProfileStructureElementDefinition);
    procedure ComposeProfileStructureElementDefinitionType(json : TJSONWriter; name : string; elem : TFhirProfileStructureElementDefinitionType);
    procedure ComposeProfileStructureElementDefinitionConstraint(json : TJSONWriter; name : string; elem : TFhirProfileStructureElementDefinitionConstraint);
    procedure ComposeProfileStructureElementDefinitionMapping(json : TJSONWriter; name : string; elem : TFhirProfileStructureElementDefinitionMapping);
    procedure ComposeProfileExtensionDefn(json : TJSONWriter; name : string; elem : TFhirProfileExtensionDefn);
    procedure ComposeProfileBinding(json : TJSONWriter; name : string; elem : TFhirProfileBinding);
    procedure ComposeProfile(json : TJSONWriter; name : string; elem : TFhirProfile);
    procedure ComposeProvenanceAgent(json : TJSONWriter; name : string; elem : TFhirProvenanceAgent);
    procedure ComposeProvenanceEntity(json : TJSONWriter; name : string; elem : TFhirProvenanceEntity);
    procedure ComposeProvenance(json : TJSONWriter; name : string; elem : TFhirProvenance);
    procedure ComposeQueryResponse(json : TJSONWriter; name : string; elem : TFhirQueryResponse);
    procedure ComposeQuery(json : TJSONWriter; name : string; elem : TFhirQuery);
    procedure ComposeQuestionnaireQuestion(json : TJSONWriter; name : string; elem : TFhirQuestionnaireQuestion);
    procedure ComposeQuestionnaireGroup(json : TJSONWriter; name : string; elem : TFhirQuestionnaireGroup);
    procedure ComposeQuestionnaire(json : TJSONWriter; name : string; elem : TFhirQuestionnaire);
    procedure ComposeRelatedPerson(json : TJSONWriter; name : string; elem : TFhirRelatedPerson);
    procedure ComposeSecurityEventEvent(json : TJSONWriter; name : string; elem : TFhirSecurityEventEvent);
    procedure ComposeSecurityEventParticipant(json : TJSONWriter; name : string; elem : TFhirSecurityEventParticipant);
    procedure ComposeSecurityEventParticipantNetwork(json : TJSONWriter; name : string; elem : TFhirSecurityEventParticipantNetwork);
    procedure ComposeSecurityEventSource(json : TJSONWriter; name : string; elem : TFhirSecurityEventSource);
    procedure ComposeSecurityEventObject(json : TJSONWriter; name : string; elem : TFhirSecurityEventObject);
    procedure ComposeSecurityEventObjectDetail(json : TJSONWriter; name : string; elem : TFhirSecurityEventObjectDetail);
    procedure ComposeSecurityEvent(json : TJSONWriter; name : string; elem : TFhirSecurityEvent);
    procedure ComposeSpecimenSource(json : TJSONWriter; name : string; elem : TFhirSpecimenSource);
    procedure ComposeSpecimenCollection(json : TJSONWriter; name : string; elem : TFhirSpecimenCollection);
    procedure ComposeSpecimenTreatment(json : TJSONWriter; name : string; elem : TFhirSpecimenTreatment);
    procedure ComposeSpecimenContainer(json : TJSONWriter; name : string; elem : TFhirSpecimenContainer);
    procedure ComposeSpecimen(json : TJSONWriter; name : string; elem : TFhirSpecimen);
    procedure ComposeSubstance(json : TJSONWriter; name : string; elem : TFhirSubstance);
    procedure ComposeSupplyDispense(json : TJSONWriter; name : string; elem : TFhirSupplyDispense);
    procedure ComposeSupply(json : TJSONWriter; name : string; elem : TFhirSupply);
    procedure ComposeValueSetDefine(json : TJSONWriter; name : string; elem : TFhirValueSetDefine);
    procedure ComposeValueSetDefineConcept(json : TJSONWriter; name : string; elem : TFhirValueSetDefineConcept);
    procedure ComposeValueSetCompose(json : TJSONWriter; name : string; elem : TFhirValueSetCompose);
    procedure ComposeValueSetComposeInclude(json : TJSONWriter; name : string; elem : TFhirValueSetComposeInclude);
    procedure ComposeValueSetComposeIncludeFilter(json : TJSONWriter; name : string; elem : TFhirValueSetComposeIncludeFilter);
    procedure ComposeValueSetExpansion(json : TJSONWriter; name : string; elem : TFhirValueSetExpansion);
    procedure ComposeValueSetExpansionContains(json : TJSONWriter; name : string; elem : TFhirValueSetExpansionContains);
    procedure ComposeValueSet(json : TJSONWriter; name : string; elem : TFhirValueSet);
    procedure ComposeResource(json : TJSONWriter; id, ver : String; resource : TFhirResource); override;
  end;


implementation

{ TFHIRXmlParser }

Procedure TFHIRXmlParser.ParseElementAttributes(value : TFhirElement; element : IXmlDomElement);
begin
  TakeCommentsStart(value);
  value.xmlId := GetAttribute(element, 'id');
end;

Function TFHIRXmlParser.ParseElementChild(element : TFhirElement; child : IXmlDomElement) : boolean;
begin
  result := true;
  if (child.baseName = 'extension') then
    element.ExtensionList.add(ParseExtension(child))
  else
    result := false;
end;

Function TFHIRJsonParser.ParseElementProperty(element : TFhirElement) : boolean;
begin
  result := true;
  if (json.ItemName = '_id') then
    element.xmlId := json.itemValue
  else if (json.ItemName = 'extension') then
  begin
    json.checkState(jpitArray);
    json.Next;
    while (json.ItemType <> jpitEnd) do
    begin
      element.extensionList.Add(ParseExtension);
      json.Next;
    end;
  end
  else
    result := false;

end;

Procedure TFHIRXmlComposer.ComposeElementAttributes(xml : TXmlBuilder; element : TFhirElement);
begin
  CommentsStart(xml, element);
  Attribute(xml, 'id', element.xmlId);
end;

Procedure TFHIRXmlComposer.ComposeElementChildren(xml : TXmlBuilder; element : TFhirElement);
var
  i : integer;
begin
  if element.hasExtensions then
    for i := 0 to element.extensionList.count - 1 do
       ComposeExtension(xml, 'extension', element.extensionList[i]);
end;

Procedure TFHIRJsonComposer.ComposeElementProperties(json : TJSONWriter; elem : TFhirElement);
var
  i : integer;
begin
  Prop(json, '_id', elem.xmlId);
  if elem.hasExtensions then
  begin
    json.valueArray('extension');
    for i := 0 to elem.extensionList.count - 1 do
       ComposeExtension(json, '', elem.extensionList[i]);
    json.FinishArray;
  end;
end;

function TFHIRXmlParser.ParseEnum(Const aNames : Array Of String; element : IXmlDomElement) : TFhirEnum;
var
  child : IXMLDOMElement;
begin
  result := TFhirEnum.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    if StringArrayIndexOf(aNames, result.value) < 0 then
      raise Exception.create('unknown code: '+result.value);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseEnum(Const aNames : Array Of String) : TFhirEnum;
begin
  FJson.next;
  result := TFhirEnum.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    if StringArrayIndexOf(aNames, result.value) < 0 then
      raise Exception.create('unknown code: '+result.value);
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeEnum(xml : TXmlBuilder; name : String; value : TFhirEnum; Const aNames : Array Of String);
begin
  if (value = nil) then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeEnum(json : TJSONWriter; name : String; value : TFhirEnum; Const aNames : Array Of String);
begin
  if (value = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseInteger(element : IXmlDomElement) : TFhirInteger;
var
  child : IXMLDOMElement;
begin
  result := TFhirInteger.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseInteger: TFhirInteger;
begin
  FJson.next;
  result := TFhirInteger.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeInteger(xml : TXmlBuilder; name : String; value : TFhirInteger);
begin
  if (value = nil) or (value.value = '') then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeInteger(json : TJSONWriter; name : String; value : TFhirInteger);
begin
  if (value = nil) or (value.value = '') then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDateTime(element : IXmlDomElement) : TFhirDateTime;
var
  child : IXMLDOMElement;
begin
  result := TFhirDateTime.create;
  try
    ParseElementAttributes(result, element);
    result.value := toTDateAndTime(GetAttribute(element, 'value'));
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseDateTime: TFhirDateTime;
begin
  FJson.next;
  result := TFhirDateTime.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := toTDateAndTime(FJson.ItemValue)
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeDateTime(xml : TXmlBuilder; name : String; value : TFhirDateTime);
begin
  if (value = nil) or (value.value = nil) then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', toString(value.value));
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeDateTime(json : TJSONWriter; name : String; value : TFhirDateTime);
begin
  if (value = nil) or (value.value = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', toString(value.value));
  json.finishObject;
end;

function TFHIRXmlParser.ParseDate(element : IXmlDomElement) : TFhirDate;
var
  child : IXMLDOMElement;
begin
  result := TFhirDate.create;
  try
    ParseElementAttributes(result, element);
    result.value := toTDateAndTime(GetAttribute(element, 'value'));
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseDate: TFhirDate;
begin
  FJson.next;
  result := TFhirDate.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := toTDateAndTime(FJson.ItemValue)
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeDate(xml : TXmlBuilder; name : String; value : TFhirDate);
begin
  if (value = nil) or (value.value = nil) then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', toString(value.value));
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeDate(json : TJSONWriter; name : String; value : TFhirDate);
begin
  if (value = nil) or (value.value = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', toString(value.value));
  json.finishObject;
end;

function TFHIRXmlParser.ParseDecimal(element : IXmlDomElement) : TFhirDecimal;
var
  child : IXMLDOMElement;
begin
  result := TFhirDecimal.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseDecimal: TFhirDecimal;
begin
  FJson.next;
  result := TFhirDecimal.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeDecimal(xml : TXmlBuilder; name : String; value : TFhirDecimal);
begin
  if (value = nil) or (value.value = '') then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeDecimal(json : TJSONWriter; name : String; value : TFhirDecimal);
begin
  if (value = nil) or (value.value = '') then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseUri(element : IXmlDomElement) : TFhirUri;
var
  child : IXMLDOMElement;
begin
  result := TFhirUri.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseUri: TFhirUri;
begin
  FJson.next;
  result := TFhirUri.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeUri(xml : TXmlBuilder; name : String; value : TFhirUri);
begin
  if (value = nil) or (value.value = '') then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeUri(json : TJSONWriter; name : String; value : TFhirUri);
begin
  if (value = nil) or (value.value = '') then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseBase64Binary(element : IXmlDomElement) : TFhirBase64Binary;
var
  child : IXMLDOMElement;
begin
  result := TFhirBase64Binary.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseBase64Binary: TFhirBase64Binary;
begin
  FJson.next;
  result := TFhirBase64Binary.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeBase64Binary(xml : TXmlBuilder; name : String; value : TFhirBase64Binary);
begin
  if (value = nil) or (value.value = '') then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeBase64Binary(json : TJSONWriter; name : String; value : TFhirBase64Binary);
begin
  if (value = nil) or (value.value = '') then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseString(element : IXmlDomElement) : TFhirString;
var
  child : IXMLDOMElement;
begin
  result := TFhirString.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseString: TFhirString;
begin
  FJson.next;
  result := TFhirString.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeString(xml : TXmlBuilder; name : String; value : TFhirString);
begin
  if (value = nil) or (value.value = '') then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeString(json : TJSONWriter; name : String; value : TFhirString);
begin
  if (value = nil) or (value.value = '') then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseBoolean(element : IXmlDomElement) : TFhirBoolean;
var
  child : IXMLDOMElement;
begin
  result := TFhirBoolean.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseBoolean: TFhirBoolean;
begin
  FJson.next;
  result := TFhirBoolean.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeBoolean(xml : TXmlBuilder; name : String; value : TFhirBoolean);
begin
  if (value = nil) or (value.value = '') then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeBoolean(json : TJSONWriter; name : String; value : TFhirBoolean);
begin
  if (value = nil) or (value.value = '') then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseInstant(element : IXmlDomElement) : TFhirInstant;
var
  child : IXMLDOMElement;
begin
  result := TFhirInstant.create;
  try
    ParseElementAttributes(result, element);
    result.value := toTDateAndTime(GetAttribute(element, 'value'));
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseInstant: TFhirInstant;
begin
  FJson.next;
  result := TFhirInstant.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := toTDateAndTime(FJson.ItemValue)
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeInstant(xml : TXmlBuilder; name : String; value : TFhirInstant);
begin
  if (value = nil) or (value.value = nil) then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', toString(value.value));
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeInstant(json : TJSONWriter; name : String; value : TFhirInstant);
begin
  if (value = nil) or (value.value = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', toString(value.value));
  json.finishObject;
end;

function TFHIRXmlParser.ParseCode(element : IXmlDomElement) : TFhirCode;
var
  child : IXMLDOMElement;
begin
  result := TFhirCode.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseCode: TFhirCode;
begin
  FJson.next;
  result := TFhirCode.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeCode(xml : TXmlBuilder; name : String; value : TFhirCode);
begin
  if (value = nil) or (value.value = '') then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeCode(json : TJSONWriter; name : String; value : TFhirCode);
begin
  if (value = nil) or (value.value = '') then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseId(element : IXmlDomElement) : TFhirId;
var
  child : IXMLDOMElement;
begin
  result := TFhirId.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseId: TFhirId;
begin
  FJson.next;
  result := TFhirId.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeId(xml : TXmlBuilder; name : String; value : TFhirId);
begin
  if (value = nil) or (value.value = '') then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeId(json : TJSONWriter; name : String; value : TFhirId);
begin
  if (value = nil) or (value.value = '') then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseOid(element : IXmlDomElement) : TFhirOid;
var
  child : IXMLDOMElement;
begin
  result := TFhirOid.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseOid: TFhirOid;
begin
  FJson.next;
  result := TFhirOid.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeOid(xml : TXmlBuilder; name : String; value : TFhirOid);
begin
  if (value = nil) or (value.value = '') then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeOid(json : TJSONWriter; name : String; value : TFhirOid);
begin
  if (value = nil) or (value.value = '') then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseUuid(element : IXmlDomElement) : TFhirUuid;
var
  child : IXMLDOMElement;
begin
  result := TFhirUuid.create;
  try
    ParseElementAttributes(result, element);
    result.value := GetAttribute(element, 'value');
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

function TFHIRJsonParser.ParseUuid: TFhirUuid;
begin
  FJson.next;
  result := TFhirUuid.Create;
  try
    while (FJson.ItemType <> jpitEnd) do
    begin
      if (FJson.ItemName = 'value') then
        result.value := FJson.ItemValue
      else if not ParseElementProperty(result) then
         UnknownContent;
      FJson.next;
    end;
    result.Link;
  finally
    result.Free;
  end;
end;

Procedure TFHIRXmlComposer.ComposeUuid(xml : TXmlBuilder; name : String; value : TFhirUuid);
begin
  if (value = nil) or (value.value = '') then
    exit;
  composeElementAttributes(xml, value);
  attribute(xml, 'value', value.value);
  xml.open(name);
  composeElementChildren(xml, value);
  closeOutElement(xml, value);
  xml.close(name);
end;

Procedure TFHIRJsonComposer.ComposeUuid(json : TJSONWriter; name : String; value : TFhirUuid);
begin
  if (value = nil) or (value.value = '') then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, value);
  prop(json, 'value', value.value);
  json.finishObject;
end;

Procedure TFHIRXmlParser.ParseResourceAttributes(resource : TFhirResource; element : IXmlDomElement);
begin
  ParseElementAttributes(resource, element);
  // lang
end;

Function TFHIRXmlParser.ParseResourceChild(resource : TFhirResource; child : IXmlDomElement) : boolean;
begin
  result := true;
  if (child.baseName = 'text') then
    resource.text := ParseNarrative(child)
  else if (child.baseName = 'language') then
    resource.language := ParseCode(child)
  else if (child.baseName = 'contained') then
    resource.ContainedList.add(ParseContained(child))
  else if not parseElementChild(resource, child) then
    result := false;
end;

Function TFHIRJsonParser.ParseResourceProperty(resource : TFhirResource) : boolean;
begin
  result := true;
  if (json.ItemName = 'language') then
    resource.language := parseCode
  else if (json.ItemName = 'text') then
    resource.text := parseNarrative
  else if (json.ItemName = 'contained') then
  begin
    json.checkState(jpitArray);
    json.Next;
    while (json.ItemType <> jpitEnd) do
    begin
      resource.containedList.Add(ParseContained);
      json.Next;
    end;
  end
  else if not ParseElementProperty(resource) then
    result := false;

end;

Procedure TFHIRXmlComposer.ComposeResourceAttributes(xml : TXmlBuilder; resource : TFhirResource);
begin
  ComposeElementAttributes(xml, resource);
end;

Procedure TFHIRXmlComposer.ComposeResourceChildren(xml : TXmlBuilder; resource : TFhirResource);
var
  i : integer;
begin
  composeElementChildren(xml, resource);
  composeCode(xml, 'language', resource.language);
  composeNarrative(xml, 'text', resource.text);
  for i := 0 to resource.containedList.count - 1 do
    ComposeContained(xml, 'contained', resource.containedList[i]);
end;

Procedure TFHIRJsonComposer.ComposeResourceProperties(json : TJSONWriter; resource : TFhirResource);
var
  i : integer;
begin
  ComposeElementProperties(json, resource);
  composeCode(json, 'language', resource.language);
  ComposeNarrative(json, 'text', resource.text);
  if resource.containedList.count > 0 then
  begin
    json.valueArray('contained');
    for i := 0 to resource.containedList.Count - 1 do
      ComposeContained(json, resource.containedList[i]);
    json.FinishArray;
  end;
end;

function TFHIRXmlParser.ParseExtension(element : IXmlDomElement) : TFhirExtension;
var
  child : IXMLDOMElement;
begin
  result := TFhirExtension.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'url') then
        result.url := ParseUri(child) {b}
      else if (child.baseName = 'isModifier') then
        result.isModifier := ParseBoolean(child) {b}
      else if (child.baseName = 'valueInteger') then
        result.value := ParseInteger(child) {c}
      else if (child.baseName = 'valueDateTime') then
        result.value := ParseDateTime(child) {c}
      else if (child.baseName = 'valueCode') then
        result.value := ParseCode(child) {c}
      else if (child.baseName = 'valueDate') then
        result.value := ParseDate(child) {c}
      else if (child.baseName = 'valueDecimal') then
        result.value := ParseDecimal(child) {c}
      else if (child.baseName = 'valueUri') then
        result.value := ParseUri(child) {c}
      else if (child.baseName = 'valueId') then
        result.value := ParseId(child) {c}
      else if (child.baseName = 'valueBase64Binary') then
        result.value := ParseBase64Binary(child) {c}
      else if (child.baseName = 'valueOid') then
        result.value := ParseOid(child) {c}
      else if (child.baseName = 'valueString') then
        result.value := ParseString(child) {c}
      else if (child.baseName = 'valueBoolean') then
        result.value := ParseBoolean(child) {c}
      else if (child.baseName = 'valueUuid') then
        result.value := ParseUuid(child) {c}
      else if (child.baseName = 'valueInstant') then
        result.value := ParseInstant(child) {c}
      else if (child.baseName = 'valuePeriod') then
        result.value := ParsePeriod(child) {ePeriod}
      else if (child.baseName = 'valueCoding') then
        result.value := ParseCoding(child) {eCoding}
      else if (child.baseName = 'valueRange') then
        result.value := ParseRange(child) {eRange}
      else if (child.baseName = 'valueQuantity') then
        result.value := ParseQuantity(child) {eQuantity}
      else if (child.baseName = 'valueChoice') then
        result.value := ParseChoice(child) {eChoice}
      else if (child.baseName = 'valueAttachment') then
        result.value := ParseAttachment(child) {eAttachment}
      else if (child.baseName = 'valueRatio') then
        result.value := ParseRatio(child) {eRatio}
      else if (child.baseName = 'valueSampledData') then
        result.value := ParseSampledData(child) {eSampledData}
      else if (child.baseName = 'valueResource') then
        result.value := ParseResourceReference(child) {e0}
      else if (child.baseName = 'valueCodeableConcept') then
        result.value := ParseCodeableConcept(child) {eCodeableConcept}
      else if (child.baseName = 'valueIdentifier') then
        result.value := ParseIdentifier(child) {eIdentifier}
      else if (child.baseName = 'valueSchedule') then
        result.value := ParseSchedule(child) {f}
      else if (child.baseName = 'valueContact') then
        result.value := ParseContact(child) {f}
      else if (child.baseName = 'valueAddress') then
        result.value := ParseAddress(child) {f}
      else if (child.baseName = 'valueHumanName') then
        result.value := ParseHumanName(child) {f}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeExtension(xml : TXmlBuilder; name : string; elem : TFhirExtension);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeUri(xml, 'url', elem.url);
  ComposeBoolean(xml, 'isModifier', elem.isModifier);
  if elem.value is TFhirInteger {1} then
    ComposeInteger(xml, 'valueInteger', TFhirInteger(elem.value))
  else if elem.value is TFhirDateTime {1} then
    ComposeDateTime(xml, 'valueDateTime', TFhirDateTime(elem.value))
  else if elem.value is TFhirCode {1} then
    ComposeCode(xml, 'valueCode', TFhirCode(elem.value))
  else if elem.value is TFhirDate {1} then
    ComposeDate(xml, 'valueDate', TFhirDate(elem.value))
  else if elem.value is TFhirDecimal {1} then
    ComposeDecimal(xml, 'valueDecimal', TFhirDecimal(elem.value))
  else if elem.value is TFhirUri {1} then
    ComposeUri(xml, 'valueUri', TFhirUri(elem.value))
  else if elem.value is TFhirId {1} then
    ComposeId(xml, 'valueId', TFhirId(elem.value))
  else if elem.value is TFhirBase64Binary {1} then
    ComposeBase64Binary(xml, 'valueBase64Binary', TFhirBase64Binary(elem.value))
  else if elem.value is TFhirOid {1} then
    ComposeOid(xml, 'valueOid', TFhirOid(elem.value))
  else if elem.value is TFhirString {1} then
    ComposeString(xml, 'valueString', TFhirString(elem.value))
  else if elem.value is TFhirBoolean {1} then
    ComposeBoolean(xml, 'valueBoolean', TFhirBoolean(elem.value))
  else if elem.value is TFhirUuid {1} then
    ComposeUuid(xml, 'valueUuid', TFhirUuid(elem.value))
  else if elem.value is TFhirInstant {1} then
    ComposeInstant(xml, 'valueInstant', TFhirInstant(elem.value))
  else if elem.value is TFhirPeriod {8} then
    ComposePeriod(xml, 'valuePeriod', TFhirPeriod(elem.value))
  else if elem.value is TFhirCoding {8} then
    ComposeCoding(xml, 'valueCoding', TFhirCoding(elem.value))
  else if elem.value is TFhirRange {8} then
    ComposeRange(xml, 'valueRange', TFhirRange(elem.value))
  else if elem.value is TFhirQuantity {8} then
    ComposeQuantity(xml, 'valueQuantity', TFhirQuantity(elem.value))
  else if elem.value is TFhirChoice {8} then
    ComposeChoice(xml, 'valueChoice', TFhirChoice(elem.value))
  else if elem.value is TFhirAttachment {8} then
    ComposeAttachment(xml, 'valueAttachment', TFhirAttachment(elem.value))
  else if elem.value is TFhirRatio {8} then
    ComposeRatio(xml, 'valueRatio', TFhirRatio(elem.value))
  else if elem.value is TFhirSampledData {8} then
    ComposeSampledData(xml, 'valueSampledData', TFhirSampledData(elem.value))
  else if elem.value is TFhirResourceReference {8} then
    ComposeResourceReference(xml, 'valueResource', TFhirResourceReference(elem.value))
  else if elem.value is TFhirCodeableConcept {8} then
    ComposeCodeableConcept(xml, 'valueCodeableConcept', TFhirCodeableConcept(elem.value))
  else if elem.value is TFhirIdentifier {8} then
    ComposeIdentifier(xml, 'valueIdentifier', TFhirIdentifier(elem.value))
  else if elem.value is TFhirSchedule {9} then
    ComposeSchedule(xml, 'valueSchedule', TFhirSchedule(elem.value))
  else if elem.value is TFhirContact {9} then
    ComposeContact(xml, 'valueContact', TFhirContact(elem.value))
  else if elem.value is TFhirAddress {9} then
    ComposeAddress(xml, 'valueAddress', TFhirAddress(elem.value))
  else if elem.value is TFhirHumanName {9} then
    ComposeHumanName(xml, 'valueHumanName', TFhirHumanName(elem.value));
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseExtension : TFhirExtension;
begin
  json.next;
  result := TFhirExtension.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'url') then
        result.url := ParseUri
      else if (json.ItemName = 'isModifier') then
        result.isModifier := ParseBoolean
      else if (json.ItemName = 'valueInteger') then
        result.value := ParseInteger
      else if (json.ItemName = 'valueDateTime') then
        result.value := ParseDateTime
      else if (json.ItemName = 'valueCode') then
        result.value := ParseCode
      else if (json.ItemName = 'valueDate') then
        result.value := ParseDate
      else if (json.ItemName = 'valueDecimal') then
        result.value := ParseDecimal
      else if (json.ItemName = 'valueUri') then
        result.value := ParseUri
      else if (json.ItemName = 'valueId') then
        result.value := ParseId
      else if (json.ItemName = 'valueBase64Binary') then
        result.value := ParseBase64Binary
      else if (json.ItemName = 'valueOid') then
        result.value := ParseOid
      else if (json.ItemName = 'valueString') then
        result.value := ParseString
      else if (json.ItemName = 'valueBoolean') then
        result.value := ParseBoolean
      else if (json.ItemName = 'valueUuid') then
        result.value := ParseUuid
      else if (json.ItemName = 'valueInstant') then
        result.value := ParseInstant
      else if (json.ItemName = 'valuePeriod') then
        result.value := ParsePeriod
      else if (json.ItemName = 'valueCoding') then
        result.value := ParseCoding
      else if (json.ItemName = 'valueRange') then
        result.value := ParseRange
      else if (json.ItemName = 'valueQuantity') then
        result.value := ParseQuantity
      else if (json.ItemName = 'valueChoice') then
        result.value := ParseChoice
      else if (json.ItemName = 'valueAttachment') then
        result.value := ParseAttachment
      else if (json.ItemName = 'valueRatio') then
        result.value := ParseRatio
      else if (json.ItemName = 'valueSampledData') then
        result.value := ParseSampledData
      else if (json.ItemName = 'valueResource') then
        result.value := ParseResourceReference
      else if (json.ItemName = 'valueCodeableConcept') then
        result.value := ParseCodeableConcept
      else if (json.ItemName = 'valueIdentifier') then
        result.value := ParseIdentifier
      else if (json.ItemName = 'valueSchedule') then
        result.value := ParseSchedule
      else if (json.ItemName = 'valueContact') then
        result.value := ParseContact
      else if (json.ItemName = 'valueAddress') then
        result.value := ParseAddress
      else if (json.ItemName = 'valueHumanName') then
        result.value := ParseHumanName
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeExtension(json : TJSONWriter; name : string; elem : TFhirExtension);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeUri(json, 'url', elem.url);
  ComposeBoolean(json, 'isModifier', elem.isModifier);
  if elem.value is TFhirInteger then
    ComposeInteger(json, 'valueInteger', TFhirInteger(elem.value))
  else if elem.value is TFhirDateTime then
    ComposeDateTime(json, 'valueDateTime', TFhirDateTime(elem.value))
  else if elem.value is TFhirCode then
    ComposeCode(json, 'valueCode', TFhirCode(elem.value))
  else if elem.value is TFhirDate then
    ComposeDate(json, 'valueDate', TFhirDate(elem.value))
  else if elem.value is TFhirDecimal then
    ComposeDecimal(json, 'valueDecimal', TFhirDecimal(elem.value))
  else if elem.value is TFhirUri then
    ComposeUri(json, 'valueUri', TFhirUri(elem.value))
  else if elem.value is TFhirId then
    ComposeId(json, 'valueId', TFhirId(elem.value))
  else if elem.value is TFhirBase64Binary then
    ComposeBase64Binary(json, 'valueBase64Binary', TFhirBase64Binary(elem.value))
  else if elem.value is TFhirOid then
    ComposeOid(json, 'valueOid', TFhirOid(elem.value))
  else if elem.value is TFhirString then
    ComposeString(json, 'valueString', TFhirString(elem.value))
  else if elem.value is TFhirBoolean then
    ComposeBoolean(json, 'valueBoolean', TFhirBoolean(elem.value))
  else if elem.value is TFhirUuid then
    ComposeUuid(json, 'valueUuid', TFhirUuid(elem.value))
  else if elem.value is TFhirInstant then
    ComposeInstant(json, 'valueInstant', TFhirInstant(elem.value))
  else if elem.value is TFhirPeriod then
    ComposePeriod(json, 'valuePeriod', TFhirPeriod(elem.value))
  else if elem.value is TFhirCoding then
    ComposeCoding(json, 'valueCoding', TFhirCoding(elem.value))
  else if elem.value is TFhirRange then
    ComposeRange(json, 'valueRange', TFhirRange(elem.value))
  else if elem.value is TFhirQuantity then
    ComposeQuantity(json, 'valueQuantity', TFhirQuantity(elem.value))
  else if elem.value is TFhirChoice then
    ComposeChoice(json, 'valueChoice', TFhirChoice(elem.value))
  else if elem.value is TFhirAttachment then
    ComposeAttachment(json, 'valueAttachment', TFhirAttachment(elem.value))
  else if elem.value is TFhirRatio then
    ComposeRatio(json, 'valueRatio', TFhirRatio(elem.value))
  else if elem.value is TFhirSampledData then
    ComposeSampledData(json, 'valueSampledData', TFhirSampledData(elem.value))
  else if elem.value is TFhirResourceReference then
    ComposeResourceReference(json, 'valueResource', TFhirResourceReference(elem.value))
  else if elem.value is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'valueCodeableConcept', TFhirCodeableConcept(elem.value))
  else if elem.value is TFhirIdentifier then
    ComposeIdentifier(json, 'valueIdentifier', TFhirIdentifier(elem.value))
  else if elem.value is TFhirSchedule then
    ComposeSchedule(json, 'valueSchedule', TFhirSchedule(elem.value))
  else if elem.value is TFhirContact then
    ComposeContact(json, 'valueContact', TFhirContact(elem.value))
  else if elem.value is TFhirAddress then
    ComposeAddress(json, 'valueAddress', TFhirAddress(elem.value))
  else if elem.value is TFhirHumanName then
    ComposeHumanName(json, 'valueHumanName', TFhirHumanName(elem.value));
  json.finishObject;
end;

function TFHIRXmlParser.ParseNarrative(element : IXmlDomElement) : TFhirNarrative;
var
  child : IXMLDOMElement;
begin
  result := TFhirNarrative.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirNarrativeStatus, child)
      else if (child.baseName = 'div') then
        result.div_ := ParseXHtmlNode(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeNarrative(xml : TXmlBuilder; name : string; elem : TFhirNarrative);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirNarrativeStatus);
  ComposeXHtmlNode(xml, 'div', elem.div_);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseNarrative : TFhirNarrative;
begin
  json.next;
  result := TFhirNarrative.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirNarrativeStatus)
      else if (json.ItemName = 'div') then
        result.div_ := ParseXHtmlNode
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeNarrative(json : TJSONWriter; name : string; elem : TFhirNarrative);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirNarrativeStatus);
  ComposeXHtmlNode(json, 'div', elem.div_);
  json.finishObject;
end;

function TFHIRXmlParser.ParsePeriod(element : IXmlDomElement) : TFhirPeriod;
var
  child : IXMLDOMElement;
begin
  result := TFhirPeriod.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'start') then
        result.start := ParseDateTime(child) {b}
      else if (child.baseName = 'end') then
        result.end_ := ParseDateTime(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposePeriod(xml : TXmlBuilder; name : string; elem : TFhirPeriod);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeDateTime(xml, 'start', elem.start);
  ComposeDateTime(xml, 'end', elem.end_);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParsePeriod : TFhirPeriod;
begin
  json.next;
  result := TFhirPeriod.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'start') then
        result.start := ParseDateTime
      else if (json.ItemName = 'end') then
        result.end_ := ParseDateTime
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposePeriod(json : TJSONWriter; name : string; elem : TFhirPeriod);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeDateTime(json, 'start', elem.start);
  ComposeDateTime(json, 'end', elem.end_);
  json.finishObject;
end;

function TFHIRXmlParser.ParseCoding(element : IXmlDomElement) : TFhirCoding;
var
  child : IXMLDOMElement;
begin
  result := TFhirCoding.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'system') then
        result.system := ParseUri(child) {b}
      else if (child.baseName = 'code') then
        result.code := ParseCode(child) {b}
      else if (child.baseName = 'display') then
        result.display := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeCoding(xml : TXmlBuilder; name : string; elem : TFhirCoding);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeUri(xml, 'system', elem.system);
  ComposeCode(xml, 'code', elem.code);
  ComposeString(xml, 'display', elem.display);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseCoding : TFhirCoding;
begin
  json.next;
  result := TFhirCoding.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'system') then
        result.system := ParseUri
      else if (json.ItemName = 'code') then
        result.code := ParseCode
      else if (json.ItemName = 'display') then
        result.display := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeCoding(json : TJSONWriter; name : string; elem : TFhirCoding);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeUri(json, 'system', elem.system);
  ComposeCode(json, 'code', elem.code);
  ComposeString(json, 'display', elem.display);
  json.finishObject;
end;

function TFHIRXmlParser.ParseRange(element : IXmlDomElement) : TFhirRange;
var
  child : IXMLDOMElement;
begin
  result := TFhirRange.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'low') then
        result.low := ParseQuantity(child) {b}
      else if (child.baseName = 'high') then
        result.high := ParseQuantity(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeRange(xml : TXmlBuilder; name : string; elem : TFhirRange);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeQuantity(xml, 'low', elem.low);
  ComposeQuantity(xml, 'high', elem.high);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseRange : TFhirRange;
begin
  json.next;
  result := TFhirRange.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'low') then
        result.low := ParseQuantity
      else if (json.ItemName = 'high') then
        result.high := ParseQuantity
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeRange(json : TJSONWriter; name : string; elem : TFhirRange);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeQuantity(json, 'low', elem.low);
  ComposeQuantity(json, 'high', elem.high);
  json.finishObject;
end;

function TFHIRXmlParser.ParseQuantity(element : IXmlDomElement) : TFhirQuantity;
var
  child : IXMLDOMElement;
begin
  result := TFhirQuantity.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'value') then
        result.value := ParseDecimal(child) {b}
      else if (child.baseName = 'comparator') then
        result.comparator := ParseEnum(CODES_TFhirQuantityComparator, child)
      else if (child.baseName = 'units') then
        result.units := ParseString(child) {b}
      else if (child.baseName = 'system') then
        result.system := ParseUri(child) {b}
      else if (child.baseName = 'code') then
        result.code := ParseCode(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeQuantity(xml : TXmlBuilder; name : string; elem : TFhirQuantity);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeDecimal(xml, 'value', elem.value);
  ComposeEnum(xml, 'comparator', elem.Comparator, CODES_TFhirQuantityComparator);
  ComposeString(xml, 'units', elem.units);
  ComposeUri(xml, 'system', elem.system);
  ComposeCode(xml, 'code', elem.code);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseQuantity : TFhirQuantity;
begin
  json.next;
  result := TFhirQuantity.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'value') then
        result.value := ParseDecimal
      else if (json.ItemName = 'comparator') then
        result.comparator := ParseEnum(CODES_TFhirQuantityComparator)
      else if (json.ItemName = 'units') then
        result.units := ParseString
      else if (json.ItemName = 'system') then
        result.system := ParseUri
      else if (json.ItemName = 'code') then
        result.code := ParseCode
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeQuantity(json : TJSONWriter; name : string; elem : TFhirQuantity);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeDecimal(json, 'value', elem.value);
  ComposeEnum(json, 'comparator', elem.Comparator, CODES_TFhirQuantityComparator);
  ComposeString(json, 'units', elem.units);
  ComposeUri(json, 'system', elem.system);
  ComposeCode(json, 'code', elem.code);
  json.finishObject;
end;

function TFHIRXmlParser.ParseChoiceOption(element : IXmlDomElement) : TFhirChoiceOption;
var
  child : IXMLDOMElement;
begin
  result := TFhirChoiceOption.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCode(child) {b}
      else if (child.baseName = 'display') then
        result.display := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeChoiceOption(xml : TXmlBuilder; name : string; elem : TFhirChoiceOption);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'code', elem.code);
  ComposeString(xml, 'display', elem.display);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseChoiceOption : TFhirChoiceOption;
begin
  json.next;
  result := TFhirChoiceOption.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCode
      else if (json.ItemName = 'display') then
        result.display := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeChoiceOption(json : TJSONWriter; name : string; elem : TFhirChoiceOption);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'code', elem.code);
  ComposeString(json, 'display', elem.display);
  json.finishObject;
end;

function TFHIRXmlParser.ParseChoice(element : IXmlDomElement) : TFhirChoice;
var
  child : IXMLDOMElement;
begin
  result := TFhirChoice.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCode(child) {b}
      else if (child.baseName = 'option') then
        result.optionList.Add(ParseChoiceOption(child))
      else if (child.baseName = 'isOrdered') then
        result.isOrdered := ParseBoolean(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeChoice(xml : TXmlBuilder; name : string; elem : TFhirChoice);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'code', elem.code);
  for i := 0 to elem.optionList.Count - 1 do
    ComposeChoiceOption(xml, 'option', elem.optionList[i]);
  ComposeBoolean(xml, 'isOrdered', elem.isOrdered);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseChoice : TFhirChoice;
begin
  json.next;
  result := TFhirChoice.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCode
      else if (json.ItemName = 'option') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.optionList.Add(ParseChoiceOption);
          json.Next;
        end;
      end
      else if (json.ItemName = 'isOrdered') then
        result.isOrdered := ParseBoolean
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeChoice(json : TJSONWriter; name : string; elem : TFhirChoice);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'code', elem.code);
  if elem.optionList.Count > 0 then
  begin
    json.valueArray('option');
    for i := 0 to elem.optionList.Count - 1 do
      ComposeChoiceOption(json, '',elem.optionList[i]);
    json.FinishArray;
  end;
  ComposeBoolean(json, 'isOrdered', elem.isOrdered);
  json.finishObject;
end;

function TFHIRXmlParser.ParseAttachment(element : IXmlDomElement) : TFhirAttachment;
var
  child : IXMLDOMElement;
begin
  result := TFhirAttachment.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'contentType') then
        result.contentType := ParseCode(child) {b}
      else if (child.baseName = 'language') then
        result.language := ParseCode(child) {b}
      else if (child.baseName = 'data') then
        result.data := ParseBase64Binary(child) {b}
      else if (child.baseName = 'url') then
        result.url := ParseUri(child) {b}
      else if (child.baseName = 'size') then
        result.size := ParseInteger(child) {b}
      else if (child.baseName = 'hash') then
        result.hash := ParseBase64Binary(child) {b}
      else if (child.baseName = 'title') then
        result.title := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeAttachment(xml : TXmlBuilder; name : string; elem : TFhirAttachment);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'contentType', elem.contentType);
  ComposeCode(xml, 'language', elem.language);
  ComposeBase64Binary(xml, 'data', elem.data);
  ComposeUri(xml, 'url', elem.url);
  ComposeInteger(xml, 'size', elem.size);
  ComposeBase64Binary(xml, 'hash', elem.hash);
  ComposeString(xml, 'title', elem.title);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseAttachment : TFhirAttachment;
begin
  json.next;
  result := TFhirAttachment.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'contentType') then
        result.contentType := ParseCode
      else if (json.ItemName = 'language') then
        result.language := ParseCode
      else if (json.ItemName = 'data') then
        result.data := ParseBase64Binary
      else if (json.ItemName = 'url') then
        result.url := ParseUri
      else if (json.ItemName = 'size') then
        result.size := ParseInteger
      else if (json.ItemName = 'hash') then
        result.hash := ParseBase64Binary
      else if (json.ItemName = 'title') then
        result.title := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeAttachment(json : TJSONWriter; name : string; elem : TFhirAttachment);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'contentType', elem.contentType);
  ComposeCode(json, 'language', elem.language);
  ComposeBase64Binary(json, 'data', elem.data);
  ComposeUri(json, 'url', elem.url);
  ComposeInteger(json, 'size', elem.size);
  ComposeBase64Binary(json, 'hash', elem.hash);
  ComposeString(json, 'title', elem.title);
  json.finishObject;
end;

function TFHIRXmlParser.ParseRatio(element : IXmlDomElement) : TFhirRatio;
var
  child : IXMLDOMElement;
begin
  result := TFhirRatio.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'numerator') then
        result.numerator := ParseQuantity(child) {b}
      else if (child.baseName = 'denominator') then
        result.denominator := ParseQuantity(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeRatio(xml : TXmlBuilder; name : string; elem : TFhirRatio);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeQuantity(xml, 'numerator', elem.numerator);
  ComposeQuantity(xml, 'denominator', elem.denominator);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseRatio : TFhirRatio;
begin
  json.next;
  result := TFhirRatio.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'numerator') then
        result.numerator := ParseQuantity
      else if (json.ItemName = 'denominator') then
        result.denominator := ParseQuantity
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeRatio(json : TJSONWriter; name : string; elem : TFhirRatio);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeQuantity(json, 'numerator', elem.numerator);
  ComposeQuantity(json, 'denominator', elem.denominator);
  json.finishObject;
end;

function TFHIRXmlParser.ParseSampledData(element : IXmlDomElement) : TFhirSampledData;
var
  child : IXMLDOMElement;
begin
  result := TFhirSampledData.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'origin') then
        result.origin := ParseQuantity(child) {b}
      else if (child.baseName = 'period') then
        result.period := ParseDecimal(child) {b}
      else if (child.baseName = 'factor') then
        result.factor := ParseDecimal(child) {b}
      else if (child.baseName = 'lowerLimit') then
        result.lowerLimit := ParseDecimal(child) {b}
      else if (child.baseName = 'upperLimit') then
        result.upperLimit := ParseDecimal(child) {b}
      else if (child.baseName = 'dimensions') then
        result.dimensions := ParseInteger(child) {b}
      else if (child.baseName = 'data') then
        result.data := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSampledData(xml : TXmlBuilder; name : string; elem : TFhirSampledData);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeQuantity(xml, 'origin', elem.origin);
  ComposeDecimal(xml, 'period', elem.period);
  ComposeDecimal(xml, 'factor', elem.factor);
  ComposeDecimal(xml, 'lowerLimit', elem.lowerLimit);
  ComposeDecimal(xml, 'upperLimit', elem.upperLimit);
  ComposeInteger(xml, 'dimensions', elem.dimensions);
  ComposeString(xml, 'data', elem.data);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSampledData : TFhirSampledData;
begin
  json.next;
  result := TFhirSampledData.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'origin') then
        result.origin := ParseQuantity
      else if (json.ItemName = 'period') then
        result.period := ParseDecimal
      else if (json.ItemName = 'factor') then
        result.factor := ParseDecimal
      else if (json.ItemName = 'lowerLimit') then
        result.lowerLimit := ParseDecimal
      else if (json.ItemName = 'upperLimit') then
        result.upperLimit := ParseDecimal
      else if (json.ItemName = 'dimensions') then
        result.dimensions := ParseInteger
      else if (json.ItemName = 'data') then
        result.data := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSampledData(json : TJSONWriter; name : string; elem : TFhirSampledData);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeQuantity(json, 'origin', elem.origin);
  ComposeDecimal(json, 'period', elem.period);
  ComposeDecimal(json, 'factor', elem.factor);
  ComposeDecimal(json, 'lowerLimit', elem.lowerLimit);
  ComposeDecimal(json, 'upperLimit', elem.upperLimit);
  ComposeInteger(json, 'dimensions', elem.dimensions);
  ComposeString(json, 'data', elem.data);
  json.finishObject;
end;

function TFHIRXmlParser.ParseResourceReference(element : IXmlDomElement) : TFhirResourceReference;
var
  child : IXMLDOMElement;
begin
  result := TFhirResourceReference.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCode(child) {b}
      else if (child.baseName = 'reference') then
        result.reference := ParseString(child) {b}
      else if (child.baseName = 'display') then
        result.display := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeResourceReference(xml : TXmlBuilder; name : string; elem : TFhirResourceReference);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'type', elem.type_);
  ComposeString(xml, 'reference', elem.reference);
  ComposeString(xml, 'display', elem.display);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseResourceReference : TFhirResourceReference;
begin
  json.next;
  result := TFhirResourceReference.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCode
      else if (json.ItemName = 'reference') then
        result.reference := ParseString
      else if (json.ItemName = 'display') then
        result.display := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeResourceReference(json : TJSONWriter; name : string; elem : TFhirResourceReference);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'type', elem.type_);
  ComposeString(json, 'reference', elem.reference);
  ComposeString(json, 'display', elem.display);
  json.finishObject;
end;

function TFHIRXmlParser.ParseCodeableConcept(element : IXmlDomElement) : TFhirCodeableConcept;
var
  child : IXMLDOMElement;
begin
  result := TFhirCodeableConcept.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'coding') then
        result.codingList.Add(ParseCoding(child))
      else if (child.baseName = 'text') then
        result.text := ParseString(child) {b}
      else if (child.baseName = 'primary') then
        result.primary := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeCodeableConcept(xml : TXmlBuilder; name : string; elem : TFhirCodeableConcept);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.codingList.Count - 1 do
    ComposeCoding(xml, 'coding', elem.codingList[i]);
  ComposeString(xml, 'text', elem.text);
  ComposeString(xml, 'primary', elem.primary);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseCodeableConcept : TFhirCodeableConcept;
begin
  json.next;
  result := TFhirCodeableConcept.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'coding') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.codingList.Add(ParseCoding);
          json.Next;
        end;
      end
      else if (json.ItemName = 'text') then
        result.text := ParseString
      else if (json.ItemName = 'primary') then
        result.primary := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeCodeableConcept(json : TJSONWriter; name : string; elem : TFhirCodeableConcept);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.codingList.Count > 0 then
  begin
    json.valueArray('coding');
    for i := 0 to elem.codingList.Count - 1 do
      ComposeCoding(json, '',elem.codingList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'text', elem.text);
  ComposeString(json, 'primary', elem.primary);
  json.finishObject;
end;

function TFHIRXmlParser.ParseIdentifier(element : IXmlDomElement) : TFhirIdentifier;
var
  child : IXMLDOMElement;
begin
  result := TFhirIdentifier.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'use') then
        result.use := ParseEnum(CODES_TFhirIdentifierUse, child)
      else if (child.baseName = 'label') then
        result.label_ := ParseString(child) {b}
      else if (child.baseName = 'system') then
        result.system := ParseUri(child) {b}
      else if (child.baseName = 'key') then
        result.key := ParseString(child) {b}
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if (child.baseName = 'assigner') then
        result.assigner := ParseResourceReference{TFhirOrganization}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeIdentifier(xml : TXmlBuilder; name : string; elem : TFhirIdentifier);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'use', elem.Use, CODES_TFhirIdentifierUse);
  ComposeString(xml, 'label', elem.label_);
  ComposeUri(xml, 'system', elem.system);
  ComposeString(xml, 'key', elem.key);
  ComposePeriod(xml, 'period', elem.period);
  ComposeResourceReference{TFhirOrganization}(xml, 'assigner', elem.assigner);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseIdentifier : TFhirIdentifier;
begin
  json.next;
  result := TFhirIdentifier.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'use') then
        result.use := ParseEnum(CODES_TFhirIdentifierUse)
      else if (json.ItemName = 'label') then
        result.label_ := ParseString
      else if (json.ItemName = 'system') then
        result.system := ParseUri
      else if (json.ItemName = 'key') then
        result.key := ParseString
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if (json.ItemName = 'assigner') then
        result.assigner := ParseResourceReference{TFhirOrganization}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeIdentifier(json : TJSONWriter; name : string; elem : TFhirIdentifier);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'use', elem.Use, CODES_TFhirIdentifierUse);
  ComposeString(json, 'label', elem.label_);
  ComposeUri(json, 'system', elem.system);
  ComposeString(json, 'key', elem.key);
  ComposePeriod(json, 'period', elem.period);
  ComposeResourceReference{TFhirOrganization}(json, 'assigner', elem.assigner);
  json.finishObject;
end;

function TFHIRXmlParser.ParseScheduleRepeat(element : IXmlDomElement) : TFhirScheduleRepeat;
var
  child : IXMLDOMElement;
begin
  result := TFhirScheduleRepeat.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'frequency') then
        result.frequency := ParseInteger(child) {b}
      else if (child.baseName = 'when') then
        result.when := ParseEnum(CODES_TFhirEventTiming, child)
      else if (child.baseName = 'duration') then
        result.duration := ParseDecimal(child) {b}
      else if (child.baseName = 'units') then
        result.units := ParseEnum(CODES_TFhirUnitsOfTime, child)
      else if (child.baseName = 'count') then
        result.count := ParseInteger(child) {b}
      else if (child.baseName = 'end') then
        result.end_ := ParseDateTime(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeScheduleRepeat(xml : TXmlBuilder; name : string; elem : TFhirScheduleRepeat);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeInteger(xml, 'frequency', elem.frequency);
  ComposeEnum(xml, 'when', elem.When, CODES_TFhirEventTiming);
  ComposeDecimal(xml, 'duration', elem.duration);
  ComposeEnum(xml, 'units', elem.Units, CODES_TFhirUnitsOfTime);
  ComposeInteger(xml, 'count', elem.count);
  ComposeDateTime(xml, 'end', elem.end_);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseScheduleRepeat : TFhirScheduleRepeat;
begin
  json.next;
  result := TFhirScheduleRepeat.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'frequency') then
        result.frequency := ParseInteger
      else if (json.ItemName = 'when') then
        result.when := ParseEnum(CODES_TFhirEventTiming)
      else if (json.ItemName = 'duration') then
        result.duration := ParseDecimal
      else if (json.ItemName = 'units') then
        result.units := ParseEnum(CODES_TFhirUnitsOfTime)
      else if (json.ItemName = 'count') then
        result.count := ParseInteger
      else if (json.ItemName = 'end') then
        result.end_ := ParseDateTime
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeScheduleRepeat(json : TJSONWriter; name : string; elem : TFhirScheduleRepeat);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeInteger(json, 'frequency', elem.frequency);
  ComposeEnum(json, 'when', elem.When, CODES_TFhirEventTiming);
  ComposeDecimal(json, 'duration', elem.duration);
  ComposeEnum(json, 'units', elem.Units, CODES_TFhirUnitsOfTime);
  ComposeInteger(json, 'count', elem.count);
  ComposeDateTime(json, 'end', elem.end_);
  json.finishObject;
end;

function TFHIRXmlParser.ParseSchedule(element : IXmlDomElement) : TFhirSchedule;
var
  child : IXMLDOMElement;
begin
  result := TFhirSchedule.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'event') then
        result.eventList.Add(ParsePeriod(child))
      else if (child.baseName = 'repeat') then
        result.repeat_ := ParseScheduleRepeat(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSchedule(xml : TXmlBuilder; name : string; elem : TFhirSchedule);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.eventList.Count - 1 do
    ComposePeriod(xml, 'event', elem.eventList[i]);
  ComposeScheduleRepeat(xml, 'repeat', elem.repeat_);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSchedule : TFhirSchedule;
begin
  json.next;
  result := TFhirSchedule.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'event') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.eventList.Add(ParsePeriod);
          json.Next;
        end;
      end
      else if (json.ItemName = 'repeat') then
        result.repeat_ := ParseScheduleRepeat
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSchedule(json : TJSONWriter; name : string; elem : TFhirSchedule);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.eventList.Count > 0 then
  begin
    json.valueArray('event');
    for i := 0 to elem.eventList.Count - 1 do
      ComposePeriod(json, '',elem.eventList[i]);
    json.FinishArray;
  end;
  ComposeScheduleRepeat(json, 'repeat', elem.repeat_);
  json.finishObject;
end;

function TFHIRXmlParser.ParseContact(element : IXmlDomElement) : TFhirContact;
var
  child : IXMLDOMElement;
begin
  result := TFhirContact.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'system') then
        result.system := ParseEnum(CODES_TFhirContactSystem, child)
      else if (child.baseName = 'value') then
        result.value := ParseString(child) {b}
      else if (child.baseName = 'use') then
        result.use := ParseEnum(CODES_TFhirContactUse, child)
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeContact(xml : TXmlBuilder; name : string; elem : TFhirContact);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'system', elem.System, CODES_TFhirContactSystem);
  ComposeString(xml, 'value', elem.value);
  ComposeEnum(xml, 'use', elem.Use, CODES_TFhirContactUse);
  ComposePeriod(xml, 'period', elem.period);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseContact : TFhirContact;
begin
  json.next;
  result := TFhirContact.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'system') then
        result.system := ParseEnum(CODES_TFhirContactSystem)
      else if (json.ItemName = 'value') then
        result.value := ParseString
      else if (json.ItemName = 'use') then
        result.use := ParseEnum(CODES_TFhirContactUse)
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeContact(json : TJSONWriter; name : string; elem : TFhirContact);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'system', elem.System, CODES_TFhirContactSystem);
  ComposeString(json, 'value', elem.value);
  ComposeEnum(json, 'use', elem.Use, CODES_TFhirContactUse);
  ComposePeriod(json, 'period', elem.period);
  json.finishObject;
end;

function TFHIRXmlParser.ParseAddress(element : IXmlDomElement) : TFhirAddress;
var
  child : IXMLDOMElement;
begin
  result := TFhirAddress.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'use') then
        result.use := ParseEnum(CODES_TFhirAddressUse, child)
      else if (child.baseName = 'text') then
        result.text := ParseString(child) {b}
      else if (child.baseName = 'line') then
        result.lineList.Add(ParseString(child))
      else if (child.baseName = 'city') then
        result.city := ParseString(child) {b}
      else if (child.baseName = 'state') then
        result.state := ParseString(child) {b}
      else if (child.baseName = 'zip') then
        result.zip := ParseString(child) {b}
      else if (child.baseName = 'country') then
        result.country := ParseString(child) {b}
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeAddress(xml : TXmlBuilder; name : string; elem : TFhirAddress);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'use', elem.Use, CODES_TFhirAddressUse);
  ComposeString(xml, 'text', elem.text);
  for i := 0 to elem.lineList.Count - 1 do
    ComposeString(xml, 'line', elem.lineList[i]);
  ComposeString(xml, 'city', elem.city);
  ComposeString(xml, 'state', elem.state);
  ComposeString(xml, 'zip', elem.zip);
  ComposeString(xml, 'country', elem.country);
  ComposePeriod(xml, 'period', elem.period);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseAddress : TFhirAddress;
begin
  json.next;
  result := TFhirAddress.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'use') then
        result.use := ParseEnum(CODES_TFhirAddressUse)
      else if (json.ItemName = 'text') then
        result.text := ParseString
      else if (json.ItemName = 'line') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.lineList.Add(ParseString);
          json.Next;
        end;
      end
      else if (json.ItemName = 'city') then
        result.city := ParseString
      else if (json.ItemName = 'state') then
        result.state := ParseString
      else if (json.ItemName = 'zip') then
        result.zip := ParseString
      else if (json.ItemName = 'country') then
        result.country := ParseString
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeAddress(json : TJSONWriter; name : string; elem : TFhirAddress);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'use', elem.Use, CODES_TFhirAddressUse);
  ComposeString(json, 'text', elem.text);
  if elem.lineList.Count > 0 then
  begin
    json.valueArray('line');
    for i := 0 to elem.lineList.Count - 1 do
      ComposeString(json, '',elem.lineList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'city', elem.city);
  ComposeString(json, 'state', elem.state);
  ComposeString(json, 'zip', elem.zip);
  ComposeString(json, 'country', elem.country);
  ComposePeriod(json, 'period', elem.period);
  json.finishObject;
end;

function TFHIRXmlParser.ParseHumanName(element : IXmlDomElement) : TFhirHumanName;
var
  child : IXMLDOMElement;
begin
  result := TFhirHumanName.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'use') then
        result.use := ParseEnum(CODES_TFhirNameUse, child)
      else if (child.baseName = 'text') then
        result.text := ParseString(child) {b}
      else if (child.baseName = 'family') then
        result.familyList.Add(ParseString(child))
      else if (child.baseName = 'given') then
        result.givenList.Add(ParseString(child))
      else if (child.baseName = 'prefix') then
        result.prefixList.Add(ParseString(child))
      else if (child.baseName = 'suffix') then
        result.suffixList.Add(ParseString(child))
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeHumanName(xml : TXmlBuilder; name : string; elem : TFhirHumanName);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'use', elem.Use, CODES_TFhirNameUse);
  ComposeString(xml, 'text', elem.text);
  for i := 0 to elem.familyList.Count - 1 do
    ComposeString(xml, 'family', elem.familyList[i]);
  for i := 0 to elem.givenList.Count - 1 do
    ComposeString(xml, 'given', elem.givenList[i]);
  for i := 0 to elem.prefixList.Count - 1 do
    ComposeString(xml, 'prefix', elem.prefixList[i]);
  for i := 0 to elem.suffixList.Count - 1 do
    ComposeString(xml, 'suffix', elem.suffixList[i]);
  ComposePeriod(xml, 'period', elem.period);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseHumanName : TFhirHumanName;
begin
  json.next;
  result := TFhirHumanName.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'use') then
        result.use := ParseEnum(CODES_TFhirNameUse)
      else if (json.ItemName = 'text') then
        result.text := ParseString
      else if (json.ItemName = 'family') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.familyList.Add(ParseString);
          json.Next;
        end;
      end
      else if (json.ItemName = 'given') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.givenList.Add(ParseString);
          json.Next;
        end;
      end
      else if (json.ItemName = 'prefix') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.prefixList.Add(ParseString);
          json.Next;
        end;
      end
      else if (json.ItemName = 'suffix') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.suffixList.Add(ParseString);
          json.Next;
        end;
      end
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeHumanName(json : TJSONWriter; name : string; elem : TFhirHumanName);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'use', elem.Use, CODES_TFhirNameUse);
  ComposeString(json, 'text', elem.text);
  if elem.familyList.Count > 0 then
  begin
    json.valueArray('family');
    for i := 0 to elem.familyList.Count - 1 do
      ComposeString(json, '',elem.familyList[i]);
    json.FinishArray;
  end;
  if elem.givenList.Count > 0 then
  begin
    json.valueArray('given');
    for i := 0 to elem.givenList.Count - 1 do
      ComposeString(json, '',elem.givenList[i]);
    json.FinishArray;
  end;
  if elem.prefixList.Count > 0 then
  begin
    json.valueArray('prefix');
    for i := 0 to elem.prefixList.Count - 1 do
      ComposeString(json, '',elem.prefixList[i]);
    json.FinishArray;
  end;
  if elem.suffixList.Count > 0 then
  begin
    json.valueArray('suffix');
    for i := 0 to elem.suffixList.Count - 1 do
      ComposeString(json, '',elem.suffixList[i]);
    json.FinishArray;
  end;
  ComposePeriod(json, 'period', elem.period);
  json.finishObject;
end;

function TFHIRXmlParser.ParseAge(element : IXmlDomElement) : TFhirAge;
begin
  result := ParseQuantity(element);
end;

procedure TFHIRXmlComposer.ComposeAge(xml : TXmlBuilder; name : string; elem : TFhirAge);
begin
  ComposeQuantity(xml, name, elem);
end;

function TFHIRJsonParser.ParseAge : TFhirAge;
begin
  result := ParseQuantity;
end;

procedure TFHIRJsonComposer.ComposeAge(json : TJSONWriter; name : string; elem : TFhirAge);
begin
  ComposeQuantity(json, name, elem);
end;

function TFHIRXmlParser.ParseCount(element : IXmlDomElement) : TFhirCount;
begin
  result := ParseQuantity(element);
end;

procedure TFHIRXmlComposer.ComposeCount(xml : TXmlBuilder; name : string; elem : TFhirCount);
begin
  ComposeQuantity(xml, name, elem);
end;

function TFHIRJsonParser.ParseCount : TFhirCount;
begin
  result := ParseQuantity;
end;

procedure TFHIRJsonComposer.ComposeCount(json : TJSONWriter; name : string; elem : TFhirCount);
begin
  ComposeQuantity(json, name, elem);
end;

function TFHIRXmlParser.ParseMoney(element : IXmlDomElement) : TFhirMoney;
begin
  result := ParseQuantity(element);
end;

procedure TFHIRXmlComposer.ComposeMoney(xml : TXmlBuilder; name : string; elem : TFhirMoney);
begin
  ComposeQuantity(xml, name, elem);
end;

function TFHIRJsonParser.ParseMoney : TFhirMoney;
begin
  result := ParseQuantity;
end;

procedure TFHIRJsonComposer.ComposeMoney(json : TJSONWriter; name : string; elem : TFhirMoney);
begin
  ComposeQuantity(json, name, elem);
end;

function TFHIRXmlParser.ParseDistance(element : IXmlDomElement) : TFhirDistance;
begin
  result := ParseQuantity(element);
end;

procedure TFHIRXmlComposer.ComposeDistance(xml : TXmlBuilder; name : string; elem : TFhirDistance);
begin
  ComposeQuantity(xml, name, elem);
end;

function TFHIRJsonParser.ParseDistance : TFhirDistance;
begin
  result := ParseQuantity;
end;

procedure TFHIRJsonComposer.ComposeDistance(json : TJSONWriter; name : string; elem : TFhirDistance);
begin
  ComposeQuantity(json, name, elem);
end;

function TFHIRXmlParser.ParseDuration(element : IXmlDomElement) : TFhirDuration;
begin
  result := ParseQuantity(element);
end;

procedure TFHIRXmlComposer.ComposeDuration(xml : TXmlBuilder; name : string; elem : TFhirDuration);
begin
  ComposeQuantity(xml, name, elem);
end;

function TFHIRJsonParser.ParseDuration : TFhirDuration;
begin
  result := ParseQuantity;
end;

procedure TFHIRJsonComposer.ComposeDuration(json : TJSONWriter; name : string; elem : TFhirDuration);
begin
  ComposeQuantity(json, name, elem);
end;

function TFHIRXmlParser.ParseAdverseReactionSymptom(element : IXmlDomElement) : TFhirAdverseReactionSymptom;
var
  child : IXMLDOMElement;
begin
  result := TFhirAdverseReactionSymptom.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'severity') then
        result.severity := ParseEnum(CODES_TFhirReactionSeverity, child)
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeAdverseReactionSymptom(xml : TXmlBuilder; name : string; elem : TFhirAdverseReactionSymptom);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeEnum(xml, 'severity', elem.Severity, CODES_TFhirReactionSeverity);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseAdverseReactionSymptom : TFhirAdverseReactionSymptom;
begin
  json.next;
  result := TFhirAdverseReactionSymptom.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'severity') then
        result.severity := ParseEnum(CODES_TFhirReactionSeverity)
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeAdverseReactionSymptom(json : TJSONWriter; name : string; elem : TFhirAdverseReactionSymptom);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeEnum(json, 'severity', elem.Severity, CODES_TFhirReactionSeverity);
  json.finishObject;
end;

function TFHIRXmlParser.ParseAdverseReactionExposure(element : IXmlDomElement) : TFhirAdverseReactionExposure;
var
  child : IXMLDOMElement;
begin
  result := TFhirAdverseReactionExposure.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'exposureDate') then
        result.exposureDate := ParseDateTime(child) {b}
      else if (child.baseName = 'exposureType') then
        result.exposureType := ParseEnum(CODES_TFhirExposureType, child)
      else if (child.baseName = 'causalityExpectation') then
        result.causalityExpectation := ParseEnum(CODES_TFhirCausalityExpectation, child)
      else if (child.baseName = 'substance') then
        result.substance := ParseResourceReference{TFhirSubstance}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeAdverseReactionExposure(xml : TXmlBuilder; name : string; elem : TFhirAdverseReactionExposure);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeDateTime(xml, 'exposureDate', elem.exposureDate);
  ComposeEnum(xml, 'exposureType', elem.ExposureType, CODES_TFhirExposureType);
  ComposeEnum(xml, 'causalityExpectation', elem.CausalityExpectation, CODES_TFhirCausalityExpectation);
  ComposeResourceReference{TFhirSubstance}(xml, 'substance', elem.substance);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseAdverseReactionExposure : TFhirAdverseReactionExposure;
begin
  json.next;
  result := TFhirAdverseReactionExposure.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'exposureDate') then
        result.exposureDate := ParseDateTime
      else if (json.ItemName = 'exposureType') then
        result.exposureType := ParseEnum(CODES_TFhirExposureType)
      else if (json.ItemName = 'causalityExpectation') then
        result.causalityExpectation := ParseEnum(CODES_TFhirCausalityExpectation)
      else if (json.ItemName = 'substance') then
        result.substance := ParseResourceReference{TFhirSubstance}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeAdverseReactionExposure(json : TJSONWriter; name : string; elem : TFhirAdverseReactionExposure);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeDateTime(json, 'exposureDate', elem.exposureDate);
  ComposeEnum(json, 'exposureType', elem.ExposureType, CODES_TFhirExposureType);
  ComposeEnum(json, 'causalityExpectation', elem.CausalityExpectation, CODES_TFhirCausalityExpectation);
  ComposeResourceReference{TFhirSubstance}(json, 'substance', elem.substance);
  json.finishObject;
end;

function TFHIRXmlParser.ParseAdverseReaction(element : IXmlDomElement) : TFhirAdverseReaction;
var
  child : IXMLDOMElement;
begin
  result := TFhirAdverseReaction.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'reactionDate') then
        result.reactionDate := ParseDateTime(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'didNotOccurFlag') then
        result.didNotOccurFlag := ParseBoolean(child) {b}
      else if (child.baseName = 'recorder') then
        result.recorder := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'symptom') then
        result.symptomList.Add(ParseAdverseReactionSymptom(child))
      else if (child.baseName = 'exposure') then
        result.exposureList.Add(ParseAdverseReactionExposure(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeAdverseReaction(xml : TXmlBuilder; name : string; elem : TFhirAdverseReaction);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeDateTime(xml, 'reactionDate', elem.reactionDate);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  ComposeBoolean(xml, 'didNotOccurFlag', elem.didNotOccurFlag);
  ComposeResourceReference{Resource}(xml, 'recorder', elem.recorder);
  for i := 0 to elem.symptomList.Count - 1 do
    ComposeAdverseReactionSymptom(xml, 'symptom', elem.symptomList[i]);
  for i := 0 to elem.exposureList.Count - 1 do
    ComposeAdverseReactionExposure(xml, 'exposure', elem.exposureList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseAdverseReaction : TFhirAdverseReaction;
begin
  json.next;
  result := TFhirAdverseReaction.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'reactionDate') then
        result.reactionDate := ParseDateTime
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'didNotOccurFlag') then
        result.didNotOccurFlag := ParseBoolean
      else if (json.ItemName = 'recorder') then
        result.recorder := ParseResourceReference{Resource}
      else if (json.ItemName = 'symptom') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.symptomList.Add(ParseAdverseReactionSymptom);
          json.Next;
        end;
      end
      else if (json.ItemName = 'exposure') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.exposureList.Add(ParseAdverseReactionExposure);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeAdverseReaction(json : TJSONWriter; name : string; elem : TFhirAdverseReaction);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeDateTime(json, 'reactionDate', elem.reactionDate);
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  ComposeBoolean(json, 'didNotOccurFlag', elem.didNotOccurFlag);
  ComposeResourceReference{Resource}(json, 'recorder', elem.recorder);
  if elem.symptomList.Count > 0 then
  begin
    json.valueArray('symptom');
    for i := 0 to elem.symptomList.Count - 1 do
      ComposeAdverseReactionSymptom(json, '',elem.symptomList[i]);
    json.FinishArray;
  end;
  if elem.exposureList.Count > 0 then
  begin
    json.valueArray('exposure');
    for i := 0 to elem.exposureList.Count - 1 do
      ComposeAdverseReactionExposure(json, '',elem.exposureList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseAlert(element : IXmlDomElement) : TFhirAlert;
var
  child : IXMLDOMElement;
begin
  result := TFhirAlert.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'category') then
        result.category := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirAlertStatus, child)
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'author') then
        result.author := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'note') then
        result.note := ParseString(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeAlert(xml : TXmlBuilder; name : string; elem : TFhirAlert);
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeCodeableConcept(xml, 'category', elem.category);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirAlertStatus);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  ComposeResourceReference{Resource}(xml, 'author', elem.author);
  ComposeString(xml, 'note', elem.note);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseAlert : TFhirAlert;
begin
  json.next;
  result := TFhirAlert.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'category') then
        result.category := ParseCodeableConcept
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirAlertStatus)
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'author') then
        result.author := ParseResourceReference{Resource}
      else if (json.ItemName = 'note') then
        result.note := ParseString
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeAlert(json : TJSONWriter; name : string; elem : TFhirAlert);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeCodeableConcept(json, 'category', elem.category);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirAlertStatus);
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  ComposeResourceReference{Resource}(json, 'author', elem.author);
  ComposeString(json, 'note', elem.note);
  json.finishObject;
end;

function TFHIRXmlParser.ParseAllergyIntolerance(element : IXmlDomElement) : TFhirAllergyIntolerance;
var
  child : IXMLDOMElement;
begin
  result := TFhirAllergyIntolerance.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'criticality') then
        result.criticality := ParseEnum(CODES_TFhirCriticality, child)
      else if (child.baseName = 'sensitivityType') then
        result.sensitivityType := ParseEnum(CODES_TFhirSensitivitytype, child)
      else if (child.baseName = 'recordedDate') then
        result.recordedDate := ParseDateTime(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirSensitivitystatus, child)
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'recorder') then
        result.recorder := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'substance') then
        result.substance := ParseResourceReference{TFhirSubstance}(child) {b}
      else if (child.baseName = 'reaction') then
        result.reactionList.Add(ParseResourceReference{TFhirAdverseReaction}(child))
      else if (child.baseName = 'sensitivityTest') then
        result.sensitivityTestList.Add(ParseResourceReference{TFhirObservation}(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeAllergyIntolerance(xml : TXmlBuilder; name : string; elem : TFhirAllergyIntolerance);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeEnum(xml, 'criticality', elem.Criticality, CODES_TFhirCriticality);
  ComposeEnum(xml, 'sensitivityType', elem.SensitivityType, CODES_TFhirSensitivitytype);
  ComposeDateTime(xml, 'recordedDate', elem.recordedDate);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirSensitivitystatus);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  ComposeResourceReference{Resource}(xml, 'recorder', elem.recorder);
  ComposeResourceReference{TFhirSubstance}(xml, 'substance', elem.substance);
  for i := 0 to elem.reactionList.Count - 1 do
    ComposeResourceReference{TFhirAdverseReaction}(xml, 'reaction', elem.reactionList[i]);
  for i := 0 to elem.sensitivityTestList.Count - 1 do
    ComposeResourceReference{TFhirObservation}(xml, 'sensitivityTest', elem.sensitivityTestList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseAllergyIntolerance : TFhirAllergyIntolerance;
begin
  json.next;
  result := TFhirAllergyIntolerance.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'criticality') then
        result.criticality := ParseEnum(CODES_TFhirCriticality)
      else if (json.ItemName = 'sensitivityType') then
        result.sensitivityType := ParseEnum(CODES_TFhirSensitivitytype)
      else if (json.ItemName = 'recordedDate') then
        result.recordedDate := ParseDateTime
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirSensitivitystatus)
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'recorder') then
        result.recorder := ParseResourceReference{Resource}
      else if (json.ItemName = 'substance') then
        result.substance := ParseResourceReference{TFhirSubstance}
      else if (json.ItemName = 'reaction') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.reactionList.Add(ParseResourceReference{TFhirAdverseReaction});
          json.Next;
        end;
      end
      else if (json.ItemName = 'sensitivityTest') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.sensitivityTestList.Add(ParseResourceReference{TFhirObservation});
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeAllergyIntolerance(json : TJSONWriter; name : string; elem : TFhirAllergyIntolerance);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeEnum(json, 'criticality', elem.Criticality, CODES_TFhirCriticality);
  ComposeEnum(json, 'sensitivityType', elem.SensitivityType, CODES_TFhirSensitivitytype);
  ComposeDateTime(json, 'recordedDate', elem.recordedDate);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirSensitivitystatus);
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  ComposeResourceReference{Resource}(json, 'recorder', elem.recorder);
  ComposeResourceReference{TFhirSubstance}(json, 'substance', elem.substance);
  if elem.reactionList.Count > 0 then
  begin
    json.valueArray('reaction');
    for i := 0 to elem.reactionList.Count - 1 do
      ComposeResourceReference{TFhirAdverseReaction}(json, '',elem.reactionList[i]);
    json.FinishArray;
  end;
  if elem.sensitivityTestList.Count > 0 then
  begin
    json.valueArray('sensitivityTest');
    for i := 0 to elem.sensitivityTestList.Count - 1 do
      ComposeResourceReference{TFhirObservation}(json, '',elem.sensitivityTestList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseCarePlanParticipant(element : IXmlDomElement) : TFhirCarePlanParticipant;
var
  child : IXMLDOMElement;
begin
  result := TFhirCarePlanParticipant.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'role') then
        result.role := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'member') then
        result.member := ParseResourceReference{Resource}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeCarePlanParticipant(xml : TXmlBuilder; name : string; elem : TFhirCarePlanParticipant);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'role', elem.role);
  ComposeResourceReference{Resource}(xml, 'member', elem.member);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseCarePlanParticipant : TFhirCarePlanParticipant;
begin
  json.next;
  result := TFhirCarePlanParticipant.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'role') then
        result.role := ParseCodeableConcept
      else if (json.ItemName = 'member') then
        result.member := ParseResourceReference{Resource}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeCarePlanParticipant(json : TJSONWriter; name : string; elem : TFhirCarePlanParticipant);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'role', elem.role);
  ComposeResourceReference{Resource}(json, 'member', elem.member);
  json.finishObject;
end;

function TFHIRXmlParser.ParseCarePlanGoal(element : IXmlDomElement) : TFhirCarePlanGoal;
var
  child : IXMLDOMElement;
begin
  result := TFhirCarePlanGoal.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirCarePlanGoalStatus, child)
      else if (child.baseName = 'notes') then
        result.notes := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeCarePlanGoal(xml : TXmlBuilder; name : string; elem : TFhirCarePlanGoal);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'description', elem.description);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirCarePlanGoalStatus);
  ComposeString(xml, 'notes', elem.notes);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseCarePlanGoal : TFhirCarePlanGoal;
begin
  json.next;
  result := TFhirCarePlanGoal.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirCarePlanGoalStatus)
      else if (json.ItemName = 'notes') then
        result.notes := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeCarePlanGoal(json : TJSONWriter; name : string; elem : TFhirCarePlanGoal);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'description', elem.description);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirCarePlanGoalStatus);
  ComposeString(json, 'notes', elem.notes);
  json.finishObject;
end;

function TFHIRXmlParser.ParseCarePlanActivity(element : IXmlDomElement) : TFhirCarePlanActivity;
var
  child : IXMLDOMElement;
begin
  result := TFhirCarePlanActivity.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'category') then
        result.category := ParseEnum(CODES_TFhirCarePlanActivityCategory, child)
      else if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirCarePlanActivityStatus, child)
      else if (child.baseName = 'prohibited') then
        result.prohibited := ParseBoolean(child) {b}
      else if (child.baseName = 'timingSchedule') then
        result.timing := ParseSchedule(child)
      else if (child.baseName = 'timingPeriod') then
        result.timing := ParsePeriod(child)
      else if (child.baseName = 'timingString') then
        result.timing := ParseString(child)
      else if (child.baseName = 'location') then
        result.location := ParseResourceReference{TFhirLocation}(child) {b}
      else if (child.baseName = 'performer') then
        result.performerList.Add(ParseResourceReference{Resource}(child))
      else if (child.baseName = 'product') then
        result.product := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'dailyAmount') then
        result.dailyAmount := ParseQuantity(child) {b}
      else if (child.baseName = 'quantity') then
        result.quantity := ParseQuantity(child) {b}
      else if (child.baseName = 'details') then
        result.details := ParseString(child) {b}
      else if (child.baseName = 'actionTaken') then
        result.actionTakenList.Add(ParseResourceReference{Resource}(child))
      else if (child.baseName = 'notes') then
        result.notes := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeCarePlanActivity(xml : TXmlBuilder; name : string; elem : TFhirCarePlanActivity);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'category', elem.Category, CODES_TFhirCarePlanActivityCategory);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirCarePlanActivityStatus);
  ComposeBoolean(xml, 'prohibited', elem.prohibited);
  if elem.timing is TFhirSchedule {6} then
    ComposeSchedule(xml, 'timingSchedule', TFhirSchedule(elem.timing))
  else if elem.timing is TFhirPeriod {6} then
    ComposePeriod(xml, 'timingPeriod', TFhirPeriod(elem.timing))
  else if elem.timing is TFhirString {6} then
    ComposeString(xml, 'timingString', TFhirString(elem.timing));
  ComposeResourceReference{TFhirLocation}(xml, 'location', elem.location);
  for i := 0 to elem.performerList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'performer', elem.performerList[i]);
  ComposeResourceReference{Resource}(xml, 'product', elem.product);
  ComposeQuantity(xml, 'dailyAmount', elem.dailyAmount);
  ComposeQuantity(xml, 'quantity', elem.quantity);
  ComposeString(xml, 'details', elem.details);
  for i := 0 to elem.actionTakenList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'actionTaken', elem.actionTakenList[i]);
  ComposeString(xml, 'notes', elem.notes);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseCarePlanActivity : TFhirCarePlanActivity;
begin
  json.next;
  result := TFhirCarePlanActivity.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'category') then
        result.category := ParseEnum(CODES_TFhirCarePlanActivityCategory)
      else if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirCarePlanActivityStatus)
      else if (json.ItemName = 'prohibited') then
        result.prohibited := ParseBoolean
      else if (json.ItemName = 'timingSchedule') then
        result.timing := ParseSchedule
      else if (json.ItemName = 'timingPeriod') then
        result.timing := ParsePeriod
      else if (json.ItemName = 'timingString') then
        result.timing := ParseString
      else if (json.ItemName = 'location') then
        result.location := ParseResourceReference{TFhirLocation}
      else if (json.ItemName = 'performer') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.performerList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if (json.ItemName = 'product') then
        result.product := ParseResourceReference{Resource}
      else if (json.ItemName = 'dailyAmount') then
        result.dailyAmount := ParseQuantity
      else if (json.ItemName = 'quantity') then
        result.quantity := ParseQuantity
      else if (json.ItemName = 'details') then
        result.details := ParseString
      else if (json.ItemName = 'actionTaken') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.actionTakenList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if (json.ItemName = 'notes') then
        result.notes := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeCarePlanActivity(json : TJSONWriter; name : string; elem : TFhirCarePlanActivity);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'category', elem.Category, CODES_TFhirCarePlanActivityCategory);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirCarePlanActivityStatus);
  ComposeBoolean(json, 'prohibited', elem.prohibited);
  if elem.timing is TFhirSchedule then
    ComposeSchedule(json, 'timingSchedule', TFhirSchedule(elem.timing))
  else if elem.timing is TFhirPeriod then
    ComposePeriod(json, 'timingPeriod', TFhirPeriod(elem.timing))
  else if elem.timing is TFhirString then
    ComposeString(json, 'timingString', TFhirString(elem.timing));
  ComposeResourceReference{TFhirLocation}(json, 'location', elem.location);
  if elem.performerList.Count > 0 then
  begin
    json.valueArray('performer');
    for i := 0 to elem.performerList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.performerList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{Resource}(json, 'product', elem.product);
  ComposeQuantity(json, 'dailyAmount', elem.dailyAmount);
  ComposeQuantity(json, 'quantity', elem.quantity);
  ComposeString(json, 'details', elem.details);
  if elem.actionTakenList.Count > 0 then
  begin
    json.valueArray('actionTaken');
    for i := 0 to elem.actionTakenList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.actionTakenList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'notes', elem.notes);
  json.finishObject;
end;

function TFHIRXmlParser.ParseCarePlan(element : IXmlDomElement) : TFhirCarePlan;
var
  child : IXMLDOMElement;
begin
  result := TFhirCarePlan.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirCarePlanStatus, child)
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if (child.baseName = 'modified') then
        result.modified := ParseDateTime(child) {b}
      else if (child.baseName = 'concern') then
        result.concernList.Add(ParseResourceReference{TFhirCondition}(child))
      else if (child.baseName = 'participant') then
        result.participantList.Add(ParseCarePlanParticipant(child))
      else if (child.baseName = 'goal') then
        result.goalList.Add(ParseCarePlanGoal(child))
      else if (child.baseName = 'activity') then
        result.activityList.Add(ParseCarePlanActivity(child))
      else if (child.baseName = 'notes') then
        result.notes := ParseString(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeCarePlan(xml : TXmlBuilder; name : string; elem : TFhirCarePlan);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeResourceReference{TFhirPatient}(xml, 'patient', elem.patient);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirCarePlanStatus);
  ComposePeriod(xml, 'period', elem.period);
  ComposeDateTime(xml, 'modified', elem.modified);
  for i := 0 to elem.concernList.Count - 1 do
    ComposeResourceReference{TFhirCondition}(xml, 'concern', elem.concernList[i]);
  for i := 0 to elem.participantList.Count - 1 do
    ComposeCarePlanParticipant(xml, 'participant', elem.participantList[i]);
  for i := 0 to elem.goalList.Count - 1 do
    ComposeCarePlanGoal(xml, 'goal', elem.goalList[i]);
  for i := 0 to elem.activityList.Count - 1 do
    ComposeCarePlanActivity(xml, 'activity', elem.activityList[i]);
  ComposeString(xml, 'notes', elem.notes);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseCarePlan : TFhirCarePlan;
begin
  json.next;
  result := TFhirCarePlan.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirCarePlanStatus)
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if (json.ItemName = 'modified') then
        result.modified := ParseDateTime
      else if (json.ItemName = 'concern') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.concernList.Add(ParseResourceReference{TFhirCondition});
          json.Next;
        end;
      end
      else if (json.ItemName = 'participant') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.participantList.Add(ParseCarePlanParticipant);
          json.Next;
        end;
      end
      else if (json.ItemName = 'goal') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.goalList.Add(ParseCarePlanGoal);
          json.Next;
        end;
      end
      else if (json.ItemName = 'activity') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.activityList.Add(ParseCarePlanActivity);
          json.Next;
        end;
      end
      else if (json.ItemName = 'notes') then
        result.notes := ParseString
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeCarePlan(json : TJSONWriter; name : string; elem : TFhirCarePlan);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeResourceReference{TFhirPatient}(json, 'patient', elem.patient);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirCarePlanStatus);
  ComposePeriod(json, 'period', elem.period);
  ComposeDateTime(json, 'modified', elem.modified);
  if elem.concernList.Count > 0 then
  begin
    json.valueArray('concern');
    for i := 0 to elem.concernList.Count - 1 do
      ComposeResourceReference{TFhirCondition}(json, '',elem.concernList[i]);
    json.FinishArray;
  end;
  if elem.participantList.Count > 0 then
  begin
    json.valueArray('participant');
    for i := 0 to elem.participantList.Count - 1 do
      ComposeCarePlanParticipant(json, '',elem.participantList[i]);
    json.FinishArray;
  end;
  if elem.goalList.Count > 0 then
  begin
    json.valueArray('goal');
    for i := 0 to elem.goalList.Count - 1 do
      ComposeCarePlanGoal(json, '',elem.goalList[i]);
    json.FinishArray;
  end;
  if elem.activityList.Count > 0 then
  begin
    json.valueArray('activity');
    for i := 0 to elem.activityList.Count - 1 do
      ComposeCarePlanActivity(json, '',elem.activityList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'notes', elem.notes);
  json.finishObject;
end;

function TFHIRXmlParser.ParseConditionStage(element : IXmlDomElement) : TFhirConditionStage;
var
  child : IXMLDOMElement;
begin
  result := TFhirConditionStage.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'summary') then
        result.summary := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'assessment') then
        result.assessmentList.Add(ParseResourceReference{Resource}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConditionStage(xml : TXmlBuilder; name : string; elem : TFhirConditionStage);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'summary', elem.summary);
  for i := 0 to elem.assessmentList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'assessment', elem.assessmentList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConditionStage : TFhirConditionStage;
begin
  json.next;
  result := TFhirConditionStage.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'summary') then
        result.summary := ParseCodeableConcept
      else if (json.ItemName = 'assessment') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.assessmentList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConditionStage(json : TJSONWriter; name : string; elem : TFhirConditionStage);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'summary', elem.summary);
  if elem.assessmentList.Count > 0 then
  begin
    json.valueArray('assessment');
    for i := 0 to elem.assessmentList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.assessmentList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseConditionEvidence(element : IXmlDomElement) : TFhirConditionEvidence;
var
  child : IXMLDOMElement;
begin
  result := TFhirConditionEvidence.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'detail') then
        result.detailList.Add(ParseResourceReference{Resource}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConditionEvidence(xml : TXmlBuilder; name : string; elem : TFhirConditionEvidence);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  for i := 0 to elem.detailList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'detail', elem.detailList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConditionEvidence : TFhirConditionEvidence;
begin
  json.next;
  result := TFhirConditionEvidence.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'detail') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.detailList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConditionEvidence(json : TJSONWriter; name : string; elem : TFhirConditionEvidence);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  if elem.detailList.Count > 0 then
  begin
    json.valueArray('detail');
    for i := 0 to elem.detailList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.detailList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseConditionLocation(element : IXmlDomElement) : TFhirConditionLocation;
var
  child : IXMLDOMElement;
begin
  result := TFhirConditionLocation.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'detail') then
        result.detail := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConditionLocation(xml : TXmlBuilder; name : string; elem : TFhirConditionLocation);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeString(xml, 'detail', elem.detail);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConditionLocation : TFhirConditionLocation;
begin
  json.next;
  result := TFhirConditionLocation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'detail') then
        result.detail := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConditionLocation(json : TJSONWriter; name : string; elem : TFhirConditionLocation);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeString(json, 'detail', elem.detail);
  json.finishObject;
end;

function TFHIRXmlParser.ParseConditionRelatedItem(element : IXmlDomElement) : TFhirConditionRelatedItem;
var
  child : IXMLDOMElement;
begin
  result := TFhirConditionRelatedItem.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirConditionRelationshipType, child)
      else if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'target') then
        result.target := ParseResourceReference{Resource}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConditionRelatedItem(xml : TXmlBuilder; name : string; elem : TFhirConditionRelatedItem);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'type', elem.Type_, CODES_TFhirConditionRelationshipType);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeResourceReference{Resource}(xml, 'target', elem.target);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConditionRelatedItem : TFhirConditionRelatedItem;
begin
  json.next;
  result := TFhirConditionRelatedItem.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirConditionRelationshipType)
      else if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'target') then
        result.target := ParseResourceReference{Resource}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConditionRelatedItem(json : TJSONWriter; name : string; elem : TFhirConditionRelatedItem);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'type', elem.Type_, CODES_TFhirConditionRelationshipType);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeResourceReference{Resource}(json, 'target', elem.target);
  json.finishObject;
end;

function TFHIRXmlParser.ParseCondition(element : IXmlDomElement) : TFhirCondition;
var
  child : IXMLDOMElement;
begin
  result := TFhirCondition.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}(child) {b}
      else if (child.baseName = 'asserter') then
        result.asserter := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'dateAsserted') then
        result.dateAsserted := ParseDate(child) {b}
      else if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'category') then
        result.category := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirConditionStatus, child)
      else if (child.baseName = 'certainty') then
        result.certainty := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'severity') then
        result.severity := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'onsetDate') then
        result.onset := ParseDate(child)
      else if (child.baseName = 'onsetAge') then
        result.onset := ParseAge(child)
      else if (child.baseName = 'abatementDate') then
        result.abatement := ParseDate(child)
      else if (child.baseName = 'abatementAge') then
        result.abatement := ParseAge(child)
      else if (child.baseName = 'abatementBoolean') then
        result.abatement := ParseBoolean(child)
      else if (child.baseName = 'stage') then
        result.stage := ParseConditionStage(child) {b}
      else if (child.baseName = 'evidence') then
        result.evidenceList.Add(ParseConditionEvidence(child))
      else if (child.baseName = 'location') then
        result.locationList.Add(ParseConditionLocation(child))
      else if (child.baseName = 'relatedItem') then
        result.relatedItemList.Add(ParseConditionRelatedItem(child))
      else if (child.baseName = 'notes') then
        result.notes := ParseString(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeCondition(xml : TXmlBuilder; name : string; elem : TFhirCondition);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  ComposeResourceReference{TFhirEncounter}(xml, 'encounter', elem.encounter);
  ComposeResourceReference{Resource}(xml, 'asserter', elem.asserter);
  ComposeDate(xml, 'dateAsserted', elem.dateAsserted);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeCodeableConcept(xml, 'category', elem.category);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirConditionStatus);
  ComposeCodeableConcept(xml, 'certainty', elem.certainty);
  ComposeCodeableConcept(xml, 'severity', elem.severity);
  if elem.onset is TFhirDate {6} then
    ComposeDate(xml, 'onsetDate', TFhirDate(elem.onset))
  else if elem.onset is TFhirQuantity {6} then
    ComposeAge(xml, 'onsetAge', TFhirQuantity(elem.onset));
  if elem.abatement is TFhirDate {6} then
    ComposeDate(xml, 'abatementDate', TFhirDate(elem.abatement))
  else if elem.abatement is TFhirQuantity {6} then
    ComposeAge(xml, 'abatementAge', TFhirQuantity(elem.abatement))
  else if elem.abatement is TFhirBoolean {6} then
    ComposeBoolean(xml, 'abatementBoolean', TFhirBoolean(elem.abatement));
  ComposeConditionStage(xml, 'stage', elem.stage);
  for i := 0 to elem.evidenceList.Count - 1 do
    ComposeConditionEvidence(xml, 'evidence', elem.evidenceList[i]);
  for i := 0 to elem.locationList.Count - 1 do
    ComposeConditionLocation(xml, 'location', elem.locationList[i]);
  for i := 0 to elem.relatedItemList.Count - 1 do
    ComposeConditionRelatedItem(xml, 'relatedItem', elem.relatedItemList[i]);
  ComposeString(xml, 'notes', elem.notes);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseCondition : TFhirCondition;
begin
  json.next;
  result := TFhirCondition.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}
      else if (json.ItemName = 'asserter') then
        result.asserter := ParseResourceReference{Resource}
      else if (json.ItemName = 'dateAsserted') then
        result.dateAsserted := ParseDate
      else if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'category') then
        result.category := ParseCodeableConcept
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirConditionStatus)
      else if (json.ItemName = 'certainty') then
        result.certainty := ParseCodeableConcept
      else if (json.ItemName = 'severity') then
        result.severity := ParseCodeableConcept
      else if (json.ItemName = 'onsetDate') then
        result.onset := ParseDate
      else if (json.ItemName = 'onsetAge') then
        result.onset := ParseAge
      else if (json.ItemName = 'abatementDate') then
        result.abatement := ParseDate
      else if (json.ItemName = 'abatementAge') then
        result.abatement := ParseAge
      else if (json.ItemName = 'abatementBoolean') then
        result.abatement := ParseBoolean
      else if (json.ItemName = 'stage') then
        result.stage := ParseConditionStage
      else if (json.ItemName = 'evidence') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.evidenceList.Add(ParseConditionEvidence);
          json.Next;
        end;
      end
      else if (json.ItemName = 'location') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.locationList.Add(ParseConditionLocation);
          json.Next;
        end;
      end
      else if (json.ItemName = 'relatedItem') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.relatedItemList.Add(ParseConditionRelatedItem);
          json.Next;
        end;
      end
      else if (json.ItemName = 'notes') then
        result.notes := ParseString
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeCondition(json : TJSONWriter; name : string; elem : TFhirCondition);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  ComposeResourceReference{TFhirEncounter}(json, 'encounter', elem.encounter);
  ComposeResourceReference{Resource}(json, 'asserter', elem.asserter);
  ComposeDate(json, 'dateAsserted', elem.dateAsserted);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeCodeableConcept(json, 'category', elem.category);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirConditionStatus);
  ComposeCodeableConcept(json, 'certainty', elem.certainty);
  ComposeCodeableConcept(json, 'severity', elem.severity);
  if elem.onset is TFhirDate then
    ComposeDate(json, 'onsetDate', TFhirDate(elem.onset))
  else if elem.onset is TFhirQuantity then
    ComposeAge(json, 'onsetAge', TFhirQuantity(elem.onset));
  if elem.abatement is TFhirDate then
    ComposeDate(json, 'abatementDate', TFhirDate(elem.abatement))
  else if elem.abatement is TFhirQuantity then
    ComposeAge(json, 'abatementAge', TFhirQuantity(elem.abatement))
  else if elem.abatement is TFhirBoolean then
    ComposeBoolean(json, 'abatementBoolean', TFhirBoolean(elem.abatement));
  ComposeConditionStage(json, 'stage', elem.stage);
  if elem.evidenceList.Count > 0 then
  begin
    json.valueArray('evidence');
    for i := 0 to elem.evidenceList.Count - 1 do
      ComposeConditionEvidence(json, '',elem.evidenceList[i]);
    json.FinishArray;
  end;
  if elem.locationList.Count > 0 then
  begin
    json.valueArray('location');
    for i := 0 to elem.locationList.Count - 1 do
      ComposeConditionLocation(json, '',elem.locationList[i]);
    json.FinishArray;
  end;
  if elem.relatedItemList.Count > 0 then
  begin
    json.valueArray('relatedItem');
    for i := 0 to elem.relatedItemList.Count - 1 do
      ComposeConditionRelatedItem(json, '',elem.relatedItemList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'notes', elem.notes);
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceSoftware(element : IXmlDomElement) : TFhirConformanceSoftware;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceSoftware.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'version') then
        result.version := ParseString(child) {b}
      else if (child.baseName = 'releaseDate') then
        result.releaseDate := ParseDateTime(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceSoftware(xml : TXmlBuilder; name : string; elem : TFhirConformanceSoftware);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeString(xml, 'version', elem.version);
  ComposeDateTime(xml, 'releaseDate', elem.releaseDate);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceSoftware : TFhirConformanceSoftware;
begin
  json.next;
  result := TFhirConformanceSoftware.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'version') then
        result.version := ParseString
      else if (json.ItemName = 'releaseDate') then
        result.releaseDate := ParseDateTime
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceSoftware(json : TJSONWriter; name : string; elem : TFhirConformanceSoftware);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeString(json, 'version', elem.version);
  ComposeDateTime(json, 'releaseDate', elem.releaseDate);
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceImplementation(element : IXmlDomElement) : TFhirConformanceImplementation;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceImplementation.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'url') then
        result.url := ParseUri(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceImplementation(xml : TXmlBuilder; name : string; elem : TFhirConformanceImplementation);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'description', elem.description);
  ComposeUri(xml, 'url', elem.url);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceImplementation : TFhirConformanceImplementation;
begin
  json.next;
  result := TFhirConformanceImplementation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'url') then
        result.url := ParseUri
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceImplementation(json : TJSONWriter; name : string; elem : TFhirConformanceImplementation);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'description', elem.description);
  ComposeUri(json, 'url', elem.url);
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceRest(element : IXmlDomElement) : TFhirConformanceRest;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceRest.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'mode') then
        result.mode := ParseEnum(CODES_TFhirRestfulConformanceMode, child)
      else if (child.baseName = 'documentation') then
        result.documentation := ParseString(child) {b}
      else if (child.baseName = 'security') then
        result.security := ParseConformanceRestSecurity(child) {b}
      else if (child.baseName = 'resource') then
        result.resourceList.Add(ParseConformanceRestResource(child))
      else if (child.baseName = 'batch') then
        result.batch := ParseBoolean(child) {b}
      else if (child.baseName = 'history') then
        result.history := ParseBoolean(child) {b}
      else if (child.baseName = 'query') then
        result.queryList.Add(ParseConformanceRestQuery(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceRest(xml : TXmlBuilder; name : string; elem : TFhirConformanceRest);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'mode', elem.Mode, CODES_TFhirRestfulConformanceMode);
  ComposeString(xml, 'documentation', elem.documentation);
  ComposeConformanceRestSecurity(xml, 'security', elem.security);
  for i := 0 to elem.resourceList.Count - 1 do
    ComposeConformanceRestResource(xml, 'resource', elem.resourceList[i]);
  ComposeBoolean(xml, 'batch', elem.batch);
  ComposeBoolean(xml, 'history', elem.history);
  for i := 0 to elem.queryList.Count - 1 do
    ComposeConformanceRestQuery(xml, 'query', elem.queryList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceRest : TFhirConformanceRest;
begin
  json.next;
  result := TFhirConformanceRest.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'mode') then
        result.mode := ParseEnum(CODES_TFhirRestfulConformanceMode)
      else if (json.ItemName = 'documentation') then
        result.documentation := ParseString
      else if (json.ItemName = 'security') then
        result.security := ParseConformanceRestSecurity
      else if (json.ItemName = 'resource') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.resourceList.Add(ParseConformanceRestResource);
          json.Next;
        end;
      end
      else if (json.ItemName = 'batch') then
        result.batch := ParseBoolean
      else if (json.ItemName = 'history') then
        result.history := ParseBoolean
      else if (json.ItemName = 'query') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.queryList.Add(ParseConformanceRestQuery);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceRest(json : TJSONWriter; name : string; elem : TFhirConformanceRest);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'mode', elem.Mode, CODES_TFhirRestfulConformanceMode);
  ComposeString(json, 'documentation', elem.documentation);
  ComposeConformanceRestSecurity(json, 'security', elem.security);
  if elem.resourceList.Count > 0 then
  begin
    json.valueArray('resource');
    for i := 0 to elem.resourceList.Count - 1 do
      ComposeConformanceRestResource(json, '',elem.resourceList[i]);
    json.FinishArray;
  end;
  ComposeBoolean(json, 'batch', elem.batch);
  ComposeBoolean(json, 'history', elem.history);
  if elem.queryList.Count > 0 then
  begin
    json.valueArray('query');
    for i := 0 to elem.queryList.Count - 1 do
      ComposeConformanceRestQuery(json, '',elem.queryList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceRestSecurity(element : IXmlDomElement) : TFhirConformanceRestSecurity;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceRestSecurity.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'service') then
        result.serviceList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'certificate') then
        result.certificateList.Add(ParseConformanceRestSecurityCertificate(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceRestSecurity(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestSecurity);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.serviceList.Count - 1 do
    ComposeCodeableConcept(xml, 'service', elem.serviceList[i]);
  ComposeString(xml, 'description', elem.description);
  for i := 0 to elem.certificateList.Count - 1 do
    ComposeConformanceRestSecurityCertificate(xml, 'certificate', elem.certificateList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceRestSecurity : TFhirConformanceRestSecurity;
begin
  json.next;
  result := TFhirConformanceRestSecurity.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'service') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.serviceList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'certificate') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.certificateList.Add(ParseConformanceRestSecurityCertificate);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceRestSecurity(json : TJSONWriter; name : string; elem : TFhirConformanceRestSecurity);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.serviceList.Count > 0 then
  begin
    json.valueArray('service');
    for i := 0 to elem.serviceList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.serviceList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'description', elem.description);
  if elem.certificateList.Count > 0 then
  begin
    json.valueArray('certificate');
    for i := 0 to elem.certificateList.Count - 1 do
      ComposeConformanceRestSecurityCertificate(json, '',elem.certificateList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceRestSecurityCertificate(element : IXmlDomElement) : TFhirConformanceRestSecurityCertificate;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceRestSecurityCertificate.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCode(child) {b}
      else if (child.baseName = 'blob') then
        result.blob := ParseBase64Binary(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceRestSecurityCertificate(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestSecurityCertificate);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'type', elem.type_);
  ComposeBase64Binary(xml, 'blob', elem.blob);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceRestSecurityCertificate : TFhirConformanceRestSecurityCertificate;
begin
  json.next;
  result := TFhirConformanceRestSecurityCertificate.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCode
      else if (json.ItemName = 'blob') then
        result.blob := ParseBase64Binary
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceRestSecurityCertificate(json : TJSONWriter; name : string; elem : TFhirConformanceRestSecurityCertificate);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'type', elem.type_);
  ComposeBase64Binary(json, 'blob', elem.blob);
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceRestResource(element : IXmlDomElement) : TFhirConformanceRestResource;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceRestResource.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCode(child) {b}
      else if (child.baseName = 'profile') then
        result.profile := ParseResourceReference{TFhirProfile}(child) {b}
      else if (child.baseName = 'operation') then
        result.operationList.Add(ParseConformanceRestResourceOperation(child))
      else if (child.baseName = 'readHistory') then
        result.readHistory := ParseBoolean(child) {b}
      else if (child.baseName = 'searchInclude') then
        result.searchIncludeList.Add(ParseString(child))
      else if (child.baseName = 'searchParam') then
        result.searchParamList.Add(ParseConformanceRestResourceSearchParam(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceRestResource(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestResource);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'type', elem.type_);
  ComposeResourceReference{TFhirProfile}(xml, 'profile', elem.profile);
  for i := 0 to elem.operationList.Count - 1 do
    ComposeConformanceRestResourceOperation(xml, 'operation', elem.operationList[i]);
  ComposeBoolean(xml, 'readHistory', elem.readHistory);
  for i := 0 to elem.searchIncludeList.Count - 1 do
    ComposeString(xml, 'searchInclude', elem.searchIncludeList[i]);
  for i := 0 to elem.searchParamList.Count - 1 do
    ComposeConformanceRestResourceSearchParam(xml, 'searchParam', elem.searchParamList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceRestResource : TFhirConformanceRestResource;
begin
  json.next;
  result := TFhirConformanceRestResource.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCode
      else if (json.ItemName = 'profile') then
        result.profile := ParseResourceReference{TFhirProfile}
      else if (json.ItemName = 'operation') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.operationList.Add(ParseConformanceRestResourceOperation);
          json.Next;
        end;
      end
      else if (json.ItemName = 'readHistory') then
        result.readHistory := ParseBoolean
      else if (json.ItemName = 'searchInclude') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.searchIncludeList.Add(ParseString);
          json.Next;
        end;
      end
      else if (json.ItemName = 'searchParam') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.searchParamList.Add(ParseConformanceRestResourceSearchParam);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceRestResource(json : TJSONWriter; name : string; elem : TFhirConformanceRestResource);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'type', elem.type_);
  ComposeResourceReference{TFhirProfile}(json, 'profile', elem.profile);
  if elem.operationList.Count > 0 then
  begin
    json.valueArray('operation');
    for i := 0 to elem.operationList.Count - 1 do
      ComposeConformanceRestResourceOperation(json, '',elem.operationList[i]);
    json.FinishArray;
  end;
  ComposeBoolean(json, 'readHistory', elem.readHistory);
  if elem.searchIncludeList.Count > 0 then
  begin
    json.valueArray('searchInclude');
    for i := 0 to elem.searchIncludeList.Count - 1 do
      ComposeString(json, '',elem.searchIncludeList[i]);
    json.FinishArray;
  end;
  if elem.searchParamList.Count > 0 then
  begin
    json.valueArray('searchParam');
    for i := 0 to elem.searchParamList.Count - 1 do
      ComposeConformanceRestResourceSearchParam(json, '',elem.searchParamList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceRestResourceOperation(element : IXmlDomElement) : TFhirConformanceRestResourceOperation;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceRestResourceOperation.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseEnum(CODES_TFhirRestfulOperation, child)
      else if (child.baseName = 'documentation') then
        result.documentation := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceRestResourceOperation(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestResourceOperation);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'code', elem.Code, CODES_TFhirRestfulOperation);
  ComposeString(xml, 'documentation', elem.documentation);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceRestResourceOperation : TFhirConformanceRestResourceOperation;
begin
  json.next;
  result := TFhirConformanceRestResourceOperation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseEnum(CODES_TFhirRestfulOperation)
      else if (json.ItemName = 'documentation') then
        result.documentation := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceRestResourceOperation(json : TJSONWriter; name : string; elem : TFhirConformanceRestResourceOperation);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'code', elem.Code, CODES_TFhirRestfulOperation);
  ComposeString(json, 'documentation', elem.documentation);
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceRestResourceSearchParam(element : IXmlDomElement) : TFhirConformanceRestResourceSearchParam;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceRestResourceSearchParam.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'source') then
        result.source := ParseUri(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirSearchParamType, child)
      else if (child.baseName = 'documentation') then
        result.documentation := ParseString(child) {b}
      else if (child.baseName = 'xpath') then
        result.xpath := ParseString(child) {b}
      else if (child.baseName = 'target') then
        result.targetList.Add(ParseCode(child))
      else if (child.baseName = 'chain') then
        result.chainList.Add(ParseString(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceRestResourceSearchParam(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestResourceSearchParam);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeUri(xml, 'source', elem.source);
  ComposeEnum(xml, 'type', elem.Type_, CODES_TFhirSearchParamType);
  ComposeString(xml, 'documentation', elem.documentation);
  ComposeString(xml, 'xpath', elem.xpath);
  for i := 0 to elem.targetList.Count - 1 do
    ComposeCode(xml, 'target', elem.targetList[i]);
  for i := 0 to elem.chainList.Count - 1 do
    ComposeString(xml, 'chain', elem.chainList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceRestResourceSearchParam : TFhirConformanceRestResourceSearchParam;
begin
  json.next;
  result := TFhirConformanceRestResourceSearchParam.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'source') then
        result.source := ParseUri
      else if (json.ItemName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirSearchParamType)
      else if (json.ItemName = 'documentation') then
        result.documentation := ParseString
      else if (json.ItemName = 'xpath') then
        result.xpath := ParseString
      else if (json.ItemName = 'target') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.targetList.Add(ParseCode);
          json.Next;
        end;
      end
      else if (json.ItemName = 'chain') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.chainList.Add(ParseString);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceRestResourceSearchParam(json : TJSONWriter; name : string; elem : TFhirConformanceRestResourceSearchParam);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeUri(json, 'source', elem.source);
  ComposeEnum(json, 'type', elem.Type_, CODES_TFhirSearchParamType);
  ComposeString(json, 'documentation', elem.documentation);
  ComposeString(json, 'xpath', elem.xpath);
  if elem.targetList.Count > 0 then
  begin
    json.valueArray('target');
    for i := 0 to elem.targetList.Count - 1 do
      ComposeCode(json, '',elem.targetList[i]);
    json.FinishArray;
  end;
  if elem.chainList.Count > 0 then
  begin
    json.valueArray('chain');
    for i := 0 to elem.chainList.Count - 1 do
      ComposeString(json, '',elem.chainList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceRestQuery(element : IXmlDomElement) : TFhirConformanceRestQuery;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceRestQuery.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'documentation') then
        result.documentation := ParseString(child) {b}
      else if (child.baseName = 'parameter') then
        result.parameterList.Add(ParseConformanceRestResourceSearchParam(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceRestQuery(xml : TXmlBuilder; name : string; elem : TFhirConformanceRestQuery);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeString(xml, 'documentation', elem.documentation);
  for i := 0 to elem.parameterList.Count - 1 do
    ComposeConformanceRestResourceSearchParam(xml, 'parameter', elem.parameterList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceRestQuery : TFhirConformanceRestQuery;
begin
  json.next;
  result := TFhirConformanceRestQuery.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'documentation') then
        result.documentation := ParseString
      else if (json.ItemName = 'parameter') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.parameterList.Add(ParseConformanceRestResourceSearchParam);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceRestQuery(json : TJSONWriter; name : string; elem : TFhirConformanceRestQuery);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeString(json, 'documentation', elem.documentation);
  if elem.parameterList.Count > 0 then
  begin
    json.valueArray('parameter');
    for i := 0 to elem.parameterList.Count - 1 do
      ComposeConformanceRestResourceSearchParam(json, '',elem.parameterList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceMessaging(element : IXmlDomElement) : TFhirConformanceMessaging;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceMessaging.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'endpoint') then
        result.endpoint := ParseUri(child) {b}
      else if (child.baseName = 'reliableCache') then
        result.reliableCache := ParseInteger(child) {b}
      else if (child.baseName = 'documentation') then
        result.documentation := ParseString(child) {b}
      else if (child.baseName = 'event') then
        result.eventList.Add(ParseConformanceMessagingEvent(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceMessaging(xml : TXmlBuilder; name : string; elem : TFhirConformanceMessaging);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeUri(xml, 'endpoint', elem.endpoint);
  ComposeInteger(xml, 'reliableCache', elem.reliableCache);
  ComposeString(xml, 'documentation', elem.documentation);
  for i := 0 to elem.eventList.Count - 1 do
    ComposeConformanceMessagingEvent(xml, 'event', elem.eventList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceMessaging : TFhirConformanceMessaging;
begin
  json.next;
  result := TFhirConformanceMessaging.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'endpoint') then
        result.endpoint := ParseUri
      else if (json.ItemName = 'reliableCache') then
        result.reliableCache := ParseInteger
      else if (json.ItemName = 'documentation') then
        result.documentation := ParseString
      else if (json.ItemName = 'event') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.eventList.Add(ParseConformanceMessagingEvent);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceMessaging(json : TJSONWriter; name : string; elem : TFhirConformanceMessaging);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeUri(json, 'endpoint', elem.endpoint);
  ComposeInteger(json, 'reliableCache', elem.reliableCache);
  ComposeString(json, 'documentation', elem.documentation);
  if elem.eventList.Count > 0 then
  begin
    json.valueArray('event');
    for i := 0 to elem.eventList.Count - 1 do
      ComposeConformanceMessagingEvent(json, '',elem.eventList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceMessagingEvent(element : IXmlDomElement) : TFhirConformanceMessagingEvent;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceMessagingEvent.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCode(child) {b}
      else if (child.baseName = 'mode') then
        result.mode := ParseEnum(CODES_TFhirMessageConformanceEventMode, child)
      else if (child.baseName = 'protocol') then
        result.protocolList.Add(ParseCoding(child))
      else if (child.baseName = 'focus') then
        result.focus := ParseCode(child) {b}
      else if (child.baseName = 'request') then
        result.request := ParseResourceReference{TFhirProfile}(child) {b}
      else if (child.baseName = 'response') then
        result.response := ParseResourceReference{TFhirProfile}(child) {b}
      else if (child.baseName = 'documentation') then
        result.documentation := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceMessagingEvent(xml : TXmlBuilder; name : string; elem : TFhirConformanceMessagingEvent);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'code', elem.code);
  ComposeEnum(xml, 'mode', elem.Mode, CODES_TFhirMessageConformanceEventMode);
  for i := 0 to elem.protocolList.Count - 1 do
    ComposeCoding(xml, 'protocol', elem.protocolList[i]);
  ComposeCode(xml, 'focus', elem.focus);
  ComposeResourceReference{TFhirProfile}(xml, 'request', elem.request);
  ComposeResourceReference{TFhirProfile}(xml, 'response', elem.response);
  ComposeString(xml, 'documentation', elem.documentation);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceMessagingEvent : TFhirConformanceMessagingEvent;
begin
  json.next;
  result := TFhirConformanceMessagingEvent.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCode
      else if (json.ItemName = 'mode') then
        result.mode := ParseEnum(CODES_TFhirMessageConformanceEventMode)
      else if (json.ItemName = 'protocol') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.protocolList.Add(ParseCoding);
          json.Next;
        end;
      end
      else if (json.ItemName = 'focus') then
        result.focus := ParseCode
      else if (json.ItemName = 'request') then
        result.request := ParseResourceReference{TFhirProfile}
      else if (json.ItemName = 'response') then
        result.response := ParseResourceReference{TFhirProfile}
      else if (json.ItemName = 'documentation') then
        result.documentation := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceMessagingEvent(json : TJSONWriter; name : string; elem : TFhirConformanceMessagingEvent);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'code', elem.code);
  ComposeEnum(json, 'mode', elem.Mode, CODES_TFhirMessageConformanceEventMode);
  if elem.protocolList.Count > 0 then
  begin
    json.valueArray('protocol');
    for i := 0 to elem.protocolList.Count - 1 do
      ComposeCoding(json, '',elem.protocolList[i]);
    json.FinishArray;
  end;
  ComposeCode(json, 'focus', elem.focus);
  ComposeResourceReference{TFhirProfile}(json, 'request', elem.request);
  ComposeResourceReference{TFhirProfile}(json, 'response', elem.response);
  ComposeString(json, 'documentation', elem.documentation);
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformanceDocument(element : IXmlDomElement) : TFhirConformanceDocument;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformanceDocument.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'mode') then
        result.mode := ParseEnum(CODES_TFhirDocumentMode, child)
      else if (child.baseName = 'documentation') then
        result.documentation := ParseString(child) {b}
      else if (child.baseName = 'profile') then
        result.profile := ParseResourceReference{TFhirProfile}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformanceDocument(xml : TXmlBuilder; name : string; elem : TFhirConformanceDocument);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'mode', elem.Mode, CODES_TFhirDocumentMode);
  ComposeString(xml, 'documentation', elem.documentation);
  ComposeResourceReference{TFhirProfile}(xml, 'profile', elem.profile);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformanceDocument : TFhirConformanceDocument;
begin
  json.next;
  result := TFhirConformanceDocument.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'mode') then
        result.mode := ParseEnum(CODES_TFhirDocumentMode)
      else if (json.ItemName = 'documentation') then
        result.documentation := ParseString
      else if (json.ItemName = 'profile') then
        result.profile := ParseResourceReference{TFhirProfile}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformanceDocument(json : TJSONWriter; name : string; elem : TFhirConformanceDocument);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'mode', elem.Mode, CODES_TFhirDocumentMode);
  ComposeString(json, 'documentation', elem.documentation);
  ComposeResourceReference{TFhirProfile}(json, 'profile', elem.profile);
  json.finishObject;
end;

function TFHIRXmlParser.ParseConformance(element : IXmlDomElement) : TFhirConformance;
var
  child : IXMLDOMElement;
begin
  result := TFhirConformance.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseString(child) {b}
      else if (child.baseName = 'version') then
        result.version := ParseString(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'publisher') then
        result.publisher := ParseString(child) {b}
      else if (child.baseName = 'telecom') then
        result.telecomList.Add(ParseContact(child))
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirConformanceStatementStatus, child)
      else if (child.baseName = 'experimental') then
        result.experimental := ParseBoolean(child) {b}
      else if (child.baseName = 'date') then
        result.date := ParseDateTime(child) {b}
      else if (child.baseName = 'software') then
        result.software := ParseConformanceSoftware(child) {b}
      else if (child.baseName = 'implementation') then
        result.implementation_ := ParseConformanceImplementation(child) {b}
      else if (child.baseName = 'fhirVersion') then
        result.fhirVersion := ParseId(child) {b}
      else if (child.baseName = 'acceptUnknown') then
        result.acceptUnknown := ParseBoolean(child) {b}
      else if (child.baseName = 'format') then
        result.formatList.Add(ParseCode(child))
      else if (child.baseName = 'rest') then
        result.restList.Add(ParseConformanceRest(child))
      else if (child.baseName = 'messaging') then
        result.messagingList.Add(ParseConformanceMessaging(child))
      else if (child.baseName = 'document') then
        result.documentList.Add(ParseConformanceDocument(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeConformance(xml : TXmlBuilder; name : string; elem : TFhirConformance);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeString(xml, 'identifier', elem.identifier);
  ComposeString(xml, 'version', elem.version);
  ComposeString(xml, 'name', elem.name);
  ComposeString(xml, 'publisher', elem.publisher);
  for i := 0 to elem.telecomList.Count - 1 do
    ComposeContact(xml, 'telecom', elem.telecomList[i]);
  ComposeString(xml, 'description', elem.description);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirConformanceStatementStatus);
  ComposeBoolean(xml, 'experimental', elem.experimental);
  ComposeDateTime(xml, 'date', elem.date);
  ComposeConformanceSoftware(xml, 'software', elem.software);
  ComposeConformanceImplementation(xml, 'implementation', elem.implementation_);
  ComposeId(xml, 'fhirVersion', elem.fhirVersion);
  ComposeBoolean(xml, 'acceptUnknown', elem.acceptUnknown);
  for i := 0 to elem.formatList.Count - 1 do
    ComposeCode(xml, 'format', elem.formatList[i]);
  for i := 0 to elem.restList.Count - 1 do
    ComposeConformanceRest(xml, 'rest', elem.restList[i]);
  for i := 0 to elem.messagingList.Count - 1 do
    ComposeConformanceMessaging(xml, 'messaging', elem.messagingList[i]);
  for i := 0 to elem.documentList.Count - 1 do
    ComposeConformanceDocument(xml, 'document', elem.documentList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseConformance : TFhirConformance;
begin
  json.next;
  result := TFhirConformance.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseString
      else if (json.ItemName = 'version') then
        result.version := ParseString
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'publisher') then
        result.publisher := ParseString
      else if (json.ItemName = 'telecom') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.telecomList.Add(ParseContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirConformanceStatementStatus)
      else if (json.ItemName = 'experimental') then
        result.experimental := ParseBoolean
      else if (json.ItemName = 'date') then
        result.date := ParseDateTime
      else if (json.ItemName = 'software') then
        result.software := ParseConformanceSoftware
      else if (json.ItemName = 'implementation') then
        result.implementation_ := ParseConformanceImplementation
      else if (json.ItemName = 'fhirVersion') then
        result.fhirVersion := ParseId
      else if (json.ItemName = 'acceptUnknown') then
        result.acceptUnknown := ParseBoolean
      else if (json.ItemName = 'format') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.formatList.Add(ParseCode);
          json.Next;
        end;
      end
      else if (json.ItemName = 'rest') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.restList.Add(ParseConformanceRest);
          json.Next;
        end;
      end
      else if (json.ItemName = 'messaging') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.messagingList.Add(ParseConformanceMessaging);
          json.Next;
        end;
      end
      else if (json.ItemName = 'document') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.documentList.Add(ParseConformanceDocument);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeConformance(json : TJSONWriter; name : string; elem : TFhirConformance);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeString(json, 'identifier', elem.identifier);
  ComposeString(json, 'version', elem.version);
  ComposeString(json, 'name', elem.name);
  ComposeString(json, 'publisher', elem.publisher);
  if elem.telecomList.Count > 0 then
  begin
    json.valueArray('telecom');
    for i := 0 to elem.telecomList.Count - 1 do
      ComposeContact(json, '',elem.telecomList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'description', elem.description);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirConformanceStatementStatus);
  ComposeBoolean(json, 'experimental', elem.experimental);
  ComposeDateTime(json, 'date', elem.date);
  ComposeConformanceSoftware(json, 'software', elem.software);
  ComposeConformanceImplementation(json, 'implementation', elem.implementation_);
  ComposeId(json, 'fhirVersion', elem.fhirVersion);
  ComposeBoolean(json, 'acceptUnknown', elem.acceptUnknown);
  if elem.formatList.Count > 0 then
  begin
    json.valueArray('format');
    for i := 0 to elem.formatList.Count - 1 do
      ComposeCode(json, '',elem.formatList[i]);
    json.FinishArray;
  end;
  if elem.restList.Count > 0 then
  begin
    json.valueArray('rest');
    for i := 0 to elem.restList.Count - 1 do
      ComposeConformanceRest(json, '',elem.restList[i]);
    json.FinishArray;
  end;
  if elem.messagingList.Count > 0 then
  begin
    json.valueArray('messaging');
    for i := 0 to elem.messagingList.Count - 1 do
      ComposeConformanceMessaging(json, '',elem.messagingList[i]);
    json.FinishArray;
  end;
  if elem.documentList.Count > 0 then
  begin
    json.valueArray('document');
    for i := 0 to elem.documentList.Count - 1 do
      ComposeConformanceDocument(json, '',elem.documentList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseCoverageSubscriber(element : IXmlDomElement) : TFhirCoverageSubscriber;
var
  child : IXMLDOMElement;
begin
  result := TFhirCoverageSubscriber.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseHumanName(child) {b}
      else if (child.baseName = 'address') then
        result.address := ParseAddress(child) {b}
      else if (child.baseName = 'birthdate') then
        result.birthdate := ParseDate(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeCoverageSubscriber(xml : TXmlBuilder; name : string; elem : TFhirCoverageSubscriber);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeHumanName(xml, 'name', elem.name);
  ComposeAddress(xml, 'address', elem.address);
  ComposeDate(xml, 'birthdate', elem.birthdate);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseCoverageSubscriber : TFhirCoverageSubscriber;
begin
  json.next;
  result := TFhirCoverageSubscriber.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseHumanName
      else if (json.ItemName = 'address') then
        result.address := ParseAddress
      else if (json.ItemName = 'birthdate') then
        result.birthdate := ParseDate
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeCoverageSubscriber(json : TJSONWriter; name : string; elem : TFhirCoverageSubscriber);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeHumanName(json, 'name', elem.name);
  ComposeAddress(json, 'address', elem.address);
  ComposeDate(json, 'birthdate', elem.birthdate);
  json.finishObject;
end;

function TFHIRXmlParser.ParseCoverage(element : IXmlDomElement) : TFhirCoverage;
var
  child : IXMLDOMElement;
begin
  result := TFhirCoverage.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'issuer') then
        result.issuer := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCoding(child) {b}
      else if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'group') then
        result.group := ParseIdentifier(child) {b}
      else if (child.baseName = 'plan') then
        result.plan := ParseIdentifier(child) {b}
      else if (child.baseName = 'subplan') then
        result.subplan := ParseIdentifier(child) {b}
      else if (child.baseName = 'dependent') then
        result.dependent := ParseInteger(child) {b}
      else if (child.baseName = 'sequence') then
        result.sequence := ParseInteger(child) {b}
      else if (child.baseName = 'subscriber') then
        result.subscriber := ParseCoverageSubscriber(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeCoverage(xml : TXmlBuilder; name : string; elem : TFhirCoverage);
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeResourceReference{TFhirOrganization}(xml, 'issuer', elem.issuer);
  ComposePeriod(xml, 'period', elem.period);
  ComposeCoding(xml, 'type', elem.type_);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeIdentifier(xml, 'group', elem.group);
  ComposeIdentifier(xml, 'plan', elem.plan);
  ComposeIdentifier(xml, 'subplan', elem.subplan);
  ComposeInteger(xml, 'dependent', elem.dependent);
  ComposeInteger(xml, 'sequence', elem.sequence);
  ComposeCoverageSubscriber(xml, 'subscriber', elem.subscriber);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseCoverage : TFhirCoverage;
begin
  json.next;
  result := TFhirCoverage.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'issuer') then
        result.issuer := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if (json.ItemName = 'type') then
        result.type_ := ParseCoding
      else if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'group') then
        result.group := ParseIdentifier
      else if (json.ItemName = 'plan') then
        result.plan := ParseIdentifier
      else if (json.ItemName = 'subplan') then
        result.subplan := ParseIdentifier
      else if (json.ItemName = 'dependent') then
        result.dependent := ParseInteger
      else if (json.ItemName = 'sequence') then
        result.sequence := ParseInteger
      else if (json.ItemName = 'subscriber') then
        result.subscriber := ParseCoverageSubscriber
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeCoverage(json : TJSONWriter; name : string; elem : TFhirCoverage);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeResourceReference{TFhirOrganization}(json, 'issuer', elem.issuer);
  ComposePeriod(json, 'period', elem.period);
  ComposeCoding(json, 'type', elem.type_);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeIdentifier(json, 'group', elem.group);
  ComposeIdentifier(json, 'plan', elem.plan);
  ComposeIdentifier(json, 'subplan', elem.subplan);
  ComposeInteger(json, 'dependent', elem.dependent);
  ComposeInteger(json, 'sequence', elem.sequence);
  ComposeCoverageSubscriber(json, 'subscriber', elem.subscriber);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDeviceIdentity(element : IXmlDomElement) : TFhirDeviceIdentity;
var
  child : IXMLDOMElement;
begin
  result := TFhirDeviceIdentity.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'gtin') then
        result.gtin := ParseString(child) {b}
      else if (child.baseName = 'lot') then
        result.lot := ParseString(child) {b}
      else if (child.baseName = 'serialNumber') then
        result.serialNumber := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDeviceIdentity(xml : TXmlBuilder; name : string; elem : TFhirDeviceIdentity);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'gtin', elem.gtin);
  ComposeString(xml, 'lot', elem.lot);
  ComposeString(xml, 'serialNumber', elem.serialNumber);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDeviceIdentity : TFhirDeviceIdentity;
begin
  json.next;
  result := TFhirDeviceIdentity.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'gtin') then
        result.gtin := ParseString
      else if (json.ItemName = 'lot') then
        result.lot := ParseString
      else if (json.ItemName = 'serialNumber') then
        result.serialNumber := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDeviceIdentity(json : TJSONWriter; name : string; elem : TFhirDeviceIdentity);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'gtin', elem.gtin);
  ComposeString(json, 'lot', elem.lot);
  ComposeString(json, 'serialNumber', elem.serialNumber);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDevice(element : IXmlDomElement) : TFhirDevice;
var
  child : IXMLDOMElement;
begin
  result := TFhirDevice.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'manufacturer') then
        result.manufacturer := ParseString(child) {b}
      else if (child.baseName = 'model') then
        result.model := ParseString(child) {b}
      else if (child.baseName = 'version') then
        result.version := ParseString(child) {b}
      else if (child.baseName = 'expiry') then
        result.expiry := ParseDate(child) {b}
      else if (child.baseName = 'identity') then
        result.identity := ParseDeviceIdentity(child) {b}
      else if (child.baseName = 'owner') then
        result.owner := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'assignedId') then
        result.assignedIdList.Add(ParseIdentifier(child))
      else if (child.baseName = 'location') then
        result.location := ParseResourceReference{TFhirLocation}(child) {b}
      else if (child.baseName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'contact') then
        result.contactList.Add(ParseContact(child))
      else if (child.baseName = 'url') then
        result.url := ParseUri(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDevice(xml : TXmlBuilder; name : string; elem : TFhirDevice);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeString(xml, 'manufacturer', elem.manufacturer);
  ComposeString(xml, 'model', elem.model);
  ComposeString(xml, 'version', elem.version);
  ComposeDate(xml, 'expiry', elem.expiry);
  ComposeDeviceIdentity(xml, 'identity', elem.identity);
  ComposeResourceReference{TFhirOrganization}(xml, 'owner', elem.owner);
  for i := 0 to elem.assignedIdList.Count - 1 do
    ComposeIdentifier(xml, 'assignedId', elem.assignedIdList[i]);
  ComposeResourceReference{TFhirLocation}(xml, 'location', elem.location);
  ComposeResourceReference{TFhirPatient}(xml, 'patient', elem.patient);
  for i := 0 to elem.contactList.Count - 1 do
    ComposeContact(xml, 'contact', elem.contactList[i]);
  ComposeUri(xml, 'url', elem.url);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDevice : TFhirDevice;
begin
  json.next;
  result := TFhirDevice.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'manufacturer') then
        result.manufacturer := ParseString
      else if (json.ItemName = 'model') then
        result.model := ParseString
      else if (json.ItemName = 'version') then
        result.version := ParseString
      else if (json.ItemName = 'expiry') then
        result.expiry := ParseDate
      else if (json.ItemName = 'identity') then
        result.identity := ParseDeviceIdentity
      else if (json.ItemName = 'owner') then
        result.owner := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'assignedId') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.assignedIdList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'location') then
        result.location := ParseResourceReference{TFhirLocation}
      else if (json.ItemName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'contact') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.contactList.Add(ParseContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'url') then
        result.url := ParseUri
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDevice(json : TJSONWriter; name : string; elem : TFhirDevice);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeString(json, 'manufacturer', elem.manufacturer);
  ComposeString(json, 'model', elem.model);
  ComposeString(json, 'version', elem.version);
  ComposeDate(json, 'expiry', elem.expiry);
  ComposeDeviceIdentity(json, 'identity', elem.identity);
  ComposeResourceReference{TFhirOrganization}(json, 'owner', elem.owner);
  if elem.assignedIdList.Count > 0 then
  begin
    json.valueArray('assignedId');
    for i := 0 to elem.assignedIdList.Count - 1 do
      ComposeIdentifier(json, '',elem.assignedIdList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirLocation}(json, 'location', elem.location);
  ComposeResourceReference{TFhirPatient}(json, 'patient', elem.patient);
  if elem.contactList.Count > 0 then
  begin
    json.valueArray('contact');
    for i := 0 to elem.contactList.Count - 1 do
      ComposeContact(json, '',elem.contactList[i]);
    json.FinishArray;
  end;
  ComposeUri(json, 'url', elem.url);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDeviceCapabilitiesVirtualDevice(element : IXmlDomElement) : TFhirDeviceCapabilitiesVirtualDevice;
var
  child : IXMLDOMElement;
begin
  result := TFhirDeviceCapabilitiesVirtualDevice.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'channel') then
        result.channelList.Add(ParseDeviceCapabilitiesVirtualDeviceChannel(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDeviceCapabilitiesVirtualDevice(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilitiesVirtualDevice);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  for i := 0 to elem.channelList.Count - 1 do
    ComposeDeviceCapabilitiesVirtualDeviceChannel(xml, 'channel', elem.channelList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDeviceCapabilitiesVirtualDevice : TFhirDeviceCapabilitiesVirtualDevice;
begin
  json.next;
  result := TFhirDeviceCapabilitiesVirtualDevice.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'channel') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.channelList.Add(ParseDeviceCapabilitiesVirtualDeviceChannel);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDeviceCapabilitiesVirtualDevice(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilitiesVirtualDevice);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  if elem.channelList.Count > 0 then
  begin
    json.valueArray('channel');
    for i := 0 to elem.channelList.Count - 1 do
      ComposeDeviceCapabilitiesVirtualDeviceChannel(json, '',elem.channelList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDeviceCapabilitiesVirtualDeviceChannel(element : IXmlDomElement) : TFhirDeviceCapabilitiesVirtualDeviceChannel;
var
  child : IXMLDOMElement;
begin
  result := TFhirDeviceCapabilitiesVirtualDeviceChannel.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'metric') then
        result.metricList.Add(ParseDeviceCapabilitiesVirtualDeviceChannelMetric(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDeviceCapabilitiesVirtualDeviceChannel(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannel);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  for i := 0 to elem.metricList.Count - 1 do
    ComposeDeviceCapabilitiesVirtualDeviceChannelMetric(xml, 'metric', elem.metricList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDeviceCapabilitiesVirtualDeviceChannel : TFhirDeviceCapabilitiesVirtualDeviceChannel;
begin
  json.next;
  result := TFhirDeviceCapabilitiesVirtualDeviceChannel.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'metric') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.metricList.Add(ParseDeviceCapabilitiesVirtualDeviceChannelMetric);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDeviceCapabilitiesVirtualDeviceChannel(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannel);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  if elem.metricList.Count > 0 then
  begin
    json.valueArray('metric');
    for i := 0 to elem.metricList.Count - 1 do
      ComposeDeviceCapabilitiesVirtualDeviceChannelMetric(json, '',elem.metricList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDeviceCapabilitiesVirtualDeviceChannelMetric(element : IXmlDomElement) : TFhirDeviceCapabilitiesVirtualDeviceChannelMetric;
var
  child : IXMLDOMElement;
begin
  result := TFhirDeviceCapabilitiesVirtualDeviceChannelMetric.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'key') then
        result.key := ParseString(child) {b}
      else if (child.baseName = 'info') then
        result.info := ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfo(child) {b}
      else if (child.baseName = 'facet') then
        result.facetList.Add(ParseDeviceCapabilitiesVirtualDeviceChannelMetricFacet(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDeviceCapabilitiesVirtualDeviceChannelMetric(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetric);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeString(xml, 'key', elem.key);
  ComposeDeviceCapabilitiesVirtualDeviceChannelMetricInfo(xml, 'info', elem.info);
  for i := 0 to elem.facetList.Count - 1 do
    ComposeDeviceCapabilitiesVirtualDeviceChannelMetricFacet(xml, 'facet', elem.facetList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDeviceCapabilitiesVirtualDeviceChannelMetric : TFhirDeviceCapabilitiesVirtualDeviceChannelMetric;
begin
  json.next;
  result := TFhirDeviceCapabilitiesVirtualDeviceChannelMetric.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'key') then
        result.key := ParseString
      else if (json.ItemName = 'info') then
        result.info := ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfo
      else if (json.ItemName = 'facet') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.facetList.Add(ParseDeviceCapabilitiesVirtualDeviceChannelMetricFacet);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDeviceCapabilitiesVirtualDeviceChannelMetric(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetric);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeString(json, 'key', elem.key);
  ComposeDeviceCapabilitiesVirtualDeviceChannelMetricInfo(json, 'info', elem.info);
  if elem.facetList.Count > 0 then
  begin
    json.valueArray('facet');
    for i := 0 to elem.facetList.Count - 1 do
      ComposeDeviceCapabilitiesVirtualDeviceChannelMetricFacet(json, '',elem.facetList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfo(element : IXmlDomElement) : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo;
var
  child : IXMLDOMElement;
begin
  result := TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirDeviceDataType, child)
      else if (child.baseName = 'units') then
        result.units := ParseString(child) {b}
      else if (child.baseName = 'ucum') then
        result.ucum := ParseCode(child) {b}
      else if (child.baseName = 'template') then
        result.template := ParseSampledData(child) {b}
      else if (child.baseName = 'system') then
        result.system := ParseUri(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDeviceCapabilitiesVirtualDeviceChannelMetricInfo(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'type', elem.Type_, CODES_TFhirDeviceDataType);
  ComposeString(xml, 'units', elem.units);
  ComposeCode(xml, 'ucum', elem.ucum);
  ComposeSampledData(xml, 'template', elem.template);
  ComposeUri(xml, 'system', elem.system);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfo : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo;
begin
  json.next;
  result := TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirDeviceDataType)
      else if (json.ItemName = 'units') then
        result.units := ParseString
      else if (json.ItemName = 'ucum') then
        result.ucum := ParseCode
      else if (json.ItemName = 'template') then
        result.template := ParseSampledData
      else if (json.ItemName = 'system') then
        result.system := ParseUri
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDeviceCapabilitiesVirtualDeviceChannelMetricInfo(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'type', elem.Type_, CODES_TFhirDeviceDataType);
  ComposeString(json, 'units', elem.units);
  ComposeCode(json, 'ucum', elem.ucum);
  ComposeSampledData(json, 'template', elem.template);
  ComposeUri(json, 'system', elem.system);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDeviceCapabilitiesVirtualDeviceChannelMetricFacet(element : IXmlDomElement) : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet;
var
  child : IXMLDOMElement;
begin
  result := TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'scale') then
        result.scale := ParseDecimal(child) {b}
      else if (child.baseName = 'key') then
        result.key := ParseString(child) {b}
      else if (child.baseName = 'info') then
        result.info := ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfo(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDeviceCapabilitiesVirtualDeviceChannelMetricFacet(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeDecimal(xml, 'scale', elem.scale);
  ComposeString(xml, 'key', elem.key);
  ComposeDeviceCapabilitiesVirtualDeviceChannelMetricInfo(xml, 'info', elem.info);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDeviceCapabilitiesVirtualDeviceChannelMetricFacet : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet;
begin
  json.next;
  result := TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'scale') then
        result.scale := ParseDecimal
      else if (json.ItemName = 'key') then
        result.key := ParseString
      else if (json.ItemName = 'info') then
        result.info := ParseDeviceCapabilitiesVirtualDeviceChannelMetricInfo
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDeviceCapabilitiesVirtualDeviceChannelMetricFacet(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeDecimal(json, 'scale', elem.scale);
  ComposeString(json, 'key', elem.key);
  ComposeDeviceCapabilitiesVirtualDeviceChannelMetricInfo(json, 'info', elem.info);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDeviceCapabilities(element : IXmlDomElement) : TFhirDeviceCapabilities;
var
  child : IXMLDOMElement;
begin
  result := TFhirDeviceCapabilities.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'manufacturer') then
        result.manufacturer := ParseString(child) {b}
      else if (child.baseName = 'identity') then
        result.identity := ParseResourceReference{TFhirDevice}(child) {b}
      else if (child.baseName = 'virtualDevice') then
        result.virtualDeviceList.Add(ParseDeviceCapabilitiesVirtualDevice(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDeviceCapabilities(xml : TXmlBuilder; name : string; elem : TFhirDeviceCapabilities);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeString(xml, 'manufacturer', elem.manufacturer);
  ComposeResourceReference{TFhirDevice}(xml, 'identity', elem.identity);
  for i := 0 to elem.virtualDeviceList.Count - 1 do
    ComposeDeviceCapabilitiesVirtualDevice(xml, 'virtualDevice', elem.virtualDeviceList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDeviceCapabilities : TFhirDeviceCapabilities;
begin
  json.next;
  result := TFhirDeviceCapabilities.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'manufacturer') then
        result.manufacturer := ParseString
      else if (json.ItemName = 'identity') then
        result.identity := ParseResourceReference{TFhirDevice}
      else if (json.ItemName = 'virtualDevice') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.virtualDeviceList.Add(ParseDeviceCapabilitiesVirtualDevice);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDeviceCapabilities(json : TJSONWriter; name : string; elem : TFhirDeviceCapabilities);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeString(json, 'manufacturer', elem.manufacturer);
  ComposeResourceReference{TFhirDevice}(json, 'identity', elem.identity);
  if elem.virtualDeviceList.Count > 0 then
  begin
    json.valueArray('virtualDevice');
    for i := 0 to elem.virtualDeviceList.Count - 1 do
      ComposeDeviceCapabilitiesVirtualDevice(json, '',elem.virtualDeviceList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDeviceLogItem(element : IXmlDomElement) : TFhirDeviceLogItem;
var
  child : IXMLDOMElement;
begin
  result := TFhirDeviceLogItem.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'key') then
        result.key := ParseString(child) {b}
      else if (child.baseName = 'value') then
        result.value := ParseString(child) {b}
      else if (child.baseName = 'flag') then
        result.flag.Add(ParseEnum(CODES_TFhirDeviceValueFlag, child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDeviceLogItem(xml : TXmlBuilder; name : string; elem : TFhirDeviceLogItem);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'key', elem.key);
  ComposeString(xml, 'value', elem.value);
  for i := 0 to elem.flag.Count - 1 do
    ComposeEnum(xml, 'flag', elem.flag[i], CODES_TFhirDeviceValueFlag);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDeviceLogItem : TFhirDeviceLogItem;
begin
  json.next;
  result := TFhirDeviceLogItem.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'key') then
        result.key := ParseString
      else if (json.ItemName = 'value') then
        result.value := ParseString
      else if (json.ItemName = 'flag') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.flag.Add(ParseEnum(CODES_TFhirDeviceValueFlag));
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDeviceLogItem(json : TJSONWriter; name : string; elem : TFhirDeviceLogItem);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'key', elem.key);
  ComposeString(json, 'value', elem.value);
  if elem.flag.Count > 0 then
  begin
    json.valueArray('flag');
    for i := 0 to elem.flag.Count - 1 do
      ComposeEnum(json, 'flag', elem.flag[i], CODES_TFhirDeviceValueFlag);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDeviceLog(element : IXmlDomElement) : TFhirDeviceLog;
var
  child : IXMLDOMElement;
  item : IXMLDOMElement;
begin
  result := TFhirDeviceLog.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'instant') then
        result.instant := ParseInstant(child) {b}
      else if (child.baseName = 'capabilities') then
        result.capabilities := ParseResourceReference{TFhirDeviceCapabilities}(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'item') then
        result.itemList.Add(ParseDeviceLogItem(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDeviceLog(xml : TXmlBuilder; name : string; elem : TFhirDeviceLog);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeInstant(xml, 'instant', elem.instant);
  ComposeResourceReference{TFhirDeviceCapabilities}(xml, 'capabilities', elem.capabilities);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  for i := 0 to elem.itemList.Count - 1 do
    ComposeDeviceLogItem(xml, 'item', elem.itemList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDeviceLog : TFhirDeviceLog;
begin
  json.next;
  result := TFhirDeviceLog.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'instant') then
        result.instant := ParseInstant
      else if (json.ItemName = 'capabilities') then
        result.capabilities := ParseResourceReference{TFhirDeviceCapabilities}
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'item') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.itemList.Add(ParseDeviceLogItem);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDeviceLog(json : TJSONWriter; name : string; elem : TFhirDeviceLog);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeInstant(json, 'instant', elem.instant);
  ComposeResourceReference{TFhirDeviceCapabilities}(json, 'capabilities', elem.capabilities);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  if elem.itemList.Count > 0 then
  begin
    json.valueArray('item');
    for i := 0 to elem.itemList.Count - 1 do
      ComposeDeviceLogItem(json, '',elem.itemList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDeviceObservation(element : IXmlDomElement) : TFhirDeviceObservation;
var
  child : IXMLDOMElement;
begin
  result := TFhirDeviceObservation.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'issued') then
        result.issued := ParseInstant(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'device') then
        result.device := ParseResourceReference{TFhirDevice}(child) {b}
      else if (child.baseName = 'measurement') then
        result.measurementList.Add(ParseResourceReference{TFhirObservation}(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDeviceObservation(xml : TXmlBuilder; name : string; elem : TFhirDeviceObservation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeInstant(xml, 'issued', elem.issued);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  ComposeResourceReference{TFhirDevice}(xml, 'device', elem.device);
  for i := 0 to elem.measurementList.Count - 1 do
    ComposeResourceReference{TFhirObservation}(xml, 'measurement', elem.measurementList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDeviceObservation : TFhirDeviceObservation;
begin
  json.next;
  result := TFhirDeviceObservation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'issued') then
        result.issued := ParseInstant
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'device') then
        result.device := ParseResourceReference{TFhirDevice}
      else if (json.ItemName = 'measurement') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.measurementList.Add(ParseResourceReference{TFhirObservation});
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDeviceObservation(json : TJSONWriter; name : string; elem : TFhirDeviceObservation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeInstant(json, 'issued', elem.issued);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  ComposeResourceReference{TFhirDevice}(json, 'device', elem.device);
  if elem.measurementList.Count > 0 then
  begin
    json.valueArray('measurement');
    for i := 0 to elem.measurementList.Count - 1 do
      ComposeResourceReference{TFhirObservation}(json, '',elem.measurementList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDiagnosticOrderEvent(element : IXmlDomElement) : TFhirDiagnosticOrderEvent;
var
  child : IXMLDOMElement;
begin
  result := TFhirDiagnosticOrderEvent.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirDiagnosticOrderStatus, child)
      else if (child.baseName = 'date') then
        result.date := ParseDateTime(child) {b}
      else if (child.baseName = 'actor') then
        result.actor := ParseResourceReference{Resource}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDiagnosticOrderEvent(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticOrderEvent);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirDiagnosticOrderStatus);
  ComposeDateTime(xml, 'date', elem.date);
  ComposeResourceReference{Resource}(xml, 'actor', elem.actor);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDiagnosticOrderEvent : TFhirDiagnosticOrderEvent;
begin
  json.next;
  result := TFhirDiagnosticOrderEvent.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirDiagnosticOrderStatus)
      else if (json.ItemName = 'date') then
        result.date := ParseDateTime
      else if (json.ItemName = 'actor') then
        result.actor := ParseResourceReference{Resource}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDiagnosticOrderEvent(json : TJSONWriter; name : string; elem : TFhirDiagnosticOrderEvent);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirDiagnosticOrderStatus);
  ComposeDateTime(json, 'date', elem.date);
  ComposeResourceReference{Resource}(json, 'actor', elem.actor);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDiagnosticOrderItem(element : IXmlDomElement) : TFhirDiagnosticOrderItem;
var
  child : IXMLDOMElement;
begin
  result := TFhirDiagnosticOrderItem.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'specimen') then
        result.specimenList.Add(ParseResourceReference{TFhirSpecimen}(child))
      else if (child.baseName = 'bodySite') then
        result.bodySite := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirDiagnosticOrderStatus, child)
      else if (child.baseName = 'event') then
        result.eventList.Add(ParseDiagnosticOrderEvent(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDiagnosticOrderItem(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticOrderItem);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  for i := 0 to elem.specimenList.Count - 1 do
    ComposeResourceReference{TFhirSpecimen}(xml, 'specimen', elem.specimenList[i]);
  ComposeCodeableConcept(xml, 'bodySite', elem.bodySite);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirDiagnosticOrderStatus);
  for i := 0 to elem.eventList.Count - 1 do
    ComposeDiagnosticOrderEvent(xml, 'event', elem.eventList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDiagnosticOrderItem : TFhirDiagnosticOrderItem;
begin
  json.next;
  result := TFhirDiagnosticOrderItem.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'specimen') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.specimenList.Add(ParseResourceReference{TFhirSpecimen});
          json.Next;
        end;
      end
      else if (json.ItemName = 'bodySite') then
        result.bodySite := ParseCodeableConcept
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirDiagnosticOrderStatus)
      else if (json.ItemName = 'event') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.eventList.Add(ParseDiagnosticOrderEvent);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDiagnosticOrderItem(json : TJSONWriter; name : string; elem : TFhirDiagnosticOrderItem);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  if elem.specimenList.Count > 0 then
  begin
    json.valueArray('specimen');
    for i := 0 to elem.specimenList.Count - 1 do
      ComposeResourceReference{TFhirSpecimen}(json, '',elem.specimenList[i]);
    json.FinishArray;
  end;
  ComposeCodeableConcept(json, 'bodySite', elem.bodySite);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirDiagnosticOrderStatus);
  if elem.eventList.Count > 0 then
  begin
    json.valueArray('event');
    for i := 0 to elem.eventList.Count - 1 do
      ComposeDiagnosticOrderEvent(json, '',elem.eventList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDiagnosticOrder(element : IXmlDomElement) : TFhirDiagnosticOrder;
var
  child : IXMLDOMElement;
  item : IXMLDOMElement;
begin
  result := TFhirDiagnosticOrder.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'orderer') then
        result.orderer := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}(child) {b}
      else if (child.baseName = 'clinicalNotes') then
        result.clinicalNotes := ParseString(child) {b}
      else if (child.baseName = 'specimen') then
        result.specimenList.Add(ParseResourceReference{TFhirSpecimen}(child))
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirDiagnosticOrderStatus, child)
      else if (child.baseName = 'priority') then
        result.priority := ParseEnum(CODES_TFhirDiagnosticOrderPriority, child)
      else if (child.baseName = 'event') then
        result.eventList.Add(ParseDiagnosticOrderEvent(child))
      else if (child.baseName = 'item') then
        result.itemList.Add(ParseDiagnosticOrderItem(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDiagnosticOrder(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticOrder);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  ComposeResourceReference{TFhirPractitioner}(xml, 'orderer', elem.orderer);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeResourceReference{TFhirEncounter}(xml, 'encounter', elem.encounter);
  ComposeString(xml, 'clinicalNotes', elem.clinicalNotes);
  for i := 0 to elem.specimenList.Count - 1 do
    ComposeResourceReference{TFhirSpecimen}(xml, 'specimen', elem.specimenList[i]);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirDiagnosticOrderStatus);
  ComposeEnum(xml, 'priority', elem.Priority, CODES_TFhirDiagnosticOrderPriority);
  for i := 0 to elem.eventList.Count - 1 do
    ComposeDiagnosticOrderEvent(xml, 'event', elem.eventList[i]);
  for i := 0 to elem.itemList.Count - 1 do
    ComposeDiagnosticOrderItem(xml, 'item', elem.itemList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDiagnosticOrder : TFhirDiagnosticOrder;
begin
  json.next;
  result := TFhirDiagnosticOrder.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'orderer') then
        result.orderer := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}
      else if (json.ItemName = 'clinicalNotes') then
        result.clinicalNotes := ParseString
      else if (json.ItemName = 'specimen') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.specimenList.Add(ParseResourceReference{TFhirSpecimen});
          json.Next;
        end;
      end
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirDiagnosticOrderStatus)
      else if (json.ItemName = 'priority') then
        result.priority := ParseEnum(CODES_TFhirDiagnosticOrderPriority)
      else if (json.ItemName = 'event') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.eventList.Add(ParseDiagnosticOrderEvent);
          json.Next;
        end;
      end
      else if (json.ItemName = 'item') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.itemList.Add(ParseDiagnosticOrderItem);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDiagnosticOrder(json : TJSONWriter; name : string; elem : TFhirDiagnosticOrder);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  ComposeResourceReference{TFhirPractitioner}(json, 'orderer', elem.orderer);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirEncounter}(json, 'encounter', elem.encounter);
  ComposeString(json, 'clinicalNotes', elem.clinicalNotes);
  if elem.specimenList.Count > 0 then
  begin
    json.valueArray('specimen');
    for i := 0 to elem.specimenList.Count - 1 do
      ComposeResourceReference{TFhirSpecimen}(json, '',elem.specimenList[i]);
    json.FinishArray;
  end;
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirDiagnosticOrderStatus);
  ComposeEnum(json, 'priority', elem.Priority, CODES_TFhirDiagnosticOrderPriority);
  if elem.eventList.Count > 0 then
  begin
    json.valueArray('event');
    for i := 0 to elem.eventList.Count - 1 do
      ComposeDiagnosticOrderEvent(json, '',elem.eventList[i]);
    json.FinishArray;
  end;
  if elem.itemList.Count > 0 then
  begin
    json.valueArray('item');
    for i := 0 to elem.itemList.Count - 1 do
      ComposeDiagnosticOrderItem(json, '',elem.itemList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDiagnosticReportRequestDetail(element : IXmlDomElement) : TFhirDiagnosticReportRequestDetail;
var
  child : IXMLDOMElement;
begin
  result := TFhirDiagnosticReportRequestDetail.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}(child) {b}
      else if (child.baseName = 'requestOrderId') then
        result.requestOrderId := ParseIdentifier(child) {b}
      else if (child.baseName = 'receiverOrderId') then
        result.receiverOrderId := ParseIdentifier(child) {b}
      else if (child.baseName = 'requestTest') then
        result.requestTestList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'bodySite') then
        result.bodySite := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'requester') then
        result.requester := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'clinicalInfo') then
        result.clinicalInfo := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDiagnosticReportRequestDetail(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticReportRequestDetail);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeResourceReference{TFhirEncounter}(xml, 'encounter', elem.encounter);
  ComposeIdentifier(xml, 'requestOrderId', elem.requestOrderId);
  ComposeIdentifier(xml, 'receiverOrderId', elem.receiverOrderId);
  for i := 0 to elem.requestTestList.Count - 1 do
    ComposeCodeableConcept(xml, 'requestTest', elem.requestTestList[i]);
  ComposeCodeableConcept(xml, 'bodySite', elem.bodySite);
  ComposeResourceReference{Resource}(xml, 'requester', elem.requester);
  ComposeString(xml, 'clinicalInfo', elem.clinicalInfo);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDiagnosticReportRequestDetail : TFhirDiagnosticReportRequestDetail;
begin
  json.next;
  result := TFhirDiagnosticReportRequestDetail.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}
      else if (json.ItemName = 'requestOrderId') then
        result.requestOrderId := ParseIdentifier
      else if (json.ItemName = 'receiverOrderId') then
        result.receiverOrderId := ParseIdentifier
      else if (json.ItemName = 'requestTest') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.requestTestList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'bodySite') then
        result.bodySite := ParseCodeableConcept
      else if (json.ItemName = 'requester') then
        result.requester := ParseResourceReference{Resource}
      else if (json.ItemName = 'clinicalInfo') then
        result.clinicalInfo := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDiagnosticReportRequestDetail(json : TJSONWriter; name : string; elem : TFhirDiagnosticReportRequestDetail);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeResourceReference{TFhirEncounter}(json, 'encounter', elem.encounter);
  ComposeIdentifier(json, 'requestOrderId', elem.requestOrderId);
  ComposeIdentifier(json, 'receiverOrderId', elem.receiverOrderId);
  if elem.requestTestList.Count > 0 then
  begin
    json.valueArray('requestTest');
    for i := 0 to elem.requestTestList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.requestTestList[i]);
    json.FinishArray;
  end;
  ComposeCodeableConcept(json, 'bodySite', elem.bodySite);
  ComposeResourceReference{Resource}(json, 'requester', elem.requester);
  ComposeString(json, 'clinicalInfo', elem.clinicalInfo);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDiagnosticReportResults(element : IXmlDomElement) : TFhirDiagnosticReportResults;
var
  child : IXMLDOMElement;
begin
  result := TFhirDiagnosticReportResults.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'specimen') then
        result.specimen := ParseResourceReference{TFhirSpecimen}(child) {b}
      else if (child.baseName = 'group') then
        result.groupList.Add(ParseDiagnosticReportResults(child))
      else if (child.baseName = 'result') then
        result.resultList.Add(ParseResourceReference{TFhirObservation}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDiagnosticReportResults(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticReportResults);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'name', elem.name);
  ComposeResourceReference{TFhirSpecimen}(xml, 'specimen', elem.specimen);
  for i := 0 to elem.groupList.Count - 1 do
    ComposeDiagnosticReportResults(xml, 'group', elem.groupList[i]);
  for i := 0 to elem.resultList.Count - 1 do
    ComposeResourceReference{TFhirObservation}(xml, 'result', elem.resultList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDiagnosticReportResults : TFhirDiagnosticReportResults;
begin
  json.next;
  result := TFhirDiagnosticReportResults.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseCodeableConcept
      else if (json.ItemName = 'specimen') then
        result.specimen := ParseResourceReference{TFhirSpecimen}
      else if (json.ItemName = 'group') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.groupList.Add(ParseDiagnosticReportResults);
          json.Next;
        end;
      end
      else if (json.ItemName = 'result') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.resultList.Add(ParseResourceReference{TFhirObservation});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDiagnosticReportResults(json : TJSONWriter; name : string; elem : TFhirDiagnosticReportResults);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'name', elem.name);
  ComposeResourceReference{TFhirSpecimen}(json, 'specimen', elem.specimen);
  if elem.groupList.Count > 0 then
  begin
    json.valueArray('group');
    for i := 0 to elem.groupList.Count - 1 do
      ComposeDiagnosticReportResults(json, '',elem.groupList[i]);
    json.FinishArray;
  end;
  if elem.resultList.Count > 0 then
  begin
    json.valueArray('result');
    for i := 0 to elem.resultList.Count - 1 do
      ComposeResourceReference{TFhirObservation}(json, '',elem.resultList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDiagnosticReport(element : IXmlDomElement) : TFhirDiagnosticReport;
var
  child : IXMLDOMElement;
begin
  result := TFhirDiagnosticReport.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirObservationStatus, child)
      else if (child.baseName = 'issued') then
        result.issued := ParseDateTime(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'performer') then
        result.performer := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'reportId') then
        result.reportId := ParseIdentifier(child) {b}
      else if (child.baseName = 'requestDetail') then
        result.requestDetailList.Add(ParseDiagnosticReportRequestDetail(child))
      else if (child.baseName = 'serviceCategory') then
        result.serviceCategory := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'diagnosticTime') then
        result.diagnosticTime := ParseDateTime(child) {b}
      else if (child.baseName = 'results') then
        result.results := ParseDiagnosticReportResults(child) {b}
      else if (child.baseName = 'image') then
        result.imageList.Add(ParseResourceReference{Resource}(child))
      else if (child.baseName = 'conclusion') then
        result.conclusion := ParseString(child) {b}
      else if (child.baseName = 'codedDiagnosis') then
        result.codedDiagnosisList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'representation') then
        result.representationList.Add(ParseAttachment(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDiagnosticReport(xml : TXmlBuilder; name : string; elem : TFhirDiagnosticReport);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirObservationStatus);
  ComposeDateTime(xml, 'issued', elem.issued);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  ComposeResourceReference{TFhirOrganization}(xml, 'performer', elem.performer);
  ComposeIdentifier(xml, 'reportId', elem.reportId);
  for i := 0 to elem.requestDetailList.Count - 1 do
    ComposeDiagnosticReportRequestDetail(xml, 'requestDetail', elem.requestDetailList[i]);
  ComposeCodeableConcept(xml, 'serviceCategory', elem.serviceCategory);
  ComposeDateTime(xml, 'diagnosticTime', elem.diagnosticTime);
  ComposeDiagnosticReportResults(xml, 'results', elem.results);
  for i := 0 to elem.imageList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'image', elem.imageList[i]);
  ComposeString(xml, 'conclusion', elem.conclusion);
  for i := 0 to elem.codedDiagnosisList.Count - 1 do
    ComposeCodeableConcept(xml, 'codedDiagnosis', elem.codedDiagnosisList[i]);
  for i := 0 to elem.representationList.Count - 1 do
    ComposeAttachment(xml, 'representation', elem.representationList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDiagnosticReport : TFhirDiagnosticReport;
begin
  json.next;
  result := TFhirDiagnosticReport.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirObservationStatus)
      else if (json.ItemName = 'issued') then
        result.issued := ParseDateTime
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'performer') then
        result.performer := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'reportId') then
        result.reportId := ParseIdentifier
      else if (json.ItemName = 'requestDetail') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.requestDetailList.Add(ParseDiagnosticReportRequestDetail);
          json.Next;
        end;
      end
      else if (json.ItemName = 'serviceCategory') then
        result.serviceCategory := ParseCodeableConcept
      else if (json.ItemName = 'diagnosticTime') then
        result.diagnosticTime := ParseDateTime
      else if (json.ItemName = 'results') then
        result.results := ParseDiagnosticReportResults
      else if (json.ItemName = 'image') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.imageList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if (json.ItemName = 'conclusion') then
        result.conclusion := ParseString
      else if (json.ItemName = 'codedDiagnosis') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.codedDiagnosisList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'representation') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.representationList.Add(ParseAttachment);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDiagnosticReport(json : TJSONWriter; name : string; elem : TFhirDiagnosticReport);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirObservationStatus);
  ComposeDateTime(json, 'issued', elem.issued);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  ComposeResourceReference{TFhirOrganization}(json, 'performer', elem.performer);
  ComposeIdentifier(json, 'reportId', elem.reportId);
  if elem.requestDetailList.Count > 0 then
  begin
    json.valueArray('requestDetail');
    for i := 0 to elem.requestDetailList.Count - 1 do
      ComposeDiagnosticReportRequestDetail(json, '',elem.requestDetailList[i]);
    json.FinishArray;
  end;
  ComposeCodeableConcept(json, 'serviceCategory', elem.serviceCategory);
  ComposeDateTime(json, 'diagnosticTime', elem.diagnosticTime);
  ComposeDiagnosticReportResults(json, 'results', elem.results);
  if elem.imageList.Count > 0 then
  begin
    json.valueArray('image');
    for i := 0 to elem.imageList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.imageList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'conclusion', elem.conclusion);
  if elem.codedDiagnosisList.Count > 0 then
  begin
    json.valueArray('codedDiagnosis');
    for i := 0 to elem.codedDiagnosisList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.codedDiagnosisList[i]);
    json.FinishArray;
  end;
  if elem.representationList.Count > 0 then
  begin
    json.valueArray('representation');
    for i := 0 to elem.representationList.Count - 1 do
      ComposeAttachment(json, '',elem.representationList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDocumentAttester(element : IXmlDomElement) : TFhirDocumentAttester;
var
  child : IXMLDOMElement;
begin
  result := TFhirDocumentAttester.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'mode') then
        result.mode := ParseEnum(CODES_TFhirDocumentAttestationMode, child)
      else if (child.baseName = 'time') then
        result.time := ParseDateTime(child) {b}
      else if (child.baseName = 'party') then
        result.party := ParseResourceReference{Resource}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDocumentAttester(xml : TXmlBuilder; name : string; elem : TFhirDocumentAttester);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'mode', elem.Mode, CODES_TFhirDocumentAttestationMode);
  ComposeDateTime(xml, 'time', elem.time);
  ComposeResourceReference{Resource}(xml, 'party', elem.party);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDocumentAttester : TFhirDocumentAttester;
begin
  json.next;
  result := TFhirDocumentAttester.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'mode') then
        result.mode := ParseEnum(CODES_TFhirDocumentAttestationMode)
      else if (json.ItemName = 'time') then
        result.time := ParseDateTime
      else if (json.ItemName = 'party') then
        result.party := ParseResourceReference{Resource}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDocumentAttester(json : TJSONWriter; name : string; elem : TFhirDocumentAttester);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'mode', elem.Mode, CODES_TFhirDocumentAttestationMode);
  ComposeDateTime(json, 'time', elem.time);
  ComposeResourceReference{Resource}(json, 'party', elem.party);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDocumentEvent(element : IXmlDomElement) : TFhirDocumentEvent;
var
  child : IXMLDOMElement;
begin
  result := TFhirDocumentEvent.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.codeList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if (child.baseName = 'detail') then
        result.detailList.Add(ParseResourceReference{Resource}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDocumentEvent(xml : TXmlBuilder; name : string; elem : TFhirDocumentEvent);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.codeList.Count - 1 do
    ComposeCodeableConcept(xml, 'code', elem.codeList[i]);
  ComposePeriod(xml, 'period', elem.period);
  for i := 0 to elem.detailList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'detail', elem.detailList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDocumentEvent : TFhirDocumentEvent;
begin
  json.next;
  result := TFhirDocumentEvent.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.codeList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if (json.ItemName = 'detail') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.detailList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDocumentEvent(json : TJSONWriter; name : string; elem : TFhirDocumentEvent);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.codeList.Count > 0 then
  begin
    json.valueArray('code');
    for i := 0 to elem.codeList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.codeList[i]);
    json.FinishArray;
  end;
  ComposePeriod(json, 'period', elem.period);
  if elem.detailList.Count > 0 then
  begin
    json.valueArray('detail');
    for i := 0 to elem.detailList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.detailList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDocumentSection(element : IXmlDomElement) : TFhirDocumentSection;
var
  child : IXMLDOMElement;
begin
  result := TFhirDocumentSection.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'content') then
        result.content := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'section') then
        result.sectionList.Add(ParseDocumentSection(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDocumentSection(xml : TXmlBuilder; name : string; elem : TFhirDocumentSection);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  ComposeResourceReference{Resource}(xml, 'content', elem.content);
  for i := 0 to elem.sectionList.Count - 1 do
    ComposeDocumentSection(xml, 'section', elem.sectionList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDocumentSection : TFhirDocumentSection;
begin
  json.next;
  result := TFhirDocumentSection.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'content') then
        result.content := ParseResourceReference{Resource}
      else if (json.ItemName = 'section') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.sectionList.Add(ParseDocumentSection);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDocumentSection(json : TJSONWriter; name : string; elem : TFhirDocumentSection);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  ComposeResourceReference{Resource}(json, 'content', elem.content);
  if elem.sectionList.Count > 0 then
  begin
    json.valueArray('section');
    for i := 0 to elem.sectionList.Count - 1 do
      ComposeDocumentSection(json, '',elem.sectionList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDocument(element : IXmlDomElement) : TFhirDocument;
var
  child : IXMLDOMElement;
begin
  result := TFhirDocument.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'versionIdentifier') then
        result.versionIdentifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'created') then
        result.created := ParseInstant(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'subtype') then
        result.subtype := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'title') then
        result.title := ParseString(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirDocumentStatus, child)
      else if (child.baseName = 'confidentiality') then
        result.confidentiality := ParseCoding(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'author') then
        result.authorList.Add(ParseResourceReference{Resource}(child))
      else if (child.baseName = 'attester') then
        result.attesterList.Add(ParseDocumentAttester(child))
      else if (child.baseName = 'custodian') then
        result.custodian := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'event') then
        result.event := ParseDocumentEvent(child) {b}
      else if (child.baseName = 'encounter') then
        result.encounter := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'replaces') then
        result.replaces := ParseId(child) {b}
      else if (child.baseName = 'provenance') then
        result.provenanceList.Add(ParseResourceReference{TFhirProvenance}(child))
      else if (child.baseName = 'stylesheet') then
        result.stylesheet := ParseAttachment(child) {b}
      else if (child.baseName = 'representation') then
        result.representation := ParseAttachment(child) {b}
      else if (child.baseName = 'section') then
        result.sectionList.Add(ParseDocumentSection(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDocument(xml : TXmlBuilder; name : string; elem : TFhirDocument);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeIdentifier(xml, 'versionIdentifier', elem.versionIdentifier);
  ComposeInstant(xml, 'created', elem.created);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeCodeableConcept(xml, 'subtype', elem.subtype);
  ComposeString(xml, 'title', elem.title);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirDocumentStatus);
  ComposeCoding(xml, 'confidentiality', elem.confidentiality);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  for i := 0 to elem.authorList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'author', elem.authorList[i]);
  for i := 0 to elem.attesterList.Count - 1 do
    ComposeDocumentAttester(xml, 'attester', elem.attesterList[i]);
  ComposeResourceReference{TFhirOrganization}(xml, 'custodian', elem.custodian);
  ComposeDocumentEvent(xml, 'event', elem.event);
  ComposeResourceReference{Resource}(xml, 'encounter', elem.encounter);
  ComposeId(xml, 'replaces', elem.replaces);
  for i := 0 to elem.provenanceList.Count - 1 do
    ComposeResourceReference{TFhirProvenance}(xml, 'provenance', elem.provenanceList[i]);
  ComposeAttachment(xml, 'stylesheet', elem.stylesheet);
  ComposeAttachment(xml, 'representation', elem.representation);
  for i := 0 to elem.sectionList.Count - 1 do
    ComposeDocumentSection(xml, 'section', elem.sectionList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDocument : TFhirDocument;
begin
  json.next;
  result := TFhirDocument.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'versionIdentifier') then
        result.versionIdentifier := ParseIdentifier
      else if (json.ItemName = 'created') then
        result.created := ParseInstant
      else if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'subtype') then
        result.subtype := ParseCodeableConcept
      else if (json.ItemName = 'title') then
        result.title := ParseString
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirDocumentStatus)
      else if (json.ItemName = 'confidentiality') then
        result.confidentiality := ParseCoding
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'author') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.authorList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if (json.ItemName = 'attester') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.attesterList.Add(ParseDocumentAttester);
          json.Next;
        end;
      end
      else if (json.ItemName = 'custodian') then
        result.custodian := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'event') then
        result.event := ParseDocumentEvent
      else if (json.ItemName = 'encounter') then
        result.encounter := ParseResourceReference{Resource}
      else if (json.ItemName = 'replaces') then
        result.replaces := ParseId
      else if (json.ItemName = 'provenance') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.provenanceList.Add(ParseResourceReference{TFhirProvenance});
          json.Next;
        end;
      end
      else if (json.ItemName = 'stylesheet') then
        result.stylesheet := ParseAttachment
      else if (json.ItemName = 'representation') then
        result.representation := ParseAttachment
      else if (json.ItemName = 'section') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.sectionList.Add(ParseDocumentSection);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDocument(json : TJSONWriter; name : string; elem : TFhirDocument);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeIdentifier(json, 'versionIdentifier', elem.versionIdentifier);
  ComposeInstant(json, 'created', elem.created);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeCodeableConcept(json, 'subtype', elem.subtype);
  ComposeString(json, 'title', elem.title);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirDocumentStatus);
  ComposeCoding(json, 'confidentiality', elem.confidentiality);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  if elem.authorList.Count > 0 then
  begin
    json.valueArray('author');
    for i := 0 to elem.authorList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.authorList[i]);
    json.FinishArray;
  end;
  if elem.attesterList.Count > 0 then
  begin
    json.valueArray('attester');
    for i := 0 to elem.attesterList.Count - 1 do
      ComposeDocumentAttester(json, '',elem.attesterList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirOrganization}(json, 'custodian', elem.custodian);
  ComposeDocumentEvent(json, 'event', elem.event);
  ComposeResourceReference{Resource}(json, 'encounter', elem.encounter);
  ComposeId(json, 'replaces', elem.replaces);
  if elem.provenanceList.Count > 0 then
  begin
    json.valueArray('provenance');
    for i := 0 to elem.provenanceList.Count - 1 do
      ComposeResourceReference{TFhirProvenance}(json, '',elem.provenanceList[i]);
    json.FinishArray;
  end;
  ComposeAttachment(json, 'stylesheet', elem.stylesheet);
  ComposeAttachment(json, 'representation', elem.representation);
  if elem.sectionList.Count > 0 then
  begin
    json.valueArray('section');
    for i := 0 to elem.sectionList.Count - 1 do
      ComposeDocumentSection(json, '',elem.sectionList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDocumentReferenceService(element : IXmlDomElement) : TFhirDocumentReferenceService;
var
  child : IXMLDOMElement;
begin
  result := TFhirDocumentReferenceService.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'address') then
        result.address := ParseString(child) {b}
      else if (child.baseName = 'parameter') then
        result.parameterList.Add(ParseDocumentReferenceServiceParameter(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDocumentReferenceService(xml : TXmlBuilder; name : string; elem : TFhirDocumentReferenceService);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeString(xml, 'address', elem.address);
  for i := 0 to elem.parameterList.Count - 1 do
    ComposeDocumentReferenceServiceParameter(xml, 'parameter', elem.parameterList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDocumentReferenceService : TFhirDocumentReferenceService;
begin
  json.next;
  result := TFhirDocumentReferenceService.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'address') then
        result.address := ParseString
      else if (json.ItemName = 'parameter') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.parameterList.Add(ParseDocumentReferenceServiceParameter);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDocumentReferenceService(json : TJSONWriter; name : string; elem : TFhirDocumentReferenceService);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeString(json, 'address', elem.address);
  if elem.parameterList.Count > 0 then
  begin
    json.valueArray('parameter');
    for i := 0 to elem.parameterList.Count - 1 do
      ComposeDocumentReferenceServiceParameter(json, '',elem.parameterList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseDocumentReferenceServiceParameter(element : IXmlDomElement) : TFhirDocumentReferenceServiceParameter;
var
  child : IXMLDOMElement;
begin
  result := TFhirDocumentReferenceServiceParameter.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'value') then
        result.value := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDocumentReferenceServiceParameter(xml : TXmlBuilder; name : string; elem : TFhirDocumentReferenceServiceParameter);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeString(xml, 'value', elem.value);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDocumentReferenceServiceParameter : TFhirDocumentReferenceServiceParameter;
begin
  json.next;
  result := TFhirDocumentReferenceServiceParameter.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'value') then
        result.value := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDocumentReferenceServiceParameter(json : TJSONWriter; name : string; elem : TFhirDocumentReferenceServiceParameter);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeString(json, 'value', elem.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDocumentReferenceContext(element : IXmlDomElement) : TFhirDocumentReferenceContext;
var
  child : IXMLDOMElement;
begin
  result := TFhirDocumentReferenceContext.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.codeList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if (child.baseName = 'facilityType') then
        result.facilityType := ParseCodeableConcept(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDocumentReferenceContext(xml : TXmlBuilder; name : string; elem : TFhirDocumentReferenceContext);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.codeList.Count - 1 do
    ComposeCodeableConcept(xml, 'code', elem.codeList[i]);
  ComposePeriod(xml, 'period', elem.period);
  ComposeCodeableConcept(xml, 'facilityType', elem.facilityType);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDocumentReferenceContext : TFhirDocumentReferenceContext;
begin
  json.next;
  result := TFhirDocumentReferenceContext.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.codeList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if (json.ItemName = 'facilityType') then
        result.facilityType := ParseCodeableConcept
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDocumentReferenceContext(json : TJSONWriter; name : string; elem : TFhirDocumentReferenceContext);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.codeList.Count > 0 then
  begin
    json.valueArray('code');
    for i := 0 to elem.codeList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.codeList[i]);
    json.FinishArray;
  end;
  ComposePeriod(json, 'period', elem.period);
  ComposeCodeableConcept(json, 'facilityType', elem.facilityType);
  json.finishObject;
end;

function TFHIRXmlParser.ParseDocumentReference(element : IXmlDomElement) : TFhirDocumentReference;
var
  child : IXMLDOMElement;
begin
  result := TFhirDocumentReference.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'masterIdentifier') then
        result.masterIdentifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'subtype') then
        result.subtype := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'author') then
        result.authorList.Add(ParseResourceReference{Resource}(child))
      else if (child.baseName = 'custodian') then
        result.custodian := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'authenticator') then
        result.authenticator := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'created') then
        result.created := ParseDateTime(child) {b}
      else if (child.baseName = 'indexed') then
        result.indexed := ParseInstant(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirDocumentReferenceStatus, child)
      else if (child.baseName = 'docStatus') then
        result.docStatus := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'supercedes') then
        result.supercedes := ParseResourceReference{TFhirDocumentReference}(child) {b}
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'confidentiality') then
        result.confidentiality := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'primaryLanguage') then
        result.primaryLanguage := ParseCode(child) {b}
      else if (child.baseName = 'mimeType') then
        result.mimeType := ParseCode(child) {b}
      else if (child.baseName = 'format') then
        result.format := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'size') then
        result.size := ParseInteger(child) {b}
      else if (child.baseName = 'hash') then
        result.hash := ParseString(child) {b}
      else if (child.baseName = 'location') then
        result.location := ParseUri(child) {b}
      else if (child.baseName = 'service') then
        result.service := ParseDocumentReferenceService(child) {b}
      else if (child.baseName = 'context') then
        result.context := ParseDocumentReferenceContext(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeDocumentReference(xml : TXmlBuilder; name : string; elem : TFhirDocumentReference);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeIdentifier(xml, 'masterIdentifier', elem.masterIdentifier);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeCodeableConcept(xml, 'subtype', elem.subtype);
  for i := 0 to elem.authorList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'author', elem.authorList[i]);
  ComposeResourceReference{TFhirOrganization}(xml, 'custodian', elem.custodian);
  ComposeResourceReference{Resource}(xml, 'authenticator', elem.authenticator);
  ComposeDateTime(xml, 'created', elem.created);
  ComposeInstant(xml, 'indexed', elem.indexed);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirDocumentReferenceStatus);
  ComposeCodeableConcept(xml, 'docStatus', elem.docStatus);
  ComposeResourceReference{TFhirDocumentReference}(xml, 'supercedes', elem.supercedes);
  ComposeString(xml, 'description', elem.description);
  ComposeCodeableConcept(xml, 'confidentiality', elem.confidentiality);
  ComposeCode(xml, 'primaryLanguage', elem.primaryLanguage);
  ComposeCode(xml, 'mimeType', elem.mimeType);
  ComposeCodeableConcept(xml, 'format', elem.format);
  ComposeInteger(xml, 'size', elem.size);
  ComposeString(xml, 'hash', elem.hash);
  ComposeUri(xml, 'location', elem.location);
  ComposeDocumentReferenceService(xml, 'service', elem.service);
  ComposeDocumentReferenceContext(xml, 'context', elem.context);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseDocumentReference : TFhirDocumentReference;
begin
  json.next;
  result := TFhirDocumentReference.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'masterIdentifier') then
        result.masterIdentifier := ParseIdentifier
      else if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'subtype') then
        result.subtype := ParseCodeableConcept
      else if (json.ItemName = 'author') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.authorList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if (json.ItemName = 'custodian') then
        result.custodian := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'authenticator') then
        result.authenticator := ParseResourceReference{Resource}
      else if (json.ItemName = 'created') then
        result.created := ParseDateTime
      else if (json.ItemName = 'indexed') then
        result.indexed := ParseInstant
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirDocumentReferenceStatus)
      else if (json.ItemName = 'docStatus') then
        result.docStatus := ParseCodeableConcept
      else if (json.ItemName = 'supercedes') then
        result.supercedes := ParseResourceReference{TFhirDocumentReference}
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'confidentiality') then
        result.confidentiality := ParseCodeableConcept
      else if (json.ItemName = 'primaryLanguage') then
        result.primaryLanguage := ParseCode
      else if (json.ItemName = 'mimeType') then
        result.mimeType := ParseCode
      else if (json.ItemName = 'format') then
        result.format := ParseCodeableConcept
      else if (json.ItemName = 'size') then
        result.size := ParseInteger
      else if (json.ItemName = 'hash') then
        result.hash := ParseString
      else if (json.ItemName = 'location') then
        result.location := ParseUri
      else if (json.ItemName = 'service') then
        result.service := ParseDocumentReferenceService
      else if (json.ItemName = 'context') then
        result.context := ParseDocumentReferenceContext
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeDocumentReference(json : TJSONWriter; name : string; elem : TFhirDocumentReference);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeIdentifier(json, 'masterIdentifier', elem.masterIdentifier);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeCodeableConcept(json, 'subtype', elem.subtype);
  if elem.authorList.Count > 0 then
  begin
    json.valueArray('author');
    for i := 0 to elem.authorList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.authorList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirOrganization}(json, 'custodian', elem.custodian);
  ComposeResourceReference{Resource}(json, 'authenticator', elem.authenticator);
  ComposeDateTime(json, 'created', elem.created);
  ComposeInstant(json, 'indexed', elem.indexed);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirDocumentReferenceStatus);
  ComposeCodeableConcept(json, 'docStatus', elem.docStatus);
  ComposeResourceReference{TFhirDocumentReference}(json, 'supercedes', elem.supercedes);
  ComposeString(json, 'description', elem.description);
  ComposeCodeableConcept(json, 'confidentiality', elem.confidentiality);
  ComposeCode(json, 'primaryLanguage', elem.primaryLanguage);
  ComposeCode(json, 'mimeType', elem.mimeType);
  ComposeCodeableConcept(json, 'format', elem.format);
  ComposeInteger(json, 'size', elem.size);
  ComposeString(json, 'hash', elem.hash);
  ComposeUri(json, 'location', elem.location);
  ComposeDocumentReferenceService(json, 'service', elem.service);
  ComposeDocumentReferenceContext(json, 'context', elem.context);
  json.finishObject;
end;

function TFHIRXmlParser.ParseEncounterParticipant(element : IXmlDomElement) : TFhirEncounterParticipant;
var
  child : IXMLDOMElement;
begin
  result := TFhirEncounterParticipant.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_.Add(ParseEnum(CODES_TFhirParticipantType, child))
      else if (child.baseName = 'practitioner') then
        result.practitioner := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeEncounterParticipant(xml : TXmlBuilder; name : string; elem : TFhirEncounterParticipant);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.type_.Count - 1 do
    ComposeEnum(xml, 'type', elem.type_[i], CODES_TFhirParticipantType);
  ComposeResourceReference{TFhirPractitioner}(xml, 'practitioner', elem.practitioner);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseEncounterParticipant : TFhirEncounterParticipant;
begin
  json.next;
  result := TFhirEncounterParticipant.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.type_.Add(ParseEnum(CODES_TFhirParticipantType));
          json.Next;
        end;
      end
      else if (json.ItemName = 'practitioner') then
        result.practitioner := ParseResourceReference{TFhirPractitioner}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeEncounterParticipant(json : TJSONWriter; name : string; elem : TFhirEncounterParticipant);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.type_.Count > 0 then
  begin
    json.valueArray('type');
    for i := 0 to elem.type_.Count - 1 do
      ComposeEnum(json, 'type', elem.type_[i], CODES_TFhirParticipantType);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirPractitioner}(json, 'practitioner', elem.practitioner);
  json.finishObject;
end;

function TFHIRXmlParser.ParseEncounterHospitalization(element : IXmlDomElement) : TFhirEncounterHospitalization;
var
  child : IXMLDOMElement;
begin
  result := TFhirEncounterHospitalization.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'preAdmissionIdentifier') then
        result.preAdmissionIdentifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'origin') then
        result.origin := ParseResourceReference{TFhirLocation}(child) {b}
      else if (child.baseName = 'admitSource') then
        result.admitSource := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if (child.baseName = 'accomodation') then
        result.accomodationList.Add(ParseEncounterHospitalizationAccomodation(child))
      else if (child.baseName = 'diet') then
        result.diet := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'specialCourtesy') then
        result.specialCourtesyList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'specialArrangement') then
        result.specialArrangementList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'destination') then
        result.destination := ParseResourceReference{TFhirLocation}(child) {b}
      else if (child.baseName = 'dischargeDisposition') then
        result.dischargeDisposition := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'reAdmission') then
        result.reAdmission := ParseBoolean(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeEncounterHospitalization(xml : TXmlBuilder; name : string; elem : TFhirEncounterHospitalization);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeIdentifier(xml, 'preAdmissionIdentifier', elem.preAdmissionIdentifier);
  ComposeResourceReference{TFhirLocation}(xml, 'origin', elem.origin);
  ComposeCodeableConcept(xml, 'admitSource', elem.admitSource);
  ComposePeriod(xml, 'period', elem.period);
  for i := 0 to elem.accomodationList.Count - 1 do
    ComposeEncounterHospitalizationAccomodation(xml, 'accomodation', elem.accomodationList[i]);
  ComposeCodeableConcept(xml, 'diet', elem.diet);
  for i := 0 to elem.specialCourtesyList.Count - 1 do
    ComposeCodeableConcept(xml, 'specialCourtesy', elem.specialCourtesyList[i]);
  for i := 0 to elem.specialArrangementList.Count - 1 do
    ComposeCodeableConcept(xml, 'specialArrangement', elem.specialArrangementList[i]);
  ComposeResourceReference{TFhirLocation}(xml, 'destination', elem.destination);
  ComposeCodeableConcept(xml, 'dischargeDisposition', elem.dischargeDisposition);
  ComposeBoolean(xml, 'reAdmission', elem.reAdmission);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseEncounterHospitalization : TFhirEncounterHospitalization;
begin
  json.next;
  result := TFhirEncounterHospitalization.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'preAdmissionIdentifier') then
        result.preAdmissionIdentifier := ParseIdentifier
      else if (json.ItemName = 'origin') then
        result.origin := ParseResourceReference{TFhirLocation}
      else if (json.ItemName = 'admitSource') then
        result.admitSource := ParseCodeableConcept
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if (json.ItemName = 'accomodation') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.accomodationList.Add(ParseEncounterHospitalizationAccomodation);
          json.Next;
        end;
      end
      else if (json.ItemName = 'diet') then
        result.diet := ParseCodeableConcept
      else if (json.ItemName = 'specialCourtesy') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.specialCourtesyList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'specialArrangement') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.specialArrangementList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'destination') then
        result.destination := ParseResourceReference{TFhirLocation}
      else if (json.ItemName = 'dischargeDisposition') then
        result.dischargeDisposition := ParseCodeableConcept
      else if (json.ItemName = 'reAdmission') then
        result.reAdmission := ParseBoolean
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeEncounterHospitalization(json : TJSONWriter; name : string; elem : TFhirEncounterHospitalization);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeIdentifier(json, 'preAdmissionIdentifier', elem.preAdmissionIdentifier);
  ComposeResourceReference{TFhirLocation}(json, 'origin', elem.origin);
  ComposeCodeableConcept(json, 'admitSource', elem.admitSource);
  ComposePeriod(json, 'period', elem.period);
  if elem.accomodationList.Count > 0 then
  begin
    json.valueArray('accomodation');
    for i := 0 to elem.accomodationList.Count - 1 do
      ComposeEncounterHospitalizationAccomodation(json, '',elem.accomodationList[i]);
    json.FinishArray;
  end;
  ComposeCodeableConcept(json, 'diet', elem.diet);
  if elem.specialCourtesyList.Count > 0 then
  begin
    json.valueArray('specialCourtesy');
    for i := 0 to elem.specialCourtesyList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.specialCourtesyList[i]);
    json.FinishArray;
  end;
  if elem.specialArrangementList.Count > 0 then
  begin
    json.valueArray('specialArrangement');
    for i := 0 to elem.specialArrangementList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.specialArrangementList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirLocation}(json, 'destination', elem.destination);
  ComposeCodeableConcept(json, 'dischargeDisposition', elem.dischargeDisposition);
  ComposeBoolean(json, 'reAdmission', elem.reAdmission);
  json.finishObject;
end;

function TFHIRXmlParser.ParseEncounterHospitalizationAccomodation(element : IXmlDomElement) : TFhirEncounterHospitalizationAccomodation;
var
  child : IXMLDOMElement;
begin
  result := TFhirEncounterHospitalizationAccomodation.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'bed') then
        result.bed := ParseResourceReference{TFhirLocation}(child) {b}
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeEncounterHospitalizationAccomodation(xml : TXmlBuilder; name : string; elem : TFhirEncounterHospitalizationAccomodation);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeResourceReference{TFhirLocation}(xml, 'bed', elem.bed);
  ComposePeriod(xml, 'period', elem.period);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseEncounterHospitalizationAccomodation : TFhirEncounterHospitalizationAccomodation;
begin
  json.next;
  result := TFhirEncounterHospitalizationAccomodation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'bed') then
        result.bed := ParseResourceReference{TFhirLocation}
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeEncounterHospitalizationAccomodation(json : TJSONWriter; name : string; elem : TFhirEncounterHospitalizationAccomodation);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeResourceReference{TFhirLocation}(json, 'bed', elem.bed);
  ComposePeriod(json, 'period', elem.period);
  json.finishObject;
end;

function TFHIRXmlParser.ParseEncounterLocation(element : IXmlDomElement) : TFhirEncounterLocation;
var
  child : IXMLDOMElement;
begin
  result := TFhirEncounterLocation.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'location') then
        result.location := ParseResourceReference{TFhirLocation}(child) {b}
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeEncounterLocation(xml : TXmlBuilder; name : string; elem : TFhirEncounterLocation);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeResourceReference{TFhirLocation}(xml, 'location', elem.location);
  ComposePeriod(xml, 'period', elem.period);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseEncounterLocation : TFhirEncounterLocation;
begin
  json.next;
  result := TFhirEncounterLocation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'location') then
        result.location := ParseResourceReference{TFhirLocation}
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeEncounterLocation(json : TJSONWriter; name : string; elem : TFhirEncounterLocation);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeResourceReference{TFhirLocation}(json, 'location', elem.location);
  ComposePeriod(json, 'period', elem.period);
  json.finishObject;
end;

function TFHIRXmlParser.ParseEncounter(element : IXmlDomElement) : TFhirEncounter;
var
  child : IXMLDOMElement;
begin
  result := TFhirEncounter.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirEncounterState, child)
      else if (child.baseName = 'class') then
        result.class_ := ParseEnum(CODES_TFhirEncounterClass, child)
      else if (child.baseName = 'type') then
        result.type_List.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'participant') then
        result.participantList.Add(ParseEncounterParticipant(child))
      else if (child.baseName = 'fulfills') then
        result.fulfills := ParseResourceReference{TFhirAppointment}(child) {b}
      else if (child.baseName = 'start') then
        result.start := ParseDateTime(child) {b}
      else if (child.baseName = 'length') then
        result.length := ParseQuantity(child) {b}
      else if (child.baseName = 'reasonString') then
        result.reason := ParseString(child)
      else if (child.baseName = 'reasonCodeableConcept') then
        result.reason := ParseCodeableConcept(child)
      else if (child.baseName = 'indication') then
        result.indication := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'priority') then
        result.priority := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'hospitalization') then
        result.hospitalization := ParseEncounterHospitalization(child) {b}
      else if (child.baseName = 'location') then
        result.locationList.Add(ParseEncounterLocation(child))
      else if (child.baseName = 'serviceProvider') then
        result.serviceProvider := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'partOf') then
        result.partOf := ParseResourceReference{TFhirEncounter}(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeEncounter(xml : TXmlBuilder; name : string; elem : TFhirEncounter);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirEncounterState);
  ComposeEnum(xml, 'class', elem.Class_, CODES_TFhirEncounterClass);
  for i := 0 to elem.type_List.Count - 1 do
    ComposeCodeableConcept(xml, 'type', elem.type_List[i]);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  for i := 0 to elem.participantList.Count - 1 do
    ComposeEncounterParticipant(xml, 'participant', elem.participantList[i]);
  ComposeResourceReference{TFhirAppointment}(xml, 'fulfills', elem.fulfills);
  ComposeDateTime(xml, 'start', elem.start);
  ComposeQuantity(xml, 'length', elem.length);
  if elem.reason is TFhirString {6} then
    ComposeString(xml, 'reasonString', TFhirString(elem.reason))
  else if elem.reason is TFhirCodeableConcept {6} then
    ComposeCodeableConcept(xml, 'reasonCodeableConcept', TFhirCodeableConcept(elem.reason));
  ComposeResourceReference{Resource}(xml, 'indication', elem.indication);
  ComposeCodeableConcept(xml, 'priority', elem.priority);
  ComposeEncounterHospitalization(xml, 'hospitalization', elem.hospitalization);
  for i := 0 to elem.locationList.Count - 1 do
    ComposeEncounterLocation(xml, 'location', elem.locationList[i]);
  ComposeResourceReference{TFhirOrganization}(xml, 'serviceProvider', elem.serviceProvider);
  ComposeResourceReference{TFhirEncounter}(xml, 'partOf', elem.partOf);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseEncounter : TFhirEncounter;
begin
  json.next;
  result := TFhirEncounter.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirEncounterState)
      else if (json.ItemName = 'class') then
        result.class_ := ParseEnum(CODES_TFhirEncounterClass)
      else if (json.ItemName = 'type') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.type_List.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'participant') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.participantList.Add(ParseEncounterParticipant);
          json.Next;
        end;
      end
      else if (json.ItemName = 'fulfills') then
        result.fulfills := ParseResourceReference{TFhirAppointment}
      else if (json.ItemName = 'start') then
        result.start := ParseDateTime
      else if (json.ItemName = 'length') then
        result.length := ParseQuantity
      else if (json.ItemName = 'reasonString') then
        result.reason := ParseString
      else if (json.ItemName = 'reasonCodeableConcept') then
        result.reason := ParseCodeableConcept
      else if (json.ItemName = 'indication') then
        result.indication := ParseResourceReference{Resource}
      else if (json.ItemName = 'priority') then
        result.priority := ParseCodeableConcept
      else if (json.ItemName = 'hospitalization') then
        result.hospitalization := ParseEncounterHospitalization
      else if (json.ItemName = 'location') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.locationList.Add(ParseEncounterLocation);
          json.Next;
        end;
      end
      else if (json.ItemName = 'serviceProvider') then
        result.serviceProvider := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'partOf') then
        result.partOf := ParseResourceReference{TFhirEncounter}
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeEncounter(json : TJSONWriter; name : string; elem : TFhirEncounter);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirEncounterState);
  ComposeEnum(json, 'class', elem.Class_, CODES_TFhirEncounterClass);
  if elem.type_List.Count > 0 then
  begin
    json.valueArray('type');
    for i := 0 to elem.type_List.Count - 1 do
      ComposeCodeableConcept(json, '',elem.type_List[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  if elem.participantList.Count > 0 then
  begin
    json.valueArray('participant');
    for i := 0 to elem.participantList.Count - 1 do
      ComposeEncounterParticipant(json, '',elem.participantList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirAppointment}(json, 'fulfills', elem.fulfills);
  ComposeDateTime(json, 'start', elem.start);
  ComposeQuantity(json, 'length', elem.length);
  if elem.reason is TFhirString then
    ComposeString(json, 'reasonString', TFhirString(elem.reason))
  else if elem.reason is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'reasonCodeableConcept', TFhirCodeableConcept(elem.reason));
  ComposeResourceReference{Resource}(json, 'indication', elem.indication);
  ComposeCodeableConcept(json, 'priority', elem.priority);
  ComposeEncounterHospitalization(json, 'hospitalization', elem.hospitalization);
  if elem.locationList.Count > 0 then
  begin
    json.valueArray('location');
    for i := 0 to elem.locationList.Count - 1 do
      ComposeEncounterLocation(json, '',elem.locationList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirOrganization}(json, 'serviceProvider', elem.serviceProvider);
  ComposeResourceReference{TFhirEncounter}(json, 'partOf', elem.partOf);
  json.finishObject;
end;

function TFHIRXmlParser.ParseFamilyHistoryRelation(element : IXmlDomElement) : TFhirFamilyHistoryRelation;
var
  child : IXMLDOMElement;
begin
  result := TFhirFamilyHistoryRelation.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'relationship') then
        result.relationship := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'deceasedBoolean') then
        result.deceased := ParseBoolean(child)
      else if (child.baseName = 'deceasedAge') then
        result.deceased := ParseAge(child)
      else if (child.baseName = 'deceasedRange') then
        result.deceased := ParseRange(child)
      else if (child.baseName = 'deceasedString') then
        result.deceased := ParseString(child)
      else if (child.baseName = 'note') then
        result.note := ParseString(child) {b}
      else if (child.baseName = 'condition') then
        result.conditionList.Add(ParseFamilyHistoryRelationCondition(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeFamilyHistoryRelation(xml : TXmlBuilder; name : string; elem : TFhirFamilyHistoryRelation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeCodeableConcept(xml, 'relationship', elem.relationship);
  if elem.deceased is TFhirBoolean {6} then
    ComposeBoolean(xml, 'deceasedBoolean', TFhirBoolean(elem.deceased))
  else if elem.deceased is TFhirQuantity {6} then
    ComposeAge(xml, 'deceasedAge', TFhirQuantity(elem.deceased))
  else if elem.deceased is TFhirRange {6} then
    ComposeRange(xml, 'deceasedRange', TFhirRange(elem.deceased))
  else if elem.deceased is TFhirString {6} then
    ComposeString(xml, 'deceasedString', TFhirString(elem.deceased));
  ComposeString(xml, 'note', elem.note);
  for i := 0 to elem.conditionList.Count - 1 do
    ComposeFamilyHistoryRelationCondition(xml, 'condition', elem.conditionList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseFamilyHistoryRelation : TFhirFamilyHistoryRelation;
begin
  json.next;
  result := TFhirFamilyHistoryRelation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'relationship') then
        result.relationship := ParseCodeableConcept
      else if (json.ItemName = 'deceasedBoolean') then
        result.deceased := ParseBoolean
      else if (json.ItemName = 'deceasedAge') then
        result.deceased := ParseAge
      else if (json.ItemName = 'deceasedRange') then
        result.deceased := ParseRange
      else if (json.ItemName = 'deceasedString') then
        result.deceased := ParseString
      else if (json.ItemName = 'note') then
        result.note := ParseString
      else if (json.ItemName = 'condition') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.conditionList.Add(ParseFamilyHistoryRelationCondition);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeFamilyHistoryRelation(json : TJSONWriter; name : string; elem : TFhirFamilyHistoryRelation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeCodeableConcept(json, 'relationship', elem.relationship);
  if elem.deceased is TFhirBoolean then
    ComposeBoolean(json, 'deceasedBoolean', TFhirBoolean(elem.deceased))
  else if elem.deceased is TFhirQuantity then
    ComposeAge(json, 'deceasedAge', TFhirQuantity(elem.deceased))
  else if elem.deceased is TFhirRange then
    ComposeRange(json, 'deceasedRange', TFhirRange(elem.deceased))
  else if elem.deceased is TFhirString then
    ComposeString(json, 'deceasedString', TFhirString(elem.deceased));
  ComposeString(json, 'note', elem.note);
  if elem.conditionList.Count > 0 then
  begin
    json.valueArray('condition');
    for i := 0 to elem.conditionList.Count - 1 do
      ComposeFamilyHistoryRelationCondition(json, '',elem.conditionList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseFamilyHistoryRelationCondition(element : IXmlDomElement) : TFhirFamilyHistoryRelationCondition;
var
  child : IXMLDOMElement;
begin
  result := TFhirFamilyHistoryRelationCondition.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'outcome') then
        result.outcome := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'onsetAge') then
        result.onset := ParseAge(child)
      else if (child.baseName = 'onsetRange') then
        result.onset := ParseRange(child)
      else if (child.baseName = 'onsetString') then
        result.onset := ParseString(child)
      else if (child.baseName = 'note') then
        result.note := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeFamilyHistoryRelationCondition(xml : TXmlBuilder; name : string; elem : TFhirFamilyHistoryRelationCondition);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeCodeableConcept(xml, 'outcome', elem.outcome);
  if elem.onset is TFhirQuantity {6} then
    ComposeAge(xml, 'onsetAge', TFhirQuantity(elem.onset))
  else if elem.onset is TFhirRange {6} then
    ComposeRange(xml, 'onsetRange', TFhirRange(elem.onset))
  else if elem.onset is TFhirString {6} then
    ComposeString(xml, 'onsetString', TFhirString(elem.onset));
  ComposeString(xml, 'note', elem.note);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseFamilyHistoryRelationCondition : TFhirFamilyHistoryRelationCondition;
begin
  json.next;
  result := TFhirFamilyHistoryRelationCondition.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'outcome') then
        result.outcome := ParseCodeableConcept
      else if (json.ItemName = 'onsetAge') then
        result.onset := ParseAge
      else if (json.ItemName = 'onsetRange') then
        result.onset := ParseRange
      else if (json.ItemName = 'onsetString') then
        result.onset := ParseString
      else if (json.ItemName = 'note') then
        result.note := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeFamilyHistoryRelationCondition(json : TJSONWriter; name : string; elem : TFhirFamilyHistoryRelationCondition);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeCodeableConcept(json, 'outcome', elem.outcome);
  if elem.onset is TFhirQuantity then
    ComposeAge(json, 'onsetAge', TFhirQuantity(elem.onset))
  else if elem.onset is TFhirRange then
    ComposeRange(json, 'onsetRange', TFhirRange(elem.onset))
  else if elem.onset is TFhirString then
    ComposeString(json, 'onsetString', TFhirString(elem.onset));
  ComposeString(json, 'note', elem.note);
  json.finishObject;
end;

function TFHIRXmlParser.ParseFamilyHistory(element : IXmlDomElement) : TFhirFamilyHistory;
var
  child : IXMLDOMElement;
begin
  result := TFhirFamilyHistory.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'note') then
        result.note := ParseString(child) {b}
      else if (child.baseName = 'relation') then
        result.relationList.Add(ParseFamilyHistoryRelation(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeFamilyHistory(xml : TXmlBuilder; name : string; elem : TFhirFamilyHistory);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  ComposeString(xml, 'note', elem.note);
  for i := 0 to elem.relationList.Count - 1 do
    ComposeFamilyHistoryRelation(xml, 'relation', elem.relationList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseFamilyHistory : TFhirFamilyHistory;
begin
  json.next;
  result := TFhirFamilyHistory.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'note') then
        result.note := ParseString
      else if (json.ItemName = 'relation') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.relationList.Add(ParseFamilyHistoryRelation);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeFamilyHistory(json : TJSONWriter; name : string; elem : TFhirFamilyHistory);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  ComposeString(json, 'note', elem.note);
  if elem.relationList.Count > 0 then
  begin
    json.valueArray('relation');
    for i := 0 to elem.relationList.Count - 1 do
      ComposeFamilyHistoryRelation(json, '',elem.relationList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseGroupCharacteristic(element : IXmlDomElement) : TFhirGroupCharacteristic;
var
  child : IXMLDOMElement;
begin
  result := TFhirGroupCharacteristic.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'valueCodeableConcept') then
        result.value := ParseCodeableConcept(child)
      else if (child.baseName = 'valueString') then
        result.value := ParseString(child)
      else if (child.baseName = 'valueBoolean') then
        result.value := ParseBoolean(child)
      else if (child.baseName = 'valueQuantity') then
        result.value := ParseQuantity(child)
      else if (child.baseName = 'valueRange') then
        result.value := ParseRange(child)
      else if (child.baseName = 'exclude') then
        result.exclude := ParseBoolean(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeGroupCharacteristic(xml : TXmlBuilder; name : string; elem : TFhirGroupCharacteristic);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  if elem.value is TFhirCodeableConcept {6} then
    ComposeCodeableConcept(xml, 'valueCodeableConcept', TFhirCodeableConcept(elem.value))
  else if elem.value is TFhirString {6} then
    ComposeString(xml, 'valueString', TFhirString(elem.value))
  else if elem.value is TFhirBoolean {6} then
    ComposeBoolean(xml, 'valueBoolean', TFhirBoolean(elem.value))
  else if elem.value is TFhirQuantity {6} then
    ComposeQuantity(xml, 'valueQuantity', TFhirQuantity(elem.value))
  else if elem.value is TFhirRange {6} then
    ComposeRange(xml, 'valueRange', TFhirRange(elem.value));
  ComposeBoolean(xml, 'exclude', elem.exclude);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseGroupCharacteristic : TFhirGroupCharacteristic;
begin
  json.next;
  result := TFhirGroupCharacteristic.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'valueCodeableConcept') then
        result.value := ParseCodeableConcept
      else if (json.ItemName = 'valueString') then
        result.value := ParseString
      else if (json.ItemName = 'valueBoolean') then
        result.value := ParseBoolean
      else if (json.ItemName = 'valueQuantity') then
        result.value := ParseQuantity
      else if (json.ItemName = 'valueRange') then
        result.value := ParseRange
      else if (json.ItemName = 'exclude') then
        result.exclude := ParseBoolean
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeGroupCharacteristic(json : TJSONWriter; name : string; elem : TFhirGroupCharacteristic);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'type', elem.type_);
  if elem.value is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'valueCodeableConcept', TFhirCodeableConcept(elem.value))
  else if elem.value is TFhirString then
    ComposeString(json, 'valueString', TFhirString(elem.value))
  else if elem.value is TFhirBoolean then
    ComposeBoolean(json, 'valueBoolean', TFhirBoolean(elem.value))
  else if elem.value is TFhirQuantity then
    ComposeQuantity(json, 'valueQuantity', TFhirQuantity(elem.value))
  else if elem.value is TFhirRange then
    ComposeRange(json, 'valueRange', TFhirRange(elem.value));
  ComposeBoolean(json, 'exclude', elem.exclude);
  json.finishObject;
end;

function TFHIRXmlParser.ParseGroup(element : IXmlDomElement) : TFhirGroup;
var
  child : IXMLDOMElement;
begin
  result := TFhirGroup.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirGroupType, child)
      else if (child.baseName = 'actual') then
        result.actual := ParseBoolean(child) {b}
      else if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'quantity') then
        result.quantity := ParseInteger(child) {b}
      else if (child.baseName = 'characteristic') then
        result.characteristicList.Add(ParseGroupCharacteristic(child))
      else if (child.baseName = 'member') then
        result.memberList.Add(ParseResourceReference{Resource}(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeGroup(xml : TXmlBuilder; name : string; elem : TFhirGroup);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeEnum(xml, 'type', elem.Type_, CODES_TFhirGroupType);
  ComposeBoolean(xml, 'actual', elem.actual);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeString(xml, 'name', elem.name);
  ComposeInteger(xml, 'quantity', elem.quantity);
  for i := 0 to elem.characteristicList.Count - 1 do
    ComposeGroupCharacteristic(xml, 'characteristic', elem.characteristicList[i]);
  for i := 0 to elem.memberList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'member', elem.memberList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseGroup : TFhirGroup;
begin
  json.next;
  result := TFhirGroup.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirGroupType)
      else if (json.ItemName = 'actual') then
        result.actual := ParseBoolean
      else if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'quantity') then
        result.quantity := ParseInteger
      else if (json.ItemName = 'characteristic') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.characteristicList.Add(ParseGroupCharacteristic);
          json.Next;
        end;
      end
      else if (json.ItemName = 'member') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.memberList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeGroup(json : TJSONWriter; name : string; elem : TFhirGroup);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeEnum(json, 'type', elem.Type_, CODES_TFhirGroupType);
  ComposeBoolean(json, 'actual', elem.actual);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeString(json, 'name', elem.name);
  ComposeInteger(json, 'quantity', elem.quantity);
  if elem.characteristicList.Count > 0 then
  begin
    json.valueArray('characteristic');
    for i := 0 to elem.characteristicList.Count - 1 do
      ComposeGroupCharacteristic(json, '',elem.characteristicList[i]);
    json.FinishArray;
  end;
  if elem.memberList.Count > 0 then
  begin
    json.valueArray('member');
    for i := 0 to elem.memberList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.memberList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseImagingStudySeries(element : IXmlDomElement) : TFhirImagingStudySeries;
var
  child : IXMLDOMElement;
begin
  result := TFhirImagingStudySeries.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'number') then
        result.number := ParseInteger(child) {b}
      else if (child.baseName = 'modality') then
        result.modality := ParseEnum(CODES_TFhirModality, child)
      else if (child.baseName = 'uid') then
        result.uid := ParseOid(child) {b}
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'numberOfInstances') then
        result.numberOfInstances := ParseInteger(child) {b}
      else if (child.baseName = 'availability') then
        result.availability := ParseEnum(CODES_TFhirInstanceAvailability, child)
      else if (child.baseName = 'url') then
        result.url := ParseUri(child) {b}
      else if (child.baseName = 'bodySite') then
        result.bodySite := ParseCoding(child) {b}
      else if (child.baseName = 'dateTime') then
        result.dateTime := ParseDateTime(child) {b}
      else if (child.baseName = 'instance') then
        result.instanceList.Add(ParseImagingStudySeriesInstance(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImagingStudySeries(xml : TXmlBuilder; name : string; elem : TFhirImagingStudySeries);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeInteger(xml, 'number', elem.number);
  ComposeEnum(xml, 'modality', elem.Modality, CODES_TFhirModality);
  ComposeOid(xml, 'uid', elem.uid);
  ComposeString(xml, 'description', elem.description);
  ComposeInteger(xml, 'numberOfInstances', elem.numberOfInstances);
  ComposeEnum(xml, 'availability', elem.Availability, CODES_TFhirInstanceAvailability);
  ComposeUri(xml, 'url', elem.url);
  ComposeCoding(xml, 'bodySite', elem.bodySite);
  ComposeDateTime(xml, 'dateTime', elem.dateTime);
  for i := 0 to elem.instanceList.Count - 1 do
    ComposeImagingStudySeriesInstance(xml, 'instance', elem.instanceList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImagingStudySeries : TFhirImagingStudySeries;
begin
  json.next;
  result := TFhirImagingStudySeries.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'number') then
        result.number := ParseInteger
      else if (json.ItemName = 'modality') then
        result.modality := ParseEnum(CODES_TFhirModality)
      else if (json.ItemName = 'uid') then
        result.uid := ParseOid
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'numberOfInstances') then
        result.numberOfInstances := ParseInteger
      else if (json.ItemName = 'availability') then
        result.availability := ParseEnum(CODES_TFhirInstanceAvailability)
      else if (json.ItemName = 'url') then
        result.url := ParseUri
      else if (json.ItemName = 'bodySite') then
        result.bodySite := ParseCoding
      else if (json.ItemName = 'dateTime') then
        result.dateTime := ParseDateTime
      else if (json.ItemName = 'instance') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.instanceList.Add(ParseImagingStudySeriesInstance);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImagingStudySeries(json : TJSONWriter; name : string; elem : TFhirImagingStudySeries);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeInteger(json, 'number', elem.number);
  ComposeEnum(json, 'modality', elem.Modality, CODES_TFhirModality);
  ComposeOid(json, 'uid', elem.uid);
  ComposeString(json, 'description', elem.description);
  ComposeInteger(json, 'numberOfInstances', elem.numberOfInstances);
  ComposeEnum(json, 'availability', elem.Availability, CODES_TFhirInstanceAvailability);
  ComposeUri(json, 'url', elem.url);
  ComposeCoding(json, 'bodySite', elem.bodySite);
  ComposeDateTime(json, 'dateTime', elem.dateTime);
  if elem.instanceList.Count > 0 then
  begin
    json.valueArray('instance');
    for i := 0 to elem.instanceList.Count - 1 do
      ComposeImagingStudySeriesInstance(json, '',elem.instanceList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseImagingStudySeriesInstance(element : IXmlDomElement) : TFhirImagingStudySeriesInstance;
var
  child : IXMLDOMElement;
begin
  result := TFhirImagingStudySeriesInstance.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'number') then
        result.number := ParseInteger(child) {b}
      else if (child.baseName = 'uid') then
        result.uid := ParseOid(child) {b}
      else if (child.baseName = 'sopclass') then
        result.sopclass := ParseOid(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseString(child) {b}
      else if (child.baseName = 'title') then
        result.title := ParseString(child) {b}
      else if (child.baseName = 'url') then
        result.url := ParseUri(child) {b}
      else if (child.baseName = 'attachment') then
        result.attachment := ParseResourceReference{Resource}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImagingStudySeriesInstance(xml : TXmlBuilder; name : string; elem : TFhirImagingStudySeriesInstance);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeInteger(xml, 'number', elem.number);
  ComposeOid(xml, 'uid', elem.uid);
  ComposeOid(xml, 'sopclass', elem.sopclass);
  ComposeString(xml, 'type', elem.type_);
  ComposeString(xml, 'title', elem.title);
  ComposeUri(xml, 'url', elem.url);
  ComposeResourceReference{Resource}(xml, 'attachment', elem.attachment);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImagingStudySeriesInstance : TFhirImagingStudySeriesInstance;
begin
  json.next;
  result := TFhirImagingStudySeriesInstance.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'number') then
        result.number := ParseInteger
      else if (json.ItemName = 'uid') then
        result.uid := ParseOid
      else if (json.ItemName = 'sopclass') then
        result.sopclass := ParseOid
      else if (json.ItemName = 'type') then
        result.type_ := ParseString
      else if (json.ItemName = 'title') then
        result.title := ParseString
      else if (json.ItemName = 'url') then
        result.url := ParseUri
      else if (json.ItemName = 'attachment') then
        result.attachment := ParseResourceReference{Resource}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImagingStudySeriesInstance(json : TJSONWriter; name : string; elem : TFhirImagingStudySeriesInstance);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeInteger(json, 'number', elem.number);
  ComposeOid(json, 'uid', elem.uid);
  ComposeOid(json, 'sopclass', elem.sopclass);
  ComposeString(json, 'type', elem.type_);
  ComposeString(json, 'title', elem.title);
  ComposeUri(json, 'url', elem.url);
  ComposeResourceReference{Resource}(json, 'attachment', elem.attachment);
  json.finishObject;
end;

function TFHIRXmlParser.ParseImagingStudy(element : IXmlDomElement) : TFhirImagingStudy;
var
  child : IXMLDOMElement;
begin
  result := TFhirImagingStudy.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'dateTime') then
        result.dateTime := ParseDateTime(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'uid') then
        result.uid := ParseOid(child) {b}
      else if (child.baseName = 'accessionNo') then
        result.accessionNo := ParseIdentifier(child) {b}
      else if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'modality') then
        result.modality.Add(ParseEnum(CODES_TFhirImagingModality, child))
      else if (child.baseName = 'referrer') then
        result.referrer := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'availability') then
        result.availability := ParseEnum(CODES_TFhirInstanceAvailability, child)
      else if (child.baseName = 'url') then
        result.url := ParseUri(child) {b}
      else if (child.baseName = 'numberOfSeries') then
        result.numberOfSeries := ParseInteger(child) {b}
      else if (child.baseName = 'numberOfInstances') then
        result.numberOfInstances := ParseInteger(child) {b}
      else if (child.baseName = 'clinicalInformation') then
        result.clinicalInformation := ParseString(child) {b}
      else if (child.baseName = 'procedure') then
        result.procedure_List.Add(ParseCoding(child))
      else if (child.baseName = 'interpreter') then
        result.interpreter := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'series') then
        result.seriesList.Add(ParseImagingStudySeries(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImagingStudy(xml : TXmlBuilder; name : string; elem : TFhirImagingStudy);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeDateTime(xml, 'dateTime', elem.dateTime);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  ComposeOid(xml, 'uid', elem.uid);
  ComposeIdentifier(xml, 'accessionNo', elem.accessionNo);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  for i := 0 to elem.modality.Count - 1 do
    ComposeEnum(xml, 'modality', elem.modality[i], CODES_TFhirImagingModality);
  ComposeResourceReference{TFhirPractitioner}(xml, 'referrer', elem.referrer);
  ComposeEnum(xml, 'availability', elem.Availability, CODES_TFhirInstanceAvailability);
  ComposeUri(xml, 'url', elem.url);
  ComposeInteger(xml, 'numberOfSeries', elem.numberOfSeries);
  ComposeInteger(xml, 'numberOfInstances', elem.numberOfInstances);
  ComposeString(xml, 'clinicalInformation', elem.clinicalInformation);
  for i := 0 to elem.procedure_List.Count - 1 do
    ComposeCoding(xml, 'procedure', elem.procedure_List[i]);
  ComposeResourceReference{TFhirPractitioner}(xml, 'interpreter', elem.interpreter);
  ComposeString(xml, 'description', elem.description);
  for i := 0 to elem.seriesList.Count - 1 do
    ComposeImagingStudySeries(xml, 'series', elem.seriesList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImagingStudy : TFhirImagingStudy;
begin
  json.next;
  result := TFhirImagingStudy.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'dateTime') then
        result.dateTime := ParseDateTime
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'uid') then
        result.uid := ParseOid
      else if (json.ItemName = 'accessionNo') then
        result.accessionNo := ParseIdentifier
      else if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'modality') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.modality.Add(ParseEnum(CODES_TFhirImagingModality));
          json.Next;
        end;
      end
      else if (json.ItemName = 'referrer') then
        result.referrer := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'availability') then
        result.availability := ParseEnum(CODES_TFhirInstanceAvailability)
      else if (json.ItemName = 'url') then
        result.url := ParseUri
      else if (json.ItemName = 'numberOfSeries') then
        result.numberOfSeries := ParseInteger
      else if (json.ItemName = 'numberOfInstances') then
        result.numberOfInstances := ParseInteger
      else if (json.ItemName = 'clinicalInformation') then
        result.clinicalInformation := ParseString
      else if (json.ItemName = 'procedure') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.procedure_List.Add(ParseCoding);
          json.Next;
        end;
      end
      else if (json.ItemName = 'interpreter') then
        result.interpreter := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'series') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.seriesList.Add(ParseImagingStudySeries);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImagingStudy(json : TJSONWriter; name : string; elem : TFhirImagingStudy);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeDateTime(json, 'dateTime', elem.dateTime);
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  ComposeOid(json, 'uid', elem.uid);
  ComposeIdentifier(json, 'accessionNo', elem.accessionNo);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  if elem.modality.Count > 0 then
  begin
    json.valueArray('modality');
    for i := 0 to elem.modality.Count - 1 do
      ComposeEnum(json, 'modality', elem.modality[i], CODES_TFhirImagingModality);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirPractitioner}(json, 'referrer', elem.referrer);
  ComposeEnum(json, 'availability', elem.Availability, CODES_TFhirInstanceAvailability);
  ComposeUri(json, 'url', elem.url);
  ComposeInteger(json, 'numberOfSeries', elem.numberOfSeries);
  ComposeInteger(json, 'numberOfInstances', elem.numberOfInstances);
  ComposeString(json, 'clinicalInformation', elem.clinicalInformation);
  if elem.procedure_List.Count > 0 then
  begin
    json.valueArray('procedure');
    for i := 0 to elem.procedure_List.Count - 1 do
      ComposeCoding(json, '',elem.procedure_List[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirPractitioner}(json, 'interpreter', elem.interpreter);
  ComposeString(json, 'description', elem.description);
  if elem.seriesList.Count > 0 then
  begin
    json.valueArray('series');
    for i := 0 to elem.seriesList.Count - 1 do
      ComposeImagingStudySeries(json, '',elem.seriesList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseImmunizationExplanation(element : IXmlDomElement) : TFhirImmunizationExplanation;
var
  child : IXMLDOMElement;
begin
  result := TFhirImmunizationExplanation.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'reason') then
        result.reasonList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'refusalReason') then
        result.refusalReasonList.Add(ParseCodeableConcept(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImmunizationExplanation(xml : TXmlBuilder; name : string; elem : TFhirImmunizationExplanation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.reasonList.Count - 1 do
    ComposeCodeableConcept(xml, 'reason', elem.reasonList[i]);
  for i := 0 to elem.refusalReasonList.Count - 1 do
    ComposeCodeableConcept(xml, 'refusalReason', elem.refusalReasonList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImmunizationExplanation : TFhirImmunizationExplanation;
begin
  json.next;
  result := TFhirImmunizationExplanation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'reason') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.reasonList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'refusalReason') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.refusalReasonList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImmunizationExplanation(json : TJSONWriter; name : string; elem : TFhirImmunizationExplanation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.reasonList.Count > 0 then
  begin
    json.valueArray('reason');
    for i := 0 to elem.reasonList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.reasonList[i]);
    json.FinishArray;
  end;
  if elem.refusalReasonList.Count > 0 then
  begin
    json.valueArray('refusalReason');
    for i := 0 to elem.refusalReasonList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.refusalReasonList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseImmunizationReaction(element : IXmlDomElement) : TFhirImmunizationReaction;
var
  child : IXMLDOMElement;
begin
  result := TFhirImmunizationReaction.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'date') then
        result.date := ParseDateTime(child) {b}
      else if (child.baseName = 'detail') then
        result.detail := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'reported') then
        result.reported := ParseBoolean(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImmunizationReaction(xml : TXmlBuilder; name : string; elem : TFhirImmunizationReaction);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeDateTime(xml, 'date', elem.date);
  ComposeResourceReference{Resource}(xml, 'detail', elem.detail);
  ComposeBoolean(xml, 'reported', elem.reported);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImmunizationReaction : TFhirImmunizationReaction;
begin
  json.next;
  result := TFhirImmunizationReaction.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'date') then
        result.date := ParseDateTime
      else if (json.ItemName = 'detail') then
        result.detail := ParseResourceReference{Resource}
      else if (json.ItemName = 'reported') then
        result.reported := ParseBoolean
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImmunizationReaction(json : TJSONWriter; name : string; elem : TFhirImmunizationReaction);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeDateTime(json, 'date', elem.date);
  ComposeResourceReference{Resource}(json, 'detail', elem.detail);
  ComposeBoolean(json, 'reported', elem.reported);
  json.finishObject;
end;

function TFHIRXmlParser.ParseImmunizationVaccinationProtocol(element : IXmlDomElement) : TFhirImmunizationVaccinationProtocol;
var
  child : IXMLDOMElement;
begin
  result := TFhirImmunizationVaccinationProtocol.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'doseSequence') then
        result.doseSequence := ParseInteger(child) {b}
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'authority') then
        result.authority := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'series') then
        result.series := ParseString(child) {b}
      else if (child.baseName = 'seriesDoses') then
        result.seriesDoses := ParseInteger(child) {b}
      else if (child.baseName = 'doseTarget') then
        result.doseTarget := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'doseStatus') then
        result.doseStatus := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'doseStatusReason') then
        result.doseStatusReason := ParseCodeableConcept(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImmunizationVaccinationProtocol(xml : TXmlBuilder; name : string; elem : TFhirImmunizationVaccinationProtocol);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeInteger(xml, 'doseSequence', elem.doseSequence);
  ComposeString(xml, 'description', elem.description);
  ComposeResourceReference{TFhirOrganization}(xml, 'authority', elem.authority);
  ComposeString(xml, 'series', elem.series);
  ComposeInteger(xml, 'seriesDoses', elem.seriesDoses);
  ComposeCodeableConcept(xml, 'doseTarget', elem.doseTarget);
  ComposeCodeableConcept(xml, 'doseStatus', elem.doseStatus);
  ComposeCodeableConcept(xml, 'doseStatusReason', elem.doseStatusReason);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImmunizationVaccinationProtocol : TFhirImmunizationVaccinationProtocol;
begin
  json.next;
  result := TFhirImmunizationVaccinationProtocol.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'doseSequence') then
        result.doseSequence := ParseInteger
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'authority') then
        result.authority := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'series') then
        result.series := ParseString
      else if (json.ItemName = 'seriesDoses') then
        result.seriesDoses := ParseInteger
      else if (json.ItemName = 'doseTarget') then
        result.doseTarget := ParseCodeableConcept
      else if (json.ItemName = 'doseStatus') then
        result.doseStatus := ParseCodeableConcept
      else if (json.ItemName = 'doseStatusReason') then
        result.doseStatusReason := ParseCodeableConcept
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImmunizationVaccinationProtocol(json : TJSONWriter; name : string; elem : TFhirImmunizationVaccinationProtocol);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeInteger(json, 'doseSequence', elem.doseSequence);
  ComposeString(json, 'description', elem.description);
  ComposeResourceReference{TFhirOrganization}(json, 'authority', elem.authority);
  ComposeString(json, 'series', elem.series);
  ComposeInteger(json, 'seriesDoses', elem.seriesDoses);
  ComposeCodeableConcept(json, 'doseTarget', elem.doseTarget);
  ComposeCodeableConcept(json, 'doseStatus', elem.doseStatus);
  ComposeCodeableConcept(json, 'doseStatusReason', elem.doseStatusReason);
  json.finishObject;
end;

function TFHIRXmlParser.ParseImmunization(element : IXmlDomElement) : TFhirImmunization;
var
  child : IXMLDOMElement;
begin
  result := TFhirImmunization.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'date') then
        result.date := ParseDateTime(child) {b}
      else if (child.baseName = 'vaccineType') then
        result.vaccineType := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'refusedIndicator') then
        result.refusedIndicator := ParseBoolean(child) {b}
      else if (child.baseName = 'reported') then
        result.reported := ParseBoolean(child) {b}
      else if (child.baseName = 'performer') then
        result.performer := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'requester') then
        result.requester := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'manufacturer') then
        result.manufacturer := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'location') then
        result.location := ParseResourceReference{TFhirLocation}(child) {b}
      else if (child.baseName = 'lotNumber') then
        result.lotNumber := ParseString(child) {b}
      else if (child.baseName = 'expirationDate') then
        result.expirationDate := ParseDate(child) {b}
      else if (child.baseName = 'site') then
        result.site := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'route') then
        result.route := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'doseQuantity') then
        result.doseQuantity := ParseQuantity(child) {b}
      else if (child.baseName = 'explanation') then
        result.explanation := ParseImmunizationExplanation(child) {b}
      else if (child.baseName = 'reaction') then
        result.reactionList.Add(ParseImmunizationReaction(child))
      else if (child.baseName = 'vaccinationProtocol') then
        result.vaccinationProtocol := ParseImmunizationVaccinationProtocol(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImmunization(xml : TXmlBuilder; name : string; elem : TFhirImmunization);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeDateTime(xml, 'date', elem.date);
  ComposeCodeableConcept(xml, 'vaccineType', elem.vaccineType);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  ComposeBoolean(xml, 'refusedIndicator', elem.refusedIndicator);
  ComposeBoolean(xml, 'reported', elem.reported);
  ComposeResourceReference{TFhirPractitioner}(xml, 'performer', elem.performer);
  ComposeResourceReference{TFhirPractitioner}(xml, 'requester', elem.requester);
  ComposeResourceReference{TFhirOrganization}(xml, 'manufacturer', elem.manufacturer);
  ComposeResourceReference{TFhirLocation}(xml, 'location', elem.location);
  ComposeString(xml, 'lotNumber', elem.lotNumber);
  ComposeDate(xml, 'expirationDate', elem.expirationDate);
  ComposeCodeableConcept(xml, 'site', elem.site);
  ComposeCodeableConcept(xml, 'route', elem.route);
  ComposeQuantity(xml, 'doseQuantity', elem.doseQuantity);
  ComposeImmunizationExplanation(xml, 'explanation', elem.explanation);
  for i := 0 to elem.reactionList.Count - 1 do
    ComposeImmunizationReaction(xml, 'reaction', elem.reactionList[i]);
  ComposeImmunizationVaccinationProtocol(xml, 'vaccinationProtocol', elem.vaccinationProtocol);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImmunization : TFhirImmunization;
begin
  json.next;
  result := TFhirImmunization.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'date') then
        result.date := ParseDateTime
      else if (json.ItemName = 'vaccineType') then
        result.vaccineType := ParseCodeableConcept
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'refusedIndicator') then
        result.refusedIndicator := ParseBoolean
      else if (json.ItemName = 'reported') then
        result.reported := ParseBoolean
      else if (json.ItemName = 'performer') then
        result.performer := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'requester') then
        result.requester := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'manufacturer') then
        result.manufacturer := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'location') then
        result.location := ParseResourceReference{TFhirLocation}
      else if (json.ItemName = 'lotNumber') then
        result.lotNumber := ParseString
      else if (json.ItemName = 'expirationDate') then
        result.expirationDate := ParseDate
      else if (json.ItemName = 'site') then
        result.site := ParseCodeableConcept
      else if (json.ItemName = 'route') then
        result.route := ParseCodeableConcept
      else if (json.ItemName = 'doseQuantity') then
        result.doseQuantity := ParseQuantity
      else if (json.ItemName = 'explanation') then
        result.explanation := ParseImmunizationExplanation
      else if (json.ItemName = 'reaction') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.reactionList.Add(ParseImmunizationReaction);
          json.Next;
        end;
      end
      else if (json.ItemName = 'vaccinationProtocol') then
        result.vaccinationProtocol := ParseImmunizationVaccinationProtocol
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImmunization(json : TJSONWriter; name : string; elem : TFhirImmunization);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeDateTime(json, 'date', elem.date);
  ComposeCodeableConcept(json, 'vaccineType', elem.vaccineType);
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  ComposeBoolean(json, 'refusedIndicator', elem.refusedIndicator);
  ComposeBoolean(json, 'reported', elem.reported);
  ComposeResourceReference{TFhirPractitioner}(json, 'performer', elem.performer);
  ComposeResourceReference{TFhirPractitioner}(json, 'requester', elem.requester);
  ComposeResourceReference{TFhirOrganization}(json, 'manufacturer', elem.manufacturer);
  ComposeResourceReference{TFhirLocation}(json, 'location', elem.location);
  ComposeString(json, 'lotNumber', elem.lotNumber);
  ComposeDate(json, 'expirationDate', elem.expirationDate);
  ComposeCodeableConcept(json, 'site', elem.site);
  ComposeCodeableConcept(json, 'route', elem.route);
  ComposeQuantity(json, 'doseQuantity', elem.doseQuantity);
  ComposeImmunizationExplanation(json, 'explanation', elem.explanation);
  if elem.reactionList.Count > 0 then
  begin
    json.valueArray('reaction');
    for i := 0 to elem.reactionList.Count - 1 do
      ComposeImmunizationReaction(json, '',elem.reactionList[i]);
    json.FinishArray;
  end;
  ComposeImmunizationVaccinationProtocol(json, 'vaccinationProtocol', elem.vaccinationProtocol);
  json.finishObject;
end;

function TFHIRXmlParser.ParseImmunizationProfileRecommendation(element : IXmlDomElement) : TFhirImmunizationProfileRecommendation;
var
  child : IXMLDOMElement;
begin
  result := TFhirImmunizationProfileRecommendation.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'recommendationDate') then
        result.recommendationDate := ParseDateTime(child) {b}
      else if (child.baseName = 'vaccineType') then
        result.vaccineType := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'doseNumber') then
        result.doseNumber := ParseInteger(child) {b}
      else if (child.baseName = 'forecastStatus') then
        result.forecastStatus := ParseEnum(CODES_TFhirImmunizationForecastStatus, child)
      else if (child.baseName = 'dateCriterion') then
        result.dateCriterionList.Add(ParseImmunizationProfileRecommendationDateCriterion(child))
      else if (child.baseName = 'protocol') then
        result.protocol := ParseImmunizationProfileRecommendationProtocol(child) {b}
      else if (child.baseName = 'supportingImmunization') then
        result.supportingImmunizationList.Add(ParseResourceReference{TFhirImmunization}(child))
      else if (child.baseName = 'supportingAdverseEventReport') then
        result.supportingAdverseEventReportList.Add(ParseImmunizationProfileRecommendationSupportingAdverseEventReport(child))
      else if (child.baseName = 'supportingPatientObservation') then
        result.supportingPatientObservationList.Add(ParseResourceReference{TFhirObservation}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImmunizationProfileRecommendation(xml : TXmlBuilder; name : string; elem : TFhirImmunizationProfileRecommendation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeDateTime(xml, 'recommendationDate', elem.recommendationDate);
  ComposeCodeableConcept(xml, 'vaccineType', elem.vaccineType);
  ComposeInteger(xml, 'doseNumber', elem.doseNumber);
  ComposeEnum(xml, 'forecastStatus', elem.ForecastStatus, CODES_TFhirImmunizationForecastStatus);
  for i := 0 to elem.dateCriterionList.Count - 1 do
    ComposeImmunizationProfileRecommendationDateCriterion(xml, 'dateCriterion', elem.dateCriterionList[i]);
  ComposeImmunizationProfileRecommendationProtocol(xml, 'protocol', elem.protocol);
  for i := 0 to elem.supportingImmunizationList.Count - 1 do
    ComposeResourceReference{TFhirImmunization}(xml, 'supportingImmunization', elem.supportingImmunizationList[i]);
  for i := 0 to elem.supportingAdverseEventReportList.Count - 1 do
    ComposeImmunizationProfileRecommendationSupportingAdverseEventReport(xml, 'supportingAdverseEventReport', elem.supportingAdverseEventReportList[i]);
  for i := 0 to elem.supportingPatientObservationList.Count - 1 do
    ComposeResourceReference{TFhirObservation}(xml, 'supportingPatientObservation', elem.supportingPatientObservationList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImmunizationProfileRecommendation : TFhirImmunizationProfileRecommendation;
begin
  json.next;
  result := TFhirImmunizationProfileRecommendation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'recommendationDate') then
        result.recommendationDate := ParseDateTime
      else if (json.ItemName = 'vaccineType') then
        result.vaccineType := ParseCodeableConcept
      else if (json.ItemName = 'doseNumber') then
        result.doseNumber := ParseInteger
      else if (json.ItemName = 'forecastStatus') then
        result.forecastStatus := ParseEnum(CODES_TFhirImmunizationForecastStatus)
      else if (json.ItemName = 'dateCriterion') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.dateCriterionList.Add(ParseImmunizationProfileRecommendationDateCriterion);
          json.Next;
        end;
      end
      else if (json.ItemName = 'protocol') then
        result.protocol := ParseImmunizationProfileRecommendationProtocol
      else if (json.ItemName = 'supportingImmunization') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.supportingImmunizationList.Add(ParseResourceReference{TFhirImmunization});
          json.Next;
        end;
      end
      else if (json.ItemName = 'supportingAdverseEventReport') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.supportingAdverseEventReportList.Add(ParseImmunizationProfileRecommendationSupportingAdverseEventReport);
          json.Next;
        end;
      end
      else if (json.ItemName = 'supportingPatientObservation') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.supportingPatientObservationList.Add(ParseResourceReference{TFhirObservation});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImmunizationProfileRecommendation(json : TJSONWriter; name : string; elem : TFhirImmunizationProfileRecommendation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeDateTime(json, 'recommendationDate', elem.recommendationDate);
  ComposeCodeableConcept(json, 'vaccineType', elem.vaccineType);
  ComposeInteger(json, 'doseNumber', elem.doseNumber);
  ComposeEnum(json, 'forecastStatus', elem.ForecastStatus, CODES_TFhirImmunizationForecastStatus);
  if elem.dateCriterionList.Count > 0 then
  begin
    json.valueArray('dateCriterion');
    for i := 0 to elem.dateCriterionList.Count - 1 do
      ComposeImmunizationProfileRecommendationDateCriterion(json, '',elem.dateCriterionList[i]);
    json.FinishArray;
  end;
  ComposeImmunizationProfileRecommendationProtocol(json, 'protocol', elem.protocol);
  if elem.supportingImmunizationList.Count > 0 then
  begin
    json.valueArray('supportingImmunization');
    for i := 0 to elem.supportingImmunizationList.Count - 1 do
      ComposeResourceReference{TFhirImmunization}(json, '',elem.supportingImmunizationList[i]);
    json.FinishArray;
  end;
  if elem.supportingAdverseEventReportList.Count > 0 then
  begin
    json.valueArray('supportingAdverseEventReport');
    for i := 0 to elem.supportingAdverseEventReportList.Count - 1 do
      ComposeImmunizationProfileRecommendationSupportingAdverseEventReport(json, '',elem.supportingAdverseEventReportList[i]);
    json.FinishArray;
  end;
  if elem.supportingPatientObservationList.Count > 0 then
  begin
    json.valueArray('supportingPatientObservation');
    for i := 0 to elem.supportingPatientObservationList.Count - 1 do
      ComposeResourceReference{TFhirObservation}(json, '',elem.supportingPatientObservationList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseImmunizationProfileRecommendationDateCriterion(element : IXmlDomElement) : TFhirImmunizationProfileRecommendationDateCriterion;
var
  child : IXMLDOMElement;
begin
  result := TFhirImmunizationProfileRecommendationDateCriterion.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'value') then
        result.value := ParseDateTime(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImmunizationProfileRecommendationDateCriterion(xml : TXmlBuilder; name : string; elem : TFhirImmunizationProfileRecommendationDateCriterion);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeDateTime(xml, 'value', elem.value);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImmunizationProfileRecommendationDateCriterion : TFhirImmunizationProfileRecommendationDateCriterion;
begin
  json.next;
  result := TFhirImmunizationProfileRecommendationDateCriterion.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'value') then
        result.value := ParseDateTime
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImmunizationProfileRecommendationDateCriterion(json : TJSONWriter; name : string; elem : TFhirImmunizationProfileRecommendationDateCriterion);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeDateTime(json, 'value', elem.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseImmunizationProfileRecommendationProtocol(element : IXmlDomElement) : TFhirImmunizationProfileRecommendationProtocol;
var
  child : IXMLDOMElement;
begin
  result := TFhirImmunizationProfileRecommendationProtocol.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'doseSequence') then
        result.doseSequence := ParseInteger(child) {b}
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'authority') then
        result.authority := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'series') then
        result.series := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImmunizationProfileRecommendationProtocol(xml : TXmlBuilder; name : string; elem : TFhirImmunizationProfileRecommendationProtocol);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeInteger(xml, 'doseSequence', elem.doseSequence);
  ComposeString(xml, 'description', elem.description);
  ComposeResourceReference{TFhirOrganization}(xml, 'authority', elem.authority);
  ComposeString(xml, 'series', elem.series);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImmunizationProfileRecommendationProtocol : TFhirImmunizationProfileRecommendationProtocol;
begin
  json.next;
  result := TFhirImmunizationProfileRecommendationProtocol.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'doseSequence') then
        result.doseSequence := ParseInteger
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'authority') then
        result.authority := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'series') then
        result.series := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImmunizationProfileRecommendationProtocol(json : TJSONWriter; name : string; elem : TFhirImmunizationProfileRecommendationProtocol);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeInteger(json, 'doseSequence', elem.doseSequence);
  ComposeString(json, 'description', elem.description);
  ComposeResourceReference{TFhirOrganization}(json, 'authority', elem.authority);
  ComposeString(json, 'series', elem.series);
  json.finishObject;
end;

function TFHIRXmlParser.ParseImmunizationProfileRecommendationSupportingAdverseEventReport(element : IXmlDomElement) : TFhirImmunizationProfileRecommendationSupportingAdverseEventReport;
var
  child : IXMLDOMElement;
begin
  result := TFhirImmunizationProfileRecommendationSupportingAdverseEventReport.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseId(child))
      else if (child.baseName = 'reportType') then
        result.reportType := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'reportDate') then
        result.reportDate := ParseDateTime(child) {b}
      else if (child.baseName = 'text') then
        result.text := ParseString(child) {b}
      else if (child.baseName = 'reaction') then
        result.reactionList.Add(ParseResourceReference{TFhirAdverseReaction}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImmunizationProfileRecommendationSupportingAdverseEventReport(xml : TXmlBuilder; name : string; elem : TFhirImmunizationProfileRecommendationSupportingAdverseEventReport);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeId(xml, 'identifier', elem.identifierList[i]);
  ComposeCodeableConcept(xml, 'reportType', elem.reportType);
  ComposeDateTime(xml, 'reportDate', elem.reportDate);
  ComposeString(xml, 'text', elem.text);
  for i := 0 to elem.reactionList.Count - 1 do
    ComposeResourceReference{TFhirAdverseReaction}(xml, 'reaction', elem.reactionList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImmunizationProfileRecommendationSupportingAdverseEventReport : TFhirImmunizationProfileRecommendationSupportingAdverseEventReport;
begin
  json.next;
  result := TFhirImmunizationProfileRecommendationSupportingAdverseEventReport.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseId);
          json.Next;
        end;
      end
      else if (json.ItemName = 'reportType') then
        result.reportType := ParseCodeableConcept
      else if (json.ItemName = 'reportDate') then
        result.reportDate := ParseDateTime
      else if (json.ItemName = 'text') then
        result.text := ParseString
      else if (json.ItemName = 'reaction') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.reactionList.Add(ParseResourceReference{TFhirAdverseReaction});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImmunizationProfileRecommendationSupportingAdverseEventReport(json : TJSONWriter; name : string; elem : TFhirImmunizationProfileRecommendationSupportingAdverseEventReport);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeId(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeCodeableConcept(json, 'reportType', elem.reportType);
  ComposeDateTime(json, 'reportDate', elem.reportDate);
  ComposeString(json, 'text', elem.text);
  if elem.reactionList.Count > 0 then
  begin
    json.valueArray('reaction');
    for i := 0 to elem.reactionList.Count - 1 do
      ComposeResourceReference{TFhirAdverseReaction}(json, '',elem.reactionList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseImmunizationProfile(element : IXmlDomElement) : TFhirImmunizationProfile;
var
  child : IXMLDOMElement;
begin
  result := TFhirImmunizationProfile.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'recommendation') then
        result.recommendationList.Add(ParseImmunizationProfileRecommendation(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeImmunizationProfile(xml : TXmlBuilder; name : string; elem : TFhirImmunizationProfile);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  for i := 0 to elem.recommendationList.Count - 1 do
    ComposeImmunizationProfileRecommendation(xml, 'recommendation', elem.recommendationList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseImmunizationProfile : TFhirImmunizationProfile;
begin
  json.next;
  result := TFhirImmunizationProfile.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'recommendation') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.recommendationList.Add(ParseImmunizationProfileRecommendation);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeImmunizationProfile(json : TJSONWriter; name : string; elem : TFhirImmunizationProfile);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  if elem.recommendationList.Count > 0 then
  begin
    json.valueArray('recommendation');
    for i := 0 to elem.recommendationList.Count - 1 do
      ComposeImmunizationProfileRecommendation(json, '',elem.recommendationList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseListEntry(element : IXmlDomElement) : TFhirListEntry;
var
  child : IXMLDOMElement;
  item : IXMLDOMElement;
begin
  result := TFhirListEntry.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'flag') then
        result.flagList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'deleted') then
        result.deleted := ParseBoolean(child) {b}
      else if (child.baseName = 'date') then
        result.date := ParseDateTime(child) {b}
      else if (child.baseName = 'item') then
        result.item := ParseResourceReference{Resource}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeListEntry(xml : TXmlBuilder; name : string; elem : TFhirListEntry);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.flagList.Count - 1 do
    ComposeCodeableConcept(xml, 'flag', elem.flagList[i]);
  ComposeBoolean(xml, 'deleted', elem.deleted);
  ComposeDateTime(xml, 'date', elem.date);
  ComposeResourceReference{Resource}(xml, 'item', elem.item);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseListEntry : TFhirListEntry;
begin
  json.next;
  result := TFhirListEntry.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'flag') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.flagList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'deleted') then
        result.deleted := ParseBoolean
      else if (json.ItemName = 'date') then
        result.date := ParseDateTime
      else if (json.ItemName = 'item') then
        result.item := ParseResourceReference{Resource}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeListEntry(json : TJSONWriter; name : string; elem : TFhirListEntry);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.flagList.Count > 0 then
  begin
    json.valueArray('flag');
    for i := 0 to elem.flagList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.flagList[i]);
    json.FinishArray;
  end;
  ComposeBoolean(json, 'deleted', elem.deleted);
  ComposeDateTime(json, 'date', elem.date);
  ComposeResourceReference{Resource}(json, 'item', elem.item);
  json.finishObject;
end;

function TFHIRXmlParser.ParseList(element : IXmlDomElement) : TFhirList;
var
  child : IXMLDOMElement;
begin
  result := TFhirList.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'source') then
        result.source := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'date') then
        result.date := ParseDateTime(child) {b}
      else if (child.baseName = 'ordered') then
        result.ordered := ParseBoolean(child) {b}
      else if (child.baseName = 'mode') then
        result.mode := ParseEnum(CODES_TFhirListMode, child)
      else if (child.baseName = 'entry') then
        result.entryList.Add(ParseListEntry(child))
      else if (child.baseName = 'emptyReason') then
        result.emptyReason := ParseCodeableConcept(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeList(xml : TXmlBuilder; name : string; elem : TFhirList);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeResourceReference{Resource}(xml, 'source', elem.source);
  ComposeDateTime(xml, 'date', elem.date);
  ComposeBoolean(xml, 'ordered', elem.ordered);
  ComposeEnum(xml, 'mode', elem.Mode, CODES_TFhirListMode);
  for i := 0 to elem.entryList.Count - 1 do
    ComposeListEntry(xml, 'entry', elem.entryList[i]);
  ComposeCodeableConcept(xml, 'emptyReason', elem.emptyReason);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseList : TFhirList;
begin
  json.next;
  result := TFhirList.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'source') then
        result.source := ParseResourceReference{Resource}
      else if (json.ItemName = 'date') then
        result.date := ParseDateTime
      else if (json.ItemName = 'ordered') then
        result.ordered := ParseBoolean
      else if (json.ItemName = 'mode') then
        result.mode := ParseEnum(CODES_TFhirListMode)
      else if (json.ItemName = 'entry') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.entryList.Add(ParseListEntry);
          json.Next;
        end;
      end
      else if (json.ItemName = 'emptyReason') then
        result.emptyReason := ParseCodeableConcept
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeList(json : TJSONWriter; name : string; elem : TFhirList);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeResourceReference{Resource}(json, 'source', elem.source);
  ComposeDateTime(json, 'date', elem.date);
  ComposeBoolean(json, 'ordered', elem.ordered);
  ComposeEnum(json, 'mode', elem.Mode, CODES_TFhirListMode);
  if elem.entryList.Count > 0 then
  begin
    json.valueArray('entry');
    for i := 0 to elem.entryList.Count - 1 do
      ComposeListEntry(json, '',elem.entryList[i]);
    json.FinishArray;
  end;
  ComposeCodeableConcept(json, 'emptyReason', elem.emptyReason);
  json.finishObject;
end;

function TFHIRXmlParser.ParseLocationPosition(element : IXmlDomElement) : TFhirLocationPosition;
var
  child : IXMLDOMElement;
begin
  result := TFhirLocationPosition.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'longitude') then
        result.longitude := ParseDecimal(child) {b}
      else if (child.baseName = 'latitude') then
        result.latitude := ParseDecimal(child) {b}
      else if (child.baseName = 'altitude') then
        result.altitude := ParseDecimal(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeLocationPosition(xml : TXmlBuilder; name : string; elem : TFhirLocationPosition);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeDecimal(xml, 'longitude', elem.longitude);
  ComposeDecimal(xml, 'latitude', elem.latitude);
  ComposeDecimal(xml, 'altitude', elem.altitude);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseLocationPosition : TFhirLocationPosition;
begin
  json.next;
  result := TFhirLocationPosition.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'longitude') then
        result.longitude := ParseDecimal
      else if (json.ItemName = 'latitude') then
        result.latitude := ParseDecimal
      else if (json.ItemName = 'altitude') then
        result.altitude := ParseDecimal
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeLocationPosition(json : TJSONWriter; name : string; elem : TFhirLocationPosition);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeDecimal(json, 'longitude', elem.longitude);
  ComposeDecimal(json, 'latitude', elem.latitude);
  ComposeDecimal(json, 'altitude', elem.altitude);
  json.finishObject;
end;

function TFHIRXmlParser.ParseLocation(element : IXmlDomElement) : TFhirLocation;
var
  child : IXMLDOMElement;
begin
  result := TFhirLocation.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'type') then
        result.type_List.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'telecom') then
        result.telecom := ParseContact(child) {b}
      else if (child.baseName = 'address') then
        result.address := ParseAddress(child) {b}
      else if (child.baseName = 'position') then
        result.position := ParseLocationPosition(child) {b}
      else if (child.baseName = 'provider') then
        result.provider := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'active') then
        result.active := ParseBoolean(child) {b}
      else if (child.baseName = 'partOf') then
        result.partOf := ParseResourceReference{TFhirLocation}(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeLocation(xml : TXmlBuilder; name : string; elem : TFhirLocation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeString(xml, 'description', elem.description);
  for i := 0 to elem.type_List.Count - 1 do
    ComposeCodeableConcept(xml, 'type', elem.type_List[i]);
  ComposeContact(xml, 'telecom', elem.telecom);
  ComposeAddress(xml, 'address', elem.address);
  ComposeLocationPosition(xml, 'position', elem.position);
  ComposeResourceReference{TFhirOrganization}(xml, 'provider', elem.provider);
  ComposeBoolean(xml, 'active', elem.active);
  ComposeResourceReference{TFhirLocation}(xml, 'partOf', elem.partOf);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseLocation : TFhirLocation;
begin
  json.next;
  result := TFhirLocation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'type') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.type_List.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'telecom') then
        result.telecom := ParseContact
      else if (json.ItemName = 'address') then
        result.address := ParseAddress
      else if (json.ItemName = 'position') then
        result.position := ParseLocationPosition
      else if (json.ItemName = 'provider') then
        result.provider := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'active') then
        result.active := ParseBoolean
      else if (json.ItemName = 'partOf') then
        result.partOf := ParseResourceReference{TFhirLocation}
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeLocation(json : TJSONWriter; name : string; elem : TFhirLocation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeString(json, 'description', elem.description);
  if elem.type_List.Count > 0 then
  begin
    json.valueArray('type');
    for i := 0 to elem.type_List.Count - 1 do
      ComposeCodeableConcept(json, '',elem.type_List[i]);
    json.FinishArray;
  end;
  ComposeContact(json, 'telecom', elem.telecom);
  ComposeAddress(json, 'address', elem.address);
  ComposeLocationPosition(json, 'position', elem.position);
  ComposeResourceReference{TFhirOrganization}(json, 'provider', elem.provider);
  ComposeBoolean(json, 'active', elem.active);
  ComposeResourceReference{TFhirLocation}(json, 'partOf', elem.partOf);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedia(element : IXmlDomElement) : TFhirMedia;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedia.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirMediaType, child)
      else if (child.baseName = 'subtype') then
        result.subtype := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'dateTime') then
        result.dateTime := ParseDateTime(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'requester') then
        result.requester := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'operator') then
        result.operator := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'view') then
        result.view := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'deviceName') then
        result.deviceName := ParseString(child) {b}
      else if (child.baseName = 'height') then
        result.height := ParseInteger(child) {b}
      else if (child.baseName = 'width') then
        result.width := ParseInteger(child) {b}
      else if (child.baseName = 'frames') then
        result.frames := ParseInteger(child) {b}
      else if (child.baseName = 'length') then
        result.length := ParseInteger(child) {b}
      else if (child.baseName = 'content') then
        result.content := ParseAttachment(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedia(xml : TXmlBuilder; name : string; elem : TFhirMedia);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeEnum(xml, 'type', elem.Type_, CODES_TFhirMediaType);
  ComposeCodeableConcept(xml, 'subtype', elem.subtype);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeDateTime(xml, 'dateTime', elem.dateTime);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  ComposeResourceReference{TFhirPractitioner}(xml, 'requester', elem.requester);
  ComposeResourceReference{TFhirPractitioner}(xml, 'operator', elem.operator);
  ComposeCodeableConcept(xml, 'view', elem.view);
  ComposeString(xml, 'deviceName', elem.deviceName);
  ComposeInteger(xml, 'height', elem.height);
  ComposeInteger(xml, 'width', elem.width);
  ComposeInteger(xml, 'frames', elem.frames);
  ComposeInteger(xml, 'length', elem.length);
  ComposeAttachment(xml, 'content', elem.content);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedia : TFhirMedia;
begin
  json.next;
  result := TFhirMedia.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirMediaType)
      else if (json.ItemName = 'subtype') then
        result.subtype := ParseCodeableConcept
      else if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'dateTime') then
        result.dateTime := ParseDateTime
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'requester') then
        result.requester := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'operator') then
        result.operator := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'view') then
        result.view := ParseCodeableConcept
      else if (json.ItemName = 'deviceName') then
        result.deviceName := ParseString
      else if (json.ItemName = 'height') then
        result.height := ParseInteger
      else if (json.ItemName = 'width') then
        result.width := ParseInteger
      else if (json.ItemName = 'frames') then
        result.frames := ParseInteger
      else if (json.ItemName = 'length') then
        result.length := ParseInteger
      else if (json.ItemName = 'content') then
        result.content := ParseAttachment
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedia(json : TJSONWriter; name : string; elem : TFhirMedia);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeEnum(json, 'type', elem.Type_, CODES_TFhirMediaType);
  ComposeCodeableConcept(json, 'subtype', elem.subtype);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeDateTime(json, 'dateTime', elem.dateTime);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  ComposeResourceReference{TFhirPractitioner}(json, 'requester', elem.requester);
  ComposeResourceReference{TFhirPractitioner}(json, 'operator', elem.operator);
  ComposeCodeableConcept(json, 'view', elem.view);
  ComposeString(json, 'deviceName', elem.deviceName);
  ComposeInteger(json, 'height', elem.height);
  ComposeInteger(json, 'width', elem.width);
  ComposeInteger(json, 'frames', elem.frames);
  ComposeInteger(json, 'length', elem.length);
  ComposeAttachment(json, 'content', elem.content);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationProduct(element : IXmlDomElement) : TFhirMedicationProduct;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationProduct.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'form') then
        result.form := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'ingredient') then
        result.ingredientList.Add(ParseMedicationProductIngredient(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationProduct(xml : TXmlBuilder; name : string; elem : TFhirMedicationProduct);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'form', elem.form);
  for i := 0 to elem.ingredientList.Count - 1 do
    ComposeMedicationProductIngredient(xml, 'ingredient', elem.ingredientList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationProduct : TFhirMedicationProduct;
begin
  json.next;
  result := TFhirMedicationProduct.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'form') then
        result.form := ParseCodeableConcept
      else if (json.ItemName = 'ingredient') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.ingredientList.Add(ParseMedicationProductIngredient);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationProduct(json : TJSONWriter; name : string; elem : TFhirMedicationProduct);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'form', elem.form);
  if elem.ingredientList.Count > 0 then
  begin
    json.valueArray('ingredient');
    for i := 0 to elem.ingredientList.Count - 1 do
      ComposeMedicationProductIngredient(json, '',elem.ingredientList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationProductIngredient(element : IXmlDomElement) : TFhirMedicationProductIngredient;
var
  child : IXMLDOMElement;
  item : IXMLDOMElement;
begin
  result := TFhirMedicationProductIngredient.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'item') then
        result.item := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'amount') then
        result.amount := ParseRatio(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationProductIngredient(xml : TXmlBuilder; name : string; elem : TFhirMedicationProductIngredient);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeResourceReference{Resource}(xml, 'item', elem.item);
  ComposeRatio(xml, 'amount', elem.amount);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationProductIngredient : TFhirMedicationProductIngredient;
begin
  json.next;
  result := TFhirMedicationProductIngredient.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'item') then
        result.item := ParseResourceReference{Resource}
      else if (json.ItemName = 'amount') then
        result.amount := ParseRatio
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationProductIngredient(json : TJSONWriter; name : string; elem : TFhirMedicationProductIngredient);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeResourceReference{Resource}(json, 'item', elem.item);
  ComposeRatio(json, 'amount', elem.amount);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationPackage(element : IXmlDomElement) : TFhirMedicationPackage;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationPackage.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'container') then
        result.container := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'content') then
        result.contentList.Add(ParseMedicationPackageContent(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationPackage(xml : TXmlBuilder; name : string; elem : TFhirMedicationPackage);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'container', elem.container);
  for i := 0 to elem.contentList.Count - 1 do
    ComposeMedicationPackageContent(xml, 'content', elem.contentList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationPackage : TFhirMedicationPackage;
begin
  json.next;
  result := TFhirMedicationPackage.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'container') then
        result.container := ParseCodeableConcept
      else if (json.ItemName = 'content') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.contentList.Add(ParseMedicationPackageContent);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationPackage(json : TJSONWriter; name : string; elem : TFhirMedicationPackage);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'container', elem.container);
  if elem.contentList.Count > 0 then
  begin
    json.valueArray('content');
    for i := 0 to elem.contentList.Count - 1 do
      ComposeMedicationPackageContent(json, '',elem.contentList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationPackageContent(element : IXmlDomElement) : TFhirMedicationPackageContent;
var
  child : IXMLDOMElement;
  item : IXMLDOMElement;
begin
  result := TFhirMedicationPackageContent.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'item') then
        result.item := ParseResourceReference{TFhirMedication}(child) {b}
      else if (child.baseName = 'amount') then
        result.amount := ParseQuantity(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationPackageContent(xml : TXmlBuilder; name : string; elem : TFhirMedicationPackageContent);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeResourceReference{TFhirMedication}(xml, 'item', elem.item);
  ComposeQuantity(xml, 'amount', elem.amount);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationPackageContent : TFhirMedicationPackageContent;
begin
  json.next;
  result := TFhirMedicationPackageContent.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'item') then
        result.item := ParseResourceReference{TFhirMedication}
      else if (json.ItemName = 'amount') then
        result.amount := ParseQuantity
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationPackageContent(json : TJSONWriter; name : string; elem : TFhirMedicationPackageContent);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeResourceReference{TFhirMedication}(json, 'item', elem.item);
  ComposeQuantity(json, 'amount', elem.amount);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedication(element : IXmlDomElement) : TFhirMedication;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedication.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'isBrand') then
        result.isBrand := ParseBoolean(child) {b}
      else if (child.baseName = 'manufacturer') then
        result.manufacturer := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'kind') then
        result.kind := ParseEnum(CODES_TFhirMedicationKind, child)
      else if (child.baseName = 'product') then
        result.product := ParseMedicationProduct(child) {b}
      else if (child.baseName = 'package') then
        result.package := ParseMedicationPackage(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedication(xml : TXmlBuilder; name : string; elem : TFhirMedication);
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeBoolean(xml, 'isBrand', elem.isBrand);
  ComposeResourceReference{TFhirOrganization}(xml, 'manufacturer', elem.manufacturer);
  ComposeEnum(xml, 'kind', elem.Kind, CODES_TFhirMedicationKind);
  ComposeMedicationProduct(xml, 'product', elem.product);
  ComposeMedicationPackage(xml, 'package', elem.package);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedication : TFhirMedication;
begin
  json.next;
  result := TFhirMedication.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'isBrand') then
        result.isBrand := ParseBoolean
      else if (json.ItemName = 'manufacturer') then
        result.manufacturer := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'kind') then
        result.kind := ParseEnum(CODES_TFhirMedicationKind)
      else if (json.ItemName = 'product') then
        result.product := ParseMedicationProduct
      else if (json.ItemName = 'package') then
        result.package := ParseMedicationPackage
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedication(json : TJSONWriter; name : string; elem : TFhirMedication);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeBoolean(json, 'isBrand', elem.isBrand);
  ComposeResourceReference{TFhirOrganization}(json, 'manufacturer', elem.manufacturer);
  ComposeEnum(json, 'kind', elem.Kind, CODES_TFhirMedicationKind);
  ComposeMedicationProduct(json, 'product', elem.product);
  ComposeMedicationPackage(json, 'package', elem.package);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationAdministrationDosage(element : IXmlDomElement) : TFhirMedicationAdministrationDosage;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationAdministrationDosage.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'timing') then
        result.timing := ParseSchedule(child) {b}
      else if (child.baseName = 'site') then
        result.site := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'route') then
        result.route := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'method') then
        result.method := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'quantity') then
        result.quantity := ParseQuantity(child) {b}
      else if (child.baseName = 'rate') then
        result.rate := ParseRatio(child) {b}
      else if (child.baseName = 'maxDosePerPeriod') then
        result.maxDosePerPeriod := ParseRatio(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationAdministrationDosage(xml : TXmlBuilder; name : string; elem : TFhirMedicationAdministrationDosage);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeSchedule(xml, 'timing', elem.timing);
  ComposeCodeableConcept(xml, 'site', elem.site);
  ComposeCodeableConcept(xml, 'route', elem.route);
  ComposeCodeableConcept(xml, 'method', elem.method);
  ComposeQuantity(xml, 'quantity', elem.quantity);
  ComposeRatio(xml, 'rate', elem.rate);
  ComposeRatio(xml, 'maxDosePerPeriod', elem.maxDosePerPeriod);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationAdministrationDosage : TFhirMedicationAdministrationDosage;
begin
  json.next;
  result := TFhirMedicationAdministrationDosage.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'timing') then
        result.timing := ParseSchedule
      else if (json.ItemName = 'site') then
        result.site := ParseCodeableConcept
      else if (json.ItemName = 'route') then
        result.route := ParseCodeableConcept
      else if (json.ItemName = 'method') then
        result.method := ParseCodeableConcept
      else if (json.ItemName = 'quantity') then
        result.quantity := ParseQuantity
      else if (json.ItemName = 'rate') then
        result.rate := ParseRatio
      else if (json.ItemName = 'maxDosePerPeriod') then
        result.maxDosePerPeriod := ParseRatio
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationAdministrationDosage(json : TJSONWriter; name : string; elem : TFhirMedicationAdministrationDosage);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeSchedule(json, 'timing', elem.timing);
  ComposeCodeableConcept(json, 'site', elem.site);
  ComposeCodeableConcept(json, 'route', elem.route);
  ComposeCodeableConcept(json, 'method', elem.method);
  ComposeQuantity(json, 'quantity', elem.quantity);
  ComposeRatio(json, 'rate', elem.rate);
  ComposeRatio(json, 'maxDosePerPeriod', elem.maxDosePerPeriod);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationAdministration(element : IXmlDomElement) : TFhirMedicationAdministration;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationAdministration.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirMedicationAdminStatus, child)
      else if (child.baseName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'practitioner') then
        result.practitioner := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}(child) {b}
      else if (child.baseName = 'prescription') then
        result.prescription := ParseResourceReference{TFhirMedicationPrescription}(child) {b}
      else if (child.baseName = 'wasNotGiven') then
        result.wasNotGiven := ParseBoolean(child) {b}
      else if (child.baseName = 'reasonNotGiven') then
        result.reasonNotGivenList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'whenGiven') then
        result.whenGiven := ParsePeriod(child) {b}
      else if (child.baseName = 'medication') then
        result.medication := ParseResourceReference{TFhirMedication}(child) {b}
      else if (child.baseName = 'administrationDevice') then
        result.administrationDeviceList.Add(ParseResourceReference{TFhirDevice}(child))
      else if (child.baseName = 'dosage') then
        result.dosageList.Add(ParseMedicationAdministrationDosage(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationAdministration(xml : TXmlBuilder; name : string; elem : TFhirMedicationAdministration);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirMedicationAdminStatus);
  ComposeResourceReference{TFhirPatient}(xml, 'patient', elem.patient);
  ComposeResourceReference{TFhirPractitioner}(xml, 'practitioner', elem.practitioner);
  ComposeResourceReference{TFhirEncounter}(xml, 'encounter', elem.encounter);
  ComposeResourceReference{TFhirMedicationPrescription}(xml, 'prescription', elem.prescription);
  ComposeBoolean(xml, 'wasNotGiven', elem.wasNotGiven);
  for i := 0 to elem.reasonNotGivenList.Count - 1 do
    ComposeCodeableConcept(xml, 'reasonNotGiven', elem.reasonNotGivenList[i]);
  ComposePeriod(xml, 'whenGiven', elem.whenGiven);
  ComposeResourceReference{TFhirMedication}(xml, 'medication', elem.medication);
  for i := 0 to elem.administrationDeviceList.Count - 1 do
    ComposeResourceReference{TFhirDevice}(xml, 'administrationDevice', elem.administrationDeviceList[i]);
  for i := 0 to elem.dosageList.Count - 1 do
    ComposeMedicationAdministrationDosage(xml, 'dosage', elem.dosageList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationAdministration : TFhirMedicationAdministration;
begin
  json.next;
  result := TFhirMedicationAdministration.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirMedicationAdminStatus)
      else if (json.ItemName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'practitioner') then
        result.practitioner := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}
      else if (json.ItemName = 'prescription') then
        result.prescription := ParseResourceReference{TFhirMedicationPrescription}
      else if (json.ItemName = 'wasNotGiven') then
        result.wasNotGiven := ParseBoolean
      else if (json.ItemName = 'reasonNotGiven') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.reasonNotGivenList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'whenGiven') then
        result.whenGiven := ParsePeriod
      else if (json.ItemName = 'medication') then
        result.medication := ParseResourceReference{TFhirMedication}
      else if (json.ItemName = 'administrationDevice') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.administrationDeviceList.Add(ParseResourceReference{TFhirDevice});
          json.Next;
        end;
      end
      else if (json.ItemName = 'dosage') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.dosageList.Add(ParseMedicationAdministrationDosage);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationAdministration(json : TJSONWriter; name : string; elem : TFhirMedicationAdministration);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirMedicationAdminStatus);
  ComposeResourceReference{TFhirPatient}(json, 'patient', elem.patient);
  ComposeResourceReference{TFhirPractitioner}(json, 'practitioner', elem.practitioner);
  ComposeResourceReference{TFhirEncounter}(json, 'encounter', elem.encounter);
  ComposeResourceReference{TFhirMedicationPrescription}(json, 'prescription', elem.prescription);
  ComposeBoolean(json, 'wasNotGiven', elem.wasNotGiven);
  if elem.reasonNotGivenList.Count > 0 then
  begin
    json.valueArray('reasonNotGiven');
    for i := 0 to elem.reasonNotGivenList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.reasonNotGivenList[i]);
    json.FinishArray;
  end;
  ComposePeriod(json, 'whenGiven', elem.whenGiven);
  ComposeResourceReference{TFhirMedication}(json, 'medication', elem.medication);
  if elem.administrationDeviceList.Count > 0 then
  begin
    json.valueArray('administrationDevice');
    for i := 0 to elem.administrationDeviceList.Count - 1 do
      ComposeResourceReference{TFhirDevice}(json, '',elem.administrationDeviceList[i]);
    json.FinishArray;
  end;
  if elem.dosageList.Count > 0 then
  begin
    json.valueArray('dosage');
    for i := 0 to elem.dosageList.Count - 1 do
      ComposeMedicationAdministrationDosage(json, '',elem.dosageList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationDispenseDispense(element : IXmlDomElement) : TFhirMedicationDispenseDispense;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationDispenseDispense.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirMedicationDispenseStatus, child)
      else if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'quantity') then
        result.quantity := ParseQuantity(child) {b}
      else if (child.baseName = 'medication') then
        result.medication := ParseResourceReference{TFhirMedication}(child) {b}
      else if (child.baseName = 'whenPrepared') then
        result.whenPrepared := ParsePeriod(child) {b}
      else if (child.baseName = 'whenHandedOver') then
        result.whenHandedOver := ParsePeriod(child) {b}
      else if (child.baseName = 'destination') then
        result.destination := ParseResourceReference{TFhirLocation}(child) {b}
      else if (child.baseName = 'receiver') then
        result.receiverList.Add(ParseResourceReference{TFhirPractitioner}(child))
      else if (child.baseName = 'dosage') then
        result.dosageList.Add(ParseMedicationDispenseDispenseDosage(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationDispenseDispense(xml : TXmlBuilder; name : string; elem : TFhirMedicationDispenseDispense);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirMedicationDispenseStatus);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeQuantity(xml, 'quantity', elem.quantity);
  ComposeResourceReference{TFhirMedication}(xml, 'medication', elem.medication);
  ComposePeriod(xml, 'whenPrepared', elem.whenPrepared);
  ComposePeriod(xml, 'whenHandedOver', elem.whenHandedOver);
  ComposeResourceReference{TFhirLocation}(xml, 'destination', elem.destination);
  for i := 0 to elem.receiverList.Count - 1 do
    ComposeResourceReference{TFhirPractitioner}(xml, 'receiver', elem.receiverList[i]);
  for i := 0 to elem.dosageList.Count - 1 do
    ComposeMedicationDispenseDispenseDosage(xml, 'dosage', elem.dosageList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationDispenseDispense : TFhirMedicationDispenseDispense;
begin
  json.next;
  result := TFhirMedicationDispenseDispense.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirMedicationDispenseStatus)
      else if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'quantity') then
        result.quantity := ParseQuantity
      else if (json.ItemName = 'medication') then
        result.medication := ParseResourceReference{TFhirMedication}
      else if (json.ItemName = 'whenPrepared') then
        result.whenPrepared := ParsePeriod
      else if (json.ItemName = 'whenHandedOver') then
        result.whenHandedOver := ParsePeriod
      else if (json.ItemName = 'destination') then
        result.destination := ParseResourceReference{TFhirLocation}
      else if (json.ItemName = 'receiver') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.receiverList.Add(ParseResourceReference{TFhirPractitioner});
          json.Next;
        end;
      end
      else if (json.ItemName = 'dosage') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.dosageList.Add(ParseMedicationDispenseDispenseDosage);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationDispenseDispense(json : TJSONWriter; name : string; elem : TFhirMedicationDispenseDispense);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirMedicationDispenseStatus);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeQuantity(json, 'quantity', elem.quantity);
  ComposeResourceReference{TFhirMedication}(json, 'medication', elem.medication);
  ComposePeriod(json, 'whenPrepared', elem.whenPrepared);
  ComposePeriod(json, 'whenHandedOver', elem.whenHandedOver);
  ComposeResourceReference{TFhirLocation}(json, 'destination', elem.destination);
  if elem.receiverList.Count > 0 then
  begin
    json.valueArray('receiver');
    for i := 0 to elem.receiverList.Count - 1 do
      ComposeResourceReference{TFhirPractitioner}(json, '',elem.receiverList[i]);
    json.FinishArray;
  end;
  if elem.dosageList.Count > 0 then
  begin
    json.valueArray('dosage');
    for i := 0 to elem.dosageList.Count - 1 do
      ComposeMedicationDispenseDispenseDosage(json, '',elem.dosageList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationDispenseDispenseDosage(element : IXmlDomElement) : TFhirMedicationDispenseDispenseDosage;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationDispenseDispenseDosage.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'additionalInstructionsString') then
        result.additionalInstructions := ParseString(child)
      else if (child.baseName = 'additionalInstructionsCodeableConcept') then
        result.additionalInstructions := ParseCodeableConcept(child)
      else if (child.baseName = 'timingDateTime') then
        result.timing := ParseDateTime(child)
      else if (child.baseName = 'timingPeriod') then
        result.timing := ParsePeriod(child)
      else if (child.baseName = 'timingSchedule') then
        result.timing := ParseSchedule(child)
      else if (child.baseName = 'site') then
        result.site := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'route') then
        result.route := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'method') then
        result.method := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'quantity') then
        result.quantity := ParseQuantity(child) {b}
      else if (child.baseName = 'rate') then
        result.rate := ParseRatio(child) {b}
      else if (child.baseName = 'maxDosePerPeriod') then
        result.maxDosePerPeriod := ParseRatio(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationDispenseDispenseDosage(xml : TXmlBuilder; name : string; elem : TFhirMedicationDispenseDispenseDosage);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  if elem.additionalInstructions is TFhirString {6} then
    ComposeString(xml, 'additionalInstructionsString', TFhirString(elem.additionalInstructions))
  else if elem.additionalInstructions is TFhirCodeableConcept {6} then
    ComposeCodeableConcept(xml, 'additionalInstructionsCodeableConcept', TFhirCodeableConcept(elem.additionalInstructions));
  if elem.timing is TFhirDateTime {6} then
    ComposeDateTime(xml, 'timingDateTime', TFhirDateTime(elem.timing))
  else if elem.timing is TFhirPeriod {6} then
    ComposePeriod(xml, 'timingPeriod', TFhirPeriod(elem.timing))
  else if elem.timing is TFhirSchedule {6} then
    ComposeSchedule(xml, 'timingSchedule', TFhirSchedule(elem.timing));
  ComposeCodeableConcept(xml, 'site', elem.site);
  ComposeCodeableConcept(xml, 'route', elem.route);
  ComposeCodeableConcept(xml, 'method', elem.method);
  ComposeQuantity(xml, 'quantity', elem.quantity);
  ComposeRatio(xml, 'rate', elem.rate);
  ComposeRatio(xml, 'maxDosePerPeriod', elem.maxDosePerPeriod);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationDispenseDispenseDosage : TFhirMedicationDispenseDispenseDosage;
begin
  json.next;
  result := TFhirMedicationDispenseDispenseDosage.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'additionalInstructionsString') then
        result.additionalInstructions := ParseString
      else if (json.ItemName = 'additionalInstructionsCodeableConcept') then
        result.additionalInstructions := ParseCodeableConcept
      else if (json.ItemName = 'timingDateTime') then
        result.timing := ParseDateTime
      else if (json.ItemName = 'timingPeriod') then
        result.timing := ParsePeriod
      else if (json.ItemName = 'timingSchedule') then
        result.timing := ParseSchedule
      else if (json.ItemName = 'site') then
        result.site := ParseCodeableConcept
      else if (json.ItemName = 'route') then
        result.route := ParseCodeableConcept
      else if (json.ItemName = 'method') then
        result.method := ParseCodeableConcept
      else if (json.ItemName = 'quantity') then
        result.quantity := ParseQuantity
      else if (json.ItemName = 'rate') then
        result.rate := ParseRatio
      else if (json.ItemName = 'maxDosePerPeriod') then
        result.maxDosePerPeriod := ParseRatio
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationDispenseDispenseDosage(json : TJSONWriter; name : string; elem : TFhirMedicationDispenseDispenseDosage);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.additionalInstructions is TFhirString then
    ComposeString(json, 'additionalInstructionsString', TFhirString(elem.additionalInstructions))
  else if elem.additionalInstructions is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'additionalInstructionsCodeableConcept', TFhirCodeableConcept(elem.additionalInstructions));
  if elem.timing is TFhirDateTime then
    ComposeDateTime(json, 'timingDateTime', TFhirDateTime(elem.timing))
  else if elem.timing is TFhirPeriod then
    ComposePeriod(json, 'timingPeriod', TFhirPeriod(elem.timing))
  else if elem.timing is TFhirSchedule then
    ComposeSchedule(json, 'timingSchedule', TFhirSchedule(elem.timing));
  ComposeCodeableConcept(json, 'site', elem.site);
  ComposeCodeableConcept(json, 'route', elem.route);
  ComposeCodeableConcept(json, 'method', elem.method);
  ComposeQuantity(json, 'quantity', elem.quantity);
  ComposeRatio(json, 'rate', elem.rate);
  ComposeRatio(json, 'maxDosePerPeriod', elem.maxDosePerPeriod);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationDispenseSubstitution(element : IXmlDomElement) : TFhirMedicationDispenseSubstitution;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationDispenseSubstitution.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'reason') then
        result.reasonList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'responsibleParty') then
        result.responsiblePartyList.Add(ParseResourceReference{TFhirPractitioner}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationDispenseSubstitution(xml : TXmlBuilder; name : string; elem : TFhirMedicationDispenseSubstitution);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  for i := 0 to elem.reasonList.Count - 1 do
    ComposeCodeableConcept(xml, 'reason', elem.reasonList[i]);
  for i := 0 to elem.responsiblePartyList.Count - 1 do
    ComposeResourceReference{TFhirPractitioner}(xml, 'responsibleParty', elem.responsiblePartyList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationDispenseSubstitution : TFhirMedicationDispenseSubstitution;
begin
  json.next;
  result := TFhirMedicationDispenseSubstitution.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'reason') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.reasonList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'responsibleParty') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.responsiblePartyList.Add(ParseResourceReference{TFhirPractitioner});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationDispenseSubstitution(json : TJSONWriter; name : string; elem : TFhirMedicationDispenseSubstitution);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'type', elem.type_);
  if elem.reasonList.Count > 0 then
  begin
    json.valueArray('reason');
    for i := 0 to elem.reasonList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.reasonList[i]);
    json.FinishArray;
  end;
  if elem.responsiblePartyList.Count > 0 then
  begin
    json.valueArray('responsibleParty');
    for i := 0 to elem.responsiblePartyList.Count - 1 do
      ComposeResourceReference{TFhirPractitioner}(json, '',elem.responsiblePartyList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationDispense(element : IXmlDomElement) : TFhirMedicationDispense;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationDispense.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirMedicationDispenseStatus, child)
      else if (child.baseName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'dispenser') then
        result.dispenser := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'authorizingPrescription') then
        result.authorizingPrescriptionList.Add(ParseResourceReference{TFhirMedicationPrescription}(child))
      else if (child.baseName = 'dispense') then
        result.dispenseList.Add(ParseMedicationDispenseDispense(child))
      else if (child.baseName = 'substitution') then
        result.substitution := ParseMedicationDispenseSubstitution(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationDispense(xml : TXmlBuilder; name : string; elem : TFhirMedicationDispense);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirMedicationDispenseStatus);
  ComposeResourceReference{TFhirPatient}(xml, 'patient', elem.patient);
  ComposeResourceReference{TFhirPractitioner}(xml, 'dispenser', elem.dispenser);
  for i := 0 to elem.authorizingPrescriptionList.Count - 1 do
    ComposeResourceReference{TFhirMedicationPrescription}(xml, 'authorizingPrescription', elem.authorizingPrescriptionList[i]);
  for i := 0 to elem.dispenseList.Count - 1 do
    ComposeMedicationDispenseDispense(xml, 'dispense', elem.dispenseList[i]);
  ComposeMedicationDispenseSubstitution(xml, 'substitution', elem.substitution);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationDispense : TFhirMedicationDispense;
begin
  json.next;
  result := TFhirMedicationDispense.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirMedicationDispenseStatus)
      else if (json.ItemName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'dispenser') then
        result.dispenser := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'authorizingPrescription') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.authorizingPrescriptionList.Add(ParseResourceReference{TFhirMedicationPrescription});
          json.Next;
        end;
      end
      else if (json.ItemName = 'dispense') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.dispenseList.Add(ParseMedicationDispenseDispense);
          json.Next;
        end;
      end
      else if (json.ItemName = 'substitution') then
        result.substitution := ParseMedicationDispenseSubstitution
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationDispense(json : TJSONWriter; name : string; elem : TFhirMedicationDispense);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirMedicationDispenseStatus);
  ComposeResourceReference{TFhirPatient}(json, 'patient', elem.patient);
  ComposeResourceReference{TFhirPractitioner}(json, 'dispenser', elem.dispenser);
  if elem.authorizingPrescriptionList.Count > 0 then
  begin
    json.valueArray('authorizingPrescription');
    for i := 0 to elem.authorizingPrescriptionList.Count - 1 do
      ComposeResourceReference{TFhirMedicationPrescription}(json, '',elem.authorizingPrescriptionList[i]);
    json.FinishArray;
  end;
  if elem.dispenseList.Count > 0 then
  begin
    json.valueArray('dispense');
    for i := 0 to elem.dispenseList.Count - 1 do
      ComposeMedicationDispenseDispense(json, '',elem.dispenseList[i]);
    json.FinishArray;
  end;
  ComposeMedicationDispenseSubstitution(json, 'substitution', elem.substitution);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationPrescriptionDosageInstruction(element : IXmlDomElement) : TFhirMedicationPrescriptionDosageInstruction;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationPrescriptionDosageInstruction.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'dosageInstructionsText') then
        result.dosageInstructionsText := ParseString(child) {b}
      else if (child.baseName = 'additionalInstructionsString') then
        result.additionalInstructions := ParseString(child)
      else if (child.baseName = 'additionalInstructionsCodeableConcept') then
        result.additionalInstructions := ParseCodeableConcept(child)
      else if (child.baseName = 'timingDateTime') then
        result.timing := ParseDateTime(child)
      else if (child.baseName = 'timingPeriod') then
        result.timing := ParsePeriod(child)
      else if (child.baseName = 'timingSchedule') then
        result.timing := ParseSchedule(child)
      else if (child.baseName = 'site') then
        result.site := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'route') then
        result.route := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'method') then
        result.method := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'doseQuantity') then
        result.doseQuantity := ParseQuantity(child) {b}
      else if (child.baseName = 'rate') then
        result.rate := ParseRatio(child) {b}
      else if (child.baseName = 'maxDosePerPeriod') then
        result.maxDosePerPeriod := ParseRatio(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationPrescriptionDosageInstruction(xml : TXmlBuilder; name : string; elem : TFhirMedicationPrescriptionDosageInstruction);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'dosageInstructionsText', elem.dosageInstructionsText);
  if elem.additionalInstructions is TFhirString {6} then
    ComposeString(xml, 'additionalInstructionsString', TFhirString(elem.additionalInstructions))
  else if elem.additionalInstructions is TFhirCodeableConcept {6} then
    ComposeCodeableConcept(xml, 'additionalInstructionsCodeableConcept', TFhirCodeableConcept(elem.additionalInstructions));
  if elem.timing is TFhirDateTime {6} then
    ComposeDateTime(xml, 'timingDateTime', TFhirDateTime(elem.timing))
  else if elem.timing is TFhirPeriod {6} then
    ComposePeriod(xml, 'timingPeriod', TFhirPeriod(elem.timing))
  else if elem.timing is TFhirSchedule {6} then
    ComposeSchedule(xml, 'timingSchedule', TFhirSchedule(elem.timing));
  ComposeCodeableConcept(xml, 'site', elem.site);
  ComposeCodeableConcept(xml, 'route', elem.route);
  ComposeCodeableConcept(xml, 'method', elem.method);
  ComposeQuantity(xml, 'doseQuantity', elem.doseQuantity);
  ComposeRatio(xml, 'rate', elem.rate);
  ComposeRatio(xml, 'maxDosePerPeriod', elem.maxDosePerPeriod);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationPrescriptionDosageInstruction : TFhirMedicationPrescriptionDosageInstruction;
begin
  json.next;
  result := TFhirMedicationPrescriptionDosageInstruction.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'dosageInstructionsText') then
        result.dosageInstructionsText := ParseString
      else if (json.ItemName = 'additionalInstructionsString') then
        result.additionalInstructions := ParseString
      else if (json.ItemName = 'additionalInstructionsCodeableConcept') then
        result.additionalInstructions := ParseCodeableConcept
      else if (json.ItemName = 'timingDateTime') then
        result.timing := ParseDateTime
      else if (json.ItemName = 'timingPeriod') then
        result.timing := ParsePeriod
      else if (json.ItemName = 'timingSchedule') then
        result.timing := ParseSchedule
      else if (json.ItemName = 'site') then
        result.site := ParseCodeableConcept
      else if (json.ItemName = 'route') then
        result.route := ParseCodeableConcept
      else if (json.ItemName = 'method') then
        result.method := ParseCodeableConcept
      else if (json.ItemName = 'doseQuantity') then
        result.doseQuantity := ParseQuantity
      else if (json.ItemName = 'rate') then
        result.rate := ParseRatio
      else if (json.ItemName = 'maxDosePerPeriod') then
        result.maxDosePerPeriod := ParseRatio
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationPrescriptionDosageInstruction(json : TJSONWriter; name : string; elem : TFhirMedicationPrescriptionDosageInstruction);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'dosageInstructionsText', elem.dosageInstructionsText);
  if elem.additionalInstructions is TFhirString then
    ComposeString(json, 'additionalInstructionsString', TFhirString(elem.additionalInstructions))
  else if elem.additionalInstructions is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'additionalInstructionsCodeableConcept', TFhirCodeableConcept(elem.additionalInstructions));
  if elem.timing is TFhirDateTime then
    ComposeDateTime(json, 'timingDateTime', TFhirDateTime(elem.timing))
  else if elem.timing is TFhirPeriod then
    ComposePeriod(json, 'timingPeriod', TFhirPeriod(elem.timing))
  else if elem.timing is TFhirSchedule then
    ComposeSchedule(json, 'timingSchedule', TFhirSchedule(elem.timing));
  ComposeCodeableConcept(json, 'site', elem.site);
  ComposeCodeableConcept(json, 'route', elem.route);
  ComposeCodeableConcept(json, 'method', elem.method);
  ComposeQuantity(json, 'doseQuantity', elem.doseQuantity);
  ComposeRatio(json, 'rate', elem.rate);
  ComposeRatio(json, 'maxDosePerPeriod', elem.maxDosePerPeriod);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationPrescriptionDispense(element : IXmlDomElement) : TFhirMedicationPrescriptionDispense;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationPrescriptionDispense.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'medication') then
        result.medication := ParseResourceReference{TFhirMedication}(child) {b}
      else if (child.baseName = 'validityPeriod') then
        result.validityPeriod := ParsePeriod(child) {b}
      else if (child.baseName = 'numberOfRepeatsAllowed') then
        result.numberOfRepeatsAllowed := ParseInteger(child) {b}
      else if (child.baseName = 'quantity') then
        result.quantity := ParseQuantity(child) {b}
      else if (child.baseName = 'expectedSupplyDuration') then
        result.expectedSupplyDuration := ParseQuantity(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationPrescriptionDispense(xml : TXmlBuilder; name : string; elem : TFhirMedicationPrescriptionDispense);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeResourceReference{TFhirMedication}(xml, 'medication', elem.medication);
  ComposePeriod(xml, 'validityPeriod', elem.validityPeriod);
  ComposeInteger(xml, 'numberOfRepeatsAllowed', elem.numberOfRepeatsAllowed);
  ComposeQuantity(xml, 'quantity', elem.quantity);
  ComposeQuantity(xml, 'expectedSupplyDuration', elem.expectedSupplyDuration);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationPrescriptionDispense : TFhirMedicationPrescriptionDispense;
begin
  json.next;
  result := TFhirMedicationPrescriptionDispense.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'medication') then
        result.medication := ParseResourceReference{TFhirMedication}
      else if (json.ItemName = 'validityPeriod') then
        result.validityPeriod := ParsePeriod
      else if (json.ItemName = 'numberOfRepeatsAllowed') then
        result.numberOfRepeatsAllowed := ParseInteger
      else if (json.ItemName = 'quantity') then
        result.quantity := ParseQuantity
      else if (json.ItemName = 'expectedSupplyDuration') then
        result.expectedSupplyDuration := ParseQuantity
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationPrescriptionDispense(json : TJSONWriter; name : string; elem : TFhirMedicationPrescriptionDispense);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeResourceReference{TFhirMedication}(json, 'medication', elem.medication);
  ComposePeriod(json, 'validityPeriod', elem.validityPeriod);
  ComposeInteger(json, 'numberOfRepeatsAllowed', elem.numberOfRepeatsAllowed);
  ComposeQuantity(json, 'quantity', elem.quantity);
  ComposeQuantity(json, 'expectedSupplyDuration', elem.expectedSupplyDuration);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationPrescriptionSubstitution(element : IXmlDomElement) : TFhirMedicationPrescriptionSubstitution;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationPrescriptionSubstitution.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'reason') then
        result.reason := ParseCodeableConcept(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationPrescriptionSubstitution(xml : TXmlBuilder; name : string; elem : TFhirMedicationPrescriptionSubstitution);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeCodeableConcept(xml, 'reason', elem.reason);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationPrescriptionSubstitution : TFhirMedicationPrescriptionSubstitution;
begin
  json.next;
  result := TFhirMedicationPrescriptionSubstitution.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'reason') then
        result.reason := ParseCodeableConcept
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationPrescriptionSubstitution(json : TJSONWriter; name : string; elem : TFhirMedicationPrescriptionSubstitution);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeCodeableConcept(json, 'reason', elem.reason);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationPrescription(element : IXmlDomElement) : TFhirMedicationPrescription;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationPrescription.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'dateWritten') then
        result.dateWritten := ParseDateTime(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirMedicationPrescriptionStatus, child)
      else if (child.baseName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'prescriber') then
        result.prescriber := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}(child) {b}
      else if (child.baseName = 'reasonForPrescribingString') then
        result.reasonForPrescribing := ParseString(child)
      else if (child.baseName = 'reasonForPrescribingCodeableConcept') then
        result.reasonForPrescribing := ParseCodeableConcept(child)
      else if (child.baseName = 'medication') then
        result.medication := ParseResourceReference{TFhirMedication}(child) {b}
      else if (child.baseName = 'dosageInstruction') then
        result.dosageInstructionList.Add(ParseMedicationPrescriptionDosageInstruction(child))
      else if (child.baseName = 'dispense') then
        result.dispense := ParseMedicationPrescriptionDispense(child) {b}
      else if (child.baseName = 'substitution') then
        result.substitution := ParseMedicationPrescriptionSubstitution(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationPrescription(xml : TXmlBuilder; name : string; elem : TFhirMedicationPrescription);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeDateTime(xml, 'dateWritten', elem.dateWritten);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirMedicationPrescriptionStatus);
  ComposeResourceReference{TFhirPatient}(xml, 'patient', elem.patient);
  ComposeResourceReference{TFhirPractitioner}(xml, 'prescriber', elem.prescriber);
  ComposeResourceReference{TFhirEncounter}(xml, 'encounter', elem.encounter);
  if elem.reasonForPrescribing is TFhirString {6} then
    ComposeString(xml, 'reasonForPrescribingString', TFhirString(elem.reasonForPrescribing))
  else if elem.reasonForPrescribing is TFhirCodeableConcept {6} then
    ComposeCodeableConcept(xml, 'reasonForPrescribingCodeableConcept', TFhirCodeableConcept(elem.reasonForPrescribing));
  ComposeResourceReference{TFhirMedication}(xml, 'medication', elem.medication);
  for i := 0 to elem.dosageInstructionList.Count - 1 do
    ComposeMedicationPrescriptionDosageInstruction(xml, 'dosageInstruction', elem.dosageInstructionList[i]);
  ComposeMedicationPrescriptionDispense(xml, 'dispense', elem.dispense);
  ComposeMedicationPrescriptionSubstitution(xml, 'substitution', elem.substitution);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationPrescription : TFhirMedicationPrescription;
begin
  json.next;
  result := TFhirMedicationPrescription.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'dateWritten') then
        result.dateWritten := ParseDateTime
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirMedicationPrescriptionStatus)
      else if (json.ItemName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'prescriber') then
        result.prescriber := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}
      else if (json.ItemName = 'reasonForPrescribingString') then
        result.reasonForPrescribing := ParseString
      else if (json.ItemName = 'reasonForPrescribingCodeableConcept') then
        result.reasonForPrescribing := ParseCodeableConcept
      else if (json.ItemName = 'medication') then
        result.medication := ParseResourceReference{TFhirMedication}
      else if (json.ItemName = 'dosageInstruction') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.dosageInstructionList.Add(ParseMedicationPrescriptionDosageInstruction);
          json.Next;
        end;
      end
      else if (json.ItemName = 'dispense') then
        result.dispense := ParseMedicationPrescriptionDispense
      else if (json.ItemName = 'substitution') then
        result.substitution := ParseMedicationPrescriptionSubstitution
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationPrescription(json : TJSONWriter; name : string; elem : TFhirMedicationPrescription);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeDateTime(json, 'dateWritten', elem.dateWritten);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirMedicationPrescriptionStatus);
  ComposeResourceReference{TFhirPatient}(json, 'patient', elem.patient);
  ComposeResourceReference{TFhirPractitioner}(json, 'prescriber', elem.prescriber);
  ComposeResourceReference{TFhirEncounter}(json, 'encounter', elem.encounter);
  if elem.reasonForPrescribing is TFhirString then
    ComposeString(json, 'reasonForPrescribingString', TFhirString(elem.reasonForPrescribing))
  else if elem.reasonForPrescribing is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'reasonForPrescribingCodeableConcept', TFhirCodeableConcept(elem.reasonForPrescribing));
  ComposeResourceReference{TFhirMedication}(json, 'medication', elem.medication);
  if elem.dosageInstructionList.Count > 0 then
  begin
    json.valueArray('dosageInstruction');
    for i := 0 to elem.dosageInstructionList.Count - 1 do
      ComposeMedicationPrescriptionDosageInstruction(json, '',elem.dosageInstructionList[i]);
    json.FinishArray;
  end;
  ComposeMedicationPrescriptionDispense(json, 'dispense', elem.dispense);
  ComposeMedicationPrescriptionSubstitution(json, 'substitution', elem.substitution);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationStatementDosage(element : IXmlDomElement) : TFhirMedicationStatementDosage;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationStatementDosage.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'timing') then
        result.timing := ParseSchedule(child) {b}
      else if (child.baseName = 'site') then
        result.site := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'route') then
        result.route := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'method') then
        result.method := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'quantity') then
        result.quantity := ParseQuantity(child) {b}
      else if (child.baseName = 'rate') then
        result.rate := ParseRatio(child) {b}
      else if (child.baseName = 'maxDosePerPeriod') then
        result.maxDosePerPeriod := ParseRatio(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationStatementDosage(xml : TXmlBuilder; name : string; elem : TFhirMedicationStatementDosage);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeSchedule(xml, 'timing', elem.timing);
  ComposeCodeableConcept(xml, 'site', elem.site);
  ComposeCodeableConcept(xml, 'route', elem.route);
  ComposeCodeableConcept(xml, 'method', elem.method);
  ComposeQuantity(xml, 'quantity', elem.quantity);
  ComposeRatio(xml, 'rate', elem.rate);
  ComposeRatio(xml, 'maxDosePerPeriod', elem.maxDosePerPeriod);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationStatementDosage : TFhirMedicationStatementDosage;
begin
  json.next;
  result := TFhirMedicationStatementDosage.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'timing') then
        result.timing := ParseSchedule
      else if (json.ItemName = 'site') then
        result.site := ParseCodeableConcept
      else if (json.ItemName = 'route') then
        result.route := ParseCodeableConcept
      else if (json.ItemName = 'method') then
        result.method := ParseCodeableConcept
      else if (json.ItemName = 'quantity') then
        result.quantity := ParseQuantity
      else if (json.ItemName = 'rate') then
        result.rate := ParseRatio
      else if (json.ItemName = 'maxDosePerPeriod') then
        result.maxDosePerPeriod := ParseRatio
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationStatementDosage(json : TJSONWriter; name : string; elem : TFhirMedicationStatementDosage);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeSchedule(json, 'timing', elem.timing);
  ComposeCodeableConcept(json, 'site', elem.site);
  ComposeCodeableConcept(json, 'route', elem.route);
  ComposeCodeableConcept(json, 'method', elem.method);
  ComposeQuantity(json, 'quantity', elem.quantity);
  ComposeRatio(json, 'rate', elem.rate);
  ComposeRatio(json, 'maxDosePerPeriod', elem.maxDosePerPeriod);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMedicationStatement(element : IXmlDomElement) : TFhirMedicationStatement;
var
  child : IXMLDOMElement;
begin
  result := TFhirMedicationStatement.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'wasNotGiven') then
        result.wasNotGiven := ParseBoolean(child) {b}
      else if (child.baseName = 'reasonNotGiven') then
        result.reasonNotGivenList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'whenGiven') then
        result.whenGiven := ParsePeriod(child) {b}
      else if (child.baseName = 'medication') then
        result.medication := ParseResourceReference{TFhirMedication}(child) {b}
      else if (child.baseName = 'administrationDevice') then
        result.administrationDeviceList.Add(ParseResourceReference{TFhirDevice}(child))
      else if (child.baseName = 'dosage') then
        result.dosageList.Add(ParseMedicationStatementDosage(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMedicationStatement(xml : TXmlBuilder; name : string; elem : TFhirMedicationStatement);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeResourceReference{TFhirPatient}(xml, 'patient', elem.patient);
  ComposeBoolean(xml, 'wasNotGiven', elem.wasNotGiven);
  for i := 0 to elem.reasonNotGivenList.Count - 1 do
    ComposeCodeableConcept(xml, 'reasonNotGiven', elem.reasonNotGivenList[i]);
  ComposePeriod(xml, 'whenGiven', elem.whenGiven);
  ComposeResourceReference{TFhirMedication}(xml, 'medication', elem.medication);
  for i := 0 to elem.administrationDeviceList.Count - 1 do
    ComposeResourceReference{TFhirDevice}(xml, 'administrationDevice', elem.administrationDeviceList[i]);
  for i := 0 to elem.dosageList.Count - 1 do
    ComposeMedicationStatementDosage(xml, 'dosage', elem.dosageList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMedicationStatement : TFhirMedicationStatement;
begin
  json.next;
  result := TFhirMedicationStatement.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'wasNotGiven') then
        result.wasNotGiven := ParseBoolean
      else if (json.ItemName = 'reasonNotGiven') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.reasonNotGivenList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'whenGiven') then
        result.whenGiven := ParsePeriod
      else if (json.ItemName = 'medication') then
        result.medication := ParseResourceReference{TFhirMedication}
      else if (json.ItemName = 'administrationDevice') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.administrationDeviceList.Add(ParseResourceReference{TFhirDevice});
          json.Next;
        end;
      end
      else if (json.ItemName = 'dosage') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.dosageList.Add(ParseMedicationStatementDosage);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMedicationStatement(json : TJSONWriter; name : string; elem : TFhirMedicationStatement);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirPatient}(json, 'patient', elem.patient);
  ComposeBoolean(json, 'wasNotGiven', elem.wasNotGiven);
  if elem.reasonNotGivenList.Count > 0 then
  begin
    json.valueArray('reasonNotGiven');
    for i := 0 to elem.reasonNotGivenList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.reasonNotGivenList[i]);
    json.FinishArray;
  end;
  ComposePeriod(json, 'whenGiven', elem.whenGiven);
  ComposeResourceReference{TFhirMedication}(json, 'medication', elem.medication);
  if elem.administrationDeviceList.Count > 0 then
  begin
    json.valueArray('administrationDevice');
    for i := 0 to elem.administrationDeviceList.Count - 1 do
      ComposeResourceReference{TFhirDevice}(json, '',elem.administrationDeviceList[i]);
    json.FinishArray;
  end;
  if elem.dosageList.Count > 0 then
  begin
    json.valueArray('dosage');
    for i := 0 to elem.dosageList.Count - 1 do
      ComposeMedicationStatementDosage(json, '',elem.dosageList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseMessageResponse(element : IXmlDomElement) : TFhirMessageResponse;
var
  child : IXMLDOMElement;
begin
  result := TFhirMessageResponse.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseId(child) {b}
      else if (child.baseName = 'code') then
        result.code := ParseEnum(CODES_TFhirResponseCode, child)
      else if (child.baseName = 'details') then
        result.details := ParseResourceReference{TFhirOperationOutcome}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMessageResponse(xml : TXmlBuilder; name : string; elem : TFhirMessageResponse);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeId(xml, 'identifier', elem.identifier);
  ComposeEnum(xml, 'code', elem.Code, CODES_TFhirResponseCode);
  ComposeResourceReference{TFhirOperationOutcome}(xml, 'details', elem.details);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMessageResponse : TFhirMessageResponse;
begin
  json.next;
  result := TFhirMessageResponse.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseId
      else if (json.ItemName = 'code') then
        result.code := ParseEnum(CODES_TFhirResponseCode)
      else if (json.ItemName = 'details') then
        result.details := ParseResourceReference{TFhirOperationOutcome}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMessageResponse(json : TJSONWriter; name : string; elem : TFhirMessageResponse);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeId(json, 'identifier', elem.identifier);
  ComposeEnum(json, 'code', elem.Code, CODES_TFhirResponseCode);
  ComposeResourceReference{TFhirOperationOutcome}(json, 'details', elem.details);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMessageSource(element : IXmlDomElement) : TFhirMessageSource;
var
  child : IXMLDOMElement;
begin
  result := TFhirMessageSource.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'software') then
        result.software := ParseString(child) {b}
      else if (child.baseName = 'version') then
        result.version := ParseString(child) {b}
      else if (child.baseName = 'contact') then
        result.contact := ParseContact(child) {b}
      else if (child.baseName = 'endpoint') then
        result.endpoint := ParseUri(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMessageSource(xml : TXmlBuilder; name : string; elem : TFhirMessageSource);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeString(xml, 'software', elem.software);
  ComposeString(xml, 'version', elem.version);
  ComposeContact(xml, 'contact', elem.contact);
  ComposeUri(xml, 'endpoint', elem.endpoint);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMessageSource : TFhirMessageSource;
begin
  json.next;
  result := TFhirMessageSource.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'software') then
        result.software := ParseString
      else if (json.ItemName = 'version') then
        result.version := ParseString
      else if (json.ItemName = 'contact') then
        result.contact := ParseContact
      else if (json.ItemName = 'endpoint') then
        result.endpoint := ParseUri
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMessageSource(json : TJSONWriter; name : string; elem : TFhirMessageSource);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeString(json, 'software', elem.software);
  ComposeString(json, 'version', elem.version);
  ComposeContact(json, 'contact', elem.contact);
  ComposeUri(json, 'endpoint', elem.endpoint);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMessageDestination(element : IXmlDomElement) : TFhirMessageDestination;
var
  child : IXMLDOMElement;
begin
  result := TFhirMessageDestination.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'target') then
        result.target := ParseResourceReference{TFhirDevice}(child) {b}
      else if (child.baseName = 'endpoint') then
        result.endpoint := ParseUri(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMessageDestination(xml : TXmlBuilder; name : string; elem : TFhirMessageDestination);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeResourceReference{TFhirDevice}(xml, 'target', elem.target);
  ComposeUri(xml, 'endpoint', elem.endpoint);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMessageDestination : TFhirMessageDestination;
begin
  json.next;
  result := TFhirMessageDestination.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'target') then
        result.target := ParseResourceReference{TFhirDevice}
      else if (json.ItemName = 'endpoint') then
        result.endpoint := ParseUri
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMessageDestination(json : TJSONWriter; name : string; elem : TFhirMessageDestination);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeResourceReference{TFhirDevice}(json, 'target', elem.target);
  ComposeUri(json, 'endpoint', elem.endpoint);
  json.finishObject;
end;

function TFHIRXmlParser.ParseMessage(element : IXmlDomElement) : TFhirMessage;
var
  child : IXMLDOMElement;
begin
  result := TFhirMessage.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseId(child) {b}
      else if (child.baseName = 'timestamp') then
        result.timestamp := ParseInstant(child) {b}
      else if (child.baseName = 'event') then
        result.event := ParseCode(child) {b}
      else if (child.baseName = 'response') then
        result.response := ParseMessageResponse(child) {b}
      else if (child.baseName = 'source') then
        result.source := ParseMessageSource(child) {b}
      else if (child.baseName = 'destination') then
        result.destination := ParseMessageDestination(child) {b}
      else if (child.baseName = 'enterer') then
        result.enterer := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'author') then
        result.author := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'receiver') then
        result.receiver := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'responsible') then
        result.responsible := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'effective') then
        result.effective := ParsePeriod(child) {b}
      else if (child.baseName = 'reason') then
        result.reason := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'data') then
        result.dataList.Add(ParseResourceReference{Resource}(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeMessage(xml : TXmlBuilder; name : string; elem : TFhirMessage);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeId(xml, 'identifier', elem.identifier);
  ComposeInstant(xml, 'timestamp', elem.timestamp);
  ComposeCode(xml, 'event', elem.event);
  ComposeMessageResponse(xml, 'response', elem.response);
  ComposeMessageSource(xml, 'source', elem.source);
  ComposeMessageDestination(xml, 'destination', elem.destination);
  ComposeResourceReference{TFhirPractitioner}(xml, 'enterer', elem.enterer);
  ComposeResourceReference{TFhirPractitioner}(xml, 'author', elem.author);
  ComposeResourceReference{Resource}(xml, 'receiver', elem.receiver);
  ComposeResourceReference{Resource}(xml, 'responsible', elem.responsible);
  ComposePeriod(xml, 'effective', elem.effective);
  ComposeCodeableConcept(xml, 'reason', elem.reason);
  for i := 0 to elem.dataList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'data', elem.dataList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseMessage : TFhirMessage;
begin
  json.next;
  result := TFhirMessage.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseId
      else if (json.ItemName = 'timestamp') then
        result.timestamp := ParseInstant
      else if (json.ItemName = 'event') then
        result.event := ParseCode
      else if (json.ItemName = 'response') then
        result.response := ParseMessageResponse
      else if (json.ItemName = 'source') then
        result.source := ParseMessageSource
      else if (json.ItemName = 'destination') then
        result.destination := ParseMessageDestination
      else if (json.ItemName = 'enterer') then
        result.enterer := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'author') then
        result.author := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'receiver') then
        result.receiver := ParseResourceReference{Resource}
      else if (json.ItemName = 'responsible') then
        result.responsible := ParseResourceReference{Resource}
      else if (json.ItemName = 'effective') then
        result.effective := ParsePeriod
      else if (json.ItemName = 'reason') then
        result.reason := ParseCodeableConcept
      else if (json.ItemName = 'data') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.dataList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeMessage(json : TJSONWriter; name : string; elem : TFhirMessage);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeId(json, 'identifier', elem.identifier);
  ComposeInstant(json, 'timestamp', elem.timestamp);
  ComposeCode(json, 'event', elem.event);
  ComposeMessageResponse(json, 'response', elem.response);
  ComposeMessageSource(json, 'source', elem.source);
  ComposeMessageDestination(json, 'destination', elem.destination);
  ComposeResourceReference{TFhirPractitioner}(json, 'enterer', elem.enterer);
  ComposeResourceReference{TFhirPractitioner}(json, 'author', elem.author);
  ComposeResourceReference{Resource}(json, 'receiver', elem.receiver);
  ComposeResourceReference{Resource}(json, 'responsible', elem.responsible);
  ComposePeriod(json, 'effective', elem.effective);
  ComposeCodeableConcept(json, 'reason', elem.reason);
  if elem.dataList.Count > 0 then
  begin
    json.valueArray('data');
    for i := 0 to elem.dataList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.dataList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseObservationReferenceRange(element : IXmlDomElement) : TFhirObservationReferenceRange;
var
  child : IXMLDOMElement;
begin
  result := TFhirObservationReferenceRange.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'meaning') then
        result.meaning := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'rangeQuantity') then
        result.range := ParseQuantity(child)
      else if (child.baseName = 'rangeRange') then
        result.range := ParseRange(child)
      else if (child.baseName = 'rangeString') then
        result.range := ParseString(child)
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeObservationReferenceRange(xml : TXmlBuilder; name : string; elem : TFhirObservationReferenceRange);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'meaning', elem.meaning);
  if elem.range is TFhirQuantity {6} then
    ComposeQuantity(xml, 'rangeQuantity', TFhirQuantity(elem.range))
  else if elem.range is TFhirRange {6} then
    ComposeRange(xml, 'rangeRange', TFhirRange(elem.range))
  else if elem.range is TFhirString {6} then
    ComposeString(xml, 'rangeString', TFhirString(elem.range));
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseObservationReferenceRange : TFhirObservationReferenceRange;
begin
  json.next;
  result := TFhirObservationReferenceRange.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'meaning') then
        result.meaning := ParseCodeableConcept
      else if (json.ItemName = 'rangeQuantity') then
        result.range := ParseQuantity
      else if (json.ItemName = 'rangeRange') then
        result.range := ParseRange
      else if (json.ItemName = 'rangeString') then
        result.range := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeObservationReferenceRange(json : TJSONWriter; name : string; elem : TFhirObservationReferenceRange);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'meaning', elem.meaning);
  if elem.range is TFhirQuantity then
    ComposeQuantity(json, 'rangeQuantity', TFhirQuantity(elem.range))
  else if elem.range is TFhirRange then
    ComposeRange(json, 'rangeRange', TFhirRange(elem.range))
  else if elem.range is TFhirString then
    ComposeString(json, 'rangeString', TFhirString(elem.range));
  json.finishObject;
end;

function TFHIRXmlParser.ParseObservationComponent(element : IXmlDomElement) : TFhirObservationComponent;
var
  child : IXMLDOMElement;
begin
  result := TFhirObservationComponent.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'valueQuantity') then
        result.value := ParseQuantity(child)
      else if (child.baseName = 'valueCodeableConcept') then
        result.value := ParseCodeableConcept(child)
      else if (child.baseName = 'valueAttachment') then
        result.value := ParseAttachment(child)
      else if (child.baseName = 'valueRatio') then
        result.value := ParseRatio(child)
      else if (child.baseName = 'valueChoice') then
        result.value := ParseChoice(child)
      else if (child.baseName = 'valuePeriod') then
        result.value := ParsePeriod(child)
      else if (child.baseName = 'valueSampledData') then
        result.value := ParseSampledData(child)
      else if (child.baseName = 'valueString') then
        result.value := ParseString(child)
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeObservationComponent(xml : TXmlBuilder; name : string; elem : TFhirObservationComponent);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'name', elem.name);
  if elem.value is TFhirQuantity {6} then
    ComposeQuantity(xml, 'valueQuantity', TFhirQuantity(elem.value))
  else if elem.value is TFhirCodeableConcept {6} then
    ComposeCodeableConcept(xml, 'valueCodeableConcept', TFhirCodeableConcept(elem.value))
  else if elem.value is TFhirAttachment {6} then
    ComposeAttachment(xml, 'valueAttachment', TFhirAttachment(elem.value))
  else if elem.value is TFhirRatio {6} then
    ComposeRatio(xml, 'valueRatio', TFhirRatio(elem.value))
  else if elem.value is TFhirChoice {6} then
    ComposeChoice(xml, 'valueChoice', TFhirChoice(elem.value))
  else if elem.value is TFhirPeriod {6} then
    ComposePeriod(xml, 'valuePeriod', TFhirPeriod(elem.value))
  else if elem.value is TFhirSampledData {6} then
    ComposeSampledData(xml, 'valueSampledData', TFhirSampledData(elem.value))
  else if elem.value is TFhirString {6} then
    ComposeString(xml, 'valueString', TFhirString(elem.value));
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseObservationComponent : TFhirObservationComponent;
begin
  json.next;
  result := TFhirObservationComponent.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseCodeableConcept
      else if (json.ItemName = 'valueQuantity') then
        result.value := ParseQuantity
      else if (json.ItemName = 'valueCodeableConcept') then
        result.value := ParseCodeableConcept
      else if (json.ItemName = 'valueAttachment') then
        result.value := ParseAttachment
      else if (json.ItemName = 'valueRatio') then
        result.value := ParseRatio
      else if (json.ItemName = 'valueChoice') then
        result.value := ParseChoice
      else if (json.ItemName = 'valuePeriod') then
        result.value := ParsePeriod
      else if (json.ItemName = 'valueSampledData') then
        result.value := ParseSampledData
      else if (json.ItemName = 'valueString') then
        result.value := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeObservationComponent(json : TJSONWriter; name : string; elem : TFhirObservationComponent);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'name', elem.name);
  if elem.value is TFhirQuantity then
    ComposeQuantity(json, 'valueQuantity', TFhirQuantity(elem.value))
  else if elem.value is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'valueCodeableConcept', TFhirCodeableConcept(elem.value))
  else if elem.value is TFhirAttachment then
    ComposeAttachment(json, 'valueAttachment', TFhirAttachment(elem.value))
  else if elem.value is TFhirRatio then
    ComposeRatio(json, 'valueRatio', TFhirRatio(elem.value))
  else if elem.value is TFhirChoice then
    ComposeChoice(json, 'valueChoice', TFhirChoice(elem.value))
  else if elem.value is TFhirPeriod then
    ComposePeriod(json, 'valuePeriod', TFhirPeriod(elem.value))
  else if elem.value is TFhirSampledData then
    ComposeSampledData(json, 'valueSampledData', TFhirSampledData(elem.value))
  else if elem.value is TFhirString then
    ComposeString(json, 'valueString', TFhirString(elem.value));
  json.finishObject;
end;

function TFHIRXmlParser.ParseObservation(element : IXmlDomElement) : TFhirObservation;
var
  child : IXMLDOMElement;
begin
  result := TFhirObservation.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'valueQuantity') then
        result.value := ParseQuantity(child)
      else if (child.baseName = 'valueCodeableConcept') then
        result.value := ParseCodeableConcept(child)
      else if (child.baseName = 'valueAttachment') then
        result.value := ParseAttachment(child)
      else if (child.baseName = 'valueRatio') then
        result.value := ParseRatio(child)
      else if (child.baseName = 'valueChoice') then
        result.value := ParseChoice(child)
      else if (child.baseName = 'valuePeriod') then
        result.value := ParsePeriod(child)
      else if (child.baseName = 'valueSampledData') then
        result.value := ParseSampledData(child)
      else if (child.baseName = 'valueString') then
        result.value := ParseString(child)
      else if (child.baseName = 'interpretation') then
        result.interpretation := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'comments') then
        result.comments := ParseString(child) {b}
      else if (child.baseName = 'appliesPeriod') then
        result.applies := ParsePeriod(child)
      else if (child.baseName = 'appliesDateTime') then
        result.applies := ParseDateTime(child)
      else if (child.baseName = 'issued') then
        result.issued := ParseInstant(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirObservationStatus, child)
      else if (child.baseName = 'reliability') then
        result.reliability := ParseEnum(CODES_TFhirObservationReliability, child)
      else if (child.baseName = 'bodySite') then
        result.bodySite := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'method') then
        result.method := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'performer') then
        result.performer := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'referenceRange') then
        result.referenceRangeList.Add(ParseObservationReferenceRange(child))
      else if (child.baseName = 'component') then
        result.componentList.Add(ParseObservationComponent(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeObservation(xml : TXmlBuilder; name : string; elem : TFhirObservation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeCodeableConcept(xml, 'name', elem.name);
  if elem.value is TFhirQuantity {6} then
    ComposeQuantity(xml, 'valueQuantity', TFhirQuantity(elem.value))
  else if elem.value is TFhirCodeableConcept {6} then
    ComposeCodeableConcept(xml, 'valueCodeableConcept', TFhirCodeableConcept(elem.value))
  else if elem.value is TFhirAttachment {6} then
    ComposeAttachment(xml, 'valueAttachment', TFhirAttachment(elem.value))
  else if elem.value is TFhirRatio {6} then
    ComposeRatio(xml, 'valueRatio', TFhirRatio(elem.value))
  else if elem.value is TFhirChoice {6} then
    ComposeChoice(xml, 'valueChoice', TFhirChoice(elem.value))
  else if elem.value is TFhirPeriod {6} then
    ComposePeriod(xml, 'valuePeriod', TFhirPeriod(elem.value))
  else if elem.value is TFhirSampledData {6} then
    ComposeSampledData(xml, 'valueSampledData', TFhirSampledData(elem.value))
  else if elem.value is TFhirString {6} then
    ComposeString(xml, 'valueString', TFhirString(elem.value));
  ComposeCodeableConcept(xml, 'interpretation', elem.interpretation);
  ComposeString(xml, 'comments', elem.comments);
  if elem.applies is TFhirPeriod {6} then
    ComposePeriod(xml, 'appliesPeriod', TFhirPeriod(elem.applies))
  else if elem.applies is TFhirDateTime {6} then
    ComposeDateTime(xml, 'appliesDateTime', TFhirDateTime(elem.applies));
  ComposeInstant(xml, 'issued', elem.issued);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirObservationStatus);
  ComposeEnum(xml, 'reliability', elem.Reliability, CODES_TFhirObservationReliability);
  ComposeCodeableConcept(xml, 'bodySite', elem.bodySite);
  ComposeCodeableConcept(xml, 'method', elem.method);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  ComposeResourceReference{Resource}(xml, 'performer', elem.performer);
  for i := 0 to elem.referenceRangeList.Count - 1 do
    ComposeObservationReferenceRange(xml, 'referenceRange', elem.referenceRangeList[i]);
  for i := 0 to elem.componentList.Count - 1 do
    ComposeObservationComponent(xml, 'component', elem.componentList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseObservation : TFhirObservation;
begin
  json.next;
  result := TFhirObservation.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseCodeableConcept
      else if (json.ItemName = 'valueQuantity') then
        result.value := ParseQuantity
      else if (json.ItemName = 'valueCodeableConcept') then
        result.value := ParseCodeableConcept
      else if (json.ItemName = 'valueAttachment') then
        result.value := ParseAttachment
      else if (json.ItemName = 'valueRatio') then
        result.value := ParseRatio
      else if (json.ItemName = 'valueChoice') then
        result.value := ParseChoice
      else if (json.ItemName = 'valuePeriod') then
        result.value := ParsePeriod
      else if (json.ItemName = 'valueSampledData') then
        result.value := ParseSampledData
      else if (json.ItemName = 'valueString') then
        result.value := ParseString
      else if (json.ItemName = 'interpretation') then
        result.interpretation := ParseCodeableConcept
      else if (json.ItemName = 'comments') then
        result.comments := ParseString
      else if (json.ItemName = 'appliesPeriod') then
        result.applies := ParsePeriod
      else if (json.ItemName = 'appliesDateTime') then
        result.applies := ParseDateTime
      else if (json.ItemName = 'issued') then
        result.issued := ParseInstant
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirObservationStatus)
      else if (json.ItemName = 'reliability') then
        result.reliability := ParseEnum(CODES_TFhirObservationReliability)
      else if (json.ItemName = 'bodySite') then
        result.bodySite := ParseCodeableConcept
      else if (json.ItemName = 'method') then
        result.method := ParseCodeableConcept
      else if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'performer') then
        result.performer := ParseResourceReference{Resource}
      else if (json.ItemName = 'referenceRange') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.referenceRangeList.Add(ParseObservationReferenceRange);
          json.Next;
        end;
      end
      else if (json.ItemName = 'component') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.componentList.Add(ParseObservationComponent);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeObservation(json : TJSONWriter; name : string; elem : TFhirObservation);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeCodeableConcept(json, 'name', elem.name);
  if elem.value is TFhirQuantity then
    ComposeQuantity(json, 'valueQuantity', TFhirQuantity(elem.value))
  else if elem.value is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'valueCodeableConcept', TFhirCodeableConcept(elem.value))
  else if elem.value is TFhirAttachment then
    ComposeAttachment(json, 'valueAttachment', TFhirAttachment(elem.value))
  else if elem.value is TFhirRatio then
    ComposeRatio(json, 'valueRatio', TFhirRatio(elem.value))
  else if elem.value is TFhirChoice then
    ComposeChoice(json, 'valueChoice', TFhirChoice(elem.value))
  else if elem.value is TFhirPeriod then
    ComposePeriod(json, 'valuePeriod', TFhirPeriod(elem.value))
  else if elem.value is TFhirSampledData then
    ComposeSampledData(json, 'valueSampledData', TFhirSampledData(elem.value))
  else if elem.value is TFhirString then
    ComposeString(json, 'valueString', TFhirString(elem.value));
  ComposeCodeableConcept(json, 'interpretation', elem.interpretation);
  ComposeString(json, 'comments', elem.comments);
  if elem.applies is TFhirPeriod then
    ComposePeriod(json, 'appliesPeriod', TFhirPeriod(elem.applies))
  else if elem.applies is TFhirDateTime then
    ComposeDateTime(json, 'appliesDateTime', TFhirDateTime(elem.applies));
  ComposeInstant(json, 'issued', elem.issued);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirObservationStatus);
  ComposeEnum(json, 'reliability', elem.Reliability, CODES_TFhirObservationReliability);
  ComposeCodeableConcept(json, 'bodySite', elem.bodySite);
  ComposeCodeableConcept(json, 'method', elem.method);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  ComposeResourceReference{Resource}(json, 'performer', elem.performer);
  if elem.referenceRangeList.Count > 0 then
  begin
    json.valueArray('referenceRange');
    for i := 0 to elem.referenceRangeList.Count - 1 do
      ComposeObservationReferenceRange(json, '',elem.referenceRangeList[i]);
    json.FinishArray;
  end;
  if elem.componentList.Count > 0 then
  begin
    json.valueArray('component');
    for i := 0 to elem.componentList.Count - 1 do
      ComposeObservationComponent(json, '',elem.componentList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseOperationOutcomeIssue(element : IXmlDomElement) : TFhirOperationOutcomeIssue;
var
  child : IXMLDOMElement;
begin
  result := TFhirOperationOutcomeIssue.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'severity') then
        result.severity := ParseEnum(CODES_TFhirIssueSeverity, child)
      else if (child.baseName = 'type') then
        result.type_ := ParseCoding(child) {b}
      else if (child.baseName = 'details') then
        result.details := ParseString(child) {b}
      else if (child.baseName = 'location') then
        result.locationList.Add(ParseString(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeOperationOutcomeIssue(xml : TXmlBuilder; name : string; elem : TFhirOperationOutcomeIssue);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'severity', elem.Severity, CODES_TFhirIssueSeverity);
  ComposeCoding(xml, 'type', elem.type_);
  ComposeString(xml, 'details', elem.details);
  for i := 0 to elem.locationList.Count - 1 do
    ComposeString(xml, 'location', elem.locationList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseOperationOutcomeIssue : TFhirOperationOutcomeIssue;
begin
  json.next;
  result := TFhirOperationOutcomeIssue.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'severity') then
        result.severity := ParseEnum(CODES_TFhirIssueSeverity)
      else if (json.ItemName = 'type') then
        result.type_ := ParseCoding
      else if (json.ItemName = 'details') then
        result.details := ParseString
      else if (json.ItemName = 'location') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.locationList.Add(ParseString);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeOperationOutcomeIssue(json : TJSONWriter; name : string; elem : TFhirOperationOutcomeIssue);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'severity', elem.Severity, CODES_TFhirIssueSeverity);
  ComposeCoding(json, 'type', elem.type_);
  ComposeString(json, 'details', elem.details);
  if elem.locationList.Count > 0 then
  begin
    json.valueArray('location');
    for i := 0 to elem.locationList.Count - 1 do
      ComposeString(json, '',elem.locationList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseOperationOutcome(element : IXmlDomElement) : TFhirOperationOutcome;
var
  child : IXMLDOMElement;
begin
  result := TFhirOperationOutcome.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'issue') then
        result.issueList.Add(ParseOperationOutcomeIssue(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeOperationOutcome(xml : TXmlBuilder; name : string; elem : TFhirOperationOutcome);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  for i := 0 to elem.issueList.Count - 1 do
    ComposeOperationOutcomeIssue(xml, 'issue', elem.issueList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseOperationOutcome : TFhirOperationOutcome;
begin
  json.next;
  result := TFhirOperationOutcome.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'issue') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.issueList.Add(ParseOperationOutcomeIssue);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeOperationOutcome(json : TJSONWriter; name : string; elem : TFhirOperationOutcome);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  if elem.issueList.Count > 0 then
  begin
    json.valueArray('issue');
    for i := 0 to elem.issueList.Count - 1 do
      ComposeOperationOutcomeIssue(json, '',elem.issueList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseOrderWhen(element : IXmlDomElement) : TFhirOrderWhen;
var
  child : IXMLDOMElement;
begin
  result := TFhirOrderWhen.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'schedule') then
        result.schedule := ParseSchedule(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeOrderWhen(xml : TXmlBuilder; name : string; elem : TFhirOrderWhen);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeSchedule(xml, 'schedule', elem.schedule);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseOrderWhen : TFhirOrderWhen;
begin
  json.next;
  result := TFhirOrderWhen.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'schedule') then
        result.schedule := ParseSchedule
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeOrderWhen(json : TJSONWriter; name : string; elem : TFhirOrderWhen);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeSchedule(json, 'schedule', elem.schedule);
  json.finishObject;
end;

function TFHIRXmlParser.ParseOrder(element : IXmlDomElement) : TFhirOrder;
var
  child : IXMLDOMElement;
begin
  result := TFhirOrder.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'date') then
        result.date := ParseDateTime(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'source') then
        result.source := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'target') then
        result.target := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'reason') then
        result.reason := ParseString(child) {b}
      else if (child.baseName = 'authority') then
        result.authority := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'when') then
        result.when := ParseOrderWhen(child) {b}
      else if (child.baseName = 'detail') then
        result.detailList.Add(ParseResourceReference{Resource}(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeOrder(xml : TXmlBuilder; name : string; elem : TFhirOrder);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeDateTime(xml, 'date', elem.date);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  ComposeResourceReference{TFhirPractitioner}(xml, 'source', elem.source);
  ComposeResourceReference{Resource}(xml, 'target', elem.target);
  ComposeString(xml, 'reason', elem.reason);
  ComposeResourceReference{Resource}(xml, 'authority', elem.authority);
  ComposeOrderWhen(xml, 'when', elem.when);
  for i := 0 to elem.detailList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'detail', elem.detailList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseOrder : TFhirOrder;
begin
  json.next;
  result := TFhirOrder.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'date') then
        result.date := ParseDateTime
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'source') then
        result.source := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'target') then
        result.target := ParseResourceReference{Resource}
      else if (json.ItemName = 'reason') then
        result.reason := ParseString
      else if (json.ItemName = 'authority') then
        result.authority := ParseResourceReference{Resource}
      else if (json.ItemName = 'when') then
        result.when := ParseOrderWhen
      else if (json.ItemName = 'detail') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.detailList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeOrder(json : TJSONWriter; name : string; elem : TFhirOrder);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeDateTime(json, 'date', elem.date);
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  ComposeResourceReference{TFhirPractitioner}(json, 'source', elem.source);
  ComposeResourceReference{Resource}(json, 'target', elem.target);
  ComposeString(json, 'reason', elem.reason);
  ComposeResourceReference{Resource}(json, 'authority', elem.authority);
  ComposeOrderWhen(json, 'when', elem.when);
  if elem.detailList.Count > 0 then
  begin
    json.valueArray('detail');
    for i := 0 to elem.detailList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.detailList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseOrderResponse(element : IXmlDomElement) : TFhirOrderResponse;
var
  child : IXMLDOMElement;
begin
  result := TFhirOrderResponse.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'request') then
        result.request := ParseResourceReference{TFhirOrder}(child) {b}
      else if (child.baseName = 'date') then
        result.date := ParseDateTime(child) {b}
      else if (child.baseName = 'who') then
        result.who := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'authority') then
        result.authority := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'cost') then
        result.cost := ParseQuantity(child) {b}
      else if (child.baseName = 'code') then
        result.code := ParseEnum(CODES_TFhirOrderOutcomeCode, child)
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'fulfillment') then
        result.fulfillmentList.Add(ParseResourceReference{Resource}(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeOrderResponse(xml : TXmlBuilder; name : string; elem : TFhirOrderResponse);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeResourceReference{TFhirOrder}(xml, 'request', elem.request);
  ComposeDateTime(xml, 'date', elem.date);
  ComposeResourceReference{Resource}(xml, 'who', elem.who);
  ComposeResourceReference{Resource}(xml, 'authority', elem.authority);
  ComposeQuantity(xml, 'cost', elem.cost);
  ComposeEnum(xml, 'code', elem.Code, CODES_TFhirOrderOutcomeCode);
  ComposeString(xml, 'description', elem.description);
  for i := 0 to elem.fulfillmentList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'fulfillment', elem.fulfillmentList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseOrderResponse : TFhirOrderResponse;
begin
  json.next;
  result := TFhirOrderResponse.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'request') then
        result.request := ParseResourceReference{TFhirOrder}
      else if (json.ItemName = 'date') then
        result.date := ParseDateTime
      else if (json.ItemName = 'who') then
        result.who := ParseResourceReference{Resource}
      else if (json.ItemName = 'authority') then
        result.authority := ParseResourceReference{Resource}
      else if (json.ItemName = 'cost') then
        result.cost := ParseQuantity
      else if (json.ItemName = 'code') then
        result.code := ParseEnum(CODES_TFhirOrderOutcomeCode)
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'fulfillment') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.fulfillmentList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeOrderResponse(json : TJSONWriter; name : string; elem : TFhirOrderResponse);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeResourceReference{TFhirOrder}(json, 'request', elem.request);
  ComposeDateTime(json, 'date', elem.date);
  ComposeResourceReference{Resource}(json, 'who', elem.who);
  ComposeResourceReference{Resource}(json, 'authority', elem.authority);
  ComposeQuantity(json, 'cost', elem.cost);
  ComposeEnum(json, 'code', elem.Code, CODES_TFhirOrderOutcomeCode);
  ComposeString(json, 'description', elem.description);
  if elem.fulfillmentList.Count > 0 then
  begin
    json.valueArray('fulfillment');
    for i := 0 to elem.fulfillmentList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.fulfillmentList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseOrganizationContact(element : IXmlDomElement) : TFhirOrganizationContact;
var
  child : IXMLDOMElement;
begin
  result := TFhirOrganizationContact.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'purpose') then
        result.purpose := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseHumanName(child) {b}
      else if (child.baseName = 'telecom') then
        result.telecomList.Add(ParseContact(child))
      else if (child.baseName = 'address') then
        result.address := ParseAddress(child) {b}
      else if (child.baseName = 'gender') then
        result.gender := ParseCodeableConcept(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeOrganizationContact(xml : TXmlBuilder; name : string; elem : TFhirOrganizationContact);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'purpose', elem.purpose);
  ComposeHumanName(xml, 'name', elem.name);
  for i := 0 to elem.telecomList.Count - 1 do
    ComposeContact(xml, 'telecom', elem.telecomList[i]);
  ComposeAddress(xml, 'address', elem.address);
  ComposeCodeableConcept(xml, 'gender', elem.gender);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseOrganizationContact : TFhirOrganizationContact;
begin
  json.next;
  result := TFhirOrganizationContact.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'purpose') then
        result.purpose := ParseCodeableConcept
      else if (json.ItemName = 'name') then
        result.name := ParseHumanName
      else if (json.ItemName = 'telecom') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.telecomList.Add(ParseContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'address') then
        result.address := ParseAddress
      else if (json.ItemName = 'gender') then
        result.gender := ParseCodeableConcept
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeOrganizationContact(json : TJSONWriter; name : string; elem : TFhirOrganizationContact);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'purpose', elem.purpose);
  ComposeHumanName(json, 'name', elem.name);
  if elem.telecomList.Count > 0 then
  begin
    json.valueArray('telecom');
    for i := 0 to elem.telecomList.Count - 1 do
      ComposeContact(json, '',elem.telecomList[i]);
    json.FinishArray;
  end;
  ComposeAddress(json, 'address', elem.address);
  ComposeCodeableConcept(json, 'gender', elem.gender);
  json.finishObject;
end;

function TFHIRXmlParser.ParseOrganization(element : IXmlDomElement) : TFhirOrganization;
var
  child : IXMLDOMElement;
begin
  result := TFhirOrganization.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'telecom') then
        result.telecomList.Add(ParseContact(child))
      else if (child.baseName = 'address') then
        result.addressList.Add(ParseAddress(child))
      else if (child.baseName = 'partOf') then
        result.partOf := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'contact') then
        result.contactList.Add(ParseOrganizationContact(child))
      else if (child.baseName = 'active') then
        result.active := ParseBoolean(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeOrganization(xml : TXmlBuilder; name : string; elem : TFhirOrganization);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeString(xml, 'name', elem.name);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  for i := 0 to elem.telecomList.Count - 1 do
    ComposeContact(xml, 'telecom', elem.telecomList[i]);
  for i := 0 to elem.addressList.Count - 1 do
    ComposeAddress(xml, 'address', elem.addressList[i]);
  ComposeResourceReference{TFhirOrganization}(xml, 'partOf', elem.partOf);
  for i := 0 to elem.contactList.Count - 1 do
    ComposeOrganizationContact(xml, 'contact', elem.contactList[i]);
  ComposeBoolean(xml, 'active', elem.active);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseOrganization : TFhirOrganization;
begin
  json.next;
  result := TFhirOrganization.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'telecom') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.telecomList.Add(ParseContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'address') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.addressList.Add(ParseAddress);
          json.Next;
        end;
      end
      else if (json.ItemName = 'partOf') then
        result.partOf := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'contact') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.contactList.Add(ParseOrganizationContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'active') then
        result.active := ParseBoolean
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeOrganization(json : TJSONWriter; name : string; elem : TFhirOrganization);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'name', elem.name);
  ComposeCodeableConcept(json, 'type', elem.type_);
  if elem.telecomList.Count > 0 then
  begin
    json.valueArray('telecom');
    for i := 0 to elem.telecomList.Count - 1 do
      ComposeContact(json, '',elem.telecomList[i]);
    json.FinishArray;
  end;
  if elem.addressList.Count > 0 then
  begin
    json.valueArray('address');
    for i := 0 to elem.addressList.Count - 1 do
      ComposeAddress(json, '',elem.addressList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirOrganization}(json, 'partOf', elem.partOf);
  if elem.contactList.Count > 0 then
  begin
    json.valueArray('contact');
    for i := 0 to elem.contactList.Count - 1 do
      ComposeOrganizationContact(json, '',elem.contactList[i]);
    json.FinishArray;
  end;
  ComposeBoolean(json, 'active', elem.active);
  json.finishObject;
end;

function TFHIRXmlParser.ParseOther(element : IXmlDomElement) : TFhirOther;
var
  child : IXMLDOMElement;
begin
  result := TFhirOther.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'author') then
        result.author := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'created') then
        result.created := ParseDate(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeOther(xml : TXmlBuilder; name : string; elem : TFhirOther);
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  ComposeResourceReference{Resource}(xml, 'author', elem.author);
  ComposeDate(xml, 'created', elem.created);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseOther : TFhirOther;
begin
  json.next;
  result := TFhirOther.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'author') then
        result.author := ParseResourceReference{Resource}
      else if (json.ItemName = 'created') then
        result.created := ParseDate
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeOther(json : TJSONWriter; name : string; elem : TFhirOther);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  ComposeResourceReference{Resource}(json, 'author', elem.author);
  ComposeDate(json, 'created', elem.created);
  json.finishObject;
end;

function TFHIRXmlParser.ParsePatientContact(element : IXmlDomElement) : TFhirPatientContact;
var
  child : IXMLDOMElement;
begin
  result := TFhirPatientContact.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'relationship') then
        result.relationshipList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'name') then
        result.name := ParseHumanName(child) {b}
      else if (child.baseName = 'telecom') then
        result.telecomList.Add(ParseContact(child))
      else if (child.baseName = 'address') then
        result.address := ParseAddress(child) {b}
      else if (child.baseName = 'gender') then
        result.gender := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'organization') then
        result.organization := ParseResourceReference{TFhirOrganization}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposePatientContact(xml : TXmlBuilder; name : string; elem : TFhirPatientContact);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.relationshipList.Count - 1 do
    ComposeCodeableConcept(xml, 'relationship', elem.relationshipList[i]);
  ComposeHumanName(xml, 'name', elem.name);
  for i := 0 to elem.telecomList.Count - 1 do
    ComposeContact(xml, 'telecom', elem.telecomList[i]);
  ComposeAddress(xml, 'address', elem.address);
  ComposeCodeableConcept(xml, 'gender', elem.gender);
  ComposeResourceReference{TFhirOrganization}(xml, 'organization', elem.organization);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParsePatientContact : TFhirPatientContact;
begin
  json.next;
  result := TFhirPatientContact.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'relationship') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.relationshipList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'name') then
        result.name := ParseHumanName
      else if (json.ItemName = 'telecom') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.telecomList.Add(ParseContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'address') then
        result.address := ParseAddress
      else if (json.ItemName = 'gender') then
        result.gender := ParseCodeableConcept
      else if (json.ItemName = 'organization') then
        result.organization := ParseResourceReference{TFhirOrganization}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposePatientContact(json : TJSONWriter; name : string; elem : TFhirPatientContact);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.relationshipList.Count > 0 then
  begin
    json.valueArray('relationship');
    for i := 0 to elem.relationshipList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.relationshipList[i]);
    json.FinishArray;
  end;
  ComposeHumanName(json, 'name', elem.name);
  if elem.telecomList.Count > 0 then
  begin
    json.valueArray('telecom');
    for i := 0 to elem.telecomList.Count - 1 do
      ComposeContact(json, '',elem.telecomList[i]);
    json.FinishArray;
  end;
  ComposeAddress(json, 'address', elem.address);
  ComposeCodeableConcept(json, 'gender', elem.gender);
  ComposeResourceReference{TFhirOrganization}(json, 'organization', elem.organization);
  json.finishObject;
end;

function TFHIRXmlParser.ParsePatientAnimal(element : IXmlDomElement) : TFhirPatientAnimal;
var
  child : IXMLDOMElement;
begin
  result := TFhirPatientAnimal.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'species') then
        result.species := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'breed') then
        result.breed := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'genderStatus') then
        result.genderStatus := ParseCodeableConcept(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposePatientAnimal(xml : TXmlBuilder; name : string; elem : TFhirPatientAnimal);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'species', elem.species);
  ComposeCodeableConcept(xml, 'breed', elem.breed);
  ComposeCodeableConcept(xml, 'genderStatus', elem.genderStatus);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParsePatientAnimal : TFhirPatientAnimal;
begin
  json.next;
  result := TFhirPatientAnimal.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'species') then
        result.species := ParseCodeableConcept
      else if (json.ItemName = 'breed') then
        result.breed := ParseCodeableConcept
      else if (json.ItemName = 'genderStatus') then
        result.genderStatus := ParseCodeableConcept
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposePatientAnimal(json : TJSONWriter; name : string; elem : TFhirPatientAnimal);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'species', elem.species);
  ComposeCodeableConcept(json, 'breed', elem.breed);
  ComposeCodeableConcept(json, 'genderStatus', elem.genderStatus);
  json.finishObject;
end;

function TFHIRXmlParser.ParsePatient(element : IXmlDomElement) : TFhirPatient;
var
  child : IXMLDOMElement;
begin
  result := TFhirPatient.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'name') then
        result.nameList.Add(ParseHumanName(child))
      else if (child.baseName = 'telecom') then
        result.telecomList.Add(ParseContact(child))
      else if (child.baseName = 'gender') then
        result.gender := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'birthDate') then
        result.birthDate := ParseDateTime(child) {b}
      else if (child.baseName = 'deceasedBoolean') then
        result.deceased := ParseBoolean(child)
      else if (child.baseName = 'deceasedDateTime') then
        result.deceased := ParseDateTime(child)
      else if (child.baseName = 'address') then
        result.addressList.Add(ParseAddress(child))
      else if (child.baseName = 'maritalStatus') then
        result.maritalStatus := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'multipleBirthBoolean') then
        result.multipleBirth := ParseBoolean(child)
      else if (child.baseName = 'multipleBirthInteger') then
        result.multipleBirth := ParseInteger(child)
      else if (child.baseName = 'photo') then
        result.photoList.Add(ParseAttachment(child))
      else if (child.baseName = 'contact') then
        result.contactList.Add(ParsePatientContact(child))
      else if (child.baseName = 'animal') then
        result.animal := ParsePatientAnimal(child) {b}
      else if (child.baseName = 'communication') then
        result.communicationList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'provider') then
        result.provider := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'link') then
        result.link_List.Add(ParseResourceReference{TFhirPatient}(child))
      else if (child.baseName = 'active') then
        result.active := ParseBoolean(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposePatient(xml : TXmlBuilder; name : string; elem : TFhirPatient);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  for i := 0 to elem.nameList.Count - 1 do
    ComposeHumanName(xml, 'name', elem.nameList[i]);
  for i := 0 to elem.telecomList.Count - 1 do
    ComposeContact(xml, 'telecom', elem.telecomList[i]);
  ComposeCodeableConcept(xml, 'gender', elem.gender);
  ComposeDateTime(xml, 'birthDate', elem.birthDate);
  if elem.deceased is TFhirBoolean {6} then
    ComposeBoolean(xml, 'deceasedBoolean', TFhirBoolean(elem.deceased))
  else if elem.deceased is TFhirDateTime {6} then
    ComposeDateTime(xml, 'deceasedDateTime', TFhirDateTime(elem.deceased));
  for i := 0 to elem.addressList.Count - 1 do
    ComposeAddress(xml, 'address', elem.addressList[i]);
  ComposeCodeableConcept(xml, 'maritalStatus', elem.maritalStatus);
  if elem.multipleBirth is TFhirBoolean {6} then
    ComposeBoolean(xml, 'multipleBirthBoolean', TFhirBoolean(elem.multipleBirth))
  else if elem.multipleBirth is TFhirInteger {6} then
    ComposeInteger(xml, 'multipleBirthInteger', TFhirInteger(elem.multipleBirth));
  for i := 0 to elem.photoList.Count - 1 do
    ComposeAttachment(xml, 'photo', elem.photoList[i]);
  for i := 0 to elem.contactList.Count - 1 do
    ComposePatientContact(xml, 'contact', elem.contactList[i]);
  ComposePatientAnimal(xml, 'animal', elem.animal);
  for i := 0 to elem.communicationList.Count - 1 do
    ComposeCodeableConcept(xml, 'communication', elem.communicationList[i]);
  ComposeResourceReference{TFhirOrganization}(xml, 'provider', elem.provider);
  for i := 0 to elem.link_List.Count - 1 do
    ComposeResourceReference{TFhirPatient}(xml, 'link', elem.link_List[i]);
  ComposeBoolean(xml, 'active', elem.active);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParsePatient : TFhirPatient;
begin
  json.next;
  result := TFhirPatient.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'name') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.nameList.Add(ParseHumanName);
          json.Next;
        end;
      end
      else if (json.ItemName = 'telecom') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.telecomList.Add(ParseContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'gender') then
        result.gender := ParseCodeableConcept
      else if (json.ItemName = 'birthDate') then
        result.birthDate := ParseDateTime
      else if (json.ItemName = 'deceasedBoolean') then
        result.deceased := ParseBoolean
      else if (json.ItemName = 'deceasedDateTime') then
        result.deceased := ParseDateTime
      else if (json.ItemName = 'address') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.addressList.Add(ParseAddress);
          json.Next;
        end;
      end
      else if (json.ItemName = 'maritalStatus') then
        result.maritalStatus := ParseCodeableConcept
      else if (json.ItemName = 'multipleBirthBoolean') then
        result.multipleBirth := ParseBoolean
      else if (json.ItemName = 'multipleBirthInteger') then
        result.multipleBirth := ParseInteger
      else if (json.ItemName = 'photo') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.photoList.Add(ParseAttachment);
          json.Next;
        end;
      end
      else if (json.ItemName = 'contact') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.contactList.Add(ParsePatientContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'animal') then
        result.animal := ParsePatientAnimal
      else if (json.ItemName = 'communication') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.communicationList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'provider') then
        result.provider := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'link') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.link_List.Add(ParseResourceReference{TFhirPatient});
          json.Next;
        end;
      end
      else if (json.ItemName = 'active') then
        result.active := ParseBoolean
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposePatient(json : TJSONWriter; name : string; elem : TFhirPatient);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  if elem.nameList.Count > 0 then
  begin
    json.valueArray('name');
    for i := 0 to elem.nameList.Count - 1 do
      ComposeHumanName(json, '',elem.nameList[i]);
    json.FinishArray;
  end;
  if elem.telecomList.Count > 0 then
  begin
    json.valueArray('telecom');
    for i := 0 to elem.telecomList.Count - 1 do
      ComposeContact(json, '',elem.telecomList[i]);
    json.FinishArray;
  end;
  ComposeCodeableConcept(json, 'gender', elem.gender);
  ComposeDateTime(json, 'birthDate', elem.birthDate);
  if elem.deceased is TFhirBoolean then
    ComposeBoolean(json, 'deceasedBoolean', TFhirBoolean(elem.deceased))
  else if elem.deceased is TFhirDateTime then
    ComposeDateTime(json, 'deceasedDateTime', TFhirDateTime(elem.deceased));
  if elem.addressList.Count > 0 then
  begin
    json.valueArray('address');
    for i := 0 to elem.addressList.Count - 1 do
      ComposeAddress(json, '',elem.addressList[i]);
    json.FinishArray;
  end;
  ComposeCodeableConcept(json, 'maritalStatus', elem.maritalStatus);
  if elem.multipleBirth is TFhirBoolean then
    ComposeBoolean(json, 'multipleBirthBoolean', TFhirBoolean(elem.multipleBirth))
  else if elem.multipleBirth is TFhirInteger then
    ComposeInteger(json, 'multipleBirthInteger', TFhirInteger(elem.multipleBirth));
  if elem.photoList.Count > 0 then
  begin
    json.valueArray('photo');
    for i := 0 to elem.photoList.Count - 1 do
      ComposeAttachment(json, '',elem.photoList[i]);
    json.FinishArray;
  end;
  if elem.contactList.Count > 0 then
  begin
    json.valueArray('contact');
    for i := 0 to elem.contactList.Count - 1 do
      ComposePatientContact(json, '',elem.contactList[i]);
    json.FinishArray;
  end;
  ComposePatientAnimal(json, 'animal', elem.animal);
  if elem.communicationList.Count > 0 then
  begin
    json.valueArray('communication');
    for i := 0 to elem.communicationList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.communicationList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirOrganization}(json, 'provider', elem.provider);
  if elem.link_List.Count > 0 then
  begin
    json.valueArray('link');
    for i := 0 to elem.link_List.Count - 1 do
      ComposeResourceReference{TFhirPatient}(json, '',elem.link_List[i]);
    json.FinishArray;
  end;
  ComposeBoolean(json, 'active', elem.active);
  json.finishObject;
end;

function TFHIRXmlParser.ParsePractitionerQualification(element : IXmlDomElement) : TFhirPractitionerQualification;
var
  child : IXMLDOMElement;
begin
  result := TFhirPractitionerQualification.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if (child.baseName = 'issuer') then
        result.issuer := ParseResourceReference{TFhirOrganization}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposePractitionerQualification(xml : TXmlBuilder; name : string; elem : TFhirPractitionerQualification);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'code', elem.code);
  ComposePeriod(xml, 'period', elem.period);
  ComposeResourceReference{TFhirOrganization}(xml, 'issuer', elem.issuer);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParsePractitionerQualification : TFhirPractitionerQualification;
begin
  json.next;
  result := TFhirPractitionerQualification.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCodeableConcept
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if (json.ItemName = 'issuer') then
        result.issuer := ParseResourceReference{TFhirOrganization}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposePractitionerQualification(json : TJSONWriter; name : string; elem : TFhirPractitionerQualification);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'code', elem.code);
  ComposePeriod(json, 'period', elem.period);
  ComposeResourceReference{TFhirOrganization}(json, 'issuer', elem.issuer);
  json.finishObject;
end;

function TFHIRXmlParser.ParsePractitioner(element : IXmlDomElement) : TFhirPractitioner;
var
  child : IXMLDOMElement;
begin
  result := TFhirPractitioner.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'name') then
        result.name := ParseHumanName(child) {b}
      else if (child.baseName = 'telecom') then
        result.telecomList.Add(ParseContact(child))
      else if (child.baseName = 'address') then
        result.address := ParseAddress(child) {b}
      else if (child.baseName = 'gender') then
        result.gender := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'birthDate') then
        result.birthDate := ParseDateTime(child) {b}
      else if (child.baseName = 'photo') then
        result.photoList.Add(ParseAttachment(child))
      else if (child.baseName = 'organization') then
        result.organization := ParseResourceReference{TFhirOrganization}(child) {b}
      else if (child.baseName = 'role') then
        result.roleList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'specialty') then
        result.specialtyList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if (child.baseName = 'qualification') then
        result.qualificationList.Add(ParsePractitionerQualification(child))
      else if (child.baseName = 'communication') then
        result.communicationList.Add(ParseCodeableConcept(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposePractitioner(xml : TXmlBuilder; name : string; elem : TFhirPractitioner);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeHumanName(xml, 'name', elem.name);
  for i := 0 to elem.telecomList.Count - 1 do
    ComposeContact(xml, 'telecom', elem.telecomList[i]);
  ComposeAddress(xml, 'address', elem.address);
  ComposeCodeableConcept(xml, 'gender', elem.gender);
  ComposeDateTime(xml, 'birthDate', elem.birthDate);
  for i := 0 to elem.photoList.Count - 1 do
    ComposeAttachment(xml, 'photo', elem.photoList[i]);
  ComposeResourceReference{TFhirOrganization}(xml, 'organization', elem.organization);
  for i := 0 to elem.roleList.Count - 1 do
    ComposeCodeableConcept(xml, 'role', elem.roleList[i]);
  for i := 0 to elem.specialtyList.Count - 1 do
    ComposeCodeableConcept(xml, 'specialty', elem.specialtyList[i]);
  ComposePeriod(xml, 'period', elem.period);
  for i := 0 to elem.qualificationList.Count - 1 do
    ComposePractitionerQualification(xml, 'qualification', elem.qualificationList[i]);
  for i := 0 to elem.communicationList.Count - 1 do
    ComposeCodeableConcept(xml, 'communication', elem.communicationList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParsePractitioner : TFhirPractitioner;
begin
  json.next;
  result := TFhirPractitioner.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'name') then
        result.name := ParseHumanName
      else if (json.ItemName = 'telecom') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.telecomList.Add(ParseContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'address') then
        result.address := ParseAddress
      else if (json.ItemName = 'gender') then
        result.gender := ParseCodeableConcept
      else if (json.ItemName = 'birthDate') then
        result.birthDate := ParseDateTime
      else if (json.ItemName = 'photo') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.photoList.Add(ParseAttachment);
          json.Next;
        end;
      end
      else if (json.ItemName = 'organization') then
        result.organization := ParseResourceReference{TFhirOrganization}
      else if (json.ItemName = 'role') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.roleList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'specialty') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.specialtyList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if (json.ItemName = 'qualification') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.qualificationList.Add(ParsePractitionerQualification);
          json.Next;
        end;
      end
      else if (json.ItemName = 'communication') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.communicationList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposePractitioner(json : TJSONWriter; name : string; elem : TFhirPractitioner);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeHumanName(json, 'name', elem.name);
  if elem.telecomList.Count > 0 then
  begin
    json.valueArray('telecom');
    for i := 0 to elem.telecomList.Count - 1 do
      ComposeContact(json, '',elem.telecomList[i]);
    json.FinishArray;
  end;
  ComposeAddress(json, 'address', elem.address);
  ComposeCodeableConcept(json, 'gender', elem.gender);
  ComposeDateTime(json, 'birthDate', elem.birthDate);
  if elem.photoList.Count > 0 then
  begin
    json.valueArray('photo');
    for i := 0 to elem.photoList.Count - 1 do
      ComposeAttachment(json, '',elem.photoList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirOrganization}(json, 'organization', elem.organization);
  if elem.roleList.Count > 0 then
  begin
    json.valueArray('role');
    for i := 0 to elem.roleList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.roleList[i]);
    json.FinishArray;
  end;
  if elem.specialtyList.Count > 0 then
  begin
    json.valueArray('specialty');
    for i := 0 to elem.specialtyList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.specialtyList[i]);
    json.FinishArray;
  end;
  ComposePeriod(json, 'period', elem.period);
  if elem.qualificationList.Count > 0 then
  begin
    json.valueArray('qualification');
    for i := 0 to elem.qualificationList.Count - 1 do
      ComposePractitionerQualification(json, '',elem.qualificationList[i]);
    json.FinishArray;
  end;
  if elem.communicationList.Count > 0 then
  begin
    json.valueArray('communication');
    for i := 0 to elem.communicationList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.communicationList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseProcedurePerformer(element : IXmlDomElement) : TFhirProcedurePerformer;
var
  child : IXMLDOMElement;
begin
  result := TFhirProcedurePerformer.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'person') then
        result.person := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'role') then
        result.role := ParseCodeableConcept(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProcedurePerformer(xml : TXmlBuilder; name : string; elem : TFhirProcedurePerformer);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeResourceReference{TFhirPractitioner}(xml, 'person', elem.person);
  ComposeCodeableConcept(xml, 'role', elem.role);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProcedurePerformer : TFhirProcedurePerformer;
begin
  json.next;
  result := TFhirProcedurePerformer.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'person') then
        result.person := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'role') then
        result.role := ParseCodeableConcept
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProcedurePerformer(json : TJSONWriter; name : string; elem : TFhirProcedurePerformer);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeResourceReference{TFhirPractitioner}(json, 'person', elem.person);
  ComposeCodeableConcept(json, 'role', elem.role);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProcedureRelatedItem(element : IXmlDomElement) : TFhirProcedureRelatedItem;
var
  child : IXMLDOMElement;
begin
  result := TFhirProcedureRelatedItem.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirProcedureRelationshipType, child)
      else if (child.baseName = 'target') then
        result.target := ParseResourceReference{Resource}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProcedureRelatedItem(xml : TXmlBuilder; name : string; elem : TFhirProcedureRelatedItem);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'type', elem.Type_, CODES_TFhirProcedureRelationshipType);
  ComposeResourceReference{Resource}(xml, 'target', elem.target);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProcedureRelatedItem : TFhirProcedureRelatedItem;
begin
  json.next;
  result := TFhirProcedureRelatedItem.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirProcedureRelationshipType)
      else if (json.ItemName = 'target') then
        result.target := ParseResourceReference{Resource}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProcedureRelatedItem(json : TJSONWriter; name : string; elem : TFhirProcedureRelatedItem);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'type', elem.Type_, CODES_TFhirProcedureRelationshipType);
  ComposeResourceReference{Resource}(json, 'target', elem.target);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProcedure(element : IXmlDomElement) : TFhirProcedure;
var
  child : IXMLDOMElement;
begin
  result := TFhirProcedure.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'bodySite') then
        result.bodySiteList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'indication') then
        result.indication := ParseString(child) {b}
      else if (child.baseName = 'performer') then
        result.performerList.Add(ParseProcedurePerformer(child))
      else if (child.baseName = 'date') then
        result.date := ParsePeriod(child) {b}
      else if (child.baseName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}(child) {b}
      else if (child.baseName = 'outcome') then
        result.outcome := ParseString(child) {b}
      else if (child.baseName = 'report') then
        result.reportList.Add(ParseResourceReference{TFhirDiagnosticReport}(child))
      else if (child.baseName = 'complication') then
        result.complication := ParseString(child) {b}
      else if (child.baseName = 'followUp') then
        result.followUp := ParseString(child) {b}
      else if (child.baseName = 'relatedItem') then
        result.relatedItemList.Add(ParseProcedureRelatedItem(child))
      else if (child.baseName = 'notes') then
        result.notes := ParseString(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProcedure(xml : TXmlBuilder; name : string; elem : TFhirProcedure);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeResourceReference{TFhirPatient}(xml, 'subject', elem.subject);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  for i := 0 to elem.bodySiteList.Count - 1 do
    ComposeCodeableConcept(xml, 'bodySite', elem.bodySiteList[i]);
  ComposeString(xml, 'indication', elem.indication);
  for i := 0 to elem.performerList.Count - 1 do
    ComposeProcedurePerformer(xml, 'performer', elem.performerList[i]);
  ComposePeriod(xml, 'date', elem.date);
  ComposeResourceReference{TFhirEncounter}(xml, 'encounter', elem.encounter);
  ComposeString(xml, 'outcome', elem.outcome);
  for i := 0 to elem.reportList.Count - 1 do
    ComposeResourceReference{TFhirDiagnosticReport}(xml, 'report', elem.reportList[i]);
  ComposeString(xml, 'complication', elem.complication);
  ComposeString(xml, 'followUp', elem.followUp);
  for i := 0 to elem.relatedItemList.Count - 1 do
    ComposeProcedureRelatedItem(xml, 'relatedItem', elem.relatedItemList[i]);
  ComposeString(xml, 'notes', elem.notes);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProcedure : TFhirProcedure;
begin
  json.next;
  result := TFhirProcedure.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'bodySite') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.bodySiteList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'indication') then
        result.indication := ParseString
      else if (json.ItemName = 'performer') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.performerList.Add(ParseProcedurePerformer);
          json.Next;
        end;
      end
      else if (json.ItemName = 'date') then
        result.date := ParsePeriod
      else if (json.ItemName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}
      else if (json.ItemName = 'outcome') then
        result.outcome := ParseString
      else if (json.ItemName = 'report') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.reportList.Add(ParseResourceReference{TFhirDiagnosticReport});
          json.Next;
        end;
      end
      else if (json.ItemName = 'complication') then
        result.complication := ParseString
      else if (json.ItemName = 'followUp') then
        result.followUp := ParseString
      else if (json.ItemName = 'relatedItem') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.relatedItemList.Add(ParseProcedureRelatedItem);
          json.Next;
        end;
      end
      else if (json.ItemName = 'notes') then
        result.notes := ParseString
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProcedure(json : TJSONWriter; name : string; elem : TFhirProcedure);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeResourceReference{TFhirPatient}(json, 'subject', elem.subject);
  ComposeCodeableConcept(json, 'type', elem.type_);
  if elem.bodySiteList.Count > 0 then
  begin
    json.valueArray('bodySite');
    for i := 0 to elem.bodySiteList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.bodySiteList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'indication', elem.indication);
  if elem.performerList.Count > 0 then
  begin
    json.valueArray('performer');
    for i := 0 to elem.performerList.Count - 1 do
      ComposeProcedurePerformer(json, '',elem.performerList[i]);
    json.FinishArray;
  end;
  ComposePeriod(json, 'date', elem.date);
  ComposeResourceReference{TFhirEncounter}(json, 'encounter', elem.encounter);
  ComposeString(json, 'outcome', elem.outcome);
  if elem.reportList.Count > 0 then
  begin
    json.valueArray('report');
    for i := 0 to elem.reportList.Count - 1 do
      ComposeResourceReference{TFhirDiagnosticReport}(json, '',elem.reportList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'complication', elem.complication);
  ComposeString(json, 'followUp', elem.followUp);
  if elem.relatedItemList.Count > 0 then
  begin
    json.valueArray('relatedItem');
    for i := 0 to elem.relatedItemList.Count - 1 do
      ComposeProcedureRelatedItem(json, '',elem.relatedItemList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'notes', elem.notes);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProfileStructure(element : IXmlDomElement) : TFhirProfileStructure;
var
  child : IXMLDOMElement;
begin
  result := TFhirProfileStructure.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCode(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'publish') then
        result.publish := ParseBoolean(child) {b}
      else if (child.baseName = 'purpose') then
        result.purpose := ParseString(child) {b}
      else if (child.baseName = 'element') then
        result.elementList.Add(ParseProfileStructureElement(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProfileStructure(xml : TXmlBuilder; name : string; elem : TFhirProfileStructure);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'type', elem.type_);
  ComposeString(xml, 'name', elem.name);
  ComposeBoolean(xml, 'publish', elem.publish);
  ComposeString(xml, 'purpose', elem.purpose);
  for i := 0 to elem.elementList.Count - 1 do
    ComposeProfileStructureElement(xml, 'element', elem.elementList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProfileStructure : TFhirProfileStructure;
begin
  json.next;
  result := TFhirProfileStructure.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCode
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'publish') then
        result.publish := ParseBoolean
      else if (json.ItemName = 'purpose') then
        result.purpose := ParseString
      else if (json.ItemName = 'element') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.elementList.Add(ParseProfileStructureElement);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProfileStructure(json : TJSONWriter; name : string; elem : TFhirProfileStructure);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'type', elem.type_);
  ComposeString(json, 'name', elem.name);
  ComposeBoolean(json, 'publish', elem.publish);
  ComposeString(json, 'purpose', elem.purpose);
  if elem.elementList.Count > 0 then
  begin
    json.valueArray('element');
    for i := 0 to elem.elementList.Count - 1 do
      ComposeProfileStructureElement(json, '',elem.elementList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseProfileStructureElement(element : IXmlDomElement) : TFhirProfileStructureElement;
var
  child : IXMLDOMElement;
begin
  result := TFhirProfileStructureElement.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'path') then
        result.path := ParseString(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'slicing') then
        result.slicing := ParseProfileStructureElementSlicing(child) {b}
      else if (child.baseName = 'definition') then
        result.definition := ParseProfileStructureElementDefinition(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProfileStructureElement(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElement);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'path', elem.path);
  ComposeString(xml, 'name', elem.name);
  ComposeProfileStructureElementSlicing(xml, 'slicing', elem.slicing);
  ComposeProfileStructureElementDefinition(xml, 'definition', elem.definition);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProfileStructureElement : TFhirProfileStructureElement;
begin
  json.next;
  result := TFhirProfileStructureElement.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'path') then
        result.path := ParseString
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'slicing') then
        result.slicing := ParseProfileStructureElementSlicing
      else if (json.ItemName = 'definition') then
        result.definition := ParseProfileStructureElementDefinition
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProfileStructureElement(json : TJSONWriter; name : string; elem : TFhirProfileStructureElement);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'path', elem.path);
  ComposeString(json, 'name', elem.name);
  ComposeProfileStructureElementSlicing(json, 'slicing', elem.slicing);
  ComposeProfileStructureElementDefinition(json, 'definition', elem.definition);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProfileStructureElementSlicing(element : IXmlDomElement) : TFhirProfileStructureElementSlicing;
var
  child : IXMLDOMElement;
begin
  result := TFhirProfileStructureElementSlicing.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'discriminator') then
        result.discriminator := ParseId(child) {b}
      else if (child.baseName = 'ordered') then
        result.ordered := ParseBoolean(child) {b}
      else if (child.baseName = 'rules') then
        result.rules := ParseEnum(CODES_TFhirResourceSlicingRules, child)
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProfileStructureElementSlicing(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElementSlicing);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeId(xml, 'discriminator', elem.discriminator);
  ComposeBoolean(xml, 'ordered', elem.ordered);
  ComposeEnum(xml, 'rules', elem.Rules, CODES_TFhirResourceSlicingRules);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProfileStructureElementSlicing : TFhirProfileStructureElementSlicing;
begin
  json.next;
  result := TFhirProfileStructureElementSlicing.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'discriminator') then
        result.discriminator := ParseId
      else if (json.ItemName = 'ordered') then
        result.ordered := ParseBoolean
      else if (json.ItemName = 'rules') then
        result.rules := ParseEnum(CODES_TFhirResourceSlicingRules)
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProfileStructureElementSlicing(json : TJSONWriter; name : string; elem : TFhirProfileStructureElementSlicing);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeId(json, 'discriminator', elem.discriminator);
  ComposeBoolean(json, 'ordered', elem.ordered);
  ComposeEnum(json, 'rules', elem.Rules, CODES_TFhirResourceSlicingRules);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProfileStructureElementDefinition(element : IXmlDomElement) : TFhirProfileStructureElementDefinition;
var
  child : IXMLDOMElement;
begin
  result := TFhirProfileStructureElementDefinition.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'short') then
        result.short := ParseString(child) {b}
      else if (child.baseName = 'formal') then
        result.formal := ParseString(child) {b}
      else if (child.baseName = 'comments') then
        result.comments := ParseString(child) {b}
      else if (child.baseName = 'requirements') then
        result.requirements := ParseString(child) {b}
      else if (child.baseName = 'synonym') then
        result.synonymList.Add(ParseString(child))
      else if (child.baseName = 'min') then
        result.min := ParseInteger(child) {b}
      else if (child.baseName = 'max') then
        result.max := ParseString(child) {b}
      else if (child.baseName = 'type') then
        result.type_List.Add(ParseProfileStructureElementDefinitionType(child))
      else if (child.baseName = 'nameReference') then
        result.nameReference := ParseString(child) {b}
      else if (child.baseName = 'valueInteger') then
        result.value := ParseInteger(child) {c}
      else if (child.baseName = 'valueDateTime') then
        result.value := ParseDateTime(child) {c}
      else if (child.baseName = 'valueCode') then
        result.value := ParseCode(child) {c}
      else if (child.baseName = 'valueDate') then
        result.value := ParseDate(child) {c}
      else if (child.baseName = 'valueDecimal') then
        result.value := ParseDecimal(child) {c}
      else if (child.baseName = 'valueUri') then
        result.value := ParseUri(child) {c}
      else if (child.baseName = 'valueId') then
        result.value := ParseId(child) {c}
      else if (child.baseName = 'valueBase64Binary') then
        result.value := ParseBase64Binary(child) {c}
      else if (child.baseName = 'valueOid') then
        result.value := ParseOid(child) {c}
      else if (child.baseName = 'valueString') then
        result.value := ParseString(child) {c}
      else if (child.baseName = 'valueBoolean') then
        result.value := ParseBoolean(child) {c}
      else if (child.baseName = 'valueUuid') then
        result.value := ParseUuid(child) {c}
      else if (child.baseName = 'valueInstant') then
        result.value := ParseInstant(child) {c}
      else if (child.baseName = 'valuePeriod') then
        result.value := ParsePeriod(child) {ePeriod}
      else if (child.baseName = 'valueCoding') then
        result.value := ParseCoding(child) {eCoding}
      else if (child.baseName = 'valueRange') then
        result.value := ParseRange(child) {eRange}
      else if (child.baseName = 'valueQuantity') then
        result.value := ParseQuantity(child) {eQuantity}
      else if (child.baseName = 'valueChoice') then
        result.value := ParseChoice(child) {eChoice}
      else if (child.baseName = 'valueAttachment') then
        result.value := ParseAttachment(child) {eAttachment}
      else if (child.baseName = 'valueRatio') then
        result.value := ParseRatio(child) {eRatio}
      else if (child.baseName = 'valueSampledData') then
        result.value := ParseSampledData(child) {eSampledData}
      else if (child.baseName = 'valueResource') then
        result.value := ParseResourceReference(child) {e0}
      else if (child.baseName = 'valueCodeableConcept') then
        result.value := ParseCodeableConcept(child) {eCodeableConcept}
      else if (child.baseName = 'valueIdentifier') then
        result.value := ParseIdentifier(child) {eIdentifier}
      else if (child.baseName = 'valueSchedule') then
        result.value := ParseSchedule(child) {f}
      else if (child.baseName = 'valueContact') then
        result.value := ParseContact(child) {f}
      else if (child.baseName = 'valueAddress') then
        result.value := ParseAddress(child) {f}
      else if (child.baseName = 'valueHumanName') then
        result.value := ParseHumanName(child) {f}
      else if (child.baseName = 'exampleInteger') then
        result.example := ParseInteger(child) {c}
      else if (child.baseName = 'exampleDateTime') then
        result.example := ParseDateTime(child) {c}
      else if (child.baseName = 'exampleCode') then
        result.example := ParseCode(child) {c}
      else if (child.baseName = 'exampleDate') then
        result.example := ParseDate(child) {c}
      else if (child.baseName = 'exampleDecimal') then
        result.example := ParseDecimal(child) {c}
      else if (child.baseName = 'exampleUri') then
        result.example := ParseUri(child) {c}
      else if (child.baseName = 'exampleId') then
        result.example := ParseId(child) {c}
      else if (child.baseName = 'exampleBase64Binary') then
        result.example := ParseBase64Binary(child) {c}
      else if (child.baseName = 'exampleOid') then
        result.example := ParseOid(child) {c}
      else if (child.baseName = 'exampleString') then
        result.example := ParseString(child) {c}
      else if (child.baseName = 'exampleBoolean') then
        result.example := ParseBoolean(child) {c}
      else if (child.baseName = 'exampleUuid') then
        result.example := ParseUuid(child) {c}
      else if (child.baseName = 'exampleInstant') then
        result.example := ParseInstant(child) {c}
      else if (child.baseName = 'examplePeriod') then
        result.example := ParsePeriod(child) {ePeriod}
      else if (child.baseName = 'exampleCoding') then
        result.example := ParseCoding(child) {eCoding}
      else if (child.baseName = 'exampleRange') then
        result.example := ParseRange(child) {eRange}
      else if (child.baseName = 'exampleQuantity') then
        result.example := ParseQuantity(child) {eQuantity}
      else if (child.baseName = 'exampleChoice') then
        result.example := ParseChoice(child) {eChoice}
      else if (child.baseName = 'exampleAttachment') then
        result.example := ParseAttachment(child) {eAttachment}
      else if (child.baseName = 'exampleRatio') then
        result.example := ParseRatio(child) {eRatio}
      else if (child.baseName = 'exampleSampledData') then
        result.example := ParseSampledData(child) {eSampledData}
      else if (child.baseName = 'exampleResource') then
        result.example := ParseResourceReference(child) {e0}
      else if (child.baseName = 'exampleCodeableConcept') then
        result.example := ParseCodeableConcept(child) {eCodeableConcept}
      else if (child.baseName = 'exampleIdentifier') then
        result.example := ParseIdentifier(child) {eIdentifier}
      else if (child.baseName = 'exampleSchedule') then
        result.example := ParseSchedule(child) {f}
      else if (child.baseName = 'exampleContact') then
        result.example := ParseContact(child) {f}
      else if (child.baseName = 'exampleAddress') then
        result.example := ParseAddress(child) {f}
      else if (child.baseName = 'exampleHumanName') then
        result.example := ParseHumanName(child) {f}
      else if (child.baseName = 'maxLength') then
        result.maxLength := ParseInteger(child) {b}
      else if (child.baseName = 'condition') then
        result.conditionList.Add(ParseId(child))
      else if (child.baseName = 'constraint') then
        result.constraintList.Add(ParseProfileStructureElementDefinitionConstraint(child))
      else if (child.baseName = 'mustSupport') then
        result.mustSupport := ParseBoolean(child) {b}
      else if (child.baseName = 'isModifier') then
        result.isModifier := ParseBoolean(child) {b}
      else if (child.baseName = 'binding') then
        result.binding := ParseUri(child) {b}
      else if (child.baseName = 'mapping') then
        result.mappingList.Add(ParseProfileStructureElementDefinitionMapping(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProfileStructureElementDefinition(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElementDefinition);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'short', elem.short);
  ComposeString(xml, 'formal', elem.formal);
  ComposeString(xml, 'comments', elem.comments);
  ComposeString(xml, 'requirements', elem.requirements);
  for i := 0 to elem.synonymList.Count - 1 do
    ComposeString(xml, 'synonym', elem.synonymList[i]);
  ComposeInteger(xml, 'min', elem.min);
  ComposeString(xml, 'max', elem.max);
  for i := 0 to elem.type_List.Count - 1 do
    ComposeProfileStructureElementDefinitionType(xml, 'type', elem.type_List[i]);
  ComposeString(xml, 'nameReference', elem.nameReference);
  if elem.value is TFhirInteger {1} then
    ComposeInteger(xml, 'valueInteger', TFhirInteger(elem.value))
  else if elem.value is TFhirDateTime {1} then
    ComposeDateTime(xml, 'valueDateTime', TFhirDateTime(elem.value))
  else if elem.value is TFhirCode {1} then
    ComposeCode(xml, 'valueCode', TFhirCode(elem.value))
  else if elem.value is TFhirDate {1} then
    ComposeDate(xml, 'valueDate', TFhirDate(elem.value))
  else if elem.value is TFhirDecimal {1} then
    ComposeDecimal(xml, 'valueDecimal', TFhirDecimal(elem.value))
  else if elem.value is TFhirUri {1} then
    ComposeUri(xml, 'valueUri', TFhirUri(elem.value))
  else if elem.value is TFhirId {1} then
    ComposeId(xml, 'valueId', TFhirId(elem.value))
  else if elem.value is TFhirBase64Binary {1} then
    ComposeBase64Binary(xml, 'valueBase64Binary', TFhirBase64Binary(elem.value))
  else if elem.value is TFhirOid {1} then
    ComposeOid(xml, 'valueOid', TFhirOid(elem.value))
  else if elem.value is TFhirString {1} then
    ComposeString(xml, 'valueString', TFhirString(elem.value))
  else if elem.value is TFhirBoolean {1} then
    ComposeBoolean(xml, 'valueBoolean', TFhirBoolean(elem.value))
  else if elem.value is TFhirUuid {1} then
    ComposeUuid(xml, 'valueUuid', TFhirUuid(elem.value))
  else if elem.value is TFhirInstant {1} then
    ComposeInstant(xml, 'valueInstant', TFhirInstant(elem.value))
  else if elem.value is TFhirPeriod {8} then
    ComposePeriod(xml, 'valuePeriod', TFhirPeriod(elem.value))
  else if elem.value is TFhirCoding {8} then
    ComposeCoding(xml, 'valueCoding', TFhirCoding(elem.value))
  else if elem.value is TFhirRange {8} then
    ComposeRange(xml, 'valueRange', TFhirRange(elem.value))
  else if elem.value is TFhirQuantity {8} then
    ComposeQuantity(xml, 'valueQuantity', TFhirQuantity(elem.value))
  else if elem.value is TFhirChoice {8} then
    ComposeChoice(xml, 'valueChoice', TFhirChoice(elem.value))
  else if elem.value is TFhirAttachment {8} then
    ComposeAttachment(xml, 'valueAttachment', TFhirAttachment(elem.value))
  else if elem.value is TFhirRatio {8} then
    ComposeRatio(xml, 'valueRatio', TFhirRatio(elem.value))
  else if elem.value is TFhirSampledData {8} then
    ComposeSampledData(xml, 'valueSampledData', TFhirSampledData(elem.value))
  else if elem.value is TFhirResourceReference {8} then
    ComposeResourceReference(xml, 'valueResource', TFhirResourceReference(elem.value))
  else if elem.value is TFhirCodeableConcept {8} then
    ComposeCodeableConcept(xml, 'valueCodeableConcept', TFhirCodeableConcept(elem.value))
  else if elem.value is TFhirIdentifier {8} then
    ComposeIdentifier(xml, 'valueIdentifier', TFhirIdentifier(elem.value))
  else if elem.value is TFhirSchedule {9} then
    ComposeSchedule(xml, 'valueSchedule', TFhirSchedule(elem.value))
  else if elem.value is TFhirContact {9} then
    ComposeContact(xml, 'valueContact', TFhirContact(elem.value))
  else if elem.value is TFhirAddress {9} then
    ComposeAddress(xml, 'valueAddress', TFhirAddress(elem.value))
  else if elem.value is TFhirHumanName {9} then
    ComposeHumanName(xml, 'valueHumanName', TFhirHumanName(elem.value));
  if elem.example is TFhirInteger {1} then
    ComposeInteger(xml, 'exampleInteger', TFhirInteger(elem.example))
  else if elem.example is TFhirDateTime {1} then
    ComposeDateTime(xml, 'exampleDateTime', TFhirDateTime(elem.example))
  else if elem.example is TFhirCode {1} then
    ComposeCode(xml, 'exampleCode', TFhirCode(elem.example))
  else if elem.example is TFhirDate {1} then
    ComposeDate(xml, 'exampleDate', TFhirDate(elem.example))
  else if elem.example is TFhirDecimal {1} then
    ComposeDecimal(xml, 'exampleDecimal', TFhirDecimal(elem.example))
  else if elem.example is TFhirUri {1} then
    ComposeUri(xml, 'exampleUri', TFhirUri(elem.example))
  else if elem.example is TFhirId {1} then
    ComposeId(xml, 'exampleId', TFhirId(elem.example))
  else if elem.example is TFhirBase64Binary {1} then
    ComposeBase64Binary(xml, 'exampleBase64Binary', TFhirBase64Binary(elem.example))
  else if elem.example is TFhirOid {1} then
    ComposeOid(xml, 'exampleOid', TFhirOid(elem.example))
  else if elem.example is TFhirString {1} then
    ComposeString(xml, 'exampleString', TFhirString(elem.example))
  else if elem.example is TFhirBoolean {1} then
    ComposeBoolean(xml, 'exampleBoolean', TFhirBoolean(elem.example))
  else if elem.example is TFhirUuid {1} then
    ComposeUuid(xml, 'exampleUuid', TFhirUuid(elem.example))
  else if elem.example is TFhirInstant {1} then
    ComposeInstant(xml, 'exampleInstant', TFhirInstant(elem.example))
  else if elem.example is TFhirPeriod {8} then
    ComposePeriod(xml, 'examplePeriod', TFhirPeriod(elem.example))
  else if elem.example is TFhirCoding {8} then
    ComposeCoding(xml, 'exampleCoding', TFhirCoding(elem.example))
  else if elem.example is TFhirRange {8} then
    ComposeRange(xml, 'exampleRange', TFhirRange(elem.example))
  else if elem.example is TFhirQuantity {8} then
    ComposeQuantity(xml, 'exampleQuantity', TFhirQuantity(elem.example))
  else if elem.example is TFhirChoice {8} then
    ComposeChoice(xml, 'exampleChoice', TFhirChoice(elem.example))
  else if elem.example is TFhirAttachment {8} then
    ComposeAttachment(xml, 'exampleAttachment', TFhirAttachment(elem.example))
  else if elem.example is TFhirRatio {8} then
    ComposeRatio(xml, 'exampleRatio', TFhirRatio(elem.example))
  else if elem.example is TFhirSampledData {8} then
    ComposeSampledData(xml, 'exampleSampledData', TFhirSampledData(elem.example))
  else if elem.example is TFhirResourceReference {8} then
    ComposeResourceReference(xml, 'exampleResource', TFhirResourceReference(elem.example))
  else if elem.example is TFhirCodeableConcept {8} then
    ComposeCodeableConcept(xml, 'exampleCodeableConcept', TFhirCodeableConcept(elem.example))
  else if elem.example is TFhirIdentifier {8} then
    ComposeIdentifier(xml, 'exampleIdentifier', TFhirIdentifier(elem.example))
  else if elem.example is TFhirSchedule {9} then
    ComposeSchedule(xml, 'exampleSchedule', TFhirSchedule(elem.example))
  else if elem.example is TFhirContact {9} then
    ComposeContact(xml, 'exampleContact', TFhirContact(elem.example))
  else if elem.example is TFhirAddress {9} then
    ComposeAddress(xml, 'exampleAddress', TFhirAddress(elem.example))
  else if elem.example is TFhirHumanName {9} then
    ComposeHumanName(xml, 'exampleHumanName', TFhirHumanName(elem.example));
  ComposeInteger(xml, 'maxLength', elem.maxLength);
  for i := 0 to elem.conditionList.Count - 1 do
    ComposeId(xml, 'condition', elem.conditionList[i]);
  for i := 0 to elem.constraintList.Count - 1 do
    ComposeProfileStructureElementDefinitionConstraint(xml, 'constraint', elem.constraintList[i]);
  ComposeBoolean(xml, 'mustSupport', elem.mustSupport);
  ComposeBoolean(xml, 'isModifier', elem.isModifier);
  ComposeUri(xml, 'binding', elem.binding);
  for i := 0 to elem.mappingList.Count - 1 do
    ComposeProfileStructureElementDefinitionMapping(xml, 'mapping', elem.mappingList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProfileStructureElementDefinition : TFhirProfileStructureElementDefinition;
begin
  json.next;
  result := TFhirProfileStructureElementDefinition.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'short') then
        result.short := ParseString
      else if (json.ItemName = 'formal') then
        result.formal := ParseString
      else if (json.ItemName = 'comments') then
        result.comments := ParseString
      else if (json.ItemName = 'requirements') then
        result.requirements := ParseString
      else if (json.ItemName = 'synonym') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.synonymList.Add(ParseString);
          json.Next;
        end;
      end
      else if (json.ItemName = 'min') then
        result.min := ParseInteger
      else if (json.ItemName = 'max') then
        result.max := ParseString
      else if (json.ItemName = 'type') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.type_List.Add(ParseProfileStructureElementDefinitionType);
          json.Next;
        end;
      end
      else if (json.ItemName = 'nameReference') then
        result.nameReference := ParseString
      else if (json.ItemName = 'valueInteger') then
        result.value := ParseInteger
      else if (json.ItemName = 'valueDateTime') then
        result.value := ParseDateTime
      else if (json.ItemName = 'valueCode') then
        result.value := ParseCode
      else if (json.ItemName = 'valueDate') then
        result.value := ParseDate
      else if (json.ItemName = 'valueDecimal') then
        result.value := ParseDecimal
      else if (json.ItemName = 'valueUri') then
        result.value := ParseUri
      else if (json.ItemName = 'valueId') then
        result.value := ParseId
      else if (json.ItemName = 'valueBase64Binary') then
        result.value := ParseBase64Binary
      else if (json.ItemName = 'valueOid') then
        result.value := ParseOid
      else if (json.ItemName = 'valueString') then
        result.value := ParseString
      else if (json.ItemName = 'valueBoolean') then
        result.value := ParseBoolean
      else if (json.ItemName = 'valueUuid') then
        result.value := ParseUuid
      else if (json.ItemName = 'valueInstant') then
        result.value := ParseInstant
      else if (json.ItemName = 'valuePeriod') then
        result.value := ParsePeriod
      else if (json.ItemName = 'valueCoding') then
        result.value := ParseCoding
      else if (json.ItemName = 'valueRange') then
        result.value := ParseRange
      else if (json.ItemName = 'valueQuantity') then
        result.value := ParseQuantity
      else if (json.ItemName = 'valueChoice') then
        result.value := ParseChoice
      else if (json.ItemName = 'valueAttachment') then
        result.value := ParseAttachment
      else if (json.ItemName = 'valueRatio') then
        result.value := ParseRatio
      else if (json.ItemName = 'valueSampledData') then
        result.value := ParseSampledData
      else if (json.ItemName = 'valueResource') then
        result.value := ParseResourceReference
      else if (json.ItemName = 'valueCodeableConcept') then
        result.value := ParseCodeableConcept
      else if (json.ItemName = 'valueIdentifier') then
        result.value := ParseIdentifier
      else if (json.ItemName = 'valueSchedule') then
        result.value := ParseSchedule
      else if (json.ItemName = 'valueContact') then
        result.value := ParseContact
      else if (json.ItemName = 'valueAddress') then
        result.value := ParseAddress
      else if (json.ItemName = 'valueHumanName') then
        result.value := ParseHumanName
      else if (json.ItemName = 'exampleInteger') then
        result.example := ParseInteger
      else if (json.ItemName = 'exampleDateTime') then
        result.example := ParseDateTime
      else if (json.ItemName = 'exampleCode') then
        result.example := ParseCode
      else if (json.ItemName = 'exampleDate') then
        result.example := ParseDate
      else if (json.ItemName = 'exampleDecimal') then
        result.example := ParseDecimal
      else if (json.ItemName = 'exampleUri') then
        result.example := ParseUri
      else if (json.ItemName = 'exampleId') then
        result.example := ParseId
      else if (json.ItemName = 'exampleBase64Binary') then
        result.example := ParseBase64Binary
      else if (json.ItemName = 'exampleOid') then
        result.example := ParseOid
      else if (json.ItemName = 'exampleString') then
        result.example := ParseString
      else if (json.ItemName = 'exampleBoolean') then
        result.example := ParseBoolean
      else if (json.ItemName = 'exampleUuid') then
        result.example := ParseUuid
      else if (json.ItemName = 'exampleInstant') then
        result.example := ParseInstant
      else if (json.ItemName = 'examplePeriod') then
        result.example := ParsePeriod
      else if (json.ItemName = 'exampleCoding') then
        result.example := ParseCoding
      else if (json.ItemName = 'exampleRange') then
        result.example := ParseRange
      else if (json.ItemName = 'exampleQuantity') then
        result.example := ParseQuantity
      else if (json.ItemName = 'exampleChoice') then
        result.example := ParseChoice
      else if (json.ItemName = 'exampleAttachment') then
        result.example := ParseAttachment
      else if (json.ItemName = 'exampleRatio') then
        result.example := ParseRatio
      else if (json.ItemName = 'exampleSampledData') then
        result.example := ParseSampledData
      else if (json.ItemName = 'exampleResource') then
        result.example := ParseResourceReference
      else if (json.ItemName = 'exampleCodeableConcept') then
        result.example := ParseCodeableConcept
      else if (json.ItemName = 'exampleIdentifier') then
        result.example := ParseIdentifier
      else if (json.ItemName = 'exampleSchedule') then
        result.example := ParseSchedule
      else if (json.ItemName = 'exampleContact') then
        result.example := ParseContact
      else if (json.ItemName = 'exampleAddress') then
        result.example := ParseAddress
      else if (json.ItemName = 'exampleHumanName') then
        result.example := ParseHumanName
      else if (json.ItemName = 'maxLength') then
        result.maxLength := ParseInteger
      else if (json.ItemName = 'condition') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.conditionList.Add(ParseId);
          json.Next;
        end;
      end
      else if (json.ItemName = 'constraint') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.constraintList.Add(ParseProfileStructureElementDefinitionConstraint);
          json.Next;
        end;
      end
      else if (json.ItemName = 'mustSupport') then
        result.mustSupport := ParseBoolean
      else if (json.ItemName = 'isModifier') then
        result.isModifier := ParseBoolean
      else if (json.ItemName = 'binding') then
        result.binding := ParseUri
      else if (json.ItemName = 'mapping') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.mappingList.Add(ParseProfileStructureElementDefinitionMapping);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProfileStructureElementDefinition(json : TJSONWriter; name : string; elem : TFhirProfileStructureElementDefinition);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'short', elem.short);
  ComposeString(json, 'formal', elem.formal);
  ComposeString(json, 'comments', elem.comments);
  ComposeString(json, 'requirements', elem.requirements);
  if elem.synonymList.Count > 0 then
  begin
    json.valueArray('synonym');
    for i := 0 to elem.synonymList.Count - 1 do
      ComposeString(json, '',elem.synonymList[i]);
    json.FinishArray;
  end;
  ComposeInteger(json, 'min', elem.min);
  ComposeString(json, 'max', elem.max);
  if elem.type_List.Count > 0 then
  begin
    json.valueArray('type');
    for i := 0 to elem.type_List.Count - 1 do
      ComposeProfileStructureElementDefinitionType(json, '',elem.type_List[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'nameReference', elem.nameReference);
  if elem.value is TFhirInteger then
    ComposeInteger(json, 'valueInteger', TFhirInteger(elem.value))
  else if elem.value is TFhirDateTime then
    ComposeDateTime(json, 'valueDateTime', TFhirDateTime(elem.value))
  else if elem.value is TFhirCode then
    ComposeCode(json, 'valueCode', TFhirCode(elem.value))
  else if elem.value is TFhirDate then
    ComposeDate(json, 'valueDate', TFhirDate(elem.value))
  else if elem.value is TFhirDecimal then
    ComposeDecimal(json, 'valueDecimal', TFhirDecimal(elem.value))
  else if elem.value is TFhirUri then
    ComposeUri(json, 'valueUri', TFhirUri(elem.value))
  else if elem.value is TFhirId then
    ComposeId(json, 'valueId', TFhirId(elem.value))
  else if elem.value is TFhirBase64Binary then
    ComposeBase64Binary(json, 'valueBase64Binary', TFhirBase64Binary(elem.value))
  else if elem.value is TFhirOid then
    ComposeOid(json, 'valueOid', TFhirOid(elem.value))
  else if elem.value is TFhirString then
    ComposeString(json, 'valueString', TFhirString(elem.value))
  else if elem.value is TFhirBoolean then
    ComposeBoolean(json, 'valueBoolean', TFhirBoolean(elem.value))
  else if elem.value is TFhirUuid then
    ComposeUuid(json, 'valueUuid', TFhirUuid(elem.value))
  else if elem.value is TFhirInstant then
    ComposeInstant(json, 'valueInstant', TFhirInstant(elem.value))
  else if elem.value is TFhirPeriod then
    ComposePeriod(json, 'valuePeriod', TFhirPeriod(elem.value))
  else if elem.value is TFhirCoding then
    ComposeCoding(json, 'valueCoding', TFhirCoding(elem.value))
  else if elem.value is TFhirRange then
    ComposeRange(json, 'valueRange', TFhirRange(elem.value))
  else if elem.value is TFhirQuantity then
    ComposeQuantity(json, 'valueQuantity', TFhirQuantity(elem.value))
  else if elem.value is TFhirChoice then
    ComposeChoice(json, 'valueChoice', TFhirChoice(elem.value))
  else if elem.value is TFhirAttachment then
    ComposeAttachment(json, 'valueAttachment', TFhirAttachment(elem.value))
  else if elem.value is TFhirRatio then
    ComposeRatio(json, 'valueRatio', TFhirRatio(elem.value))
  else if elem.value is TFhirSampledData then
    ComposeSampledData(json, 'valueSampledData', TFhirSampledData(elem.value))
  else if elem.value is TFhirResourceReference then
    ComposeResourceReference(json, 'valueResource', TFhirResourceReference(elem.value))
  else if elem.value is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'valueCodeableConcept', TFhirCodeableConcept(elem.value))
  else if elem.value is TFhirIdentifier then
    ComposeIdentifier(json, 'valueIdentifier', TFhirIdentifier(elem.value))
  else if elem.value is TFhirSchedule then
    ComposeSchedule(json, 'valueSchedule', TFhirSchedule(elem.value))
  else if elem.value is TFhirContact then
    ComposeContact(json, 'valueContact', TFhirContact(elem.value))
  else if elem.value is TFhirAddress then
    ComposeAddress(json, 'valueAddress', TFhirAddress(elem.value))
  else if elem.value is TFhirHumanName then
    ComposeHumanName(json, 'valueHumanName', TFhirHumanName(elem.value));
  if elem.example is TFhirInteger then
    ComposeInteger(json, 'exampleInteger', TFhirInteger(elem.example))
  else if elem.example is TFhirDateTime then
    ComposeDateTime(json, 'exampleDateTime', TFhirDateTime(elem.example))
  else if elem.example is TFhirCode then
    ComposeCode(json, 'exampleCode', TFhirCode(elem.example))
  else if elem.example is TFhirDate then
    ComposeDate(json, 'exampleDate', TFhirDate(elem.example))
  else if elem.example is TFhirDecimal then
    ComposeDecimal(json, 'exampleDecimal', TFhirDecimal(elem.example))
  else if elem.example is TFhirUri then
    ComposeUri(json, 'exampleUri', TFhirUri(elem.example))
  else if elem.example is TFhirId then
    ComposeId(json, 'exampleId', TFhirId(elem.example))
  else if elem.example is TFhirBase64Binary then
    ComposeBase64Binary(json, 'exampleBase64Binary', TFhirBase64Binary(elem.example))
  else if elem.example is TFhirOid then
    ComposeOid(json, 'exampleOid', TFhirOid(elem.example))
  else if elem.example is TFhirString then
    ComposeString(json, 'exampleString', TFhirString(elem.example))
  else if elem.example is TFhirBoolean then
    ComposeBoolean(json, 'exampleBoolean', TFhirBoolean(elem.example))
  else if elem.example is TFhirUuid then
    ComposeUuid(json, 'exampleUuid', TFhirUuid(elem.example))
  else if elem.example is TFhirInstant then
    ComposeInstant(json, 'exampleInstant', TFhirInstant(elem.example))
  else if elem.example is TFhirPeriod then
    ComposePeriod(json, 'examplePeriod', TFhirPeriod(elem.example))
  else if elem.example is TFhirCoding then
    ComposeCoding(json, 'exampleCoding', TFhirCoding(elem.example))
  else if elem.example is TFhirRange then
    ComposeRange(json, 'exampleRange', TFhirRange(elem.example))
  else if elem.example is TFhirQuantity then
    ComposeQuantity(json, 'exampleQuantity', TFhirQuantity(elem.example))
  else if elem.example is TFhirChoice then
    ComposeChoice(json, 'exampleChoice', TFhirChoice(elem.example))
  else if elem.example is TFhirAttachment then
    ComposeAttachment(json, 'exampleAttachment', TFhirAttachment(elem.example))
  else if elem.example is TFhirRatio then
    ComposeRatio(json, 'exampleRatio', TFhirRatio(elem.example))
  else if elem.example is TFhirSampledData then
    ComposeSampledData(json, 'exampleSampledData', TFhirSampledData(elem.example))
  else if elem.example is TFhirResourceReference then
    ComposeResourceReference(json, 'exampleResource', TFhirResourceReference(elem.example))
  else if elem.example is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'exampleCodeableConcept', TFhirCodeableConcept(elem.example))
  else if elem.example is TFhirIdentifier then
    ComposeIdentifier(json, 'exampleIdentifier', TFhirIdentifier(elem.example))
  else if elem.example is TFhirSchedule then
    ComposeSchedule(json, 'exampleSchedule', TFhirSchedule(elem.example))
  else if elem.example is TFhirContact then
    ComposeContact(json, 'exampleContact', TFhirContact(elem.example))
  else if elem.example is TFhirAddress then
    ComposeAddress(json, 'exampleAddress', TFhirAddress(elem.example))
  else if elem.example is TFhirHumanName then
    ComposeHumanName(json, 'exampleHumanName', TFhirHumanName(elem.example));
  ComposeInteger(json, 'maxLength', elem.maxLength);
  if elem.conditionList.Count > 0 then
  begin
    json.valueArray('condition');
    for i := 0 to elem.conditionList.Count - 1 do
      ComposeId(json, '',elem.conditionList[i]);
    json.FinishArray;
  end;
  if elem.constraintList.Count > 0 then
  begin
    json.valueArray('constraint');
    for i := 0 to elem.constraintList.Count - 1 do
      ComposeProfileStructureElementDefinitionConstraint(json, '',elem.constraintList[i]);
    json.FinishArray;
  end;
  ComposeBoolean(json, 'mustSupport', elem.mustSupport);
  ComposeBoolean(json, 'isModifier', elem.isModifier);
  ComposeUri(json, 'binding', elem.binding);
  if elem.mappingList.Count > 0 then
  begin
    json.valueArray('mapping');
    for i := 0 to elem.mappingList.Count - 1 do
      ComposeProfileStructureElementDefinitionMapping(json, '',elem.mappingList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseProfileStructureElementDefinitionType(element : IXmlDomElement) : TFhirProfileStructureElementDefinitionType;
var
  child : IXMLDOMElement;
begin
  result := TFhirProfileStructureElementDefinitionType.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCode(child) {b}
      else if (child.baseName = 'profile') then
        result.profile := ParseUri(child) {b}
      else if (child.baseName = 'bundled') then
        result.bundled := ParseBoolean(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProfileStructureElementDefinitionType(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElementDefinitionType);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'code', elem.code);
  ComposeUri(xml, 'profile', elem.profile);
  ComposeBoolean(xml, 'bundled', elem.bundled);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProfileStructureElementDefinitionType : TFhirProfileStructureElementDefinitionType;
begin
  json.next;
  result := TFhirProfileStructureElementDefinitionType.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCode
      else if (json.ItemName = 'profile') then
        result.profile := ParseUri
      else if (json.ItemName = 'bundled') then
        result.bundled := ParseBoolean
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProfileStructureElementDefinitionType(json : TJSONWriter; name : string; elem : TFhirProfileStructureElementDefinitionType);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'code', elem.code);
  ComposeUri(json, 'profile', elem.profile);
  ComposeBoolean(json, 'bundled', elem.bundled);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProfileStructureElementDefinitionConstraint(element : IXmlDomElement) : TFhirProfileStructureElementDefinitionConstraint;
var
  child : IXMLDOMElement;
begin
  result := TFhirProfileStructureElementDefinitionConstraint.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'key') then
        result.key := ParseId(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'severity') then
        result.severity := ParseEnum(CODES_TFhirConstraintSeverity, child)
      else if (child.baseName = 'human') then
        result.human := ParseString(child) {b}
      else if (child.baseName = 'xpath') then
        result.xpath := ParseString(child) {b}
      else if (child.baseName = 'ocl') then
        result.ocl := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProfileStructureElementDefinitionConstraint(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElementDefinitionConstraint);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeId(xml, 'key', elem.key);
  ComposeString(xml, 'name', elem.name);
  ComposeEnum(xml, 'severity', elem.Severity, CODES_TFhirConstraintSeverity);
  ComposeString(xml, 'human', elem.human);
  ComposeString(xml, 'xpath', elem.xpath);
  ComposeString(xml, 'ocl', elem.ocl);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProfileStructureElementDefinitionConstraint : TFhirProfileStructureElementDefinitionConstraint;
begin
  json.next;
  result := TFhirProfileStructureElementDefinitionConstraint.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'key') then
        result.key := ParseId
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'severity') then
        result.severity := ParseEnum(CODES_TFhirConstraintSeverity)
      else if (json.ItemName = 'human') then
        result.human := ParseString
      else if (json.ItemName = 'xpath') then
        result.xpath := ParseString
      else if (json.ItemName = 'ocl') then
        result.ocl := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProfileStructureElementDefinitionConstraint(json : TJSONWriter; name : string; elem : TFhirProfileStructureElementDefinitionConstraint);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeId(json, 'key', elem.key);
  ComposeString(json, 'name', elem.name);
  ComposeEnum(json, 'severity', elem.Severity, CODES_TFhirConstraintSeverity);
  ComposeString(json, 'human', elem.human);
  ComposeString(json, 'xpath', elem.xpath);
  ComposeString(json, 'ocl', elem.ocl);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProfileStructureElementDefinitionMapping(element : IXmlDomElement) : TFhirProfileStructureElementDefinitionMapping;
var
  child : IXMLDOMElement;
begin
  result := TFhirProfileStructureElementDefinitionMapping.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'target') then
        result.target := ParseUri(child) {b}
      else if (child.baseName = 'map') then
        result.map := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProfileStructureElementDefinitionMapping(xml : TXmlBuilder; name : string; elem : TFhirProfileStructureElementDefinitionMapping);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeUri(xml, 'target', elem.target);
  ComposeString(xml, 'map', elem.map);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProfileStructureElementDefinitionMapping : TFhirProfileStructureElementDefinitionMapping;
begin
  json.next;
  result := TFhirProfileStructureElementDefinitionMapping.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'target') then
        result.target := ParseUri
      else if (json.ItemName = 'map') then
        result.map := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProfileStructureElementDefinitionMapping(json : TJSONWriter; name : string; elem : TFhirProfileStructureElementDefinitionMapping);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeUri(json, 'target', elem.target);
  ComposeString(json, 'map', elem.map);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProfileExtensionDefn(element : IXmlDomElement) : TFhirProfileExtensionDefn;
var
  child : IXMLDOMElement;
begin
  result := TFhirProfileExtensionDefn.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCode(child) {b}
      else if (child.baseName = 'contextType') then
        result.contextType := ParseEnum(CODES_TFhirExtensionContext, child)
      else if (child.baseName = 'context') then
        result.contextList.Add(ParseString(child))
      else if (child.baseName = 'definition') then
        result.definition := ParseProfileStructureElementDefinition(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProfileExtensionDefn(xml : TXmlBuilder; name : string; elem : TFhirProfileExtensionDefn);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'code', elem.code);
  ComposeEnum(xml, 'contextType', elem.ContextType, CODES_TFhirExtensionContext);
  for i := 0 to elem.contextList.Count - 1 do
    ComposeString(xml, 'context', elem.contextList[i]);
  ComposeProfileStructureElementDefinition(xml, 'definition', elem.definition);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProfileExtensionDefn : TFhirProfileExtensionDefn;
begin
  json.next;
  result := TFhirProfileExtensionDefn.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCode
      else if (json.ItemName = 'contextType') then
        result.contextType := ParseEnum(CODES_TFhirExtensionContext)
      else if (json.ItemName = 'context') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.contextList.Add(ParseString);
          json.Next;
        end;
      end
      else if (json.ItemName = 'definition') then
        result.definition := ParseProfileStructureElementDefinition
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProfileExtensionDefn(json : TJSONWriter; name : string; elem : TFhirProfileExtensionDefn);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'code', elem.code);
  ComposeEnum(json, 'contextType', elem.ContextType, CODES_TFhirExtensionContext);
  if elem.contextList.Count > 0 then
  begin
    json.valueArray('context');
    for i := 0 to elem.contextList.Count - 1 do
      ComposeString(json, '',elem.contextList[i]);
    json.FinishArray;
  end;
  ComposeProfileStructureElementDefinition(json, 'definition', elem.definition);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProfileBinding(element : IXmlDomElement) : TFhirProfileBinding;
var
  child : IXMLDOMElement;
begin
  result := TFhirProfileBinding.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'isExtensible') then
        result.isExtensible := ParseBoolean(child) {b}
      else if (child.baseName = 'conformance') then
        result.conformance := ParseEnum(CODES_TFhirBindingConformance, child)
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'referenceUri') then
        result.reference := ParseUri(child)
      else if (child.baseName = 'referenceResource') then
        result.reference := ParseResourceReference(child) {a}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProfileBinding(xml : TXmlBuilder; name : string; elem : TFhirProfileBinding);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'name', elem.name);
  ComposeBoolean(xml, 'isExtensible', elem.isExtensible);
  ComposeEnum(xml, 'conformance', elem.Conformance, CODES_TFhirBindingConformance);
  ComposeString(xml, 'description', elem.description);
  if elem.reference is TFhirUri {6} then
    ComposeUri(xml, 'referenceUri', TFhirUri(elem.reference))
  else if elem.reference is TFhirResourceReference {2} then
    ComposeResourceReference(xml, 'referenceResource', TFhirResourceReference(elem.reference));
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProfileBinding : TFhirProfileBinding;
begin
  json.next;
  result := TFhirProfileBinding.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'isExtensible') then
        result.isExtensible := ParseBoolean
      else if (json.ItemName = 'conformance') then
        result.conformance := ParseEnum(CODES_TFhirBindingConformance)
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'referenceUri') then
        result.reference := ParseUri
      else if (json.ItemName = 'referenceResource') then
        result.reference := ParseResourceReference
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProfileBinding(json : TJSONWriter; name : string; elem : TFhirProfileBinding);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'name', elem.name);
  ComposeBoolean(json, 'isExtensible', elem.isExtensible);
  ComposeEnum(json, 'conformance', elem.Conformance, CODES_TFhirBindingConformance);
  ComposeString(json, 'description', elem.description);
  if elem.reference is TFhirUri then
    ComposeUri(json, 'referenceUri', TFhirUri(elem.reference))
  else if elem.reference is TFhirResourceReference then
    ComposeResourceReference(json, 'referenceResource', TFhirResourceReference(elem.reference));
  json.finishObject;
end;

function TFHIRXmlParser.ParseProfile(element : IXmlDomElement) : TFhirProfile;
var
  child : IXMLDOMElement;
begin
  result := TFhirProfile.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseString(child) {b}
      else if (child.baseName = 'version') then
        result.version := ParseString(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'publisher') then
        result.publisher := ParseString(child) {b}
      else if (child.baseName = 'telecom') then
        result.telecomList.Add(ParseContact(child))
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'code') then
        result.codeList.Add(ParseCoding(child))
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirResourceProfileStatus, child)
      else if (child.baseName = 'experimental') then
        result.experimental := ParseBoolean(child) {b}
      else if (child.baseName = 'date') then
        result.date := ParseDateTime(child) {b}
      else if (child.baseName = 'fhirVersion') then
        result.fhirVersion := ParseId(child) {b}
      else if (child.baseName = 'structure') then
        result.structureList.Add(ParseProfileStructure(child))
      else if (child.baseName = 'extensionDefn') then
        result.extensionDefnList.Add(ParseProfileExtensionDefn(child))
      else if (child.baseName = 'binding') then
        result.bindingList.Add(ParseProfileBinding(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProfile(xml : TXmlBuilder; name : string; elem : TFhirProfile);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeString(xml, 'identifier', elem.identifier);
  ComposeString(xml, 'version', elem.version);
  ComposeString(xml, 'name', elem.name);
  ComposeString(xml, 'publisher', elem.publisher);
  for i := 0 to elem.telecomList.Count - 1 do
    ComposeContact(xml, 'telecom', elem.telecomList[i]);
  ComposeString(xml, 'description', elem.description);
  for i := 0 to elem.codeList.Count - 1 do
    ComposeCoding(xml, 'code', elem.codeList[i]);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirResourceProfileStatus);
  ComposeBoolean(xml, 'experimental', elem.experimental);
  ComposeDateTime(xml, 'date', elem.date);
  ComposeId(xml, 'fhirVersion', elem.fhirVersion);
  for i := 0 to elem.structureList.Count - 1 do
    ComposeProfileStructure(xml, 'structure', elem.structureList[i]);
  for i := 0 to elem.extensionDefnList.Count - 1 do
    ComposeProfileExtensionDefn(xml, 'extensionDefn', elem.extensionDefnList[i]);
  for i := 0 to elem.bindingList.Count - 1 do
    ComposeProfileBinding(xml, 'binding', elem.bindingList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProfile : TFhirProfile;
begin
  json.next;
  result := TFhirProfile.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseString
      else if (json.ItemName = 'version') then
        result.version := ParseString
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'publisher') then
        result.publisher := ParseString
      else if (json.ItemName = 'telecom') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.telecomList.Add(ParseContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'code') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.codeList.Add(ParseCoding);
          json.Next;
        end;
      end
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirResourceProfileStatus)
      else if (json.ItemName = 'experimental') then
        result.experimental := ParseBoolean
      else if (json.ItemName = 'date') then
        result.date := ParseDateTime
      else if (json.ItemName = 'fhirVersion') then
        result.fhirVersion := ParseId
      else if (json.ItemName = 'structure') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.structureList.Add(ParseProfileStructure);
          json.Next;
        end;
      end
      else if (json.ItemName = 'extensionDefn') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.extensionDefnList.Add(ParseProfileExtensionDefn);
          json.Next;
        end;
      end
      else if (json.ItemName = 'binding') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.bindingList.Add(ParseProfileBinding);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProfile(json : TJSONWriter; name : string; elem : TFhirProfile);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeString(json, 'identifier', elem.identifier);
  ComposeString(json, 'version', elem.version);
  ComposeString(json, 'name', elem.name);
  ComposeString(json, 'publisher', elem.publisher);
  if elem.telecomList.Count > 0 then
  begin
    json.valueArray('telecom');
    for i := 0 to elem.telecomList.Count - 1 do
      ComposeContact(json, '',elem.telecomList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'description', elem.description);
  if elem.codeList.Count > 0 then
  begin
    json.valueArray('code');
    for i := 0 to elem.codeList.Count - 1 do
      ComposeCoding(json, '',elem.codeList[i]);
    json.FinishArray;
  end;
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirResourceProfileStatus);
  ComposeBoolean(json, 'experimental', elem.experimental);
  ComposeDateTime(json, 'date', elem.date);
  ComposeId(json, 'fhirVersion', elem.fhirVersion);
  if elem.structureList.Count > 0 then
  begin
    json.valueArray('structure');
    for i := 0 to elem.structureList.Count - 1 do
      ComposeProfileStructure(json, '',elem.structureList[i]);
    json.FinishArray;
  end;
  if elem.extensionDefnList.Count > 0 then
  begin
    json.valueArray('extensionDefn');
    for i := 0 to elem.extensionDefnList.Count - 1 do
      ComposeProfileExtensionDefn(json, '',elem.extensionDefnList[i]);
    json.FinishArray;
  end;
  if elem.bindingList.Count > 0 then
  begin
    json.valueArray('binding');
    for i := 0 to elem.bindingList.Count - 1 do
      ComposeProfileBinding(json, '',elem.bindingList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseProvenanceAgent(element : IXmlDomElement) : TFhirProvenanceAgent;
var
  child : IXMLDOMElement;
begin
  result := TFhirProvenanceAgent.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'role') then
        result.role := ParseCoding(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCoding(child) {b}
      else if (child.baseName = 'reference') then
        result.reference := ParseUri(child) {b}
      else if (child.baseName = 'display') then
        result.display := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProvenanceAgent(xml : TXmlBuilder; name : string; elem : TFhirProvenanceAgent);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCoding(xml, 'role', elem.role);
  ComposeCoding(xml, 'type', elem.type_);
  ComposeUri(xml, 'reference', elem.reference);
  ComposeString(xml, 'display', elem.display);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProvenanceAgent : TFhirProvenanceAgent;
begin
  json.next;
  result := TFhirProvenanceAgent.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'role') then
        result.role := ParseCoding
      else if (json.ItemName = 'type') then
        result.type_ := ParseCoding
      else if (json.ItemName = 'reference') then
        result.reference := ParseUri
      else if (json.ItemName = 'display') then
        result.display := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProvenanceAgent(json : TJSONWriter; name : string; elem : TFhirProvenanceAgent);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCoding(json, 'role', elem.role);
  ComposeCoding(json, 'type', elem.type_);
  ComposeUri(json, 'reference', elem.reference);
  ComposeString(json, 'display', elem.display);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProvenanceEntity(element : IXmlDomElement) : TFhirProvenanceEntity;
var
  child : IXMLDOMElement;
begin
  result := TFhirProvenanceEntity.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'role') then
        result.role := ParseEnum(CODES_TFhirProvenanceEntityRole, child)
      else if (child.baseName = 'type') then
        result.type_ := ParseCoding(child) {b}
      else if (child.baseName = 'reference') then
        result.reference := ParseUri(child) {b}
      else if (child.baseName = 'display') then
        result.display := ParseString(child) {b}
      else if (child.baseName = 'agent') then
        result.agent := ParseProvenanceAgent(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProvenanceEntity(xml : TXmlBuilder; name : string; elem : TFhirProvenanceEntity);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'role', elem.Role, CODES_TFhirProvenanceEntityRole);
  ComposeCoding(xml, 'type', elem.type_);
  ComposeUri(xml, 'reference', elem.reference);
  ComposeString(xml, 'display', elem.display);
  ComposeProvenanceAgent(xml, 'agent', elem.agent);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProvenanceEntity : TFhirProvenanceEntity;
begin
  json.next;
  result := TFhirProvenanceEntity.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'role') then
        result.role := ParseEnum(CODES_TFhirProvenanceEntityRole)
      else if (json.ItemName = 'type') then
        result.type_ := ParseCoding
      else if (json.ItemName = 'reference') then
        result.reference := ParseUri
      else if (json.ItemName = 'display') then
        result.display := ParseString
      else if (json.ItemName = 'agent') then
        result.agent := ParseProvenanceAgent
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProvenanceEntity(json : TJSONWriter; name : string; elem : TFhirProvenanceEntity);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'role', elem.Role, CODES_TFhirProvenanceEntityRole);
  ComposeCoding(json, 'type', elem.type_);
  ComposeUri(json, 'reference', elem.reference);
  ComposeString(json, 'display', elem.display);
  ComposeProvenanceAgent(json, 'agent', elem.agent);
  json.finishObject;
end;

function TFHIRXmlParser.ParseProvenance(element : IXmlDomElement) : TFhirProvenance;
var
  child : IXMLDOMElement;
begin
  result := TFhirProvenance.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'target') then
        result.targetList.Add(ParseResourceReference{Resource}(child))
      else if (child.baseName = 'period') then
        result.period := ParsePeriod(child) {b}
      else if (child.baseName = 'recorded') then
        result.recorded := ParseInstant(child) {b}
      else if (child.baseName = 'reason') then
        result.reason := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'location') then
        result.location := ParseResourceReference{TFhirLocation}(child) {b}
      else if (child.baseName = 'policy') then
        result.policyList.Add(ParseUri(child))
      else if (child.baseName = 'agent') then
        result.agentList.Add(ParseProvenanceAgent(child))
      else if (child.baseName = 'entity') then
        result.entityList.Add(ParseProvenanceEntity(child))
      else if (child.baseName = 'signature') then
        result.signature := ParseString(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeProvenance(xml : TXmlBuilder; name : string; elem : TFhirProvenance);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  for i := 0 to elem.targetList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'target', elem.targetList[i]);
  ComposePeriod(xml, 'period', elem.period);
  ComposeInstant(xml, 'recorded', elem.recorded);
  ComposeCodeableConcept(xml, 'reason', elem.reason);
  ComposeResourceReference{TFhirLocation}(xml, 'location', elem.location);
  for i := 0 to elem.policyList.Count - 1 do
    ComposeUri(xml, 'policy', elem.policyList[i]);
  for i := 0 to elem.agentList.Count - 1 do
    ComposeProvenanceAgent(xml, 'agent', elem.agentList[i]);
  for i := 0 to elem.entityList.Count - 1 do
    ComposeProvenanceEntity(xml, 'entity', elem.entityList[i]);
  ComposeString(xml, 'signature', elem.signature);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseProvenance : TFhirProvenance;
begin
  json.next;
  result := TFhirProvenance.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'target') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.targetList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if (json.ItemName = 'period') then
        result.period := ParsePeriod
      else if (json.ItemName = 'recorded') then
        result.recorded := ParseInstant
      else if (json.ItemName = 'reason') then
        result.reason := ParseCodeableConcept
      else if (json.ItemName = 'location') then
        result.location := ParseResourceReference{TFhirLocation}
      else if (json.ItemName = 'policy') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.policyList.Add(ParseUri);
          json.Next;
        end;
      end
      else if (json.ItemName = 'agent') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.agentList.Add(ParseProvenanceAgent);
          json.Next;
        end;
      end
      else if (json.ItemName = 'entity') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.entityList.Add(ParseProvenanceEntity);
          json.Next;
        end;
      end
      else if (json.ItemName = 'signature') then
        result.signature := ParseString
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeProvenance(json : TJSONWriter; name : string; elem : TFhirProvenance);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  if elem.targetList.Count > 0 then
  begin
    json.valueArray('target');
    for i := 0 to elem.targetList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.targetList[i]);
    json.FinishArray;
  end;
  ComposePeriod(json, 'period', elem.period);
  ComposeInstant(json, 'recorded', elem.recorded);
  ComposeCodeableConcept(json, 'reason', elem.reason);
  ComposeResourceReference{TFhirLocation}(json, 'location', elem.location);
  if elem.policyList.Count > 0 then
  begin
    json.valueArray('policy');
    for i := 0 to elem.policyList.Count - 1 do
      ComposeUri(json, '',elem.policyList[i]);
    json.FinishArray;
  end;
  if elem.agentList.Count > 0 then
  begin
    json.valueArray('agent');
    for i := 0 to elem.agentList.Count - 1 do
      ComposeProvenanceAgent(json, '',elem.agentList[i]);
    json.FinishArray;
  end;
  if elem.entityList.Count > 0 then
  begin
    json.valueArray('entity');
    for i := 0 to elem.entityList.Count - 1 do
      ComposeProvenanceEntity(json, '',elem.entityList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'signature', elem.signature);
  json.finishObject;
end;

function TFHIRXmlParser.ParseQueryResponse(element : IXmlDomElement) : TFhirQueryResponse;
var
  child : IXMLDOMElement;
begin
  result := TFhirQueryResponse.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseUri(child) {b}
      else if (child.baseName = 'outcome') then
        result.outcome := ParseEnum(CODES_TFhirQueryOutcome, child)
      else if (child.baseName = 'total') then
        result.total := ParseInteger(child) {b}
      else if (child.baseName = 'parameter') then
        result.parameterList.Add(ParseExtension(child))
      else if (child.baseName = 'first') then
        result.firstList.Add(ParseExtension(child))
      else if (child.baseName = 'previous') then
        result.previousList.Add(ParseExtension(child))
      else if (child.baseName = 'next') then
        result.nextList.Add(ParseExtension(child))
      else if (child.baseName = 'last') then
        result.lastList.Add(ParseExtension(child))
      else if (child.baseName = 'reference') then
        result.referenceList.Add(ParseResourceReference{Resource}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeQueryResponse(xml : TXmlBuilder; name : string; elem : TFhirQueryResponse);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeUri(xml, 'identifier', elem.identifier);
  ComposeEnum(xml, 'outcome', elem.Outcome, CODES_TFhirQueryOutcome);
  ComposeInteger(xml, 'total', elem.total);
  for i := 0 to elem.parameterList.Count - 1 do
    ComposeExtension(xml, 'parameter', elem.parameterList[i]);
  for i := 0 to elem.firstList.Count - 1 do
    ComposeExtension(xml, 'first', elem.firstList[i]);
  for i := 0 to elem.previousList.Count - 1 do
    ComposeExtension(xml, 'previous', elem.previousList[i]);
  for i := 0 to elem.nextList.Count - 1 do
    ComposeExtension(xml, 'next', elem.nextList[i]);
  for i := 0 to elem.lastList.Count - 1 do
    ComposeExtension(xml, 'last', elem.lastList[i]);
  for i := 0 to elem.referenceList.Count - 1 do
    ComposeResourceReference{Resource}(xml, 'reference', elem.referenceList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseQueryResponse : TFhirQueryResponse;
begin
  json.next;
  result := TFhirQueryResponse.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseUri
      else if (json.ItemName = 'outcome') then
        result.outcome := ParseEnum(CODES_TFhirQueryOutcome)
      else if (json.ItemName = 'total') then
        result.total := ParseInteger
      else if (json.ItemName = 'parameter') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.parameterList.Add(ParseExtension);
          json.Next;
        end;
      end
      else if (json.ItemName = 'first') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.firstList.Add(ParseExtension);
          json.Next;
        end;
      end
      else if (json.ItemName = 'previous') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.previousList.Add(ParseExtension);
          json.Next;
        end;
      end
      else if (json.ItemName = 'next') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.nextList.Add(ParseExtension);
          json.Next;
        end;
      end
      else if (json.ItemName = 'last') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.lastList.Add(ParseExtension);
          json.Next;
        end;
      end
      else if (json.ItemName = 'reference') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.referenceList.Add(ParseResourceReference{Resource});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeQueryResponse(json : TJSONWriter; name : string; elem : TFhirQueryResponse);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeUri(json, 'identifier', elem.identifier);
  ComposeEnum(json, 'outcome', elem.Outcome, CODES_TFhirQueryOutcome);
  ComposeInteger(json, 'total', elem.total);
  if elem.parameterList.Count > 0 then
  begin
    json.valueArray('parameter');
    for i := 0 to elem.parameterList.Count - 1 do
      ComposeExtension(json, '',elem.parameterList[i]);
    json.FinishArray;
  end;
  if elem.firstList.Count > 0 then
  begin
    json.valueArray('first');
    for i := 0 to elem.firstList.Count - 1 do
      ComposeExtension(json, '',elem.firstList[i]);
    json.FinishArray;
  end;
  if elem.previousList.Count > 0 then
  begin
    json.valueArray('previous');
    for i := 0 to elem.previousList.Count - 1 do
      ComposeExtension(json, '',elem.previousList[i]);
    json.FinishArray;
  end;
  if elem.nextList.Count > 0 then
  begin
    json.valueArray('next');
    for i := 0 to elem.nextList.Count - 1 do
      ComposeExtension(json, '',elem.nextList[i]);
    json.FinishArray;
  end;
  if elem.lastList.Count > 0 then
  begin
    json.valueArray('last');
    for i := 0 to elem.lastList.Count - 1 do
      ComposeExtension(json, '',elem.lastList[i]);
    json.FinishArray;
  end;
  if elem.referenceList.Count > 0 then
  begin
    json.valueArray('reference');
    for i := 0 to elem.referenceList.Count - 1 do
      ComposeResourceReference{Resource}(json, '',elem.referenceList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseQuery(element : IXmlDomElement) : TFhirQuery;
var
  child : IXMLDOMElement;
begin
  result := TFhirQuery.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseUri(child) {b}
      else if (child.baseName = 'parameter') then
        result.parameterList.Add(ParseExtension(child))
      else if (child.baseName = 'response') then
        result.response := ParseQueryResponse(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeQuery(xml : TXmlBuilder; name : string; elem : TFhirQuery);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeUri(xml, 'identifier', elem.identifier);
  for i := 0 to elem.parameterList.Count - 1 do
    ComposeExtension(xml, 'parameter', elem.parameterList[i]);
  ComposeQueryResponse(xml, 'response', elem.response);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseQuery : TFhirQuery;
begin
  json.next;
  result := TFhirQuery.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseUri
      else if (json.ItemName = 'parameter') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.parameterList.Add(ParseExtension);
          json.Next;
        end;
      end
      else if (json.ItemName = 'response') then
        result.response := ParseQueryResponse
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeQuery(json : TJSONWriter; name : string; elem : TFhirQuery);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeUri(json, 'identifier', elem.identifier);
  if elem.parameterList.Count > 0 then
  begin
    json.valueArray('parameter');
    for i := 0 to elem.parameterList.Count - 1 do
      ComposeExtension(json, '',elem.parameterList[i]);
    json.FinishArray;
  end;
  ComposeQueryResponse(json, 'response', elem.response);
  json.finishObject;
end;

function TFHIRXmlParser.ParseQuestionnaireQuestion(element : IXmlDomElement) : TFhirQuestionnaireQuestion;
var
  child : IXMLDOMElement;
begin
  result := TFhirQuestionnaireQuestion.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'text') then
        result.text := ParseString(child) {b}
      else if (child.baseName = 'answerDecimal') then
        result.answer := ParseDecimal(child)
      else if (child.baseName = 'answerInteger') then
        result.answer := ParseInteger(child)
      else if (child.baseName = 'answerBoolean') then
        result.answer := ParseBoolean(child)
      else if (child.baseName = 'answerDate') then
        result.answer := ParseDate(child)
      else if (child.baseName = 'answerString') then
        result.answer := ParseString(child)
      else if (child.baseName = 'answerDateTime') then
        result.answer := ParseDateTime(child)
      else if (child.baseName = 'answerInstant') then
        result.answer := ParseInstant(child)
      else if (child.baseName = 'choice') then
        result.choiceList.Add(ParseCoding(child))
      else if (child.baseName = 'optionsUri') then
        result.options := ParseUri(child)
      else if (child.baseName = 'optionsResource') then
        result.options := ParseResourceReference(child) {a}
      else if (child.baseName = 'dataInteger') then
        result.data := ParseInteger(child) {c}
      else if (child.baseName = 'dataDateTime') then
        result.data := ParseDateTime(child) {c}
      else if (child.baseName = 'dataCode') then
        result.data := ParseCode(child) {c}
      else if (child.baseName = 'dataDate') then
        result.data := ParseDate(child) {c}
      else if (child.baseName = 'dataDecimal') then
        result.data := ParseDecimal(child) {c}
      else if (child.baseName = 'dataUri') then
        result.data := ParseUri(child) {c}
      else if (child.baseName = 'dataId') then
        result.data := ParseId(child) {c}
      else if (child.baseName = 'dataBase64Binary') then
        result.data := ParseBase64Binary(child) {c}
      else if (child.baseName = 'dataOid') then
        result.data := ParseOid(child) {c}
      else if (child.baseName = 'dataString') then
        result.data := ParseString(child) {c}
      else if (child.baseName = 'dataBoolean') then
        result.data := ParseBoolean(child) {c}
      else if (child.baseName = 'dataUuid') then
        result.data := ParseUuid(child) {c}
      else if (child.baseName = 'dataInstant') then
        result.data := ParseInstant(child) {c}
      else if (child.baseName = 'dataPeriod') then
        result.data := ParsePeriod(child) {ePeriod}
      else if (child.baseName = 'dataCoding') then
        result.data := ParseCoding(child) {eCoding}
      else if (child.baseName = 'dataRange') then
        result.data := ParseRange(child) {eRange}
      else if (child.baseName = 'dataQuantity') then
        result.data := ParseQuantity(child) {eQuantity}
      else if (child.baseName = 'dataChoice') then
        result.data := ParseChoice(child) {eChoice}
      else if (child.baseName = 'dataAttachment') then
        result.data := ParseAttachment(child) {eAttachment}
      else if (child.baseName = 'dataRatio') then
        result.data := ParseRatio(child) {eRatio}
      else if (child.baseName = 'dataSampledData') then
        result.data := ParseSampledData(child) {eSampledData}
      else if (child.baseName = 'dataResource') then
        result.data := ParseResourceReference(child) {e0}
      else if (child.baseName = 'dataCodeableConcept') then
        result.data := ParseCodeableConcept(child) {eCodeableConcept}
      else if (child.baseName = 'dataIdentifier') then
        result.data := ParseIdentifier(child) {eIdentifier}
      else if (child.baseName = 'dataSchedule') then
        result.data := ParseSchedule(child) {f}
      else if (child.baseName = 'dataContact') then
        result.data := ParseContact(child) {f}
      else if (child.baseName = 'dataAddress') then
        result.data := ParseAddress(child) {f}
      else if (child.baseName = 'dataHumanName') then
        result.data := ParseHumanName(child) {f}
      else if (child.baseName = 'remarks') then
        result.remarks := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeQuestionnaireQuestion(xml : TXmlBuilder; name : string; elem : TFhirQuestionnaireQuestion);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'name', elem.name);
  ComposeString(xml, 'text', elem.text);
  if elem.answer is TFhirDecimal {6} then
    ComposeDecimal(xml, 'answerDecimal', TFhirDecimal(elem.answer))
  else if elem.answer is TFhirInteger {6} then
    ComposeInteger(xml, 'answerInteger', TFhirInteger(elem.answer))
  else if elem.answer is TFhirBoolean {6} then
    ComposeBoolean(xml, 'answerBoolean', TFhirBoolean(elem.answer))
  else if elem.answer is TFhirDate {6} then
    ComposeDate(xml, 'answerDate', TFhirDate(elem.answer))
  else if elem.answer is TFhirString {6} then
    ComposeString(xml, 'answerString', TFhirString(elem.answer))
  else if elem.answer is TFhirDateTime {6} then
    ComposeDateTime(xml, 'answerDateTime', TFhirDateTime(elem.answer))
  else if elem.answer is TFhirInstant {6} then
    ComposeInstant(xml, 'answerInstant', TFhirInstant(elem.answer));
  for i := 0 to elem.choiceList.Count - 1 do
    ComposeCoding(xml, 'choice', elem.choiceList[i]);
  if elem.options is TFhirUri {6} then
    ComposeUri(xml, 'optionsUri', TFhirUri(elem.options))
  else if elem.options is TFhirResourceReference {2} then
    ComposeResourceReference(xml, 'optionsResource', TFhirResourceReference(elem.options));
  if elem.data is TFhirInteger {1} then
    ComposeInteger(xml, 'dataInteger', TFhirInteger(elem.data))
  else if elem.data is TFhirDateTime {1} then
    ComposeDateTime(xml, 'dataDateTime', TFhirDateTime(elem.data))
  else if elem.data is TFhirCode {1} then
    ComposeCode(xml, 'dataCode', TFhirCode(elem.data))
  else if elem.data is TFhirDate {1} then
    ComposeDate(xml, 'dataDate', TFhirDate(elem.data))
  else if elem.data is TFhirDecimal {1} then
    ComposeDecimal(xml, 'dataDecimal', TFhirDecimal(elem.data))
  else if elem.data is TFhirUri {1} then
    ComposeUri(xml, 'dataUri', TFhirUri(elem.data))
  else if elem.data is TFhirId {1} then
    ComposeId(xml, 'dataId', TFhirId(elem.data))
  else if elem.data is TFhirBase64Binary {1} then
    ComposeBase64Binary(xml, 'dataBase64Binary', TFhirBase64Binary(elem.data))
  else if elem.data is TFhirOid {1} then
    ComposeOid(xml, 'dataOid', TFhirOid(elem.data))
  else if elem.data is TFhirString {1} then
    ComposeString(xml, 'dataString', TFhirString(elem.data))
  else if elem.data is TFhirBoolean {1} then
    ComposeBoolean(xml, 'dataBoolean', TFhirBoolean(elem.data))
  else if elem.data is TFhirUuid {1} then
    ComposeUuid(xml, 'dataUuid', TFhirUuid(elem.data))
  else if elem.data is TFhirInstant {1} then
    ComposeInstant(xml, 'dataInstant', TFhirInstant(elem.data))
  else if elem.data is TFhirPeriod {8} then
    ComposePeriod(xml, 'dataPeriod', TFhirPeriod(elem.data))
  else if elem.data is TFhirCoding {8} then
    ComposeCoding(xml, 'dataCoding', TFhirCoding(elem.data))
  else if elem.data is TFhirRange {8} then
    ComposeRange(xml, 'dataRange', TFhirRange(elem.data))
  else if elem.data is TFhirQuantity {8} then
    ComposeQuantity(xml, 'dataQuantity', TFhirQuantity(elem.data))
  else if elem.data is TFhirChoice {8} then
    ComposeChoice(xml, 'dataChoice', TFhirChoice(elem.data))
  else if elem.data is TFhirAttachment {8} then
    ComposeAttachment(xml, 'dataAttachment', TFhirAttachment(elem.data))
  else if elem.data is TFhirRatio {8} then
    ComposeRatio(xml, 'dataRatio', TFhirRatio(elem.data))
  else if elem.data is TFhirSampledData {8} then
    ComposeSampledData(xml, 'dataSampledData', TFhirSampledData(elem.data))
  else if elem.data is TFhirResourceReference {8} then
    ComposeResourceReference(xml, 'dataResource', TFhirResourceReference(elem.data))
  else if elem.data is TFhirCodeableConcept {8} then
    ComposeCodeableConcept(xml, 'dataCodeableConcept', TFhirCodeableConcept(elem.data))
  else if elem.data is TFhirIdentifier {8} then
    ComposeIdentifier(xml, 'dataIdentifier', TFhirIdentifier(elem.data))
  else if elem.data is TFhirSchedule {9} then
    ComposeSchedule(xml, 'dataSchedule', TFhirSchedule(elem.data))
  else if elem.data is TFhirContact {9} then
    ComposeContact(xml, 'dataContact', TFhirContact(elem.data))
  else if elem.data is TFhirAddress {9} then
    ComposeAddress(xml, 'dataAddress', TFhirAddress(elem.data))
  else if elem.data is TFhirHumanName {9} then
    ComposeHumanName(xml, 'dataHumanName', TFhirHumanName(elem.data));
  ComposeString(xml, 'remarks', elem.remarks);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseQuestionnaireQuestion : TFhirQuestionnaireQuestion;
begin
  json.next;
  result := TFhirQuestionnaireQuestion.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseCodeableConcept
      else if (json.ItemName = 'text') then
        result.text := ParseString
      else if (json.ItemName = 'answerDecimal') then
        result.answer := ParseDecimal
      else if (json.ItemName = 'answerInteger') then
        result.answer := ParseInteger
      else if (json.ItemName = 'answerBoolean') then
        result.answer := ParseBoolean
      else if (json.ItemName = 'answerDate') then
        result.answer := ParseDate
      else if (json.ItemName = 'answerString') then
        result.answer := ParseString
      else if (json.ItemName = 'answerDateTime') then
        result.answer := ParseDateTime
      else if (json.ItemName = 'answerInstant') then
        result.answer := ParseInstant
      else if (json.ItemName = 'choice') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.choiceList.Add(ParseCoding);
          json.Next;
        end;
      end
      else if (json.ItemName = 'optionsUri') then
        result.options := ParseUri
      else if (json.ItemName = 'optionsResource') then
        result.options := ParseResourceReference
      else if (json.ItemName = 'dataInteger') then
        result.data := ParseInteger
      else if (json.ItemName = 'dataDateTime') then
        result.data := ParseDateTime
      else if (json.ItemName = 'dataCode') then
        result.data := ParseCode
      else if (json.ItemName = 'dataDate') then
        result.data := ParseDate
      else if (json.ItemName = 'dataDecimal') then
        result.data := ParseDecimal
      else if (json.ItemName = 'dataUri') then
        result.data := ParseUri
      else if (json.ItemName = 'dataId') then
        result.data := ParseId
      else if (json.ItemName = 'dataBase64Binary') then
        result.data := ParseBase64Binary
      else if (json.ItemName = 'dataOid') then
        result.data := ParseOid
      else if (json.ItemName = 'dataString') then
        result.data := ParseString
      else if (json.ItemName = 'dataBoolean') then
        result.data := ParseBoolean
      else if (json.ItemName = 'dataUuid') then
        result.data := ParseUuid
      else if (json.ItemName = 'dataInstant') then
        result.data := ParseInstant
      else if (json.ItemName = 'dataPeriod') then
        result.data := ParsePeriod
      else if (json.ItemName = 'dataCoding') then
        result.data := ParseCoding
      else if (json.ItemName = 'dataRange') then
        result.data := ParseRange
      else if (json.ItemName = 'dataQuantity') then
        result.data := ParseQuantity
      else if (json.ItemName = 'dataChoice') then
        result.data := ParseChoice
      else if (json.ItemName = 'dataAttachment') then
        result.data := ParseAttachment
      else if (json.ItemName = 'dataRatio') then
        result.data := ParseRatio
      else if (json.ItemName = 'dataSampledData') then
        result.data := ParseSampledData
      else if (json.ItemName = 'dataResource') then
        result.data := ParseResourceReference
      else if (json.ItemName = 'dataCodeableConcept') then
        result.data := ParseCodeableConcept
      else if (json.ItemName = 'dataIdentifier') then
        result.data := ParseIdentifier
      else if (json.ItemName = 'dataSchedule') then
        result.data := ParseSchedule
      else if (json.ItemName = 'dataContact') then
        result.data := ParseContact
      else if (json.ItemName = 'dataAddress') then
        result.data := ParseAddress
      else if (json.ItemName = 'dataHumanName') then
        result.data := ParseHumanName
      else if (json.ItemName = 'remarks') then
        result.remarks := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeQuestionnaireQuestion(json : TJSONWriter; name : string; elem : TFhirQuestionnaireQuestion);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'name', elem.name);
  ComposeString(json, 'text', elem.text);
  if elem.answer is TFhirDecimal then
    ComposeDecimal(json, 'answerDecimal', TFhirDecimal(elem.answer))
  else if elem.answer is TFhirInteger then
    ComposeInteger(json, 'answerInteger', TFhirInteger(elem.answer))
  else if elem.answer is TFhirBoolean then
    ComposeBoolean(json, 'answerBoolean', TFhirBoolean(elem.answer))
  else if elem.answer is TFhirDate then
    ComposeDate(json, 'answerDate', TFhirDate(elem.answer))
  else if elem.answer is TFhirString then
    ComposeString(json, 'answerString', TFhirString(elem.answer))
  else if elem.answer is TFhirDateTime then
    ComposeDateTime(json, 'answerDateTime', TFhirDateTime(elem.answer))
  else if elem.answer is TFhirInstant then
    ComposeInstant(json, 'answerInstant', TFhirInstant(elem.answer));
  if elem.choiceList.Count > 0 then
  begin
    json.valueArray('choice');
    for i := 0 to elem.choiceList.Count - 1 do
      ComposeCoding(json, '',elem.choiceList[i]);
    json.FinishArray;
  end;
  if elem.options is TFhirUri then
    ComposeUri(json, 'optionsUri', TFhirUri(elem.options))
  else if elem.options is TFhirResourceReference then
    ComposeResourceReference(json, 'optionsResource', TFhirResourceReference(elem.options));
  if elem.data is TFhirInteger then
    ComposeInteger(json, 'dataInteger', TFhirInteger(elem.data))
  else if elem.data is TFhirDateTime then
    ComposeDateTime(json, 'dataDateTime', TFhirDateTime(elem.data))
  else if elem.data is TFhirCode then
    ComposeCode(json, 'dataCode', TFhirCode(elem.data))
  else if elem.data is TFhirDate then
    ComposeDate(json, 'dataDate', TFhirDate(elem.data))
  else if elem.data is TFhirDecimal then
    ComposeDecimal(json, 'dataDecimal', TFhirDecimal(elem.data))
  else if elem.data is TFhirUri then
    ComposeUri(json, 'dataUri', TFhirUri(elem.data))
  else if elem.data is TFhirId then
    ComposeId(json, 'dataId', TFhirId(elem.data))
  else if elem.data is TFhirBase64Binary then
    ComposeBase64Binary(json, 'dataBase64Binary', TFhirBase64Binary(elem.data))
  else if elem.data is TFhirOid then
    ComposeOid(json, 'dataOid', TFhirOid(elem.data))
  else if elem.data is TFhirString then
    ComposeString(json, 'dataString', TFhirString(elem.data))
  else if elem.data is TFhirBoolean then
    ComposeBoolean(json, 'dataBoolean', TFhirBoolean(elem.data))
  else if elem.data is TFhirUuid then
    ComposeUuid(json, 'dataUuid', TFhirUuid(elem.data))
  else if elem.data is TFhirInstant then
    ComposeInstant(json, 'dataInstant', TFhirInstant(elem.data))
  else if elem.data is TFhirPeriod then
    ComposePeriod(json, 'dataPeriod', TFhirPeriod(elem.data))
  else if elem.data is TFhirCoding then
    ComposeCoding(json, 'dataCoding', TFhirCoding(elem.data))
  else if elem.data is TFhirRange then
    ComposeRange(json, 'dataRange', TFhirRange(elem.data))
  else if elem.data is TFhirQuantity then
    ComposeQuantity(json, 'dataQuantity', TFhirQuantity(elem.data))
  else if elem.data is TFhirChoice then
    ComposeChoice(json, 'dataChoice', TFhirChoice(elem.data))
  else if elem.data is TFhirAttachment then
    ComposeAttachment(json, 'dataAttachment', TFhirAttachment(elem.data))
  else if elem.data is TFhirRatio then
    ComposeRatio(json, 'dataRatio', TFhirRatio(elem.data))
  else if elem.data is TFhirSampledData then
    ComposeSampledData(json, 'dataSampledData', TFhirSampledData(elem.data))
  else if elem.data is TFhirResourceReference then
    ComposeResourceReference(json, 'dataResource', TFhirResourceReference(elem.data))
  else if elem.data is TFhirCodeableConcept then
    ComposeCodeableConcept(json, 'dataCodeableConcept', TFhirCodeableConcept(elem.data))
  else if elem.data is TFhirIdentifier then
    ComposeIdentifier(json, 'dataIdentifier', TFhirIdentifier(elem.data))
  else if elem.data is TFhirSchedule then
    ComposeSchedule(json, 'dataSchedule', TFhirSchedule(elem.data))
  else if elem.data is TFhirContact then
    ComposeContact(json, 'dataContact', TFhirContact(elem.data))
  else if elem.data is TFhirAddress then
    ComposeAddress(json, 'dataAddress', TFhirAddress(elem.data))
  else if elem.data is TFhirHumanName then
    ComposeHumanName(json, 'dataHumanName', TFhirHumanName(elem.data));
  ComposeString(json, 'remarks', elem.remarks);
  json.finishObject;
end;

function TFHIRXmlParser.ParseQuestionnaireGroup(element : IXmlDomElement) : TFhirQuestionnaireGroup;
var
  child : IXMLDOMElement;
begin
  result := TFhirQuestionnaireGroup.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'header') then
        result.header := ParseString(child) {b}
      else if (child.baseName = 'text') then
        result.text := ParseString(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'question') then
        result.questionList.Add(ParseQuestionnaireQuestion(child))
      else if (child.baseName = 'group') then
        result.groupList.Add(ParseQuestionnaireGroup(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeQuestionnaireGroup(xml : TXmlBuilder; name : string; elem : TFhirQuestionnaireGroup);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'name', elem.name);
  ComposeString(xml, 'header', elem.header);
  ComposeString(xml, 'text', elem.text);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  for i := 0 to elem.questionList.Count - 1 do
    ComposeQuestionnaireQuestion(xml, 'question', elem.questionList[i]);
  for i := 0 to elem.groupList.Count - 1 do
    ComposeQuestionnaireGroup(xml, 'group', elem.groupList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseQuestionnaireGroup : TFhirQuestionnaireGroup;
begin
  json.next;
  result := TFhirQuestionnaireGroup.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseCodeableConcept
      else if (json.ItemName = 'header') then
        result.header := ParseString
      else if (json.ItemName = 'text') then
        result.text := ParseString
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'question') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.questionList.Add(ParseQuestionnaireQuestion);
          json.Next;
        end;
      end
      else if (json.ItemName = 'group') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.groupList.Add(ParseQuestionnaireGroup);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeQuestionnaireGroup(json : TJSONWriter; name : string; elem : TFhirQuestionnaireGroup);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'name', elem.name);
  ComposeString(json, 'header', elem.header);
  ComposeString(json, 'text', elem.text);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  if elem.questionList.Count > 0 then
  begin
    json.valueArray('question');
    for i := 0 to elem.questionList.Count - 1 do
      ComposeQuestionnaireQuestion(json, '',elem.questionList[i]);
    json.FinishArray;
  end;
  if elem.groupList.Count > 0 then
  begin
    json.valueArray('group');
    for i := 0 to elem.groupList.Count - 1 do
      ComposeQuestionnaireGroup(json, '',elem.groupList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseQuestionnaire(element : IXmlDomElement) : TFhirQuestionnaire;
var
  child : IXMLDOMElement;
begin
  result := TFhirQuestionnaire.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirObservationStatus, child)
      else if (child.baseName = 'authored') then
        result.authored := ParseDateTime(child) {b}
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'author') then
        result.author := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'source') then
        result.source := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}(child) {b}
      else if (child.baseName = 'question') then
        result.questionList.Add(ParseQuestionnaireQuestion(child))
      else if (child.baseName = 'group') then
        result.groupList.Add(ParseQuestionnaireGroup(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeQuestionnaire(xml : TXmlBuilder; name : string; elem : TFhirQuestionnaire);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirObservationStatus);
  ComposeDateTime(xml, 'authored', elem.authored);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  ComposeResourceReference{Resource}(xml, 'author', elem.author);
  ComposeResourceReference{Resource}(xml, 'source', elem.source);
  ComposeCodeableConcept(xml, 'name', elem.name);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeResourceReference{TFhirEncounter}(xml, 'encounter', elem.encounter);
  for i := 0 to elem.questionList.Count - 1 do
    ComposeQuestionnaireQuestion(xml, 'question', elem.questionList[i]);
  for i := 0 to elem.groupList.Count - 1 do
    ComposeQuestionnaireGroup(xml, 'group', elem.groupList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseQuestionnaire : TFhirQuestionnaire;
begin
  json.next;
  result := TFhirQuestionnaire.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirObservationStatus)
      else if (json.ItemName = 'authored') then
        result.authored := ParseDateTime
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'author') then
        result.author := ParseResourceReference{Resource}
      else if (json.ItemName = 'source') then
        result.source := ParseResourceReference{Resource}
      else if (json.ItemName = 'name') then
        result.name := ParseCodeableConcept
      else if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'encounter') then
        result.encounter := ParseResourceReference{TFhirEncounter}
      else if (json.ItemName = 'question') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.questionList.Add(ParseQuestionnaireQuestion);
          json.Next;
        end;
      end
      else if (json.ItemName = 'group') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.groupList.Add(ParseQuestionnaireGroup);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeQuestionnaire(json : TJSONWriter; name : string; elem : TFhirQuestionnaire);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirObservationStatus);
  ComposeDateTime(json, 'authored', elem.authored);
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  ComposeResourceReference{Resource}(json, 'author', elem.author);
  ComposeResourceReference{Resource}(json, 'source', elem.source);
  ComposeCodeableConcept(json, 'name', elem.name);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeResourceReference{TFhirEncounter}(json, 'encounter', elem.encounter);
  if elem.questionList.Count > 0 then
  begin
    json.valueArray('question');
    for i := 0 to elem.questionList.Count - 1 do
      ComposeQuestionnaireQuestion(json, '',elem.questionList[i]);
    json.FinishArray;
  end;
  if elem.groupList.Count > 0 then
  begin
    json.valueArray('group');
    for i := 0 to elem.groupList.Count - 1 do
      ComposeQuestionnaireGroup(json, '',elem.groupList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseRelatedPerson(element : IXmlDomElement) : TFhirRelatedPerson;
var
  child : IXMLDOMElement;
begin
  result := TFhirRelatedPerson.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'relationship') then
        result.relationship := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseHumanName(child) {b}
      else if (child.baseName = 'telecom') then
        result.telecomList.Add(ParseContact(child))
      else if (child.baseName = 'gender') then
        result.gender := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'address') then
        result.address := ParseAddress(child) {b}
      else if (child.baseName = 'photo') then
        result.photoList.Add(ParseAttachment(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeRelatedPerson(xml : TXmlBuilder; name : string; elem : TFhirRelatedPerson);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeResourceReference{TFhirPatient}(xml, 'patient', elem.patient);
  ComposeCodeableConcept(xml, 'relationship', elem.relationship);
  ComposeHumanName(xml, 'name', elem.name);
  for i := 0 to elem.telecomList.Count - 1 do
    ComposeContact(xml, 'telecom', elem.telecomList[i]);
  ComposeCodeableConcept(xml, 'gender', elem.gender);
  ComposeAddress(xml, 'address', elem.address);
  for i := 0 to elem.photoList.Count - 1 do
    ComposeAttachment(xml, 'photo', elem.photoList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseRelatedPerson : TFhirRelatedPerson;
begin
  json.next;
  result := TFhirRelatedPerson.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'relationship') then
        result.relationship := ParseCodeableConcept
      else if (json.ItemName = 'name') then
        result.name := ParseHumanName
      else if (json.ItemName = 'telecom') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.telecomList.Add(ParseContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'gender') then
        result.gender := ParseCodeableConcept
      else if (json.ItemName = 'address') then
        result.address := ParseAddress
      else if (json.ItemName = 'photo') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.photoList.Add(ParseAttachment);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeRelatedPerson(json : TJSONWriter; name : string; elem : TFhirRelatedPerson);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{TFhirPatient}(json, 'patient', elem.patient);
  ComposeCodeableConcept(json, 'relationship', elem.relationship);
  ComposeHumanName(json, 'name', elem.name);
  if elem.telecomList.Count > 0 then
  begin
    json.valueArray('telecom');
    for i := 0 to elem.telecomList.Count - 1 do
      ComposeContact(json, '',elem.telecomList[i]);
    json.FinishArray;
  end;
  ComposeCodeableConcept(json, 'gender', elem.gender);
  ComposeAddress(json, 'address', elem.address);
  if elem.photoList.Count > 0 then
  begin
    json.valueArray('photo');
    for i := 0 to elem.photoList.Count - 1 do
      ComposeAttachment(json, '',elem.photoList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseSecurityEventEvent(element : IXmlDomElement) : TFhirSecurityEventEvent;
var
  child : IXMLDOMElement;
begin
  result := TFhirSecurityEventEvent.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'subtype') then
        result.subtypeList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'action') then
        result.action := ParseEnum(CODES_TFhirSecurityEventAction, child)
      else if (child.baseName = 'dateTime') then
        result.dateTime := ParseInstant(child) {b}
      else if (child.baseName = 'outcome') then
        result.outcome := ParseEnum(CODES_TFhirSecurityEventOutcome, child)
      else if (child.baseName = 'outcomeDesc') then
        result.outcomeDesc := ParseString(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSecurityEventEvent(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventEvent);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  for i := 0 to elem.subtypeList.Count - 1 do
    ComposeCodeableConcept(xml, 'subtype', elem.subtypeList[i]);
  ComposeEnum(xml, 'action', elem.Action, CODES_TFhirSecurityEventAction);
  ComposeInstant(xml, 'dateTime', elem.dateTime);
  ComposeEnum(xml, 'outcome', elem.Outcome, CODES_TFhirSecurityEventOutcome);
  ComposeString(xml, 'outcomeDesc', elem.outcomeDesc);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSecurityEventEvent : TFhirSecurityEventEvent;
begin
  json.next;
  result := TFhirSecurityEventEvent.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'subtype') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.subtypeList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'action') then
        result.action := ParseEnum(CODES_TFhirSecurityEventAction)
      else if (json.ItemName = 'dateTime') then
        result.dateTime := ParseInstant
      else if (json.ItemName = 'outcome') then
        result.outcome := ParseEnum(CODES_TFhirSecurityEventOutcome)
      else if (json.ItemName = 'outcomeDesc') then
        result.outcomeDesc := ParseString
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSecurityEventEvent(json : TJSONWriter; name : string; elem : TFhirSecurityEventEvent);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCodeableConcept(json, 'type', elem.type_);
  if elem.subtypeList.Count > 0 then
  begin
    json.valueArray('subtype');
    for i := 0 to elem.subtypeList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.subtypeList[i]);
    json.FinishArray;
  end;
  ComposeEnum(json, 'action', elem.Action, CODES_TFhirSecurityEventAction);
  ComposeInstant(json, 'dateTime', elem.dateTime);
  ComposeEnum(json, 'outcome', elem.Outcome, CODES_TFhirSecurityEventOutcome);
  ComposeString(json, 'outcomeDesc', elem.outcomeDesc);
  json.finishObject;
end;

function TFHIRXmlParser.ParseSecurityEventParticipant(element : IXmlDomElement) : TFhirSecurityEventParticipant;
var
  child : IXMLDOMElement;
begin
  result := TFhirSecurityEventParticipant.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'role') then
        result.roleList.Add(ParseCodeableConcept(child))
      else if (child.baseName = 'reference') then
        result.reference := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'userId') then
        result.userId := ParseString(child) {b}
      else if (child.baseName = 'authId') then
        result.authId := ParseString(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'requestor') then
        result.requestor := ParseBoolean(child) {b}
      else if (child.baseName = 'media') then
        result.media := ParseCoding(child) {b}
      else if (child.baseName = 'network') then
        result.network := ParseSecurityEventParticipantNetwork(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSecurityEventParticipant(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventParticipant);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.roleList.Count - 1 do
    ComposeCodeableConcept(xml, 'role', elem.roleList[i]);
  ComposeResourceReference{Resource}(xml, 'reference', elem.reference);
  ComposeString(xml, 'userId', elem.userId);
  ComposeString(xml, 'authId', elem.authId);
  ComposeString(xml, 'name', elem.name);
  ComposeBoolean(xml, 'requestor', elem.requestor);
  ComposeCoding(xml, 'media', elem.media);
  ComposeSecurityEventParticipantNetwork(xml, 'network', elem.network);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSecurityEventParticipant : TFhirSecurityEventParticipant;
begin
  json.next;
  result := TFhirSecurityEventParticipant.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'role') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.roleList.Add(ParseCodeableConcept);
          json.Next;
        end;
      end
      else if (json.ItemName = 'reference') then
        result.reference := ParseResourceReference{Resource}
      else if (json.ItemName = 'userId') then
        result.userId := ParseString
      else if (json.ItemName = 'authId') then
        result.authId := ParseString
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'requestor') then
        result.requestor := ParseBoolean
      else if (json.ItemName = 'media') then
        result.media := ParseCoding
      else if (json.ItemName = 'network') then
        result.network := ParseSecurityEventParticipantNetwork
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSecurityEventParticipant(json : TJSONWriter; name : string; elem : TFhirSecurityEventParticipant);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.roleList.Count > 0 then
  begin
    json.valueArray('role');
    for i := 0 to elem.roleList.Count - 1 do
      ComposeCodeableConcept(json, '',elem.roleList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{Resource}(json, 'reference', elem.reference);
  ComposeString(json, 'userId', elem.userId);
  ComposeString(json, 'authId', elem.authId);
  ComposeString(json, 'name', elem.name);
  ComposeBoolean(json, 'requestor', elem.requestor);
  ComposeCoding(json, 'media', elem.media);
  ComposeSecurityEventParticipantNetwork(json, 'network', elem.network);
  json.finishObject;
end;

function TFHIRXmlParser.ParseSecurityEventParticipantNetwork(element : IXmlDomElement) : TFhirSecurityEventParticipantNetwork;
var
  child : IXMLDOMElement;
begin
  result := TFhirSecurityEventParticipantNetwork.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseString(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirNetworkType, child)
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSecurityEventParticipantNetwork(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventParticipantNetwork);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'identifier', elem.identifier);
  ComposeEnum(xml, 'type', elem.Type_, CODES_TFhirNetworkType);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSecurityEventParticipantNetwork : TFhirSecurityEventParticipantNetwork;
begin
  json.next;
  result := TFhirSecurityEventParticipantNetwork.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseString
      else if (json.ItemName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirNetworkType)
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSecurityEventParticipantNetwork(json : TJSONWriter; name : string; elem : TFhirSecurityEventParticipantNetwork);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'identifier', elem.identifier);
  ComposeEnum(json, 'type', elem.Type_, CODES_TFhirNetworkType);
  json.finishObject;
end;

function TFHIRXmlParser.ParseSecurityEventSource(element : IXmlDomElement) : TFhirSecurityEventSource;
var
  child : IXMLDOMElement;
begin
  result := TFhirSecurityEventSource.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'site') then
        result.site := ParseString(child) {b}
      else if (child.baseName = 'identifier') then
        result.identifier := ParseString(child) {b}
      else if (child.baseName = 'type') then
        result.type_List.Add(ParseCoding(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSecurityEventSource(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventSource);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'site', elem.site);
  ComposeString(xml, 'identifier', elem.identifier);
  for i := 0 to elem.type_List.Count - 1 do
    ComposeCoding(xml, 'type', elem.type_List[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSecurityEventSource : TFhirSecurityEventSource;
begin
  json.next;
  result := TFhirSecurityEventSource.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'site') then
        result.site := ParseString
      else if (json.ItemName = 'identifier') then
        result.identifier := ParseString
      else if (json.ItemName = 'type') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.type_List.Add(ParseCoding);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSecurityEventSource(json : TJSONWriter; name : string; elem : TFhirSecurityEventSource);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'site', elem.site);
  ComposeString(json, 'identifier', elem.identifier);
  if elem.type_List.Count > 0 then
  begin
    json.valueArray('type');
    for i := 0 to elem.type_List.Count - 1 do
      ComposeCoding(json, '',elem.type_List[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseSecurityEventObject(element : IXmlDomElement) : TFhirSecurityEventObject;
var
  child : IXMLDOMElement;
begin
  result := TFhirSecurityEventObject.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'reference') then
        result.reference := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirObjectType, child)
      else if (child.baseName = 'role') then
        result.role := ParseEnum(CODES_TFhirObjectRole, child)
      else if (child.baseName = 'lifecycle') then
        result.lifecycle := ParseEnum(CODES_TFhirObjectLifecycle, child)
      else if (child.baseName = 'sensitivity') then
        result.sensitivity := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'query') then
        result.query := ParseBase64Binary(child) {b}
      else if (child.baseName = 'detail') then
        result.detailList.Add(ParseSecurityEventObjectDetail(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSecurityEventObject(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventObject);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeResourceReference{Resource}(xml, 'reference', elem.reference);
  ComposeEnum(xml, 'type', elem.Type_, CODES_TFhirObjectType);
  ComposeEnum(xml, 'role', elem.Role, CODES_TFhirObjectRole);
  ComposeEnum(xml, 'lifecycle', elem.Lifecycle, CODES_TFhirObjectLifecycle);
  ComposeCodeableConcept(xml, 'sensitivity', elem.sensitivity);
  ComposeString(xml, 'name', elem.name);
  ComposeBase64Binary(xml, 'query', elem.query);
  for i := 0 to elem.detailList.Count - 1 do
    ComposeSecurityEventObjectDetail(xml, 'detail', elem.detailList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSecurityEventObject : TFhirSecurityEventObject;
begin
  json.next;
  result := TFhirSecurityEventObject.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'reference') then
        result.reference := ParseResourceReference{Resource}
      else if (json.ItemName = 'type') then
        result.type_ := ParseEnum(CODES_TFhirObjectType)
      else if (json.ItemName = 'role') then
        result.role := ParseEnum(CODES_TFhirObjectRole)
      else if (json.ItemName = 'lifecycle') then
        result.lifecycle := ParseEnum(CODES_TFhirObjectLifecycle)
      else if (json.ItemName = 'sensitivity') then
        result.sensitivity := ParseCodeableConcept
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'query') then
        result.query := ParseBase64Binary
      else if (json.ItemName = 'detail') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.detailList.Add(ParseSecurityEventObjectDetail);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSecurityEventObject(json : TJSONWriter; name : string; elem : TFhirSecurityEventObject);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeResourceReference{Resource}(json, 'reference', elem.reference);
  ComposeEnum(json, 'type', elem.Type_, CODES_TFhirObjectType);
  ComposeEnum(json, 'role', elem.Role, CODES_TFhirObjectRole);
  ComposeEnum(json, 'lifecycle', elem.Lifecycle, CODES_TFhirObjectLifecycle);
  ComposeCodeableConcept(json, 'sensitivity', elem.sensitivity);
  ComposeString(json, 'name', elem.name);
  ComposeBase64Binary(json, 'query', elem.query);
  if elem.detailList.Count > 0 then
  begin
    json.valueArray('detail');
    for i := 0 to elem.detailList.Count - 1 do
      ComposeSecurityEventObjectDetail(json, '',elem.detailList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseSecurityEventObjectDetail(element : IXmlDomElement) : TFhirSecurityEventObjectDetail;
var
  child : IXMLDOMElement;
begin
  result := TFhirSecurityEventObjectDetail.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'type') then
        result.type_ := ParseString(child) {b}
      else if (child.baseName = 'value') then
        result.value := ParseBase64Binary(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSecurityEventObjectDetail(xml : TXmlBuilder; name : string; elem : TFhirSecurityEventObjectDetail);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'type', elem.type_);
  ComposeBase64Binary(xml, 'value', elem.value);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSecurityEventObjectDetail : TFhirSecurityEventObjectDetail;
begin
  json.next;
  result := TFhirSecurityEventObjectDetail.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'type') then
        result.type_ := ParseString
      else if (json.ItemName = 'value') then
        result.value := ParseBase64Binary
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSecurityEventObjectDetail(json : TJSONWriter; name : string; elem : TFhirSecurityEventObjectDetail);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'type', elem.type_);
  ComposeBase64Binary(json, 'value', elem.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseSecurityEvent(element : IXmlDomElement) : TFhirSecurityEvent;
var
  child : IXMLDOMElement;
begin
  result := TFhirSecurityEvent.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'event') then
        result.event := ParseSecurityEventEvent(child) {b}
      else if (child.baseName = 'participant') then
        result.participantList.Add(ParseSecurityEventParticipant(child))
      else if (child.baseName = 'source') then
        result.source := ParseSecurityEventSource(child) {b}
      else if (child.baseName = 'object') then
        result.object_List.Add(ParseSecurityEventObject(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSecurityEvent(xml : TXmlBuilder; name : string; elem : TFhirSecurityEvent);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeSecurityEventEvent(xml, 'event', elem.event);
  for i := 0 to elem.participantList.Count - 1 do
    ComposeSecurityEventParticipant(xml, 'participant', elem.participantList[i]);
  ComposeSecurityEventSource(xml, 'source', elem.source);
  for i := 0 to elem.object_List.Count - 1 do
    ComposeSecurityEventObject(xml, 'object', elem.object_List[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSecurityEvent : TFhirSecurityEvent;
begin
  json.next;
  result := TFhirSecurityEvent.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'event') then
        result.event := ParseSecurityEventEvent
      else if (json.ItemName = 'participant') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.participantList.Add(ParseSecurityEventParticipant);
          json.Next;
        end;
      end
      else if (json.ItemName = 'source') then
        result.source := ParseSecurityEventSource
      else if (json.ItemName = 'object') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.object_List.Add(ParseSecurityEventObject);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSecurityEvent(json : TJSONWriter; name : string; elem : TFhirSecurityEvent);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeSecurityEventEvent(json, 'event', elem.event);
  if elem.participantList.Count > 0 then
  begin
    json.valueArray('participant');
    for i := 0 to elem.participantList.Count - 1 do
      ComposeSecurityEventParticipant(json, '',elem.participantList[i]);
    json.FinishArray;
  end;
  ComposeSecurityEventSource(json, 'source', elem.source);
  if elem.object_List.Count > 0 then
  begin
    json.valueArray('object');
    for i := 0 to elem.object_List.Count - 1 do
      ComposeSecurityEventObject(json, '',elem.object_List[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseSpecimenSource(element : IXmlDomElement) : TFhirSpecimenSource;
var
  child : IXMLDOMElement;
begin
  result := TFhirSpecimenSource.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'relationship') then
        result.relationship := ParseEnum(CODES_TFhirHierarchicalRelationshipType, child)
      else if (child.baseName = 'target') then
        result.targetList.Add(ParseResourceReference{TFhirSpecimen}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSpecimenSource(xml : TXmlBuilder; name : string; elem : TFhirSpecimenSource);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeEnum(xml, 'relationship', elem.Relationship, CODES_TFhirHierarchicalRelationshipType);
  for i := 0 to elem.targetList.Count - 1 do
    ComposeResourceReference{TFhirSpecimen}(xml, 'target', elem.targetList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSpecimenSource : TFhirSpecimenSource;
begin
  json.next;
  result := TFhirSpecimenSource.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'relationship') then
        result.relationship := ParseEnum(CODES_TFhirHierarchicalRelationshipType)
      else if (json.ItemName = 'target') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.targetList.Add(ParseResourceReference{TFhirSpecimen});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSpecimenSource(json : TJSONWriter; name : string; elem : TFhirSpecimenSource);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeEnum(json, 'relationship', elem.Relationship, CODES_TFhirHierarchicalRelationshipType);
  if elem.targetList.Count > 0 then
  begin
    json.valueArray('target');
    for i := 0 to elem.targetList.Count - 1 do
      ComposeResourceReference{TFhirSpecimen}(json, '',elem.targetList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseSpecimenCollection(element : IXmlDomElement) : TFhirSpecimenCollection;
var
  child : IXMLDOMElement;
begin
  result := TFhirSpecimenCollection.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'collector') then
        result.collector := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'comment') then
        result.commentList.Add(ParseString(child))
      else if (child.baseName = 'collectedTime') then
        result.collectedTime := ParseDateTime(child) {b}
      else if (child.baseName = 'quantity') then
        result.quantity := ParseQuantity(child) {b}
      else if (child.baseName = 'method') then
        result.method := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'sourceSite') then
        result.sourceSite := ParseCodeableConcept(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSpecimenCollection(xml : TXmlBuilder; name : string; elem : TFhirSpecimenCollection);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeResourceReference{TFhirPractitioner}(xml, 'collector', elem.collector);
  for i := 0 to elem.commentList.Count - 1 do
    ComposeString(xml, 'comment', elem.commentList[i]);
  ComposeDateTime(xml, 'collectedTime', elem.collectedTime);
  ComposeQuantity(xml, 'quantity', elem.quantity);
  ComposeCodeableConcept(xml, 'method', elem.method);
  ComposeCodeableConcept(xml, 'sourceSite', elem.sourceSite);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSpecimenCollection : TFhirSpecimenCollection;
begin
  json.next;
  result := TFhirSpecimenCollection.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'collector') then
        result.collector := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'comment') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.commentList.Add(ParseString);
          json.Next;
        end;
      end
      else if (json.ItemName = 'collectedTime') then
        result.collectedTime := ParseDateTime
      else if (json.ItemName = 'quantity') then
        result.quantity := ParseQuantity
      else if (json.ItemName = 'method') then
        result.method := ParseCodeableConcept
      else if (json.ItemName = 'sourceSite') then
        result.sourceSite := ParseCodeableConcept
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSpecimenCollection(json : TJSONWriter; name : string; elem : TFhirSpecimenCollection);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeResourceReference{TFhirPractitioner}(json, 'collector', elem.collector);
  if elem.commentList.Count > 0 then
  begin
    json.valueArray('comment');
    for i := 0 to elem.commentList.Count - 1 do
      ComposeString(json, '',elem.commentList[i]);
    json.FinishArray;
  end;
  ComposeDateTime(json, 'collectedTime', elem.collectedTime);
  ComposeQuantity(json, 'quantity', elem.quantity);
  ComposeCodeableConcept(json, 'method', elem.method);
  ComposeCodeableConcept(json, 'sourceSite', elem.sourceSite);
  json.finishObject;
end;

function TFHIRXmlParser.ParseSpecimenTreatment(element : IXmlDomElement) : TFhirSpecimenTreatment;
var
  child : IXMLDOMElement;
begin
  result := TFhirSpecimenTreatment.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'procedure') then
        result.procedure_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'additive') then
        result.additiveList.Add(ParseResourceReference{TFhirSubstance}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSpecimenTreatment(xml : TXmlBuilder; name : string; elem : TFhirSpecimenTreatment);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeString(xml, 'description', elem.description);
  ComposeCodeableConcept(xml, 'procedure', elem.procedure_);
  for i := 0 to elem.additiveList.Count - 1 do
    ComposeResourceReference{TFhirSubstance}(xml, 'additive', elem.additiveList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSpecimenTreatment : TFhirSpecimenTreatment;
begin
  json.next;
  result := TFhirSpecimenTreatment.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'procedure') then
        result.procedure_ := ParseCodeableConcept
      else if (json.ItemName = 'additive') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.additiveList.Add(ParseResourceReference{TFhirSubstance});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSpecimenTreatment(json : TJSONWriter; name : string; elem : TFhirSpecimenTreatment);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeString(json, 'description', elem.description);
  ComposeCodeableConcept(json, 'procedure', elem.procedure_);
  if elem.additiveList.Count > 0 then
  begin
    json.valueArray('additive');
    for i := 0 to elem.additiveList.Count - 1 do
      ComposeResourceReference{TFhirSubstance}(json, '',elem.additiveList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseSpecimenContainer(element : IXmlDomElement) : TFhirSpecimenContainer;
var
  child : IXMLDOMElement;
begin
  result := TFhirSpecimenContainer.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'capacity') then
        result.capacity := ParseQuantity(child) {b}
      else if (child.baseName = 'specimenQuantity') then
        result.specimenQuantity := ParseQuantity(child) {b}
      else if (child.baseName = 'additive') then
        result.additive := ParseResourceReference{TFhirSubstance}(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSpecimenContainer(xml : TXmlBuilder; name : string; elem : TFhirSpecimenContainer);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.identifierList.Count - 1 do
    ComposeIdentifier(xml, 'identifier', elem.identifierList[i]);
  ComposeString(xml, 'description', elem.description);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeQuantity(xml, 'capacity', elem.capacity);
  ComposeQuantity(xml, 'specimenQuantity', elem.specimenQuantity);
  ComposeResourceReference{TFhirSubstance}(xml, 'additive', elem.additive);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSpecimenContainer : TFhirSpecimenContainer;
begin
  json.next;
  result := TFhirSpecimenContainer.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.identifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'capacity') then
        result.capacity := ParseQuantity
      else if (json.ItemName = 'specimenQuantity') then
        result.specimenQuantity := ParseQuantity
      else if (json.ItemName = 'additive') then
        result.additive := ParseResourceReference{TFhirSubstance}
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSpecimenContainer(json : TJSONWriter; name : string; elem : TFhirSpecimenContainer);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.identifierList.Count > 0 then
  begin
    json.valueArray('identifier');
    for i := 0 to elem.identifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.identifierList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'description', elem.description);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeQuantity(json, 'capacity', elem.capacity);
  ComposeQuantity(json, 'specimenQuantity', elem.specimenQuantity);
  ComposeResourceReference{TFhirSubstance}(json, 'additive', elem.additive);
  json.finishObject;
end;

function TFHIRXmlParser.ParseSpecimen(element : IXmlDomElement) : TFhirSpecimen;
var
  child : IXMLDOMElement;
begin
  result := TFhirSpecimen.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'source') then
        result.sourceList.Add(ParseSpecimenSource(child))
      else if (child.baseName = 'subject') then
        result.subject := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'accessionIdentifier') then
        result.accessionIdentifierList.Add(ParseIdentifier(child))
      else if (child.baseName = 'receivedTime') then
        result.receivedTime := ParseDateTime(child) {b}
      else if (child.baseName = 'collection') then
        result.collection := ParseSpecimenCollection(child) {b}
      else if (child.baseName = 'treatment') then
        result.treatmentList.Add(ParseSpecimenTreatment(child))
      else if (child.baseName = 'container') then
        result.containerList.Add(ParseSpecimenContainer(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSpecimen(xml : TXmlBuilder; name : string; elem : TFhirSpecimen);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  for i := 0 to elem.sourceList.Count - 1 do
    ComposeSpecimenSource(xml, 'source', elem.sourceList[i]);
  ComposeResourceReference{Resource}(xml, 'subject', elem.subject);
  for i := 0 to elem.accessionIdentifierList.Count - 1 do
    ComposeIdentifier(xml, 'accessionIdentifier', elem.accessionIdentifierList[i]);
  ComposeDateTime(xml, 'receivedTime', elem.receivedTime);
  ComposeSpecimenCollection(xml, 'collection', elem.collection);
  for i := 0 to elem.treatmentList.Count - 1 do
    ComposeSpecimenTreatment(xml, 'treatment', elem.treatmentList[i]);
  for i := 0 to elem.containerList.Count - 1 do
    ComposeSpecimenContainer(xml, 'container', elem.containerList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSpecimen : TFhirSpecimen;
begin
  json.next;
  result := TFhirSpecimen.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'source') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.sourceList.Add(ParseSpecimenSource);
          json.Next;
        end;
      end
      else if (json.ItemName = 'subject') then
        result.subject := ParseResourceReference{Resource}
      else if (json.ItemName = 'accessionIdentifier') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.accessionIdentifierList.Add(ParseIdentifier);
          json.Next;
        end;
      end
      else if (json.ItemName = 'receivedTime') then
        result.receivedTime := ParseDateTime
      else if (json.ItemName = 'collection') then
        result.collection := ParseSpecimenCollection
      else if (json.ItemName = 'treatment') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.treatmentList.Add(ParseSpecimenTreatment);
          json.Next;
        end;
      end
      else if (json.ItemName = 'container') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.containerList.Add(ParseSpecimenContainer);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSpecimen(json : TJSONWriter; name : string; elem : TFhirSpecimen);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeCodeableConcept(json, 'type', elem.type_);
  if elem.sourceList.Count > 0 then
  begin
    json.valueArray('source');
    for i := 0 to elem.sourceList.Count - 1 do
      ComposeSpecimenSource(json, '',elem.sourceList[i]);
    json.FinishArray;
  end;
  ComposeResourceReference{Resource}(json, 'subject', elem.subject);
  if elem.accessionIdentifierList.Count > 0 then
  begin
    json.valueArray('accessionIdentifier');
    for i := 0 to elem.accessionIdentifierList.Count - 1 do
      ComposeIdentifier(json, '',elem.accessionIdentifierList[i]);
    json.FinishArray;
  end;
  ComposeDateTime(json, 'receivedTime', elem.receivedTime);
  ComposeSpecimenCollection(json, 'collection', elem.collection);
  if elem.treatmentList.Count > 0 then
  begin
    json.valueArray('treatment');
    for i := 0 to elem.treatmentList.Count - 1 do
      ComposeSpecimenTreatment(json, '',elem.treatmentList[i]);
    json.FinishArray;
  end;
  if elem.containerList.Count > 0 then
  begin
    json.valueArray('container');
    for i := 0 to elem.containerList.Count - 1 do
      ComposeSpecimenContainer(json, '',elem.containerList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseSubstance(element : IXmlDomElement) : TFhirSubstance;
var
  child : IXMLDOMElement;
begin
  result := TFhirSubstance.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'effectiveTime') then
        result.effectiveTime := ParsePeriod(child) {b}
      else if (child.baseName = 'quantity') then
        result.quantity := ParseQuantity(child) {b}
      else if (child.baseName = 'ingredient') then
        result.ingredientList.Add(ParseResourceReference{TFhirSubstance}(child))
      else if (child.baseName = 'quantityMode') then
        result.quantityMode := ParseCodeableConcept(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSubstance(xml : TXmlBuilder; name : string; elem : TFhirSubstance);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeString(xml, 'name', elem.name);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeString(xml, 'description', elem.description);
  ComposeCodeableConcept(xml, 'status', elem.status);
  ComposePeriod(xml, 'effectiveTime', elem.effectiveTime);
  ComposeQuantity(xml, 'quantity', elem.quantity);
  for i := 0 to elem.ingredientList.Count - 1 do
    ComposeResourceReference{TFhirSubstance}(xml, 'ingredient', elem.ingredientList[i]);
  ComposeCodeableConcept(xml, 'quantityMode', elem.quantityMode);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSubstance : TFhirSubstance;
begin
  json.next;
  result := TFhirSubstance.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'status') then
        result.status := ParseCodeableConcept
      else if (json.ItemName = 'effectiveTime') then
        result.effectiveTime := ParsePeriod
      else if (json.ItemName = 'quantity') then
        result.quantity := ParseQuantity
      else if (json.ItemName = 'ingredient') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.ingredientList.Add(ParseResourceReference{TFhirSubstance});
          json.Next;
        end;
      end
      else if (json.ItemName = 'quantityMode') then
        result.quantityMode := ParseCodeableConcept
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSubstance(json : TJSONWriter; name : string; elem : TFhirSubstance);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeString(json, 'name', elem.name);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeString(json, 'description', elem.description);
  ComposeCodeableConcept(json, 'status', elem.status);
  ComposePeriod(json, 'effectiveTime', elem.effectiveTime);
  ComposeQuantity(json, 'quantity', elem.quantity);
  if elem.ingredientList.Count > 0 then
  begin
    json.valueArray('ingredient');
    for i := 0 to elem.ingredientList.Count - 1 do
      ComposeResourceReference{TFhirSubstance}(json, '',elem.ingredientList[i]);
    json.FinishArray;
  end;
  ComposeCodeableConcept(json, 'quantityMode', elem.quantityMode);
  json.finishObject;
end;

function TFHIRXmlParser.ParseSupplyDispense(element : IXmlDomElement) : TFhirSupplyDispense;
var
  child : IXMLDOMElement;
begin
  result := TFhirSupplyDispense.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseCode(child) {b}
      else if (child.baseName = 'type') then
        result.type_ := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'quantity') then
        result.quantity := ParseQuantity(child) {b}
      else if (child.baseName = 'suppliedItem') then
        result.suppliedItem := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'supplier') then
        result.supplier := ParseResourceReference{TFhirPractitioner}(child) {b}
      else if (child.baseName = 'whenPrepared') then
        result.whenPrepared := ParsePeriod(child) {b}
      else if (child.baseName = 'whenHandedOver') then
        result.whenHandedOver := ParsePeriod(child) {b}
      else if (child.baseName = 'destination') then
        result.destination := ParseResourceReference{TFhirLocation}(child) {b}
      else if (child.baseName = 'receiver') then
        result.receiverList.Add(ParseResourceReference{TFhirPractitioner}(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSupplyDispense(xml : TXmlBuilder; name : string; elem : TFhirSupplyDispense);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeCode(xml, 'status', elem.status);
  ComposeCodeableConcept(xml, 'type', elem.type_);
  ComposeQuantity(xml, 'quantity', elem.quantity);
  ComposeResourceReference{Resource}(xml, 'suppliedItem', elem.suppliedItem);
  ComposeResourceReference{TFhirPractitioner}(xml, 'supplier', elem.supplier);
  ComposePeriod(xml, 'whenPrepared', elem.whenPrepared);
  ComposePeriod(xml, 'whenHandedOver', elem.whenHandedOver);
  ComposeResourceReference{TFhirLocation}(xml, 'destination', elem.destination);
  for i := 0 to elem.receiverList.Count - 1 do
    ComposeResourceReference{TFhirPractitioner}(xml, 'receiver', elem.receiverList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSupplyDispense : TFhirSupplyDispense;
begin
  json.next;
  result := TFhirSupplyDispense.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'status') then
        result.status := ParseCode
      else if (json.ItemName = 'type') then
        result.type_ := ParseCodeableConcept
      else if (json.ItemName = 'quantity') then
        result.quantity := ParseQuantity
      else if (json.ItemName = 'suppliedItem') then
        result.suppliedItem := ParseResourceReference{Resource}
      else if (json.ItemName = 'supplier') then
        result.supplier := ParseResourceReference{TFhirPractitioner}
      else if (json.ItemName = 'whenPrepared') then
        result.whenPrepared := ParsePeriod
      else if (json.ItemName = 'whenHandedOver') then
        result.whenHandedOver := ParsePeriod
      else if (json.ItemName = 'destination') then
        result.destination := ParseResourceReference{TFhirLocation}
      else if (json.ItemName = 'receiver') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.receiverList.Add(ParseResourceReference{TFhirPractitioner});
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSupplyDispense(json : TJSONWriter; name : string; elem : TFhirSupplyDispense);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeCode(json, 'status', elem.status);
  ComposeCodeableConcept(json, 'type', elem.type_);
  ComposeQuantity(json, 'quantity', elem.quantity);
  ComposeResourceReference{Resource}(json, 'suppliedItem', elem.suppliedItem);
  ComposeResourceReference{TFhirPractitioner}(json, 'supplier', elem.supplier);
  ComposePeriod(json, 'whenPrepared', elem.whenPrepared);
  ComposePeriod(json, 'whenHandedOver', elem.whenHandedOver);
  ComposeResourceReference{TFhirLocation}(json, 'destination', elem.destination);
  if elem.receiverList.Count > 0 then
  begin
    json.valueArray('receiver');
    for i := 0 to elem.receiverList.Count - 1 do
      ComposeResourceReference{TFhirPractitioner}(json, '',elem.receiverList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseSupply(element : IXmlDomElement) : TFhirSupply;
var
  child : IXMLDOMElement;
begin
  result := TFhirSupply.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'name') then
        result.name := ParseCodeableConcept(child) {b}
      else if (child.baseName = 'identifier') then
        result.identifier := ParseIdentifier(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseCode(child) {b}
      else if (child.baseName = 'orderedItem') then
        result.orderedItem := ParseResourceReference{Resource}(child) {b}
      else if (child.baseName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}(child) {b}
      else if (child.baseName = 'dispense') then
        result.dispenseList.Add(ParseSupplyDispense(child))
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeSupply(xml : TXmlBuilder; name : string; elem : TFhirSupply);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeCodeableConcept(xml, 'name', elem.name);
  ComposeIdentifier(xml, 'identifier', elem.identifier);
  ComposeCode(xml, 'status', elem.status);
  ComposeResourceReference{Resource}(xml, 'orderedItem', elem.orderedItem);
  ComposeResourceReference{TFhirPatient}(xml, 'patient', elem.patient);
  for i := 0 to elem.dispenseList.Count - 1 do
    ComposeSupplyDispense(xml, 'dispense', elem.dispenseList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseSupply : TFhirSupply;
begin
  json.next;
  result := TFhirSupply.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'name') then
        result.name := ParseCodeableConcept
      else if (json.ItemName = 'identifier') then
        result.identifier := ParseIdentifier
      else if (json.ItemName = 'status') then
        result.status := ParseCode
      else if (json.ItemName = 'orderedItem') then
        result.orderedItem := ParseResourceReference{Resource}
      else if (json.ItemName = 'patient') then
        result.patient := ParseResourceReference{TFhirPatient}
      else if (json.ItemName = 'dispense') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.dispenseList.Add(ParseSupplyDispense);
          json.Next;
        end;
      end
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeSupply(json : TJSONWriter; name : string; elem : TFhirSupply);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeCodeableConcept(json, 'name', elem.name);
  ComposeIdentifier(json, 'identifier', elem.identifier);
  ComposeCode(json, 'status', elem.status);
  ComposeResourceReference{Resource}(json, 'orderedItem', elem.orderedItem);
  ComposeResourceReference{TFhirPatient}(json, 'patient', elem.patient);
  if elem.dispenseList.Count > 0 then
  begin
    json.valueArray('dispense');
    for i := 0 to elem.dispenseList.Count - 1 do
      ComposeSupplyDispense(json, '',elem.dispenseList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseValueSetDefine(element : IXmlDomElement) : TFhirValueSetDefine;
var
  child : IXMLDOMElement;
begin
  result := TFhirValueSetDefine.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'system') then
        result.system := ParseUri(child) {b}
      else if (child.baseName = 'caseSensitive') then
        result.caseSensitive := ParseBoolean(child) {b}
      else if (child.baseName = 'concept') then
        result.conceptList.Add(ParseValueSetDefineConcept(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeValueSetDefine(xml : TXmlBuilder; name : string; elem : TFhirValueSetDefine);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeUri(xml, 'system', elem.system);
  ComposeBoolean(xml, 'caseSensitive', elem.caseSensitive);
  for i := 0 to elem.conceptList.Count - 1 do
    ComposeValueSetDefineConcept(xml, 'concept', elem.conceptList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseValueSetDefine : TFhirValueSetDefine;
begin
  json.next;
  result := TFhirValueSetDefine.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'system') then
        result.system := ParseUri
      else if (json.ItemName = 'caseSensitive') then
        result.caseSensitive := ParseBoolean
      else if (json.ItemName = 'concept') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.conceptList.Add(ParseValueSetDefineConcept);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeValueSetDefine(json : TJSONWriter; name : string; elem : TFhirValueSetDefine);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeUri(json, 'system', elem.system);
  ComposeBoolean(json, 'caseSensitive', elem.caseSensitive);
  if elem.conceptList.Count > 0 then
  begin
    json.valueArray('concept');
    for i := 0 to elem.conceptList.Count - 1 do
      ComposeValueSetDefineConcept(json, '',elem.conceptList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseValueSetDefineConcept(element : IXmlDomElement) : TFhirValueSetDefineConcept;
var
  child : IXMLDOMElement;
begin
  result := TFhirValueSetDefineConcept.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'code') then
        result.code := ParseCode(child) {b}
      else if (child.baseName = 'abstract') then
        result.abstract := ParseBoolean(child) {b}
      else if (child.baseName = 'display') then
        result.display := ParseString(child) {b}
      else if (child.baseName = 'definition') then
        result.definition := ParseString(child) {b}
      else if (child.baseName = 'concept') then
        result.conceptList.Add(ParseValueSetDefineConcept(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeValueSetDefineConcept(xml : TXmlBuilder; name : string; elem : TFhirValueSetDefineConcept);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'code', elem.code);
  ComposeBoolean(xml, 'abstract', elem.abstract);
  ComposeString(xml, 'display', elem.display);
  ComposeString(xml, 'definition', elem.definition);
  for i := 0 to elem.conceptList.Count - 1 do
    ComposeValueSetDefineConcept(xml, 'concept', elem.conceptList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseValueSetDefineConcept : TFhirValueSetDefineConcept;
begin
  json.next;
  result := TFhirValueSetDefineConcept.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'code') then
        result.code := ParseCode
      else if (json.ItemName = 'abstract') then
        result.abstract := ParseBoolean
      else if (json.ItemName = 'display') then
        result.display := ParseString
      else if (json.ItemName = 'definition') then
        result.definition := ParseString
      else if (json.ItemName = 'concept') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.conceptList.Add(ParseValueSetDefineConcept);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeValueSetDefineConcept(json : TJSONWriter; name : string; elem : TFhirValueSetDefineConcept);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'code', elem.code);
  ComposeBoolean(json, 'abstract', elem.abstract);
  ComposeString(json, 'display', elem.display);
  ComposeString(json, 'definition', elem.definition);
  if elem.conceptList.Count > 0 then
  begin
    json.valueArray('concept');
    for i := 0 to elem.conceptList.Count - 1 do
      ComposeValueSetDefineConcept(json, '',elem.conceptList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseValueSetCompose(element : IXmlDomElement) : TFhirValueSetCompose;
var
  child : IXMLDOMElement;
begin
  result := TFhirValueSetCompose.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'import') then
        result.importList.Add(ParseUri(child))
      else if (child.baseName = 'include') then
        result.includeList.Add(ParseValueSetComposeInclude(child))
      else if (child.baseName = 'exclude') then
        result.excludeList.Add(ParseValueSetComposeInclude(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeValueSetCompose(xml : TXmlBuilder; name : string; elem : TFhirValueSetCompose);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  for i := 0 to elem.importList.Count - 1 do
    ComposeUri(xml, 'import', elem.importList[i]);
  for i := 0 to elem.includeList.Count - 1 do
    ComposeValueSetComposeInclude(xml, 'include', elem.includeList[i]);
  for i := 0 to elem.excludeList.Count - 1 do
    ComposeValueSetComposeInclude(xml, 'exclude', elem.excludeList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseValueSetCompose : TFhirValueSetCompose;
begin
  json.next;
  result := TFhirValueSetCompose.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'import') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.importList.Add(ParseUri);
          json.Next;
        end;
      end
      else if (json.ItemName = 'include') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.includeList.Add(ParseValueSetComposeInclude);
          json.Next;
        end;
      end
      else if (json.ItemName = 'exclude') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.excludeList.Add(ParseValueSetComposeInclude);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeValueSetCompose(json : TJSONWriter; name : string; elem : TFhirValueSetCompose);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  if elem.importList.Count > 0 then
  begin
    json.valueArray('import');
    for i := 0 to elem.importList.Count - 1 do
      ComposeUri(json, '',elem.importList[i]);
    json.FinishArray;
  end;
  if elem.includeList.Count > 0 then
  begin
    json.valueArray('include');
    for i := 0 to elem.includeList.Count - 1 do
      ComposeValueSetComposeInclude(json, '',elem.includeList[i]);
    json.FinishArray;
  end;
  if elem.excludeList.Count > 0 then
  begin
    json.valueArray('exclude');
    for i := 0 to elem.excludeList.Count - 1 do
      ComposeValueSetComposeInclude(json, '',elem.excludeList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseValueSetComposeInclude(element : IXmlDomElement) : TFhirValueSetComposeInclude;
var
  child : IXMLDOMElement;
begin
  result := TFhirValueSetComposeInclude.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'system') then
        result.system := ParseUri(child) {b}
      else if (child.baseName = 'version') then
        result.version := ParseString(child) {b}
      else if (child.baseName = 'code') then
        result.codeList.Add(ParseCode(child))
      else if (child.baseName = 'filter') then
        result.filterList.Add(ParseValueSetComposeIncludeFilter(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeValueSetComposeInclude(xml : TXmlBuilder; name : string; elem : TFhirValueSetComposeInclude);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeUri(xml, 'system', elem.system);
  ComposeString(xml, 'version', elem.version);
  for i := 0 to elem.codeList.Count - 1 do
    ComposeCode(xml, 'code', elem.codeList[i]);
  for i := 0 to elem.filterList.Count - 1 do
    ComposeValueSetComposeIncludeFilter(xml, 'filter', elem.filterList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseValueSetComposeInclude : TFhirValueSetComposeInclude;
begin
  json.next;
  result := TFhirValueSetComposeInclude.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'system') then
        result.system := ParseUri
      else if (json.ItemName = 'version') then
        result.version := ParseString
      else if (json.ItemName = 'code') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.codeList.Add(ParseCode);
          json.Next;
        end;
      end
      else if (json.ItemName = 'filter') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.filterList.Add(ParseValueSetComposeIncludeFilter);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeValueSetComposeInclude(json : TJSONWriter; name : string; elem : TFhirValueSetComposeInclude);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeUri(json, 'system', elem.system);
  ComposeString(json, 'version', elem.version);
  if elem.codeList.Count > 0 then
  begin
    json.valueArray('code');
    for i := 0 to elem.codeList.Count - 1 do
      ComposeCode(json, '',elem.codeList[i]);
    json.FinishArray;
  end;
  if elem.filterList.Count > 0 then
  begin
    json.valueArray('filter');
    for i := 0 to elem.filterList.Count - 1 do
      ComposeValueSetComposeIncludeFilter(json, '',elem.filterList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseValueSetComposeIncludeFilter(element : IXmlDomElement) : TFhirValueSetComposeIncludeFilter;
var
  child : IXMLDOMElement;
begin
  result := TFhirValueSetComposeIncludeFilter.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'property') then
        result.property_ := ParseCode(child) {b}
      else if (child.baseName = 'op') then
        result.op := ParseEnum(CODES_TFhirFilterOperator, child)
      else if (child.baseName = 'value') then
        result.value := ParseCode(child) {b}
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeValueSetComposeIncludeFilter(xml : TXmlBuilder; name : string; elem : TFhirValueSetComposeIncludeFilter);
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeCode(xml, 'property', elem.property_);
  ComposeEnum(xml, 'op', elem.Op, CODES_TFhirFilterOperator);
  ComposeCode(xml, 'value', elem.value);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseValueSetComposeIncludeFilter : TFhirValueSetComposeIncludeFilter;
begin
  json.next;
  result := TFhirValueSetComposeIncludeFilter.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'property') then
        result.property_ := ParseCode
      else if (json.ItemName = 'op') then
        result.op := ParseEnum(CODES_TFhirFilterOperator)
      else if (json.ItemName = 'value') then
        result.value := ParseCode
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeValueSetComposeIncludeFilter(json : TJSONWriter; name : string; elem : TFhirValueSetComposeIncludeFilter);
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeCode(json, 'property', elem.property_);
  ComposeEnum(json, 'op', elem.Op, CODES_TFhirFilterOperator);
  ComposeCode(json, 'value', elem.value);
  json.finishObject;
end;

function TFHIRXmlParser.ParseValueSetExpansion(element : IXmlDomElement) : TFhirValueSetExpansion;
var
  child : IXMLDOMElement;
begin
  result := TFhirValueSetExpansion.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'timestamp') then
        result.timestamp := ParseInstant(child) {b}
      else if (child.baseName = 'contains') then
        result.containsList.Add(ParseValueSetExpansionContains(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeValueSetExpansion(xml : TXmlBuilder; name : string; elem : TFhirValueSetExpansion);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeInstant(xml, 'timestamp', elem.timestamp);
  for i := 0 to elem.containsList.Count - 1 do
    ComposeValueSetExpansionContains(xml, 'contains', elem.containsList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseValueSetExpansion : TFhirValueSetExpansion;
begin
  json.next;
  result := TFhirValueSetExpansion.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'timestamp') then
        result.timestamp := ParseInstant
      else if (json.ItemName = 'contains') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.containsList.Add(ParseValueSetExpansionContains);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeValueSetExpansion(json : TJSONWriter; name : string; elem : TFhirValueSetExpansion);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeInstant(json, 'timestamp', elem.timestamp);
  if elem.containsList.Count > 0 then
  begin
    json.valueArray('contains');
    for i := 0 to elem.containsList.Count - 1 do
      ComposeValueSetExpansionContains(json, '',elem.containsList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseValueSetExpansionContains(element : IXmlDomElement) : TFhirValueSetExpansionContains;
var
  child : IXMLDOMElement;
begin
  result := TFhirValueSetExpansionContains.create;
  try
    parseElementAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'system') then
        result.system := ParseUri(child) {b}
      else if (child.baseName = 'code') then
        result.code := ParseCode(child) {b}
      else if (child.baseName = 'display') then
        result.display := ParseString(child) {b}
      else if (child.baseName = 'contains') then
        result.containsList.Add(ParseValueSetExpansionContains(child))
      else if Not ParseElementChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeValueSetExpansionContains(xml : TXmlBuilder; name : string; elem : TFhirValueSetExpansionContains);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeElementAttributes(xml, elem);
  xml.open(name);
  composeElementChildren(xml, elem);
  ComposeUri(xml, 'system', elem.system);
  ComposeCode(xml, 'code', elem.code);
  ComposeString(xml, 'display', elem.display);
  for i := 0 to elem.containsList.Count - 1 do
    ComposeValueSetExpansionContains(xml, 'contains', elem.containsList[i]);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseValueSetExpansionContains : TFhirValueSetExpansionContains;
begin
  json.next;
  result := TFhirValueSetExpansionContains.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'system') then
        result.system := ParseUri
      else if (json.ItemName = 'code') then
        result.code := ParseCode
      else if (json.ItemName = 'display') then
        result.display := ParseString
      else if (json.ItemName = 'contains') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.containsList.Add(ParseValueSetExpansionContains);
          json.Next;
        end;
      end
      else if not ParseElementProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeValueSetExpansionContains(json : TJSONWriter; name : string; elem : TFhirValueSetExpansionContains);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeElementProperties(json, elem);
  ComposeUri(json, 'system', elem.system);
  ComposeCode(json, 'code', elem.code);
  ComposeString(json, 'display', elem.display);
  if elem.containsList.Count > 0 then
  begin
    json.valueArray('contains');
    for i := 0 to elem.containsList.Count - 1 do
      ComposeValueSetExpansionContains(json, '',elem.containsList[i]);
    json.FinishArray;
  end;
  json.finishObject;
end;

function TFHIRXmlParser.ParseValueSet(element : IXmlDomElement) : TFhirValueSet;
var
  child : IXMLDOMElement;
begin
  result := TFhirValueSet.create;
  try
    parseResourceAttributes(result, element);
    child := FirstChild(element);
    while (child <> nil) do
    begin
      if (child.baseName = 'identifier') then
        result.identifier := ParseString(child) {b}
      else if (child.baseName = 'version') then
        result.version := ParseString(child) {b}
      else if (child.baseName = 'name') then
        result.name := ParseString(child) {b}
      else if (child.baseName = 'publisher') then
        result.publisher := ParseString(child) {b}
      else if (child.baseName = 'telecom') then
        result.telecomList.Add(ParseContact(child))
      else if (child.baseName = 'description') then
        result.description := ParseString(child) {b}
      else if (child.baseName = 'copyright') then
        result.copyright := ParseString(child) {b}
      else if (child.baseName = 'status') then
        result.status := ParseEnum(CODES_TFhirValuesetStatus, child)
      else if (child.baseName = 'experimental') then
        result.experimental := ParseBoolean(child) {b}
      else if (child.baseName = 'date') then
        result.date := ParseDateTime(child) {b}
      else if (child.baseName = 'define') then
        result.define := ParseValueSetDefine(child) {b}
      else if (child.baseName = 'compose') then
        result.compose := ParseValueSetCompose(child) {b}
      else if (child.baseName = 'expansion') then
        result.expansion := ParseValueSetExpansion(child) {b}
      else if Not ParseResourceChild(result, child) then
         UnknownContent(child);
      child := NextSibling(child);
    end;
    closeOutElement(result, element);

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRXmlComposer.ComposeValueSet(xml : TXmlBuilder; name : string; elem : TFhirValueSet);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  composeResourceAttributes(xml, elem);
  xml.open(name);
  composeResourceChildren(xml, elem);
  ComposeString(xml, 'identifier', elem.identifier);
  ComposeString(xml, 'version', elem.version);
  ComposeString(xml, 'name', elem.name);
  ComposeString(xml, 'publisher', elem.publisher);
  for i := 0 to elem.telecomList.Count - 1 do
    ComposeContact(xml, 'telecom', elem.telecomList[i]);
  ComposeString(xml, 'description', elem.description);
  ComposeString(xml, 'copyright', elem.copyright);
  ComposeEnum(xml, 'status', elem.Status, CODES_TFhirValuesetStatus);
  ComposeBoolean(xml, 'experimental', elem.experimental);
  ComposeDateTime(xml, 'date', elem.date);
  ComposeValueSetDefine(xml, 'define', elem.define);
  ComposeValueSetCompose(xml, 'compose', elem.compose);
  ComposeValueSetExpansion(xml, 'expansion', elem.expansion);
  closeOutElement(xml, elem);
  xml.close(name);
end;

function TFHIRJsonParser.ParseValueSet : TFhirValueSet;
begin
  json.next;
  result := TFhirValueSet.create;
  try
    while (json.ItemType <> jpitEnd) do
    begin
      if (json.ItemName = 'identifier') then
        result.identifier := ParseString
      else if (json.ItemName = 'version') then
        result.version := ParseString
      else if (json.ItemName = 'name') then
        result.name := ParseString
      else if (json.ItemName = 'publisher') then
        result.publisher := ParseString
      else if (json.ItemName = 'telecom') then
      begin
        json.checkState(jpitArray);
        json.Next;
        while (json.ItemType <> jpitEnd) do
        begin
          result.telecomList.Add(ParseContact);
          json.Next;
        end;
      end
      else if (json.ItemName = 'description') then
        result.description := ParseString
      else if (json.ItemName = 'copyright') then
        result.copyright := ParseString
      else if (json.ItemName = 'status') then
        result.status := ParseEnum(CODES_TFhirValuesetStatus)
      else if (json.ItemName = 'experimental') then
        result.experimental := ParseBoolean
      else if (json.ItemName = 'date') then
        result.date := ParseDateTime
      else if (json.ItemName = 'define') then
        result.define := ParseValueSetDefine
      else if (json.ItemName = 'compose') then
        result.compose := ParseValueSetCompose
      else if (json.ItemName = 'expansion') then
        result.expansion := ParseValueSetExpansion
      else if not ParseResourceProperty(result) then
         UnknownContent;
      json.next;
    end;

    result.link;
  finally
    result.free;
  end;
end;

procedure TFHIRJsonComposer.ComposeValueSet(json : TJSONWriter; name : string; elem : TFhirValueSet);
var
  i : integer;
begin
  if (elem = nil) then
    exit;
  json.valueObject(name);
  ComposeResourceProperties(json, elem);
  ComposeString(json, 'identifier', elem.identifier);
  ComposeString(json, 'version', elem.version);
  ComposeString(json, 'name', elem.name);
  ComposeString(json, 'publisher', elem.publisher);
  if elem.telecomList.Count > 0 then
  begin
    json.valueArray('telecom');
    for i := 0 to elem.telecomList.Count - 1 do
      ComposeContact(json, '',elem.telecomList[i]);
    json.FinishArray;
  end;
  ComposeString(json, 'description', elem.description);
  ComposeString(json, 'copyright', elem.copyright);
  ComposeEnum(json, 'status', elem.Status, CODES_TFhirValuesetStatus);
  ComposeBoolean(json, 'experimental', elem.experimental);
  ComposeDateTime(json, 'date', elem.date);
  ComposeValueSetDefine(json, 'define', elem.define);
  ComposeValueSetCompose(json, 'compose', elem.compose);
  ComposeValueSetExpansion(json, 'expansion', elem.expansion);
  json.finishObject;
end;

function TFHIRXmlParser.ParseResource(element : IXmlDomElement) : TFhirResource;
begin
  if (element = nil) Then
    Raise Exception.Create('error - element is nil')
  else if element.baseName = 'AdverseReaction' Then
    result := ParseAdverseReaction(element)
  else if element.baseName = 'Alert' Then
    result := ParseAlert(element)
  else if element.baseName = 'AllergyIntolerance' Then
    result := ParseAllergyIntolerance(element)
  else if element.baseName = 'CarePlan' Then
    result := ParseCarePlan(element)
  else if element.baseName = 'Condition' Then
    result := ParseCondition(element)
  else if element.baseName = 'Conformance' Then
    result := ParseConformance(element)
  else if element.baseName = 'Coverage' Then
    result := ParseCoverage(element)
  else if element.baseName = 'Device' Then
    result := ParseDevice(element)
  else if element.baseName = 'DeviceCapabilities' Then
    result := ParseDeviceCapabilities(element)
  else if element.baseName = 'DeviceLog' Then
    result := ParseDeviceLog(element)
  else if element.baseName = 'DeviceObservation' Then
    result := ParseDeviceObservation(element)
  else if element.baseName = 'DiagnosticOrder' Then
    result := ParseDiagnosticOrder(element)
  else if element.baseName = 'DiagnosticReport' Then
    result := ParseDiagnosticReport(element)
  else if element.baseName = 'Document' Then
    result := ParseDocument(element)
  else if element.baseName = 'DocumentReference' Then
    result := ParseDocumentReference(element)
  else if element.baseName = 'Encounter' Then
    result := ParseEncounter(element)
  else if element.baseName = 'FamilyHistory' Then
    result := ParseFamilyHistory(element)
  else if element.baseName = 'Group' Then
    result := ParseGroup(element)
  else if element.baseName = 'ImagingStudy' Then
    result := ParseImagingStudy(element)
  else if element.baseName = 'Immunization' Then
    result := ParseImmunization(element)
  else if element.baseName = 'ImmunizationProfile' Then
    result := ParseImmunizationProfile(element)
  else if element.baseName = 'List' Then
    result := ParseList(element)
  else if element.baseName = 'Location' Then
    result := ParseLocation(element)
  else if element.baseName = 'Media' Then
    result := ParseMedia(element)
  else if element.baseName = 'Medication' Then
    result := ParseMedication(element)
  else if element.baseName = 'MedicationAdministration' Then
    result := ParseMedicationAdministration(element)
  else if element.baseName = 'MedicationDispense' Then
    result := ParseMedicationDispense(element)
  else if element.baseName = 'MedicationPrescription' Then
    result := ParseMedicationPrescription(element)
  else if element.baseName = 'MedicationStatement' Then
    result := ParseMedicationStatement(element)
  else if element.baseName = 'Message' Then
    result := ParseMessage(element)
  else if element.baseName = 'Observation' Then
    result := ParseObservation(element)
  else if element.baseName = 'OperationOutcome' Then
    result := ParseOperationOutcome(element)
  else if element.baseName = 'Order' Then
    result := ParseOrder(element)
  else if element.baseName = 'OrderResponse' Then
    result := ParseOrderResponse(element)
  else if element.baseName = 'Organization' Then
    result := ParseOrganization(element)
  else if element.baseName = 'Other' Then
    result := ParseOther(element)
  else if element.baseName = 'Patient' Then
    result := ParsePatient(element)
  else if element.baseName = 'Practitioner' Then
    result := ParsePractitioner(element)
  else if element.baseName = 'Procedure' Then
    result := ParseProcedure(element)
  else if element.baseName = 'Profile' Then
    result := ParseProfile(element)
  else if element.baseName = 'Provenance' Then
    result := ParseProvenance(element)
  else if element.baseName = 'Query' Then
    result := ParseQuery(element)
  else if element.baseName = 'Questionnaire' Then
    result := ParseQuestionnaire(element)
  else if element.baseName = 'RelatedPerson' Then
    result := ParseRelatedPerson(element)
  else if element.baseName = 'SecurityEvent' Then
    result := ParseSecurityEvent(element)
  else if element.baseName = 'Specimen' Then
    result := ParseSpecimen(element)
  else if element.baseName = 'Substance' Then
    result := ParseSubstance(element)
  else if element.baseName = 'Supply' Then
    result := ParseSupply(element)
  else if element.baseName = 'ValueSet' Then
    result := ParseValueSet(element)
  else if (element.baseName = 'Binary') Then
    result := ParseBinary(element)
  else
    raise Exception.create('Error: the element '+element.baseName+' is not recognised as a valid resource name');
end;

procedure TFHIRXmlComposer.ComposeResource(xml : TXmlBuilder; id, ver : String; resource: TFhirResource);
begin
  if (resource = nil) Then
    Raise Exception.Create('error - resource is nil');
  Case resource.ResourceType of
    frtAdverseReaction: ComposeAdverseReaction(xml, 'AdverseReaction', TFhirAdverseReaction(resource));
    frtAlert: ComposeAlert(xml, 'Alert', TFhirAlert(resource));
    frtAllergyIntolerance: ComposeAllergyIntolerance(xml, 'AllergyIntolerance', TFhirAllergyIntolerance(resource));
    frtCarePlan: ComposeCarePlan(xml, 'CarePlan', TFhirCarePlan(resource));
    frtCondition: ComposeCondition(xml, 'Condition', TFhirCondition(resource));
    frtConformance: ComposeConformance(xml, 'Conformance', TFhirConformance(resource));
    frtCoverage: ComposeCoverage(xml, 'Coverage', TFhirCoverage(resource));
    frtDevice: ComposeDevice(xml, 'Device', TFhirDevice(resource));
    frtDeviceCapabilities: ComposeDeviceCapabilities(xml, 'DeviceCapabilities', TFhirDeviceCapabilities(resource));
    frtDeviceLog: ComposeDeviceLog(xml, 'DeviceLog', TFhirDeviceLog(resource));
    frtDeviceObservation: ComposeDeviceObservation(xml, 'DeviceObservation', TFhirDeviceObservation(resource));
    frtDiagnosticOrder: ComposeDiagnosticOrder(xml, 'DiagnosticOrder', TFhirDiagnosticOrder(resource));
    frtDiagnosticReport: ComposeDiagnosticReport(xml, 'DiagnosticReport', TFhirDiagnosticReport(resource));
    frtDocument: ComposeDocument(xml, 'Document', TFhirDocument(resource));
    frtDocumentReference: ComposeDocumentReference(xml, 'DocumentReference', TFhirDocumentReference(resource));
    frtEncounter: ComposeEncounter(xml, 'Encounter', TFhirEncounter(resource));
    frtFamilyHistory: ComposeFamilyHistory(xml, 'FamilyHistory', TFhirFamilyHistory(resource));
    frtGroup: ComposeGroup(xml, 'Group', TFhirGroup(resource));
    frtImagingStudy: ComposeImagingStudy(xml, 'ImagingStudy', TFhirImagingStudy(resource));
    frtImmunization: ComposeImmunization(xml, 'Immunization', TFhirImmunization(resource));
    frtImmunizationProfile: ComposeImmunizationProfile(xml, 'ImmunizationProfile', TFhirImmunizationProfile(resource));
    frtList: ComposeList(xml, 'List', TFhirList(resource));
    frtLocation: ComposeLocation(xml, 'Location', TFhirLocation(resource));
    frtMedia: ComposeMedia(xml, 'Media', TFhirMedia(resource));
    frtMedication: ComposeMedication(xml, 'Medication', TFhirMedication(resource));
    frtMedicationAdministration: ComposeMedicationAdministration(xml, 'MedicationAdministration', TFhirMedicationAdministration(resource));
    frtMedicationDispense: ComposeMedicationDispense(xml, 'MedicationDispense', TFhirMedicationDispense(resource));
    frtMedicationPrescription: ComposeMedicationPrescription(xml, 'MedicationPrescription', TFhirMedicationPrescription(resource));
    frtMedicationStatement: ComposeMedicationStatement(xml, 'MedicationStatement', TFhirMedicationStatement(resource));
    frtMessage: ComposeMessage(xml, 'Message', TFhirMessage(resource));
    frtObservation: ComposeObservation(xml, 'Observation', TFhirObservation(resource));
    frtOperationOutcome: ComposeOperationOutcome(xml, 'OperationOutcome', TFhirOperationOutcome(resource));
    frtOrder: ComposeOrder(xml, 'Order', TFhirOrder(resource));
    frtOrderResponse: ComposeOrderResponse(xml, 'OrderResponse', TFhirOrderResponse(resource));
    frtOrganization: ComposeOrganization(xml, 'Organization', TFhirOrganization(resource));
    frtOther: ComposeOther(xml, 'Other', TFhirOther(resource));
    frtPatient: ComposePatient(xml, 'Patient', TFhirPatient(resource));
    frtPractitioner: ComposePractitioner(xml, 'Practitioner', TFhirPractitioner(resource));
    frtProcedure: ComposeProcedure(xml, 'Procedure', TFhirProcedure(resource));
    frtProfile: ComposeProfile(xml, 'Profile', TFhirProfile(resource));
    frtProvenance: ComposeProvenance(xml, 'Provenance', TFhirProvenance(resource));
    frtQuery: ComposeQuery(xml, 'Query', TFhirQuery(resource));
    frtQuestionnaire: ComposeQuestionnaire(xml, 'Questionnaire', TFhirQuestionnaire(resource));
    frtRelatedPerson: ComposeRelatedPerson(xml, 'RelatedPerson', TFhirRelatedPerson(resource));
    frtSecurityEvent: ComposeSecurityEvent(xml, 'SecurityEvent', TFhirSecurityEvent(resource));
    frtSpecimen: ComposeSpecimen(xml, 'Specimen', TFhirSpecimen(resource));
    frtSubstance: ComposeSubstance(xml, 'Substance', TFhirSubstance(resource));
    frtSupply: ComposeSupply(xml, 'Supply', TFhirSupply(resource));
    frtValueSet: ComposeValueSet(xml, 'ValueSet', TFhirValueSet(resource));
    frtBinary: ComposeBinary(xml, TFhirBinary(resource));
  else
    raise Exception.create('Internal error: the resource type '+CODES_TFhirResourceType[resource.ResourceType]+' is not a valid resource type');
  end;
end;

function TFHIRJsonParser.ParseResource : TFhirResource;
begin
  if json.ItemName = 'AdverseReaction' Then
    result := ParseAdverseReaction
  else if json.ItemName = 'Alert' Then
    result := ParseAlert
  else if json.ItemName = 'AllergyIntolerance' Then
    result := ParseAllergyIntolerance
  else if json.ItemName = 'CarePlan' Then
    result := ParseCarePlan
  else if json.ItemName = 'Condition' Then
    result := ParseCondition
  else if json.ItemName = 'Conformance' Then
    result := ParseConformance
  else if json.ItemName = 'Coverage' Then
    result := ParseCoverage
  else if json.ItemName = 'Device' Then
    result := ParseDevice
  else if json.ItemName = 'DeviceCapabilities' Then
    result := ParseDeviceCapabilities
  else if json.ItemName = 'DeviceLog' Then
    result := ParseDeviceLog
  else if json.ItemName = 'DeviceObservation' Then
    result := ParseDeviceObservation
  else if json.ItemName = 'DiagnosticOrder' Then
    result := ParseDiagnosticOrder
  else if json.ItemName = 'DiagnosticReport' Then
    result := ParseDiagnosticReport
  else if json.ItemName = 'Document' Then
    result := ParseDocument
  else if json.ItemName = 'DocumentReference' Then
    result := ParseDocumentReference
  else if json.ItemName = 'Encounter' Then
    result := ParseEncounter
  else if json.ItemName = 'FamilyHistory' Then
    result := ParseFamilyHistory
  else if json.ItemName = 'Group' Then
    result := ParseGroup
  else if json.ItemName = 'ImagingStudy' Then
    result := ParseImagingStudy
  else if json.ItemName = 'Immunization' Then
    result := ParseImmunization
  else if json.ItemName = 'ImmunizationProfile' Then
    result := ParseImmunizationProfile
  else if json.ItemName = 'List' Then
    result := ParseList
  else if json.ItemName = 'Location' Then
    result := ParseLocation
  else if json.ItemName = 'Media' Then
    result := ParseMedia
  else if json.ItemName = 'Medication' Then
    result := ParseMedication
  else if json.ItemName = 'MedicationAdministration' Then
    result := ParseMedicationAdministration
  else if json.ItemName = 'MedicationDispense' Then
    result := ParseMedicationDispense
  else if json.ItemName = 'MedicationPrescription' Then
    result := ParseMedicationPrescription
  else if json.ItemName = 'MedicationStatement' Then
    result := ParseMedicationStatement
  else if json.ItemName = 'Message' Then
    result := ParseMessage
  else if json.ItemName = 'Observation' Then
    result := ParseObservation
  else if json.ItemName = 'OperationOutcome' Then
    result := ParseOperationOutcome
  else if json.ItemName = 'Order' Then
    result := ParseOrder
  else if json.ItemName = 'OrderResponse' Then
    result := ParseOrderResponse
  else if json.ItemName = 'Organization' Then
    result := ParseOrganization
  else if json.ItemName = 'Other' Then
    result := ParseOther
  else if json.ItemName = 'Patient' Then
    result := ParsePatient
  else if json.ItemName = 'Practitioner' Then
    result := ParsePractitioner
  else if json.ItemName = 'Procedure' Then
    result := ParseProcedure
  else if json.ItemName = 'Profile' Then
    result := ParseProfile
  else if json.ItemName = 'Provenance' Then
    result := ParseProvenance
  else if json.ItemName = 'Query' Then
    result := ParseQuery
  else if json.ItemName = 'Questionnaire' Then
    result := ParseQuestionnaire
  else if json.ItemName = 'RelatedPerson' Then
    result := ParseRelatedPerson
  else if json.ItemName = 'SecurityEvent' Then
    result := ParseSecurityEvent
  else if json.ItemName = 'Specimen' Then
    result := ParseSpecimen
  else if json.ItemName = 'Substance' Then
    result := ParseSubstance
  else if json.ItemName = 'Supply' Then
    result := ParseSupply
  else if json.ItemName = 'ValueSet' Then
    result := ParseValueSet
  else if (json.itemName = 'Binary') Then
    result := ParseBinary
  else
    raise Exception.create('error: the element '+json.itemName+' is not a valid resource name');
end;

procedure TFHIRJsonComposer.ComposeResource(json : TJSONWriter; id, ver : String; resource: TFhirResource);
begin
  if (resource = nil) Then
    Raise Exception.Create('error - resource is nil');
  Case resource.ResourceType of
    frtAdverseReaction: ComposeAdverseReaction(json, 'AdverseReaction', TFhirAdverseReaction(resource));
    frtAlert: ComposeAlert(json, 'Alert', TFhirAlert(resource));
    frtAllergyIntolerance: ComposeAllergyIntolerance(json, 'AllergyIntolerance', TFhirAllergyIntolerance(resource));
    frtCarePlan: ComposeCarePlan(json, 'CarePlan', TFhirCarePlan(resource));
    frtCondition: ComposeCondition(json, 'Condition', TFhirCondition(resource));
    frtConformance: ComposeConformance(json, 'Conformance', TFhirConformance(resource));
    frtCoverage: ComposeCoverage(json, 'Coverage', TFhirCoverage(resource));
    frtDevice: ComposeDevice(json, 'Device', TFhirDevice(resource));
    frtDeviceCapabilities: ComposeDeviceCapabilities(json, 'DeviceCapabilities', TFhirDeviceCapabilities(resource));
    frtDeviceLog: ComposeDeviceLog(json, 'DeviceLog', TFhirDeviceLog(resource));
    frtDeviceObservation: ComposeDeviceObservation(json, 'DeviceObservation', TFhirDeviceObservation(resource));
    frtDiagnosticOrder: ComposeDiagnosticOrder(json, 'DiagnosticOrder', TFhirDiagnosticOrder(resource));
    frtDiagnosticReport: ComposeDiagnosticReport(json, 'DiagnosticReport', TFhirDiagnosticReport(resource));
    frtDocument: ComposeDocument(json, 'Document', TFhirDocument(resource));
    frtDocumentReference: ComposeDocumentReference(json, 'DocumentReference', TFhirDocumentReference(resource));
    frtEncounter: ComposeEncounter(json, 'Encounter', TFhirEncounter(resource));
    frtFamilyHistory: ComposeFamilyHistory(json, 'FamilyHistory', TFhirFamilyHistory(resource));
    frtGroup: ComposeGroup(json, 'Group', TFhirGroup(resource));
    frtImagingStudy: ComposeImagingStudy(json, 'ImagingStudy', TFhirImagingStudy(resource));
    frtImmunization: ComposeImmunization(json, 'Immunization', TFhirImmunization(resource));
    frtImmunizationProfile: ComposeImmunizationProfile(json, 'ImmunizationProfile', TFhirImmunizationProfile(resource));
    frtList: ComposeList(json, 'List', TFhirList(resource));
    frtLocation: ComposeLocation(json, 'Location', TFhirLocation(resource));
    frtMedia: ComposeMedia(json, 'Media', TFhirMedia(resource));
    frtMedication: ComposeMedication(json, 'Medication', TFhirMedication(resource));
    frtMedicationAdministration: ComposeMedicationAdministration(json, 'MedicationAdministration', TFhirMedicationAdministration(resource));
    frtMedicationDispense: ComposeMedicationDispense(json, 'MedicationDispense', TFhirMedicationDispense(resource));
    frtMedicationPrescription: ComposeMedicationPrescription(json, 'MedicationPrescription', TFhirMedicationPrescription(resource));
    frtMedicationStatement: ComposeMedicationStatement(json, 'MedicationStatement', TFhirMedicationStatement(resource));
    frtMessage: ComposeMessage(json, 'Message', TFhirMessage(resource));
    frtObservation: ComposeObservation(json, 'Observation', TFhirObservation(resource));
    frtOperationOutcome: ComposeOperationOutcome(json, 'OperationOutcome', TFhirOperationOutcome(resource));
    frtOrder: ComposeOrder(json, 'Order', TFhirOrder(resource));
    frtOrderResponse: ComposeOrderResponse(json, 'OrderResponse', TFhirOrderResponse(resource));
    frtOrganization: ComposeOrganization(json, 'Organization', TFhirOrganization(resource));
    frtOther: ComposeOther(json, 'Other', TFhirOther(resource));
    frtPatient: ComposePatient(json, 'Patient', TFhirPatient(resource));
    frtPractitioner: ComposePractitioner(json, 'Practitioner', TFhirPractitioner(resource));
    frtProcedure: ComposeProcedure(json, 'Procedure', TFhirProcedure(resource));
    frtProfile: ComposeProfile(json, 'Profile', TFhirProfile(resource));
    frtProvenance: ComposeProvenance(json, 'Provenance', TFhirProvenance(resource));
    frtQuery: ComposeQuery(json, 'Query', TFhirQuery(resource));
    frtQuestionnaire: ComposeQuestionnaire(json, 'Questionnaire', TFhirQuestionnaire(resource));
    frtRelatedPerson: ComposeRelatedPerson(json, 'RelatedPerson', TFhirRelatedPerson(resource));
    frtSecurityEvent: ComposeSecurityEvent(json, 'SecurityEvent', TFhirSecurityEvent(resource));
    frtSpecimen: ComposeSpecimen(json, 'Specimen', TFhirSpecimen(resource));
    frtSubstance: ComposeSubstance(json, 'Substance', TFhirSubstance(resource));
    frtSupply: ComposeSupply(json, 'Supply', TFhirSupply(resource));
    frtValueSet: ComposeValueSet(json, 'ValueSet', TFhirValueSet(resource));
    frtBinary: ComposeBinary(json, TFhirBinary(resource));
  else
    raise Exception.create('Internal error: the resource type '+CODES_TFhirResourceType[resource.ResourceType]+' is not a valid resource type');
  end;
end;


end.

