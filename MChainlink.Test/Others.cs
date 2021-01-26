using System.Numerics;
using System.Threading.Tasks;
using NChainlink;
using Xunit;

namespace MChainlink.Test 
{ 
    public class Others
    {
        [Fact]
        public async Task Description()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetDescriptionAsync();
            Assert.Equal((string) "LINK / ETH", (string) result);
        }
        [Fact]
        public async Task Decimals()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetDecimalsAsync();
            Assert.True(result > 0);
        }
        [Fact]
        public async Task Aggregator()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetAggregatorAsync();
            Assert.True(result.Length > 10);
        }
        [Fact]
        public async Task AccessController()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GeAccessControllerAsync();
            Assert.True(result.Length > 0);
        }
        [Fact]
        public async Task Owner()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetOwnerAsync();
            Assert.True(result.Length > 0);
        }
        [Fact]
        public async Task Version()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetVersionAsync();
            Assert.Equal<BigInteger>(3,result);
        }
    }
}
