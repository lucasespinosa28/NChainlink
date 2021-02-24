using System.Numerics;
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

            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetProposedGetRoundDataAsync(BigInteger.Parse("5583"));
            Assert.True(Result.Answer > 1);
            Assert.True(Result.StartedAt > 1);
            Assert.True(Result.UpdatedAt > 1);
            Assert.True(Result.AnsweredInRound > 1);
            Assert.True(Result.RoundId > 1);
        }
        [Fact]
        public async Task ProposedAggregator()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetProposedAggregatorAsync();
            Assert.NotNull(Result);
        }
        [Fact]
        public async Task ProposedLatestRoundData()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetProposedLatestRoundDataAsync();
            Assert.True(Result.Answer > 1);
            Assert.True(Result.StartedAt > 1);
            Assert.True(Result.UpdatedAt > 1);
            Assert.True(Result.AnsweredInRound > 1);
            Assert.True(Result.RoundId > 1);
        }
    }
    
}
