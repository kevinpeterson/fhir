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
// Generated on Wed, Jun 19, 2013 01:55+1000 for FHIR v0.09
//

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Study instances
    /// </summary>
    internal static partial class StudyParser
    {
        /// <summary>
        /// Parse Study
        /// </summary>
        public static Hl7.Fhir.Model.Study ParseStudy(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Study existingInstance = null )
        {
            Hl7.Fhir.Model.Study result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Study();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
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
                        result.Contained = new List<Hl7.Fhir.Model.Resource>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "contained") )
                            result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                    {
                        result.Identifier = new List<Hl7.Fhir.Model.Identifier>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                            result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element sponsor
                    else if( ParserUtils.IsAtFhirElement(reader, "sponsor") )
                        result.Sponsor = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element title
                    else if( ParserUtils.IsAtFhirElement(reader, "title") )
                        result.Title = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element condition
                    else if( ParserUtils.IsAtFhirElement(reader, "condition") )
                    {
                        result.Condition = new List<Hl7.Fhir.Model.CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "condition") )
                            result.Condition.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element treatment
                    else if( ParserUtils.IsAtFhirElement(reader, "treatment") )
                    {
                        result.Treatment = new List<Hl7.Fhir.Model.Study.StudyTreatmentComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "treatment") )
                            result.Treatment.Add(StudyParser.ParseStudyTreatmentComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element controlType
                    else if( ParserUtils.IsAtFhirElement(reader, "controlType") )
                    {
                        result.ControlType = new List<Hl7.Fhir.Model.CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "controlType") )
                            result.ControlType.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element objective
                    else if( ParserUtils.IsAtFhirElement(reader, "objective") )
                    {
                        result.Objective = new List<Hl7.Fhir.Model.FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "objective") )
                            result.Objective.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element outcomeMeasure
                    else if( ParserUtils.IsAtFhirElement(reader, "outcomeMeasure") )
                    {
                        result.OutcomeMeasure = new List<Hl7.Fhir.Model.FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "outcomeMeasure") )
                            result.OutcomeMeasure.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element eligibility
                    else if( ParserUtils.IsAtFhirElement(reader, "eligibility") )
                    {
                        result.Eligibility = new List<Hl7.Fhir.Model.ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "eligibility") )
                            result.Eligibility.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element period
                    else if( ParserUtils.IsAtFhirElement(reader, "period") )
                        result.Period = PeriodParser.ParsePeriod(reader, errors);
                    
                    // Parse element duration
                    else if( ParserUtils.IsAtFhirElement(reader, "duration") )
                        result.Duration = DurationParser.ParseDuration(reader, errors);
                    
                    // Parse element plannedEnrollment
                    else if( ParserUtils.IsAtFhirElement(reader, "plannedEnrollment") )
                        result.PlannedEnrollment = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element intervention
                    else if( ParserUtils.IsAtFhirElement(reader, "intervention") )
                        result.Intervention = StudyParser.ParseStudyInterventionComponent(reader, errors);
                    
                    // Parse element protocol
                    else if( ParserUtils.IsAtFhirElement(reader, "protocol") )
                    {
                        result.Protocol = new List<Hl7.Fhir.Model.ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "protocol") )
                            result.Protocol.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element dataStructure
                    else if( ParserUtils.IsAtFhirElement(reader, "dataStructure") )
                        result.DataStructure = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element data
                    else if( ParserUtils.IsAtFhirElement(reader, "data") )
                    {
                        result.Data = new List<Hl7.Fhir.Model.ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "data") )
                            result.Data.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
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
        /// Parse StudyInterventionComponent
        /// </summary>
        public static Hl7.Fhir.Model.Study.StudyInterventionComponent ParseStudyInterventionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Study.StudyInterventionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Study.StudyInterventionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Study.StudyInterventionComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element model
                    else if( ParserUtils.IsAtFhirElement(reader, "model") )
                        result.Model = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element randomized
                    else if( ParserUtils.IsAtFhirElement(reader, "randomized") )
                        result.Randomized = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element blindingScheme
                    else if( ParserUtils.IsAtFhirElement(reader, "blindingScheme") )
                        result.BlindingScheme = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element randomizationQuotient
                    else if( ParserUtils.IsAtFhirElement(reader, "randomizationQuotient", true) )
                        result.RandomizationQuotient = FhirParser.ParseElement(reader, errors);
                    
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
        /// Parse StudyTreatmentComponent
        /// </summary>
        public static Hl7.Fhir.Model.Study.StudyTreatmentComponent ParseStudyTreatmentComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Study.StudyTreatmentComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Study.StudyTreatmentComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Study.StudyTreatmentComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element role
                    else if( ParserUtils.IsAtFhirElement(reader, "role") )
                        result.Role = CodeParser.ParseCode<Hl7.Fhir.Model.Study.StudyTreatmentRole>(reader, errors);
                    
                    // Parse element detail
                    else if( ParserUtils.IsAtFhirElement(reader, "detail") )
                        result.Detail = ActivityDefinitionParser.ParseActivityDefinition(reader, errors);
                    
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
