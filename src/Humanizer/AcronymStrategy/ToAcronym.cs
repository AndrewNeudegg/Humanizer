using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Humanizer.Localisation.Acronym;

namespace Humanizer
{
    class ToAcronym : IStringTransformer
    {
        public string Transform(string input)
        {
            var words = input;

            if (input.Length != 0)
            {
                words = Regex.Replace(words, @"\([^\(]*\)", " ");
                words = Regex.Replace(words, @"\[[^\[]*\]", " ");



                string[] arrPunc = { " ", ",", ".", ";", ":", "-", "!", "?", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
                for (int i = 0; i < arrPunc.Length; i++)
                {
                    words = words.Replace(arrPunc[i], " ");
                }

                string[] arr = words.Split(' ');

                StringBuilder str = new StringBuilder();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (!IStopWords.IsStopWord(arr[i]))
                    {
                        if (!arr[i].Equals("")) str.Append(arr[i].Substring(0, 1).ToUpper());
                    }
                }
                return str.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}