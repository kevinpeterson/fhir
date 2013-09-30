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

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Supply instances
    */
    internal static partial class SupplySerializer
    {
        public static void SerializeSupply(Hl7.Fhir.Model.Supply value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Supply");
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
            
            // Serialize element name
            if(value.Name != null && !summary)
            {
                writer.WriteStartElement("name");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Name, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element identifier
            if(value.Identifier != null && !summary)
            {
                writer.WriteStartElement("identifier");
                IdentifierSerializer.SerializeIdentifier(value.Identifier, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null && !summary)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element orderedItem
            if(value.OrderedItem != null && !summary)
            {
                writer.WriteStartElement("orderedItem");
                ResourceReferenceSerializer.SerializeResourceReference(value.OrderedItem, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element patient
            if(value.Patient != null && !summary)
            {
                writer.WriteStartElement("patient");
                ResourceReferenceSerializer.SerializeResourceReference(value.Patient, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element dispense
            if(value.Dispense != null && !summary && value.Dispense.Count > 0)
            {
                writer.WriteStartArrayElement("dispense");
                foreach(var item in value.Dispense)
                {
                    writer.WriteStartArrayMember("dispense");
                    SupplySerializer.SerializeSupplyDispenseComponent(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeSupplyDispenseComponent(Hl7.Fhir.Model.Supply.SupplyDispenseComponent value, IFhirWriter writer, bool summary)
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
            
            // Serialize element identifier
            if(value.Identifier != null)
            {
                writer.WriteStartElement("identifier");
                IdentifierSerializer.SerializeIdentifier(value.Identifier, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.StatusElement != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode(value.StatusElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element quantity
            if(value.Quantity != null)
            {
                writer.WriteStartElement("quantity");
                QuantitySerializer.SerializeQuantity(value.Quantity, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element suppliedItem
            if(value.SuppliedItem != null)
            {
                writer.WriteStartElement("suppliedItem");
                ResourceReferenceSerializer.SerializeResourceReference(value.SuppliedItem, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element supplier
            if(value.Supplier != null)
            {
                writer.WriteStartElement("supplier");
                ResourceReferenceSerializer.SerializeResourceReference(value.Supplier, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element whenPrepared
            if(value.WhenPrepared != null)
            {
                writer.WriteStartElement("whenPrepared");
                PeriodSerializer.SerializePeriod(value.WhenPrepared, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element whenHandedOver
            if(value.WhenHandedOver != null)
            {
                writer.WriteStartElement("whenHandedOver");
                PeriodSerializer.SerializePeriod(value.WhenHandedOver, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element destination
            if(value.Destination != null)
            {
                writer.WriteStartElement("destination");
                ResourceReferenceSerializer.SerializeResourceReference(value.Destination, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element receiver
            if(value.Receiver != null && value.Receiver.Count > 0)
            {
                writer.WriteStartArrayElement("receiver");
                foreach(var item in value.Receiver)
                {
                    writer.WriteStartArrayMember("receiver");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
