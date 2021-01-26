using NChainlink.Controllers;
using Nethereum.Web3;

namespace NChainlink
{
    public class ChainlinkOut
    {
        public Web3 Web { get; set; }
    }

    public static class ChainlinkExtension
    {
        public static ChainlinkOut Chainlink(this Web3 web)
        {
            return new ChainlinkOut {Web = web};
        }
    }

    public static class PriceFeedExtension
    {
        public static Pricefeed Pricefeed(this ChainlinkOut web, string address)
        {
            return new Pricefeed {Web = web.Web, Contract = address};
        }
    }
}