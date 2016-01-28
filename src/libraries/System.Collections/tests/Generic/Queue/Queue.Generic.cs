﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace System.Collections.Tests
{
    public class Queue_Generic_Tests_string : Queue_Generic_Tests<string>
    {
        protected override string TFactory(int seed)
        {
            int stringLength = seed % 10 + 5;
            Random rand = new Random(seed);
            byte[] bytes = new byte[stringLength];
            rand.NextBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
    }

    public class Queue_Generic_Tests_int : Queue_Generic_Tests<int>
    {
        protected override int TFactory(int seed)
        {
            Random rand = new Random(seed);
            return rand.Next();
        }
    }
}
