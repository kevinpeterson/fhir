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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Family History
    /// </summary>
    [FhirResource("FamilyHistory")]
    [Serializable]
    public partial class FamilyHistory : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The nature of the relationship between the patient and the person with the condition. Based on the HL7v3 RoleCode: OID: 2.16.840.1.113883.5.111 with some inappropriate items removed
        /// </summary>
        public enum FamilialRelationship
        {
            AUNT, // The player of the role is a sister of the scoping person's mother or father.
            BRO, // The player of the role is a male sharing one or both parents in common with the scoping entity.
            BROINLAW, // The player of the role is: (1) a brother of the scoping person's spouse, or (2) the husband of the scoping person's sister, or (3) the husband of a sister of the scoping person's spouse.
            CHLDADOPT, // The player of the role is a child taken into a family through legal means and raised by the scoping person (parent) as his or her own child.
            CHLDFOST, // The player of the role is a child receiving parental care and nurture from the scoping person (parent) but not related to him or her through legal or blood ties.
            CHLDINLAW, // The player of the role is the spouse of scoping person's child.
            COUSN, // The player of the role is a relative of the scoping person descended from a common ancestor, such as a grandparent, by two or more steps in a diverging line.
            DAU, // The player of the role is a female offspring of the scoping entity (parent).
            DAUADOPT, // The player of the role is a female child taken into a family through legal means and raised by the scoping person (parent) as his or her own child.
            DAUC, // <New Concept> The player of the role is a female child (of any type) of scoping entity (parent).
            DAUFOST, // The player of the role is a female child receiving parental care and nurture from the scoping person (parent) but not related to him or her through legal or blood ties.
            DAUINLAW, // The player of the role is the wife of scoping person's son.
            CHILD, // The player of the role is a child of the scoping entity.
            EXT, // A family member outside the immediate family unit, not having a direct genetic or legal relationship e.g. Aunt, cousin, great grandparent, grandchild, grandparent, neiceNephew, and uncle.
            IMED, // A member of the immediate family unit by direct genetic or legal relationship.
            PRN, // one that begets or brings forth offspring or a person who brings up and cares for another (Webster's Collegiate Dictionary).
            SIB, // One person who shares a parent or parents with another.
            SIGOTHR, // A person who is important to one's well being; especially a spouse or one in a similar relationship. (The player is the one who is important).
            DOMPART, // The player of the role cohabits with the scoping person but is not the scoping person's spouse.
            SPS, // The player of the role is a marriage partner of the scoping person.
            FTH, // The player of the role is a male who begets or raises or nurtures the scoping entity (child).
            FTHINLAW, // The player of the role is the father of the scoping person's husband or wife.
            GGRFTH, // The player of the role is the father of the scoping person's grandparent.
            GGRMTH, // The player of the role is the mother of the scoping person's grandparent.
            GGRPRN, // The player of the role is a parent of the scoping person's grandparent.
            GRFTH, // The player of the role is the father of the scoping person's mother or father.
            GRMTH, // The player of the role is the mother of the scoping person's mother or father.
            GRNDCHILD, // The player of the role is a child of the scoping person's son or daughter.
            GRNDDAU, // The player of the role is a daughter of the scoping person's son or daughter.
            GRNDSON, // The player of the role is a son of the scoping person's son or daughter.
            GRPRN, // parent of a parent of the subject.
            HBRO, // The player of the role is a male related to the scoping entity by sharing only one biological parent.
            HSIB, // The player of the role is related to the scoping entity by sharing only one biological parent.
            HSIS, // The player of the role is a female related to the scoping entity by sharing only one biological parent.
            HUSB, // The player of the role is a man joined to a woman (scoping person) in marriage.
            MTH, // The player of the role is a female who conceives, gives birth to, or raises and nurtures the scoping entity (child).
            MTHINLAW, // The player of the role is the mother of the scoping person's husband or wife.
            NBOR, // The player of the role lives near or next to the scoping person.
            NBRO, // The player of the role is a male having the same biological parents as the scoping entity.
            NCHILD, // A child as determined by birth.
            NEPHEW, // The player of the role is a son of the scoping person's brother or sister or of the brother or sister of the scoping person's spouse.
            NFTH, // The player of the role is a male who begets the scoping entity (child).
            NFTHF, // Indicates the biologic male parent of a fetus.
            NIECE, // The player of the role is a daughter of the scoping person's brother or sister or of the brother or sister of the scoping person's spouse.
            NIENEPH, // The player of the role is a child of scoping person's brother or sister or of the brother or sister of the scoping person's spouse.
            NMTH, // The player of the role is a female who conceives or gives birth to the scoping entity (child).
            NOK, // Played by an individual who is designated as the next of kin for another individual which scopes the role.
            NPRN,
            NSIB, // The player of the role has both biological parents in common with the scoping entity.
            NSIS, // The player of the role is a female having the same biological parents as the scoping entity.
            PRNINLAW, // The player of the role is the parent of scoping person's husband or wife.
            ROOM, // One who shares living quarters with the subject.
            SIBINLAW, // The player of the role is: (1) a sibling of the scoping person's spouse, or (2) the spouse of the scoping person's sibling, or (3) the spouse of a sibling of the scoping person's spouse.
            SIS, // The player of the role is a female sharing one or both parents in common with the scoping entity.
            SISINLAW, // The player of the role is: (1) a sister of the scoping person's spouse, or (2) the wife of the scoping person's brother, or (3) the wife of a brother of the scoping person's spouse.
            SON, // The player of the role is a male offspring of the scoping entity (parent).
            SONADOPT, // The player of the role is a male child taken into a family through legal means and raised by the scoping person (parent) as his or her own child.
            SONC, // <New Concept> The player of the role is a male child (of any type) of scoping entity (parent).
            SONFOST, // The player of the role is a male child receiving parental care and nurture from the scoping person (parent) but not related to him or her through legal or blood ties.
            SONINLAW, // The player of the role is the husband of scoping person's daughter.
            STPBRO, // The player of the role is a son of the scoping person's stepparent.
            STPCHLD, // The player of the role is a child of the scoping person's spouse by a previous union.
            STPDAU, // The player of the role is a daughter of the scoping person's spouse by a previous union.
            STPFTH, // The player of the role is the husband of scoping person's mother and not the scoping person's natural father.
            STPMTH, // The player of the role is the wife of scoping person's father and not the scoping person's natural mother.
            STPPRN, // The player of the role is the spouse of the scoping person's parent and not the scoping person's natural parent.
            STPSIB, // The player of the role is a child of the scoping person's stepparent.
            STPSIS, // The player of the role is a daughter of the scoping person's stepparent.
            STPSON, // The player of the role is a son of the scoping person's spouse by a previous union.
            UNCLE, // The player of the role is a brother of the scoping person's mother or father.
            WIFE, // The player of the role is a woman joined to a man (scoping person) in marriage.
        }
        
        /// <summary>
        /// Conversion of FamilialRelationshipfrom and into string
        /// <summary>
        public static class FamilialRelationshipHandling
        {
            public static bool TryParse(string value, out FamilialRelationship result)
            {
                result = default(FamilialRelationship);
                
                if( value=="AUNT")
                    result = FamilialRelationship.AUNT;
                else if( value=="BRO")
                    result = FamilialRelationship.BRO;
                else if( value=="BROINLAW")
                    result = FamilialRelationship.BROINLAW;
                else if( value=="CHLDADOPT")
                    result = FamilialRelationship.CHLDADOPT;
                else if( value=="CHLDFOST")
                    result = FamilialRelationship.CHLDFOST;
                else if( value=="CHLDINLAW")
                    result = FamilialRelationship.CHLDINLAW;
                else if( value=="COUSN")
                    result = FamilialRelationship.COUSN;
                else if( value=="DAU")
                    result = FamilialRelationship.DAU;
                else if( value=="DAUADOPT")
                    result = FamilialRelationship.DAUADOPT;
                else if( value=="DAUC")
                    result = FamilialRelationship.DAUC;
                else if( value=="DAUFOST")
                    result = FamilialRelationship.DAUFOST;
                else if( value=="DAUINLAW")
                    result = FamilialRelationship.DAUINLAW;
                else if( value=="CHILD")
                    result = FamilialRelationship.CHILD;
                else if( value=="EXT")
                    result = FamilialRelationship.EXT;
                else if( value=="IMED")
                    result = FamilialRelationship.IMED;
                else if( value=="PRN")
                    result = FamilialRelationship.PRN;
                else if( value=="SIB")
                    result = FamilialRelationship.SIB;
                else if( value=="SIGOTHR")
                    result = FamilialRelationship.SIGOTHR;
                else if( value=="DOMPART")
                    result = FamilialRelationship.DOMPART;
                else if( value=="SPS")
                    result = FamilialRelationship.SPS;
                else if( value=="FTH")
                    result = FamilialRelationship.FTH;
                else if( value=="FTHINLAW")
                    result = FamilialRelationship.FTHINLAW;
                else if( value=="GGRFTH")
                    result = FamilialRelationship.GGRFTH;
                else if( value=="GGRMTH")
                    result = FamilialRelationship.GGRMTH;
                else if( value=="GGRPRN")
                    result = FamilialRelationship.GGRPRN;
                else if( value=="GRFTH")
                    result = FamilialRelationship.GRFTH;
                else if( value=="GRMTH")
                    result = FamilialRelationship.GRMTH;
                else if( value=="GRNDCHILD")
                    result = FamilialRelationship.GRNDCHILD;
                else if( value=="GRNDDAU")
                    result = FamilialRelationship.GRNDDAU;
                else if( value=="GRNDSON")
                    result = FamilialRelationship.GRNDSON;
                else if( value=="GRPRN")
                    result = FamilialRelationship.GRPRN;
                else if( value=="HBRO")
                    result = FamilialRelationship.HBRO;
                else if( value=="HSIB")
                    result = FamilialRelationship.HSIB;
                else if( value=="HSIS")
                    result = FamilialRelationship.HSIS;
                else if( value=="HUSB")
                    result = FamilialRelationship.HUSB;
                else if( value=="MTH")
                    result = FamilialRelationship.MTH;
                else if( value=="MTHINLAW")
                    result = FamilialRelationship.MTHINLAW;
                else if( value=="NBOR")
                    result = FamilialRelationship.NBOR;
                else if( value=="NBRO")
                    result = FamilialRelationship.NBRO;
                else if( value=="NCHILD")
                    result = FamilialRelationship.NCHILD;
                else if( value=="NEPHEW")
                    result = FamilialRelationship.NEPHEW;
                else if( value=="NFTH")
                    result = FamilialRelationship.NFTH;
                else if( value=="NFTHF")
                    result = FamilialRelationship.NFTHF;
                else if( value=="NIECE")
                    result = FamilialRelationship.NIECE;
                else if( value=="NIENEPH")
                    result = FamilialRelationship.NIENEPH;
                else if( value=="NMTH")
                    result = FamilialRelationship.NMTH;
                else if( value=="NOK")
                    result = FamilialRelationship.NOK;
                else if( value=="NPRN")
                    result = FamilialRelationship.NPRN;
                else if( value=="NSIB")
                    result = FamilialRelationship.NSIB;
                else if( value=="NSIS")
                    result = FamilialRelationship.NSIS;
                else if( value=="PRNINLAW")
                    result = FamilialRelationship.PRNINLAW;
                else if( value=="ROOM")
                    result = FamilialRelationship.ROOM;
                else if( value=="SIBINLAW")
                    result = FamilialRelationship.SIBINLAW;
                else if( value=="SIS")
                    result = FamilialRelationship.SIS;
                else if( value=="SISINLAW")
                    result = FamilialRelationship.SISINLAW;
                else if( value=="SON")
                    result = FamilialRelationship.SON;
                else if( value=="SONADOPT")
                    result = FamilialRelationship.SONADOPT;
                else if( value=="SONC")
                    result = FamilialRelationship.SONC;
                else if( value=="SONFOST")
                    result = FamilialRelationship.SONFOST;
                else if( value=="SONINLAW")
                    result = FamilialRelationship.SONINLAW;
                else if( value=="STPBRO")
                    result = FamilialRelationship.STPBRO;
                else if( value=="STPCHLD")
                    result = FamilialRelationship.STPCHLD;
                else if( value=="STPDAU")
                    result = FamilialRelationship.STPDAU;
                else if( value=="STPFTH")
                    result = FamilialRelationship.STPFTH;
                else if( value=="STPMTH")
                    result = FamilialRelationship.STPMTH;
                else if( value=="STPPRN")
                    result = FamilialRelationship.STPPRN;
                else if( value=="STPSIB")
                    result = FamilialRelationship.STPSIB;
                else if( value=="STPSIS")
                    result = FamilialRelationship.STPSIS;
                else if( value=="STPSON")
                    result = FamilialRelationship.STPSON;
                else if( value=="UNCLE")
                    result = FamilialRelationship.UNCLE;
                else if( value=="WIFE")
                    result = FamilialRelationship.WIFE;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(FamilialRelationship value)
            {
                if( value==FamilialRelationship.AUNT )
                    return "AUNT";
                else if( value==FamilialRelationship.BRO )
                    return "BRO";
                else if( value==FamilialRelationship.BROINLAW )
                    return "BROINLAW";
                else if( value==FamilialRelationship.CHLDADOPT )
                    return "CHLDADOPT";
                else if( value==FamilialRelationship.CHLDFOST )
                    return "CHLDFOST";
                else if( value==FamilialRelationship.CHLDINLAW )
                    return "CHLDINLAW";
                else if( value==FamilialRelationship.COUSN )
                    return "COUSN";
                else if( value==FamilialRelationship.DAU )
                    return "DAU";
                else if( value==FamilialRelationship.DAUADOPT )
                    return "DAUADOPT";
                else if( value==FamilialRelationship.DAUC )
                    return "DAUC";
                else if( value==FamilialRelationship.DAUFOST )
                    return "DAUFOST";
                else if( value==FamilialRelationship.DAUINLAW )
                    return "DAUINLAW";
                else if( value==FamilialRelationship.CHILD )
                    return "CHILD";
                else if( value==FamilialRelationship.EXT )
                    return "EXT";
                else if( value==FamilialRelationship.IMED )
                    return "IMED";
                else if( value==FamilialRelationship.PRN )
                    return "PRN";
                else if( value==FamilialRelationship.SIB )
                    return "SIB";
                else if( value==FamilialRelationship.SIGOTHR )
                    return "SIGOTHR";
                else if( value==FamilialRelationship.DOMPART )
                    return "DOMPART";
                else if( value==FamilialRelationship.SPS )
                    return "SPS";
                else if( value==FamilialRelationship.FTH )
                    return "FTH";
                else if( value==FamilialRelationship.FTHINLAW )
                    return "FTHINLAW";
                else if( value==FamilialRelationship.GGRFTH )
                    return "GGRFTH";
                else if( value==FamilialRelationship.GGRMTH )
                    return "GGRMTH";
                else if( value==FamilialRelationship.GGRPRN )
                    return "GGRPRN";
                else if( value==FamilialRelationship.GRFTH )
                    return "GRFTH";
                else if( value==FamilialRelationship.GRMTH )
                    return "GRMTH";
                else if( value==FamilialRelationship.GRNDCHILD )
                    return "GRNDCHILD";
                else if( value==FamilialRelationship.GRNDDAU )
                    return "GRNDDAU";
                else if( value==FamilialRelationship.GRNDSON )
                    return "GRNDSON";
                else if( value==FamilialRelationship.GRPRN )
                    return "GRPRN";
                else if( value==FamilialRelationship.HBRO )
                    return "HBRO";
                else if( value==FamilialRelationship.HSIB )
                    return "HSIB";
                else if( value==FamilialRelationship.HSIS )
                    return "HSIS";
                else if( value==FamilialRelationship.HUSB )
                    return "HUSB";
                else if( value==FamilialRelationship.MTH )
                    return "MTH";
                else if( value==FamilialRelationship.MTHINLAW )
                    return "MTHINLAW";
                else if( value==FamilialRelationship.NBOR )
                    return "NBOR";
                else if( value==FamilialRelationship.NBRO )
                    return "NBRO";
                else if( value==FamilialRelationship.NCHILD )
                    return "NCHILD";
                else if( value==FamilialRelationship.NEPHEW )
                    return "NEPHEW";
                else if( value==FamilialRelationship.NFTH )
                    return "NFTH";
                else if( value==FamilialRelationship.NFTHF )
                    return "NFTHF";
                else if( value==FamilialRelationship.NIECE )
                    return "NIECE";
                else if( value==FamilialRelationship.NIENEPH )
                    return "NIENEPH";
                else if( value==FamilialRelationship.NMTH )
                    return "NMTH";
                else if( value==FamilialRelationship.NOK )
                    return "NOK";
                else if( value==FamilialRelationship.NPRN )
                    return "NPRN";
                else if( value==FamilialRelationship.NSIB )
                    return "NSIB";
                else if( value==FamilialRelationship.NSIS )
                    return "NSIS";
                else if( value==FamilialRelationship.PRNINLAW )
                    return "PRNINLAW";
                else if( value==FamilialRelationship.ROOM )
                    return "ROOM";
                else if( value==FamilialRelationship.SIBINLAW )
                    return "SIBINLAW";
                else if( value==FamilialRelationship.SIS )
                    return "SIS";
                else if( value==FamilialRelationship.SISINLAW )
                    return "SISINLAW";
                else if( value==FamilialRelationship.SON )
                    return "SON";
                else if( value==FamilialRelationship.SONADOPT )
                    return "SONADOPT";
                else if( value==FamilialRelationship.SONC )
                    return "SONC";
                else if( value==FamilialRelationship.SONFOST )
                    return "SONFOST";
                else if( value==FamilialRelationship.SONINLAW )
                    return "SONINLAW";
                else if( value==FamilialRelationship.STPBRO )
                    return "STPBRO";
                else if( value==FamilialRelationship.STPCHLD )
                    return "STPCHLD";
                else if( value==FamilialRelationship.STPDAU )
                    return "STPDAU";
                else if( value==FamilialRelationship.STPFTH )
                    return "STPFTH";
                else if( value==FamilialRelationship.STPMTH )
                    return "STPMTH";
                else if( value==FamilialRelationship.STPPRN )
                    return "STPPRN";
                else if( value==FamilialRelationship.STPSIB )
                    return "STPSIB";
                else if( value==FamilialRelationship.STPSIS )
                    return "STPSIS";
                else if( value==FamilialRelationship.STPSON )
                    return "STPSON";
                else if( value==FamilialRelationship.UNCLE )
                    return "UNCLE";
                else if( value==FamilialRelationship.WIFE )
                    return "WIFE";
                else
                    throw new ArgumentException("Unrecognized FamilialRelationship value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("FamilyHistoryRelationConditionComponent")]
        [Serializable]
        public partial class FamilyHistoryRelationConditionComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The condition
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Type { get; set; }
            
            /// <summary>
            /// deceased | permanent disability | etc.
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Outcome { get; set; }
            
            /// <summary>
            /// How old the person was when the condition manifested
            /// </summary>
            public Hl7.Fhir.Model.Element Onset { get; set; }
            
            /// <summary>
            /// General notes
            /// </summary>
            public Hl7.Fhir.Model.FhirString NoteElement { get; set; }
            
            public string Note
            {
                get { return NoteElement != null ? NoteElement.Value : null; }
                set
                {
                    if(value == null)
                      NoteElement = null; 
                    else
                      NoteElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(Type != null )
                    result.AddRange(Type.Validate());
                if(Outcome != null )
                    result.AddRange(Outcome.Validate());
                if(Onset != null )
                    result.AddRange(Onset.Validate());
                if(NoteElement != null )
                    result.AddRange(NoteElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("FamilyHistoryRelationComponent")]
        [Serializable]
        public partial class FamilyHistoryRelationComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The family member who had the condition
            /// </summary>
            public Hl7.Fhir.Model.FhirString NameElement { get; set; }
            
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Relationship to the subject
            /// </summary>
            public Hl7.Fhir.Model.CodeableConcept Relationship { get; set; }
            
            /// <summary>
            /// Is the person deceased
            /// </summary>
            public Hl7.Fhir.Model.Element Deceased { get; set; }
            
            /// <summary>
            /// General note about the related person
            /// </summary>
            public Hl7.Fhir.Model.FhirString NoteElement { get; set; }
            
            public string Note
            {
                get { return NoteElement != null ? NoteElement.Value : null; }
                set
                {
                    if(value == null)
                      NoteElement = null; 
                    else
                      NoteElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// The Condition that the related person had
            /// </summary>
            public List<Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationConditionComponent> Condition { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(NameElement != null )
                    result.AddRange(NameElement.Validate());
                if(Relationship != null )
                    result.AddRange(Relationship.Validate());
                if(Deceased != null )
                    result.AddRange(Deceased.Validate());
                if(NoteElement != null )
                    result.AddRange(NoteElement.Validate());
                if(Condition != null )
                    Condition.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// Subject of this history
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Additional details
        /// </summary>
        public Hl7.Fhir.Model.FhirString NoteElement { get; set; }
        
        public string Note
        {
            get { return NoteElement != null ? NoteElement.Value : null; }
            set
            {
                if(value == null)
                  NoteElement = null; 
                else
                  NoteElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// The relation
        /// </summary>
        public List<Hl7.Fhir.Model.FamilyHistory.FamilyHistoryRelationComponent> Relation { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(NoteElement != null )
                result.AddRange(NoteElement.Validate());
            if(Relation != null )
                Relation.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
