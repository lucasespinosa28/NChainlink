using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System;
using System.Numerics;

namespace NChainlink
{
    public partial class Model
    {
        [Function("phaseId","uint16")]
        public class PhaseId : FunctionMessage
        {
        }
    }
}
