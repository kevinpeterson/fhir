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
    /// Definition of a Medication
    /// </summary>
    [FhirResource("Medication")]
    [Serializable]
    public partial class Medication : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Whether the medication is a product or a package
        /// </summary>
        public enum MedicationKind
        {
            Product, // The medication is a product.
            Package, // The medication is a package - a contained group of one of more products.
        }
        
        /// <summary>
        /// Conversion of MedicationKindfrom and into string
        /// <summary>
        public static class MedicationKindHandling
        {
            public static bool TryParse(string value, out MedicationKind result)
            {
                result = default(MedicationKind);
                
                if( value=="product")
                    result = MedicationKind.Product;
                else if( value=="package")
                    result = MedicationKind.Package;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(MedicationKind value)
            {
                if( value==MedicationKind.Product )
                    return "product";
                else if( value==MedicationKind.Package )
                    return "package";
                else
                    throw new ArgumentException("Unrecognized MedicationKind value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationPackageContentComponent")]
        [Serializable]
        public partial class MedicationPackageContentComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// A product in the package
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Item { get; set; }
            
            /// <summary>
            /// Amount in the package
            /// </summary>
            public Hl7.Fhir.Model.Quantity Amount { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Item != null )
                    result.AddRange(Item.Validate());
                if(Amount != null )
                    result.AddRange(Amount.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationPackageComponent")]
        [Serializable]
        public partial class MedicationPackageComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Kind of container
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Container { get; set; }
            
            /// <summary>
            /// What is  in the package
            /// </summary>
            public List<Hl7.Fhir.Model.Medication.MedicationPackageContentComponent> Content { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Container != null )
                    result.AddRange(Container.Validate());
                if(Content != null )
                    Content.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationProductIngredientComponent")]
        [Serializable]
        public partial class MedicationProductIngredientComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Ingredient
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Item { get; set; }
            
            /// <summary>
            /// Amount of ingredient
            /// </summary>
            public Hl7.Fhir.Model.Ratio Amount { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Item != null )
                    result.AddRange(Item.Validate());
                if(Amount != null )
                    result.AddRange(Amount.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MedicationProductComponent")]
        [Serializable]
        public partial class MedicationProductComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Powder | tablets | carton etc
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Form { get; set; }
            
            /// <summary>
            /// Ingredients, if specified
            /// </summary>
            public List<Hl7.Fhir.Model.Medication.MedicationProductIngredientComponent> Ingredient { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Form != null )
                    result.AddRange(Form.Validate());
                if(Ingredient != null )
                    Ingredient.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Common / Commercial name
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
        /// References to std. medication terminologies
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
        
        /// <summary>
        /// True if a brand
        /// </summary>
        public Hl7.Fhir.Model.FhirBoolean IsBrandElement { get; set; }
        
        public bool? IsBrand
        {
            get { return IsBrandElement != null ? IsBrandElement.Value : null; }
            set
            {
                if(value == null)
                  IsBrandElement = null; 
                else
                  IsBrandElement = new Hl7.Fhir.Model.FhirBoolean(value);
            }
        }
        
        /// <summary>
        /// Manufacturer of the item
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Manufacturer { get; set; }
        
        /// <summary>
        /// product | package
        /// </summary>
        public Code<Hl7.Fhir.Model.Medication.MedicationKind> KindElement { get; set; }
        
        public Hl7.Fhir.Model.Medication.MedicationKind? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if(value == null)
                  KindElement = null; 
                else
                  KindElement = new Code<Hl7.Fhir.Model.Medication.MedicationKind>(value);
            }
        }
        
        /// <summary>
        /// If is a product
        /// </summary>
        public Hl7.Fhir.Model.Medication.MedicationProductComponent Product { get; set; }
        
        /// <summary>
        /// If is a package
        /// </summary>
        public Hl7.Fhir.Model.Medication.MedicationPackageComponent Package { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(NameElement != null )
                result.AddRange(NameElement.Validate());
            if(Code != null )
                result.AddRange(Code.Validate());
            if(IsBrandElement != null )
                result.AddRange(IsBrandElement.Validate());
            if(Manufacturer != null )
                result.AddRange(Manufacturer.Validate());
            if(KindElement != null )
                result.AddRange(KindElement.Validate());
            if(Product != null )
                result.AddRange(Product.Validate());
            if(Package != null )
                result.AddRange(Package.Validate());
            
            return result;
        }
    }
    
}
