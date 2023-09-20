using System;
using System.Runtime.InteropServices;

namespace MyCSharpApp.Desktop.Lib
{
    public static class LibExt
    {
        #region DLL Functions

        /// <summary>
        /// Adds two numbers and shows the result by using the 
        /// 32 bits DLL release file for MyCSharpApp built in C++
        /// </summary>
        /// <param name="a">value of the parameter</param>
        /// <param name="b"></param>
        /// <returns></returns>
        [DllImport("MyCSharpApp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double addition(double a, double b);

        #endregion
    }
}
