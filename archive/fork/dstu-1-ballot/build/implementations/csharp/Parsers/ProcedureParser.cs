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
    /// Parser for Procedure instances
    /// </summary>
    internal static partial class ProcedureParser
    {
        /// <summary>
        /// Parse Procedure
        /// </summary>
        public static Hl7.Fhir.Model.Procedure ParseProcedure(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Procedure existingInstance = null )
        {
            Hl7.Fhir.Model.Procedure result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Procedure();
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
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element bodySite
                else if( atName == "bodySite" )
                {
                    result.BodySite = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "bodySite") )
                        result.BodySite.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element indication
                else if( atName == "indication" )
                    result.IndicationElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element performer
                else if( atName == "performer" )
                {
                    result.Performer = new List<Hl7.Fhir.Model.Procedure.ProcedurePerformerComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "performer") )
                        result.Performer.Add(ProcedureParser.ParseProcedurePerformerComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element date
                else if( atName == "date" )
                    result.Date = PeriodParser.ParsePeriod(reader, errors);
                
                // Parse element encounter
                else if( atName == "encounter" )
                    result.Encounter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element outcome
                else if( atName == "outcome" )
                    result.OutcomeElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element report
                else if( atName == "report" )
                {
                    result.Report = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "report") )
                        result.Report.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element complication
                else if( atName == "complication" )
                    result.ComplicationElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element followUp
                else if( atName == "followUp" )
                    result.FollowUpElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element relatedItem
                else if( atName == "relatedItem" )
                {
                    result.RelatedItem = new List<Hl7.Fhir.Model.Procedure.ProcedureRelatedItemComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "relatedItem") )
                        result.RelatedItem.Add(ProcedureParser.ParseProcedureRelatedItemComponent(reader, errors));
                    
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
        /// Parse ProcedureRelatedItemComponent
        /// </summary>
        public static Hl7.Fhir.Model.Procedure.ProcedureRelatedItemComponent ParseProcedureRelatedItemComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Procedure.ProcedureRelatedItemComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Procedure.ProcedureRelatedItemComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Procedure.ProcedureRelatedItemComponent();
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
                    result.TypeElement = CodeParser.ParseCode<Hl7.Fhir.Model.Procedure.ProcedureRelationshipType>(reader, errors);
                
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
        /// Parse ProcedurePerformerComponent
        /// </summary>
        public static Hl7.Fhir.Model.Procedure.ProcedurePerformerComponent ParseProcedurePerformerComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Procedure.ProcedurePerformerComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Procedure.ProcedurePerformerComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Procedure.ProcedurePerformerComponent();
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
                
                // Parse element person
                else if( atName == "person" )
                    result.Person = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element role
                else if( atName == "role" )
                    result.Role = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
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
