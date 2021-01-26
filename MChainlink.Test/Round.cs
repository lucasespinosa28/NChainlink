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
            var PriceFeed = Web3Api.Web.Chainlink().Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetRoundDataAsync("55340232221128658359");
            Assert.True(result.Answer > 1);
            Assert.True(result.StartedAt > 1);
            Assert.True(result.UpdatedAt > 1);
            Assert.True(result.AnsweredInRound > 1);
            Assert.True(result.RoundId > 1);

        }
        //[Fact]
        //public async Task LatestRound()
        //{
        //    var PriceFeed = Web3Api.Web.Chainlink().Pricefeed(Web3Api.Address);
        //    var result = await PriceFeed.GetLatestRoundAsync();
        //    Assert.True(result > 1);
        //}
        [Fact]
        public async Task LatestRoundData()
        {
            var PriceFeed = Web3Api.Web.Chainlink().Pricefeed(Web3Api.Address);
            var result = await PriceFeed.GetLatestRoundDataAsync();
            Assert.True(result.Answer > 1);
            Assert.True(result.StartedAt > 1);
            Assert.True(result.UpdatedAt > 1);
            Assert.True(result.AnsweredInRound > 1);
            Assert.True(result.RoundId > 1);
        }
    }
}
