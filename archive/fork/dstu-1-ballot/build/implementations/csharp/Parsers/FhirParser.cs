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

namespace Hl7.Fhir.Parsers
{
    /*
    * Starting point for parsing resources
    */
    public static partial class FhirParser
    {
        internal static Resource ParseResource(IFhirReader reader, ErrorList errors)
        {
            try
            {
                reader.MoveToContent();
                
                if( ParserUtils.IsAtFhirElement(reader, "AdverseReaction" ) )
                    return AdverseReactionParser.ParseAdverseReaction(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Alert" ) )
                    return AlertParser.ParseAlert(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "AllergyIntolerance" ) )
                    return AllergyIntoleranceParser.ParseAllergyIntolerance(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "CarePlan" ) )
                    return CarePlanParser.ParseCarePlan(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Condition" ) )
                    return ConditionParser.ParseCondition(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Conformance" ) )
                    return ConformanceParser.ParseConformance(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Coverage" ) )
                    return CoverageParser.ParseCoverage(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Device" ) )
                    return DeviceParser.ParseDevice(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "DeviceCapabilities" ) )
                    return DeviceCapabilitiesParser.ParseDeviceCapabilities(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "DeviceLog" ) )
                    return DeviceLogParser.ParseDeviceLog(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "DeviceObservation" ) )
                    return DeviceObservationParser.ParseDeviceObservation(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "DiagnosticOrder" ) )
                    return DiagnosticOrderParser.ParseDiagnosticOrder(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "DiagnosticReport" ) )
                    return DiagnosticReportParser.ParseDiagnosticReport(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Document" ) )
                    return DocumentParser.ParseDocument(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "DocumentReference" ) )
                    return DocumentReferenceParser.ParseDocumentReference(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Encounter" ) )
                    return EncounterParser.ParseEncounter(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "FamilyHistory" ) )
                    return FamilyHistoryParser.ParseFamilyHistory(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Group" ) )
                    return GroupParser.ParseGroup(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "ImagingStudy" ) )
                    return ImagingStudyParser.ParseImagingStudy(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Immunization" ) )
                    return ImmunizationParser.ParseImmunization(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "ImmunizationProfile" ) )
                    return ImmunizationProfileParser.ParseImmunizationProfile(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "List" ) )
                    return ListParser.ParseList(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Location" ) )
                    return LocationParser.ParseLocation(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Media" ) )
                    return MediaParser.ParseMedia(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Medication" ) )
                    return MedicationParser.ParseMedication(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "MedicationAdministration" ) )
                    return MedicationAdministrationParser.ParseMedicationAdministration(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "MedicationDispense" ) )
                    return MedicationDispenseParser.ParseMedicationDispense(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "MedicationPrescription" ) )
                    return MedicationPrescriptionParser.ParseMedicationPrescription(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "MedicationStatement" ) )
                    return MedicationStatementParser.ParseMedicationStatement(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Message" ) )
                    return MessageParser.ParseMessage(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Observation" ) )
                    return ObservationParser.ParseObservation(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "OperationOutcome" ) )
                    return OperationOutcomeParser.ParseOperationOutcome(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Order" ) )
                    return OrderParser.ParseOrder(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "OrderResponse" ) )
                    return OrderResponseParser.ParseOrderResponse(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Organization" ) )
                    return OrganizationParser.ParseOrganization(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Other" ) )
                    return OtherParser.ParseOther(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Patient" ) )
                    return PatientParser.ParsePatient(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Practitioner" ) )
                    return PractitionerParser.ParsePractitioner(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Procedure" ) )
                    return ProcedureParser.ParseProcedure(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Profile" ) )
                    return ProfileParser.ParseProfile(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Provenance" ) )
                    return ProvenanceParser.ParseProvenance(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Query" ) )
                    return QueryParser.ParseQuery(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Questionnaire" ) )
                    return QuestionnaireParser.ParseQuestionnaire(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "RelatedPerson" ) )
                    return RelatedPersonParser.ParseRelatedPerson(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "SecurityEvent" ) )
                    return SecurityEventParser.ParseSecurityEvent(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Specimen" ) )
                    return SpecimenParser.ParseSpecimen(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Substance" ) )
                    return SubstanceParser.ParseSubstance(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Supply" ) )
                    return SupplyParser.ParseSupply(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "ValueSet" ) )
                    return ValueSetParser.ParseValueSet(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Binary" ) )
                    return BinaryParser.ParseBinary(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "Appointment" ) )
                    return AppointmentParser.ParseAppointment(reader, errors);
                else if( ParserUtils.IsAtFhirElement(reader, "InterestOfCare" ) )
                    return InterestOfCareParser.ParseInterestOfCare(reader, errors);
                else
                {
                    errors.Add(String.Format("Encountered unrecognized resource '{0}'",	reader.CurrentElementName), reader);
                    reader.SkipSubElementsFor(reader.CurrentElementName);
                    return null;
                }
            }
            catch( Exception xe )
            {
                errors.Add( xe.Message, reader);
                return null;
            }
        }
        
        internal static Element ParseElement(IFhirReader reader, ErrorList errors)
        {
            try
            {
                reader.MoveToContent();
                
                if( ParserUtils.IsAtFhirElementEndingWith(reader, "Age" ))
                    return AgeParser.ParseAge(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Count" ))
                    return CountParser.ParseCount(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Distance" ))
                    return DistanceParser.ParseDistance(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Duration" ))
                    return DurationParser.ParseDuration(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Money" ))
                    return MoneyParser.ParseMoney(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Address" ))
                    return AddressParser.ParseAddress(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Attachment" ))
                    return AttachmentParser.ParseAttachment(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Choice" ))
                    return ChoiceParser.ParseChoice(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "CodeableConcept" ))
                    return CodeableConceptParser.ParseCodeableConcept(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Coding" ))
                    return CodingParser.ParseCoding(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Contact" ))
                    return ContactParser.ParseContact(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Extension" ))
                    return ExtensionParser.ParseExtension(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "HumanName" ))
                    return HumanNameParser.ParseHumanName(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Identifier" ))
                    return IdentifierParser.ParseIdentifier(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Narrative" ))
                    return NarrativeParser.ParseNarrative(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Period" ))
                    return PeriodParser.ParsePeriod(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Quantity" ))
                    return QuantityParser.ParseQuantity(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Range" ))
                    return RangeParser.ParseRange(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Ratio" ))
                    return RatioParser.ParseRatio(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Resource" ))
                    return ResourceReferenceParser.ParseResourceReference(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "SampledData" ))
                    return SampledDataParser.ParseSampledData(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Schedule" ))
                    return ScheduleParser.ParseSchedule(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Base64Binary" ))
                    return Base64BinaryParser.ParseBase64Binary(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Boolean" ))
                    return FhirBooleanParser.ParseFhirBoolean(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Code" ))
                    return CodeParser.ParseCode(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Date" ))
                    return DateParser.ParseDate(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "DateTime" ))
                    return FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Decimal" ))
                    return FhirDecimalParser.ParseFhirDecimal(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Id" ))
                    return IdParser.ParseId(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Idref" ))
                    return IdRefParser.ParseIdRef(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Instant" ))
                    return InstantParser.ParseInstant(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Integer" ))
                    return IntegerParser.ParseInteger(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Oid" ))
                    return OidParser.ParseOid(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "String" ))
                    return FhirStringParser.ParseFhirString(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Uri" ))
                    return FhirUriParser.ParseFhirUri(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Uuid" ))
                    return UuidParser.ParseUuid(reader, errors);
                else if( ParserUtils.IsAtFhirElementEndingWith(reader, "Xhtml" ))
                    return XHtmlParser.ParseXHtml(reader, errors);
                else
                {
                    errors.Add(String.Format("Encountered unrecognized datatype '{0}'",	reader.CurrentElementName), reader);
                    reader.SkipSubElementsFor(reader.CurrentElementName);
                    return null;
                }
            }
            catch( Exception xe )
            {
                errors.Add( xe.Message, reader);
                return null;
            }
        }
    }
}
