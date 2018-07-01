using System;
using Xunit;

namespace ReverseAddState.Test
{
    public class StateReverse
    {
        [Theory]
        [ClassData(typeof(TD_StateReverse))]
        public void Reverse_ResultCorrect(int input, int reverse)
        {
            var sut = new RAState(input);

            Assert.Equal(reverse, sut.Reversed);
        }
    }
}
