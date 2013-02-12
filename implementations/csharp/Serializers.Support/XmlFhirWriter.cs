﻿/*
  Copyright (c) 2011-2012, HL7, Inc.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using HL7.Fhir.Instance.Support;

namespace HL7.Fhir.Instance.Serializers
{
    public class XmlFhirWriter : IFhirWriter
    {
        private XmlWriter xw;

        public XmlFhirWriter(XmlWriter xwriter)
        {
            xw = xwriter;
        }

        public void WriteStartRootObject(string name)
        {
            WriteStartElement(name);
        }

        public void WriteEndRootObject()
        {
            WriteEndElement();
        }

        public void WriteStartElement(string name)
        {
            xw.WriteStartElement(name, Util.FHIRNS);            
        }

        public void WriteEndElement()
        {
            xw.WriteEndElement();
        }

        public void WriteStartComplexContent()
        {
            // Nothing
        }

        public void WriteEndComplexContent()
        {
            // Nothing
        }

        public void WritePrimitiveContents(string value)
        {
            xw.WriteAttributeString(Parsers.XmlFhirReader.VALUEATTR, value);
        }
        
        public void WriteXhtmlContents(string xhtml)
        {
            // Write xhtml directly into the output stream,
            // the xhtml <div> becomes part of the elements
            // of the type, just like the other FHIR elements
            xw.WriteRaw(xhtml);
        }


        public void WriteRefIdContents(string id)
        {
            xw.WriteAttributeString(Parsers.XmlFhirReader.IDATTR, id);
        }

        public void WriteStartArrayElement(string name)
        {
            // Nothing
        }

        public void WriteStartArrayMember(string name)
        {
            WriteStartElement(name);
        }

        public void WriteEndArrayMember()
        {
            WriteEndElement();
        }

        public void WriteEndArrayElement()
        {
            // Nothing
        }

        void IDisposable.Dispose()
        {
            ((IDisposable)xw).Dispose();
        }
    }
}
