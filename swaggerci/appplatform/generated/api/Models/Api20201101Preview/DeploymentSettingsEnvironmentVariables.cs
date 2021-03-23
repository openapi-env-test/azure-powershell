namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Collection of environment variables</summary>
    public partial class DeploymentSettingsEnvironmentVariables :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettingsEnvironmentVariables,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettingsEnvironmentVariablesInternal
    {

        /// <summary>Creates an new <see cref="DeploymentSettingsEnvironmentVariables" /> instance.</summary>
        public DeploymentSettingsEnvironmentVariables()
        {

        }
    }
    /// Collection of environment variables
    public partial interface IDeploymentSettingsEnvironmentVariables :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IAssociativeArray<string>
    {

    }
    /// Collection of environment variables
    internal partial interface IDeploymentSettingsEnvironmentVariablesInternal

    {

    }
}