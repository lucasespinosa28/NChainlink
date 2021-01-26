using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("version", "uint256")]
        public class Version : FunctionMessage
        {
        }
    }
}