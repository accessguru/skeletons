using Microsoft.AspNetCore.Components;

namespace Skeleton.Components
{
    public abstract class SkeletonComponentBase : ComponentBase
    {
        [Parameter]
        public string CssClass { get; set; }
    }
}
