using System;
using Nethereum.Contracts.Services;
using NChainlink;
using Nethereum.Web3;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.ENS;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink 
    {
        private Web3 Web3 { get; set; }
        private string contract { get; set; }
        public Chainlink(Web3 web3, string contractAddress)
        {
            Web3 = web3;
            contract = contractAddress;
        }
    }
}
