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
    /// A schedule that specifies an event that may occur multiple times
    /// </summary>
    [FhirComposite("Schedule")]
    [Serializable]
    public partial class Schedule : Hl7.Fhir.Model.Element
    {
        /// <summary>
        /// A unit of time (units from UCUM)
        /// </summary>
        public enum UnitsOfTime
        {
            S, // second.
            Min, // minute.
            H, // hour.
            D, // day.
            Wk, // week.
            Mo, // month.
            A, // year.
        }
        
        /// <summary>
        /// Conversion of UnitsOfTimefrom and into string
        /// <summary>
        public static class UnitsOfTimeHandling
        {
            public static bool TryParse(string value, out UnitsOfTime result)
            {
                result = default(UnitsOfTime);
                
                if( value=="s")
                    result = UnitsOfTime.S;
                else if( value=="min")
                    result = UnitsOfTime.Min;
                else if( value=="h")
                    result = UnitsOfTime.H;
                else if( value=="d")
                    result = UnitsOfTime.D;
                else if( value=="wk")
                    result = UnitsOfTime.Wk;
                else if( value=="mo")
                    result = UnitsOfTime.Mo;
                else if( value=="a")
                    result = UnitsOfTime.A;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(UnitsOfTime value)
            {
                if( value==UnitsOfTime.S )
                    return "s";
                else if( value==UnitsOfTime.Min )
                    return "min";
                else if( value==UnitsOfTime.H )
                    return "h";
                else if( value==UnitsOfTime.D )
                    return "d";
                else if( value==UnitsOfTime.Wk )
                    return "wk";
                else if( value==UnitsOfTime.Mo )
                    return "mo";
                else if( value==UnitsOfTime.A )
                    return "a";
                else
                    throw new ArgumentException("Unrecognized UnitsOfTime value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Real world event that the schedule relates to
        /// </summary>
        public enum EventTiming
        {
            HS, // event occurs [duration] before the hour of sleep (or trying to).
            WAKE, // event occurs [duration] after waking.
            AC, // event occurs [duration] before a meal (from the Latin ante cibus).
            ACM, // event occurs [duration] before breakfast (from the Latin ante cibus matutinus).
            ACD, // event occurs [duration] before lunch (from the Latin ante cibus diurnus).
            ACV, // event occurs [duration] before dinner (from the Latin ante cibus vespertinus).
            PC, // event occurs [duration] after a meal (from the Latin post cibus).
            PCM, // event occurs [duration] after breakfast (from the Latin post cibus matutinus).
            PCD, // event occurs [duration] after lunch (from the Latin post cibus diurnus).
            PCV, // event occurs [duration] after dinner (from the Latin post cibus vespertinus).
        }
        
        /// <summary>
        /// Conversion of EventTimingfrom and into string
        /// <summary>
        public static class EventTimingHandling
        {
            public static bool TryParse(string value, out EventTiming result)
            {
                result = default(EventTiming);
                
                if( value=="HS")
                    result = EventTiming.HS;
                else if( value=="WAKE")
                    result = EventTiming.WAKE;
                else if( value=="AC")
                    result = EventTiming.AC;
                else if( value=="ACM")
                    result = EventTiming.ACM;
                else if( value=="ACD")
                    result = EventTiming.ACD;
                else if( value=="ACV")
                    result = EventTiming.ACV;
                else if( value=="PC")
                    result = EventTiming.PC;
                else if( value=="PCM")
                    result = EventTiming.PCM;
                else if( value=="PCD")
                    result = EventTiming.PCD;
                else if( value=="PCV")
                    result = EventTiming.PCV;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(EventTiming value)
            {
                if( value==EventTiming.HS )
                    return "HS";
                else if( value==EventTiming.WAKE )
                    return "WAKE";
                else if( value==EventTiming.AC )
                    return "AC";
                else if( value==EventTiming.ACM )
                    return "ACM";
                else if( value==EventTiming.ACD )
                    return "ACD";
                else if( value==EventTiming.ACV )
                    return "ACV";
                else if( value==EventTiming.PC )
                    return "PC";
                else if( value==EventTiming.PCM )
                    return "PCM";
                else if( value==EventTiming.PCD )
                    return "PCD";
                else if( value==EventTiming.PCV )
                    return "PCV";
                else
                    throw new ArgumentException("Unrecognized EventTiming value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ScheduleRepeatComponent")]
        [Serializable]
        public partial class ScheduleRepeatComponent : Hl7.Fhir.Model.Element
        {
            /// <summary>
            /// Event occurs frequency times per duration
            /// </summary>
            public Hl7.Fhir.Model.Integer FrequencyElement { get; set; }
            
            public int? Frequency
            {
                get { return FrequencyElement != null ? FrequencyElement.Value : null; }
                set
                {
                    if(value == null)
                      FrequencyElement = null; 
                    else
                      FrequencyElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// Event occurs duration from common life event
            /// </summary>
            public Code<Hl7.Fhir.Model.Schedule.EventTiming> WhenElement { get; set; }
            
            public Hl7.Fhir.Model.Schedule.EventTiming? When
            {
                get { return WhenElement != null ? WhenElement.Value : null; }
                set
                {
                    if(value == null)
                      WhenElement = null; 
                    else
                      WhenElement = new Code<Hl7.Fhir.Model.Schedule.EventTiming>(value);
                }
            }
            
            /// <summary>
            /// Repeating or event-related duration
            /// </summary>
            public Hl7.Fhir.Model.FhirDecimal DurationElement { get; set; }
            
            public decimal? Duration
            {
                get { return DurationElement != null ? DurationElement.Value : null; }
                set
                {
                    if(value == null)
                      DurationElement = null; 
                    else
                      DurationElement = new Hl7.Fhir.Model.FhirDecimal(value);
                }
            }
            
            /// <summary>
            /// The units of time for the duration
            /// </summary>
            public Code<Hl7.Fhir.Model.Schedule.UnitsOfTime> UnitsElement { get; set; }
            
            public Hl7.Fhir.Model.Schedule.UnitsOfTime? Units
            {
                get { return UnitsElement != null ? UnitsElement.Value : null; }
                set
                {
                    if(value == null)
                      UnitsElement = null; 
                    else
                      UnitsElement = new Code<Hl7.Fhir.Model.Schedule.UnitsOfTime>(value);
                }
            }
            
            /// <summary>
            /// Number of times to repeat
            /// </summary>
            public Hl7.Fhir.Model.Integer CountElement { get; set; }
            
            public int? Count
            {
                get { return CountElement != null ? CountElement.Value : null; }
                set
                {
                    if(value == null)
                      CountElement = null; 
                    else
                      CountElement = new Hl7.Fhir.Model.Integer(value);
                }
            }
            
            /// <summary>
            /// When to stop repeats
            /// </summary>
            public Hl7.Fhir.Model.FhirDateTime EndElement { get; set; }
            
            public string End
            {
                get { return EndElement != null ? EndElement.Value : null; }
                set
                {
                    if(value == null)
                      EndElement = null; 
                    else
                      EndElement = new Hl7.Fhir.Model.FhirDateTime(value);
                }
            }
            
            public override ErrorList Validate()
            {
                var result = new ErrorList();
                
                result.AddRange(base.Validate());
                
                if(FrequencyElement != null )
                    result.AddRange(FrequencyElement.Validate());
                if(WhenElement != null )
                    result.AddRange(WhenElement.Validate());
                if(DurationElement != null )
                    result.AddRange(DurationElement.Validate());
                if(UnitsElement != null )
                    result.AddRange(UnitsElement.Validate());
                if(CountElement != null )
                    result.AddRange(CountElement.Validate());
                if(EndElement != null )
                    result.AddRange(EndElement.Validate());
                
                return result;
            }
        }
        
        
        /// <summary>
        /// When the event occurs
        /// </summary>
        public List<Hl7.Fhir.Model.Period> Event { get; set; }
        
        /// <summary>
        /// Only if there is none or one event
        /// </summary>
        public Hl7.Fhir.Model.Schedule.ScheduleRepeatComponent Repeat { get; set; }
        
        public override ErrorList Validate()
        {
            var result = new ErrorList();
            
            result.AddRange(base.Validate());
            
            if(Event != null )
                Event.ForEach(elem => result.AddRange(elem.Validate()));
            if(Repeat != null )
                result.AddRange(Repeat.Validate());
            
            return result;
        }
    }
    
}
