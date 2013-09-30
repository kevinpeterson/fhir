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
// Generated on Thu, Aug 8, 2013 08:48+1000 for FHIR v0.10
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// An Image used in healthcare. The actual pixels maybe inline or provided by direct reference
    /// </summary>
    [FhirResource("Picture")]
    [Serializable]
    public partial class Picture : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// The type of image in the picture
        /// </summary>
        public enum PictureType
        {
            DIA, // Hand-drawn diagram.
            AR, // Autorefraction.
            AU, // Audio.
            BDUS, // Bone Densitometry (Ultrasound).
            BI, // Biomagnetic Imaging.
            BMD, // Bone Densitometry (X-Ray).
            CR, // Computed Radiography.
            CT, // Computed Tomography.
            DG, // Diaphanography.
            DOC, // Document.
            DX, // Digital Radiography.
            ECG, // Electrocardiograms.
            EM, // Electron Microscope.
            EPS, // Cardiac Electrophysiology.
            ES, // Endoscopy.
            FID, // Fiducials.
            GM, // General Microscopy.
            HC, // Hard Copy.
            HD, // Hemodynamic Waveform.
            IO, // Intra-oral Radiography.
            IOL, // Intraocular Lens Data.
            IVOCT, // Intravascular Optical Coherence Tomography.
            IVUS, // Intravascular Ultrasound.
            KO, // Key Object Selection.
            KER, // Keratometry.
            LEN, // Lensometry.
            LS, // Laser Surface Scan.
            MG, // Mammography.
            MR, // Magnetic Resonance.
            NM, // Nuclear Medicine.
            OAM, // Opthalmic Axial Measurements.
            OCT, // Optical Coherence Tomography.
            OPM, // Ophthalmic Mapping.
            OPT, // Opthalmic Tomography.
            OPV, // Ophthalmic Visual Field.
            OT, // Other.
            PLAN, // Plan.
            PR, // Presentation State.
            PT, // Positron Emission Tomography (PET).
            PX, // Panoramic X-Ray.
            REG, // Registration.
            RESP, // Respiratory Waveform.
            RF, // Radio Fluoroscopy.
            RG, // Radiographic Imaging (conventional film screen).
            RTDOSE, // Radiotherapy Dose.
            RTIMAGE, // Radiotherapy Image.
            RTPLAN, // Radiotherapy Plan (a.k.a. RTPLAN).
            RTRECORD, // RT Treatment Record.
            RTSTRUCT, // Radiotherapy Structure Set (a.k.a. RTSTRUCT).
            SC, // Secondary Capture.
            SEG, // Segmentation.
            SM, // Slide Microscopy.
            SMR, // Stereometric Relationship.
            SR, // SR Document.
            SRF, // Subjective Refraction.
            TG, // Thermography.
            US, // Ultrasound.
            VA, // Visual Acuity.
            VL, // Visible Light.
            XA, // X-Ray Angiography.
            XC, // External Camera (Photography).
        }
        
        /// <summary>
        /// Conversion of PictureTypefrom and into string
        /// <summary>
        public static class PictureTypeHandling
        {
            public static bool TryParse(string value, out PictureType result)
            {
                result = default(PictureType);
                
                if( value=="DIA")
                    result = PictureType.DIA;
                else if( value=="AR")
                    result = PictureType.AR;
                else if( value=="AU")
                    result = PictureType.AU;
                else if( value=="BDUS")
                    result = PictureType.BDUS;
                else if( value=="BI")
                    result = PictureType.BI;
                else if( value=="BMD")
                    result = PictureType.BMD;
                else if( value=="CR")
                    result = PictureType.CR;
                else if( value=="CT")
                    result = PictureType.CT;
                else if( value=="DG")
                    result = PictureType.DG;
                else if( value=="DOC")
                    result = PictureType.DOC;
                else if( value=="DX")
                    result = PictureType.DX;
                else if( value=="ECG")
                    result = PictureType.ECG;
                else if( value=="EM")
                    result = PictureType.EM;
                else if( value=="EPS")
                    result = PictureType.EPS;
                else if( value=="ES")
                    result = PictureType.ES;
                else if( value=="FID")
                    result = PictureType.FID;
                else if( value=="GM")
                    result = PictureType.GM;
                else if( value=="HC")
                    result = PictureType.HC;
                else if( value=="HD")
                    result = PictureType.HD;
                else if( value=="IO")
                    result = PictureType.IO;
                else if( value=="IOL")
                    result = PictureType.IOL;
                else if( value=="IVOCT")
                    result = PictureType.IVOCT;
                else if( value=="IVUS")
                    result = PictureType.IVUS;
                else if( value=="KO")
                    result = PictureType.KO;
                else if( value=="KER")
                    result = PictureType.KER;
                else if( value=="LEN")
                    result = PictureType.LEN;
                else if( value=="LS")
                    result = PictureType.LS;
                else if( value=="MG")
                    result = PictureType.MG;
                else if( value=="MR")
                    result = PictureType.MR;
                else if( value=="NM")
                    result = PictureType.NM;
                else if( value=="OAM")
                    result = PictureType.OAM;
                else if( value=="OCT")
                    result = PictureType.OCT;
                else if( value=="OPM")
                    result = PictureType.OPM;
                else if( value=="OPT")
                    result = PictureType.OPT;
                else if( value=="OPV")
                    result = PictureType.OPV;
                else if( value=="OT")
                    result = PictureType.OT;
                else if( value=="PLAN")
                    result = PictureType.PLAN;
                else if( value=="PR")
                    result = PictureType.PR;
                else if( value=="PT")
                    result = PictureType.PT;
                else if( value=="PX")
                    result = PictureType.PX;
                else if( value=="REG")
                    result = PictureType.REG;
                else if( value=="RESP")
                    result = PictureType.RESP;
                else if( value=="RF")
                    result = PictureType.RF;
                else if( value=="RG")
                    result = PictureType.RG;
                else if( value=="RTDOSE")
                    result = PictureType.RTDOSE;
                else if( value=="RTIMAGE")
                    result = PictureType.RTIMAGE;
                else if( value=="RTPLAN")
                    result = PictureType.RTPLAN;
                else if( value=="RTRECORD")
                    result = PictureType.RTRECORD;
                else if( value=="RTSTRUCT")
                    result = PictureType.RTSTRUCT;
                else if( value=="SC")
                    result = PictureType.SC;
                else if( value=="SEG")
                    result = PictureType.SEG;
                else if( value=="SM")
                    result = PictureType.SM;
                else if( value=="SMR")
                    result = PictureType.SMR;
                else if( value=="SR")
                    result = PictureType.SR;
                else if( value=="SRF")
                    result = PictureType.SRF;
                else if( value=="TG")
                    result = PictureType.TG;
                else if( value=="US")
                    result = PictureType.US;
                else if( value=="VA")
                    result = PictureType.VA;
                else if( value=="VL")
                    result = PictureType.VL;
                else if( value=="XA")
                    result = PictureType.XA;
                else if( value=="XC")
                    result = PictureType.XC;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(PictureType value)
            {
                if( value==PictureType.DIA )
                    return "DIA";
                else if( value==PictureType.AR )
                    return "AR";
                else if( value==PictureType.AU )
                    return "AU";
                else if( value==PictureType.BDUS )
                    return "BDUS";
                else if( value==PictureType.BI )
                    return "BI";
                else if( value==PictureType.BMD )
                    return "BMD";
                else if( value==PictureType.CR )
                    return "CR";
                else if( value==PictureType.CT )
                    return "CT";
                else if( value==PictureType.DG )
                    return "DG";
                else if( value==PictureType.DOC )
                    return "DOC";
                else if( value==PictureType.DX )
                    return "DX";
                else if( value==PictureType.ECG )
                    return "ECG";
                else if( value==PictureType.EM )
                    return "EM";
                else if( value==PictureType.EPS )
                    return "EPS";
                else if( value==PictureType.ES )
                    return "ES";
                else if( value==PictureType.FID )
                    return "FID";
                else if( value==PictureType.GM )
                    return "GM";
                else if( value==PictureType.HC )
                    return "HC";
                else if( value==PictureType.HD )
                    return "HD";
                else if( value==PictureType.IO )
                    return "IO";
                else if( value==PictureType.IOL )
                    return "IOL";
                else if( value==PictureType.IVOCT )
                    return "IVOCT";
                else if( value==PictureType.IVUS )
                    return "IVUS";
                else if( value==PictureType.KO )
                    return "KO";
                else if( value==PictureType.KER )
                    return "KER";
                else if( value==PictureType.LEN )
                    return "LEN";
                else if( value==PictureType.LS )
                    return "LS";
                else if( value==PictureType.MG )
                    return "MG";
                else if( value==PictureType.MR )
                    return "MR";
                else if( value==PictureType.NM )
                    return "NM";
                else if( value==PictureType.OAM )
                    return "OAM";
                else if( value==PictureType.OCT )
                    return "OCT";
                else if( value==PictureType.OPM )
                    return "OPM";
                else if( value==PictureType.OPT )
                    return "OPT";
                else if( value==PictureType.OPV )
                    return "OPV";
                else if( value==PictureType.OT )
                    return "OT";
                else if( value==PictureType.PLAN )
                    return "PLAN";
                else if( value==PictureType.PR )
                    return "PR";
                else if( value==PictureType.PT )
                    return "PT";
                else if( value==PictureType.PX )
                    return "PX";
                else if( value==PictureType.REG )
                    return "REG";
                else if( value==PictureType.RESP )
                    return "RESP";
                else if( value==PictureType.RF )
                    return "RF";
                else if( value==PictureType.RG )
                    return "RG";
                else if( value==PictureType.RTDOSE )
                    return "RTDOSE";
                else if( value==PictureType.RTIMAGE )
                    return "RTIMAGE";
                else if( value==PictureType.RTPLAN )
                    return "RTPLAN";
                else if( value==PictureType.RTRECORD )
                    return "RTRECORD";
                else if( value==PictureType.RTSTRUCT )
                    return "RTSTRUCT";
                else if( value==PictureType.SC )
                    return "SC";
                else if( value==PictureType.SEG )
                    return "SEG";
                else if( value==PictureType.SM )
                    return "SM";
                else if( value==PictureType.SMR )
                    return "SMR";
                else if( value==PictureType.SR )
                    return "SR";
                else if( value==PictureType.SRF )
                    return "SRF";
                else if( value==PictureType.TG )
                    return "TG";
                else if( value==PictureType.US )
                    return "US";
                else if( value==PictureType.VA )
                    return "VA";
                else if( value==PictureType.VL )
                    return "VL";
                else if( value==PictureType.XA )
                    return "XA";
                else if( value==PictureType.XC )
                    return "XC";
                else
                    throw new ArgumentException("Unrecognized PictureType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Who/What this image is taken of
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// When the image was taken
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
        /// The person who generated the image
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Operator { get; set; }
        
        /// <summary>
        /// Identifier for the image
        /// </summary>
        public Hl7.Fhir.Model.Identifier Identifier { get; set; }
        
        /// <summary>
        /// Used by the requester to link back to the original context
        /// </summary>
        public Hl7.Fhir.Model.Identifier AccessionNo { get; set; }
        
        /// <summary>
        /// The session in which the picture was taken
        /// </summary>
        public Hl7.Fhir.Model.Identifier StudyId { get; set; }
        
        /// <summary>
        /// The series of images in which this picture was taken
        /// </summary>
        public Hl7.Fhir.Model.Identifier SeriesId { get; set; }
        
        /// <summary>
        /// How the image was taken
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Method { get; set; }
        
        /// <summary>
        /// Who asked that this image be collected
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Requester { get; set; }
        
        /// <summary>
        /// Type of the image capturing machinery
        /// </summary>
        public Code<Hl7.Fhir.Model.Picture.PictureType> ModalityElement { get; set; }
        
        public Hl7.Fhir.Model.Picture.PictureType? Modality
        {
            get { return ModalityElement != null ? ModalityElement.Value : null; }
            set
            {
                if(value == null)
                  ModalityElement = null; 
                else
                  ModalityElement = new Code<Hl7.Fhir.Model.Picture.PictureType>(value);
            }
        }
        
        /// <summary>
        /// Name of the manufacturer
        /// </summary>
        public Hl7.Fhir.Model.FhirString DeviceNameElement { get; set; }
        
        public string DeviceName
        {
            get { return DeviceNameElement != null ? DeviceNameElement.Value : null; }
            set
            {
                if(value == null)
                  DeviceNameElement = null; 
                else
                  DeviceNameElement = new Hl7.Fhir.Model.FhirString(value);
            }
        }
        
        /// <summary>
        /// Height of the image
        /// </summary>
        public Hl7.Fhir.Model.Integer HeightElement { get; set; }
        
        public int? Height
        {
            get { return HeightElement != null ? HeightElement.Value : null; }
            set
            {
                if(value == null)
                  HeightElement = null; 
                else
                  HeightElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Width of the image
        /// </summary>
        public Hl7.Fhir.Model.Integer WidthElement { get; set; }
        
        public int? Width
        {
            get { return WidthElement != null ? WidthElement.Value : null; }
            set
            {
                if(value == null)
                  WidthElement = null; 
                else
                  WidthElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Number of bits of colour (2..32)
        /// </summary>
        public Hl7.Fhir.Model.Integer BitsElement { get; set; }
        
        public int? Bits
        {
            get { return BitsElement != null ? BitsElement.Value : null; }
            set
            {
                if(value == null)
                  BitsElement = null; 
                else
                  BitsElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Number of frames
        /// </summary>
        public Hl7.Fhir.Model.Integer FramesElement { get; set; }
        
        public int? Frames
        {
            get { return FramesElement != null ? FramesElement.Value : null; }
            set
            {
                if(value == null)
                  FramesElement = null; 
                else
                  FramesElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Length of time between frames
        /// </summary>
        public Hl7.Fhir.Model.Duration FrameDelay { get; set; }
        
        /// <summary>
        /// Imaging view e.g Lateral or Antero-posterior (AP)
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept View { get; set; }
        
        /// <summary>
        /// Actual picture - reference or data
        /// </summary>
        public Hl7.Fhir.Model.Attachment Content { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(DateTimeElement != null )
                result.AddRange(DateTimeElement.Validate());
            if(Operator != null )
                result.AddRange(Operator.Validate());
            if(Identifier != null )
                result.AddRange(Identifier.Validate());
            if(AccessionNo != null )
                result.AddRange(AccessionNo.Validate());
            if(StudyId != null )
                result.AddRange(StudyId.Validate());
            if(SeriesId != null )
                result.AddRange(SeriesId.Validate());
            if(Method != null )
                result.AddRange(Method.Validate());
            if(Requester != null )
                result.AddRange(Requester.Validate());
            if(ModalityElement != null )
                result.AddRange(ModalityElement.Validate());
            if(DeviceNameElement != null )
                result.AddRange(DeviceNameElement.Validate());
            if(HeightElement != null )
                result.AddRange(HeightElement.Validate());
            if(WidthElement != null )
                result.AddRange(WidthElement.Validate());
            if(BitsElement != null )
                result.AddRange(BitsElement.Validate());
            if(FramesElement != null )
                result.AddRange(FramesElement.Validate());
            if(FrameDelay != null )
                result.AddRange(FrameDelay.Validate());
            if(View != null )
                result.AddRange(View.Validate());
            if(Content != null )
                result.AddRange(Content.Validate());
            
            return result;
        }
    }
    
}
