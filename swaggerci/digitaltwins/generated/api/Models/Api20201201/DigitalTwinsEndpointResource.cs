namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>DigitalTwinsInstance endpoint resource.</summary>
    public partial class DigitalTwinsEndpointResource :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResource,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResource __externalResource = new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.ExternalResource();

        /// <summary>Specifies the authentication type being used for connecting to the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType? AuthenticationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).AuthenticationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).AuthenticationType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType)""); }

        /// <summary>Time when the Endpoint was added to DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).CreatedTime; }

        /// <summary>
        /// Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public string DeadLetterSecret { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).DeadLetterSecret; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).DeadLetterSecret = value ?? null; }

        /// <summary>Dead letter storage URL for identity-based authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public string DeadLetterUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).DeadLetterUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).DeadLetterUri = value ?? null; }

        /// <summary>The type of Digital Twins endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointType EndpointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).EndpointType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).EndpointType = value ; }

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal)__externalResource).Id; }

        /// <summary>Internal Acessors for CreatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceInternal.CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).CreatedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).CreatedTime = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceProperties Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.DigitalTwinsEndpointResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal)__externalResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal)__externalResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal)__externalResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal)__externalResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal)__externalResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal)__externalResource).Type = value; }

        /// <summary>Extension resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal)__externalResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceProperties _property;

        /// <summary>DigitalTwinsInstance endpoint resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.DigitalTwinsEndpointResourceProperties()); set => this._property = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal)__externalResource).Type; }

        /// <summary>Creates an new <see cref="DigitalTwinsEndpointResource" /> instance.</summary>
        public DigitalTwinsEndpointResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__externalResource), __externalResource);
            await eventListener.AssertObjectIsValid(nameof(__externalResource), __externalResource);
        }
    }
    /// DigitalTwinsInstance endpoint resource.
    public partial interface IDigitalTwinsEndpointResource :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResource
    {
        /// <summary>Specifies the authentication type being used for connecting to the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the authentication type being used for connecting to the endpoint.",
        SerializedName = @"authenticationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType? AuthenticationType { get; set; }
        /// <summary>Time when the Endpoint was added to DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time when the Endpoint was added to DigitalTwinsInstance.",
        SerializedName = @"createdTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedTime { get;  }
        /// <summary>
        /// Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dead letter storage secret for key-based authentication. Will be obfuscated during read.",
        SerializedName = @"deadLetterSecret",
        PossibleTypes = new [] { typeof(string) })]
        string DeadLetterSecret { get; set; }
        /// <summary>Dead letter storage URL for identity-based authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dead letter storage URL for identity-based authentication.",
        SerializedName = @"deadLetterUri",
        PossibleTypes = new [] { typeof(string) })]
        string DeadLetterUri { get; set; }
        /// <summary>The type of Digital Twins endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of Digital Twins endpoint",
        SerializedName = @"endpointType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointType EndpointType { get; set; }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? ProvisioningState { get;  }

    }
    /// DigitalTwinsInstance endpoint resource.
    internal partial interface IDigitalTwinsEndpointResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IExternalResourceInternal
    {
        /// <summary>Specifies the authentication type being used for connecting to the endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType? AuthenticationType { get; set; }
        /// <summary>Time when the Endpoint was added to DigitalTwinsInstance.</summary>
        global::System.DateTime? CreatedTime { get; set; }
        /// <summary>
        /// Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        /// </summary>
        string DeadLetterSecret { get; set; }
        /// <summary>Dead letter storage URL for identity-based authentication.</summary>
        string DeadLetterUri { get; set; }
        /// <summary>The type of Digital Twins endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointType EndpointType { get; set; }
        /// <summary>DigitalTwinsInstance endpoint resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceProperties Property { get; set; }
        /// <summary>The provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? ProvisioningState { get; set; }

    }
}