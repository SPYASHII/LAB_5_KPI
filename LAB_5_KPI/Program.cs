using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5_KPI
{
    class Program
    {
        static void Main()
        {
            string twoWords = "One two three";
            string cyrillic = "Задача организации, в особенности же постоянное информационно-пропагандистское обеспечение нашей деятельности играет важную роль в формировании позиций, занимаемых участниками в отношении поставленных задач. Не следует, однако забывать, что рамки и место обучения кадров представляет собой интересный эксперимент проверки соответствующий условий активизации.";
            string latin = "The task of the organization, in particular the constant information and propaganda support of our activities, plays an important role in shaping the positions taken by the participants in relation to the tasks set. It should not be forgotten, however, that the scope and place of staff training is an interesting experiment to test the appropriate activation conditions.";
            string japanese = "ス";
            string chinese = "组";
            string korean = "의";
            var sentenceCyr = new Text.Sentence(cyrillic);
            var sentenceEng = new Text.Sentence(latin);
            var sentenceChin = new Text.Sentence(chinese);
            var wordCyr = new Text.Word(cyrillic);
            var wordEng = new Text.Word(latin);
            var wordJap = new Text.Word(japanese);
            var characterCyr = new Text.Character(cyrillic);
            var characterJap = new Text.Character(japanese);
            var characterChin = new Text.Character(chinese);
            var characterKor = new Text.Character(korean);

            Console.OutputEncoding = Encoding.Unicode;

            Display(sentenceCyr);
            Display(sentenceEng);
            Display(sentenceChin);

            Display (wordCyr);
            Display(wordEng);
            Display(wordJap);

            Display(characterCyr);
            Display(characterJap);
            Display(characterChin);
            Display(characterKor);

            Console.ReadKey();
        }
        static void Display<T>(T text) where T : Text.Text
        {
            if (text.GetType() == typeof(Text.Sentence))
                Console.WriteLine($"{text.Alphabet} | words: {text._Count} | {text._Text}\n");
            else
                Console.WriteLine($"{text.Alphabet} | symbols: {text._Count} | {text._Text}\n");
        }
    }
}
