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
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for ValueSet instances
    */
    internal static partial class ValueSetSerializer
    {
        public static void SerializeValueSet(Hl7.Fhir.Model.ValueSet value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("ValueSet");
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
            
            // Serialize element copyright
            if(value.CopyrightElement != null && !summary)
            {
                writer.WriteStartElement("copyright");
                FhirStringSerializer.SerializeFhirString(value.CopyrightElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.ValueSet.ValueSetStatus>(value.StatusElement, writer, summary);
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
            
            // Serialize element define
            if(value.Define != null && !summary)
            {
                writer.WriteStartElement("define");
                ValueSetSerializer.SerializeValueSetDefineComponent(value.Define, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element compose
            if(value.Compose != null && !summary)
            {
                writer.WriteStartElement("compose");
                ValueSetSerializer.SerializeValueSetComposeComponent(value.Compose, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element expansion
            if(value.Expansion != null && !summary)
            {
                writer.WriteStartElement("expansion");
                ValueSetSerializer.SerializeValueSetExpansionComponent(value.Expansion, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeValueSetDefineComponent(Hl7.Fhir.Model.ValueSet.ValueSetDefineComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element system
            if(value.SystemElement != null)
            {
                writer.WriteStartElement("system");
                FhirUriSerializer.SerializeFhirUri(value.SystemElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element caseSensitive
            if(value.CaseSensitiveElement != null)
            {
                writer.WriteStartElement("caseSensitive");
                FhirBooleanSerializer.SerializeFhirBoolean(value.CaseSensitiveElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element concept
            if(value.Concept != null && value.Concept.Count > 0)
            {
                writer.WriteStartArrayElement("concept");
                foreach(var item in value.Concept)
                {
                    writer.WriteStartArrayMember("concept");
                    ValueSetSerializer.SerializeValueSetDefineConceptComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeValueSetExpansionContainsComponent(Hl7.Fhir.Model.ValueSet.ValueSetExpansionContainsComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element system
            if(value.SystemElement != null)
            {
                writer.WriteStartElement("system");
                FhirUriSerializer.SerializeFhirUri(value.SystemElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.CodeElement != null)
            {
                writer.WriteStartElement("code");
                CodeSerializer.SerializeCode(value.CodeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element display
            if(value.DisplayElement != null)
            {
                writer.WriteStartElement("display");
                FhirStringSerializer.SerializeFhirString(value.DisplayElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element contains
            if(value.Contains != null && value.Contains.Count > 0)
            {
                writer.WriteStartArrayElement("contains");
                foreach(var item in value.Contains)
                {
                    writer.WriteStartArrayMember("contains");
                    ValueSetSerializer.SerializeValueSetExpansionContainsComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConceptSetComponent(Hl7.Fhir.Model.ValueSet.ConceptSetComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element system
            if(value.SystemElement != null)
            {
                writer.WriteStartElement("system");
                FhirUriSerializer.SerializeFhirUri(value.SystemElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element version
            if(value.VersionElement != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.VersionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.CodeElement != null && value.CodeElement.Count > 0)
            {
                writer.WriteStartArrayElement("code");
                foreach(var item in value.CodeElement)
                {
                    writer.WriteStartArrayMember("code");
                    CodeSerializer.SerializeCode(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element filter
            if(value.Filter != null && value.Filter.Count > 0)
            {
                writer.WriteStartArrayElement("filter");
                foreach(var item in value.Filter)
                {
                    writer.WriteStartArrayMember("filter");
                    ValueSetSerializer.SerializeConceptSetFilterComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConceptSetFilterComponent(Hl7.Fhir.Model.ValueSet.ConceptSetFilterComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element property
            if(value.PropertyElement != null)
            {
                writer.WriteStartElement("property");
                CodeSerializer.SerializeCode(value.PropertyElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element op
            if(value.OpElement != null)
            {
                writer.WriteStartElement("op");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.ValueSet.FilterOperator>(value.OpElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element value
            if(value.ValueElement != null)
            {
                writer.WriteStartElement("value");
                CodeSerializer.SerializeCode(value.ValueElement, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeValueSetComposeComponent(Hl7.Fhir.Model.ValueSet.ValueSetComposeComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element import
            if(value.ImportElement != null && value.ImportElement.Count > 0)
            {
                writer.WriteStartArrayElement("import");
                foreach(var item in value.ImportElement)
                {
                    writer.WriteStartArrayMember("import");
                    FhirUriSerializer.SerializeFhirUri(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element include
            if(value.Include != null && value.Include.Count > 0)
            {
                writer.WriteStartArrayElement("include");
                foreach(var item in value.Include)
                {
                    writer.WriteStartArrayMember("include");
                    ValueSetSerializer.SerializeConceptSetComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element exclude
            if(value.Exclude != null && value.Exclude.Count > 0)
            {
                writer.WriteStartArrayElement("exclude");
                foreach(var item in value.Exclude)
                {
                    writer.WriteStartArrayMember("exclude");
                    ValueSetSerializer.SerializeConceptSetComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeValueSetDefineConceptComponent(Hl7.Fhir.Model.ValueSet.ValueSetDefineConceptComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element abstract
            if(value.AbstractElement != null)
            {
                writer.WriteStartElement("abstract");
                FhirBooleanSerializer.SerializeFhirBoolean(value.AbstractElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element display
            if(value.DisplayElement != null)
            {
                writer.WriteStartElement("display");
                FhirStringSerializer.SerializeFhirString(value.DisplayElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element definition
            if(value.DefinitionElement != null)
            {
                writer.WriteStartElement("definition");
                FhirStringSerializer.SerializeFhirString(value.DefinitionElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element concept
            if(value.Concept != null && value.Concept.Count > 0)
            {
                writer.WriteStartArrayElement("concept");
                foreach(var item in value.Concept)
                {
                    writer.WriteStartArrayMember("concept");
                    ValueSetSerializer.SerializeValueSetDefineConceptComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeValueSetExpansionComponent(Hl7.Fhir.Model.ValueSet.ValueSetExpansionComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element timestamp
            if(value.TimestampElement != null)
            {
                writer.WriteStartElement("timestamp");
                InstantSerializer.SerializeInstant(value.TimestampElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element contains
            if(value.Contains != null && value.Contains.Count > 0)
            {
                writer.WriteStartArrayElement("contains");
                foreach(var item in value.Contains)
                {
                    writer.WriteStartArrayMember("contains");
                    ValueSetSerializer.SerializeValueSetExpansionContainsComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
