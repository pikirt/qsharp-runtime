﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Microsoft.Quantum.Simulation.Common.Exceptions
{
    public class QuantumProcessorException : Exception
    {
        public QuantumProcessorException()
            : base("An exception occurred while invoking a quantum processor.")
        {
        }
    }
}