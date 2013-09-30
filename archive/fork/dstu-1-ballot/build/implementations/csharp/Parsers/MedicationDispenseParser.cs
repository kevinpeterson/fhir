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
    /// <summary>
    /// Parser for MedicationDispense instances
    /// </summary>
    internal static partial class MedicationDispenseParser
    {
        /// <summary>
        /// Parse MedicationDispense
        /// </summary>
        public static Hl7.Fhir.Model.MedicationDispense ParseMedicationDispense(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.MedicationDispense existingInstance = null )
        {
            Hl7.Fhir.Model.MedicationDispense result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.MedicationDispense();
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
                    result.Identifier = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus>(reader, errors);
                
                // Parse element patient
                else if( atName == "patient" )
                    result.Patient = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element dispenser
                else if( atName == "dispenser" )
                    result.Dispenser = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element authorizingPrescription
                else if( atName == "authorizingPrescription" )
                {
                    result.AuthorizingPrescription = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "authorizingPrescription") )
                        result.AuthorizingPrescription.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element dispense
                else if( atName == "dispense" )
                {
                    result.Dispense = new List<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "dispense") )
                        result.Dispense.Add(MedicationDispenseParser.ParseMedicationDispenseDispenseComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element substitution
                else if( atName == "substitution" )
                    result.Substitution = MedicationDispenseParser.ParseMedicationDispenseSubstitutionComponent(reader, errors);
                
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
        /// Parse MedicationDispenseDispenseDosageComponent
        /// </summary>
        public static Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseDosageComponent ParseMedicationDispenseDispenseDosageComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseDosageComponent existingInstance = null )
        {
            Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseDosageComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseDosageComponent();
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
                
                // Parse element quantity
                else if( atName == "quantity" )
                    result.Quantity = QuantityParser.ParseQuantity(reader, errors);
                
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
        /// Parse MedicationDispenseSubstitutionComponent
        /// </summary>
        public static Hl7.Fhir.Model.MedicationDispense.MedicationDispenseSubstitutionComponent ParseMedicationDispenseSubstitutionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.MedicationDispense.MedicationDispenseSubstitutionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.MedicationDispense.MedicationDispenseSubstitutionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.MedicationDispense.MedicationDispenseSubstitutionComponent();
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
                {
                    result.Reason = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "reason") )
                        result.Reason.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element responsibleParty
                else if( atName == "responsibleParty" )
                {
                    result.ResponsibleParty = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "responsibleParty") )
                        result.ResponsibleParty.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
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
        /// Parse MedicationDispenseDispenseComponent
        /// </summary>
        public static Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseComponent ParseMedicationDispenseDispenseComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseComponent existingInstance = null )
        {
            Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseComponent();
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
                
                // Parse element identifier
                else if( atName == "identifier" )
                    result.Identifier = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseStatus>(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element quantity
                else if( atName == "quantity" )
                    result.Quantity = QuantityParser.ParseQuantity(reader, errors);
                
                // Parse element medication
                else if( atName == "medication" )
                    result.Medication = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element whenPrepared
                else if( atName == "whenPrepared" )
                    result.WhenPrepared = PeriodParser.ParsePeriod(reader, errors);
                
                // Parse element whenHandedOver
                else if( atName == "whenHandedOver" )
                    result.WhenHandedOver = PeriodParser.ParsePeriod(reader, errors);
                
                // Parse element destination
                else if( atName == "destination" )
                    result.Destination = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element receiver
                else if( atName == "receiver" )
                {
                    result.Receiver = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "receiver") )
                        result.Receiver.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element dosage
                else if( atName == "dosage" )
                {
                    result.Dosage = new List<Hl7.Fhir.Model.MedicationDispense.MedicationDispenseDispenseDosageComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "dosage") )
                        result.Dosage.Add(MedicationDispenseParser.ParseMedicationDispenseDispenseDosageComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
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
