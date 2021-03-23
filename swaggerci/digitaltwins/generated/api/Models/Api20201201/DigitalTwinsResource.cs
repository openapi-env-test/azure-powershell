namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The common properties of a DigitalTwinsInstance.</summary>
    public partial class DigitalTwinsResource :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResource,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentity _identity;

        /// <summary>The managed identity for the DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.DigitalTwinsIdentity()); set => this._identity = value; }

        /// <summary>
        /// The object id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-identity-principal-id
        /// header in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-client-tenant-id header
        /// in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType)""); }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentity Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.DigitalTwinsIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceTags _tag;

        /// <summary>The resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.DigitalTwinsResourceTags()); set => this._tag = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="DigitalTwinsResource" /> instance.</summary>
        public DigitalTwinsResource()
        {

        }
    }
    /// The common properties of a DigitalTwinsInstance.
    public partial interface IDigitalTwinsResource :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>
        /// The object id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-identity-principal-id
        /// header in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The object id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-identity-principal-id header in the PUT request if the resource has a systemAssigned(implicit) identity",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-client-tenant-id header
        /// in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-client-tenant-id header in the PUT request if the resource has a systemAssigned(implicit) identity",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType? IdentityType { get; set; }
        /// <summary>The resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource location.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceTags Tag { get; set; }
        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The common properties of a DigitalTwinsInstance.
    internal partial interface IDigitalTwinsResourceInternal

    {
        /// <summary>The resource identifier.</summary>
        string Id { get; set; }
        /// <summary>The managed identity for the DigitalTwinsInstance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentity Identity { get; set; }
        /// <summary>
        /// The object id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-identity-principal-id
        /// header in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-client-tenant-id header
        /// in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType? IdentityType { get; set; }
        /// <summary>The resource location.</summary>
        string Location { get; set; }
        /// <summary>The resource name.</summary>
        string Name { get; set; }
        /// <summary>The resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceTags Tag { get; set; }
        /// <summary>The resource type.</summary>
        string Type { get; set; }

    }
}