﻿using System;
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
    * Serializer for Query instances
    */
    internal static partial class QuerySerializer
    {
        public static void SerializeQuery(Hl7.Fhir.Model.Query value, IFhirWriter writer, bool summary)
        {
            writer.WriteStartRootObject("Query");
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
            if(value.IdentifierElement != null && !summary)
            {
                writer.WriteStartElement("identifier");
                FhirUriSerializer.SerializeFhirUri(value.IdentifierElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element parameter
            if(value.Parameter != null && !summary && value.Parameter.Count > 0)
            {
                writer.WriteStartArrayElement("parameter");
                foreach(var item in value.Parameter)
                {
                    writer.WriteStartArrayMember("parameter");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element response
            if(value.Response != null && !summary)
            {
                writer.WriteStartElement("response");
                QuerySerializer.SerializeQueryResponseComponent(value.Response, writer, summary);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeQueryResponseComponent(Hl7.Fhir.Model.Query.QueryResponseComponent value, IFhirWriter writer, bool summary)
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
            if(value.IdentifierElement != null)
            {
                writer.WriteStartElement("identifier");
                FhirUriSerializer.SerializeFhirUri(value.IdentifierElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element outcome
            if(value.OutcomeElement != null)
            {
                writer.WriteStartElement("outcome");
                CodeSerializer.SerializeCode<Hl7.Fhir.Model.Query.QueryOutcome>(value.OutcomeElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element total
            if(value.TotalElement != null)
            {
                writer.WriteStartElement("total");
                IntegerSerializer.SerializeInteger(value.TotalElement, writer, summary);
                writer.WriteEndElement();
            }
            
            // Serialize element parameter
            if(value.Parameter != null && value.Parameter.Count > 0)
            {
                writer.WriteStartArrayElement("parameter");
                foreach(var item in value.Parameter)
                {
                    writer.WriteStartArrayMember("parameter");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element first
            if(value.First != null && value.First.Count > 0)
            {
                writer.WriteStartArrayElement("first");
                foreach(var item in value.First)
                {
                    writer.WriteStartArrayMember("first");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element previous
            if(value.Previous != null && value.Previous.Count > 0)
            {
                writer.WriteStartArrayElement("previous");
                foreach(var item in value.Previous)
                {
                    writer.WriteStartArrayMember("previous");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
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
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element last
            if(value.Last != null && value.Last.Count > 0)
            {
                writer.WriteStartArrayElement("last");
                foreach(var item in value.Last)
                {
                    writer.WriteStartArrayMember("last");
                    ExtensionSerializer.SerializeExtension(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element reference
            if(value.Reference != null && value.Reference.Count > 0)
            {
                writer.WriteStartArrayElement("reference");
                foreach(var item in value.Reference)
                {
                    writer.WriteStartArrayMember("reference");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer, summary);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}