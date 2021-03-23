
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
Links an Azure Notification Hub to this communication service.
.Description
Links an Azure Notification Hub to this communication service.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILinkNotificationHubParameters
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.ICommunicationServiceIdentity
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <ICommunicationServiceIdentity>: Identity Parameter
  [CommunicationServiceName <String>]: The name of the CommunicationService resource.
  [Id <String>]: Resource identity path
  [Location <String>]: The Azure region
  [OperationId <String>]: The ID of an ongoing async operation
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription.

LINKNOTIFICATIONHUBPARAMETER <ILinkNotificationHubParameters>: Description of an Azure Notification Hub to link to the communication service
  ConnectionString <String>: Connection string for the notification hub
  ResourceId <String>: The resource ID of the notification hub
.Link
https://docs.microsoft.com/en-us/powershell/module/az.communicationservice/invoke-azcommunicationservicelinkcommunicationservicenotificationhub
#>
function Invoke-AzCommunicationServiceLinkCommunicationServiceNotificationHub {
[OutputType([System.String])]
[CmdletBinding(DefaultParameterSetName='LinkExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Link', Mandatory)]
    [Parameter(ParameterSetName='LinkExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Path')]
    [System.String]
    # The name of the CommunicationService resource.
    ${CommunicationServiceName},

    [Parameter(ParameterSetName='Link', Mandatory)]
    [Parameter(ParameterSetName='LinkExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Link')]
    [Parameter(ParameterSetName='LinkExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='LinkViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='LinkViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.ICommunicationServiceIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Link', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='LinkViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILinkNotificationHubParameters]
    # Description of an Azure Notification Hub to link to the communication service
    # To construct, see NOTES section for LINKNOTIFICATIONHUBPARAMETER properties and create a hash table.
    ${LinkNotificationHubParameter},

    [Parameter(ParameterSetName='LinkExpanded', Mandatory)]
    [Parameter(ParameterSetName='LinkViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Body')]
    [System.String]
    # Connection string for the notification hub
    ${ConnectionString},

    [Parameter(ParameterSetName='LinkExpanded', Mandatory)]
    [Parameter(ParameterSetName='LinkViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Body')]
    [System.String]
    # The resource ID of the notification hub
    ${ResourceId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
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
            Link = 'Az.CommunicationService.private\Invoke-AzCommunicationServiceLinkCommunicationServiceNotificationHub_Link';
            LinkExpanded = 'Az.CommunicationService.private\Invoke-AzCommunicationServiceLinkCommunicationServiceNotificationHub_LinkExpanded';
            LinkViaIdentity = 'Az.CommunicationService.private\Invoke-AzCommunicationServiceLinkCommunicationServiceNotificationHub_LinkViaIdentity';
            LinkViaIdentityExpanded = 'Az.CommunicationService.private\Invoke-AzCommunicationServiceLinkCommunicationServiceNotificationHub_LinkViaIdentityExpanded';
        }
        if (('Link', 'LinkExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
