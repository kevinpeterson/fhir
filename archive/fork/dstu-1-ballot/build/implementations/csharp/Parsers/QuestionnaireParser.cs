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
    /// Parser for Questionnaire instances
    /// </summary>
    internal static partial class QuestionnaireParser
    {
        /// <summary>
        /// Parse Questionnaire
        /// </summary>
        public static Hl7.Fhir.Model.Questionnaire ParseQuestionnaire(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Questionnaire existingInstance = null )
        {
            Hl7.Fhir.Model.Questionnaire result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Questionnaire();
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
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.ObservationStatus>(reader, errors);
                
                // Parse element authored
                else if( atName == "authored" )
                    result.AuthoredElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element author
                else if( atName == "author" )
                    result.Author = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element source
                else if( atName == "source" )
                    result.Source = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element name
                else if( atName == "name" )
                    result.Name = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element identifier
                else if( atName == "identifier" )
                    result.Identifier = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element encounter
                else if( atName == "encounter" )
                    result.Encounter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element question
                else if( atName == "question" )
                {
                    result.Question = new List<Hl7.Fhir.Model.Questionnaire.QuestionComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "question") )
                        result.Question.Add(QuestionnaireParser.ParseQuestionComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element group
                else if( atName == "group" )
                {
                    result.Group = new List<Hl7.Fhir.Model.Questionnaire.GroupComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "group") )
                        result.Group.Add(QuestionnaireParser.ParseGroupComponent(reader, errors));
                    
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
        /// Parse QuestionComponent
        /// </summary>
        public static Hl7.Fhir.Model.Questionnaire.QuestionComponent ParseQuestionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Questionnaire.QuestionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Questionnaire.QuestionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Questionnaire.QuestionComponent();
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
                
                // Parse element name
                else if( atName == "name" )
                    result.Name = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element text
                else if( atName == "text" )
                    result.TextElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element answer
                else if( atName.StartsWith("answer") )
                    result.Answer = FhirParser.ParseElement(reader, errors);
                
                // Parse element choice
                else if( atName == "choice" )
                {
                    result.Choice = new List<Hl7.Fhir.Model.Coding>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "choice") )
                        result.Choice.Add(CodingParser.ParseCoding(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element options
                else if( atName.StartsWith("options") )
                    result.Options = FhirParser.ParseElement(reader, errors);
                
                // Parse element data
                else if( atName.StartsWith("data") )
                    result.Data = FhirParser.ParseElement(reader, errors);
                
                // Parse element remarks
                else if( atName == "remarks" )
                    result.RemarksElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse GroupComponent
        /// </summary>
        public static Hl7.Fhir.Model.Questionnaire.GroupComponent ParseGroupComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Questionnaire.GroupComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Questionnaire.GroupComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Questionnaire.GroupComponent();
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
                
                // Parse element name
                else if( atName == "name" )
                    result.Name = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element header
                else if( atName == "header" )
                    result.HeaderElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element text
                else if( atName == "text" )
                    result.TextElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element question
                else if( atName == "question" )
                {
                    result.Question = new List<Hl7.Fhir.Model.Questionnaire.QuestionComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "question") )
                        result.Question.Add(QuestionnaireParser.ParseQuestionComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element group
                else if( atName == "group" )
                {
                    result.Group = new List<Hl7.Fhir.Model.Questionnaire.GroupComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "group") )
                        result.Group.Add(QuestionnaireParser.ParseGroupComponent(reader, errors));
                    
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
