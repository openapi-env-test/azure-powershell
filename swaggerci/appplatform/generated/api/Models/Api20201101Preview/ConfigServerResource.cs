namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Config Server resource</summary>
    public partial class ConfigServerResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerResource,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.Resource();

        /// <summary>The code of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).Code = value ?? null; }

        /// <summary>Public sshKey of git repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string GitPropertyHostKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyHostKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyHostKey = value ?? null; }

        /// <summary>SshKey algorithm of git repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string GitPropertyHostKeyAlgorithm { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyHostKeyAlgorithm; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyHostKeyAlgorithm = value ?? null; }

        /// <summary>Label of the repository</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string GitPropertyLabel { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyLabel; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyLabel = value ?? null; }

        /// <summary>Password of git repository basic auth.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string GitPropertyPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyPassword = value ?? null; }

        /// <summary>Private sshKey algorithm of git repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string GitPropertyPrivateKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyPrivateKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyPrivateKey = value ?? null; }

        /// <summary>Repositories of git.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IGitPatternRepository[] GitPropertyRepository { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyRepository; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyRepository = value ?? null /* arrayOf */; }

        /// <summary>Searching path of the repository</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string[] GitPropertySearchPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertySearchPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertySearchPath = value ?? null /* arrayOf */; }

        /// <summary>Strict host key checking or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public bool? GitPropertyStrictHostKeyChecking { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyStrictHostKeyChecking; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyStrictHostKeyChecking = value ?? default(bool); }

        /// <summary>URI of the repository</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string GitPropertyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyUri = value ?? null; }

        /// <summary>Username of git repository basic auth.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string GitPropertyUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).GitPropertyUsername = value ?? null; }

        /// <summary>Fully qualified resource Id for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Id; }

        /// <summary>The message of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).Message = value ?? null; }

        /// <summary>Internal Acessors for ConfigServer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerSettings Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerResourceInternal.ConfigServer { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).ConfigServer; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).ConfigServer = value; }

        /// <summary>Internal Acessors for ConfigServerGitProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerGitProperty Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerResourceInternal.ConfigServerGitProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).ConfigServerGitProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).ConfigServerGitProperty = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IError Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerResourceInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).Error = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerProperties Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ConfigServerProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ConfigServerState? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerProperties _property;

        /// <summary>Properties of the Config Server resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ConfigServerProperties()); set => this._property = value; }

        /// <summary>State of the config server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ConfigServerState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="ConfigServerResource" /> instance.</summary>
        public ConfigServerResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Config Server resource
    public partial interface IConfigServerResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResource
    {
        /// <summary>The code of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The code of error.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>Public sshKey of git repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Public sshKey of git repository.",
        SerializedName = @"hostKey",
        PossibleTypes = new [] { typeof(string) })]
        string GitPropertyHostKey { get; set; }
        /// <summary>SshKey algorithm of git repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SshKey algorithm of git repository.",
        SerializedName = @"hostKeyAlgorithm",
        PossibleTypes = new [] { typeof(string) })]
        string GitPropertyHostKeyAlgorithm { get; set; }
        /// <summary>Label of the repository</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Label of the repository",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string GitPropertyLabel { get; set; }
        /// <summary>Password of git repository basic auth.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Password of git repository basic auth.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string GitPropertyPassword { get; set; }
        /// <summary>Private sshKey algorithm of git repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Private sshKey algorithm of git repository.",
        SerializedName = @"privateKey",
        PossibleTypes = new [] { typeof(string) })]
        string GitPropertyPrivateKey { get; set; }
        /// <summary>Repositories of git.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Repositories of git.",
        SerializedName = @"repositories",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IGitPatternRepository) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IGitPatternRepository[] GitPropertyRepository { get; set; }
        /// <summary>Searching path of the repository</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Searching path of the repository",
        SerializedName = @"searchPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] GitPropertySearchPath { get; set; }
        /// <summary>Strict host key checking or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Strict host key checking or not.",
        SerializedName = @"strictHostKeyChecking",
        PossibleTypes = new [] { typeof(bool) })]
        bool? GitPropertyStrictHostKeyChecking { get; set; }
        /// <summary>URI of the repository</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI of the repository",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string GitPropertyUri { get; set; }
        /// <summary>Username of git repository basic auth.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Username of git repository basic auth.",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string GitPropertyUsername { get; set; }
        /// <summary>The message of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The message of error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>State of the config server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State of the config server.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ConfigServerState) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ConfigServerState? ProvisioningState { get;  }

    }
    /// Config Server resource
    internal partial interface IConfigServerResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal
    {
        /// <summary>The code of error.</summary>
        string Code { get; set; }
        /// <summary>Settings of config server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerSettings ConfigServer { get; set; }
        /// <summary>Property of git environment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerGitProperty ConfigServerGitProperty { get; set; }
        /// <summary>Error when apply config server settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IError Error { get; set; }
        /// <summary>Public sshKey of git repository.</summary>
        string GitPropertyHostKey { get; set; }
        /// <summary>SshKey algorithm of git repository.</summary>
        string GitPropertyHostKeyAlgorithm { get; set; }
        /// <summary>Label of the repository</summary>
        string GitPropertyLabel { get; set; }
        /// <summary>Password of git repository basic auth.</summary>
        string GitPropertyPassword { get; set; }
        /// <summary>Private sshKey algorithm of git repository.</summary>
        string GitPropertyPrivateKey { get; set; }
        /// <summary>Repositories of git.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IGitPatternRepository[] GitPropertyRepository { get; set; }
        /// <summary>Searching path of the repository</summary>
        string[] GitPropertySearchPath { get; set; }
        /// <summary>Strict host key checking or not.</summary>
        bool? GitPropertyStrictHostKeyChecking { get; set; }
        /// <summary>URI of the repository</summary>
        string GitPropertyUri { get; set; }
        /// <summary>Username of git repository basic auth.</summary>
        string GitPropertyUsername { get; set; }
        /// <summary>The message of error.</summary>
        string Message { get; set; }
        /// <summary>Properties of the Config Server resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IConfigServerProperties Property { get; set; }
        /// <summary>State of the config server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ConfigServerState? ProvisioningState { get; set; }

    }
}