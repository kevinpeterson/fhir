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
    /// A set of images produced in single study (one or more series of references images)
    /// </summary>
    [FhirResource("ImagingStudy")]
    [Serializable]
    public partial class ImagingStudy : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Type of acquired image data in the instance
        /// </summary>
        public enum ImagingModality
        {
            AR,
            BMD,
            BDUS,
            EPS,
            CR,
            CT,
            DX,
            ECG,
            ES,
            XC,
            GM,
            HD,
            IO,
            IVOCT,
            IVUS,
            KER,
            LEN,
            MR,
            MG,
            NM,
            OAM,
            OCT,
            OPM,
            OP,
            OPR,
            OPT,
            OPV,
            PX,
            PT,
            RF,
            RG,
            SM,
            SRF,
            US,
            VA,
            XA,
        }
        
        /// <summary>
        /// Conversion of ImagingModalityfrom and into string
        /// <summary>
        public static class ImagingModalityHandling
        {
            public static bool TryParse(string value, out ImagingModality result)
            {
                result = default(ImagingModality);
                
                if( value=="AR")
                    result = ImagingModality.AR;
                else if( value=="BMD")
                    result = ImagingModality.BMD;
                else if( value=="BDUS")
                    result = ImagingModality.BDUS;
                else if( value=="EPS")
                    result = ImagingModality.EPS;
                else if( value=="CR")
                    result = ImagingModality.CR;
                else if( value=="CT")
                    result = ImagingModality.CT;
                else if( value=="DX")
                    result = ImagingModality.DX;
                else if( value=="ECG")
                    result = ImagingModality.ECG;
                else if( value=="ES")
                    result = ImagingModality.ES;
                else if( value=="XC")
                    result = ImagingModality.XC;
                else if( value=="GM")
                    result = ImagingModality.GM;
                else if( value=="HD")
                    result = ImagingModality.HD;
                else if( value=="IO")
                    result = ImagingModality.IO;
                else if( value=="IVOCT")
                    result = ImagingModality.IVOCT;
                else if( value=="IVUS")
                    result = ImagingModality.IVUS;
                else if( value=="KER")
                    result = ImagingModality.KER;
                else if( value=="LEN")
                    result = ImagingModality.LEN;
                else if( value=="MR")
                    result = ImagingModality.MR;
                else if( value=="MG")
                    result = ImagingModality.MG;
                else if( value=="NM")
                    result = ImagingModality.NM;
                else if( value=="OAM")
                    result = ImagingModality.OAM;
                else if( value=="OCT")
                    result = ImagingModality.OCT;
                else if( value=="OPM")
                    result = ImagingModality.OPM;
                else if( value=="OP")
                    result = ImagingModality.OP;
                else if( value=="OPR")
                    result = ImagingModality.OPR;
                else if( value=="OPT")
                    result = ImagingModality.OPT;
                else if( value=="OPV")
                    result = ImagingModality.OPV;
                else if( value=="PX")
                    result = ImagingModality.PX;
                else if( value=="PT")
                    result = ImagingModality.PT;
                else if( value=="RF")
                    result = ImagingModality.RF;
                else if( value=="RG")
                    result = ImagingModality.RG;
                else if( value=="SM")
                    result = ImagingModality.SM;
                else if( value=="SRF")
                    result = ImagingModality.SRF;
                else if( value=="US")
                    result = ImagingModality.US;
                else if( value=="VA")
                    result = ImagingModality.VA;
                else if( value=="XA")
                    result = ImagingModality.XA;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ImagingModality value)
            {
                if( value==ImagingModality.AR )
                    return "AR";
                else if( value==ImagingModality.BMD )
                    return "BMD";
                else if( value==ImagingModality.BDUS )
                    return "BDUS";
                else if( value==ImagingModality.EPS )
                    return "EPS";
                else if( value==ImagingModality.CR )
                    return "CR";
                else if( value==ImagingModality.CT )
                    return "CT";
                else if( value==ImagingModality.DX )
                    return "DX";
                else if( value==ImagingModality.ECG )
                    return "ECG";
                else if( value==ImagingModality.ES )
                    return "ES";
                else if( value==ImagingModality.XC )
                    return "XC";
                else if( value==ImagingModality.GM )
                    return "GM";
                else if( value==ImagingModality.HD )
                    return "HD";
                else if( value==ImagingModality.IO )
                    return "IO";
                else if( value==ImagingModality.IVOCT )
                    return "IVOCT";
                else if( value==ImagingModality.IVUS )
                    return "IVUS";
                else if( value==ImagingModality.KER )
                    return "KER";
                else if( value==ImagingModality.LEN )
                    return "LEN";
                else if( value==ImagingModality.MR )
                    return "MR";
                else if( value==ImagingModality.MG )
                    return "MG";
                else if( value==ImagingModality.NM )
                    return "NM";
                else if( value==ImagingModality.OAM )
                    return "OAM";
                else if( value==ImagingModality.OCT )
                    return "OCT";
                else if( value==ImagingModality.OPM )
                    return "OPM";
                else if( value==ImagingModality.OP )
                    return "OP";
                else if( value==ImagingModality.OPR )
                    return "OPR";
                else if( value==ImagingModality.OPT )
                    return "OPT";
                else if( value==ImagingModality.OPV )
                    return "OPV";
                else if( value==ImagingModality.PX )
                    return "PX";
                else if( value==ImagingModality.PT )
                    return "PT";
                else if( value==ImagingModality.RF )
                    return "RF";
                else if( value==ImagingModality.RG )
                    return "RG";
                else if( value==ImagingModality.SM )
                    return "SM";
                else if( value==ImagingModality.SRF )
                    return "SRF";
                else if( value==ImagingModality.US )
                    return "US";
                else if( value==ImagingModality.VA )
                    return "VA";
                else if( value==ImagingModality.XA )
                    return "XA";
                else
                    throw new ArgumentException("Unrecognized ImagingModality value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Availability of the resource
        /// </summary>
        public enum InstanceAvailability
        {
            ONLINE, // Resources are immediately available,.
            OFFLINE, // Resources need to be retrieved by manual intervention.
            NEARLINE, // Resources need to be retrieved from relatively slow media.
            UNAVAILABLE, // Resources cannot be retrieved.
        }
        
        /// <summary>
        /// Conversion of InstanceAvailabilityfrom and into string
        /// <summary>
        public static class InstanceAvailabilityHandling
        {
            public static bool TryParse(string value, out InstanceAvailability result)
            {
                result = default(InstanceAvailability);
                
                if( value=="ONLINE")
                    result = InstanceAvailability.ONLINE;
                else if( value=="OFFLINE")
                    result = InstanceAvailability.OFFLINE;
                else if( value=="NEARLINE")
                    result = InstanceAvailability.NEARLINE;
                else if( value=="UNAVAILABLE")
                    result = InstanceAvailability.UNAVAILABLE;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(InstanceAvailability value)
            {
                if( value==InstanceAvailability.ONLINE )
                    return "ONLINE";
                else if( value==InstanceAvailability.OFFLINE )
                    return "OFFLINE";
                else if( value==InstanceAvailability.NEARLINE )
                    return "NEARLINE";
                else if( value==InstanceAvailability.UNAVAILABLE )
                    return "UNAVAILABLE";
                else
                    throw new ArgumentException("Unrecognized InstanceAvailability value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Type of data in the instance
        /// </summary>
        public enum Modality
        {
            AR,
            AU,
            BDUS,
            BI,
            BMD,
            CR,
            CT,
            DG,
            DX,
            ECG,
            EPS,
            ES,
            GM,
            HC,
            HD,
            IO,
            IVOCT,
            IVUS,
            KER,
            KO,
            LEN,
            LS,
            MG,
            MR,
            NM,
            OAM,
            OCT,
            OP,
            OPM,
            OPT,
            OPV,
            OT,
            PR,
            PT,
            PX,
            REG,
            RF,
            RG,
            RTDOSE,
            RTIMAGE,
            RTPLAN,
            RTRECORD,
            RTSTRUCT,
            SEG,
            SM,
            SMR,
            SR,
            SRF,
            TG,
            US,
            VA,
            XA,
            XC,
        }
        
        /// <summary>
        /// Conversion of Modalityfrom and into string
        /// <summary>
        public static class ModalityHandling
        {
            public static bool TryParse(string value, out Modality result)
            {
                result = default(Modality);
                
                if( value=="AR")
                    result = Modality.AR;
                else if( value=="AU")
                    result = Modality.AU;
                else if( value=="BDUS")
                    result = Modality.BDUS;
                else if( value=="BI")
                    result = Modality.BI;
                else if( value=="BMD")
                    result = Modality.BMD;
                else if( value=="CR")
                    result = Modality.CR;
                else if( value=="CT")
                    result = Modality.CT;
                else if( value=="DG")
                    result = Modality.DG;
                else if( value=="DX")
                    result = Modality.DX;
                else if( value=="ECG")
                    result = Modality.ECG;
                else if( value=="EPS")
                    result = Modality.EPS;
                else if( value=="ES")
                    result = Modality.ES;
                else if( value=="GM")
                    result = Modality.GM;
                else if( value=="HC")
                    result = Modality.HC;
                else if( value=="HD")
                    result = Modality.HD;
                else if( value=="IO")
                    result = Modality.IO;
                else if( value=="IVOCT")
                    result = Modality.IVOCT;
                else if( value=="IVUS")
                    result = Modality.IVUS;
                else if( value=="KER")
                    result = Modality.KER;
                else if( value=="KO")
                    result = Modality.KO;
                else if( value=="LEN")
                    result = Modality.LEN;
                else if( value=="LS")
                    result = Modality.LS;
                else if( value=="MG")
                    result = Modality.MG;
                else if( value=="MR")
                    result = Modality.MR;
                else if( value=="NM")
                    result = Modality.NM;
                else if( value=="OAM")
                    result = Modality.OAM;
                else if( value=="OCT")
                    result = Modality.OCT;
                else if( value=="OP")
                    result = Modality.OP;
                else if( value=="OPM")
                    result = Modality.OPM;
                else if( value=="OPT")
                    result = Modality.OPT;
                else if( value=="OPV")
                    result = Modality.OPV;
                else if( value=="OT")
                    result = Modality.OT;
                else if( value=="PR")
                    result = Modality.PR;
                else if( value=="PT")
                    result = Modality.PT;
                else if( value=="PX")
                    result = Modality.PX;
                else if( value=="REG")
                    result = Modality.REG;
                else if( value=="RF")
                    result = Modality.RF;
                else if( value=="RG")
                    result = Modality.RG;
                else if( value=="RTDOSE")
                    result = Modality.RTDOSE;
                else if( value=="RTIMAGE")
                    result = Modality.RTIMAGE;
                else if( value=="RTPLAN")
                    result = Modality.RTPLAN;
                else if( value=="RTRECORD")
                    result = Modality.RTRECORD;
                else if( value=="RTSTRUCT")
                    result = Modality.RTSTRUCT;
                else if( value=="SEG")
                    result = Modality.SEG;
                else if( value=="SM")
                    result = Modality.SM;
                else if( value=="SMR")
                    result = Modality.SMR;
                else if( value=="SR")
                    result = Modality.SR;
                else if( value=="SRF")
                    result = Modality.SRF;
                else if( value=="TG")
                    result = Modality.TG;
                else if( value=="US")
                    result = Modality.US;
                else if( value=="VA")
                    result = Modality.VA;
                else if( value=="XA")
                    result = Modality.XA;
                else if( value=="XC")
                    result = Modality.XC;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(Modality value)
            {
                if( value==Modality.AR )
                    return "AR";
                else if( value==Modality.AU )
                    return "AU";
                else if( value==Modality.BDUS )
                    return "BDUS";
                else if( value==Modality.BI )
                    return "BI";
                else if( value==Modality.BMD )
                    return "BMD";
                else if( value==Modality.CR )
                    return "CR";
                else if( value==Modality.CT )
                    return "CT";
                else if( value==Modality.DG )
                    return "DG";
                else if( value==Modality.DX )
                    return "DX";
                else if( value==Modality.ECG )
                    return "ECG";
                else if( value==Modality.EPS )
                    return "EPS";
                else if( value==Modality.ES )
                    return "ES";
                else if( value==Modality.GM )
                    return "GM";
                else if( value==Modality.HC )
                    return "HC";
                else if( value==Modality.HD )
                    return "HD";
                else if( value==Modality.IO )
                    return "IO";
                else if( value==Modality.IVOCT )
                    return "IVOCT";
                else if( value==Modality.IVUS )
                    return "IVUS";
                else if( value==Modality.KER )
                    return "KER";
                else if( value==Modality.KO )
                    return "KO";
                else if( value==Modality.LEN )
                    return "LEN";
                else if( value==Modality.LS )
                    return "LS";
                else if( value==Modality.MG )
                    return "MG";
                else if( value==Modality.MR )
                    return "MR";
                else if( value==Modality.NM )
                    return "NM";
                else if( value==Modality.OAM )
                    return "OAM";
                else if( value==Modality.OCT )
                    return "OCT";
                else if( value==Modality.OP )
                    return "OP";
                else if( value==Modality.OPM )
                    return "OPM";
                else if( value==Modality.OPT )
                    return "OPT";
                else if( value==Modality.OPV )
                    return "OPV";
                else if( value==Modality.OT )
                    return "OT";
                else if( value==Modality.PR )
                    return "PR";
                else if( value==Modality.PT )
                    return "PT";
                else if( value==Modality.PX )
                    return "PX";
                else if( value==Modality.REG )
                    return "REG";
                else if( value==Modality.RF )
                    return "RF";
                else if( value==Modality.RG )
                    return "RG";
                else if( value==Modality.RTDOSE )
                    return "RTDOSE";
                else if( value==Modality.RTIMAGE )
                    return "RTIMAGE";
                else if( value==Modality.RTPLAN )
                    return "RTPLAN";
                else if( value==Modality.RTRECORD )
                    return "RTRECORD";
                else if( value==Modality.RTSTRUCT )
                    return "RTSTRUCT";
                else if( value==Modality.SEG )
                    return "SEG";
                else if( value==Modality.SM )
                    return "SM";
                else if( value==Modality.SMR )
                    return "SMR";
                else if( value==Modality.SR )
                    return "SR";
                else if( value==Modality.SRF )
                    return "SRF";
                else if( value==Modality.TG )
                    return "TG";
                else if( value==Modality.US )
                    return "US";
                else if( value==Modality.VA )
                    return "VA";
                else if( value==Modality.XA )
                    return "XA";
                else if( value==Modality.XC )
                    return "XC";
                else
                    throw new ArgumentException("Unrecognized Modality value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImagingStudySeriesComponent")]
        [Serializable]
        public partial class ImagingStudySeriesComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Number of this series in overall sequence (0020,0011)
            /// </summary>
            public Hl7.Fhir.Model.Integer NumberElement { get; set; }
            
            public int? Number
            {
                get { return NumberElement != null ? NumberElement.Value : null; }
                set
                {
                    if(value == null)
                      NumberElement = null; 
                    else
                      NumberElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// The modality of this sequence (0008,0060)
            /// </summary>
            public Code<Hl7.Fhir.Model.ImagingStudy.Modality> ModalityElement { get; set; }
            
            public Hl7.Fhir.Model.ImagingStudy.Modality? Modality
            {
                get { return ModalityElement != null ? ModalityElement.Value : null; }
                set
                {
                    if(value == null)
                      ModalityElement = null; 
                    else
                      ModalityElement = new Code<Hl7.Fhir.Model.ImagingStudy.Modality>(value);
                }
            }
            
            /// <summary>
            /// Formal identifier for this series (0020,000E)
            /// </summary>
            public Hl7.Fhir.Model.Oid UidElement { get; set; }
            
            public string Uid
            {
                get { return UidElement != null ? UidElement.Value : null; }
                set
                {
                    if(value == null)
                      UidElement = null; 
                    else
                      UidElement = new Hl7.Fhir.Model.Oid(value);
                }
            }
            
            /// <summary>
            /// A description of the series (0008,103E)
            /// </summary>
            public Hl7.Fhir.Model.FhirString DescriptionElement { get; set; }
            
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Number of Series Related Instances (0020,1209)
            /// </summary>
            public Hl7.Fhir.Model.Integer NumberOfInstancesElement { get; set; }
            
            public int? NumberOfInstances
            {
                get { return NumberOfInstancesElement != null ? NumberOfInstancesElement.Value : null; }
                set
                {
                    if(value == null)
                      NumberOfInstancesElement = null; 
                    else
                      NumberOfInstancesElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Instance Availability (0008,0056)
            /// </summary>
            public Code<Hl7.Fhir.Model.ImagingStudy.InstanceAvailability> AvailabilityElement { get; set; }
            
            public Hl7.Fhir.Model.ImagingStudy.InstanceAvailability? Availability
            {
                get { return AvailabilityElement != null ? AvailabilityElement.Value : null; }
                set
                {
                    if(value == null)
                      AvailabilityElement = null; 
                    else
                      AvailabilityElement = new Code<Hl7.Fhir.Model.ImagingStudy.InstanceAvailability>(value);
                }
            }
            
            /// <summary>
            /// Retrieve URI (0040,E010)
            /// </summary>
            public Hl7.Fhir.Model.FhirUri UrlElement { get; set; }
            
            public System.Uri Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if(value == null)
                      UrlElement = null; 
                    else
                      UrlElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// Body part examined (Map from 0018,0015)
            /// </summary>
            public Hl7.Fhir.Model.Coding BodySite { get; set; }
            
            /// <summary>
            /// When the series started
            /// </summary>
            public Hl7.Fhir.Model.FhirDateTime DateTimeElement { get; set; }
            
            public string DateTime
            {
                get { return DateTimeElement != null ? DateTimeElement.Value : null; }
                set
                {
                    if(value == null)
                      DateTimeElement = null; 
                    else
                      DateTimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
                }
            }
            
            /// <summary>
            /// A single instance taken from a patient (image or other)
            /// </summary>
            public List<Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesInstanceComponent> Instance { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(NumberElement != null )
                    result.AddRange(NumberElement.Validate());
                if(ModalityElement != null )
                    result.AddRange(ModalityElement.Validate());
                if(UidElement != null )
                    result.AddRange(UidElement.Validate());
                if(DescriptionElement != null )
                    result.AddRange(DescriptionElement.Validate());
                if(NumberOfInstancesElement != null )
                    result.AddRange(NumberOfInstancesElement.Validate());
                if(AvailabilityElement != null )
                    result.AddRange(AvailabilityElement.Validate());
                if(UrlElement != null )
                    result.AddRange(UrlElement.Validate());
                if(BodySite != null )
                    result.AddRange(BodySite.Validate());
                if(DateTimeElement != null )
                    result.AddRange(DateTimeElement.Validate());
                if(Instance != null )
                    Instance.ForEach(elem => result.AddRange(elem.Validate()));
                
                return result;
            }
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImagingStudySeriesInstanceComponent")]
        [Serializable]
        public partial class ImagingStudySeriesInstanceComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// The number of this instance in the series (0020,0013)
            /// </summary>
            public Hl7.Fhir.Model.Integer NumberElement { get; set; }
            
            public int? Number
            {
                get { return NumberElement != null ? NumberElement.Value : null; }
                set
                {
                    if(value == null)
                      NumberElement = null; 
                    else
                      NumberElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Formal identifier for this instance (0008,0018)
            /// </summary>
            public Hl7.Fhir.Model.Oid UidElement { get; set; }
            
            public string Uid
            {
                get { return UidElement != null ? UidElement.Value : null; }
                set
                {
                    if(value == null)
                      UidElement = null; 
                    else
                      UidElement = new Hl7.Fhir.Model.Oid(value);
                }
            }
            
            /// <summary>
            /// DICOM class type (0008,0016)
            /// </summary>
            public Hl7.Fhir.Model.Oid SopclassElement { get; set; }
            
            public string Sopclass
            {
                get { return SopclassElement != null ? SopclassElement.Value : null; }
                set
                {
                    if(value == null)
                      SopclassElement = null; 
                    else
                      SopclassElement = new Hl7.Fhir.Model.Oid(value);
                }
            }
            
            /// <summary>
            /// Type of instance (0004,1430)
            /// </summary>
            public Hl7.Fhir.Model.FhirString TypeElement { get; set; }
            
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// Description to be provided
            /// </summary>
            public Hl7.Fhir.Model.FhirString TitleElement { get; set; }
            
            public string Title
            {
                get { return TitleElement != null ? TitleElement.Value : null; }
                set
                {
                    if(value == null)
                      TitleElement = null; 
                    else
                      TitleElement = new Hl7.Fhir.Model.FhirString(value);
                }
            }
            
            /// <summary>
            /// WADO / WADO-RS service where instance is available
            /// </summary>
            public Hl7.Fhir.Model.FhirUri UrlElement { get; set; }
            
            public System.Uri Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if(value == null)
                      UrlElement = null; 
                    else
                      UrlElement = new Hl7.Fhir.Model.FhirUri(value);
                }
            }
            
            /// <summary>
            /// A FHIR resource with content for this instance
            /// </summary>
            public Hl7.Fhir.Model.ResourceReference Attachment { get; set; }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(NumberElement != null )
                    result.AddRange(NumberElement.Validate());
                if(UidElement != null )
                    result.AddRange(UidElement.Validate());
                if(SopclassElement != null )
                    result.AddRange(SopclassElement.Validate());
                if(TypeElement != null )
                    result.AddRange(TypeElement.Validate());
                if(TitleElement != null )
                    result.AddRange(TitleElement.Validate());
                if(UrlElement != null )
                    result.AddRange(UrlElement.Validate());
                if(Attachment != null )
                    result.AddRange(Attachment.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// When the study was performed
        /// </summary>
        public Hl7.Fhir.Model.FhirDateTime DateTimeElement { get; set; }
        
        public string DateTime
        {
            get { return DateTimeElement != null ? DateTimeElement.Value : null; }
            set
            {
                if(value == null)
                  DateTimeElement = null; 
                else
                  DateTimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
            }
        }
        
        /// <summary>
        /// Who the images are of
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Formal identifier for the study (0020,000D)
        /// </summary>
        public Hl7.Fhir.Model.Oid UidElement { get; set; }
        
        public string Uid
        {
            get { return UidElement != null ? UidElement.Value : null; }
            set
            {
                if(value == null)
                  UidElement = null; 
                else
                  UidElement = new Hl7.Fhir.Model.Oid(value);
            }
        }
        
        /// <summary>
        /// Accession Number (0008,0050)
        /// </summary>
        public Hl7.Fhir.Model.Identifier AccessionNo { get; set; }
        
        /// <summary>
        /// Other identifiers for the study (0020,0010)
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// All series.modality if actual acquisition modalities
        /// </summary>
        public List<Code<Hl7.Fhir.Model.ImagingStudy.ImagingModality>> Modality_Element { get; set; }
        
        public IEnumerable<Hl7.Fhir.Model.ImagingStudy.ImagingModality?> Modality_
        {
            get { return Modality_Element != null ? Modality_Element.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  Modality_Element = null; 
                else
                  Modality_Element = new List<Code<Hl7.Fhir.Model.ImagingStudy.ImagingModality>>(value.Select(elem=>new Code<Hl7.Fhir.Model.ImagingStudy.ImagingModality>(elem)));
            }
        }
        
        /// <summary>
        /// Referring physician (0008,0090)
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Referrer { get; set; }
        
        /// <summary>
        /// Instance Availability (0008,0056)
        /// </summary>
        public Code<Hl7.Fhir.Model.ImagingStudy.InstanceAvailability> AvailabilityElement { get; set; }
        
        public Hl7.Fhir.Model.ImagingStudy.InstanceAvailability? Availability
        {
            get { return AvailabilityElement != null ? AvailabilityElement.Value : null; }
            set
            {
                if(value == null)
                  AvailabilityElement = null; 
                else
                  AvailabilityElement = new Code<Hl7.Fhir.Model.ImagingStudy.InstanceAvailability>(value);
            }
        }
        
        /// <summary>
        /// Retrieve URI (0040,E010)
        /// </summary>
        public Hl7.Fhir.Model.FhirUri UrlElement { get; set; }
        
        public System.Uri Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if(value == null)
                  UrlElement = null; 
                else
                  UrlElement = new Hl7.Fhir.Model.FhirUri(value);
            }
        }
        
        /// <summary>
        /// Number of Study Related Series (0020,1206)
        /// </summary>
        public Hl7.Fhir.Model.Integer NumberOfSeriesElement { get; set; }
        
        public int? NumberOfSeries
        {
            get { return NumberOfSeriesElement != null ? NumberOfSeriesElement.Value : null; }
            set
            {
                if(value == null)
                  NumberOfSeriesElement = null; 
                else
                  NumberOfSeriesElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Number of Study Related Instances (0020,1208)
        /// </summary>
        public Hl7.Fhir.Model.Integer NumberOfInstancesElement { get; set; }
        
        public int? NumberOfInstances
        {
            get { return NumberOfInstancesElement != null ? NumberOfInstancesElement.Value : null; }
            set
            {
                if(value == null)
                  NumberOfInstancesElement = null; 
                else
                  NumberOfInstancesElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Diagnoses etc with request (0008,1080)
        /// </summary>
        public Hl7.Fhir.Model.FhirString ClinicalInformationElement { get; set; }
        
        public string ClinicalInformation
        {
            get { return ClinicalInformationElement != null ? ClinicalInformationElement.Value : null; }
            set
            {
                if(value == null)
                  ClinicalInformationElement = null; 
                else
                  ClinicalInformationElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Type of procedure performed (0008,1032)
        /// </summary>
        public List<Hl7.Fhir.Model.Coding> Procedure { get; set; }
        
        /// <summary>
        /// Who interpreted images (0008,1060)
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Interpreter { get; set; }
        
        /// <summary>
        /// Institution-generated description (0008,1030)
        /// </summary>
        public Hl7.Fhir.Model.FhirString DescriptionElement { get; set; }
        
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Each study has one or more series of instances
        /// </summary>
        public List<Hl7.Fhir.Model.ImagingStudy.ImagingStudySeriesComponent> Series { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(DateTimeElement != null )
                result.AddRange(DateTimeElement.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(UidElement != null )
                result.AddRange(UidElement.Validate());
            if(AccessionNo != null )
                result.AddRange(AccessionNo.Validate());
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(Modality_Element != null )
                Modality_Element.ForEach(elem => result.AddRange(elem.Validate()));
            if(Referrer != null )
                result.AddRange(Referrer.Validate());
            if(AvailabilityElement != null )
                result.AddRange(AvailabilityElement.Validate());
            if(UrlElement != null )
                result.AddRange(UrlElement.Validate());
            if(NumberOfSeriesElement != null )
                result.AddRange(NumberOfSeriesElement.Validate());
            if(NumberOfInstancesElement != null )
                result.AddRange(NumberOfInstancesElement.Validate());
            if(ClinicalInformationElement != null )
                result.AddRange(ClinicalInformationElement.Validate());
            if(Procedure != null )
                Procedure.ForEach(elem => result.AddRange(elem.Validate()));
            if(Interpreter != null )
                result.AddRange(Interpreter.Validate());
            if(DescriptionElement != null )
                result.AddRange(DescriptionElement.Validate());
            if(Series != null )
                Series.ForEach(elem => result.AddRange(elem.Validate()));
            
            return result;
        }
    }
    
}
