using System.Threading.Tasks;
using NChainlink.Models;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get the price from the latest round.
        /// </summary>
        /// <returns>
        ///     <list type="bullet">
        ///         <item>
        ///             <term>roundId</term>
        ///             <description>The round ID.</description>
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
        public async Task<Model.RoundDataOutput> GetLatestRoundDataAsync()
        {
            var RounDataFunctionMessage = new Model.LatestRoundData();
            var RounDataHandler = Web.Eth.GetContractQueryHandler<Model.LatestRoundData>();
            return await RounDataHandler.QueryDeserializingToObjectAsync<Model.RoundDataOutput>(RounDataFunctionMessage,
                Contract);
        }
    }
}