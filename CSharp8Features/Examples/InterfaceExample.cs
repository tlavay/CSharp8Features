using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features.Examples
{
    public sealed class InterfaceExample : IInterfaceExample
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#default-interface-methods
        #region Old Way
        public string MethodA()
        {
            return "Tyler seamlessly implemented this method weeks ago.";
        }

        #endregion

        #region New way
        //public string MethodB()
        //{
        //    return "Hell yeah. Interfaces.";
        //}

        #endregion
    }
}
