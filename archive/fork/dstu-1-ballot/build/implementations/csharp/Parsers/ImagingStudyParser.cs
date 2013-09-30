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
    /// Parser for ImagingStudy instances
    /// </summary>
    internal static partial class ImagingStudyParser
    {
        /// <summary>
        /// Parse ImagingStudy
        /// </summary>
        public static Hl7.Fhir.Model.ImagingStudy ParseImagingStudy(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ImagingStudy existingInstance = null )
        {
            Hl7.Fhir.Model.ImagingStudy result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ImagingStudy();
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
                
                // Parse element dateTime
                else if( atName == "dateTime" )
                    result.DateTimeElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element uid
                else if( atName == "uid" )
                    result.UidElement = OidParser.ParseOid(reader, errors);
                
                // Parse element accessionNo
                else if( atName == "accessionNo" )
                    result.AccessionNo = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element identifier
                else if( atName == "identifier" )
                {
                    result.Identifier = new List<Hl7.Fhir.Model.Identifier>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                        result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element modality
                else if( atName == "modality" )
                {
                    result.Modality_Element = new List<Code<Hl7.Fhir.Model.ImagingStudy.ImagingModality>>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "modality") )
                        result.Modality_Element.Add(CodeParser.ParseCode<Hl7.Fhir.Model.ImagingStudy.ImagingModality>(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element referrer
                else if( atName == "referrer" )
                    result.Referrer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element availability
                else if( atName == "availability" )
                    result.AvailabilityElement = CodeParser.ParseCode<Hl7.Fhir.Model.ImagingStudy.InstanceAvailability>(reader, errors);
                
                // Parse element url
                else if( atName == "url" )
                    result.UrlElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element numberOfSeries
                else if( atName == "numberOfSeries" )
                    result.NumberOfSeriesElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element numberOfInstances
                else if( atName == "numberOfInstances" )
                    result.NumberOfInstancesElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element clinicalInformation
                else if( atName == "clinicalInformation" )
                    result.ClinicalInformationElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element procedure
                else if( atName == "procedure" )
                {
                    result.Procedure = new List<Hl7.Fhir.Model.Coding>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "procedure") )
                        result.Procedure.Add(CodingParser.ParseCoding(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element interpreter
                else if( atName == "interpreter" )
                    result.Interpreter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element series
                else if( atName == "series" )
                {
                    result.Series = new List<Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "series") )
                        result.Series.Add(ImagingStudyParser.ParseImagingStudySeriesComponent(reader, errors));
                    
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
        /// Parse ImagingStudySeriesComponent
        /// </summary>
        public static Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesComponent ParseImagingStudySeriesComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesComponent();
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
                
                // Parse element number
                else if( atName == "number" )
                    result.NumberElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element modality
                else if( atName == "modality" )
                    result.ModalityElement = CodeParser.ParseCode<Hl7.Fhir.Model.ImagingStudy.Modality>(reader, errors);
                
                // Parse element uid
                else if( atName == "uid" )
                    result.UidElement = OidParser.ParseOid(reader, errors);
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element numberOfInstances
                else if( atName == "numberOfInstances" )
                    result.NumberOfInstancesElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element availability
                else if( atName == "availability" )
                    result.AvailabilityElement = CodeParser.ParseCode<Hl7.Fhir.Model.ImagingStudy.InstanceAvailability>(reader, errors);
                
                // Parse element url
                else if( atName == "url" )
                    result.UrlElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element bodySite
                else if( atName == "bodySite" )
                    result.BodySite = CodingParser.ParseCoding(reader, errors);
                
                // Parse element dateTime
                else if( atName == "dateTime" )
                    result.DateTimeElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element instance
                else if( atName == "instance" )
                {
                    result.Instance = new List<Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesInstanceComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "instance") )
                        result.Instance.Add(ImagingStudyParser.ParseImagingStudySeriesInstanceComponent(reader, errors));
                    
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
        /// Parse ImagingStudySeriesInstanceComponent
        /// </summary>
        public static Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesInstanceComponent ParseImagingStudySeriesInstanceComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesInstanceComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesInstanceComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesInstanceComponent();
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
                
                // Parse element number
                else if( atName == "number" )
                    result.NumberElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element uid
                else if( atName == "uid" )
                    result.UidElement = OidParser.ParseOid(reader, errors);
                
                // Parse element sopclass
                else if( atName == "sopclass" )
                    result.SopclassElement = OidParser.ParseOid(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.TypeElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element title
                else if( atName == "title" )
                    result.TitleElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element url
                else if( atName == "url" )
                    result.UrlElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element attachment
                else if( atName == "attachment" )
                    result.Attachment = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
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
