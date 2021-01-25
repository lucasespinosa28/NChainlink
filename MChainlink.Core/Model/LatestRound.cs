using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace NChainlink
{
    public partial class Model
    {
        [Function("latestRound", "uint256")]
        public class LatestRound : FunctionMessage
        {
        }
    }
}
