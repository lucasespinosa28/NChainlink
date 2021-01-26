using Nethereum.Web3;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        public Web3 Web { get; set; }
        public string Contract { get; set; }
    }
}