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
 * Concept - reference to a terminology or just  text
 */
#import "FHIRCodeableConcept.h"

#import "FHIRCoding.h"
#import "FHIRString.h"

#import "FHIRErrorList.h"

@implementation FHIRCodeableConcept

- (NSString *)text
{
    if(self.textElement)
    {
        return [self.textElement value];
    }
    return nil;
}

- (void )setText:(NSString *)text
{
    if(text)
    {
        [self setTextElement:[[FHIRString alloc] initWithValue:text]];
    }
    else
    {
        [self setTextElement:nil];
    }
}


- (FHIRErrorList *)validate
{
    FHIRErrorList *result = [[FHIRErrorList alloc] init];
    
    [result addValidation:[super validate]];
    
    if(self.coding != nil )
        for(FHIRCoding *elem in self.coding)
            [result addValidationRange:[elem validate]];
    if(self.textElement != nil )
        [result addValidationRange:[self.textElement validate]];
    
    return result;
}

@end