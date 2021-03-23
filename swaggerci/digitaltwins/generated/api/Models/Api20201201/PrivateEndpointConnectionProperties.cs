namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    public partial class PrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionProperties __connectionProperties = new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.ConnectionProperties();

        /// <summary>The list of group ids for the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string[] GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).GroupId = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for PrivateEndpointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal.PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateEndpointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateEndpointId = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ConnectionPropertiesProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).ProvisioningState = value; }

        /// <summary>The private endpoint property of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpoint PrivateEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateEndpoint = value ?? null /* model class */; }

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateEndpointId; }

        /// <summary>The current state of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState PrivateLinkServiceConnectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateLinkServiceConnectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateLinkServiceConnectionState = value ?? null /* model class */; }

        /// <summary>Actions required for a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateLinkServiceConnectionStateActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateLinkServiceConnectionStateActionsRequired = value ?? null; }

        /// <summary>The description for the current state of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateLinkServiceConnectionStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateLinkServiceConnectionStateDescription = value ?? null; }

        /// <summary>The status of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus? PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateLinkServiceConnectionStateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).PrivateLinkServiceConnectionStateStatus = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus)""); }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ConnectionPropertiesProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal)__connectionProperties).ProvisioningState; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionProperties" /> instance.</summary>
        public PrivateEndpointConnectionProperties()
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
            await eventListener.AssertNotNull(nameof(__connectionProperties), __connectionProperties);
            await eventListener.AssertObjectIsValid(nameof(__connectionProperties), __connectionProperties);
        }
    }
    public partial interface IPrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionProperties
    {

    }
    internal partial interface IPrivateEndpointConnectionPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesInternal
    {

    }
}