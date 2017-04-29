using System;
using System.Collections.Generic;
using Xunit;
using Humanizer.Localisation.Acronym;
using Humanizer;

namespace Humanizer.Tests
{
    public class AcronymTest
    {
        [Theory]
        [InlineData("Laugh, Out Loud", "LOL")]
        [InlineData("Laugh Out; Loud", "LOL")]
        [InlineData("Laugh (Kind of) Out loud", "LOL")]
        [InlineData("Laugh[1] out loud", "LOL")]
        [InlineData("Laugh Out-loud", "LOL")]
        [InlineData("Laugh 2 out loud", "LOL")]
        [InlineData("The and yes", "")]
        public void AcronymTestCase(string input, string expectedOutput)
        {
            Assert.Equal(expectedOutput, input.Transform(To.Acronym));
        }
    }
}
