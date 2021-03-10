namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>
    /// A dictionary of tags that can help identify what a key-value may be applicable for.
    /// </summary>
    public partial class KeyValuePropertiesTags :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyValuePropertiesTags,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyValuePropertiesTagsInternal
    {

        /// <summary>Creates an new <see cref="KeyValuePropertiesTags" /> instance.</summary>
        public KeyValuePropertiesTags()
        {

        }
    }
    /// A dictionary of tags that can help identify what a key-value may be applicable for.
    public partial interface IKeyValuePropertiesTags :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// A dictionary of tags that can help identify what a key-value may be applicable for.
    internal partial interface IKeyValuePropertiesTagsInternal

    {

    }
}