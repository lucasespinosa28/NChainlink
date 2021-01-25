using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace NChainlink
{
    public partial class Model
    {
        [Function("proposedGetRoundData")]
        public class ProposedGetRoundData : FunctionMessage 
        {
            [Parameter("uint80", "_roundId", 1)]
            public BigInteger RoundId { get; set; }
        }
    }
}
