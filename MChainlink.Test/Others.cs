using System.Numerics;
using System.Threading.Tasks;
using NChainlink;
using NChainlink.Models;
using Xunit;

namespace MChainlink.Test 
{ 
    public class Others
    {

        [Fact]
        public async Task Description()
        {
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.DescriptionQueryAsync();

            Assert.Equal("LINK / ETH", Result);
        }
        [Fact]
        public async Task Decimals()
        {
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.DecimalsQueryAsync();
            Assert.True(Result > 0);
        }
        [Fact]
        public async Task Aggregator()
        {
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.AggregatorQueryAsync();
            Assert.True(Result.Length > 10);
        }
        [Fact]
        public async Task AccessController()
        {
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.AccessControllerQueryAsync();
            Assert.True(Result.Length > 0);
        }
        [Fact]
        public async Task Owner()
        {
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.OwnerQueryAsync();
            Assert.True(Result.Length > 0);
        }
        [Fact]
        public async Task Version()
        {
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.VersionQueryAsync();
            Assert.Equal<BigInteger>(3,Result);
        }
        [Fact]
        public async Task VersionObject()
        {
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var versionData = new Model.VersionFunction();
            var Result = await PriceFeed.VersionQueryAsync(versionData);
            Assert.Equal<BigInteger>(3, Result);
        }
    }
}
