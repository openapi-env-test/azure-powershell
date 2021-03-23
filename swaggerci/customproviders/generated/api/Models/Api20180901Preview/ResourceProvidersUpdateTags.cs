namespace Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Runtime.Extensions;

    /// <summary>Resource tags</summary>
    public partial class ResourceProvidersUpdateTags :
        Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.IResourceProvidersUpdateTags,
        Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.IResourceProvidersUpdateTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceProvidersUpdateTags" /> instance.</summary>
        public ResourceProvidersUpdateTags()
        {

        }
    }
    /// Resource tags
    public partial interface IResourceProvidersUpdateTags :
        Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags
    internal partial interface IResourceProvidersUpdateTagsInternal

    {

    }
}