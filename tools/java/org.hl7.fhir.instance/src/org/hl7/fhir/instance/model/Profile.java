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

// Generated on Thu, Jan 31, 2013 23:34+1100 for FHIR v0.07

import java.util.*;

import java.net.*;
/**
 * A Resource Profile - a statement of use of FHIR.  It may include constraints on Resources, Data Types, Terminology Binding Statements and Extension Definitions
 */
public class Profile extends Resource {

    public enum ResourceProfileStatus {
        draft, // This profile is still under development
        testing, // This profile was authored for testing purposes (or education/evaluation/marketing)
        review, // This profile is undergoing review to check that it is ready for production use
        production, // This profile is ready for use in production systems
        withdrawn, // This profile has been withdrawn and should no longer be used
        superseded, // This profile has been superseded by a more recent version
        Null; // added to help the parsers
        public static ResourceProfileStatus fromCode(String codeString) throws Exception {
            if (codeString == null || "".equals(codeString))
                return null;
        if ("draft".equals(codeString))
          return draft;
        if ("testing".equals(codeString))
          return testing;
        if ("review".equals(codeString))
          return review;
        if ("production".equals(codeString))
          return production;
        if ("withdrawn".equals(codeString))
          return withdrawn;
        if ("superseded".equals(codeString))
          return superseded;
        throw new Exception("Unknown ResourceProfileStatus code '"+codeString+"'");
        }
        public String toCode() {
          switch (this) {
            case draft: return "draft";
            case testing: return "testing";
            case review: return "review";
            case production: return "production";
            case withdrawn: return "withdrawn";
            case superseded: return "superseded";
            default: return "?";
          }
        }
    }

  public class ResourceProfileStatusEnumFactory implements EnumFactory {
    public Enum<?> fromCode(String codeString) throws Exception {
      if (codeString == null || "".equals(codeString))
            if (codeString == null || "".equals(codeString))
                return null;
        if ("draft".equals(codeString))
          return ResourceProfileStatus.draft;
        if ("testing".equals(codeString))
          return ResourceProfileStatus.testing;
        if ("review".equals(codeString))
          return ResourceProfileStatus.review;
        if ("production".equals(codeString))
          return ResourceProfileStatus.production;
        if ("withdrawn".equals(codeString))
          return ResourceProfileStatus.withdrawn;
        if ("superseded".equals(codeString))
          return ResourceProfileStatus.superseded;
        throw new Exception("Unknown ResourceProfileStatus code '"+codeString+"'");
        }
    public String toCode(Enum<?> code) throws Exception {
      if (code == ResourceProfileStatus.draft)
        return "draft";
      if (code == ResourceProfileStatus.testing)
        return "testing";
      if (code == ResourceProfileStatus.review)
        return "review";
      if (code == ResourceProfileStatus.production)
        return "production";
      if (code == ResourceProfileStatus.withdrawn)
        return "withdrawn";
      if (code == ResourceProfileStatus.superseded)
        return "superseded";
      return "?";
      }
    }

    public enum ConstraintSeverity {
        error, // If the constraint is violated, the resource is not conformant
        warning, // If the constraint is violated, the resource is conformant, but it is not necessarily following best practice.
        Null; // added to help the parsers
        public static ConstraintSeverity fromCode(String codeString) throws Exception {
            if (codeString == null || "".equals(codeString))
                return null;
        if ("error".equals(codeString))
          return error;
        if ("warning".equals(codeString))
          return warning;
        throw new Exception("Unknown ConstraintSeverity code '"+codeString+"'");
        }
        public String toCode() {
          switch (this) {
            case error: return "error";
            case warning: return "warning";
            default: return "?";
          }
        }
    }

  public class ConstraintSeverityEnumFactory implements EnumFactory {
    public Enum<?> fromCode(String codeString) throws Exception {
      if (codeString == null || "".equals(codeString))
            if (codeString == null || "".equals(codeString))
                return null;
        if ("error".equals(codeString))
          return ConstraintSeverity.error;
        if ("warning".equals(codeString))
          return ConstraintSeverity.warning;
        throw new Exception("Unknown ConstraintSeverity code '"+codeString+"'");
        }
    public String toCode(Enum<?> code) throws Exception {
      if (code == ConstraintSeverity.error)
        return "error";
      if (code == ConstraintSeverity.warning)
        return "warning";
      return "?";
      }
    }

    public enum SearchParamType {
        integer, // Search parameter must be a simple whole number
        string, // Search parameter is a simple string, like a name part (search usually functions on partial matches)
        text, // Search parameter is on a long string (i.e. a text filter type search)
        date, // Search parameter is on a date (and should support -before and -after variants). The date format is the standard XML format, though other formats may be supported
        token, // Search parameter is on a fixed value string (i.e. search has an exact match)
        qtoken, // Search parameter is a pair of fixed value strings, namespace and value, separated by a "#". The namespace is usually a uri, such as one of the defined code systems and is optional when searching
        Null; // added to help the parsers
        public static SearchParamType fromCode(String codeString) throws Exception {
            if (codeString == null || "".equals(codeString))
                return null;
        if ("integer".equals(codeString))
          return integer;
        if ("string".equals(codeString))
          return string;
        if ("text".equals(codeString))
          return text;
        if ("date".equals(codeString))
          return date;
        if ("token".equals(codeString))
          return token;
        if ("qtoken".equals(codeString))
          return qtoken;
        throw new Exception("Unknown SearchParamType code '"+codeString+"'");
        }
        public String toCode() {
          switch (this) {
            case integer: return "integer";
            case string: return "string";
            case text: return "text";
            case date: return "date";
            case token: return "token";
            case qtoken: return "qtoken";
            default: return "?";
          }
        }
    }

  public class SearchParamTypeEnumFactory implements EnumFactory {
    public Enum<?> fromCode(String codeString) throws Exception {
      if (codeString == null || "".equals(codeString))
            if (codeString == null || "".equals(codeString))
                return null;
        if ("integer".equals(codeString))
          return SearchParamType.integer;
        if ("string".equals(codeString))
          return SearchParamType.string;
        if ("text".equals(codeString))
          return SearchParamType.text;
        if ("date".equals(codeString))
          return SearchParamType.date;
        if ("token".equals(codeString))
          return SearchParamType.token;
        if ("qtoken".equals(codeString))
          return SearchParamType.qtoken;
        throw new Exception("Unknown SearchParamType code '"+codeString+"'");
        }
    public String toCode(Enum<?> code) throws Exception {
      if (code == SearchParamType.integer)
        return "integer";
      if (code == SearchParamType.string)
        return "string";
      if (code == SearchParamType.text)
        return "text";
      if (code == SearchParamType.date)
        return "date";
      if (code == SearchParamType.token)
        return "token";
      if (code == SearchParamType.qtoken)
        return "qtoken";
      return "?";
      }
    }

    public enum SearchRepeatBehavior {
        single, // The search parameter may only occur once
        union, // When the search parameter occurs more than once, match resources with any of the values
        intersection, // When the search parameter occurs more than once, match resources with all of the values
        Null; // added to help the parsers
        public static SearchRepeatBehavior fromCode(String codeString) throws Exception {
            if (codeString == null || "".equals(codeString))
                return null;
        if ("single".equals(codeString))
          return single;
        if ("union".equals(codeString))
          return union;
        if ("intersection".equals(codeString))
          return intersection;
        throw new Exception("Unknown SearchRepeatBehavior code '"+codeString+"'");
        }
        public String toCode() {
          switch (this) {
            case single: return "single";
            case union: return "union";
            case intersection: return "intersection";
            default: return "?";
          }
        }
    }

  public class SearchRepeatBehaviorEnumFactory implements EnumFactory {
    public Enum<?> fromCode(String codeString) throws Exception {
      if (codeString == null || "".equals(codeString))
            if (codeString == null || "".equals(codeString))
                return null;
        if ("single".equals(codeString))
          return SearchRepeatBehavior.single;
        if ("union".equals(codeString))
          return SearchRepeatBehavior.union;
        if ("intersection".equals(codeString))
          return SearchRepeatBehavior.intersection;
        throw new Exception("Unknown SearchRepeatBehavior code '"+codeString+"'");
        }
    public String toCode(Enum<?> code) throws Exception {
      if (code == SearchRepeatBehavior.single)
        return "single";
      if (code == SearchRepeatBehavior.union)
        return "union";
      if (code == SearchRepeatBehavior.intersection)
        return "intersection";
      return "?";
      }
    }

    public enum ExtensionContext {
        resource, // The context is all elements matching a particular resource element path
        datatype, // The context is all nodes matching a particular data type element path (root or repeating element) or all elements referencing a particular primitive data type (expressed as the datatype name)
        mapping, // The context is all nodes whose mapping to a specified reference model corresponds to a particular mapping structure.  The context identifies the mapping target. The mapping should clearly identify where such an extension could be used, though this 
        extension, // The context is a particular extension from a particular profile.  Expressed as uri#name, where uri identifies the profile and #name identifies the extension code
        Null; // added to help the parsers
        public static ExtensionContext fromCode(String codeString) throws Exception {
            if (codeString == null || "".equals(codeString))
                return null;
        if ("resource".equals(codeString))
          return resource;
        if ("datatype".equals(codeString))
          return datatype;
        if ("mapping".equals(codeString))
          return mapping;
        if ("extension".equals(codeString))
          return extension;
        throw new Exception("Unknown ExtensionContext code '"+codeString+"'");
        }
        public String toCode() {
          switch (this) {
            case resource: return "resource";
            case datatype: return "datatype";
            case mapping: return "mapping";
            case extension: return "extension";
            default: return "?";
          }
        }
    }

  public class ExtensionContextEnumFactory implements EnumFactory {
    public Enum<?> fromCode(String codeString) throws Exception {
      if (codeString == null || "".equals(codeString))
            if (codeString == null || "".equals(codeString))
                return null;
        if ("resource".equals(codeString))
          return ExtensionContext.resource;
        if ("datatype".equals(codeString))
          return ExtensionContext.datatype;
        if ("mapping".equals(codeString))
          return ExtensionContext.mapping;
        if ("extension".equals(codeString))
          return ExtensionContext.extension;
        throw new Exception("Unknown ExtensionContext code '"+codeString+"'");
        }
    public String toCode(Enum<?> code) throws Exception {
      if (code == ExtensionContext.resource)
        return "resource";
      if (code == ExtensionContext.datatype)
        return "datatype";
      if (code == ExtensionContext.mapping)
        return "mapping";
      if (code == ExtensionContext.extension)
        return "extension";
      return "?";
      }
    }

    public enum BindingType {
        valueset, // The binding name has an associated URL which is a reference to a Value Set Resource that provides a formal definition of the set of possible codes
        codelist, // The binding name is associated with a simple list of codes, and definitions from some identified code system (SID, URI, OID, UUID). In resource definitions, the system reference may be omitted, and a list of custom codes with definitions supplied (this is for status and workflow fields that applications need to know)
        reference, // The binding name has an associated URL which refers to some external standard or specification that defines the possible codes
        special, // The binding points to a list of concepts defined as part of FHIR itself (see below for possible values)
        Null; // added to help the parsers
        public static BindingType fromCode(String codeString) throws Exception {
            if (codeString == null || "".equals(codeString))
                return null;
        if ("valueset".equals(codeString))
          return valueset;
        if ("codelist".equals(codeString))
          return codelist;
        if ("reference".equals(codeString))
          return reference;
        if ("special".equals(codeString))
          return special;
        throw new Exception("Unknown BindingType code '"+codeString+"'");
        }
        public String toCode() {
          switch (this) {
            case valueset: return "valueset";
            case codelist: return "codelist";
            case reference: return "reference";
            case special: return "special";
            default: return "?";
          }
        }
    }

  public class BindingTypeEnumFactory implements EnumFactory {
    public Enum<?> fromCode(String codeString) throws Exception {
      if (codeString == null || "".equals(codeString))
            if (codeString == null || "".equals(codeString))
                return null;
        if ("valueset".equals(codeString))
          return BindingType.valueset;
        if ("codelist".equals(codeString))
          return BindingType.codelist;
        if ("reference".equals(codeString))
          return BindingType.reference;
        if ("special".equals(codeString))
          return BindingType.special;
        throw new Exception("Unknown BindingType code '"+codeString+"'");
        }
    public String toCode(Enum<?> code) throws Exception {
      if (code == BindingType.valueset)
        return "valueset";
      if (code == BindingType.codelist)
        return "codelist";
      if (code == BindingType.reference)
        return "reference";
      if (code == BindingType.special)
        return "special";
      return "?";
      }
    }

    public enum BindingConformance {
        required, // Only codes in the specified set are allowed.  If the binding is extensible, other codes may be used for concepts not covered by the bound set of codes
        preferred, // For greater interoperability, implementers are strongly encouraged to use the bound set of codes, however alternate codes may be used in derived profiles and implementations if necessary without being considered non-conformant
        example, // The codes in the set are an example to illustrate the meaning of the field. There is no particular preference for its use nor any assertion that the provided values are sufficient to meet implementation needs
        Null; // added to help the parsers
        public static BindingConformance fromCode(String codeString) throws Exception {
            if (codeString == null || "".equals(codeString))
                return null;
        if ("required".equals(codeString))
          return required;
        if ("preferred".equals(codeString))
          return preferred;
        if ("example".equals(codeString))
          return example;
        throw new Exception("Unknown BindingConformance code '"+codeString+"'");
        }
        public String toCode() {
          switch (this) {
            case required: return "required";
            case preferred: return "preferred";
            case example: return "example";
            default: return "?";
          }
        }
    }

  public class BindingConformanceEnumFactory implements EnumFactory {
    public Enum<?> fromCode(String codeString) throws Exception {
      if (codeString == null || "".equals(codeString))
            if (codeString == null || "".equals(codeString))
                return null;
        if ("required".equals(codeString))
          return BindingConformance.required;
        if ("preferred".equals(codeString))
          return BindingConformance.preferred;
        if ("example".equals(codeString))
          return BindingConformance.example;
        throw new Exception("Unknown BindingConformance code '"+codeString+"'");
        }
    public String toCode(Enum<?> code) throws Exception {
      if (code == BindingConformance.required)
        return "required";
      if (code == BindingConformance.preferred)
        return "preferred";
      if (code == BindingConformance.example)
        return "example";
      return "?";
      }
    }

    public class Author extends Element {
        /**
         * The name of the individual or organization with primary responsibility for the content of the profile
         */
        private String_ name;

        /**
         * Contacts of the author to assist a user in finding and communicating with the author
         */
        private List<Contact> telecom = new ArrayList<Contact>();

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

        public List<Contact> getTelecom() { 
          return this.telecom;
        }

  }

    public class Status extends Element {
        /**
         * A coded value for the position of the profile within its life-cycle
         */
        private Enumeration<ResourceProfileStatus> code;

        /**
         * The date that the current value for status was applied to the profile
         */
        private DateTime date;

        /**
         * Additional commentary related to the profile's status
         */
        private String_ comment;

        public Enumeration<ResourceProfileStatus> getCode() { 
          return this.code;
        }

        public void setCode(Enumeration<ResourceProfileStatus> value) { 
          this.code = value;
        }

        public ResourceProfileStatus getCodeSimple() { 
          return this.code == null ? null : this.code.getValue();
        }

        public void setCodeSimple(ResourceProfileStatus value) { 
          if (value == null)
            this.code = null;
          else {
            if (this.code == null)
              this.code = new Enumeration<ResourceProfileStatus>();
            this.code.setValue(value);
          }
        }

        public DateTime getDate() { 
          return this.date;
        }

        public void setDate(DateTime value) { 
          this.date = value;
        }

        public String getDateSimple() { 
          return this.date == null ? null : this.date.getValue();
        }

        public void setDateSimple(String value) { 
          if (value == null)
            this.date = null;
          else {
            if (this.date == null)
              this.date = new DateTime();
            this.date.setValue(value);
          }
        }

        public String_ getComment() { 
          return this.comment;
        }

        public void setComment(String_ value) { 
          this.comment = value;
        }

        public String getCommentSimple() { 
          return this.comment == null ? null : this.comment.getValue();
        }

        public void setCommentSimple(String value) { 
          if (value == null)
            this.comment = null;
          else {
            if (this.comment == null)
              this.comment = new String_();
            this.comment.setValue(value);
          }
        }

  }

    public class Import extends Element {
        /**
         * The identifier for the profile, ideally the URL it can be retrieved from
         */
        private Uri uri;

        /**
         * The short label used for display of the profile when uniquely identifying imported extensions
         */
        private String_ prefix;

        public Uri getUri() { 
          return this.uri;
        }

        public void setUri(Uri value) { 
          this.uri = value;
        }

        public URI getUriSimple() { 
          return this.uri == null ? null : this.uri.getValue();
        }

        public void setUriSimple(URI value) { 
          if (value == null)
            this.uri = null;
          else {
            if (this.uri == null)
              this.uri = new Uri();
            this.uri.setValue(value);
          }
        }

        public String_ getPrefix() { 
          return this.prefix;
        }

        public void setPrefix(String_ value) { 
          this.prefix = value;
        }

        public String getPrefixSimple() { 
          return this.prefix == null ? null : this.prefix.getValue();
        }

        public void setPrefixSimple(String value) { 
          if (value == null)
            this.prefix = null;
          else {
            if (this.prefix == null)
              this.prefix = new String_();
            this.prefix.setValue(value);
          }
        }

  }

    public class Resource extends Element {
        /**
         * The Resource or Data type being described
         */
        private Code type;

        /**
         * Reference to a resource profile that includes the constraint statement that applies to this resource
         */
        private Uri profile;

        /**
         * The name of this resource constraint statement (to refer to it from other resource constraints)
         */
        private String_ name;

        /**
         * Human summary: why describe this resource?
         */
        private String_ purpose;

        /**
         * Captures constraints on each element within the resource
         */
        private List<Element_> element = new ArrayList<Element_>();

        /**
         * Defines additional search parameters for implementations to support and/or make use of
         */
        private List<SearchParam> searchParam = new ArrayList<SearchParam>();

        public Code getType() { 
          return this.type;
        }

        public void setType(Code value) { 
          this.type = value;
        }

        public String getTypeSimple() { 
          return this.type == null ? null : this.type.getValue();
        }

        public void setTypeSimple(String value) { 
          if (value == null)
            this.type = null;
          else {
            if (this.type == null)
              this.type = new Code();
            this.type.setValue(value);
          }
        }

        public Uri getProfile() { 
          return this.profile;
        }

        public void setProfile(Uri value) { 
          this.profile = value;
        }

        public URI getProfileSimple() { 
          return this.profile == null ? null : this.profile.getValue();
        }

        public void setProfileSimple(URI value) { 
          if (value == null)
            this.profile = null;
          else {
            if (this.profile == null)
              this.profile = new Uri();
            this.profile.setValue(value);
          }
        }

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

        public String_ getPurpose() { 
          return this.purpose;
        }

        public void setPurpose(String_ value) { 
          this.purpose = value;
        }

        public String getPurposeSimple() { 
          return this.purpose == null ? null : this.purpose.getValue();
        }

        public void setPurposeSimple(String value) { 
          if (value == null)
            this.purpose = null;
          else {
            if (this.purpose == null)
              this.purpose = new String_();
            this.purpose.setValue(value);
          }
        }

        public List<Element_> getElement() { 
          return this.element;
        }

        public List<SearchParam> getSearchParam() { 
          return this.searchParam;
        }

  }

    public class Element_ extends Element {
        /**
         * The path identifies the element and is expressed as a "."-separated list of ancestor elements, beginning with the name of the resource
         */
        private String_ path;

        /**
         * A unique name referring to a specific set of constraints applied to this element
         */
        private String_ name;

        /**
         * Definition of the content of the element to provide a more specific definition than that contained for the element in the base resource
         */
        private Definition definition;

        /**
         * Whether the Resource that is the value for this element is included in the bundle, if the profile is specifying a bundle
         */
        private Boolean bundled;

        /**
         * Indicates whether the set of slices defined is "exhaustive".  I.e. Have all the possible variants for the repeating element been defined?  If true, then no new slices can be created off the base element in derived profiles - though existing slices can be further sliced if they are defined as repeating elements
         */
        private Boolean closed;

        public String_ getPath() { 
          return this.path;
        }

        public void setPath(String_ value) { 
          this.path = value;
        }

        public String getPathSimple() { 
          return this.path == null ? null : this.path.getValue();
        }

        public void setPathSimple(String value) { 
          if (value == null)
            this.path = null;
          else {
            if (this.path == null)
              this.path = new String_();
            this.path.setValue(value);
          }
        }

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

        public Definition getDefinition() { 
          return this.definition;
        }

        public void setDefinition(Definition value) { 
          this.definition = value;
        }

        public Boolean getBundled() { 
          return this.bundled;
        }

        public void setBundled(Boolean value) { 
          this.bundled = value;
        }

        public boolean getBundledSimple() { 
          return this.bundled == null ? null : this.bundled.getValue();
        }

        public void setBundledSimple(boolean value) { 
          if (value == false)
            this.bundled = null;
          else {
            if (this.bundled == null)
              this.bundled = new Boolean();
            this.bundled.setValue(value);
          }
        }

        public Boolean getClosed() { 
          return this.closed;
        }

        public void setClosed(Boolean value) { 
          this.closed = value;
        }

        public boolean getClosedSimple() { 
          return this.closed == null ? null : this.closed.getValue();
        }

        public void setClosedSimple(boolean value) { 
          if (value == false)
            this.closed = null;
          else {
            if (this.closed == null)
              this.closed = new Boolean();
            this.closed.setValue(value);
          }
        }

  }

    public class Definition extends Element {
        /**
         * A concise definition that  is shown in the concise XML format that summarizes profiles
         */
        private String_ short_;

        /**
         *  The definition must be consistent with the base definition, but convey the meaning of the element in the particular context of use of the resource
         */
        private String_ formal;

        /**
         * Comments about the use of the element, including notes about how to use the data properly, exceptions to proper use, etc.
         */
        private String_ comments;

        /**
         * Explains why this element is needed and why it's been constrained as it has
         */
        private String_ requirements;

        /**
         * Identifies additional names by which this element might also be known
         */
        private List<String_> synonym = new ArrayList<String_>();

        /**
         * The minimum number of times this element must appear in the instance
         */
        private Integer min;

        /**
         * The maximum number of times this element is permitted to appear in the instance
         */
        private String_ max;

        /**
         * The data type or resource that the value of this element is permitted to be
         */
        private List<Type> type = new ArrayList<Type>();

        /**
         * Identifies the name of a slice defined elsewhere in the profile whose constraints should be applied to the current element 
         */
        private String_ nameReference;

        /**
         * Specifies a value that must hold for this element in the instance
         */
        private org.hl7.fhir.instance.model.Type value;

        /**
         * Indicates the shortest length that must be supported by conformant instances without truncation
         */
        private Integer maxLength;

        /**
         * A reference to an invariant that may make additional statements about the cardinality in the instance
         */
        private List<Id> condition = new ArrayList<Id>();

        /**
         * Formal constraints such as co-occurrence and other constraints that can be computationally evaluated within the context of the instance
         */
        private List<Constraint> constraint = new ArrayList<Constraint>();

        /**
         * If true, conformant resource authors must be capable of providing a value for the element and resource consumers must be capable of extracting and doing something useful with the data element.  If false, the element may be ignored and not supported
         */
        private Boolean mustSupport;

        /**
         * If true, the element cannot be ignored by systems unless they recognize the element and a pre-determination has been made that it is not relevant to their particular system
         */
        private Boolean mustUnderstand;

        /**
         * Identifies the set of codes that applies to this element if a data type supporting codes is used
         */
        private String_ binding;

        /**
         * Identifies a concept from an external specification that roughly corresponds to this element
         */
        private List<Mapping> mapping = new ArrayList<Mapping>();

        public String_ getShort() { 
          return this.short_;
        }

        public void setShort(String_ value) { 
          this.short_ = value;
        }

        public String getShortSimple() { 
          return this.short_ == null ? null : this.short_.getValue();
        }

        public void setShortSimple(String value) { 
          if (value == null)
            this.short_ = null;
          else {
            if (this.short_ == null)
              this.short_ = new String_();
            this.short_.setValue(value);
          }
        }

        public String_ getFormal() { 
          return this.formal;
        }

        public void setFormal(String_ value) { 
          this.formal = value;
        }

        public String getFormalSimple() { 
          return this.formal == null ? null : this.formal.getValue();
        }

        public void setFormalSimple(String value) { 
          if (value == null)
            this.formal = null;
          else {
            if (this.formal == null)
              this.formal = new String_();
            this.formal.setValue(value);
          }
        }

        public String_ getComments() { 
          return this.comments;
        }

        public void setComments(String_ value) { 
          this.comments = value;
        }

        public String getCommentsSimple() { 
          return this.comments == null ? null : this.comments.getValue();
        }

        public void setCommentsSimple(String value) { 
          if (value == null)
            this.comments = null;
          else {
            if (this.comments == null)
              this.comments = new String_();
            this.comments.setValue(value);
          }
        }

        public String_ getRequirements() { 
          return this.requirements;
        }

        public void setRequirements(String_ value) { 
          this.requirements = value;
        }

        public String getRequirementsSimple() { 
          return this.requirements == null ? null : this.requirements.getValue();
        }

        public void setRequirementsSimple(String value) { 
          if (value == null)
            this.requirements = null;
          else {
            if (this.requirements == null)
              this.requirements = new String_();
            this.requirements.setValue(value);
          }
        }

        public List<String_> getSynonym() { 
          return this.synonym;
        }

        public Integer getMin() { 
          return this.min;
        }

        public void setMin(Integer value) { 
          this.min = value;
        }

        public int getMinSimple() { 
          return this.min == null ? null : this.min.getValue();
        }

        public void setMinSimple(int value) { 
          if (value == -1)
            this.min = null;
          else {
            if (this.min == null)
              this.min = new Integer();
            this.min.setValue(value);
          }
        }

        public String_ getMax() { 
          return this.max;
        }

        public void setMax(String_ value) { 
          this.max = value;
        }

        public String getMaxSimple() { 
          return this.max == null ? null : this.max.getValue();
        }

        public void setMaxSimple(String value) { 
          if (value == null)
            this.max = null;
          else {
            if (this.max == null)
              this.max = new String_();
            this.max.setValue(value);
          }
        }

        public List<Type> getType() { 
          return this.type;
        }

        public String_ getNameReference() { 
          return this.nameReference;
        }

        public void setNameReference(String_ value) { 
          this.nameReference = value;
        }

        public String getNameReferenceSimple() { 
          return this.nameReference == null ? null : this.nameReference.getValue();
        }

        public void setNameReferenceSimple(String value) { 
          if (value == null)
            this.nameReference = null;
          else {
            if (this.nameReference == null)
              this.nameReference = new String_();
            this.nameReference.setValue(value);
          }
        }

        public org.hl7.fhir.instance.model.Type getValue() { 
          return this.value;
        }

        public void setValue(org.hl7.fhir.instance.model.Type value) { 
          this.value = value;
        }

        public Integer getMaxLength() { 
          return this.maxLength;
        }

        public void setMaxLength(Integer value) { 
          this.maxLength = value;
        }

        public int getMaxLengthSimple() { 
          return this.maxLength == null ? null : this.maxLength.getValue();
        }

        public void setMaxLengthSimple(int value) { 
          if (value == -1)
            this.maxLength = null;
          else {
            if (this.maxLength == null)
              this.maxLength = new Integer();
            this.maxLength.setValue(value);
          }
        }

        public List<Id> getCondition() { 
          return this.condition;
        }

        public List<Constraint> getConstraint() { 
          return this.constraint;
        }

        public Boolean getMustSupport() { 
          return this.mustSupport;
        }

        public void setMustSupport(Boolean value) { 
          this.mustSupport = value;
        }

        public boolean getMustSupportSimple() { 
          return this.mustSupport == null ? null : this.mustSupport.getValue();
        }

        public void setMustSupportSimple(boolean value) { 
          if (value == false)
            this.mustSupport = null;
          else {
            if (this.mustSupport == null)
              this.mustSupport = new Boolean();
            this.mustSupport.setValue(value);
          }
        }

        public Boolean getMustUnderstand() { 
          return this.mustUnderstand;
        }

        public void setMustUnderstand(Boolean value) { 
          this.mustUnderstand = value;
        }

        public boolean getMustUnderstandSimple() { 
          return this.mustUnderstand == null ? null : this.mustUnderstand.getValue();
        }

        public void setMustUnderstandSimple(boolean value) { 
          if (value == false)
            this.mustUnderstand = null;
          else {
            if (this.mustUnderstand == null)
              this.mustUnderstand = new Boolean();
            this.mustUnderstand.setValue(value);
          }
        }

        public String_ getBinding() { 
          return this.binding;
        }

        public void setBinding(String_ value) { 
          this.binding = value;
        }

        public String getBindingSimple() { 
          return this.binding == null ? null : this.binding.getValue();
        }

        public void setBindingSimple(String value) { 
          if (value == null)
            this.binding = null;
          else {
            if (this.binding == null)
              this.binding = new String_();
            this.binding.setValue(value);
          }
        }

        public List<Mapping> getMapping() { 
          return this.mapping;
        }

  }

    public class Type extends Element {
        /**
         * Data type or Resource
         */
        private Code code;

        /**
         * Identifies a profile that must hold for resources or datatypes referenced as the type of this element
         */
        private Uri profile;

        public Code getCode() { 
          return this.code;
        }

        public void setCode(Code value) { 
          this.code = value;
        }

        public String getCodeSimple() { 
          return this.code == null ? null : this.code.getValue();
        }

        public void setCodeSimple(String value) { 
          if (value == null)
            this.code = null;
          else {
            if (this.code == null)
              this.code = new Code();
            this.code.setValue(value);
          }
        }

        public Uri getProfile() { 
          return this.profile;
        }

        public void setProfile(Uri value) { 
          this.profile = value;
        }

        public URI getProfileSimple() { 
          return this.profile == null ? null : this.profile.getValue();
        }

        public void setProfileSimple(URI value) { 
          if (value == null)
            this.profile = null;
          else {
            if (this.profile == null)
              this.profile = new Uri();
            this.profile.setValue(value);
          }
        }

  }

    public class Constraint extends Element {
        /**
         * Allows identification of which elements have their cardinalities impacted by the constraint.  Will not be referenced for constraints that do not affect cardinality
         */
        private Id id;

        /**
         * Used to label the constraint in OCL or in short displays incapable of displaying the full human description
         */
        private String_ name;

        /**
         * Identifies the impact constraint violation has on the conformance of the instance
         */
        private Enumeration<ConstraintSeverity> severity;

        /**
         * This is the text that describes the constraint in messages identifying that the constraint has been violated 
         */
        private String_ human;

        /**
         * XPath expression of constraint
         */
        private String_ xpath;

        /**
         * OCL expression of constraint
         */
        private String_ ocl;

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

        public Enumeration<ConstraintSeverity> getSeverity() { 
          return this.severity;
        }

        public void setSeverity(Enumeration<ConstraintSeverity> value) { 
          this.severity = value;
        }

        public ConstraintSeverity getSeveritySimple() { 
          return this.severity == null ? null : this.severity.getValue();
        }

        public void setSeveritySimple(ConstraintSeverity value) { 
          if (value == null)
            this.severity = null;
          else {
            if (this.severity == null)
              this.severity = new Enumeration<ConstraintSeverity>();
            this.severity.setValue(value);
          }
        }

        public String_ getHuman() { 
          return this.human;
        }

        public void setHuman(String_ value) { 
          this.human = value;
        }

        public String getHumanSimple() { 
          return this.human == null ? null : this.human.getValue();
        }

        public void setHumanSimple(String value) { 
          if (value == null)
            this.human = null;
          else {
            if (this.human == null)
              this.human = new String_();
            this.human.setValue(value);
          }
        }

        public String_ getXpath() { 
          return this.xpath;
        }

        public void setXpath(String_ value) { 
          this.xpath = value;
        }

        public String getXpathSimple() { 
          return this.xpath == null ? null : this.xpath.getValue();
        }

        public void setXpathSimple(String value) { 
          if (value == null)
            this.xpath = null;
          else {
            if (this.xpath == null)
              this.xpath = new String_();
            this.xpath.setValue(value);
          }
        }

        public String_ getOcl() { 
          return this.ocl;
        }

        public void setOcl(String_ value) { 
          this.ocl = value;
        }

        public String getOclSimple() { 
          return this.ocl == null ? null : this.ocl.getValue();
        }

        public void setOclSimple(String value) { 
          if (value == null)
            this.ocl = null;
          else {
            if (this.ocl == null)
              this.ocl = new String_();
            this.ocl.setValue(value);
          }
        }

  }

    public class Mapping extends Element {
        /**
         * The name of the specification is mapping is being expressed to
         */
        private String_ target;

        /**
         * Expresses what part of the target specification corresponds to this element
         */
        private String_ map;

        public String_ getTarget() { 
          return this.target;
        }

        public void setTarget(String_ value) { 
          this.target = value;
        }

        public String getTargetSimple() { 
          return this.target == null ? null : this.target.getValue();
        }

        public void setTargetSimple(String value) { 
          if (value == null)
            this.target = null;
          else {
            if (this.target == null)
              this.target = new String_();
            this.target.setValue(value);
          }
        }

        public String_ getMap() { 
          return this.map;
        }

        public void setMap(String_ value) { 
          this.map = value;
        }

        public String getMapSimple() { 
          return this.map == null ? null : this.map.getValue();
        }

        public void setMapSimple(String value) { 
          if (value == null)
            this.map = null;
          else {
            if (this.map == null)
              this.map = new String_();
            this.map.setValue(value);
          }
        }

  }

    public class SearchParam extends Element {
        /**
         * Corresponds to the name of the standard or custom search parameter
         */
        private String_ name;

        /**
         * The type of value a search parameter refers to, and how the content is interpreted
         */
        private Enumeration<SearchParamType> type;

        /**
         * Whether multiple uses of the parameter are allowed in searches, and if they are, how the multiple values are understood
         */
        private Enumeration<SearchRepeatBehavior> repeats;

        /**
         * For standard parameters, provides additional information on how the parameter is used in this solution.  For custom parameters, provides a description of what the parameter does
         */
        private String_ documentation;

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

        public Enumeration<SearchParamType> getType() { 
          return this.type;
        }

        public void setType(Enumeration<SearchParamType> value) { 
          this.type = value;
        }

        public SearchParamType getTypeSimple() { 
          return this.type == null ? null : this.type.getValue();
        }

        public void setTypeSimple(SearchParamType value) { 
          if (value == null)
            this.type = null;
          else {
            if (this.type == null)
              this.type = new Enumeration<SearchParamType>();
            this.type.setValue(value);
          }
        }

        public Enumeration<SearchRepeatBehavior> getRepeats() { 
          return this.repeats;
        }

        public void setRepeats(Enumeration<SearchRepeatBehavior> value) { 
          this.repeats = value;
        }

        public SearchRepeatBehavior getRepeatsSimple() { 
          return this.repeats == null ? null : this.repeats.getValue();
        }

        public void setRepeatsSimple(SearchRepeatBehavior value) { 
          if (value == null)
            this.repeats = null;
          else {
            if (this.repeats == null)
              this.repeats = new Enumeration<SearchRepeatBehavior>();
            this.repeats.setValue(value);
          }
        }

        public String_ getDocumentation() { 
          return this.documentation;
        }

        public void setDocumentation(String_ value) { 
          this.documentation = value;
        }

        public String getDocumentationSimple() { 
          return this.documentation == null ? null : this.documentation.getValue();
        }

        public void setDocumentationSimple(String value) { 
          if (value == null)
            this.documentation = null;
          else {
            if (this.documentation == null)
              this.documentation = new String_();
            this.documentation.setValue(value);
          }
        }

  }

    public class ExtensionDefn extends Element {
        /**
         * A unique code (within the profile) used to identify the extension
         */
        private Id id;

        /**
         * Identifies the type of context to which the extension applies
         */
        private Enumeration<ExtensionContext> contextType;

        /**
         * Identifies the types of resource or data type elements to which the extension can be applied
         */
        private List<String_> context = new ArrayList<String_>();

        /**
         * Definition of the extension and its content
         */
        private Definition definition;

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

        public Enumeration<ExtensionContext> getContextType() { 
          return this.contextType;
        }

        public void setContextType(Enumeration<ExtensionContext> value) { 
          this.contextType = value;
        }

        public ExtensionContext getContextTypeSimple() { 
          return this.contextType == null ? null : this.contextType.getValue();
        }

        public void setContextTypeSimple(ExtensionContext value) { 
          if (value == null)
            this.contextType = null;
          else {
            if (this.contextType == null)
              this.contextType = new Enumeration<ExtensionContext>();
            this.contextType.setValue(value);
          }
        }

        public List<String_> getContext() { 
          return this.context;
        }

        public Definition getDefinition() { 
          return this.definition;
        }

        public void setDefinition(Definition value) { 
          this.definition = value;
        }

  }

    public class Binding extends Element {
        /**
         * The name to be associated with this set of codes
         */
        private String_ name;

        /**
         * Describes the intended use of this particular set of codes
         */
        private String_ definition;

        /**
         * Identifies how the set of codes for this binding is being defined
         */
        private Enumeration<BindingType> type;

        /**
         * If true, then conformant systems may use additional codes or (where the data type permits) text alone to convey concepts not covered by the set of codes identified in the binding.  If false, then conformant systems are constrained to the provided codes alone
         */
        private Boolean isExtensible;

        /**
         * Indicates the degree of conformance expectations associated with this binding
         */
        private Enumeration<BindingConformance> conformance;

        /**
         * Points to the value set or external definition that identifies the set of codes to be used
         */
        private Uri reference;

        /**
         * Identifies the codes forming the code list for the binding
         */
        private List<Concept> concept = new ArrayList<Concept>();

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

        public String_ getDefinition() { 
          return this.definition;
        }

        public void setDefinition(String_ value) { 
          this.definition = value;
        }

        public String getDefinitionSimple() { 
          return this.definition == null ? null : this.definition.getValue();
        }

        public void setDefinitionSimple(String value) { 
          if (value == null)
            this.definition = null;
          else {
            if (this.definition == null)
              this.definition = new String_();
            this.definition.setValue(value);
          }
        }

        public Enumeration<BindingType> getType() { 
          return this.type;
        }

        public void setType(Enumeration<BindingType> value) { 
          this.type = value;
        }

        public BindingType getTypeSimple() { 
          return this.type == null ? null : this.type.getValue();
        }

        public void setTypeSimple(BindingType value) { 
          if (value == null)
            this.type = null;
          else {
            if (this.type == null)
              this.type = new Enumeration<BindingType>();
            this.type.setValue(value);
          }
        }

        public Boolean getIsExtensible() { 
          return this.isExtensible;
        }

        public void setIsExtensible(Boolean value) { 
          this.isExtensible = value;
        }

        public boolean getIsExtensibleSimple() { 
          return this.isExtensible == null ? null : this.isExtensible.getValue();
        }

        public void setIsExtensibleSimple(boolean value) { 
          if (value == false)
            this.isExtensible = null;
          else {
            if (this.isExtensible == null)
              this.isExtensible = new Boolean();
            this.isExtensible.setValue(value);
          }
        }

        public Enumeration<BindingConformance> getConformance() { 
          return this.conformance;
        }

        public void setConformance(Enumeration<BindingConformance> value) { 
          this.conformance = value;
        }

        public BindingConformance getConformanceSimple() { 
          return this.conformance == null ? null : this.conformance.getValue();
        }

        public void setConformanceSimple(BindingConformance value) { 
          if (value == null)
            this.conformance = null;
          else {
            if (this.conformance == null)
              this.conformance = new Enumeration<BindingConformance>();
            this.conformance.setValue(value);
          }
        }

        public Uri getReference() { 
          return this.reference;
        }

        public void setReference(Uri value) { 
          this.reference = value;
        }

        public URI getReferenceSimple() { 
          return this.reference == null ? null : this.reference.getValue();
        }

        public void setReferenceSimple(URI value) { 
          if (value == null)
            this.reference = null;
          else {
            if (this.reference == null)
              this.reference = new Uri();
            this.reference.setValue(value);
          }
        }

        public List<Concept> getConcept() { 
          return this.concept;
        }

  }

    public class Concept extends Element {
        /**
         * Identifies the code referenced or being defined as part of the binding
         */
        private String_ code;

        /**
         * Identifies the system in which the referenced code is defined
         */
        private Uri system;

        /**
         * Identifies the text to be displayed to the user for this code.  If none provided, then the code itself is displayed
         */
        private String_ display;

        /**
         * A free-text description of the meaning of this code
         */
        private String_ definition;

        public String_ getCode() { 
          return this.code;
        }

        public void setCode(String_ value) { 
          this.code = value;
        }

        public String getCodeSimple() { 
          return this.code == null ? null : this.code.getValue();
        }

        public void setCodeSimple(String value) { 
          if (value == null)
            this.code = null;
          else {
            if (this.code == null)
              this.code = new String_();
            this.code.setValue(value);
          }
        }

        public Uri getSystem() { 
          return this.system;
        }

        public void setSystem(Uri value) { 
          this.system = value;
        }

        public URI getSystemSimple() { 
          return this.system == null ? null : this.system.getValue();
        }

        public void setSystemSimple(URI value) { 
          if (value == null)
            this.system = null;
          else {
            if (this.system == null)
              this.system = new Uri();
            this.system.setValue(value);
          }
        }

        public String_ getDisplay() { 
          return this.display;
        }

        public void setDisplay(String_ value) { 
          this.display = value;
        }

        public String getDisplaySimple() { 
          return this.display == null ? null : this.display.getValue();
        }

        public void setDisplaySimple(String value) { 
          if (value == null)
            this.display = null;
          else {
            if (this.display == null)
              this.display = new String_();
            this.display.setValue(value);
          }
        }

        public String_ getDefinition() { 
          return this.definition;
        }

        public void setDefinition(String_ value) { 
          this.definition = value;
        }

        public String getDefinitionSimple() { 
          return this.definition == null ? null : this.definition.getValue();
        }

        public void setDefinitionSimple(String value) { 
          if (value == null)
            this.definition = null;
          else {
            if (this.definition == null)
              this.definition = new String_();
            this.definition.setValue(value);
          }
        }

  }

    /**
     * A free text natural language name identifying the Profile
     */
    private String_ name;

    /**
     * The official version of this profile - for external version specific references. This has an arbitrary value managed by the profile author manually
     */
    private String_ version;

    /**
     * Details of the author who accepts responsibility for publishing the profile
     */
    private Author author;

    /**
     * A free text natural language description of the profile and its use
     */
    private String_ description;

    /**
     * A set of terms from external terminologies that may be used to assist with indexing and searching of templates.
     */
    private List<Coding> code = new ArrayList<Coding>();

    /**
     * Indicates where the profile exists in its overall life-cycle
     */
    private Status status;

    /**
     * Other profiles that define extensions and bindings that are used in this profile
     */
    private List<Import> import_ = new ArrayList<Import>();

    /**
     * If this profile describes a bundle, the first resource in the bundle (usually a Message or a Document)
     */
    private Code bundle;

    /**
     * A constraint statement about what contents a resource or data type may have
     */
    private List<Resource> resource = new ArrayList<Resource>();

    /**
     * An extension defined as part of the profile
     */
    private List<ExtensionDefn> extensionDefn = new ArrayList<ExtensionDefn>();

    /**
     * Defines a linkage between a vocabulary binding name used in the profile (or expected to be used in profile importing this one) and a value set or code list
     */
    private List<Binding> binding = new ArrayList<Binding>();

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

    public Author getAuthor() { 
      return this.author;
    }

    public void setAuthor(Author value) { 
      this.author = value;
    }

    public String_ getDescription() { 
      return this.description;
    }

    public void setDescription(String_ value) { 
      this.description = value;
    }

    public String getDescriptionSimple() { 
      return this.description == null ? null : this.description.getValue();
    }

    public void setDescriptionSimple(String value) { 
      if (value == null)
        this.description = null;
      else {
        if (this.description == null)
          this.description = new String_();
        this.description.setValue(value);
      }
    }

    public List<Coding> getCode() { 
      return this.code;
    }

    public Status getStatus() { 
      return this.status;
    }

    public void setStatus(Status value) { 
      this.status = value;
    }

    public List<Import> getImport() { 
      return this.import_;
    }

    public Code getBundle() { 
      return this.bundle;
    }

    public void setBundle(Code value) { 
      this.bundle = value;
    }

    public String getBundleSimple() { 
      return this.bundle == null ? null : this.bundle.getValue();
    }

    public void setBundleSimple(String value) { 
      if (value == null)
        this.bundle = null;
      else {
        if (this.bundle == null)
          this.bundle = new Code();
        this.bundle.setValue(value);
      }
    }

    public List<Resource> getResource() { 
      return this.resource;
    }

    public List<ExtensionDefn> getExtensionDefn() { 
      return this.extensionDefn;
    }

    public List<Binding> getBinding() { 
      return this.binding;
    }

  @Override
  public ResourceType getResourceType() {
    return ResourceType.Profile;
   }


}

