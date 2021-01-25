using Nethereum.Web3;
using System.Numerics;
using Xunit;
using MChainlink;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.ENS;
using System.Threading.Tasks;

namespace MChainlink.Test
{
    public class Proposeds
    {
        public string Address { get; set; } = "0xDC530D9457755926550b59e8ECcdaE7624181557";
        
        [Fact]
        public async Task ProposedGetRoundData()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetProposedGetRoundDataAsync("102");
            Assert.NotNull(result);
        }
        [Fact]
        public async Task ProposedAggregator()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetProposedAggregatorAsync();
            Assert.True(result.Length > 0);
        }
        [Fact]
        public async Task ProposedLatestRoundData()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetProposedLatestRoundData();
            Assert.NotNull(result);
        }
    }
    
}
