namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    public partial class ConnectionPropertiesPrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesPrivateLinkServiceConnectionState,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesPrivateLinkServiceConnectionStateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState __connectionState = new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.ConnectionState();

        /// <summary>Actions required for a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string ActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)__connectionState).ActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)__connectionState).ActionsRequired = value ?? null; }

        /// <summary>The description for the current state of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)__connectionState).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)__connectionState).Description = value ; }

        /// <summary>The status of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)__connectionState).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)__connectionState).Status = value ; }

        /// <summary>
        /// Creates an new <see cref="ConnectionPropertiesPrivateLinkServiceConnectionState" /> instance.
        /// </summary>
        public ConnectionPropertiesPrivateLinkServiceConnectionState()
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
            await eventListener.AssertNotNull(nameof(__connectionState), __connectionState);
            await eventListener.AssertObjectIsValid(nameof(__connectionState), __connectionState);
        }
    }
    public partial interface IConnectionPropertiesPrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState
    {

    }
    internal partial interface IConnectionPropertiesPrivateLinkServiceConnectionStateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal
    {

    }
}