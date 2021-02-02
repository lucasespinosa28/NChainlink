using System.Numerics;
using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get Propose round data.
        ///     <param name="roundId"> The Proposed round ID</param>
        /// </summary>
        /// <returns>
        ///     <list type="bullet">
        ///         <item>
        ///             <term>roundId</term>
        ///             <description>The round ID.</description>
        ///         </item>
        ///         <item>
        ///             <term>answer</term>
        ///             <description>The price.</description>
        ///         </item>
        ///         <item>
        ///             <term>startedAt</term>
        ///             <description>Timestamp of when the round started.</description>
        ///         </item>
        ///         <item>
        ///             <term>updatedAt</term>
        ///             <description>Timestamp of when the round was updated.</description>
        ///         </item>
        ///         <item>
        ///             <term>answeredInRound</term>
        ///             <description>The round ID of the round in which the answer was computed.</description>
        ///         </item>
        ///     </list>
        /// </returns>
        public Task<Model.ProposedGetRoundDataOutputDto> ProposedGetRoundDataQueryAsync(string roundId,
            BlockParameter blockParameter = null)
        {
            return ContractHandler
                .QueryDeserializingToObjectAsync<Model.ProposedGetRoundDataFunction, Model.ProposedGetRoundDataOutputDto
                >(new Model.ProposedGetRoundDataFunction {RoundId = BigInteger.Parse(roundId)}, blockParameter);
        }
    }
}