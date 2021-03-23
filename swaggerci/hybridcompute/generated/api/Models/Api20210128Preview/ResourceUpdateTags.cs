namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Resource tags</summary>
    public partial class ResourceUpdateTags :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IResourceUpdateTags,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IResourceUpdateTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceUpdateTags" /> instance.</summary>
        public ResourceUpdateTags()
        {

        }
    }
    /// Resource tags
    public partial interface IResourceUpdateTags :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags
    internal partial interface IResourceUpdateTagsInternal

    {

    }
}