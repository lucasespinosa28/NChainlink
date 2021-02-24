using System.Threading.Tasks;
using NChainlink;
using Xunit;

namespace MChainlink.Test
{
    public class Phases
    {
        [Fact]
        public async Task PhaseId()
        {

            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetPhaseIdAsync();
            Assert.Equal(3, Result);
        }
        [Fact]
        public async Task PhaseAggregators()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetPhaseAggregatorsAsync(1);
            Assert.Equal("0xf79d6afbb6da890132f9d7c355e3015f15f3406f", (string) Result);
        }
    }
    
}
