using System.Collections.Generic;
using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.Contracts;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
       public Task<List<EventLog<Model.OwnershipTransferredEventDto>>> OwnershipTransferredEvent(ulong fromBlock, ulong toBlock)
        {
            var transferEventHandler  = Web3.Eth.GetEvent<Model.OwnershipTransferredEventDto>(Contract);
            var filterAllTransferEventsForContract = transferEventHandler.CreateFilterInput(new BlockParameter(fromBlock), new BlockParameter(toBlock));
            return transferEventHandler.GetAllChanges(filterAllTransferEventsForContract);
        }
    }
}