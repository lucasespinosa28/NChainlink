using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("decimals", "uint8")]
        public class DecimalsFunction : FunctionMessage
        {
        }
    }
}