using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAB_5_KPI.Text
{
    abstract class Text
    {
        public string Alphabet { get; protected set; }
        public int _Count { get; protected set; }
        public string _Text { get; protected set; }
        public Text(string text)
        {
            Count(text);
        }
        protected virtual void IdentifyAlphabet()
        {
            string lat = "";
            string cyr = "";
            if (Regex.IsMatch(_Text, @"[A-Za-z]"))
                lat = "Latin";
            if (Regex.IsMatch(_Text, @"[А-Яа-я]"))
                cyr = "Cyrillic";
            Alphabet = $"{lat}{cyr}";
            if (Alphabet == "")
                Alphabet = "Unknown";
        }
        protected virtual void Count(string text)
        {
            int a = Regex.Replace(text, @"[ ]+", "").Length;
            _Count = a;
        }
        abstract protected string Select(string text);
    }
}
