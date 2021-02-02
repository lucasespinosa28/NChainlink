using System.Threading;
using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        public Task<string> TransferOwnershipRequestAsync(Model.TransferOwnershipFunction transferOwnershipFunction)
        {
            return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(
            Model.TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(string to)
        {
            return ContractHandler.SendRequestAsync(new Model.TransferOwnershipFunction {To = to});
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string to,
            CancellationTokenSource cancellationToken = null)
        {
            return ContractHandler.SendRequestAndWaitForReceiptAsync(new Model.TransferOwnershipFunction {To = to},
                cancellationToken);
        }
    }
}