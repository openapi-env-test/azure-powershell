
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
Returns a Azure Arc PrivateLinkScope's validation details.
.Description
Returns a Azure Arc PrivateLinkScope's validation details.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IHybridComputeIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopeValidationDetails
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IHybridComputeIdentity>: Identity Parameter
  [ExtensionName <String>]: The name of the machine extension.
  [GroupName <String>]: The name of the private link resource.
  [Id <String>]: Resource identity path
  [Location <String>]: The location of the target resource.
  [MachineName <String>]: The name of the hybrid machine.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection.
  [PrivateLinkScopeId <String>]: The id (Guid) of the Azure Arc PrivateLinkScope resource.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScopeName <String>]: The name of the Azure Arc PrivateLinkScope resource.
  [SubscriptionId <String>]: The ID of the target subscription.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.hybridcompute/get-azhybridcomputeprivatelinkscopevalidationdetail
#>
function Get-AzHybridComputePrivateLinkScopeValidationDetail {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IPrivateLinkScopeValidationDetails])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [System.String]
    # The location of the target resource.
    ${Location},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [System.String]
    # The id (Guid) of the Azure Arc PrivateLinkScope resource.
    ${PrivateLinkScopeId},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='Get1')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get1', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [System.String]
    # The name of the target machine to get the private link scope validation details for.
    ${MachineName},

    [Parameter(ParameterSetName='Get1', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='GetViaIdentity1', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IHybridComputeIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
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
            Get = 'Az.HybridCompute.private\Get-AzHybridComputePrivateLinkScopeValidationDetail_Get';
            Get1 = 'Az.HybridCompute.private\Get-AzHybridComputePrivateLinkScopeValidationDetail_Get1';
            GetViaIdentity = 'Az.HybridCompute.private\Get-AzHybridComputePrivateLinkScopeValidationDetail_GetViaIdentity';
            GetViaIdentity1 = 'Az.HybridCompute.private\Get-AzHybridComputePrivateLinkScopeValidationDetail_GetViaIdentity1';
        }
        if (('Get', 'Get1') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
