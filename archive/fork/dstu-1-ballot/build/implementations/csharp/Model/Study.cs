using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

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
// Generated on Wed, Jun 19, 2013 01:55+1000 for FHIR v0.09
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Research study
    /// </summary>
    [FhirResource("Study")]
    public partial class Study : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Indicates whether the study observes or directs behavior of subjects
        /// </summary>
        public enum StudyType
        {
            Interventional,
            Observational,
            ExpandedAccess,
        }
        
        /// <summary>
        /// Conversion of StudyTypefrom and into string
        /// <summary>
        public static class StudyTypeHandling
        {
            public static bool TryParse(string value, out StudyType result)
            {
                result = default(StudyType);
                
                if( value=="interventional")
                    result = StudyType.Interventional;
                else if( value=="observational")
                    result = StudyType.Observational;
                else if( value=="expanded access")
                    result = StudyType.ExpandedAccess;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyType value)
            {
                if( value==StudyType.Interventional )
                    return "interventional";
                else if( value==StudyType.Observational )
                    return "observational";
                else if( value==StudyType.ExpandedAccess )
                    return "expanded access";
                else
                    throw new ArgumentException("Unrecognized StudyType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The general design pattern for the study in terms of how interventions are experienced by the study subjects
        /// </summary>
        public enum StudyInterventionModel
        {
            CrossOver,
            Factorial,
            Parallel,
            SingleGroup,
        }
        
        /// <summary>
        /// Conversion of StudyInterventionModelfrom and into string
        /// <summary>
        public static class StudyInterventionModelHandling
        {
            public static bool TryParse(string value, out StudyInterventionModel result)
            {
                result = default(StudyInterventionModel);
                
                if( value=="cross-over")
                    result = StudyInterventionModel.CrossOver;
                else if( value=="factorial")
                    result = StudyInterventionModel.Factorial;
                else if( value=="parallel")
                    result = StudyInterventionModel.Parallel;
                else if( value=="single group")
                    result = StudyInterventionModel.SingleGroup;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyInterventionModel value)
            {
                if( value==StudyInterventionModel.CrossOver )
                    return "cross-over";
                else if( value==StudyInterventionModel.Factorial )
                    return "factorial";
                else if( value==StudyInterventionModel.Parallel )
                    return "parallel";
                else if( value==StudyInterventionModel.SingleGroup )
                    return "single group";
                else
                    throw new ArgumentException("Unrecognized StudyInterventionModel value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The type of control therapy used for comparison in the study
        /// </summary>
        public enum StudyControlType
        {
            Placebo,
            Active,
            Historical,
            Uncontrolled,
            DoseComparison,
        }
        
        /// <summary>
        /// Conversion of StudyControlTypefrom and into string
        /// <summary>
        public static class StudyControlTypeHandling
        {
            public static bool TryParse(string value, out StudyControlType result)
            {
                result = default(StudyControlType);
                
                if( value=="placebo")
                    result = StudyControlType.Placebo;
                else if( value=="active")
                    result = StudyControlType.Active;
                else if( value=="historical")
                    result = StudyControlType.Historical;
                else if( value=="uncontrolled")
                    result = StudyControlType.Uncontrolled;
                else if( value=="dose comparison")
                    result = StudyControlType.DoseComparison;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyControlType value)
            {
                if( value==StudyControlType.Placebo )
                    return "placebo";
                else if( value==StudyControlType.Active )
                    return "active";
                else if( value==StudyControlType.Historical )
                    return "historical";
                else if( value==StudyControlType.Uncontrolled )
                    return "uncontrolled";
                else if( value==StudyControlType.DoseComparison )
                    return "dose comparison";
                else
                    throw new ArgumentException("Unrecognized StudyControlType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// How is a treatment used in the study
        /// </summary>
        public enum StudyTreatmentRole
        {
            Investigational,
            Comparative,
            Current,
        }
        
        /// <summary>
        /// Conversion of StudyTreatmentRolefrom and into string
        /// <summary>
        public static class StudyTreatmentRoleHandling
        {
            public static bool TryParse(string value, out StudyTreatmentRole result)
            {
                result = default(StudyTreatmentRole);
                
                if( value=="investigational")
                    result = StudyTreatmentRole.Investigational;
                else if( value=="comparative")
                    result = StudyTreatmentRole.Comparative;
                else if( value=="current")
                    result = StudyTreatmentRole.Current;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyTreatmentRole value)
            {
                if( value==StudyTreatmentRole.Investigational )
                    return "investigational";
                else if( value==StudyTreatmentRole.Comparative )
                    return "comparative";
                else if( value==StudyTreatmentRole.Current )
                    return "current";
                else
                    throw new ArgumentException("Unrecognized StudyTreatmentRole value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The general category of intervention performed by the study
        /// </summary>
        public enum StudyInterventionType
        {
            DietarySupplement,
            BehavioralTherapy,
            Biologic,
            Device,
            Drug,
            Genetic,
            Other,
            Procedure,
            Radiation,
        }
        
        /// <summary>
        /// Conversion of StudyInterventionTypefrom and into string
        /// <summary>
        public static class StudyInterventionTypeHandling
        {
            public static bool TryParse(string value, out StudyInterventionType result)
            {
                result = default(StudyInterventionType);
                
                if( value=="dietary supplement")
                    result = StudyInterventionType.DietarySupplement;
                else if( value=="behavioral therapy")
                    result = StudyInterventionType.BehavioralTherapy;
                else if( value=="biologic")
                    result = StudyInterventionType.Biologic;
                else if( value=="device")
                    result = StudyInterventionType.Device;
                else if( value=="drug")
                    result = StudyInterventionType.Drug;
                else if( value=="genetic")
                    result = StudyInterventionType.Genetic;
                else if( value=="other")
                    result = StudyInterventionType.Other;
                else if( value=="procedure")
                    result = StudyInterventionType.Procedure;
                else if( value=="radiation")
                    result = StudyInterventionType.Radiation;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyInterventionType value)
            {
                if( value==StudyInterventionType.DietarySupplement )
                    return "dietary supplement";
                else if( value==StudyInterventionType.BehavioralTherapy )
                    return "behavioral therapy";
                else if( value==StudyInterventionType.Biologic )
                    return "biologic";
                else if( value==StudyInterventionType.Device )
                    return "device";
                else if( value==StudyInterventionType.Drug )
                    return "drug";
                else if( value==StudyInterventionType.Genetic )
                    return "genetic";
                else if( value==StudyInterventionType.Other )
                    return "other";
                else if( value==StudyInterventionType.Procedure )
                    return "procedure";
                else if( value==StudyInterventionType.Radiation )
                    return "radiation";
                else
                    throw new ArgumentException("Unrecognized StudyInterventionType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The approach to blinding taken by the study
        /// </summary>
        public enum StudyBlindingScheme
        {
            OpenLabel,
            DoubleBlind,
            SingleBlind,
        }
        
        /// <summary>
        /// Conversion of StudyBlindingSchemefrom and into string
        /// <summary>
        public static class StudyBlindingSchemeHandling
        {
            public static bool TryParse(string value, out StudyBlindingScheme result)
            {
                result = default(StudyBlindingScheme);
                
                if( value=="open label")
                    result = StudyBlindingScheme.OpenLabel;
                else if( value=="double blind")
                    result = StudyBlindingScheme.DoubleBlind;
                else if( value=="single blind")
                    result = StudyBlindingScheme.SingleBlind;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyBlindingScheme value)
            {
                if( value==StudyBlindingScheme.OpenLabel )
                    return "open label";
                else if( value==StudyBlindingScheme.DoubleBlind )
                    return "double blind";
                else if( value==StudyBlindingScheme.SingleBlind )
                    return "single blind";
                else
                    throw new ArgumentException("Unrecognized StudyBlindingScheme value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyInterventionComponent")]
        public partial class StudyInterventionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// What kind of intervention
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// e.g. cross-over | factorial | parallel | single group
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Model { get; set; }
            
            /// <summary>
            /// Are study participants randomly assigned?
            /// </summary>
            public Hl7.Fhir.Model.FhirBoolean Randomized { get; set; }
            
            /// <summary>
            /// e.g. open label | double blind | single blind
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept BlindingScheme { get; set; }
            
            /// <summary>
            /// What portion of subjects receive therapy?
            /// </summary>
            public Hl7.Fhir.Model.Element RandomizationQuotient { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyTreatmentComponent")]
        public partial class StudyTreatmentComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// investigational | comparative | current
            /// </summary>
            public Code<Hl7.Fhir.Model.Study.StudyTreatmentRole> Role { get; set; }
            
            /// <summary>
            /// Treatment details
            /// </summary>
            public Hl7.Fhir.Model.ActivityDefinition Detail { get; set; }
            
        }
        
        
        /// <summary>
        /// Id for study
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// Who's responsible?
        /// </summary>
        public Hl7.Fhir.Model.FhirString Sponsor { get; set; }
        
        /// <summary>
        /// Name of study
        /// </summary>
        public Hl7.Fhir.Model.FhirString Title { get; set; }
        
        /// <summary>
        /// Description of study
        /// </summary>
        public Hl7.Fhir.Model.FhirString Description { get; set; }
        
        /// <summary>
        /// e.g. interventional | observational | expanded access
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
        
        /// <summary>
        /// Condition(s) addressed
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> Condition { get; set; }
        
        /// <summary>
        /// Focal treatments for study
        /// </summary>
        public List<Hl7.Fhir.Model.Study.StudyTreatmentComponent> Treatment { get; set; }
        
        /// <summary>
        /// e.g. placebo | active | historical | uncontrolled | dose comparison
        /// </summary>
        public List<Hl7.Fhir.Model.CodeableConcept> ControlType { get; set; }
        
        /// <summary>
        /// What will study accomplish?
        /// </summary>
        public List<Hl7.Fhir.Model.FhirString> Objective { get; set; }
        
        /// <summary>
        /// How will we know if it's accomplished?
        /// </summary>
        public List<Hl7.Fhir.Model.FhirString> OutcomeMeasure { get; set; }
        
        /// <summary>
        /// Eligibility criteria
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Eligibility { get; set; }
        
        /// <summary>
        /// When will/did study begin & end
        /// </summary>
        public Hl7.Fhir.Model.Period Period { get; set; }
        
        /// <summary>
        /// How long it will run
        /// </summary>
        public Hl7.Fhir.Model.Duration Duration { get; set; }
        
        /// <summary>
        /// Intended # of subjects
        /// </summary>
        public Hl7.Fhir.Model.Integer PlannedEnrollment { get; set; }
        
        /// <summary>
        /// Information for interventional studies
        /// </summary>
        public Hl7.Fhir.Model.Study.StudyInterventionComponent Intervention { get; set; }
        
        /// <summary>
        /// What steps are to be followed for participants in study?
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Protocol { get; set; }
        
        /// <summary>
        /// What data is submitted
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference DataStructure { get; set; }
        
        /// <summary>
        /// Data collected during study
        /// </summary>
        public List<Hl7.Fhir.Model.ResourceReference> Data { get; set; }
        
    }
    
}
