
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
Update the status of a private endpoint connection with the given name.
.Description
Update the status of a private endpoint connection with the given name.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection
.Link
https://docs.microsoft.com/en-us/powershell/module/az.digitaltwins/new-azdigitaltwinsprivateendpointconnection
#>
function New-AzDigitalTwinsPrivateEndpointConnection {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('PrivateEndpointConnectionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
    [System.String]
    # The name of the private endpoint connection.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
    [System.String]
    # The name of the resource group that contains the DigitalTwinsInstance.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
    [System.String]
    # The name of the DigitalTwinsInstance.
    ${ResourceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription identifier.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
    [System.String[]]
    # The list of group ids for the private endpoint connection.
    ${GroupId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
    [System.String]
    # Actions required for a private endpoint connection.
    ${PrivateLinkServiceConnectionStateActionsRequired},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
    [System.String]
    # The description for the current state of a private endpoint connection.
    ${PrivateLinkServiceConnectionStateDescription},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus]
    # The status of a private endpoint connection.
    ${PrivateLinkServiceConnectionStateStatus},

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
            CreateExpanded = 'Az.DigitalTwins.private\New-AzDigitalTwinsPrivateEndpointConnection_CreateExpanded';
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
