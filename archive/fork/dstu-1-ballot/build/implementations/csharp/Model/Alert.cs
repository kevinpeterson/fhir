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
    /// Alert
    /// </summary>
    [FhirResource("Alert")]
    [Serializable]
    public partial class Alert : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Indicates whether this alert is active and needs to be displayed to a user, or whether it is no longer needed or entered in error
        /// </summary>
        public enum AlertStatus
        {
            Active, // A current alert that should be displayed to a user. A system may use the category to determine which roles should view the alert.
            Inactive, // The alert does not need to be displayed any more.
            Error, // The alert was added in error, and should no longer be displayed.
        }
        
        /// <summary>
        /// Conversion of AlertStatusfrom and into string
        /// <summary>
        public static class AlertStatusHandling
        {
            public static bool TryParse(string value, out AlertStatus result)
            {
                result = default(AlertStatus);
                
                if( value=="active")
                    result = AlertStatus.Active;
                else if( value=="inactive")
                    result = AlertStatus.Inactive;
                else if( value=="error")
                    result = AlertStatus.Error;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(AlertStatus value)
            {
                if( value==AlertStatus.Active )
                    return "active";
                else if( value==AlertStatus.Inactive )
                    return "inactive";
                else if( value==AlertStatus.Error )
                    return "error";
                else
                    throw new ArgumentException("Unrecognized AlertStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The category of this alert
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Category { get; set; }
        
        /// <summary>
        /// active | inactive | incorrect
        /// </summary>
        public Code<Hl7.Fhir.Model.Alert.AlertStatus> StatusElement { get; set; }
        
        public Hl7.Fhir.Model.Alert.AlertStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Alert.AlertStatus>(value);
            }
        }
        
        /// <summary>
        /// Subject of this alert
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Alert creator
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Author { get; set; }
        
        /// <summary>
        /// Text of alert
        /// </summary>
        public Hl7.Fhir.Model.FhirString NoteElement { get; set; }
        
        public string Note
        {
            get { return NoteElement != null ? NoteElement.Value : null; }
            set
            {
                if(value == null)
                  NoteElement = null; 
                else
                  NoteElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Category != null )
                result.AddRange(Category.Validate());
            if(StatusElement != null )
                result.AddRange(StatusElement.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Author != null )
                result.AddRange(Author.Validate());
            if(NoteElement != null )
                result.AddRange(NoteElement.Validate());
            
            return result;
        }
    }
    
}
