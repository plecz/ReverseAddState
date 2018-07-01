using System;
using Xunit;

namespace ReverseAddState.Test
{
    public class TD_StateSum : TheoryData<int, int>
    {
        public TD_StateSum()
        {
            Add(1, 2);
            Add(77, 154);
            Add(131, 262);
            Add(100, 101);
            Add(180, 261);
            Add(0, 0);
            Add(1001, 2002);
            Add(1234, 5555);
            Add(32768, 119491);
        }
    }
}
