
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
Update metadata of DigitalTwinsInstance.
.Description
Update metadata of DigitalTwinsInstance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsDescription
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDigitalTwinsIdentity>: Identity Parameter
  [EndpointName <String>]: Name of Endpoint Resource.
  [Id <String>]: Resource identity path
  [Location <String>]: Location of DigitalTwinsInstance.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection.
  [ResourceGroupName <String>]: The name of the resource group that contains the DigitalTwinsInstance.
  [ResourceId <String>]: The name of the private link resource.
  [ResourceName <String>]: The name of the DigitalTwinsInstance.
  [SubscriptionId <String>]: The subscription identifier.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.digitaltwins/update-azdigitaltwinsdigitaltwin
#>
function Update-AzDigitalTwinsDigitalTwin {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsDescription])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
    [System.String]
    # The name of the resource group that contains the DigitalTwinsInstance.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
    [System.String]
    # The name of the DigitalTwinsInstance.
    ${ResourceName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription identifier.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType]
    # The type of Managed Identity used by the DigitalTwinsInstance.
    # Only SystemAssigned is supported.
    ${IdentityType},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess])]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess]
    # Public network access for the DigitalTwinsInstance.
    ${PublicNetworkAccess},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPatchDescriptionTags]))]
    [System.Collections.Hashtable]
    # Instance patch properties
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
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
            UpdateExpanded = 'Az.DigitalTwins.private\Update-AzDigitalTwinsDigitalTwin_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.DigitalTwins.private\Update-AzDigitalTwinsDigitalTwin_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
