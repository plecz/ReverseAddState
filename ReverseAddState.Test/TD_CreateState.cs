using System;
using Xunit;

namespace ReverseAddState.Test
{
    public class TD_CreateState : TheoryData<int>
    {
        public TD_CreateState()
        {
            Add(0);
            Add(1);
            Add(183);
        }
    }
}
