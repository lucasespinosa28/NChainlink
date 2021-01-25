using Nethereum.Web3;
using System.Numerics;
using Xunit;
using MChainlink;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.ENS;
using System.Threading.Tasks;

namespace MChainlink.Test
{
    public class Rounds
    {
        public string Address { get; set; } = "0xDC530D9457755926550b59e8ECcdaE7624181557";
        
        [Fact]
        public async Task RoundData()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetRoundDataAsync("55340232221128658359");
            Assert.NotNull(result);
        }
        [Fact]
        public async Task LatestRound()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetLatestRoundAsync();
            Assert.True(result > 1);
        }
        [Fact]
        public async Task LatestRoundData()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetLatestRoundDataAsync();
            Assert.NotNull(result);
        }
    }
}
