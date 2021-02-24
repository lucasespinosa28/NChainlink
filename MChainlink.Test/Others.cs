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
            var Result = await PriceFeed.GetDescriptionAsync();

            Assert.Equal("ETH / USD", Result);
        }
        [Fact]
        public async Task Decimals()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetDecimalsAsync();
            Assert.True(Result > 0);
        }
        [Fact]
        public async Task Aggregator()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetAggregatorAsync();
            Assert.True(Result.Length > 10);
        }
        [Fact]
        public async Task AccessController()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetAccessControllerAsync();
            Assert.True(Result.Length > 0);
        }
        [Fact]
        public async Task Owner()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetOwnerAsync();
            Assert.True(Result.Length > 0);
        }
        [Fact]
        public async Task Version()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetVersionAsync();
            Assert.Equal<BigInteger>(3,Result);
        }
    }
}
