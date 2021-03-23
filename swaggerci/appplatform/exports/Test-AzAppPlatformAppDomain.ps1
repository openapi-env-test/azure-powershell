
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Check the resource name is valid as well as not in use.
.Description
Check the resource name is valid as well as not in use.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ICustomDomainValidatePayload
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.IAppPlatformIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ICustomDomainValidateResult
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IAppPlatformIdentity>: Identity Parameter
  [AppName <String>]: The name of the App resource.
  [BindingName <String>]: The name of the Binding resource.
  [CertificateName <String>]: The name of the certificate resource.
  [DeploymentName <String>]: The name of the Deployment resource.
  [DomainName <String>]: The name of the custom domain resource.
  [Id <String>]: Resource identity path
  [Location <String>]: the region
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [ServiceName <String>]: The name of the Service resource.
  [SubscriptionId <String>]: Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

VALIDATEPAYLOAD <ICustomDomainValidatePayload>: Custom domain validate payload.
  Name <String>: Name to be validated
.Link
https://docs.microsoft.com/en-us/powershell/module/az.appplatform/test-azappplatformappdomain
#>
function Test-AzAppPlatformAppDomain {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ICustomDomainValidateResult])]
[CmdletBinding(DefaultParameterSetName='ValidateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Validate', Mandatory)]
    [Parameter(ParameterSetName='ValidateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [System.String]
    # The name of the App resource.
    ${AppName},

    [Parameter(ParameterSetName='Validate', Mandatory)]
    [Parameter(ParameterSetName='ValidateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Validate', Mandatory)]
    [Parameter(ParameterSetName='ValidateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [System.String]
    # The name of the Service resource.
    ${ServiceName},

    [Parameter(ParameterSetName='Validate')]
    [Parameter(ParameterSetName='ValidateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription ID which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='ValidateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ValidateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.IAppPlatformIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Validate', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ValidateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ICustomDomainValidatePayload]
    # Custom domain validate payload.
    # To construct, see NOTES section for VALIDATEPAYLOAD properties and create a hash table.
    ${ValidatePayload},

    [Parameter(ParameterSetName='ValidateExpanded', Mandatory)]
    [Parameter(ParameterSetName='ValidateViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Name to be validated
    ${Name},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Validate = 'Az.AppPlatform.private\Test-AzAppPlatformAppDomain_Validate';
            ValidateExpanded = 'Az.AppPlatform.private\Test-AzAppPlatformAppDomain_ValidateExpanded';
            ValidateViaIdentity = 'Az.AppPlatform.private\Test-AzAppPlatformAppDomain_ValidateViaIdentity';
            ValidateViaIdentityExpanded = 'Az.AppPlatform.private\Test-AzAppPlatformAppDomain_ValidateViaIdentityExpanded';
        }
        if (('Validate', 'ValidateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
