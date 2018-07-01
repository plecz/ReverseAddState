using System;
using Xunit;

namespace ReverseAddState.Test
{
    public class NextState
    {
        [Fact]
        public void NextState_NotNull()
        {
            var initialState = new RAState(154);

            var sut = initialState.Next();

            Assert.NotNull(sut);
        }

        [Fact]
        public void NextState_StepCountIncreased()
        {
            var initialState = new RAState(173);

            var sut = initialState.Next();

            Assert.Equal(2, sut.StepCount);
        }

        [Theory]
        [ClassData(typeof(TD_NextState))]
        public void NextState_InputIsPreviousSum(int input)
        {
            var initialState = new RAState(input);
            var expected = initialState.Sum;

            var sut = initialState.Next();

            Assert.Equal(expected, sut.Input);
        }

    }
}
