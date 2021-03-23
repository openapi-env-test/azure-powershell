namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>The parameters for updating a configuration store.</summary>
    public partial class ConfigurationStoreUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentity _identity;

        /// <summary>The managed identity information for the configuration store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ResourceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The principal id of the identity. This property will only be provided for a system-assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant id associated with the resource's identity. This property will only be provided for a system-assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identities.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType)""); }

        /// <summary>
        /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
        /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The client id of the identity which will be used to access key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyIdentityClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal)Property).KeyVaultPropertyIdentityClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal)Property).KeyVaultPropertyIdentityClientId = value ?? null; }

        /// <summary>The URI of the key vault key used to encrypt data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal)Property).KeyVaultPropertyKeyIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal)Property).KeyVaultPropertyKeyIdentifier = value ?? null; }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionProperties Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersInternal.Encryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal)Property).Encryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal)Property).Encryption = value; }

        /// <summary>Internal Acessors for EncryptionKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersInternal.EncryptionKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal)Property).EncryptionKeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal)Property).EncryptionKeyVaultProperty = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentity Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ResourceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParameters Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ConfigurationStorePropertiesUpdateParameters()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ISku Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.Sku()); set { {_sku = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParameters _property;

        /// <summary>The properties for updating a configuration store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParameters Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ConfigurationStorePropertiesUpdateParameters()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ISku _sku;

        /// <summary>The SKU of the configuration store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.Sku()); set => this._sku = value; }

        /// <summary>The SKU name of the configuration store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ISkuInternal)Sku).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersTags _tag;

        /// <summary>The ARM resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ConfigurationStoreUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ConfigurationStoreUpdateParameters" /> instance.</summary>
        public ConfigurationStoreUpdateParameters()
        {

        }
    }
    /// The parameters for updating a configuration store.
    public partial interface IConfigurationStoreUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The principal id of the identity. This property will only be provided for a system-assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal id of the identity. This property will only be provided for a system-assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant id associated with the resource's identity. This property will only be provided for a system-assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant id associated with the resource's identity. This property will only be provided for a system-assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identities.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identities.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType? IdentityType { get; set; }
        /// <summary>
        /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
        /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>The client id of the identity which will be used to access key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The client id of the identity which will be used to access key vault.",
        SerializedName = @"identityClientId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyIdentityClientId { get; set; }
        /// <summary>The URI of the key vault key used to encrypt data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI of the key vault key used to encrypt data.",
        SerializedName = @"keyIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyIdentifier { get; set; }
        /// <summary>The SKU name of the configuration store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SKU name of the configuration store.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>The ARM resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ARM resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersTags Tag { get; set; }

    }
    /// The parameters for updating a configuration store.
    internal partial interface IConfigurationStoreUpdateParametersInternal

    {
        /// <summary>The encryption settings of the configuration store.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionProperties Encryption { get; set; }
        /// <summary>Key vault properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyVaultProperties EncryptionKeyVaultProperty { get; set; }
        /// <summary>The managed identity information for the configuration store.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentity Identity { get; set; }
        /// <summary>
        /// The principal id of the identity. This property will only be provided for a system-assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant id associated with the resource's identity. This property will only be provided for a system-assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identities.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType? IdentityType { get; set; }
        /// <summary>
        /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
        /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>The client id of the identity which will be used to access key vault.</summary>
        string KeyVaultPropertyIdentityClientId { get; set; }
        /// <summary>The URI of the key vault key used to encrypt data.</summary>
        string KeyVaultPropertyKeyIdentifier { get; set; }
        /// <summary>The properties for updating a configuration store.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParameters Property { get; set; }
        /// <summary>The SKU of the configuration store.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ISku Sku { get; set; }
        /// <summary>The SKU name of the configuration store.</summary>
        string SkuName { get; set; }
        /// <summary>The ARM resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStoreUpdateParametersTags Tag { get; set; }

    }
}