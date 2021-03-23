namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    public partial class ConnectionPropertiesPrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesPrivateEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionPropertiesPrivateEndpointInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpoint"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpoint __privateEndpoint = new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.PrivateEndpoint();

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointInternal)__privateEndpoint).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointInternal)__privateEndpoint).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointInternal)__privateEndpoint).Id = value; }

        /// <summary>Creates an new <see cref="ConnectionPropertiesPrivateEndpoint" /> instance.</summary>
        public ConnectionPropertiesPrivateEndpoint()
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
            await eventListener.AssertNotNull(nameof(__privateEndpoint), __privateEndpoint);
            await eventListener.AssertObjectIsValid(nameof(__privateEndpoint), __privateEndpoint);
        }
    }
    public partial interface IConnectionPropertiesPrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpoint
    {

    }
    internal partial interface IConnectionPropertiesPrivateEndpointInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointInternal
    {

    }
}