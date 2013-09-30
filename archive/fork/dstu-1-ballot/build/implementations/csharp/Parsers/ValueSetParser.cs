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
    /// Parser for ValueSet instances
    /// </summary>
    internal static partial class ValueSetParser
    {
        /// <summary>
        /// Parse ValueSet
        /// </summary>
        public static Hl7.Fhir.Model.ValueSet ParseValueSet(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ValueSet existingInstance = null )
        {
            Hl7.Fhir.Model.ValueSet result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ValueSet();
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
                    result.IdentifierElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element version
                else if( atName == "version" )
                    result.VersionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element name
                else if( atName == "name" )
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element publisher
                else if( atName == "publisher" )
                    result.PublisherElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element telecom
                else if( atName == "telecom" )
                {
                    result.Telecom = new List<Hl7.Fhir.Model.Contact>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "telecom") )
                        result.Telecom.Add(ContactParser.ParseContact(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element copyright
                else if( atName == "copyright" )
                    result.CopyrightElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.ValueSet.ValueSetStatus>(reader, errors);
                
                // Parse element experimental
                else if( atName == "experimental" )
                    result.ExperimentalElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element date
                else if( atName == "date" )
                    result.DateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element define
                else if( atName == "define" )
                    result.Define = ValueSetParser.ParseValueSetDefineComponent(reader, errors);
                
                // Parse element compose
                else if( atName == "compose" )
                    result.Compose = ValueSetParser.ParseValueSetComposeComponent(reader, errors);
                
                // Parse element expansion
                else if( atName == "expansion" )
                    result.Expansion = ValueSetParser.ParseValueSetExpansionComponent(reader, errors);
                
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
        /// Parse ValueSetDefineComponent
        /// </summary>
        public static Hl7.Fhir.Model.ValueSet.ValueSetDefineComponent ParseValueSetDefineComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ValueSet.ValueSetDefineComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ValueSet.ValueSetDefineComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ValueSet.ValueSetDefineComponent();
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
                
                // Parse element system
                else if( atName == "system" )
                    result.SystemElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element caseSensitive
                else if( atName == "caseSensitive" )
                    result.CaseSensitiveElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element concept
                else if( atName == "concept" )
                {
                    result.Concept = new List<Hl7.Fhir.Model.ValueSet.ValueSetDefineConceptComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "concept") )
                        result.Concept.Add(ValueSetParser.ParseValueSetDefineConceptComponent(reader, errors));
                    
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
        /// Parse ValueSetExpansionContainsComponent
        /// </summary>
        public static Hl7.Fhir.Model.ValueSet.ValueSetExpansionContainsComponent ParseValueSetExpansionContainsComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ValueSet.ValueSetExpansionContainsComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ValueSet.ValueSetExpansionContainsComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ValueSet.ValueSetExpansionContainsComponent();
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
                
                // Parse element system
                else if( atName == "system" )
                    result.SystemElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element code
                else if( atName == "code" )
                    result.CodeElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element display
                else if( atName == "display" )
                    result.DisplayElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element contains
                else if( atName == "contains" )
                {
                    result.Contains = new List<Hl7.Fhir.Model.ValueSet.ValueSetExpansionContainsComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "contains") )
                        result.Contains.Add(ValueSetParser.ParseValueSetExpansionContainsComponent(reader, errors));
                    
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
        /// Parse ConceptSetComponent
        /// </summary>
        public static Hl7.Fhir.Model.ValueSet.ConceptSetComponent ParseConceptSetComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ValueSet.ConceptSetComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ValueSet.ConceptSetComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ValueSet.ConceptSetComponent();
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
                
                // Parse element system
                else if( atName == "system" )
                    result.SystemElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element version
                else if( atName == "version" )
                    result.VersionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element code
                else if( atName == "code" )
                {
                    result.CodeElement = new List<Hl7.Fhir.Model.Code>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "code") )
                        result.CodeElement.Add(CodeParser.ParseCode(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element filter
                else if( atName == "filter" )
                {
                    result.Filter = new List<Hl7.Fhir.Model.ValueSet.ConceptSetFilterComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "filter") )
                        result.Filter.Add(ValueSetParser.ParseConceptSetFilterComponent(reader, errors));
                    
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
        /// Parse ConceptSetFilterComponent
        /// </summary>
        public static Hl7.Fhir.Model.ValueSet.ConceptSetFilterComponent ParseConceptSetFilterComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ValueSet.ConceptSetFilterComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ValueSet.ConceptSetFilterComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ValueSet.ConceptSetFilterComponent();
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
                
                // Parse element property
                else if( atName == "property" )
                    result.PropertyElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element op
                else if( atName == "op" )
                    result.OpElement = CodeParser.ParseCode<Hl7.Fhir.Model.ValueSet.FilterOperator>(reader, errors);
                
                // Parse element value
                else if( atName == "value" )
                    result.ValueElement = CodeParser.ParseCode(reader, errors);
                
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
        /// Parse ValueSetComposeComponent
        /// </summary>
        public static Hl7.Fhir.Model.ValueSet.ValueSetComposeComponent ParseValueSetComposeComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ValueSet.ValueSetComposeComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ValueSet.ValueSetComposeComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ValueSet.ValueSetComposeComponent();
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
                
                // Parse element import
                else if( atName == "import" )
                {
                    result.ImportElement = new List<Hl7.Fhir.Model.FhirUri>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "import") )
                        result.ImportElement.Add(FhirUriParser.ParseFhirUri(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element include
                else if( atName == "include" )
                {
                    result.Include = new List<Hl7.Fhir.Model.ValueSet.ConceptSetComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "include") )
                        result.Include.Add(ValueSetParser.ParseConceptSetComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element exclude
                else if( atName == "exclude" )
                {
                    result.Exclude = new List<Hl7.Fhir.Model.ValueSet.ConceptSetComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "exclude") )
                        result.Exclude.Add(ValueSetParser.ParseConceptSetComponent(reader, errors));
                    
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
        /// Parse ValueSetDefineConceptComponent
        /// </summary>
        public static Hl7.Fhir.Model.ValueSet.ValueSetDefineConceptComponent ParseValueSetDefineConceptComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ValueSet.ValueSetDefineConceptComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ValueSet.ValueSetDefineConceptComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ValueSet.ValueSetDefineConceptComponent();
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
                    result.CodeElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element abstract
                else if( atName == "abstract" )
                    result.AbstractElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element display
                else if( atName == "display" )
                    result.DisplayElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element definition
                else if( atName == "definition" )
                    result.DefinitionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element concept
                else if( atName == "concept" )
                {
                    result.Concept = new List<Hl7.Fhir.Model.ValueSet.ValueSetDefineConceptComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "concept") )
                        result.Concept.Add(ValueSetParser.ParseValueSetDefineConceptComponent(reader, errors));
                    
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
        /// Parse ValueSetExpansionComponent
        /// </summary>
        public static Hl7.Fhir.Model.ValueSet.ValueSetExpansionComponent ParseValueSetExpansionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.ValueSet.ValueSetExpansionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.ValueSet.ValueSetExpansionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.ValueSet.ValueSetExpansionComponent();
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
                
                // Parse element timestamp
                else if( atName == "timestamp" )
                    result.TimestampElement = InstantParser.ParseInstant(reader, errors);
                
                // Parse element contains
                else if( atName == "contains" )
                {
                    result.Contains = new List<Hl7.Fhir.Model.ValueSet.ValueSetExpansionContainsComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "contains") )
                        result.Contains.Add(ValueSetParser.ParseValueSetExpansionContainsComponent(reader, errors));
                    
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
