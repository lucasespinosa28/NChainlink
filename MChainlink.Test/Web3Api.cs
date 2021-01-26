using Nethereum.Web3;

namespace MChainlink.Test
{
    public static class Web3Api
    {
        public static Web3 Web => new Web3("https://mainnet.infura.io/v3/1cca02da44c94251b71d81d05eabe285");
        public static string Address => "0xDC530D9457755926550b59e8ECcdaE7624181557";
    }
    
}
