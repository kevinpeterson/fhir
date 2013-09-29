{!Wrapper uses FHIRBase, FHIRBase_Wrapper, FHIRTypes, FHIRTypes_Wrapper, FHIRComponents, FHIRComponents_Wrapper}
{!ignore ALL_RESOURCE_TYPES}

unit FHIRResources;

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
  SysUtils, Classes, StringSupport, DecimalSupport, AdvBuffers, MSSEWrap, FHIRBase, FHIRTypes, FHIRComponents;

Type
  {@Enum TFhirResourceType
    Enumeration of known resource types
  }
  TFhirResourceType = (
    frtNull, {@enum.value Resource type not known / not Specified }
    frtAdverseReaction, {@enum.value Specific reactions to a substance. }
    frtAlert, {@enum.value Prospective warnings of potential issues when providing care to the patient. }
    frtAllergyIntolerance, {@enum.value Allergy/Intolerance. }
    frtCarePlan, {@enum.value Describes the intention of how one or more practitioners intend to deliver care for a particular patient for a period of time, possibly limited to care for a specific condition or set of conditions. }
    frtCondition, {@enum.value Use to record detailed information about conditions, problems or diagnoses recognized by a clinician. There are many uses including: recording a Diagnosis during an Encounter; populating a problem List or a Summary Statement, such as a Discharge Summary. }
    frtConformance, {@enum.value A conformance statement about how an application or implementation supports FHIR or the set of requirements for a desired implementation. }
    frtCoverage, {@enum.value Financial instrument by which payment information for health care. }
    frtDevice, {@enum.value This resource identifies an instance of a manufactured thing that is used in the provision of healthcare without being substantially changed through that activity. The device may be a machine, an insert, a computer, an application, etc. This includes durable (reusable) medical equipment as well as disposable equipment used for diagnostic, treatment, and research for healthcare and public health. }
    frtDeviceCapabilities, {@enum.value Describes the set of data produced by a device. }
    frtDeviceLog, {@enum.value A set of raw data produced by a device. }
    frtDeviceObservation, {@enum.value A set of observations produced by a device. }
    frtDiagnosticOrder, {@enum.value A request for a diagnostic investigation service to be performed. }
    frtDiagnosticReport, {@enum.value The findings and interpretation of diagnostic  tests performed on patients and/or specimens. The report includes clinical context such as requesting and provider information, and some mix of atomic results, images, textual and coded interpretation, and formatted representation of diagnostic reports. }
    frtDocument, {@enum.value A documentation of healthcare-related information that is assembled together into a single statement of meaning that establishes its own context. A document is composed of a set of resources that include both human and computer readable portions. A human may attest to the accuracy of the human readable portion and may authenticate and/or sign the entire whole. A document may be kept as a set of logically linked resources, or they may be bundled together in an atom feed. }
    frtDocumentReference, {@enum.value A reference to a document. }
    frtEncounter, {@enum.value An interaction between a patient and healthcare provider(s) for the purpose of providing healthcare service(s) or assessing the health status of a patient. }
    frtFamilyHistory, {@enum.value Significant health events and conditions for people related to the subject relevant in the context of care for the subject. }
    frtGroup, {@enum.value Represents a defined collection of entities that may be discussed or acted upon collectively but which are not expected to act collectively and are not formally or legally recognized.  I.e. A collection of entities that isn't an Organization. }
    frtImagingStudy, {@enum.value Manifest of a set of images produced in study. The set of images may include every image in the study, or it may be an incomplete sample, such as a list of key images. }
    frtImmunization, {@enum.value Immunization event information. }
    frtImmunizationProfile, {@enum.value A patient's point-of-time immunization status and recommendation with optional supporting justification. }
    frtList, {@enum.value A set of information summarized from a list of other resources. }
    frtLocation, {@enum.value Contact details and position information for a physical place that may be visited and where healthcare resources and participants may be found or contained, accommodated, or stored. }
    frtMedia, {@enum.value A photo, video, or audio recording acquired or used in healthcare. The actual content maybe inline or provided by direct reference. }
    frtMedication, {@enum.value Primarily used for identification and definition of Medication, but also covers ingredients and packaging. }
    frtMedicationAdministration, {@enum.value Describes the event of a patient being given a dose of a medication.  This may be as simple as swallowing a tablet or it may be a long running infusion.

Related resources tie this event to the authorizing prescription, and the specific encounter between patient and health care practitioner. }
    frtMedicationDispense, {@enum.value Dispensing a medication to a named patient.  This includes a description of the supply provided and the instructions for administering the medication. }
    frtMedicationPrescription, {@enum.value An order for both supply of the medication and the instructions for administration of the medicine to a patient. }
    frtMedicationStatement, {@enum.value A record of medication being taken by a patient, or that the medication has been given to a patient where the record is the result of a report from the patient, or another clinician. }
    frtMessage, {@enum.value The root for a transmission either requesting or responding to an action.  The resource(s) that are the subject of the action as well as other Information related to the action are typically transmitted in a bundle of which the Message resource instance is the first resource in the bundle. }
    frtObservation, {@enum.value Simple assertions and measurements made about a patient, device or other subject. }
    frtOperationOutcome, {@enum.value A collection of error, warning or information messages that result from a system action. }
    frtOrder, {@enum.value A request to perform an action. }
    frtOrderResponse, {@enum.value A response to an order. }
    frtOrganization, {@enum.value A formally or informally recognized grouping of people or organizations formed for the purpose of achieving some form of collective action.  Includes companies, institutions, corporations, departments, community groups, healthcare practice groups, etc. }
    frtOther, {@enum.value Other is a conformant for handling resource concepts not yet defined for FHIR or outside HL7's scope of interest. }
    frtPatient, {@enum.value Demographics and other administrative information about a person or animal receiving care or other health-related services. }
    frtPractitioner, {@enum.value Demographics and qualification information for an individual who is directly or indirectly involved in the provisioning of healthcare. }
    frtProcedure, {@enum.value An action that is performed on a patient. This can be a physical 'thing' like an operation, or less invasive like counseling or hypnotherapy. }
    frtProfile, {@enum.value A Resource Profile - a statement of use of one or more FHIR Resources.  It may include constraints on Resources and Data Types, Terminology Binding Statements and Extension Definitions. }
    frtProvenance, {@enum.value Provenance information that describes the activity that lead to the creation of a set of resources. This information can be used to help determine their reliability or trace where the information in them came from. The focus of the provenance resource is record keeping, audit and traceability, and not explicit statements of clinical significance. }
    frtQuery, {@enum.value A description of a query with a set of parameters. }
    frtQuestionnaire, {@enum.value A set of answers to predefined lists of questions. The questions may be ordered and grouped into coherent subsets, corresponding to the structure of the grouping of the underlying questions. }
    frtRelatedPerson, {@enum.value Information about a person that is involved in the care for a patient, but who is not the target of healthcare, nor has a formal responsibility in the care process. }
    frtSecurityEvent, {@enum.value A record of an event made for purposes of maintaining a security log. Typical uses include detection of intrusion attempts and monitoring for inappropriate usage. }
    frtSpecimen, {@enum.value Sample for analysis. }
    frtSubstance, {@enum.value A homogeneous material with a definite composition used in healthcare. }
    frtSupply, {@enum.value A supply -  request and provision. }
    frtValueSet, {@enum.value A value set specifies a set of codes drawn from one or more code systems. }
    frtBinary); {@enum.value Binary Resource }

  TFhirResourceTypeSet = set of TFhirResourceType;
  {@Enum TSearchParamsAdverseReaction
    Search Parameters for AdverseReaction
  }
  TSearchParamsAdverseReaction = (
    spAdverseReaction__id, {@enum.value spAdverseReaction__id The logical resource id associated with the resource (must be supported by all servers) }
    spAdverseReaction_Date, {@enum.value spAdverseReaction_Date the date of the reaction }
    spAdverseReaction_Subject, {@enum.value spAdverseReaction_Subject The subject that the sensitivity is about }
    spAdverseReaction_Substance, {@enum.value spAdverseReaction_Substance The name or code of the substance that produces the sensitivity }
    spAdverseReaction_Symptom); {@enum.value spAdverseReaction_Symptom One of the symptoms of the reaction. }

  {@Enum TSearchParamsAlert
    Search Parameters for Alert
  }
  TSearchParamsAlert = (
    spAlert__id, {@enum.value spAlert__id The logical resource id associated with the resource (must be supported by all servers) }
    spAlert_Subject); {@enum.value spAlert_Subject The identity of a subject to list alerts for }

  {@Enum TSearchParamsAllergyIntolerance
    Search Parameters for AllergyIntolerance
  }
  TSearchParamsAllergyIntolerance = (
    spAllergyIntolerance__id, {@enum.value spAllergyIntolerance__id The logical resource id associated with the resource (must be supported by all servers) }
    spAllergyIntolerance_Date, {@enum.value spAllergyIntolerance_Date recorded date/time. }
    spAllergyIntolerance_Recorder, {@enum.value spAllergyIntolerance_Recorder who recorded the sensitivity }
    spAllergyIntolerance_Status, {@enum.value spAllergyIntolerance_Status The status of the sensitivity }
    spAllergyIntolerance_Subject, {@enum.value spAllergyIntolerance_Subject The subject that the sensitivity is about }
    spAllergyIntolerance_Substance, {@enum.value spAllergyIntolerance_Substance The name or code of the substance that produces the sensitivity }
    spAllergyIntolerance_Type); {@enum.value spAllergyIntolerance_Type The type of sensitivity }

  {@Enum TSearchParamsCarePlan
    Search Parameters for CarePlan
  }
  TSearchParamsCarePlan = (
    spCarePlan__id, {@enum.value spCarePlan__id The logical resource id associated with the resource (must be supported by all servers) }
    spCarePlan_Activity, {@enum.value spCarePlan_Activity [CarePlan.activity.code] }
    spCarePlan_Activitydate, {@enum.value spCarePlan_Activitydate Specified date occurs within period specified by CarePlan.activity.timingSchedule }
    spCarePlan_Condition, {@enum.value spCarePlan_Condition [CarePlan.concern] }
    spCarePlan_Date, {@enum.value spCarePlan_Date [CarePlan.period] contains date }
    spCarePlan_Participant, {@enum.value spCarePlan_Participant [CarePlan.participant.member] }
    spCarePlan_Patient); {@enum.value spCarePlan_Patient [CarePlan.patient] }

  {@Enum TSearchParamsCondition
    Search Parameters for Condition
  }
  TSearchParamsCondition = (
    spCondition__id, {@enum.value spCondition__id The logical resource id associated with the resource (must be supported by all servers) }
    spCondition_Asserter, {@enum.value spCondition_Asserter Person who asserts this condition }
    spCondition_Category, {@enum.value spCondition_Category the category of the condition }
    spCondition_Code, {@enum.value spCondition_Code code for the condition }
    spCondition_Date_asserted, {@enum.value spCondition_Date_asserted When first detected/suspected/entered }
    spCondition_Encounter, {@enum.value spCondition_Encounter Encounter during which the condition was first asserted }
    spCondition_Evidence, {@enum.value spCondition_Evidence Manifestation/symptom }
    spCondition_Location, {@enum.value spCondition_Location Location - may include laterality }
    spCondition_Onset, {@enum.value spCondition_Onset when the Condition started (if started on a date) }
    spCondition_Related_code, {@enum.value spCondition_Related_code Relationship target by means of a predefined code }
    spCondition_Related_item, {@enum.value spCondition_Related_item Relationship target resource }
    spCondition_Severity, {@enum.value spCondition_Severity the severity of the condition }
    spCondition_Stage, {@enum.value spCondition_Stage Simple summary (disease specific) }
    spCondition_Status, {@enum.value spCondition_Status the status of the condition }
    spCondition_Subject); {@enum.value spCondition_Subject Subject of this condition }

  {@Enum TSearchParamsConformance
    Search Parameters for Conformance
  }
  TSearchParamsConformance = (
    spConformance__id, {@enum.value spConformance__id The logical resource id associated with the resource (must be supported by all servers) }
    spConformance_Date, {@enum.value spConformance_Date the conformance statement publication date }
    spConformance_Event, {@enum.value spConformance_Event event code in a conformance statement }
    spConformance_Format, {@enum.value spConformance_Format formats supported (xml | json | mime type) }
    spConformance_Mode, {@enum.value spConformance_Mode mode - restful (server/client) or messaging (sender/receiver) }
    spConformance_Profile, {@enum.value spConformance_Profile a profile id invoked in a conformance statement }
    spConformance_Publisher, {@enum.value spConformance_Publisher part of a publisher name }
    spConformance_Resource, {@enum.value spConformance_Resource name of a resource mentioned in a conformance statement }
    spConformance_Security, {@enum.value spConformance_Security Information about security of implementation }
    spConformance_Software, {@enum.value spConformance_Software part of a the name of a software application }
    spConformance_Version); {@enum.value spConformance_Version the version of FHIR }

  {@Enum TSearchParamsCoverage
    Search Parameters for Coverage
  }
  TSearchParamsCoverage = (
    spCoverage__id, {@enum.value spCoverage__id The logical resource id associated with the resource (must be supported by all servers) }
    spCoverage_Dependent, {@enum.value spCoverage_Dependent Dependent number }
    spCoverage_Group, {@enum.value spCoverage_Group Group identifier }
    spCoverage_Identifier, {@enum.value spCoverage_Identifier The primary identifier of the insured }
    spCoverage_Issuer, {@enum.value spCoverage_Issuer The identity of the insurer }
    spCoverage_Name, {@enum.value spCoverage_Name The name of the subscriber }
    spCoverage_Plan, {@enum.value spCoverage_Plan A plan or policy identifier }
    spCoverage_Sequence, {@enum.value spCoverage_Sequence Sequence number }
    spCoverage_Subplan, {@enum.value spCoverage_Subplan Sub-plan identifier }
    spCoverage_Type); {@enum.value spCoverage_Type The kind of coverage }

  {@Enum TSearchParamsDevice
    Search Parameters for Device
  }
  TSearchParamsDevice = (
    spDevice__id, {@enum.value spDevice__id The logical resource id associated with the resource (must be supported by all servers) }
    spDevice_Assigned_id, {@enum.value spDevice_Assigned_id identifier assigned by the organization }
    spDevice_Location, {@enum.value spDevice_Location Where the resource is found }
    spDevice_Manufacturer, {@enum.value spDevice_Manufacturer the manufacturer of the device }
    spDevice_Model, {@enum.value spDevice_Model the model of the device }
    spDevice_Organization, {@enum.value spDevice_Organization the organization responsible for the device }
    spDevice_Patient, {@enum.value spDevice_Patient If the resource is affixed to a person }
    spDevice_Serial, {@enum.value spDevice_Serial the serial number of the device }
    spDevice_Type); {@enum.value spDevice_Type the type of the device }

  {@Enum TSearchParamsDeviceCapabilities
    Search Parameters for DeviceCapabilities
  }
  TSearchParamsDeviceCapabilities = (
    spDeviceCapabilities__id, {@enum.value spDeviceCapabilities__id The logical resource id associated with the resource (must be supported by all servers) }
    spDeviceCapabilities_Channel, {@enum.value spDeviceCapabilities_Channel The channel code }
    spDeviceCapabilities_Code, {@enum.value spDeviceCapabilities_Code The compatment code }
    spDeviceCapabilities_Datatype, {@enum.value spDeviceCapabilities_Datatype Quantity | Coding | Array | string }
    spDeviceCapabilities_Facet, {@enum.value spDeviceCapabilities_Facet The facet code }
    spDeviceCapabilities_Identity, {@enum.value spDeviceCapabilities_Identity Identifies this particular device uniquely }
    spDeviceCapabilities_Manufacturer, {@enum.value spDeviceCapabilities_Manufacturer Company that built the device }
    spDeviceCapabilities_Metric, {@enum.value spDeviceCapabilities_Metric The metric code }
    spDeviceCapabilities_Name, {@enum.value spDeviceCapabilities_Name The name of this device }
    spDeviceCapabilities_Type); {@enum.value spDeviceCapabilities_Type The type of device }

  {@Enum TSearchParamsDeviceLog
    Search Parameters for DeviceLog
  }
  TSearchParamsDeviceLog = (
    spDeviceLog__id, {@enum.value spDeviceLog__id The logical resource id associated with the resource (must be supported by all servers) }
    spDeviceLog_Capabilities, {@enum.value spDeviceLog_Capabilities Explicit reference to the capabilities }
    spDeviceLog_Flag, {@enum.value spDeviceLog_Flag Information about the quality of the data etc }
    spDeviceLog_Instant, {@enum.value spDeviceLog_Instant When the data values are reported }
    spDeviceLog_Key, {@enum.value spDeviceLog_Key Reference to device capabilities declaration }
    spDeviceLog_Subject, {@enum.value spDeviceLog_Subject Subject of the measurement }
    spDeviceLog_Value); {@enum.value spDeviceLog_Value The value of the data item, if available }

  {@Enum TSearchParamsDeviceObservation
    Search Parameters for DeviceObservation
  }
  TSearchParamsDeviceObservation = (
    spDeviceObservation__id, {@enum.value spDeviceObservation__id The logical resource id associated with the resource (must be supported by all servers) }
    spDeviceObservation_Code, {@enum.value spDeviceObservation_Code Type of device observation }
    spDeviceObservation_Device, {@enum.value spDeviceObservation_Device Device that produced the results }
    spDeviceObservation_Identifier, {@enum.value spDeviceObservation_Identifier Identifiers assigned to this observation }
    spDeviceObservation_Issued, {@enum.value spDeviceObservation_Issued Date the measurements were made }
    spDeviceObservation_Measurement, {@enum.value spDeviceObservation_Measurement Actual measurements }
    spDeviceObservation_Subject); {@enum.value spDeviceObservation_Subject The subject of the measurements }

  {@Enum TSearchParamsDiagnosticOrder
    Search Parameters for DiagnosticOrder
  }
  TSearchParamsDiagnosticOrder = (
    spDiagnosticOrder__id, {@enum.value spDiagnosticOrder__id The logical resource id associated with the resource (must be supported by all servers) }
    spDiagnosticOrder_Actor, {@enum.value spDiagnosticOrder_Actor Who recorded or did this }
    spDiagnosticOrder_Bodysite, {@enum.value spDiagnosticOrder_Bodysite Location of requested test (if applicable) }
    spDiagnosticOrder_Code, {@enum.value spDiagnosticOrder_Code Code for this item }
    spDiagnosticOrder_Date, {@enum.value spDiagnosticOrder_Date The date at which the event happened }
    spDiagnosticOrder_Encounter, {@enum.value spDiagnosticOrder_Encounter The encounter that this diagnostic order is associated with }
    spDiagnosticOrder_Identifier, {@enum.value spDiagnosticOrder_Identifier Identifiers assigned to this order }
    spDiagnosticOrder_Item_date, {@enum.value spDiagnosticOrder_Item_date The date at which the event happened }
    spDiagnosticOrder_Item_past_status, {@enum.value spDiagnosticOrder_Item_past_status requested | received | accepted | inprogress | review | complete | suspended | rejected | failed }
    spDiagnosticOrder_Item_status, {@enum.value spDiagnosticOrder_Item_status requested | received | accepted | inprogress | review | complete | suspended | rejected | failed }
    spDiagnosticOrder_Item_status_date, {@enum.value spDiagnosticOrder_Item_status_date A combination of item-past-status and item-date }
    spDiagnosticOrder_Orderer, {@enum.value spDiagnosticOrder_Orderer Who ordered the test }
    spDiagnosticOrder_Past_status, {@enum.value spDiagnosticOrder_Past_status requested | received | accepted | inprogress | review | complete | suspended | rejected | failed }
    spDiagnosticOrder_Specimen, {@enum.value spDiagnosticOrder_Specimen If the whole order relates to specific specimens }
    spDiagnosticOrder_Status, {@enum.value spDiagnosticOrder_Status requested | received | accepted | inprogress | review | complete | suspended | rejected | failed }
    spDiagnosticOrder_Status_date, {@enum.value spDiagnosticOrder_Status_date A combination of past-status and date }
    spDiagnosticOrder_Subject); {@enum.value spDiagnosticOrder_Subject Who/what test is about }

  {@Enum TSearchParamsDiagnosticReport
    Search Parameters for DiagnosticReport
  }
  TSearchParamsDiagnosticReport = (
    spDiagnosticReport__id, {@enum.value spDiagnosticReport__id The logical resource id associated with the resource (must be supported by all servers) }
    spDiagnosticReport_Code, {@enum.value spDiagnosticReport_Code a coded diagnosis on the report }
    spDiagnosticReport_Date, {@enum.value spDiagnosticReport_Date the clinically relevant time of the report }
    spDiagnosticReport_Group, {@enum.value spDiagnosticReport_Group name /code of a group in the report }
    spDiagnosticReport_Identifier, {@enum.value spDiagnosticReport_Identifier an identifier for the report }
    spDiagnosticReport_Issued, {@enum.value spDiagnosticReport_Issued when the report was issued }
    spDiagnosticReport_Name, {@enum.value spDiagnosticReport_Name the name/code of the report }
    spDiagnosticReport_Performer, {@enum.value spDiagnosticReport_Performer who was the source of the report (organization) }
    spDiagnosticReport_Requester, {@enum.value spDiagnosticReport_Requester who made a request that lead to the report }
    spDiagnosticReport_Result, {@enum.value spDiagnosticReport_Result link to an atomic result (observation resource) }
    spDiagnosticReport_Service, {@enum.value spDiagnosticReport_Service which diagnostic discipline/department created the report }
    spDiagnosticReport_Specimen, {@enum.value spDiagnosticReport_Specimen the specimen details }
    spDiagnosticReport_Status, {@enum.value spDiagnosticReport_Status The status of the report }
    spDiagnosticReport_Subject, {@enum.value spDiagnosticReport_Subject the subject of the report }
    spDiagnosticReport_Test); {@enum.value spDiagnosticReport_Test a test requested that the report is in response to }

  {@Enum TSearchParamsDocument
    Search Parameters for Document
  }
  TSearchParamsDocument = (
    spDocument__id, {@enum.value spDocument__id The logical resource id associated with the resource (must be supported by all servers) }
    spDocument_Attester, {@enum.value spDocument_Attester attester of the document }
    spDocument_Author, {@enum.value spDocument_Author author of the document }
    spDocument_Context, {@enum.value spDocument_Context context of the document }
    spDocument_Date, {@enum.value spDocument_Date the document creation time }
    spDocument_Identifier, {@enum.value spDocument_Identifier Logical identifier for document (version-independent) }
    spDocument_Section_content, {@enum.value spDocument_Section_content content resource of the section }
    spDocument_Section_type, {@enum.value spDocument_Section_type code of the document }
    spDocument_Subject, {@enum.value spDocument_Subject subject of the document }
    spDocument_Type, {@enum.value spDocument_Type the type of the document }
    spDocument_Version); {@enum.value spDocument_Version Version-specific identifier for document }

  {@Enum TSearchParamsDocumentReference
    Search Parameters for DocumentReference
  }
  TSearchParamsDocumentReference = (
    spDocumentReference__id, {@enum.value spDocumentReference__id The logical resource id associated with the resource (must be supported by all servers) }
    spDocumentReference_Authenticator, {@enum.value spDocumentReference_Authenticator Who authenticated the document }
    spDocumentReference_Author, {@enum.value spDocumentReference_Author Who/what authored the document }
    spDocumentReference_Confidentiality, {@enum.value spDocumentReference_Confidentiality Sensitivity of source document }
    spDocumentReference_Created, {@enum.value spDocumentReference_Created Document creation time }
    spDocumentReference_Custodian, {@enum.value spDocumentReference_Custodian Org which maintains the document }
    spDocumentReference_Description, {@enum.value spDocumentReference_Description Human Readable description (title) }
    spDocumentReference_Event, {@enum.value spDocumentReference_Event Type of context (i.e. type of event) }
    spDocumentReference_Facility, {@enum.value spDocumentReference_Facility Kind of facility where patient was seen }
    spDocumentReference_Format, {@enum.value spDocumentReference_Format Format of the document }
    spDocumentReference_Identifier, {@enum.value spDocumentReference_Identifier Other identifiers for the document }
    spDocumentReference_Indexed, {@enum.value spDocumentReference_Indexed When this document reference created }
    spDocumentReference_Language, {@enum.value spDocumentReference_Language Primary language of the document }
    spDocumentReference_Location, {@enum.value spDocumentReference_Location Where to access the document }
    spDocumentReference_Period, {@enum.value spDocumentReference_Period Time described by the document }
    spDocumentReference_Size, {@enum.value spDocumentReference_Size Size of the document in bytes }
    spDocumentReference_Status, {@enum.value spDocumentReference_Status current | superseded | error }
    spDocumentReference_Subject, {@enum.value spDocumentReference_Subject The subject of the document }
    spDocumentReference_Subtype, {@enum.value spDocumentReference_Subtype More detail about the document type }
    spDocumentReference_Supersedes, {@enum.value spDocumentReference_Supersedes If this document replaces another }
    spDocumentReference_Type); {@enum.value spDocumentReference_Type What kind of document this is (LOINC if possible) }

  {@Enum TSearchParamsEncounter
    Search Parameters for Encounter
  }
  TSearchParamsEncounter = (
    spEncounter__id, {@enum.value spEncounter__id The logical resource id associated with the resource (must be supported by all servers) }
    spEncounter_Fulfills, {@enum.value spEncounter_Fulfills The appointment that scheduled this encounter }
    spEncounter_Identifier, {@enum.value spEncounter_Identifier Identifier(s) by which this encounter is known }
    spEncounter_Indication, {@enum.value spEncounter_Indication Reason the encounter takes place }
    spEncounter_Length, {@enum.value spEncounter_Length Length of encounter in days }
    spEncounter_Start, {@enum.value spEncounter_Start The date and time the encounter starts }
    spEncounter_Status, {@enum.value spEncounter_Status E.g. active, aborted, finished }
    spEncounter_Subject); {@enum.value spEncounter_Subject The patient present at the encounter }

  {@Enum TSearchParamsFamilyHistory
    Search Parameters for FamilyHistory
  }
  TSearchParamsFamilyHistory = (
    spFamilyHistory__id, {@enum.value spFamilyHistory__id The logical resource id associated with the resource (must be supported by all servers) }
    spFamilyHistory_Subject); {@enum.value spFamilyHistory_Subject The identity of a subject to list family history items for }

  {@Enum TSearchParamsGroup
    Search Parameters for Group
  }
  TSearchParamsGroup = (
    spGroup__id, {@enum.value spGroup__id The logical resource id associated with the resource (must be supported by all servers) }
    spGroup_Actual, {@enum.value spGroup_Actual Descriptive or actual }
    spGroup_Code, {@enum.value spGroup_Code The kind of resources contained }
    spGroup_Exclude, {@enum.value spGroup_Exclude Group includes or excludes }
    spGroup_Group_type, {@enum.value spGroup_Group_type The type of resources the group contains }
    spGroup_Identifier, {@enum.value spGroup_Identifier Unique id }
    spGroup_Member, {@enum.value spGroup_Member Who is in group }
    spGroup_Type, {@enum.value spGroup_Type Kind of characteristic }
    spGroup_Type_value, {@enum.value spGroup_Type_value A composite of both type and value }
    spGroup_Value); {@enum.value spGroup_Value Value held by characteristic }

  {@Enum TSearchParamsImagingStudy
    Search Parameters for ImagingStudy
  }
  TSearchParamsImagingStudy = (
    spImagingStudy__id, {@enum.value spImagingStudy__id The logical resource id associated with the resource (must be supported by all servers) }
    spImagingStudy_Accession, {@enum.value spImagingStudy_Accession the accession id for the image }
    spImagingStudy_Bodysite, {@enum.value spImagingStudy_Bodysite Body part examined (Map from 0018,0015) }
    spImagingStudy_Date, {@enum.value spImagingStudy_Date the date the study was done was taken }
    spImagingStudy_Dicom_class, {@enum.value spImagingStudy_Dicom_class DICOM class type (0008,0016) }
    spImagingStudy_Modality, {@enum.value spImagingStudy_Modality the modality of the image }
    spImagingStudy_Series, {@enum.value spImagingStudy_Series the series id for the image }
    spImagingStudy_Size, {@enum.value spImagingStudy_Size the size of the image in MB - may include > or < in the value }
    spImagingStudy_Study, {@enum.value spImagingStudy_Study the study id for the image }
    spImagingStudy_Subject, {@enum.value spImagingStudy_Subject Who the study is about }
    spImagingStudy_Uid); {@enum.value spImagingStudy_Uid Formal identifier for this instance (0008,0018) }

  {@Enum TSearchParamsImmunization
    Search Parameters for Immunization
  }
  TSearchParamsImmunization = (
    spImmunization__id, {@enum.value spImmunization__id The logical resource id associated with the resource (must be supported by all servers) }
    spImmunization_Date, {@enum.value spImmunization_Date Vaccination  Administration / Refusal Date }
    spImmunization_Location, {@enum.value spImmunization_Location The service delivery location or facility in which the vaccine was / was to be administered }
    spImmunization_Lot_number, {@enum.value spImmunization_Lot_number Vaccine Lot Number }
    spImmunization_Manufacturer, {@enum.value spImmunization_Manufacturer Vaccine Manufacturer }
    spImmunization_Performer, {@enum.value spImmunization_Performer The practitioner who administered the vaccination }
    spImmunization_Refusal_reason, {@enum.value spImmunization_Refusal_reason Explanation of refusal / exemption }
    spImmunization_Requester, {@enum.value spImmunization_Requester The practitioner who ordered the vaccination }
    spImmunization_Subject, {@enum.value spImmunization_Subject The subject of the vaccination event / refusal }
    spImmunization_Vaccine_type); {@enum.value spImmunization_Vaccine_type Vaccine Product Type Administered }

  {@Enum TSearchParamsImmunizationProfile
    Search Parameters for ImmunizationProfile
  }
  TSearchParamsImmunizationProfile = (
    spImmunizationProfile__id, {@enum.value spImmunizationProfile__id The logical resource id associated with the resource (must be supported by all servers) }
    spImmunizationProfile_Subject, {@enum.value spImmunizationProfile_Subject Who this profile is for }
    spImmunizationProfile_Vaccine_type); {@enum.value spImmunizationProfile_Vaccine_type Vaccine that pertains to the recommendation }

  {@Enum TSearchParamsList
    Search Parameters for List
  }
  TSearchParamsList = (
    spList__id, {@enum.value spList__id The logical resource id associated with the resource (must be supported by all servers) }
    spList_Code, {@enum.value spList_Code What the purpose of this list is }
    spList_Date, {@enum.value spList_Date When the list was prepared }
    spList_Empty_reason, {@enum.value spList_Empty_reason Why list is empty }
    spList_Item, {@enum.value spList_Item Actual entry }
    spList_Source); {@enum.value spList_Source Source of the list }

  {@Enum TSearchParamsLocation
    Search Parameters for Location
  }
  TSearchParamsLocation = (
    spLocation__id, {@enum.value spLocation__id The logical resource id associated with the resource (must be supported by all servers) }
    spLocation_Active, {@enum.value spLocation_Active Whether to search for active or inactive locations }
    spLocation_Address, {@enum.value spLocation_Address A (part of the) address of the location }
    spLocation_Name, {@enum.value spLocation_Name A (portion of the) name of the location }
    spLocation_Near, {@enum.value spLocation_Near The coordinates expressed as [lat],[long] (using KML, see notes) to find locations near to (servers may search using a square rather than a circle for efficiency) }
    spLocation_Near_distance, {@enum.value spLocation_Near_distance A distance quantity to limit the near search to locations within a specific distance }
    spLocation_Partof, {@enum.value spLocation_Partof The location of which this location is a part }
    spLocation_Type); {@enum.value spLocation_Type A code for the type of location }

  {@Enum TSearchParamsMedia
    Search Parameters for Media
  }
  TSearchParamsMedia = (
    spMedia__id, {@enum.value spMedia__id The logical resource id associated with the resource (must be supported by all servers) }
    spMedia_Date, {@enum.value spMedia_Date When the media was taken/recorded }
    spMedia_Identifier, {@enum.value spMedia_Identifier Identifier(s) for the image }
    spMedia_Operator, {@enum.value spMedia_Operator The person who generated the image }
    spMedia_Subject, {@enum.value spMedia_Subject Who/What this Media is a record of }
    spMedia_Subtype, {@enum.value spMedia_Subtype The type of acquisition equipment/process }
    spMedia_Type, {@enum.value spMedia_Type photo | audio | video }
    spMedia_View); {@enum.value spMedia_View Imaging view e.g Lateral or Antero-posterior }

  {@Enum TSearchParamsMedication
    Search Parameters for Medication
  }
  TSearchParamsMedication = (
    spMedication__id, {@enum.value spMedication__id The logical resource id associated with the resource (must be supported by all servers) }
    spMedication_Code, {@enum.value spMedication_Code References to std. medication terminologies }
    spMedication_Container, {@enum.value spMedication_Container Kind of container }
    spMedication_Content, {@enum.value spMedication_Content A product in the package }
    spMedication_Form, {@enum.value spMedication_Form Powder | tablets | carton etc }
    spMedication_Ingredient, {@enum.value spMedication_Ingredient Ingredient }
    spMedication_Manufacturer, {@enum.value spMedication_Manufacturer Manufacturer of the item }
    spMedication_Name); {@enum.value spMedication_Name Common / Commercial name }

  {@Enum TSearchParamsMedicationAdministration
    Search Parameters for MedicationAdministration
  }
  TSearchParamsMedicationAdministration = (
    spMedicationAdministration__id, {@enum.value spMedicationAdministration__id The logical resource id associated with the resource (must be supported by all servers) }
    spMedicationAdministration_Administrationdevice, {@enum.value spMedicationAdministration_Administrationdevice Return administrations with this administration device identity }
    spMedicationAdministration_Encounter, {@enum.value spMedicationAdministration_Encounter Return administrations that share this encounter }
    spMedicationAdministration_Identifier, {@enum.value spMedicationAdministration_Identifier Return administrations with this external identity }
    spMedicationAdministration_Medication, {@enum.value spMedicationAdministration_Medication Return administrations of this medication }
    spMedicationAdministration_Notgiven, {@enum.value spMedicationAdministration_Notgiven Administrations that were not made }
    spMedicationAdministration_Patient, {@enum.value spMedicationAdministration_Patient The identity of a patient to list administrations  for }
    spMedicationAdministration_Prescription, {@enum.value spMedicationAdministration_Prescription The identity of a prescription to list administrations from }
    spMedicationAdministration_Status, {@enum.value spMedicationAdministration_Status MedicationAdministration event status (for example one of active/paused/completed/nullified) }
    spMedicationAdministration_Whengiven); {@enum.value spMedicationAdministration_Whengiven Date of administration }

  {@Enum TSearchParamsMedicationDispense
    Search Parameters for MedicationDispense
  }
  TSearchParamsMedicationDispense = (
    spMedicationDispense__id, {@enum.value spMedicationDispense__id The logical resource id associated with the resource (must be supported by all servers) }
    spMedicationDispense_Destination, {@enum.value spMedicationDispense_Destination Return dispenses that should be sent to a secific destination }
    spMedicationDispense_Dispenser, {@enum.value spMedicationDispense_Dispenser Return all dispenses performed by a specific indiividual }
    spMedicationDispense_Identifier, {@enum.value spMedicationDispense_Identifier Return dispenses with this external identity }
    spMedicationDispense_Medication, {@enum.value spMedicationDispense_Medication Returns dispenses of this medicine }
    spMedicationDispense_Patient, {@enum.value spMedicationDispense_Patient The identity of a patient to list dispenses  for }
    spMedicationDispense_Prescription, {@enum.value spMedicationDispense_Prescription The identity of a prescription to list dispenses from }
    spMedicationDispense_Responsibleparty, {@enum.value spMedicationDispense_Responsibleparty Return all dispenses with the specified responsibel party }
    spMedicationDispense_Status, {@enum.value spMedicationDispense_Status Status of the dispense }
    spMedicationDispense_Type, {@enum.value spMedicationDispense_Type Return all dispenses of a specific type }
    spMedicationDispense_Whenhandedover, {@enum.value spMedicationDispense_Whenhandedover Date when medication handed over to patient (outpatient setting), or supplied to ward or clinic (inpatient setting) }
    spMedicationDispense_Whenprepared); {@enum.value spMedicationDispense_Whenprepared Date when medication prepared }

  {@Enum TSearchParamsMedicationPrescription
    Search Parameters for MedicationPrescription
  }
  TSearchParamsMedicationPrescription = (
    spMedicationPrescription__id, {@enum.value spMedicationPrescription__id The logical resource id associated with the resource (must be supported by all servers) }
    spMedicationPrescription_Datewritten, {@enum.value spMedicationPrescription_Datewritten Return prescriptions written on this date }
    spMedicationPrescription_Encounter, {@enum.value spMedicationPrescription_Encounter Return prescriptions with this encounter identity }
    spMedicationPrescription_Identifier, {@enum.value spMedicationPrescription_Identifier Return prescriptions with this external identity }
    spMedicationPrescription_Medication, {@enum.value spMedicationPrescription_Medication Code for medicine or text in medicine name }
    spMedicationPrescription_Patient, {@enum.value spMedicationPrescription_Patient The identity of a patient to list dispenses  for }
    spMedicationPrescription_Status); {@enum.value spMedicationPrescription_Status Status of the prescription }

  {@Enum TSearchParamsMedicationStatement
    Search Parameters for MedicationStatement
  }
  TSearchParamsMedicationStatement = (
    spMedicationStatement__id, {@enum.value spMedicationStatement__id The logical resource id associated with the resource (must be supported by all servers) }
    spMedicationStatement_Administrationdevice, {@enum.value spMedicationStatement_Administrationdevice Return administrations with this administration device identity }
    spMedicationStatement_Identifier, {@enum.value spMedicationStatement_Identifier Return administrations with this external identity }
    spMedicationStatement_Medication, {@enum.value spMedicationStatement_Medication Code for medicine or text in medicine name }
    spMedicationStatement_Patient, {@enum.value spMedicationStatement_Patient The identity of a patient to list administrations  for }
    spMedicationStatement_When_given); {@enum.value spMedicationStatement_When_given Date of administration }

  {@Enum TSearchParamsMessage
    Search Parameters for Message
  }
  TSearchParamsMessage = (
    spMessage__id); {@enum.value spMessage__id The logical resource id associated with the resource (must be supported by all servers) }

  {@Enum TSearchParamsObservation
    Search Parameters for Observation
  }
  TSearchParamsObservation = (
    spObservation__id, {@enum.value spObservation__id The logical resource id associated with the resource (must be supported by all servers) }
    spObservation_Date, {@enum.value spObservation_Date obtained date/time. If the obtained element is a period, a date that falls in the period }
    spObservation_Name, {@enum.value spObservation_Name The name of the observation type or component type }
    spObservation_Name_value, {@enum.value spObservation_Name_value Both name and value }
    spObservation_Performer, {@enum.value spObservation_Performer who/what performed the observation }
    spObservation_Reliability, {@enum.value spObservation_Reliability The reliability of the observation }
    spObservation_Status, {@enum.value spObservation_Status The status of the observation }
    spObservation_Subject, {@enum.value spObservation_Subject The subject that the observation is about }
    spObservation_Value); {@enum.value spObservation_Value The code or value of a result }

  {@Enum TSearchParamsOperationOutcome
    Search Parameters for OperationOutcome
  }
  TSearchParamsOperationOutcome = (
    spOperationOutcome__id); {@enum.value spOperationOutcome__id The logical resource id associated with the resource (must be supported by all servers) }

  {@Enum TSearchParamsOrder
    Search Parameters for Order
  }
  TSearchParamsOrder = (
    spOrder__id, {@enum.value spOrder__id The logical resource id associated with the resource (must be supported by all servers) }
    spOrder_Authority, {@enum.value spOrder_Authority If required by policy }
    spOrder_Date, {@enum.value spOrder_Date When the order was made }
    spOrder_Detail, {@enum.value spOrder_Detail What action is being ordered }
    spOrder_Source, {@enum.value spOrder_Source Who initiated the order }
    spOrder_Subject, {@enum.value spOrder_Subject Patient this order is about }
    spOrder_Target, {@enum.value spOrder_Target Who is intended to fulfill the order }
    spOrder_When, {@enum.value spOrder_When A formal schedule }
    spOrder_When_code); {@enum.value spOrder_When_code Code specifies when request should be done. The code may simply be a priority code }

  {@Enum TSearchParamsOrderResponse
    Search Parameters for OrderResponse
  }
  TSearchParamsOrderResponse = (
    spOrderResponse__id, {@enum.value spOrderResponse__id The logical resource id associated with the resource (must be supported by all servers) }
    spOrderResponse_Authority, {@enum.value spOrderResponse_Authority If required by policy }
    spOrderResponse_Code, {@enum.value spOrderResponse_Code The status of the response }
    spOrderResponse_Cost, {@enum.value spOrderResponse_Cost How much the request will/did cost }
    spOrderResponse_Date, {@enum.value spOrderResponse_Date When the response was made }
    spOrderResponse_Fulfillment, {@enum.value spOrderResponse_Fulfillment Details of the outcome of performing the order }
    spOrderResponse_Request, {@enum.value spOrderResponse_Request The order that this is a response to }
    spOrderResponse_Who); {@enum.value spOrderResponse_Who Who made the response }

  {@Enum TSearchParamsOrganization
    Search Parameters for Organization
  }
  TSearchParamsOrganization = (
    spOrganization__id, {@enum.value spOrganization__id The logical resource id associated with the resource (must be supported by all servers) }
    spOrganization_Active, {@enum.value spOrganization_Active Whether the organization's record is active }
    spOrganization_Identifier, {@enum.value spOrganization_Identifier Any identifier for the organization (not the accreditation issuer's identifier) }
    spOrganization_Name, {@enum.value spOrganization_Name A portion of the organization's name }
    spOrganization_Partof, {@enum.value spOrganization_Partof Search all organizations that are part of the given organization }
    spOrganization_Phonetic, {@enum.value spOrganization_Phonetic A portion of the organization's name using some kind of phonetic matching algorithm }
    spOrganization_Type); {@enum.value spOrganization_Type A code for the type of organization }

  {@Enum TSearchParamsOther
    Search Parameters for Other
  }
  TSearchParamsOther = (
    spOther__id, {@enum.value spOther__id The logical resource id associated with the resource (must be supported by all servers) }
    spOther_Created, {@enum.value spOther_Created When created }
    spOther_Subject); {@enum.value spOther_Subject Identifies the }

  {@Enum TSearchParamsPatient
    Search Parameters for Patient
  }
  TSearchParamsPatient = (
    spPatient__id, {@enum.value spPatient__id The logical resource id associated with the resource (must be supported by all servers) }
    spPatient_Active, {@enum.value spPatient_Active Whether the patient record is active }
    spPatient_Address, {@enum.value spPatient_Address an address in any kind of address/part of the patient }
    spPatient_Animal_breed, {@enum.value spPatient_Animal_breed the breed for animal patients }
    spPatient_Animal_species, {@enum.value spPatient_Animal_species the species for animal patients }
    spPatient_Birthdate, {@enum.value spPatient_Birthdate the patient's date of birth }
    spPatient_Family, {@enum.value spPatient_Family a portion of the family name of the patient }
    spPatient_Gender, {@enum.value spPatient_Gender gender of the patient }
    spPatient_Given, {@enum.value spPatient_Given a portion of the given name of the patient }
    spPatient_Identifier, {@enum.value spPatient_Identifier A patient identifier }
    spPatient_Language, {@enum.value spPatient_Language language code (irrespective of use value) }
    spPatient_Name, {@enum.value spPatient_Name a portion of either family or given name of the patient }
    spPatient_Phonetic, {@enum.value spPatient_Phonetic a portion of either family or given name using some kind of phonetic matching algorithm }
    spPatient_Provider, {@enum.value spPatient_Provider The identity of the organization at which this person is a patient }
    spPatient_Telecom); {@enum.value spPatient_Telecom the value in any kind of telecom details of the patient }

  {@Enum TSearchParamsPractitioner
    Search Parameters for Practitioner
  }
  TSearchParamsPractitioner = (
    spPractitioner__id, {@enum.value spPractitioner__id The logical resource id associated with the resource (must be supported by all servers) }
    spPractitioner_Address, {@enum.value spPractitioner_Address an address in any kind of address/part }
    spPractitioner_Family, {@enum.value spPractitioner_Family a portion of the family name }
    spPractitioner_Gender, {@enum.value spPractitioner_Gender gender of the practitioner }
    spPractitioner_Given, {@enum.value spPractitioner_Given a portion of the given name }
    spPractitioner_Identifier, {@enum.value spPractitioner_Identifier A practitioner's Identifier }
    spPractitioner_Name, {@enum.value spPractitioner_Name a portion of either family or given name }
    spPractitioner_Organization, {@enum.value spPractitioner_Organization The identity of the organization the practitioner represents / acts on behalf of }
    spPractitioner_Phonetic, {@enum.value spPractitioner_Phonetic a portion of either family or given name using some kind of phonetic matching algorithm }
    spPractitioner_Telecom); {@enum.value spPractitioner_Telecom the value in any kind of contact }

  {@Enum TSearchParamsProcedure
    Search Parameters for Procedure
  }
  TSearchParamsProcedure = (
    spProcedure__id, {@enum.value spProcedure__id The logical resource id associated with the resource (must be supported by all servers) }
    spProcedure_Date, {@enum.value spProcedure_Date the date the procedure was performed on }
    spProcedure_Subject, {@enum.value spProcedure_Subject The identity of a patient to list procedures  for }
    spProcedure_Type); {@enum.value spProcedure_Type type of procedure }

  {@Enum TSearchParamsProfile
    Search Parameters for Profile
  }
  TSearchParamsProfile = (
    spProfile__id, {@enum.value spProfile__id The logical resource id associated with the resource (must be supported by all servers) }
    spProfile_Author, {@enum.value spProfile_Author Name or id of the author of the profile }
    spProfile_Binding, {@enum.value spProfile_Binding A vocabulary binding code }
    spProfile_Code, {@enum.value spProfile_Code A code for the profile in the format uri::code (server may choose to do subsumption) }
    spProfile_Date, {@enum.value spProfile_Date The profile publication date }
    spProfile_Extension, {@enum.value spProfile_Extension An extension code (use or definition) }
    spProfile_Name, {@enum.value spProfile_Name A portion of the name of the profile }
    spProfile_Reference, {@enum.value spProfile_Reference An id of another profile referenced in the profile }
    spProfile_Resource, {@enum.value spProfile_Resource A resource constrained in a profile }
    spProfile_Status, {@enum.value spProfile_Status The current status of the profile }
    spProfile_Type, {@enum.value spProfile_Type Type of resource that is constrained in the profile }
    spProfile_Word); {@enum.value spProfile_Word A word somewhere in the definition of the profile or the elements in the resource. (Common words  - 'and', etc. - are often not supported) }

  {@Enum TSearchParamsProvenance
    Search Parameters for Provenance
  }
  TSearchParamsProvenance = (
    spProvenance__id, {@enum.value spProvenance__id The logical resource id associated with the resource (must be supported by all servers) }
    spProvenance_End, {@enum.value spProvenance_End The end of the period, if not ongoing }
    spProvenance_Location, {@enum.value spProvenance_Location Where the activity occurred, if relevant }
    spProvenance_Party, {@enum.value spProvenance_Party Identity of agent (urn or url) }
    spProvenance_Partytype, {@enum.value spProvenance_Partytype Resource | Person | Application | Record | Document + }
    spProvenance_Start, {@enum.value spProvenance_Start The start of the period }
    spProvenance_Target); {@enum.value spProvenance_Target Target resource(s) (usually version specific) }

  {@Enum TSearchParamsQuery
    Search Parameters for Query
  }
  TSearchParamsQuery = (
    spQuery__id, {@enum.value spQuery__id The logical resource id associated with the resource (must be supported by all servers) }
    spQuery_Identifier, {@enum.value spQuery_Identifier Links query and its response(s) }
    spQuery_Response); {@enum.value spQuery_Response Links response to source query }

  {@Enum TSearchParamsQuestionnaire
    Search Parameters for Questionnaire
  }
  TSearchParamsQuestionnaire = (
    spQuestionnaire__id, {@enum.value spQuestionnaire__id The logical resource id associated with the resource (must be supported by all servers) }
    spQuestionnaire_Author, {@enum.value spQuestionnaire_Author the author of the questionnaire }
    spQuestionnaire_Authored, {@enum.value spQuestionnaire_Authored when the questionnaire was authored }
    spQuestionnaire_Encounter, {@enum.value spQuestionnaire_Encounter encounter during which questionnaire was authored }
    spQuestionnaire_Identifier, {@enum.value spQuestionnaire_Identifier an identifier for the questionnaire }
    spQuestionnaire_Name, {@enum.value spQuestionnaire_Name name of the questionnaire }
    spQuestionnaire_Status, {@enum.value spQuestionnaire_Status The status of the questionnaire }
    spQuestionnaire_Subject); {@enum.value spQuestionnaire_Subject the subject of the questionnaire }

  {@Enum TSearchParamsRelatedPerson
    Search Parameters for RelatedPerson
  }
  TSearchParamsRelatedPerson = (
    spRelatedPerson__id, {@enum.value spRelatedPerson__id The logical resource id associated with the resource (must be supported by all servers) }
    spRelatedPerson_Address, {@enum.value spRelatedPerson_Address an address in any kind of address/part }
    spRelatedPerson_Gender, {@enum.value spRelatedPerson_Gender gender of the person }
    spRelatedPerson_Identifier, {@enum.value spRelatedPerson_Identifier A patient Identifier }
    spRelatedPerson_Name, {@enum.value spRelatedPerson_Name a portion of name in any name part }
    spRelatedPerson_Patient, {@enum.value spRelatedPerson_Patient The patient this person is related to }
    spRelatedPerson_Phonetic, {@enum.value spRelatedPerson_Phonetic a portion of name using some kind of phonetic matching algorithm }
    spRelatedPerson_Telecom); {@enum.value spRelatedPerson_Telecom the value in any kind of contact }

  {@Enum TSearchParamsSecurityEvent
    Search Parameters for SecurityEvent
  }
  TSearchParamsSecurityEvent = (
    spSecurityEvent__id, {@enum.value spSecurityEvent__id The logical resource id associated with the resource (must be supported by all servers) }
    spSecurityEvent_Action, {@enum.value spSecurityEvent_Action Type of action performed during the event }
    spSecurityEvent_Address, {@enum.value spSecurityEvent_Address Identifier for the network access point of the user device }
    spSecurityEvent_Authid, {@enum.value spSecurityEvent_Authid User id used by authentication system }
    spSecurityEvent_Date, {@enum.value spSecurityEvent_Date Time when the event occurred on source }
    spSecurityEvent_Desc, {@enum.value spSecurityEvent_Desc Instance-specific descriptor for Object }
    spSecurityEvent_Identity, {@enum.value spSecurityEvent_Identity Specific instance of object (e.g. versioned) }
    spSecurityEvent_Name, {@enum.value spSecurityEvent_Name Human-meaningful name for the user }
    spSecurityEvent_Object_type, {@enum.value spSecurityEvent_Object_type Object type being audited }
    spSecurityEvent_Patientid, {@enum.value spSecurityEvent_Patientid The id of the patient (one of multiple kinds of participations) }
    spSecurityEvent_Reference, {@enum.value spSecurityEvent_Reference Specific instance of resource (e.g. versioned) }
    spSecurityEvent_Site, {@enum.value spSecurityEvent_Site Logical source location within the enterprise }
    spSecurityEvent_Source, {@enum.value spSecurityEvent_Source The id of source where event originated }
    spSecurityEvent_Subtype, {@enum.value spSecurityEvent_Subtype Sub-type of event }
    spSecurityEvent_Type, {@enum.value spSecurityEvent_Type Type of event }
    spSecurityEvent_User); {@enum.value spSecurityEvent_User Unique identifier for the user }

  {@Enum TSearchParamsSpecimen
    Search Parameters for Specimen
  }
  TSearchParamsSpecimen = (
    spSpecimen__id, {@enum.value spSpecimen__id The logical resource id associated with the resource (must be supported by all servers) }
    spSpecimen_Subject); {@enum.value spSpecimen_Subject the subject of the specimen }

  {@Enum TSearchParamsSubstance
    Search Parameters for Substance
  }
  TSearchParamsSubstance = (
    spSubstance__id, {@enum.value spSubstance__id The logical resource id associated with the resource (must be supported by all servers) }
    spSubstance_Name, {@enum.value spSubstance_Name The name of the substance }
    spSubstance_Type); {@enum.value spSubstance_Type The type of the substance }

  {@Enum TSearchParamsSupply
    Search Parameters for Supply
  }
  TSearchParamsSupply = (
    spSupply__id, {@enum.value spSupply__id The logical resource id associated with the resource (must be supported by all servers) }
    spSupply_Dispenseid, {@enum.value spSupply_Dispenseid External identifier }
    spSupply_Dispensestatus, {@enum.value spSupply_Dispensestatus Active/Completed/Aborted }
    spSupply_Identifier, {@enum.value spSupply_Identifier Unique identifier }
    spSupply_Name, {@enum.value spSupply_Name The kind of supply (central, non-stock, etc) }
    spSupply_Patient, {@enum.value spSupply_Patient Patient }
    spSupply_Status, {@enum.value spSupply_Status Dispensed|Received|Requested }
    spSupply_Supplier); {@enum.value spSupply_Supplier Dispenser }

  {@Enum TSearchParamsValueSet
    Search Parameters for ValueSet
  }
  TSearchParamsValueSet = (
    spValueSet__id, {@enum.value spValueSet__id The logical resource id associated with the resource (must be supported by all servers) }
    spValueSet_Code, {@enum.value spValueSet_Code a code defined in the value set }
    spValueSet_Description, {@enum.value spValueSet_Description Human language description of the value set }
    spValueSet_Identifier, {@enum.value spValueSet_Identifier the identifier of the value set }
    spValueSet_Name, {@enum.value spValueSet_Name a portion of the name of the value set }
    spValueSet_Reference, {@enum.value spValueSet_Reference a code system included or excluded in the value set or an imported value set }
    spValueSet_Status, {@enum.value spValueSet_Status the status of the value set }
    spValueSet_System, {@enum.value spValueSet_System the system for any codes defined by this value set }
    spValueSet_Version); {@enum.value spValueSet_Version the version identifier of the value set }

Type
  TFhirResource = class;
  TFhirResourceList = class;
  TFhirAdverseReaction = class;
  TFhirAlert = class;
  TFhirAllergyIntolerance = class;
  TFhirCarePlan = class;
  TFhirCondition = class;
  TFhirConformance = class;
  TFhirCoverage = class;
  TFhirDevice = class;
  TFhirDeviceCapabilities = class;
  TFhirDeviceLog = class;
  TFhirDeviceObservation = class;
  TFhirDiagnosticOrder = class;
  TFhirDiagnosticReport = class;
  TFhirDocument = class;
  TFhirDocumentReference = class;
  TFhirEncounter = class;
  TFhirFamilyHistory = class;
  TFhirGroup = class;
  TFhirImagingStudy = class;
  TFhirImmunization = class;
  TFhirImmunizationProfile = class;
  TFhirList = class;
  TFhirLocation = class;
  TFhirMedia = class;
  TFhirMedication = class;
  TFhirMedicationAdministration = class;
  TFhirMedicationDispense = class;
  TFhirMedicationPrescription = class;
  TFhirMedicationStatement = class;
  TFhirMessage = class;
  TFhirObservation = class;
  TFhirOperationOutcome = class;
  TFhirOrder = class;
  TFhirOrderResponse = class;
  TFhirOrganization = class;
  TFhirOther = class;
  TFhirPatient = class;
  TFhirPractitioner = class;
  TFhirProcedure = class;
  TFhirProfile = class;
  TFhirProvenance = class;
  TFhirQuery = class;
  TFhirQuestionnaire = class;
  TFhirRelatedPerson = class;
  TFhirSecurityEvent = class;
  TFhirSpecimen = class;
  TFhirSubstance = class;
  TFhirSupply = class;
  TFhirValueSet = class;

  {@Class TFhirResource : TFhirElement
    Base Resource Definition - extensions, narrative, contained resources
  }
  {!.Net HL7Connect.Fhir.Resource}
  TFhirResource = {abstract} class (TFhirElement)
  private
    FText : TFhirNarrative;
    FLanguage : TFhirCode;
    FFormat : TFHIRFormat;
    FContainedList : TFhirResourceList;
    procedure SetText(value : TFhirNarrative);
    procedure SetLanguage(value : TFhirCode);
  protected
    function GetResourceType : TFhirResourceType; virtual; abstract;
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
  public
    constructor Create; override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirResource; overload;
    function Clone : TFhirResource; overload;
    {!script show}
  published
    Property ResourceType : TFhirResourceType read GetResourceType;

    {@member language
      The base language of the resource
    }
    property language : TFhirCode read FLanguage write SetLanguage;
    {@member text
      Text summary of resource content, for human interpretation
    }
    property text : TFhirNarrative read FText write SetText;
    {@member containedList
      Text summary of resource content, for human interpretation
    }
    property containedList : TFhirResourceList read FContainedList;
    {@member _source_format
      Whether the resource was first represented in XML or JSON
    }
    property _source_format : TFHIRFormat read FFormat write FFormat;
  end;
  
  TFhirResourceClass = class of TFhirResource;
  
  
  {@Class TFhirBinary : TFhirResource
    Special Binary Resource
  }
  {!.Net HL7Connect.Fhir.Binary}
  TFhirBinary = class (TFhirResource)
  private
    FContent : TAdvBuffer;
    FContentType : string;
  protected
    function GetResourceType : TFhirResourceType; override;
  public
    Constructor create; Overload; Override;
    Destructor Destroy; Override;
  published
    Property Content : TAdvBuffer read FContent;
    Property ContentType : string read FContentType write FContentType;
  end;
  


  {@Class TFhirResourceList
    A list of FhirResource
  }
  {!.Net HL7Connect.Fhir.ResourceList}
  TFhirResourceList = class (TFHIRObjectList)
  private
    function GetItemN(index : Integer) : TFhirResource;
    procedure SetItemN(index : Integer; value : TFhirResource);
  public
    {!script hide}
    function Link : TFhirResourceList; Overload;
    function Clone : TFhirResourceList; Overload;
    {!script show}
    

    
    {@member AddItem
      Add an already existing FhirResource to the end of the list.
    }
    procedure AddItem(value : TFhirResource);
    
    {@member IndexOf
      See if an item is already in the list. returns -1 if not in the list
    }
    
    {@member IndexOf
      See if an item is already in the list. returns -1 if not in the list
    }
    function IndexOf(value : TFhirResource) : Integer;
    

    {@member InsertItem
       Insert an existing FhirResource before the designated index (0 = first item)
    }
    procedure InsertItem(index : Integer; value : TFhirResource);
    
    {@member Item
       Get the iIndexth FhirResource. (0 = first item)
    }
    
    {@member Item
       Get the iIndexth FhirResource. (0 = first item)
    }
    procedure SetItemByIndex(index : Integer; value : TFhirResource);
    
    {@member Count
      The number of items in the collection
    }
    function Item(index : Integer) : TFhirResource;
    
    {@member Count
      The number of items in the collection
    }
    function Count : Integer; Overload;
    
    {@member remove
      Remove the indexth item. The first item is index 0.
    }
    procedure Remove(index : Integer);
    {@member ClearItems
      Remove All Items from the list
    }
    procedure ClearItems;
    
    Property FhirResources[index : Integer] : TFhirResource read GetItemN write SetItemN; default;
  End;


  {@Class TFhirAdverseReaction : TFhirResource
    Specific reactions to a substance.
  }
  {!.Net HL7Connect.Fhir.AdverseReaction}
  TFhirAdverseReaction = class (TFhirResource)
  private
    FReactionDate : TFhirDateTime;
    FSubject : TFhirResourceReference{TFhirPatient};
    FDidNotOccurFlag : TFhirBoolean;
    FRecorder : TFhirResourceReference{Resource};
    FsymptomList : TFhirAdverseReactionSymptomList;
    FexposureList : TFhirAdverseReactionExposureList;
    Procedure SetReactionDate(value : TFhirDateTime);
    Function GetReactionDateST : TDateAndTime;
    Procedure SetReactionDateST(value : TDateAndTime);
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
    Procedure SetDidNotOccurFlag(value : TFhirBoolean);
    Function GetDidNotOccurFlagST : String;
    Procedure SetDidNotOccurFlagST(value : String);
    Procedure SetRecorder(value : TFhirResourceReference{Resource});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirAdverseReaction; overload;
    function Clone : TFhirAdverseReaction; overload;
    {!script show}
  published
    {@member reactionDate
      When the reaction occurred.
    }
    property reactionDate : TFhirDateTime read FReactionDate write SetReactionDate;
    {@member reactionDateST
      Typed access to When the reaction occurred.
    }
    property reactionDateST : TDateAndTime read GetReactionDateST write SetReactionDateST;

    {@member subject
      The subject of the adverse reaction.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member didNotOccurFlag
      To say that a reaction to substance did not occur.
    }
    property didNotOccurFlag : TFhirBoolean read FDidNotOccurFlag write SetDidNotOccurFlag;
    {@member didNotOccurFlagST
      Typed access to To say that a reaction to substance did not occur.
    }
    property didNotOccurFlagST : String read GetDidNotOccurFlagST write SetDidNotOccurFlagST;

    {@member recorder
      Who recorded the reaction.
    }
    property recorder : TFhirResourceReference{Resource} read FRecorder write SetRecorder;

    {@member symptomList
      The signs and symptoms that were observed as part of the reaction.
    }
    property symptomList : TFhirAdverseReactionSymptomList read FSymptomList;

    {@member exposureList
      An exposure to a substance that preceded a reaction occurrence.
    }
    property exposureList : TFhirAdverseReactionExposureList read FExposureList;

  end;


  {@Class TFhirAlert : TFhirResource
    Prospective warnings of potential issues when providing care to the patient.
  }
  {!.Net HL7Connect.Fhir.Alert}
  TFhirAlert = class (TFhirResource)
  private
    FCategory : TFhirCodeableConcept;
    FStatus : TFhirEnum;
    FSubject : TFhirResourceReference{TFhirPatient};
    FAuthor : TFhirResourceReference{Resource};
    FNote : TFhirString;
    Procedure SetCategory(value : TFhirCodeableConcept);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirAlertStatus;
    Procedure SetStatusST(value : TFhirAlertStatus);
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
    Procedure SetAuthor(value : TFhirResourceReference{Resource});
    Procedure SetNote(value : TFhirString);
    Function GetNoteST : String;
    Procedure SetNoteST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirAlert; overload;
    function Clone : TFhirAlert; overload;
    {!script show}
  published
    {@member category
      Allows an alert to be divided into different categories like clinical, administrative etc.
    }
    property category : TFhirCodeableConcept read FCategory write SetCategory;

    {@member status
      Supports basic workflow.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to Supports basic workflow.
    }
    property statusST : TFhirAlertStatus read GetStatusST write SetStatusST;

    {@member subject
      The person who this alert concerns.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member author
      The person or device that created the alert.
    }
    property author : TFhirResourceReference{Resource} read FAuthor write SetAuthor;

    {@member note
      The textual component of the alert to display to the user.
    }
    property note : TFhirString read FNote write SetNote;
    {@member noteST
      Typed access to The textual component of the alert to display to the user.
    }
    property noteST : String read GetNoteST write SetNoteST;

  end;


  {@Class TFhirAllergyIntolerance : TFhirResource
    Allergy/Intolerance.
  }
  {!.Net HL7Connect.Fhir.AllergyIntolerance}
  TFhirAllergyIntolerance = class (TFhirResource)
  private
    FIdentifier : TFhirIdentifier;
    FCriticality : TFhirEnum;
    FSensitivityType : TFhirEnum;
    FRecordedDate : TFhirDateTime;
    FStatus : TFhirEnum;
    FSubject : TFhirResourceReference{TFhirPatient};
    FRecorder : TFhirResourceReference{Resource};
    FSubstance : TFhirResourceReference{TFhirSubstance};
    FreactionList : TFhirResourceReferenceList{TFhirAdverseReaction};
    FsensitivityTestList : TFhirResourceReferenceList{TFhirObservation};
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetCriticality(value : TFhirEnum);
    Function GetCriticalityST : TFhirCriticality;
    Procedure SetCriticalityST(value : TFhirCriticality);
    Procedure SetSensitivityType(value : TFhirEnum);
    Function GetSensitivityTypeST : TFhirSensitivitytype;
    Procedure SetSensitivityTypeST(value : TFhirSensitivitytype);
    Procedure SetRecordedDate(value : TFhirDateTime);
    Function GetRecordedDateST : TDateAndTime;
    Procedure SetRecordedDateST(value : TDateAndTime);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirSensitivitystatus;
    Procedure SetStatusST(value : TFhirSensitivitystatus);
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
    Procedure SetRecorder(value : TFhirResourceReference{Resource});
    Procedure SetSubstance(value : TFhirResourceReference{TFhirSubstance});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirAllergyIntolerance; overload;
    function Clone : TFhirAllergyIntolerance; overload;
    {!script show}
  published
    {@member identifier
      An external identifier for the sensitivity.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member criticality
      Criticality of the sensitivity.
    }
    property criticality : TFhirEnum read FCriticality write SetCriticality;
    {@member criticalityST
      Typed access to Criticality of the sensitivity.
    }
    property criticalityST : TFhirCriticality read GetCriticalityST write SetCriticalityST;

    {@member sensitivityType
      Type of the sensitivity.
    }
    property sensitivityType : TFhirEnum read FSensitivityType write SetSensitivityType;
    {@member sensitivityTypeST
      Typed access to Type of the sensitivity.
    }
    property sensitivityTypeST : TFhirSensitivitytype read GetSensitivityTypeST write SetSensitivityTypeST;

    {@member recordedDate
      Date when the sensitivity was recorded.
    }
    property recordedDate : TFhirDateTime read FRecordedDate write SetRecordedDate;
    {@member recordedDateST
      Typed access to Date when the sensitivity was recorded.
    }
    property recordedDateST : TDateAndTime read GetRecordedDateST write SetRecordedDateST;

    {@member status
      Suspected, Confirmed, Refuted, Resolved.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to Suspected, Confirmed, Refuted, Resolved.
    }
    property statusST : TFhirSensitivitystatus read GetStatusST write SetStatusST;

    {@member subject
      Who the sensitivity is for.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member recorder
      Who recorded the sensitivity.
    }
    property recorder : TFhirResourceReference{Resource} read FRecorder write SetRecorder;

    {@member substance
      The substance that causes the sensitivity.
    }
    property substance : TFhirResourceReference{TFhirSubstance} read FSubstance write SetSubstance;

    {@member reactionList
      Reactions associated with the sensitivity.
    }
    property reactionList : TFhirResourceReferenceList{TFhirAdverseReaction} read FReactionList;

    {@member sensitivityTestList
      Observations that confirm or refute the sensitivity.
    }
    property sensitivityTestList : TFhirResourceReferenceList{TFhirObservation} read FSensitivityTestList;

  end;


  {@Class TFhirCarePlan : TFhirResource
    Describes the intention of how one or more practitioners intend to deliver care for a particular patient for a period of time, possibly limited to care for a specific condition or set of conditions.
  }
  {!.Net HL7Connect.Fhir.CarePlan}
  TFhirCarePlan = class (TFhirResource)
  private
    FIdentifier : TFhirIdentifier;
    FPatient : TFhirResourceReference{TFhirPatient};
    FStatus : TFhirEnum;
    FPeriod : TFhirPeriod;
    FModified : TFhirDateTime;
    FconcernList : TFhirResourceReferenceList{TFhirCondition};
    FparticipantList : TFhirCarePlanParticipantList;
    FgoalList : TFhirCarePlanGoalList;
    FactivityList : TFhirCarePlanActivityList;
    FNotes : TFhirString;
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetPatient(value : TFhirResourceReference{TFhirPatient});
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirCarePlanStatus;
    Procedure SetStatusST(value : TFhirCarePlanStatus);
    Procedure SetPeriod(value : TFhirPeriod);
    Procedure SetModified(value : TFhirDateTime);
    Function GetModifiedST : TDateAndTime;
    Procedure SetModifiedST(value : TDateAndTime);
    Procedure SetNotes(value : TFhirString);
    Function GetNotesST : String;
    Procedure SetNotesST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirCarePlan; overload;
    function Clone : TFhirCarePlan; overload;
    {!script show}
  published
    {@member identifier
      Unique identifier by which the care plan is known in different business contexts.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member patient
      Identifies the patient/subject whose intended care is described by the plan.
    }
    property patient : TFhirResourceReference{TFhirPatient} read FPatient write SetPatient;

    {@member status
      Indicates whether the plan is currently being acted upon, represents future intentions or is now just historical record.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to Indicates whether the plan is currently being acted upon, represents future intentions or is now just historical record.
    }
    property statusST : TFhirCarePlanStatus read GetStatusST write SetStatusST;

    {@member period
      Indicates when the plan did (or is intended to) come into effect and end.
    }
    property period : TFhirPeriod read FPeriod write SetPeriod;

    {@member modified
      Identifies the most recent date on which the plan has been revised.
    }
    property modified : TFhirDateTime read FModified write SetModified;
    {@member modifiedST
      Typed access to Identifies the most recent date on which the plan has been revised.
    }
    property modifiedST : TDateAndTime read GetModifiedST write SetModifiedST;

    {@member concernList
      Identifies the conditions/problems/concerns/diagnoses/etc. whose management and/or mitigation are handled by this plan.
    }
    property concernList : TFhirResourceReferenceList{TFhirCondition} read FConcernList;

    {@member participantList
      Identifies all people and organizations who are expected to be involved in the care envisioned by this plan.
    }
    property participantList : TFhirCarePlanParticipantList read FParticipantList;

    {@member goalList
      Describes the intended objective(s) of carrying out the Care Plan.
    }
    property goalList : TFhirCarePlanGoalList read FGoalList;

    {@member activityList
      Identifies a planned action to occur as part of the plan.  For example, a medication to be used, lab tests to perform, self-monitoring, education, etc.
    }
    property activityList : TFhirCarePlanActivityList read FActivityList;

    {@member notes
      General notes about the care plan not covered elsewhere.
    }
    property notes : TFhirString read FNotes write SetNotes;
    {@member notesST
      Typed access to General notes about the care plan not covered elsewhere.
    }
    property notesST : String read GetNotesST write SetNotesST;

  end;


  {@Class TFhirCondition : TFhirResource
    Use to record detailed information about conditions, problems or diagnoses recognized by a clinician. There are many uses including: recording a Diagnosis during an Encounter; populating a problem List or a Summary Statement, such as a Discharge Summary.
  }
  {!.Net HL7Connect.Fhir.Condition}
  TFhirCondition = class (TFhirResource)
  private
    FSubject : TFhirResourceReference{TFhirPatient};
    FEncounter : TFhirResourceReference{TFhirEncounter};
    FAsserter : TFhirResourceReference{Resource};
    FDateAsserted : TFhirDate;
    FCode : TFhirCodeableConcept;
    FCategory : TFhirCodeableConcept;
    FStatus : TFhirEnum;
    FCertainty : TFhirCodeableConcept;
    FSeverity : TFhirCodeableConcept;
    FOnset : TFhirType;
    FAbatement : TFhirType;
    FStage : TFhirConditionStage;
    FevidenceList : TFhirConditionEvidenceList;
    FlocationList : TFhirConditionLocationList;
    FrelatedItemList : TFhirConditionRelatedItemList;
    FNotes : TFhirString;
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
    Procedure SetEncounter(value : TFhirResourceReference{TFhirEncounter});
    Procedure SetAsserter(value : TFhirResourceReference{Resource});
    Procedure SetDateAsserted(value : TFhirDate);
    Function GetDateAssertedST : TDateAndTime;
    Procedure SetDateAssertedST(value : TDateAndTime);
    Procedure SetCode(value : TFhirCodeableConcept);
    Procedure SetCategory(value : TFhirCodeableConcept);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirConditionStatus;
    Procedure SetStatusST(value : TFhirConditionStatus);
    Procedure SetCertainty(value : TFhirCodeableConcept);
    Procedure SetSeverity(value : TFhirCodeableConcept);
    Procedure SetOnset(value : TFhirType);
    Procedure SetAbatement(value : TFhirType);
    Procedure SetStage(value : TFhirConditionStage);
    Procedure SetNotes(value : TFhirString);
    Function GetNotesST : String;
    Procedure SetNotesST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirCondition; overload;
    function Clone : TFhirCondition; overload;
    {!script show}
  published
    {@member subject
      Subject of this condition.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member encounter
      Encounter during which the condition was first asserted.
    }
    property encounter : TFhirResourceReference{TFhirEncounter} read FEncounter write SetEncounter;

    {@member asserter
      Person who takes responsibility for asserting the existence of the condition as part of the electronic record.
    }
    property asserter : TFhirResourceReference{Resource} read FAsserter write SetAsserter;

    {@member dateAsserted
      Estimated or actual date the condition/problem/diagnosis was first detected/suspected.
    }
    property dateAsserted : TFhirDate read FDateAsserted write SetDateAsserted;
    {@member dateAssertedST
      Typed access to Estimated or actual date the condition/problem/diagnosis was first detected/suspected.
    }
    property dateAssertedST : TDateAndTime read GetDateAssertedST write SetDateAssertedST;

    {@member code
      Identification of the condition, problem or diagnosis.
    }
    property code : TFhirCodeableConcept read FCode write SetCode;

    {@member category
      A category assigned to the condition. E.g. finding | Condition | diagnosis | concern | condition.
    }
    property category : TFhirCodeableConcept read FCategory write SetCategory;

    {@member status
      The clinical status of the condition.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to The clinical status of the condition.
    }
    property statusST : TFhirConditionStatus read GetStatusST write SetStatusST;

    {@member certainty
      The degree of confidence that this condition is correct.
    }
    property certainty : TFhirCodeableConcept read FCertainty write SetCertainty;

    {@member severity
      A subjective assessment of the severity of the condition as evaluated by the clinician.
    }
    property severity : TFhirCodeableConcept read FSeverity write SetSeverity;

    {@member onset
      Estimated or actual date the condition began, in the opinion of the clinician.
    }
    property onset : TFhirType read FOnset write SetOnset;

    {@member abatement
      The date or estimated date that the condition resolved or went into remission. This is called "abatement" because of the many overloaded connotations associated with "remission" or "resolution" - Conditions are never really resolved, but they can abate.
    }
    property abatement : TFhirType read FAbatement write SetAbatement;

    {@member stage
      Clinical stage or grade of a condition. May include formal severity assessments.
    }
    property stage : TFhirConditionStage read FStage write SetStage;

    {@member evidenceList
      Supporting Evidence / manifestations that are the basis on which this condition is suspected or confirmed.
    }
    property evidenceList : TFhirConditionEvidenceList read FEvidenceList;

    {@member locationList
      The anatomical location where this condition manifests itself.
    }
    property locationList : TFhirConditionLocationList read FLocationList;

    {@member relatedItemList
      Further conditions, problems, diagnoses, procedures or events that are related in some way to this condition, or the substance that caused/triggered this Condition.
    }
    property relatedItemList : TFhirConditionRelatedItemList read FRelatedItemList;

    {@member notes
      Additional information about the Condition. This is a general notes/comments entry  for description of the Condition, its diagnosis and prognosis.
    }
    property notes : TFhirString read FNotes write SetNotes;
    {@member notesST
      Typed access to Additional information about the Condition. This is a general notes/comments entry  for description of the Condition, its diagnosis and prognosis.
    }
    property notesST : String read GetNotesST write SetNotesST;

  end;


  {@Class TFhirConformance : TFhirResource
    A conformance statement about how an application or implementation supports FHIR or the set of requirements for a desired implementation.
  }
  {!.Net HL7Connect.Fhir.Conformance}
  TFhirConformance = class (TFhirResource)
  private
    FIdentifier : TFhirString;
    FVersion : TFhirString;
    FName : TFhirString;
    FPublisher : TFhirString;
    FtelecomList : TFhirContactList;
    FDescription : TFhirString;
    FStatus : TFhirEnum;
    FExperimental : TFhirBoolean;
    FDate : TFhirDateTime;
    FSoftware : TFhirConformanceSoftware;
    FImplementation_ : TFhirConformanceImplementation;
    FFhirVersion : TFhirId;
    FAcceptUnknown : TFhirBoolean;
    FformatList : TFhirCodeList;
    FrestList : TFhirConformanceRestList;
    FmessagingList : TFhirConformanceMessagingList;
    FdocumentList : TFhirConformanceDocumentList;
    Procedure SetIdentifier(value : TFhirString);
    Function GetIdentifierST : String;
    Procedure SetIdentifierST(value : String);
    Procedure SetVersion(value : TFhirString);
    Function GetVersionST : String;
    Procedure SetVersionST(value : String);
    Procedure SetName(value : TFhirString);
    Function GetNameST : String;
    Procedure SetNameST(value : String);
    Procedure SetPublisher(value : TFhirString);
    Function GetPublisherST : String;
    Procedure SetPublisherST(value : String);
    Procedure SetDescription(value : TFhirString);
    Function GetDescriptionST : String;
    Procedure SetDescriptionST(value : String);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirConformanceStatementStatus;
    Procedure SetStatusST(value : TFhirConformanceStatementStatus);
    Procedure SetExperimental(value : TFhirBoolean);
    Function GetExperimentalST : String;
    Procedure SetExperimentalST(value : String);
    Procedure SetDate(value : TFhirDateTime);
    Function GetDateST : TDateAndTime;
    Procedure SetDateST(value : TDateAndTime);
    Procedure SetSoftware(value : TFhirConformanceSoftware);
    Procedure SetImplementation_(value : TFhirConformanceImplementation);
    Procedure SetFhirVersion(value : TFhirId);
    Function GetFhirVersionST : String;
    Procedure SetFhirVersionST(value : String);
    Procedure SetAcceptUnknown(value : TFhirBoolean);
    Function GetAcceptUnknownST : String;
    Procedure SetAcceptUnknownST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirConformance; overload;
    function Clone : TFhirConformance; overload;
    {!script show}
  published
    {@member identifier
      The identifier that is used to identify this conformance statement when it is referenced in a specification, model, design or an instance (should be globally unique OID, UUID, or URI).
    }
    property identifier : TFhirString read FIdentifier write SetIdentifier;
    {@member identifierST
      Typed access to The identifier that is used to identify this conformance statement when it is referenced in a specification, model, design or an instance (should be globally unique OID, UUID, or URI).
    }
    property identifierST : String read GetIdentifierST write SetIdentifierST;

    {@member version
      The identifier that is used to identify this version of the conformance statement when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the profile author manually and the value should be a timestamp.
    }
    property version : TFhirString read FVersion write SetVersion;
    {@member versionST
      Typed access to The identifier that is used to identify this version of the conformance statement when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the profile author manually and the value should be a timestamp.
    }
    property versionST : String read GetVersionST write SetVersionST;

    {@member name
      A free text natural language name identifying the conformance statement.
    }
    property name : TFhirString read FName write SetName;
    {@member nameST
      Typed access to A free text natural language name identifying the conformance statement.
    }
    property nameST : String read GetNameST write SetNameST;

    {@member publisher
      Name of Organization.
    }
    property publisher : TFhirString read FPublisher write SetPublisher;
    {@member publisherST
      Typed access to Name of Organization.
    }
    property publisherST : String read GetPublisherST write SetPublisherST;

    {@member telecomList
      Contacts for Organization relevant to this conformance statement.  May be website, email, phone numbers, etc.
    }
    property telecomList : TFhirContactList read FTelecomList;

    {@member description
      A free text natural language description of the conformance statement and its use. Typically, this is used when the profile describes a desired rather than an actual solution, for example as a formal expression of requirements as part of an RFP.
    }
    property description : TFhirString read FDescription write SetDescription;
    {@member descriptionST
      Typed access to A free text natural language description of the conformance statement and its use. Typically, this is used when the profile describes a desired rather than an actual solution, for example as a formal expression of requirements as part of an RFP.
    }
    property descriptionST : String read GetDescriptionST write SetDescriptionST;

    {@member status
      The status of this conformance statement.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to The status of this conformance statement.
    }
    property statusST : TFhirConformanceStatementStatus read GetStatusST write SetStatusST;

    {@member experimental
      This conformance statement was authored for testing purposes (or education/evaluation/marketing), and is not intended to be used for genuine usage.
    }
    property experimental : TFhirBoolean read FExperimental write SetExperimental;
    {@member experimentalST
      Typed access to This conformance statement was authored for testing purposes (or education/evaluation/marketing), and is not intended to be used for genuine usage.
    }
    property experimentalST : String read GetExperimentalST write SetExperimentalST;

    {@member date
      Date that the conformance statement is published.
    }
    property date : TFhirDateTime read FDate write SetDate;
    {@member dateST
      Typed access to Date that the conformance statement is published.
    }
    property dateST : TDateAndTime read GetDateST write SetDateST;

    {@member software
      Describes the software that is covered by this conformance statement.  Used when the profile describes the capabilities of a particular software version, independent of an installation.
    }
    property software : TFhirConformanceSoftware read FSoftware write SetSoftware;

    {@member implementation_
      Used when the statement describes the capabilities of a specific implementation instance - i.e. a particular installation, rather than the capabilities of a software program.
    }
    property implementation_ : TFhirConformanceImplementation read FImplementation_ write SetImplementation_;

    {@member fhirVersion
      The version of the FHIR specification on which this conformance statement is based.
    }
    property fhirVersion : TFhirId read FFhirVersion write SetFhirVersion;
    {@member fhirVersionST
      Typed access to The version of the FHIR specification on which this conformance statement is based.
    }
    property fhirVersionST : String read GetFhirVersionST write SetFhirVersionST;

    {@member acceptUnknown
      Whether the application accepts unknown non-"must understand" elements as part of a resource. This does not include extensions, but genuine new additions to a resource.
    }
    property acceptUnknown : TFhirBoolean read FAcceptUnknown write SetAcceptUnknown;
    {@member acceptUnknownST
      Typed access to Whether the application accepts unknown non-"must understand" elements as part of a resource. This does not include extensions, but genuine new additions to a resource.
    }
    property acceptUnknownST : String read GetAcceptUnknownST write SetAcceptUnknownST;

    {@member formatList
      The formats supported by this implementation.
    }
    property formatList : TFhirCodeList read FFormatList;

    {@member restList
      Defines the restful capabilities of the solution, if any.
    }
    property restList : TFhirConformanceRestList read FRestList;

    {@member messagingList
      Describes the messaging capabilities of the solution.
    }
    property messagingList : TFhirConformanceMessagingList read FMessagingList;

    {@member documentList
      A document definition.
    }
    property documentList : TFhirConformanceDocumentList read FDocumentList;

  end;


  {@Class TFhirCoverage : TFhirResource
    Financial instrument by which payment information for health care.
  }
  {!.Net HL7Connect.Fhir.Coverage}
  TFhirCoverage = class (TFhirResource)
  private
    FIssuer : TFhirResourceReference{TFhirOrganization};
    FPeriod : TFhirPeriod;
    FType_ : TFhirCoding;
    FIdentifier : TFhirIdentifier;
    FGroup : TFhirIdentifier;
    FPlan : TFhirIdentifier;
    FSubplan : TFhirIdentifier;
    FDependent : TFhirInteger;
    FSequence : TFhirInteger;
    FSubscriber : TFhirCoverageSubscriber;
    Procedure SetIssuer(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetPeriod(value : TFhirPeriod);
    Procedure SetType_(value : TFhirCoding);
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetGroup(value : TFhirIdentifier);
    Procedure SetPlan(value : TFhirIdentifier);
    Procedure SetSubplan(value : TFhirIdentifier);
    Procedure SetDependent(value : TFhirInteger);
    Function GetDependentST : String;
    Procedure SetDependentST(value : String);
    Procedure SetSequence(value : TFhirInteger);
    Function GetSequenceST : String;
    Procedure SetSequenceST(value : String);
    Procedure SetSubscriber(value : TFhirCoverageSubscriber);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirCoverage; overload;
    function Clone : TFhirCoverage; overload;
    {!script show}
  published
    {@member issuer
      The program or plan underwriter or payor.
    }
    property issuer : TFhirResourceReference{TFhirOrganization} read FIssuer write SetIssuer;

    {@member period
      Time period during which the coverage is in force. A missing start date indicates the start date isn't known, a missing end date means the coverage is continuing to be in force.
    }
    property period : TFhirPeriod read FPeriod write SetPeriod;

    {@member type_
      The type of coverage: social program, medical plan, accident coverage (workers compensation, auto), group health.
    }
    property type_ : TFhirCoding read FType_ write SetType_;

    {@member identifier
      The main (and possibly only) identifier for the coverage - often referred to as a Subscriber Id, Certificate number or Personal Health Number or Case ID.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member group
      Todo.
    }
    property group : TFhirIdentifier read FGroup write SetGroup;

    {@member plan
      Identifies a style or collective of coverage issues by the underwriter, for example may be used to identify a class of coverage or employer group. May also be referred to as a Policy or Group ID.
    }
    property plan : TFhirIdentifier read FPlan write SetPlan;

    {@member subplan
      Identifies a sub-style or sub-collective of coverage issues by the underwriter, for example may be used to identify a specific employer group within a class of employers. May be referred to as a Section or Division ID.
    }
    property subplan : TFhirIdentifier read FSubplan write SetSubplan;

    {@member dependent
      A unique identifier for a dependent under the coverage.
    }
    property dependent : TFhirInteger read FDependent write SetDependent;
    {@member dependentST
      Typed access to A unique identifier for a dependent under the coverage.
    }
    property dependentST : String read GetDependentST write SetDependentST;

    {@member sequence
      An optional counter for a particular instance of the identified coverage which increments upon each renewal.
    }
    property sequence : TFhirInteger read FSequence write SetSequence;
    {@member sequenceST
      Typed access to An optional counter for a particular instance of the identified coverage which increments upon each renewal.
    }
    property sequenceST : String read GetSequenceST write SetSequenceST;

    {@member subscriber
      Planholder information.
    }
    property subscriber : TFhirCoverageSubscriber read FSubscriber write SetSubscriber;

  end;


  {@Class TFhirDevice : TFhirResource
    This resource identifies an instance of a manufactured thing that is used in the provision of healthcare without being substantially changed through that activity. The device may be a machine, an insert, a computer, an application, etc. This includes durable (reusable) medical equipment as well as disposable equipment used for diagnostic, treatment, and research for healthcare and public health.
  }
  {!.Net HL7Connect.Fhir.Device}
  TFhirDevice = class (TFhirResource)
  private
    FType_ : TFhirCodeableConcept;
    FManufacturer : TFhirString;
    FModel : TFhirString;
    FVersion : TFhirString;
    FExpiry : TFhirDate;
    FIdentity : TFhirDeviceIdentity;
    FOwner : TFhirResourceReference{TFhirOrganization};
    FassignedIdList : TFhirIdentifierList;
    FLocation : TFhirResourceReference{TFhirLocation};
    FPatient : TFhirResourceReference{TFhirPatient};
    FcontactList : TFhirContactList;
    FUrl : TFhirUri;
    Procedure SetType_(value : TFhirCodeableConcept);
    Procedure SetManufacturer(value : TFhirString);
    Function GetManufacturerST : String;
    Procedure SetManufacturerST(value : String);
    Procedure SetModel(value : TFhirString);
    Function GetModelST : String;
    Procedure SetModelST(value : String);
    Procedure SetVersion(value : TFhirString);
    Function GetVersionST : String;
    Procedure SetVersionST(value : String);
    Procedure SetExpiry(value : TFhirDate);
    Function GetExpiryST : TDateAndTime;
    Procedure SetExpiryST(value : TDateAndTime);
    Procedure SetIdentity(value : TFhirDeviceIdentity);
    Procedure SetOwner(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetLocation(value : TFhirResourceReference{TFhirLocation});
    Procedure SetPatient(value : TFhirResourceReference{TFhirPatient});
    Procedure SetUrl(value : TFhirUri);
    Function GetUrlST : String;
    Procedure SetUrlST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirDevice; overload;
    function Clone : TFhirDevice; overload;
    {!script show}
  published
    {@member type_
      Describes what kind of device that this.
    }
    property type_ : TFhirCodeableConcept read FType_ write SetType_;

    {@member manufacturer
      The name of the manufacturer.
    }
    property manufacturer : TFhirString read FManufacturer write SetManufacturer;
    {@member manufacturerST
      Typed access to The name of the manufacturer.
    }
    property manufacturerST : String read GetManufacturerST write SetManufacturerST;

    {@member model
      The "model" - an identifier assigned by the manufacturer to identify the product by its type. This number is shared by the all devices sold as the same type.
    }
    property model : TFhirString read FModel write SetModel;
    {@member modelST
      Typed access to The "model" - an identifier assigned by the manufacturer to identify the product by its type. This number is shared by the all devices sold as the same type.
    }
    property modelST : String read GetModelST write SetModelST;

    {@member version
      The version of the device, if the device has multiple releases under the same model, or if the device is software or carries firmware.
    }
    property version : TFhirString read FVersion write SetVersion;
    {@member versionST
      Typed access to The version of the device, if the device has multiple releases under the same model, or if the device is software or carries firmware.
    }
    property versionST : String read GetVersionST write SetVersionST;

    {@member expiry
      Date of expiry of this device (if applicable).
    }
    property expiry : TFhirDate read FExpiry write SetExpiry;
    {@member expiryST
      Typed access to Date of expiry of this device (if applicable).
    }
    property expiryST : TDateAndTime read GetExpiryST write SetExpiryST;

    {@member identity
      Universal Device Id fields.
    }
    property identity : TFhirDeviceIdentity read FIdentity write SetIdentity;

    {@member owner
      The organization that is responsible for the provision and ongoing maintenance of the device.
    }
    property owner : TFhirResourceReference{TFhirOrganization} read FOwner write SetOwner;

    {@member assignedIdList
      Identifiers assigned to this device by various organizations (unless other specific fields exist for them).
    }
    property assignedIdList : TFhirIdentifierList read FAssignedIdList;

    {@member location
      The resource may be found in a literal location (i.e. GPS coordinates), a logical place (i.e. "in/with the patient"), or a coded location.
    }
    property location : TFhirResourceReference{TFhirLocation} read FLocation write SetLocation;

    {@member patient
      If the resource is affixed to a person.
    }
    property patient : TFhirResourceReference{TFhirPatient} read FPatient write SetPatient;

    {@member contactList
      Contact details for an organization or a particular human that is responsible for the device.
    }
    property contactList : TFhirContactList read FContactList;

    {@member url
      A network address on which the device may be contacted directly.
    }
    property url : TFhirUri read FUrl write SetUrl;
    {@member urlST
      Typed access to A network address on which the device may be contacted directly.
    }
    property urlST : String read GetUrlST write SetUrlST;

  end;


  {@Class TFhirDeviceCapabilities : TFhirResource
    Describes the set of data produced by a device.
  }
  {!.Net HL7Connect.Fhir.DeviceCapabilities}
  TFhirDeviceCapabilities = class (TFhirResource)
  private
    FName : TFhirString;
    FType_ : TFhirCodeableConcept;
    FManufacturer : TFhirString;
    FIdentity : TFhirResourceReference{TFhirDevice};
    FvirtualDeviceList : TFhirDeviceCapabilitiesVirtualDeviceList;
    Procedure SetName(value : TFhirString);
    Function GetNameST : String;
    Procedure SetNameST(value : String);
    Procedure SetType_(value : TFhirCodeableConcept);
    Procedure SetManufacturer(value : TFhirString);
    Function GetManufacturerST : String;
    Procedure SetManufacturerST(value : String);
    Procedure SetIdentity(value : TFhirResourceReference{TFhirDevice});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirDeviceCapabilities; overload;
    function Clone : TFhirDeviceCapabilities; overload;
    {!script show}
  published
    {@member name
      The name of this device.
    }
    property name : TFhirString read FName write SetName;
    {@member nameST
      Typed access to The name of this device.
    }
    property nameST : String read GetNameST write SetNameST;

    {@member type_
      The kind of device - what kind of functionality it provides.
    }
    property type_ : TFhirCodeableConcept read FType_ write SetType_;

    {@member manufacturer
      The company that built this device.
    }
    property manufacturer : TFhirString read FManufacturer write SetManufacturer;
    {@member manufacturerST
      Typed access to The company that built this device.
    }
    property manufacturerST : String read GetManufacturerST write SetManufacturerST;

    {@member identity
      Identifies this particular device uniquely.
    }
    property identity : TFhirResourceReference{TFhirDevice} read FIdentity write SetIdentity;

    {@member virtualDeviceList
      A medical-related subsystem of a medical device.
    }
    property virtualDeviceList : TFhirDeviceCapabilitiesVirtualDeviceList read FVirtualDeviceList;

  end;


  {@Class TFhirDeviceLog : TFhirResource
    A set of raw data produced by a device.
  }
  {!.Net HL7Connect.Fhir.DeviceLog}
  TFhirDeviceLog = class (TFhirResource)
  private
    FInstant : TFhirInstant;
    FCapabilities : TFhirResourceReference{TFhirDeviceCapabilities};
    FSubject : TFhirResourceReference{Resource};
    FitemList : TFhirDeviceLogItemList;
    Procedure SetInstant(value : TFhirInstant);
    Function GetInstantST : TDateAndTime;
    Procedure SetInstantST(value : TDateAndTime);
    Procedure SetCapabilities(value : TFhirResourceReference{TFhirDeviceCapabilities});
    Procedure SetSubject(value : TFhirResourceReference{Resource});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirDeviceLog; overload;
    function Clone : TFhirDeviceLog; overload;
    {!script show}
  published
    {@member instant
      The point in time that the values are reported.
    }
    property instant : TFhirInstant read FInstant write SetInstant;
    {@member instantST
      Typed access to The point in time that the values are reported.
    }
    property instantST : TDateAndTime read GetInstantST write SetInstantST;

    {@member capabilities
      An explicit reference  to the capabilities.
    }
    property capabilities : TFhirResourceReference{TFhirDeviceCapabilities} read FCapabilities write SetCapabilities;

    {@member subject
      The subject of the measurement.
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member itemList
      An item of data that the device produces.
    }
    property itemList : TFhirDeviceLogItemList read FItemList;

  end;


  {@Class TFhirDeviceObservation : TFhirResource
    A set of observations produced by a device.
  }
  {!.Net HL7Connect.Fhir.DeviceObservation}
  TFhirDeviceObservation = class (TFhirResource)
  private
    FCode : TFhirCodeableConcept;
    FidentifierList : TFhirIdentifierList;
    FIssued : TFhirInstant;
    FSubject : TFhirResourceReference{Resource};
    FDevice : TFhirResourceReference{TFhirDevice};
    FmeasurementList : TFhirResourceReferenceList{TFhirObservation};
    Procedure SetCode(value : TFhirCodeableConcept);
    Procedure SetIssued(value : TFhirInstant);
    Function GetIssuedST : TDateAndTime;
    Procedure SetIssuedST(value : TDateAndTime);
    Procedure SetSubject(value : TFhirResourceReference{Resource});
    Procedure SetDevice(value : TFhirResourceReference{TFhirDevice});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirDeviceObservation; overload;
    function Clone : TFhirDeviceObservation; overload;
    {!script show}
  published
    {@member code
      A code that identifies what type of device observation this is.
    }
    property code : TFhirCodeableConcept read FCode write SetCode;

    {@member identifierList
      Identifiers assigned to this observation.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member issued
      Date the measurements were made.
    }
    property issued : TFhirInstant read FIssued write SetIssued;
    {@member issuedST
      Typed access to Date the measurements were made.
    }
    property issuedST : TDateAndTime read GetIssuedST write SetIssuedST;

    {@member subject
      The subject of the measurements. Usually, but not always, this is a patient. However devices are also used to make measurements on other things as well.
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member device
      Device that produced the results.
    }
    property device : TFhirResourceReference{TFhirDevice} read FDevice write SetDevice;

    {@member measurementList
      The actual measurements that the device produced.
    }
    property measurementList : TFhirResourceReferenceList{TFhirObservation} read FMeasurementList;

  end;


  {@Class TFhirDiagnosticOrder : TFhirResource
    A request for a diagnostic investigation service to be performed.
  }
  {!.Net HL7Connect.Fhir.DiagnosticOrder}
  TFhirDiagnosticOrder = class (TFhirResource)
  private
    FSubject : TFhirResourceReference{Resource};
    FOrderer : TFhirResourceReference{TFhirPractitioner};
    FidentifierList : TFhirIdentifierList;
    FEncounter : TFhirResourceReference{TFhirEncounter};
    FClinicalNotes : TFhirString;
    FspecimenList : TFhirResourceReferenceList{TFhirSpecimen};
    FStatus : TFhirEnum;
    FPriority : TFhirEnum;
    FeventList : TFhirDiagnosticOrderEventList;
    FitemList : TFhirDiagnosticOrderItemList;
    Procedure SetSubject(value : TFhirResourceReference{Resource});
    Procedure SetOrderer(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetEncounter(value : TFhirResourceReference{TFhirEncounter});
    Procedure SetClinicalNotes(value : TFhirString);
    Function GetClinicalNotesST : String;
    Procedure SetClinicalNotesST(value : String);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirDiagnosticOrderStatus;
    Procedure SetStatusST(value : TFhirDiagnosticOrderStatus);
    Procedure SetPriority(value : TFhirEnum);
    Function GetPriorityST : TFhirDiagnosticOrderPriority;
    Procedure SetPriorityST(value : TFhirDiagnosticOrderPriority);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirDiagnosticOrder; overload;
    function Clone : TFhirDiagnosticOrder; overload;
    {!script show}
  published
    {@member subject
      Who or what the investigation is to be performed on. This is usually a human patient, but diagnostic tests can also be requested on animals, groups of humans or animals, devices such as dialysis machines, or even locations (typically for environmental scans).
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member orderer
      The practitioner that holds legal responsibility for ordering the investigation.
    }
    property orderer : TFhirResourceReference{TFhirPractitioner} read FOrderer write SetOrderer;

    {@member identifierList
      Identifiers assigned to this order by the order or by the receiver.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member encounter
      An encounter that provides additional informaton about the healthcare context in which this request is made.
    }
    property encounter : TFhirResourceReference{TFhirEncounter} read FEncounter write SetEncounter;

    {@member clinicalNotes
      An explanation or justification for why this diagnostic investigation is being requested.
    }
    property clinicalNotes : TFhirString read FClinicalNotes write SetClinicalNotes;
    {@member clinicalNotesST
      Typed access to An explanation or justification for why this diagnostic investigation is being requested.
    }
    property clinicalNotesST : String read GetClinicalNotesST write SetClinicalNotesST;

    {@member specimenList
      One or more specimens that the diagnostic investigation is about.
    }
    property specimenList : TFhirResourceReferenceList{TFhirSpecimen} read FSpecimenList;

    {@member status
      The status of the order.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to The status of the order.
    }
    property statusST : TFhirDiagnosticOrderStatus read GetStatusST write SetStatusST;

    {@member priority
      The clinical priority associated with this order.
    }
    property priority : TFhirEnum read FPriority write SetPriority;
    {@member priorityST
      Typed access to The clinical priority associated with this order.
    }
    property priorityST : TFhirDiagnosticOrderPriority read GetPriorityST write SetPriorityST;

    {@member eventList
      A summary of the events of interest that have occurred as the request is processed.
    }
    property eventList : TFhirDiagnosticOrderEventList read FEventList;

    {@member itemList
      The specific diagnostic investigations that are requested as part of this request. Sometimes, there can only be one item per request, but in most contexts, more than one investigation can be requested.
    }
    property itemList : TFhirDiagnosticOrderItemList read FItemList;

  end;


  {@Class TFhirDiagnosticReport : TFhirResource
    The findings and interpretation of diagnostic  tests performed on patients and/or specimens. The report includes clinical context such as requesting and provider information, and some mix of atomic results, images, textual and coded interpretation, and formatted representation of diagnostic reports.
  }
  {!.Net HL7Connect.Fhir.DiagnosticReport}
  TFhirDiagnosticReport = class (TFhirResource)
  private
    FStatus : TFhirEnum;
    FIssued : TFhirDateTime;
    FSubject : TFhirResourceReference{Resource};
    FPerformer : TFhirResourceReference{TFhirOrganization};
    FReportId : TFhirIdentifier;
    FrequestDetailList : TFhirDiagnosticReportRequestDetailList;
    FServiceCategory : TFhirCodeableConcept;
    FDiagnosticTime : TFhirDateTime;
    FResults : TFhirDiagnosticReportResults;
    FimageList : TFhirResourceReferenceList{Resource};
    FConclusion : TFhirString;
    FcodedDiagnosisList : TFhirCodeableConceptList;
    FrepresentationList : TFhirAttachmentList;
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirObservationStatus;
    Procedure SetStatusST(value : TFhirObservationStatus);
    Procedure SetIssued(value : TFhirDateTime);
    Function GetIssuedST : TDateAndTime;
    Procedure SetIssuedST(value : TDateAndTime);
    Procedure SetSubject(value : TFhirResourceReference{Resource});
    Procedure SetPerformer(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetReportId(value : TFhirIdentifier);
    Procedure SetServiceCategory(value : TFhirCodeableConcept);
    Procedure SetDiagnosticTime(value : TFhirDateTime);
    Function GetDiagnosticTimeST : TDateAndTime;
    Procedure SetDiagnosticTimeST(value : TDateAndTime);
    Procedure SetResults(value : TFhirDiagnosticReportResults);
    Procedure SetConclusion(value : TFhirString);
    Function GetConclusionST : String;
    Procedure SetConclusionST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirDiagnosticReport; overload;
    function Clone : TFhirDiagnosticReport; overload;
    {!script show}
  published
    {@member status
      The status of the diagnostic report as a whole.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to The status of the diagnostic report as a whole.
    }
    property statusST : TFhirObservationStatus read GetStatusST write SetStatusST;

    {@member issued
      The date and/or time that this version of the report was released from the source diagnostic service.
    }
    property issued : TFhirDateTime read FIssued write SetIssued;
    {@member issuedST
      Typed access to The date and/or time that this version of the report was released from the source diagnostic service.
    }
    property issuedST : TDateAndTime read GetIssuedST write SetIssuedST;

    {@member subject
      The subject of the report. Usually, but not always, this is a patient. However diagnostic services also perform analyses on specimens collected from a variety of other sources.
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member performer
      The diagnostic service that is responsible for issuing the report.
    }
    property performer : TFhirResourceReference{TFhirOrganization} read FPerformer write SetPerformer;

    {@member reportId
      The local ID assigned to the report by the order filler, usually by the Information System of the diagnostic service provider.
    }
    property reportId : TFhirIdentifier read FReportId write SetReportId;

    {@member requestDetailList
      Details concerning a single pathology test requested.
    }
    property requestDetailList : TFhirDiagnosticReportRequestDetailList read FRequestDetailList;

    {@member serviceCategory
      The section of the diagnostic service that performs the examination e.g. biochemistry, haematology, MRI.
    }
    property serviceCategory : TFhirCodeableConcept read FServiceCategory write SetServiceCategory;

    {@member diagnosticTime
      The diagnostically relevant time for this report.
    }
    property diagnosticTime : TFhirDateTime read FDiagnosticTime write SetDiagnosticTime;
    {@member diagnosticTimeST
      Typed access to The diagnostically relevant time for this report.
    }
    property diagnosticTimeST : TDateAndTime read GetDiagnosticTimeST write SetDiagnosticTimeST;

    {@member results
      A group of results. Results may be grouped by specimen, or by some value in DiagnosticReport.resultGroup.name to describe what binds all the results together.
    }
    property results : TFhirDiagnosticReportResults read FResults write SetResults;

    {@member imageList
      A list of key images associated with this report. The images are generally created during the diagnostic process, and maybe directly of the patient, or of treated specimens (i.e. slides of interest).
    }
    property imageList : TFhirResourceReferenceList{Resource} read FImageList;

    {@member conclusion
      Concise and clinically contextualised narrative interpretation of the diagnostic report.
    }
    property conclusion : TFhirString read FConclusion write SetConclusion;
    {@member conclusionST
      Typed access to Concise and clinically contextualised narrative interpretation of the diagnostic report.
    }
    property conclusionST : String read GetConclusionST write SetConclusionST;

    {@member codedDiagnosisList
      Codes for the conclusion.
    }
    property codedDiagnosisList : TFhirCodeableConceptList read FCodedDiagnosisList;

    {@member representationList
      Rich text representation of the entire result as issued by the diagnostic service. Multiple formats are allowed but they must be semantically equivalent.
    }
    property representationList : TFhirAttachmentList read FRepresentationList;

  end;


  {@Class TFhirDocument : TFhirResource
    A documentation of healthcare-related information that is assembled together into a single statement of meaning that establishes its own context. A document is composed of a set of resources that include both human and computer readable portions. A human may attest to the accuracy of the human readable portion and may authenticate and/or sign the entire whole. A document may be kept as a set of logically linked resources, or they may be bundled together in an atom feed.
  }
  {!.Net HL7Connect.Fhir.Document}
  TFhirDocument = class (TFhirResource)
  private
    FIdentifier : TFhirIdentifier;
    FVersionIdentifier : TFhirIdentifier;
    FCreated : TFhirInstant;
    FType_ : TFhirCodeableConcept;
    FSubtype : TFhirCodeableConcept;
    FTitle : TFhirString;
    FStatus : TFhirEnum;
    FConfidentiality : TFhirCoding;
    FSubject : TFhirResourceReference{Resource};
    FauthorList : TFhirResourceReferenceList{Resource};
    FattesterList : TFhirDocumentAttesterList;
    FCustodian : TFhirResourceReference{TFhirOrganization};
    FEvent : TFhirDocumentEvent;
    FEncounter : TFhirResourceReference{Resource};
    FReplaces : TFhirId;
    FprovenanceList : TFhirResourceReferenceList{TFhirProvenance};
    FStylesheet : TFhirAttachment;
    FRepresentation : TFhirAttachment;
    FsectionList : TFhirDocumentSectionList;
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetVersionIdentifier(value : TFhirIdentifier);
    Procedure SetCreated(value : TFhirInstant);
    Function GetCreatedST : TDateAndTime;
    Procedure SetCreatedST(value : TDateAndTime);
    Procedure SetType_(value : TFhirCodeableConcept);
    Procedure SetSubtype(value : TFhirCodeableConcept);
    Procedure SetTitle(value : TFhirString);
    Function GetTitleST : String;
    Procedure SetTitleST(value : String);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirDocumentStatus;
    Procedure SetStatusST(value : TFhirDocumentStatus);
    Procedure SetConfidentiality(value : TFhirCoding);
    Procedure SetSubject(value : TFhirResourceReference{Resource});
    Procedure SetCustodian(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetEvent(value : TFhirDocumentEvent);
    Procedure SetEncounter(value : TFhirResourceReference{Resource});
    Procedure SetReplaces(value : TFhirId);
    Function GetReplacesST : String;
    Procedure SetReplacesST(value : String);
    Procedure SetStylesheet(value : TFhirAttachment);
    Procedure SetRepresentation(value : TFhirAttachment);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirDocument; overload;
    function Clone : TFhirDocument; overload;
    {!script show}
  published
    {@member identifier
      Logical Identifier for the document, assigned when created. This identifier stays constant when subsequent versions of the document are created.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member versionIdentifier
      Version specific identifier for the document, assigned when created. This identifier changes when subsequent versions of the document are created.
    }
    property versionIdentifier : TFhirIdentifier read FVersionIdentifier write SetVersionIdentifier;

    {@member created
      The document creation time, when the document first came into being. Where the document is a transform from an original document in some other format, the ClinicalDocument.effectiveTime is the time the original document is created.
    }
    property created : TFhirInstant read FCreated write SetCreated;
    {@member createdST
      Typed access to The document creation time, when the document first came into being. Where the document is a transform from an original document in some other format, the ClinicalDocument.effectiveTime is the time the original document is created.
    }
    property createdST : TDateAndTime read GetCreatedST write SetCreatedST;

    {@member type_
      Specifies the particular kind of document (e.g. History and Physical, Discharge Summary, Progress Note).
    }
    property type_ : TFhirCodeableConcept read FType_ write SetType_;

    {@member subtype
      Additional detailed type for the document.
    }
    property subtype : TFhirCodeableConcept read FSubtype write SetSubtype;

    {@member title
      Official human-readable label for the document.
    }
    property title : TFhirString read FTitle write SetTitle;
    {@member titleST
      Typed access to Official human-readable label for the document.
    }
    property titleST : String read GetTitleST write SetTitleST;

    {@member status
      The workflow/clinical status of this document. The status is a rough guide to the clinical standing of the document.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to The workflow/clinical status of this document. The status is a rough guide to the clinical standing of the document.
    }
    property statusST : TFhirDocumentStatus read GetStatusST write SetStatusST;

    {@member confidentiality
      The code specifying the level of confidentiality of the XDS Document. These codes are specific to an XDS Affinity Domain.
    }
    property confidentiality : TFhirCoding read FConfidentiality write SetConfidentiality;

    {@member subject
      Who or what the document is about. The document can be about a person, (patient or healthcare practitioner), a device (I.e. machine) or even a group of subjects (such as a document about a herd of farm animals, or a set of patients that share a common exposure).
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member authorList
      Identifies who is responsible for the information in the document.  (Not necessarily who typed it in.).
    }
    property authorList : TFhirResourceReferenceList{Resource} read FAuthorList;

    {@member attesterList
      A participant who has attested to the accuracy of the document.
    }
    property attesterList : TFhirDocumentAttesterList read FAttesterList;

    {@member custodian
      Identifies the organization or group who is responsible for ongoing maintenance of and access to the document.
    }
    property custodian : TFhirResourceReference{TFhirOrganization} read FCustodian write SetCustodian;

    {@member event
      The main event/act/item, such as a colonoscopy or an appendectomy, being documented.
    }
    property event : TFhirDocumentEvent read FEvent write SetEvent;

    {@member encounter
      Describes the clinical encounter or type of care this document is associated with.
    }
    property encounter : TFhirResourceReference{Resource} read FEncounter write SetEncounter;

    {@member replaces
      Identifies the document this document supersedes, if any.
    }
    property replaces : TFhirId read FReplaces write SetReplaces;
    {@member replacesST
      Typed access to Identifies the document this document supersedes, if any.
    }
    property replacesST : String read GetReplacesST write SetReplacesST;

    {@member provenanceList
      Additional provenance about the document and the resources that are the sections.
    }
    property provenanceList : TFhirResourceReferenceList{TFhirProvenance} read FProvenanceList;

    {@member stylesheet
      A fixed CSS stylesheet to use when rendering the documents.
    }
    property stylesheet : TFhirAttachment read FStylesheet write SetStylesheet;

    {@member representation
      An alternative representation of the document that can be used in place of the html based rendering.
    }
    property representation : TFhirAttachment read FRepresentation write SetRepresentation;

    {@member sectionList
      Identifies a main topic within the document's table of contents.
    }
    property sectionList : TFhirDocumentSectionList read FSectionList;

  end;


  {@Class TFhirDocumentReference : TFhirResource
    A reference to a document.
  }
  {!.Net HL7Connect.Fhir.DocumentReference}
  TFhirDocumentReference = class (TFhirResource)
  private
    FMasterIdentifier : TFhirIdentifier;
    FidentifierList : TFhirIdentifierList;
    FSubject : TFhirResourceReference{Resource};
    FType_ : TFhirCodeableConcept;
    FSubtype : TFhirCodeableConcept;
    FauthorList : TFhirResourceReferenceList{Resource};
    FCustodian : TFhirResourceReference{TFhirOrganization};
    FAuthenticator : TFhirResourceReference{Resource};
    FCreated : TFhirDateTime;
    FIndexed : TFhirInstant;
    FStatus : TFhirEnum;
    FDocStatus : TFhirCodeableConcept;
    FSupercedes : TFhirResourceReference{TFhirDocumentReference};
    FDescription : TFhirString;
    FConfidentiality : TFhirCodeableConcept;
    FPrimaryLanguage : TFhirCode;
    FMimeType : TFhirCode;
    FFormat : TFhirCodeableConcept;
    FSize : TFhirInteger;
    FHash : TFhirString;
    FLocation : TFhirUri;
    FService : TFhirDocumentReferenceService;
    FContext : TFhirDocumentReferenceContext;
    Procedure SetMasterIdentifier(value : TFhirIdentifier);
    Procedure SetSubject(value : TFhirResourceReference{Resource});
    Procedure SetType_(value : TFhirCodeableConcept);
    Procedure SetSubtype(value : TFhirCodeableConcept);
    Procedure SetCustodian(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetAuthenticator(value : TFhirResourceReference{Resource});
    Procedure SetCreated(value : TFhirDateTime);
    Function GetCreatedST : TDateAndTime;
    Procedure SetCreatedST(value : TDateAndTime);
    Procedure SetIndexed(value : TFhirInstant);
    Function GetIndexedST : TDateAndTime;
    Procedure SetIndexedST(value : TDateAndTime);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirDocumentReferenceStatus;
    Procedure SetStatusST(value : TFhirDocumentReferenceStatus);
    Procedure SetDocStatus(value : TFhirCodeableConcept);
    Procedure SetSupercedes(value : TFhirResourceReference{TFhirDocumentReference});
    Procedure SetDescription(value : TFhirString);
    Function GetDescriptionST : String;
    Procedure SetDescriptionST(value : String);
    Procedure SetConfidentiality(value : TFhirCodeableConcept);
    Procedure SetPrimaryLanguage(value : TFhirCode);
    Function GetPrimaryLanguageST : String;
    Procedure SetPrimaryLanguageST(value : String);
    Procedure SetMimeType(value : TFhirCode);
    Function GetMimeTypeST : String;
    Procedure SetMimeTypeST(value : String);
    Procedure SetFormat(value : TFhirCodeableConcept);
    Procedure SetSize(value : TFhirInteger);
    Function GetSizeST : String;
    Procedure SetSizeST(value : String);
    Procedure SetHash(value : TFhirString);
    Function GetHashST : String;
    Procedure SetHashST(value : String);
    Procedure SetLocation(value : TFhirUri);
    Function GetLocationST : String;
    Procedure SetLocationST(value : String);
    Procedure SetService(value : TFhirDocumentReferenceService);
    Procedure SetContext(value : TFhirDocumentReferenceContext);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirDocumentReference; overload;
    function Clone : TFhirDocumentReference; overload;
    {!script show}
  published
    {@member masterIdentifier
      Document identifier as assigned by the source of the document. This identifier is specific to this version of the document. This unique identifier may be used elsewhere to identify this version of the document.
    }
    property masterIdentifier : TFhirIdentifier read FMasterIdentifier write SetMasterIdentifier;

    {@member identifierList
      Other identifiers associated with the record.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member subject
      Who or what the document is about. The document can be about a person, (patient or healthcare practitioner), a device (I.e. machine) or even a group of subjects (such as a document about a herd of farm animals, or a set of patients that share a common exposure).
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member type_
      Specifies the particular kind of document (e.g. Patient Summary, Discharge Summary, Prescription, etc.).
    }
    property type_ : TFhirCodeableConcept read FType_ write SetType_;

    {@member subtype
      More detailed information about the document type.
    }
    property subtype : TFhirCodeableConcept read FSubtype write SetSubtype;

    {@member authorList
      Identifies who is responsible for adding the information to the document.
    }
    property authorList : TFhirResourceReferenceList{Resource} read FAuthorList;

    {@member custodian
      Identifies the organization or group who is responsible for ongoing maintenance of and access to the document.
    }
    property custodian : TFhirResourceReference{TFhirOrganization} read FCustodian write SetCustodian;

    {@member authenticator
      Which person or organization authenticates that this document is valid.
    }
    property authenticator : TFhirResourceReference{Resource} read FAuthenticator write SetAuthenticator;

    {@member created
      When the document was created.
    }
    property created : TFhirDateTime read FCreated write SetCreated;
    {@member createdST
      Typed access to When the document was created.
    }
    property createdST : TDateAndTime read GetCreatedST write SetCreatedST;

    {@member indexed
      When the document reference was created.
    }
    property indexed : TFhirInstant read FIndexed write SetIndexed;
    {@member indexedST
      Typed access to When the document reference was created.
    }
    property indexedST : TDateAndTime read GetIndexedST write SetIndexedST;

    {@member status
      The status of this document reference.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to The status of this document reference.
    }
    property statusST : TFhirDocumentReferenceStatus read GetStatusST write SetStatusST;

    {@member docStatus
      The status of the underlying document.
    }
    property docStatus : TFhirCodeableConcept read FDocStatus write SetDocStatus;

    {@member supercedes
      If this document replaces another.
    }
    property supercedes : TFhirResourceReference{TFhirDocumentReference} read FSupercedes write SetSupercedes;

    {@member description
      Human Readable description of the source document. This is sometimes known as the "title".
    }
    property description : TFhirString read FDescription write SetDescription;
    {@member descriptionST
      Typed access to Human Readable description of the source document. This is sometimes known as the "title".
    }
    property descriptionST : String read GetDescriptionST write SetDescriptionST;

    {@member confidentiality
      A code specifying the level of confidentiality of the XDS Document.
    }
    property confidentiality : TFhirCodeableConcept read FConfidentiality write SetConfidentiality;

    {@member primaryLanguage
      The primary language in which the source document is written.
    }
    property primaryLanguage : TFhirCode read FPrimaryLanguage write SetPrimaryLanguage;
    {@member primaryLanguageST
      Typed access to The primary language in which the source document is written.
    }
    property primaryLanguageST : String read GetPrimaryLanguageST write SetPrimaryLanguageST;

    {@member mimeType
      The mime type of the source document.
    }
    property mimeType : TFhirCode read FMimeType write SetMimeType;
    {@member mimeTypeST
      Typed access to The mime type of the source document.
    }
    property mimeTypeST : String read GetMimeTypeST write SetMimeTypeST;

    {@member format
      The format of the document. This is used when the mimeType of the document does not provide enough differentiating information (typically, when the mime type of the document is text/xml).
    }
    property format : TFhirCodeableConcept read FFormat write SetFormat;

    {@member size
      The size of the source document this reference refers to in bytes.
    }
    property size : TFhirInteger read FSize write SetSize;
    {@member sizeST
      Typed access to The size of the source document this reference refers to in bytes.
    }
    property sizeST : String read GetSizeST write SetSizeST;

    {@member hash
      A hash of the source document to ensure that changes have not occurred.
    }
    property hash : TFhirString read FHash write SetHash;
    {@member hashST
      Typed access to A hash of the source document to ensure that changes have not occurred.
    }
    property hashST : String read GetHashST write SetHashST;

    {@member location
      A url at which the document can be accessed.
    }
    property location : TFhirUri read FLocation write SetLocation;
    {@member locationST
      Typed access to A url at which the document can be accessed.
    }
    property locationST : String read GetLocationST write SetLocationST;

    {@member service
      A description of a service call that can be used to retrieve the document.
    }
    property service : TFhirDocumentReferenceService read FService write SetService;

    {@member context
      The clinical context in which the document was prepared.
    }
    property context : TFhirDocumentReferenceContext read FContext write SetContext;

  end;


  {@Class TFhirEncounter : TFhirResource
    An interaction between a patient and healthcare provider(s) for the purpose of providing healthcare service(s) or assessing the health status of a patient.
  }
  {!.Net HL7Connect.Fhir.Encounter}
  TFhirEncounter = class (TFhirResource)
  private
    FidentifierList : TFhirIdentifierList;
    FStatus : TFhirEnum;
    FClass_ : TFhirEnum;
    Ftype_List : TFhirCodeableConceptList;
    FSubject : TFhirResourceReference{TFhirPatient};
    FparticipantList : TFhirEncounterParticipantList;
    FFulfills : TFhirResourceReference{TFhirAppointment};
    FStart : TFhirDateTime;
    FLength : TFhirQuantity;
    FReason : TFhirType;
    FIndication : TFhirResourceReference{Resource};
    FPriority : TFhirCodeableConcept;
    FHospitalization : TFhirEncounterHospitalization;
    FlocationList : TFhirEncounterLocationList;
    FServiceProvider : TFhirResourceReference{TFhirOrganization};
    FPartOf : TFhirResourceReference{TFhirEncounter};
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirEncounterState;
    Procedure SetStatusST(value : TFhirEncounterState);
    Procedure SetClass_(value : TFhirEnum);
    Function GetClass_ST : TFhirEncounterClass;
    Procedure SetClass_ST(value : TFhirEncounterClass);
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
    Procedure SetFulfills(value : TFhirResourceReference{TFhirAppointment});
    Procedure SetStart(value : TFhirDateTime);
    Function GetStartST : TDateAndTime;
    Procedure SetStartST(value : TDateAndTime);
    Procedure SetLength(value : TFhirQuantity);
    Procedure SetReason(value : TFhirType);
    Procedure SetIndication(value : TFhirResourceReference{Resource});
    Procedure SetPriority(value : TFhirCodeableConcept);
    Procedure SetHospitalization(value : TFhirEncounterHospitalization);
    Procedure SetServiceProvider(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetPartOf(value : TFhirResourceReference{TFhirEncounter});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirEncounter; overload;
    function Clone : TFhirEncounter; overload;
    {!script show}
  published
    {@member identifierList
      Identifier(s) by which this encounter is known.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member status
      E.g. active, aborted, finished.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to E.g. active, aborted, finished.
    }
    property statusST : TFhirEncounterState read GetStatusST write SetStatusST;

    {@member class_
      Inpatient | Outpatient etc.
    }
    property class_ : TFhirEnum read FClass_ write SetClass_;
    {@member class_ST
      Typed access to Inpatient | Outpatient etc.
    }
    property class_ST : TFhirEncounterClass read GetClass_ST write SetClass_ST;

    {@member type_List
      Specific type of encounter (e.g. e-mail consultation, surgical day-care, skilled nursing, rehabilitation).
    }
    property type_List : TFhirCodeableConceptList read FType_List;

    {@member subject
      The patient present at the encounter.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member participantList
      The main practitioner responsible for providing the service.
    }
    property participantList : TFhirEncounterParticipantList read FParticipantList;

    {@member fulfills
      The appointment that scheduled this encounter.
    }
    property fulfills : TFhirResourceReference{TFhirAppointment} read FFulfills write SetFulfills;

    {@member start
      The date and time the encounter starts, e.g. the patient arrives.
    }
    property start : TFhirDateTime read FStart write SetStart;
    {@member startST
      Typed access to The date and time the encounter starts, e.g. the patient arrives.
    }
    property startST : TDateAndTime read GetStartST write SetStartST;

    {@member length
      Quantity of time the encounter lasted. This excludes the time during leaves of absence.
    }
    property length : TFhirQuantity read FLength write SetLength;

    {@member reason
      Reason the encounter takes place.
    }
    property reason : TFhirType read FReason write SetReason;

    {@member indication
      Reason the encounter takes place.
    }
    property indication : TFhirResourceReference{Resource} read FIndication write SetIndication;

    {@member priority
      Indicates the urgency of the encounter.
    }
    property priority : TFhirCodeableConcept read FPriority write SetPriority;

    {@member hospitalization
      Details about an admission to a clinic.
    }
    property hospitalization : TFhirEncounterHospitalization read FHospitalization write SetHospitalization;

    {@member locationList
      List of locations the patient has been at.
    }
    property locationList : TFhirEncounterLocationList read FLocationList;

    {@member serviceProvider
      Department or team providing care.
    }
    property serviceProvider : TFhirResourceReference{TFhirOrganization} read FServiceProvider write SetServiceProvider;

    {@member partOf
      Another Encounter this encounter is part of (administratively or in time).
    }
    property partOf : TFhirResourceReference{TFhirEncounter} read FPartOf write SetPartOf;

  end;


  {@Class TFhirFamilyHistory : TFhirResource
    Significant health events and conditions for people related to the subject relevant in the context of care for the subject.
  }
  {!.Net HL7Connect.Fhir.FamilyHistory}
  TFhirFamilyHistory = class (TFhirResource)
  private
    FSubject : TFhirResourceReference{TFhirPatient};
    FNote : TFhirString;
    FrelationList : TFhirFamilyHistoryRelationList;
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
    Procedure SetNote(value : TFhirString);
    Function GetNoteST : String;
    Procedure SetNoteST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirFamilyHistory; overload;
    function Clone : TFhirFamilyHistory; overload;
    {!script show}
  published
    {@member subject
      The person who this history concerns.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member note
      Conveys information about family history not specific to individual relations.
    }
    property note : TFhirString read FNote write SetNote;
    {@member noteST
      Typed access to Conveys information about family history not specific to individual relations.
    }
    property noteST : String read GetNoteST write SetNoteST;

    {@member relationList
      The related person. Each FamilyHistory resource contains the entire family history for a single person.
    }
    property relationList : TFhirFamilyHistoryRelationList read FRelationList;

  end;


  {@Class TFhirGroup : TFhirResource
    Represents a defined collection of entities that may be discussed or acted upon collectively but which are not expected to act collectively and are not formally or legally recognized.  I.e. A collection of entities that isn't an Organization.
  }
  {!.Net HL7Connect.Fhir.Group}
  TFhirGroup = class (TFhirResource)
  private
    FIdentifier : TFhirIdentifier;
    FType_ : TFhirEnum;
    FActual : TFhirBoolean;
    FCode : TFhirCodeableConcept;
    FName : TFhirString;
    FQuantity : TFhirInteger;
    FcharacteristicList : TFhirGroupCharacteristicList;
    FmemberList : TFhirResourceReferenceList{Resource};
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetType_(value : TFhirEnum);
    Function GetType_ST : TFhirGroupType;
    Procedure SetType_ST(value : TFhirGroupType);
    Procedure SetActual(value : TFhirBoolean);
    Function GetActualST : String;
    Procedure SetActualST(value : String);
    Procedure SetCode(value : TFhirCodeableConcept);
    Procedure SetName(value : TFhirString);
    Function GetNameST : String;
    Procedure SetNameST(value : String);
    Procedure SetQuantity(value : TFhirInteger);
    Function GetQuantityST : String;
    Procedure SetQuantityST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirGroup; overload;
    function Clone : TFhirGroup; overload;
    {!script show}
  published
    {@member identifier
      A unique business identifier for this group.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member type_
      Identifies the broad classification of the kind of resources the group includes.
    }
    property type_ : TFhirEnum read FType_ write SetType_;
    {@member type_ST
      Typed access to Identifies the broad classification of the kind of resources the group includes.
    }
    property type_ST : TFhirGroupType read GetType_ST write SetType_ST;

    {@member actual
      If true, indicates that the resource refers to a specific group of real individuals.  If false, the group defines a set of intended individuals.
    }
    property actual : TFhirBoolean read FActual write SetActual;
    {@member actualST
      Typed access to If true, indicates that the resource refers to a specific group of real individuals.  If false, the group defines a set of intended individuals.
    }
    property actualST : String read GetActualST write SetActualST;

    {@member code
      Provides a specific type of resource the group includes.  E.g. "cow", "syringe", etc.
    }
    property code : TFhirCodeableConcept read FCode write SetCode;

    {@member name
      A label assigned to the group for human identification and communication.
    }
    property name : TFhirString read FName write SetName;
    {@member nameST
      Typed access to A label assigned to the group for human identification and communication.
    }
    property nameST : String read GetNameST write SetNameST;

    {@member quantity
      A count of the number of resource instances that are part of the group.
    }
    property quantity : TFhirInteger read FQuantity write SetQuantity;
    {@member quantityST
      Typed access to A count of the number of resource instances that are part of the group.
    }
    property quantityST : String read GetQuantityST write SetQuantityST;

    {@member characteristicList
      Identifies the traits shared by members of the group.
    }
    property characteristicList : TFhirGroupCharacteristicList read FCharacteristicList;

    {@member memberList
      Identifies the resource instances that are members of the group.
    }
    property memberList : TFhirResourceReferenceList{Resource} read FMemberList;

  end;


  {@Class TFhirImagingStudy : TFhirResource
    Manifest of a set of images produced in study. The set of images may include every image in the study, or it may be an incomplete sample, such as a list of key images.
  }
  {!.Net HL7Connect.Fhir.ImagingStudy}
  TFhirImagingStudy = class (TFhirResource)
  private
    FDateTime : TFhirDateTime;
    FSubject : TFhirResourceReference{TFhirPatient};
    FUid : TFhirOid;
    FAccessionNo : TFhirIdentifier;
    FidentifierList : TFhirIdentifierList;
    FModality : TFhirEnumList;
    FReferrer : TFhirResourceReference{TFhirPractitioner};
    FAvailability : TFhirEnum;
    FUrl : TFhirUri;
    FNumberOfSeries : TFhirInteger;
    FNumberOfInstances : TFhirInteger;
    FClinicalInformation : TFhirString;
    Fprocedure_List : TFhirCodingList;
    FInterpreter : TFhirResourceReference{TFhirPractitioner};
    FDescription : TFhirString;
    FseriesList : TFhirImagingStudySeriesList;
    Procedure SetDateTime(value : TFhirDateTime);
    Function GetDateTimeST : TDateAndTime;
    Procedure SetDateTimeST(value : TDateAndTime);
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
    Procedure SetUid(value : TFhirOid);
    Function GetUidST : String;
    Procedure SetUidST(value : String);
    Procedure SetAccessionNo(value : TFhirIdentifier);
    Function GetModalityST : TFhirImagingModalityList;
    Procedure SetModalityST(value : TFhirImagingModalityList);
    Procedure SetReferrer(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetAvailability(value : TFhirEnum);
    Function GetAvailabilityST : TFhirInstanceAvailability;
    Procedure SetAvailabilityST(value : TFhirInstanceAvailability);
    Procedure SetUrl(value : TFhirUri);
    Function GetUrlST : String;
    Procedure SetUrlST(value : String);
    Procedure SetNumberOfSeries(value : TFhirInteger);
    Function GetNumberOfSeriesST : String;
    Procedure SetNumberOfSeriesST(value : String);
    Procedure SetNumberOfInstances(value : TFhirInteger);
    Function GetNumberOfInstancesST : String;
    Procedure SetNumberOfInstancesST(value : String);
    Procedure SetClinicalInformation(value : TFhirString);
    Function GetClinicalInformationST : String;
    Procedure SetClinicalInformationST(value : String);
    Procedure SetInterpreter(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetDescription(value : TFhirString);
    Function GetDescriptionST : String;
    Procedure SetDescriptionST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirImagingStudy; overload;
    function Clone : TFhirImagingStudy; overload;
    {!script show}
  published
    {@member dateTime
      Date and Time the study took place.
    }
    property dateTime : TFhirDateTime read FDateTime write SetDateTime;
    {@member dateTimeST
      Typed access to Date and Time the study took place.
    }
    property dateTimeST : TDateAndTime read GetDateTimeST write SetDateTimeST;

    {@member subject
      Who the images are of.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member uid
      Formal identifier for the study.
    }
    property uid : TFhirOid read FUid write SetUid;
    {@member uidST
      Typed access to Formal identifier for the study.
    }
    property uidST : String read GetUidST write SetUidST;

    {@member accessionNo
      Accession Number.
    }
    property accessionNo : TFhirIdentifier read FAccessionNo write SetAccessionNo;

    {@member identifierList
      Other identifiers for the study.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member modality
      A list of all the Series.ImageModality values that are actual acquisition modalities, i.e. those in the DICOM Context Group 29 (value set OID 1.2.840.10008.6.1.19).
    }
    property modality : TFhirEnumList read FModality;
    {@member modalityST
      Typed access to A list of all the Series.ImageModality values that are actual acquisition modalities, i.e. those in the DICOM Context Group 29 (value set OID 1.2.840.10008.6.1.19).
    }
    property modalityST : TFhirImagingModalityList read GetModalityST write SetModalityST;
    {@member referrer
      The requesting/referring physician.
    }
    property referrer : TFhirResourceReference{TFhirPractitioner} read FReferrer write SetReferrer;

    {@member availability
      Availability of study (online, offline or nearlnie).
    }
    property availability : TFhirEnum read FAvailability write SetAvailability;
    {@member availabilityST
      Typed access to Availability of study (online, offline or nearlnie).
    }
    property availabilityST : TFhirInstanceAvailability read GetAvailabilityST write SetAvailabilityST;

    {@member url
      WADO-RS URI where Study is available.
    }
    property url : TFhirUri read FUrl write SetUrl;
    {@member urlST
      Typed access to WADO-RS URI where Study is available.
    }
    property urlST : String read GetUrlST write SetUrlST;

    {@member numberOfSeries
      Number of Series in Study.
    }
    property numberOfSeries : TFhirInteger read FNumberOfSeries write SetNumberOfSeries;
    {@member numberOfSeriesST
      Typed access to Number of Series in Study.
    }
    property numberOfSeriesST : String read GetNumberOfSeriesST write SetNumberOfSeriesST;

    {@member numberOfInstances
      Number of SOP Instances in Study.
    }
    property numberOfInstances : TFhirInteger read FNumberOfInstances write SetNumberOfInstances;
    {@member numberOfInstancesST
      Typed access to Number of SOP Instances in Study.
    }
    property numberOfInstancesST : String read GetNumberOfInstancesST write SetNumberOfInstancesST;

    {@member clinicalInformation
      Diagnoses etc provided with request.
    }
    property clinicalInformation : TFhirString read FClinicalInformation write SetClinicalInformation;
    {@member clinicalInformationST
      Typed access to Diagnoses etc provided with request.
    }
    property clinicalInformationST : String read GetClinicalInformationST write SetClinicalInformationST;

    {@member procedure_List
      Type of procedure performed.
    }
    property procedure_List : TFhirCodingList read FProcedure_List;

    {@member interpreter
      Who read study and interpreted the images.
    }
    property interpreter : TFhirResourceReference{TFhirPractitioner} read FInterpreter write SetInterpreter;

    {@member description
      Institution-generated description or classification of the Study (component) performed.
    }
    property description : TFhirString read FDescription write SetDescription;
    {@member descriptionST
      Typed access to Institution-generated description or classification of the Study (component) performed.
    }
    property descriptionST : String read GetDescriptionST write SetDescriptionST;

    {@member seriesList
      Each study has one or more series of image instances.
    }
    property seriesList : TFhirImagingStudySeriesList read FSeriesList;

  end;


  {@Class TFhirImmunization : TFhirResource
    Immunization event information.
  }
  {!.Net HL7Connect.Fhir.Immunization}
  TFhirImmunization = class (TFhirResource)
  private
    FDate : TFhirDateTime;
    FVaccineType : TFhirCodeableConcept;
    FSubject : TFhirResourceReference{TFhirPatient};
    FRefusedIndicator : TFhirBoolean;
    FReported : TFhirBoolean;
    FPerformer : TFhirResourceReference{TFhirPractitioner};
    FRequester : TFhirResourceReference{TFhirPractitioner};
    FManufacturer : TFhirResourceReference{TFhirOrganization};
    FLocation : TFhirResourceReference{TFhirLocation};
    FLotNumber : TFhirString;
    FExpirationDate : TFhirDate;
    FSite : TFhirCodeableConcept;
    FRoute : TFhirCodeableConcept;
    FDoseQuantity : TFhirQuantity;
    FExplanation : TFhirImmunizationExplanation;
    FreactionList : TFhirImmunizationReactionList;
    FVaccinationProtocol : TFhirImmunizationVaccinationProtocol;
    Procedure SetDate(value : TFhirDateTime);
    Function GetDateST : TDateAndTime;
    Procedure SetDateST(value : TDateAndTime);
    Procedure SetVaccineType(value : TFhirCodeableConcept);
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
    Procedure SetRefusedIndicator(value : TFhirBoolean);
    Function GetRefusedIndicatorST : String;
    Procedure SetRefusedIndicatorST(value : String);
    Procedure SetReported(value : TFhirBoolean);
    Function GetReportedST : String;
    Procedure SetReportedST(value : String);
    Procedure SetPerformer(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetRequester(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetManufacturer(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetLocation(value : TFhirResourceReference{TFhirLocation});
    Procedure SetLotNumber(value : TFhirString);
    Function GetLotNumberST : String;
    Procedure SetLotNumberST(value : String);
    Procedure SetExpirationDate(value : TFhirDate);
    Function GetExpirationDateST : TDateAndTime;
    Procedure SetExpirationDateST(value : TDateAndTime);
    Procedure SetSite(value : TFhirCodeableConcept);
    Procedure SetRoute(value : TFhirCodeableConcept);
    Procedure SetDoseQuantity(value : TFhirQuantity);
    Procedure SetExplanation(value : TFhirImmunizationExplanation);
    Procedure SetVaccinationProtocol(value : TFhirImmunizationVaccinationProtocol);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirImmunization; overload;
    function Clone : TFhirImmunization; overload;
    {!script show}
  published
    {@member date
      Date vaccine administered or was to be administered.
    }
    property date : TFhirDateTime read FDate write SetDate;
    {@member dateST
      Typed access to Date vaccine administered or was to be administered.
    }
    property dateST : TDateAndTime read GetDateST write SetDateST;

    {@member vaccineType
      Vaccine that was administered or was to be administered.
    }
    property vaccineType : TFhirCodeableConcept read FVaccineType write SetVaccineType;

    {@member subject
      The patient to whom the vaccine was to be administered.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member refusedIndicator
      Indicates if the vaccination was refused.
    }
    property refusedIndicator : TFhirBoolean read FRefusedIndicator write SetRefusedIndicator;
    {@member refusedIndicatorST
      Typed access to Indicates if the vaccination was refused.
    }
    property refusedIndicatorST : String read GetRefusedIndicatorST write SetRefusedIndicatorST;

    {@member reported
      True if this administration was reported rather than directly administered.
    }
    property reported : TFhirBoolean read FReported write SetReported;
    {@member reportedST
      Typed access to True if this administration was reported rather than directly administered.
    }
    property reportedST : String read GetReportedST write SetReportedST;

    {@member performer
      Clinician that administered the vaccine.
    }
    property performer : TFhirResourceReference{TFhirPractitioner} read FPerformer write SetPerformer;

    {@member requester
      Clinician who ordered the vaccination.
    }
    property requester : TFhirResourceReference{TFhirPractitioner} read FRequester write SetRequester;

    {@member manufacturer
      Name of vaccine manufacturer.
    }
    property manufacturer : TFhirResourceReference{TFhirOrganization} read FManufacturer write SetManufacturer;

    {@member location
      The service delivery location where the vaccine administration occurred.
    }
    property location : TFhirResourceReference{TFhirLocation} read FLocation write SetLocation;

    {@member lotNumber
      Lot number of the  vaccine product.
    }
    property lotNumber : TFhirString read FLotNumber write SetLotNumber;
    {@member lotNumberST
      Typed access to Lot number of the  vaccine product.
    }
    property lotNumberST : String read GetLotNumberST write SetLotNumberST;

    {@member expirationDate
      Date vaccine batch expires.
    }
    property expirationDate : TFhirDate read FExpirationDate write SetExpirationDate;
    {@member expirationDateST
      Typed access to Date vaccine batch expires.
    }
    property expirationDateST : TDateAndTime read GetExpirationDateST write SetExpirationDateST;

    {@member site
      Body site where vaccine was administered.
    }
    property site : TFhirCodeableConcept read FSite write SetSite;

    {@member route
      The path by which the vaccine product is taken into the body.
    }
    property route : TFhirCodeableConcept read FRoute write SetRoute;

    {@member doseQuantity
      The quantity of vaccine product that was administered.
    }
    property doseQuantity : TFhirQuantity read FDoseQuantity write SetDoseQuantity;

    {@member explanation
      Reasons why a vaccine was administered or refused.
    }
    property explanation : TFhirImmunizationExplanation read FExplanation write SetExplanation;

    {@member reactionList
      Categorical data indicating that an adverse event is associated in time to an immunization.
    }
    property reactionList : TFhirImmunizationReactionList read FReactionList;

    {@member vaccinationProtocol
      Contains information about the protocol under which the vaccine was administered.
    }
    property vaccinationProtocol : TFhirImmunizationVaccinationProtocol read FVaccinationProtocol write SetVaccinationProtocol;

  end;


  {@Class TFhirImmunizationProfile : TFhirResource
    A patient's point-of-time immunization status and recommendation with optional supporting justification.
  }
  {!.Net HL7Connect.Fhir.ImmunizationProfile}
  TFhirImmunizationProfile = class (TFhirResource)
  private
    FSubject : TFhirResourceReference{TFhirPatient};
    FrecommendationList : TFhirImmunizationProfileRecommendationList;
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirImmunizationProfile; overload;
    function Clone : TFhirImmunizationProfile; overload;
    {!script show}
  published
    {@member subject
      The patient who is the subject of the profile.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member recommendationList
      Vaccine administration recommendations.
    }
    property recommendationList : TFhirImmunizationProfileRecommendationList read FRecommendationList;

  end;


  {@Class TFhirList : TFhirResource
    A set of information summarized from a list of other resources.
  }
  {!.Net HL7Connect.Fhir.List}
  TFhirList = class (TFhirResource)
  private
    FCode : TFhirCodeableConcept;
    FSource : TFhirResourceReference{Resource};
    FDate : TFhirDateTime;
    FOrdered : TFhirBoolean;
    FMode : TFhirEnum;
    FentryList : TFhirListEntryList;
    FEmptyReason : TFhirCodeableConcept;
    Procedure SetCode(value : TFhirCodeableConcept);
    Procedure SetSource(value : TFhirResourceReference{Resource});
    Procedure SetDate(value : TFhirDateTime);
    Function GetDateST : TDateAndTime;
    Procedure SetDateST(value : TDateAndTime);
    Procedure SetOrdered(value : TFhirBoolean);
    Function GetOrderedST : String;
    Procedure SetOrderedST(value : String);
    Procedure SetMode(value : TFhirEnum);
    Function GetModeST : TFhirListMode;
    Procedure SetModeST(value : TFhirListMode);
    Procedure SetEmptyReason(value : TFhirCodeableConcept);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirList; overload;
    function Clone : TFhirList; overload;
    {!script show}
  published
    {@member code
      This code defines the purpose of the list - why it was created.
    }
    property code : TFhirCodeableConcept read FCode write SetCode;

    {@member source
      The entity responsible for deciding what the contents of the list were.
    }
    property source : TFhirResourceReference{Resource} read FSource write SetSource;

    {@member date
      The date that the list was prepared.
    }
    property date : TFhirDateTime read FDate write SetDate;
    {@member dateST
      Typed access to The date that the list was prepared.
    }
    property dateST : TDateAndTime read GetDateST write SetDateST;

    {@member ordered
      Whether items in the list have a meaningful order.
    }
    property ordered : TFhirBoolean read FOrdered write SetOrdered;
    {@member orderedST
      Typed access to Whether items in the list have a meaningful order.
    }
    property orderedST : String read GetOrderedST write SetOrderedST;

    {@member mode
      How this list was prepared - whether it is a working list that is suitable for being maintained in an ongoing basis, or if it represents a snapshot of a list of items from another source, or whether it is a prepared list where items may be marked as added, modified or deleted.
    }
    property mode : TFhirEnum read FMode write SetMode;
    {@member modeST
      Typed access to How this list was prepared - whether it is a working list that is suitable for being maintained in an ongoing basis, or if it represents a snapshot of a list of items from another source, or whether it is a prepared list where items may be marked as added, modified or deleted.
    }
    property modeST : TFhirListMode read GetModeST write SetModeST;

    {@member entryList
      Entries in this list.
    }
    property entryList : TFhirListEntryList read FEntryList;

    {@member emptyReason
      If the list is empty, why the list is empty.
    }
    property emptyReason : TFhirCodeableConcept read FEmptyReason write SetEmptyReason;

  end;


  {@Class TFhirLocation : TFhirResource
    Contact details and position information for a physical place that may be visited and where healthcare resources and participants may be found or contained, accommodated, or stored.
  }
  {!.Net HL7Connect.Fhir.Location}
  TFhirLocation = class (TFhirResource)
  private
    FName : TFhirString;
    FDescription : TFhirString;
    Ftype_List : TFhirCodeableConceptList;
    FTelecom : TFhirContact;
    FAddress : TFhirAddress;
    FPosition : TFhirLocationPosition;
    FProvider : TFhirResourceReference{TFhirOrganization};
    FActive : TFhirBoolean;
    FPartOf : TFhirResourceReference{TFhirLocation};
    Procedure SetName(value : TFhirString);
    Function GetNameST : String;
    Procedure SetNameST(value : String);
    Procedure SetDescription(value : TFhirString);
    Function GetDescriptionST : String;
    Procedure SetDescriptionST(value : String);
    Procedure SetTelecom(value : TFhirContact);
    Procedure SetAddress(value : TFhirAddress);
    Procedure SetPosition(value : TFhirLocationPosition);
    Procedure SetProvider(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetActive(value : TFhirBoolean);
    Function GetActiveST : String;
    Procedure SetActiveST(value : String);
    Procedure SetPartOf(value : TFhirResourceReference{TFhirLocation});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirLocation; overload;
    function Clone : TFhirLocation; overload;
    {!script show}
  published
    {@member name
      Name of the location which identifies it to its users.
    }
    property name : TFhirString read FName write SetName;
    {@member nameST
      Typed access to Name of the location which identifies it to its users.
    }
    property nameST : String read GetNameST write SetNameST;

    {@member description
      Description of the Location, which helps in finding or referencing the place.
    }
    property description : TFhirString read FDescription write SetDescription;
    {@member descriptionST
      Typed access to Description of the Location, which helps in finding or referencing the place.
    }
    property descriptionST : String read GetDescriptionST write SetDescriptionST;

    {@member type_List
      Classification of the location.
    }
    property type_List : TFhirCodeableConceptList read FType_List;

    {@member telecom
      The contact details of the main communication devices present at the location.
    }
    property telecom : TFhirContact read FTelecom write SetTelecom;

    {@member address
      Physical location.
    }
    property address : TFhirAddress read FAddress write SetAddress;

    {@member position
      The absolute geographic location of the Location, expressed in a KML compatible manner (see notes below for KML).
    }
    property position : TFhirLocationPosition read FPosition write SetPosition;

    {@member provider
      The organization that provides services at the location.
    }
    property provider : TFhirResourceReference{TFhirOrganization} read FProvider write SetProvider;

    {@member active
      Whether the location is still used to provide services.
    }
    property active : TFhirBoolean read FActive write SetActive;
    {@member activeST
      Typed access to Whether the location is still used to provide services.
    }
    property activeST : String read GetActiveST write SetActiveST;

    {@member partOf
      Another Location which this Location is physically inside of.
    }
    property partOf : TFhirResourceReference{TFhirLocation} read FPartOf write SetPartOf;

  end;


  {@Class TFhirMedia : TFhirResource
    A photo, video, or audio recording acquired or used in healthcare. The actual content maybe inline or provided by direct reference.
  }
  {!.Net HL7Connect.Fhir.Media}
  TFhirMedia = class (TFhirResource)
  private
    FType_ : TFhirEnum;
    FSubtype : TFhirCodeableConcept;
    FidentifierList : TFhirIdentifierList;
    FDateTime : TFhirDateTime;
    FSubject : TFhirResourceReference{Resource};
    FRequester : TFhirResourceReference{TFhirPractitioner};
    FOperator : TFhirResourceReference{TFhirPractitioner};
    FView : TFhirCodeableConcept;
    FDeviceName : TFhirString;
    FHeight : TFhirInteger;
    FWidth : TFhirInteger;
    FFrames : TFhirInteger;
    FLength : TFhirInteger;
    FContent : TFhirAttachment;
    Procedure SetType_(value : TFhirEnum);
    Function GetType_ST : TFhirMediaType;
    Procedure SetType_ST(value : TFhirMediaType);
    Procedure SetSubtype(value : TFhirCodeableConcept);
    Procedure SetDateTime(value : TFhirDateTime);
    Function GetDateTimeST : TDateAndTime;
    Procedure SetDateTimeST(value : TDateAndTime);
    Procedure SetSubject(value : TFhirResourceReference{Resource});
    Procedure SetRequester(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetOperator(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetView(value : TFhirCodeableConcept);
    Procedure SetDeviceName(value : TFhirString);
    Function GetDeviceNameST : String;
    Procedure SetDeviceNameST(value : String);
    Procedure SetHeight(value : TFhirInteger);
    Function GetHeightST : String;
    Procedure SetHeightST(value : String);
    Procedure SetWidth(value : TFhirInteger);
    Function GetWidthST : String;
    Procedure SetWidthST(value : String);
    Procedure SetFrames(value : TFhirInteger);
    Function GetFramesST : String;
    Procedure SetFramesST(value : String);
    Procedure SetLength(value : TFhirInteger);
    Function GetLengthST : String;
    Procedure SetLengthST(value : String);
    Procedure SetContent(value : TFhirAttachment);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirMedia; overload;
    function Clone : TFhirMedia; overload;
    {!script show}
  published
    {@member type_
      Whether the media is a photo (still image), an audio recording, or a video recording.
    }
    property type_ : TFhirEnum read FType_ write SetType_;
    {@member type_ST
      Typed access to Whether the media is a photo (still image), an audio recording, or a video recording.
    }
    property type_ST : TFhirMediaType read GetType_ST write SetType_ST;

    {@member subtype
      Details of the type of the media - usually, how it was acquired (what type of device). If images sourced from a DICOM system, are wrapped in a Media resource, then this is the modality.
    }
    property subtype : TFhirCodeableConcept read FSubtype write SetSubtype;

    {@member identifierList
      Identifiers associated with the image - these may include identifiers for the image itself, identifiers for the context of its collection (e.g. series ids) and context ids such as accession numbers or other workflow identifiers.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member dateTime
      When the media was originally recorded. For video and audio, if the length of the recording is not insignificant, this is the end of the recording.
    }
    property dateTime : TFhirDateTime read FDateTime write SetDateTime;
    {@member dateTimeST
      Typed access to When the media was originally recorded. For video and audio, if the length of the recording is not insignificant, this is the end of the recording.
    }
    property dateTimeST : TDateAndTime read GetDateTimeST write SetDateTimeST;

    {@member subject
      Who/What this Media is a record of.
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member requester
      Who requested that this image be collected.
    }
    property requester : TFhirResourceReference{TFhirPractitioner} read FRequester write SetRequester;

    {@member operator
      The person who administered the collection of the image.
    }
    property operator : TFhirResourceReference{TFhirPractitioner} read FOperator write SetOperator;

    {@member view
      The name of the imaging view e.g Lateral or Antero-posterior (AP).
    }
    property view : TFhirCodeableConcept read FView write SetView;

    {@member deviceName
      The name of the device / manufacturer of the device  that was used to make the recording.
    }
    property deviceName : TFhirString read FDeviceName write SetDeviceName;
    {@member deviceNameST
      Typed access to The name of the device / manufacturer of the device  that was used to make the recording.
    }
    property deviceNameST : String read GetDeviceNameST write SetDeviceNameST;

    {@member height
      Height of the image in pixels(photo/video).
    }
    property height : TFhirInteger read FHeight write SetHeight;
    {@member heightST
      Typed access to Height of the image in pixels(photo/video).
    }
    property heightST : String read GetHeightST write SetHeightST;

    {@member width
      Width of the image in pixels (photo/video).
    }
    property width : TFhirInteger read FWidth write SetWidth;
    {@member widthST
      Typed access to Width of the image in pixels (photo/video).
    }
    property widthST : String read GetWidthST write SetWidthST;

    {@member frames
      The number of frames in a photo. This is used with a multi-page fax, or an imaging acquisition context that takes multiple slices in a single iamge, or an animated gif. If there is more than one frame, this must have a value in order to alert interface software that a multi-frame capable rendering widget is required.
    }
    property frames : TFhirInteger read FFrames write SetFrames;
    {@member framesST
      Typed access to The number of frames in a photo. This is used with a multi-page fax, or an imaging acquisition context that takes multiple slices in a single iamge, or an animated gif. If there is more than one frame, this must have a value in order to alert interface software that a multi-frame capable rendering widget is required.
    }
    property framesST : String read GetFramesST write SetFramesST;

    {@member length
      The length of the recording in seconds - for audio and video.
    }
    property length : TFhirInteger read FLength write SetLength;
    {@member lengthST
      Typed access to The length of the recording in seconds - for audio and video.
    }
    property lengthST : String read GetLengthST write SetLengthST;

    {@member content
      The actual content of the media - inline or by direct reference to the media source file.
    }
    property content : TFhirAttachment read FContent write SetContent;

  end;


  {@Class TFhirMedication : TFhirResource
    Primarily used for identification and definition of Medication, but also covers ingredients and packaging.
  }
  {!.Net HL7Connect.Fhir.Medication}
  TFhirMedication = class (TFhirResource)
  private
    FName : TFhirString;
    FCode : TFhirCodeableConcept;
    FIsBrand : TFhirBoolean;
    FManufacturer : TFhirResourceReference{TFhirOrganization};
    FKind : TFhirEnum;
    FProduct : TFhirMedicationProduct;
    FPackage : TFhirMedicationPackage;
    Procedure SetName(value : TFhirString);
    Function GetNameST : String;
    Procedure SetNameST(value : String);
    Procedure SetCode(value : TFhirCodeableConcept);
    Procedure SetIsBrand(value : TFhirBoolean);
    Function GetIsBrandST : String;
    Procedure SetIsBrandST(value : String);
    Procedure SetManufacturer(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetKind(value : TFhirEnum);
    Function GetKindST : TFhirMedicationKind;
    Procedure SetKindST(value : TFhirMedicationKind);
    Procedure SetProduct(value : TFhirMedicationProduct);
    Procedure SetPackage(value : TFhirMedicationPackage);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirMedication; overload;
    function Clone : TFhirMedication; overload;
    {!script show}
  published
    {@member name
      The common name of the medication.
    }
    property name : TFhirString read FName write SetName;
    {@member nameST
      Typed access to The common name of the medication.
    }
    property nameST : String read GetNameST write SetNameST;

    {@member code
      References to codes for this medication in standard medication terminologies, drug dictionaries, etc.
    }
    property code : TFhirCodeableConcept read FCode write SetCode;

    {@member isBrand
      Set to true if the item is attributable to a specific manufacturer (even if we don't know who that is).
    }
    property isBrand : TFhirBoolean read FIsBrand write SetIsBrand;
    {@member isBrandST
      Typed access to Set to true if the item is attributable to a specific manufacturer (even if we don't know who that is).
    }
    property isBrandST : String read GetIsBrandST write SetIsBrandST;

    {@member manufacturer
      Describes the details of the manufacturer.
    }
    property manufacturer : TFhirResourceReference{TFhirOrganization} read FManufacturer write SetManufacturer;

    {@member kind
      product | package.
    }
    property kind : TFhirEnum read FKind write SetKind;
    {@member kindST
      Typed access to product | package.
    }
    property kindST : TFhirMedicationKind read GetKindST write SetKindST;

    {@member product
      If is a product.
    }
    property product : TFhirMedicationProduct read FProduct write SetProduct;

    {@member package
      Specifies Ingredient / Product / Package.
    }
    property package : TFhirMedicationPackage read FPackage write SetPackage;

  end;


  {@Class TFhirMedicationAdministration : TFhirResource
    Describes the event of a patient being given a dose of a medication.  This may be as simple as swallowing a tablet or it may be a long running infusion.

Related resources tie this event to the authorizing prescription, and the specific encounter between patient and health care practitioner.
  }
  {!.Net HL7Connect.Fhir.MedicationAdministration}
  TFhirMedicationAdministration = class (TFhirResource)
  private
    FidentifierList : TFhirIdentifierList;
    FStatus : TFhirEnum;
    FPatient : TFhirResourceReference{TFhirPatient};
    FPractitioner : TFhirResourceReference{TFhirPractitioner};
    FEncounter : TFhirResourceReference{TFhirEncounter};
    FPrescription : TFhirResourceReference{TFhirMedicationPrescription};
    FWasNotGiven : TFhirBoolean;
    FreasonNotGivenList : TFhirCodeableConceptList;
    FWhenGiven : TFhirPeriod;
    FMedication : TFhirResourceReference{TFhirMedication};
    FadministrationDeviceList : TFhirResourceReferenceList{TFhirDevice};
    FdosageList : TFhirMedicationAdministrationDosageList;
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirMedicationAdminStatus;
    Procedure SetStatusST(value : TFhirMedicationAdminStatus);
    Procedure SetPatient(value : TFhirResourceReference{TFhirPatient});
    Procedure SetPractitioner(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetEncounter(value : TFhirResourceReference{TFhirEncounter});
    Procedure SetPrescription(value : TFhirResourceReference{TFhirMedicationPrescription});
    Procedure SetWasNotGiven(value : TFhirBoolean);
    Function GetWasNotGivenST : String;
    Procedure SetWasNotGivenST(value : String);
    Procedure SetWhenGiven(value : TFhirPeriod);
    Procedure SetMedication(value : TFhirResourceReference{TFhirMedication});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirMedicationAdministration; overload;
    function Clone : TFhirMedicationAdministration; overload;
    {!script show}
  published
    {@member identifierList
      External identifier - FHIR will generate its own internal IDs (probably URLs) which do not need to be explicitly managed by the resource.  The identifier here is one that would be used by another non-FHIR system - for example an automated medication pump would provide a record each time it operated; an administration while the patient was off the ward might be made with a different system and entered after the event.  Particularly important if these records have to be updated.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member status
      Will generally be set to show that the administration has been completed.  For some long running administrations such as infusions it is possible for an administration to be started but not completed or it may be paused while some other process is under way.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to Will generally be set to show that the administration has been completed.  For some long running administrations such as infusions it is possible for an administration to be started but not completed or it may be paused while some other process is under way.
    }
    property statusST : TFhirMedicationAdminStatus read GetStatusST write SetStatusST;

    {@member patient
      A link to a resource representing the person to whom the medication was given.
    }
    property patient : TFhirResourceReference{TFhirPatient} read FPatient write SetPatient;

    {@member practitioner
      The individual who is responsible for giving the medication to the patient.
    }
    property practitioner : TFhirResourceReference{TFhirPractitioner} read FPractitioner write SetPractitioner;

    {@member encounter
      An link to a resource that identifies the particular occurrence of contact between patient and health care provider.
    }
    property encounter : TFhirResourceReference{TFhirEncounter} read FEncounter write SetEncounter;

    {@member prescription
      A link to a resource that provides the original request, instruction and authority to perform the administration.
    }
    property prescription : TFhirResourceReference{TFhirMedicationPrescription} read FPrescription write SetPrescription;

    {@member wasNotGiven
      Set this to true if the record is saying that the medication was NOT administered.
    }
    property wasNotGiven : TFhirBoolean read FWasNotGiven write SetWasNotGiven;
    {@member wasNotGivenST
      Typed access to Set this to true if the record is saying that the medication was NOT administered.
    }
    property wasNotGivenST : String read GetWasNotGivenST write SetWasNotGivenST;

    {@member reasonNotGivenList
      A code indicating why the administration has been negated.

Use only if isNegated is set to TRUE.
    }
    property reasonNotGivenList : TFhirCodeableConceptList read FReasonNotGivenList;

    {@member whenGiven
      An interval of time during which the administration takes place.  For many administrations, such as swallowing a tablet the lower and upper values of the interval will be the same.
    }
    property whenGiven : TFhirPeriod read FWhenGiven write SetWhenGiven;

    {@member medication
      Identifies the medication being administered. This is either a link to a resource representing the details of the medication or a simple attribute carrying a code that identifies the medication from a known list of medications.
    }
    property medication : TFhirResourceReference{TFhirMedication} read FMedication write SetMedication;

    {@member administrationDeviceList
      An identifier or a link to a resource that identifies a device used in administering the medication to the patient.
    }
    property administrationDeviceList : TFhirResourceReferenceList{TFhirDevice} read FAdministrationDeviceList;

    {@member dosageList
      Indicates how the medication is to be used by the patient.
    }
    property dosageList : TFhirMedicationAdministrationDosageList read FDosageList;

  end;


  {@Class TFhirMedicationDispense : TFhirResource
    Dispensing a medication to a named patient.  This includes a description of the supply provided and the instructions for administering the medication.
  }
  {!.Net HL7Connect.Fhir.MedicationDispense}
  TFhirMedicationDispense = class (TFhirResource)
  private
    FIdentifier : TFhirIdentifier;
    FStatus : TFhirEnum;
    FPatient : TFhirResourceReference{TFhirPatient};
    FDispenser : TFhirResourceReference{TFhirPractitioner};
    FauthorizingPrescriptionList : TFhirResourceReferenceList{TFhirMedicationPrescription};
    FdispenseList : TFhirMedicationDispenseDispenseList;
    FSubstitution : TFhirMedicationDispenseSubstitution;
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirMedicationDispenseStatus;
    Procedure SetStatusST(value : TFhirMedicationDispenseStatus);
    Procedure SetPatient(value : TFhirResourceReference{TFhirPatient});
    Procedure SetDispenser(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetSubstitution(value : TFhirMedicationDispenseSubstitution);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirMedicationDispense; overload;
    function Clone : TFhirMedicationDispense; overload;
    {!script show}
  published
    {@member identifier
      Identifier assigned by the dispensing facility - this is an identifier assigned outside FHIR.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member status
      A code specifying the state of the set of dispense events.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to A code specifying the state of the set of dispense events.
    }
    property statusST : TFhirMedicationDispenseStatus read GetStatusST write SetStatusST;

    {@member patient
      A link to a resource representing the person to whom the medication will be given.
    }
    property patient : TFhirResourceReference{TFhirPatient} read FPatient write SetPatient;

    {@member dispenser
      The individual reponsible for dispensing the medication.
    }
    property dispenser : TFhirResourceReference{TFhirPractitioner} read FDispenser write SetDispenser;

    {@member authorizingPrescriptionList
      Indicates the medication order that is being dispensed against.
    }
    property authorizingPrescriptionList : TFhirResourceReferenceList{TFhirMedicationPrescription} read FAuthorizingPrescriptionList;

    {@member dispenseList
      Indicates the details of the dispense event such as the days supply and quantity of medication dispensed.
    }
    property dispenseList : TFhirMedicationDispenseDispenseList read FDispenseList;

    {@member substitution
      Indicates whether or not substitution was made as part of the dispense.  In some cases substitution will be expected but doesn't happen, in other cases substitution is not expected but does happen.  This block explains what substitition did or did not happen and why.
    }
    property substitution : TFhirMedicationDispenseSubstitution read FSubstitution write SetSubstitution;

  end;


  {@Class TFhirMedicationPrescription : TFhirResource
    An order for both supply of the medication and the instructions for administration of the medicine to a patient.
  }
  {!.Net HL7Connect.Fhir.MedicationPrescription}
  TFhirMedicationPrescription = class (TFhirResource)
  private
    FidentifierList : TFhirIdentifierList;
    FDateWritten : TFhirDateTime;
    FStatus : TFhirEnum;
    FPatient : TFhirResourceReference{TFhirPatient};
    FPrescriber : TFhirResourceReference{TFhirPractitioner};
    FEncounter : TFhirResourceReference{TFhirEncounter};
    FReasonForPrescribing : TFhirType;
    FMedication : TFhirResourceReference{TFhirMedication};
    FdosageInstructionList : TFhirMedicationPrescriptionDosageInstructionList;
    FDispense : TFhirMedicationPrescriptionDispense;
    FSubstitution : TFhirMedicationPrescriptionSubstitution;
    Procedure SetDateWritten(value : TFhirDateTime);
    Function GetDateWrittenST : TDateAndTime;
    Procedure SetDateWrittenST(value : TDateAndTime);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirMedicationPrescriptionStatus;
    Procedure SetStatusST(value : TFhirMedicationPrescriptionStatus);
    Procedure SetPatient(value : TFhirResourceReference{TFhirPatient});
    Procedure SetPrescriber(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetEncounter(value : TFhirResourceReference{TFhirEncounter});
    Procedure SetReasonForPrescribing(value : TFhirType);
    Procedure SetMedication(value : TFhirResourceReference{TFhirMedication});
    Procedure SetDispense(value : TFhirMedicationPrescriptionDispense);
    Procedure SetSubstitution(value : TFhirMedicationPrescriptionSubstitution);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirMedicationPrescription; overload;
    function Clone : TFhirMedicationPrescription; overload;
    {!script show}
  published
    {@member identifierList
      External identifier - one that would be used by another non-FHIR system - for example a re-imbursement system might issue its own id for each prescription that is created.  This is particularly important where FHIR only provides part of an erntire workflow process where records have to be tracked through an entire system.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member dateWritten
      The date (and perhaps time) when the prescription was written.
    }
    property dateWritten : TFhirDateTime read FDateWritten write SetDateWritten;
    {@member dateWrittenST
      Typed access to The date (and perhaps time) when the prescription was written.
    }
    property dateWrittenST : TDateAndTime read GetDateWrittenST write SetDateWrittenST;

    {@member status
      A code specifying the state of the order.  Generally this will be active or completed state.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to A code specifying the state of the order.  Generally this will be active or completed state.
    }
    property statusST : TFhirMedicationPrescriptionStatus read GetStatusST write SetStatusST;

    {@member patient
      A link to a resource representing the person to whom the medication will be given.
    }
    property patient : TFhirResourceReference{TFhirPatient} read FPatient write SetPatient;

    {@member prescriber
      The healthcare professional responsible for authorising the prescription.
    }
    property prescriber : TFhirResourceReference{TFhirPractitioner} read FPrescriber write SetPrescriber;

    {@member encounter
      A link to a resource that identifies the particular occurrence of contact between patient and health care provider.
    }
    property encounter : TFhirResourceReference{TFhirEncounter} read FEncounter write SetEncounter;

    {@member reasonForPrescribing
      Can be the reason or the indication for writing the prescription.
    }
    property reasonForPrescribing : TFhirType read FReasonForPrescribing write SetReasonForPrescribing;

    {@member medication
      Identifies the medication being administered. This is either a link to a resource representing the details of the medication or a simple attribute carrying a code that identifies the medication from a known list of medications.
    }
    property medication : TFhirResourceReference{TFhirMedication} read FMedication write SetMedication;

    {@member dosageInstructionList
      Indicates how the medication is to be used by the patient.
    }
    property dosageInstructionList : TFhirMedicationPrescriptionDosageInstructionList read FDosageInstructionList;

    {@member dispense
      Deals with details of the dispense part of the order.
    }
    property dispense : TFhirMedicationPrescriptionDispense read FDispense write SetDispense;

    {@member substitution
      Indicates whether or not substitution can or should as part of the dispense.  In some cases substitution must  happen, in other cases substitution must not happen, and in others it does not matter.  This block explains the prescribers intent.  If nothing is specified substitution may be done.
    }
    property substitution : TFhirMedicationPrescriptionSubstitution read FSubstitution write SetSubstitution;

  end;


  {@Class TFhirMedicationStatement : TFhirResource
    A record of medication being taken by a patient, or that the medication has been given to a patient where the record is the result of a report from the patient, or another clinician.
  }
  {!.Net HL7Connect.Fhir.MedicationStatement}
  TFhirMedicationStatement = class (TFhirResource)
  private
    FidentifierList : TFhirIdentifierList;
    FPatient : TFhirResourceReference{TFhirPatient};
    FWasNotGiven : TFhirBoolean;
    FreasonNotGivenList : TFhirCodeableConceptList;
    FWhenGiven : TFhirPeriod;
    FMedication : TFhirResourceReference{TFhirMedication};
    FadministrationDeviceList : TFhirResourceReferenceList{TFhirDevice};
    FdosageList : TFhirMedicationStatementDosageList;
    Procedure SetPatient(value : TFhirResourceReference{TFhirPatient});
    Procedure SetWasNotGiven(value : TFhirBoolean);
    Function GetWasNotGivenST : String;
    Procedure SetWasNotGivenST(value : String);
    Procedure SetWhenGiven(value : TFhirPeriod);
    Procedure SetMedication(value : TFhirResourceReference{TFhirMedication});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirMedicationStatement; overload;
    function Clone : TFhirMedicationStatement; overload;
    {!script show}
  published
    {@member identifierList
      External identifier - FHIR will generate its own internal IDs (probably URLs) which do not need to be explicitly managed by the resource.  The identifier here is one that would be used by another non-FHIR system - for example an automated medication pump would provide a record each time it operated; an administration while the patient was off the ward might be made with a different system and entered after the event.  Particularly important if these records have to be updated.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member patient
      A link to a resource representing the person to whom the medication was given.
    }
    property patient : TFhirResourceReference{TFhirPatient} read FPatient write SetPatient;

    {@member wasNotGiven
      Set this to true if the record is saying that the medication was NOT administered.
    }
    property wasNotGiven : TFhirBoolean read FWasNotGiven write SetWasNotGiven;
    {@member wasNotGivenST
      Typed access to Set this to true if the record is saying that the medication was NOT administered.
    }
    property wasNotGivenST : String read GetWasNotGivenST write SetWasNotGivenST;

    {@member reasonNotGivenList
      A code indicating why the administration has been negated.

Use only if isNegated is set to TRUE.
    }
    property reasonNotGivenList : TFhirCodeableConceptList read FReasonNotGivenList;

    {@member whenGiven
      An interval of time during which the administration takes place.  For many administrations, such as swallowing a tablet the lower and upper values of the interval will be the same.
    }
    property whenGiven : TFhirPeriod read FWhenGiven write SetWhenGiven;

    {@member medication
      Identifies the medication being administered. This is either a link to a resource representing the details of the medication or a simple attribute carrying a code that identifies the medication from a known list of medications.
    }
    property medication : TFhirResourceReference{TFhirMedication} read FMedication write SetMedication;

    {@member administrationDeviceList
      An identifier or a link to a resource that identifies a device used in administering the medication to the patient.
    }
    property administrationDeviceList : TFhirResourceReferenceList{TFhirDevice} read FAdministrationDeviceList;

    {@member dosageList
      Indicates how the medication is to be used by the patient.
    }
    property dosageList : TFhirMedicationStatementDosageList read FDosageList;

  end;


  {@Class TFhirMessage : TFhirResource
    The root for a transmission either requesting or responding to an action.  The resource(s) that are the subject of the action as well as other Information related to the action are typically transmitted in a bundle of which the Message resource instance is the first resource in the bundle.
  }
  {!.Net HL7Connect.Fhir.Message}
  TFhirMessage = class (TFhirResource)
  private
    FIdentifier : TFhirId;
    FTimestamp : TFhirInstant;
    FEvent : TFhirCode;
    FResponse : TFhirMessageResponse;
    FSource : TFhirMessageSource;
    FDestination : TFhirMessageDestination;
    FEnterer : TFhirResourceReference{TFhirPractitioner};
    FAuthor : TFhirResourceReference{TFhirPractitioner};
    FReceiver : TFhirResourceReference{Resource};
    FResponsible : TFhirResourceReference{Resource};
    FEffective : TFhirPeriod;
    FReason : TFhirCodeableConcept;
    FdataList : TFhirResourceReferenceList{Resource};
    Procedure SetIdentifier(value : TFhirId);
    Function GetIdentifierST : String;
    Procedure SetIdentifierST(value : String);
    Procedure SetTimestamp(value : TFhirInstant);
    Function GetTimestampST : TDateAndTime;
    Procedure SetTimestampST(value : TDateAndTime);
    Procedure SetEvent(value : TFhirCode);
    Function GetEventST : String;
    Procedure SetEventST(value : String);
    Procedure SetResponse(value : TFhirMessageResponse);
    Procedure SetSource(value : TFhirMessageSource);
    Procedure SetDestination(value : TFhirMessageDestination);
    Procedure SetEnterer(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetAuthor(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetReceiver(value : TFhirResourceReference{Resource});
    Procedure SetResponsible(value : TFhirResourceReference{Resource});
    Procedure SetEffective(value : TFhirPeriod);
    Procedure SetReason(value : TFhirCodeableConcept);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirMessage; overload;
    function Clone : TFhirMessage; overload;
    {!script show}
  published
    {@member identifier
      The identifier of this message.
    }
    property identifier : TFhirId read FIdentifier write SetIdentifier;
    {@member identifierST
      Typed access to The identifier of this message.
    }
    property identifierST : String read GetIdentifierST write SetIdentifierST;

    {@member timestamp
      The time that the message was sent.
    }
    property timestamp : TFhirInstant read FTimestamp write SetTimestamp;
    {@member timestampST
      Typed access to The time that the message was sent.
    }
    property timestampST : TDateAndTime read GetTimestampST write SetTimestampST;

    {@member event
      Code that identifies the event this message represents and connects it with the event definition in the FHIR specification.
    }
    property event : TFhirCode read FEvent write SetEvent;
    {@member eventST
      Typed access to Code that identifies the event this message represents and connects it with the event definition in the FHIR specification.
    }
    property eventST : String read GetEventST write SetEventST;

    {@member response
      Information about the message that this message is a response to.  Only present if this message is a response.
    }
    property response : TFhirMessageResponse read FResponse write SetResponse;

    {@member source
      The source application from which this message originated.
    }
    property source : TFhirMessageSource read FSource write SetSource;

    {@member destination
      The destination application which the message is intended for.
    }
    property destination : TFhirMessageDestination read FDestination write SetDestination;

    {@member enterer
      The person or device that performed the data entry leading to this message. Where there is more than one candidate, pick the most proximal to the message. Can provide other enterers in extensions.
    }
    property enterer : TFhirResourceReference{TFhirPractitioner} read FEnterer write SetEnterer;

    {@member author
      The logical author of the message - the person or device that decided the described event should happen. Where there is more than one candidate, pick the most proximal to the Message. Can provide other authors in extensions.
    }
    property author : TFhirResourceReference{TFhirPractitioner} read FAuthor write SetAuthor;

    {@member receiver
      Allows data conveyed by a message to be addressed to a particular person or department when routing to a specific application isn't sufficient.
    }
    property receiver : TFhirResourceReference{Resource} read FReceiver write SetReceiver;

    {@member responsible
      The person or organization that accepts overall responsibility for the contents of the Message. The implication is that the message event happened under the policies of the responsible party.
    }
    property responsible : TFhirResourceReference{Resource} read FResponsible write SetResponsible;

    {@member effective
      The effective time - the real world time of the event that the message represents. Usually this is just a starting time, but some message events also have an end time (do x for period y).
    }
    property effective : TFhirPeriod read FEffective write SetEffective;

    {@member reason
      Coded indication of the cause for the event - indicates  a reason for the occurance of the event that is a focus of this message.
    }
    property reason : TFhirCodeableConcept read FReason write SetReason;

    {@member dataList
      The actual data of the message - a reference to the root/focus class of the event.
    }
    property dataList : TFhirResourceReferenceList{Resource} read FDataList;

  end;


  {@Class TFhirObservation : TFhirResource
    Simple assertions and measurements made about a patient, device or other subject.
  }
  {!.Net HL7Connect.Fhir.Observation}
  TFhirObservation = class (TFhirResource)
  private
    FName : TFhirCodeableConcept;
    FValue : TFhirType;
    FInterpretation : TFhirCodeableConcept;
    FComments : TFhirString;
    FApplies : TFhirType;
    FIssued : TFhirInstant;
    FStatus : TFhirEnum;
    FReliability : TFhirEnum;
    FBodySite : TFhirCodeableConcept;
    FMethod : TFhirCodeableConcept;
    FIdentifier : TFhirIdentifier;
    FSubject : TFhirResourceReference{Resource};
    FPerformer : TFhirResourceReference{Resource};
    FreferenceRangeList : TFhirObservationReferenceRangeList;
    FcomponentList : TFhirObservationComponentList;
    Procedure SetName(value : TFhirCodeableConcept);
    Procedure SetValue(value : TFhirType);
    Procedure SetInterpretation(value : TFhirCodeableConcept);
    Procedure SetComments(value : TFhirString);
    Function GetCommentsST : String;
    Procedure SetCommentsST(value : String);
    Procedure SetApplies(value : TFhirType);
    Procedure SetIssued(value : TFhirInstant);
    Function GetIssuedST : TDateAndTime;
    Procedure SetIssuedST(value : TDateAndTime);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirObservationStatus;
    Procedure SetStatusST(value : TFhirObservationStatus);
    Procedure SetReliability(value : TFhirEnum);
    Function GetReliabilityST : TFhirObservationReliability;
    Procedure SetReliabilityST(value : TFhirObservationReliability);
    Procedure SetBodySite(value : TFhirCodeableConcept);
    Procedure SetMethod(value : TFhirCodeableConcept);
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetSubject(value : TFhirResourceReference{Resource});
    Procedure SetPerformer(value : TFhirResourceReference{Resource});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirObservation; overload;
    function Clone : TFhirObservation; overload;
    {!script show}
  published
    {@member name
      Identifies what type of observation was performed.
    }
    property name : TFhirCodeableConcept read FName write SetName;

    {@member value
      The information determined as a result of making the observation.
    }
    property value : TFhirType read FValue write SetValue;

    {@member interpretation
      The assessment made based on the result of the observation.
    }
    property interpretation : TFhirCodeableConcept read FInterpretation write SetInterpretation;

    {@member comments
      May include statements about significant, unexpected or unreliable values, or information about the source of the value where this may be relevant to the interpretation of the result.
    }
    property comments : TFhirString read FComments write SetComments;
    {@member commentsST
      Typed access to May include statements about significant, unexpected or unreliable values, or information about the source of the value where this may be relevant to the interpretation of the result.
    }
    property commentsST : String read GetCommentsST write SetCommentsST;

    {@member applies
      The time or time-period the observed value is asserted as being true. For biological subjects - e.g. human patients - this is usually called the "physiologically relevant time".
    }
    property applies : TFhirType read FApplies write SetApplies;

    {@member issued
      Date/Time this was made available.
    }
    property issued : TFhirInstant read FIssued write SetIssued;
    {@member issuedST
      Typed access to Date/Time this was made available.
    }
    property issuedST : TDateAndTime read GetIssuedST write SetIssuedST;

    {@member status
      The status of the result value.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to The status of the result value.
    }
    property statusST : TFhirObservationStatus read GetStatusST write SetStatusST;

    {@member reliability
      An estimate of the degree to which quality issues have impacted on the value reported.
    }
    property reliability : TFhirEnum read FReliability write SetReliability;
    {@member reliabilityST
      Typed access to An estimate of the degree to which quality issues have impacted on the value reported.
    }
    property reliabilityST : TFhirObservationReliability read GetReliabilityST write SetReliabilityST;

    {@member bodySite
      Indicates where on the subject's body the observation was made.
    }
    property bodySite : TFhirCodeableConcept read FBodySite write SetBodySite;

    {@member method
      Indicates the mechanism used to perform the observation.
    }
    property method : TFhirCodeableConcept read FMethod write SetMethod;

    {@member identifier
      A unique identifier for the simple observation.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member subject
      The thing the observation is being made about.
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member performer
      Who was responsible for asserting the observed value as "true".
    }
    property performer : TFhirResourceReference{Resource} read FPerformer write SetPerformer;

    {@member referenceRangeList
      Guidance on how to interpret the value by comparison to a normal or recommended range.
    }
    property referenceRangeList : TFhirObservationReferenceRangeList read FReferenceRangeList;

    {@member componentList
      Component observation.
    }
    property componentList : TFhirObservationComponentList read FComponentList;

  end;


  {@Class TFhirOperationOutcome : TFhirResource
    A collection of error, warning or information messages that result from a system action.
  }
  {!.Net HL7Connect.Fhir.OperationOutcome}
  TFhirOperationOutcome = class (TFhirResource)
  private
    FissueList : TFhirOperationOutcomeIssueList;
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirOperationOutcome; overload;
    function Clone : TFhirOperationOutcome; overload;
    {!script show}
  published
    {@member issueList
      An error, warning or information message that results from a system action.
    }
    property issueList : TFhirOperationOutcomeIssueList read FIssueList;

  end;


  {@Class TFhirOrder : TFhirResource
    A request to perform an action.
  }
  {!.Net HL7Connect.Fhir.Order}
  TFhirOrder = class (TFhirResource)
  private
    FDate : TFhirDateTime;
    FSubject : TFhirResourceReference{TFhirPatient};
    FSource : TFhirResourceReference{TFhirPractitioner};
    FTarget : TFhirResourceReference{Resource};
    FReason : TFhirString;
    FAuthority : TFhirResourceReference{Resource};
    FWhen : TFhirOrderWhen;
    FdetailList : TFhirResourceReferenceList{Resource};
    Procedure SetDate(value : TFhirDateTime);
    Function GetDateST : TDateAndTime;
    Procedure SetDateST(value : TDateAndTime);
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
    Procedure SetSource(value : TFhirResourceReference{TFhirPractitioner});
    Procedure SetTarget(value : TFhirResourceReference{Resource});
    Procedure SetReason(value : TFhirString);
    Function GetReasonST : String;
    Procedure SetReasonST(value : String);
    Procedure SetAuthority(value : TFhirResourceReference{Resource});
    Procedure SetWhen(value : TFhirOrderWhen);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirOrder; overload;
    function Clone : TFhirOrder; overload;
    {!script show}
  published
    {@member date
      When the order was made.
    }
    property date : TFhirDateTime read FDate write SetDate;
    {@member dateST
      Typed access to When the order was made.
    }
    property dateST : TDateAndTime read GetDateST write SetDateST;

    {@member subject
      Patient this order is about.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member source
      Who initiated the order.
    }
    property source : TFhirResourceReference{TFhirPractitioner} read FSource write SetSource;

    {@member target
      Who is intended to fulfill the order.
    }
    property target : TFhirResourceReference{Resource} read FTarget write SetTarget;

    {@member reason
      Text - why the order was made.
    }
    property reason : TFhirString read FReason write SetReason;
    {@member reasonST
      Typed access to Text - why the order was made.
    }
    property reasonST : String read GetReasonST write SetReasonST;

    {@member authority
      If required by policy.
    }
    property authority : TFhirResourceReference{Resource} read FAuthority write SetAuthority;

    {@member when
      When order should be fulfilled.
    }
    property when : TFhirOrderWhen read FWhen write SetWhen;

    {@member detailList
      What action is being ordered.
    }
    property detailList : TFhirResourceReferenceList{Resource} read FDetailList;

  end;


  {@Class TFhirOrderResponse : TFhirResource
    A response to an order.
  }
  {!.Net HL7Connect.Fhir.OrderResponse}
  TFhirOrderResponse = class (TFhirResource)
  private
    FRequest : TFhirResourceReference{TFhirOrder};
    FDate : TFhirDateTime;
    FWho : TFhirResourceReference{Resource};
    FAuthority : TFhirResourceReference{Resource};
    FCost : TFhirQuantity;
    FCode : TFhirEnum;
    FDescription : TFhirString;
    FfulfillmentList : TFhirResourceReferenceList{Resource};
    Procedure SetRequest(value : TFhirResourceReference{TFhirOrder});
    Procedure SetDate(value : TFhirDateTime);
    Function GetDateST : TDateAndTime;
    Procedure SetDateST(value : TDateAndTime);
    Procedure SetWho(value : TFhirResourceReference{Resource});
    Procedure SetAuthority(value : TFhirResourceReference{Resource});
    Procedure SetCost(value : TFhirQuantity);
    Procedure SetCode(value : TFhirEnum);
    Function GetCodeST : TFhirOrderOutcomeCode;
    Procedure SetCodeST(value : TFhirOrderOutcomeCode);
    Procedure SetDescription(value : TFhirString);
    Function GetDescriptionST : String;
    Procedure SetDescriptionST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirOrderResponse; overload;
    function Clone : TFhirOrderResponse; overload;
    {!script show}
  published
    {@member request
      The order that this is a response to.
    }
    property request : TFhirResourceReference{TFhirOrder} read FRequest write SetRequest;

    {@member date
      When the response was made.
    }
    property date : TFhirDateTime read FDate write SetDate;
    {@member dateST
      Typed access to When the response was made.
    }
    property dateST : TDateAndTime read GetDateST write SetDateST;

    {@member who
      Who made the response.
    }
    property who : TFhirResourceReference{Resource} read FWho write SetWho;

    {@member authority
      If required by policy.
    }
    property authority : TFhirResourceReference{Resource} read FAuthority write SetAuthority;

    {@member cost
      How much the request will/did cost.
    }
    property cost : TFhirQuantity read FCost write SetCost;

    {@member code
      The status of the response.
    }
    property code : TFhirEnum read FCode write SetCode;
    {@member codeST
      Typed access to The status of the response.
    }
    property codeST : TFhirOrderOutcomeCode read GetCodeST write SetCodeST;

    {@member description
      Additional description of the response.
    }
    property description : TFhirString read FDescription write SetDescription;
    {@member descriptionST
      Typed access to Additional description of the response.
    }
    property descriptionST : String read GetDescriptionST write SetDescriptionST;

    {@member fulfillmentList
      Details of the outcome of performing the order.
    }
    property fulfillmentList : TFhirResourceReferenceList{Resource} read FFulfillmentList;

  end;


  {@Class TFhirOrganization : TFhirResource
    A formally or informally recognized grouping of people or organizations formed for the purpose of achieving some form of collective action.  Includes companies, institutions, corporations, departments, community groups, healthcare practice groups, etc.
  }
  {!.Net HL7Connect.Fhir.Organization}
  TFhirOrganization = class (TFhirResource)
  private
    FidentifierList : TFhirIdentifierList;
    FName : TFhirString;
    FType_ : TFhirCodeableConcept;
    FtelecomList : TFhirContactList;
    FaddressList : TFhirAddressList;
    FPartOf : TFhirResourceReference{TFhirOrganization};
    FcontactList : TFhirOrganizationContactList;
    FActive : TFhirBoolean;
    Procedure SetName(value : TFhirString);
    Function GetNameST : String;
    Procedure SetNameST(value : String);
    Procedure SetType_(value : TFhirCodeableConcept);
    Procedure SetPartOf(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetActive(value : TFhirBoolean);
    Function GetActiveST : String;
    Procedure SetActiveST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirOrganization; overload;
    function Clone : TFhirOrganization; overload;
    {!script show}
  published
    {@member identifierList
      Identifier for the organization that is used to identify the organization across multiple disparate systems.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member name
      A name associated with the organization.
    }
    property name : TFhirString read FName write SetName;
    {@member nameST
      Typed access to A name associated with the organization.
    }
    property nameST : String read GetNameST write SetNameST;

    {@member type_
      The kind of organization that this is.
    }
    property type_ : TFhirCodeableConcept read FType_ write SetType_;

    {@member telecomList
      A contact detail for the organization.
    }
    property telecomList : TFhirContactList read FTelecomList;

    {@member addressList
      An address for the organization.
    }
    property addressList : TFhirAddressList read FAddressList;

    {@member partOf
      The organization of which this organization forms a part.
    }
    property partOf : TFhirResourceReference{TFhirOrganization} read FPartOf write SetPartOf;

    {@member contactList
      Contact for the organization for a certain purpose.
    }
    property contactList : TFhirOrganizationContactList read FContactList;

    {@member active
      Whether the organization's record is still in active use.
    }
    property active : TFhirBoolean read FActive write SetActive;
    {@member activeST
      Typed access to Whether the organization's record is still in active use.
    }
    property activeST : String read GetActiveST write SetActiveST;

  end;


  {@Class TFhirOther : TFhirResource
    Other is a conformant for handling resource concepts not yet defined for FHIR or outside HL7's scope of interest.
  }
  {!.Net HL7Connect.Fhir.Other}
  TFhirOther = class (TFhirResource)
  private
    FCode : TFhirCodeableConcept;
    FSubject : TFhirResourceReference{Resource};
    FAuthor : TFhirResourceReference{Resource};
    FCreated : TFhirDate;
    Procedure SetCode(value : TFhirCodeableConcept);
    Procedure SetSubject(value : TFhirResourceReference{Resource});
    Procedure SetAuthor(value : TFhirResourceReference{Resource});
    Procedure SetCreated(value : TFhirDate);
    Function GetCreatedST : TDateAndTime;
    Procedure SetCreatedST(value : TDateAndTime);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirOther; overload;
    function Clone : TFhirOther; overload;
    {!script show}
  published
    {@member code
      Identifies the 'type' of resource - equivalent to the resource name for other resources.
    }
    property code : TFhirCodeableConcept read FCode write SetCode;

    {@member subject
      Identifies the patient, practitioner, device or any other resource that is the "focus" of this resoruce.
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member author
      Indicates who was responsible for creating the resource instance.
    }
    property author : TFhirResourceReference{Resource} read FAuthor write SetAuthor;

    {@member created
      Identifies when the resource was first created.
    }
    property created : TFhirDate read FCreated write SetCreated;
    {@member createdST
      Typed access to Identifies when the resource was first created.
    }
    property createdST : TDateAndTime read GetCreatedST write SetCreatedST;

  end;


  {@Class TFhirPatient : TFhirResource
    Demographics and other administrative information about a person or animal receiving care or other health-related services.
  }
  {!.Net HL7Connect.Fhir.Patient}
  TFhirPatient = class (TFhirResource)
  private
    FidentifierList : TFhirIdentifierList;
    FnameList : TFhirHumanNameList;
    FtelecomList : TFhirContactList;
    FGender : TFhirCodeableConcept;
    FBirthDate : TFhirDateTime;
    FDeceased : TFhirType;
    FaddressList : TFhirAddressList;
    FMaritalStatus : TFhirCodeableConcept;
    FMultipleBirth : TFhirType;
    FphotoList : TFhirAttachmentList;
    FcontactList : TFhirPatientContactList;
    FAnimal : TFhirPatientAnimal;
    FcommunicationList : TFhirCodeableConceptList;
    FProvider : TFhirResourceReference{TFhirOrganization};
    Flink_List : TFhirResourceReferenceList{TFhirPatient};
    FActive : TFhirBoolean;
    Procedure SetGender(value : TFhirCodeableConcept);
    Procedure SetBirthDate(value : TFhirDateTime);
    Function GetBirthDateST : TDateAndTime;
    Procedure SetBirthDateST(value : TDateAndTime);
    Procedure SetDeceased(value : TFhirType);
    Procedure SetMaritalStatus(value : TFhirCodeableConcept);
    Procedure SetMultipleBirth(value : TFhirType);
    Procedure SetAnimal(value : TFhirPatientAnimal);
    Procedure SetProvider(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetActive(value : TFhirBoolean);
    Function GetActiveST : String;
    Procedure SetActiveST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirPatient; overload;
    function Clone : TFhirPatient; overload;
    {!script show}
  published
    {@member identifierList
      An identifier that applies to this person as a patient.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member nameList
      A name associated with the individual.
    }
    property nameList : TFhirHumanNameList read FNameList;

    {@member telecomList
      A contact detail (e.g. a telephone number or an email address) by which the individual may be contacted.
    }
    property telecomList : TFhirContactList read FTelecomList;

    {@member gender
      Administrative Gender - the gender that the patient is considered to have for administration and record keeping purposes.
    }
    property gender : TFhirCodeableConcept read FGender write SetGender;

    {@member birthDate
      The date and time of birth for the individual.
    }
    property birthDate : TFhirDateTime read FBirthDate write SetBirthDate;
    {@member birthDateST
      Typed access to The date and time of birth for the individual.
    }
    property birthDateST : TDateAndTime read GetBirthDateST write SetBirthDateST;

    {@member deceased
      Indicates if the individual is deceased or not.
    }
    property deceased : TFhirType read FDeceased write SetDeceased;

    {@member addressList
      Addresses for the individual.
    }
    property addressList : TFhirAddressList read FAddressList;

    {@member maritalStatus
      This field contains a patient's most recent marital (civil) status.
    }
    property maritalStatus : TFhirCodeableConcept read FMaritalStatus write SetMaritalStatus;

    {@member multipleBirth
      Indicates whether the patient is part of a multiple or indicates the actual birth order.
    }
    property multipleBirth : TFhirType read FMultipleBirth write SetMultipleBirth;

    {@member photoList
      Image of the person.
    }
    property photoList : TFhirAttachmentList read FPhotoList;

    {@member contactList
      A contact party (e.g. guardian, partner, friend) for the patient.
    }
    property contactList : TFhirPatientContactList read FContactList;

    {@member animal
      This element has a value if the patient is an animal.
    }
    property animal : TFhirPatientAnimal read FAnimal write SetAnimal;

    {@member communicationList
      Languages which may be used to communicate with the patient.
    }
    property communicationList : TFhirCodeableConceptList read FCommunicationList;

    {@member provider
      The provider for whom this is a patient record.
    }
    property provider : TFhirResourceReference{TFhirOrganization} read FProvider write SetProvider;

    {@member link_List
      A linked patient resource is a resource that concerns the same patient. Resources are linked after it is realized that at least one was created in error.
    }
    property link_List : TFhirResourceReferenceList{TFhirPatient} read FLink_List;

    {@member active
      Whether this patient record is in active use.
    }
    property active : TFhirBoolean read FActive write SetActive;
    {@member activeST
      Typed access to Whether this patient record is in active use.
    }
    property activeST : String read GetActiveST write SetActiveST;

  end;


  {@Class TFhirPractitioner : TFhirResource
    Demographics and qualification information for an individual who is directly or indirectly involved in the provisioning of healthcare.
  }
  {!.Net HL7Connect.Fhir.Practitioner}
  TFhirPractitioner = class (TFhirResource)
  private
    FidentifierList : TFhirIdentifierList;
    FName : TFhirHumanName;
    FtelecomList : TFhirContactList;
    FAddress : TFhirAddress;
    FGender : TFhirCodeableConcept;
    FBirthDate : TFhirDateTime;
    FphotoList : TFhirAttachmentList;
    FOrganization : TFhirResourceReference{TFhirOrganization};
    FroleList : TFhirCodeableConceptList;
    FspecialtyList : TFhirCodeableConceptList;
    FPeriod : TFhirPeriod;
    FqualificationList : TFhirPractitionerQualificationList;
    FcommunicationList : TFhirCodeableConceptList;
    Procedure SetName(value : TFhirHumanName);
    Procedure SetAddress(value : TFhirAddress);
    Procedure SetGender(value : TFhirCodeableConcept);
    Procedure SetBirthDate(value : TFhirDateTime);
    Function GetBirthDateST : TDateAndTime;
    Procedure SetBirthDateST(value : TDateAndTime);
    Procedure SetOrganization(value : TFhirResourceReference{TFhirOrganization});
    Procedure SetPeriod(value : TFhirPeriod);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirPractitioner; overload;
    function Clone : TFhirPractitioner; overload;
    {!script show}
  published
    {@member identifierList
      An identifier that applies to this person in this role.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member name
      A name associated with the person.
    }
    property name : TFhirHumanName read FName write SetName;

    {@member telecomList
      A contact detail for the practitioner, e.g. a telephone number or an email address.
    }
    property telecomList : TFhirContactList read FTelecomList;

    {@member address
      One or more addresses where the practitioner can be found or visited.
    }
    property address : TFhirAddress read FAddress write SetAddress;

    {@member gender
      Administrative Gender - the gender that the person is considered to have for administration and record keeping purposes.
    }
    property gender : TFhirCodeableConcept read FGender write SetGender;

    {@member birthDate
      The date and time of birth for the practitioner.
    }
    property birthDate : TFhirDateTime read FBirthDate write SetBirthDate;
    {@member birthDateST
      Typed access to The date and time of birth for the practitioner.
    }
    property birthDateST : TDateAndTime read GetBirthDateST write SetBirthDateST;

    {@member photoList
      Image of the person.
    }
    property photoList : TFhirAttachmentList read FPhotoList;

    {@member organization
      The organization that the practitioner represents.
    }
    property organization : TFhirResourceReference{TFhirOrganization} read FOrganization write SetOrganization;

    {@member roleList
      The way in which the person represents the organization - what role do they have?.
    }
    property roleList : TFhirCodeableConceptList read FRoleList;

    {@member specialtyList
      Specific specialty of the practitioner.
    }
    property specialtyList : TFhirCodeableConceptList read FSpecialtyList;

    {@member period
      The period during which the person is authorized to perform the service.
    }
    property period : TFhirPeriod read FPeriod write SetPeriod;

    {@member qualificationList
      Qualifications relevant to the provided service.
    }
    property qualificationList : TFhirPractitionerQualificationList read FQualificationList;

    {@member communicationList
      A language the practitioner is able to use in patient communication.
    }
    property communicationList : TFhirCodeableConceptList read FCommunicationList;

  end;


  {@Class TFhirProcedure : TFhirResource
    An action that is performed on a patient. This can be a physical 'thing' like an operation, or less invasive like counseling or hypnotherapy.
  }
  {!.Net HL7Connect.Fhir.Procedure}
  TFhirProcedure = class (TFhirResource)
  private
    FSubject : TFhirResourceReference{TFhirPatient};
    FType_ : TFhirCodeableConcept;
    FbodySiteList : TFhirCodeableConceptList;
    FIndication : TFhirString;
    FperformerList : TFhirProcedurePerformerList;
    FDate : TFhirPeriod;
    FEncounter : TFhirResourceReference{TFhirEncounter};
    FOutcome : TFhirString;
    FreportList : TFhirResourceReferenceList{TFhirDiagnosticReport};
    FComplication : TFhirString;
    FFollowUp : TFhirString;
    FrelatedItemList : TFhirProcedureRelatedItemList;
    FNotes : TFhirString;
    Procedure SetSubject(value : TFhirResourceReference{TFhirPatient});
    Procedure SetType_(value : TFhirCodeableConcept);
    Procedure SetIndication(value : TFhirString);
    Function GetIndicationST : String;
    Procedure SetIndicationST(value : String);
    Procedure SetDate(value : TFhirPeriod);
    Procedure SetEncounter(value : TFhirResourceReference{TFhirEncounter});
    Procedure SetOutcome(value : TFhirString);
    Function GetOutcomeST : String;
    Procedure SetOutcomeST(value : String);
    Procedure SetComplication(value : TFhirString);
    Function GetComplicationST : String;
    Procedure SetComplicationST(value : String);
    Procedure SetFollowUp(value : TFhirString);
    Function GetFollowUpST : String;
    Procedure SetFollowUpST(value : String);
    Procedure SetNotes(value : TFhirString);
    Function GetNotesST : String;
    Procedure SetNotesST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirProcedure; overload;
    function Clone : TFhirProcedure; overload;
    {!script show}
  published
    {@member subject
      The person on whom the procedure was performed.
    }
    property subject : TFhirResourceReference{TFhirPatient} read FSubject write SetSubject;

    {@member type_
      The specific procedure that is performed.
    }
    property type_ : TFhirCodeableConcept read FType_ write SetType_;

    {@member bodySiteList
      Detailed and structured anatomical location information. Multiple locations are allowed - e.g. multiple punch biopsies of a lesion.
    }
    property bodySiteList : TFhirCodeableConceptList read FBodySiteList;

    {@member indication
      The reason why the procedure was performed. This may be due to a Condition, may be coded entity of some type, or may simply be present as text.
    }
    property indication : TFhirString read FIndication write SetIndication;
    {@member indicationST
      Typed access to The reason why the procedure was performed. This may be due to a Condition, may be coded entity of some type, or may simply be present as text.
    }
    property indicationST : String read GetIndicationST write SetIndicationST;

    {@member performerList
      Limited to 'real' people rather than equipment.
    }
    property performerList : TFhirProcedurePerformerList read FPerformerList;

    {@member date
      The dates over which the period was performed. Allows a period to support complex procedures that span more that one date, and also allows for the length of the procedure to be captured.
    }
    property date : TFhirPeriod read FDate write SetDate;

    {@member encounter
      The encounter during which the procedure was performed.
    }
    property encounter : TFhirResourceReference{TFhirEncounter} read FEncounter write SetEncounter;

    {@member outcome
      What was the outcome of the procedure - did it resolve reasons why the procedure was performed?.
    }
    property outcome : TFhirString read FOutcome write SetOutcome;
    {@member outcomeST
      Typed access to What was the outcome of the procedure - did it resolve reasons why the procedure was performed?.
    }
    property outcomeST : String read GetOutcomeST write SetOutcomeST;

    {@member reportList
      This could be a histology result. There could potentially be multiple reports - e.g. if this was a procedure that made multiple biopsies.
    }
    property reportList : TFhirResourceReferenceList{TFhirDiagnosticReport} read FReportList;

    {@member complication
      Any complications that occurred during the procedure, or in the immediate post-operative period. These are generally tracked separately from the notes, which typically will describe the procedure itself rather than any 'post procedure' issues.
    }
    property complication : TFhirString read FComplication write SetComplication;
    {@member complicationST
      Typed access to Any complications that occurred during the procedure, or in the immediate post-operative period. These are generally tracked separately from the notes, which typically will describe the procedure itself rather than any 'post procedure' issues.
    }
    property complicationST : String read GetComplicationST write SetComplicationST;

    {@member followUp
      If the procedure required specific follow up - e.g. removal of sutures. The followup may be represented as a simple note, or potentially could be more complex in which case the CarePlan resource can be used.
    }
    property followUp : TFhirString read FFollowUp write SetFollowUp;
    {@member followUpST
      Typed access to If the procedure required specific follow up - e.g. removal of sutures. The followup may be represented as a simple note, or potentially could be more complex in which case the CarePlan resource can be used.
    }
    property followUpST : String read GetFollowUpST write SetFollowUpST;

    {@member relatedItemList
      Procedures may be related to other items such as procedures or medications. For example treating wound dehiscence following a previous procedure.
    }
    property relatedItemList : TFhirProcedureRelatedItemList read FRelatedItemList;

    {@member notes
      Any other notes about the procedure - e.g. the operative notes.
    }
    property notes : TFhirString read FNotes write SetNotes;
    {@member notesST
      Typed access to Any other notes about the procedure - e.g. the operative notes.
    }
    property notesST : String read GetNotesST write SetNotesST;

  end;


  {@Class TFhirProfile : TFhirResource
    A Resource Profile - a statement of use of one or more FHIR Resources.  It may include constraints on Resources and Data Types, Terminology Binding Statements and Extension Definitions.
  }
  {!.Net HL7Connect.Fhir.Profile}
  TFhirProfile = class (TFhirResource)
  private
    FIdentifier : TFhirString;
    FVersion : TFhirString;
    FName : TFhirString;
    FPublisher : TFhirString;
    FtelecomList : TFhirContactList;
    FDescription : TFhirString;
    FcodeList : TFhirCodingList;
    FStatus : TFhirEnum;
    FExperimental : TFhirBoolean;
    FDate : TFhirDateTime;
    FFhirVersion : TFhirId;
    FstructureList : TFhirProfileStructureList;
    FextensionDefnList : TFhirProfileExtensionDefnList;
    FbindingList : TFhirProfileBindingList;
    Procedure SetIdentifier(value : TFhirString);
    Function GetIdentifierST : String;
    Procedure SetIdentifierST(value : String);
    Procedure SetVersion(value : TFhirString);
    Function GetVersionST : String;
    Procedure SetVersionST(value : String);
    Procedure SetName(value : TFhirString);
    Function GetNameST : String;
    Procedure SetNameST(value : String);
    Procedure SetPublisher(value : TFhirString);
    Function GetPublisherST : String;
    Procedure SetPublisherST(value : String);
    Procedure SetDescription(value : TFhirString);
    Function GetDescriptionST : String;
    Procedure SetDescriptionST(value : String);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirResourceProfileStatus;
    Procedure SetStatusST(value : TFhirResourceProfileStatus);
    Procedure SetExperimental(value : TFhirBoolean);
    Function GetExperimentalST : String;
    Procedure SetExperimentalST(value : String);
    Procedure SetDate(value : TFhirDateTime);
    Function GetDateST : TDateAndTime;
    Procedure SetDateST(value : TDateAndTime);
    Procedure SetFhirVersion(value : TFhirId);
    Function GetFhirVersionST : String;
    Procedure SetFhirVersionST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirProfile; overload;
    function Clone : TFhirProfile; overload;
    {!script show}
  published
    {@member identifier
      The identifier that is used to identify this profile when it is referenced in a specification, model, design or an instance  (should be globally unique OID, UUID, or URI).
    }
    property identifier : TFhirString read FIdentifier write SetIdentifier;
    {@member identifierST
      Typed access to The identifier that is used to identify this profile when it is referenced in a specification, model, design or an instance  (should be globally unique OID, UUID, or URI).
    }
    property identifierST : String read GetIdentifierST write SetIdentifierST;

    {@member version
      The identifier that is used to identify this version of the profile when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the profile author manually and the value should be a timestamp.
    }
    property version : TFhirString read FVersion write SetVersion;
    {@member versionST
      Typed access to The identifier that is used to identify this version of the profile when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the profile author manually and the value should be a timestamp.
    }
    property versionST : String read GetVersionST write SetVersionST;

    {@member name
      A free text natural language name identifying the Profile.
    }
    property name : TFhirString read FName write SetName;
    {@member nameST
      Typed access to A free text natural language name identifying the Profile.
    }
    property nameST : String read GetNameST write SetNameST;

    {@member publisher
      Details of the individual or organization who accepts responsibility for publishing the profile.
    }
    property publisher : TFhirString read FPublisher write SetPublisher;
    {@member publisherST
      Typed access to Details of the individual or organization who accepts responsibility for publishing the profile.
    }
    property publisherST : String read GetPublisherST write SetPublisherST;

    {@member telecomList
      Contact details to assist a user in finding and communicating with the publisher.
    }
    property telecomList : TFhirContactList read FTelecomList;

    {@member description
      A free text natural language description of the profile and its use.
    }
    property description : TFhirString read FDescription write SetDescription;
    {@member descriptionST
      Typed access to A free text natural language description of the profile and its use.
    }
    property descriptionST : String read GetDescriptionST write SetDescriptionST;

    {@member codeList
      A set of terms from external terminologies that may be used to assist with indexing and searching of templates.
    }
    property codeList : TFhirCodingList read FCodeList;

    {@member status
      The status of the profile.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to The status of the profile.
    }
    property statusST : TFhirResourceProfileStatus read GetStatusST write SetStatusST;

    {@member experimental
      This profile was authored for testing purposes (or education/evaluation/marketing), and is not intended to be used for genuine usage.
    }
    property experimental : TFhirBoolean read FExperimental write SetExperimental;
    {@member experimentalST
      Typed access to This profile was authored for testing purposes (or education/evaluation/marketing), and is not intended to be used for genuine usage.
    }
    property experimentalST : String read GetExperimentalST write SetExperimentalST;

    {@member date
      The date that this version of the profile was published.
    }
    property date : TFhirDateTime read FDate write SetDate;
    {@member dateST
      Typed access to The date that this version of the profile was published.
    }
    property dateST : TDateAndTime read GetDateST write SetDateST;

    {@member fhirVersion
      The version of the FHIR specification on which this profile is based.
    }
    property fhirVersion : TFhirId read FFhirVersion write SetFhirVersion;
    {@member fhirVersionST
      Typed access to The version of the FHIR specification on which this profile is based.
    }
    property fhirVersionST : String read GetFhirVersionST write SetFhirVersionST;

    {@member structureList
      A constraint statement about what contents a resource or data type may have.
    }
    property structureList : TFhirProfileStructureList read FStructureList;

    {@member extensionDefnList
      An extension defined as part of the profile.
    }
    property extensionDefnList : TFhirProfileExtensionDefnList read FExtensionDefnList;

    {@member bindingList
      Defines a linkage between a vocabulary binding name used in the profile (or expected to be used in profile importing this one) and a value set or code list.
    }
    property bindingList : TFhirProfileBindingList read FBindingList;

  end;


  {@Class TFhirProvenance : TFhirResource
    Provenance information that describes the activity that lead to the creation of a set of resources. This information can be used to help determine their reliability or trace where the information in them came from. The focus of the provenance resource is record keeping, audit and traceability, and not explicit statements of clinical significance.
  }
  {!.Net HL7Connect.Fhir.Provenance}
  TFhirProvenance = class (TFhirResource)
  private
    FtargetList : TFhirResourceReferenceList{Resource};
    FPeriod : TFhirPeriod;
    FRecorded : TFhirInstant;
    FReason : TFhirCodeableConcept;
    FLocation : TFhirResourceReference{TFhirLocation};
    FpolicyList : TFhirUriList;
    FagentList : TFhirProvenanceAgentList;
    FentityList : TFhirProvenanceEntityList;
    FSignature : TFhirString;
    Procedure SetPeriod(value : TFhirPeriod);
    Procedure SetRecorded(value : TFhirInstant);
    Function GetRecordedST : TDateAndTime;
    Procedure SetRecordedST(value : TDateAndTime);
    Procedure SetReason(value : TFhirCodeableConcept);
    Procedure SetLocation(value : TFhirResourceReference{TFhirLocation});
    Procedure SetSignature(value : TFhirString);
    Function GetSignatureST : String;
    Procedure SetSignatureST(value : String);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirProvenance; overload;
    function Clone : TFhirProvenance; overload;
    {!script show}
  published
    {@member targetList
      The resource(s) that were generated by  the activity described in this resource. A provenance can point to more than one target if multiple resources were created/updated by the same activity.
    }
    property targetList : TFhirResourceReferenceList{Resource} read FTargetList;

    {@member period
      The period during which the activity occurred.
    }
    property period : TFhirPeriod read FPeriod write SetPeriod;

    {@member recorded
      The instant of time at which the activity was recorded.
    }
    property recorded : TFhirInstant read FRecorded write SetRecorded;
    {@member recordedST
      Typed access to The instant of time at which the activity was recorded.
    }
    property recordedST : TDateAndTime read GetRecordedST write SetRecordedST;

    {@member reason
      The reason that the activity was taking place.
    }
    property reason : TFhirCodeableConcept read FReason write SetReason;

    {@member location
      Where the activity occurred, if relevant.
    }
    property location : TFhirResourceReference{TFhirLocation} read FLocation write SetLocation;

    {@member policyList
      Policy or plan the activity was defined by. Typically, a single activity may have multiple applicable policy documents, such as patient consent, guarantor funding, etc.
    }
    property policyList : TFhirUriList read FPolicyList;

    {@member agentList
      An agent takes a role in an activity such that the agent can be assigned some degree of responsibility for the activity taking place. An agent can be a person, a piece of software, an inanimate object, an organization, or other entities that may be ascribed responsibility.
    }
    property agentList : TFhirProvenanceAgentList read FAgentList;

    {@member entityList
      An entity used in this activity.
    }
    property entityList : TFhirProvenanceEntityList read FEntityList;

    {@member signature
      A digital signature on the target resource. The signature should reference a participant by xml:id. The signature is only added to support checking cryptographic integrity of the provenance, and not to represent workflow and clinical aspects of the signing process.
    }
    property signature : TFhirString read FSignature write SetSignature;
    {@member signatureST
      Typed access to A digital signature on the target resource. The signature should reference a participant by xml:id. The signature is only added to support checking cryptographic integrity of the provenance, and not to represent workflow and clinical aspects of the signing process.
    }
    property signatureST : String read GetSignatureST write SetSignatureST;

  end;


  {@Class TFhirQuery : TFhirResource
    A description of a query with a set of parameters.
  }
  {!.Net HL7Connect.Fhir.Query}
  TFhirQuery = class (TFhirResource)
  private
    FIdentifier : TFhirUri;
    FparameterList : TFhirExtensionList;
    FResponse : TFhirQueryResponse;
    Procedure SetIdentifier(value : TFhirUri);
    Function GetIdentifierST : String;
    Procedure SetIdentifierST(value : String);
    Procedure SetResponse(value : TFhirQueryResponse);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirQuery; overload;
    function Clone : TFhirQuery; overload;
    {!script show}
  published
    {@member identifier
      Links query and its response(s).
    }
    property identifier : TFhirUri read FIdentifier write SetIdentifier;
    {@member identifierST
      Typed access to Links query and its response(s).
    }
    property identifierST : String read GetIdentifierST write SetIdentifierST;

    {@member parameterList
      Set of query parameters with values.
    }
    property parameterList : TFhirExtensionList read FParameterList;

    {@member response
      If this is a response to a query.
    }
    property response : TFhirQueryResponse read FResponse write SetResponse;

  end;


  {@Class TFhirQuestionnaire : TFhirResource
    A set of answers to predefined lists of questions. The questions may be ordered and grouped into coherent subsets, corresponding to the structure of the grouping of the underlying questions.
  }
  {!.Net HL7Connect.Fhir.Questionnaire}
  TFhirQuestionnaire = class (TFhirResource)
  private
    FStatus : TFhirEnum;
    FAuthored : TFhirDateTime;
    FSubject : TFhirResourceReference{Resource};
    FAuthor : TFhirResourceReference{Resource};
    FSource : TFhirResourceReference{Resource};
    FName : TFhirCodeableConcept;
    FIdentifier : TFhirIdentifier;
    FEncounter : TFhirResourceReference{TFhirEncounter};
    FquestionList : TFhirQuestionnaireQuestionList;
    FgroupList : TFhirQuestionnaireGroupList;
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirObservationStatus;
    Procedure SetStatusST(value : TFhirObservationStatus);
    Procedure SetAuthored(value : TFhirDateTime);
    Function GetAuthoredST : TDateAndTime;
    Procedure SetAuthoredST(value : TDateAndTime);
    Procedure SetSubject(value : TFhirResourceReference{Resource});
    Procedure SetAuthor(value : TFhirResourceReference{Resource});
    Procedure SetSource(value : TFhirResourceReference{Resource});
    Procedure SetName(value : TFhirCodeableConcept);
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetEncounter(value : TFhirResourceReference{TFhirEncounter});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirQuestionnaire; overload;
    function Clone : TFhirQuestionnaire; overload;
    {!script show}
  published
    {@member status
      The status of the questionnaire as a whole.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to The status of the questionnaire as a whole.
    }
    property statusST : TFhirObservationStatus read GetStatusST write SetStatusST;

    {@member authored
      The date and/or time that this version of the questionnaire was authored.
    }
    property authored : TFhirDateTime read FAuthored write SetAuthored;
    {@member authoredST
      Typed access to The date and/or time that this version of the questionnaire was authored.
    }
    property authoredST : TDateAndTime read GetAuthoredST write SetAuthoredST;

    {@member subject
      The subject of the questionnaires: this is the patient that the answers apply to, but this person is not necessarily the source of information.
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member author
      Person that collected the answers to the questions in the Questionnaire.
    }
    property author : TFhirResourceReference{Resource} read FAuthor write SetAuthor;

    {@member source
      The person that answered the questions about the subject. Only used when this is not the subject him/herself.
    }
    property source : TFhirResourceReference{Resource} read FSource write SetSource;

    {@member name
      Structured name for a predefined list of questions this questionnaire is responding to.
    }
    property name : TFhirCodeableConcept read FName write SetName;

    {@member identifier
      An identifier that identifier this specific set of answers.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member encounter
      Encounter during which this questionnaireanswers were collected. When there were multiple encounters, this is the one considered most relevant to the context of the answers.
    }
    property encounter : TFhirResourceReference{TFhirEncounter} read FEncounter write SetEncounter;

    {@member questionList
      Answers to questions on a questionnaire.
    }
    property questionList : TFhirQuestionnaireQuestionList read FQuestionList;

    {@member groupList
      A group of questions to a possibly similarly grouped set of question in the questionnaire.
    }
    property groupList : TFhirQuestionnaireGroupList read FGroupList;

  end;


  {@Class TFhirRelatedPerson : TFhirResource
    Information about a person that is involved in the care for a patient, but who is not the target of healthcare, nor has a formal responsibility in the care process.
  }
  {!.Net HL7Connect.Fhir.RelatedPerson}
  TFhirRelatedPerson = class (TFhirResource)
  private
    FidentifierList : TFhirIdentifierList;
    FPatient : TFhirResourceReference{TFhirPatient};
    FRelationship : TFhirCodeableConcept;
    FName : TFhirHumanName;
    FtelecomList : TFhirContactList;
    FGender : TFhirCodeableConcept;
    FAddress : TFhirAddress;
    FphotoList : TFhirAttachmentList;
    Procedure SetPatient(value : TFhirResourceReference{TFhirPatient});
    Procedure SetRelationship(value : TFhirCodeableConcept);
    Procedure SetName(value : TFhirHumanName);
    Procedure SetGender(value : TFhirCodeableConcept);
    Procedure SetAddress(value : TFhirAddress);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirRelatedPerson; overload;
    function Clone : TFhirRelatedPerson; overload;
    {!script show}
  published
    {@member identifierList
      Identifier for a person within a particular scope.
    }
    property identifierList : TFhirIdentifierList read FIdentifierList;

    {@member patient
      The patient this person is related to.
    }
    property patient : TFhirResourceReference{TFhirPatient} read FPatient write SetPatient;

    {@member relationship
      The nature of the relationship between a patient and the related person.
    }
    property relationship : TFhirCodeableConcept read FRelationship write SetRelationship;

    {@member name
      A name associated with the person.
    }
    property name : TFhirHumanName read FName write SetName;

    {@member telecomList
      A contact detail for the person, e.g. a telephone number or an email address.
    }
    property telecomList : TFhirContactList read FTelecomList;

    {@member gender
      Administrative Gender - the gender that the person is considered to have for administration and record keeping purposes.
    }
    property gender : TFhirCodeableConcept read FGender write SetGender;

    {@member address
      Address where the related person can be contacted or visited.
    }
    property address : TFhirAddress read FAddress write SetAddress;

    {@member photoList
      Image of the person.
    }
    property photoList : TFhirAttachmentList read FPhotoList;

  end;


  {@Class TFhirSecurityEvent : TFhirResource
    A record of an event made for purposes of maintaining a security log. Typical uses include detection of intrusion attempts and monitoring for inappropriate usage.
  }
  {!.Net HL7Connect.Fhir.SecurityEvent}
  TFhirSecurityEvent = class (TFhirResource)
  private
    FEvent : TFhirSecurityEventEvent;
    FparticipantList : TFhirSecurityEventParticipantList;
    FSource : TFhirSecurityEventSource;
    Fobject_List : TFhirSecurityEventObjectList;
    Procedure SetEvent(value : TFhirSecurityEventEvent);
    Procedure SetSource(value : TFhirSecurityEventSource);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirSecurityEvent; overload;
    function Clone : TFhirSecurityEvent; overload;
    {!script show}
  published
    {@member event
      Identifies the name, action type, time, and disposition of the audited event.
    }
    property event : TFhirSecurityEventEvent read FEvent write SetEvent;

    {@member participantList
      A person, a hardware device or software process.
    }
    property participantList : TFhirSecurityEventParticipantList read FParticipantList;

    {@member source
      Application systems and processes.
    }
    property source : TFhirSecurityEventSource read FSource write SetSource;

    {@member object_List
      Specific instances of data or objects that have been accessed.
    }
    property object_List : TFhirSecurityEventObjectList read FObject_List;

  end;


  {@Class TFhirSpecimen : TFhirResource
    Sample for analysis.
  }
  {!.Net HL7Connect.Fhir.Specimen}
  TFhirSpecimen = class (TFhirResource)
  private
    FIdentifier : TFhirIdentifier;
    FType_ : TFhirCodeableConcept;
    FsourceList : TFhirSpecimenSourceList;
    FSubject : TFhirResourceReference{Resource};
    FaccessionIdentifierList : TFhirIdentifierList;
    FReceivedTime : TFhirDateTime;
    FCollection : TFhirSpecimenCollection;
    FtreatmentList : TFhirSpecimenTreatmentList;
    FcontainerList : TFhirSpecimenContainerList;
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetType_(value : TFhirCodeableConcept);
    Procedure SetSubject(value : TFhirResourceReference{Resource});
    Procedure SetReceivedTime(value : TFhirDateTime);
    Function GetReceivedTimeST : TDateAndTime;
    Procedure SetReceivedTimeST(value : TDateAndTime);
    Procedure SetCollection(value : TFhirSpecimenCollection);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirSpecimen; overload;
    function Clone : TFhirSpecimen; overload;
    {!script show}
  published
    {@member identifier
      Id for specimen.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member type_
      The type of the specimen. This is sometimes called the "matrix".
    }
    property type_ : TFhirCodeableConcept read FType_ write SetType_;

    {@member sourceList
      Parent specimen from which the focal specimen was a component.
    }
    property sourceList : TFhirSpecimenSourceList read FSourceList;

    {@member subject
      The subject of the report.
    }
    property subject : TFhirResourceReference{Resource} read FSubject write SetSubject;

    {@member accessionIdentifierList
      The identifier(s) assigned by the lab when accessioning specimen(s). This is not necessarily the same as the specimen identifier, depending on local lab procedures.
    }
    property accessionIdentifierList : TFhirIdentifierList read FAccessionIdentifierList;

    {@member receivedTime
      Time when specimen was received for processing or testing.
    }
    property receivedTime : TFhirDateTime read FReceivedTime write SetReceivedTime;
    {@member receivedTimeST
      Typed access to Time when specimen was received for processing or testing.
    }
    property receivedTimeST : TDateAndTime read GetReceivedTimeST write SetReceivedTimeST;

    {@member collection
      Details concerning the specimen collection.
    }
    property collection : TFhirSpecimenCollection read FCollection write SetCollection;

    {@member treatmentList
      Details concerning treatment and processing steps for the specimen.
    }
    property treatmentList : TFhirSpecimenTreatmentList read FTreatmentList;

    {@member containerList
      The container holding the specimen. May be recursive; ie blood in tube in tray in rack.
    }
    property containerList : TFhirSpecimenContainerList read FContainerList;

  end;


  {@Class TFhirSubstance : TFhirResource
    A homogeneous material with a definite composition used in healthcare.
  }
  {!.Net HL7Connect.Fhir.Substance}
  TFhirSubstance = class (TFhirResource)
  private
    FIdentifier : TFhirIdentifier;
    FName : TFhirString;
    FType_ : TFhirCodeableConcept;
    FDescription : TFhirString;
    FStatus : TFhirCodeableConcept;
    FEffectiveTime : TFhirPeriod;
    FQuantity : TFhirQuantity;
    FingredientList : TFhirResourceReferenceList{TFhirSubstance};
    FQuantityMode : TFhirCodeableConcept;
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetName(value : TFhirString);
    Function GetNameST : String;
    Procedure SetNameST(value : String);
    Procedure SetType_(value : TFhirCodeableConcept);
    Procedure SetDescription(value : TFhirString);
    Function GetDescriptionST : String;
    Procedure SetDescriptionST(value : String);
    Procedure SetStatus(value : TFhirCodeableConcept);
    Procedure SetEffectiveTime(value : TFhirPeriod);
    Procedure SetQuantity(value : TFhirQuantity);
    Procedure SetQuantityMode(value : TFhirCodeableConcept);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirSubstance; overload;
    function Clone : TFhirSubstance; overload;
    {!script show}
  published
    {@member identifier
      Identifier of the substance.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member name
      Name of the substance.
    }
    property name : TFhirString read FName write SetName;
    {@member nameST
      Typed access to Name of the substance.
    }
    property nameST : String read GetNameST write SetNameST;

    {@member type_
      Type of the substance.
    }
    property type_ : TFhirCodeableConcept read FType_ write SetType_;

    {@member description
      Description of the substance.
    }
    property description : TFhirString read FDescription write SetDescription;
    {@member descriptionST
      Typed access to Description of the substance.
    }
    property descriptionST : String read GetDescriptionST write SetDescriptionST;

    {@member status
      Substance status.
    }
    property status : TFhirCodeableConcept read FStatus write SetStatus;

    {@member effectiveTime
      When the substance is active or effective.
    }
    property effectiveTime : TFhirPeriod read FEffectiveTime write SetEffectiveTime;

    {@member quantity
      The amount of the substance.
    }
    property quantity : TFhirQuantity read FQuantity write SetQuantity;

    {@member ingredientList
      A substance can be composed of other substances.
    }
    property ingredientList : TFhirResourceReferenceList{TFhirSubstance} read FIngredientList;

    {@member quantityMode
      Indicates whether the substance quantity (used for ingredients) are absolute values or values relative to each other (percentages).
    }
    property quantityMode : TFhirCodeableConcept read FQuantityMode write SetQuantityMode;

  end;


  {@Class TFhirSupply : TFhirResource
    A supply -  request and provision.
  }
  {!.Net HL7Connect.Fhir.Supply}
  TFhirSupply = class (TFhirResource)
  private
    FName : TFhirCodeableConcept;
    FIdentifier : TFhirIdentifier;
    FStatus : TFhirCode;
    FOrderedItem : TFhirResourceReference{Resource};
    FPatient : TFhirResourceReference{TFhirPatient};
    FdispenseList : TFhirSupplyDispenseList;
    Procedure SetName(value : TFhirCodeableConcept);
    Procedure SetIdentifier(value : TFhirIdentifier);
    Procedure SetStatus(value : TFhirCode);
    Function GetStatusST : String;
    Procedure SetStatusST(value : String);
    Procedure SetOrderedItem(value : TFhirResourceReference{Resource});
    Procedure SetPatient(value : TFhirResourceReference{TFhirPatient});
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirSupply; overload;
    function Clone : TFhirSupply; overload;
    {!script show}
  published
    {@member name
      Category of supply.
    }
    property name : TFhirCodeableConcept read FName write SetName;

    {@member identifier
      Unique identifier for this kind of supply.
    }
    property identifier : TFhirIdentifier read FIdentifier write SetIdentifier;

    {@member status
      Status of the supply.
    }
    property status : TFhirCode read FStatus write SetStatus;
    {@member statusST
      Typed access to Status of the supply.
    }
    property statusST : String read GetStatusST write SetStatusST;

    {@member orderedItem
      The item which was ordered.
    }
    property orderedItem : TFhirResourceReference{Resource} read FOrderedItem write SetOrderedItem;

    {@member patient
      A link to a resource representing the person to whom the medication will be given.
    }
    property patient : TFhirResourceReference{TFhirPatient} read FPatient write SetPatient;

    {@member dispenseList
      Indicates the details of the dispense event such as the days supply and quantity of a supply dispensed.
    }
    property dispenseList : TFhirSupplyDispenseList read FDispenseList;

  end;


  {@Class TFhirValueSet : TFhirResource
    A value set specifies a set of codes drawn from one or more code systems.
  }
  {!.Net HL7Connect.Fhir.ValueSet}
  TFhirValueSet = class (TFhirResource)
  private
    FIdentifier : TFhirString;
    FVersion : TFhirString;
    FName : TFhirString;
    FPublisher : TFhirString;
    FtelecomList : TFhirContactList;
    FDescription : TFhirString;
    FCopyright : TFhirString;
    FStatus : TFhirEnum;
    FExperimental : TFhirBoolean;
    FDate : TFhirDateTime;
    FDefine : TFhirValueSetDefine;
    FCompose : TFhirValueSetCompose;
    FExpansion : TFhirValueSetExpansion;
    Procedure SetIdentifier(value : TFhirString);
    Function GetIdentifierST : String;
    Procedure SetIdentifierST(value : String);
    Procedure SetVersion(value : TFhirString);
    Function GetVersionST : String;
    Procedure SetVersionST(value : String);
    Procedure SetName(value : TFhirString);
    Function GetNameST : String;
    Procedure SetNameST(value : String);
    Procedure SetPublisher(value : TFhirString);
    Function GetPublisherST : String;
    Procedure SetPublisherST(value : String);
    Procedure SetDescription(value : TFhirString);
    Function GetDescriptionST : String;
    Procedure SetDescriptionST(value : String);
    Procedure SetCopyright(value : TFhirString);
    Function GetCopyrightST : String;
    Procedure SetCopyrightST(value : String);
    Procedure SetStatus(value : TFhirEnum);
    Function GetStatusST : TFhirValuesetStatus;
    Procedure SetStatusST(value : TFhirValuesetStatus);
    Procedure SetExperimental(value : TFhirBoolean);
    Function GetExperimentalST : String;
    Procedure SetExperimentalST(value : String);
    Procedure SetDate(value : TFhirDateTime);
    Function GetDateST : TDateAndTime;
    Procedure SetDateST(value : TDateAndTime);
    Procedure SetDefine(value : TFhirValueSetDefine);
    Procedure SetCompose(value : TFhirValueSetCompose);
    Procedure SetExpansion(value : TFhirValueSetExpansion);
  protected
    Procedure GetChildrenByName(child_name : string; list : TFHIRObjectList); override;
    Procedure ListProperties(oList : TFHIRPropertyList; bInheritedProperties : Boolean); Override;
    function GetResourceType : TFhirResourceType; override;
  public
    constructor Create; Override;
    destructor Destroy; override;
    {!script hide}
    procedure Assign(oSource : TAdvObject); override;
    function Link : TFhirValueSet; overload;
    function Clone : TFhirValueSet; overload;
    {!script show}
  published
    {@member identifier
      The identifier that is used to identify this value set when it is referenced in a specification, model, design or an instance (should be globally unique OID, UUID, or URI).
    }
    property identifier : TFhirString read FIdentifier write SetIdentifier;
    {@member identifierST
      Typed access to The identifier that is used to identify this value set when it is referenced in a specification, model, design or an instance (should be globally unique OID, UUID, or URI).
    }
    property identifierST : String read GetIdentifierST write SetIdentifierST;

    {@member version
      The identifier that is used to identify this version of the value set when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the profile author manually and the value should be a timestamp.
    }
    property version : TFhirString read FVersion write SetVersion;
    {@member versionST
      Typed access to The identifier that is used to identify this version of the value set when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the profile author manually and the value should be a timestamp.
    }
    property versionST : String read GetVersionST write SetVersionST;

    {@member name
      A free text natural language name describing the value set.
    }
    property name : TFhirString read FName write SetName;
    {@member nameST
      Typed access to A free text natural language name describing the value set.
    }
    property nameST : String read GetNameST write SetNameST;

    {@member publisher
      The name of the individual or organization that published the value set.
    }
    property publisher : TFhirString read FPublisher write SetPublisher;
    {@member publisherST
      Typed access to The name of the individual or organization that published the value set.
    }
    property publisherST : String read GetPublisherST write SetPublisherST;

    {@member telecomList
      Contacts of the publisher to assist a user in finding and communicating with the publisher.
    }
    property telecomList : TFhirContactList read FTelecomList;

    {@member description
      A free text natural language description of the use of the value set - reason for definition, conditions of use, etc.
    }
    property description : TFhirString read FDescription write SetDescription;
    {@member descriptionST
      Typed access to A free text natural language description of the use of the value set - reason for definition, conditions of use, etc.
    }
    property descriptionST : String read GetDescriptionST write SetDescriptionST;

    {@member copyright
      A copyright statement relating to the value set and/or its contents.
    }
    property copyright : TFhirString read FCopyright write SetCopyright;
    {@member copyrightST
      Typed access to A copyright statement relating to the value set and/or its contents.
    }
    property copyrightST : String read GetCopyrightST write SetCopyrightST;

    {@member status
      The status of the value set.
    }
    property status : TFhirEnum read FStatus write SetStatus;
    {@member statusST
      Typed access to The status of the value set.
    }
    property statusST : TFhirValuesetStatus read GetStatusST write SetStatusST;

    {@member experimental
      This valueset was authored for testing purposes (or education/evaluation/marketing), and is not intended to be used for genuine usage.
    }
    property experimental : TFhirBoolean read FExperimental write SetExperimental;
    {@member experimentalST
      Typed access to This valueset was authored for testing purposes (or education/evaluation/marketing), and is not intended to be used for genuine usage.
    }
    property experimentalST : String read GetExperimentalST write SetExperimentalST;

    {@member date
      The date that the value set status was last changed.
    }
    property date : TFhirDateTime read FDate write SetDate;
    {@member dateST
      Typed access to The date that the value set status was last changed.
    }
    property dateST : TDateAndTime read GetDateST write SetDateST;

    {@member define
      When value set defines its own codes.
    }
    property define : TFhirValueSetDefine read FDefine write SetDefine;

    {@member compose
      When value set includes codes from elsewhere.
    }
    property compose : TFhirValueSetCompose read FCompose write SetCompose;

    {@member expansion
      When value set is an expansion.
    }
    property expansion : TFhirValueSetExpansion read FExpansion write SetExpansion;

  end;


 TFhirResourceFactory = class (TFHIRBaseFactory)
  public
    {@member newExtension
      create a new Extension
    }
    {!script nolink}
    function newExtension : TFhirExtension;
    {@member newNarrative
      create a new Narrative
    }
    {!script nolink}
    function newNarrative : TFhirNarrative;
    {@member newPeriod
      create a new Period
    }
    {!script nolink}
    function newPeriod : TFhirPeriod;
    {@member newCoding
      create a new Coding
    }
    {!script nolink}
    function newCoding : TFhirCoding;
    {@member newRange
      create a new Range
    }
    {!script nolink}
    function newRange : TFhirRange;
    {@member newQuantity
      create a new Quantity
    }
    {!script nolink}
    function newQuantity : TFhirQuantity;
    {@member newChoiceOption
      create a new option
    }
    {!script nolink}
    function newChoiceOption : TFhirChoiceOption;
    {@member newChoice
      create a new Choice
    }
    {!script nolink}
    function newChoice : TFhirChoice;
    {@member newAttachment
      create a new Attachment
    }
    {!script nolink}
    function newAttachment : TFhirAttachment;
    {@member newRatio
      create a new Ratio
    }
    {!script nolink}
    function newRatio : TFhirRatio;
    {@member newSampledData
      create a new SampledData
    }
    {!script nolink}
    function newSampledData : TFhirSampledData;
    {@member newResourceReference
      create a new ResourceReference
    }
    {!script nolink}
    function newResourceReference : TFhirResourceReference;
    {@member newCodeableConcept
      create a new CodeableConcept
    }
    {!script nolink}
    function newCodeableConcept : TFhirCodeableConcept;
    {@member newIdentifier
      create a new Identifier
    }
    {!script nolink}
    function newIdentifier : TFhirIdentifier;
    {@member newScheduleRepeat
      create a new repeat
    }
    {!script nolink}
    function newScheduleRepeat : TFhirScheduleRepeat;
    {@member newSchedule
      create a new Schedule
    }
    {!script nolink}
    function newSchedule : TFhirSchedule;
    {@member newContact
      create a new Contact
    }
    {!script nolink}
    function newContact : TFhirContact;
    {@member newAddress
      create a new Address
    }
    {!script nolink}
    function newAddress : TFhirAddress;
    {@member newHumanName
      create a new HumanName
    }
    {!script nolink}
    function newHumanName : TFhirHumanName;
    {@member newAdverseReactionSymptom
      create a new symptom
    }
    {!script nolink}
    function newAdverseReactionSymptom : TFhirAdverseReactionSymptom;
    {@member newAdverseReactionExposure
      create a new exposure
    }
    {!script nolink}
    function newAdverseReactionExposure : TFhirAdverseReactionExposure;
    {@member newAdverseReaction
      create a new AdverseReaction
    }
    {!script nolink}
    function newAdverseReaction : TFhirAdverseReaction;
    {@member newAlert
      create a new Alert
    }
    {!script nolink}
    function newAlert : TFhirAlert;
    {@member newAllergyIntolerance
      create a new AllergyIntolerance
    }
    {!script nolink}
    function newAllergyIntolerance : TFhirAllergyIntolerance;
    {@member newCarePlanParticipant
      create a new participant
    }
    {!script nolink}
    function newCarePlanParticipant : TFhirCarePlanParticipant;
    {@member newCarePlanGoal
      create a new goal
    }
    {!script nolink}
    function newCarePlanGoal : TFhirCarePlanGoal;
    {@member newCarePlanActivity
      create a new activity
    }
    {!script nolink}
    function newCarePlanActivity : TFhirCarePlanActivity;
    {@member newCarePlan
      create a new CarePlan
    }
    {!script nolink}
    function newCarePlan : TFhirCarePlan;
    {@member newConditionStage
      create a new stage
    }
    {!script nolink}
    function newConditionStage : TFhirConditionStage;
    {@member newConditionEvidence
      create a new evidence
    }
    {!script nolink}
    function newConditionEvidence : TFhirConditionEvidence;
    {@member newConditionLocation
      create a new location
    }
    {!script nolink}
    function newConditionLocation : TFhirConditionLocation;
    {@member newConditionRelatedItem
      create a new relatedItem
    }
    {!script nolink}
    function newConditionRelatedItem : TFhirConditionRelatedItem;
    {@member newCondition
      create a new Condition
    }
    {!script nolink}
    function newCondition : TFhirCondition;
    {@member newConformanceSoftware
      create a new software
    }
    {!script nolink}
    function newConformanceSoftware : TFhirConformanceSoftware;
    {@member newConformanceImplementation
      create a new implementation
    }
    {!script nolink}
    function newConformanceImplementation : TFhirConformanceImplementation;
    {@member newConformanceRest
      create a new rest
    }
    {!script nolink}
    function newConformanceRest : TFhirConformanceRest;
    {@member newConformanceRestSecurity
      create a new security
    }
    {!script nolink}
    function newConformanceRestSecurity : TFhirConformanceRestSecurity;
    {@member newConformanceRestSecurityCertificate
      create a new certificate
    }
    {!script nolink}
    function newConformanceRestSecurityCertificate : TFhirConformanceRestSecurityCertificate;
    {@member newConformanceRestResource
      create a new resource
    }
    {!script nolink}
    function newConformanceRestResource : TFhirConformanceRestResource;
    {@member newConformanceRestResourceOperation
      create a new operation
    }
    {!script nolink}
    function newConformanceRestResourceOperation : TFhirConformanceRestResourceOperation;
    {@member newConformanceRestResourceSearchParam
      create a new searchParam
    }
    {!script nolink}
    function newConformanceRestResourceSearchParam : TFhirConformanceRestResourceSearchParam;
    {@member newConformanceRestQuery
      create a new query
    }
    {!script nolink}
    function newConformanceRestQuery : TFhirConformanceRestQuery;
    {@member newConformanceMessaging
      create a new messaging
    }
    {!script nolink}
    function newConformanceMessaging : TFhirConformanceMessaging;
    {@member newConformanceMessagingEvent
      create a new event
    }
    {!script nolink}
    function newConformanceMessagingEvent : TFhirConformanceMessagingEvent;
    {@member newConformanceDocument
      create a new document
    }
    {!script nolink}
    function newConformanceDocument : TFhirConformanceDocument;
    {@member newConformance
      create a new Conformance
    }
    {!script nolink}
    function newConformance : TFhirConformance;
    {@member newCoverageSubscriber
      create a new subscriber
    }
    {!script nolink}
    function newCoverageSubscriber : TFhirCoverageSubscriber;
    {@member newCoverage
      create a new Coverage
    }
    {!script nolink}
    function newCoverage : TFhirCoverage;
    {@member newDeviceIdentity
      create a new identity
    }
    {!script nolink}
    function newDeviceIdentity : TFhirDeviceIdentity;
    {@member newDevice
      create a new Device
    }
    {!script nolink}
    function newDevice : TFhirDevice;
    {@member newDeviceCapabilitiesVirtualDevice
      create a new virtualDevice
    }
    {!script nolink}
    function newDeviceCapabilitiesVirtualDevice : TFhirDeviceCapabilitiesVirtualDevice;
    {@member newDeviceCapabilitiesVirtualDeviceChannel
      create a new channel
    }
    {!script nolink}
    function newDeviceCapabilitiesVirtualDeviceChannel : TFhirDeviceCapabilitiesVirtualDeviceChannel;
    {@member newDeviceCapabilitiesVirtualDeviceChannelMetric
      create a new metric
    }
    {!script nolink}
    function newDeviceCapabilitiesVirtualDeviceChannelMetric : TFhirDeviceCapabilitiesVirtualDeviceChannelMetric;
    {@member newDeviceCapabilitiesVirtualDeviceChannelMetricInfo
      create a new info
    }
    {!script nolink}
    function newDeviceCapabilitiesVirtualDeviceChannelMetricInfo : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo;
    {@member newDeviceCapabilitiesVirtualDeviceChannelMetricFacet
      create a new facet
    }
    {!script nolink}
    function newDeviceCapabilitiesVirtualDeviceChannelMetricFacet : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet;
    {@member newDeviceCapabilities
      create a new DeviceCapabilities
    }
    {!script nolink}
    function newDeviceCapabilities : TFhirDeviceCapabilities;
    {@member newDeviceLogItem
      create a new item
    }
    {!script nolink}
    function newDeviceLogItem : TFhirDeviceLogItem;
    {@member newDeviceLog
      create a new DeviceLog
    }
    {!script nolink}
    function newDeviceLog : TFhirDeviceLog;
    {@member newDeviceObservation
      create a new DeviceObservation
    }
    {!script nolink}
    function newDeviceObservation : TFhirDeviceObservation;
    {@member newDiagnosticOrderEvent
      create a new event
    }
    {!script nolink}
    function newDiagnosticOrderEvent : TFhirDiagnosticOrderEvent;
    {@member newDiagnosticOrderItem
      create a new item
    }
    {!script nolink}
    function newDiagnosticOrderItem : TFhirDiagnosticOrderItem;
    {@member newDiagnosticOrder
      create a new DiagnosticOrder
    }
    {!script nolink}
    function newDiagnosticOrder : TFhirDiagnosticOrder;
    {@member newDiagnosticReportRequestDetail
      create a new requestDetail
    }
    {!script nolink}
    function newDiagnosticReportRequestDetail : TFhirDiagnosticReportRequestDetail;
    {@member newDiagnosticReportResults
      create a new results
    }
    {!script nolink}
    function newDiagnosticReportResults : TFhirDiagnosticReportResults;
    {@member newDiagnosticReport
      create a new DiagnosticReport
    }
    {!script nolink}
    function newDiagnosticReport : TFhirDiagnosticReport;
    {@member newDocumentAttester
      create a new attester
    }
    {!script nolink}
    function newDocumentAttester : TFhirDocumentAttester;
    {@member newDocumentEvent
      create a new event
    }
    {!script nolink}
    function newDocumentEvent : TFhirDocumentEvent;
    {@member newDocumentSection
      create a new section
    }
    {!script nolink}
    function newDocumentSection : TFhirDocumentSection;
    {@member newDocument
      create a new Document
    }
    {!script nolink}
    function newDocument : TFhirDocument;
    {@member newDocumentReferenceService
      create a new service
    }
    {!script nolink}
    function newDocumentReferenceService : TFhirDocumentReferenceService;
    {@member newDocumentReferenceServiceParameter
      create a new parameter
    }
    {!script nolink}
    function newDocumentReferenceServiceParameter : TFhirDocumentReferenceServiceParameter;
    {@member newDocumentReferenceContext
      create a new context
    }
    {!script nolink}
    function newDocumentReferenceContext : TFhirDocumentReferenceContext;
    {@member newDocumentReference
      create a new DocumentReference
    }
    {!script nolink}
    function newDocumentReference : TFhirDocumentReference;
    {@member newEncounterParticipant
      create a new participant
    }
    {!script nolink}
    function newEncounterParticipant : TFhirEncounterParticipant;
    {@member newEncounterHospitalization
      create a new hospitalization
    }
    {!script nolink}
    function newEncounterHospitalization : TFhirEncounterHospitalization;
    {@member newEncounterHospitalizationAccomodation
      create a new accomodation
    }
    {!script nolink}
    function newEncounterHospitalizationAccomodation : TFhirEncounterHospitalizationAccomodation;
    {@member newEncounterLocation
      create a new location
    }
    {!script nolink}
    function newEncounterLocation : TFhirEncounterLocation;
    {@member newEncounter
      create a new Encounter
    }
    {!script nolink}
    function newEncounter : TFhirEncounter;
    {@member newFamilyHistoryRelation
      create a new relation
    }
    {!script nolink}
    function newFamilyHistoryRelation : TFhirFamilyHistoryRelation;
    {@member newFamilyHistoryRelationCondition
      create a new condition
    }
    {!script nolink}
    function newFamilyHistoryRelationCondition : TFhirFamilyHistoryRelationCondition;
    {@member newFamilyHistory
      create a new FamilyHistory
    }
    {!script nolink}
    function newFamilyHistory : TFhirFamilyHistory;
    {@member newGroupCharacteristic
      create a new characteristic
    }
    {!script nolink}
    function newGroupCharacteristic : TFhirGroupCharacteristic;
    {@member newGroup
      create a new Group
    }
    {!script nolink}
    function newGroup : TFhirGroup;
    {@member newImagingStudySeries
      create a new series
    }
    {!script nolink}
    function newImagingStudySeries : TFhirImagingStudySeries;
    {@member newImagingStudySeriesInstance
      create a new instance
    }
    {!script nolink}
    function newImagingStudySeriesInstance : TFhirImagingStudySeriesInstance;
    {@member newImagingStudy
      create a new ImagingStudy
    }
    {!script nolink}
    function newImagingStudy : TFhirImagingStudy;
    {@member newImmunizationExplanation
      create a new explanation
    }
    {!script nolink}
    function newImmunizationExplanation : TFhirImmunizationExplanation;
    {@member newImmunizationReaction
      create a new reaction
    }
    {!script nolink}
    function newImmunizationReaction : TFhirImmunizationReaction;
    {@member newImmunizationVaccinationProtocol
      create a new vaccinationProtocol
    }
    {!script nolink}
    function newImmunizationVaccinationProtocol : TFhirImmunizationVaccinationProtocol;
    {@member newImmunization
      create a new Immunization
    }
    {!script nolink}
    function newImmunization : TFhirImmunization;
    {@member newImmunizationProfileRecommendation
      create a new recommendation
    }
    {!script nolink}
    function newImmunizationProfileRecommendation : TFhirImmunizationProfileRecommendation;
    {@member newImmunizationProfileRecommendationDateCriterion
      create a new dateCriterion
    }
    {!script nolink}
    function newImmunizationProfileRecommendationDateCriterion : TFhirImmunizationProfileRecommendationDateCriterion;
    {@member newImmunizationProfileRecommendationProtocol
      create a new protocol
    }
    {!script nolink}
    function newImmunizationProfileRecommendationProtocol : TFhirImmunizationProfileRecommendationProtocol;
    {@member newImmunizationProfileRecommendationSupportingAdverseEventReport
      create a new supportingAdverseEventReport
    }
    {!script nolink}
    function newImmunizationProfileRecommendationSupportingAdverseEventReport : TFhirImmunizationProfileRecommendationSupportingAdverseEventReport;
    {@member newImmunizationProfile
      create a new ImmunizationProfile
    }
    {!script nolink}
    function newImmunizationProfile : TFhirImmunizationProfile;
    {@member newListEntry
      create a new entry
    }
    {!script nolink}
    function newListEntry : TFhirListEntry;
    {@member newList
      create a new List
    }
    {!script nolink}
    function newList : TFhirList;
    {@member newLocationPosition
      create a new position
    }
    {!script nolink}
    function newLocationPosition : TFhirLocationPosition;
    {@member newLocation
      create a new Location
    }
    {!script nolink}
    function newLocation : TFhirLocation;
    {@member newMedia
      create a new Media
    }
    {!script nolink}
    function newMedia : TFhirMedia;
    {@member newMedicationProduct
      create a new product
    }
    {!script nolink}
    function newMedicationProduct : TFhirMedicationProduct;
    {@member newMedicationProductIngredient
      create a new ingredient
    }
    {!script nolink}
    function newMedicationProductIngredient : TFhirMedicationProductIngredient;
    {@member newMedicationPackage
      create a new package
    }
    {!script nolink}
    function newMedicationPackage : TFhirMedicationPackage;
    {@member newMedicationPackageContent
      create a new content
    }
    {!script nolink}
    function newMedicationPackageContent : TFhirMedicationPackageContent;
    {@member newMedication
      create a new Medication
    }
    {!script nolink}
    function newMedication : TFhirMedication;
    {@member newMedicationAdministrationDosage
      create a new dosage
    }
    {!script nolink}
    function newMedicationAdministrationDosage : TFhirMedicationAdministrationDosage;
    {@member newMedicationAdministration
      create a new MedicationAdministration
    }
    {!script nolink}
    function newMedicationAdministration : TFhirMedicationAdministration;
    {@member newMedicationDispenseDispense
      create a new dispense
    }
    {!script nolink}
    function newMedicationDispenseDispense : TFhirMedicationDispenseDispense;
    {@member newMedicationDispenseDispenseDosage
      create a new dosage
    }
    {!script nolink}
    function newMedicationDispenseDispenseDosage : TFhirMedicationDispenseDispenseDosage;
    {@member newMedicationDispenseSubstitution
      create a new substitution
    }
    {!script nolink}
    function newMedicationDispenseSubstitution : TFhirMedicationDispenseSubstitution;
    {@member newMedicationDispense
      create a new MedicationDispense
    }
    {!script nolink}
    function newMedicationDispense : TFhirMedicationDispense;
    {@member newMedicationPrescriptionDosageInstruction
      create a new dosageInstruction
    }
    {!script nolink}
    function newMedicationPrescriptionDosageInstruction : TFhirMedicationPrescriptionDosageInstruction;
    {@member newMedicationPrescriptionDispense
      create a new dispense
    }
    {!script nolink}
    function newMedicationPrescriptionDispense : TFhirMedicationPrescriptionDispense;
    {@member newMedicationPrescriptionSubstitution
      create a new substitution
    }
    {!script nolink}
    function newMedicationPrescriptionSubstitution : TFhirMedicationPrescriptionSubstitution;
    {@member newMedicationPrescription
      create a new MedicationPrescription
    }
    {!script nolink}
    function newMedicationPrescription : TFhirMedicationPrescription;
    {@member newMedicationStatementDosage
      create a new dosage
    }
    {!script nolink}
    function newMedicationStatementDosage : TFhirMedicationStatementDosage;
    {@member newMedicationStatement
      create a new MedicationStatement
    }
    {!script nolink}
    function newMedicationStatement : TFhirMedicationStatement;
    {@member newMessageResponse
      create a new response
    }
    {!script nolink}
    function newMessageResponse : TFhirMessageResponse;
    {@member newMessageSource
      create a new source
    }
    {!script nolink}
    function newMessageSource : TFhirMessageSource;
    {@member newMessageDestination
      create a new destination
    }
    {!script nolink}
    function newMessageDestination : TFhirMessageDestination;
    {@member newMessage
      create a new Message
    }
    {!script nolink}
    function newMessage : TFhirMessage;
    {@member newObservationReferenceRange
      create a new referenceRange
    }
    {!script nolink}
    function newObservationReferenceRange : TFhirObservationReferenceRange;
    {@member newObservationComponent
      create a new component
    }
    {!script nolink}
    function newObservationComponent : TFhirObservationComponent;
    {@member newObservation
      create a new Observation
    }
    {!script nolink}
    function newObservation : TFhirObservation;
    {@member newOperationOutcomeIssue
      create a new issue
    }
    {!script nolink}
    function newOperationOutcomeIssue : TFhirOperationOutcomeIssue;
    {@member newOperationOutcome
      create a new OperationOutcome
    }
    {!script nolink}
    function newOperationOutcome : TFhirOperationOutcome;
    {@member newOrderWhen
      create a new when
    }
    {!script nolink}
    function newOrderWhen : TFhirOrderWhen;
    {@member newOrder
      create a new Order
    }
    {!script nolink}
    function newOrder : TFhirOrder;
    {@member newOrderResponse
      create a new OrderResponse
    }
    {!script nolink}
    function newOrderResponse : TFhirOrderResponse;
    {@member newOrganizationContact
      create a new contact
    }
    {!script nolink}
    function newOrganizationContact : TFhirOrganizationContact;
    {@member newOrganization
      create a new Organization
    }
    {!script nolink}
    function newOrganization : TFhirOrganization;
    {@member newOther
      create a new Other
    }
    {!script nolink}
    function newOther : TFhirOther;
    {@member newPatientContact
      create a new contact
    }
    {!script nolink}
    function newPatientContact : TFhirPatientContact;
    {@member newPatientAnimal
      create a new animal
    }
    {!script nolink}
    function newPatientAnimal : TFhirPatientAnimal;
    {@member newPatient
      create a new Patient
    }
    {!script nolink}
    function newPatient : TFhirPatient;
    {@member newPractitionerQualification
      create a new qualification
    }
    {!script nolink}
    function newPractitionerQualification : TFhirPractitionerQualification;
    {@member newPractitioner
      create a new Practitioner
    }
    {!script nolink}
    function newPractitioner : TFhirPractitioner;
    {@member newProcedurePerformer
      create a new performer
    }
    {!script nolink}
    function newProcedurePerformer : TFhirProcedurePerformer;
    {@member newProcedureRelatedItem
      create a new relatedItem
    }
    {!script nolink}
    function newProcedureRelatedItem : TFhirProcedureRelatedItem;
    {@member newProcedure
      create a new Procedure
    }
    {!script nolink}
    function newProcedure : TFhirProcedure;
    {@member newProfileStructure
      create a new structure
    }
    {!script nolink}
    function newProfileStructure : TFhirProfileStructure;
    {@member newProfileStructureElement
      create a new element
    }
    {!script nolink}
    function newProfileStructureElement : TFhirProfileStructureElement;
    {@member newProfileStructureElementSlicing
      create a new slicing
    }
    {!script nolink}
    function newProfileStructureElementSlicing : TFhirProfileStructureElementSlicing;
    {@member newProfileStructureElementDefinition
      create a new definition
    }
    {!script nolink}
    function newProfileStructureElementDefinition : TFhirProfileStructureElementDefinition;
    {@member newProfileStructureElementDefinitionType
      create a new type
    }
    {!script nolink}
    function newProfileStructureElementDefinitionType : TFhirProfileStructureElementDefinitionType;
    {@member newProfileStructureElementDefinitionConstraint
      create a new constraint
    }
    {!script nolink}
    function newProfileStructureElementDefinitionConstraint : TFhirProfileStructureElementDefinitionConstraint;
    {@member newProfileStructureElementDefinitionMapping
      create a new mapping
    }
    {!script nolink}
    function newProfileStructureElementDefinitionMapping : TFhirProfileStructureElementDefinitionMapping;
    {@member newProfileExtensionDefn
      create a new extensionDefn
    }
    {!script nolink}
    function newProfileExtensionDefn : TFhirProfileExtensionDefn;
    {@member newProfileBinding
      create a new binding
    }
    {!script nolink}
    function newProfileBinding : TFhirProfileBinding;
    {@member newProfile
      create a new Profile
    }
    {!script nolink}
    function newProfile : TFhirProfile;
    {@member newProvenanceAgent
      create a new agent
    }
    {!script nolink}
    function newProvenanceAgent : TFhirProvenanceAgent;
    {@member newProvenanceEntity
      create a new entity
    }
    {!script nolink}
    function newProvenanceEntity : TFhirProvenanceEntity;
    {@member newProvenance
      create a new Provenance
    }
    {!script nolink}
    function newProvenance : TFhirProvenance;
    {@member newQueryResponse
      create a new response
    }
    {!script nolink}
    function newQueryResponse : TFhirQueryResponse;
    {@member newQuery
      create a new Query
    }
    {!script nolink}
    function newQuery : TFhirQuery;
    {@member newQuestionnaireQuestion
      create a new question
    }
    {!script nolink}
    function newQuestionnaireQuestion : TFhirQuestionnaireQuestion;
    {@member newQuestionnaireGroup
      create a new group
    }
    {!script nolink}
    function newQuestionnaireGroup : TFhirQuestionnaireGroup;
    {@member newQuestionnaire
      create a new Questionnaire
    }
    {!script nolink}
    function newQuestionnaire : TFhirQuestionnaire;
    {@member newRelatedPerson
      create a new RelatedPerson
    }
    {!script nolink}
    function newRelatedPerson : TFhirRelatedPerson;
    {@member newSecurityEventEvent
      create a new event
    }
    {!script nolink}
    function newSecurityEventEvent : TFhirSecurityEventEvent;
    {@member newSecurityEventParticipant
      create a new participant
    }
    {!script nolink}
    function newSecurityEventParticipant : TFhirSecurityEventParticipant;
    {@member newSecurityEventParticipantNetwork
      create a new network
    }
    {!script nolink}
    function newSecurityEventParticipantNetwork : TFhirSecurityEventParticipantNetwork;
    {@member newSecurityEventSource
      create a new source
    }
    {!script nolink}
    function newSecurityEventSource : TFhirSecurityEventSource;
    {@member newSecurityEventObject
      create a new object
    }
    {!script nolink}
    function newSecurityEventObject : TFhirSecurityEventObject;
    {@member newSecurityEventObjectDetail
      create a new detail
    }
    {!script nolink}
    function newSecurityEventObjectDetail : TFhirSecurityEventObjectDetail;
    {@member newSecurityEvent
      create a new SecurityEvent
    }
    {!script nolink}
    function newSecurityEvent : TFhirSecurityEvent;
    {@member newSpecimenSource
      create a new source
    }
    {!script nolink}
    function newSpecimenSource : TFhirSpecimenSource;
    {@member newSpecimenCollection
      create a new collection
    }
    {!script nolink}
    function newSpecimenCollection : TFhirSpecimenCollection;
    {@member newSpecimenTreatment
      create a new treatment
    }
    {!script nolink}
    function newSpecimenTreatment : TFhirSpecimenTreatment;
    {@member newSpecimenContainer
      create a new container
    }
    {!script nolink}
    function newSpecimenContainer : TFhirSpecimenContainer;
    {@member newSpecimen
      create a new Specimen
    }
    {!script nolink}
    function newSpecimen : TFhirSpecimen;
    {@member newSubstance
      create a new Substance
    }
    {!script nolink}
    function newSubstance : TFhirSubstance;
    {@member newSupplyDispense
      create a new dispense
    }
    {!script nolink}
    function newSupplyDispense : TFhirSupplyDispense;
    {@member newSupply
      create a new Supply
    }
    {!script nolink}
    function newSupply : TFhirSupply;
    {@member newValueSetDefine
      create a new define
    }
    {!script nolink}
    function newValueSetDefine : TFhirValueSetDefine;
    {@member newValueSetDefineConcept
      create a new concept
    }
    {!script nolink}
    function newValueSetDefineConcept : TFhirValueSetDefineConcept;
    {@member newValueSetCompose
      create a new compose
    }
    {!script nolink}
    function newValueSetCompose : TFhirValueSetCompose;
    {@member newValueSetComposeInclude
      create a new include
    }
    {!script nolink}
    function newValueSetComposeInclude : TFhirValueSetComposeInclude;
    {@member newValueSetComposeIncludeFilter
      create a new filter
    }
    {!script nolink}
    function newValueSetComposeIncludeFilter : TFhirValueSetComposeIncludeFilter;
    {@member newValueSetExpansion
      create a new expansion
    }
    {!script nolink}
    function newValueSetExpansion : TFhirValueSetExpansion;
    {@member newValueSetExpansionContains
      create a new contains
    }
    {!script nolink}
    function newValueSetExpansionContains : TFhirValueSetExpansionContains;
    {@member newValueSet
      create a new ValueSet
    }
    {!script nolink}
    function newValueSet : TFhirValueSet;
  end;

Const
  CODES_TFhirResourceType : Array[TFhirResourceType] of String = ('', 'AdverseReaction', 'Alert', 'AllergyIntolerance', 'CarePlan', 'Condition', 'Conformance', 'Coverage', 'Device', 'DeviceCapabilities', 'DeviceLog', 'DeviceObservation', 'DiagnosticOrder', 'DiagnosticReport', 'Document', 'DocumentReference', 'Encounter', 'FamilyHistory', 'Group', 'ImagingStudy', 'Immunization', 'ImmunizationProfile', 'List', 'Location', 'Media', 'Medication', 'MedicationAdministration', 'MedicationDispense', 'MedicationPrescription', 'MedicationStatement', 'Message', 'Observation', 'OperationOutcome', 'Order', 'OrderResponse', 'Organization', 'Other', 'Patient', 'Practitioner', 'Procedure', 'Profile', 'Provenance', 'Query', 'Questionnaire', 'RelatedPerson', 'SecurityEvent', 'Specimen', 'Substance', 'Supply', 'ValueSet', 'Binary');
  PLURAL_CODES_TFhirResourceType : Array[TFhirResourceType] of String = ('', 'adversereactions', 'alerts', 'allergyintolerances', 'careplans', 'conditions', 'conformances', 'coverages', 'devices', 'devicecapabilities', 'devicelogs', 'deviceobservations', 'diagnosticorders', 'diagnosticreports', 'documents', 'documentreferences', 'encounters', 'familyhistories', 'groups', 'imagingstudies', 'immunizations', 'immunizationprofiles', 'lists', 'locations', 'media', 'medications', 'medicationadministrations', 'medicationdispenses', 'medicationprescriptions', 'medicationstatements', 'messages', 'observations', 'operationoutcomes', 'orders', 'orderresponses', 'organizations', 'others', 'patients', 'practitioners', 'procedures', 'profiles', 'provenances', 'queries', 'questionnaires', 'relatedpeople', 'securityevents', 'specimen', 'substances', 'supplies', 'valuesets', 'binaries');
  LOWERCASE_CODES_TFhirResourceType : Array[TFhirResourceType] of String = ('', 'adversereaction', 'alert', 'allergyintolerance', 'careplan', 'condition', 'conformance', 'coverage', 'device', 'devicecapabilities', 'devicelog', 'deviceobservation', 'diagnosticorder', 'diagnosticreport', 'document', 'documentreference', 'encounter', 'familyhistory', 'group', 'imagingstudy', 'immunization', 'immunizationprofile', 'list', 'location', 'media', 'medication', 'medicationadministration', 'medicationdispense', 'medicationprescription', 'medicationstatement', 'message', 'observation', 'operationoutcome', 'order', 'orderresponse', 'organization', 'other', 'patient', 'practitioner', 'procedure', 'profile', 'provenance', 'query', 'questionnaire', 'relatedperson', 'securityevent', 'specimen', 'substance', 'supply', 'valueset', 'binary');
  CLASSES_TFhirResourceType : Array[TFhirResourceType] of TFhirResourceClass = (nil, TFhirAdverseReaction, TFhirAlert, TFhirAllergyIntolerance, TFhirCarePlan, TFhirCondition, TFhirConformance, TFhirCoverage, TFhirDevice, TFhirDeviceCapabilities, TFhirDeviceLog, TFhirDeviceObservation, TFhirDiagnosticOrder, TFhirDiagnosticReport, TFhirDocument, TFhirDocumentReference, TFhirEncounter, TFhirFamilyHistory, TFhirGroup, TFhirImagingStudy, TFhirImmunization, TFhirImmunizationProfile, TFhirList, TFhirLocation, TFhirMedia, TFhirMedication, TFhirMedicationAdministration, TFhirMedicationDispense, TFhirMedicationPrescription, TFhirMedicationStatement, TFhirMessage, TFhirObservation, TFhirOperationOutcome, TFhirOrder, TFhirOrderResponse, TFhirOrganization, TFhirOther, TFhirPatient, TFhirPractitioner, TFhirProcedure, TFhirProfile, TFhirProvenance, TFhirQuery, TFhirQuestionnaire, TFhirRelatedPerson, TFhirSecurityEvent, TFhirSpecimen, TFhirSubstance, TFhirSupply, TFhirValueSet, TFhirBinary);
  ALL_RESOURCE_TYPES = [frtAdverseReaction, frtAlert, frtAllergyIntolerance, frtCarePlan, frtCondition, frtConformance, frtCoverage, frtDevice, frtDeviceCapabilities, frtDeviceLog, frtDeviceObservation, frtDiagnosticOrder, frtDiagnosticReport, frtDocument, frtDocumentReference, frtEncounter, frtFamilyHistory, frtGroup, frtImagingStudy, frtImmunization, frtImmunizationProfile, frtList, frtLocation, frtMedia, frtMedication, frtMedicationAdministration, frtMedicationDispense, frtMedicationPrescription, frtMedicationStatement, frtMessage, frtObservation, frtOperationOutcome, frtOrder, frtOrderResponse, frtOrganization, frtOther, frtPatient, frtPractitioner, frtProcedure, frtProfile, frtProvenance, frtQuery, frtQuestionnaire, frtRelatedPerson, frtSecurityEvent, frtSpecimen, frtSubstance, frtSupply, frtValueSet, frtBinary];

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

  FHIR_GENERATED_REVISION = '????';

  FHIR_GENERATED_DATE = '20130930031559';



implementation

{ TFhirResource }

constructor TFhirResource.Create;
begin
  FContainedList := TFhirResourceList.create;
  inherited;
end;

destructor TFhirResource.Destroy;
begin
  FText.Free;
  FContainedList.Free;
  inherited;
end;

procedure TFhirResource.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'contained') then
    list.addAll(FContainedList);
  if (child_name = 'text') then
    list.add(text.Link);
end;

procedure TFhirResource.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'contained', 'Resource', FContainedList.Link));
  oList.add(TFHIRProperty.create(self, 'text', 'Narrative', FText.Link));
end;

procedure TFhirResource.Assign(oSource : TAdvObject);
begin
  inherited;
  FFormat := TFhirResource(oSource).FFormat;
  containedList.assign(TFhirResource(oSource).containedList);
  text := TFhirResource(oSource).text.Clone;
end;

function TFhirResource.Link : TFhirResource;
begin
  result := TFhirResource(inherited Link);
end;

function TFhirResource.Clone : TFhirResource;
begin
  result := TFhirResource(inherited Clone);
end;

procedure TFhirResource.SetText(value : TFhirNarrative);
begin
  FText.Free;
  FText := value;
end;

procedure TFhirResource.SetLanguage(value : TFhirCode);
begin
  FLanguage.Free;
  FLanguage := value;
end;

constructor TFhirBinary.create;
begin
  inherited;
  FContent := TAdvBuffer.create;
end;

destructor TFhirBinary.Destroy;
begin
  FContent.free;
  inherited;
end;

function TFhirBinary.GetResourceType : TFhirResourceType;
begin
  result := frtBinary;
end;


{ TFhirResourceList }
procedure TFhirResourceList.AddItem(value: TFhirResource);
begin
  assert(value.ClassName = 'TFhirResource', 'Attempt to add an item of type '+value.ClassName+' to a List of TFhirResource');
  add(value);
end;


procedure TFhirResourceList.ClearItems;
begin
  Clear;
end;

function TFhirResourceList.Clone: TFhirResourceList;
begin
  result := TFhirResourceList(inherited Clone);
end;

function TFhirResourceList.Count: Integer;
begin
  result := Inherited Count;
end;

function TFhirResourceList.GetItemN(index: Integer): TFhirResource;
begin
  result := TFhirResource(ObjectByIndex[index]);
end;

function TFhirResourceList.IndexOf(value: TFhirResource): Integer;
begin
  result := IndexByReference(value);
end;


procedure TFhirResourceList.InsertItem(index: Integer; value: TFhirResource);
begin
  assert(value is TFhirResource);
  Inherited Insert(index, value);
end;

function TFhirResourceList.Item(index: Integer): TFhirResource;
begin
  result := TFhirResource(ObjectByIndex[index]);
end;

function TFhirResourceList.Link: TFhirResourceList;
begin
  result := TFhirResourceList(inherited Link);
end;

procedure TFhirResourceList.Remove(index: Integer);
begin
  DeleteByIndex(index);
end;

procedure TFhirResourceList.SetItemByIndex(index: Integer; value: TFhirResource);
begin
  assert(value is TFhirResource);
  FhirResources[index] := value;
end;

procedure TFhirResourceList.SetItemN(index: Integer; value: TFhirResource);
begin
  assert(value is TFhirResource);
  ObjectByIndex[index] := value;
end;

{ TFhirAdverseReaction }

constructor TFhirAdverseReaction.Create;
begin
  inherited;
  FSymptomList := TFhirAdverseReactionSymptomList.Create;
  FExposureList := TFhirAdverseReactionExposureList.Create;
end;

destructor TFhirAdverseReaction.Destroy;
begin
  FReactionDate.free;
  FSubject.free;
  FDidNotOccurFlag.free;
  FRecorder.free;
  FSymptomList.Free;
  FExposureList.Free;
  inherited;
end;

function TFhirAdverseReaction.GetResourceType : TFhirResourceType;
begin
  result := frtAdverseReaction;
end;

procedure TFhirAdverseReaction.Assign(oSource : TAdvObject);
begin
  inherited;
  reactionDate := TFhirAdverseReaction(oSource).reactionDate.Clone;
  subject := TFhirAdverseReaction(oSource).subject.Clone;
  didNotOccurFlag := TFhirAdverseReaction(oSource).didNotOccurFlag.Clone;
  recorder := TFhirAdverseReaction(oSource).recorder.Clone;
  FSymptomList.Assign(TFhirAdverseReaction(oSource).FSymptomList);
  FExposureList.Assign(TFhirAdverseReaction(oSource).FExposureList);
end;

procedure TFhirAdverseReaction.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'reactionDate') Then
     list.add(ReactionDate.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'didNotOccurFlag') Then
     list.add(DidNotOccurFlag.Link);
  if (child_name = 'recorder') Then
     list.add(Recorder.Link);
  if (child_name = 'symptom') Then
     list.addAll(FSymptomList);
  if (child_name = 'exposure') Then
     list.addAll(FExposureList);
end;

procedure TFhirAdverseReaction.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'reactionDate', 'dateTime', FReactionDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'didNotOccurFlag', 'boolean', FDidNotOccurFlag.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'recorder', 'Resource(Practitioner|Patient)', FRecorder.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'symptom', '', FSymptomList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'exposure', '', FExposureList.Link)){3};
end;

function TFhirAdverseReaction.Link : TFhirAdverseReaction;
begin
  result := TFhirAdverseReaction(inherited Link);
end;

function TFhirAdverseReaction.Clone : TFhirAdverseReaction;
begin
  result := TFhirAdverseReaction(inherited Clone);
end;

{ TFhirAdverseReaction }

Procedure TFhirAdverseReaction.SetReactionDate(value : TFhirDateTime);
begin
  FReactionDate.free;
  FReactionDate := value;
end;

Function TFhirAdverseReaction.GetReactionDateST : TDateAndTime;
begin
  if FReactionDate = nil then
    result := nil
  else
    result := ReactionDate.value;
end;

Procedure TFhirAdverseReaction.SetReactionDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FReactionDate = nil then
      FReactionDate := TFhirDateTime.create;
    FReactionDate.value := value
  end
  else if FReactionDate <> nil then
    FReactionDate.value := nil;
end;

Procedure TFhirAdverseReaction.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirAdverseReaction.SetDidNotOccurFlag(value : TFhirBoolean);
begin
  FDidNotOccurFlag.free;
  FDidNotOccurFlag := value;
end;

Function TFhirAdverseReaction.GetDidNotOccurFlagST : String;
begin
  if FDidNotOccurFlag = nil then
    result := ''
  else
    result := DidNotOccurFlag.value;
end;

Procedure TFhirAdverseReaction.SetDidNotOccurFlagST(value : String);
begin
  if value <> '' then
  begin
    if FDidNotOccurFlag = nil then
      FDidNotOccurFlag := TFhirBoolean.create;
    FDidNotOccurFlag.value := value
  end
  else if FDidNotOccurFlag <> nil then
    FDidNotOccurFlag.value := '';
end;

Procedure TFhirAdverseReaction.SetRecorder(value : TFhirResourceReference{Resource});
begin
  FRecorder.free;
  FRecorder := value;
end;


{ TFhirAlert }

constructor TFhirAlert.Create;
begin
  inherited;
end;

destructor TFhirAlert.Destroy;
begin
  FCategory.free;
  FStatus.free;
  FSubject.free;
  FAuthor.free;
  FNote.free;
  inherited;
end;

function TFhirAlert.GetResourceType : TFhirResourceType;
begin
  result := frtAlert;
end;

procedure TFhirAlert.Assign(oSource : TAdvObject);
begin
  inherited;
  category := TFhirAlert(oSource).category.Clone;
  FStatus := TFhirAlert(oSource).FStatus.Link;
  subject := TFhirAlert(oSource).subject.Clone;
  author := TFhirAlert(oSource).author.Clone;
  note := TFhirAlert(oSource).note.Clone;
end;

procedure TFhirAlert.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'category') Then
     list.add(Category.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'author') Then
     list.add(Author.Link);
  if (child_name = 'note') Then
     list.add(Note.Link);
end;

procedure TFhirAlert.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'category', 'CodeableConcept', FCategory.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'author', 'Resource(Practitioner|Patient|Device)', FAuthor.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'note', 'string', FNote.Link.Link));{2}
end;

function TFhirAlert.Link : TFhirAlert;
begin
  result := TFhirAlert(inherited Link);
end;

function TFhirAlert.Clone : TFhirAlert;
begin
  result := TFhirAlert(inherited Clone);
end;

{ TFhirAlert }

Procedure TFhirAlert.SetCategory(value : TFhirCodeableConcept);
begin
  FCategory.free;
  FCategory := value;
end;

Procedure TFhirAlert.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirAlert.GetStatusST : TFhirAlertStatus;
begin
  if FStatus = nil then
    result := TFhirAlertStatus(0)
  else
    result := TFhirAlertStatus(StringArrayIndexOf(CODES_TFhirAlertStatus, Status.value));
end;

Procedure TFhirAlert.SetStatusST(value : TFhirAlertStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirAlertStatus[value]);
end;

Procedure TFhirAlert.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirAlert.SetAuthor(value : TFhirResourceReference{Resource});
begin
  FAuthor.free;
  FAuthor := value;
end;

Procedure TFhirAlert.SetNote(value : TFhirString);
begin
  FNote.free;
  FNote := value;
end;

Function TFhirAlert.GetNoteST : String;
begin
  if FNote = nil then
    result := ''
  else
    result := Note.value;
end;

Procedure TFhirAlert.SetNoteST(value : String);
begin
  if value <> '' then
  begin
    if FNote = nil then
      FNote := TFhirString.create;
    FNote.value := value
  end
  else if FNote <> nil then
    FNote.value := '';
end;


{ TFhirAllergyIntolerance }

constructor TFhirAllergyIntolerance.Create;
begin
  inherited;
  FReactionList := TFhirResourceReferenceList{TFhirAdverseReaction}.Create;
  FSensitivityTestList := TFhirResourceReferenceList{TFhirObservation}.Create;
end;

destructor TFhirAllergyIntolerance.Destroy;
begin
  FIdentifier.free;
  FCriticality.free;
  FSensitivityType.free;
  FRecordedDate.free;
  FStatus.free;
  FSubject.free;
  FRecorder.free;
  FSubstance.free;
  FReactionList.Free;
  FSensitivityTestList.Free;
  inherited;
end;

function TFhirAllergyIntolerance.GetResourceType : TFhirResourceType;
begin
  result := frtAllergyIntolerance;
end;

procedure TFhirAllergyIntolerance.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirAllergyIntolerance(oSource).identifier.Clone;
  FCriticality := TFhirAllergyIntolerance(oSource).FCriticality.Link;
  FSensitivityType := TFhirAllergyIntolerance(oSource).FSensitivityType.Link;
  recordedDate := TFhirAllergyIntolerance(oSource).recordedDate.Clone;
  FStatus := TFhirAllergyIntolerance(oSource).FStatus.Link;
  subject := TFhirAllergyIntolerance(oSource).subject.Clone;
  recorder := TFhirAllergyIntolerance(oSource).recorder.Clone;
  substance := TFhirAllergyIntolerance(oSource).substance.Clone;
  FReactionList.Assign(TFhirAllergyIntolerance(oSource).FReactionList);
  FSensitivityTestList.Assign(TFhirAllergyIntolerance(oSource).FSensitivityTestList);
end;

procedure TFhirAllergyIntolerance.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'criticality') Then
     list.add(FCriticality.Link);
  if (child_name = 'sensitivityType') Then
     list.add(FSensitivityType.Link);
  if (child_name = 'recordedDate') Then
     list.add(RecordedDate.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'recorder') Then
     list.add(Recorder.Link);
  if (child_name = 'substance') Then
     list.add(Substance.Link);
  if (child_name = 'reaction') Then
     list.addAll(FReactionList);
  if (child_name = 'sensitivityTest') Then
     list.addAll(FSensitivityTestList);
end;

procedure TFhirAllergyIntolerance.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'criticality', 'code', FCriticality.Link));{1}
  oList.add(TFHIRProperty.create(self, 'sensitivityType', 'code', FSensitivityType.Link));{1}
  oList.add(TFHIRProperty.create(self, 'recordedDate', 'dateTime', FRecordedDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'recorder', 'Resource(Practitioner|Patient)', FRecorder.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'substance', 'Resource(Substance)', FSubstance.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reaction', 'Resource(AdverseReaction)', FReactionList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'sensitivityTest', 'Resource(Observation)', FSensitivityTestList.Link)){3};
end;

function TFhirAllergyIntolerance.Link : TFhirAllergyIntolerance;
begin
  result := TFhirAllergyIntolerance(inherited Link);
end;

function TFhirAllergyIntolerance.Clone : TFhirAllergyIntolerance;
begin
  result := TFhirAllergyIntolerance(inherited Clone);
end;

{ TFhirAllergyIntolerance }

Procedure TFhirAllergyIntolerance.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirAllergyIntolerance.SetCriticality(value : TFhirEnum);
begin
  FCriticality.free;
  FCriticality := value;
end;

Function TFhirAllergyIntolerance.GetCriticalityST : TFhirCriticality;
begin
  if FCriticality = nil then
    result := TFhirCriticality(0)
  else
    result := TFhirCriticality(StringArrayIndexOf(CODES_TFhirCriticality, Criticality.value));
end;

Procedure TFhirAllergyIntolerance.SetCriticalityST(value : TFhirCriticality);
begin
  if ord(value) = 0 then
    Criticality := nil
  else
    Criticality := TFhirEnum.create(CODES_TFhirCriticality[value]);
end;

Procedure TFhirAllergyIntolerance.SetSensitivityType(value : TFhirEnum);
begin
  FSensitivityType.free;
  FSensitivityType := value;
end;

Function TFhirAllergyIntolerance.GetSensitivityTypeST : TFhirSensitivitytype;
begin
  if FSensitivityType = nil then
    result := TFhirSensitivitytype(0)
  else
    result := TFhirSensitivitytype(StringArrayIndexOf(CODES_TFhirSensitivitytype, SensitivityType.value));
end;

Procedure TFhirAllergyIntolerance.SetSensitivityTypeST(value : TFhirSensitivitytype);
begin
  if ord(value) = 0 then
    SensitivityType := nil
  else
    SensitivityType := TFhirEnum.create(CODES_TFhirSensitivitytype[value]);
end;

Procedure TFhirAllergyIntolerance.SetRecordedDate(value : TFhirDateTime);
begin
  FRecordedDate.free;
  FRecordedDate := value;
end;

Function TFhirAllergyIntolerance.GetRecordedDateST : TDateAndTime;
begin
  if FRecordedDate = nil then
    result := nil
  else
    result := RecordedDate.value;
end;

Procedure TFhirAllergyIntolerance.SetRecordedDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FRecordedDate = nil then
      FRecordedDate := TFhirDateTime.create;
    FRecordedDate.value := value
  end
  else if FRecordedDate <> nil then
    FRecordedDate.value := nil;
end;

Procedure TFhirAllergyIntolerance.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirAllergyIntolerance.GetStatusST : TFhirSensitivitystatus;
begin
  if FStatus = nil then
    result := TFhirSensitivitystatus(0)
  else
    result := TFhirSensitivitystatus(StringArrayIndexOf(CODES_TFhirSensitivitystatus, Status.value));
end;

Procedure TFhirAllergyIntolerance.SetStatusST(value : TFhirSensitivitystatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirSensitivitystatus[value]);
end;

Procedure TFhirAllergyIntolerance.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirAllergyIntolerance.SetRecorder(value : TFhirResourceReference{Resource});
begin
  FRecorder.free;
  FRecorder := value;
end;

Procedure TFhirAllergyIntolerance.SetSubstance(value : TFhirResourceReference{TFhirSubstance});
begin
  FSubstance.free;
  FSubstance := value;
end;


{ TFhirCarePlan }

constructor TFhirCarePlan.Create;
begin
  inherited;
  FConcernList := TFhirResourceReferenceList{TFhirCondition}.Create;
  FParticipantList := TFhirCarePlanParticipantList.Create;
  FGoalList := TFhirCarePlanGoalList.Create;
  FActivityList := TFhirCarePlanActivityList.Create;
end;

destructor TFhirCarePlan.Destroy;
begin
  FIdentifier.free;
  FPatient.free;
  FStatus.free;
  FPeriod.free;
  FModified.free;
  FConcernList.Free;
  FParticipantList.Free;
  FGoalList.Free;
  FActivityList.Free;
  FNotes.free;
  inherited;
end;

function TFhirCarePlan.GetResourceType : TFhirResourceType;
begin
  result := frtCarePlan;
end;

procedure TFhirCarePlan.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirCarePlan(oSource).identifier.Clone;
  patient := TFhirCarePlan(oSource).patient.Clone;
  FStatus := TFhirCarePlan(oSource).FStatus.Link;
  period := TFhirCarePlan(oSource).period.Clone;
  modified := TFhirCarePlan(oSource).modified.Clone;
  FConcernList.Assign(TFhirCarePlan(oSource).FConcernList);
  FParticipantList.Assign(TFhirCarePlan(oSource).FParticipantList);
  FGoalList.Assign(TFhirCarePlan(oSource).FGoalList);
  FActivityList.Assign(TFhirCarePlan(oSource).FActivityList);
  notes := TFhirCarePlan(oSource).notes.Clone;
end;

procedure TFhirCarePlan.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'patient') Then
     list.add(Patient.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'period') Then
     list.add(Period.Link);
  if (child_name = 'modified') Then
     list.add(Modified.Link);
  if (child_name = 'concern') Then
     list.addAll(FConcernList);
  if (child_name = 'participant') Then
     list.addAll(FParticipantList);
  if (child_name = 'goal') Then
     list.addAll(FGoalList);
  if (child_name = 'activity') Then
     list.addAll(FActivityList);
  if (child_name = 'notes') Then
     list.add(Notes.Link);
end;

procedure TFhirCarePlan.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'patient', 'Resource(Patient)', FPatient.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'period', 'Period', FPeriod.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'modified', 'dateTime', FModified.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'concern', 'Resource(Condition)', FConcernList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'participant', '', FParticipantList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'goal', '', FGoalList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'activity', '', FActivityList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'notes', 'string', FNotes.Link.Link));{2}
end;

function TFhirCarePlan.Link : TFhirCarePlan;
begin
  result := TFhirCarePlan(inherited Link);
end;

function TFhirCarePlan.Clone : TFhirCarePlan;
begin
  result := TFhirCarePlan(inherited Clone);
end;

{ TFhirCarePlan }

Procedure TFhirCarePlan.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirCarePlan.SetPatient(value : TFhirResourceReference{TFhirPatient});
begin
  FPatient.free;
  FPatient := value;
end;

Procedure TFhirCarePlan.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirCarePlan.GetStatusST : TFhirCarePlanStatus;
begin
  if FStatus = nil then
    result := TFhirCarePlanStatus(0)
  else
    result := TFhirCarePlanStatus(StringArrayIndexOf(CODES_TFhirCarePlanStatus, Status.value));
end;

Procedure TFhirCarePlan.SetStatusST(value : TFhirCarePlanStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirCarePlanStatus[value]);
end;

Procedure TFhirCarePlan.SetPeriod(value : TFhirPeriod);
begin
  FPeriod.free;
  FPeriod := value;
end;

Procedure TFhirCarePlan.SetModified(value : TFhirDateTime);
begin
  FModified.free;
  FModified := value;
end;

Function TFhirCarePlan.GetModifiedST : TDateAndTime;
begin
  if FModified = nil then
    result := nil
  else
    result := Modified.value;
end;

Procedure TFhirCarePlan.SetModifiedST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FModified = nil then
      FModified := TFhirDateTime.create;
    FModified.value := value
  end
  else if FModified <> nil then
    FModified.value := nil;
end;

Procedure TFhirCarePlan.SetNotes(value : TFhirString);
begin
  FNotes.free;
  FNotes := value;
end;

Function TFhirCarePlan.GetNotesST : String;
begin
  if FNotes = nil then
    result := ''
  else
    result := Notes.value;
end;

Procedure TFhirCarePlan.SetNotesST(value : String);
begin
  if value <> '' then
  begin
    if FNotes = nil then
      FNotes := TFhirString.create;
    FNotes.value := value
  end
  else if FNotes <> nil then
    FNotes.value := '';
end;


{ TFhirCondition }

constructor TFhirCondition.Create;
begin
  inherited;
  FEvidenceList := TFhirConditionEvidenceList.Create;
  FLocationList := TFhirConditionLocationList.Create;
  FRelatedItemList := TFhirConditionRelatedItemList.Create;
end;

destructor TFhirCondition.Destroy;
begin
  FSubject.free;
  FEncounter.free;
  FAsserter.free;
  FDateAsserted.free;
  FCode.free;
  FCategory.free;
  FStatus.free;
  FCertainty.free;
  FSeverity.free;
  FOnset.free;
  FAbatement.free;
  FStage.free;
  FEvidenceList.Free;
  FLocationList.Free;
  FRelatedItemList.Free;
  FNotes.free;
  inherited;
end;

function TFhirCondition.GetResourceType : TFhirResourceType;
begin
  result := frtCondition;
end;

procedure TFhirCondition.Assign(oSource : TAdvObject);
begin
  inherited;
  subject := TFhirCondition(oSource).subject.Clone;
  encounter := TFhirCondition(oSource).encounter.Clone;
  asserter := TFhirCondition(oSource).asserter.Clone;
  dateAsserted := TFhirCondition(oSource).dateAsserted.Clone;
  code := TFhirCondition(oSource).code.Clone;
  category := TFhirCondition(oSource).category.Clone;
  FStatus := TFhirCondition(oSource).FStatus.Link;
  certainty := TFhirCondition(oSource).certainty.Clone;
  severity := TFhirCondition(oSource).severity.Clone;
  onset := TFhirCondition(oSource).onset.Clone;
  abatement := TFhirCondition(oSource).abatement.Clone;
  stage := TFhirCondition(oSource).stage.Clone;
  FEvidenceList.Assign(TFhirCondition(oSource).FEvidenceList);
  FLocationList.Assign(TFhirCondition(oSource).FLocationList);
  FRelatedItemList.Assign(TFhirCondition(oSource).FRelatedItemList);
  notes := TFhirCondition(oSource).notes.Clone;
end;

procedure TFhirCondition.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'encounter') Then
     list.add(Encounter.Link);
  if (child_name = 'asserter') Then
     list.add(Asserter.Link);
  if (child_name = 'dateAsserted') Then
     list.add(DateAsserted.Link);
  if (child_name = 'code') Then
     list.add(Code.Link);
  if (child_name = 'category') Then
     list.add(Category.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'certainty') Then
     list.add(Certainty.Link);
  if (child_name = 'severity') Then
     list.add(Severity.Link);
  if (child_name = 'onset') Then
     list.add(Onset.Link);
  if (child_name = 'abatement') Then
     list.add(Abatement.Link);
  if (child_name = 'stage') Then
     list.add(Stage.Link);
  if (child_name = 'evidence') Then
     list.addAll(FEvidenceList);
  if (child_name = 'location') Then
     list.addAll(FLocationList);
  if (child_name = 'relatedItem') Then
     list.addAll(FRelatedItemList);
  if (child_name = 'notes') Then
     list.add(Notes.Link);
end;

procedure TFhirCondition.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'encounter', 'Resource(Encounter)', FEncounter.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'asserter', 'Resource(Practitioner|Patient)', FAsserter.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'dateAsserted', 'date', FDateAsserted.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'code', 'CodeableConcept', FCode.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'category', 'CodeableConcept', FCategory.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'certainty', 'CodeableConcept', FCertainty.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'severity', 'CodeableConcept', FSeverity.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'onset[x]', 'date|Age', FOnset.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'abatement[x]', 'date|Age|boolean', FAbatement.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'stage', '', FStage.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'evidence', '', FEvidenceList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'location', '', FLocationList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'relatedItem', '', FRelatedItemList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'notes', 'string', FNotes.Link.Link));{2}
end;

function TFhirCondition.Link : TFhirCondition;
begin
  result := TFhirCondition(inherited Link);
end;

function TFhirCondition.Clone : TFhirCondition;
begin
  result := TFhirCondition(inherited Clone);
end;

{ TFhirCondition }

Procedure TFhirCondition.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirCondition.SetEncounter(value : TFhirResourceReference{TFhirEncounter});
begin
  FEncounter.free;
  FEncounter := value;
end;

Procedure TFhirCondition.SetAsserter(value : TFhirResourceReference{Resource});
begin
  FAsserter.free;
  FAsserter := value;
end;

Procedure TFhirCondition.SetDateAsserted(value : TFhirDate);
begin
  FDateAsserted.free;
  FDateAsserted := value;
end;

Function TFhirCondition.GetDateAssertedST : TDateAndTime;
begin
  if FDateAsserted = nil then
    result := nil
  else
    result := DateAsserted.value;
end;

Procedure TFhirCondition.SetDateAssertedST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDateAsserted = nil then
      FDateAsserted := TFhirDate.create;
    FDateAsserted.value := value
  end
  else if FDateAsserted <> nil then
    FDateAsserted.value := nil;
end;

Procedure TFhirCondition.SetCode(value : TFhirCodeableConcept);
begin
  FCode.free;
  FCode := value;
end;

Procedure TFhirCondition.SetCategory(value : TFhirCodeableConcept);
begin
  FCategory.free;
  FCategory := value;
end;

Procedure TFhirCondition.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirCondition.GetStatusST : TFhirConditionStatus;
begin
  if FStatus = nil then
    result := TFhirConditionStatus(0)
  else
    result := TFhirConditionStatus(StringArrayIndexOf(CODES_TFhirConditionStatus, Status.value));
end;

Procedure TFhirCondition.SetStatusST(value : TFhirConditionStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirConditionStatus[value]);
end;

Procedure TFhirCondition.SetCertainty(value : TFhirCodeableConcept);
begin
  FCertainty.free;
  FCertainty := value;
end;

Procedure TFhirCondition.SetSeverity(value : TFhirCodeableConcept);
begin
  FSeverity.free;
  FSeverity := value;
end;

Procedure TFhirCondition.SetOnset(value : TFhirType);
begin
  FOnset.free;
  FOnset := value;
end;

Procedure TFhirCondition.SetAbatement(value : TFhirType);
begin
  FAbatement.free;
  FAbatement := value;
end;

Procedure TFhirCondition.SetStage(value : TFhirConditionStage);
begin
  FStage.free;
  FStage := value;
end;

Procedure TFhirCondition.SetNotes(value : TFhirString);
begin
  FNotes.free;
  FNotes := value;
end;

Function TFhirCondition.GetNotesST : String;
begin
  if FNotes = nil then
    result := ''
  else
    result := Notes.value;
end;

Procedure TFhirCondition.SetNotesST(value : String);
begin
  if value <> '' then
  begin
    if FNotes = nil then
      FNotes := TFhirString.create;
    FNotes.value := value
  end
  else if FNotes <> nil then
    FNotes.value := '';
end;


{ TFhirConformance }

constructor TFhirConformance.Create;
begin
  inherited;
  FTelecomList := TFhirContactList.Create;
  FFormatList := TFhirCodeList.Create;
  FRestList := TFhirConformanceRestList.Create;
  FMessagingList := TFhirConformanceMessagingList.Create;
  FDocumentList := TFhirConformanceDocumentList.Create;
end;

destructor TFhirConformance.Destroy;
begin
  FIdentifier.free;
  FVersion.free;
  FName.free;
  FPublisher.free;
  FTelecomList.Free;
  FDescription.free;
  FStatus.free;
  FExperimental.free;
  FDate.free;
  FSoftware.free;
  FImplementation_.free;
  FFhirVersion.free;
  FAcceptUnknown.free;
  FFormatList.Free;
  FRestList.Free;
  FMessagingList.Free;
  FDocumentList.Free;
  inherited;
end;

function TFhirConformance.GetResourceType : TFhirResourceType;
begin
  result := frtConformance;
end;

procedure TFhirConformance.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirConformance(oSource).identifier.Clone;
  version := TFhirConformance(oSource).version.Clone;
  name := TFhirConformance(oSource).name.Clone;
  publisher := TFhirConformance(oSource).publisher.Clone;
  FTelecomList.Assign(TFhirConformance(oSource).FTelecomList);
  description := TFhirConformance(oSource).description.Clone;
  FStatus := TFhirConformance(oSource).FStatus.Link;
  experimental := TFhirConformance(oSource).experimental.Clone;
  date := TFhirConformance(oSource).date.Clone;
  software := TFhirConformance(oSource).software.Clone;
  implementation_ := TFhirConformance(oSource).implementation_.Clone;
  fhirVersion := TFhirConformance(oSource).fhirVersion.Clone;
  acceptUnknown := TFhirConformance(oSource).acceptUnknown.Clone;
  FFormatList.Assign(TFhirConformance(oSource).FFormatList);
  FRestList.Assign(TFhirConformance(oSource).FRestList);
  FMessagingList.Assign(TFhirConformance(oSource).FMessagingList);
  FDocumentList.Assign(TFhirConformance(oSource).FDocumentList);
end;

procedure TFhirConformance.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'version') Then
     list.add(Version.Link);
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'publisher') Then
     list.add(Publisher.Link);
  if (child_name = 'telecom') Then
     list.addAll(FTelecomList);
  if (child_name = 'description') Then
     list.add(Description.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'experimental') Then
     list.add(Experimental.Link);
  if (child_name = 'date') Then
     list.add(Date.Link);
  if (child_name = 'software') Then
     list.add(Software.Link);
  if (child_name = 'implementation_') Then
     list.add(Implementation_.Link);
  if (child_name = 'fhirVersion') Then
     list.add(FhirVersion.Link);
  if (child_name = 'acceptUnknown') Then
     list.add(AcceptUnknown.Link);
  if (child_name = 'format') Then
     list.addAll(FFormatList);
  if (child_name = 'rest') Then
     list.addAll(FRestList);
  if (child_name = 'messaging') Then
     list.addAll(FMessagingList);
  if (child_name = 'document') Then
     list.addAll(FDocumentList);
end;

procedure TFhirConformance.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'string', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'version', 'string', FVersion.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'name', 'string', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'publisher', 'string', FPublisher.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'telecom', 'Contact', FTelecomList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'description', 'string', FDescription.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'experimental', 'boolean', FExperimental.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'date', 'dateTime', FDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'software', '', FSoftware.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'implementation', '', FImplementation_.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'fhirVersion', 'id', FFhirVersion.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'acceptUnknown', 'boolean', FAcceptUnknown.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'format', 'code', FFormatList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'rest', '', FRestList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'messaging', '', FMessagingList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'document', '', FDocumentList.Link)){3};
end;

function TFhirConformance.Link : TFhirConformance;
begin
  result := TFhirConformance(inherited Link);
end;

function TFhirConformance.Clone : TFhirConformance;
begin
  result := TFhirConformance(inherited Clone);
end;

{ TFhirConformance }

Procedure TFhirConformance.SetIdentifier(value : TFhirString);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Function TFhirConformance.GetIdentifierST : String;
begin
  if FIdentifier = nil then
    result := ''
  else
    result := Identifier.value;
end;

Procedure TFhirConformance.SetIdentifierST(value : String);
begin
  if value <> '' then
  begin
    if FIdentifier = nil then
      FIdentifier := TFhirString.create;
    FIdentifier.value := value
  end
  else if FIdentifier <> nil then
    FIdentifier.value := '';
end;

Procedure TFhirConformance.SetVersion(value : TFhirString);
begin
  FVersion.free;
  FVersion := value;
end;

Function TFhirConformance.GetVersionST : String;
begin
  if FVersion = nil then
    result := ''
  else
    result := Version.value;
end;

Procedure TFhirConformance.SetVersionST(value : String);
begin
  if value <> '' then
  begin
    if FVersion = nil then
      FVersion := TFhirString.create;
    FVersion.value := value
  end
  else if FVersion <> nil then
    FVersion.value := '';
end;

Procedure TFhirConformance.SetName(value : TFhirString);
begin
  FName.free;
  FName := value;
end;

Function TFhirConformance.GetNameST : String;
begin
  if FName = nil then
    result := ''
  else
    result := Name.value;
end;

Procedure TFhirConformance.SetNameST(value : String);
begin
  if value <> '' then
  begin
    if FName = nil then
      FName := TFhirString.create;
    FName.value := value
  end
  else if FName <> nil then
    FName.value := '';
end;

Procedure TFhirConformance.SetPublisher(value : TFhirString);
begin
  FPublisher.free;
  FPublisher := value;
end;

Function TFhirConformance.GetPublisherST : String;
begin
  if FPublisher = nil then
    result := ''
  else
    result := Publisher.value;
end;

Procedure TFhirConformance.SetPublisherST(value : String);
begin
  if value <> '' then
  begin
    if FPublisher = nil then
      FPublisher := TFhirString.create;
    FPublisher.value := value
  end
  else if FPublisher <> nil then
    FPublisher.value := '';
end;

Procedure TFhirConformance.SetDescription(value : TFhirString);
begin
  FDescription.free;
  FDescription := value;
end;

Function TFhirConformance.GetDescriptionST : String;
begin
  if FDescription = nil then
    result := ''
  else
    result := Description.value;
end;

Procedure TFhirConformance.SetDescriptionST(value : String);
begin
  if value <> '' then
  begin
    if FDescription = nil then
      FDescription := TFhirString.create;
    FDescription.value := value
  end
  else if FDescription <> nil then
    FDescription.value := '';
end;

Procedure TFhirConformance.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirConformance.GetStatusST : TFhirConformanceStatementStatus;
begin
  if FStatus = nil then
    result := TFhirConformanceStatementStatus(0)
  else
    result := TFhirConformanceStatementStatus(StringArrayIndexOf(CODES_TFhirConformanceStatementStatus, Status.value));
end;

Procedure TFhirConformance.SetStatusST(value : TFhirConformanceStatementStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirConformanceStatementStatus[value]);
end;

Procedure TFhirConformance.SetExperimental(value : TFhirBoolean);
begin
  FExperimental.free;
  FExperimental := value;
end;

Function TFhirConformance.GetExperimentalST : String;
begin
  if FExperimental = nil then
    result := ''
  else
    result := Experimental.value;
end;

Procedure TFhirConformance.SetExperimentalST(value : String);
begin
  if value <> '' then
  begin
    if FExperimental = nil then
      FExperimental := TFhirBoolean.create;
    FExperimental.value := value
  end
  else if FExperimental <> nil then
    FExperimental.value := '';
end;

Procedure TFhirConformance.SetDate(value : TFhirDateTime);
begin
  FDate.free;
  FDate := value;
end;

Function TFhirConformance.GetDateST : TDateAndTime;
begin
  if FDate = nil then
    result := nil
  else
    result := Date.value;
end;

Procedure TFhirConformance.SetDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDate = nil then
      FDate := TFhirDateTime.create;
    FDate.value := value
  end
  else if FDate <> nil then
    FDate.value := nil;
end;

Procedure TFhirConformance.SetSoftware(value : TFhirConformanceSoftware);
begin
  FSoftware.free;
  FSoftware := value;
end;

Procedure TFhirConformance.SetImplementation_(value : TFhirConformanceImplementation);
begin
  FImplementation_.free;
  FImplementation_ := value;
end;

Procedure TFhirConformance.SetFhirVersion(value : TFhirId);
begin
  FFhirVersion.free;
  FFhirVersion := value;
end;

Function TFhirConformance.GetFhirVersionST : String;
begin
  if FFhirVersion = nil then
    result := ''
  else
    result := FhirVersion.value;
end;

Procedure TFhirConformance.SetFhirVersionST(value : String);
begin
  if value <> '' then
  begin
    if FFhirVersion = nil then
      FFhirVersion := TFhirId.create;
    FFhirVersion.value := value
  end
  else if FFhirVersion <> nil then
    FFhirVersion.value := '';
end;

Procedure TFhirConformance.SetAcceptUnknown(value : TFhirBoolean);
begin
  FAcceptUnknown.free;
  FAcceptUnknown := value;
end;

Function TFhirConformance.GetAcceptUnknownST : String;
begin
  if FAcceptUnknown = nil then
    result := ''
  else
    result := AcceptUnknown.value;
end;

Procedure TFhirConformance.SetAcceptUnknownST(value : String);
begin
  if value <> '' then
  begin
    if FAcceptUnknown = nil then
      FAcceptUnknown := TFhirBoolean.create;
    FAcceptUnknown.value := value
  end
  else if FAcceptUnknown <> nil then
    FAcceptUnknown.value := '';
end;


{ TFhirCoverage }

constructor TFhirCoverage.Create;
begin
  inherited;
end;

destructor TFhirCoverage.Destroy;
begin
  FIssuer.free;
  FPeriod.free;
  FType_.free;
  FIdentifier.free;
  FGroup.free;
  FPlan.free;
  FSubplan.free;
  FDependent.free;
  FSequence.free;
  FSubscriber.free;
  inherited;
end;

function TFhirCoverage.GetResourceType : TFhirResourceType;
begin
  result := frtCoverage;
end;

procedure TFhirCoverage.Assign(oSource : TAdvObject);
begin
  inherited;
  issuer := TFhirCoverage(oSource).issuer.Clone;
  period := TFhirCoverage(oSource).period.Clone;
  type_ := TFhirCoverage(oSource).type_.Clone;
  identifier := TFhirCoverage(oSource).identifier.Clone;
  group := TFhirCoverage(oSource).group.Clone;
  plan := TFhirCoverage(oSource).plan.Clone;
  subplan := TFhirCoverage(oSource).subplan.Clone;
  dependent := TFhirCoverage(oSource).dependent.Clone;
  sequence := TFhirCoverage(oSource).sequence.Clone;
  subscriber := TFhirCoverage(oSource).subscriber.Clone;
end;

procedure TFhirCoverage.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'issuer') Then
     list.add(Issuer.Link);
  if (child_name = 'period') Then
     list.add(Period.Link);
  if (child_name = 'type_') Then
     list.add(Type_.Link);
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'group') Then
     list.add(Group.Link);
  if (child_name = 'plan') Then
     list.add(Plan.Link);
  if (child_name = 'subplan') Then
     list.add(Subplan.Link);
  if (child_name = 'dependent') Then
     list.add(Dependent.Link);
  if (child_name = 'sequence') Then
     list.add(Sequence.Link);
  if (child_name = 'subscriber') Then
     list.add(Subscriber.Link);
end;

procedure TFhirCoverage.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'issuer', 'Resource(Organization)', FIssuer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'period', 'Period', FPeriod.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'type', 'Coding', FType_.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'group', 'Identifier', FGroup.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'plan', 'Identifier', FPlan.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subplan', 'Identifier', FSubplan.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'dependent', 'integer', FDependent.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'sequence', 'integer', FSequence.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subscriber', '', FSubscriber.Link.Link));{2}
end;

function TFhirCoverage.Link : TFhirCoverage;
begin
  result := TFhirCoverage(inherited Link);
end;

function TFhirCoverage.Clone : TFhirCoverage;
begin
  result := TFhirCoverage(inherited Clone);
end;

{ TFhirCoverage }

Procedure TFhirCoverage.SetIssuer(value : TFhirResourceReference{TFhirOrganization});
begin
  FIssuer.free;
  FIssuer := value;
end;

Procedure TFhirCoverage.SetPeriod(value : TFhirPeriod);
begin
  FPeriod.free;
  FPeriod := value;
end;

Procedure TFhirCoverage.SetType_(value : TFhirCoding);
begin
  FType_.free;
  FType_ := value;
end;

Procedure TFhirCoverage.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirCoverage.SetGroup(value : TFhirIdentifier);
begin
  FGroup.free;
  FGroup := value;
end;

Procedure TFhirCoverage.SetPlan(value : TFhirIdentifier);
begin
  FPlan.free;
  FPlan := value;
end;

Procedure TFhirCoverage.SetSubplan(value : TFhirIdentifier);
begin
  FSubplan.free;
  FSubplan := value;
end;

Procedure TFhirCoverage.SetDependent(value : TFhirInteger);
begin
  FDependent.free;
  FDependent := value;
end;

Function TFhirCoverage.GetDependentST : String;
begin
  if FDependent = nil then
    result := ''
  else
    result := Dependent.value;
end;

Procedure TFhirCoverage.SetDependentST(value : String);
begin
  if value <> '' then
  begin
    if FDependent = nil then
      FDependent := TFhirInteger.create;
    FDependent.value := value
  end
  else if FDependent <> nil then
    FDependent.value := '';
end;

Procedure TFhirCoverage.SetSequence(value : TFhirInteger);
begin
  FSequence.free;
  FSequence := value;
end;

Function TFhirCoverage.GetSequenceST : String;
begin
  if FSequence = nil then
    result := ''
  else
    result := Sequence.value;
end;

Procedure TFhirCoverage.SetSequenceST(value : String);
begin
  if value <> '' then
  begin
    if FSequence = nil then
      FSequence := TFhirInteger.create;
    FSequence.value := value
  end
  else if FSequence <> nil then
    FSequence.value := '';
end;

Procedure TFhirCoverage.SetSubscriber(value : TFhirCoverageSubscriber);
begin
  FSubscriber.free;
  FSubscriber := value;
end;


{ TFhirDevice }

constructor TFhirDevice.Create;
begin
  inherited;
  FAssignedIdList := TFhirIdentifierList.Create;
  FContactList := TFhirContactList.Create;
end;

destructor TFhirDevice.Destroy;
begin
  FType_.free;
  FManufacturer.free;
  FModel.free;
  FVersion.free;
  FExpiry.free;
  FIdentity.free;
  FOwner.free;
  FAssignedIdList.Free;
  FLocation.free;
  FPatient.free;
  FContactList.Free;
  FUrl.free;
  inherited;
end;

function TFhirDevice.GetResourceType : TFhirResourceType;
begin
  result := frtDevice;
end;

procedure TFhirDevice.Assign(oSource : TAdvObject);
begin
  inherited;
  type_ := TFhirDevice(oSource).type_.Clone;
  manufacturer := TFhirDevice(oSource).manufacturer.Clone;
  model := TFhirDevice(oSource).model.Clone;
  version := TFhirDevice(oSource).version.Clone;
  expiry := TFhirDevice(oSource).expiry.Clone;
  identity := TFhirDevice(oSource).identity.Clone;
  owner := TFhirDevice(oSource).owner.Clone;
  FAssignedIdList.Assign(TFhirDevice(oSource).FAssignedIdList);
  location := TFhirDevice(oSource).location.Clone;
  patient := TFhirDevice(oSource).patient.Clone;
  FContactList.Assign(TFhirDevice(oSource).FContactList);
  url := TFhirDevice(oSource).url.Clone;
end;

procedure TFhirDevice.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'type_') Then
     list.add(Type_.Link);
  if (child_name = 'manufacturer') Then
     list.add(Manufacturer.Link);
  if (child_name = 'model') Then
     list.add(Model.Link);
  if (child_name = 'version') Then
     list.add(Version.Link);
  if (child_name = 'expiry') Then
     list.add(Expiry.Link);
  if (child_name = 'identity') Then
     list.add(Identity.Link);
  if (child_name = 'owner') Then
     list.add(Owner.Link);
  if (child_name = 'assignedId') Then
     list.addAll(FAssignedIdList);
  if (child_name = 'location') Then
     list.add(Location.Link);
  if (child_name = 'patient') Then
     list.add(Patient.Link);
  if (child_name = 'contact') Then
     list.addAll(FContactList);
  if (child_name = 'url') Then
     list.add(Url.Link);
end;

procedure TFhirDevice.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'type', 'CodeableConcept', FType_.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'manufacturer', 'string', FManufacturer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'model', 'string', FModel.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'version', 'string', FVersion.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'expiry', 'date', FExpiry.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identity', '', FIdentity.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'owner', 'Resource(Organization)', FOwner.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'assignedId', 'Identifier', FAssignedIdList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'location', 'Resource(Location)', FLocation.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'patient', 'Resource(Patient)', FPatient.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'contact', 'Contact', FContactList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'url', 'uri', FUrl.Link.Link));{2}
end;

function TFhirDevice.Link : TFhirDevice;
begin
  result := TFhirDevice(inherited Link);
end;

function TFhirDevice.Clone : TFhirDevice;
begin
  result := TFhirDevice(inherited Clone);
end;

{ TFhirDevice }

Procedure TFhirDevice.SetType_(value : TFhirCodeableConcept);
begin
  FType_.free;
  FType_ := value;
end;

Procedure TFhirDevice.SetManufacturer(value : TFhirString);
begin
  FManufacturer.free;
  FManufacturer := value;
end;

Function TFhirDevice.GetManufacturerST : String;
begin
  if FManufacturer = nil then
    result := ''
  else
    result := Manufacturer.value;
end;

Procedure TFhirDevice.SetManufacturerST(value : String);
begin
  if value <> '' then
  begin
    if FManufacturer = nil then
      FManufacturer := TFhirString.create;
    FManufacturer.value := value
  end
  else if FManufacturer <> nil then
    FManufacturer.value := '';
end;

Procedure TFhirDevice.SetModel(value : TFhirString);
begin
  FModel.free;
  FModel := value;
end;

Function TFhirDevice.GetModelST : String;
begin
  if FModel = nil then
    result := ''
  else
    result := Model.value;
end;

Procedure TFhirDevice.SetModelST(value : String);
begin
  if value <> '' then
  begin
    if FModel = nil then
      FModel := TFhirString.create;
    FModel.value := value
  end
  else if FModel <> nil then
    FModel.value := '';
end;

Procedure TFhirDevice.SetVersion(value : TFhirString);
begin
  FVersion.free;
  FVersion := value;
end;

Function TFhirDevice.GetVersionST : String;
begin
  if FVersion = nil then
    result := ''
  else
    result := Version.value;
end;

Procedure TFhirDevice.SetVersionST(value : String);
begin
  if value <> '' then
  begin
    if FVersion = nil then
      FVersion := TFhirString.create;
    FVersion.value := value
  end
  else if FVersion <> nil then
    FVersion.value := '';
end;

Procedure TFhirDevice.SetExpiry(value : TFhirDate);
begin
  FExpiry.free;
  FExpiry := value;
end;

Function TFhirDevice.GetExpiryST : TDateAndTime;
begin
  if FExpiry = nil then
    result := nil
  else
    result := Expiry.value;
end;

Procedure TFhirDevice.SetExpiryST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FExpiry = nil then
      FExpiry := TFhirDate.create;
    FExpiry.value := value
  end
  else if FExpiry <> nil then
    FExpiry.value := nil;
end;

Procedure TFhirDevice.SetIdentity(value : TFhirDeviceIdentity);
begin
  FIdentity.free;
  FIdentity := value;
end;

Procedure TFhirDevice.SetOwner(value : TFhirResourceReference{TFhirOrganization});
begin
  FOwner.free;
  FOwner := value;
end;

Procedure TFhirDevice.SetLocation(value : TFhirResourceReference{TFhirLocation});
begin
  FLocation.free;
  FLocation := value;
end;

Procedure TFhirDevice.SetPatient(value : TFhirResourceReference{TFhirPatient});
begin
  FPatient.free;
  FPatient := value;
end;

Procedure TFhirDevice.SetUrl(value : TFhirUri);
begin
  FUrl.free;
  FUrl := value;
end;

Function TFhirDevice.GetUrlST : String;
begin
  if FUrl = nil then
    result := ''
  else
    result := Url.value;
end;

Procedure TFhirDevice.SetUrlST(value : String);
begin
  if value <> '' then
  begin
    if FUrl = nil then
      FUrl := TFhirUri.create;
    FUrl.value := value
  end
  else if FUrl <> nil then
    FUrl.value := '';
end;


{ TFhirDeviceCapabilities }

constructor TFhirDeviceCapabilities.Create;
begin
  inherited;
  FVirtualDeviceList := TFhirDeviceCapabilitiesVirtualDeviceList.Create;
end;

destructor TFhirDeviceCapabilities.Destroy;
begin
  FName.free;
  FType_.free;
  FManufacturer.free;
  FIdentity.free;
  FVirtualDeviceList.Free;
  inherited;
end;

function TFhirDeviceCapabilities.GetResourceType : TFhirResourceType;
begin
  result := frtDeviceCapabilities;
end;

procedure TFhirDeviceCapabilities.Assign(oSource : TAdvObject);
begin
  inherited;
  name := TFhirDeviceCapabilities(oSource).name.Clone;
  type_ := TFhirDeviceCapabilities(oSource).type_.Clone;
  manufacturer := TFhirDeviceCapabilities(oSource).manufacturer.Clone;
  identity := TFhirDeviceCapabilities(oSource).identity.Clone;
  FVirtualDeviceList.Assign(TFhirDeviceCapabilities(oSource).FVirtualDeviceList);
end;

procedure TFhirDeviceCapabilities.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'type_') Then
     list.add(Type_.Link);
  if (child_name = 'manufacturer') Then
     list.add(Manufacturer.Link);
  if (child_name = 'identity') Then
     list.add(Identity.Link);
  if (child_name = 'virtualDevice') Then
     list.addAll(FVirtualDeviceList);
end;

procedure TFhirDeviceCapabilities.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'name', 'string', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'type', 'CodeableConcept', FType_.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'manufacturer', 'string', FManufacturer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identity', 'Resource(Device)', FIdentity.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'virtualDevice', '', FVirtualDeviceList.Link)){3};
end;

function TFhirDeviceCapabilities.Link : TFhirDeviceCapabilities;
begin
  result := TFhirDeviceCapabilities(inherited Link);
end;

function TFhirDeviceCapabilities.Clone : TFhirDeviceCapabilities;
begin
  result := TFhirDeviceCapabilities(inherited Clone);
end;

{ TFhirDeviceCapabilities }

Procedure TFhirDeviceCapabilities.SetName(value : TFhirString);
begin
  FName.free;
  FName := value;
end;

Function TFhirDeviceCapabilities.GetNameST : String;
begin
  if FName = nil then
    result := ''
  else
    result := Name.value;
end;

Procedure TFhirDeviceCapabilities.SetNameST(value : String);
begin
  if value <> '' then
  begin
    if FName = nil then
      FName := TFhirString.create;
    FName.value := value
  end
  else if FName <> nil then
    FName.value := '';
end;

Procedure TFhirDeviceCapabilities.SetType_(value : TFhirCodeableConcept);
begin
  FType_.free;
  FType_ := value;
end;

Procedure TFhirDeviceCapabilities.SetManufacturer(value : TFhirString);
begin
  FManufacturer.free;
  FManufacturer := value;
end;

Function TFhirDeviceCapabilities.GetManufacturerST : String;
begin
  if FManufacturer = nil then
    result := ''
  else
    result := Manufacturer.value;
end;

Procedure TFhirDeviceCapabilities.SetManufacturerST(value : String);
begin
  if value <> '' then
  begin
    if FManufacturer = nil then
      FManufacturer := TFhirString.create;
    FManufacturer.value := value
  end
  else if FManufacturer <> nil then
    FManufacturer.value := '';
end;

Procedure TFhirDeviceCapabilities.SetIdentity(value : TFhirResourceReference{TFhirDevice});
begin
  FIdentity.free;
  FIdentity := value;
end;


{ TFhirDeviceLog }

constructor TFhirDeviceLog.Create;
begin
  inherited;
  FItemList := TFhirDeviceLogItemList.Create;
end;

destructor TFhirDeviceLog.Destroy;
begin
  FInstant.free;
  FCapabilities.free;
  FSubject.free;
  FItemList.Free;
  inherited;
end;

function TFhirDeviceLog.GetResourceType : TFhirResourceType;
begin
  result := frtDeviceLog;
end;

procedure TFhirDeviceLog.Assign(oSource : TAdvObject);
begin
  inherited;
  instant := TFhirDeviceLog(oSource).instant.Clone;
  capabilities := TFhirDeviceLog(oSource).capabilities.Clone;
  subject := TFhirDeviceLog(oSource).subject.Clone;
  FItemList.Assign(TFhirDeviceLog(oSource).FItemList);
end;

procedure TFhirDeviceLog.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'instant') Then
     list.add(Instant.Link);
  if (child_name = 'capabilities') Then
     list.add(Capabilities.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'item') Then
     list.addAll(FItemList);
end;

procedure TFhirDeviceLog.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'instant', 'instant', FInstant.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'capabilities', 'Resource(DeviceCapabilities)', FCapabilities.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient|Group|Device)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'item', '', FItemList.Link)){3};
end;

function TFhirDeviceLog.Link : TFhirDeviceLog;
begin
  result := TFhirDeviceLog(inherited Link);
end;

function TFhirDeviceLog.Clone : TFhirDeviceLog;
begin
  result := TFhirDeviceLog(inherited Clone);
end;

{ TFhirDeviceLog }

Procedure TFhirDeviceLog.SetInstant(value : TFhirInstant);
begin
  FInstant.free;
  FInstant := value;
end;

Function TFhirDeviceLog.GetInstantST : TDateAndTime;
begin
  if FInstant = nil then
    result := nil
  else
    result := Instant.value;
end;

Procedure TFhirDeviceLog.SetInstantST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FInstant = nil then
      FInstant := TFhirInstant.create;
    FInstant.value := value
  end
  else if FInstant <> nil then
    FInstant.value := nil;
end;

Procedure TFhirDeviceLog.SetCapabilities(value : TFhirResourceReference{TFhirDeviceCapabilities});
begin
  FCapabilities.free;
  FCapabilities := value;
end;

Procedure TFhirDeviceLog.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;


{ TFhirDeviceObservation }

constructor TFhirDeviceObservation.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FMeasurementList := TFhirResourceReferenceList{TFhirObservation}.Create;
end;

destructor TFhirDeviceObservation.Destroy;
begin
  FCode.free;
  FIdentifierList.Free;
  FIssued.free;
  FSubject.free;
  FDevice.free;
  FMeasurementList.Free;
  inherited;
end;

function TFhirDeviceObservation.GetResourceType : TFhirResourceType;
begin
  result := frtDeviceObservation;
end;

procedure TFhirDeviceObservation.Assign(oSource : TAdvObject);
begin
  inherited;
  code := TFhirDeviceObservation(oSource).code.Clone;
  FIdentifierList.Assign(TFhirDeviceObservation(oSource).FIdentifierList);
  issued := TFhirDeviceObservation(oSource).issued.Clone;
  subject := TFhirDeviceObservation(oSource).subject.Clone;
  device := TFhirDeviceObservation(oSource).device.Clone;
  FMeasurementList.Assign(TFhirDeviceObservation(oSource).FMeasurementList);
end;

procedure TFhirDeviceObservation.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'code') Then
     list.add(Code.Link);
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'issued') Then
     list.add(Issued.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'device') Then
     list.add(Device.Link);
  if (child_name = 'measurement') Then
     list.addAll(FMeasurementList);
end;

procedure TFhirDeviceObservation.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'code', 'CodeableConcept', FCode.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'issued', 'instant', FIssued.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient|Group|Device)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'device', 'Resource(Device)', FDevice.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'measurement', 'Resource(Observation)', FMeasurementList.Link)){3};
end;

function TFhirDeviceObservation.Link : TFhirDeviceObservation;
begin
  result := TFhirDeviceObservation(inherited Link);
end;

function TFhirDeviceObservation.Clone : TFhirDeviceObservation;
begin
  result := TFhirDeviceObservation(inherited Clone);
end;

{ TFhirDeviceObservation }

Procedure TFhirDeviceObservation.SetCode(value : TFhirCodeableConcept);
begin
  FCode.free;
  FCode := value;
end;

Procedure TFhirDeviceObservation.SetIssued(value : TFhirInstant);
begin
  FIssued.free;
  FIssued := value;
end;

Function TFhirDeviceObservation.GetIssuedST : TDateAndTime;
begin
  if FIssued = nil then
    result := nil
  else
    result := Issued.value;
end;

Procedure TFhirDeviceObservation.SetIssuedST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FIssued = nil then
      FIssued := TFhirInstant.create;
    FIssued.value := value
  end
  else if FIssued <> nil then
    FIssued.value := nil;
end;

Procedure TFhirDeviceObservation.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirDeviceObservation.SetDevice(value : TFhirResourceReference{TFhirDevice});
begin
  FDevice.free;
  FDevice := value;
end;


{ TFhirDiagnosticOrder }

constructor TFhirDiagnosticOrder.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FSpecimenList := TFhirResourceReferenceList{TFhirSpecimen}.Create;
  FEventList := TFhirDiagnosticOrderEventList.Create;
  FItemList := TFhirDiagnosticOrderItemList.Create;
end;

destructor TFhirDiagnosticOrder.Destroy;
begin
  FSubject.free;
  FOrderer.free;
  FIdentifierList.Free;
  FEncounter.free;
  FClinicalNotes.free;
  FSpecimenList.Free;
  FStatus.free;
  FPriority.free;
  FEventList.Free;
  FItemList.Free;
  inherited;
end;

function TFhirDiagnosticOrder.GetResourceType : TFhirResourceType;
begin
  result := frtDiagnosticOrder;
end;

procedure TFhirDiagnosticOrder.Assign(oSource : TAdvObject);
begin
  inherited;
  subject := TFhirDiagnosticOrder(oSource).subject.Clone;
  orderer := TFhirDiagnosticOrder(oSource).orderer.Clone;
  FIdentifierList.Assign(TFhirDiagnosticOrder(oSource).FIdentifierList);
  encounter := TFhirDiagnosticOrder(oSource).encounter.Clone;
  clinicalNotes := TFhirDiagnosticOrder(oSource).clinicalNotes.Clone;
  FSpecimenList.Assign(TFhirDiagnosticOrder(oSource).FSpecimenList);
  FStatus := TFhirDiagnosticOrder(oSource).FStatus.Link;
  FPriority := TFhirDiagnosticOrder(oSource).FPriority.Link;
  FEventList.Assign(TFhirDiagnosticOrder(oSource).FEventList);
  FItemList.Assign(TFhirDiagnosticOrder(oSource).FItemList);
end;

procedure TFhirDiagnosticOrder.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'orderer') Then
     list.add(Orderer.Link);
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'encounter') Then
     list.add(Encounter.Link);
  if (child_name = 'clinicalNotes') Then
     list.add(ClinicalNotes.Link);
  if (child_name = 'specimen') Then
     list.addAll(FSpecimenList);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'priority') Then
     list.add(FPriority.Link);
  if (child_name = 'event') Then
     list.addAll(FEventList);
  if (child_name = 'item') Then
     list.addAll(FItemList);
end;

procedure TFhirDiagnosticOrder.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient|Group|Location|Device)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'orderer', 'Resource(Practitioner)', FOrderer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'encounter', 'Resource(Encounter)', FEncounter.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'clinicalNotes', 'string', FClinicalNotes.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'specimen', 'Resource(Specimen)', FSpecimenList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'priority', 'code', FPriority.Link));{1}
  oList.add(TFHIRProperty.create(self, 'event', '', FEventList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'item', '', FItemList.Link)){3};
end;

function TFhirDiagnosticOrder.Link : TFhirDiagnosticOrder;
begin
  result := TFhirDiagnosticOrder(inherited Link);
end;

function TFhirDiagnosticOrder.Clone : TFhirDiagnosticOrder;
begin
  result := TFhirDiagnosticOrder(inherited Clone);
end;

{ TFhirDiagnosticOrder }

Procedure TFhirDiagnosticOrder.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirDiagnosticOrder.SetOrderer(value : TFhirResourceReference{TFhirPractitioner});
begin
  FOrderer.free;
  FOrderer := value;
end;

Procedure TFhirDiagnosticOrder.SetEncounter(value : TFhirResourceReference{TFhirEncounter});
begin
  FEncounter.free;
  FEncounter := value;
end;

Procedure TFhirDiagnosticOrder.SetClinicalNotes(value : TFhirString);
begin
  FClinicalNotes.free;
  FClinicalNotes := value;
end;

Function TFhirDiagnosticOrder.GetClinicalNotesST : String;
begin
  if FClinicalNotes = nil then
    result := ''
  else
    result := ClinicalNotes.value;
end;

Procedure TFhirDiagnosticOrder.SetClinicalNotesST(value : String);
begin
  if value <> '' then
  begin
    if FClinicalNotes = nil then
      FClinicalNotes := TFhirString.create;
    FClinicalNotes.value := value
  end
  else if FClinicalNotes <> nil then
    FClinicalNotes.value := '';
end;

Procedure TFhirDiagnosticOrder.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirDiagnosticOrder.GetStatusST : TFhirDiagnosticOrderStatus;
begin
  if FStatus = nil then
    result := TFhirDiagnosticOrderStatus(0)
  else
    result := TFhirDiagnosticOrderStatus(StringArrayIndexOf(CODES_TFhirDiagnosticOrderStatus, Status.value));
end;

Procedure TFhirDiagnosticOrder.SetStatusST(value : TFhirDiagnosticOrderStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirDiagnosticOrderStatus[value]);
end;

Procedure TFhirDiagnosticOrder.SetPriority(value : TFhirEnum);
begin
  FPriority.free;
  FPriority := value;
end;

Function TFhirDiagnosticOrder.GetPriorityST : TFhirDiagnosticOrderPriority;
begin
  if FPriority = nil then
    result := TFhirDiagnosticOrderPriority(0)
  else
    result := TFhirDiagnosticOrderPriority(StringArrayIndexOf(CODES_TFhirDiagnosticOrderPriority, Priority.value));
end;

Procedure TFhirDiagnosticOrder.SetPriorityST(value : TFhirDiagnosticOrderPriority);
begin
  if ord(value) = 0 then
    Priority := nil
  else
    Priority := TFhirEnum.create(CODES_TFhirDiagnosticOrderPriority[value]);
end;


{ TFhirDiagnosticReport }

constructor TFhirDiagnosticReport.Create;
begin
  inherited;
  FRequestDetailList := TFhirDiagnosticReportRequestDetailList.Create;
  FImageList := TFhirResourceReferenceList{Resource}.Create;
  FCodedDiagnosisList := TFhirCodeableConceptList.Create;
  FRepresentationList := TFhirAttachmentList.Create;
end;

destructor TFhirDiagnosticReport.Destroy;
begin
  FStatus.free;
  FIssued.free;
  FSubject.free;
  FPerformer.free;
  FReportId.free;
  FRequestDetailList.Free;
  FServiceCategory.free;
  FDiagnosticTime.free;
  FResults.free;
  FImageList.Free;
  FConclusion.free;
  FCodedDiagnosisList.Free;
  FRepresentationList.Free;
  inherited;
end;

function TFhirDiagnosticReport.GetResourceType : TFhirResourceType;
begin
  result := frtDiagnosticReport;
end;

procedure TFhirDiagnosticReport.Assign(oSource : TAdvObject);
begin
  inherited;
  FStatus := TFhirDiagnosticReport(oSource).FStatus.Link;
  issued := TFhirDiagnosticReport(oSource).issued.Clone;
  subject := TFhirDiagnosticReport(oSource).subject.Clone;
  performer := TFhirDiagnosticReport(oSource).performer.Clone;
  reportId := TFhirDiagnosticReport(oSource).reportId.Clone;
  FRequestDetailList.Assign(TFhirDiagnosticReport(oSource).FRequestDetailList);
  serviceCategory := TFhirDiagnosticReport(oSource).serviceCategory.Clone;
  diagnosticTime := TFhirDiagnosticReport(oSource).diagnosticTime.Clone;
  results := TFhirDiagnosticReport(oSource).results.Clone;
  FImageList.Assign(TFhirDiagnosticReport(oSource).FImageList);
  conclusion := TFhirDiagnosticReport(oSource).conclusion.Clone;
  FCodedDiagnosisList.Assign(TFhirDiagnosticReport(oSource).FCodedDiagnosisList);
  FRepresentationList.Assign(TFhirDiagnosticReport(oSource).FRepresentationList);
end;

procedure TFhirDiagnosticReport.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'issued') Then
     list.add(Issued.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'performer') Then
     list.add(Performer.Link);
  if (child_name = 'reportId') Then
     list.add(ReportId.Link);
  if (child_name = 'requestDetail') Then
     list.addAll(FRequestDetailList);
  if (child_name = 'serviceCategory') Then
     list.add(ServiceCategory.Link);
  if (child_name = 'diagnosticTime') Then
     list.add(DiagnosticTime.Link);
  if (child_name = 'results') Then
     list.add(Results.Link);
  if (child_name = 'image') Then
     list.addAll(FImageList);
  if (child_name = 'conclusion') Then
     list.add(Conclusion.Link);
  if (child_name = 'codedDiagnosis') Then
     list.addAll(FCodedDiagnosisList);
  if (child_name = 'representation') Then
     list.addAll(FRepresentationList);
end;

procedure TFhirDiagnosticReport.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'issued', 'dateTime', FIssued.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient|Group|Device)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'performer', 'Resource(Organization)', FPerformer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reportId', 'Identifier', FReportId.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'requestDetail', '', FRequestDetailList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'serviceCategory', 'CodeableConcept', FServiceCategory.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'diagnosticTime', 'dateTime', FDiagnosticTime.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'results', '', FResults.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'image', 'Resource(Media|ImagingStudy)', FImageList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'conclusion', 'string', FConclusion.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'codedDiagnosis', 'CodeableConcept', FCodedDiagnosisList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'representation', 'Attachment', FRepresentationList.Link)){3};
end;

function TFhirDiagnosticReport.Link : TFhirDiagnosticReport;
begin
  result := TFhirDiagnosticReport(inherited Link);
end;

function TFhirDiagnosticReport.Clone : TFhirDiagnosticReport;
begin
  result := TFhirDiagnosticReport(inherited Clone);
end;

{ TFhirDiagnosticReport }

Procedure TFhirDiagnosticReport.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirDiagnosticReport.GetStatusST : TFhirObservationStatus;
begin
  if FStatus = nil then
    result := TFhirObservationStatus(0)
  else
    result := TFhirObservationStatus(StringArrayIndexOf(CODES_TFhirObservationStatus, Status.value));
end;

Procedure TFhirDiagnosticReport.SetStatusST(value : TFhirObservationStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirObservationStatus[value]);
end;

Procedure TFhirDiagnosticReport.SetIssued(value : TFhirDateTime);
begin
  FIssued.free;
  FIssued := value;
end;

Function TFhirDiagnosticReport.GetIssuedST : TDateAndTime;
begin
  if FIssued = nil then
    result := nil
  else
    result := Issued.value;
end;

Procedure TFhirDiagnosticReport.SetIssuedST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FIssued = nil then
      FIssued := TFhirDateTime.create;
    FIssued.value := value
  end
  else if FIssued <> nil then
    FIssued.value := nil;
end;

Procedure TFhirDiagnosticReport.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirDiagnosticReport.SetPerformer(value : TFhirResourceReference{TFhirOrganization});
begin
  FPerformer.free;
  FPerformer := value;
end;

Procedure TFhirDiagnosticReport.SetReportId(value : TFhirIdentifier);
begin
  FReportId.free;
  FReportId := value;
end;

Procedure TFhirDiagnosticReport.SetServiceCategory(value : TFhirCodeableConcept);
begin
  FServiceCategory.free;
  FServiceCategory := value;
end;

Procedure TFhirDiagnosticReport.SetDiagnosticTime(value : TFhirDateTime);
begin
  FDiagnosticTime.free;
  FDiagnosticTime := value;
end;

Function TFhirDiagnosticReport.GetDiagnosticTimeST : TDateAndTime;
begin
  if FDiagnosticTime = nil then
    result := nil
  else
    result := DiagnosticTime.value;
end;

Procedure TFhirDiagnosticReport.SetDiagnosticTimeST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDiagnosticTime = nil then
      FDiagnosticTime := TFhirDateTime.create;
    FDiagnosticTime.value := value
  end
  else if FDiagnosticTime <> nil then
    FDiagnosticTime.value := nil;
end;

Procedure TFhirDiagnosticReport.SetResults(value : TFhirDiagnosticReportResults);
begin
  FResults.free;
  FResults := value;
end;

Procedure TFhirDiagnosticReport.SetConclusion(value : TFhirString);
begin
  FConclusion.free;
  FConclusion := value;
end;

Function TFhirDiagnosticReport.GetConclusionST : String;
begin
  if FConclusion = nil then
    result := ''
  else
    result := Conclusion.value;
end;

Procedure TFhirDiagnosticReport.SetConclusionST(value : String);
begin
  if value <> '' then
  begin
    if FConclusion = nil then
      FConclusion := TFhirString.create;
    FConclusion.value := value
  end
  else if FConclusion <> nil then
    FConclusion.value := '';
end;


{ TFhirDocument }

constructor TFhirDocument.Create;
begin
  inherited;
  FAuthorList := TFhirResourceReferenceList{Resource}.Create;
  FAttesterList := TFhirDocumentAttesterList.Create;
  FProvenanceList := TFhirResourceReferenceList{TFhirProvenance}.Create;
  FSectionList := TFhirDocumentSectionList.Create;
end;

destructor TFhirDocument.Destroy;
begin
  FIdentifier.free;
  FVersionIdentifier.free;
  FCreated.free;
  FType_.free;
  FSubtype.free;
  FTitle.free;
  FStatus.free;
  FConfidentiality.free;
  FSubject.free;
  FAuthorList.Free;
  FAttesterList.Free;
  FCustodian.free;
  FEvent.free;
  FEncounter.free;
  FReplaces.free;
  FProvenanceList.Free;
  FStylesheet.free;
  FRepresentation.free;
  FSectionList.Free;
  inherited;
end;

function TFhirDocument.GetResourceType : TFhirResourceType;
begin
  result := frtDocument;
end;

procedure TFhirDocument.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirDocument(oSource).identifier.Clone;
  versionIdentifier := TFhirDocument(oSource).versionIdentifier.Clone;
  created := TFhirDocument(oSource).created.Clone;
  type_ := TFhirDocument(oSource).type_.Clone;
  subtype := TFhirDocument(oSource).subtype.Clone;
  title := TFhirDocument(oSource).title.Clone;
  FStatus := TFhirDocument(oSource).FStatus.Link;
  confidentiality := TFhirDocument(oSource).confidentiality.Clone;
  subject := TFhirDocument(oSource).subject.Clone;
  FAuthorList.Assign(TFhirDocument(oSource).FAuthorList);
  FAttesterList.Assign(TFhirDocument(oSource).FAttesterList);
  custodian := TFhirDocument(oSource).custodian.Clone;
  event := TFhirDocument(oSource).event.Clone;
  encounter := TFhirDocument(oSource).encounter.Clone;
  replaces := TFhirDocument(oSource).replaces.Clone;
  FProvenanceList.Assign(TFhirDocument(oSource).FProvenanceList);
  stylesheet := TFhirDocument(oSource).stylesheet.Clone;
  representation := TFhirDocument(oSource).representation.Clone;
  FSectionList.Assign(TFhirDocument(oSource).FSectionList);
end;

procedure TFhirDocument.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'versionIdentifier') Then
     list.add(VersionIdentifier.Link);
  if (child_name = 'created') Then
     list.add(Created.Link);
  if (child_name = 'type_') Then
     list.add(Type_.Link);
  if (child_name = 'subtype') Then
     list.add(Subtype.Link);
  if (child_name = 'title') Then
     list.add(Title.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'confidentiality') Then
     list.add(Confidentiality.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'author') Then
     list.addAll(FAuthorList);
  if (child_name = 'attester') Then
     list.addAll(FAttesterList);
  if (child_name = 'custodian') Then
     list.add(Custodian.Link);
  if (child_name = 'event') Then
     list.add(Event.Link);
  if (child_name = 'encounter') Then
     list.add(Encounter.Link);
  if (child_name = 'replaces') Then
     list.add(Replaces.Link);
  if (child_name = 'provenance') Then
     list.addAll(FProvenanceList);
  if (child_name = 'stylesheet') Then
     list.add(Stylesheet.Link);
  if (child_name = 'representation') Then
     list.add(Representation.Link);
  if (child_name = 'section') Then
     list.addAll(FSectionList);
end;

procedure TFhirDocument.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'versionIdentifier', 'Identifier', FVersionIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'created', 'instant', FCreated.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'type', 'CodeableConcept', FType_.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subtype', 'CodeableConcept', FSubtype.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'title', 'string', FTitle.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'confidentiality', 'Coding', FConfidentiality.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient|Practitioner|Group|Device)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'author', 'Resource(Practitioner|Device)', FAuthorList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'attester', '', FAttesterList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'custodian', 'Resource(Organization)', FCustodian.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'event', '', FEvent.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'encounter', 'Resource(Encounter|InterestOfCare)', FEncounter.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'replaces', 'id', FReplaces.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'provenance', 'Resource(Provenance)', FProvenanceList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'stylesheet', 'Attachment', FStylesheet.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'representation', 'Attachment', FRepresentation.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'section', '', FSectionList.Link)){3};
end;

function TFhirDocument.Link : TFhirDocument;
begin
  result := TFhirDocument(inherited Link);
end;

function TFhirDocument.Clone : TFhirDocument;
begin
  result := TFhirDocument(inherited Clone);
end;

{ TFhirDocument }

Procedure TFhirDocument.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirDocument.SetVersionIdentifier(value : TFhirIdentifier);
begin
  FVersionIdentifier.free;
  FVersionIdentifier := value;
end;

Procedure TFhirDocument.SetCreated(value : TFhirInstant);
begin
  FCreated.free;
  FCreated := value;
end;

Function TFhirDocument.GetCreatedST : TDateAndTime;
begin
  if FCreated = nil then
    result := nil
  else
    result := Created.value;
end;

Procedure TFhirDocument.SetCreatedST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FCreated = nil then
      FCreated := TFhirInstant.create;
    FCreated.value := value
  end
  else if FCreated <> nil then
    FCreated.value := nil;
end;

Procedure TFhirDocument.SetType_(value : TFhirCodeableConcept);
begin
  FType_.free;
  FType_ := value;
end;

Procedure TFhirDocument.SetSubtype(value : TFhirCodeableConcept);
begin
  FSubtype.free;
  FSubtype := value;
end;

Procedure TFhirDocument.SetTitle(value : TFhirString);
begin
  FTitle.free;
  FTitle := value;
end;

Function TFhirDocument.GetTitleST : String;
begin
  if FTitle = nil then
    result := ''
  else
    result := Title.value;
end;

Procedure TFhirDocument.SetTitleST(value : String);
begin
  if value <> '' then
  begin
    if FTitle = nil then
      FTitle := TFhirString.create;
    FTitle.value := value
  end
  else if FTitle <> nil then
    FTitle.value := '';
end;

Procedure TFhirDocument.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirDocument.GetStatusST : TFhirDocumentStatus;
begin
  if FStatus = nil then
    result := TFhirDocumentStatus(0)
  else
    result := TFhirDocumentStatus(StringArrayIndexOf(CODES_TFhirDocumentStatus, Status.value));
end;

Procedure TFhirDocument.SetStatusST(value : TFhirDocumentStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirDocumentStatus[value]);
end;

Procedure TFhirDocument.SetConfidentiality(value : TFhirCoding);
begin
  FConfidentiality.free;
  FConfidentiality := value;
end;

Procedure TFhirDocument.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirDocument.SetCustodian(value : TFhirResourceReference{TFhirOrganization});
begin
  FCustodian.free;
  FCustodian := value;
end;

Procedure TFhirDocument.SetEvent(value : TFhirDocumentEvent);
begin
  FEvent.free;
  FEvent := value;
end;

Procedure TFhirDocument.SetEncounter(value : TFhirResourceReference{Resource});
begin
  FEncounter.free;
  FEncounter := value;
end;

Procedure TFhirDocument.SetReplaces(value : TFhirId);
begin
  FReplaces.free;
  FReplaces := value;
end;

Function TFhirDocument.GetReplacesST : String;
begin
  if FReplaces = nil then
    result := ''
  else
    result := Replaces.value;
end;

Procedure TFhirDocument.SetReplacesST(value : String);
begin
  if value <> '' then
  begin
    if FReplaces = nil then
      FReplaces := TFhirId.create;
    FReplaces.value := value
  end
  else if FReplaces <> nil then
    FReplaces.value := '';
end;

Procedure TFhirDocument.SetStylesheet(value : TFhirAttachment);
begin
  FStylesheet.free;
  FStylesheet := value;
end;

Procedure TFhirDocument.SetRepresentation(value : TFhirAttachment);
begin
  FRepresentation.free;
  FRepresentation := value;
end;


{ TFhirDocumentReference }

constructor TFhirDocumentReference.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FAuthorList := TFhirResourceReferenceList{Resource}.Create;
end;

destructor TFhirDocumentReference.Destroy;
begin
  FMasterIdentifier.free;
  FIdentifierList.Free;
  FSubject.free;
  FType_.free;
  FSubtype.free;
  FAuthorList.Free;
  FCustodian.free;
  FAuthenticator.free;
  FCreated.free;
  FIndexed.free;
  FStatus.free;
  FDocStatus.free;
  FSupercedes.free;
  FDescription.free;
  FConfidentiality.free;
  FPrimaryLanguage.free;
  FMimeType.free;
  FFormat.free;
  FSize.free;
  FHash.free;
  FLocation.free;
  FService.free;
  FContext.free;
  inherited;
end;

function TFhirDocumentReference.GetResourceType : TFhirResourceType;
begin
  result := frtDocumentReference;
end;

procedure TFhirDocumentReference.Assign(oSource : TAdvObject);
begin
  inherited;
  masterIdentifier := TFhirDocumentReference(oSource).masterIdentifier.Clone;
  FIdentifierList.Assign(TFhirDocumentReference(oSource).FIdentifierList);
  subject := TFhirDocumentReference(oSource).subject.Clone;
  type_ := TFhirDocumentReference(oSource).type_.Clone;
  subtype := TFhirDocumentReference(oSource).subtype.Clone;
  FAuthorList.Assign(TFhirDocumentReference(oSource).FAuthorList);
  custodian := TFhirDocumentReference(oSource).custodian.Clone;
  authenticator := TFhirDocumentReference(oSource).authenticator.Clone;
  created := TFhirDocumentReference(oSource).created.Clone;
  indexed := TFhirDocumentReference(oSource).indexed.Clone;
  FStatus := TFhirDocumentReference(oSource).FStatus.Link;
  docStatus := TFhirDocumentReference(oSource).docStatus.Clone;
  supercedes := TFhirDocumentReference(oSource).supercedes.Clone;
  description := TFhirDocumentReference(oSource).description.Clone;
  confidentiality := TFhirDocumentReference(oSource).confidentiality.Clone;
  primaryLanguage := TFhirDocumentReference(oSource).primaryLanguage.Clone;
  mimeType := TFhirDocumentReference(oSource).mimeType.Clone;
  format := TFhirDocumentReference(oSource).format.Clone;
  size := TFhirDocumentReference(oSource).size.Clone;
  hash := TFhirDocumentReference(oSource).hash.Clone;
  location := TFhirDocumentReference(oSource).location.Clone;
  service := TFhirDocumentReference(oSource).service.Clone;
  context := TFhirDocumentReference(oSource).context.Clone;
end;

procedure TFhirDocumentReference.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'masterIdentifier') Then
     list.add(MasterIdentifier.Link);
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'type_') Then
     list.add(Type_.Link);
  if (child_name = 'subtype') Then
     list.add(Subtype.Link);
  if (child_name = 'author') Then
     list.addAll(FAuthorList);
  if (child_name = 'custodian') Then
     list.add(Custodian.Link);
  if (child_name = 'authenticator') Then
     list.add(Authenticator.Link);
  if (child_name = 'created') Then
     list.add(Created.Link);
  if (child_name = 'indexed') Then
     list.add(Indexed.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'docStatus') Then
     list.add(DocStatus.Link);
  if (child_name = 'supercedes') Then
     list.add(Supercedes.Link);
  if (child_name = 'description') Then
     list.add(Description.Link);
  if (child_name = 'confidentiality') Then
     list.add(Confidentiality.Link);
  if (child_name = 'primaryLanguage') Then
     list.add(PrimaryLanguage.Link);
  if (child_name = 'mimeType') Then
     list.add(MimeType.Link);
  if (child_name = 'format') Then
     list.add(Format.Link);
  if (child_name = 'size') Then
     list.add(Size.Link);
  if (child_name = 'hash') Then
     list.add(Hash.Link);
  if (child_name = 'location') Then
     list.add(Location.Link);
  if (child_name = 'service') Then
     list.add(Service.Link);
  if (child_name = 'context') Then
     list.add(Context.Link);
end;

procedure TFhirDocumentReference.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'masterIdentifier', 'Identifier', FMasterIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient|Practitioner|Group|Device)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'type', 'CodeableConcept', FType_.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subtype', 'CodeableConcept', FSubtype.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'author', 'Resource(Practitioner|Device)', FAuthorList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'custodian', 'Resource(Organization)', FCustodian.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'authenticator', 'Resource(Practitioner|Organization)', FAuthenticator.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'created', 'dateTime', FCreated.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'indexed', 'instant', FIndexed.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'docStatus', 'CodeableConcept', FDocStatus.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'supercedes', 'Resource(DocumentReference)', FSupercedes.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'description', 'string', FDescription.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'confidentiality', 'CodeableConcept', FConfidentiality.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'primaryLanguage', 'code', FPrimaryLanguage.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'mimeType', 'code', FMimeType.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'format', 'CodeableConcept', FFormat.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'size', 'integer', FSize.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'hash', 'string', FHash.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'location', 'uri', FLocation.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'service', '', FService.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'context', '', FContext.Link.Link));{2}
end;

function TFhirDocumentReference.Link : TFhirDocumentReference;
begin
  result := TFhirDocumentReference(inherited Link);
end;

function TFhirDocumentReference.Clone : TFhirDocumentReference;
begin
  result := TFhirDocumentReference(inherited Clone);
end;

{ TFhirDocumentReference }

Procedure TFhirDocumentReference.SetMasterIdentifier(value : TFhirIdentifier);
begin
  FMasterIdentifier.free;
  FMasterIdentifier := value;
end;

Procedure TFhirDocumentReference.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirDocumentReference.SetType_(value : TFhirCodeableConcept);
begin
  FType_.free;
  FType_ := value;
end;

Procedure TFhirDocumentReference.SetSubtype(value : TFhirCodeableConcept);
begin
  FSubtype.free;
  FSubtype := value;
end;

Procedure TFhirDocumentReference.SetCustodian(value : TFhirResourceReference{TFhirOrganization});
begin
  FCustodian.free;
  FCustodian := value;
end;

Procedure TFhirDocumentReference.SetAuthenticator(value : TFhirResourceReference{Resource});
begin
  FAuthenticator.free;
  FAuthenticator := value;
end;

Procedure TFhirDocumentReference.SetCreated(value : TFhirDateTime);
begin
  FCreated.free;
  FCreated := value;
end;

Function TFhirDocumentReference.GetCreatedST : TDateAndTime;
begin
  if FCreated = nil then
    result := nil
  else
    result := Created.value;
end;

Procedure TFhirDocumentReference.SetCreatedST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FCreated = nil then
      FCreated := TFhirDateTime.create;
    FCreated.value := value
  end
  else if FCreated <> nil then
    FCreated.value := nil;
end;

Procedure TFhirDocumentReference.SetIndexed(value : TFhirInstant);
begin
  FIndexed.free;
  FIndexed := value;
end;

Function TFhirDocumentReference.GetIndexedST : TDateAndTime;
begin
  if FIndexed = nil then
    result := nil
  else
    result := Indexed.value;
end;

Procedure TFhirDocumentReference.SetIndexedST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FIndexed = nil then
      FIndexed := TFhirInstant.create;
    FIndexed.value := value
  end
  else if FIndexed <> nil then
    FIndexed.value := nil;
end;

Procedure TFhirDocumentReference.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirDocumentReference.GetStatusST : TFhirDocumentReferenceStatus;
begin
  if FStatus = nil then
    result := TFhirDocumentReferenceStatus(0)
  else
    result := TFhirDocumentReferenceStatus(StringArrayIndexOf(CODES_TFhirDocumentReferenceStatus, Status.value));
end;

Procedure TFhirDocumentReference.SetStatusST(value : TFhirDocumentReferenceStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirDocumentReferenceStatus[value]);
end;

Procedure TFhirDocumentReference.SetDocStatus(value : TFhirCodeableConcept);
begin
  FDocStatus.free;
  FDocStatus := value;
end;

Procedure TFhirDocumentReference.SetSupercedes(value : TFhirResourceReference{TFhirDocumentReference});
begin
  FSupercedes.free;
  FSupercedes := value;
end;

Procedure TFhirDocumentReference.SetDescription(value : TFhirString);
begin
  FDescription.free;
  FDescription := value;
end;

Function TFhirDocumentReference.GetDescriptionST : String;
begin
  if FDescription = nil then
    result := ''
  else
    result := Description.value;
end;

Procedure TFhirDocumentReference.SetDescriptionST(value : String);
begin
  if value <> '' then
  begin
    if FDescription = nil then
      FDescription := TFhirString.create;
    FDescription.value := value
  end
  else if FDescription <> nil then
    FDescription.value := '';
end;

Procedure TFhirDocumentReference.SetConfidentiality(value : TFhirCodeableConcept);
begin
  FConfidentiality.free;
  FConfidentiality := value;
end;

Procedure TFhirDocumentReference.SetPrimaryLanguage(value : TFhirCode);
begin
  FPrimaryLanguage.free;
  FPrimaryLanguage := value;
end;

Function TFhirDocumentReference.GetPrimaryLanguageST : String;
begin
  if FPrimaryLanguage = nil then
    result := ''
  else
    result := PrimaryLanguage.value;
end;

Procedure TFhirDocumentReference.SetPrimaryLanguageST(value : String);
begin
  if value <> '' then
  begin
    if FPrimaryLanguage = nil then
      FPrimaryLanguage := TFhirCode.create;
    FPrimaryLanguage.value := value
  end
  else if FPrimaryLanguage <> nil then
    FPrimaryLanguage.value := '';
end;

Procedure TFhirDocumentReference.SetMimeType(value : TFhirCode);
begin
  FMimeType.free;
  FMimeType := value;
end;

Function TFhirDocumentReference.GetMimeTypeST : String;
begin
  if FMimeType = nil then
    result := ''
  else
    result := MimeType.value;
end;

Procedure TFhirDocumentReference.SetMimeTypeST(value : String);
begin
  if value <> '' then
  begin
    if FMimeType = nil then
      FMimeType := TFhirCode.create;
    FMimeType.value := value
  end
  else if FMimeType <> nil then
    FMimeType.value := '';
end;

Procedure TFhirDocumentReference.SetFormat(value : TFhirCodeableConcept);
begin
  FFormat.free;
  FFormat := value;
end;

Procedure TFhirDocumentReference.SetSize(value : TFhirInteger);
begin
  FSize.free;
  FSize := value;
end;

Function TFhirDocumentReference.GetSizeST : String;
begin
  if FSize = nil then
    result := ''
  else
    result := Size.value;
end;

Procedure TFhirDocumentReference.SetSizeST(value : String);
begin
  if value <> '' then
  begin
    if FSize = nil then
      FSize := TFhirInteger.create;
    FSize.value := value
  end
  else if FSize <> nil then
    FSize.value := '';
end;

Procedure TFhirDocumentReference.SetHash(value : TFhirString);
begin
  FHash.free;
  FHash := value;
end;

Function TFhirDocumentReference.GetHashST : String;
begin
  if FHash = nil then
    result := ''
  else
    result := Hash.value;
end;

Procedure TFhirDocumentReference.SetHashST(value : String);
begin
  if value <> '' then
  begin
    if FHash = nil then
      FHash := TFhirString.create;
    FHash.value := value
  end
  else if FHash <> nil then
    FHash.value := '';
end;

Procedure TFhirDocumentReference.SetLocation(value : TFhirUri);
begin
  FLocation.free;
  FLocation := value;
end;

Function TFhirDocumentReference.GetLocationST : String;
begin
  if FLocation = nil then
    result := ''
  else
    result := Location.value;
end;

Procedure TFhirDocumentReference.SetLocationST(value : String);
begin
  if value <> '' then
  begin
    if FLocation = nil then
      FLocation := TFhirUri.create;
    FLocation.value := value
  end
  else if FLocation <> nil then
    FLocation.value := '';
end;

Procedure TFhirDocumentReference.SetService(value : TFhirDocumentReferenceService);
begin
  FService.free;
  FService := value;
end;

Procedure TFhirDocumentReference.SetContext(value : TFhirDocumentReferenceContext);
begin
  FContext.free;
  FContext := value;
end;


{ TFhirEncounter }

constructor TFhirEncounter.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FType_List := TFhirCodeableConceptList.Create;
  FParticipantList := TFhirEncounterParticipantList.Create;
  FLocationList := TFhirEncounterLocationList.Create;
end;

destructor TFhirEncounter.Destroy;
begin
  FIdentifierList.Free;
  FStatus.free;
  FClass_.free;
  FType_List.Free;
  FSubject.free;
  FParticipantList.Free;
  FFulfills.free;
  FStart.free;
  FLength.free;
  FReason.free;
  FIndication.free;
  FPriority.free;
  FHospitalization.free;
  FLocationList.Free;
  FServiceProvider.free;
  FPartOf.free;
  inherited;
end;

function TFhirEncounter.GetResourceType : TFhirResourceType;
begin
  result := frtEncounter;
end;

procedure TFhirEncounter.Assign(oSource : TAdvObject);
begin
  inherited;
  FIdentifierList.Assign(TFhirEncounter(oSource).FIdentifierList);
  FStatus := TFhirEncounter(oSource).FStatus.Link;
  FClass_ := TFhirEncounter(oSource).FClass_.Link;
  FType_List.Assign(TFhirEncounter(oSource).FType_List);
  subject := TFhirEncounter(oSource).subject.Clone;
  FParticipantList.Assign(TFhirEncounter(oSource).FParticipantList);
  fulfills := TFhirEncounter(oSource).fulfills.Clone;
  start := TFhirEncounter(oSource).start.Clone;
  length := TFhirEncounter(oSource).length.Clone;
  reason := TFhirEncounter(oSource).reason.Clone;
  indication := TFhirEncounter(oSource).indication.Clone;
  priority := TFhirEncounter(oSource).priority.Clone;
  hospitalization := TFhirEncounter(oSource).hospitalization.Clone;
  FLocationList.Assign(TFhirEncounter(oSource).FLocationList);
  serviceProvider := TFhirEncounter(oSource).serviceProvider.Clone;
  partOf := TFhirEncounter(oSource).partOf.Clone;
end;

procedure TFhirEncounter.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'class_') Then
     list.add(FClass_.Link);
  if (child_name = 'type_') Then
     list.addAll(FType_List);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'participant') Then
     list.addAll(FParticipantList);
  if (child_name = 'fulfills') Then
     list.add(Fulfills.Link);
  if (child_name = 'start') Then
     list.add(Start.Link);
  if (child_name = 'length') Then
     list.add(Length.Link);
  if (child_name = 'reason') Then
     list.add(Reason.Link);
  if (child_name = 'indication') Then
     list.add(Indication.Link);
  if (child_name = 'priority') Then
     list.add(Priority.Link);
  if (child_name = 'hospitalization') Then
     list.add(Hospitalization.Link);
  if (child_name = 'location') Then
     list.addAll(FLocationList);
  if (child_name = 'serviceProvider') Then
     list.add(ServiceProvider.Link);
  if (child_name = 'partOf') Then
     list.add(PartOf.Link);
end;

procedure TFhirEncounter.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'class', 'code', FClass_.Link));{1}
  oList.add(TFHIRProperty.create(self, 'type', 'CodeableConcept', FType_List.Link)){3};
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'participant', '', FParticipantList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'fulfills', 'Resource(Appointment)', FFulfills.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'start', 'dateTime', FStart.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'length', 'Duration', FLength.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reason[x]', 'string|CodeableConcept', FReason.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'indication', 'Resource(Any)', FIndication.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'priority', 'CodeableConcept', FPriority.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'hospitalization', '', FHospitalization.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'location', '', FLocationList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'serviceProvider', 'Resource(Organization)', FServiceProvider.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'partOf', 'Resource(Encounter)', FPartOf.Link.Link));{2}
end;

function TFhirEncounter.Link : TFhirEncounter;
begin
  result := TFhirEncounter(inherited Link);
end;

function TFhirEncounter.Clone : TFhirEncounter;
begin
  result := TFhirEncounter(inherited Clone);
end;

{ TFhirEncounter }

Procedure TFhirEncounter.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirEncounter.GetStatusST : TFhirEncounterState;
begin
  if FStatus = nil then
    result := TFhirEncounterState(0)
  else
    result := TFhirEncounterState(StringArrayIndexOf(CODES_TFhirEncounterState, Status.value));
end;

Procedure TFhirEncounter.SetStatusST(value : TFhirEncounterState);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirEncounterState[value]);
end;

Procedure TFhirEncounter.SetClass_(value : TFhirEnum);
begin
  FClass_.free;
  FClass_ := value;
end;

Function TFhirEncounter.GetClass_ST : TFhirEncounterClass;
begin
  if FClass_ = nil then
    result := TFhirEncounterClass(0)
  else
    result := TFhirEncounterClass(StringArrayIndexOf(CODES_TFhirEncounterClass, Class_.value));
end;

Procedure TFhirEncounter.SetClass_ST(value : TFhirEncounterClass);
begin
  if ord(value) = 0 then
    Class_ := nil
  else
    Class_ := TFhirEnum.create(CODES_TFhirEncounterClass[value]);
end;

Procedure TFhirEncounter.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirEncounter.SetFulfills(value : TFhirResourceReference{TFhirAppointment});
begin
  FFulfills.free;
  FFulfills := value;
end;

Procedure TFhirEncounter.SetStart(value : TFhirDateTime);
begin
  FStart.free;
  FStart := value;
end;

Function TFhirEncounter.GetStartST : TDateAndTime;
begin
  if FStart = nil then
    result := nil
  else
    result := Start.value;
end;

Procedure TFhirEncounter.SetStartST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FStart = nil then
      FStart := TFhirDateTime.create;
    FStart.value := value
  end
  else if FStart <> nil then
    FStart.value := nil;
end;

Procedure TFhirEncounter.SetLength(value : TFhirQuantity);
begin
  FLength.free;
  FLength := value;
end;

Procedure TFhirEncounter.SetReason(value : TFhirType);
begin
  FReason.free;
  FReason := value;
end;

Procedure TFhirEncounter.SetIndication(value : TFhirResourceReference{Resource});
begin
  FIndication.free;
  FIndication := value;
end;

Procedure TFhirEncounter.SetPriority(value : TFhirCodeableConcept);
begin
  FPriority.free;
  FPriority := value;
end;

Procedure TFhirEncounter.SetHospitalization(value : TFhirEncounterHospitalization);
begin
  FHospitalization.free;
  FHospitalization := value;
end;

Procedure TFhirEncounter.SetServiceProvider(value : TFhirResourceReference{TFhirOrganization});
begin
  FServiceProvider.free;
  FServiceProvider := value;
end;

Procedure TFhirEncounter.SetPartOf(value : TFhirResourceReference{TFhirEncounter});
begin
  FPartOf.free;
  FPartOf := value;
end;


{ TFhirFamilyHistory }

constructor TFhirFamilyHistory.Create;
begin
  inherited;
  FRelationList := TFhirFamilyHistoryRelationList.Create;
end;

destructor TFhirFamilyHistory.Destroy;
begin
  FSubject.free;
  FNote.free;
  FRelationList.Free;
  inherited;
end;

function TFhirFamilyHistory.GetResourceType : TFhirResourceType;
begin
  result := frtFamilyHistory;
end;

procedure TFhirFamilyHistory.Assign(oSource : TAdvObject);
begin
  inherited;
  subject := TFhirFamilyHistory(oSource).subject.Clone;
  note := TFhirFamilyHistory(oSource).note.Clone;
  FRelationList.Assign(TFhirFamilyHistory(oSource).FRelationList);
end;

procedure TFhirFamilyHistory.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'note') Then
     list.add(Note.Link);
  if (child_name = 'relation') Then
     list.addAll(FRelationList);
end;

procedure TFhirFamilyHistory.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'note', 'string', FNote.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'relation', '', FRelationList.Link)){3};
end;

function TFhirFamilyHistory.Link : TFhirFamilyHistory;
begin
  result := TFhirFamilyHistory(inherited Link);
end;

function TFhirFamilyHistory.Clone : TFhirFamilyHistory;
begin
  result := TFhirFamilyHistory(inherited Clone);
end;

{ TFhirFamilyHistory }

Procedure TFhirFamilyHistory.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirFamilyHistory.SetNote(value : TFhirString);
begin
  FNote.free;
  FNote := value;
end;

Function TFhirFamilyHistory.GetNoteST : String;
begin
  if FNote = nil then
    result := ''
  else
    result := Note.value;
end;

Procedure TFhirFamilyHistory.SetNoteST(value : String);
begin
  if value <> '' then
  begin
    if FNote = nil then
      FNote := TFhirString.create;
    FNote.value := value
  end
  else if FNote <> nil then
    FNote.value := '';
end;


{ TFhirGroup }

constructor TFhirGroup.Create;
begin
  inherited;
  FCharacteristicList := TFhirGroupCharacteristicList.Create;
  FMemberList := TFhirResourceReferenceList{Resource}.Create;
end;

destructor TFhirGroup.Destroy;
begin
  FIdentifier.free;
  FType_.free;
  FActual.free;
  FCode.free;
  FName.free;
  FQuantity.free;
  FCharacteristicList.Free;
  FMemberList.Free;
  inherited;
end;

function TFhirGroup.GetResourceType : TFhirResourceType;
begin
  result := frtGroup;
end;

procedure TFhirGroup.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirGroup(oSource).identifier.Clone;
  FType_ := TFhirGroup(oSource).FType_.Link;
  actual := TFhirGroup(oSource).actual.Clone;
  code := TFhirGroup(oSource).code.Clone;
  name := TFhirGroup(oSource).name.Clone;
  quantity := TFhirGroup(oSource).quantity.Clone;
  FCharacteristicList.Assign(TFhirGroup(oSource).FCharacteristicList);
  FMemberList.Assign(TFhirGroup(oSource).FMemberList);
end;

procedure TFhirGroup.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'type_') Then
     list.add(FType_.Link);
  if (child_name = 'actual') Then
     list.add(Actual.Link);
  if (child_name = 'code') Then
     list.add(Code.Link);
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'quantity') Then
     list.add(Quantity.Link);
  if (child_name = 'characteristic') Then
     list.addAll(FCharacteristicList);
  if (child_name = 'member') Then
     list.addAll(FMemberList);
end;

procedure TFhirGroup.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'type', 'code', FType_.Link));{1}
  oList.add(TFHIRProperty.create(self, 'actual', 'boolean', FActual.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'code', 'CodeableConcept', FCode.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'name', 'string', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'quantity', 'integer', FQuantity.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'characteristic', '', FCharacteristicList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'member', 'Resource(Patient|Practitioner|Device|Medication)', FMemberList.Link)){3};
end;

function TFhirGroup.Link : TFhirGroup;
begin
  result := TFhirGroup(inherited Link);
end;

function TFhirGroup.Clone : TFhirGroup;
begin
  result := TFhirGroup(inherited Clone);
end;

{ TFhirGroup }

Procedure TFhirGroup.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirGroup.SetType_(value : TFhirEnum);
begin
  FType_.free;
  FType_ := value;
end;

Function TFhirGroup.GetType_ST : TFhirGroupType;
begin
  if FType_ = nil then
    result := TFhirGroupType(0)
  else
    result := TFhirGroupType(StringArrayIndexOf(CODES_TFhirGroupType, Type_.value));
end;

Procedure TFhirGroup.SetType_ST(value : TFhirGroupType);
begin
  if ord(value) = 0 then
    Type_ := nil
  else
    Type_ := TFhirEnum.create(CODES_TFhirGroupType[value]);
end;

Procedure TFhirGroup.SetActual(value : TFhirBoolean);
begin
  FActual.free;
  FActual := value;
end;

Function TFhirGroup.GetActualST : String;
begin
  if FActual = nil then
    result := ''
  else
    result := Actual.value;
end;

Procedure TFhirGroup.SetActualST(value : String);
begin
  if value <> '' then
  begin
    if FActual = nil then
      FActual := TFhirBoolean.create;
    FActual.value := value
  end
  else if FActual <> nil then
    FActual.value := '';
end;

Procedure TFhirGroup.SetCode(value : TFhirCodeableConcept);
begin
  FCode.free;
  FCode := value;
end;

Procedure TFhirGroup.SetName(value : TFhirString);
begin
  FName.free;
  FName := value;
end;

Function TFhirGroup.GetNameST : String;
begin
  if FName = nil then
    result := ''
  else
    result := Name.value;
end;

Procedure TFhirGroup.SetNameST(value : String);
begin
  if value <> '' then
  begin
    if FName = nil then
      FName := TFhirString.create;
    FName.value := value
  end
  else if FName <> nil then
    FName.value := '';
end;

Procedure TFhirGroup.SetQuantity(value : TFhirInteger);
begin
  FQuantity.free;
  FQuantity := value;
end;

Function TFhirGroup.GetQuantityST : String;
begin
  if FQuantity = nil then
    result := ''
  else
    result := Quantity.value;
end;

Procedure TFhirGroup.SetQuantityST(value : String);
begin
  if value <> '' then
  begin
    if FQuantity = nil then
      FQuantity := TFhirInteger.create;
    FQuantity.value := value
  end
  else if FQuantity <> nil then
    FQuantity.value := '';
end;


{ TFhirImagingStudy }

constructor TFhirImagingStudy.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FModality := TFHIREnumList.Create;
  FProcedure_List := TFhirCodingList.Create;
  FSeriesList := TFhirImagingStudySeriesList.Create;
end;

destructor TFhirImagingStudy.Destroy;
begin
  FDateTime.free;
  FSubject.free;
  FUid.free;
  FAccessionNo.free;
  FIdentifierList.Free;
  FModality.Free;
  FReferrer.free;
  FAvailability.free;
  FUrl.free;
  FNumberOfSeries.free;
  FNumberOfInstances.free;
  FClinicalInformation.free;
  FProcedure_List.Free;
  FInterpreter.free;
  FDescription.free;
  FSeriesList.Free;
  inherited;
end;

function TFhirImagingStudy.GetResourceType : TFhirResourceType;
begin
  result := frtImagingStudy;
end;

procedure TFhirImagingStudy.Assign(oSource : TAdvObject);
begin
  inherited;
  dateTime := TFhirImagingStudy(oSource).dateTime.Clone;
  subject := TFhirImagingStudy(oSource).subject.Clone;
  uid := TFhirImagingStudy(oSource).uid.Clone;
  accessionNo := TFhirImagingStudy(oSource).accessionNo.Clone;
  FIdentifierList.Assign(TFhirImagingStudy(oSource).FIdentifierList);
  FModality.Assign(TFhirImagingStudy(oSource).FModality);
  referrer := TFhirImagingStudy(oSource).referrer.Clone;
  FAvailability := TFhirImagingStudy(oSource).FAvailability.Link;
  url := TFhirImagingStudy(oSource).url.Clone;
  numberOfSeries := TFhirImagingStudy(oSource).numberOfSeries.Clone;
  numberOfInstances := TFhirImagingStudy(oSource).numberOfInstances.Clone;
  clinicalInformation := TFhirImagingStudy(oSource).clinicalInformation.Clone;
  FProcedure_List.Assign(TFhirImagingStudy(oSource).FProcedure_List);
  interpreter := TFhirImagingStudy(oSource).interpreter.Clone;
  description := TFhirImagingStudy(oSource).description.Clone;
  FSeriesList.Assign(TFhirImagingStudy(oSource).FSeriesList);
end;

procedure TFhirImagingStudy.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'dateTime') Then
     list.add(DateTime.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'uid') Then
     list.add(Uid.Link);
  if (child_name = 'accessionNo') Then
     list.add(AccessionNo.Link);
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'modality') Then
     list.addAll(FModality);
  if (child_name = 'referrer') Then
     list.add(Referrer.Link);
  if (child_name = 'availability') Then
     list.add(FAvailability.Link);
  if (child_name = 'url') Then
     list.add(Url.Link);
  if (child_name = 'numberOfSeries') Then
     list.add(NumberOfSeries.Link);
  if (child_name = 'numberOfInstances') Then
     list.add(NumberOfInstances.Link);
  if (child_name = 'clinicalInformation') Then
     list.add(ClinicalInformation.Link);
  if (child_name = 'procedure_') Then
     list.addAll(FProcedure_List);
  if (child_name = 'interpreter') Then
     list.add(Interpreter.Link);
  if (child_name = 'description') Then
     list.add(Description.Link);
  if (child_name = 'series') Then
     list.addAll(FSeriesList);
end;

procedure TFhirImagingStudy.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'dateTime', 'dateTime', FDateTime.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'uid', 'oid', FUid.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'accessionNo', 'Identifier', FAccessionNo.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'modality', 'code', FModality.Link)){3};
  oList.add(TFHIRProperty.create(self, 'referrer', 'Resource(Practitioner)', FReferrer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'availability', 'code', FAvailability.Link));{1}
  oList.add(TFHIRProperty.create(self, 'url', 'uri', FUrl.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'numberOfSeries', 'integer', FNumberOfSeries.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'numberOfInstances', 'integer', FNumberOfInstances.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'clinicalInformation', 'string', FClinicalInformation.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'procedure', 'Coding', FProcedure_List.Link)){3};
  oList.add(TFHIRProperty.create(self, 'interpreter', 'Resource(Practitioner)', FInterpreter.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'description', 'string', FDescription.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'series', '', FSeriesList.Link)){3};
end;

function TFhirImagingStudy.Link : TFhirImagingStudy;
begin
  result := TFhirImagingStudy(inherited Link);
end;

function TFhirImagingStudy.Clone : TFhirImagingStudy;
begin
  result := TFhirImagingStudy(inherited Clone);
end;

{ TFhirImagingStudy }

Procedure TFhirImagingStudy.SetDateTime(value : TFhirDateTime);
begin
  FDateTime.free;
  FDateTime := value;
end;

Function TFhirImagingStudy.GetDateTimeST : TDateAndTime;
begin
  if FDateTime = nil then
    result := nil
  else
    result := DateTime.value;
end;

Procedure TFhirImagingStudy.SetDateTimeST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDateTime = nil then
      FDateTime := TFhirDateTime.create;
    FDateTime.value := value
  end
  else if FDateTime <> nil then
    FDateTime.value := nil;
end;

Procedure TFhirImagingStudy.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirImagingStudy.SetUid(value : TFhirOid);
begin
  FUid.free;
  FUid := value;
end;

Function TFhirImagingStudy.GetUidST : String;
begin
  if FUid = nil then
    result := ''
  else
    result := Uid.value;
end;

Procedure TFhirImagingStudy.SetUidST(value : String);
begin
  if value <> '' then
  begin
    if FUid = nil then
      FUid := TFhirOid.create;
    FUid.value := value
  end
  else if FUid <> nil then
    FUid.value := '';
end;

Procedure TFhirImagingStudy.SetAccessionNo(value : TFhirIdentifier);
begin
  FAccessionNo.free;
  FAccessionNo := value;
end;

Function TFhirImagingStudy.GetModalityST : TFhirImagingModalityList;
  var i : integer;
begin
  result := [];
  for i := 0 to modality.count - 1 do
    result := result + [TFhirImagingModality(StringArrayIndexOf(CODES_TFhirImagingModality, modality[i].value))];
end;

Procedure TFhirImagingStudy.SetModalityST(value : TFhirImagingModalityList);
var a : TFhirImagingModality;
begin
  modality.clear;
  for a := low(TFhirImagingModality) to high(TFhirImagingModality) do
    if a in value then
      modality.add(TFhirEnum.create(CODES_TFhirImagingModality[a]));
end;

Procedure TFhirImagingStudy.SetReferrer(value : TFhirResourceReference{TFhirPractitioner});
begin
  FReferrer.free;
  FReferrer := value;
end;

Procedure TFhirImagingStudy.SetAvailability(value : TFhirEnum);
begin
  FAvailability.free;
  FAvailability := value;
end;

Function TFhirImagingStudy.GetAvailabilityST : TFhirInstanceAvailability;
begin
  if FAvailability = nil then
    result := TFhirInstanceAvailability(0)
  else
    result := TFhirInstanceAvailability(StringArrayIndexOf(CODES_TFhirInstanceAvailability, Availability.value));
end;

Procedure TFhirImagingStudy.SetAvailabilityST(value : TFhirInstanceAvailability);
begin
  if ord(value) = 0 then
    Availability := nil
  else
    Availability := TFhirEnum.create(CODES_TFhirInstanceAvailability[value]);
end;

Procedure TFhirImagingStudy.SetUrl(value : TFhirUri);
begin
  FUrl.free;
  FUrl := value;
end;

Function TFhirImagingStudy.GetUrlST : String;
begin
  if FUrl = nil then
    result := ''
  else
    result := Url.value;
end;

Procedure TFhirImagingStudy.SetUrlST(value : String);
begin
  if value <> '' then
  begin
    if FUrl = nil then
      FUrl := TFhirUri.create;
    FUrl.value := value
  end
  else if FUrl <> nil then
    FUrl.value := '';
end;

Procedure TFhirImagingStudy.SetNumberOfSeries(value : TFhirInteger);
begin
  FNumberOfSeries.free;
  FNumberOfSeries := value;
end;

Function TFhirImagingStudy.GetNumberOfSeriesST : String;
begin
  if FNumberOfSeries = nil then
    result := ''
  else
    result := NumberOfSeries.value;
end;

Procedure TFhirImagingStudy.SetNumberOfSeriesST(value : String);
begin
  if value <> '' then
  begin
    if FNumberOfSeries = nil then
      FNumberOfSeries := TFhirInteger.create;
    FNumberOfSeries.value := value
  end
  else if FNumberOfSeries <> nil then
    FNumberOfSeries.value := '';
end;

Procedure TFhirImagingStudy.SetNumberOfInstances(value : TFhirInteger);
begin
  FNumberOfInstances.free;
  FNumberOfInstances := value;
end;

Function TFhirImagingStudy.GetNumberOfInstancesST : String;
begin
  if FNumberOfInstances = nil then
    result := ''
  else
    result := NumberOfInstances.value;
end;

Procedure TFhirImagingStudy.SetNumberOfInstancesST(value : String);
begin
  if value <> '' then
  begin
    if FNumberOfInstances = nil then
      FNumberOfInstances := TFhirInteger.create;
    FNumberOfInstances.value := value
  end
  else if FNumberOfInstances <> nil then
    FNumberOfInstances.value := '';
end;

Procedure TFhirImagingStudy.SetClinicalInformation(value : TFhirString);
begin
  FClinicalInformation.free;
  FClinicalInformation := value;
end;

Function TFhirImagingStudy.GetClinicalInformationST : String;
begin
  if FClinicalInformation = nil then
    result := ''
  else
    result := ClinicalInformation.value;
end;

Procedure TFhirImagingStudy.SetClinicalInformationST(value : String);
begin
  if value <> '' then
  begin
    if FClinicalInformation = nil then
      FClinicalInformation := TFhirString.create;
    FClinicalInformation.value := value
  end
  else if FClinicalInformation <> nil then
    FClinicalInformation.value := '';
end;

Procedure TFhirImagingStudy.SetInterpreter(value : TFhirResourceReference{TFhirPractitioner});
begin
  FInterpreter.free;
  FInterpreter := value;
end;

Procedure TFhirImagingStudy.SetDescription(value : TFhirString);
begin
  FDescription.free;
  FDescription := value;
end;

Function TFhirImagingStudy.GetDescriptionST : String;
begin
  if FDescription = nil then
    result := ''
  else
    result := Description.value;
end;

Procedure TFhirImagingStudy.SetDescriptionST(value : String);
begin
  if value <> '' then
  begin
    if FDescription = nil then
      FDescription := TFhirString.create;
    FDescription.value := value
  end
  else if FDescription <> nil then
    FDescription.value := '';
end;


{ TFhirImmunization }

constructor TFhirImmunization.Create;
begin
  inherited;
  FReactionList := TFhirImmunizationReactionList.Create;
end;

destructor TFhirImmunization.Destroy;
begin
  FDate.free;
  FVaccineType.free;
  FSubject.free;
  FRefusedIndicator.free;
  FReported.free;
  FPerformer.free;
  FRequester.free;
  FManufacturer.free;
  FLocation.free;
  FLotNumber.free;
  FExpirationDate.free;
  FSite.free;
  FRoute.free;
  FDoseQuantity.free;
  FExplanation.free;
  FReactionList.Free;
  FVaccinationProtocol.free;
  inherited;
end;

function TFhirImmunization.GetResourceType : TFhirResourceType;
begin
  result := frtImmunization;
end;

procedure TFhirImmunization.Assign(oSource : TAdvObject);
begin
  inherited;
  date := TFhirImmunization(oSource).date.Clone;
  vaccineType := TFhirImmunization(oSource).vaccineType.Clone;
  subject := TFhirImmunization(oSource).subject.Clone;
  refusedIndicator := TFhirImmunization(oSource).refusedIndicator.Clone;
  reported := TFhirImmunization(oSource).reported.Clone;
  performer := TFhirImmunization(oSource).performer.Clone;
  requester := TFhirImmunization(oSource).requester.Clone;
  manufacturer := TFhirImmunization(oSource).manufacturer.Clone;
  location := TFhirImmunization(oSource).location.Clone;
  lotNumber := TFhirImmunization(oSource).lotNumber.Clone;
  expirationDate := TFhirImmunization(oSource).expirationDate.Clone;
  site := TFhirImmunization(oSource).site.Clone;
  route := TFhirImmunization(oSource).route.Clone;
  doseQuantity := TFhirImmunization(oSource).doseQuantity.Clone;
  explanation := TFhirImmunization(oSource).explanation.Clone;
  FReactionList.Assign(TFhirImmunization(oSource).FReactionList);
  vaccinationProtocol := TFhirImmunization(oSource).vaccinationProtocol.Clone;
end;

procedure TFhirImmunization.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'date') Then
     list.add(Date.Link);
  if (child_name = 'vaccineType') Then
     list.add(VaccineType.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'refusedIndicator') Then
     list.add(RefusedIndicator.Link);
  if (child_name = 'reported') Then
     list.add(Reported.Link);
  if (child_name = 'performer') Then
     list.add(Performer.Link);
  if (child_name = 'requester') Then
     list.add(Requester.Link);
  if (child_name = 'manufacturer') Then
     list.add(Manufacturer.Link);
  if (child_name = 'location') Then
     list.add(Location.Link);
  if (child_name = 'lotNumber') Then
     list.add(LotNumber.Link);
  if (child_name = 'expirationDate') Then
     list.add(ExpirationDate.Link);
  if (child_name = 'site') Then
     list.add(Site.Link);
  if (child_name = 'route') Then
     list.add(Route.Link);
  if (child_name = 'doseQuantity') Then
     list.add(DoseQuantity.Link);
  if (child_name = 'explanation') Then
     list.add(Explanation.Link);
  if (child_name = 'reaction') Then
     list.addAll(FReactionList);
  if (child_name = 'vaccinationProtocol') Then
     list.add(VaccinationProtocol.Link);
end;

procedure TFhirImmunization.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'date', 'dateTime', FDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'vaccineType', 'CodeableConcept', FVaccineType.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'refusedIndicator', 'boolean', FRefusedIndicator.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reported', 'boolean', FReported.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'performer', 'Resource(Practitioner)', FPerformer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'requester', 'Resource(Practitioner)', FRequester.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'manufacturer', 'Resource(Organization)', FManufacturer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'location', 'Resource(Location)', FLocation.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'lotNumber', 'string', FLotNumber.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'expirationDate', 'date', FExpirationDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'site', 'CodeableConcept', FSite.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'route', 'CodeableConcept', FRoute.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'doseQuantity', 'Quantity', FDoseQuantity.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'explanation', '', FExplanation.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reaction', '', FReactionList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'vaccinationProtocol', '', FVaccinationProtocol.Link.Link));{2}
end;

function TFhirImmunization.Link : TFhirImmunization;
begin
  result := TFhirImmunization(inherited Link);
end;

function TFhirImmunization.Clone : TFhirImmunization;
begin
  result := TFhirImmunization(inherited Clone);
end;

{ TFhirImmunization }

Procedure TFhirImmunization.SetDate(value : TFhirDateTime);
begin
  FDate.free;
  FDate := value;
end;

Function TFhirImmunization.GetDateST : TDateAndTime;
begin
  if FDate = nil then
    result := nil
  else
    result := Date.value;
end;

Procedure TFhirImmunization.SetDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDate = nil then
      FDate := TFhirDateTime.create;
    FDate.value := value
  end
  else if FDate <> nil then
    FDate.value := nil;
end;

Procedure TFhirImmunization.SetVaccineType(value : TFhirCodeableConcept);
begin
  FVaccineType.free;
  FVaccineType := value;
end;

Procedure TFhirImmunization.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirImmunization.SetRefusedIndicator(value : TFhirBoolean);
begin
  FRefusedIndicator.free;
  FRefusedIndicator := value;
end;

Function TFhirImmunization.GetRefusedIndicatorST : String;
begin
  if FRefusedIndicator = nil then
    result := ''
  else
    result := RefusedIndicator.value;
end;

Procedure TFhirImmunization.SetRefusedIndicatorST(value : String);
begin
  if value <> '' then
  begin
    if FRefusedIndicator = nil then
      FRefusedIndicator := TFhirBoolean.create;
    FRefusedIndicator.value := value
  end
  else if FRefusedIndicator <> nil then
    FRefusedIndicator.value := '';
end;

Procedure TFhirImmunization.SetReported(value : TFhirBoolean);
begin
  FReported.free;
  FReported := value;
end;

Function TFhirImmunization.GetReportedST : String;
begin
  if FReported = nil then
    result := ''
  else
    result := Reported.value;
end;

Procedure TFhirImmunization.SetReportedST(value : String);
begin
  if value <> '' then
  begin
    if FReported = nil then
      FReported := TFhirBoolean.create;
    FReported.value := value
  end
  else if FReported <> nil then
    FReported.value := '';
end;

Procedure TFhirImmunization.SetPerformer(value : TFhirResourceReference{TFhirPractitioner});
begin
  FPerformer.free;
  FPerformer := value;
end;

Procedure TFhirImmunization.SetRequester(value : TFhirResourceReference{TFhirPractitioner});
begin
  FRequester.free;
  FRequester := value;
end;

Procedure TFhirImmunization.SetManufacturer(value : TFhirResourceReference{TFhirOrganization});
begin
  FManufacturer.free;
  FManufacturer := value;
end;

Procedure TFhirImmunization.SetLocation(value : TFhirResourceReference{TFhirLocation});
begin
  FLocation.free;
  FLocation := value;
end;

Procedure TFhirImmunization.SetLotNumber(value : TFhirString);
begin
  FLotNumber.free;
  FLotNumber := value;
end;

Function TFhirImmunization.GetLotNumberST : String;
begin
  if FLotNumber = nil then
    result := ''
  else
    result := LotNumber.value;
end;

Procedure TFhirImmunization.SetLotNumberST(value : String);
begin
  if value <> '' then
  begin
    if FLotNumber = nil then
      FLotNumber := TFhirString.create;
    FLotNumber.value := value
  end
  else if FLotNumber <> nil then
    FLotNumber.value := '';
end;

Procedure TFhirImmunization.SetExpirationDate(value : TFhirDate);
begin
  FExpirationDate.free;
  FExpirationDate := value;
end;

Function TFhirImmunization.GetExpirationDateST : TDateAndTime;
begin
  if FExpirationDate = nil then
    result := nil
  else
    result := ExpirationDate.value;
end;

Procedure TFhirImmunization.SetExpirationDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FExpirationDate = nil then
      FExpirationDate := TFhirDate.create;
    FExpirationDate.value := value
  end
  else if FExpirationDate <> nil then
    FExpirationDate.value := nil;
end;

Procedure TFhirImmunization.SetSite(value : TFhirCodeableConcept);
begin
  FSite.free;
  FSite := value;
end;

Procedure TFhirImmunization.SetRoute(value : TFhirCodeableConcept);
begin
  FRoute.free;
  FRoute := value;
end;

Procedure TFhirImmunization.SetDoseQuantity(value : TFhirQuantity);
begin
  FDoseQuantity.free;
  FDoseQuantity := value;
end;

Procedure TFhirImmunization.SetExplanation(value : TFhirImmunizationExplanation);
begin
  FExplanation.free;
  FExplanation := value;
end;

Procedure TFhirImmunization.SetVaccinationProtocol(value : TFhirImmunizationVaccinationProtocol);
begin
  FVaccinationProtocol.free;
  FVaccinationProtocol := value;
end;


{ TFhirImmunizationProfile }

constructor TFhirImmunizationProfile.Create;
begin
  inherited;
  FRecommendationList := TFhirImmunizationProfileRecommendationList.Create;
end;

destructor TFhirImmunizationProfile.Destroy;
begin
  FSubject.free;
  FRecommendationList.Free;
  inherited;
end;

function TFhirImmunizationProfile.GetResourceType : TFhirResourceType;
begin
  result := frtImmunizationProfile;
end;

procedure TFhirImmunizationProfile.Assign(oSource : TAdvObject);
begin
  inherited;
  subject := TFhirImmunizationProfile(oSource).subject.Clone;
  FRecommendationList.Assign(TFhirImmunizationProfile(oSource).FRecommendationList);
end;

procedure TFhirImmunizationProfile.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'recommendation') Then
     list.addAll(FRecommendationList);
end;

procedure TFhirImmunizationProfile.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'recommendation', '', FRecommendationList.Link)){3};
end;

function TFhirImmunizationProfile.Link : TFhirImmunizationProfile;
begin
  result := TFhirImmunizationProfile(inherited Link);
end;

function TFhirImmunizationProfile.Clone : TFhirImmunizationProfile;
begin
  result := TFhirImmunizationProfile(inherited Clone);
end;

{ TFhirImmunizationProfile }

Procedure TFhirImmunizationProfile.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;


{ TFhirList }

constructor TFhirList.Create;
begin
  inherited;
  FEntryList := TFhirListEntryList.Create;
end;

destructor TFhirList.Destroy;
begin
  FCode.free;
  FSource.free;
  FDate.free;
  FOrdered.free;
  FMode.free;
  FEntryList.Free;
  FEmptyReason.free;
  inherited;
end;

function TFhirList.GetResourceType : TFhirResourceType;
begin
  result := frtList;
end;

procedure TFhirList.Assign(oSource : TAdvObject);
begin
  inherited;
  code := TFhirList(oSource).code.Clone;
  source := TFhirList(oSource).source.Clone;
  date := TFhirList(oSource).date.Clone;
  ordered := TFhirList(oSource).ordered.Clone;
  FMode := TFhirList(oSource).FMode.Link;
  FEntryList.Assign(TFhirList(oSource).FEntryList);
  emptyReason := TFhirList(oSource).emptyReason.Clone;
end;

procedure TFhirList.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'code') Then
     list.add(Code.Link);
  if (child_name = 'source') Then
     list.add(Source.Link);
  if (child_name = 'date') Then
     list.add(Date.Link);
  if (child_name = 'ordered') Then
     list.add(Ordered.Link);
  if (child_name = 'mode') Then
     list.add(FMode.Link);
  if (child_name = 'entry') Then
     list.addAll(FEntryList);
  if (child_name = 'emptyReason') Then
     list.add(EmptyReason.Link);
end;

procedure TFhirList.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'code', 'CodeableConcept', FCode.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'source', 'Resource(Practitioner|Patient|Device)', FSource.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'date', 'dateTime', FDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'ordered', 'boolean', FOrdered.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'mode', 'code', FMode.Link));{1}
  oList.add(TFHIRProperty.create(self, 'entry', '', FEntryList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'emptyReason', 'CodeableConcept', FEmptyReason.Link.Link));{2}
end;

function TFhirList.Link : TFhirList;
begin
  result := TFhirList(inherited Link);
end;

function TFhirList.Clone : TFhirList;
begin
  result := TFhirList(inherited Clone);
end;

{ TFhirList }

Procedure TFhirList.SetCode(value : TFhirCodeableConcept);
begin
  FCode.free;
  FCode := value;
end;

Procedure TFhirList.SetSource(value : TFhirResourceReference{Resource});
begin
  FSource.free;
  FSource := value;
end;

Procedure TFhirList.SetDate(value : TFhirDateTime);
begin
  FDate.free;
  FDate := value;
end;

Function TFhirList.GetDateST : TDateAndTime;
begin
  if FDate = nil then
    result := nil
  else
    result := Date.value;
end;

Procedure TFhirList.SetDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDate = nil then
      FDate := TFhirDateTime.create;
    FDate.value := value
  end
  else if FDate <> nil then
    FDate.value := nil;
end;

Procedure TFhirList.SetOrdered(value : TFhirBoolean);
begin
  FOrdered.free;
  FOrdered := value;
end;

Function TFhirList.GetOrderedST : String;
begin
  if FOrdered = nil then
    result := ''
  else
    result := Ordered.value;
end;

Procedure TFhirList.SetOrderedST(value : String);
begin
  if value <> '' then
  begin
    if FOrdered = nil then
      FOrdered := TFhirBoolean.create;
    FOrdered.value := value
  end
  else if FOrdered <> nil then
    FOrdered.value := '';
end;

Procedure TFhirList.SetMode(value : TFhirEnum);
begin
  FMode.free;
  FMode := value;
end;

Function TFhirList.GetModeST : TFhirListMode;
begin
  if FMode = nil then
    result := TFhirListMode(0)
  else
    result := TFhirListMode(StringArrayIndexOf(CODES_TFhirListMode, Mode.value));
end;

Procedure TFhirList.SetModeST(value : TFhirListMode);
begin
  if ord(value) = 0 then
    Mode := nil
  else
    Mode := TFhirEnum.create(CODES_TFhirListMode[value]);
end;

Procedure TFhirList.SetEmptyReason(value : TFhirCodeableConcept);
begin
  FEmptyReason.free;
  FEmptyReason := value;
end;


{ TFhirLocation }

constructor TFhirLocation.Create;
begin
  inherited;
  FType_List := TFhirCodeableConceptList.Create;
end;

destructor TFhirLocation.Destroy;
begin
  FName.free;
  FDescription.free;
  FType_List.Free;
  FTelecom.free;
  FAddress.free;
  FPosition.free;
  FProvider.free;
  FActive.free;
  FPartOf.free;
  inherited;
end;

function TFhirLocation.GetResourceType : TFhirResourceType;
begin
  result := frtLocation;
end;

procedure TFhirLocation.Assign(oSource : TAdvObject);
begin
  inherited;
  name := TFhirLocation(oSource).name.Clone;
  description := TFhirLocation(oSource).description.Clone;
  FType_List.Assign(TFhirLocation(oSource).FType_List);
  telecom := TFhirLocation(oSource).telecom.Clone;
  address := TFhirLocation(oSource).address.Clone;
  position := TFhirLocation(oSource).position.Clone;
  provider := TFhirLocation(oSource).provider.Clone;
  active := TFhirLocation(oSource).active.Clone;
  partOf := TFhirLocation(oSource).partOf.Clone;
end;

procedure TFhirLocation.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'description') Then
     list.add(Description.Link);
  if (child_name = 'type_') Then
     list.addAll(FType_List);
  if (child_name = 'telecom') Then
     list.add(Telecom.Link);
  if (child_name = 'address') Then
     list.add(Address.Link);
  if (child_name = 'position') Then
     list.add(Position.Link);
  if (child_name = 'provider') Then
     list.add(Provider.Link);
  if (child_name = 'active') Then
     list.add(Active.Link);
  if (child_name = 'partOf') Then
     list.add(PartOf.Link);
end;

procedure TFhirLocation.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'name', 'string', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'description', 'string', FDescription.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'type', 'CodeableConcept', FType_List.Link)){3};
  oList.add(TFHIRProperty.create(self, 'telecom', 'Contact', FTelecom.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'address', 'Address', FAddress.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'position', '', FPosition.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'provider', 'Resource(Organization)', FProvider.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'active', 'boolean', FActive.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'partOf', 'Resource(Location)', FPartOf.Link.Link));{2}
end;

function TFhirLocation.Link : TFhirLocation;
begin
  result := TFhirLocation(inherited Link);
end;

function TFhirLocation.Clone : TFhirLocation;
begin
  result := TFhirLocation(inherited Clone);
end;

{ TFhirLocation }

Procedure TFhirLocation.SetName(value : TFhirString);
begin
  FName.free;
  FName := value;
end;

Function TFhirLocation.GetNameST : String;
begin
  if FName = nil then
    result := ''
  else
    result := Name.value;
end;

Procedure TFhirLocation.SetNameST(value : String);
begin
  if value <> '' then
  begin
    if FName = nil then
      FName := TFhirString.create;
    FName.value := value
  end
  else if FName <> nil then
    FName.value := '';
end;

Procedure TFhirLocation.SetDescription(value : TFhirString);
begin
  FDescription.free;
  FDescription := value;
end;

Function TFhirLocation.GetDescriptionST : String;
begin
  if FDescription = nil then
    result := ''
  else
    result := Description.value;
end;

Procedure TFhirLocation.SetDescriptionST(value : String);
begin
  if value <> '' then
  begin
    if FDescription = nil then
      FDescription := TFhirString.create;
    FDescription.value := value
  end
  else if FDescription <> nil then
    FDescription.value := '';
end;

Procedure TFhirLocation.SetTelecom(value : TFhirContact);
begin
  FTelecom.free;
  FTelecom := value;
end;

Procedure TFhirLocation.SetAddress(value : TFhirAddress);
begin
  FAddress.free;
  FAddress := value;
end;

Procedure TFhirLocation.SetPosition(value : TFhirLocationPosition);
begin
  FPosition.free;
  FPosition := value;
end;

Procedure TFhirLocation.SetProvider(value : TFhirResourceReference{TFhirOrganization});
begin
  FProvider.free;
  FProvider := value;
end;

Procedure TFhirLocation.SetActive(value : TFhirBoolean);
begin
  FActive.free;
  FActive := value;
end;

Function TFhirLocation.GetActiveST : String;
begin
  if FActive = nil then
    result := ''
  else
    result := Active.value;
end;

Procedure TFhirLocation.SetActiveST(value : String);
begin
  if value <> '' then
  begin
    if FActive = nil then
      FActive := TFhirBoolean.create;
    FActive.value := value
  end
  else if FActive <> nil then
    FActive.value := '';
end;

Procedure TFhirLocation.SetPartOf(value : TFhirResourceReference{TFhirLocation});
begin
  FPartOf.free;
  FPartOf := value;
end;


{ TFhirMedia }

constructor TFhirMedia.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
end;

destructor TFhirMedia.Destroy;
begin
  FType_.free;
  FSubtype.free;
  FIdentifierList.Free;
  FDateTime.free;
  FSubject.free;
  FRequester.free;
  FOperator.free;
  FView.free;
  FDeviceName.free;
  FHeight.free;
  FWidth.free;
  FFrames.free;
  FLength.free;
  FContent.free;
  inherited;
end;

function TFhirMedia.GetResourceType : TFhirResourceType;
begin
  result := frtMedia;
end;

procedure TFhirMedia.Assign(oSource : TAdvObject);
begin
  inherited;
  FType_ := TFhirMedia(oSource).FType_.Link;
  subtype := TFhirMedia(oSource).subtype.Clone;
  FIdentifierList.Assign(TFhirMedia(oSource).FIdentifierList);
  dateTime := TFhirMedia(oSource).dateTime.Clone;
  subject := TFhirMedia(oSource).subject.Clone;
  requester := TFhirMedia(oSource).requester.Clone;
  operator := TFhirMedia(oSource).operator.Clone;
  view := TFhirMedia(oSource).view.Clone;
  deviceName := TFhirMedia(oSource).deviceName.Clone;
  height := TFhirMedia(oSource).height.Clone;
  width := TFhirMedia(oSource).width.Clone;
  frames := TFhirMedia(oSource).frames.Clone;
  length := TFhirMedia(oSource).length.Clone;
  content := TFhirMedia(oSource).content.Clone;
end;

procedure TFhirMedia.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'type_') Then
     list.add(FType_.Link);
  if (child_name = 'subtype') Then
     list.add(Subtype.Link);
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'dateTime') Then
     list.add(DateTime.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'requester') Then
     list.add(Requester.Link);
  if (child_name = 'operator') Then
     list.add(Operator.Link);
  if (child_name = 'view') Then
     list.add(View.Link);
  if (child_name = 'deviceName') Then
     list.add(DeviceName.Link);
  if (child_name = 'height') Then
     list.add(Height.Link);
  if (child_name = 'width') Then
     list.add(Width.Link);
  if (child_name = 'frames') Then
     list.add(Frames.Link);
  if (child_name = 'length') Then
     list.add(Length.Link);
  if (child_name = 'content') Then
     list.add(Content.Link);
end;

procedure TFhirMedia.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'type', 'code', FType_.Link));{1}
  oList.add(TFHIRProperty.create(self, 'subtype', 'CodeableConcept', FSubtype.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'dateTime', 'dateTime', FDateTime.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient|Practitioner|Group|Device|Specimen)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'requester', 'Resource(Practitioner)', FRequester.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'operator', 'Resource(Practitioner)', FOperator.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'view', 'CodeableConcept', FView.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'deviceName', 'string', FDeviceName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'height', 'integer', FHeight.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'width', 'integer', FWidth.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'frames', 'integer', FFrames.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'length', 'integer', FLength.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'content', 'Attachment', FContent.Link.Link));{2}
end;

function TFhirMedia.Link : TFhirMedia;
begin
  result := TFhirMedia(inherited Link);
end;

function TFhirMedia.Clone : TFhirMedia;
begin
  result := TFhirMedia(inherited Clone);
end;

{ TFhirMedia }

Procedure TFhirMedia.SetType_(value : TFhirEnum);
begin
  FType_.free;
  FType_ := value;
end;

Function TFhirMedia.GetType_ST : TFhirMediaType;
begin
  if FType_ = nil then
    result := TFhirMediaType(0)
  else
    result := TFhirMediaType(StringArrayIndexOf(CODES_TFhirMediaType, Type_.value));
end;

Procedure TFhirMedia.SetType_ST(value : TFhirMediaType);
begin
  if ord(value) = 0 then
    Type_ := nil
  else
    Type_ := TFhirEnum.create(CODES_TFhirMediaType[value]);
end;

Procedure TFhirMedia.SetSubtype(value : TFhirCodeableConcept);
begin
  FSubtype.free;
  FSubtype := value;
end;

Procedure TFhirMedia.SetDateTime(value : TFhirDateTime);
begin
  FDateTime.free;
  FDateTime := value;
end;

Function TFhirMedia.GetDateTimeST : TDateAndTime;
begin
  if FDateTime = nil then
    result := nil
  else
    result := DateTime.value;
end;

Procedure TFhirMedia.SetDateTimeST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDateTime = nil then
      FDateTime := TFhirDateTime.create;
    FDateTime.value := value
  end
  else if FDateTime <> nil then
    FDateTime.value := nil;
end;

Procedure TFhirMedia.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirMedia.SetRequester(value : TFhirResourceReference{TFhirPractitioner});
begin
  FRequester.free;
  FRequester := value;
end;

Procedure TFhirMedia.SetOperator(value : TFhirResourceReference{TFhirPractitioner});
begin
  FOperator.free;
  FOperator := value;
end;

Procedure TFhirMedia.SetView(value : TFhirCodeableConcept);
begin
  FView.free;
  FView := value;
end;

Procedure TFhirMedia.SetDeviceName(value : TFhirString);
begin
  FDeviceName.free;
  FDeviceName := value;
end;

Function TFhirMedia.GetDeviceNameST : String;
begin
  if FDeviceName = nil then
    result := ''
  else
    result := DeviceName.value;
end;

Procedure TFhirMedia.SetDeviceNameST(value : String);
begin
  if value <> '' then
  begin
    if FDeviceName = nil then
      FDeviceName := TFhirString.create;
    FDeviceName.value := value
  end
  else if FDeviceName <> nil then
    FDeviceName.value := '';
end;

Procedure TFhirMedia.SetHeight(value : TFhirInteger);
begin
  FHeight.free;
  FHeight := value;
end;

Function TFhirMedia.GetHeightST : String;
begin
  if FHeight = nil then
    result := ''
  else
    result := Height.value;
end;

Procedure TFhirMedia.SetHeightST(value : String);
begin
  if value <> '' then
  begin
    if FHeight = nil then
      FHeight := TFhirInteger.create;
    FHeight.value := value
  end
  else if FHeight <> nil then
    FHeight.value := '';
end;

Procedure TFhirMedia.SetWidth(value : TFhirInteger);
begin
  FWidth.free;
  FWidth := value;
end;

Function TFhirMedia.GetWidthST : String;
begin
  if FWidth = nil then
    result := ''
  else
    result := Width.value;
end;

Procedure TFhirMedia.SetWidthST(value : String);
begin
  if value <> '' then
  begin
    if FWidth = nil then
      FWidth := TFhirInteger.create;
    FWidth.value := value
  end
  else if FWidth <> nil then
    FWidth.value := '';
end;

Procedure TFhirMedia.SetFrames(value : TFhirInteger);
begin
  FFrames.free;
  FFrames := value;
end;

Function TFhirMedia.GetFramesST : String;
begin
  if FFrames = nil then
    result := ''
  else
    result := Frames.value;
end;

Procedure TFhirMedia.SetFramesST(value : String);
begin
  if value <> '' then
  begin
    if FFrames = nil then
      FFrames := TFhirInteger.create;
    FFrames.value := value
  end
  else if FFrames <> nil then
    FFrames.value := '';
end;

Procedure TFhirMedia.SetLength(value : TFhirInteger);
begin
  FLength.free;
  FLength := value;
end;

Function TFhirMedia.GetLengthST : String;
begin
  if FLength = nil then
    result := ''
  else
    result := Length.value;
end;

Procedure TFhirMedia.SetLengthST(value : String);
begin
  if value <> '' then
  begin
    if FLength = nil then
      FLength := TFhirInteger.create;
    FLength.value := value
  end
  else if FLength <> nil then
    FLength.value := '';
end;

Procedure TFhirMedia.SetContent(value : TFhirAttachment);
begin
  FContent.free;
  FContent := value;
end;


{ TFhirMedication }

constructor TFhirMedication.Create;
begin
  inherited;
end;

destructor TFhirMedication.Destroy;
begin
  FName.free;
  FCode.free;
  FIsBrand.free;
  FManufacturer.free;
  FKind.free;
  FProduct.free;
  FPackage.free;
  inherited;
end;

function TFhirMedication.GetResourceType : TFhirResourceType;
begin
  result := frtMedication;
end;

procedure TFhirMedication.Assign(oSource : TAdvObject);
begin
  inherited;
  name := TFhirMedication(oSource).name.Clone;
  code := TFhirMedication(oSource).code.Clone;
  isBrand := TFhirMedication(oSource).isBrand.Clone;
  manufacturer := TFhirMedication(oSource).manufacturer.Clone;
  FKind := TFhirMedication(oSource).FKind.Link;
  product := TFhirMedication(oSource).product.Clone;
  package := TFhirMedication(oSource).package.Clone;
end;

procedure TFhirMedication.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'code') Then
     list.add(Code.Link);
  if (child_name = 'isBrand') Then
     list.add(IsBrand.Link);
  if (child_name = 'manufacturer') Then
     list.add(Manufacturer.Link);
  if (child_name = 'kind') Then
     list.add(FKind.Link);
  if (child_name = 'product') Then
     list.add(Product.Link);
  if (child_name = 'package') Then
     list.add(Package.Link);
end;

procedure TFhirMedication.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'name', 'string', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'code', 'CodeableConcept', FCode.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'isBrand', 'boolean', FIsBrand.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'manufacturer', 'Resource(Organization)', FManufacturer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'kind', 'code', FKind.Link));{1}
  oList.add(TFHIRProperty.create(self, 'product', '', FProduct.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'package', '', FPackage.Link.Link));{2}
end;

function TFhirMedication.Link : TFhirMedication;
begin
  result := TFhirMedication(inherited Link);
end;

function TFhirMedication.Clone : TFhirMedication;
begin
  result := TFhirMedication(inherited Clone);
end;

{ TFhirMedication }

Procedure TFhirMedication.SetName(value : TFhirString);
begin
  FName.free;
  FName := value;
end;

Function TFhirMedication.GetNameST : String;
begin
  if FName = nil then
    result := ''
  else
    result := Name.value;
end;

Procedure TFhirMedication.SetNameST(value : String);
begin
  if value <> '' then
  begin
    if FName = nil then
      FName := TFhirString.create;
    FName.value := value
  end
  else if FName <> nil then
    FName.value := '';
end;

Procedure TFhirMedication.SetCode(value : TFhirCodeableConcept);
begin
  FCode.free;
  FCode := value;
end;

Procedure TFhirMedication.SetIsBrand(value : TFhirBoolean);
begin
  FIsBrand.free;
  FIsBrand := value;
end;

Function TFhirMedication.GetIsBrandST : String;
begin
  if FIsBrand = nil then
    result := ''
  else
    result := IsBrand.value;
end;

Procedure TFhirMedication.SetIsBrandST(value : String);
begin
  if value <> '' then
  begin
    if FIsBrand = nil then
      FIsBrand := TFhirBoolean.create;
    FIsBrand.value := value
  end
  else if FIsBrand <> nil then
    FIsBrand.value := '';
end;

Procedure TFhirMedication.SetManufacturer(value : TFhirResourceReference{TFhirOrganization});
begin
  FManufacturer.free;
  FManufacturer := value;
end;

Procedure TFhirMedication.SetKind(value : TFhirEnum);
begin
  FKind.free;
  FKind := value;
end;

Function TFhirMedication.GetKindST : TFhirMedicationKind;
begin
  if FKind = nil then
    result := TFhirMedicationKind(0)
  else
    result := TFhirMedicationKind(StringArrayIndexOf(CODES_TFhirMedicationKind, Kind.value));
end;

Procedure TFhirMedication.SetKindST(value : TFhirMedicationKind);
begin
  if ord(value) = 0 then
    Kind := nil
  else
    Kind := TFhirEnum.create(CODES_TFhirMedicationKind[value]);
end;

Procedure TFhirMedication.SetProduct(value : TFhirMedicationProduct);
begin
  FProduct.free;
  FProduct := value;
end;

Procedure TFhirMedication.SetPackage(value : TFhirMedicationPackage);
begin
  FPackage.free;
  FPackage := value;
end;


{ TFhirMedicationAdministration }

constructor TFhirMedicationAdministration.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FReasonNotGivenList := TFhirCodeableConceptList.Create;
  FAdministrationDeviceList := TFhirResourceReferenceList{TFhirDevice}.Create;
  FDosageList := TFhirMedicationAdministrationDosageList.Create;
end;

destructor TFhirMedicationAdministration.Destroy;
begin
  FIdentifierList.Free;
  FStatus.free;
  FPatient.free;
  FPractitioner.free;
  FEncounter.free;
  FPrescription.free;
  FWasNotGiven.free;
  FReasonNotGivenList.Free;
  FWhenGiven.free;
  FMedication.free;
  FAdministrationDeviceList.Free;
  FDosageList.Free;
  inherited;
end;

function TFhirMedicationAdministration.GetResourceType : TFhirResourceType;
begin
  result := frtMedicationAdministration;
end;

procedure TFhirMedicationAdministration.Assign(oSource : TAdvObject);
begin
  inherited;
  FIdentifierList.Assign(TFhirMedicationAdministration(oSource).FIdentifierList);
  FStatus := TFhirMedicationAdministration(oSource).FStatus.Link;
  patient := TFhirMedicationAdministration(oSource).patient.Clone;
  practitioner := TFhirMedicationAdministration(oSource).practitioner.Clone;
  encounter := TFhirMedicationAdministration(oSource).encounter.Clone;
  prescription := TFhirMedicationAdministration(oSource).prescription.Clone;
  wasNotGiven := TFhirMedicationAdministration(oSource).wasNotGiven.Clone;
  FReasonNotGivenList.Assign(TFhirMedicationAdministration(oSource).FReasonNotGivenList);
  whenGiven := TFhirMedicationAdministration(oSource).whenGiven.Clone;
  medication := TFhirMedicationAdministration(oSource).medication.Clone;
  FAdministrationDeviceList.Assign(TFhirMedicationAdministration(oSource).FAdministrationDeviceList);
  FDosageList.Assign(TFhirMedicationAdministration(oSource).FDosageList);
end;

procedure TFhirMedicationAdministration.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'patient') Then
     list.add(Patient.Link);
  if (child_name = 'practitioner') Then
     list.add(Practitioner.Link);
  if (child_name = 'encounter') Then
     list.add(Encounter.Link);
  if (child_name = 'prescription') Then
     list.add(Prescription.Link);
  if (child_name = 'wasNotGiven') Then
     list.add(WasNotGiven.Link);
  if (child_name = 'reasonNotGiven') Then
     list.addAll(FReasonNotGivenList);
  if (child_name = 'whenGiven') Then
     list.add(WhenGiven.Link);
  if (child_name = 'medication') Then
     list.add(Medication.Link);
  if (child_name = 'administrationDevice') Then
     list.addAll(FAdministrationDeviceList);
  if (child_name = 'dosage') Then
     list.addAll(FDosageList);
end;

procedure TFhirMedicationAdministration.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'patient', 'Resource(Patient)', FPatient.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'practitioner', 'Resource(Practitioner)', FPractitioner.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'encounter', 'Resource(Encounter)', FEncounter.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'prescription', 'Resource(MedicationPrescription)', FPrescription.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'wasNotGiven', 'boolean', FWasNotGiven.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reasonNotGiven', 'CodeableConcept', FReasonNotGivenList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'whenGiven', 'Period', FWhenGiven.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'medication', 'Resource(Medication)', FMedication.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'administrationDevice', 'Resource(Device)', FAdministrationDeviceList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'dosage', '', FDosageList.Link)){3};
end;

function TFhirMedicationAdministration.Link : TFhirMedicationAdministration;
begin
  result := TFhirMedicationAdministration(inherited Link);
end;

function TFhirMedicationAdministration.Clone : TFhirMedicationAdministration;
begin
  result := TFhirMedicationAdministration(inherited Clone);
end;

{ TFhirMedicationAdministration }

Procedure TFhirMedicationAdministration.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirMedicationAdministration.GetStatusST : TFhirMedicationAdminStatus;
begin
  if FStatus = nil then
    result := TFhirMedicationAdminStatus(0)
  else
    result := TFhirMedicationAdminStatus(StringArrayIndexOf(CODES_TFhirMedicationAdminStatus, Status.value));
end;

Procedure TFhirMedicationAdministration.SetStatusST(value : TFhirMedicationAdminStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirMedicationAdminStatus[value]);
end;

Procedure TFhirMedicationAdministration.SetPatient(value : TFhirResourceReference{TFhirPatient});
begin
  FPatient.free;
  FPatient := value;
end;

Procedure TFhirMedicationAdministration.SetPractitioner(value : TFhirResourceReference{TFhirPractitioner});
begin
  FPractitioner.free;
  FPractitioner := value;
end;

Procedure TFhirMedicationAdministration.SetEncounter(value : TFhirResourceReference{TFhirEncounter});
begin
  FEncounter.free;
  FEncounter := value;
end;

Procedure TFhirMedicationAdministration.SetPrescription(value : TFhirResourceReference{TFhirMedicationPrescription});
begin
  FPrescription.free;
  FPrescription := value;
end;

Procedure TFhirMedicationAdministration.SetWasNotGiven(value : TFhirBoolean);
begin
  FWasNotGiven.free;
  FWasNotGiven := value;
end;

Function TFhirMedicationAdministration.GetWasNotGivenST : String;
begin
  if FWasNotGiven = nil then
    result := ''
  else
    result := WasNotGiven.value;
end;

Procedure TFhirMedicationAdministration.SetWasNotGivenST(value : String);
begin
  if value <> '' then
  begin
    if FWasNotGiven = nil then
      FWasNotGiven := TFhirBoolean.create;
    FWasNotGiven.value := value
  end
  else if FWasNotGiven <> nil then
    FWasNotGiven.value := '';
end;

Procedure TFhirMedicationAdministration.SetWhenGiven(value : TFhirPeriod);
begin
  FWhenGiven.free;
  FWhenGiven := value;
end;

Procedure TFhirMedicationAdministration.SetMedication(value : TFhirResourceReference{TFhirMedication});
begin
  FMedication.free;
  FMedication := value;
end;


{ TFhirMedicationDispense }

constructor TFhirMedicationDispense.Create;
begin
  inherited;
  FAuthorizingPrescriptionList := TFhirResourceReferenceList{TFhirMedicationPrescription}.Create;
  FDispenseList := TFhirMedicationDispenseDispenseList.Create;
end;

destructor TFhirMedicationDispense.Destroy;
begin
  FIdentifier.free;
  FStatus.free;
  FPatient.free;
  FDispenser.free;
  FAuthorizingPrescriptionList.Free;
  FDispenseList.Free;
  FSubstitution.free;
  inherited;
end;

function TFhirMedicationDispense.GetResourceType : TFhirResourceType;
begin
  result := frtMedicationDispense;
end;

procedure TFhirMedicationDispense.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirMedicationDispense(oSource).identifier.Clone;
  FStatus := TFhirMedicationDispense(oSource).FStatus.Link;
  patient := TFhirMedicationDispense(oSource).patient.Clone;
  dispenser := TFhirMedicationDispense(oSource).dispenser.Clone;
  FAuthorizingPrescriptionList.Assign(TFhirMedicationDispense(oSource).FAuthorizingPrescriptionList);
  FDispenseList.Assign(TFhirMedicationDispense(oSource).FDispenseList);
  substitution := TFhirMedicationDispense(oSource).substitution.Clone;
end;

procedure TFhirMedicationDispense.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'patient') Then
     list.add(Patient.Link);
  if (child_name = 'dispenser') Then
     list.add(Dispenser.Link);
  if (child_name = 'authorizingPrescription') Then
     list.addAll(FAuthorizingPrescriptionList);
  if (child_name = 'dispense') Then
     list.addAll(FDispenseList);
  if (child_name = 'substitution') Then
     list.add(Substitution.Link);
end;

procedure TFhirMedicationDispense.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'patient', 'Resource(Patient)', FPatient.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'dispenser', 'Resource(Practitioner)', FDispenser.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'authorizingPrescription', 'Resource(MedicationPrescription)', FAuthorizingPrescriptionList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'dispense', '', FDispenseList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'substitution', '', FSubstitution.Link.Link));{2}
end;

function TFhirMedicationDispense.Link : TFhirMedicationDispense;
begin
  result := TFhirMedicationDispense(inherited Link);
end;

function TFhirMedicationDispense.Clone : TFhirMedicationDispense;
begin
  result := TFhirMedicationDispense(inherited Clone);
end;

{ TFhirMedicationDispense }

Procedure TFhirMedicationDispense.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirMedicationDispense.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirMedicationDispense.GetStatusST : TFhirMedicationDispenseStatus;
begin
  if FStatus = nil then
    result := TFhirMedicationDispenseStatus(0)
  else
    result := TFhirMedicationDispenseStatus(StringArrayIndexOf(CODES_TFhirMedicationDispenseStatus, Status.value));
end;

Procedure TFhirMedicationDispense.SetStatusST(value : TFhirMedicationDispenseStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirMedicationDispenseStatus[value]);
end;

Procedure TFhirMedicationDispense.SetPatient(value : TFhirResourceReference{TFhirPatient});
begin
  FPatient.free;
  FPatient := value;
end;

Procedure TFhirMedicationDispense.SetDispenser(value : TFhirResourceReference{TFhirPractitioner});
begin
  FDispenser.free;
  FDispenser := value;
end;

Procedure TFhirMedicationDispense.SetSubstitution(value : TFhirMedicationDispenseSubstitution);
begin
  FSubstitution.free;
  FSubstitution := value;
end;


{ TFhirMedicationPrescription }

constructor TFhirMedicationPrescription.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FDosageInstructionList := TFhirMedicationPrescriptionDosageInstructionList.Create;
end;

destructor TFhirMedicationPrescription.Destroy;
begin
  FIdentifierList.Free;
  FDateWritten.free;
  FStatus.free;
  FPatient.free;
  FPrescriber.free;
  FEncounter.free;
  FReasonForPrescribing.free;
  FMedication.free;
  FDosageInstructionList.Free;
  FDispense.free;
  FSubstitution.free;
  inherited;
end;

function TFhirMedicationPrescription.GetResourceType : TFhirResourceType;
begin
  result := frtMedicationPrescription;
end;

procedure TFhirMedicationPrescription.Assign(oSource : TAdvObject);
begin
  inherited;
  FIdentifierList.Assign(TFhirMedicationPrescription(oSource).FIdentifierList);
  dateWritten := TFhirMedicationPrescription(oSource).dateWritten.Clone;
  FStatus := TFhirMedicationPrescription(oSource).FStatus.Link;
  patient := TFhirMedicationPrescription(oSource).patient.Clone;
  prescriber := TFhirMedicationPrescription(oSource).prescriber.Clone;
  encounter := TFhirMedicationPrescription(oSource).encounter.Clone;
  reasonForPrescribing := TFhirMedicationPrescription(oSource).reasonForPrescribing.Clone;
  medication := TFhirMedicationPrescription(oSource).medication.Clone;
  FDosageInstructionList.Assign(TFhirMedicationPrescription(oSource).FDosageInstructionList);
  dispense := TFhirMedicationPrescription(oSource).dispense.Clone;
  substitution := TFhirMedicationPrescription(oSource).substitution.Clone;
end;

procedure TFhirMedicationPrescription.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'dateWritten') Then
     list.add(DateWritten.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'patient') Then
     list.add(Patient.Link);
  if (child_name = 'prescriber') Then
     list.add(Prescriber.Link);
  if (child_name = 'encounter') Then
     list.add(Encounter.Link);
  if (child_name = 'reasonForPrescribing') Then
     list.add(ReasonForPrescribing.Link);
  if (child_name = 'medication') Then
     list.add(Medication.Link);
  if (child_name = 'dosageInstruction') Then
     list.addAll(FDosageInstructionList);
  if (child_name = 'dispense') Then
     list.add(Dispense.Link);
  if (child_name = 'substitution') Then
     list.add(Substitution.Link);
end;

procedure TFhirMedicationPrescription.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'dateWritten', 'dateTime', FDateWritten.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'patient', 'Resource(Patient)', FPatient.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'prescriber', 'Resource(Practitioner)', FPrescriber.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'encounter', 'Resource(Encounter)', FEncounter.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reasonForPrescribing[x]', 'string|CodeableConcept', FReasonForPrescribing.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'medication', 'Resource(Medication)', FMedication.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'dosageInstruction', '', FDosageInstructionList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'dispense', '', FDispense.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'substitution', '', FSubstitution.Link.Link));{2}
end;

function TFhirMedicationPrescription.Link : TFhirMedicationPrescription;
begin
  result := TFhirMedicationPrescription(inherited Link);
end;

function TFhirMedicationPrescription.Clone : TFhirMedicationPrescription;
begin
  result := TFhirMedicationPrescription(inherited Clone);
end;

{ TFhirMedicationPrescription }

Procedure TFhirMedicationPrescription.SetDateWritten(value : TFhirDateTime);
begin
  FDateWritten.free;
  FDateWritten := value;
end;

Function TFhirMedicationPrescription.GetDateWrittenST : TDateAndTime;
begin
  if FDateWritten = nil then
    result := nil
  else
    result := DateWritten.value;
end;

Procedure TFhirMedicationPrescription.SetDateWrittenST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDateWritten = nil then
      FDateWritten := TFhirDateTime.create;
    FDateWritten.value := value
  end
  else if FDateWritten <> nil then
    FDateWritten.value := nil;
end;

Procedure TFhirMedicationPrescription.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirMedicationPrescription.GetStatusST : TFhirMedicationPrescriptionStatus;
begin
  if FStatus = nil then
    result := TFhirMedicationPrescriptionStatus(0)
  else
    result := TFhirMedicationPrescriptionStatus(StringArrayIndexOf(CODES_TFhirMedicationPrescriptionStatus, Status.value));
end;

Procedure TFhirMedicationPrescription.SetStatusST(value : TFhirMedicationPrescriptionStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirMedicationPrescriptionStatus[value]);
end;

Procedure TFhirMedicationPrescription.SetPatient(value : TFhirResourceReference{TFhirPatient});
begin
  FPatient.free;
  FPatient := value;
end;

Procedure TFhirMedicationPrescription.SetPrescriber(value : TFhirResourceReference{TFhirPractitioner});
begin
  FPrescriber.free;
  FPrescriber := value;
end;

Procedure TFhirMedicationPrescription.SetEncounter(value : TFhirResourceReference{TFhirEncounter});
begin
  FEncounter.free;
  FEncounter := value;
end;

Procedure TFhirMedicationPrescription.SetReasonForPrescribing(value : TFhirType);
begin
  FReasonForPrescribing.free;
  FReasonForPrescribing := value;
end;

Procedure TFhirMedicationPrescription.SetMedication(value : TFhirResourceReference{TFhirMedication});
begin
  FMedication.free;
  FMedication := value;
end;

Procedure TFhirMedicationPrescription.SetDispense(value : TFhirMedicationPrescriptionDispense);
begin
  FDispense.free;
  FDispense := value;
end;

Procedure TFhirMedicationPrescription.SetSubstitution(value : TFhirMedicationPrescriptionSubstitution);
begin
  FSubstitution.free;
  FSubstitution := value;
end;


{ TFhirMedicationStatement }

constructor TFhirMedicationStatement.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FReasonNotGivenList := TFhirCodeableConceptList.Create;
  FAdministrationDeviceList := TFhirResourceReferenceList{TFhirDevice}.Create;
  FDosageList := TFhirMedicationStatementDosageList.Create;
end;

destructor TFhirMedicationStatement.Destroy;
begin
  FIdentifierList.Free;
  FPatient.free;
  FWasNotGiven.free;
  FReasonNotGivenList.Free;
  FWhenGiven.free;
  FMedication.free;
  FAdministrationDeviceList.Free;
  FDosageList.Free;
  inherited;
end;

function TFhirMedicationStatement.GetResourceType : TFhirResourceType;
begin
  result := frtMedicationStatement;
end;

procedure TFhirMedicationStatement.Assign(oSource : TAdvObject);
begin
  inherited;
  FIdentifierList.Assign(TFhirMedicationStatement(oSource).FIdentifierList);
  patient := TFhirMedicationStatement(oSource).patient.Clone;
  wasNotGiven := TFhirMedicationStatement(oSource).wasNotGiven.Clone;
  FReasonNotGivenList.Assign(TFhirMedicationStatement(oSource).FReasonNotGivenList);
  whenGiven := TFhirMedicationStatement(oSource).whenGiven.Clone;
  medication := TFhirMedicationStatement(oSource).medication.Clone;
  FAdministrationDeviceList.Assign(TFhirMedicationStatement(oSource).FAdministrationDeviceList);
  FDosageList.Assign(TFhirMedicationStatement(oSource).FDosageList);
end;

procedure TFhirMedicationStatement.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'patient') Then
     list.add(Patient.Link);
  if (child_name = 'wasNotGiven') Then
     list.add(WasNotGiven.Link);
  if (child_name = 'reasonNotGiven') Then
     list.addAll(FReasonNotGivenList);
  if (child_name = 'whenGiven') Then
     list.add(WhenGiven.Link);
  if (child_name = 'medication') Then
     list.add(Medication.Link);
  if (child_name = 'administrationDevice') Then
     list.addAll(FAdministrationDeviceList);
  if (child_name = 'dosage') Then
     list.addAll(FDosageList);
end;

procedure TFhirMedicationStatement.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'patient', 'Resource(Patient)', FPatient.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'wasNotGiven', 'boolean', FWasNotGiven.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reasonNotGiven', 'CodeableConcept', FReasonNotGivenList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'whenGiven', 'Period', FWhenGiven.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'medication', 'Resource(Medication)', FMedication.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'administrationDevice', 'Resource(Device)', FAdministrationDeviceList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'dosage', '', FDosageList.Link)){3};
end;

function TFhirMedicationStatement.Link : TFhirMedicationStatement;
begin
  result := TFhirMedicationStatement(inherited Link);
end;

function TFhirMedicationStatement.Clone : TFhirMedicationStatement;
begin
  result := TFhirMedicationStatement(inherited Clone);
end;

{ TFhirMedicationStatement }

Procedure TFhirMedicationStatement.SetPatient(value : TFhirResourceReference{TFhirPatient});
begin
  FPatient.free;
  FPatient := value;
end;

Procedure TFhirMedicationStatement.SetWasNotGiven(value : TFhirBoolean);
begin
  FWasNotGiven.free;
  FWasNotGiven := value;
end;

Function TFhirMedicationStatement.GetWasNotGivenST : String;
begin
  if FWasNotGiven = nil then
    result := ''
  else
    result := WasNotGiven.value;
end;

Procedure TFhirMedicationStatement.SetWasNotGivenST(value : String);
begin
  if value <> '' then
  begin
    if FWasNotGiven = nil then
      FWasNotGiven := TFhirBoolean.create;
    FWasNotGiven.value := value
  end
  else if FWasNotGiven <> nil then
    FWasNotGiven.value := '';
end;

Procedure TFhirMedicationStatement.SetWhenGiven(value : TFhirPeriod);
begin
  FWhenGiven.free;
  FWhenGiven := value;
end;

Procedure TFhirMedicationStatement.SetMedication(value : TFhirResourceReference{TFhirMedication});
begin
  FMedication.free;
  FMedication := value;
end;


{ TFhirMessage }

constructor TFhirMessage.Create;
begin
  inherited;
  FDataList := TFhirResourceReferenceList{Resource}.Create;
end;

destructor TFhirMessage.Destroy;
begin
  FIdentifier.free;
  FTimestamp.free;
  FEvent.free;
  FResponse.free;
  FSource.free;
  FDestination.free;
  FEnterer.free;
  FAuthor.free;
  FReceiver.free;
  FResponsible.free;
  FEffective.free;
  FReason.free;
  FDataList.Free;
  inherited;
end;

function TFhirMessage.GetResourceType : TFhirResourceType;
begin
  result := frtMessage;
end;

procedure TFhirMessage.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirMessage(oSource).identifier.Clone;
  timestamp := TFhirMessage(oSource).timestamp.Clone;
  event := TFhirMessage(oSource).event.Clone;
  response := TFhirMessage(oSource).response.Clone;
  source := TFhirMessage(oSource).source.Clone;
  destination := TFhirMessage(oSource).destination.Clone;
  enterer := TFhirMessage(oSource).enterer.Clone;
  author := TFhirMessage(oSource).author.Clone;
  receiver := TFhirMessage(oSource).receiver.Clone;
  responsible := TFhirMessage(oSource).responsible.Clone;
  effective := TFhirMessage(oSource).effective.Clone;
  reason := TFhirMessage(oSource).reason.Clone;
  FDataList.Assign(TFhirMessage(oSource).FDataList);
end;

procedure TFhirMessage.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'timestamp') Then
     list.add(Timestamp.Link);
  if (child_name = 'event') Then
     list.add(Event.Link);
  if (child_name = 'response') Then
     list.add(Response.Link);
  if (child_name = 'source') Then
     list.add(Source.Link);
  if (child_name = 'destination') Then
     list.add(Destination.Link);
  if (child_name = 'enterer') Then
     list.add(Enterer.Link);
  if (child_name = 'author') Then
     list.add(Author.Link);
  if (child_name = 'receiver') Then
     list.add(Receiver.Link);
  if (child_name = 'responsible') Then
     list.add(Responsible.Link);
  if (child_name = 'effective') Then
     list.add(Effective.Link);
  if (child_name = 'reason') Then
     list.add(Reason.Link);
  if (child_name = 'data') Then
     list.addAll(FDataList);
end;

procedure TFhirMessage.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'id', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'timestamp', 'instant', FTimestamp.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'event', 'code', FEvent.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'response', '', FResponse.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'source', '', FSource.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'destination', '', FDestination.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'enterer', 'Resource(Practitioner)', FEnterer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'author', 'Resource(Practitioner)', FAuthor.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'receiver', 'Resource(Practitioner|Organization)', FReceiver.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'responsible', 'Resource(Practitioner|Organization)', FResponsible.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'effective', 'Period', FEffective.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reason', 'CodeableConcept', FReason.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'data', 'Resource(Any)', FDataList.Link)){3};
end;

function TFhirMessage.Link : TFhirMessage;
begin
  result := TFhirMessage(inherited Link);
end;

function TFhirMessage.Clone : TFhirMessage;
begin
  result := TFhirMessage(inherited Clone);
end;

{ TFhirMessage }

Procedure TFhirMessage.SetIdentifier(value : TFhirId);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Function TFhirMessage.GetIdentifierST : String;
begin
  if FIdentifier = nil then
    result := ''
  else
    result := Identifier.value;
end;

Procedure TFhirMessage.SetIdentifierST(value : String);
begin
  if value <> '' then
  begin
    if FIdentifier = nil then
      FIdentifier := TFhirId.create;
    FIdentifier.value := value
  end
  else if FIdentifier <> nil then
    FIdentifier.value := '';
end;

Procedure TFhirMessage.SetTimestamp(value : TFhirInstant);
begin
  FTimestamp.free;
  FTimestamp := value;
end;

Function TFhirMessage.GetTimestampST : TDateAndTime;
begin
  if FTimestamp = nil then
    result := nil
  else
    result := Timestamp.value;
end;

Procedure TFhirMessage.SetTimestampST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FTimestamp = nil then
      FTimestamp := TFhirInstant.create;
    FTimestamp.value := value
  end
  else if FTimestamp <> nil then
    FTimestamp.value := nil;
end;

Procedure TFhirMessage.SetEvent(value : TFhirCode);
begin
  FEvent.free;
  FEvent := value;
end;

Function TFhirMessage.GetEventST : String;
begin
  if FEvent = nil then
    result := ''
  else
    result := Event.value;
end;

Procedure TFhirMessage.SetEventST(value : String);
begin
  if value <> '' then
  begin
    if FEvent = nil then
      FEvent := TFhirCode.create;
    FEvent.value := value
  end
  else if FEvent <> nil then
    FEvent.value := '';
end;

Procedure TFhirMessage.SetResponse(value : TFhirMessageResponse);
begin
  FResponse.free;
  FResponse := value;
end;

Procedure TFhirMessage.SetSource(value : TFhirMessageSource);
begin
  FSource.free;
  FSource := value;
end;

Procedure TFhirMessage.SetDestination(value : TFhirMessageDestination);
begin
  FDestination.free;
  FDestination := value;
end;

Procedure TFhirMessage.SetEnterer(value : TFhirResourceReference{TFhirPractitioner});
begin
  FEnterer.free;
  FEnterer := value;
end;

Procedure TFhirMessage.SetAuthor(value : TFhirResourceReference{TFhirPractitioner});
begin
  FAuthor.free;
  FAuthor := value;
end;

Procedure TFhirMessage.SetReceiver(value : TFhirResourceReference{Resource});
begin
  FReceiver.free;
  FReceiver := value;
end;

Procedure TFhirMessage.SetResponsible(value : TFhirResourceReference{Resource});
begin
  FResponsible.free;
  FResponsible := value;
end;

Procedure TFhirMessage.SetEffective(value : TFhirPeriod);
begin
  FEffective.free;
  FEffective := value;
end;

Procedure TFhirMessage.SetReason(value : TFhirCodeableConcept);
begin
  FReason.free;
  FReason := value;
end;


{ TFhirObservation }

constructor TFhirObservation.Create;
begin
  inherited;
  FReferenceRangeList := TFhirObservationReferenceRangeList.Create;
  FComponentList := TFhirObservationComponentList.Create;
end;

destructor TFhirObservation.Destroy;
begin
  FName.free;
  FValue.free;
  FInterpretation.free;
  FComments.free;
  FApplies.free;
  FIssued.free;
  FStatus.free;
  FReliability.free;
  FBodySite.free;
  FMethod.free;
  FIdentifier.free;
  FSubject.free;
  FPerformer.free;
  FReferenceRangeList.Free;
  FComponentList.Free;
  inherited;
end;

function TFhirObservation.GetResourceType : TFhirResourceType;
begin
  result := frtObservation;
end;

procedure TFhirObservation.Assign(oSource : TAdvObject);
begin
  inherited;
  name := TFhirObservation(oSource).name.Clone;
  value := TFhirObservation(oSource).value.Clone;
  interpretation := TFhirObservation(oSource).interpretation.Clone;
  comments := TFhirObservation(oSource).comments.Clone;
  applies := TFhirObservation(oSource).applies.Clone;
  issued := TFhirObservation(oSource).issued.Clone;
  FStatus := TFhirObservation(oSource).FStatus.Link;
  FReliability := TFhirObservation(oSource).FReliability.Link;
  bodySite := TFhirObservation(oSource).bodySite.Clone;
  method := TFhirObservation(oSource).method.Clone;
  identifier := TFhirObservation(oSource).identifier.Clone;
  subject := TFhirObservation(oSource).subject.Clone;
  performer := TFhirObservation(oSource).performer.Clone;
  FReferenceRangeList.Assign(TFhirObservation(oSource).FReferenceRangeList);
  FComponentList.Assign(TFhirObservation(oSource).FComponentList);
end;

procedure TFhirObservation.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'value') Then
     list.add(Value.Link);
  if (child_name = 'interpretation') Then
     list.add(Interpretation.Link);
  if (child_name = 'comments') Then
     list.add(Comments.Link);
  if (child_name = 'applies') Then
     list.add(Applies.Link);
  if (child_name = 'issued') Then
     list.add(Issued.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'reliability') Then
     list.add(FReliability.Link);
  if (child_name = 'bodySite') Then
     list.add(BodySite.Link);
  if (child_name = 'method') Then
     list.add(Method.Link);
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'performer') Then
     list.add(Performer.Link);
  if (child_name = 'referenceRange') Then
     list.addAll(FReferenceRangeList);
  if (child_name = 'component') Then
     list.addAll(FComponentList);
end;

procedure TFhirObservation.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'name', 'CodeableConcept', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'value[x]', 'Quantity|CodeableConcept|Attachment|Ratio|Choice|Period|SampledData|string', FValue.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'interpretation', 'CodeableConcept', FInterpretation.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'comments', 'string', FComments.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'applies[x]', 'Period|dateTime', FApplies.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'issued', 'instant', FIssued.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'reliability', 'code', FReliability.Link));{1}
  oList.add(TFHIRProperty.create(self, 'bodySite', 'CodeableConcept', FBodySite.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'method', 'CodeableConcept', FMethod.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient|Group|Device)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'performer', 'Resource(Practitioner|Device|Organization)', FPerformer.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'referenceRange', '', FReferenceRangeList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'component', '', FComponentList.Link)){3};
end;

function TFhirObservation.Link : TFhirObservation;
begin
  result := TFhirObservation(inherited Link);
end;

function TFhirObservation.Clone : TFhirObservation;
begin
  result := TFhirObservation(inherited Clone);
end;

{ TFhirObservation }

Procedure TFhirObservation.SetName(value : TFhirCodeableConcept);
begin
  FName.free;
  FName := value;
end;

Procedure TFhirObservation.SetValue(value : TFhirType);
begin
  FValue.free;
  FValue := value;
end;

Procedure TFhirObservation.SetInterpretation(value : TFhirCodeableConcept);
begin
  FInterpretation.free;
  FInterpretation := value;
end;

Procedure TFhirObservation.SetComments(value : TFhirString);
begin
  FComments.free;
  FComments := value;
end;

Function TFhirObservation.GetCommentsST : String;
begin
  if FComments = nil then
    result := ''
  else
    result := Comments.value;
end;

Procedure TFhirObservation.SetCommentsST(value : String);
begin
  if value <> '' then
  begin
    if FComments = nil then
      FComments := TFhirString.create;
    FComments.value := value
  end
  else if FComments <> nil then
    FComments.value := '';
end;

Procedure TFhirObservation.SetApplies(value : TFhirType);
begin
  FApplies.free;
  FApplies := value;
end;

Procedure TFhirObservation.SetIssued(value : TFhirInstant);
begin
  FIssued.free;
  FIssued := value;
end;

Function TFhirObservation.GetIssuedST : TDateAndTime;
begin
  if FIssued = nil then
    result := nil
  else
    result := Issued.value;
end;

Procedure TFhirObservation.SetIssuedST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FIssued = nil then
      FIssued := TFhirInstant.create;
    FIssued.value := value
  end
  else if FIssued <> nil then
    FIssued.value := nil;
end;

Procedure TFhirObservation.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirObservation.GetStatusST : TFhirObservationStatus;
begin
  if FStatus = nil then
    result := TFhirObservationStatus(0)
  else
    result := TFhirObservationStatus(StringArrayIndexOf(CODES_TFhirObservationStatus, Status.value));
end;

Procedure TFhirObservation.SetStatusST(value : TFhirObservationStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirObservationStatus[value]);
end;

Procedure TFhirObservation.SetReliability(value : TFhirEnum);
begin
  FReliability.free;
  FReliability := value;
end;

Function TFhirObservation.GetReliabilityST : TFhirObservationReliability;
begin
  if FReliability = nil then
    result := TFhirObservationReliability(0)
  else
    result := TFhirObservationReliability(StringArrayIndexOf(CODES_TFhirObservationReliability, Reliability.value));
end;

Procedure TFhirObservation.SetReliabilityST(value : TFhirObservationReliability);
begin
  if ord(value) = 0 then
    Reliability := nil
  else
    Reliability := TFhirEnum.create(CODES_TFhirObservationReliability[value]);
end;

Procedure TFhirObservation.SetBodySite(value : TFhirCodeableConcept);
begin
  FBodySite.free;
  FBodySite := value;
end;

Procedure TFhirObservation.SetMethod(value : TFhirCodeableConcept);
begin
  FMethod.free;
  FMethod := value;
end;

Procedure TFhirObservation.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirObservation.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirObservation.SetPerformer(value : TFhirResourceReference{Resource});
begin
  FPerformer.free;
  FPerformer := value;
end;


{ TFhirOperationOutcome }

constructor TFhirOperationOutcome.Create;
begin
  inherited;
  FIssueList := TFhirOperationOutcomeIssueList.Create;
end;

destructor TFhirOperationOutcome.Destroy;
begin
  FIssueList.Free;
  inherited;
end;

function TFhirOperationOutcome.GetResourceType : TFhirResourceType;
begin
  result := frtOperationOutcome;
end;

procedure TFhirOperationOutcome.Assign(oSource : TAdvObject);
begin
  inherited;
  FIssueList.Assign(TFhirOperationOutcome(oSource).FIssueList);
end;

procedure TFhirOperationOutcome.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'issue') Then
     list.addAll(FIssueList);
end;

procedure TFhirOperationOutcome.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'issue', '', FIssueList.Link)){3};
end;

function TFhirOperationOutcome.Link : TFhirOperationOutcome;
begin
  result := TFhirOperationOutcome(inherited Link);
end;

function TFhirOperationOutcome.Clone : TFhirOperationOutcome;
begin
  result := TFhirOperationOutcome(inherited Clone);
end;

{ TFhirOperationOutcome }


{ TFhirOrder }

constructor TFhirOrder.Create;
begin
  inherited;
  FDetailList := TFhirResourceReferenceList{Resource}.Create;
end;

destructor TFhirOrder.Destroy;
begin
  FDate.free;
  FSubject.free;
  FSource.free;
  FTarget.free;
  FReason.free;
  FAuthority.free;
  FWhen.free;
  FDetailList.Free;
  inherited;
end;

function TFhirOrder.GetResourceType : TFhirResourceType;
begin
  result := frtOrder;
end;

procedure TFhirOrder.Assign(oSource : TAdvObject);
begin
  inherited;
  date := TFhirOrder(oSource).date.Clone;
  subject := TFhirOrder(oSource).subject.Clone;
  source := TFhirOrder(oSource).source.Clone;
  target := TFhirOrder(oSource).target.Clone;
  reason := TFhirOrder(oSource).reason.Clone;
  authority := TFhirOrder(oSource).authority.Clone;
  when := TFhirOrder(oSource).when.Clone;
  FDetailList.Assign(TFhirOrder(oSource).FDetailList);
end;

procedure TFhirOrder.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'date') Then
     list.add(Date.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'source') Then
     list.add(Source.Link);
  if (child_name = 'target') Then
     list.add(Target.Link);
  if (child_name = 'reason') Then
     list.add(Reason.Link);
  if (child_name = 'authority') Then
     list.add(Authority.Link);
  if (child_name = 'when') Then
     list.add(When.Link);
  if (child_name = 'detail') Then
     list.addAll(FDetailList);
end;

procedure TFhirOrder.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'date', 'dateTime', FDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'source', 'Resource(Practitioner)', FSource.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'target', 'Resource(Organization|Device)', FTarget.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reason', 'string', FReason.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'authority', 'Resource(Any)', FAuthority.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'when', '', FWhen.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'detail', 'Resource(Any)', FDetailList.Link)){3};
end;

function TFhirOrder.Link : TFhirOrder;
begin
  result := TFhirOrder(inherited Link);
end;

function TFhirOrder.Clone : TFhirOrder;
begin
  result := TFhirOrder(inherited Clone);
end;

{ TFhirOrder }

Procedure TFhirOrder.SetDate(value : TFhirDateTime);
begin
  FDate.free;
  FDate := value;
end;

Function TFhirOrder.GetDateST : TDateAndTime;
begin
  if FDate = nil then
    result := nil
  else
    result := Date.value;
end;

Procedure TFhirOrder.SetDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDate = nil then
      FDate := TFhirDateTime.create;
    FDate.value := value
  end
  else if FDate <> nil then
    FDate.value := nil;
end;

Procedure TFhirOrder.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirOrder.SetSource(value : TFhirResourceReference{TFhirPractitioner});
begin
  FSource.free;
  FSource := value;
end;

Procedure TFhirOrder.SetTarget(value : TFhirResourceReference{Resource});
begin
  FTarget.free;
  FTarget := value;
end;

Procedure TFhirOrder.SetReason(value : TFhirString);
begin
  FReason.free;
  FReason := value;
end;

Function TFhirOrder.GetReasonST : String;
begin
  if FReason = nil then
    result := ''
  else
    result := Reason.value;
end;

Procedure TFhirOrder.SetReasonST(value : String);
begin
  if value <> '' then
  begin
    if FReason = nil then
      FReason := TFhirString.create;
    FReason.value := value
  end
  else if FReason <> nil then
    FReason.value := '';
end;

Procedure TFhirOrder.SetAuthority(value : TFhirResourceReference{Resource});
begin
  FAuthority.free;
  FAuthority := value;
end;

Procedure TFhirOrder.SetWhen(value : TFhirOrderWhen);
begin
  FWhen.free;
  FWhen := value;
end;


{ TFhirOrderResponse }

constructor TFhirOrderResponse.Create;
begin
  inherited;
  FFulfillmentList := TFhirResourceReferenceList{Resource}.Create;
end;

destructor TFhirOrderResponse.Destroy;
begin
  FRequest.free;
  FDate.free;
  FWho.free;
  FAuthority.free;
  FCost.free;
  FCode.free;
  FDescription.free;
  FFulfillmentList.Free;
  inherited;
end;

function TFhirOrderResponse.GetResourceType : TFhirResourceType;
begin
  result := frtOrderResponse;
end;

procedure TFhirOrderResponse.Assign(oSource : TAdvObject);
begin
  inherited;
  request := TFhirOrderResponse(oSource).request.Clone;
  date := TFhirOrderResponse(oSource).date.Clone;
  who := TFhirOrderResponse(oSource).who.Clone;
  authority := TFhirOrderResponse(oSource).authority.Clone;
  cost := TFhirOrderResponse(oSource).cost.Clone;
  FCode := TFhirOrderResponse(oSource).FCode.Link;
  description := TFhirOrderResponse(oSource).description.Clone;
  FFulfillmentList.Assign(TFhirOrderResponse(oSource).FFulfillmentList);
end;

procedure TFhirOrderResponse.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'request') Then
     list.add(Request.Link);
  if (child_name = 'date') Then
     list.add(Date.Link);
  if (child_name = 'who') Then
     list.add(Who.Link);
  if (child_name = 'authority') Then
     list.add(Authority.Link);
  if (child_name = 'cost') Then
     list.add(Cost.Link);
  if (child_name = 'code') Then
     list.add(FCode.Link);
  if (child_name = 'description') Then
     list.add(Description.Link);
  if (child_name = 'fulfillment') Then
     list.addAll(FFulfillmentList);
end;

procedure TFhirOrderResponse.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'request', 'Resource(Order)', FRequest.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'date', 'dateTime', FDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'who', 'Resource(Practitioner|Organization)', FWho.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'authority', 'Resource(Any)', FAuthority.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'cost', 'Money', FCost.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'code', 'code', FCode.Link));{1}
  oList.add(TFHIRProperty.create(self, 'description', 'string', FDescription.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'fulfillment', 'Resource(Any)', FFulfillmentList.Link)){3};
end;

function TFhirOrderResponse.Link : TFhirOrderResponse;
begin
  result := TFhirOrderResponse(inherited Link);
end;

function TFhirOrderResponse.Clone : TFhirOrderResponse;
begin
  result := TFhirOrderResponse(inherited Clone);
end;

{ TFhirOrderResponse }

Procedure TFhirOrderResponse.SetRequest(value : TFhirResourceReference{TFhirOrder});
begin
  FRequest.free;
  FRequest := value;
end;

Procedure TFhirOrderResponse.SetDate(value : TFhirDateTime);
begin
  FDate.free;
  FDate := value;
end;

Function TFhirOrderResponse.GetDateST : TDateAndTime;
begin
  if FDate = nil then
    result := nil
  else
    result := Date.value;
end;

Procedure TFhirOrderResponse.SetDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDate = nil then
      FDate := TFhirDateTime.create;
    FDate.value := value
  end
  else if FDate <> nil then
    FDate.value := nil;
end;

Procedure TFhirOrderResponse.SetWho(value : TFhirResourceReference{Resource});
begin
  FWho.free;
  FWho := value;
end;

Procedure TFhirOrderResponse.SetAuthority(value : TFhirResourceReference{Resource});
begin
  FAuthority.free;
  FAuthority := value;
end;

Procedure TFhirOrderResponse.SetCost(value : TFhirQuantity);
begin
  FCost.free;
  FCost := value;
end;

Procedure TFhirOrderResponse.SetCode(value : TFhirEnum);
begin
  FCode.free;
  FCode := value;
end;

Function TFhirOrderResponse.GetCodeST : TFhirOrderOutcomeCode;
begin
  if FCode = nil then
    result := TFhirOrderOutcomeCode(0)
  else
    result := TFhirOrderOutcomeCode(StringArrayIndexOf(CODES_TFhirOrderOutcomeCode, Code.value));
end;

Procedure TFhirOrderResponse.SetCodeST(value : TFhirOrderOutcomeCode);
begin
  if ord(value) = 0 then
    Code := nil
  else
    Code := TFhirEnum.create(CODES_TFhirOrderOutcomeCode[value]);
end;

Procedure TFhirOrderResponse.SetDescription(value : TFhirString);
begin
  FDescription.free;
  FDescription := value;
end;

Function TFhirOrderResponse.GetDescriptionST : String;
begin
  if FDescription = nil then
    result := ''
  else
    result := Description.value;
end;

Procedure TFhirOrderResponse.SetDescriptionST(value : String);
begin
  if value <> '' then
  begin
    if FDescription = nil then
      FDescription := TFhirString.create;
    FDescription.value := value
  end
  else if FDescription <> nil then
    FDescription.value := '';
end;


{ TFhirOrganization }

constructor TFhirOrganization.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FTelecomList := TFhirContactList.Create;
  FAddressList := TFhirAddressList.Create;
  FContactList := TFhirOrganizationContactList.Create;
end;

destructor TFhirOrganization.Destroy;
begin
  FIdentifierList.Free;
  FName.free;
  FType_.free;
  FTelecomList.Free;
  FAddressList.Free;
  FPartOf.free;
  FContactList.Free;
  FActive.free;
  inherited;
end;

function TFhirOrganization.GetResourceType : TFhirResourceType;
begin
  result := frtOrganization;
end;

procedure TFhirOrganization.Assign(oSource : TAdvObject);
begin
  inherited;
  FIdentifierList.Assign(TFhirOrganization(oSource).FIdentifierList);
  name := TFhirOrganization(oSource).name.Clone;
  type_ := TFhirOrganization(oSource).type_.Clone;
  FTelecomList.Assign(TFhirOrganization(oSource).FTelecomList);
  FAddressList.Assign(TFhirOrganization(oSource).FAddressList);
  partOf := TFhirOrganization(oSource).partOf.Clone;
  FContactList.Assign(TFhirOrganization(oSource).FContactList);
  active := TFhirOrganization(oSource).active.Clone;
end;

procedure TFhirOrganization.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'type_') Then
     list.add(Type_.Link);
  if (child_name = 'telecom') Then
     list.addAll(FTelecomList);
  if (child_name = 'address') Then
     list.addAll(FAddressList);
  if (child_name = 'partOf') Then
     list.add(PartOf.Link);
  if (child_name = 'contact') Then
     list.addAll(FContactList);
  if (child_name = 'active') Then
     list.add(Active.Link);
end;

procedure TFhirOrganization.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'name', 'string', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'type', 'CodeableConcept', FType_.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'telecom', 'Contact', FTelecomList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'address', 'Address', FAddressList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'partOf', 'Resource(Organization)', FPartOf.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'contact', '', FContactList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'active', 'boolean', FActive.Link.Link));{2}
end;

function TFhirOrganization.Link : TFhirOrganization;
begin
  result := TFhirOrganization(inherited Link);
end;

function TFhirOrganization.Clone : TFhirOrganization;
begin
  result := TFhirOrganization(inherited Clone);
end;

{ TFhirOrganization }

Procedure TFhirOrganization.SetName(value : TFhirString);
begin
  FName.free;
  FName := value;
end;

Function TFhirOrganization.GetNameST : String;
begin
  if FName = nil then
    result := ''
  else
    result := Name.value;
end;

Procedure TFhirOrganization.SetNameST(value : String);
begin
  if value <> '' then
  begin
    if FName = nil then
      FName := TFhirString.create;
    FName.value := value
  end
  else if FName <> nil then
    FName.value := '';
end;

Procedure TFhirOrganization.SetType_(value : TFhirCodeableConcept);
begin
  FType_.free;
  FType_ := value;
end;

Procedure TFhirOrganization.SetPartOf(value : TFhirResourceReference{TFhirOrganization});
begin
  FPartOf.free;
  FPartOf := value;
end;

Procedure TFhirOrganization.SetActive(value : TFhirBoolean);
begin
  FActive.free;
  FActive := value;
end;

Function TFhirOrganization.GetActiveST : String;
begin
  if FActive = nil then
    result := ''
  else
    result := Active.value;
end;

Procedure TFhirOrganization.SetActiveST(value : String);
begin
  if value <> '' then
  begin
    if FActive = nil then
      FActive := TFhirBoolean.create;
    FActive.value := value
  end
  else if FActive <> nil then
    FActive.value := '';
end;


{ TFhirOther }

constructor TFhirOther.Create;
begin
  inherited;
end;

destructor TFhirOther.Destroy;
begin
  FCode.free;
  FSubject.free;
  FAuthor.free;
  FCreated.free;
  inherited;
end;

function TFhirOther.GetResourceType : TFhirResourceType;
begin
  result := frtOther;
end;

procedure TFhirOther.Assign(oSource : TAdvObject);
begin
  inherited;
  code := TFhirOther(oSource).code.Clone;
  subject := TFhirOther(oSource).subject.Clone;
  author := TFhirOther(oSource).author.Clone;
  created := TFhirOther(oSource).created.Clone;
end;

procedure TFhirOther.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'code') Then
     list.add(Code.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'author') Then
     list.add(Author.Link);
  if (child_name = 'created') Then
     list.add(Created.Link);
end;

procedure TFhirOther.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'code', 'CodeableConcept', FCode.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Any)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'author', 'Resource(Practitioner|Patient|RelatedPerson)', FAuthor.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'created', 'date', FCreated.Link.Link));{2}
end;

function TFhirOther.Link : TFhirOther;
begin
  result := TFhirOther(inherited Link);
end;

function TFhirOther.Clone : TFhirOther;
begin
  result := TFhirOther(inherited Clone);
end;

{ TFhirOther }

Procedure TFhirOther.SetCode(value : TFhirCodeableConcept);
begin
  FCode.free;
  FCode := value;
end;

Procedure TFhirOther.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirOther.SetAuthor(value : TFhirResourceReference{Resource});
begin
  FAuthor.free;
  FAuthor := value;
end;

Procedure TFhirOther.SetCreated(value : TFhirDate);
begin
  FCreated.free;
  FCreated := value;
end;

Function TFhirOther.GetCreatedST : TDateAndTime;
begin
  if FCreated = nil then
    result := nil
  else
    result := Created.value;
end;

Procedure TFhirOther.SetCreatedST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FCreated = nil then
      FCreated := TFhirDate.create;
    FCreated.value := value
  end
  else if FCreated <> nil then
    FCreated.value := nil;
end;


{ TFhirPatient }

constructor TFhirPatient.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FNameList := TFhirHumanNameList.Create;
  FTelecomList := TFhirContactList.Create;
  FAddressList := TFhirAddressList.Create;
  FPhotoList := TFhirAttachmentList.Create;
  FContactList := TFhirPatientContactList.Create;
  FCommunicationList := TFhirCodeableConceptList.Create;
  FLink_List := TFhirResourceReferenceList{TFhirPatient}.Create;
end;

destructor TFhirPatient.Destroy;
begin
  FIdentifierList.Free;
  FNameList.Free;
  FTelecomList.Free;
  FGender.free;
  FBirthDate.free;
  FDeceased.free;
  FAddressList.Free;
  FMaritalStatus.free;
  FMultipleBirth.free;
  FPhotoList.Free;
  FContactList.Free;
  FAnimal.free;
  FCommunicationList.Free;
  FProvider.free;
  FLink_List.Free;
  FActive.free;
  inherited;
end;

function TFhirPatient.GetResourceType : TFhirResourceType;
begin
  result := frtPatient;
end;

procedure TFhirPatient.Assign(oSource : TAdvObject);
begin
  inherited;
  FIdentifierList.Assign(TFhirPatient(oSource).FIdentifierList);
  FNameList.Assign(TFhirPatient(oSource).FNameList);
  FTelecomList.Assign(TFhirPatient(oSource).FTelecomList);
  gender := TFhirPatient(oSource).gender.Clone;
  birthDate := TFhirPatient(oSource).birthDate.Clone;
  deceased := TFhirPatient(oSource).deceased.Clone;
  FAddressList.Assign(TFhirPatient(oSource).FAddressList);
  maritalStatus := TFhirPatient(oSource).maritalStatus.Clone;
  multipleBirth := TFhirPatient(oSource).multipleBirth.Clone;
  FPhotoList.Assign(TFhirPatient(oSource).FPhotoList);
  FContactList.Assign(TFhirPatient(oSource).FContactList);
  animal := TFhirPatient(oSource).animal.Clone;
  FCommunicationList.Assign(TFhirPatient(oSource).FCommunicationList);
  provider := TFhirPatient(oSource).provider.Clone;
  FLink_List.Assign(TFhirPatient(oSource).FLink_List);
  active := TFhirPatient(oSource).active.Clone;
end;

procedure TFhirPatient.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'name') Then
     list.addAll(FNameList);
  if (child_name = 'telecom') Then
     list.addAll(FTelecomList);
  if (child_name = 'gender') Then
     list.add(Gender.Link);
  if (child_name = 'birthDate') Then
     list.add(BirthDate.Link);
  if (child_name = 'deceased') Then
     list.add(Deceased.Link);
  if (child_name = 'address') Then
     list.addAll(FAddressList);
  if (child_name = 'maritalStatus') Then
     list.add(MaritalStatus.Link);
  if (child_name = 'multipleBirth') Then
     list.add(MultipleBirth.Link);
  if (child_name = 'photo') Then
     list.addAll(FPhotoList);
  if (child_name = 'contact') Then
     list.addAll(FContactList);
  if (child_name = 'animal') Then
     list.add(Animal.Link);
  if (child_name = 'communication') Then
     list.addAll(FCommunicationList);
  if (child_name = 'provider') Then
     list.add(Provider.Link);
  if (child_name = 'link_') Then
     list.addAll(FLink_List);
  if (child_name = 'active') Then
     list.add(Active.Link);
end;

procedure TFhirPatient.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'name', 'HumanName', FNameList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'telecom', 'Contact', FTelecomList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'gender', 'CodeableConcept', FGender.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'birthDate', 'dateTime', FBirthDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'deceased[x]', 'boolean|dateTime', FDeceased.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'address', 'Address', FAddressList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'maritalStatus', 'CodeableConcept', FMaritalStatus.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'multipleBirth[x]', 'boolean|integer', FMultipleBirth.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'photo', 'Attachment', FPhotoList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'contact', '', FContactList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'animal', '', FAnimal.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'communication', 'CodeableConcept', FCommunicationList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'provider', 'Resource(Organization)', FProvider.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'link', 'Resource(Patient)', FLink_List.Link)){3};
  oList.add(TFHIRProperty.create(self, 'active', 'boolean', FActive.Link.Link));{2}
end;

function TFhirPatient.Link : TFhirPatient;
begin
  result := TFhirPatient(inherited Link);
end;

function TFhirPatient.Clone : TFhirPatient;
begin
  result := TFhirPatient(inherited Clone);
end;

{ TFhirPatient }

Procedure TFhirPatient.SetGender(value : TFhirCodeableConcept);
begin
  FGender.free;
  FGender := value;
end;

Procedure TFhirPatient.SetBirthDate(value : TFhirDateTime);
begin
  FBirthDate.free;
  FBirthDate := value;
end;

Function TFhirPatient.GetBirthDateST : TDateAndTime;
begin
  if FBirthDate = nil then
    result := nil
  else
    result := BirthDate.value;
end;

Procedure TFhirPatient.SetBirthDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FBirthDate = nil then
      FBirthDate := TFhirDateTime.create;
    FBirthDate.value := value
  end
  else if FBirthDate <> nil then
    FBirthDate.value := nil;
end;

Procedure TFhirPatient.SetDeceased(value : TFhirType);
begin
  FDeceased.free;
  FDeceased := value;
end;

Procedure TFhirPatient.SetMaritalStatus(value : TFhirCodeableConcept);
begin
  FMaritalStatus.free;
  FMaritalStatus := value;
end;

Procedure TFhirPatient.SetMultipleBirth(value : TFhirType);
begin
  FMultipleBirth.free;
  FMultipleBirth := value;
end;

Procedure TFhirPatient.SetAnimal(value : TFhirPatientAnimal);
begin
  FAnimal.free;
  FAnimal := value;
end;

Procedure TFhirPatient.SetProvider(value : TFhirResourceReference{TFhirOrganization});
begin
  FProvider.free;
  FProvider := value;
end;

Procedure TFhirPatient.SetActive(value : TFhirBoolean);
begin
  FActive.free;
  FActive := value;
end;

Function TFhirPatient.GetActiveST : String;
begin
  if FActive = nil then
    result := ''
  else
    result := Active.value;
end;

Procedure TFhirPatient.SetActiveST(value : String);
begin
  if value <> '' then
  begin
    if FActive = nil then
      FActive := TFhirBoolean.create;
    FActive.value := value
  end
  else if FActive <> nil then
    FActive.value := '';
end;


{ TFhirPractitioner }

constructor TFhirPractitioner.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FTelecomList := TFhirContactList.Create;
  FPhotoList := TFhirAttachmentList.Create;
  FRoleList := TFhirCodeableConceptList.Create;
  FSpecialtyList := TFhirCodeableConceptList.Create;
  FQualificationList := TFhirPractitionerQualificationList.Create;
  FCommunicationList := TFhirCodeableConceptList.Create;
end;

destructor TFhirPractitioner.Destroy;
begin
  FIdentifierList.Free;
  FName.free;
  FTelecomList.Free;
  FAddress.free;
  FGender.free;
  FBirthDate.free;
  FPhotoList.Free;
  FOrganization.free;
  FRoleList.Free;
  FSpecialtyList.Free;
  FPeriod.free;
  FQualificationList.Free;
  FCommunicationList.Free;
  inherited;
end;

function TFhirPractitioner.GetResourceType : TFhirResourceType;
begin
  result := frtPractitioner;
end;

procedure TFhirPractitioner.Assign(oSource : TAdvObject);
begin
  inherited;
  FIdentifierList.Assign(TFhirPractitioner(oSource).FIdentifierList);
  name := TFhirPractitioner(oSource).name.Clone;
  FTelecomList.Assign(TFhirPractitioner(oSource).FTelecomList);
  address := TFhirPractitioner(oSource).address.Clone;
  gender := TFhirPractitioner(oSource).gender.Clone;
  birthDate := TFhirPractitioner(oSource).birthDate.Clone;
  FPhotoList.Assign(TFhirPractitioner(oSource).FPhotoList);
  organization := TFhirPractitioner(oSource).organization.Clone;
  FRoleList.Assign(TFhirPractitioner(oSource).FRoleList);
  FSpecialtyList.Assign(TFhirPractitioner(oSource).FSpecialtyList);
  period := TFhirPractitioner(oSource).period.Clone;
  FQualificationList.Assign(TFhirPractitioner(oSource).FQualificationList);
  FCommunicationList.Assign(TFhirPractitioner(oSource).FCommunicationList);
end;

procedure TFhirPractitioner.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'telecom') Then
     list.addAll(FTelecomList);
  if (child_name = 'address') Then
     list.add(Address.Link);
  if (child_name = 'gender') Then
     list.add(Gender.Link);
  if (child_name = 'birthDate') Then
     list.add(BirthDate.Link);
  if (child_name = 'photo') Then
     list.addAll(FPhotoList);
  if (child_name = 'organization') Then
     list.add(Organization.Link);
  if (child_name = 'role') Then
     list.addAll(FRoleList);
  if (child_name = 'specialty') Then
     list.addAll(FSpecialtyList);
  if (child_name = 'period') Then
     list.add(Period.Link);
  if (child_name = 'qualification') Then
     list.addAll(FQualificationList);
  if (child_name = 'communication') Then
     list.addAll(FCommunicationList);
end;

procedure TFhirPractitioner.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'name', 'HumanName', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'telecom', 'Contact', FTelecomList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'address', 'Address', FAddress.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'gender', 'CodeableConcept', FGender.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'birthDate', 'dateTime', FBirthDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'photo', 'Attachment', FPhotoList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'organization', 'Resource(Organization)', FOrganization.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'role', 'CodeableConcept', FRoleList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'specialty', 'CodeableConcept', FSpecialtyList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'period', 'Period', FPeriod.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'qualification', '', FQualificationList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'communication', 'CodeableConcept', FCommunicationList.Link)){3};
end;

function TFhirPractitioner.Link : TFhirPractitioner;
begin
  result := TFhirPractitioner(inherited Link);
end;

function TFhirPractitioner.Clone : TFhirPractitioner;
begin
  result := TFhirPractitioner(inherited Clone);
end;

{ TFhirPractitioner }

Procedure TFhirPractitioner.SetName(value : TFhirHumanName);
begin
  FName.free;
  FName := value;
end;

Procedure TFhirPractitioner.SetAddress(value : TFhirAddress);
begin
  FAddress.free;
  FAddress := value;
end;

Procedure TFhirPractitioner.SetGender(value : TFhirCodeableConcept);
begin
  FGender.free;
  FGender := value;
end;

Procedure TFhirPractitioner.SetBirthDate(value : TFhirDateTime);
begin
  FBirthDate.free;
  FBirthDate := value;
end;

Function TFhirPractitioner.GetBirthDateST : TDateAndTime;
begin
  if FBirthDate = nil then
    result := nil
  else
    result := BirthDate.value;
end;

Procedure TFhirPractitioner.SetBirthDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FBirthDate = nil then
      FBirthDate := TFhirDateTime.create;
    FBirthDate.value := value
  end
  else if FBirthDate <> nil then
    FBirthDate.value := nil;
end;

Procedure TFhirPractitioner.SetOrganization(value : TFhirResourceReference{TFhirOrganization});
begin
  FOrganization.free;
  FOrganization := value;
end;

Procedure TFhirPractitioner.SetPeriod(value : TFhirPeriod);
begin
  FPeriod.free;
  FPeriod := value;
end;


{ TFhirProcedure }

constructor TFhirProcedure.Create;
begin
  inherited;
  FBodySiteList := TFhirCodeableConceptList.Create;
  FPerformerList := TFhirProcedurePerformerList.Create;
  FReportList := TFhirResourceReferenceList{TFhirDiagnosticReport}.Create;
  FRelatedItemList := TFhirProcedureRelatedItemList.Create;
end;

destructor TFhirProcedure.Destroy;
begin
  FSubject.free;
  FType_.free;
  FBodySiteList.Free;
  FIndication.free;
  FPerformerList.Free;
  FDate.free;
  FEncounter.free;
  FOutcome.free;
  FReportList.Free;
  FComplication.free;
  FFollowUp.free;
  FRelatedItemList.Free;
  FNotes.free;
  inherited;
end;

function TFhirProcedure.GetResourceType : TFhirResourceType;
begin
  result := frtProcedure;
end;

procedure TFhirProcedure.Assign(oSource : TAdvObject);
begin
  inherited;
  subject := TFhirProcedure(oSource).subject.Clone;
  type_ := TFhirProcedure(oSource).type_.Clone;
  FBodySiteList.Assign(TFhirProcedure(oSource).FBodySiteList);
  indication := TFhirProcedure(oSource).indication.Clone;
  FPerformerList.Assign(TFhirProcedure(oSource).FPerformerList);
  date := TFhirProcedure(oSource).date.Clone;
  encounter := TFhirProcedure(oSource).encounter.Clone;
  outcome := TFhirProcedure(oSource).outcome.Clone;
  FReportList.Assign(TFhirProcedure(oSource).FReportList);
  complication := TFhirProcedure(oSource).complication.Clone;
  followUp := TFhirProcedure(oSource).followUp.Clone;
  FRelatedItemList.Assign(TFhirProcedure(oSource).FRelatedItemList);
  notes := TFhirProcedure(oSource).notes.Clone;
end;

procedure TFhirProcedure.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'type_') Then
     list.add(Type_.Link);
  if (child_name = 'bodySite') Then
     list.addAll(FBodySiteList);
  if (child_name = 'indication') Then
     list.add(Indication.Link);
  if (child_name = 'performer') Then
     list.addAll(FPerformerList);
  if (child_name = 'date') Then
     list.add(Date.Link);
  if (child_name = 'encounter') Then
     list.add(Encounter.Link);
  if (child_name = 'outcome') Then
     list.add(Outcome.Link);
  if (child_name = 'report') Then
     list.addAll(FReportList);
  if (child_name = 'complication') Then
     list.add(Complication.Link);
  if (child_name = 'followUp') Then
     list.add(FollowUp.Link);
  if (child_name = 'relatedItem') Then
     list.addAll(FRelatedItemList);
  if (child_name = 'notes') Then
     list.add(Notes.Link);
end;

procedure TFhirProcedure.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'type', 'CodeableConcept', FType_.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'bodySite', 'CodeableConcept', FBodySiteList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'indication', 'string', FIndication.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'performer', '', FPerformerList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'date', 'Period', FDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'encounter', 'Resource(Encounter)', FEncounter.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'outcome', 'string', FOutcome.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'report', 'Resource(DiagnosticReport)', FReportList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'complication', 'string', FComplication.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'followUp', 'string', FFollowUp.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'relatedItem', '', FRelatedItemList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'notes', 'string', FNotes.Link.Link));{2}
end;

function TFhirProcedure.Link : TFhirProcedure;
begin
  result := TFhirProcedure(inherited Link);
end;

function TFhirProcedure.Clone : TFhirProcedure;
begin
  result := TFhirProcedure(inherited Clone);
end;

{ TFhirProcedure }

Procedure TFhirProcedure.SetSubject(value : TFhirResourceReference{TFhirPatient});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirProcedure.SetType_(value : TFhirCodeableConcept);
begin
  FType_.free;
  FType_ := value;
end;

Procedure TFhirProcedure.SetIndication(value : TFhirString);
begin
  FIndication.free;
  FIndication := value;
end;

Function TFhirProcedure.GetIndicationST : String;
begin
  if FIndication = nil then
    result := ''
  else
    result := Indication.value;
end;

Procedure TFhirProcedure.SetIndicationST(value : String);
begin
  if value <> '' then
  begin
    if FIndication = nil then
      FIndication := TFhirString.create;
    FIndication.value := value
  end
  else if FIndication <> nil then
    FIndication.value := '';
end;

Procedure TFhirProcedure.SetDate(value : TFhirPeriod);
begin
  FDate.free;
  FDate := value;
end;

Procedure TFhirProcedure.SetEncounter(value : TFhirResourceReference{TFhirEncounter});
begin
  FEncounter.free;
  FEncounter := value;
end;

Procedure TFhirProcedure.SetOutcome(value : TFhirString);
begin
  FOutcome.free;
  FOutcome := value;
end;

Function TFhirProcedure.GetOutcomeST : String;
begin
  if FOutcome = nil then
    result := ''
  else
    result := Outcome.value;
end;

Procedure TFhirProcedure.SetOutcomeST(value : String);
begin
  if value <> '' then
  begin
    if FOutcome = nil then
      FOutcome := TFhirString.create;
    FOutcome.value := value
  end
  else if FOutcome <> nil then
    FOutcome.value := '';
end;

Procedure TFhirProcedure.SetComplication(value : TFhirString);
begin
  FComplication.free;
  FComplication := value;
end;

Function TFhirProcedure.GetComplicationST : String;
begin
  if FComplication = nil then
    result := ''
  else
    result := Complication.value;
end;

Procedure TFhirProcedure.SetComplicationST(value : String);
begin
  if value <> '' then
  begin
    if FComplication = nil then
      FComplication := TFhirString.create;
    FComplication.value := value
  end
  else if FComplication <> nil then
    FComplication.value := '';
end;

Procedure TFhirProcedure.SetFollowUp(value : TFhirString);
begin
  FFollowUp.free;
  FFollowUp := value;
end;

Function TFhirProcedure.GetFollowUpST : String;
begin
  if FFollowUp = nil then
    result := ''
  else
    result := FollowUp.value;
end;

Procedure TFhirProcedure.SetFollowUpST(value : String);
begin
  if value <> '' then
  begin
    if FFollowUp = nil then
      FFollowUp := TFhirString.create;
    FFollowUp.value := value
  end
  else if FFollowUp <> nil then
    FFollowUp.value := '';
end;

Procedure TFhirProcedure.SetNotes(value : TFhirString);
begin
  FNotes.free;
  FNotes := value;
end;

Function TFhirProcedure.GetNotesST : String;
begin
  if FNotes = nil then
    result := ''
  else
    result := Notes.value;
end;

Procedure TFhirProcedure.SetNotesST(value : String);
begin
  if value <> '' then
  begin
    if FNotes = nil then
      FNotes := TFhirString.create;
    FNotes.value := value
  end
  else if FNotes <> nil then
    FNotes.value := '';
end;


{ TFhirProfile }

constructor TFhirProfile.Create;
begin
  inherited;
  FTelecomList := TFhirContactList.Create;
  FCodeList := TFhirCodingList.Create;
  FStructureList := TFhirProfileStructureList.Create;
  FExtensionDefnList := TFhirProfileExtensionDefnList.Create;
  FBindingList := TFhirProfileBindingList.Create;
end;

destructor TFhirProfile.Destroy;
begin
  FIdentifier.free;
  FVersion.free;
  FName.free;
  FPublisher.free;
  FTelecomList.Free;
  FDescription.free;
  FCodeList.Free;
  FStatus.free;
  FExperimental.free;
  FDate.free;
  FFhirVersion.free;
  FStructureList.Free;
  FExtensionDefnList.Free;
  FBindingList.Free;
  inherited;
end;

function TFhirProfile.GetResourceType : TFhirResourceType;
begin
  result := frtProfile;
end;

procedure TFhirProfile.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirProfile(oSource).identifier.Clone;
  version := TFhirProfile(oSource).version.Clone;
  name := TFhirProfile(oSource).name.Clone;
  publisher := TFhirProfile(oSource).publisher.Clone;
  FTelecomList.Assign(TFhirProfile(oSource).FTelecomList);
  description := TFhirProfile(oSource).description.Clone;
  FCodeList.Assign(TFhirProfile(oSource).FCodeList);
  FStatus := TFhirProfile(oSource).FStatus.Link;
  experimental := TFhirProfile(oSource).experimental.Clone;
  date := TFhirProfile(oSource).date.Clone;
  fhirVersion := TFhirProfile(oSource).fhirVersion.Clone;
  FStructureList.Assign(TFhirProfile(oSource).FStructureList);
  FExtensionDefnList.Assign(TFhirProfile(oSource).FExtensionDefnList);
  FBindingList.Assign(TFhirProfile(oSource).FBindingList);
end;

procedure TFhirProfile.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'version') Then
     list.add(Version.Link);
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'publisher') Then
     list.add(Publisher.Link);
  if (child_name = 'telecom') Then
     list.addAll(FTelecomList);
  if (child_name = 'description') Then
     list.add(Description.Link);
  if (child_name = 'code') Then
     list.addAll(FCodeList);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'experimental') Then
     list.add(Experimental.Link);
  if (child_name = 'date') Then
     list.add(Date.Link);
  if (child_name = 'fhirVersion') Then
     list.add(FhirVersion.Link);
  if (child_name = 'structure') Then
     list.addAll(FStructureList);
  if (child_name = 'extensionDefn') Then
     list.addAll(FExtensionDefnList);
  if (child_name = 'binding') Then
     list.addAll(FBindingList);
end;

procedure TFhirProfile.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'string', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'version', 'string', FVersion.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'name', 'string', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'publisher', 'string', FPublisher.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'telecom', 'Contact', FTelecomList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'description', 'string', FDescription.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'code', 'Coding', FCodeList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'experimental', 'boolean', FExperimental.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'date', 'dateTime', FDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'fhirVersion', 'id', FFhirVersion.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'structure', '', FStructureList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'extensionDefn', '', FExtensionDefnList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'binding', '', FBindingList.Link)){3};
end;

function TFhirProfile.Link : TFhirProfile;
begin
  result := TFhirProfile(inherited Link);
end;

function TFhirProfile.Clone : TFhirProfile;
begin
  result := TFhirProfile(inherited Clone);
end;

{ TFhirProfile }

Procedure TFhirProfile.SetIdentifier(value : TFhirString);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Function TFhirProfile.GetIdentifierST : String;
begin
  if FIdentifier = nil then
    result := ''
  else
    result := Identifier.value;
end;

Procedure TFhirProfile.SetIdentifierST(value : String);
begin
  if value <> '' then
  begin
    if FIdentifier = nil then
      FIdentifier := TFhirString.create;
    FIdentifier.value := value
  end
  else if FIdentifier <> nil then
    FIdentifier.value := '';
end;

Procedure TFhirProfile.SetVersion(value : TFhirString);
begin
  FVersion.free;
  FVersion := value;
end;

Function TFhirProfile.GetVersionST : String;
begin
  if FVersion = nil then
    result := ''
  else
    result := Version.value;
end;

Procedure TFhirProfile.SetVersionST(value : String);
begin
  if value <> '' then
  begin
    if FVersion = nil then
      FVersion := TFhirString.create;
    FVersion.value := value
  end
  else if FVersion <> nil then
    FVersion.value := '';
end;

Procedure TFhirProfile.SetName(value : TFhirString);
begin
  FName.free;
  FName := value;
end;

Function TFhirProfile.GetNameST : String;
begin
  if FName = nil then
    result := ''
  else
    result := Name.value;
end;

Procedure TFhirProfile.SetNameST(value : String);
begin
  if value <> '' then
  begin
    if FName = nil then
      FName := TFhirString.create;
    FName.value := value
  end
  else if FName <> nil then
    FName.value := '';
end;

Procedure TFhirProfile.SetPublisher(value : TFhirString);
begin
  FPublisher.free;
  FPublisher := value;
end;

Function TFhirProfile.GetPublisherST : String;
begin
  if FPublisher = nil then
    result := ''
  else
    result := Publisher.value;
end;

Procedure TFhirProfile.SetPublisherST(value : String);
begin
  if value <> '' then
  begin
    if FPublisher = nil then
      FPublisher := TFhirString.create;
    FPublisher.value := value
  end
  else if FPublisher <> nil then
    FPublisher.value := '';
end;

Procedure TFhirProfile.SetDescription(value : TFhirString);
begin
  FDescription.free;
  FDescription := value;
end;

Function TFhirProfile.GetDescriptionST : String;
begin
  if FDescription = nil then
    result := ''
  else
    result := Description.value;
end;

Procedure TFhirProfile.SetDescriptionST(value : String);
begin
  if value <> '' then
  begin
    if FDescription = nil then
      FDescription := TFhirString.create;
    FDescription.value := value
  end
  else if FDescription <> nil then
    FDescription.value := '';
end;

Procedure TFhirProfile.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirProfile.GetStatusST : TFhirResourceProfileStatus;
begin
  if FStatus = nil then
    result := TFhirResourceProfileStatus(0)
  else
    result := TFhirResourceProfileStatus(StringArrayIndexOf(CODES_TFhirResourceProfileStatus, Status.value));
end;

Procedure TFhirProfile.SetStatusST(value : TFhirResourceProfileStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirResourceProfileStatus[value]);
end;

Procedure TFhirProfile.SetExperimental(value : TFhirBoolean);
begin
  FExperimental.free;
  FExperimental := value;
end;

Function TFhirProfile.GetExperimentalST : String;
begin
  if FExperimental = nil then
    result := ''
  else
    result := Experimental.value;
end;

Procedure TFhirProfile.SetExperimentalST(value : String);
begin
  if value <> '' then
  begin
    if FExperimental = nil then
      FExperimental := TFhirBoolean.create;
    FExperimental.value := value
  end
  else if FExperimental <> nil then
    FExperimental.value := '';
end;

Procedure TFhirProfile.SetDate(value : TFhirDateTime);
begin
  FDate.free;
  FDate := value;
end;

Function TFhirProfile.GetDateST : TDateAndTime;
begin
  if FDate = nil then
    result := nil
  else
    result := Date.value;
end;

Procedure TFhirProfile.SetDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDate = nil then
      FDate := TFhirDateTime.create;
    FDate.value := value
  end
  else if FDate <> nil then
    FDate.value := nil;
end;

Procedure TFhirProfile.SetFhirVersion(value : TFhirId);
begin
  FFhirVersion.free;
  FFhirVersion := value;
end;

Function TFhirProfile.GetFhirVersionST : String;
begin
  if FFhirVersion = nil then
    result := ''
  else
    result := FhirVersion.value;
end;

Procedure TFhirProfile.SetFhirVersionST(value : String);
begin
  if value <> '' then
  begin
    if FFhirVersion = nil then
      FFhirVersion := TFhirId.create;
    FFhirVersion.value := value
  end
  else if FFhirVersion <> nil then
    FFhirVersion.value := '';
end;


{ TFhirProvenance }

constructor TFhirProvenance.Create;
begin
  inherited;
  FTargetList := TFhirResourceReferenceList{Resource}.Create;
  FPolicyList := TFhirUriList.Create;
  FAgentList := TFhirProvenanceAgentList.Create;
  FEntityList := TFhirProvenanceEntityList.Create;
end;

destructor TFhirProvenance.Destroy;
begin
  FTargetList.Free;
  FPeriod.free;
  FRecorded.free;
  FReason.free;
  FLocation.free;
  FPolicyList.Free;
  FAgentList.Free;
  FEntityList.Free;
  FSignature.free;
  inherited;
end;

function TFhirProvenance.GetResourceType : TFhirResourceType;
begin
  result := frtProvenance;
end;

procedure TFhirProvenance.Assign(oSource : TAdvObject);
begin
  inherited;
  FTargetList.Assign(TFhirProvenance(oSource).FTargetList);
  period := TFhirProvenance(oSource).period.Clone;
  recorded := TFhirProvenance(oSource).recorded.Clone;
  reason := TFhirProvenance(oSource).reason.Clone;
  location := TFhirProvenance(oSource).location.Clone;
  FPolicyList.Assign(TFhirProvenance(oSource).FPolicyList);
  FAgentList.Assign(TFhirProvenance(oSource).FAgentList);
  FEntityList.Assign(TFhirProvenance(oSource).FEntityList);
  signature := TFhirProvenance(oSource).signature.Clone;
end;

procedure TFhirProvenance.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'target') Then
     list.addAll(FTargetList);
  if (child_name = 'period') Then
     list.add(Period.Link);
  if (child_name = 'recorded') Then
     list.add(Recorded.Link);
  if (child_name = 'reason') Then
     list.add(Reason.Link);
  if (child_name = 'location') Then
     list.add(Location.Link);
  if (child_name = 'policy') Then
     list.addAll(FPolicyList);
  if (child_name = 'agent') Then
     list.addAll(FAgentList);
  if (child_name = 'entity') Then
     list.addAll(FEntityList);
  if (child_name = 'signature') Then
     list.add(Signature.Link);
end;

procedure TFhirProvenance.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'target', 'Resource(Any)', FTargetList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'period', 'Period', FPeriod.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'recorded', 'instant', FRecorded.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'reason', 'CodeableConcept', FReason.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'location', 'Resource(Location)', FLocation.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'policy', 'uri', FPolicyList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'agent', '', FAgentList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'entity', '', FEntityList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'signature', 'string', FSignature.Link.Link));{2}
end;

function TFhirProvenance.Link : TFhirProvenance;
begin
  result := TFhirProvenance(inherited Link);
end;

function TFhirProvenance.Clone : TFhirProvenance;
begin
  result := TFhirProvenance(inherited Clone);
end;

{ TFhirProvenance }

Procedure TFhirProvenance.SetPeriod(value : TFhirPeriod);
begin
  FPeriod.free;
  FPeriod := value;
end;

Procedure TFhirProvenance.SetRecorded(value : TFhirInstant);
begin
  FRecorded.free;
  FRecorded := value;
end;

Function TFhirProvenance.GetRecordedST : TDateAndTime;
begin
  if FRecorded = nil then
    result := nil
  else
    result := Recorded.value;
end;

Procedure TFhirProvenance.SetRecordedST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FRecorded = nil then
      FRecorded := TFhirInstant.create;
    FRecorded.value := value
  end
  else if FRecorded <> nil then
    FRecorded.value := nil;
end;

Procedure TFhirProvenance.SetReason(value : TFhirCodeableConcept);
begin
  FReason.free;
  FReason := value;
end;

Procedure TFhirProvenance.SetLocation(value : TFhirResourceReference{TFhirLocation});
begin
  FLocation.free;
  FLocation := value;
end;

Procedure TFhirProvenance.SetSignature(value : TFhirString);
begin
  FSignature.free;
  FSignature := value;
end;

Function TFhirProvenance.GetSignatureST : String;
begin
  if FSignature = nil then
    result := ''
  else
    result := Signature.value;
end;

Procedure TFhirProvenance.SetSignatureST(value : String);
begin
  if value <> '' then
  begin
    if FSignature = nil then
      FSignature := TFhirString.create;
    FSignature.value := value
  end
  else if FSignature <> nil then
    FSignature.value := '';
end;


{ TFhirQuery }

constructor TFhirQuery.Create;
begin
  inherited;
  FParameterList := TFhirExtensionList.Create;
end;

destructor TFhirQuery.Destroy;
begin
  FIdentifier.free;
  FParameterList.Free;
  FResponse.free;
  inherited;
end;

function TFhirQuery.GetResourceType : TFhirResourceType;
begin
  result := frtQuery;
end;

procedure TFhirQuery.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirQuery(oSource).identifier.Clone;
  FParameterList.Assign(TFhirQuery(oSource).FParameterList);
  response := TFhirQuery(oSource).response.Clone;
end;

procedure TFhirQuery.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'parameter') Then
     list.addAll(FParameterList);
  if (child_name = 'response') Then
     list.add(Response.Link);
end;

procedure TFhirQuery.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'uri', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'parameter', 'Extension', FParameterList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'response', '', FResponse.Link.Link));{2}
end;

function TFhirQuery.Link : TFhirQuery;
begin
  result := TFhirQuery(inherited Link);
end;

function TFhirQuery.Clone : TFhirQuery;
begin
  result := TFhirQuery(inherited Clone);
end;

{ TFhirQuery }

Procedure TFhirQuery.SetIdentifier(value : TFhirUri);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Function TFhirQuery.GetIdentifierST : String;
begin
  if FIdentifier = nil then
    result := ''
  else
    result := Identifier.value;
end;

Procedure TFhirQuery.SetIdentifierST(value : String);
begin
  if value <> '' then
  begin
    if FIdentifier = nil then
      FIdentifier := TFhirUri.create;
    FIdentifier.value := value
  end
  else if FIdentifier <> nil then
    FIdentifier.value := '';
end;

Procedure TFhirQuery.SetResponse(value : TFhirQueryResponse);
begin
  FResponse.free;
  FResponse := value;
end;


{ TFhirQuestionnaire }

constructor TFhirQuestionnaire.Create;
begin
  inherited;
  FQuestionList := TFhirQuestionnaireQuestionList.Create;
  FGroupList := TFhirQuestionnaireGroupList.Create;
end;

destructor TFhirQuestionnaire.Destroy;
begin
  FStatus.free;
  FAuthored.free;
  FSubject.free;
  FAuthor.free;
  FSource.free;
  FName.free;
  FIdentifier.free;
  FEncounter.free;
  FQuestionList.Free;
  FGroupList.Free;
  inherited;
end;

function TFhirQuestionnaire.GetResourceType : TFhirResourceType;
begin
  result := frtQuestionnaire;
end;

procedure TFhirQuestionnaire.Assign(oSource : TAdvObject);
begin
  inherited;
  FStatus := TFhirQuestionnaire(oSource).FStatus.Link;
  authored := TFhirQuestionnaire(oSource).authored.Clone;
  subject := TFhirQuestionnaire(oSource).subject.Clone;
  author := TFhirQuestionnaire(oSource).author.Clone;
  source := TFhirQuestionnaire(oSource).source.Clone;
  name := TFhirQuestionnaire(oSource).name.Clone;
  identifier := TFhirQuestionnaire(oSource).identifier.Clone;
  encounter := TFhirQuestionnaire(oSource).encounter.Clone;
  FQuestionList.Assign(TFhirQuestionnaire(oSource).FQuestionList);
  FGroupList.Assign(TFhirQuestionnaire(oSource).FGroupList);
end;

procedure TFhirQuestionnaire.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'authored') Then
     list.add(Authored.Link);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'author') Then
     list.add(Author.Link);
  if (child_name = 'source') Then
     list.add(Source.Link);
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'encounter') Then
     list.add(Encounter.Link);
  if (child_name = 'question') Then
     list.addAll(FQuestionList);
  if (child_name = 'group') Then
     list.addAll(FGroupList);
end;

procedure TFhirQuestionnaire.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'authored', 'dateTime', FAuthored.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient|RelatedPerson)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'author', 'Resource(Practitioner|Patient|RelatedPerson)', FAuthor.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'source', 'Resource(Patient|Practitioner|RelatedPerson)', FSource.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'name', 'CodeableConcept', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'encounter', 'Resource(Encounter)', FEncounter.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'question', '', FQuestionList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'group', '', FGroupList.Link)){3};
end;

function TFhirQuestionnaire.Link : TFhirQuestionnaire;
begin
  result := TFhirQuestionnaire(inherited Link);
end;

function TFhirQuestionnaire.Clone : TFhirQuestionnaire;
begin
  result := TFhirQuestionnaire(inherited Clone);
end;

{ TFhirQuestionnaire }

Procedure TFhirQuestionnaire.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirQuestionnaire.GetStatusST : TFhirObservationStatus;
begin
  if FStatus = nil then
    result := TFhirObservationStatus(0)
  else
    result := TFhirObservationStatus(StringArrayIndexOf(CODES_TFhirObservationStatus, Status.value));
end;

Procedure TFhirQuestionnaire.SetStatusST(value : TFhirObservationStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirObservationStatus[value]);
end;

Procedure TFhirQuestionnaire.SetAuthored(value : TFhirDateTime);
begin
  FAuthored.free;
  FAuthored := value;
end;

Function TFhirQuestionnaire.GetAuthoredST : TDateAndTime;
begin
  if FAuthored = nil then
    result := nil
  else
    result := Authored.value;
end;

Procedure TFhirQuestionnaire.SetAuthoredST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FAuthored = nil then
      FAuthored := TFhirDateTime.create;
    FAuthored.value := value
  end
  else if FAuthored <> nil then
    FAuthored.value := nil;
end;

Procedure TFhirQuestionnaire.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirQuestionnaire.SetAuthor(value : TFhirResourceReference{Resource});
begin
  FAuthor.free;
  FAuthor := value;
end;

Procedure TFhirQuestionnaire.SetSource(value : TFhirResourceReference{Resource});
begin
  FSource.free;
  FSource := value;
end;

Procedure TFhirQuestionnaire.SetName(value : TFhirCodeableConcept);
begin
  FName.free;
  FName := value;
end;

Procedure TFhirQuestionnaire.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirQuestionnaire.SetEncounter(value : TFhirResourceReference{TFhirEncounter});
begin
  FEncounter.free;
  FEncounter := value;
end;


{ TFhirRelatedPerson }

constructor TFhirRelatedPerson.Create;
begin
  inherited;
  FIdentifierList := TFhirIdentifierList.Create;
  FTelecomList := TFhirContactList.Create;
  FPhotoList := TFhirAttachmentList.Create;
end;

destructor TFhirRelatedPerson.Destroy;
begin
  FIdentifierList.Free;
  FPatient.free;
  FRelationship.free;
  FName.free;
  FTelecomList.Free;
  FGender.free;
  FAddress.free;
  FPhotoList.Free;
  inherited;
end;

function TFhirRelatedPerson.GetResourceType : TFhirResourceType;
begin
  result := frtRelatedPerson;
end;

procedure TFhirRelatedPerson.Assign(oSource : TAdvObject);
begin
  inherited;
  FIdentifierList.Assign(TFhirRelatedPerson(oSource).FIdentifierList);
  patient := TFhirRelatedPerson(oSource).patient.Clone;
  relationship := TFhirRelatedPerson(oSource).relationship.Clone;
  name := TFhirRelatedPerson(oSource).name.Clone;
  FTelecomList.Assign(TFhirRelatedPerson(oSource).FTelecomList);
  gender := TFhirRelatedPerson(oSource).gender.Clone;
  address := TFhirRelatedPerson(oSource).address.Clone;
  FPhotoList.Assign(TFhirRelatedPerson(oSource).FPhotoList);
end;

procedure TFhirRelatedPerson.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.addAll(FIdentifierList);
  if (child_name = 'patient') Then
     list.add(Patient.Link);
  if (child_name = 'relationship') Then
     list.add(Relationship.Link);
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'telecom') Then
     list.addAll(FTelecomList);
  if (child_name = 'gender') Then
     list.add(Gender.Link);
  if (child_name = 'address') Then
     list.add(Address.Link);
  if (child_name = 'photo') Then
     list.addAll(FPhotoList);
end;

procedure TFhirRelatedPerson.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'patient', 'Resource(Patient)', FPatient.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'relationship', 'CodeableConcept', FRelationship.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'name', 'HumanName', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'telecom', 'Contact', FTelecomList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'gender', 'CodeableConcept', FGender.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'address', 'Address', FAddress.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'photo', 'Attachment', FPhotoList.Link)){3};
end;

function TFhirRelatedPerson.Link : TFhirRelatedPerson;
begin
  result := TFhirRelatedPerson(inherited Link);
end;

function TFhirRelatedPerson.Clone : TFhirRelatedPerson;
begin
  result := TFhirRelatedPerson(inherited Clone);
end;

{ TFhirRelatedPerson }

Procedure TFhirRelatedPerson.SetPatient(value : TFhirResourceReference{TFhirPatient});
begin
  FPatient.free;
  FPatient := value;
end;

Procedure TFhirRelatedPerson.SetRelationship(value : TFhirCodeableConcept);
begin
  FRelationship.free;
  FRelationship := value;
end;

Procedure TFhirRelatedPerson.SetName(value : TFhirHumanName);
begin
  FName.free;
  FName := value;
end;

Procedure TFhirRelatedPerson.SetGender(value : TFhirCodeableConcept);
begin
  FGender.free;
  FGender := value;
end;

Procedure TFhirRelatedPerson.SetAddress(value : TFhirAddress);
begin
  FAddress.free;
  FAddress := value;
end;


{ TFhirSecurityEvent }

constructor TFhirSecurityEvent.Create;
begin
  inherited;
  FParticipantList := TFhirSecurityEventParticipantList.Create;
  FObject_List := TFhirSecurityEventObjectList.Create;
end;

destructor TFhirSecurityEvent.Destroy;
begin
  FEvent.free;
  FParticipantList.Free;
  FSource.free;
  FObject_List.Free;
  inherited;
end;

function TFhirSecurityEvent.GetResourceType : TFhirResourceType;
begin
  result := frtSecurityEvent;
end;

procedure TFhirSecurityEvent.Assign(oSource : TAdvObject);
begin
  inherited;
  event := TFhirSecurityEvent(oSource).event.Clone;
  FParticipantList.Assign(TFhirSecurityEvent(oSource).FParticipantList);
  source := TFhirSecurityEvent(oSource).source.Clone;
  FObject_List.Assign(TFhirSecurityEvent(oSource).FObject_List);
end;

procedure TFhirSecurityEvent.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'event') Then
     list.add(Event.Link);
  if (child_name = 'participant') Then
     list.addAll(FParticipantList);
  if (child_name = 'source') Then
     list.add(Source.Link);
  if (child_name = 'object_') Then
     list.addAll(FObject_List);
end;

procedure TFhirSecurityEvent.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'event', '', FEvent.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'participant', '', FParticipantList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'source', '', FSource.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'object', '', FObject_List.Link)){3};
end;

function TFhirSecurityEvent.Link : TFhirSecurityEvent;
begin
  result := TFhirSecurityEvent(inherited Link);
end;

function TFhirSecurityEvent.Clone : TFhirSecurityEvent;
begin
  result := TFhirSecurityEvent(inherited Clone);
end;

{ TFhirSecurityEvent }

Procedure TFhirSecurityEvent.SetEvent(value : TFhirSecurityEventEvent);
begin
  FEvent.free;
  FEvent := value;
end;

Procedure TFhirSecurityEvent.SetSource(value : TFhirSecurityEventSource);
begin
  FSource.free;
  FSource := value;
end;


{ TFhirSpecimen }

constructor TFhirSpecimen.Create;
begin
  inherited;
  FSourceList := TFhirSpecimenSourceList.Create;
  FAccessionIdentifierList := TFhirIdentifierList.Create;
  FTreatmentList := TFhirSpecimenTreatmentList.Create;
  FContainerList := TFhirSpecimenContainerList.Create;
end;

destructor TFhirSpecimen.Destroy;
begin
  FIdentifier.free;
  FType_.free;
  FSourceList.Free;
  FSubject.free;
  FAccessionIdentifierList.Free;
  FReceivedTime.free;
  FCollection.free;
  FTreatmentList.Free;
  FContainerList.Free;
  inherited;
end;

function TFhirSpecimen.GetResourceType : TFhirResourceType;
begin
  result := frtSpecimen;
end;

procedure TFhirSpecimen.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirSpecimen(oSource).identifier.Clone;
  type_ := TFhirSpecimen(oSource).type_.Clone;
  FSourceList.Assign(TFhirSpecimen(oSource).FSourceList);
  subject := TFhirSpecimen(oSource).subject.Clone;
  FAccessionIdentifierList.Assign(TFhirSpecimen(oSource).FAccessionIdentifierList);
  receivedTime := TFhirSpecimen(oSource).receivedTime.Clone;
  collection := TFhirSpecimen(oSource).collection.Clone;
  FTreatmentList.Assign(TFhirSpecimen(oSource).FTreatmentList);
  FContainerList.Assign(TFhirSpecimen(oSource).FContainerList);
end;

procedure TFhirSpecimen.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'type_') Then
     list.add(Type_.Link);
  if (child_name = 'source') Then
     list.addAll(FSourceList);
  if (child_name = 'subject') Then
     list.add(Subject.Link);
  if (child_name = 'accessionIdentifier') Then
     list.addAll(FAccessionIdentifierList);
  if (child_name = 'receivedTime') Then
     list.add(ReceivedTime.Link);
  if (child_name = 'collection') Then
     list.add(Collection.Link);
  if (child_name = 'treatment') Then
     list.addAll(FTreatmentList);
  if (child_name = 'container') Then
     list.addAll(FContainerList);
end;

procedure TFhirSpecimen.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'type', 'CodeableConcept', FType_.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'source', '', FSourceList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'subject', 'Resource(Patient|Group|Device|Substance)', FSubject.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'accessionIdentifier', 'Identifier', FAccessionIdentifierList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'receivedTime', 'dateTime', FReceivedTime.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'collection', '', FCollection.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'treatment', '', FTreatmentList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'container', '', FContainerList.Link)){3};
end;

function TFhirSpecimen.Link : TFhirSpecimen;
begin
  result := TFhirSpecimen(inherited Link);
end;

function TFhirSpecimen.Clone : TFhirSpecimen;
begin
  result := TFhirSpecimen(inherited Clone);
end;

{ TFhirSpecimen }

Procedure TFhirSpecimen.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirSpecimen.SetType_(value : TFhirCodeableConcept);
begin
  FType_.free;
  FType_ := value;
end;

Procedure TFhirSpecimen.SetSubject(value : TFhirResourceReference{Resource});
begin
  FSubject.free;
  FSubject := value;
end;

Procedure TFhirSpecimen.SetReceivedTime(value : TFhirDateTime);
begin
  FReceivedTime.free;
  FReceivedTime := value;
end;

Function TFhirSpecimen.GetReceivedTimeST : TDateAndTime;
begin
  if FReceivedTime = nil then
    result := nil
  else
    result := ReceivedTime.value;
end;

Procedure TFhirSpecimen.SetReceivedTimeST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FReceivedTime = nil then
      FReceivedTime := TFhirDateTime.create;
    FReceivedTime.value := value
  end
  else if FReceivedTime <> nil then
    FReceivedTime.value := nil;
end;

Procedure TFhirSpecimen.SetCollection(value : TFhirSpecimenCollection);
begin
  FCollection.free;
  FCollection := value;
end;


{ TFhirSubstance }

constructor TFhirSubstance.Create;
begin
  inherited;
  FIngredientList := TFhirResourceReferenceList{TFhirSubstance}.Create;
end;

destructor TFhirSubstance.Destroy;
begin
  FIdentifier.free;
  FName.free;
  FType_.free;
  FDescription.free;
  FStatus.free;
  FEffectiveTime.free;
  FQuantity.free;
  FIngredientList.Free;
  FQuantityMode.free;
  inherited;
end;

function TFhirSubstance.GetResourceType : TFhirResourceType;
begin
  result := frtSubstance;
end;

procedure TFhirSubstance.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirSubstance(oSource).identifier.Clone;
  name := TFhirSubstance(oSource).name.Clone;
  type_ := TFhirSubstance(oSource).type_.Clone;
  description := TFhirSubstance(oSource).description.Clone;
  status := TFhirSubstance(oSource).status.Clone;
  effectiveTime := TFhirSubstance(oSource).effectiveTime.Clone;
  quantity := TFhirSubstance(oSource).quantity.Clone;
  FIngredientList.Assign(TFhirSubstance(oSource).FIngredientList);
  quantityMode := TFhirSubstance(oSource).quantityMode.Clone;
end;

procedure TFhirSubstance.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'type_') Then
     list.add(Type_.Link);
  if (child_name = 'description') Then
     list.add(Description.Link);
  if (child_name = 'status') Then
     list.add(Status.Link);
  if (child_name = 'effectiveTime') Then
     list.add(EffectiveTime.Link);
  if (child_name = 'quantity') Then
     list.add(Quantity.Link);
  if (child_name = 'ingredient') Then
     list.addAll(FIngredientList);
  if (child_name = 'quantityMode') Then
     list.add(QuantityMode.Link);
end;

procedure TFhirSubstance.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'name', 'string', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'type', 'CodeableConcept', FType_.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'description', 'string', FDescription.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'CodeableConcept', FStatus.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'effectiveTime', 'Period', FEffectiveTime.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'quantity', 'Quantity', FQuantity.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'ingredient', 'Resource(Substance)', FIngredientList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'quantityMode', 'CodeableConcept', FQuantityMode.Link.Link));{2}
end;

function TFhirSubstance.Link : TFhirSubstance;
begin
  result := TFhirSubstance(inherited Link);
end;

function TFhirSubstance.Clone : TFhirSubstance;
begin
  result := TFhirSubstance(inherited Clone);
end;

{ TFhirSubstance }

Procedure TFhirSubstance.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirSubstance.SetName(value : TFhirString);
begin
  FName.free;
  FName := value;
end;

Function TFhirSubstance.GetNameST : String;
begin
  if FName = nil then
    result := ''
  else
    result := Name.value;
end;

Procedure TFhirSubstance.SetNameST(value : String);
begin
  if value <> '' then
  begin
    if FName = nil then
      FName := TFhirString.create;
    FName.value := value
  end
  else if FName <> nil then
    FName.value := '';
end;

Procedure TFhirSubstance.SetType_(value : TFhirCodeableConcept);
begin
  FType_.free;
  FType_ := value;
end;

Procedure TFhirSubstance.SetDescription(value : TFhirString);
begin
  FDescription.free;
  FDescription := value;
end;

Function TFhirSubstance.GetDescriptionST : String;
begin
  if FDescription = nil then
    result := ''
  else
    result := Description.value;
end;

Procedure TFhirSubstance.SetDescriptionST(value : String);
begin
  if value <> '' then
  begin
    if FDescription = nil then
      FDescription := TFhirString.create;
    FDescription.value := value
  end
  else if FDescription <> nil then
    FDescription.value := '';
end;

Procedure TFhirSubstance.SetStatus(value : TFhirCodeableConcept);
begin
  FStatus.free;
  FStatus := value;
end;

Procedure TFhirSubstance.SetEffectiveTime(value : TFhirPeriod);
begin
  FEffectiveTime.free;
  FEffectiveTime := value;
end;

Procedure TFhirSubstance.SetQuantity(value : TFhirQuantity);
begin
  FQuantity.free;
  FQuantity := value;
end;

Procedure TFhirSubstance.SetQuantityMode(value : TFhirCodeableConcept);
begin
  FQuantityMode.free;
  FQuantityMode := value;
end;


{ TFhirSupply }

constructor TFhirSupply.Create;
begin
  inherited;
  FDispenseList := TFhirSupplyDispenseList.Create;
end;

destructor TFhirSupply.Destroy;
begin
  FName.free;
  FIdentifier.free;
  FStatus.free;
  FOrderedItem.free;
  FPatient.free;
  FDispenseList.Free;
  inherited;
end;

function TFhirSupply.GetResourceType : TFhirResourceType;
begin
  result := frtSupply;
end;

procedure TFhirSupply.Assign(oSource : TAdvObject);
begin
  inherited;
  name := TFhirSupply(oSource).name.Clone;
  identifier := TFhirSupply(oSource).identifier.Clone;
  status := TFhirSupply(oSource).status.Clone;
  orderedItem := TFhirSupply(oSource).orderedItem.Clone;
  patient := TFhirSupply(oSource).patient.Clone;
  FDispenseList.Assign(TFhirSupply(oSource).FDispenseList);
end;

procedure TFhirSupply.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'status') Then
     list.add(Status.Link);
  if (child_name = 'orderedItem') Then
     list.add(OrderedItem.Link);
  if (child_name = 'patient') Then
     list.add(Patient.Link);
  if (child_name = 'dispense') Then
     list.addAll(FDispenseList);
end;

procedure TFhirSupply.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'name', 'CodeableConcept', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'identifier', 'Identifier', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'orderedItem', 'Resource(Medication|Substance|Device)', FOrderedItem.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'patient', 'Resource(Patient)', FPatient.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'dispense', '', FDispenseList.Link)){3};
end;

function TFhirSupply.Link : TFhirSupply;
begin
  result := TFhirSupply(inherited Link);
end;

function TFhirSupply.Clone : TFhirSupply;
begin
  result := TFhirSupply(inherited Clone);
end;

{ TFhirSupply }

Procedure TFhirSupply.SetName(value : TFhirCodeableConcept);
begin
  FName.free;
  FName := value;
end;

Procedure TFhirSupply.SetIdentifier(value : TFhirIdentifier);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Procedure TFhirSupply.SetStatus(value : TFhirCode);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirSupply.GetStatusST : String;
begin
  if FStatus = nil then
    result := ''
  else
    result := Status.value;
end;

Procedure TFhirSupply.SetStatusST(value : String);
begin
  if value <> '' then
  begin
    if FStatus = nil then
      FStatus := TFhirCode.create;
    FStatus.value := value
  end
  else if FStatus <> nil then
    FStatus.value := '';
end;

Procedure TFhirSupply.SetOrderedItem(value : TFhirResourceReference{Resource});
begin
  FOrderedItem.free;
  FOrderedItem := value;
end;

Procedure TFhirSupply.SetPatient(value : TFhirResourceReference{TFhirPatient});
begin
  FPatient.free;
  FPatient := value;
end;


{ TFhirValueSet }

constructor TFhirValueSet.Create;
begin
  inherited;
  FTelecomList := TFhirContactList.Create;
end;

destructor TFhirValueSet.Destroy;
begin
  FIdentifier.free;
  FVersion.free;
  FName.free;
  FPublisher.free;
  FTelecomList.Free;
  FDescription.free;
  FCopyright.free;
  FStatus.free;
  FExperimental.free;
  FDate.free;
  FDefine.free;
  FCompose.free;
  FExpansion.free;
  inherited;
end;

function TFhirValueSet.GetResourceType : TFhirResourceType;
begin
  result := frtValueSet;
end;

procedure TFhirValueSet.Assign(oSource : TAdvObject);
begin
  inherited;
  identifier := TFhirValueSet(oSource).identifier.Clone;
  version := TFhirValueSet(oSource).version.Clone;
  name := TFhirValueSet(oSource).name.Clone;
  publisher := TFhirValueSet(oSource).publisher.Clone;
  FTelecomList.Assign(TFhirValueSet(oSource).FTelecomList);
  description := TFhirValueSet(oSource).description.Clone;
  copyright := TFhirValueSet(oSource).copyright.Clone;
  FStatus := TFhirValueSet(oSource).FStatus.Link;
  experimental := TFhirValueSet(oSource).experimental.Clone;
  date := TFhirValueSet(oSource).date.Clone;
  define := TFhirValueSet(oSource).define.Clone;
  compose := TFhirValueSet(oSource).compose.Clone;
  expansion := TFhirValueSet(oSource).expansion.Clone;
end;

procedure TFhirValueSet.GetChildrenByName(child_name : string; list : TFHIRObjectList);
begin
  inherited;
  if (child_name = 'identifier') Then
     list.add(Identifier.Link);
  if (child_name = 'version') Then
     list.add(Version.Link);
  if (child_name = 'name') Then
     list.add(Name.Link);
  if (child_name = 'publisher') Then
     list.add(Publisher.Link);
  if (child_name = 'telecom') Then
     list.addAll(FTelecomList);
  if (child_name = 'description') Then
     list.add(Description.Link);
  if (child_name = 'copyright') Then
     list.add(Copyright.Link);
  if (child_name = 'status') Then
     list.add(FStatus.Link);
  if (child_name = 'experimental') Then
     list.add(Experimental.Link);
  if (child_name = 'date') Then
     list.add(Date.Link);
  if (child_name = 'define') Then
     list.add(Define.Link);
  if (child_name = 'compose') Then
     list.add(Compose.Link);
  if (child_name = 'expansion') Then
     list.add(Expansion.Link);
end;

procedure TFhirValueSet.ListProperties(oList: TFHIRPropertyList; bInheritedProperties: Boolean);
begin
  inherited;
  oList.add(TFHIRProperty.create(self, 'identifier', 'string', FIdentifier.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'version', 'string', FVersion.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'name', 'string', FName.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'publisher', 'string', FPublisher.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'telecom', 'Contact', FTelecomList.Link)){3};
  oList.add(TFHIRProperty.create(self, 'description', 'string', FDescription.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'copyright', 'string', FCopyright.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'status', 'code', FStatus.Link));{1}
  oList.add(TFHIRProperty.create(self, 'experimental', 'boolean', FExperimental.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'date', 'dateTime', FDate.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'define', '', FDefine.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'compose', '', FCompose.Link.Link));{2}
  oList.add(TFHIRProperty.create(self, 'expansion', '', FExpansion.Link.Link));{2}
end;

function TFhirValueSet.Link : TFhirValueSet;
begin
  result := TFhirValueSet(inherited Link);
end;

function TFhirValueSet.Clone : TFhirValueSet;
begin
  result := TFhirValueSet(inherited Clone);
end;

{ TFhirValueSet }

Procedure TFhirValueSet.SetIdentifier(value : TFhirString);
begin
  FIdentifier.free;
  FIdentifier := value;
end;

Function TFhirValueSet.GetIdentifierST : String;
begin
  if FIdentifier = nil then
    result := ''
  else
    result := Identifier.value;
end;

Procedure TFhirValueSet.SetIdentifierST(value : String);
begin
  if value <> '' then
  begin
    if FIdentifier = nil then
      FIdentifier := TFhirString.create;
    FIdentifier.value := value
  end
  else if FIdentifier <> nil then
    FIdentifier.value := '';
end;

Procedure TFhirValueSet.SetVersion(value : TFhirString);
begin
  FVersion.free;
  FVersion := value;
end;

Function TFhirValueSet.GetVersionST : String;
begin
  if FVersion = nil then
    result := ''
  else
    result := Version.value;
end;

Procedure TFhirValueSet.SetVersionST(value : String);
begin
  if value <> '' then
  begin
    if FVersion = nil then
      FVersion := TFhirString.create;
    FVersion.value := value
  end
  else if FVersion <> nil then
    FVersion.value := '';
end;

Procedure TFhirValueSet.SetName(value : TFhirString);
begin
  FName.free;
  FName := value;
end;

Function TFhirValueSet.GetNameST : String;
begin
  if FName = nil then
    result := ''
  else
    result := Name.value;
end;

Procedure TFhirValueSet.SetNameST(value : String);
begin
  if value <> '' then
  begin
    if FName = nil then
      FName := TFhirString.create;
    FName.value := value
  end
  else if FName <> nil then
    FName.value := '';
end;

Procedure TFhirValueSet.SetPublisher(value : TFhirString);
begin
  FPublisher.free;
  FPublisher := value;
end;

Function TFhirValueSet.GetPublisherST : String;
begin
  if FPublisher = nil then
    result := ''
  else
    result := Publisher.value;
end;

Procedure TFhirValueSet.SetPublisherST(value : String);
begin
  if value <> '' then
  begin
    if FPublisher = nil then
      FPublisher := TFhirString.create;
    FPublisher.value := value
  end
  else if FPublisher <> nil then
    FPublisher.value := '';
end;

Procedure TFhirValueSet.SetDescription(value : TFhirString);
begin
  FDescription.free;
  FDescription := value;
end;

Function TFhirValueSet.GetDescriptionST : String;
begin
  if FDescription = nil then
    result := ''
  else
    result := Description.value;
end;

Procedure TFhirValueSet.SetDescriptionST(value : String);
begin
  if value <> '' then
  begin
    if FDescription = nil then
      FDescription := TFhirString.create;
    FDescription.value := value
  end
  else if FDescription <> nil then
    FDescription.value := '';
end;

Procedure TFhirValueSet.SetCopyright(value : TFhirString);
begin
  FCopyright.free;
  FCopyright := value;
end;

Function TFhirValueSet.GetCopyrightST : String;
begin
  if FCopyright = nil then
    result := ''
  else
    result := Copyright.value;
end;

Procedure TFhirValueSet.SetCopyrightST(value : String);
begin
  if value <> '' then
  begin
    if FCopyright = nil then
      FCopyright := TFhirString.create;
    FCopyright.value := value
  end
  else if FCopyright <> nil then
    FCopyright.value := '';
end;

Procedure TFhirValueSet.SetStatus(value : TFhirEnum);
begin
  FStatus.free;
  FStatus := value;
end;

Function TFhirValueSet.GetStatusST : TFhirValuesetStatus;
begin
  if FStatus = nil then
    result := TFhirValuesetStatus(0)
  else
    result := TFhirValuesetStatus(StringArrayIndexOf(CODES_TFhirValuesetStatus, Status.value));
end;

Procedure TFhirValueSet.SetStatusST(value : TFhirValuesetStatus);
begin
  if ord(value) = 0 then
    Status := nil
  else
    Status := TFhirEnum.create(CODES_TFhirValuesetStatus[value]);
end;

Procedure TFhirValueSet.SetExperimental(value : TFhirBoolean);
begin
  FExperimental.free;
  FExperimental := value;
end;

Function TFhirValueSet.GetExperimentalST : String;
begin
  if FExperimental = nil then
    result := ''
  else
    result := Experimental.value;
end;

Procedure TFhirValueSet.SetExperimentalST(value : String);
begin
  if value <> '' then
  begin
    if FExperimental = nil then
      FExperimental := TFhirBoolean.create;
    FExperimental.value := value
  end
  else if FExperimental <> nil then
    FExperimental.value := '';
end;

Procedure TFhirValueSet.SetDate(value : TFhirDateTime);
begin
  FDate.free;
  FDate := value;
end;

Function TFhirValueSet.GetDateST : TDateAndTime;
begin
  if FDate = nil then
    result := nil
  else
    result := Date.value;
end;

Procedure TFhirValueSet.SetDateST(value : TDateAndTime);
begin
  if value <> nil then
  begin
    if FDate = nil then
      FDate := TFhirDateTime.create;
    FDate.value := value
  end
  else if FDate <> nil then
    FDate.value := nil;
end;

Procedure TFhirValueSet.SetDefine(value : TFhirValueSetDefine);
begin
  FDefine.free;
  FDefine := value;
end;

Procedure TFhirValueSet.SetCompose(value : TFhirValueSetCompose);
begin
  FCompose.free;
  FCompose := value;
end;

Procedure TFhirValueSet.SetExpansion(value : TFhirValueSetExpansion);
begin
  FExpansion.free;
  FExpansion := value;
end;


function TFhirResourceFactory.newExtension : TFhirExtension;
begin
  result := TFhirExtension.create;
end;

function TFhirResourceFactory.newNarrative : TFhirNarrative;
begin
  result := TFhirNarrative.create;
end;

function TFhirResourceFactory.newPeriod : TFhirPeriod;
begin
  result := TFhirPeriod.create;
end;

function TFhirResourceFactory.newCoding : TFhirCoding;
begin
  result := TFhirCoding.create;
end;

function TFhirResourceFactory.newRange : TFhirRange;
begin
  result := TFhirRange.create;
end;

function TFhirResourceFactory.newQuantity : TFhirQuantity;
begin
  result := TFhirQuantity.create;
end;

function TFhirResourceFactory.newChoiceOption : TFhirChoiceOption;
begin
  result := TFhirChoiceOption.create;
end;

function TFhirResourceFactory.newChoice : TFhirChoice;
begin
  result := TFhirChoice.create;
end;

function TFhirResourceFactory.newAttachment : TFhirAttachment;
begin
  result := TFhirAttachment.create;
end;

function TFhirResourceFactory.newRatio : TFhirRatio;
begin
  result := TFhirRatio.create;
end;

function TFhirResourceFactory.newSampledData : TFhirSampledData;
begin
  result := TFhirSampledData.create;
end;

function TFhirResourceFactory.newResourceReference : TFhirResourceReference;
begin
  result := TFhirResourceReference.create;
end;

function TFhirResourceFactory.newCodeableConcept : TFhirCodeableConcept;
begin
  result := TFhirCodeableConcept.create;
end;

function TFhirResourceFactory.newIdentifier : TFhirIdentifier;
begin
  result := TFhirIdentifier.create;
end;

function TFhirResourceFactory.newScheduleRepeat : TFhirScheduleRepeat;
begin
  result := TFhirScheduleRepeat.create;
end;

function TFhirResourceFactory.newSchedule : TFhirSchedule;
begin
  result := TFhirSchedule.create;
end;

function TFhirResourceFactory.newContact : TFhirContact;
begin
  result := TFhirContact.create;
end;

function TFhirResourceFactory.newAddress : TFhirAddress;
begin
  result := TFhirAddress.create;
end;

function TFhirResourceFactory.newHumanName : TFhirHumanName;
begin
  result := TFhirHumanName.create;
end;

function TFhirResourceFactory.newAdverseReactionSymptom : TFhirAdverseReactionSymptom;
begin
  result := TFhirAdverseReactionSymptom.create;
end;

function TFhirResourceFactory.newAdverseReactionExposure : TFhirAdverseReactionExposure;
begin
  result := TFhirAdverseReactionExposure.create;
end;

function TFhirResourceFactory.newAdverseReaction : TFhirAdverseReaction;
begin
  result := TFhirAdverseReaction.create;
end;

function TFhirResourceFactory.newAlert : TFhirAlert;
begin
  result := TFhirAlert.create;
end;

function TFhirResourceFactory.newAllergyIntolerance : TFhirAllergyIntolerance;
begin
  result := TFhirAllergyIntolerance.create;
end;

function TFhirResourceFactory.newCarePlanParticipant : TFhirCarePlanParticipant;
begin
  result := TFhirCarePlanParticipant.create;
end;

function TFhirResourceFactory.newCarePlanGoal : TFhirCarePlanGoal;
begin
  result := TFhirCarePlanGoal.create;
end;

function TFhirResourceFactory.newCarePlanActivity : TFhirCarePlanActivity;
begin
  result := TFhirCarePlanActivity.create;
end;

function TFhirResourceFactory.newCarePlan : TFhirCarePlan;
begin
  result := TFhirCarePlan.create;
end;

function TFhirResourceFactory.newConditionStage : TFhirConditionStage;
begin
  result := TFhirConditionStage.create;
end;

function TFhirResourceFactory.newConditionEvidence : TFhirConditionEvidence;
begin
  result := TFhirConditionEvidence.create;
end;

function TFhirResourceFactory.newConditionLocation : TFhirConditionLocation;
begin
  result := TFhirConditionLocation.create;
end;

function TFhirResourceFactory.newConditionRelatedItem : TFhirConditionRelatedItem;
begin
  result := TFhirConditionRelatedItem.create;
end;

function TFhirResourceFactory.newCondition : TFhirCondition;
begin
  result := TFhirCondition.create;
end;

function TFhirResourceFactory.newConformanceSoftware : TFhirConformanceSoftware;
begin
  result := TFhirConformanceSoftware.create;
end;

function TFhirResourceFactory.newConformanceImplementation : TFhirConformanceImplementation;
begin
  result := TFhirConformanceImplementation.create;
end;

function TFhirResourceFactory.newConformanceRest : TFhirConformanceRest;
begin
  result := TFhirConformanceRest.create;
end;

function TFhirResourceFactory.newConformanceRestSecurity : TFhirConformanceRestSecurity;
begin
  result := TFhirConformanceRestSecurity.create;
end;

function TFhirResourceFactory.newConformanceRestSecurityCertificate : TFhirConformanceRestSecurityCertificate;
begin
  result := TFhirConformanceRestSecurityCertificate.create;
end;

function TFhirResourceFactory.newConformanceRestResource : TFhirConformanceRestResource;
begin
  result := TFhirConformanceRestResource.create;
end;

function TFhirResourceFactory.newConformanceRestResourceOperation : TFhirConformanceRestResourceOperation;
begin
  result := TFhirConformanceRestResourceOperation.create;
end;

function TFhirResourceFactory.newConformanceRestResourceSearchParam : TFhirConformanceRestResourceSearchParam;
begin
  result := TFhirConformanceRestResourceSearchParam.create;
end;

function TFhirResourceFactory.newConformanceRestQuery : TFhirConformanceRestQuery;
begin
  result := TFhirConformanceRestQuery.create;
end;

function TFhirResourceFactory.newConformanceMessaging : TFhirConformanceMessaging;
begin
  result := TFhirConformanceMessaging.create;
end;

function TFhirResourceFactory.newConformanceMessagingEvent : TFhirConformanceMessagingEvent;
begin
  result := TFhirConformanceMessagingEvent.create;
end;

function TFhirResourceFactory.newConformanceDocument : TFhirConformanceDocument;
begin
  result := TFhirConformanceDocument.create;
end;

function TFhirResourceFactory.newConformance : TFhirConformance;
begin
  result := TFhirConformance.create;
end;

function TFhirResourceFactory.newCoverageSubscriber : TFhirCoverageSubscriber;
begin
  result := TFhirCoverageSubscriber.create;
end;

function TFhirResourceFactory.newCoverage : TFhirCoverage;
begin
  result := TFhirCoverage.create;
end;

function TFhirResourceFactory.newDeviceIdentity : TFhirDeviceIdentity;
begin
  result := TFhirDeviceIdentity.create;
end;

function TFhirResourceFactory.newDevice : TFhirDevice;
begin
  result := TFhirDevice.create;
end;

function TFhirResourceFactory.newDeviceCapabilitiesVirtualDevice : TFhirDeviceCapabilitiesVirtualDevice;
begin
  result := TFhirDeviceCapabilitiesVirtualDevice.create;
end;

function TFhirResourceFactory.newDeviceCapabilitiesVirtualDeviceChannel : TFhirDeviceCapabilitiesVirtualDeviceChannel;
begin
  result := TFhirDeviceCapabilitiesVirtualDeviceChannel.create;
end;

function TFhirResourceFactory.newDeviceCapabilitiesVirtualDeviceChannelMetric : TFhirDeviceCapabilitiesVirtualDeviceChannelMetric;
begin
  result := TFhirDeviceCapabilitiesVirtualDeviceChannelMetric.create;
end;

function TFhirResourceFactory.newDeviceCapabilitiesVirtualDeviceChannelMetricInfo : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo;
begin
  result := TFhirDeviceCapabilitiesVirtualDeviceChannelMetricInfo.create;
end;

function TFhirResourceFactory.newDeviceCapabilitiesVirtualDeviceChannelMetricFacet : TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet;
begin
  result := TFhirDeviceCapabilitiesVirtualDeviceChannelMetricFacet.create;
end;

function TFhirResourceFactory.newDeviceCapabilities : TFhirDeviceCapabilities;
begin
  result := TFhirDeviceCapabilities.create;
end;

function TFhirResourceFactory.newDeviceLogItem : TFhirDeviceLogItem;
begin
  result := TFhirDeviceLogItem.create;
end;

function TFhirResourceFactory.newDeviceLog : TFhirDeviceLog;
begin
  result := TFhirDeviceLog.create;
end;

function TFhirResourceFactory.newDeviceObservation : TFhirDeviceObservation;
begin
  result := TFhirDeviceObservation.create;
end;

function TFhirResourceFactory.newDiagnosticOrderEvent : TFhirDiagnosticOrderEvent;
begin
  result := TFhirDiagnosticOrderEvent.create;
end;

function TFhirResourceFactory.newDiagnosticOrderItem : TFhirDiagnosticOrderItem;
begin
  result := TFhirDiagnosticOrderItem.create;
end;

function TFhirResourceFactory.newDiagnosticOrder : TFhirDiagnosticOrder;
begin
  result := TFhirDiagnosticOrder.create;
end;

function TFhirResourceFactory.newDiagnosticReportRequestDetail : TFhirDiagnosticReportRequestDetail;
begin
  result := TFhirDiagnosticReportRequestDetail.create;
end;

function TFhirResourceFactory.newDiagnosticReportResults : TFhirDiagnosticReportResults;
begin
  result := TFhirDiagnosticReportResults.create;
end;

function TFhirResourceFactory.newDiagnosticReport : TFhirDiagnosticReport;
begin
  result := TFhirDiagnosticReport.create;
end;

function TFhirResourceFactory.newDocumentAttester : TFhirDocumentAttester;
begin
  result := TFhirDocumentAttester.create;
end;

function TFhirResourceFactory.newDocumentEvent : TFhirDocumentEvent;
begin
  result := TFhirDocumentEvent.create;
end;

function TFhirResourceFactory.newDocumentSection : TFhirDocumentSection;
begin
  result := TFhirDocumentSection.create;
end;

function TFhirResourceFactory.newDocument : TFhirDocument;
begin
  result := TFhirDocument.create;
end;

function TFhirResourceFactory.newDocumentReferenceService : TFhirDocumentReferenceService;
begin
  result := TFhirDocumentReferenceService.create;
end;

function TFhirResourceFactory.newDocumentReferenceServiceParameter : TFhirDocumentReferenceServiceParameter;
begin
  result := TFhirDocumentReferenceServiceParameter.create;
end;

function TFhirResourceFactory.newDocumentReferenceContext : TFhirDocumentReferenceContext;
begin
  result := TFhirDocumentReferenceContext.create;
end;

function TFhirResourceFactory.newDocumentReference : TFhirDocumentReference;
begin
  result := TFhirDocumentReference.create;
end;

function TFhirResourceFactory.newEncounterParticipant : TFhirEncounterParticipant;
begin
  result := TFhirEncounterParticipant.create;
end;

function TFhirResourceFactory.newEncounterHospitalization : TFhirEncounterHospitalization;
begin
  result := TFhirEncounterHospitalization.create;
end;

function TFhirResourceFactory.newEncounterHospitalizationAccomodation : TFhirEncounterHospitalizationAccomodation;
begin
  result := TFhirEncounterHospitalizationAccomodation.create;
end;

function TFhirResourceFactory.newEncounterLocation : TFhirEncounterLocation;
begin
  result := TFhirEncounterLocation.create;
end;

function TFhirResourceFactory.newEncounter : TFhirEncounter;
begin
  result := TFhirEncounter.create;
end;

function TFhirResourceFactory.newFamilyHistoryRelation : TFhirFamilyHistoryRelation;
begin
  result := TFhirFamilyHistoryRelation.create;
end;

function TFhirResourceFactory.newFamilyHistoryRelationCondition : TFhirFamilyHistoryRelationCondition;
begin
  result := TFhirFamilyHistoryRelationCondition.create;
end;

function TFhirResourceFactory.newFamilyHistory : TFhirFamilyHistory;
begin
  result := TFhirFamilyHistory.create;
end;

function TFhirResourceFactory.newGroupCharacteristic : TFhirGroupCharacteristic;
begin
  result := TFhirGroupCharacteristic.create;
end;

function TFhirResourceFactory.newGroup : TFhirGroup;
begin
  result := TFhirGroup.create;
end;

function TFhirResourceFactory.newImagingStudySeries : TFhirImagingStudySeries;
begin
  result := TFhirImagingStudySeries.create;
end;

function TFhirResourceFactory.newImagingStudySeriesInstance : TFhirImagingStudySeriesInstance;
begin
  result := TFhirImagingStudySeriesInstance.create;
end;

function TFhirResourceFactory.newImagingStudy : TFhirImagingStudy;
begin
  result := TFhirImagingStudy.create;
end;

function TFhirResourceFactory.newImmunizationExplanation : TFhirImmunizationExplanation;
begin
  result := TFhirImmunizationExplanation.create;
end;

function TFhirResourceFactory.newImmunizationReaction : TFhirImmunizationReaction;
begin
  result := TFhirImmunizationReaction.create;
end;

function TFhirResourceFactory.newImmunizationVaccinationProtocol : TFhirImmunizationVaccinationProtocol;
begin
  result := TFhirImmunizationVaccinationProtocol.create;
end;

function TFhirResourceFactory.newImmunization : TFhirImmunization;
begin
  result := TFhirImmunization.create;
end;

function TFhirResourceFactory.newImmunizationProfileRecommendation : TFhirImmunizationProfileRecommendation;
begin
  result := TFhirImmunizationProfileRecommendation.create;
end;

function TFhirResourceFactory.newImmunizationProfileRecommendationDateCriterion : TFhirImmunizationProfileRecommendationDateCriterion;
begin
  result := TFhirImmunizationProfileRecommendationDateCriterion.create;
end;

function TFhirResourceFactory.newImmunizationProfileRecommendationProtocol : TFhirImmunizationProfileRecommendationProtocol;
begin
  result := TFhirImmunizationProfileRecommendationProtocol.create;
end;

function TFhirResourceFactory.newImmunizationProfileRecommendationSupportingAdverseEventReport : TFhirImmunizationProfileRecommendationSupportingAdverseEventReport;
begin
  result := TFhirImmunizationProfileRecommendationSupportingAdverseEventReport.create;
end;

function TFhirResourceFactory.newImmunizationProfile : TFhirImmunizationProfile;
begin
  result := TFhirImmunizationProfile.create;
end;

function TFhirResourceFactory.newListEntry : TFhirListEntry;
begin
  result := TFhirListEntry.create;
end;

function TFhirResourceFactory.newList : TFhirList;
begin
  result := TFhirList.create;
end;

function TFhirResourceFactory.newLocationPosition : TFhirLocationPosition;
begin
  result := TFhirLocationPosition.create;
end;

function TFhirResourceFactory.newLocation : TFhirLocation;
begin
  result := TFhirLocation.create;
end;

function TFhirResourceFactory.newMedia : TFhirMedia;
begin
  result := TFhirMedia.create;
end;

function TFhirResourceFactory.newMedicationProduct : TFhirMedicationProduct;
begin
  result := TFhirMedicationProduct.create;
end;

function TFhirResourceFactory.newMedicationProductIngredient : TFhirMedicationProductIngredient;
begin
  result := TFhirMedicationProductIngredient.create;
end;

function TFhirResourceFactory.newMedicationPackage : TFhirMedicationPackage;
begin
  result := TFhirMedicationPackage.create;
end;

function TFhirResourceFactory.newMedicationPackageContent : TFhirMedicationPackageContent;
begin
  result := TFhirMedicationPackageContent.create;
end;

function TFhirResourceFactory.newMedication : TFhirMedication;
begin
  result := TFhirMedication.create;
end;

function TFhirResourceFactory.newMedicationAdministrationDosage : TFhirMedicationAdministrationDosage;
begin
  result := TFhirMedicationAdministrationDosage.create;
end;

function TFhirResourceFactory.newMedicationAdministration : TFhirMedicationAdministration;
begin
  result := TFhirMedicationAdministration.create;
end;

function TFhirResourceFactory.newMedicationDispenseDispense : TFhirMedicationDispenseDispense;
begin
  result := TFhirMedicationDispenseDispense.create;
end;

function TFhirResourceFactory.newMedicationDispenseDispenseDosage : TFhirMedicationDispenseDispenseDosage;
begin
  result := TFhirMedicationDispenseDispenseDosage.create;
end;

function TFhirResourceFactory.newMedicationDispenseSubstitution : TFhirMedicationDispenseSubstitution;
begin
  result := TFhirMedicationDispenseSubstitution.create;
end;

function TFhirResourceFactory.newMedicationDispense : TFhirMedicationDispense;
begin
  result := TFhirMedicationDispense.create;
end;

function TFhirResourceFactory.newMedicationPrescriptionDosageInstruction : TFhirMedicationPrescriptionDosageInstruction;
begin
  result := TFhirMedicationPrescriptionDosageInstruction.create;
end;

function TFhirResourceFactory.newMedicationPrescriptionDispense : TFhirMedicationPrescriptionDispense;
begin
  result := TFhirMedicationPrescriptionDispense.create;
end;

function TFhirResourceFactory.newMedicationPrescriptionSubstitution : TFhirMedicationPrescriptionSubstitution;
begin
  result := TFhirMedicationPrescriptionSubstitution.create;
end;

function TFhirResourceFactory.newMedicationPrescription : TFhirMedicationPrescription;
begin
  result := TFhirMedicationPrescription.create;
end;

function TFhirResourceFactory.newMedicationStatementDosage : TFhirMedicationStatementDosage;
begin
  result := TFhirMedicationStatementDosage.create;
end;

function TFhirResourceFactory.newMedicationStatement : TFhirMedicationStatement;
begin
  result := TFhirMedicationStatement.create;
end;

function TFhirResourceFactory.newMessageResponse : TFhirMessageResponse;
begin
  result := TFhirMessageResponse.create;
end;

function TFhirResourceFactory.newMessageSource : TFhirMessageSource;
begin
  result := TFhirMessageSource.create;
end;

function TFhirResourceFactory.newMessageDestination : TFhirMessageDestination;
begin
  result := TFhirMessageDestination.create;
end;

function TFhirResourceFactory.newMessage : TFhirMessage;
begin
  result := TFhirMessage.create;
end;

function TFhirResourceFactory.newObservationReferenceRange : TFhirObservationReferenceRange;
begin
  result := TFhirObservationReferenceRange.create;
end;

function TFhirResourceFactory.newObservationComponent : TFhirObservationComponent;
begin
  result := TFhirObservationComponent.create;
end;

function TFhirResourceFactory.newObservation : TFhirObservation;
begin
  result := TFhirObservation.create;
end;

function TFhirResourceFactory.newOperationOutcomeIssue : TFhirOperationOutcomeIssue;
begin
  result := TFhirOperationOutcomeIssue.create;
end;

function TFhirResourceFactory.newOperationOutcome : TFhirOperationOutcome;
begin
  result := TFhirOperationOutcome.create;
end;

function TFhirResourceFactory.newOrderWhen : TFhirOrderWhen;
begin
  result := TFhirOrderWhen.create;
end;

function TFhirResourceFactory.newOrder : TFhirOrder;
begin
  result := TFhirOrder.create;
end;

function TFhirResourceFactory.newOrderResponse : TFhirOrderResponse;
begin
  result := TFhirOrderResponse.create;
end;

function TFhirResourceFactory.newOrganizationContact : TFhirOrganizationContact;
begin
  result := TFhirOrganizationContact.create;
end;

function TFhirResourceFactory.newOrganization : TFhirOrganization;
begin
  result := TFhirOrganization.create;
end;

function TFhirResourceFactory.newOther : TFhirOther;
begin
  result := TFhirOther.create;
end;

function TFhirResourceFactory.newPatientContact : TFhirPatientContact;
begin
  result := TFhirPatientContact.create;
end;

function TFhirResourceFactory.newPatientAnimal : TFhirPatientAnimal;
begin
  result := TFhirPatientAnimal.create;
end;

function TFhirResourceFactory.newPatient : TFhirPatient;
begin
  result := TFhirPatient.create;
end;

function TFhirResourceFactory.newPractitionerQualification : TFhirPractitionerQualification;
begin
  result := TFhirPractitionerQualification.create;
end;

function TFhirResourceFactory.newPractitioner : TFhirPractitioner;
begin
  result := TFhirPractitioner.create;
end;

function TFhirResourceFactory.newProcedurePerformer : TFhirProcedurePerformer;
begin
  result := TFhirProcedurePerformer.create;
end;

function TFhirResourceFactory.newProcedureRelatedItem : TFhirProcedureRelatedItem;
begin
  result := TFhirProcedureRelatedItem.create;
end;

function TFhirResourceFactory.newProcedure : TFhirProcedure;
begin
  result := TFhirProcedure.create;
end;

function TFhirResourceFactory.newProfileStructure : TFhirProfileStructure;
begin
  result := TFhirProfileStructure.create;
end;

function TFhirResourceFactory.newProfileStructureElement : TFhirProfileStructureElement;
begin
  result := TFhirProfileStructureElement.create;
end;

function TFhirResourceFactory.newProfileStructureElementSlicing : TFhirProfileStructureElementSlicing;
begin
  result := TFhirProfileStructureElementSlicing.create;
end;

function TFhirResourceFactory.newProfileStructureElementDefinition : TFhirProfileStructureElementDefinition;
begin
  result := TFhirProfileStructureElementDefinition.create;
end;

function TFhirResourceFactory.newProfileStructureElementDefinitionType : TFhirProfileStructureElementDefinitionType;
begin
  result := TFhirProfileStructureElementDefinitionType.create;
end;

function TFhirResourceFactory.newProfileStructureElementDefinitionConstraint : TFhirProfileStructureElementDefinitionConstraint;
begin
  result := TFhirProfileStructureElementDefinitionConstraint.create;
end;

function TFhirResourceFactory.newProfileStructureElementDefinitionMapping : TFhirProfileStructureElementDefinitionMapping;
begin
  result := TFhirProfileStructureElementDefinitionMapping.create;
end;

function TFhirResourceFactory.newProfileExtensionDefn : TFhirProfileExtensionDefn;
begin
  result := TFhirProfileExtensionDefn.create;
end;

function TFhirResourceFactory.newProfileBinding : TFhirProfileBinding;
begin
  result := TFhirProfileBinding.create;
end;

function TFhirResourceFactory.newProfile : TFhirProfile;
begin
  result := TFhirProfile.create;
end;

function TFhirResourceFactory.newProvenanceAgent : TFhirProvenanceAgent;
begin
  result := TFhirProvenanceAgent.create;
end;

function TFhirResourceFactory.newProvenanceEntity : TFhirProvenanceEntity;
begin
  result := TFhirProvenanceEntity.create;
end;

function TFhirResourceFactory.newProvenance : TFhirProvenance;
begin
  result := TFhirProvenance.create;
end;

function TFhirResourceFactory.newQueryResponse : TFhirQueryResponse;
begin
  result := TFhirQueryResponse.create;
end;

function TFhirResourceFactory.newQuery : TFhirQuery;
begin
  result := TFhirQuery.create;
end;

function TFhirResourceFactory.newQuestionnaireQuestion : TFhirQuestionnaireQuestion;
begin
  result := TFhirQuestionnaireQuestion.create;
end;

function TFhirResourceFactory.newQuestionnaireGroup : TFhirQuestionnaireGroup;
begin
  result := TFhirQuestionnaireGroup.create;
end;

function TFhirResourceFactory.newQuestionnaire : TFhirQuestionnaire;
begin
  result := TFhirQuestionnaire.create;
end;

function TFhirResourceFactory.newRelatedPerson : TFhirRelatedPerson;
begin
  result := TFhirRelatedPerson.create;
end;

function TFhirResourceFactory.newSecurityEventEvent : TFhirSecurityEventEvent;
begin
  result := TFhirSecurityEventEvent.create;
end;

function TFhirResourceFactory.newSecurityEventParticipant : TFhirSecurityEventParticipant;
begin
  result := TFhirSecurityEventParticipant.create;
end;

function TFhirResourceFactory.newSecurityEventParticipantNetwork : TFhirSecurityEventParticipantNetwork;
begin
  result := TFhirSecurityEventParticipantNetwork.create;
end;

function TFhirResourceFactory.newSecurityEventSource : TFhirSecurityEventSource;
begin
  result := TFhirSecurityEventSource.create;
end;

function TFhirResourceFactory.newSecurityEventObject : TFhirSecurityEventObject;
begin
  result := TFhirSecurityEventObject.create;
end;

function TFhirResourceFactory.newSecurityEventObjectDetail : TFhirSecurityEventObjectDetail;
begin
  result := TFhirSecurityEventObjectDetail.create;
end;

function TFhirResourceFactory.newSecurityEvent : TFhirSecurityEvent;
begin
  result := TFhirSecurityEvent.create;
end;

function TFhirResourceFactory.newSpecimenSource : TFhirSpecimenSource;
begin
  result := TFhirSpecimenSource.create;
end;

function TFhirResourceFactory.newSpecimenCollection : TFhirSpecimenCollection;
begin
  result := TFhirSpecimenCollection.create;
end;

function TFhirResourceFactory.newSpecimenTreatment : TFhirSpecimenTreatment;
begin
  result := TFhirSpecimenTreatment.create;
end;

function TFhirResourceFactory.newSpecimenContainer : TFhirSpecimenContainer;
begin
  result := TFhirSpecimenContainer.create;
end;

function TFhirResourceFactory.newSpecimen : TFhirSpecimen;
begin
  result := TFhirSpecimen.create;
end;

function TFhirResourceFactory.newSubstance : TFhirSubstance;
begin
  result := TFhirSubstance.create;
end;

function TFhirResourceFactory.newSupplyDispense : TFhirSupplyDispense;
begin
  result := TFhirSupplyDispense.create;
end;

function TFhirResourceFactory.newSupply : TFhirSupply;
begin
  result := TFhirSupply.create;
end;

function TFhirResourceFactory.newValueSetDefine : TFhirValueSetDefine;
begin
  result := TFhirValueSetDefine.create;
end;

function TFhirResourceFactory.newValueSetDefineConcept : TFhirValueSetDefineConcept;
begin
  result := TFhirValueSetDefineConcept.create;
end;

function TFhirResourceFactory.newValueSetCompose : TFhirValueSetCompose;
begin
  result := TFhirValueSetCompose.create;
end;

function TFhirResourceFactory.newValueSetComposeInclude : TFhirValueSetComposeInclude;
begin
  result := TFhirValueSetComposeInclude.create;
end;

function TFhirResourceFactory.newValueSetComposeIncludeFilter : TFhirValueSetComposeIncludeFilter;
begin
  result := TFhirValueSetComposeIncludeFilter.create;
end;

function TFhirResourceFactory.newValueSetExpansion : TFhirValueSetExpansion;
begin
  result := TFhirValueSetExpansion.create;
end;

function TFhirResourceFactory.newValueSetExpansionContains : TFhirValueSetExpansionContains;
begin
  result := TFhirValueSetExpansionContains.create;
end;

function TFhirResourceFactory.newValueSet : TFhirValueSet;
begin
  result := TFhirValueSet.create;
end;


end.

