using System;
using System.Collections.Generic;
using System.Text;

namespace Humanizer
{
    class ToAcronym : IStringTransformer
    {
        public string Transform(string input)
        {
            var words = input.Split(' ');
            var result = "";
            //var result = new List<string>;
            foreach (var word in words)
            {
                if(word.Length != 0)
                {
                    result += char.ToUpper(word[0]);
                }
            }

            return result;
        }
    }
}
