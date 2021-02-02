using Nethereum.Contracts.ContractHandlers;
using Nethereum.Web3;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        protected Web3 Web3 { get; }

        public ContractHandler ContractHandler { get; }

        public string Contract { get; set; }
        public Pricefeed(Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
            Contract = contractAddress;
        }

    }
}