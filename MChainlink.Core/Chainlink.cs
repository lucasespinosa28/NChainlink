using NChainlink.Controllers;
using Nethereum.Web3;

namespace NChainlink
{
    public class Chainlink
    {
        public Chainlink(Web3 web3)
        {
            Web = web3;
        }

        public Web3 Web { get; set; }

        public Pricefeed Pricefeed(string contract)
        {
            return new Pricefeed(Web, contract);
        }
    }
}