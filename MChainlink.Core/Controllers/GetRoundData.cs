using NChainlink.Models;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;

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
        public Task<RoundDataOutput> GetRoundDataAsync(BigInteger roundId) => Contract.GetFunction("getRoundData").CallDeserializingToObjectAsync<RoundDataOutput>(roundId);
      
    }
}