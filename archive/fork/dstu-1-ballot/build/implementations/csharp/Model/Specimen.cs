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
    /// Sample for analysis
    /// </summary>
    [FhirResource("Specimen")]
    [Serializable]
    public partial class Specimen : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Type indicating if this is a parent or child relationship
        /// </summary>
        public enum HierarchicalRelationshipType
        {
            Parent, // The target resource is the parent of the focal specimen resource.
            Child, // The target resource is the child of the focal specimen resource.
        }
        
        /// <summary>
        /// Conversion of HierarchicalRelationshipTypefrom and into string
        /// <summary>
        public static class HierarchicalRelationshipTypeHandling
        {
            public static bool TryParse(string value, out HierarchicalRelationshipType result)
            {
                result = default(HierarchicalRelationshipType);
                
                if( value=="parent")
                    result = HierarchicalRelationshipType.Parent;
                else if( value=="child")
                    result = HierarchicalRelationshipType.Child;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(HierarchicalRelationshipType value)
            {
                if( value==HierarchicalRelationshipType.Parent )
                    return "parent";
                else if( value==HierarchicalRelationshipType.Child )
                    return "child";
                else
                    throw new ArgumentException("Unrecognized HierarchicalRelationshipType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SpecimenCollectionComponent")]
        [Serializable]
        public partial class SpecimenCollectionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Who collected the specimen
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Collector { get; set; }
            
            /// <summary>
            /// Collector comments
            /// </summary>
            public List<Hl7.Fhir.Model.FhirString> CommentElement { get; set; }
            
            public IEnumerable<string> Comment
            {
                get { return CommentElement != null ? CommentElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      CommentElement = null; 
                    else
                      CommentElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                }
            }
            
            /// <summary>
            /// Collection time
            /// </summary>
            public Hl7.Fhir.Model.FhirDateTime CollectedTimeElement { get; set; }
            
            public string CollectedTime
            {
                get { return CollectedTimeElement != null ? CollectedTimeElement.Value : null; }
                set
                {
                    if(value == null)
                      CollectedTimeElement = null; 
                    else
                      CollectedTimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
                }
            }
            
            /// <summary>
            /// The quantity of specimen collected
            /// </summary>
            public Hl7.Fhir.Model.Quantity Quantity { get; set; }
            
            /// <summary>
            /// Specimen Collection Method
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Method { get; set; }
            
            /// <summary>
            /// Site of the source of the specimen
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept SourceSite { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Collector != null )
                    result.AddRange(Collector.Validate());
                if(CommentElement != null )
                    CommentElement.ForEach(elem => result.AddRange(elem.Validate()));
                if(CollectedTimeElement != null )
                    result.AddRange(CollectedTimeElement.Validate());
                if(Quantity != null )
                    result.AddRange(Quantity.Validate());
                if(Method != null )
                    result.AddRange(Method.Validate());
                if(SourceSite != null )
                    result.AddRange(SourceSite.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SpecimenSourceComponent")]
        [Serializable]
        public partial class SpecimenSourceComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// parent | child
            /// </summary>
            public Code<Hl7.Fhir.Model.Specimen.HierarchicalRelationshipType> RelationshipElement { get; set; }
            
            public Hl7.Fhir.Model.Specimen.HierarchicalRelationshipType? Relationship
            {
                get { return RelationshipElement != null ? RelationshipElement.Value : null; }
                set
                {
                    if(value == null)
                      RelationshipElement = null; 
                    else
                      RelationshipElement = new Code<Hl7.Fhir.Model.Specimen.HierarchicalRelationshipType>(value);
                }
            }
            
            /// <summary>
            /// The subject of the relationship
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Target { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(RelationshipElement != null )
                    result.AddRange(RelationshipElement.Validate());
                if(Target != null )
                    Target.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SpecimenTreatmentComponent")]
        [Serializable]
        public partial class SpecimenTreatmentComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Textual description of procedure
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
            /// Specimen Treatment Procedure
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Procedure { get; set; }
            
            /// <summary>
            /// Specimen additive
            /// </summary>
            public List<Hl7.Fhir.Model.ResourceReference> Additive { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(DescriptionElement != null )
                    result.AddRange(DescriptionElement.Validate());
                if(Procedure != null )
                    result.AddRange(Procedure.Validate());
                if(Additive != null )
                    Additive.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SpecimenContainerComponent")]
        [Serializable]
        public partial class SpecimenContainerComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Id for container
            /// </summary>
            public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
            
            /// <summary>
            /// Textual description of container
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
            /// Specimen Container Type
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Container Capacity
            /// </summary>
            public Hl7.Fhir.Model.Quantity Capacity { get; set; }
            
            /// <summary>
            /// Specimen Container Quantity
            /// </summary>
            public Hl7.Fhir.Model.Quantity SpecimenQuantity { get; set; }
            
            /// <summary>
            /// Container Additive
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Additive { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Identifier != null )
                    Identifier.ForEach(elem => result.AddRange(elem.Validate()));
                if(DescriptionElement != null )
                    result.AddRange(DescriptionElement.Validate());
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(Capacity != null )
                    result.AddRange(Capacity.Validate());
                if(SpecimenQuantity != null )
                    result.AddRange(SpecimenQuantity.Validate());
                if(Additive != null )
                    result.AddRange(Additive.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// External Identifier
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// Type of specimen
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
        
        /// <summary>
        /// Parent of specimen
        /// </summary>
        public List<Hl7.Fhir.Model.Specimen.SpecimenSourceComponent> Source { get; set; }
        
        /// <summary>
        /// The subject of the report
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Accession Identifier
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> AccessionIdentifier { get; set; }
        
        /// <summary>
        /// Received Time
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime ReceivedTimeElement { get; set; }
        
        public string ReceivedTime
        {
            get { return ReceivedTimeElement != null ? ReceivedTimeElement.Value : null; }
            set
            {
                if(value == null)
                  ReceivedTimeElement = null; 
                else
                  ReceivedTimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// Collection details
        /// </summary>
        public Hl7.Fhir.Model.Specimen.SpecimenCollectionComponent Collection { get; set; }
        
        /// <summary>
        /// Specimen Treatments
        /// </summary>
        public List<Hl7.Fhir.Model.Specimen.SpecimenTreatmentComponent> Treatment { get; set; }
        
        /// <summary>
        /// Specimen Container
        /// </summary>
        public List<Hl7.Fhir.Model.Specimen.SpecimenContainerComponent> Container { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(Type != null )
                result.AddRange(Type.Validate());
            if(Source != null )
                Source.ForEach(elem => result.AddRange(elem.Validate()));
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(AccessionIdentifier != null )
                AccessionIdentifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(ReceivedTimeElement != null )
                result.AddRange(ReceivedTimeElement.Validate());
            if(Collection != null )
                result.AddRange(Collection.Validate());
            if(Treatment != null )
                Treatment.ForEach(elem => result.AddRange(elem.Validate()));
            if(Container != null )
                Container.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
