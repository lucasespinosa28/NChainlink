using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("aggregator", "address")]
        public class Aggregator : FunctionMessage
        {
        }
    }
}