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
    /// Parser for DiagnosticReport instances
    /// </summary>
    internal static partial class DiagnosticReportParser
    {
        /// <summary>
        /// Parse DiagnosticReport
        /// </summary>
        public static Hl7.Fhir.Model.DiagnosticReport ParseDiagnosticReport(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DiagnosticReport existingInstance = null )
        {
            Hl7.Fhir.Model.DiagnosticReport result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DiagnosticReport();
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
                
                // Parse element issued
                else if( atName == "issued" )
                    result.IssuedElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element performer
                else if( atName == "performer" )
                    result.Performer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element reportId
                else if( atName == "reportId" )
                    result.ReportId = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element requestDetail
                else if( atName == "requestDetail" )
                {
                    result.RequestDetail = new List<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportRequestDetailComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "requestDetail") )
                        result.RequestDetail.Add(DiagnosticReportParser.ParseDiagnosticReportRequestDetailComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element serviceCategory
                else if( atName == "serviceCategory" )
                    result.ServiceCategory = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element diagnosticTime
                else if( atName == "diagnosticTime" )
                    result.DiagnosticTimeElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element results
                else if( atName == "results" )
                    result.Results = DiagnosticReportParser.ParseResultGroupComponent(reader, errors);
                
                // Parse element image
                else if( atName == "image" )
                {
                    result.Image = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "image") )
                        result.Image.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element conclusion
                else if( atName == "conclusion" )
                    result.ConclusionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element codedDiagnosis
                else if( atName == "codedDiagnosis" )
                {
                    result.CodedDiagnosis = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "codedDiagnosis") )
                        result.CodedDiagnosis.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element representation
                else if( atName == "representation" )
                {
                    result.Representation = new List<Hl7.Fhir.Model.Attachment>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "representation") )
                        result.Representation.Add(AttachmentParser.ParseAttachment(reader, errors));
                    
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
        /// Parse DiagnosticReportRequestDetailComponent
        /// </summary>
        public static Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportRequestDetailComponent ParseDiagnosticReportRequestDetailComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportRequestDetailComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportRequestDetailComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportRequestDetailComponent();
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
                
                // Parse element encounter
                else if( atName == "encounter" )
                    result.Encounter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element requestOrderId
                else if( atName == "requestOrderId" )
                    result.RequestOrderId = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element receiverOrderId
                else if( atName == "receiverOrderId" )
                    result.ReceiverOrderId = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element requestTest
                else if( atName == "requestTest" )
                {
                    result.RequestTest = new List<Hl7.Fhir.Model.CodeableConcept>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "requestTest") )
                        result.RequestTest.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element bodySite
                else if( atName == "bodySite" )
                    result.BodySite = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element requester
                else if( atName == "requester" )
                    result.Requester = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element clinicalInfo
                else if( atName == "clinicalInfo" )
                    result.ClinicalInfoElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse ResultGroupComponent
        /// </summary>
        public static Hl7.Fhir.Model.DiagnosticReport.ResultGroupComponent ParseResultGroupComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.DiagnosticReport.ResultGroupComponent existingInstance = null )
        {
            Hl7.Fhir.Model.DiagnosticReport.ResultGroupComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.DiagnosticReport.ResultGroupComponent();
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
                
                // Parse element specimen
                else if( atName == "specimen" )
                    result.Specimen = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element group
                else if( atName == "group" )
                {
                    result.Group = new List<Hl7.Fhir.Model.DiagnosticReport.ResultGroupComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "group") )
                        result.Group.Add(DiagnosticReportParser.ParseResultGroupComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element result
                else if( atName == "result" )
                {
                    result.Result = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "result") )
                        result.Result.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
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
