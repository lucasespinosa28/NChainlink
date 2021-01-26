using System.Numerics;
using System.Threading.Tasks;
using NChainlink.Models;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get the price from the latest round.
        ///     <param name="roundId">A double precision number.</param>
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
        public async Task<Model.RoundDataOutput> GetRoundDataAsync(string roundId)
        {
            var RounDataFunctionMessage = new Model.RoundData
            {
                RoundId = BigInteger.Parse(roundId)
            };
            var RounDataHandler = Web.Eth.GetContractQueryHandler<Model.RoundData>();
            return await RounDataHandler.QueryDeserializingToObjectAsync<Model.RoundDataOutput>(RounDataFunctionMessage,
                Contract);
        }
    }
}