using System.Threading.Tasks;
using NChainlink;
using Xunit;

namespace MChainlink.Test
{
    public class Proposeds
    {
        [Fact]
        public async Task ProposedGetRoundData()
        {
            var PriceFeed = Web3Api.Web.Chainlink().Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetProposedGetRoundDataAsync("102");
            Assert.True(result.Answer > 1);
            Assert.True(result.StartedAt > 1);
            Assert.True(result.UpdatedAt > 1);
            Assert.True(result.AnsweredInRound > 1);
            Assert.True(result.RoundId > 1);
        }
        [Fact]
        public async Task ProposedAggregator()
        {
            var PriceFeed = Web3Api.Web.Chainlink().Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetProposedAggregatorAsync();
            Assert.True(result.Length > 0);
        }
        [Fact]
        public async Task ProposedLatestRoundData()
        {
            var PriceFeed = Web3Api.Web.Chainlink().Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetProposedLatestRoundData();
            Assert.True(result.Answer > 1);
            Assert.True(result.StartedAt > 1);
            Assert.True(result.UpdatedAt > 1);
            Assert.True(result.AnsweredInRound > 1);
            Assert.True(result.RoundId > 1);
        }
    }
    
}
