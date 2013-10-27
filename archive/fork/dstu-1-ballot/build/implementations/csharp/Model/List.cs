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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Information summarized from a list of other resources
    /// </summary>
    [FhirResource("List")]
    [Serializable]
    public partial class List : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The processing mode that applies to this list
        /// </summary>
        public enum ListMode
        {
            Working, // This list is the master list, maintained in an ongoing fashion with regular updates as the real world list it is tracking changes.
            Snapshot, // This list was prepared as a snapshot. It should not be assumed to be current.
            Changes, // The list is prepared as a statement of changes that have been made or recommended.
        }
        
        /// <summary>
        /// Conversion of ListModefrom and into string
        /// <summary>
        public static class ListModeHandling
        {
            public static bool TryParse(string value, out ListMode result)
            {
                result = default(ListMode);
                
                if( value=="working")
                    result = ListMode.Working;
                else if( value=="snapshot")
                    result = ListMode.Snapshot;
                else if( value=="changes")
                    result = ListMode.Changes;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ListMode value)
            {
                if( value==ListMode.Working )
                    return "working";
                else if( value==ListMode.Snapshot )
                    return "snapshot";
                else if( value==ListMode.Changes )
                    return "changes";
                else
                    throw new ArgumentException("Unrecognized ListMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ListEntryComponent")]
        [Serializable]
        public partial class ListEntryComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Workflow information about this item
            /// </summary>
            public List<Hl7.Fhir.Model.CodeableConcept> Flag { get; set; }
            
            /// <summary>
            /// If this item is actually marked as deleted
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean DeletedElement { get; set; }
            
            public bool? Deleted
            {
                get { return DeletedElement != null ? DeletedElement.Value : null; }
                set
                {
                    if(value == null)
                      DeletedElement = null; 
                    else
                      DeletedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                }
            }
            
            /// <summary>
            /// When item added to list
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
            /// Actual entry
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Item { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Flag != null )
                    Flag.ForEach(elem => result.AddRange(elem.Validate()));
                if(DeletedElement != null )
                    result.AddRange(DeletedElement.Validate());
                if(DateElement != null )
                    result.AddRange(DateElement.Validate());
                if(Item != null )
                    result.AddRange(Item.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// What the purpose of this list is
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Code { get; set; }
        
        /// <summary>
        /// Source of the list
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Source { get; set; }
        
        /// <summary>
        /// When the list was prepared
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
        /// Whether items in the list have a meaningful order
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
        /// working | snapshot | changes
        /// </summary>
        public Code<Hl7.Fhir.Model.List.ListMode> ModeElement { get; set; }
        
        public Hl7.Fhir.Model.List.ListMode? Mode
        {
            get { return ModeElement != null ? ModeElement.Value : null; }
            set
            {
                if(value == null)
                  ModeElement = null; 
                else
                  ModeElement = new Code<Hl7.Fhir.Model.List.ListMode>(value);
            }
        }
        
        /// <summary>
        /// Entries in the list
        /// </summary>
        public List<Hl7.Fhir.Model.List.ListEntryComponent> Entry { get; set; }
        
        /// <summary>
        /// Why list is empty
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept EmptyReason { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Code != null )
                result.AddRange(Code.Validate());
            if(Source != null )
                result.AddRange(Source.Validate());
            if(DateElement != null )
                result.AddRange(DateElement.Validate());
            if(OrderedElement != null )
                result.AddRange(OrderedElement.Validate());
            if(ModeElement != null )
                result.AddRange(ModeElement.Validate());
            if(Entry != null )
                Entry.ForEach(elem => result.AddRange(elem.Validate()));
            if(EmptyReason != null )
                result.AddRange(EmptyReason.Validate());
            
            return result;
        }
    }
    
}
