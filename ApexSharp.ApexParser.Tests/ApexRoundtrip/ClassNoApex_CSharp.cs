namespace ApexSharpDemo.ApexCode
{
    using Apex;
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.ApexSharp.Extensions;
    using Apex.System;
    using SObjects;

    public class ClassNoApex
    {
        // Any classes in NoApex name space will be commented out in Apex and uncommented on c#.
        public static void MethodOne()
        {
            NoApex.Serilog.LogInfo("Jay");
        }

        // Any method in NoApex name space will be commented out in Apex and uncommented on c#.
        public static void NoApexMethodTwo()
        {
            NoApex.Serilog.LogInfo("Jay");
        }
    }
}
