using Nethereum.Web3;
using System.Numerics;
using Xunit;
using MChainlink;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.ENS;
using System.Threading.Tasks;

namespace MChainlink.Test
{
    public class Phases
    {
        public string Address { get; set; } = "0x6Df09E975c830ECae5bd4eD9d90f3A95a4f88012";
        public Web3 web { get; set; } = new Web3("https://mainnet.infura.io/v3/02d86dbe025647f9b912fad4d9e82397");
        [Fact]
        public async Task PhaseId()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetPhaseIdAsync();
            Assert.Equal(1, result);
        }
        [Fact]
        public async Task PhaseAggregators()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetPhaseAggregatorsAsync(1);
            Assert.Equal("0x42F3b59f72772EB5794B04D2d85aFAC0D30A5683".ToLower(), result);
        }
    }
    
}
