using Nethereum.Web3;
using System.Numerics;
using Xunit;
using MChainlink;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.ENS;
using System.Threading.Tasks;

namespace MChainlink.Test
{
    public class Anwers
    {
        public string Address { get; set; } = "0xDC530D9457755926550b59e8ECcdaE7624181557";
        public Web3 web { get; set; } = new Web3("https://mainnet.infura.io/v3/02d86dbe025647f9b912fad4d9e82397");
        [Fact]
        public async Task GetAnswer()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetAnswerAsync("18446744073709553653");
            Assert.True(result > 0);
        }
        [Fact]
        public async Task GetLatestAnswer()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetLatestAnswerAsync();
            Assert.True(result > 0);
        }
    }
    
}
