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
    /// Parser for DiagnosticOrder instances
    /// </summary>
    internal static partial class DiagnosticOrderParser
    {
        /// <summary>
        /// Parse DiagnosticOrder
        /// </summary>
        public static Hl7.Fhir.Model.DiagnosticOrder ParseDiagnosticOrder(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DiagnosticOrder existingInstance = null )
        {
            Hl7.Fhir.Model.DiagnosticOrder result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DiagnosticOrder();
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
                
                // Parse element orderer
                else if( atName == "orderer" )
                    result.Orderer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element identifier
                else if( atName == "identifier" )
                {
                    result.Identifier = new List<Hl7.Fhir.Model.Identifier>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                        result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element encounter
                else if( atName == "encounter" )
                    result.Encounter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element clinicalNotes
                else if( atName == "clinicalNotes" )
                    result.ClinicalNotesElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element specimen
                else if( atName == "specimen" )
                {
                    result.Specimen = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "specimen") )
                        result.Specimen.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus>(reader, errors);
                
                // Parse element priority
                else if( atName == "priority" )
                    result.PriorityElement = CodeParser.ParseCode<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderPriority>(reader, errors);
                
                // Parse element event
                else if( atName == "event" )
                {
                    result.Event = new List<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderEventComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "event") )
                        result.Event.Add(DiagnosticOrderParser.ParseDiagnosticOrderEventComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element item
                else if( atName == "item" )
                {
                    result.Item = new List<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderItemComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "item") )
                        result.Item.Add(DiagnosticOrderParser.ParseDiagnosticOrderItemComponent(reader, errors));
                    
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
        /// Parse DiagnosticOrderItemComponent
        /// </summary>
        public static Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderItemComponent ParseDiagnosticOrderItemComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderItemComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderItemComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderItemComponent();
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
                
                // Parse element specimen
                else if( atName == "specimen" )
                {
                    result.Specimen = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "specimen") )
                        result.Specimen.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element bodySite
                else if( atName == "bodySite" )
                    result.BodySite = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus>(reader, errors);
                
                // Parse element event
                else if( atName == "event" )
                {
                    result.Event = new List<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderEventComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "event") )
                        result.Event.Add(DiagnosticOrderParser.ParseDiagnosticOrderEventComponent(reader, errors));
                    
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
        /// Parse DiagnosticOrderEventComponent
        /// </summary>
        public static Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderEventComponent ParseDiagnosticOrderEventComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderEventComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderEventComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderEventComponent();
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
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.DiagnosticOrder.DiagnosticOrderStatus>(reader, errors);
                
                // Parse element date
                else if( atName == "date" )
                    result.DateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element actor
                else if( atName == "actor" )
                    result.Actor = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
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
