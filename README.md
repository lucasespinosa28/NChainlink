# NChainlink [![NuGet](https://img.shields.io/nuget/v/NChainlink)](https://www.nuget.org/packages/NChainlink/) ![License](https://img.shields.io/github/license/lucasespinosa28/NChainlink)

NChainlink a library made for Nethereum to help work with chainlink smart contract 

## How to use NChainlink 
#### Basic example
```C#
using System;
using Nethereum.Web3;
using NChainlink;
using System.Threading.Tasks;

//Ethereum endpoint URL.
var web3 = new Web3("https://mainnet.infura.io/v3/<KEY>");

//Pass web3 to chainlink to access Ethereum
var chainlink = new Chainlink(web3);

//Address of price feed oracle.
 var pricefeed = chainlink.Pricefeed("0x5f4eC3Df9cbd43714FE2740f5E3616155c5b8419");

//Description, this address contract will return Token pair name.
var description = await pricefeed.DescriptionQueryAsync();

//get all information about the last data.
var lastRoundData = await pricefeed.LatestRoundDataQueryAsync();

//Show the last price.
Console.WriteLine($"Latest Price { lastRoundData.Answer} of { description }")
```
#### Comple example with domain Ens and price in Eth
```C#
using System;
using Nethereum.Web3;
using Nethereum.ENS;
using NChainlink;
using System.Threading.Tasks;

//Ethereum endpoint URL.
var web3 = new Web3("https://mainnet.infura.io/v3/<KEY>");

//Create a Ens service; 
var ensService = new ENSService(web3);

//Turn an Ens URL into contract address.
var address = await ensService.ResolveAddressAsync("link-eth.data.eth");

//Pass web3 to chainlink to access Ethereum
var chainlink = new Chainlink(web3);

//Address of price feed oracle.
 var pricefeed = chainlink.Pricefeed(address);

//Description, this address contract will return Token pair name.
var description = await pricefeed.DescriptionQueryAsync();

//get all information about the last data.
var lastRoundData = await pricefeed.LatestRoundDataQueryAsync();

//Convert last price in wai to eth
var LastPriceInEth = Web3.Convert.FromWei(lastRoundData.Answer);
//Convert unix time to datetime
var LastUpdateDateTime =  DateTimeOffset.FromUnixTimeSeconds((long)lastRoundData.UpdatedAt); 

//Show latest name,price and time
Console.WriteLine($"Description: { description }\nPrice: {LastPriceInEth}\nTime: { LastUpdateDateTime}")
```

## Goals
- [x] Read pricefeed contract
- [ ] Write pricefeed contract
- [ ] Add support to chainlink market
- [ ] build a website for the documentation
- [ ] Read VRF contract
- [ ] Write VRF contract
