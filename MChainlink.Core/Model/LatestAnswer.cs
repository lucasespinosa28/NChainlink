using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace NChainlink
{
    public partial class Model
    {
        [Function("latestAnswer", "int256")]
        public class LatestAnswer : FunctionMessage
        {
        }
    }
}
