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
    /// Parser for AdverseReaction instances
    /// </summary>
    internal static partial class AdverseReactionParser
    {
        /// <summary>
        /// Parse AdverseReaction
        /// </summary>
        public static Hl7.Fhir.Model.AdverseReaction ParseAdverseReaction(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.AdverseReaction existingInstance = null )
        {
            Hl7.Fhir.Model.AdverseReaction result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.AdverseReaction();
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
                
                // Parse element reactionDate
                else if( atName == "reactionDate" )
                    result.ReactionDateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element didNotOccurFlag
                else if( atName == "didNotOccurFlag" )
                    result.DidNotOccurFlagElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element recorder
                else if( atName == "recorder" )
                    result.Recorder = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element symptom
                else if( atName == "symptom" )
                {
                    result.Symptom = new List<Hl7.Fhir.Model.AdverseReaction.AdverseReactionSymptomComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "symptom") )
                        result.Symptom.Add(AdverseReactionParser.ParseAdverseReactionSymptomComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element exposure
                else if( atName == "exposure" )
                {
                    result.Exposure = new List<Hl7.Fhir.Model.AdverseReaction.AdverseReactionExposureComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "exposure") )
                        result.Exposure.Add(AdverseReactionParser.ParseAdverseReactionExposureComponent(reader, errors));
                    
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
        /// Parse AdverseReactionSymptomComponent
        /// </summary>
        public static Hl7.Fhir.Model.AdverseReaction.AdverseReactionSymptomComponent ParseAdverseReactionSymptomComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.AdverseReaction.AdverseReactionSymptomComponent existingInstance = null )
        {
            Hl7.Fhir.Model.AdverseReaction.AdverseReactionSymptomComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.AdverseReaction.AdverseReactionSymptomComponent();
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
                
                // Parse element severity
                else if( atName == "severity" )
                    result.SeverityElement = CodeParser.ParseCode<Hl7.Fhir.Model.AdverseReaction.ReactionSeverity>(reader, errors);
                
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
        /// Parse AdverseReactionExposureComponent
        /// </summary>
        public static Hl7.Fhir.Model.AdverseReaction.AdverseReactionExposureComponent ParseAdverseReactionExposureComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.AdverseReaction.AdverseReactionExposureComponent existingInstance = null )
        {
            Hl7.Fhir.Model.AdverseReaction.AdverseReactionExposureComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.AdverseReaction.AdverseReactionExposureComponent();
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
                
                // Parse element exposureDate
                else if( atName == "exposureDate" )
                    result.ExposureDateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element exposureType
                else if( atName == "exposureType" )
                    result.ExposureTypeElement = CodeParser.ParseCode<Hl7.Fhir.Model.AdverseReaction.ExposureType>(reader, errors);
                
                // Parse element causalityExpectation
                else if( atName == "causalityExpectation" )
                    result.CausalityExpectationElement = CodeParser.ParseCode<Hl7.Fhir.Model.AdverseReaction.CausalityExpectation>(reader, errors);
                
                // Parse element substance
                else if( atName == "substance" )
                    result.Substance = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
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
