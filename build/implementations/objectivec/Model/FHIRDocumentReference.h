﻿/*
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
  

 * Generated on Wed, Jan 29, 2014 07:56+1100 for FHIR v0.12
 */
/*
 * A reference to a document
 *
 * [FhirResource("DocumentReference")]
 * [Serializable]
 */

#import "FHIRResource.h"


@class FHIRIdentifier;
@class FHIRResourceReference;
@class FHIRCodeableConcept;
@class FHIRUri;
@class FHIRDateTime;
@class FHIRInstant;
@class FHIRCode;
@class FHIRDocumentReferenceRelatesToComponent;
@class FHIRString;
@class FHIRInteger;
@class FHIRDocumentReferenceServiceComponent;
@class FHIRDocumentReferenceContextComponent;

@interface FHIRDocumentReference : FHIRResource

/*
 * The type of relationship between documents
 */
typedef enum 
{
    kDocumentRelationshipTypeReplaces, // This document logically replaces or supercedes the target document.
    kDocumentRelationshipTypeTransforms, // This document was generated by transforming the target document (e.g. format or language conversion).
    kDocumentRelationshipTypeSigns, // This document is a signature of the target document.
    kDocumentRelationshipTypeAppends, // This document adds additional information to the target document.
} kDocumentRelationshipType;

/*
 * The status of the document reference
 */
typedef enum 
{
    kDocumentReferenceStatusCurrent, // This is the current reference for this document.
    kDocumentReferenceStatusSuperceded, // This reference has been superseded by another reference.
    kDocumentReferenceStatusEnteredInError, // This reference was created in error.
} kDocumentReferenceStatus;

/*
 * Master Version Specific Identifier
 */
@property (nonatomic, strong) FHIRIdentifier *masterIdentifier;

/*
 * Other identifiers for the document
 */
@property (nonatomic, strong) NSArray/*<Identifier>*/ *identifier;

/*
 * Who|what is the subject of the document
 */
@property (nonatomic, strong) FHIRResourceReference *subject;

/*
 * What kind of document this is (LOINC if possible)
 */
@property (nonatomic, strong) FHIRCodeableConcept *type;

/*
 * Categorization of Document
 */
@property (nonatomic, strong) FHIRCodeableConcept *class_;

/*
 * Who and/or what authored the document
 */
@property (nonatomic, strong) NSArray/*<ResourceReference>*/ *author;

/*
 * Org which maintains the document
 */
@property (nonatomic, strong) FHIRResourceReference *custodian;

/*
 * Manages access policies for the document
 */
@property (nonatomic, strong) FHIRUri *policyManagerElement;

@property (nonatomic, strong) NSString *policyManager;

/*
 * Who/What authenticated the document
 */
@property (nonatomic, strong) FHIRResourceReference *authenticator;

/*
 * Document creation time
 */
@property (nonatomic, strong) FHIRDateTime *createdElement;

@property (nonatomic, strong) NSString *created;

/*
 * When this document reference created
 */
@property (nonatomic, strong) FHIRInstant *indexedElement;

@property (nonatomic, strong) NSDate *indexed;

/*
 * current | superceded | entered in error
 */
@property (nonatomic, strong) FHIRCode/*<code>*/ *statusElement;

@property (nonatomic) kDocumentReferenceStatus status;

/*
 * preliminary | final | appended | amended | entered in error
 */
@property (nonatomic, strong) FHIRCodeableConcept *docStatus;

/*
 * Relationships to other documents
 */
@property (nonatomic, strong) NSArray/*<DocumentReferenceRelatesToComponent>*/ *relatesTo;

/*
 * Human-readable description (title)
 */
@property (nonatomic, strong) FHIRString *descriptionElement;

@property (nonatomic, strong) NSString *description;

/*
 * Sensitivity of source document
 */
@property (nonatomic, strong) NSArray/*<CodeableConcept>*/ *confidentiality;

/*
 * The marked primary language for the document
 */
@property (nonatomic, strong) FHIRCode *primaryLanguageElement;

@property (nonatomic, strong) NSString *primaryLanguage;

/*
 * Mime type, + maybe character encoding
 */
@property (nonatomic, strong) FHIRCode *mimeTypeElement;

@property (nonatomic, strong) NSString *mimeType;

/*
 * Format/content rules for the document
 */
@property (nonatomic, strong) NSArray/*<uri>*/ *formatElement;

@property (nonatomic, strong) NSArray /*<NSString>*/ *format;

/*
 * Size of the document in bytes
 */
@property (nonatomic, strong) FHIRInteger *sizeElement;

@property (nonatomic, strong) NSNumber *size;

/*
 * HexBinary representation of SHA1
 */
@property (nonatomic, strong) FHIRString *hashElement;

@property (nonatomic, strong) NSString *hash;

/*
 * Where to access the document
 */
@property (nonatomic, strong) FHIRUri *locationElement;

@property (nonatomic, strong) NSString *location;

/*
 * If access is not fully described by location
 */
@property (nonatomic, strong) FHIRDocumentReferenceServiceComponent *service;

/*
 * Clinical context of document
 */
@property (nonatomic, strong) FHIRDocumentReferenceContextComponent *context;

- (FHIRErrorList *)validate;

@end