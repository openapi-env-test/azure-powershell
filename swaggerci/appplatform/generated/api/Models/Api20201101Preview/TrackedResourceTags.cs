namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>
    /// Tags of the service which is a list of key value pairs that describe the resource.
    /// </summary>
    public partial class TrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITrackedResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="TrackedResourceTags" /> instance.</summary>
        public TrackedResourceTags()
        {

        }
    }
    /// Tags of the service which is a list of key value pairs that describe the resource.
    public partial interface ITrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IAssociativeArray<string>
    {

    }
    /// Tags of the service which is a list of key value pairs that describe the resource.
    internal partial interface ITrackedResourceTagsInternal

    {

    }
}