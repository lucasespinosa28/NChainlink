using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("accessController", "address")]
        public class AccessControllerFunction : FunctionMessage
        {
        }

        [Function("setController")]
        public class SetControllerFunction : FunctionMessage
        {
            [Parameter("address", "_accessController")]
            public virtual string AccessController { get; set; }
        }
    }
}