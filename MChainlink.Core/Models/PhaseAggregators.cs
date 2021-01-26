using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("phaseAggregators", "address")]
        public class PhaseAggregators : FunctionMessage
        {
            [Parameter("uint16", "<input>")] public short Input { get; set; }
        }
    }
}