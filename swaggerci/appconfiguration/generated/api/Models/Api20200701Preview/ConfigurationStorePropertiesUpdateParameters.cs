namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>The properties for updating a configuration store.</summary>
    public partial class ConfigurationStorePropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="Encryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionProperties _encryption;

        /// <summary>The encryption settings of the configuration store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionProperties Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.EncryptionProperties()); set => this._encryption = value; }

        /// <summary>The client id of the identity which will be used to access key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyIdentityClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionPropertiesInternal)Encryption).KeyVaultPropertyIdentityClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionPropertiesInternal)Encryption).KeyVaultPropertyIdentityClientId = value ?? null; }

        /// <summary>The URI of the key vault key used to encrypt data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionPropertiesInternal)Encryption).KeyVaultPropertyKeyIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionPropertiesInternal)Encryption).KeyVaultPropertyKeyIdentifier = value ?? null; }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionProperties Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal.Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.EncryptionProperties()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IConfigurationStorePropertiesUpdateParametersInternal.EncryptionKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionPropertiesInternal)Encryption).KeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionPropertiesInternal)Encryption).KeyVaultProperty = value; }

        /// <summary>
        /// Creates an new <see cref="ConfigurationStorePropertiesUpdateParameters" /> instance.
        /// </summary>
        public ConfigurationStorePropertiesUpdateParameters()
        {

        }
    }
    /// The properties for updating a configuration store.
    public partial interface IConfigurationStorePropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
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

    }
    /// The properties for updating a configuration store.
    internal partial interface IConfigurationStorePropertiesUpdateParametersInternal

    {
        /// <summary>The encryption settings of the configuration store.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IEncryptionProperties Encryption { get; set; }
        /// <summary>Key vault properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IKeyVaultProperties EncryptionKeyVaultProperty { get; set; }
        /// <summary>The client id of the identity which will be used to access key vault.</summary>
        string KeyVaultPropertyIdentityClientId { get; set; }
        /// <summary>The URI of the key vault key used to encrypt data.</summary>
        string KeyVaultPropertyKeyIdentifier { get; set; }

    }
}