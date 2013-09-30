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
    /// Parser for Specimen instances
    /// </summary>
    internal static partial class SpecimenParser
    {
        /// <summary>
        /// Parse Specimen
        /// </summary>
        public static Hl7.Fhir.Model.Specimen ParseSpecimen(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Specimen existingInstance = null )
        {
            Hl7.Fhir.Model.Specimen result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Specimen();
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
                
                // Parse element identifier
                else if( atName == "identifier" )
                    result.Identifier = IdentifierParser.ParseIdentifier(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element source
                else if( atName == "source" )
                {
                    result.Source = new List<Hl7.Fhir.Model.Specimen.SpecimenSourceComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "source") )
                        result.Source.Add(SpecimenParser.ParseSpecimenSourceComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element subject
                else if( atName == "subject" )
                    result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element accessionIdentifier
                else if( atName == "accessionIdentifier" )
                {
                    result.AccessionIdentifier = new List<Hl7.Fhir.Model.Identifier>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "accessionIdentifier") )
                        result.AccessionIdentifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element receivedTime
                else if( atName == "receivedTime" )
                    result.ReceivedTimeElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element collection
                else if( atName == "collection" )
                    result.Collection = SpecimenParser.ParseSpecimenCollectionComponent(reader, errors);
                
                // Parse element treatment
                else if( atName == "treatment" )
                {
                    result.Treatment = new List<Hl7.Fhir.Model.Specimen.SpecimenTreatmentComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "treatment") )
                        result.Treatment.Add(SpecimenParser.ParseSpecimenTreatmentComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element container
                else if( atName == "container" )
                {
                    result.Container = new List<Hl7.Fhir.Model.Specimen.SpecimenContainerComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "container") )
                        result.Container.Add(SpecimenParser.ParseSpecimenContainerComponent(reader, errors));
                    
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
        /// Parse SpecimenCollectionComponent
        /// </summary>
        public static Hl7.Fhir.Model.Specimen.SpecimenCollectionComponent ParseSpecimenCollectionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Specimen.SpecimenCollectionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Specimen.SpecimenCollectionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Specimen.SpecimenCollectionComponent();
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
                
                // Parse element collector
                else if( atName == "collector" )
                    result.Collector = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element comment
                else if( atName == "comment" )
                {
                    result.CommentElement = new List<Hl7.Fhir.Model.FhirString>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "comment") )
                        result.CommentElement.Add(FhirStringParser.ParseFhirString(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element collectedTime
                else if( atName == "collectedTime" )
                    result.CollectedTimeElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element quantity
                else if( atName == "quantity" )
                    result.Quantity = QuantityParser.ParseQuantity(reader, errors);
                
                // Parse element method
                else if( atName == "method" )
                    result.Method = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element sourceSite
                else if( atName == "sourceSite" )
                    result.SourceSite = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
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
        /// Parse SpecimenSourceComponent
        /// </summary>
        public static Hl7.Fhir.Model.Specimen.SpecimenSourceComponent ParseSpecimenSourceComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Specimen.SpecimenSourceComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Specimen.SpecimenSourceComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Specimen.SpecimenSourceComponent();
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
                
                // Parse element relationship
                else if( atName == "relationship" )
                    result.RelationshipElement = CodeParser.ParseCode<Hl7.Fhir.Model.Specimen.HierarchicalRelationshipType>(reader, errors);
                
                // Parse element target
                else if( atName == "target" )
                {
                    result.Target = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "target") )
                        result.Target.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
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
        /// Parse SpecimenTreatmentComponent
        /// </summary>
        public static Hl7.Fhir.Model.Specimen.SpecimenTreatmentComponent ParseSpecimenTreatmentComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Specimen.SpecimenTreatmentComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Specimen.SpecimenTreatmentComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Specimen.SpecimenTreatmentComponent();
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
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element procedure
                else if( atName == "procedure" )
                    result.Procedure = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element additive
                else if( atName == "additive" )
                {
                    result.Additive = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "additive") )
                        result.Additive.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
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
        /// Parse SpecimenContainerComponent
        /// </summary>
        public static Hl7.Fhir.Model.Specimen.SpecimenContainerComponent ParseSpecimenContainerComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Specimen.SpecimenContainerComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Specimen.SpecimenContainerComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Specimen.SpecimenContainerComponent();
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
                    result.Identifier = new List<Hl7.Fhir.Model.Identifier>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                        result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element capacity
                else if( atName == "capacity" )
                    result.Capacity = QuantityParser.ParseQuantity(reader, errors);
                
                // Parse element specimenQuantity
                else if( atName == "specimenQuantity" )
                    result.SpecimenQuantity = QuantityParser.ParseQuantity(reader, errors);
                
                // Parse element additive
                else if( atName == "additive" )
                    result.Additive = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
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
