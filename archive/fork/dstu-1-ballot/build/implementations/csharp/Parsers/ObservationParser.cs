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
    /// Parser for Observation instances
    /// </summary>
    internal static partial class ObservationParser
    {
        /// <summary>
        /// Parse Observation
        /// </summary>
        public static Hl7.Fhir.Model.Observation ParseObservation(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Observation existingInstance = null )
        {
            Hl7.Fhir.Model.Observation result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Observation();
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
                
                // Parse element name
                else if( atName == "name" )
                    result.Name = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element value
                else if( atName.StartsWith("value") )
                    result.Value = FhirParser.ParseElement(reader, errors);
                
                // Parse element interpretation
                else if( atName == "interpretation" )
                    result.Interpretation = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element comments
                else if( atName == "comments" )
                    result.CommentsElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element applies
                else if( atName.StartsWith("applies") )
                    result.Applies = FhirParser.ParseElement(reader, errors);
                
                // Parse element issued
                else if( atName == "issued" )
                    result.IssuedElement = InstantParser.ParseInstant(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.ObservationStatus>(reader, errors);
                
                // Parse element reliability
                else if( atName == "reliability" )
                    result.ReliabilityElement = CodeParser.ParseCode<Hl7.Fhir.Model.Observation.ObservationReliability>(reader, errors);
                
                // Parse element bodySite
                else if( atName == "bodySite" )
                    result.BodySite = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element method
                else if( atName == "method" )
                    result.Method = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element identifier
                else if( atName == "identifier" )
                    result.Identifier = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element performer
                else if( atName == "performer" )
                    result.Performer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element referenceRange
                else if( atName == "referenceRange" )
                {
                    result.ReferenceRange = new List<Hl7.Fhir.Model.Observation.ObservationReferenceRangeComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "referenceRange") )
                        result.ReferenceRange.Add(ObservationParser.ParseObservationReferenceRangeComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element component
                else if( atName == "component" )
                {
                    result.Component = new List<Hl7.Fhir.Model.Observation.ObservationComponentComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "component") )
                        result.Component.Add(ObservationParser.ParseObservationComponentComponent(reader, errors));
                    
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
        /// Parse ObservationComponentComponent
        /// </summary>
        public static Hl7.Fhir.Model.Observation.ObservationComponentComponent ParseObservationComponentComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Observation.ObservationComponentComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Observation.ObservationComponentComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Observation.ObservationComponentComponent();
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
                
                // Parse element value
                else if( atName.StartsWith("value") )
                    result.Value = FhirParser.ParseElement(reader, errors);
                
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
        /// Parse ObservationReferenceRangeComponent
        /// </summary>
        public static Hl7.Fhir.Model.Observation.ObservationReferenceRangeComponent ParseObservationReferenceRangeComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Observation.ObservationReferenceRangeComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Observation.ObservationReferenceRangeComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Observation.ObservationReferenceRangeComponent();
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
                
                // Parse element meaning
                else if( atName == "meaning" )
                    result.Meaning = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element range
                else if( atName.StartsWith("range") )
                    result.Range = FhirParser.ParseElement(reader, errors);
                
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
