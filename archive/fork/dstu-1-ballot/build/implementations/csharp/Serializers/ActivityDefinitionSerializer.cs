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
    * Serializer for ActivityDefinition instances
    */
    internal static partial class ActivityDefinitionSerializer
    {
        public static void SerializeActivityDefinition(Hl7.Fhir.Model.ActivityDefinition value, IFhirWriter writer)
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
            
            // Serialize element category
            if(value.Category != null)
            {
                writer.WriteStartElement("category");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.ActivityDefinition.ActivityDefinitionCategory>(value.Category, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element timing
            if(value.Timing != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("timing", value.Timing.GetType()) );
                FhirSerializer.SerializeElement(value.Timing, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element location
            if(value.Location != null)
            {
                writer.WriteStartElement("location");
                ResourceReferenceSerializer.SerializeResourceReference(value.Location, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element performer
            if(value.Performer != null && value.Performer.Count > 0)
            {
                writer.WriteStartArrayElement("performer");
                foreach(var item in value.Performer)
                {
                    writer.WriteStartArrayMember("performer");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element product
            if(value.Product != null)
            {
                writer.WriteStartElement("product");
                ResourceReferenceSerializer.SerializeResourceReference(value.Product, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element quantity
            if(value.Quantity != null)
            {
                writer.WriteStartElement("quantity");
                QuantitySerializer.SerializeQuantity(value.Quantity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element details
            if(value.Details != null)
            {
                writer.WriteStartElement("details");
                FhirStringSerializer.SerializeFhirString(value.Details, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
