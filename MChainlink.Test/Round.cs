using System.Numerics;
using System.Threading.Tasks;
using NChainlink;
using Xunit;

namespace MChainlink.Test
{
    public class Rounds
    {
        [Fact]
        public async Task RoundData()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetRoundDataAsync(BigInteger.Parse("55340232221128675888"));
            Assert.True(Result.Answer > 1);
            Assert.True(Result.StartedAt > 1);
            Assert.True(Result.UpdatedAt > 1);
            Assert.True(Result.AnsweredInRound > 1);
            Assert.True(Result.RoundId > 1);

        }
        [Fact]
        public async Task LatestRoundData()
        {
            var Chainlink = new Chainlink(Web3Api.Web);
            var PriceFeed = Chainlink.Pricefeed(Web3Api.Address);
            var Result = await PriceFeed.GetLatestRoundDataAsync();
            Assert.True(Result.Answer > 1);
            Assert.True(Result.StartedAt > 1);
            Assert.True(Result.UpdatedAt > 1);
            Assert.True(Result.AnsweredInRound > 1);
            Assert.True(Result.RoundId > 1);
        }
    }
}
