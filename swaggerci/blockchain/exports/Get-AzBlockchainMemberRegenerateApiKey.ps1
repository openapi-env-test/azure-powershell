
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
Regenerate the API keys for a blockchain member.
.Description
Regenerate the API keys for a blockchain member.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

APIKEY <IApiKey>: API key payload which is exposed in the request/response of the resource provider.
  [KeyName <String>]: Gets or sets the API key name.
  [Value <String>]: Gets or sets the API key value.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchainmemberregenerateapikey
#>
function Get-AzBlockchainMemberRegenerateApiKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey])]
[CmdletBinding(DefaultParameterSetName='ListExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='List', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey]
    # API key payload which is exposed in the request/response of the resource provider.
    # To construct, see NOTES section for APIKEY properties and create a hash table.
    ${ApiKey},

    [Parameter(ParameterSetName='ListExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the API key name.
    ${KeyName},

    [Parameter(ParameterSetName='ListExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the API key value.
    ${Value},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            List = 'Az.Blockchain.private\Get-AzBlockchainMemberRegenerateApiKey_List';
            ListExpanded = 'Az.Blockchain.private\Get-AzBlockchainMemberRegenerateApiKey_ListExpanded';
        }
        if (('List', 'ListExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
