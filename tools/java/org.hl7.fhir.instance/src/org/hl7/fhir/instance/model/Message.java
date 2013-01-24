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

// Generated on Fri, Jan 25, 2013 06:40+1100 for FHIR v0.07

import java.util.*;

import java.net.*;
/**
 * A transmission requesting action on a bundle of one or more resources or a response to such a request
 */
public class Message extends Resource {

    public enum ResponseCode {
        ok, // The message was accepted and processed without error
        error, // Some internal unexpected error occurred - wait and try again. Note - this is usually used for things like database unavailable, which may be expected to resolve, though human intervention may be required
        rejection, // The message was rejected because of some content in it. There is no point in re-sending without change. The response narrative must describe what the issue is.
        rules, // The message was rejected because of some event-specific business rules, and it may be possible to modify the request and re-submit (as a different request). The response must include an Issue report that describes what problem is
        undeliverable, // A middleware agent was unable to deliver the message to its intended destination
        Null; // added to help the parsers
        public static ResponseCode fromCode(String codeString) throws Exception {
            if (codeString == null || "".equals(codeString))
                return null;
        if ("ok".equals(codeString))
          return ok;
        if ("error".equals(codeString))
          return error;
        if ("rejection".equals(codeString))
          return rejection;
        if ("rules".equals(codeString))
          return rules;
        if ("undeliverable".equals(codeString))
          return undeliverable;
        throw new Exception("Unknown ResponseCode code '"+codeString+"'");
        }
        public String toCode() {
          switch (this) {
            case ok: return "ok";
            case error: return "error";
            case rejection: return "rejection";
            case rules: return "rules";
            case undeliverable: return "undeliverable";
            default: return "?";
          }
        }
    }

  public class ResponseCodeEnumFactory implements EnumFactory {
    public Enum<?> fromCode(String codeString) throws Exception {
      if (codeString == null || "".equals(codeString))
            if (codeString == null || "".equals(codeString))
                return null;
        if ("ok".equals(codeString))
          return ResponseCode.ok;
        if ("error".equals(codeString))
          return ResponseCode.error;
        if ("rejection".equals(codeString))
          return ResponseCode.rejection;
        if ("rules".equals(codeString))
          return ResponseCode.rules;
        if ("undeliverable".equals(codeString))
          return ResponseCode.undeliverable;
        throw new Exception("Unknown ResponseCode code '"+codeString+"'");
        }
    public String toCode(Enum<?> code) throws Exception {
      if (code == ResponseCode.ok)
        return "ok";
      if (code == ResponseCode.error)
        return "error";
      if (code == ResponseCode.rejection)
        return "rejection";
      if (code == ResponseCode.rules)
        return "rules";
      if (code == ResponseCode.undeliverable)
        return "undeliverable";
      return "?";
      }
    }

    public class Response extends Element {
        /**
         * The id of the message that this a response to
         */
        private Id id;

        /**
         * Code that identifies the type of response to the message - whether it was successful or not, and whether it should be resent or not
         */
        private Enumeration<ResponseCode> code;

        /**
         * Full details of any issues found in the message
         */
        private ResourceReference details;

        public Id getId() { 
          return this.id;
        }

        public void setId(Id value) { 
          this.id = value;
        }

        public String getIdSimple() { 
          return this.id == null ? null : this.id.getValue();
        }

        public void setIdSimple(String value) { 
          if (value == null)
            this.id = null;
          else {
            if (this.id == null)
              this.id = new Id();
            this.id.setValue(value);
          }
        }

        public Enumeration<ResponseCode> getCode() { 
          return this.code;
        }

        public void setCode(Enumeration<ResponseCode> value) { 
          this.code = value;
        }

        public ResponseCode getCodeSimple() { 
          return this.code == null ? null : this.code.getValue();
        }

        public void setCodeSimple(ResponseCode value) { 
          if (value == null)
            this.code = null;
          else {
            if (this.code == null)
              this.code = new Enumeration<ResponseCode>();
            this.code.setValue(value);
          }
        }

        public ResourceReference getDetails() { 
          return this.details;
        }

        public void setDetails(ResourceReference value) { 
          this.details = value;
        }

  }

    public class Source extends Element {
        /**
         * Human readable name for the target system
         */
        private String_ name;

        /**
         * May include configuration or other information useful in debugging.
         */
        private String_ software;

        /**
         * Can convey versions of multiple systems in situations where a message passes through multiple hands.
         */
        private String_ version;

        /**
         * An e-mail, phone, website or other contact point to use to resolve issues with message communications.
         */
        private Contact contact;

        /**
         * Identifies the routing target to send acknowledgements to.
         */
        private Uri endpoint;

        public String_ getName() { 
          return this.name;
        }

        public void setName(String_ value) { 
          this.name = value;
        }

        public String getNameSimple() { 
          return this.name == null ? null : this.name.getValue();
        }

        public void setNameSimple(String value) { 
          if (value == null)
            this.name = null;
          else {
            if (this.name == null)
              this.name = new String_();
            this.name.setValue(value);
          }
        }

        public String_ getSoftware() { 
          return this.software;
        }

        public void setSoftware(String_ value) { 
          this.software = value;
        }

        public String getSoftwareSimple() { 
          return this.software == null ? null : this.software.getValue();
        }

        public void setSoftwareSimple(String value) { 
          if (value == null)
            this.software = null;
          else {
            if (this.software == null)
              this.software = new String_();
            this.software.setValue(value);
          }
        }

        public String_ getVersion() { 
          return this.version;
        }

        public void setVersion(String_ value) { 
          this.version = value;
        }

        public String getVersionSimple() { 
          return this.version == null ? null : this.version.getValue();
        }

        public void setVersionSimple(String value) { 
          if (value == null)
            this.version = null;
          else {
            if (this.version == null)
              this.version = new String_();
            this.version.setValue(value);
          }
        }

        public Contact getContact() { 
          return this.contact;
        }

        public void setContact(Contact value) { 
          this.contact = value;
        }

        public Uri getEndpoint() { 
          return this.endpoint;
        }

        public void setEndpoint(Uri value) { 
          this.endpoint = value;
        }

        public URI getEndpointSimple() { 
          return this.endpoint == null ? null : this.endpoint.getValue();
        }

        public void setEndpointSimple(URI value) { 
          if (value == null)
            this.endpoint = null;
          else {
            if (this.endpoint == null)
              this.endpoint = new Uri();
            this.endpoint.setValue(value);
          }
        }

  }

    public class Destination extends Element {
        /**
         * Human readable name for the source system
         */
        private String_ name;

        /**
         * Identifies the target end system in situations where the initial message transmission is to an intermediary system.
         */
        private ResourceReference target;

        /**
         * Indicates where the message should be routed to.
         */
        private Uri endpoint;

        public String_ getName() { 
          return this.name;
        }

        public void setName(String_ value) { 
          this.name = value;
        }

        public String getNameSimple() { 
          return this.name == null ? null : this.name.getValue();
        }

        public void setNameSimple(String value) { 
          if (value == null)
            this.name = null;
          else {
            if (this.name == null)
              this.name = new String_();
            this.name.setValue(value);
          }
        }

        public ResourceReference getTarget() { 
          return this.target;
        }

        public void setTarget(ResourceReference value) { 
          this.target = value;
        }

        public Uri getEndpoint() { 
          return this.endpoint;
        }

        public void setEndpoint(Uri value) { 
          this.endpoint = value;
        }

        public URI getEndpointSimple() { 
          return this.endpoint == null ? null : this.endpoint.getValue();
        }

        public void setEndpointSimple(URI value) { 
          if (value == null)
            this.endpoint = null;
          else {
            if (this.endpoint == null)
              this.endpoint = new Uri();
            this.endpoint.setValue(value);
          }
        }

  }

    /**
     * The identifier of this message
     */
    private Id id;

    /**
     * Instant the message was sent
     */
    private Instant instant;

    /**
     * Code that identifies the event this message represents and connects it with the event definition in the FHIR specification
     */
    private Code event;

    /**
     * Information about the message that this message is a response to.  Only present if this message is a response.
     */
    private Response response;

    /**
     * The source application from which this message originated
     */
    private Source source;

    /**
     * The destination application which the message is intended for
     */
    private Destination destination;

    /**
     * The person or device that performed the data entry leading to this Message. Where there is more than one candidate, pick the most proximal to the Message. Can provide other enterers in extensions
     */
    private ResourceReference enterer;

    /**
     * The logical author of the message - the person or device that decided the described event should happen. Where there is more than one candidate, pick the most proximal to the Message. Can provide other authors in extensions
     */
    private ResourceReference author;

    /**
     * Allows data conveyed by a message to be addressed to a particular person or department when routing to a specific application isn't sufficient.
     */
    private ResourceReference receiver;

    /**
     * The person or organization that accepts overall responsibility for the contents of the Message. The implication is that the message event happened under the policies of the responsible party
     */
    private ResourceReference responsible;

    /**
     * The effective time - the real world time of the event that the message represents. Usually this is just a starting time, but some message events also have an end time (do x for period y)
     */
    private Period effective;

    /**
     * The cause of the event - a reason for the event that is a focus of this message occurred
     */
    private CodeableConcept reason;

    /**
     * The actual data of the message - a reference to the root/focus class of the event. 
     */
    private List<ResourceReference> data = new ArrayList<ResourceReference>();

    public Id getId() { 
      return this.id;
    }

    public void setId(Id value) { 
      this.id = value;
    }

    public String getIdSimple() { 
      return this.id == null ? null : this.id.getValue();
    }

    public void setIdSimple(String value) { 
      if (value == null)
        this.id = null;
      else {
        if (this.id == null)
          this.id = new Id();
        this.id.setValue(value);
      }
    }

    public Instant getInstant() { 
      return this.instant;
    }

    public void setInstant(Instant value) { 
      this.instant = value;
    }

    public Calendar getInstantSimple() { 
      return this.instant == null ? null : this.instant.getValue();
    }

    public void setInstantSimple(Calendar value) { 
      if (value == null)
        this.instant = null;
      else {
        if (this.instant == null)
          this.instant = new Instant();
        this.instant.setValue(value);
      }
    }

    public Code getEvent() { 
      return this.event;
    }

    public void setEvent(Code value) { 
      this.event = value;
    }

    public String getEventSimple() { 
      return this.event == null ? null : this.event.getValue();
    }

    public void setEventSimple(String value) { 
      if (value == null)
        this.event = null;
      else {
        if (this.event == null)
          this.event = new Code();
        this.event.setValue(value);
      }
    }

    public Response getResponse() { 
      return this.response;
    }

    public void setResponse(Response value) { 
      this.response = value;
    }

    public Source getSource() { 
      return this.source;
    }

    public void setSource(Source value) { 
      this.source = value;
    }

    public Destination getDestination() { 
      return this.destination;
    }

    public void setDestination(Destination value) { 
      this.destination = value;
    }

    public ResourceReference getEnterer() { 
      return this.enterer;
    }

    public void setEnterer(ResourceReference value) { 
      this.enterer = value;
    }

    public ResourceReference getAuthor() { 
      return this.author;
    }

    public void setAuthor(ResourceReference value) { 
      this.author = value;
    }

    public ResourceReference getReceiver() { 
      return this.receiver;
    }

    public void setReceiver(ResourceReference value) { 
      this.receiver = value;
    }

    public ResourceReference getResponsible() { 
      return this.responsible;
    }

    public void setResponsible(ResourceReference value) { 
      this.responsible = value;
    }

    public Period getEffective() { 
      return this.effective;
    }

    public void setEffective(Period value) { 
      this.effective = value;
    }

    public CodeableConcept getReason() { 
      return this.reason;
    }

    public void setReason(CodeableConcept value) { 
      this.reason = value;
    }

    public List<ResourceReference> getData() { 
      return this.data;
    }

  @Override
  public ResourceType getResourceType() {
    return ResourceType.Message;
   }


}

