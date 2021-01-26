# NChainlink [![NuGet](https://img.shields.io/nuget/v/NChainlink)](https://www.nuget.org/packages/NChainlink/) ![License](https://img.shields.io/github/license/lucasespinosa28/NChainlink)

NChainlink is let your acesses chainlink smart contracts using nethereum with minimal lines de code 

## How to use NChainlink 
#### Basic example
```C#
using System;
using Nethereum.Web3;
using NChainlink;
using System.Threading.Tasks;

//Ethereum endpoint URL.
var web3 = new Web3("https://mainnet.infura.io/v3/<KEY>");

//Extend Nethereum.web3 with chainlink . 
var chainlink = web3.Chainlink();

//Address of price feed oracle.
var pricefeed = chainlink.Pricefeed("0x5f4eC3Df9cbd43714FE2740f5E3616155c5b8419");

//Description, this address contract will return Token pair name.
var description = await pricefeed.GetDescriptionAsync();

//get all information about the last data.
var lastRoundData = await pricefeed.GetLatestRoundDataAsync();

//Show the last price.
Console.WriteLine($"Latest Price { lastRoundData.Answer} of { description }")
```
