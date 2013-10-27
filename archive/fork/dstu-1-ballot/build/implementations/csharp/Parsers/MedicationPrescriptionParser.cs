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

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for MedicationPrescription instances
    /// </summary>
    internal static partial class MedicationPrescriptionParser
    {
        /// <summary>
        /// Parse MedicationPrescription
        /// </summary>
        public static Hl7.Fhir.Model.MedicationPrescription ParseMedicationPrescription(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.MedicationPrescription existingInstance = null )
        {
            Hl7.Fhir.Model.MedicationPrescription result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.MedicationPrescription();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element language
                else if( atName == "language" )
                    result.LanguageElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element text
                else if( atName == "text" )
                    result.Text = NarrativeParser.ParseNarrative(reader, errors);
                
                // Parse element contained
                else if( atName == "contained" )
                {
                    result.Contained = new List<Hl7.Fhir.Model.Resource>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "contained") )
                        result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element identifier
                else if( atName == "identifier" )
                {
                    result.Identifier = new List<Hl7.Fhir.Model.Identifier>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                        result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element dateWritten
                else if( atName == "dateWritten" )
                    result.DateWrittenElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionStatus>(reader, errors);
                
                // Parse element patient
                else if( atName == "patient" )
                    result.Patient = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element prescriber
                else if( atName == "prescriber" )
                    result.Prescriber = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element encounter
                else if( atName == "encounter" )
                    result.Encounter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element reasonForPrescribing
                else if( atName.StartsWith("reasonForPrescribing") )
                    result.ReasonForPrescribing = FhirParser.ParseElement(reader, errors);
                
                // Parse element medication
                else if( atName == "medication" )
                    result.Medication = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element dosageInstruction
                else if( atName == "dosageInstruction" )
                {
                    result.DosageInstruction = new List<Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDosageInstructionComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "dosageInstruction") )
                        result.DosageInstruction.Add(MedicationPrescriptionParser.ParseMedicationPrescriptionDosageInstructionComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element dispense
                else if( atName == "dispense" )
                    result.Dispense = MedicationPrescriptionParser.ParseMedicationPrescriptionDispenseComponent(reader, errors);
                
                // Parse element substitution
                else if( atName == "substitution" )
                    result.Substitution = MedicationPrescriptionParser.ParseMedicationPrescriptionSubstitutionComponent(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse MedicationPrescriptionDosageInstructionComponent
        /// </summary>
        public static Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDosageInstructionComponent ParseMedicationPrescriptionDosageInstructionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDosageInstructionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDosageInstructionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDosageInstructionComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element dosageInstructionsText
                else if( atName == "dosageInstructionsText" )
                    result.DosageInstructionsTextElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element additionalInstructions
                else if( atName.StartsWith("additionalInstructions") )
                    result.AdditionalInstructions = FhirParser.ParseElement(reader, errors);
                
                // Parse element timing
                else if( atName.StartsWith("timing") )
                    result.Timing = FhirParser.ParseElement(reader, errors);
                
                // Parse element site
                else if( atName == "site" )
                    result.Site = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element route
                else if( atName == "route" )
                    result.Route = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element method
                else if( atName == "method" )
                    result.Method = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element doseQuantity
                else if( atName == "doseQuantity" )
                    result.DoseQuantity = QuantityParser.ParseQuantity(reader, errors);
                
                // Parse element rate
                else if( atName == "rate" )
                    result.Rate = RatioParser.ParseRatio(reader, errors);
                
                // Parse element maxDosePerPeriod
                else if( atName == "maxDosePerPeriod" )
                    result.MaxDosePerPeriod = RatioParser.ParseRatio(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse MedicationPrescriptionSubstitutionComponent
        /// </summary>
        public static Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionSubstitutionComponent ParseMedicationPrescriptionSubstitutionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionSubstitutionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionSubstitutionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionSubstitutionComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element reason
                else if( atName == "reason" )
                    result.Reason = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse MedicationPrescriptionDispenseComponent
        /// </summary>
        public static Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDispenseComponent ParseMedicationPrescriptionDispenseComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDispenseComponent existingInstance = null )
        {
            Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDispenseComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.MedicationPrescription.MedicationPrescriptionDispenseComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element medication
                else if( atName == "medication" )
                    result.Medication = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element validityPeriod
                else if( atName == "validityPeriod" )
                    result.ValidityPeriod = PeriodParser.ParsePeriod(reader, errors);
                
                // Parse element numberOfRepeatsAllowed
                else if( atName == "numberOfRepeatsAllowed" )
                    result.NumberOfRepeatsAllowedElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element quantity
                else if( atName == "quantity" )
                    result.Quantity = QuantityParser.ParseQuantity(reader, errors);
                
                // Parse element expectedSupplyDuration
                else if( atName == "expectedSupplyDuration" )
                    result.ExpectedSupplyDuration = DurationParser.ParseDuration(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
    }
}
