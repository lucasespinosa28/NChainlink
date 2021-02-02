using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("description", "string")]
        public class DescriptionFunction : FunctionMessage
        {
        }
    }
}