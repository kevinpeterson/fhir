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

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Prescription instances
    /// </summary>
    internal static partial class PrescriptionParser
    {
        /// <summary>
        /// Parse Prescription
        /// </summary>
        public static Prescription ParsePrescription(IFhirReader reader, ErrorList errors, Prescription existingInstance = null )
        {
            Prescription result = existingInstance != null ? existingInstance : new Prescription();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element language
                    else if( ParserUtils.IsAtFhirElement(reader, "language") )
                        result.Language = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element text
                    else if( ParserUtils.IsAtFhirElement(reader, "text") )
                        result.Text = NarrativeParser.ParseNarrative(reader, errors);
                    
                    // Parse element contained
                    else if( ParserUtils.IsAtFhirElement(reader, "contained") )
                    {
                        result.Contained = new List<Resource>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "contained") )
                            result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                    {
                        result.Identifier = new List<Identifier>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                            result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = CodeParser.ParseCode<Prescription.PrescriptionStatus>(reader, errors);
                    
                    // Parse element patient
                    else if( ParserUtils.IsAtFhirElement(reader, "patient") )
                        result.Patient = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element prescriber
                    else if( ParserUtils.IsAtFhirElement(reader, "prescriber") )
                        result.Prescriber = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element prescribed
                    else if( ParserUtils.IsAtFhirElement(reader, "prescribed") )
                        result.Prescribed = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element dispense
                    else if( ParserUtils.IsAtFhirElement(reader, "dispense") )
                        result.Dispense = PrescriptionParser.ParsePrescriptionDispenseComponent(reader, errors);
                    
                    // Parse element medicine
                    else if( ParserUtils.IsAtFhirElement(reader, "medicine") )
                        result.Medicine = PrescriptionParser.ParsePrescriptionMedicineComponent(reader, errors);
                    
                    // Parse element administrationRequest
                    else if( ParserUtils.IsAtFhirElement(reader, "administrationRequest") )
                        result.AdministrationRequest = PrescriptionParser.ParsePrescriptionAdministrationRequestComponent(reader, errors);
                    
                    // Parse element reason
                    else if( ParserUtils.IsAtFhirElement(reader, "reason") )
                        result.Reason = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse PrescriptionDispenseComponent
        /// </summary>
        public static Prescription.PrescriptionDispenseComponent ParsePrescriptionDispenseComponent(IFhirReader reader, ErrorList errors, Prescription.PrescriptionDispenseComponent existingInstance = null )
        {
            Prescription.PrescriptionDispenseComponent result = existingInstance != null ? existingInstance : new Prescription.PrescriptionDispenseComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element repeats
                    else if( ParserUtils.IsAtFhirElement(reader, "repeats") )
                        result.Repeats = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element quantity
                    else if( ParserUtils.IsAtFhirElement(reader, "quantity") )
                        result.Quantity = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element dispenser
                    else if( ParserUtils.IsAtFhirElement(reader, "dispenser") )
                        result.Dispenser = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse PrescriptionMedicineActiveIngredientComponent
        /// </summary>
        public static Prescription.PrescriptionMedicineActiveIngredientComponent ParsePrescriptionMedicineActiveIngredientComponent(IFhirReader reader, ErrorList errors, Prescription.PrescriptionMedicineActiveIngredientComponent existingInstance = null )
        {
            Prescription.PrescriptionMedicineActiveIngredientComponent result = existingInstance != null ? existingInstance : new Prescription.PrescriptionMedicineActiveIngredientComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element identification
                    else if( ParserUtils.IsAtFhirElement(reader, "identification") )
                        result.Identification = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element quantity
                    else if( ParserUtils.IsAtFhirElement(reader, "quantity", true) )
                        result.Quantity = FhirParser.ParseElement(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse PrescriptionAdministrationRequestComponent
        /// </summary>
        public static Prescription.PrescriptionAdministrationRequestComponent ParsePrescriptionAdministrationRequestComponent(IFhirReader reader, ErrorList errors, Prescription.PrescriptionAdministrationRequestComponent existingInstance = null )
        {
            Prescription.PrescriptionAdministrationRequestComponent result = existingInstance != null ? existingInstance : new Prescription.PrescriptionAdministrationRequestComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element totalPeriodicDose
                    else if( ParserUtils.IsAtFhirElement(reader, "totalPeriodicDose") )
                        result.TotalPeriodicDose = RatioParser.ParseRatio(reader, errors);
                    
                    // Parse element start
                    else if( ParserUtils.IsAtFhirElement(reader, "start") )
                        result.Start = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element end
                    else if( ParserUtils.IsAtFhirElement(reader, "end") )
                        result.End = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element duration
                    else if( ParserUtils.IsAtFhirElement(reader, "duration") )
                        result.Duration = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element numberOfAdministrations
                    else if( ParserUtils.IsAtFhirElement(reader, "numberOfAdministrations") )
                        result.NumberOfAdministrations = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element dosageInstruction
                    else if( ParserUtils.IsAtFhirElement(reader, "dosageInstruction") )
                    {
                        result.DosageInstruction = new List<Prescription.PrescriptionAdministrationRequestDosageInstructionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "dosageInstruction") )
                            result.DosageInstruction.Add(PrescriptionParser.ParsePrescriptionAdministrationRequestDosageInstructionComponent(reader, errors));
                        
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
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse PrescriptionMedicineComponent
        /// </summary>
        public static Prescription.PrescriptionMedicineComponent ParsePrescriptionMedicineComponent(IFhirReader reader, ErrorList errors, Prescription.PrescriptionMedicineComponent existingInstance = null )
        {
            Prescription.PrescriptionMedicineComponent result = existingInstance != null ? existingInstance : new Prescription.PrescriptionMedicineComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element identification
                    else if( ParserUtils.IsAtFhirElement(reader, "identification") )
                        result.Identification = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element activeIngredient
                    else if( ParserUtils.IsAtFhirElement(reader, "activeIngredient") )
                    {
                        result.ActiveIngredient = new List<Prescription.PrescriptionMedicineActiveIngredientComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "activeIngredient") )
                            result.ActiveIngredient.Add(PrescriptionParser.ParsePrescriptionMedicineActiveIngredientComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element inactiveIngredient
                    else if( ParserUtils.IsAtFhirElement(reader, "inactiveIngredient") )
                    {
                        result.InactiveIngredient = new List<Prescription.PrescriptionMedicineInactiveIngredientComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "inactiveIngredient") )
                            result.InactiveIngredient.Add(PrescriptionParser.ParsePrescriptionMedicineInactiveIngredientComponent(reader, errors));
                        
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
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse PrescriptionMedicineInactiveIngredientComponent
        /// </summary>
        public static Prescription.PrescriptionMedicineInactiveIngredientComponent ParsePrescriptionMedicineInactiveIngredientComponent(IFhirReader reader, ErrorList errors, Prescription.PrescriptionMedicineInactiveIngredientComponent existingInstance = null )
        {
            Prescription.PrescriptionMedicineInactiveIngredientComponent result = existingInstance != null ? existingInstance : new Prescription.PrescriptionMedicineInactiveIngredientComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element identification
                    else if( ParserUtils.IsAtFhirElement(reader, "identification") )
                        result.Identification = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element quantity
                    else if( ParserUtils.IsAtFhirElement(reader, "quantity", true) )
                        result.Quantity = FhirParser.ParseElement(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse PrescriptionAdministrationRequestDosageInstructionComponent
        /// </summary>
        public static Prescription.PrescriptionAdministrationRequestDosageInstructionComponent ParsePrescriptionAdministrationRequestDosageInstructionComponent(IFhirReader reader, ErrorList errors, Prescription.PrescriptionAdministrationRequestDosageInstructionComponent existingInstance = null )
        {
            Prescription.PrescriptionAdministrationRequestDosageInstructionComponent result = existingInstance != null ? existingInstance : new Prescription.PrescriptionAdministrationRequestDosageInstructionComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element precondition
                    else if( ParserUtils.IsAtFhirElement(reader, "precondition") )
                    {
                        result.Precondition = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "precondition") )
                            result.Precondition.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element prn
                    else if( ParserUtils.IsAtFhirElement(reader, "prn") )
                        result.Prn = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element additionalInstruction
                    else if( ParserUtils.IsAtFhirElement(reader, "additionalInstruction") )
                    {
                        result.AdditionalInstruction = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "additionalInstruction") )
                            result.AdditionalInstruction.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element route
                    else if( ParserUtils.IsAtFhirElement(reader, "route") )
                        result.Route = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element dose
                    else if( ParserUtils.IsAtFhirElement(reader, "dose", true) )
                        result.Dose = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element rate
                    else if( ParserUtils.IsAtFhirElement(reader, "rate") )
                        result.Rate = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element schedule
                    else if( ParserUtils.IsAtFhirElement(reader, "schedule") )
                    {
                        result.Schedule = new List<Schedule>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "schedule") )
                            result.Schedule.Add(ScheduleParser.ParseSchedule(reader, errors));
                        
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
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
    }
}
