﻿/*
  Copyright (c) 2011-2012, HL7, Inc
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HL7.Fhir.Instance.Model
{
    public partial class Code
    {
        // Must conform to the pattern [^\s]+([\s]+[^\s]+)*
        private const string PATTERN = @"[^\s]+([\s]+[^\s]+)*";

        public static bool TryParse(string value, out Code result)
        {       
            Regex codeRegEx = new Regex(PATTERN);

            if (codeRegEx.IsMatch(value))
            {
                result = new Code(value);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public static Code Parse(string value)
        {
            Code result = null;

            if (TryParse(value, out result))
                return result;
            else
                throw new FhirValueFormatException("Not a correctly formatted code value");
        }

        public override string ValidateData()
        {
            if (Value == null)
                return "Code values cannot be empty";

            Code dummy;

            if (!TryParse( this.Value, out dummy ))
                return "Not an correctly formatted code value";
            
            return null; 
        }
    }

    public class Code<T> : Primitive<T>  where T : struct, IConvertible
    {
        public Code(T value)
            : base(value)
        {
            if (!typeof(T).IsEnum) throw new ArgumentException("T must be an enumerated type");
        }

        public static implicit operator Code<T>(T value)
        {
            return new Code<T>(value);
        }

        public static implicit operator T(Code<T> value)
        {
            return value.Value;
        }

        public static bool TryParse(string value, out Code<T> result)
        {
            object enumValue;

            if (EnumHelper.TryParseEnum(value, typeof(T), out enumValue))
            {
                result = new Code<T>((T)enumValue);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public static Code<T> Parse(string value)
        {
            Code<T> result = null;

            if (TryParse(value, out result))
                return result;
            else
                throw new FhirValueFormatException("'" + value + "' is not a correct value for " +
                            "enum " + typeof(T).Name );
        }

        public override string ValidateData()
        {
            return null;        // cannot be empty and cannot be set to illegal values
        }
    }
}
