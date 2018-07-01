using System;
using Xunit;

namespace ReverseAddState.Test
{
    public class TD_StateIsFinal : TheoryData<int, bool>
    {
        public TD_StateIsFinal()
        {
            Add(1, true);
            Add(77, false);
            Add(131, true);
            Add(100, true);
            Add(180, false);
            Add(0, true);
            Add(1001, true);
            Add(1234, true);
            Add(32768, false);
        }
    }
}
