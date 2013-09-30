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

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Protocol instances
    */
    internal static partial class ProtocolSerializer
    {
        public static void SerializeProtocol(Hl7.Fhir.Model.Protocol value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Protocol");
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element language
            if(value.Language != null)
            {
                writer.WriteStartElement("language");
                CodeSerializer.SerializeCode(value.Language, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.Text != null)
            {
                writer.WriteStartElement("text");
                NarrativeSerializer.SerializeNarrative(value.Text, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element contained
            if(value.Contained != null && value.Contained.Count > 0)
            {
                writer.WriteStartArrayElement("contained");
                foreach(var item in value.Contained)
                {
                    writer.WriteStartArrayMember("contained");
                    FhirSerializer.SerializeResource(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element title
            if(value.Title != null)
            {
                writer.WriteStartElement("title");
                FhirStringSerializer.SerializeFhirString(value.Title, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Protocol.ProtocolType>(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.Status != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Protocol.ProtocolStatus>(value.Status, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element author
            if(value.Author != null)
            {
                writer.WriteStartElement("author");
                ResourceReferenceSerializer.SerializeResourceReference(value.Author, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element purpose
            if(value.Purpose != null)
            {
                writer.WriteStartElement("purpose");
                FhirStringSerializer.SerializeFhirString(value.Purpose, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element group
            if(value.Group != null)
            {
                writer.WriteStartElement("group");
                ResourceReferenceSerializer.SerializeResourceReference(value.Group, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element step
            if(value.Step != null && value.Step.Count > 0)
            {
                writer.WriteStartArrayElement("step");
                foreach(var item in value.Step)
                {
                    writer.WriteStartArrayMember("step");
                    ProtocolSerializer.SerializeProtocolStepComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeProtocolStepPreconditionComponent(Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element condition
            if(value.Condition != null)
            {
                writer.WriteStartElement("condition");
                ProtocolSerializer.SerializeProtocolStepPreconditionConditionComponent(value.Condition, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element intersection
            if(value.Intersection != null && value.Intersection.Count > 0)
            {
                writer.WriteStartArrayElement("intersection");
                foreach(var item in value.Intersection)
                {
                    writer.WriteStartArrayMember("intersection");
                    ProtocolSerializer.SerializeProtocolStepPreconditionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element union
            if(value.Union != null && value.Union.Count > 0)
            {
                writer.WriteStartArrayElement("union");
                foreach(var item in value.Union)
                {
                    writer.WriteStartArrayMember("union");
                    ProtocolSerializer.SerializeProtocolStepPreconditionComponent(item, writer);
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
                    ProtocolSerializer.SerializeProtocolStepPreconditionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProtocolStepActivityComponentComponent(Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponentComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element sequence
            if(value.Sequence != null)
            {
                writer.WriteStartElement("sequence");
                IntegerSerializer.SerializeInteger(value.Sequence, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element activity
            if(value.Activity != null)
            {
                writer.WriteStartElement("activity");
                IdRefSerializer.SerializeIdRef(value.Activity, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProtocolStepPreconditionConditionComponent(Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionConditionComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element value
            if(value.Value != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("value", value.Value.GetType()) );
                FhirSerializer.SerializeElement(value.Value, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProtocolStepActivityComponent(Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element alternative
            if(value.Alternative != null && value.Alternative.Count > 0)
            {
                writer.WriteStartArrayElement("alternative");
                foreach(var item in value.Alternative)
                {
                    writer.WriteStartArrayMember("alternative");
                    IdRefSerializer.SerializeIdRef(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element component
            if(value.Component != null && value.Component.Count > 0)
            {
                writer.WriteStartArrayElement("component");
                foreach(var item in value.Component)
                {
                    writer.WriteStartArrayMember("component");
                    ProtocolSerializer.SerializeProtocolStepActivityComponentComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element following
            if(value.Following != null && value.Following.Count > 0)
            {
                writer.WriteStartArrayElement("following");
                foreach(var item in value.Following)
                {
                    writer.WriteStartArrayMember("following");
                    IdRefSerializer.SerializeIdRef(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element wait
            if(value.Wait != null)
            {
                writer.WriteStartElement("wait");
                QuantitySerializer.SerializeQuantity(value.Wait, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element detail
            if(value.Detail != null)
            {
                writer.WriteStartElement("detail");
                ActivityDefinitionSerializer.SerializeActivityDefinition(value.Detail, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProtocolStepComponent(Hl7.Fhir.Model.Protocol.ProtocolStepComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.Name, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element duration
            if(value.Duration != null)
            {
                writer.WriteStartElement("duration");
                QuantitySerializer.SerializeQuantity(value.Duration, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element precondition
            if(value.Precondition != null)
            {
                writer.WriteStartElement("precondition");
                ProtocolSerializer.SerializeProtocolStepPreconditionComponent(value.Precondition, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element exit
            if(value.Exit != null)
            {
                writer.WriteStartElement("exit");
                ProtocolSerializer.SerializeProtocolStepPreconditionComponent(value.Exit, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element firstActivity
            if(value.FirstActivity != null)
            {
                writer.WriteStartElement("firstActivity");
                IdRefSerializer.SerializeIdRef(value.FirstActivity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element activity
            if(value.Activity != null && value.Activity.Count > 0)
            {
                writer.WriteStartArrayElement("activity");
                foreach(var item in value.Activity)
                {
                    writer.WriteStartArrayMember("activity");
                    ProtocolSerializer.SerializeProtocolStepActivityComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element next
            if(value.Next != null && value.Next.Count > 0)
            {
                writer.WriteStartArrayElement("next");
                foreach(var item in value.Next)
                {
                    writer.WriteStartArrayMember("next");
                    ProtocolSerializer.SerializeProtocolStepNextComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProtocolStepNextComponent(Hl7.Fhir.Model.Protocol.ProtocolStepNextComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element _id
            if(value.LocalId != null)
            {
                writer.WriteStartElement("_id");
                IdSerializer.SerializeId(value.LocalId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element id
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                IdRefSerializer.SerializeIdRef(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element condition
            if(value.Condition != null)
            {
                writer.WriteStartElement("condition");
                ProtocolSerializer.SerializeProtocolStepPreconditionComponent(value.Condition, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
