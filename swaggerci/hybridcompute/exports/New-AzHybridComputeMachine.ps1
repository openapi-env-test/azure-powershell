
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
The operation to create or update a hybrid machine resource identity in Azure.
.Description
The operation to create or update a hybrid machine resource identity in Azure.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachine
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

EXTENSION <IMachineExtensionInstanceView[]>: Machine Extensions information
  [Name <String>]: The machine extension name.
  [StatusCode <String>]: The status code.
  [StatusDisplayStatus <String>]: The short localizable label for the status.
  [StatusLevel <StatusLevelTypes?>]: The level code.
  [StatusMessage <String>]: The detailed status message, including for alerts and error messages.
  [StatusTime <DateTime?>]: The time of the status.
  [Type <String>]: Specifies the type of the extension; an example is "CustomScriptExtension".
  [TypeHandlerVersion <String>]: Specifies the version of the script handler.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.hybridcompute/new-azhybridcomputemachine
#>
function New-AzHybridComputeMachine {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachine])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('MachineName')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [System.String]
    # The name of the hybrid machine.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # Public Key that the client provides to be used during initial resource onboarding
    ${ClientPublicKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineExtensionInstanceView[]]
    # Machine Extensions information
    # To construct, see NOTES section for EXTENSION properties and create a hash table.
    ${Extension},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType]
    # The identity type.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # The city or locality where the resource is located.
    ${LocationDataCity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # The country or region where the resource is located
    ${LocationDataCountryOrRegion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # The district, state, or province where the resource is located.
    ${LocationDataDistrict},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # A canonical name for the geographic or physical location.
    ${LocationDataName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # The resource id of the private link scope this machine is assigned to, if any.
    ${PrivateLinkScopeResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # Specifies the hybrid machine unique ID.
    ${VMId},

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
            CreateExpanded = 'Az.HybridCompute.private\New-AzHybridComputeMachine_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
