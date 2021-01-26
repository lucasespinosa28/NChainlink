using System.Threading;
using NChainlink.Controllers;
using Nethereum.Web3;

namespace NChainlink
{

    public class Chainlink
    {
        public Web3 Web { get; set; }

        public Chainlink(Web3 web3)
        {
            Web = web3;
        }
    }

    public static class PriceFeedExtension
    {
        public static Pricefeed Pricefeed(this Chainlink web, string address)
        {
            return new Pricefeed {Web = web.Web, Contract = address};
        }
    }
}