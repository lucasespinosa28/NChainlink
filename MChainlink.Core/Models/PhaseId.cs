using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("phaseId", "uint16")]
        public class PhaseId : FunctionMessage
        {
        }
    }
}