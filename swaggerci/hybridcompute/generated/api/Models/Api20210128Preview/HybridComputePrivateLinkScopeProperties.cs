namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Properties that define a Azure Arc PrivateLinkScope resource.</summary>
    public partial class HybridComputePrivateLinkScopeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopePropertiesInternal
    {

        /// <summary>Internal Acessors for PrivateLinkScopeId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopePropertiesInternal.PrivateLinkScopeId { get => this._privateLinkScopeId; set { {_privateLinkScopeId = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IHybridComputePrivateLinkScopePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PrivateLinkScopeId" /> property.</summary>
        private string _privateLinkScopeId;

        /// <summary>The Guid id of the private link scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string PrivateLinkScopeId { get => this._privateLinkScopeId; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined.
        /// Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and
        /// Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType? _publicNetworkAccess;

        /// <summary>
        /// Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType? PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Creates an new <see cref="HybridComputePrivateLinkScopeProperties" /> instance.</summary>
        public HybridComputePrivateLinkScopeProperties()
        {

        }
    }
    /// Properties that define a Azure Arc PrivateLinkScope resource.
    public partial interface IHybridComputePrivateLinkScopeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>The Guid id of the private link scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Guid id of the private link scope.",
        SerializedName = @"privateLinkScopeId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkScopeId { get;  }
        /// <summary>
        /// Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined.
        /// Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and
        /// Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and Failed.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>
        /// Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType? PublicNetworkAccess { get; set; }

    }
    /// Properties that define a Azure Arc PrivateLinkScope resource.
    internal partial interface IHybridComputePrivateLinkScopePropertiesInternal

    {
        /// <summary>The Guid id of the private link scope.</summary>
        string PrivateLinkScopeId { get; set; }
        /// <summary>
        /// Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined.
        /// Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and
        /// Failed.
        /// </summary>
        string ProvisioningState { get; set; }
        /// <summary>
        /// Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType? PublicNetworkAccess { get; set; }

    }
}