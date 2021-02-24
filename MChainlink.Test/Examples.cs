using System;
using Nethereum.Web3;
using NChainlink;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Nethereum.ENS;

namespace MChainlink.Test
{
    public class Examples
    {
        private readonly ITestOutputHelper output;

        public Examples(ITestOutputHelper testOutput)
        {
            output = testOutput;
        }

        [Fact]
        public async Task Example1()
        {
            //Ethereum endpoint URL.
            var web3 = new Web3("https://mainnet.infura.io/v3/<key>");

            //Pass web3 to chainlink to access Ethereum
            var chainlink = new Chainlink(web3);

            //Address of price feed oracle.
            var pricefeed = chainlink.Pricefeed("0xDC530D9457755926550b59e8ECcdaE7624181557");

            //Description, this address contract will return Token pair name.
            var description = await pricefeed.GetDescriptionAsync();

            //get all information about the last data.
            var lastRoundData = await pricefeed.GetLatestRoundDataAsync();

            //Show the last price.
            output.WriteLine($"Latest Price { Web3.Convert.FromWei(lastRoundData.Answer)} of { description }");
        }

        [Fact]
        public async Task Example2() 
        {
            //Ethereum endpoint URL.
            var web3 = new Web3("https://mainnet.infura.io/v3/<key>");

            //Create a Ens service; 
            var ensService = new ENSService(web3);

            //Turn an Ens URL into contract address.
            var address = await ensService.ResolveAddressAsync("link-eth.data.eth");

            //Pass web3 to chainlink to access Ethereum
            var chainlink = new Chainlink(web3);

            //Address of price feed oracle.
            var pricefeed = chainlink.Pricefeed(address);

            //Description, this address contract will return Token pair name.
            var description = await pricefeed.GetDescriptionAsync();

            //get all information about the last data.
            var lastRoundData = await pricefeed.GetLatestRoundDataAsync();

            //Convert last price in wai to eth
            var LastPriceInEth = Web3.Convert.FromWei(lastRoundData.Answer);
            //Convert unix time to datetime
            var LastUpdateDateTime = DateTimeOffset.FromUnixTimeSeconds((long)lastRoundData.UpdatedAt);

            //Show latest name,price and time
            output.WriteLine($"Description: { description }\nPrice: {LastPriceInEth}\nTime: { LastUpdateDateTime}");
        }
    }
}