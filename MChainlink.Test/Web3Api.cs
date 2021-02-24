using NChainlink;
using Nethereum.Web3;
using NChainlink.Controllers;
namespace MChainlink.Test
{
    public static class Web3Api
    {
        public static Web3 Web => new Web3("https://mainnet.infura.io/v3/");
        public static string Address => "0x5f4eC3Df9cbd43714FE2740f5E3616155c5b8419";
    }
    
}
