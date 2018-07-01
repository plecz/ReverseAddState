using System;
using Xunit;

namespace ReverseAddState.Test
{
    public class TD_StateReverse : TheoryData<int, int>
    {
        public TD_StateReverse()
        {
            Add(1, 1);
            Add(77, 77);
            Add(131, 131);
            Add(100, 1);
            Add(180, 81);
            Add(0, 0);
            Add(1001, 1001);
            Add(1234, 4321);
            Add(32768, 86723);
        }
    }
}
