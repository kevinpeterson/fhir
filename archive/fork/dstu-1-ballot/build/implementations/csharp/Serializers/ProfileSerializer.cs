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
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Profile instances
    */
    internal static partial class ProfileSerializer
    {
        public static void SerializeProfile(Hl7.Fhir.Model.Profile value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Profile");
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element language
            if(value.LanguageElement != null && !summary)
            {
                writer.WriteStartElement("language");
                CodeSerializer.SerializeCode(value.LanguageElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.Text != null && !summary)
            {
                writer.WriteStartElement("text");
                NarrativeSerializer.SerializeNarrative(value.Text, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element contained
            if(value.Contained != null && !summary && value.Contained.Count > 0)
            {
                writer.WriteStartArrayElement("contained");
                foreach(var item in value.Contained)
                {
                    writer.WriteStartArrayMember("contained");
                    FhirSerializer.SerializeResource(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element identifier
            if(value.IdentifierElement != null)
            {
                writer.WriteStartElement("identifier");
                FhirStringSerializer.SerializeFhirString(value.IdentifierElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element version
            if(value.VersionElement != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.VersionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.NameElement != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element publisher
            if(value.PublisherElement != null)
            {
                writer.WriteStartElement("publisher");
                FhirStringSerializer.SerializeFhirString(value.PublisherElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element telecom
            if(value.Telecom != null && value.Telecom.Count > 0)
            {
                writer.WriteStartArrayElement("telecom");
                foreach(var item in value.Telecom)
                {
                    writer.WriteStartArrayMember("telecom");
                    ContactSerializer.SerializeContact(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element description
            if(value.DescriptionElement != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null && value.Code.Count > 0)
            {
                writer.WriteStartArrayElement("code");
                foreach(var item in value.Code)
                {
                    writer.WriteStartArrayMember("code");
                    CodingSerializer.SerializeCoding(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Profile.ResourceProfileStatus>(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element experimental
            if(value.ExperimentalElement != null)
            {
                writer.WriteStartElement("experimental");
                FhirBooleanSerializer.SerializeFhirBoolean(value.ExperimentalElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element date
            if(value.DateElement != null)
            {
                writer.WriteStartElement("date");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element fhirVersion
            if(value.FhirVersionElement != null)
            {
                writer.WriteStartElement("fhirVersion");
                IdSerializer.SerializeId(value.FhirVersionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element structure
            if(value.Structure != null && !summary && value.Structure.Count > 0)
            {
                writer.WriteStartArrayElement("structure");
                foreach(var item in value.Structure)
                {
                    writer.WriteStartArrayMember("structure");
                    ProfileSerializer.SerializeProfileStructureComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element extensionDefn
            if(value.ExtensionDefn != null && !summary && value.ExtensionDefn.Count > 0)
            {
                writer.WriteStartArrayElement("extensionDefn");
                foreach(var item in value.ExtensionDefn)
                {
                    writer.WriteStartArrayMember("extensionDefn");
                    ProfileSerializer.SerializeProfileExtensionDefnComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element binding
            if(value.Binding != null && !summary && value.Binding.Count > 0)
            {
                writer.WriteStartArrayElement("binding");
                foreach(var item in value.Binding)
                {
                    writer.WriteStartArrayMember("binding");
                    ProfileSerializer.SerializeProfileBindingComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeElementDefinitionComponent(Hl7.Fhir.Model.Profile.ElementDefinitionComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element short
            if(value.ShortElement != null)
            {
                writer.WriteStartElement("short");
                FhirStringSerializer.SerializeFhirString(value.ShortElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element formal
            if(value.FormalElement != null)
            {
                writer.WriteStartElement("formal");
                FhirStringSerializer.SerializeFhirString(value.FormalElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element comments
            if(value.CommentsElement != null)
            {
                writer.WriteStartElement("comments");
                FhirStringSerializer.SerializeFhirString(value.CommentsElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element requirements
            if(value.RequirementsElement != null)
            {
                writer.WriteStartElement("requirements");
                FhirStringSerializer.SerializeFhirString(value.RequirementsElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element synonym
            if(value.SynonymElement != null && value.SynonymElement.Count > 0)
            {
                writer.WriteStartArrayElement("synonym");
                foreach(var item in value.SynonymElement)
                {
                    writer.WriteStartArrayMember("synonym");
                    FhirStringSerializer.SerializeFhirString(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element min
            if(value.MinElement != null)
            {
                writer.WriteStartElement("min");
                IntegerSerializer.SerializeInteger(value.MinElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element max
            if(value.MaxElement != null)
            {
                writer.WriteStartElement("max");
                FhirStringSerializer.SerializeFhirString(value.MaxElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null && value.Type.Count > 0)
            {
                writer.WriteStartArrayElement("type");
                foreach(var item in value.Type)
                {
                    writer.WriteStartArrayMember("type");
                    ProfileSerializer.SerializeTypeRefComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element nameReference
            if(value.NameReferenceElement != null)
            {
                writer.WriteStartElement("nameReference");
                FhirStringSerializer.SerializeFhirString(value.NameReferenceElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element value
            if(value.Value != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("value", value.Value.GetType()) );
                FhirSerializer.SerializeElement(value.Value, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element example
            if(value.Example != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("example", value.Example.GetType()) );
                FhirSerializer.SerializeElement(value.Example, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element maxLength
            if(value.MaxLengthElement != null)
            {
                writer.WriteStartElement("maxLength");
                IntegerSerializer.SerializeInteger(value.MaxLengthElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element condition
            if(value.ConditionElement != null && value.ConditionElement.Count > 0)
            {
                writer.WriteStartArrayElement("condition");
                foreach(var item in value.ConditionElement)
                {
                    writer.WriteStartArrayMember("condition");
                    IdSerializer.SerializeId(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element constraint
            if(value.Constraint != null && value.Constraint.Count > 0)
            {
                writer.WriteStartArrayElement("constraint");
                foreach(var item in value.Constraint)
                {
                    writer.WriteStartArrayMember("constraint");
                    ProfileSerializer.SerializeElementDefinitionConstraintComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element mustSupport
            if(value.MustSupportElement != null)
            {
                writer.WriteStartElement("mustSupport");
                FhirBooleanSerializer.SerializeFhirBoolean(value.MustSupportElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element isModifier
            if(value.IsModifierElement != null)
            {
                writer.WriteStartElement("isModifier");
                FhirBooleanSerializer.SerializeFhirBoolean(value.IsModifierElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element binding
            if(value.BindingElement != null)
            {
                writer.WriteStartElement("binding");
                FhirUriSerializer.SerializeFhirUri(value.BindingElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element mapping
            if(value.Mapping != null && value.Mapping.Count > 0)
            {
                writer.WriteStartArrayElement("mapping");
                foreach(var item in value.Mapping)
                {
                    writer.WriteStartArrayMember("mapping");
                    ProfileSerializer.SerializeElementDefinitionMappingComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeElementSlicingComponent(Hl7.Fhir.Model.Profile.ElementSlicingComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element discriminator
            if(value.DiscriminatorElement != null)
            {
                writer.WriteStartElement("discriminator");
                IdSerializer.SerializeId(value.DiscriminatorElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element ordered
            if(value.OrderedElement != null)
            {
                writer.WriteStartElement("ordered");
                FhirBooleanSerializer.SerializeFhirBoolean(value.OrderedElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element rules
            if(value.RulesElement != null)
            {
                writer.WriteStartElement("rules");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Profile.SlicingRules>(value.RulesElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProfileStructureComponent(Hl7.Fhir.Model.Profile.ProfileStructureComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element type
            if(value.TypeElement != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode(value.TypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.NameElement != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element publish
            if(value.PublishElement != null)
            {
                writer.WriteStartElement("publish");
                FhirBooleanSerializer.SerializeFhirBoolean(value.PublishElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element purpose
            if(value.PurposeElement != null)
            {
                writer.WriteStartElement("purpose");
                FhirStringSerializer.SerializeFhirString(value.PurposeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element element
            if(value.Element != null && value.Element.Count > 0)
            {
                writer.WriteStartArrayElement("element");
                foreach(var item in value.Element)
                {
                    writer.WriteStartArrayMember("element");
                    ProfileSerializer.SerializeElementComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProfileBindingComponent(Hl7.Fhir.Model.Profile.ProfileBindingComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element name
            if(value.NameElement != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element isExtensible
            if(value.IsExtensibleElement != null)
            {
                writer.WriteStartElement("isExtensible");
                FhirBooleanSerializer.SerializeFhirBoolean(value.IsExtensibleElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element conformance
            if(value.ConformanceElement != null)
            {
                writer.WriteStartElement("conformance");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Profile.BindingConformance>(value.ConformanceElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.DescriptionElement != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.DescriptionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reference
            if(value.Reference != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("reference", value.Reference.GetType()) );
                FhirSerializer.SerializeElement(value.Reference, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeTypeRefComponent(Hl7.Fhir.Model.Profile.TypeRefComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element code
            if(value.CodeElement != null)
            {
                writer.WriteStartElement("code");
                CodeSerializer.SerializeCode(value.CodeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element profile
            if(value.ProfileElement != null)
            {
                writer.WriteStartElement("profile");
                FhirUriSerializer.SerializeFhirUri(value.ProfileElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element bundled
            if(value.BundledElement != null)
            {
                writer.WriteStartElement("bundled");
                FhirBooleanSerializer.SerializeFhirBoolean(value.BundledElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeElementDefinitionMappingComponent(Hl7.Fhir.Model.Profile.ElementDefinitionMappingComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element target
            if(value.TargetElement != null)
            {
                writer.WriteStartElement("target");
                FhirUriSerializer.SerializeFhirUri(value.TargetElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element map
            if(value.MapElement != null)
            {
                writer.WriteStartElement("map");
                FhirStringSerializer.SerializeFhirString(value.MapElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeElementDefinitionConstraintComponent(Hl7.Fhir.Model.Profile.ElementDefinitionConstraintComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element key
            if(value.KeyElement != null)
            {
                writer.WriteStartElement("key");
                IdSerializer.SerializeId(value.KeyElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.NameElement != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element severity
            if(value.SeverityElement != null)
            {
                writer.WriteStartElement("severity");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Profile.ConstraintSeverity>(value.SeverityElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element human
            if(value.HumanElement != null)
            {
                writer.WriteStartElement("human");
                FhirStringSerializer.SerializeFhirString(value.HumanElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element xpath
            if(value.XpathElement != null)
            {
                writer.WriteStartElement("xpath");
                FhirStringSerializer.SerializeFhirString(value.XpathElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element ocl
            if(value.OclElement != null)
            {
                writer.WriteStartElement("ocl");
                FhirStringSerializer.SerializeFhirString(value.OclElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeElementComponent(Hl7.Fhir.Model.Profile.ElementComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element path
            if(value.PathElement != null)
            {
                writer.WriteStartElement("path");
                FhirStringSerializer.SerializeFhirString(value.PathElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.NameElement != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.NameElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element slicing
            if(value.Slicing != null)
            {
                writer.WriteStartElement("slicing");
                ProfileSerializer.SerializeElementSlicingComponent(value.Slicing, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element definition
            if(value.Definition != null)
            {
                writer.WriteStartElement("definition");
                ProfileSerializer.SerializeElementDefinitionComponent(value.Definition, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProfileExtensionDefnComponent(Hl7.Fhir.Model.Profile.ProfileExtensionDefnComponent value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element _id
            if(value.LocalIdElement != null)
                writer.WritePrimitiveContents("_id", value.LocalIdElement, XmlSerializationHint.Attribute);
            
            // Serialize element extension
            if(value.Extension != null && !summary && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element code
            if(value.CodeElement != null)
            {
                writer.WriteStartElement("code");
                CodeSerializer.SerializeCode(value.CodeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element contextType
            if(value.ContextTypeElement != null)
            {
                writer.WriteStartElement("contextType");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Profile.ExtensionContext>(value.ContextTypeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element context
            if(value.ContextElement != null && value.ContextElement.Count > 0)
            {
                writer.WriteStartArrayElement("context");
                foreach(var item in value.ContextElement)
                {
                    writer.WriteStartArrayMember("context");
                    FhirStringSerializer.SerializeFhirString(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element definition
            if(value.Definition != null)
            {
                writer.WriteStartElement("definition");
                ProfileSerializer.SerializeElementDefinitionComponent(value.Definition, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
