using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features.Examples
{
    public sealed class LocalStaticFunctions
    {
        int M()
        {
            int y;
            LocalFunction();
            return y;

            void LocalFunction() => y = 0;
        }

        int M2()
        {
            int y = 5;
            int x = 7;
            return Add(x, y);

            static int Add(int left, int right)
            {
                return left + right;
            }
        }
    }
}
