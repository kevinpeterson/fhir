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
    /// Parser for CarePlan instances
    /// </summary>
    internal static partial class CarePlanParser
    {
        /// <summary>
        /// Parse CarePlan
        /// </summary>
        public static Hl7.Fhir.Model.CarePlan ParseCarePlan(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.CarePlan existingInstance = null )
        {
            Hl7.Fhir.Model.CarePlan result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.CarePlan();
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
                
                // Parse element patient
                else if( atName == "patient" )
                    result.Patient = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.CarePlan.CarePlanStatus>(reader, errors);
                
                // Parse element period
                else if( atName == "period" )
                    result.Period = PeriodParser.ParsePeriod(reader, errors);
                
                // Parse element modified
                else if( atName == "modified" )
                    result.ModifiedElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element concern
                else if( atName == "concern" )
                {
                    result.Concern = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "concern") )
                        result.Concern.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element participant
                else if( atName == "participant" )
                {
                    result.Participant = new List<Hl7.Fhir.Model.CarePlan.CarePlanParticipantComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "participant") )
                        result.Participant.Add(CarePlanParser.ParseCarePlanParticipantComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element goal
                else if( atName == "goal" )
                {
                    result.Goal = new List<Hl7.Fhir.Model.CarePlan.CarePlanGoalComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "goal") )
                        result.Goal.Add(CarePlanParser.ParseCarePlanGoalComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element activity
                else if( atName == "activity" )
                {
                    result.Activity = new List<Hl7.Fhir.Model.CarePlan.CarePlanActivityComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "activity") )
                        result.Activity.Add(CarePlanParser.ParseCarePlanActivityComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element notes
                else if( atName == "notes" )
                    result.NotesElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse CarePlanGoalComponent
        /// </summary>
        public static Hl7.Fhir.Model.CarePlan.CarePlanGoalComponent ParseCarePlanGoalComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.CarePlan.CarePlanGoalComponent existingInstance = null )
        {
            Hl7.Fhir.Model.CarePlan.CarePlanGoalComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.CarePlan.CarePlanGoalComponent();
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
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.CarePlan.CarePlanGoalStatus>(reader, errors);
                
                // Parse element notes
                else if( atName == "notes" )
                    result.NotesElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse CarePlanParticipantComponent
        /// </summary>
        public static Hl7.Fhir.Model.CarePlan.CarePlanParticipantComponent ParseCarePlanParticipantComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.CarePlan.CarePlanParticipantComponent existingInstance = null )
        {
            Hl7.Fhir.Model.CarePlan.CarePlanParticipantComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.CarePlan.CarePlanParticipantComponent();
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
                
                // Parse element role
                else if( atName == "role" )
                    result.Role = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element member
                else if( atName == "member" )
                    result.Member = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
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
        /// Parse CarePlanActivityComponent
        /// </summary>
        public static Hl7.Fhir.Model.CarePlan.CarePlanActivityComponent ParseCarePlanActivityComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.CarePlan.CarePlanActivityComponent existingInstance = null )
        {
            Hl7.Fhir.Model.CarePlan.CarePlanActivityComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.CarePlan.CarePlanActivityComponent();
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
                
                // Parse element category
                else if( atName == "category" )
                    result.CategoryElement = CodeParser.ParseCode<Hl7.Fhir.Model.CarePlan.CarePlanActivityCategory>(reader, errors);
                
                // Parse element code
                else if( atName == "code" )
                    result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus>(reader, errors);
                
                // Parse element prohibited
                else if( atName == "prohibited" )
                    result.ProhibitedElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element timing
                else if( atName.StartsWith("timing") )
                    result.Timing = FhirParser.ParseElement(reader, errors);
                
                // Parse element location
                else if( atName == "location" )
                    result.Location = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element performer
                else if( atName == "performer" )
                {
                    result.Performer = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "performer") )
                        result.Performer.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element product
                else if( atName == "product" )
                    result.Product = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element dailyAmount
                else if( atName == "dailyAmount" )
                    result.DailyAmount = QuantityParser.ParseQuantity(reader, errors);
                
                // Parse element quantity
                else if( atName == "quantity" )
                    result.Quantity = QuantityParser.ParseQuantity(reader, errors);
                
                // Parse element details
                else if( atName == "details" )
                    result.DetailsElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element actionTaken
                else if( atName == "actionTaken" )
                {
                    result.ActionTaken = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "actionTaken") )
                        result.ActionTaken.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element notes
                else if( atName == "notes" )
                    result.NotesElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
