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

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Protocol instances
    /// </summary>
    internal static partial class ProtocolParser
    {
        /// <summary>
        /// Parse Protocol
        /// </summary>
        public static Hl7.Fhir.Model.Protocol ParseProtocol(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Protocol existingInstance = null )
        {
            Hl7.Fhir.Model.Protocol result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Protocol();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element language
                    else if( ParserUtils.IsAtFhirElement(reader, "language") )
                        result.Language = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element text
                    else if( ParserUtils.IsAtFhirElement(reader, "text") )
                        result.Text = NarrativeParser.ParseNarrative(reader, errors);
                    
                    // Parse element contained
                    else if( ParserUtils.IsAtFhirElement(reader, "contained") )
                    {
                        result.Contained = new List<Hl7.Fhir.Model.Resource>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "contained") )
                            result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element title
                    else if( ParserUtils.IsAtFhirElement(reader, "title") )
                        result.Title = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeParser.ParseCode<Hl7.Fhir.Model.Protocol.ProtocolType>(reader, errors);
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = CodeParser.ParseCode<Hl7.Fhir.Model.Protocol.ProtocolStatus>(reader, errors);
                    
                    // Parse element author
                    else if( ParserUtils.IsAtFhirElement(reader, "author") )
                        result.Author = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element purpose
                    else if( ParserUtils.IsAtFhirElement(reader, "purpose") )
                        result.Purpose = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element group
                    else if( ParserUtils.IsAtFhirElement(reader, "group") )
                        result.Group = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element step
                    else if( ParserUtils.IsAtFhirElement(reader, "step") )
                    {
                        result.Step = new List<Hl7.Fhir.Model.Protocol.ProtocolStepComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "step") )
                            result.Step.Add(ProtocolParser.ParseProtocolStepComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse ProtocolStepPreconditionComponent
        /// </summary>
        public static Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent ParseProtocolStepPreconditionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element condition
                    else if( ParserUtils.IsAtFhirElement(reader, "condition") )
                        result.Condition = ProtocolParser.ParseProtocolStepPreconditionConditionComponent(reader, errors);
                    
                    // Parse element intersection
                    else if( ParserUtils.IsAtFhirElement(reader, "intersection") )
                    {
                        result.Intersection = new List<Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "intersection") )
                            result.Intersection.Add(ProtocolParser.ParseProtocolStepPreconditionComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element union
                    else if( ParserUtils.IsAtFhirElement(reader, "union") )
                    {
                        result.Union = new List<Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "union") )
                            result.Union.Add(ProtocolParser.ParseProtocolStepPreconditionComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element exclude
                    else if( ParserUtils.IsAtFhirElement(reader, "exclude") )
                    {
                        result.Exclude = new List<Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "exclude") )
                            result.Exclude.Add(ProtocolParser.ParseProtocolStepPreconditionComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse ProtocolStepActivityComponentComponent
        /// </summary>
        public static Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponentComponent ParseProtocolStepActivityComponentComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponentComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponentComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponentComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element sequence
                    else if( ParserUtils.IsAtFhirElement(reader, "sequence") )
                        result.Sequence = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element activity
                    else if( ParserUtils.IsAtFhirElement(reader, "activity") )
                        result.Activity = IdRefParser.ParseIdRef(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse ProtocolStepPreconditionConditionComponent
        /// </summary>
        public static Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionConditionComponent ParseProtocolStepPreconditionConditionComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionConditionComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionConditionComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Protocol.ProtocolStepPreconditionConditionComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element value
                    else if( ParserUtils.IsAtFhirElement(reader, "value", true) )
                        result.Value = FhirParser.ParseElement(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse ProtocolStepActivityComponent
        /// </summary>
        public static Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponent ParseProtocolStepActivityComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element alternative
                    else if( ParserUtils.IsAtFhirElement(reader, "alternative") )
                    {
                        result.Alternative = new List<Hl7.Fhir.Model.IdRef>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "alternative") )
                            result.Alternative.Add(IdRefParser.ParseIdRef(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element component
                    else if( ParserUtils.IsAtFhirElement(reader, "component") )
                    {
                        result.Component = new List<Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponentComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "component") )
                            result.Component.Add(ProtocolParser.ParseProtocolStepActivityComponentComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element following
                    else if( ParserUtils.IsAtFhirElement(reader, "following") )
                    {
                        result.Following = new List<Hl7.Fhir.Model.IdRef>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "following") )
                            result.Following.Add(IdRefParser.ParseIdRef(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element wait
                    else if( ParserUtils.IsAtFhirElement(reader, "wait") )
                        result.Wait = DurationParser.ParseDuration(reader, errors);
                    
                    // Parse element detail
                    else if( ParserUtils.IsAtFhirElement(reader, "detail") )
                        result.Detail = ActivityDefinitionParser.ParseActivityDefinition(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse ProtocolStepComponent
        /// </summary>
        public static Hl7.Fhir.Model.Protocol.ProtocolStepComponent ParseProtocolStepComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Protocol.ProtocolStepComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Protocol.ProtocolStepComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Protocol.ProtocolStepComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element duration
                    else if( ParserUtils.IsAtFhirElement(reader, "duration") )
                        result.Duration = DurationParser.ParseDuration(reader, errors);
                    
                    // Parse element precondition
                    else if( ParserUtils.IsAtFhirElement(reader, "precondition") )
                        result.Precondition = ProtocolParser.ParseProtocolStepPreconditionComponent(reader, errors);
                    
                    // Parse element exit
                    else if( ParserUtils.IsAtFhirElement(reader, "exit") )
                        result.Exit = ProtocolParser.ParseProtocolStepPreconditionComponent(reader, errors);
                    
                    // Parse element firstActivity
                    else if( ParserUtils.IsAtFhirElement(reader, "firstActivity") )
                        result.FirstActivity = IdRefParser.ParseIdRef(reader, errors);
                    
                    // Parse element activity
                    else if( ParserUtils.IsAtFhirElement(reader, "activity") )
                    {
                        result.Activity = new List<Hl7.Fhir.Model.Protocol.ProtocolStepActivityComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "activity") )
                            result.Activity.Add(ProtocolParser.ParseProtocolStepActivityComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element next
                    else if( ParserUtils.IsAtFhirElement(reader, "next") )
                    {
                        result.Next = new List<Hl7.Fhir.Model.Protocol.ProtocolStepNextComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "next") )
                            result.Next.Add(ProtocolParser.ParseProtocolStepNextComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse ProtocolStepNextComponent
        /// </summary>
        public static Hl7.Fhir.Model.Protocol.ProtocolStepNextComponent ParseProtocolStepNextComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Protocol.ProtocolStepNextComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Protocol.ProtocolStepNextComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Protocol.ProtocolStepNextComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Hl7.Fhir.Model.Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element _id
                    else if( ParserUtils.IsAtFhirElement(reader, "_id") )
                        result.LocalId = Id.Parse(reader.ReadPrimitiveContents("id"));
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                        result.Id = IdRefParser.ParseIdRef(reader, errors);
                    
                    // Parse element condition
                    else if( ParserUtils.IsAtFhirElement(reader, "condition") )
                        result.Condition = ProtocolParser.ParseProtocolStepPreconditionComponent(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
    }
}
