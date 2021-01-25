using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System;
using System.Numerics;

namespace NChainlink
{
    public partial class Model
    {
        [Function("phaseAggregators","address")]
        public class PhaseAggregators : FunctionMessage
        {
            [Parameter("uint16", "<input>", 1)]
            public Int16 Input { get; set; }
        }
    }
}
