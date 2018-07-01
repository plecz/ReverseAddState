using System;
using Xunit;

namespace ReverseAddState.Test
{
    public class StateIsFinal
    {
        [Theory]
        [ClassData(typeof(TD_StateIsFinal))]
        public void Sum_ResultCorrect(int input, bool final)
        {
            var sut = new RAState(input);

            Assert.Equal(final, sut.IsFinalState);
        }
    }
}
