using Nethereum.Contracts;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Web3;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        protected Contract Contract { get; set; }

        public ContractHandler ContractHandler { get; }

        //public string Contract { get; set; }
        public Pricefeed(Web3 web3, string contractAddress)
        {
            Contract = web3.Eth.GetContract(PriceFeedAbi.Json, contractAddress);
        }

    }
}