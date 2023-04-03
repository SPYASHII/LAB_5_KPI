using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAB_5_KPI.Text
{
    class Word : Sentence
    {
        public Word (string text) : base(text)
        {
            _Text = Select(text);
            base.Count(_Text);
            IdentifyAlphabet();
        }
        protected override string Select(string text)
        {
            return Regex.Match(text, @"\b[\w']*\b").ToString();
        }
    }
}
