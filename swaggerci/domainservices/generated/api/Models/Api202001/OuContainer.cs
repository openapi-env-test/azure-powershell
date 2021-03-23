namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>Resource for OuContainer.</summary>
    public partial class OuContainer :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.Resource();

        /// <summary>The list of container accounts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount[] Account { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).Account; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).Account = value ?? null /* arrayOf */; }

        /// <summary>The OuContainer name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inlined)]
        public string ContainerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).ContainerId; }

        /// <summary>The Deployment id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inlined)]
        public string DeploymentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).DeploymentId; }

        /// <summary>Distinguished Name of OuContainer instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inlined)]
        public string DistinguishedName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).DistinguishedName; }

        /// <summary>The domain name of Domain Services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inlined)]
        public string DomainName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).DomainName; }

        /// <summary>Resource etag</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Etag = value ?? null; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Id; }

        /// <summary>Resource location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for ContainerId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal.ContainerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).ContainerId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).ContainerId = value; }

        /// <summary>Internal Acessors for DeploymentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal.DeploymentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).DeploymentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).DeploymentId = value; }

        /// <summary>Internal Acessors for DistinguishedName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal.DistinguishedName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).DistinguishedName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).DistinguishedName = value; }

        /// <summary>Internal Acessors for DomainName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal.DomainName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).DomainName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).DomainName = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerProperties Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.OuContainerProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ServiceStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal.ServiceStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).ServiceStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).ServiceStatus = value; }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerInternal.TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).TenantId = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerProperties _property;

        /// <summary>OuContainer properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.OuContainerProperties()); set => this._property = value; }

        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Status of OuContainer instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inlined)]
        public string ServiceStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).ServiceStatus; }

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Azure Active Directory tenant id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inlined)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal)Property).TenantId; }

        /// <summary>Resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="OuContainer" /> instance.</summary>
        public OuContainer()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Resource for OuContainer.
    public partial interface IOuContainer :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResource
    {
        /// <summary>The list of container accounts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of container accounts",
        SerializedName = @"accounts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount[] Account { get; set; }
        /// <summary>The OuContainer name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The OuContainer name",
        SerializedName = @"containerId",
        PossibleTypes = new [] { typeof(string) })]
        string ContainerId { get;  }
        /// <summary>The Deployment id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Deployment id",
        SerializedName = @"deploymentId",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentId { get;  }
        /// <summary>Distinguished Name of OuContainer instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Distinguished Name of OuContainer instance",
        SerializedName = @"distinguishedName",
        PossibleTypes = new [] { typeof(string) })]
        string DistinguishedName { get;  }
        /// <summary>The domain name of Domain Services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The domain name of Domain Services.",
        SerializedName = @"domainName",
        PossibleTypes = new [] { typeof(string) })]
        string DomainName { get;  }
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current deployment or provisioning state, which only appears in the response.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>Status of OuContainer instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of OuContainer instance",
        SerializedName = @"serviceStatus",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceStatus { get;  }
        /// <summary>Azure Active Directory tenant id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure Active Directory tenant id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }

    }
    /// Resource for OuContainer.
    internal partial interface IOuContainerInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceInternal
    {
        /// <summary>The list of container accounts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount[] Account { get; set; }
        /// <summary>The OuContainer name</summary>
        string ContainerId { get; set; }
        /// <summary>The Deployment id</summary>
        string DeploymentId { get; set; }
        /// <summary>Distinguished Name of OuContainer instance</summary>
        string DistinguishedName { get; set; }
        /// <summary>The domain name of Domain Services.</summary>
        string DomainName { get; set; }
        /// <summary>OuContainer properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerProperties Property { get; set; }
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response.
        /// </summary>
        string ProvisioningState { get; set; }
        /// <summary>Status of OuContainer instance</summary>
        string ServiceStatus { get; set; }
        /// <summary>Azure Active Directory tenant id</summary>
        string TenantId { get; set; }

    }
}