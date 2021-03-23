namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The private endpoint connection of a Digital Twin.</summary>
    public partial class PrivateEndpointConnection :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionInternal
    {

        /// <summary>The list of group ids for the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public string[] GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).GroupId = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionInternal.PrivateEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateEndpoint = value; }

        /// <summary>Internal Acessors for PrivateEndpointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionInternal.PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateEndpointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateEndpointId = value; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionInternal.PrivateLinkServiceConnectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionState = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionProperties Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.ConnectionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ConnectionPropertiesProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateEndpointId; }

        /// <summary>Actions required for a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired = value ?? null; }

        /// <summary>The description for the current state of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription = value ?? null; }

        /// <summary>The status of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus? PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus)""); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionProperties _property;

        /// <summary>The properties of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.ConnectionProperties()); set => this._property = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ConnectionPropertiesProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnection" /> instance.</summary>
        public PrivateEndpointConnection()
        {

        }
    }
    /// The private endpoint connection of a Digital Twin.
    public partial interface IPrivateEndpointConnection :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>The list of group ids for the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of group ids for the private endpoint connection.",
        SerializedName = @"groupIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] GroupId { get; set; }
        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointId { get;  }
        /// <summary>Actions required for a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Actions required for a private endpoint connection.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The description for the current state of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description for the current state of a private endpoint connection.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The status of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of a private endpoint connection.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus? PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ConnectionPropertiesProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ConnectionPropertiesProvisioningState? ProvisioningState { get;  }
        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The private endpoint connection of a Digital Twin.
    internal partial interface IPrivateEndpointConnectionInternal

    {
        /// <summary>The list of group ids for the private endpoint connection.</summary>
        string[] GroupId { get; set; }
        /// <summary>The resource identifier.</summary>
        string Id { get; set; }
        /// <summary>The resource name.</summary>
        string Name { get; set; }
        /// <summary>The private endpoint property of a private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary>The resource identifier.</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>The current state of a private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>Actions required for a private endpoint connection.</summary>
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The description for the current state of a private endpoint connection.</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The status of a private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus? PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The properties of a private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionProperties Property { get; set; }
        /// <summary>The provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ConnectionPropertiesProvisioningState? ProvisioningState { get; set; }
        /// <summary>The resource type.</summary>
        string Type { get; set; }

    }
}