﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAB_5_KPI.Text
{
    class Sentence : Word
    {
        public Sentence(string text) : base(text)
        {
        }
        protected override void Count(string text)
        {
            var matches = Regex.Matches(text, @"[\wа-яА-Я]+");
            _Count = matches.Count;
        }
        protected override string Select(string text)
        {
            if(Regex.IsMatch(text, @"[.?!]"))
            return text.Substring(0, Regex.Match(text, @"[.?!]").Index + 1);
            return text;
        }
    }
}
