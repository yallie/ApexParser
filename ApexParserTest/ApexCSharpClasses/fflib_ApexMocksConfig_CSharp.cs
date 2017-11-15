namespace ApexSharpDemo.ApexCode
{
    using Apex.ApexSharp;
    using Apex.System;
    using SObjects;
    using NUnit.Framework;

    /*
     * Copyright (c) 2017 FinancialForce.com, inc.  All rights reserved.
     */
    [IsTest]
    public class fflib_ApexMocksConfig
    {
        /**
         * When false, stubbed behaviour and invocation counts are shared among all test spies.
         * - See fflib_ApexMocksTest.thatMultipleInstancesCanBeMockedDependently
         * - This is the default for backwards compatibility.
         * When true, each test spy instance has its own stubbed behaviour and invocations.
         * - See fflib_ApexMocksTest.thatMultipleInstancesCanBeMockedIndependently
         */
        public static bool HasIndependentMocks { get; set; }

        static fflib_ApexMocksConfig()
        {
            HasIndependentMocks = false;
        }
    }
}
