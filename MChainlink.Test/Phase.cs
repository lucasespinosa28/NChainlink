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

            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.PhaseIdQueryAsync();
            Assert.Equal(3, Result);
        }
        [Fact]
        public async Task PhaseAggregators()
        {
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.PhaseAggregatorsQueryAsync(1);
            Assert.Equal("0xecfa53a8bda4f0c4dd39c55cc8def3757acfdd07", (string) Result);
        }
    }
    
}
