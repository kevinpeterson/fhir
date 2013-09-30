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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Used to specify why the normally expected content of the data element is missing
    /// </summary>
    public enum DataAbsentReason
    {
        Unknown, // The value is not known
        Asked, // The source human does not know the value
        Temp, // There is reason to expect (from the workflow) that the value may become known
        Notasked, // The workflow didn't lead to this value being known
        Masked, // The information is not available due to security, privacy or related reasons
        Unsupported, // The source system wasn't capable of supporting this element
        Astext, // The content of the data is represented as text
        Error, // Some system or workflow process error means that the information is not available
    }
    
    /// <summary>
    /// Conversion of DataAbsentReasonfrom and into string
    /// <summary>
    public static class DataAbsentReasonHandling
    {
        public static bool TryParse(string value, out DataAbsentReason result)
        {
            result = default(DataAbsentReason);
            
            if( value=="unknown")
                result = DataAbsentReason.Unknown;
            else if( value=="asked")
                result = DataAbsentReason.Asked;
            else if( value=="temp")
                result = DataAbsentReason.Temp;
            else if( value=="notasked")
                result = DataAbsentReason.Notasked;
            else if( value=="masked")
                result = DataAbsentReason.Masked;
            else if( value=="unsupported")
                result = DataAbsentReason.Unsupported;
            else if( value=="astext")
                result = DataAbsentReason.Astext;
            else if( value=="error")
                result = DataAbsentReason.Error;
            else
                return false;
            
            return true;
        }
        
        public static string ToString(DataAbsentReason value)
        {
            if( value==DataAbsentReason.Unknown )
                return "unknown";
            else if( value==DataAbsentReason.Asked )
                return "asked";
            else if( value==DataAbsentReason.Temp )
                return "temp";
            else if( value==DataAbsentReason.Notasked )
                return "notasked";
            else if( value==DataAbsentReason.Masked )
                return "masked";
            else if( value==DataAbsentReason.Unsupported )
                return "unsupported";
            else if( value==DataAbsentReason.Astext )
                return "astext";
            else if( value==DataAbsentReason.Error )
                return "error";
            else
                throw new ArgumentException("Unrecognized DataAbsentReason value: " + value.ToString());
        }
    }
    
    /// <summary>
    /// Codes providing the status of an observation
    /// </summary>
    public enum ObservationStatus
    {
        Registered, // The existence of the observation is registered, but there is no result yet available
        Interim, // This is an initial or interim observation: data may be incomplete or unverified
        Final, // The observation is complete and verified by an authorised person
        Amended, // The observation has been modified subsequent to being Final, and is complete and verified by an authorised person
        Cancelled, // The observation is unavailable because the measurement was not started or not completed (also sometimes called "aborted")
        Withdrawn, // The observation has been withdrawn following previous Final release
    }
    
    /// <summary>
    /// Conversion of ObservationStatusfrom and into string
    /// <summary>
    public static class ObservationStatusHandling
    {
        public static bool TryParse(string value, out ObservationStatus result)
        {
            result = default(ObservationStatus);
            
            if( value=="registered")
                result = ObservationStatus.Registered;
            else if( value=="interim")
                result = ObservationStatus.Interim;
            else if( value=="final")
                result = ObservationStatus.Final;
            else if( value=="amended")
                result = ObservationStatus.Amended;
            else if( value=="cancelled")
                result = ObservationStatus.Cancelled;
            else if( value=="withdrawn")
                result = ObservationStatus.Withdrawn;
            else
                return false;
            
            return true;
        }
        
        public static string ToString(ObservationStatus value)
        {
            if( value==ObservationStatus.Registered )
                return "registered";
            else if( value==ObservationStatus.Interim )
                return "interim";
            else if( value==ObservationStatus.Final )
                return "final";
            else if( value==ObservationStatus.Amended )
                return "amended";
            else if( value==ObservationStatus.Cancelled )
                return "cancelled";
            else if( value==ObservationStatus.Withdrawn )
                return "withdrawn";
            else
                throw new ArgumentException("Unrecognized ObservationStatus value: " + value.ToString());
        }
    }
    
    /// <summary>
    /// A set of generally useful codes defined so they can be included in value sets
    /// </summary>
    public enum SpecialValues
    {
        True, // Boolean true
        False, // Boolean false
        Trace, // The content is greater than zero, but too small to be quantified
        Sufficient, // The specific quantity is not known, but is known to be non-zero and is not specified because it makes up the bulk of the material
        Withdrawn, // The value is no longer available
        NilKnown, // The are no known applicable values in this context
    }
    
    /// <summary>
    /// Conversion of SpecialValuesfrom and into string
    /// <summary>
    public static class SpecialValuesHandling
    {
        public static bool TryParse(string value, out SpecialValues result)
        {
            result = default(SpecialValues);
            
            if( value=="true")
                result = SpecialValues.True;
            else if( value=="false")
                result = SpecialValues.False;
            else if( value=="trace")
                result = SpecialValues.Trace;
            else if( value=="sufficient")
                result = SpecialValues.Sufficient;
            else if( value=="withdrawn")
                result = SpecialValues.Withdrawn;
            else if( value=="nil known")
                result = SpecialValues.NilKnown;
            else
                return false;
            
            return true;
        }
        
        public static string ToString(SpecialValues value)
        {
            if( value==SpecialValues.True )
                return "true";
            else if( value==SpecialValues.False )
                return "false";
            else if( value==SpecialValues.Trace )
                return "trace";
            else if( value==SpecialValues.Sufficient )
                return "sufficient";
            else if( value==SpecialValues.Withdrawn )
                return "withdrawn";
            else if( value==SpecialValues.NilKnown )
                return "nil known";
            else
                throw new ArgumentException("Unrecognized SpecialValues value: " + value.ToString());
        }
    }
    
    /// <summary>
    /// List of all supported FHIR Resources
    /// </summary>
    public enum ResourceType
    {
        Resource, // The Resource resource
        AdverseReaction, // The AdverseReaction resource
        Alert, // The Alert resource
        AllergyIntolerance, // The AllergyIntolerance resource
        CarePlan, // The CarePlan resource
        Condition, // The Condition resource
        Conformance, // The Conformance resource
        Coverage, // The Coverage resource
        Device, // The Device resource
        DeviceCapabilities, // The DeviceCapabilities resource
        DeviceLog, // The DeviceLog resource
        DeviceObservation, // The DeviceObservation resource
        DiagnosticOrder, // The DiagnosticOrder resource
        DiagnosticReport, // The DiagnosticReport resource
        Document, // The Document resource
        DocumentReference, // The DocumentReference resource
        Encounter, // The Encounter resource
        FamilyHistory, // The FamilyHistory resource
        Group, // The Group resource
        ImagingStudy, // The ImagingStudy resource
        Immunization, // The Immunization resource
        ImmunizationProfile, // The ImmunizationProfile resource
        List, // The List resource
        Location, // The Location resource
        Media, // The Media resource
        Medication, // The Medication resource
        MedicationAdministration, // The MedicationAdministration resource
        MedicationDispense, // The MedicationDispense resource
        MedicationPrescription, // The MedicationPrescription resource
        MedicationStatement, // The MedicationStatement resource
        Message, // The Message resource
        Observation, // The Observation resource
        OperationOutcome, // The OperationOutcome resource
        Order, // The Order resource
        OrderResponse, // The OrderResponse resource
        Organization, // The Organization resource
        Other, // The Other resource
        Patient, // The Patient resource
        Practitioner, // The Practitioner resource
        Procedure, // The Procedure resource
        Profile, // The Profile resource
        Provenance, // The Provenance resource
        Query, // The Query resource
        Questionnaire, // The Questionnaire resource
        RelatedPerson, // The RelatedPerson resource
        SecurityEvent, // The SecurityEvent resource
        Specimen, // The Specimen resource
        Substance, // The Substance resource
        Supply, // The Supply resource
        ValueSet, // The ValueSet resource
        Binary, // The Binary resource
        Appointment, // The Appointment resource
        InterestOfCare, // The InterestOfCare resource
    }
    
    /// <summary>
    /// Conversion of ResourceTypefrom and into string
    /// <summary>
    public static class ResourceTypeHandling
    {
        public static bool TryParse(string value, out ResourceType result)
        {
            result = default(ResourceType);
            
            if( value=="Resource")
                result = ResourceType.Resource;
            else if( value=="AdverseReaction")
                result = ResourceType.AdverseReaction;
            else if( value=="Alert")
                result = ResourceType.Alert;
            else if( value=="AllergyIntolerance")
                result = ResourceType.AllergyIntolerance;
            else if( value=="CarePlan")
                result = ResourceType.CarePlan;
            else if( value=="Condition")
                result = ResourceType.Condition;
            else if( value=="Conformance")
                result = ResourceType.Conformance;
            else if( value=="Coverage")
                result = ResourceType.Coverage;
            else if( value=="Device")
                result = ResourceType.Device;
            else if( value=="DeviceCapabilities")
                result = ResourceType.DeviceCapabilities;
            else if( value=="DeviceLog")
                result = ResourceType.DeviceLog;
            else if( value=="DeviceObservation")
                result = ResourceType.DeviceObservation;
            else if( value=="DiagnosticOrder")
                result = ResourceType.DiagnosticOrder;
            else if( value=="DiagnosticReport")
                result = ResourceType.DiagnosticReport;
            else if( value=="Document")
                result = ResourceType.Document;
            else if( value=="DocumentReference")
                result = ResourceType.DocumentReference;
            else if( value=="Encounter")
                result = ResourceType.Encounter;
            else if( value=="FamilyHistory")
                result = ResourceType.FamilyHistory;
            else if( value=="Group")
                result = ResourceType.Group;
            else if( value=="ImagingStudy")
                result = ResourceType.ImagingStudy;
            else if( value=="Immunization")
                result = ResourceType.Immunization;
            else if( value=="ImmunizationProfile")
                result = ResourceType.ImmunizationProfile;
            else if( value=="List")
                result = ResourceType.List;
            else if( value=="Location")
                result = ResourceType.Location;
            else if( value=="Media")
                result = ResourceType.Media;
            else if( value=="Medication")
                result = ResourceType.Medication;
            else if( value=="MedicationAdministration")
                result = ResourceType.MedicationAdministration;
            else if( value=="MedicationDispense")
                result = ResourceType.MedicationDispense;
            else if( value=="MedicationPrescription")
                result = ResourceType.MedicationPrescription;
            else if( value=="MedicationStatement")
                result = ResourceType.MedicationStatement;
            else if( value=="Message")
                result = ResourceType.Message;
            else if( value=="Observation")
                result = ResourceType.Observation;
            else if( value=="OperationOutcome")
                result = ResourceType.OperationOutcome;
            else if( value=="Order")
                result = ResourceType.Order;
            else if( value=="OrderResponse")
                result = ResourceType.OrderResponse;
            else if( value=="Organization")
                result = ResourceType.Organization;
            else if( value=="Other")
                result = ResourceType.Other;
            else if( value=="Patient")
                result = ResourceType.Patient;
            else if( value=="Practitioner")
                result = ResourceType.Practitioner;
            else if( value=="Procedure")
                result = ResourceType.Procedure;
            else if( value=="Profile")
                result = ResourceType.Profile;
            else if( value=="Provenance")
                result = ResourceType.Provenance;
            else if( value=="Query")
                result = ResourceType.Query;
            else if( value=="Questionnaire")
                result = ResourceType.Questionnaire;
            else if( value=="RelatedPerson")
                result = ResourceType.RelatedPerson;
            else if( value=="SecurityEvent")
                result = ResourceType.SecurityEvent;
            else if( value=="Specimen")
                result = ResourceType.Specimen;
            else if( value=="Substance")
                result = ResourceType.Substance;
            else if( value=="Supply")
                result = ResourceType.Supply;
            else if( value=="ValueSet")
                result = ResourceType.ValueSet;
            else if( value=="Binary")
                result = ResourceType.Binary;
            else if( value=="Appointment")
                result = ResourceType.Appointment;
            else if( value=="InterestOfCare")
                result = ResourceType.InterestOfCare;
            else
                return false;
            
            return true;
        }
        
        public static string ToString(ResourceType value)
        {
            if( value==ResourceType.Resource )
                return "Resource";
            else if( value==ResourceType.AdverseReaction )
                return "AdverseReaction";
            else if( value==ResourceType.Alert )
                return "Alert";
            else if( value==ResourceType.AllergyIntolerance )
                return "AllergyIntolerance";
            else if( value==ResourceType.CarePlan )
                return "CarePlan";
            else if( value==ResourceType.Condition )
                return "Condition";
            else if( value==ResourceType.Conformance )
                return "Conformance";
            else if( value==ResourceType.Coverage )
                return "Coverage";
            else if( value==ResourceType.Device )
                return "Device";
            else if( value==ResourceType.DeviceCapabilities )
                return "DeviceCapabilities";
            else if( value==ResourceType.DeviceLog )
                return "DeviceLog";
            else if( value==ResourceType.DeviceObservation )
                return "DeviceObservation";
            else if( value==ResourceType.DiagnosticOrder )
                return "DiagnosticOrder";
            else if( value==ResourceType.DiagnosticReport )
                return "DiagnosticReport";
            else if( value==ResourceType.Document )
                return "Document";
            else if( value==ResourceType.DocumentReference )
                return "DocumentReference";
            else if( value==ResourceType.Encounter )
                return "Encounter";
            else if( value==ResourceType.FamilyHistory )
                return "FamilyHistory";
            else if( value==ResourceType.Group )
                return "Group";
            else if( value==ResourceType.ImagingStudy )
                return "ImagingStudy";
            else if( value==ResourceType.Immunization )
                return "Immunization";
            else if( value==ResourceType.ImmunizationProfile )
                return "ImmunizationProfile";
            else if( value==ResourceType.List )
                return "List";
            else if( value==ResourceType.Location )
                return "Location";
            else if( value==ResourceType.Media )
                return "Media";
            else if( value==ResourceType.Medication )
                return "Medication";
            else if( value==ResourceType.MedicationAdministration )
                return "MedicationAdministration";
            else if( value==ResourceType.MedicationDispense )
                return "MedicationDispense";
            else if( value==ResourceType.MedicationPrescription )
                return "MedicationPrescription";
            else if( value==ResourceType.MedicationStatement )
                return "MedicationStatement";
            else if( value==ResourceType.Message )
                return "Message";
            else if( value==ResourceType.Observation )
                return "Observation";
            else if( value==ResourceType.OperationOutcome )
                return "OperationOutcome";
            else if( value==ResourceType.Order )
                return "Order";
            else if( value==ResourceType.OrderResponse )
                return "OrderResponse";
            else if( value==ResourceType.Organization )
                return "Organization";
            else if( value==ResourceType.Other )
                return "Other";
            else if( value==ResourceType.Patient )
                return "Patient";
            else if( value==ResourceType.Practitioner )
                return "Practitioner";
            else if( value==ResourceType.Procedure )
                return "Procedure";
            else if( value==ResourceType.Profile )
                return "Profile";
            else if( value==ResourceType.Provenance )
                return "Provenance";
            else if( value==ResourceType.Query )
                return "Query";
            else if( value==ResourceType.Questionnaire )
                return "Questionnaire";
            else if( value==ResourceType.RelatedPerson )
                return "RelatedPerson";
            else if( value==ResourceType.SecurityEvent )
                return "SecurityEvent";
            else if( value==ResourceType.Specimen )
                return "Specimen";
            else if( value==ResourceType.Substance )
                return "Substance";
            else if( value==ResourceType.Supply )
                return "Supply";
            else if( value==ResourceType.ValueSet )
                return "ValueSet";
            else if( value==ResourceType.Binary )
                return "Binary";
            else if( value==ResourceType.Appointment )
                return "Appointment";
            else if( value==ResourceType.InterestOfCare )
                return "InterestOfCare";
            else
                throw new ArgumentException("Unrecognized ResourceType value: " + value.ToString());
        }
    }
    
}
