// Copyright (c) Sarah Kaiser. All rights reserved.
// Licensed under the MIT License.

using System;
using Microsoft.Quantum.Simulation.Common;
using Microsoft.Quantum.Simulation.QuantumProcessor;

// This C# project is based on a Python implementation by @Strilanc here: 
// https://github.com/Strilanc/python-chp-stabilizer-simulator
namespace chp
{
    public class StabilizerSimulator : QuantumProcessorDispatcher
    {
        public StabilizerSimulator() : base(new StabilizerProcessor())
        {
            (this.QuantumProcessor as StabilizerProcessor).Simulator = this;
        }
    }
}
