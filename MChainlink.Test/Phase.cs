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
            var PriceFeed = Web3Api.Web.Chainlink().Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetPhaseIdAsync();
            Assert.Equal(3, Result);
        }
        [Fact]
        public async Task PhaseAggregators()
        {
            var PriceFeed = Web3Api.Web.Chainlink().Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetPhaseAggregatorsAsync(1);
            Assert.Equal((string) "0xecfa53a8bda4f0c4dd39c55cc8def3757acfdd07", (string) result);
        }
    }
    
}
