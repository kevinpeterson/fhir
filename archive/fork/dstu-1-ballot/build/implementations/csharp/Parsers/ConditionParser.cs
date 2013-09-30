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
    /// Parser for Condition instances
    /// </summary>
    internal static partial class ConditionParser
    {
        /// <summary>
        /// Parse Condition
        /// </summary>
        public static Hl7.Fhir.Model.Condition ParseCondition(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Condition existingInstance = null )
        {
            Hl7.Fhir.Model.Condition result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Condition();
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
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element encounter
                else if( atName == "encounter" )
                    result.Encounter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element asserter
                else if( atName == "asserter" )
                    result.Asserter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element dateAsserted
                else if( atName == "dateAsserted" )
                    result.DateAssertedElement = DateParser.ParseDate(reader, errors);
                
                // Parse element code
                else if( atName == "code" )
                    result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element category
                else if( atName == "category" )
                    result.Category = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.Condition.ConditionStatus>(reader, errors);
                
                // Parse element certainty
                else if( atName == "certainty" )
                    result.Certainty = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element severity
                else if( atName == "severity" )
                    result.Severity = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element onset
                else if( atName.StartsWith("onset") )
                    result.Onset = FhirParser.ParseElement(reader, errors);
                
                // Parse element abatement
                else if( atName.StartsWith("abatement") )
                    result.Abatement = FhirParser.ParseElement(reader, errors);
                
                // Parse element stage
                else if( atName == "stage" )
                    result.Stage = ConditionParser.ParseConditionStageComponent(reader, errors);
                
                // Parse element evidence
                else if( atName == "evidence" )
                {
                    result.Evidence = new List<Hl7.Fhir.Model.Condition.ConditionEvidenceComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "evidence") )
                        result.Evidence.Add(ConditionParser.ParseConditionEvidenceComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element location
                else if( atName == "location" )
                {
                    result.Location = new List<Hl7.Fhir.Model.Condition.ConditionLocationComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "location") )
                        result.Location.Add(ConditionParser.ParseConditionLocationComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element relatedItem
                else if( atName == "relatedItem" )
                {
                    result.RelatedItem = new List<Hl7.Fhir.Model.Condition.ConditionRelatedItemComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "relatedItem") )
                        result.RelatedItem.Add(ConditionParser.ParseConditionRelatedItemComponent(reader, errors));
                    
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
        /// Parse ConditionRelatedItemComponent
        /// </summary>
        public static Hl7.Fhir.Model.Condition.ConditionRelatedItemComponent ParseConditionRelatedItemComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Condition.ConditionRelatedItemComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Condition.ConditionRelatedItemComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Condition.ConditionRelatedItemComponent();
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
                    result.TypeElement = CodeParser.ParseCode<Hl7.Fhir.Model.Condition.ConditionRelationshipType>(reader, errors);
                
                // Parse element code
                else if( atName == "code" )
                    result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element target
                else if( atName == "target" )
                    result.Target = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
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
        /// Parse ConditionEvidenceComponent
        /// </summary>
        public static Hl7.Fhir.Model.Condition.ConditionEvidenceComponent ParseConditionEvidenceComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Condition.ConditionEvidenceComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Condition.ConditionEvidenceComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Condition.ConditionEvidenceComponent();
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
                
                // Parse element code
                else if( atName == "code" )
                    result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element detail
                else if( atName == "detail" )
                {
                    result.Detail = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "detail") )
                        result.Detail.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
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
        /// Parse ConditionStageComponent
        /// </summary>
        public static Hl7.Fhir.Model.Condition.ConditionStageComponent ParseConditionStageComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Condition.ConditionStageComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Condition.ConditionStageComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Condition.ConditionStageComponent();
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
                
                // Parse element summary
                else if( atName == "summary" )
                    result.Summary = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element assessment
                else if( atName == "assessment" )
                {
                    result.Assessment = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "assessment") )
                        result.Assessment.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
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
        /// Parse ConditionLocationComponent
        /// </summary>
        public static Hl7.Fhir.Model.Condition.ConditionLocationComponent ParseConditionLocationComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Condition.ConditionLocationComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Condition.ConditionLocationComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Condition.ConditionLocationComponent();
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
                
                // Parse element code
                else if( atName == "code" )
                    result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element detail
                else if( atName == "detail" )
                    result.DetailElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
