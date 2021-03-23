namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>A list of private endpoint connections.</summary>
    public partial class PrivateEndpointConnectionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointConnectionListResult,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointConnectionListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointConnectionListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointConnection[] Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointConnectionListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to retrieve next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointConnection[] _value;

        /// <summary>Array of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointConnection[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionListResult" /> instance.</summary>
        public PrivateEndpointConnectionListResult()
        {

        }
    }
    /// A list of private endpoint connections.
    public partial interface IPrivateEndpointConnectionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Link to retrieve next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link to retrieve next page of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Array of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Array of results.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointConnection[] Value { get;  }

    }
    /// A list of private endpoint connections.
    internal partial interface IPrivateEndpointConnectionListResultInternal

    {
        /// <summary>Link to retrieve next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>Array of results.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointConnection[] Value { get; set; }

    }
}