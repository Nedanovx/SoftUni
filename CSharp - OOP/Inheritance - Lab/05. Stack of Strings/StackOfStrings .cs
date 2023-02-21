using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return Count == 0;
        }

        public StackOfStrings AddRange(IEnumerable<string> range )
        {
            foreach( string item in range )
            {
                Push(item);
            }
            return this;
        }
    }
}
