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
    /// Parser for FamilyHistory instances
    /// </summary>
    internal static partial class FamilyHistoryParser
    {
        /// <summary>
        /// Parse FamilyHistory
        /// </summary>
        public static Hl7.Fhir.Model.FamilyHistory ParseFamilyHistory(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.FamilyHistory existingInstance = null )
        {
            Hl7.Fhir.Model.FamilyHistory result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.FamilyHistory();
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
                
                // Parse element note
                else if( atName == "note" )
                    result.NoteElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element relation
                else if( atName == "relation" )
                {
                    result.Relation = new List<Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "relation") )
                        result.Relation.Add(FamilyHistoryParser.ParseFamilyHistoryRelationComponent(reader, errors));
                    
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
        /// Parse FamilyHistoryRelationConditionComponent
        /// </summary>
        public static Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationConditionComponent ParseFamilyHistoryRelationConditionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationConditionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationConditionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationConditionComponent();
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
                
                // Parse element outcome
                else if( atName == "outcome" )
                    result.Outcome = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element onset
                else if( atName.StartsWith("onset") )
                    result.Onset = FhirParser.ParseElement(reader, errors);
                
                // Parse element note
                else if( atName == "note" )
                    result.NoteElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse FamilyHistoryRelationComponent
        /// </summary>
        public static Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationComponent ParseFamilyHistoryRelationComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationComponent existingInstance = null )
        {
            Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationComponent();
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
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element relationship
                else if( atName == "relationship" )
                    result.Relationship = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element deceased
                else if( atName.StartsWith("deceased") )
                    result.Deceased = FhirParser.ParseElement(reader, errors);
                
                // Parse element note
                else if( atName == "note" )
                    result.NoteElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element condition
                else if( atName == "condition" )
                {
                    result.Condition = new List<Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationConditionComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "condition") )
                        result.Condition.Add(FamilyHistoryParser.ParseFamilyHistoryRelationConditionComponent(reader, errors));
                    
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
