namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Deployment settings payload</summary>
    public partial class DeploymentSettings :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettings,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettingsInternal
    {

        /// <summary>Backing field for <see cref="Cpu" /> property.</summary>
        private int? _cpu;

        /// <summary>Required CPU, basic tier should be 1, standard tier should be in range (1, 4)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public int? Cpu { get => this._cpu; set => this._cpu = value; }

        /// <summary>Backing field for <see cref="EnvironmentVariable" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettingsEnvironmentVariables _environmentVariable;

        /// <summary>Collection of environment variables</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettingsEnvironmentVariables EnvironmentVariable { get => (this._environmentVariable = this._environmentVariable ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentSettingsEnvironmentVariables()); set => this._environmentVariable = value; }

        /// <summary>Backing field for <see cref="JvmOption" /> property.</summary>
        private string _jvmOption;

        /// <summary>JVM parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string JvmOption { get => this._jvmOption; set => this._jvmOption = value; }

        /// <summary>Backing field for <see cref="MemoryInGb" /> property.</summary>
        private int? _memoryInGb;

        /// <summary>
        /// Required Memory size in GB, basic tier should be in range (1, 2), standard tier should be in range (1, 8)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public int? MemoryInGb { get => this._memoryInGb; set => this._memoryInGb = value; }

        /// <summary>Backing field for <see cref="NetCoreMainEntryPath" /> property.</summary>
        private string _netCoreMainEntryPath;

        /// <summary>The path to the .NET executable relative to zip root</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string NetCoreMainEntryPath { get => this._netCoreMainEntryPath; set => this._netCoreMainEntryPath = value; }

        /// <summary>Backing field for <see cref="RuntimeVersion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion? _runtimeVersion;

        /// <summary>Runtime version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion? RuntimeVersion { get => this._runtimeVersion; set => this._runtimeVersion = value; }

        /// <summary>Creates an new <see cref="DeploymentSettings" /> instance.</summary>
        public DeploymentSettings()
        {

        }
    }
    /// Deployment settings payload
    public partial interface IDeploymentSettings :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Required CPU, basic tier should be 1, standard tier should be in range (1, 4)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Required CPU, basic tier should be 1, standard tier should be in range (1, 4)",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(int) })]
        int? Cpu { get; set; }
        /// <summary>Collection of environment variables</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of environment variables",
        SerializedName = @"environmentVariables",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettingsEnvironmentVariables) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettingsEnvironmentVariables EnvironmentVariable { get; set; }
        /// <summary>JVM parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"JVM parameter",
        SerializedName = @"jvmOptions",
        PossibleTypes = new [] { typeof(string) })]
        string JvmOption { get; set; }
        /// <summary>
        /// Required Memory size in GB, basic tier should be in range (1, 2), standard tier should be in range (1, 8)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Required Memory size in GB, basic tier should be in range (1, 2), standard tier should be in range (1, 8)",
        SerializedName = @"memoryInGB",
        PossibleTypes = new [] { typeof(int) })]
        int? MemoryInGb { get; set; }
        /// <summary>The path to the .NET executable relative to zip root</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path to the .NET executable relative to zip root",
        SerializedName = @"netCoreMainEntryPath",
        PossibleTypes = new [] { typeof(string) })]
        string NetCoreMainEntryPath { get; set; }
        /// <summary>Runtime version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Runtime version",
        SerializedName = @"runtimeVersion",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion? RuntimeVersion { get; set; }

    }
    /// Deployment settings payload
    internal partial interface IDeploymentSettingsInternal

    {
        /// <summary>Required CPU, basic tier should be 1, standard tier should be in range (1, 4)</summary>
        int? Cpu { get; set; }
        /// <summary>Collection of environment variables</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettingsEnvironmentVariables EnvironmentVariable { get; set; }
        /// <summary>JVM parameter</summary>
        string JvmOption { get; set; }
        /// <summary>
        /// Required Memory size in GB, basic tier should be in range (1, 2), standard tier should be in range (1, 8)
        /// </summary>
        int? MemoryInGb { get; set; }
        /// <summary>The path to the .NET executable relative to zip root</summary>
        string NetCoreMainEntryPath { get; set; }
        /// <summary>Runtime version</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion? RuntimeVersion { get; set; }

    }
}