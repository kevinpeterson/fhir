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
    /// Parser for Profile instances
    /// </summary>
    internal static partial class ProfileParser
    {
        /// <summary>
        /// Parse Profile
        /// </summary>
        public static Hl7.Fhir.Model.Profile ParseProfile(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Profile existingInstance = null )
        {
            Hl7.Fhir.Model.Profile result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Profile();
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
                
                // Parse element code
                else if( atName == "code" )
                {
                    result.Code = new List<Hl7.Fhir.Model.Coding>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "code") )
                        result.Code.Add(CodingParser.ParseCoding(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element status
                else if( atName == "status" )
                    result.StatusElement = CodeParser.ParseCode<Hl7.Fhir.Model.Profile.ResourceProfileStatus>(reader, errors);
                
                // Parse element experimental
                else if( atName == "experimental" )
                    result.ExperimentalElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element date
                else if( atName == "date" )
                    result.DateElement = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                
                // Parse element fhirVersion
                else if( atName == "fhirVersion" )
                    result.FhirVersionElement = IdParser.ParseId(reader, errors);
                
                // Parse element structure
                else if( atName == "structure" )
                {
                    result.Structure = new List<Hl7.Fhir.Model.Profile.ProfileStructureComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "structure") )
                        result.Structure.Add(ProfileParser.ParseProfileStructureComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element extensionDefn
                else if( atName == "extensionDefn" )
                {
                    result.ExtensionDefn = new List<Hl7.Fhir.Model.Profile.ProfileExtensionDefnComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extensionDefn") )
                        result.ExtensionDefn.Add(ProfileParser.ParseProfileExtensionDefnComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element binding
                else if( atName == "binding" )
                {
                    result.Binding = new List<Hl7.Fhir.Model.Profile.ProfileBindingComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "binding") )
                        result.Binding.Add(ProfileParser.ParseProfileBindingComponent(reader, errors));
                    
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
        /// Parse ElementDefinitionComponent
        /// </summary>
        public static Hl7.Fhir.Model.Profile.ElementDefinitionComponent ParseElementDefinitionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Profile.ElementDefinitionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Profile.ElementDefinitionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Profile.ElementDefinitionComponent();
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
                
                // Parse element short
                else if( atName == "short" )
                    result.ShortElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element formal
                else if( atName == "formal" )
                    result.FormalElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element comments
                else if( atName == "comments" )
                    result.CommentsElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element requirements
                else if( atName == "requirements" )
                    result.RequirementsElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element synonym
                else if( atName == "synonym" )
                {
                    result.SynonymElement = new List<Hl7.Fhir.Model.FhirString>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "synonym") )
                        result.SynonymElement.Add(FhirStringParser.ParseFhirString(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element min
                else if( atName == "min" )
                    result.MinElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element max
                else if( atName == "max" )
                    result.MaxElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                {
                    result.Type = new List<Hl7.Fhir.Model.Profile.TypeRefComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "type") )
                        result.Type.Add(ProfileParser.ParseTypeRefComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element nameReference
                else if( atName == "nameReference" )
                    result.NameReferenceElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element value
                else if( atName.StartsWith("value") )
                    result.Value = FhirParser.ParseElement(reader, errors);
                
                // Parse element example
                else if( atName.StartsWith("example") )
                    result.Example = FhirParser.ParseElement(reader, errors);
                
                // Parse element maxLength
                else if( atName == "maxLength" )
                    result.MaxLengthElement = IntegerParser.ParseInteger(reader, errors);
                
                // Parse element condition
                else if( atName == "condition" )
                {
                    result.ConditionElement = new List<Hl7.Fhir.Model.Id>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "condition") )
                        result.ConditionElement.Add(IdParser.ParseId(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element constraint
                else if( atName == "constraint" )
                {
                    result.Constraint = new List<Hl7.Fhir.Model.Profile.ElementDefinitionConstraintComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "constraint") )
                        result.Constraint.Add(ProfileParser.ParseElementDefinitionConstraintComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element mustSupport
                else if( atName == "mustSupport" )
                    result.MustSupportElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element isModifier
                else if( atName == "isModifier" )
                    result.IsModifierElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element binding
                else if( atName == "binding" )
                    result.BindingElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element mapping
                else if( atName == "mapping" )
                {
                    result.Mapping = new List<Hl7.Fhir.Model.Profile.ElementDefinitionMappingComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "mapping") )
                        result.Mapping.Add(ProfileParser.ParseElementDefinitionMappingComponent(reader, errors));
                    
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
        /// Parse ElementSlicingComponent
        /// </summary>
        public static Hl7.Fhir.Model.Profile.ElementSlicingComponent ParseElementSlicingComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Profile.ElementSlicingComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Profile.ElementSlicingComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Profile.ElementSlicingComponent();
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
                
                // Parse element discriminator
                else if( atName == "discriminator" )
                    result.DiscriminatorElement = IdParser.ParseId(reader, errors);
                
                // Parse element ordered
                else if( atName == "ordered" )
                    result.OrderedElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element rules
                else if( atName == "rules" )
                    result.RulesElement = CodeParser.ParseCode<Hl7.Fhir.Model.Profile.SlicingRules>(reader, errors);
                
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
        /// Parse ProfileStructureComponent
        /// </summary>
        public static Hl7.Fhir.Model.Profile.ProfileStructureComponent ParseProfileStructureComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Profile.ProfileStructureComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Profile.ProfileStructureComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Profile.ProfileStructureComponent();
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
                    result.TypeElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element name
                else if( atName == "name" )
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element publish
                else if( atName == "publish" )
                    result.PublishElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element purpose
                else if( atName == "purpose" )
                    result.PurposeElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element element
                else if( atName == "element" )
                {
                    result.Element = new List<Hl7.Fhir.Model.Profile.ElementComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "element") )
                        result.Element.Add(ProfileParser.ParseElementComponent(reader, errors));
                    
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
        /// Parse ProfileBindingComponent
        /// </summary>
        public static Hl7.Fhir.Model.Profile.ProfileBindingComponent ParseProfileBindingComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Profile.ProfileBindingComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Profile.ProfileBindingComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Profile.ProfileBindingComponent();
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
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element isExtensible
                else if( atName == "isExtensible" )
                    result.IsExtensibleElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
                // Parse element conformance
                else if( atName == "conformance" )
                    result.ConformanceElement = CodeParser.ParseCode<Hl7.Fhir.Model.Profile.BindingConformance>(reader, errors);
                
                // Parse element description
                else if( atName == "description" )
                    result.DescriptionElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element reference
                else if( atName.StartsWith("reference") )
                    result.Reference = FhirParser.ParseElement(reader, errors);
                
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
        /// Parse TypeRefComponent
        /// </summary>
        public static Hl7.Fhir.Model.Profile.TypeRefComponent ParseTypeRefComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Profile.TypeRefComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Profile.TypeRefComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Profile.TypeRefComponent();
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
                
                // Parse element profile
                else if( atName == "profile" )
                    result.ProfileElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element bundled
                else if( atName == "bundled" )
                    result.BundledElement = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                
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
        /// Parse ElementDefinitionMappingComponent
        /// </summary>
        public static Hl7.Fhir.Model.Profile.ElementDefinitionMappingComponent ParseElementDefinitionMappingComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Profile.ElementDefinitionMappingComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Profile.ElementDefinitionMappingComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Profile.ElementDefinitionMappingComponent();
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
                
                // Parse element target
                else if( atName == "target" )
                    result.TargetElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element map
                else if( atName == "map" )
                    result.MapElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse ElementDefinitionConstraintComponent
        /// </summary>
        public static Hl7.Fhir.Model.Profile.ElementDefinitionConstraintComponent ParseElementDefinitionConstraintComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Profile.ElementDefinitionConstraintComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Profile.ElementDefinitionConstraintComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Profile.ElementDefinitionConstraintComponent();
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
                
                // Parse element key
                else if( atName == "key" )
                    result.KeyElement = IdParser.ParseId(reader, errors);
                
                // Parse element name
                else if( atName == "name" )
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element severity
                else if( atName == "severity" )
                    result.SeverityElement = CodeParser.ParseCode<Hl7.Fhir.Model.Profile.ConstraintSeverity>(reader, errors);
                
                // Parse element human
                else if( atName == "human" )
                    result.HumanElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element xpath
                else if( atName == "xpath" )
                    result.XpathElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element ocl
                else if( atName == "ocl" )
                    result.OclElement = FhirStringParser.ParseFhirString(reader, errors);
                
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
        /// Parse ElementComponent
        /// </summary>
        public static Hl7.Fhir.Model.Profile.ElementComponent ParseElementComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Profile.ElementComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Profile.ElementComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Profile.ElementComponent();
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
                
                // Parse element path
                else if( atName == "path" )
                    result.PathElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element name
                else if( atName == "name" )
                    result.NameElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element slicing
                else if( atName == "slicing" )
                    result.Slicing = ProfileParser.ParseElementSlicingComponent(reader, errors);
                
                // Parse element definition
                else if( atName == "definition" )
                    result.Definition = ProfileParser.ParseElementDefinitionComponent(reader, errors);
                
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
        /// Parse ProfileExtensionDefnComponent
        /// </summary>
        public static Hl7.Fhir.Model.Profile.ProfileExtensionDefnComponent ParseProfileExtensionDefnComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Profile.ProfileExtensionDefnComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Profile.ProfileExtensionDefnComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Profile.ProfileExtensionDefnComponent();
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
                
                // Parse element contextType
                else if( atName == "contextType" )
                    result.ContextTypeElement = CodeParser.ParseCode<Hl7.Fhir.Model.Profile.ExtensionContext>(reader, errors);
                
                // Parse element context
                else if( atName == "context" )
                {
                    result.ContextElement = new List<Hl7.Fhir.Model.FhirString>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "context") )
                        result.ContextElement.Add(FhirStringParser.ParseFhirString(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element definition
                else if( atName == "definition" )
                    result.Definition = ProfileParser.ParseElementDefinitionComponent(reader, errors);
                
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
