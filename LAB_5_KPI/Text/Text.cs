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
            int a = Regex.Replace(text, @"[ ]+", "").Length;
            _Count = a;
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
        abstract protected void IdentifyAlphabet();
        abstract protected void Count(string text);
        abstract protected string Select(string text);
        protected void Initialize()
        {
            _Text = Select(_Text);
            Count(_Text);
            IdentifyAlphabet();
        }
    }
}
