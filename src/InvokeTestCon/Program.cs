using System;
using InvokeTestLib;

namespace InvokeTestCon;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine(Tools.GetName());
        
        #if NET7_0
        Console.WriteLine("Main called in NET7_0");
        #endif
    }
}