
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
Create or update an application.
.Description
Create or update an application.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IApplication
.Link
https://docs.microsoft.com/en-us/powershell/module/az.desktopvirtualizationapi/new-azdesktopvirtualizationapiapplication
#>
function New-AzDesktopVirtualizationApiApplication {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IApplication])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('ApplicationGroupName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [System.String]
    # The name of the application group
    ${GroupName},

    [Parameter(Mandatory)]
    [Alias('ApplicationName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [System.String]
    # The name of the application within the specified application group
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CommandLineSetting])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CommandLineSetting]
    # Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all.
    ${CommandLineSetting},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RemoteApplicationType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RemoteApplicationType]
    # Resource Type of Application.
    ${ApplicationType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Command Line Arguments for Application.
    ${CommandLineArgument},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Description of Application.
    ${Description},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Specifies a path for the executable file for the application.
    ${FilePath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Friendly name of Application.
    ${FriendlyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.Int32]
    # Index of the icon.
    ${IconIndex},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Path to icon.
    ${IconPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Specifies the package application Id for MSIX applications
    ${MsixPackageApplicationId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Specifies the package family name for MSIX applications
    ${MsixPackageFamilyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Specifies whether to show the RemoteApp program in the RD Web Access server.
    ${ShowInPortal},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
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
            CreateExpanded = 'Az.DesktopVirtualizationApi.private\New-AzDesktopVirtualizationApiApplication_CreateExpanded';
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
