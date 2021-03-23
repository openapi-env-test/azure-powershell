namespace Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Extensions;

    /// <summary>HealthBot resource definition</summary>
    public partial class HealthBot :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBot,
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.TrackedResource();

        /// <summary>The link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inlined)]
        public string BotManagementPortalLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotPropertiesInternal)Property).BotManagementPortalLink; }

        /// <summary>Fully qualified resource Id for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for BotManagementPortalLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotInternal.BotManagementPortalLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotPropertiesInternal)Property).BotManagementPortalLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotPropertiesInternal)Property).BotManagementPortalLink = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotProperties Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.HealthBotProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ISku Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotProperties _property;

        /// <summary>The set of properties specific to Healthbot resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.HealthBotProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the Healthbot resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ISku _sku;

        /// <summary>SKU of the HealthBot.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.Sku()); set => this._sku = value; }

        /// <summary>The name of the HealthBot SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.SkuName SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ISkuInternal)Sku).Name = value ; }

        /// <summary>Metadata pertaining to creation and last modification of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.IdentityType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.IdentityType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.IdentityType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.IdentityType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Origin(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="HealthBot" /> instance.</summary>
        public HealthBot()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// HealthBot resource definition
    public partial interface IHealthBot :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ITrackedResource
    {
        /// <summary>The link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The link.",
        SerializedName = @"botManagementPortalLink",
        PossibleTypes = new [] { typeof(string) })]
        string BotManagementPortalLink { get;  }
        /// <summary>The provisioning state of the Healthbot resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the Healthbot resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>The name of the HealthBot SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the HealthBot SKU",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.SkuName SkuName { get; set; }

    }
    /// HealthBot resource definition
    internal partial interface IHealthBotInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ITrackedResourceInternal
    {
        /// <summary>The link.</summary>
        string BotManagementPortalLink { get; set; }
        /// <summary>The set of properties specific to Healthbot resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IHealthBotProperties Property { get; set; }
        /// <summary>The provisioning state of the Healthbot resource.</summary>
        string ProvisioningState { get; set; }
        /// <summary>SKU of the HealthBot.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ISku Sku { get; set; }
        /// <summary>The name of the HealthBot SKU</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Support.SkuName SkuName { get; set; }

    }
}