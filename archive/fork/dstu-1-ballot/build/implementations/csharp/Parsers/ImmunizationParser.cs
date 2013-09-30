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
    /// Parser for Immunization instances
    /// </summary>
    internal static partial class ImmunizationParser
    {
        /// <summary>
        /// Parse Immunization
        /// </summary>
        public static Hl7.Fhir.Model.Immunization ParseImmunization(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Immunization existingInstance = null )
        {
            Hl7.Fhir.Model.Immunization result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Immunization();
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
                
                // Parse element date
                else if( atName == "date" )
                    result.DateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element vaccineType
                else if( atName == "vaccineType" )
                    result.VaccineType = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element refusedIndicator
                else if( atName == "refusedIndicator" )
                    result.RefusedIndicatorElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element reported
                else if( atName == "reported" )
                    result.ReportedElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element performer
                else if( atName == "performer" )
                    result.Performer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element requester
                else if( atName == "requester" )
                    result.Requester = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element manufacturer
                else if( atName == "manufacturer" )
                    result.Manufacturer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element location
                else if( atName == "location" )
                    result.Location = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element lotNumber
                else if( atName == "lotNumber" )
                    result.LotNumberElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element expirationDate
                else if( atName == "expirationDate" )
                    result.ExpirationDateElement = DateParser.ParseDate(reader, errors);
                
                // Parse element site
                else if( atName == "site" )
                    result.Site = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element route
                else if( atName == "route" )
                    result.Route = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element doseQuantity
                else if( atName == "doseQuantity" )
                    result.DoseQuantity = QuantityParser.ParseQuantity(reader, errors);
                
                // Parse element explanation
                else if( atName == "explanation" )
                    result.Explanation = ImmunizationParser.ParseImmunizationExplanationComponent(reader, errors);
                
                // Parse element reaction
                else if( atName == "reaction" )
                {
                    result.Reaction = new List<Hl7.Fhir.Model.Immunization.ImmunizationReactionComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "reaction") )
                        result.Reaction.Add(ImmunizationParser.ParseImmunizationReactionComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element vaccinationProtocol
                else if( atName == "vaccinationProtocol" )
                    result.VaccinationProtocol = ImmunizationParser.ParseImmunizationVaccinationProtocolComponent(reader, errors);
                
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
        /// Parse ImmunizationVaccinationProtocolComponent
        /// </summary>
        public static Hl7.Fhir.Model.Immunization.ImmunizationVaccinationProtocolComponent ParseImmunizationVaccinationProtocolComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Immunization.ImmunizationVaccinationProtocolComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Immunization.ImmunizationVaccinationProtocolComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Immunization.ImmunizationVaccinationProtocolComponent();
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
                
                // Parse element doseSequence
                else if( atName == "doseSequence" )
                    result.DoseSequenceElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element authority
                else if( atName == "authority" )
                    result.Authority = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element series
                else if( atName == "series" )
                    result.SeriesElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element seriesDoses
                else if( atName == "seriesDoses" )
                    result.SeriesDosesElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element doseTarget
                else if( atName == "doseTarget" )
                    result.DoseTarget = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element doseStatus
                else if( atName == "doseStatus" )
                    result.DoseStatus = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element doseStatusReason
                else if( atName == "doseStatusReason" )
                    result.DoseStatusReason = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
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
        /// Parse ImmunizationExplanationComponent
        /// </summary>
        public static Hl7.Fhir.Model.Immunization.ImmunizationExplanationComponent ParseImmunizationExplanationComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Immunization.ImmunizationExplanationComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Immunization.ImmunizationExplanationComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Immunization.ImmunizationExplanationComponent();
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
                
                // Parse element reason
                else if( atName == "reason" )
                {
                    result.Reason = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "reason") )
                        result.Reason.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element refusalReason
                else if( atName == "refusalReason" )
                {
                    result.RefusalReason = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "refusalReason") )
                        result.RefusalReason.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
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
        /// Parse ImmunizationReactionComponent
        /// </summary>
        public static Hl7.Fhir.Model.Immunization.ImmunizationReactionComponent ParseImmunizationReactionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Immunization.ImmunizationReactionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Immunization.ImmunizationReactionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Immunization.ImmunizationReactionComponent();
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
                
                // Parse element date
                else if( atName == "date" )
                    result.DateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element detail
                else if( atName == "detail" )
                    result.Detail = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element reported
                else if( atName == "reported" )
                    result.ReportedElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
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
