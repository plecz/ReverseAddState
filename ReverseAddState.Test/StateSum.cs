using System;
using Xunit;

namespace ReverseAddState.Test
{
    public class StateSum
    {
        [Theory]
        [ClassData(typeof(TD_StateSum))]
        public void Sum_ResultCorrect(int input, int sum)
        {
            var sut = new RAState(input);

            Assert.Equal(sum, sut.Sum);
        }
    }
}
