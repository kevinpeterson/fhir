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
    /// Parser for ImmunizationProfile instances
    /// </summary>
    internal static partial class ImmunizationProfileParser
    {
        /// <summary>
        /// Parse ImmunizationProfile
        /// </summary>
        public static Hl7.Fhir.Model.ImmunizationProfile ParseImmunizationProfile(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ImmunizationProfile existingInstance = null )
        {
            Hl7.Fhir.Model.ImmunizationProfile result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ImmunizationProfile();
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
                
                // Parse element recommendation
                else if( atName == "recommendation" )
                {
                    result.Recommendation = new List<Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "recommendation") )
                        result.Recommendation.Add(ImmunizationProfileParser.ParseImmunizationProfileRecommendationComponent(reader, errors));
                    
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
        /// Parse ImmunizationProfileRecommendationProtocolComponent
        /// </summary>
        public static Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent ParseImmunizationProfileRecommendationProtocolComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent();
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
                
                // Parse element doseSequence
                else if( atName == "doseSequence" )
                    result.DoseSequenceElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element authority
                else if( atName == "authority" )
                    result.Authority = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element series
                else if( atName == "series" )
                    result.SeriesElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse ImmunizationProfileRecommendationDateCriterionComponent
        /// </summary>
        public static Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent ParseImmunizationProfileRecommendationDateCriterionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent();
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
                
                // Parse element value
                else if( atName == "value" )
                    result.ValueElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
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
        /// Parse ImmunizationProfileRecommendationSupportingAdverseEventReportComponent
        /// </summary>
        public static Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent ParseImmunizationProfileRecommendationSupportingAdverseEventReportComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent();
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
                
                // Parse element identifier
                else if( atName == "identifier" )
                {
                    result.IdentifierElement = new List<Hl7.Fhir.Model.Id>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                        result.IdentifierElement.Add(IdParser.ParseId(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element reportType
                else if( atName == "reportType" )
                    result.ReportType = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element reportDate
                else if( atName == "reportDate" )
                    result.ReportDateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element text
                else if( atName == "text" )
                    result.TextElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element reaction
                else if( atName == "reaction" )
                {
                    result.Reaction = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "reaction") )
                        result.Reaction.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
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
        /// Parse ImmunizationProfileRecommendationComponent
        /// </summary>
        public static Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationComponent ParseImmunizationProfileRecommendationComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationComponent();
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
                
                // Parse element recommendationDate
                else if( atName == "recommendationDate" )
                    result.RecommendationDateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element vaccineType
                else if( atName == "vaccineType" )
                    result.VaccineType = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element doseNumber
                else if( atName == "doseNumber" )
                    result.DoseNumberElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element forecastStatus
                else if( atName == "forecastStatus" )
                    result.ForecastStatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.ImmunizationProfile.ImmunizationForecastStatus>(reader, errors);
                
                // Parse element dateCriterion
                else if( atName == "dateCriterion" )
                {
                    result.DateCriterion = new List<Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "dateCriterion") )
                        result.DateCriterion.Add(ImmunizationProfileParser.ParseImmunizationProfileRecommendationDateCriterionComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element protocol
                else if( atName == "protocol" )
                    result.Protocol = ImmunizationProfileParser.ParseImmunizationProfileRecommendationProtocolComponent(reader, errors);
                
                // Parse element supportingImmunization
                else if( atName == "supportingImmunization" )
                {
                    result.SupportingImmunization = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "supportingImmunization") )
                        result.SupportingImmunization.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element supportingAdverseEventReport
                else if( atName == "supportingAdverseEventReport" )
                {
                    result.SupportingAdverseEventReport = new List<Hl7.Fhir.Model.ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "supportingAdverseEventReport") )
                        result.SupportingAdverseEventReport.Add(ImmunizationProfileParser.ParseImmunizationProfileRecommendationSupportingAdverseEventReportComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element supportingPatientObservation
                else if( atName == "supportingPatientObservation" )
                {
                    result.SupportingPatientObservation = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "supportingPatientObservation") )
                        result.SupportingPatientObservation.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
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
