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
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.ProposedGetRoundDataQueryAsync("4230");
            Assert.True(Result.Answer > 1);
            Assert.True(Result.StartedAt > 1);
            Assert.True(Result.UpdatedAt > 1);
            Assert.True(Result.AnsweredInRound > 1);
            Assert.True(Result.RoundId > 1);
        }
        [Fact]
        public async Task ProposedAggregator()
        {
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.ProposedAggregatorQueryAsync();
            Assert.NotNull(Result);
        }
        [Fact]
        public async Task ProposedLatestRoundData()
        {
            var Chainlink = new NChainlink.Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.ProposedLatestRoundDataQueryAsync();
            Assert.True(Result.Answer > 1);
            Assert.True(Result.StartedAt > 1);
            Assert.True(Result.UpdatedAt > 1);
            Assert.True(Result.AnsweredInRound > 1);
            Assert.True(Result.RoundId > 1);
        }
    }
    
}
