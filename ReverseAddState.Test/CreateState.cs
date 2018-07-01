using System;
using Xunit;

namespace ReverseAddState.Test
{
    public class CreateState
    {
        [Theory]
        [ClassData(typeof(TD_CreateState))]
        public void CreateState_NotNull(int input)
        {
            var sut = new RAState(input);

            Assert.NotNull(sut);
        }

        [Theory]
        [ClassData(typeof(TD_CreateState))]
        public void CreatedState_StepCountCorrect(int input)
        {
            var sut = new RAState(input);

            Assert.Equal(1, sut.StepCount);
        }

        [Theory]
        [ClassData(typeof(TD_CreateState))]
        public void CreatedState_InputCorrect(int input)
        {
            var sut = new RAState(input);

            Assert.Equal(input, sut.Input);
        }

    }
}
