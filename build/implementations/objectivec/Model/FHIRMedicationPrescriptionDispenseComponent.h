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
 * null
 *
 * [FhirComposite("MedicationPrescriptionDispenseComponent")]
 * [Serializable]
 */

#import "FHIRElement.h"

#import "FHIRMedicationPrescription.h"

@class FHIRResourceReference;
@class FHIRPeriod;
@class FHIRInteger;
@class FHIRQuantity;
@class FHIRDuration;

@interface FHIRMedicationPrescriptionDispenseComponent : FHIRElement

/*
 * Product to be supplied
 */
@property (nonatomic, strong) FHIRResourceReference *medication;

/*
 * Time period supply is authorized for
 */
@property (nonatomic, strong) FHIRPeriod *validityPeriod;

/*
 * # of refills authorized
 */
@property (nonatomic, strong) FHIRInteger *numberOfRepeatsAllowedElement;

@property (nonatomic, strong) NSNumber *numberOfRepeatsAllowed;

/*
 * Amount of medication to supply per dispense
 */
@property (nonatomic, strong) FHIRQuantity *quantity;

/*
 * Days supply per dispense
 */
@property (nonatomic, strong) FHIRDuration *expectedSupplyDuration;

- (FHIRErrorList *)validate;

@end
