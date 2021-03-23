namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes a hybrid machine Update.</summary>
    public partial class MachineUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IResourceUpdate"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IResourceUpdate __resourceUpdate = new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.ResourceUpdate();

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentity _identity;

        /// <summary>Identity for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.Identity()); set => this._identity = value; }

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).PrincipalId; }

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).TenantId; }

        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType)""); }

        /// <summary>The city or locality where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).LocationDataCity; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).LocationDataCity = value ?? null; }

        /// <summary>The country or region where the resource is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataCountryOrRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).LocationDataCountryOrRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).LocationDataCountryOrRegion = value ?? null; }

        /// <summary>The district, state, or province where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataDistrict { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).LocationDataDistrict; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).LocationDataDistrict = value ?? null; }

        /// <summary>A canonical name for the geographic or physical location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataName { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).LocationDataName; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).LocationDataName = value ?? null; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentity Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.Identity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for LocationData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateInternal.LocationData { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).LocationData; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).LocationData = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.MachineUpdateProperties()); set { {_property = value;} } }

        /// <summary>The resource id of the private link scope this machine is assigned to, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string PrivateLinkScopeResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).PrivateLinkScopeResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdatePropertiesInternal)Property).PrivateLinkScopeResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateProperties _property;

        /// <summary>Hybrid Compute Machine properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.MachineUpdateProperties()); set => this._property = value; }

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IResourceUpdateTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IResourceUpdateInternal)__resourceUpdate).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IResourceUpdateInternal)__resourceUpdate).Tag = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="MachineUpdate" /> instance.</summary>
        public MachineUpdate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceUpdate), __resourceUpdate);
            await eventListener.AssertObjectIsValid(nameof(__resourceUpdate), __resourceUpdate);
        }
    }
    /// Describes a hybrid machine Update.
    public partial interface IMachineUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IResourceUpdate
    {
        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal ID of resource identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of resource.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType? IdentityType { get; set; }
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
    /// Describes a hybrid machine Update.
    internal partial interface IMachineUpdateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IResourceUpdateInternal
    {
        /// <summary>Identity for the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentity Identity { get; set; }
        /// <summary>The principal ID of resource identity.</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        string IdentityTenantId { get; set; }
        /// <summary>The identity type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType? IdentityType { get; set; }
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
        /// <summary>Hybrid Compute Machine properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineUpdateProperties Property { get; set; }

    }
}