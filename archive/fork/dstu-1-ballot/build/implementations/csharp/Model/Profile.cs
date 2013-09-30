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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Resource Profile
    /// </summary>
    [FhirResource("Profile")]
    [Serializable]
    public partial class Profile : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Binding conformance for applications
        /// </summary>
        public enum BindingConformance
        {
            Required, // Only codes in the specified set are allowed.  If the binding is extensible, other codes may be used for concepts not covered by the bound set of codes.
            Preferred, // For greater interoperability, implementers are strongly encouraged to use the bound set of codes, however alternate codes may be used in derived profiles and implementations if necessary without being considered non-conformant.
            Example, // The codes in the set are an example to illustrate the meaning of the field. There is no particular preference for its use nor any assertion that the provided values are sufficient to meet implementation needs.
        }
        
        /// <summary>
        /// Conversion of BindingConformancefrom and into string
        /// <summary>
        public static class BindingConformanceHandling
        {
            public static bool TryParse(string value, out BindingConformance result)
            {
                result = default(BindingConformance);
                
                if( value=="required")
                    result = BindingConformance.Required;
                else if( value=="preferred")
                    result = BindingConformance.Preferred;
                else if( value=="example")
                    result = BindingConformance.Example;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(BindingConformance value)
            {
                if( value==BindingConformance.Required )
                    return "required";
                else if( value==BindingConformance.Preferred )
                    return "preferred";
                else if( value==BindingConformance.Example )
                    return "example";
                else
                    throw new ArgumentException("Unrecognized BindingConformance value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Must applications comply with this constraint?
        /// </summary>
        public enum ConstraintSeverity
        {
            Error, // If the constraint is violated, the resource is not conformant.
            Warning, // If the constraint is violated, the resource is conformant, but it is not necessarily following best practice.
        }
        
        /// <summary>
        /// Conversion of ConstraintSeverityfrom and into string
        /// <summary>
        public static class ConstraintSeverityHandling
        {
            public static bool TryParse(string value, out ConstraintSeverity result)
            {
                result = default(ConstraintSeverity);
                
                if( value=="error")
                    result = ConstraintSeverity.Error;
                else if( value=="warning")
                    result = ConstraintSeverity.Warning;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ConstraintSeverity value)
            {
                if( value==ConstraintSeverity.Error )
                    return "error";
                else if( value==ConstraintSeverity.Warning )
                    return "warning";
                else
                    throw new ArgumentException("Unrecognized ConstraintSeverity value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The lifecycle status of a Resource Profile
        /// </summary>
        public enum ResourceProfileStatus
        {
            Draft, // This profile is still under development.
            Active, // This profile is ready for normal use.
            Retired, // This profile has been withdrawn or superseded and should no longer be used.
        }
        
        /// <summary>
        /// Conversion of ResourceProfileStatusfrom and into string
        /// <summary>
        public static class ResourceProfileStatusHandling
        {
            public static bool TryParse(string value, out ResourceProfileStatus result)
            {
                result = default(ResourceProfileStatus);
                
                if( value=="draft")
                    result = ResourceProfileStatus.Draft;
                else if( value=="active")
                    result = ResourceProfileStatus.Active;
                else if( value=="retired")
                    result = ResourceProfileStatus.Retired;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ResourceProfileStatus value)
            {
                if( value==ResourceProfileStatus.Draft )
                    return "draft";
                else if( value==ResourceProfileStatus.Active )
                    return "active";
                else if( value==ResourceProfileStatus.Retired )
                    return "retired";
                else
                    throw new ArgumentException("Unrecognized ResourceProfileStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// How an extension context is interpreted
        /// </summary>
        public enum ExtensionContext
        {
            Resource, // The context is all elements matching a particular resource element path.
            Datatype, // The context is all nodes matching a particular data type element path (root or repeating element) or all elements referencing a particular primitive data type (expressed as the datatype name).
            Mapping, // The context is all nodes whose mapping to a specified reference model corresponds to a particular mapping structure.  The context identifies the mapping target. The mapping should clearly identify where such an extension could be used, though this.
            Extension, // The context is a particular extension from a particular profile.  Expressed as uri#name, where uri identifies the profile and #name identifies the extension code.
        }
        
        /// <summary>
        /// Conversion of ExtensionContextfrom and into string
        /// <summary>
        public static class ExtensionContextHandling
        {
            public static bool TryParse(string value, out ExtensionContext result)
            {
                result = default(ExtensionContext);
                
                if( value=="resource")
                    result = ExtensionContext.Resource;
                else if( value=="datatype")
                    result = ExtensionContext.Datatype;
                else if( value=="mapping")
                    result = ExtensionContext.Mapping;
                else if( value=="extension")
                    result = ExtensionContext.Extension;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ExtensionContext value)
            {
                if( value==ExtensionContext.Resource )
                    return "resource";
                else if( value==ExtensionContext.Datatype )
                    return "datatype";
                else if( value==ExtensionContext.Mapping )
                    return "mapping";
                else if( value==ExtensionContext.Extension )
                    return "extension";
                else
                    throw new ArgumentException("Unrecognized ExtensionContext value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// How slices are interpreted when evaluating an instance
        /// </summary>
        public enum SlicingRules
        {
            Closed, // No additional content is allowed other than that described by the slices in this profile.
            Open, // Additional content is allowed anywhere in the list.
            OpenAtEnd, // Additional content is allowed, but only at the end of the list.
        }
        
        /// <summary>
        /// Conversion of SlicingRulesfrom and into string
        /// <summary>
        public static class SlicingRulesHandling
        {
            public static bool TryParse(string value, out SlicingRules result)
            {
                result = default(SlicingRules);
                
                if( value=="closed")
                    result = SlicingRules.Closed;
                else if( value=="open")
                    result = SlicingRules.Open;
                else if( value=="openAtEnd")
                    result = SlicingRules.OpenAtEnd;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SlicingRules value)
            {
                if( value==SlicingRules.Closed )
                    return "closed";
                else if( value==SlicingRules.Open )
                    return "open";
                else if( value==SlicingRules.OpenAtEnd )
                    return "openAtEnd";
                else
                    throw new ArgumentException("Unrecognized SlicingRules value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ElementDefinitionComponent")]
        [Serializable]
        public partial class ElementDefinitionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Concise definition for xml presentation
            /// </summary>
            public Hl7.Fhir.Model.FhirString ShortElement { get; set; }
            
            public string Short
            {
                get { return ShortElement != null ? ShortElement.Value : null; }
                set
                {
                    if(value == null)
                      ShortElement = null; 
                    else
                      ShortElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Formal definition
            /// </summary>
            public Hl7.Fhir.Model.FhirString FormalElement { get; set; }
            
            public string Formal
            {
                get { return FormalElement != null ? FormalElement.Value : null; }
                set
                {
                    if(value == null)
                      FormalElement = null; 
                    else
                      FormalElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Comments about the use of this element
            /// </summary>
            public Hl7.Fhir.Model.FhirString CommentsElement { get; set; }
            
            public string Comments
            {
                get { return CommentsElement != null ? CommentsElement.Value : null; }
                set
                {
                    if(value == null)
                      CommentsElement = null; 
                    else
                      CommentsElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Why is this needed?
            /// </summary>
            public Hl7.Fhir.Model.FhirString RequirementsElement { get; set; }
            
            public string Requirements
            {
                get { return RequirementsElement != null ? RequirementsElement.Value : null; }
                set
                {
                    if(value == null)
                      RequirementsElement = null; 
                    else
                      RequirementsElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Other names
            /// </summary>
            public List<Hl7.Fhir.Model.FhirString> SynonymElement { get; set; }
            
            public IEnumerable<string> Synonym
            {
                get { return SynonymElement != null ? SynonymElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      SynonymElement = null; 
                    else
                      SynonymElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                }
            }
            
            /// <summary>
            /// Minimum Cardinality
            /// </summary>
            public Hl7.Fhir.Model.Integer MinElement { get; set; }
            
            public int? Min
            {
                get { return MinElement != null ? MinElement.Value : null; }
                set
                {
                    if(value == null)
                      MinElement = null; 
                    else
                      MinElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Maximum Cardinality (a number or *)
            /// </summary>
            public Hl7.Fhir.Model.FhirString MaxElement { get; set; }
            
            public string Max
            {
                get { return MaxElement != null ? MaxElement.Value : null; }
                set
                {
                    if(value == null)
                      MaxElement = null; 
                    else
                      MaxElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Type of the element
            /// </summary>
            public List<Hl7.Fhir.Model.Profile.TypeRefComponent> Type { get; set; }
            
            /// <summary>
            /// To another element constraint (by element.name)
            /// </summary>
            public Hl7.Fhir.Model.FhirString NameReferenceElement { get; set; }
            
            public string NameReference
            {
                get { return NameReferenceElement != null ? NameReferenceElement.Value : null; }
                set
                {
                    if(value == null)
                      NameReferenceElement = null; 
                    else
                      NameReferenceElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Fixed value: [as defined for type]
            /// </summary>
            public Hl7.Fhir.Model.Element Value { get; set; }
            
            /// <summary>
            /// Example value: [as defined for type]
            /// </summary>
            public Hl7.Fhir.Model.Element Example { get; set; }
            
            /// <summary>
            /// Length for strings
            /// </summary>
            public Hl7.Fhir.Model.Integer MaxLengthElement { get; set; }
            
            public int? MaxLength
            {
                get { return MaxLengthElement != null ? MaxLengthElement.Value : null; }
                set
                {
                    if(value == null)
                      MaxLengthElement = null; 
                    else
                      MaxLengthElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Reference to invariant about presence
            /// </summary>
            public List<Hl7.Fhir.Model.Id> ConditionElement { get; set; }
            
            public IEnumerable<string> Condition
            {
                get { return ConditionElement != null ? ConditionElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      ConditionElement = null; 
                    else
                      ConditionElement = new List<Hl7.Fhir.Model.Id>(value.Select(elem=>new Hl7.Fhir.Model.Id(elem)));
                }
            }
            
            /// <summary>
            /// Condition that must evaluate to true
            /// </summary>
            public List<Hl7.Fhir.Model.Profile.ElementDefinitionConstraintComponent> Constraint { get; set; }
            
            /// <summary>
            /// If the element must be usable
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean MustSupportElement { get; set; }
            
            public bool? MustSupport
            {
                get { return MustSupportElement != null ? MustSupportElement.Value : null; }
                set
                {
                    if(value == null)
                      MustSupportElement = null; 
                    else
                      MustSupportElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// If this modifies the meaning of other elements
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean IsModifierElement { get; set; }
            
            public bool? IsModifier
            {
                get { return IsModifierElement != null ? IsModifierElement.Value : null; }
                set
                {
                    if(value == null)
                      IsModifierElement = null; 
                    else
                      IsModifierElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// Reference to a binding (local or absolute)
            /// </summary>
            public Hl7.Fhir.Model.FhirUri BindingElement { get; set; }
            
            public System.Uri Binding
            {
                get { return BindingElement != null ? BindingElement.Value : null; }
                set
                {
                    if(value == null)
                      BindingElement = null; 
                    else
                      BindingElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// Map element to another set of definitions
            /// </summary>
            public List<Hl7.Fhir.Model.Profile.ElementDefinitionMappingComponent> Mapping { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(ShortElement != null )
                    result.AddRange(ShortElement.Validate());
                if(FormalElement != null )
                    result.AddRange(FormalElement.Validate());
                if(CommentsElement != null )
                    result.AddRange(CommentsElement.Validate());
                if(RequirementsElement != null )
                    result.AddRange(RequirementsElement.Validate());
                if(SynonymElement != null )
                    SynonymElement.ForEach(elem => result.AddRange(elem.Validate()));
                if(MinElement != null )
                    result.AddRange(MinElement.Validate());
                if(MaxElement != null )
                    result.AddRange(MaxElement.Validate());
                if(Type != null )
                    Type.ForEach(elem => result.AddRange(elem.Validate()));
                if(NameReferenceElement != null )
                    result.AddRange(NameReferenceElement.Validate());
                if(Value != null )
                    result.AddRange(Value.Validate());
                if(Example != null )
                    result.AddRange(Example.Validate());
                if(MaxLengthElement != null )
                    result.AddRange(MaxLengthElement.Validate());
                if(ConditionElement != null )
                    ConditionElement.ForEach(elem => result.AddRange(elem.Validate()));
                if(Constraint != null )
                    Constraint.ForEach(elem => result.AddRange(elem.Validate()));
                if(MustSupportElement != null )
                    result.AddRange(MustSupportElement.Validate());
                if(IsModifierElement != null )
                    result.AddRange(IsModifierElement.Validate());
                if(BindingElement != null )
                    result.AddRange(BindingElement.Validate());
                if(Mapping != null )
                    Mapping.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ElementSlicingComponent")]
        [Serializable]
        public partial class ElementSlicingComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Element that used to distinguish the slices
            /// </summary>
            public Hl7.Fhir.Model.Id DiscriminatorElement { get; set; }
            
            public string Discriminator
            {
                get { return DiscriminatorElement != null ? DiscriminatorElement.Value : null; }
                set
                {
                    if(value == null)
                      DiscriminatorElement = null; 
                    else
                      DiscriminatorElement = new Hl7.Fhir.Model.Id(value);
                }
            }
            
            /// <summary>
            /// If elements must be in same order as slices
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean OrderedElement { get; set; }
            
            public bool? Ordered
            {
                get { return OrderedElement != null ? OrderedElement.Value : null; }
                set
                {
                    if(value == null)
                      OrderedElement = null; 
                    else
                      OrderedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// Whether slice list is open or closed
            /// </summary>
            public Code<Hl7.Fhir.Model.Profile.SlicingRules> RulesElement { get; set; }
            
            public Hl7.Fhir.Model.Profile.SlicingRules? Rules
            {
                get { return RulesElement != null ? RulesElement.Value : null; }
                set
                {
                    if(value == null)
                      RulesElement = null; 
                    else
                      RulesElement = new Code<Hl7.Fhir.Model.Profile.SlicingRules>(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(DiscriminatorElement != null )
                    result.AddRange(DiscriminatorElement.Validate());
                if(OrderedElement != null )
                    result.AddRange(OrderedElement.Validate());
                if(RulesElement != null )
                    result.AddRange(RulesElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProfileStructureComponent")]
        [Serializable]
        public partial class ProfileStructureComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The Resource or Data Type being described
            /// </summary>
            public Hl7.Fhir.Model.Code TypeElement { get; set; }
            
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Hl7.Fhir.Model.Code(value);
                }
            }
            
            /// <summary>
            /// Name for this particular structure (reference target)
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
            /// This definition is published (i.e. for validation)
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean PublishElement { get; set; }
            
            public bool? Publish
            {
                get { return PublishElement != null ? PublishElement.Value : null; }
                set
                {
                    if(value == null)
                      PublishElement = null; 
                    else
                      PublishElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// Human summary: why describe this resource?
            /// </summary>
            public Hl7.Fhir.Model.FhirString PurposeElement { get; set; }
            
            public string Purpose
            {
                get { return PurposeElement != null ? PurposeElement.Value : null; }
                set
                {
                    if(value == null)
                      PurposeElement = null; 
                    else
                      PurposeElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Definition of elements in the resource (if no profile)
            /// </summary>
            public List<Hl7.Fhir.Model.Profile.ElementComponent> Element { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(PublishElement != null )
                    result.AddRange(PublishElement.Validate());
                if(PurposeElement != null )
                    result.AddRange(PurposeElement.Validate());
                if(Element != null )
                    Element.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProfileBindingComponent")]
        [Serializable]
        public partial class ProfileBindingComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Binding name
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
            /// Can additional codes be used?
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean IsExtensibleElement { get; set; }
            
            public bool? IsExtensible
            {
                get { return IsExtensibleElement != null ? IsExtensibleElement.Value : null; }
                set
                {
                    if(value == null)
                      IsExtensibleElement = null; 
                    else
                      IsExtensibleElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// required | preferred | example
            /// </summary>
            public Code<Hl7.Fhir.Model.Profile.BindingConformance> ConformanceElement { get; set; }
            
            public Hl7.Fhir.Model.Profile.BindingConformance? Conformance
            {
                get { return ConformanceElement != null ? ConformanceElement.Value : null; }
                set
                {
                    if(value == null)
                      ConformanceElement = null; 
                    else
                      ConformanceElement = new Code<Hl7.Fhir.Model.Profile.BindingConformance>(value);
                }
            }
            
            /// <summary>
            /// Human explanation of the binding
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
            /// Source of binding content
            /// </summary>
            public Hl7.Fhir.Model.Element Reference { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(IsExtensibleElement != null )
                    result.AddRange(IsExtensibleElement.Validate());
                if(ConformanceElement != null )
                    result.AddRange(ConformanceElement.Validate());
                if(DescriptionElement != null )
                    result.AddRange(DescriptionElement.Validate());
                if(Reference != null )
                    result.AddRange(Reference.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("TypeRefComponent")]
        [Serializable]
        public partial class TypeRefComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Data type or Resource
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
            /// Profile.structure to apply
            /// </summary>
            public Hl7.Fhir.Model.FhirUri ProfileElement { get; set; }
            
            public System.Uri Profile
            {
                get { return ProfileElement != null ? ProfileElement.Value : null; }
                set
                {
                    if(value == null)
                      ProfileElement = null; 
                    else
                      ProfileElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// If code is a Resource, is it in the bundle?
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean BundledElement { get; set; }
            
            public bool? Bundled
            {
                get { return BundledElement != null ? BundledElement.Value : null; }
                set
                {
                    if(value == null)
                      BundledElement = null; 
                    else
                      BundledElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(CodeElement != null )
                    result.AddRange(CodeElement.Validate());
                if(ProfileElement != null )
                    result.AddRange(ProfileElement.Validate());
                if(BundledElement != null )
                    result.AddRange(BundledElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ElementDefinitionMappingComponent")]
        [Serializable]
        public partial class ElementDefinitionMappingComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Which mapping this is (v2, CDA, openEHR, etc.)
            /// </summary>
            public Hl7.Fhir.Model.FhirUri TargetElement { get; set; }
            
            public System.Uri Target
            {
                get { return TargetElement != null ? TargetElement.Value : null; }
                set
                {
                    if(value == null)
                      TargetElement = null; 
                    else
                      TargetElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// Details of the mapping
            /// </summary>
            public Hl7.Fhir.Model.FhirString MapElement { get; set; }
            
            public string Map
            {
                get { return MapElement != null ? MapElement.Value : null; }
                set
                {
                    if(value == null)
                      MapElement = null; 
                    else
                      MapElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(TargetElement != null )
                    result.AddRange(TargetElement.Validate());
                if(MapElement != null )
                    result.AddRange(MapElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ElementDefinitionConstraintComponent")]
        [Serializable]
        public partial class ElementDefinitionConstraintComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Target of 'condition' reference above
            /// </summary>
            public Hl7.Fhir.Model.Id KeyElement { get; set; }
            
            public string Key
            {
                get { return KeyElement != null ? KeyElement.Value : null; }
                set
                {
                    if(value == null)
                      KeyElement = null; 
                    else
                      KeyElement = new Hl7.Fhir.Model.Id(value);
                }
            }
            
            /// <summary>
            /// Short human label
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
            /// error | warning
            /// </summary>
            public Code<Hl7.Fhir.Model.Profile.ConstraintSeverity> SeverityElement { get; set; }
            
            public Hl7.Fhir.Model.Profile.ConstraintSeverity? Severity
            {
                get { return SeverityElement != null ? SeverityElement.Value : null; }
                set
                {
                    if(value == null)
                      SeverityElement = null; 
                    else
                      SeverityElement = new Code<Hl7.Fhir.Model.Profile.ConstraintSeverity>(value);
                }
            }
            
            /// <summary>
            /// Human description of constraint
            /// </summary>
            public Hl7.Fhir.Model.FhirString HumanElement { get; set; }
            
            public string Human
            {
                get { return HumanElement != null ? HumanElement.Value : null; }
                set
                {
                    if(value == null)
                      HumanElement = null; 
                    else
                      HumanElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// XPath expression of constraint
            /// </summary>
            public Hl7.Fhir.Model.FhirString XpathElement { get; set; }
            
            public string Xpath
            {
                get { return XpathElement != null ? XpathElement.Value : null; }
                set
                {
                    if(value == null)
                      XpathElement = null; 
                    else
                      XpathElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// OCL expression of constraint
            /// </summary>
            public Hl7.Fhir.Model.FhirString OclElement { get; set; }
            
            public string Ocl
            {
                get { return OclElement != null ? OclElement.Value : null; }
                set
                {
                    if(value == null)
                      OclElement = null; 
                    else
                      OclElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(KeyElement != null )
                    result.AddRange(KeyElement.Validate());
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(SeverityElement != null )
                    result.AddRange(SeverityElement.Validate());
                if(HumanElement != null )
                    result.AddRange(HumanElement.Validate());
                if(XpathElement != null )
                    result.AddRange(XpathElement.Validate());
                if(OclElement != null )
                    result.AddRange(OclElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ElementComponent")]
        [Serializable]
        public partial class ElementComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The path of the element (see the formal definitions)
            /// </summary>
            public Hl7.Fhir.Model.FhirString PathElement { get; set; }
            
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if(value == null)
                      PathElement = null; 
                    else
                      PathElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Name for this particular element definition (reference target)
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
            /// This element is sliced - slices follow
            /// </summary>
            public Hl7.Fhir.Model.Profile.ElementSlicingComponent Slicing { get; set; }
            
            /// <summary>
            /// More specific definition of the element
            /// </summary>
            public Hl7.Fhir.Model.Profile.ElementDefinitionComponent Definition { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(PathElement != null )
                    result.AddRange(PathElement.Validate());
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(Slicing != null )
                    result.AddRange(Slicing.Validate());
                if(Definition != null )
                    result.AddRange(Definition.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProfileExtensionDefnComponent")]
        [Serializable]
        public partial class ProfileExtensionDefnComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Identifies the extension in this profile
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
            /// resource | datatype | mapping | extension
            /// </summary>
            public Code<Hl7.Fhir.Model.Profile.ExtensionContext> ContextTypeElement { get; set; }
            
            public Hl7.Fhir.Model.Profile.ExtensionContext? ContextType
            {
                get { return ContextTypeElement != null ? ContextTypeElement.Value : null; }
                set
                {
                    if(value == null)
                      ContextTypeElement = null; 
                    else
                      ContextTypeElement = new Code<Hl7.Fhir.Model.Profile.ExtensionContext>(value);
                }
            }
            
            /// <summary>
            /// Where the extension can be used in instances
            /// </summary>
            public List<Hl7.Fhir.Model.FhirString> ContextElement { get; set; }
            
            public IEnumerable<string> Context
            {
                get { return ContextElement != null ? ContextElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      ContextElement = null; 
                    else
                      ContextElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                }
            }
            
            /// <summary>
            /// Definition of the extension and its content
            /// </summary>
            public Hl7.Fhir.Model.Profile.ElementDefinitionComponent Definition { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(CodeElement != null )
                    result.AddRange(CodeElement.Validate());
                if(ContextTypeElement != null )
                    result.AddRange(ContextTypeElement.Validate());
                if(ContextElement != null )
                    ContextElement.ForEach(elem => result.AddRange(elem.Validate()));
                if(Definition != null )
                    result.AddRange(Definition.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Logical id to reference this profile
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
        /// Logical id for this version of the profile
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
        /// Informal name for this profile
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
        /// Natural language description of the profile
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
        /// Assist with indexing and finding
        /// </summary>
        public List<Hl7.Fhir.Model.Coding> Code { get; set; }
        
        /// <summary>
        /// draft | experimental | review | production | withdrawn | superseded
        /// </summary>
        public Code<Hl7.Fhir.Model.Profile.ResourceProfileStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.Profile.ResourceProfileStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Profile.ResourceProfileStatus>(value);
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
        /// Date for this version of the profile
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
        /// FHIR Version this profile targets
        /// </summary>
        public Hl7.Fhir.Model.Id FhirVersionElement { get; set; }
        
        public string FhirVersion
        {
            get { return FhirVersionElement != null ? FhirVersionElement.Value : null; }
            set
            {
                if(value == null)
                  FhirVersionElement = null; 
                else
                  FhirVersionElement = new Hl7.Fhir.Model.Id(value);
            }
        }
        
        /// <summary>
        /// A constraint on a resource or a data type
        /// </summary>
        public List<Hl7.Fhir.Model.Profile.ProfileStructureComponent> Structure { get; set; }
        
        /// <summary>
        /// Definition of an extension
        /// </summary>
        public List<Hl7.Fhir.Model.Profile.ProfileExtensionDefnComponent> ExtensionDefn { get; set; }
        
        /// <summary>
        /// Define code sets for coded elements
        /// </summary>
        public List<Hl7.Fhir.Model.Profile.ProfileBindingComponent> Binding { get; set; }
        
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
            if(Code != null )
                Code.ForEach(elem => result.AddRange(elem.Validate()));
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(ExperimentalElement != null )
                result.AddRange(ExperimentalElement.Validate());
            if(DateElement != null )
                result.AddRange(DateElement.Validate());
            if(FhirVersionElement != null )
                result.AddRange(FhirVersionElement.Validate());
            if(Structure != null )
                Structure.ForEach(elem => result.AddRange(elem.Validate()));
            if(ExtensionDefn != null )
                ExtensionDefn.ForEach(elem => result.AddRange(elem.Validate()));
            if(Binding != null )
                Binding.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
