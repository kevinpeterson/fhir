package org.hl7.fhir.instance.model;

/*
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

// Generated on Sat, Nov 10, 2012 08:14+1100 for FHIR v0.06

import java.util.*;
import org.hl7.fhir.utilities.xhtml.XhtmlNode;

/**
 * A human readable formatted text, including images
 */
public class Narrative extends Element {

    public enum NarrativeStatus {
        generated, // The contents of the narrative are entirely generated from the structured data in the resource.
        extensions, // The contents of the narrative are entirely generated from the structured data in the resource and some of the content is generated from extensions
        additional; // The contents of the narrative contain additional information not found in the structured data
        public static NarrativeStatus fromCode(String codeString) throws Exception {
            if (codeString == null || "".equals(codeString))
                return null;
        if ("generated".equals(codeString))
          return generated;
        if ("extensions".equals(codeString))
          return extensions;
        if ("additional".equals(codeString))
          return additional;
        throw new Exception("Unknown NarrativeStatus code '"+codeString+"'");
        }
        public String toCode() {
          switch (this) {
            case generated: return "generated";
            case extensions: return "extensions";
            case additional: return "additional";
            default: return "?";
          }
        }
    }

    public class Image extends Element {
        /**
         * Mime type of image
         */
        private String mimeType;

        /**
         * base64 image data
         */
        private byte[] content;

        public String getMimeType() { 
          return this.mimeType;
        }

        public void setMimeType(String value) { 
          this.mimeType = value;
        }

        public byte[] getContent() { 
          return this.content;
        }

        public void setContent(byte[] value) { 
          this.content = value;
        }

    }

    /**
     * The status of the narrative - whether it's entirely generated (from just the defined data or the extensions too), or whether a human authored it and it may contain additional data
     */
    private NarrativeStatus status;

    /**
     * The actual narrative content, a stripped down version of XHTML
     */
    private XhtmlNode div;

    /**
     * An image referred to directly in the xhtml
     */
    private List<Image> image = new ArrayList<Image>();

    public NarrativeStatus getStatus() { 
      return this.status;
    }

    public void setStatus(NarrativeStatus value) { 
      this.status = value;
    }

    public XhtmlNode getDiv() { 
      return this.div;
    }

    public void setDiv(XhtmlNode value) { 
      this.div = value;
    }

    public List<Image> getImage() { 
      return this.image;
    }


}

