namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    public partial class AvailableRuntimeVersions :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAvailableRuntimeVersions,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAvailableRuntimeVersionsInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ISupportedRuntimeVersion[] Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAvailableRuntimeVersionsInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ISupportedRuntimeVersion[] _value;

        /// <summary>A list of all supported runtime versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ISupportedRuntimeVersion[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="AvailableRuntimeVersions" /> instance.</summary>
        public AvailableRuntimeVersions()
        {

        }
    }
    public partial interface IAvailableRuntimeVersions :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>A list of all supported runtime versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A list of all supported runtime versions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ISupportedRuntimeVersion) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ISupportedRuntimeVersion[] Value { get;  }

    }
    internal partial interface IAvailableRuntimeVersionsInternal

    {
        /// <summary>A list of all supported runtime versions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ISupportedRuntimeVersion[] Value { get; set; }

    }
}