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
// Generated on Fri, Jun 21, 2013 15:52+1000 for FHIR v0.09
//

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Problem instances
    /// </summary>
    internal static partial class ProblemParser
    {
        /// <summary>
        /// Parse Problem
        /// </summary>
        public static Hl7.Fhir.Model.Problem ParseProblem(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Problem existingInstance = null )
        {
            Hl7.Fhir.Model.Problem result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Problem();
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
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element visit
                    else if( ParserUtils.IsAtFhirElement(reader, "visit") )
                        result.Visit = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element asserter
                    else if( ParserUtils.IsAtFhirElement(reader, "asserter") )
                        result.Asserter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element dateAsserted
                    else if( ParserUtils.IsAtFhirElement(reader, "dateAsserted") )
                        result.DateAsserted = DateParser.ParseDate(reader, errors);
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element category
                    else if( ParserUtils.IsAtFhirElement(reader, "category") )
                        result.Category = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = CodeParser.ParseCode<Hl7.Fhir.Model.Problem.ProblemStatus>(reader, errors);
                    
                    // Parse element certainty
                    else if( ParserUtils.IsAtFhirElement(reader, "certainty") )
                        result.Certainty = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element severity
                    else if( ParserUtils.IsAtFhirElement(reader, "severity") )
                        result.Severity = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element onset
                    else if( ParserUtils.IsAtFhirElement(reader, "onset", true) )
                        result.Onset = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element abatement
                    else if( ParserUtils.IsAtFhirElement(reader, "abatement", true) )
                        result.Abatement = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element stage
                    else if( ParserUtils.IsAtFhirElement(reader, "stage") )
                        result.Stage = ProblemParser.ParseProblemStageComponent(reader, errors);
                    
                    // Parse element evidence
                    else if( ParserUtils.IsAtFhirElement(reader, "evidence") )
                    {
                        result.Evidence = new List<Hl7.Fhir.Model.Problem.ProblemEvidenceComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "evidence") )
                            result.Evidence.Add(ProblemParser.ParseProblemEvidenceComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element location
                    else if( ParserUtils.IsAtFhirElement(reader, "location") )
                    {
                        result.Location = new List<Hl7.Fhir.Model.Problem.ProblemLocationComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "location") )
                            result.Location.Add(ProblemParser.ParseProblemLocationComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element relatedItem
                    else if( ParserUtils.IsAtFhirElement(reader, "relatedItem") )
                    {
                        result.RelatedItem = new List<Hl7.Fhir.Model.Problem.ProblemRelatedItemComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "relatedItem") )
                            result.RelatedItem.Add(ProblemParser.ParseProblemRelatedItemComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element notes
                    else if( ParserUtils.IsAtFhirElement(reader, "notes") )
                        result.Notes = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ProblemStageComponent
        /// </summary>
        public static Hl7.Fhir.Model.Problem.ProblemStageComponent ParseProblemStageComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Problem.ProblemStageComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Problem.ProblemStageComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Problem.ProblemStageComponent();
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
                    
                    // Parse element summary
                    else if( ParserUtils.IsAtFhirElement(reader, "summary") )
                        result.Summary = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element assessment
                    else if( ParserUtils.IsAtFhirElement(reader, "assessment") )
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
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse ProblemLocationComponent
        /// </summary>
        public static Hl7.Fhir.Model.Problem.ProblemLocationComponent ParseProblemLocationComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Problem.ProblemLocationComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Problem.ProblemLocationComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Problem.ProblemLocationComponent();
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
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element details
                    else if( ParserUtils.IsAtFhirElement(reader, "details") )
                        result.Details = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ProblemEvidenceComponent
        /// </summary>
        public static Hl7.Fhir.Model.Problem.ProblemEvidenceComponent ParseProblemEvidenceComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Problem.ProblemEvidenceComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Problem.ProblemEvidenceComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Problem.ProblemEvidenceComponent();
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
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element details
                    else if( ParserUtils.IsAtFhirElement(reader, "details") )
                    {
                        result.Details = new List<Hl7.Fhir.Model.ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "details") )
                            result.Details.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
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
        /// Parse ProblemRelatedItemComponent
        /// </summary>
        public static Hl7.Fhir.Model.Problem.ProblemRelatedItemComponent ParseProblemRelatedItemComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Problem.ProblemRelatedItemComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Problem.ProblemRelatedItemComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Problem.ProblemRelatedItemComponent();
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
                        result.Type = CodeParser.ParseCode<Hl7.Fhir.Model.Problem.ProblemRelationshipType>(reader, errors);
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element target
                    else if( ParserUtils.IsAtFhirElement(reader, "target") )
                        result.Target = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
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
