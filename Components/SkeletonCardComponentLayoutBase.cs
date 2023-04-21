using Microsoft.AspNetCore.Components;

namespace Skeleton.Components
{
    public abstract class SkeletonCardComponentLayoutBase : SkeletonComponentLayoutBase
    {
        /// <summary>
        /// Gets or sets the number of cards.  Defaults to 15.
        /// </summary>
        /// <value>
        /// The number of cards.
        /// </value>
        [Parameter] 
        public byte NumberOfCards { get; set; } = 15;
    }
}
