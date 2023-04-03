using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAB_5_KPI.Text
{
    class Character : Text
    {
        public Character(string text) : base(text)
        {
            
        }
        protected override void IdentifyAlphabet()
        {
            base.IdentifyAlphabet();
            if(Alphabet == "Unknown")
            {
                if (Regex.IsMatch(_Text, @"[\u3040-\u30FF]+"))
                {
                    Alphabet = "Japanese";
                    return;
                }
                if (Regex.IsMatch(_Text, @"[\u4E00-\u9FFF]+"))
                {
                    Alphabet = "Chinese";
                    return;
                }
                if (Regex.IsMatch(_Text, @"[\uAC00-\uD7AF]+"))
                {
                    Alphabet = "Korean";
                    return;
                }
            }
        }
        protected override string Select(string text)
        {
            return text.First().ToString();
        }
        protected override void Initialize()
        {
            _Text = Select(_Text);
            _Count = 1;
            IdentifyAlphabet();
        }
    }
}
