﻿using System;
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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A set of codes drawn from one or more code systems
    /// </summary>
    [FhirResource("ValueSet")]
    [Serializable]
    public partial class ValueSet : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The way in which the code is selected
        /// </summary>
        public enum CodeSelectionMode
        {
            Code, // Only this code is selected.
            Children, // Only the immediate children (codes with a is-a relationship) are selected, but not this code itself.
            Descendants, // All descendants of this code are selected, but not this code itself.
            All, // This code and any descendants are selected.
            System, // All codes from the specified code system.
        }
        
        /// <summary>
        /// Conversion of CodeSelectionModefrom and into string
        /// <summary>
        public static class CodeSelectionModeHandling
        {
            public static bool TryParse(string value, out CodeSelectionMode result)
            {
                result = default(CodeSelectionMode);
                
                if( value=="code")
                    result = CodeSelectionMode.Code;
                else if( value=="children")
                    result = CodeSelectionMode.Children;
                else if( value=="descendants")
                    result = CodeSelectionMode.Descendants;
                else if( value=="all")
                    result = CodeSelectionMode.All;
                else if( value=="system")
                    result = CodeSelectionMode.System;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CodeSelectionMode value)
            {
                if( value==CodeSelectionMode.Code )
                    return "code";
                else if( value==CodeSelectionMode.Children )
                    return "children";
                else if( value==CodeSelectionMode.Descendants )
                    return "descendants";
                else if( value==CodeSelectionMode.All )
                    return "all";
                else if( value==CodeSelectionMode.System )
                    return "system";
                else
                    throw new ArgumentException("Unrecognized CodeSelectionMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The lifecycle status of a Value Set
        /// </summary>
        public enum ValueSetStatus
        {
            Draft, // This valueset is still under development.
            Active, // This valueset is ready for normal use.
            Retired, // This valueset has been withdrawn or superceded and should no longer be used.
        }
        
        /// <summary>
        /// Conversion of ValueSetStatusfrom and into string
        /// <summary>
        public static class ValueSetStatusHandling
        {
            public static bool TryParse(string value, out ValueSetStatus result)
            {
                result = default(ValueSetStatus);
                
                if( value=="draft")
                    result = ValueSetStatus.Draft;
                else if( value=="active")
                    result = ValueSetStatus.Active;
                else if( value=="retired")
                    result = ValueSetStatus.Retired;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ValueSetStatus value)
            {
                if( value==ValueSetStatus.Draft )
                    return "draft";
                else if( value==ValueSetStatus.Active )
                    return "active";
                else if( value==ValueSetStatus.Retired )
                    return "retired";
                else
                    throw new ArgumentException("Unrecognized ValueSetStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The kind of operation to perform as part of a property based filter
        /// </summary>
        public enum FilterOperator
        {
            Equal, // The property value has the concept specified by the value.
            IsA, // The property value has a concept that has an is-a relationship with the value.
            IsNotA, // The property value has a concept that does not have an is-a relationship with the value.
            Regex, // The property value representation matches the regex specified in the value.
        }
        
        /// <summary>
        /// Conversion of FilterOperatorfrom and into string
        /// <summary>
        public static class FilterOperatorHandling
        {
            public static bool TryParse(string value, out FilterOperator result)
            {
                result = default(FilterOperator);
                
                if( value=="=")
                    result = FilterOperator.Equal;
                else if( value=="is-a")
                    result = FilterOperator.IsA;
                else if( value=="is-not-a")
                    result = FilterOperator.IsNotA;
                else if( value=="regex")
                    result = FilterOperator.Regex;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(FilterOperator value)
            {
                if( value==FilterOperator.Equal )
                    return "=";
                else if( value==FilterOperator.IsA )
                    return "is-a";
                else if( value==FilterOperator.IsNotA )
                    return "is-not-a";
                else if( value==FilterOperator.Regex )
                    return "regex";
                else
                    throw new ArgumentException("Unrecognized FilterOperator value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ValueSetDefineComponent")]
        [Serializable]
        public partial class ValueSetDefineComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// URI to identify the code system
            /// </summary>
            public Hl7.Fhir.Model.FhirUri SystemElement { get; set; }
            
            public System.Uri System
            {
                get { return SystemElement != null ? SystemElement.Value : null; }
                set
                {
                    if(value == null)
                      SystemElement = null; 
                    else
                      SystemElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// If code comparison is case sensitive
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean CaseSensitiveElement { get; set; }
            
            public bool? CaseSensitive
            {
                get { return CaseSensitiveElement != null ? CaseSensitiveElement.Value : null; }
                set
                {
                    if(value == null)
                      CaseSensitiveElement = null; 
                    else
                      CaseSensitiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// Concepts in the code system
            /// </summary>
            public List<Hl7.Fhir.Model.ValueSet.ValueSetDefineConceptComponent> Concept { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(SystemElement != null )
                    result.AddRange(SystemElement.Validate());
                if(CaseSensitiveElement != null )
                    result.AddRange(CaseSensitiveElement.Validate());
                if(Concept != null )
                    Concept.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ValueSetExpansionContainsComponent")]
        [Serializable]
        public partial class ValueSetExpansionContainsComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// System value for the code
            /// </summary>
            public Hl7.Fhir.Model.FhirUri SystemElement { get; set; }
            
            public System.Uri System
            {
                get { return SystemElement != null ? SystemElement.Value : null; }
                set
                {
                    if(value == null)
                      SystemElement = null; 
                    else
                      SystemElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// Code - if blank, this is not a choosable code
            /// </summary>
            public Hl7.Fhir.Model.Code CodeElement { get; set; }
            
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeElement = null; 
                    else
                      CodeElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            /// <summary>
            /// User display for the concept
            /// </summary>
            public Hl7.Fhir.Model.FhirString DisplayElement { get; set; }
            
            public string Display
            {
                get { return DisplayElement != null ? DisplayElement.Value : null; }
                set
                {
                    if(value == null)
                      DisplayElement = null; 
                    else
                      DisplayElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Codes contained in this concept
            /// </summary>
            public List<Hl7.Fhir.Model.ValueSet.ValueSetExpansionContainsComponent> Contains { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(SystemElement != null )
                    result.AddRange(SystemElement.Validate());
                if(CodeElement != null )
                    result.AddRange(CodeElement.Validate());
                if(DisplayElement != null )
                    result.AddRange(DisplayElement.Validate());
                if(Contains != null )
                    Contains.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConceptSetComponent")]
        [Serializable]
        public partial class ConceptSetComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The system the codes come from
            /// </summary>
            public Hl7.Fhir.Model.FhirUri SystemElement { get; set; }
            
            public System.Uri System
            {
                get { return SystemElement != null ? SystemElement.Value : null; }
                set
                {
                    if(value == null)
                      SystemElement = null; 
                    else
                      SystemElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// Specific version of the code system referred to
            /// </summary>
            public Hl7.Fhir.Model.FhirString VersionElement { get; set; }
            
            public string Version
            {
                get { return VersionElement != null ? VersionElement.Value : null; }
                set
                {
                    if(value == null)
                      VersionElement = null; 
                    else
                      VersionElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Code or concept
            /// </summary>
            public List<Hl7.Fhir.Model.Code> CodeElement { get; set; }
            
            public IEnumerable<string> Code
            {
                get { return CodeElement != null ? CodeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      CodeElement = null; 
                    else
                      CodeElement = new List<Hl7.Fhir.Model.Code>(value.Select(elem=>new Hl7.Fhir.Model.Code(elem)));
                }
            }
            
            /// <summary>
            /// Select codes/concepts by their properties (including relationships)
            /// </summary>
            public List<Hl7.Fhir.Model.ValueSet.ConceptSetFilterComponent> Filter { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(SystemElement != null )
                    result.AddRange(SystemElement.Validate());
                if(VersionElement != null )
                    result.AddRange(VersionElement.Validate());
                if(CodeElement != null )
                    CodeElement.ForEach(elem => result.AddRange(elem.Validate()));
                if(Filter != null )
                    Filter.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConceptSetFilterComponent")]
        [Serializable]
        public partial class ConceptSetFilterComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// A property defined by the code system
            /// </summary>
            public Hl7.Fhir.Model.Code PropertyElement { get; set; }
            
            public string Property
            {
                get { return PropertyElement != null ? PropertyElement.Value : null; }
                set
                {
                    if(value == null)
                      PropertyElement = null; 
                    else
                      PropertyElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            /// <summary>
            /// = | is-a | is_not_a | regex
            /// </summary>
            public Code<Hl7.Fhir.Model.ValueSet.FilterOperator> OpElement { get; set; }
            
            public Hl7.Fhir.Model.ValueSet.FilterOperator? Op
            {
                get { return OpElement != null ? OpElement.Value : null; }
                set
                {
                    if(value == null)
                      OpElement = null; 
                    else
                      OpElement = new Code<Hl7.Fhir.Model.ValueSet.FilterOperator>(value);
                }
            }
            
            /// <summary>
            /// Code from the system, or regex criteria
            /// </summary>
            public Hl7.Fhir.Model.Code ValueElement { get; set; }
            
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if(value == null)
                      ValueElement = null; 
                    else
                      ValueElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(PropertyElement != null )
                    result.AddRange(PropertyElement.Validate());
                if(OpElement != null )
                    result.AddRange(OpElement.Validate());
                if(ValueElement != null )
                    result.AddRange(ValueElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ValueSetComposeComponent")]
        [Serializable]
        public partial class ValueSetComposeComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Import the contents of another value set
            /// </summary>
            public List<Hl7.Fhir.Model.FhirUri> ImportElement { get; set; }
            
            public IEnumerable<System.Uri> Import
            {
                get { return ImportElement != null ? ImportElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      ImportElement = null; 
                    else
                      ImportElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
                }
            }
            
            /// <summary>
            /// Include one or more codes from a code system
            /// </summary>
            public List<Hl7.Fhir.Model.ValueSet.ConceptSetComponent> Include { get; set; }
            
            /// <summary>
            /// Explicitly exclude codes
            /// </summary>
            public List<Hl7.Fhir.Model.ValueSet.ConceptSetComponent> Exclude { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(ImportElement != null )
                    ImportElement.ForEach(elem => result.AddRange(elem.Validate()));
                if(Include != null )
                    Include.ForEach(elem => result.AddRange(elem.Validate()));
                if(Exclude != null )
                    Exclude.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ValueSetDefineConceptComponent")]
        [Serializable]
        public partial class ValueSetDefineConceptComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Code that identifies concept
            /// </summary>
            public Hl7.Fhir.Model.Code CodeElement { get; set; }
            
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if(value == null)
                      CodeElement = null; 
                    else
                      CodeElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            /// <summary>
            /// If this code is not for use as a real concept
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean AbstractElement { get; set; }
            
            public bool? Abstract
            {
                get { return AbstractElement != null ? AbstractElement.Value : null; }
                set
                {
                    if(value == null)
                      AbstractElement = null; 
                    else
                      AbstractElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// Text to Display to the user
            /// </summary>
            public Hl7.Fhir.Model.FhirString DisplayElement { get; set; }
            
            public string Display
            {
                get { return DisplayElement != null ? DisplayElement.Value : null; }
                set
                {
                    if(value == null)
                      DisplayElement = null; 
                    else
                      DisplayElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Formal Definition
            /// </summary>
            public Hl7.Fhir.Model.FhirString DefinitionElement { get; set; }
            
            public string Definition
            {
                get { return DefinitionElement != null ? DefinitionElement.Value : null; }
                set
                {
                    if(value == null)
                      DefinitionElement = null; 
                    else
                      DefinitionElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Child Concepts (is-a / contains)
            /// </summary>
            public List<Hl7.Fhir.Model.ValueSet.ValueSetDefineConceptComponent> Concept { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(CodeElement != null )
                    result.AddRange(CodeElement.Validate());
                if(AbstractElement != null )
                    result.AddRange(AbstractElement.Validate());
                if(DisplayElement != null )
                    result.AddRange(DisplayElement.Validate());
                if(DefinitionElement != null )
                    result.AddRange(DefinitionElement.Validate());
                if(Concept != null )
                    Concept.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ValueSetExpansionComponent")]
        [Serializable]
        public partial class ValueSetExpansionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Time valueset expansion happened
            /// </summary>
            public Hl7.Fhir.Model.Instant TimestampElement { get; set; }
            
            public DateTimeOffset? Timestamp
            {
                get { return TimestampElement != null ? TimestampElement.Value : null; }
                set
                {
                    if(value == null)
                      TimestampElement = null; 
                    else
                      TimestampElement = new Hl7.Fhir.Model.Instant(value);
                }
            }
            
            /// <summary>
            /// Codes in the value set
            /// </summary>
            public List<Hl7.Fhir.Model.ValueSet.ValueSetExpansionContainsComponent> Contains { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(TimestampElement != null )
                    result.AddRange(TimestampElement.Validate());
                if(Contains != null )
                    Contains.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Logical id to reference this value set
        /// </summary>
        public Hl7.Fhir.Model.FhirString IdentifierElement { get; set; }
        
        public string Identifier
        {
            get { return IdentifierElement != null ? IdentifierElement.Value : null; }
            set
            {
                if(value == null)
                  IdentifierElement = null; 
                else
                  IdentifierElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Logical id for this version of the value set
        /// </summary>
        public Hl7.Fhir.Model.FhirString VersionElement { get; set; }
        
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if(value == null)
                  VersionElement = null; 
                else
                  VersionElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Informal name for this value set
        /// </summary>
        public Hl7.Fhir.Model.FhirString NameElement { get; set; }
        
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if(value == null)
                  NameElement = null; 
                else
                  NameElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        public Hl7.Fhir.Model.FhirString PublisherElement { get; set; }
        
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if(value == null)
                  PublisherElement = null; 
                else
                  PublisherElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Contact information of the publisher
        /// </summary>
        public List<Hl7.Fhir.Model.Contact> Telecom { get; set; }
        
        /// <summary>
        /// Human language description of the value set
        /// </summary>
        public Hl7.Fhir.Model.FhirString DescriptionElement { get; set; }
        
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// About the value set or its content
        /// </summary>
        public Hl7.Fhir.Model.FhirString CopyrightElement { get; set; }
        
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if(value == null)
                  CopyrightElement = null; 
                else
                  CopyrightElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// draft | experimental | review | production | withdrawn | superseded
        /// </summary>
        public Code<Hl7.Fhir.Model.ValueSet.ValueSetStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.ValueSet.ValueSetStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.ValueSet.ValueSetStatus>(value);
            }
        }
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean ExperimentalElement { get; set; }
        
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if(value == null)
                  ExperimentalElement = null; 
                else
                  ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        /// <summary>
        /// Date for given status
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime DateElement { get; set; }
        
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// When value set defines its own codes
        /// </summary>
        public Hl7.Fhir.Model.ValueSet.ValueSetDefineComponent Define { get; set; }
        
        /// <summary>
        /// When value set includes codes from elsewhere
        /// </summary>
        public Hl7.Fhir.Model.ValueSet.ValueSetComposeComponent Compose { get; set; }
        
        /// <summary>
        /// When value set is an expansion
        /// </summary>
        public Hl7.Fhir.Model.ValueSet.ValueSetExpansionComponent Expansion { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(IdentifierElement != null )
                result.AddRange(IdentifierElement.Validate());
            if(VersionElement != null )
                result.AddRange(VersionElement.Validate());
            if(NameElement != null )
                result.AddRange(NameElement.Validate());
            if(PublisherElement != null )
                result.AddRange(PublisherElement.Validate());
            if(Telecom != null )
                Telecom.ForEach(elem => result.AddRange(elem.Validate()));
            if(DescriptionElement != null )
                result.AddRange(DescriptionElement.Validate());
            if(CopyrightElement != null )
                result.AddRange(CopyrightElement.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(ExperimentalElement != null )
                result.AddRange(ExperimentalElement.Validate());
            if(DateElement != null )
                result.AddRange(DateElement.Validate());
            if(Define != null )
                result.AddRange(Define.Validate());
            if(Compose != null )
                result.AddRange(Compose.Validate());
            if(Expansion != null )
                result.AddRange(Expansion.Validate());
            
            return result;
        }
    }
    
}
