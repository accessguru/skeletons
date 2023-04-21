using Microsoft.AspNetCore.Components;

namespace Skeleton.Components
{
    public abstract class SkeletonComponentLayoutBase : SkeletonComponentBase
    {
        [Parameter]
        public bool IsBusy { get; set; }
    }
}
