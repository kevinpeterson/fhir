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
// Generated on Wed, Oct 2, 2013 07:37+1000 for FHIR v0.11
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A photo, video, or audio recording acquired or used in healthcare. The actual content maybe inline or provided by direct reference
    /// </summary>
    [FhirResource("Media")]
    [Serializable]
    public partial class Media : Hl7.Fhir.Model.Resource
    {
        /// <summary>
        /// Whether the Media is a photo, video, or audio
        /// </summary>
        public enum MediaType
        {
            Photo, // The media consists of one or more unmoving images.
            Video, // The media consists of a series of frames that capture a moving image.
            Audio, // The media consists of a sound recording.
        }
        
        /// <summary>
        /// Conversion of MediaTypefrom and into string
        /// <summary>
        public static class MediaTypeHandling
        {
            public static bool TryParse(string value, out MediaType result)
            {
                result = default(MediaType);
                
                if( value=="photo")
                    result = MediaType.Photo;
                else if( value=="video")
                    result = MediaType.Video;
                else if( value=="audio")
                    result = MediaType.Audio;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(MediaType value)
            {
                if( value==MediaType.Photo )
                    return "photo";
                else if( value==MediaType.Video )
                    return "video";
                else if( value==MediaType.Audio )
                    return "audio";
                else
                    throw new ArgumentException("Unrecognized MediaType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// photo | audio | video
        /// </summary>
        public Code<Hl7.Fhir.Model.Media.MediaType> TypeElement { get; set; }
        
        public Hl7.Fhir.Model.Media.MediaType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if(value == null)
                  TypeElement = null; 
                else
                  TypeElement = new Code<Hl7.Fhir.Model.Media.MediaType>(value);
            }
        }
        
        /// <summary>
        /// The type of acquisition equipment/process
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept Subtype { get; set; }
        
        /// <summary>
        /// Identifier(s) for the image
        /// </summary>
        public List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
        
        /// <summary>
        /// When the media was taken/recorded
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
        /// Who/What this Media is a record of
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Who asked that this image be collected
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Requester { get; set; }
        
        /// <summary>
        /// The person who generated the image
        /// </summary>
        public Hl7.Fhir.Model.ResourceReference Operator { get; set; }
        
        /// <summary>
        /// Imaging view e.g Lateral or Antero-posterior
        /// </summary>
        public Hl7.Fhir.Model.CodeableConcept View { get; set; }
        
        /// <summary>
        /// Name of the device/manufacturer
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
        /// Height of the image in pixels(photo/video)
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
        /// Width of the image in pixels (photo/video)
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
        /// Number of frames if > 1 (photo)
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
        /// Length in seconds (audio / video)
        /// </summary>
        public Hl7.Fhir.Model.Integer LengthElement { get; set; }
        
        public int? Length
        {
            get { return LengthElement != null ? LengthElement.Value : null; }
            set
            {
                if(value == null)
                  LengthElement = null; 
                else
                  LengthElement = new Hl7.Fhir.Model.Integer(value);
            }
        }
        
        /// <summary>
        /// Actual Media - reference or data
        /// </summary>
        public Hl7.Fhir.Model.Attachment Content { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(TypeElement != null )
                result.AddRange(TypeElement.Validate());
            if(Subtype != null )
                result.AddRange(Subtype.Validate());
            if(Identifier != null )
                Identifier.ForEach(elem => result.AddRange(elem.Validate()));
            if(DateTimeElement != null )
                result.AddRange(DateTimeElement.Validate());
            if(Subject != null )
                result.AddRange(Subject.Validate());
            if(Requester != null )
                result.AddRange(Requester.Validate());
            if(Operator != null )
                result.AddRange(Operator.Validate());
            if(View != null )
                result.AddRange(View.Validate());
            if(DeviceNameElement != null )
                result.AddRange(DeviceNameElement.Validate());
            if(HeightElement != null )
                result.AddRange(HeightElement.Validate());
            if(WidthElement != null )
                result.AddRange(WidthElement.Validate());
            if(FramesElement != null )
                result.AddRange(FramesElement.Validate());
            if(LengthElement != null )
                result.AddRange(LengthElement.Validate());
            if(Content != null )
                result.AddRange(Content.Validate());
            
            return result;
        }
    }
    
}
