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
        protected string alphabet;
        protected string text;
        protected int count;
        protected bool initialized = false;
        protected Text(string text)
        {
            Count(text);
            _Text = text;
        }
        public string Alphabet
        {
            get
            {
                if (!initialized) { initialized = true; Initialize(); }
                return alphabet;
            }
            protected set => alphabet = value;
        }
        public int _Count 
        {
            get
            {
                if (!initialized) { initialized = true; Initialize(); }
                return count;
            }
            protected set => count = value; 
        }
        public string _Text 
        {
            get
            {
                if (!initialized) { initialized = true; Initialize(); }
                return text;
            }
            protected set => text = value;
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
        abstract protected void Initialize();
    }
}
