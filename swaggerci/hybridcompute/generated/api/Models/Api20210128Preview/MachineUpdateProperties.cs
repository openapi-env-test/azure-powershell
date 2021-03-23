namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes the ARM updatable properties of a hybrid machine.</summary>
    public partial class MachineUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="LocationData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData _locationData;

        /// <summary>Metadata pertaining to the geographic location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData LocationData { get => (this._locationData = this._locationData ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.LocationData()); set => this._locationData = value; }

        /// <summary>The city or locality where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationDataInternal)LocationData).City; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationDataInternal)LocationData).City = value ?? null; }

        /// <summary>The country or region where the resource is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataCountryOrRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationDataInternal)LocationData).CountryOrRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationDataInternal)LocationData).CountryOrRegion = value ?? null; }

        /// <summary>The district, state, or province where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataDistrict { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationDataInternal)LocationData).District; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationDataInternal)LocationData).District = value ?? null; }

        /// <summary>A canonical name for the geographic or physical location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataName { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationDataInternal)LocationData).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationDataInternal)LocationData).Name = value ?? null; }

        /// <summary>Internal Acessors for LocationData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal.LocationData { get => (this._locationData = this._locationData ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.LocationData()); set { {_locationData = value;} } }

        /// <summary>Backing field for <see cref="PrivateLinkScopeResourceId" /> property.</summary>
        private string _privateLinkScopeResourceId;

        /// <summary>The resource id of the private link scope this machine is assigned to, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string PrivateLinkScopeResourceId { get => this._privateLinkScopeResourceId; set => this._privateLinkScopeResourceId = value; }

        /// <summary>Creates an new <see cref="MachineUpdateProperties" /> instance.</summary>
        public MachineUpdateProperties()
        {

        }
    }
    /// Describes the ARM updatable properties of a hybrid machine.
    public partial interface IMachineUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>The city or locality where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The city or locality where the resource is located.",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataCity { get; set; }
        /// <summary>The country or region where the resource is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The country or region where the resource is located",
        SerializedName = @"countryOrRegion",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataCountryOrRegion { get; set; }
        /// <summary>The district, state, or province where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The district, state, or province where the resource is located.",
        SerializedName = @"district",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataDistrict { get; set; }
        /// <summary>A canonical name for the geographic or physical location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A canonical name for the geographic or physical location.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataName { get; set; }
        /// <summary>The resource id of the private link scope this machine is assigned to, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the private link scope this machine is assigned to, if any.",
        SerializedName = @"privateLinkScopeResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkScopeResourceId { get; set; }

    }
    /// Describes the ARM updatable properties of a hybrid machine.
    internal partial interface IMachineUpdatePropertiesInternal

    {
        /// <summary>Metadata pertaining to the geographic location of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData LocationData { get; set; }
        /// <summary>The city or locality where the resource is located.</summary>
        string LocationDataCity { get; set; }
        /// <summary>The country or region where the resource is located</summary>
        string LocationDataCountryOrRegion { get; set; }
        /// <summary>The district, state, or province where the resource is located.</summary>
        string LocationDataDistrict { get; set; }
        /// <summary>A canonical name for the geographic or physical location.</summary>
        string LocationDataName { get; set; }
        /// <summary>The resource id of the private link scope this machine is assigned to, if any.</summary>
        string PrivateLinkScopeResourceId { get; set; }

    }
}