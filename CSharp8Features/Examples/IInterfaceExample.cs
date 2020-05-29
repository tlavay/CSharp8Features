using CSharp8Features.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features.Examples
{
    public interface IInterfaceExample
    {
        #region Old Way
        //Interfaces are immutable once they've been released! This is a breaking change!" C# 8.0 adds default interface implementations for upgrading interfaces
        string MethodA();

        #endregion

        #region New Way

        //public string MethodB() => DefaultMethodB();
        //protected static string DefaultMethodB()
        //{
        //    return "This will not break the implementation I already have!";
        //}

        #endregion
    }
}
