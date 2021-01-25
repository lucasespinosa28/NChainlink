using Nethereum.Web3;
using System.Numerics;
using Xunit;
using MChainlink;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.ENS;
using System.Threading.Tasks;

namespace MChainlink.Test 
{ 
    public class Others
    {
        public string Address { get; set; } = "0xDC530D9457755926550b59e8ECcdaE7624181557";
        public Web3 web { get; set; } = new Web3("https://mainnet.infura.io/v3/02d86dbe025647f9b912fad4d9e82397");
        [Fact]
        public async Task Description()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetDescriptionAsync();
            Assert.Equal("LINK / ETH", result);
        }
        [Fact]
        public async Task Decimals()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetDecimalsAsync();
            Assert.True(result > 0);
        }
        [Fact]
        public async Task Aggregator()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetAggregatorAsync();
            Assert.True(result.Length > 10);
        }
        [Fact]
        public async Task AccessController()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GeAccessControllerAsync();
            Assert.True(result.Length > 0);
        }
        [Fact]
        public async Task Owner()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetOwnerAsync();
            Assert.True(result.Length > 0);
        }

        [Fact]
        public async Task Version()
        {
            var chainLink = new Chainlink(Web3Api.Web, Address);
            var result = await chainLink.GetVersionAsync();
            Assert.Equal(3,result);
        }
    }
}
