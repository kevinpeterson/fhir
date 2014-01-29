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
  

 * Generated on Mon, Jan 27, 2014 13:55-0500 for FHIR v0.12
 */
/*
 * (informative) A slot of time that may be available for booking appointments
 */
#import "FHIRSlot.h"

#import "FHIRIdentifier.h"
#import "FHIRCodeableConcept.h"
#import "FHIRResourceReference.h"
#import "FHIRCode.h"
#import "FHIRInstant.h"
#import "FHIRString.h"
#import "FHIRDateTime.h"

#import "FHIRErrorList.h"

@implementation FHIRSlot

- (kSlotStatus )freeBusyType
{
    return [FHIREnumHelper parseString:[self.freeBusyTypeElement value] enumType:kEnumTypeSlotStatus];
}

- (void )setFreeBusyType:(kSlotStatus )freeBusyType
{
    [self setFreeBusyTypeElement:[[FHIRCode/*<code>*/ alloc] initWithValue:[FHIREnumHelper enumToString:freeBusyType enumType:kEnumTypeSlotStatus]]];
}


- (NSDate *)start
{
    if(self.startElement)
    {
        return [self.startElement value];
    }
    return nil;
}

- (void )setStart:(NSDate *)start
{
    if(start)
    {
        [self setStartElement:[[FHIRInstant alloc] initWithValue:start]];
    }
    else
    {
        [self setStartElement:nil];
    }
}


- (NSDate *)end
{
    if(self.endElement)
    {
        return [self.endElement value];
    }
    return nil;
}

- (void )setEnd:(NSDate *)end
{
    if(end)
    {
        [self setEndElement:[[FHIRInstant alloc] initWithValue:end]];
    }
    else
    {
        [self setEndElement:nil];
    }
}


- (NSString *)comment
{
    if(self.commentElement)
    {
        return [self.commentElement value];
    }
    return nil;
}

- (void )setComment:(NSString *)comment
{
    if(comment)
    {
        [self setCommentElement:[[FHIRString alloc] initWithValue:comment]];
    }
    else
    {
        [self setCommentElement:nil];
    }
}


- (NSString *)authorDate
{
    if(self.authorDateElement)
    {
        return [self.authorDateElement value];
    }
    return nil;
}

- (void )setAuthorDate:(NSString *)authorDate
{
    if(authorDate)
    {
        [self setAuthorDateElement:[[FHIRDateTime alloc] initWithValue:authorDate]];
    }
    else
    {
        [self setAuthorDateElement:nil];
    }
}


- (FHIRErrorList *)validate
{
    FHIRErrorList *result = [[FHIRErrorList alloc] init];
    
    [result addValidation:[super validate]];
    
    if(self.identifier != nil )
        for(FHIRIdentifier *elem in self.identifier)
            [result addValidationRange:[elem validate]];
    if(self.type != nil )
        [result addValidationRange:[self.type validate]];
    if(self.availability != nil )
        [result addValidationRange:[self.availability validate]];
    if(self.freeBusyTypeElement != nil )
        [result addValidationRange:[self.freeBusyTypeElement validate]];
    if(self.startElement != nil )
        [result addValidationRange:[self.startElement validate]];
    if(self.endElement != nil )
        [result addValidationRange:[self.endElement validate]];
    if(self.commentElement != nil )
        [result addValidationRange:[self.commentElement validate]];
    if(self.author != nil )
        [result addValidationRange:[self.author validate]];
    if(self.authorDateElement != nil )
        [result addValidationRange:[self.authorDateElement validate]];
    
    return result;
}

@end