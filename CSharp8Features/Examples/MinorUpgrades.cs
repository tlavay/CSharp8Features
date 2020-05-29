using CSharp8Features.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
    public sealed class MinorUpgrades
    {
        #region Null Coalescing Assignment
        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator

        //Simple singleton pattern
        private ExampleClass exampleClass;
        public ExampleClass NullCoalescingOperator
        {
            get
            {
                return this.exampleClass ?? (this.exampleClass = new ExampleClass());
            }
        }

        public ExampleClass NullCoalescingAssignmentExample
        {
            get
            {
                return this.exampleClass ??= new ExampleClass();
            }
        }

        #endregion

        #region Interpolated Verbatim

        public void InterpolatedVerbatimStringsExample()
        {
            //var filePath = "C:\Users\tylavay\Documents\fileName";
        }

        #endregion
    }
}
