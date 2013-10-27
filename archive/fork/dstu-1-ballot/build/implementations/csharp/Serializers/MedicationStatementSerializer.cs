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
    * Serializer for MedicationStatement instances
    */
    internal static partial class MedicationStatementSerializer
    {
        public static void SerializeMedicationStatement(Hl7.Fhir.Model.MedicationStatement value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("MedicationStatement");
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
            if(value.Identifier != null && !summary && value.Identifier.Count > 0)
            {
                writer.WriteStartArrayElement("identifier");
                foreach(var item in value.Identifier)
                {
                    writer.WriteStartArrayMember("identifier");
                    IdentifierSerializer.SerializeIdentifier(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element patient
            if(value.Patient != null && !summary)
            {
                writer.WriteStartElement("patient");
                ResourceReferenceSerializer.SerializeResourceReference(value.Patient, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element wasNotGiven
            if(value.WasNotGivenElement != null && !summary)
            {
                writer.WriteStartElement("wasNotGiven");
                FhirBooleanSerializer.SerializeFhirBoolean(value.WasNotGivenElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element reasonNotGiven
            if(value.ReasonNotGiven != null && !summary && value.ReasonNotGiven.Count > 0)
            {
                writer.WriteStartArrayElement("reasonNotGiven");
                foreach(var item in value.ReasonNotGiven)
                {
                    writer.WriteStartArrayMember("reasonNotGiven");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element whenGiven
            if(value.WhenGiven != null && !summary)
            {
                writer.WriteStartElement("whenGiven");
                PeriodSerializer.SerializePeriod(value.WhenGiven, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element medication
            if(value.Medication != null && !summary)
            {
                writer.WriteStartElement("medication");
                ResourceReferenceSerializer.SerializeResourceReference(value.Medication, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element administrationDevice
            if(value.AdministrationDevice != null && !summary && value.AdministrationDevice.Count > 0)
            {
                writer.WriteStartArrayElement("administrationDevice");
                foreach(var item in value.AdministrationDevice)
                {
                    writer.WriteStartArrayMember("administrationDevice");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element dosage
            if(value.Dosage != null && !summary && value.Dosage.Count > 0)
            {
                writer.WriteStartArrayElement("dosage");
                foreach(var item in value.Dosage)
                {
                    writer.WriteStartArrayMember("dosage");
                    MedicationStatementSerializer.SerializeMedicationStatementDosageComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeMedicationStatementDosageComponent(Hl7.Fhir.Model.MedicationStatement.MedicationStatementDosageComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element timing
            if(value.Timing != null)
            {
                writer.WriteStartElement("timing");
                ScheduleSerializer.SerializeSchedule(value.Timing, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element site
            if(value.Site != null)
            {
                writer.WriteStartElement("site");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Site, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element route
            if(value.Route != null)
            {
                writer.WriteStartElement("route");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Route, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element method
            if(value.Method != null)
            {
                writer.WriteStartElement("method");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Method, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element quantity
            if(value.Quantity != null)
            {
                writer.WriteStartElement("quantity");
                QuantitySerializer.SerializeQuantity(value.Quantity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element rate
            if(value.Rate != null)
            {
                writer.WriteStartElement("rate");
                RatioSerializer.SerializeRatio(value.Rate, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element maxDosePerPeriod
            if(value.MaxDosePerPeriod != null)
            {
                writer.WriteStartElement("maxDosePerPeriod");
                RatioSerializer.SerializeRatio(value.MaxDosePerPeriod, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
