namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Private endpoint which the connection belongs to.</summary>
    public partial class PrivateEndpointProperty :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointProperty,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateEndpointPropertyInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource id of the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="PrivateEndpointProperty" /> instance.</summary>
        public PrivateEndpointProperty()
        {

        }
    }
    /// Private endpoint which the connection belongs to.
    public partial interface IPrivateEndpointProperty :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Resource id of the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource id of the private endpoint.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Private endpoint which the connection belongs to.
    internal partial interface IPrivateEndpointPropertyInternal

    {
        /// <summary>Resource id of the private endpoint.</summary>
        string Id { get; set; }

    }
}