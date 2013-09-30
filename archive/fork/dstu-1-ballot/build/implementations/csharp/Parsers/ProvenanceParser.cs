using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;
using System.Linq;

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
// Generated on Mon, Sep 30, 2013 03:15+1000 for FHIR v0.11
//

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Provenance instances
    /// </summary>
    internal static partial class ProvenanceParser
    {
        /// <summary>
        /// Parse Provenance
        /// </summary>
        public static Hl7.Fhir.Model.Provenance ParseProvenance(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Provenance existingInstance = null )
        {
            Hl7.Fhir.Model.Provenance result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Provenance();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element language
                else if( atName == "language" )
                    result.LanguageElement = CodeParser.ParseCode(reader, errors);
                
                // Parse element text
                else if( atName == "text" )
                    result.Text = NarrativeParser.ParseNarrative(reader, errors);
                
                // Parse element contained
                else if( atName == "contained" )
                {
                    result.Contained = new List<Hl7.Fhir.Model.Resource>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "contained") )
                        result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element target
                else if( atName == "target" )
                {
                    result.Target = new List<Hl7.Fhir.Model.ResourceReference>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "target") )
                        result.Target.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element period
                else if( atName == "period" )
                    result.Period = PeriodParser.ParsePeriod(reader, errors);
                
                // Parse element recorded
                else if( atName == "recorded" )
                    result.RecordedElement = InstantParser.ParseInstant(reader, errors);
                
                // Parse element reason
                else if( atName == "reason" )
                    result.Reason = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                
                // Parse element location
                else if( atName == "location" )
                    result.Location = ResourceReferenceParser.ParseResourceReference(reader, errors);
                
                // Parse element policy
                else if( atName == "policy" )
                {
                    result.PolicyElement = new List<Hl7.Fhir.Model.FhirUri>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "policy") )
                        result.PolicyElement.Add(FhirUriParser.ParseFhirUri(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element agent
                else if( atName == "agent" )
                {
                    result.Agent = new List<Hl7.Fhir.Model.Provenance.ProvenanceAgentComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "agent") )
                        result.Agent.Add(ProvenanceParser.ParseProvenanceAgentComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element entity
                else if( atName == "entity" )
                {
                    result.Entity = new List<Hl7.Fhir.Model.Provenance.ProvenanceEntityComponent>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "entity") )
                        result.Entity.Add(ProvenanceParser.ParseProvenanceEntityComponent(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element signature
                else if( atName == "signature" )
                    result.SignatureElement = FhirStringParser.ParseFhirString(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse ProvenanceAgentComponent
        /// </summary>
        public static Hl7.Fhir.Model.Provenance.ProvenanceAgentComponent ParseProvenanceAgentComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Provenance.ProvenanceAgentComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Provenance.ProvenanceAgentComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Provenance.ProvenanceAgentComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element role
                else if( atName == "role" )
                    result.Role = CodingParser.ParseCoding(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodingParser.ParseCoding(reader, errors);
                
                // Parse element reference
                else if( atName == "reference" )
                    result.ReferenceElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element display
                else if( atName == "display" )
                    result.DisplayElement = FhirStringParser.ParseFhirString(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
        /// <summary>
        /// Parse ProvenanceEntityComponent
        /// </summary>
        public static Hl7.Fhir.Model.Provenance.ProvenanceEntityComponent ParseProvenanceEntityComponent(IFhirReader reader, ErrorList errors, Hl7.Fhir.Model.Provenance.ProvenanceEntityComponent existingInstance = null )
        {
            Hl7.Fhir.Model.Provenance.ProvenanceEntityComponent result = existingInstance != null ? existingInstance : new Hl7.Fhir.Model.Provenance.ProvenanceEntityComponent();
            string currentElementName = reader.CurrentElementName;
            reader.EnterElement();
            
            while (reader.HasMoreElements())
            {
                var atName = reader.CurrentElementName;
                // Parse element extension
                if( atName == "extension" )
                {
                    result.Extension = new List<Hl7.Fhir.Model.Extension>();
                    reader.EnterArray();
                    
                    while( ParserUtils.IsAtArrayElement(reader, "extension") )
                        result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                    
                    reader.LeaveArray();
                }
                
                // Parse element _id
                else if( atName == "_id" )
                    result.LocalIdElement = Id.Parse(reader.ReadPrimitiveContents(typeof(Id)));
                
                // Parse element role
                else if( atName == "role" )
                    result.RoleElement = CodeParser.ParseCode<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>(reader, errors);
                
                // Parse element type
                else if( atName == "type" )
                    result.Type = CodingParser.ParseCoding(reader, errors);
                
                // Parse element reference
                else if( atName == "reference" )
                    result.ReferenceElement = FhirUriParser.ParseFhirUri(reader, errors);
                
                // Parse element display
                else if( atName == "display" )
                    result.DisplayElement = FhirStringParser.ParseFhirString(reader, errors);
                
                // Parse element agent
                else if( atName == "agent" )
                    result.Agent = ProvenanceParser.ParseProvenanceAgentComponent(reader, errors);
                
                else
                {
                    errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                    reader.SkipSubElementsFor(currentElementName);
                    result = null;
                }
            }
            
            reader.LeaveElement();
            return result;
        }
        
    }
}
