using System;
using System.Collections.Generic;
using System.Text;

namespace Humanizer.Localisation.Acronym
{
    class IStopWords
    {
        public static bool IsStopWord(string input)
        {
            string str = input.ToLower();
            if (EnglishUKStopWords.Stopwords.ContainsKey(str) == false)
            {
                return false;
            }
            return true;
        }

        public static bool ContainsStopWord(string input)
        {
            var words = input.Split(' ');

            foreach (string currentWord in words)
            {
                if (IsStopWord(currentWord))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
