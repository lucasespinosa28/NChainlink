using Nethereum.Web3;
using System.Numerics;
using Xunit;
using MChainlink;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.ENS;
using System.Threading.Tasks;

namespace MChainlink.Test
{
    public class Timestamps
    {
        public string Address { get; set; } = "0x6Df09E975c830ECae5bd4eD9d90f3A95a4f88012";
        public Web3 web { get; set; } = new Web3("https://mainnet.infura.io/v3/02d86dbe025647f9b912fad4d9e82397");
        [Fact]
        public async Task LatestTimestamp()
        {
            var chainLink  = new Chainlink(web, Address);
            var result = await chainLink.GetLatestTimestamp();
            Assert.True(result > 0);
        }
        [Fact]
        public async Task GetTimestamp()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetTimestamp("18446744073709553653");
            Assert.Equal(1611528879, result);
        }
    }
}
