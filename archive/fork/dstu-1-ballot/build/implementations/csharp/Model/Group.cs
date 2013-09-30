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
    /// Group of multiple entities
    /// </summary>
    [FhirResource("Group")]
    [Serializable]
    public partial class Group : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Types of resources that are part of group
        /// </summary>
        public enum GroupType
        {
            Person, // Group contains "person" Patient resources.
            Animal, // Group contains "animal" Patient resources.
            Device, // Group contains Device resources.
            Medication, // Group contains Medication resources.
            Substance, // Group contains Substance resources.
        }
        
        /// <summary>
        /// Conversion of GroupTypefrom and into string
        /// <summary>
        public static class GroupTypeHandling
        {
            public static bool TryParse(string value, out GroupType result)
            {
                result = default(GroupType);
                
                if( value=="person")
                    result = GroupType.Person;
                else if( value=="animal")
                    result = GroupType.Animal;
                else if( value=="device")
                    result = GroupType.Device;
                else if( value=="medication")
                    result = GroupType.Medication;
                else if( value=="substance")
                    result = GroupType.Substance;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(GroupType value)
            {
                if( value==GroupType.Person )
                    return "person";
                else if( value==GroupType.Animal )
                    return "animal";
                else if( value==GroupType.Device )
                    return "device";
                else if( value==GroupType.Medication )
                    return "medication";
                else if( value==GroupType.Substance )
                    return "substance";
                else
                    throw new ArgumentException("Unrecognized GroupType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("GroupCharacteristicComponent")]
        [Serializable]
        public partial class GroupCharacteristicComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Kind of characteristic
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Value held by characteristic
            /// </summary>
            public Hl7.Fhir.Model.Element Value { get; set; }
            
            /// <summary>
            /// Group includes or excludes
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean ExcludeElement { get; set; }
            
            public bool? Exclude
            {
                get { return ExcludeElement != null ? ExcludeElement.Value : null; }
                set
                {
                    if(value == null)
                      ExcludeElement = null; 
                    else
                      ExcludeElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(Value != null )
                    result.AddRange(Value.Validate());
                if(ExcludeElement != null )
                    result.AddRange(ExcludeElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Unique id
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// Group Classification
        /// </summary>
        public Code<Hl7.Fhir.Model.Group.GroupType> TypeElement { get; set; }
        
        public Hl7.Fhir.Model.Group.GroupType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if(value == null)
                  TypeElement = null; 
                else
                  TypeElement = new Code<Hl7.Fhir.Model.Group.GroupType>(value);
            }
        }
        
        /// <summary>
        /// Descriptive or actual
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean ActualElement { get; set; }
        
        public bool? Actual
        {
            get { return ActualElement != null ? ActualElement.Value : null; }
            set
            {
                if(value == null)
                  ActualElement = null; 
                else
                  ActualElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        /// <summary>
        /// Kind of Group members
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
        
        /// <summary>
        /// Label for Group
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
        /// Number of members
        /// </summary>
        public Hl7.Fhir.Model.Integer QuantityElement { get; set; }
        
        public int? Quantity
        {
            get { return QuantityElement != null ? QuantityElement.Value : null; }
            set
            {
                if(value == null)
                  QuantityElement = null; 
                else
                  QuantityElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Trait of group members
        /// </summary>
        public List<Hl7.Fhir.Model.Group.GroupCharacteristicComponent> Characteristic { get; set; }
        
        /// <summary>
        /// Who is in group
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Member { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(TypeElement != null )
                result.AddRange(TypeElement.Validate());
            if(ActualElement != null )
                result.AddRange(ActualElement.Validate());
            if(Code != null )
                result.AddRange(Code.Validate());
            if(NameElement != null )
                result.AddRange(NameElement.Validate());
            if(QuantityElement != null )
                result.AddRange(QuantityElement.Validate());
            if(Characteristic != null )
                Characteristic.ForEach(elem => result.AddRange(elem.Validate()));
            if(Member != null )
                Member.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
