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
    * Serializer for Test instances
    */
    internal static partial class TestSerializer
    {
        public static void SerializeTest(Hl7.Fhir.Model.Test value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Test");
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
            
            // Serialize element stringErr
            if(value.StringErr != null && value.StringErr.Count > 0)
            {
                writer.WriteStartArrayElement("stringErr");
                foreach(var item in value.StringErr)
                {
                    writer.WriteStartArrayMember("stringErr");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element stringCorr
            if(value.StringCorr != null && value.StringCorr.Count > 0)
            {
                writer.WriteStartArrayElement("stringCorr");
                foreach(var item in value.StringCorr)
                {
                    writer.WriteStartArrayMember("stringCorr");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element booleanErr
            if(value.BooleanErr != null && value.BooleanErr.Count > 0)
            {
                writer.WriteStartArrayElement("booleanErr");
                foreach(var item in value.BooleanErr)
                {
                    writer.WriteStartArrayMember("booleanErr");
                    FhirBooleanSerializer.SerializeFhirBoolean(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element booleanCorr
            if(value.BooleanCorr != null && value.BooleanCorr.Count > 0)
            {
                writer.WriteStartArrayElement("booleanCorr");
                foreach(var item in value.BooleanCorr)
                {
                    writer.WriteStartArrayMember("booleanCorr");
                    FhirBooleanSerializer.SerializeFhirBoolean(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element integerErr
            if(value.IntegerErr != null && value.IntegerErr.Count > 0)
            {
                writer.WriteStartArrayElement("integerErr");
                foreach(var item in value.IntegerErr)
                {
                    writer.WriteStartArrayMember("integerErr");
                    IntegerSerializer.SerializeInteger(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element integerCorr
            if(value.IntegerCorr != null && value.IntegerCorr.Count > 0)
            {
                writer.WriteStartArrayElement("integerCorr");
                foreach(var item in value.IntegerCorr)
                {
                    writer.WriteStartArrayMember("integerCorr");
                    IntegerSerializer.SerializeInteger(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element decimalErr
            if(value.DecimalErr != null && value.DecimalErr.Count > 0)
            {
                writer.WriteStartArrayElement("decimalErr");
                foreach(var item in value.DecimalErr)
                {
                    writer.WriteStartArrayMember("decimalErr");
                    FhirDecimalSerializer.SerializeFhirDecimal(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element decimalCorr
            if(value.DecimalCorr != null && value.DecimalCorr.Count > 0)
            {
                writer.WriteStartArrayElement("decimalCorr");
                foreach(var item in value.DecimalCorr)
                {
                    writer.WriteStartArrayMember("decimalCorr");
                    FhirDecimalSerializer.SerializeFhirDecimal(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element b64Err
            if(value.B64Err != null && value.B64Err.Count > 0)
            {
                writer.WriteStartArrayElement("b64Err");
                foreach(var item in value.B64Err)
                {
                    writer.WriteStartArrayMember("b64Err");
                    Base64BinarySerializer.SerializeBase64Binary(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element b64Corr
            if(value.B64Corr != null && value.B64Corr.Count > 0)
            {
                writer.WriteStartArrayElement("b64Corr");
                foreach(var item in value.B64Corr)
                {
                    writer.WriteStartArrayMember("b64Corr");
                    Base64BinarySerializer.SerializeBase64Binary(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element instantErr
            if(value.InstantErr != null && value.InstantErr.Count > 0)
            {
                writer.WriteStartArrayElement("instantErr");
                foreach(var item in value.InstantErr)
                {
                    writer.WriteStartArrayMember("instantErr");
                    InstantSerializer.SerializeInstant(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element instantCorr
            if(value.InstantCorr != null && value.InstantCorr.Count > 0)
            {
                writer.WriteStartArrayElement("instantCorr");
                foreach(var item in value.InstantCorr)
                {
                    writer.WriteStartArrayMember("instantCorr");
                    InstantSerializer.SerializeInstant(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element uriErr
            if(value.UriErr != null && value.UriErr.Count > 0)
            {
                writer.WriteStartArrayElement("uriErr");
                foreach(var item in value.UriErr)
                {
                    writer.WriteStartArrayMember("uriErr");
                    FhirUriSerializer.SerializeFhirUri(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element uriCorr
            if(value.UriCorr != null && value.UriCorr.Count > 0)
            {
                writer.WriteStartArrayElement("uriCorr");
                foreach(var item in value.UriCorr)
                {
                    writer.WriteStartArrayMember("uriCorr");
                    FhirUriSerializer.SerializeFhirUri(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element idrefSingle
            if(value.IdrefSingle != null)
            {
                writer.WriteStartElement("idrefSingle");
                IdRefSerializer.SerializeIdRef(value.IdrefSingle, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
    }
}
