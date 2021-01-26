using NChainlink;
using Nethereum.Web3;
using NChainlink.Controllers;
namespace MChainlink.Test
{
    public static class Web3Api
    {
        public static Web3 Web => new Web3("https://mainnet.infura.io/v3/<key>");
        public static string Address => "0xDC530D9457755926550b59e8ECcdaE7624181557";
    }
    
}
