using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NChainlink
{
    public partial class Model
    {
        [Function("proposedAggregator", "address")]
        public class ProposedAggregator : FunctionMessage { }
    }
}
