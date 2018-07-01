using System;
using Xunit;

namespace ReverseAddState.Test
{
    public class TD_NextState : TheoryData<int>
    {
        public TD_NextState()
        {
            Add(0);
            Add(1);
            Add(183);
        }
    }
}
