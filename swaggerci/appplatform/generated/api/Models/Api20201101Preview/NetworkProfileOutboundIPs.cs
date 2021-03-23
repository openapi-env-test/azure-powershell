namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Desired outbound IP resources for Azure Spring Cloud instance.</summary>
    public partial class NetworkProfileOutboundIPs :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.INetworkProfileOutboundIPs,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.INetworkProfileOutboundIPsInternal
    {

        /// <summary>Internal Acessors for PublicIP</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.INetworkProfileOutboundIPsInternal.PublicIP { get => this._publicIP; set { {_publicIP = value;} } }

        /// <summary>Backing field for <see cref="PublicIP" /> property.</summary>
        private string[] _publicIP;

        /// <summary>A list of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string[] PublicIP { get => this._publicIP; }

        /// <summary>Creates an new <see cref="NetworkProfileOutboundIPs" /> instance.</summary>
        public NetworkProfileOutboundIPs()
        {

        }
    }
    /// Desired outbound IP resources for Azure Spring Cloud instance.
    public partial interface INetworkProfileOutboundIPs :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>A list of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A list of public IP addresses.",
        SerializedName = @"publicIPs",
        PossibleTypes = new [] { typeof(string) })]
        string[] PublicIP { get;  }

    }
    /// Desired outbound IP resources for Azure Spring Cloud instance.
    internal partial interface INetworkProfileOutboundIPsInternal

    {
        /// <summary>A list of public IP addresses.</summary>
        string[] PublicIP { get; set; }

    }
}