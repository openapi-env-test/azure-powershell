
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
Create or update a MSIX package.
.Description
Create or update a MSIX package.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IMsixPackage
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PACKAGEAPPLICATION <IMsixPackageApplications[]>: List of package applications. 
  [AppId <String>]: Package Application Id, found in appxmanifest.xml.
  [AppUserModelId <String>]: Used to activate Package Application. Consists of Package Name and ApplicationID. Found in appxmanifest.xml.
  [Description <String>]: Description of Package Application.
  [FriendlyName <String>]: User friendly name.
  [IconImageName <String>]: User friendly name.
  [RawIcon <Byte[]>]: the icon a 64 bit string as a byte array.
  [RawPng <Byte[]>]: the icon a 64 bit string as a byte array.

PACKAGEDEPENDENCY <IMsixPackageDependencies[]>: List of package dependencies. 
  [DependencyName <String>]: Name of package dependency.
  [MinVersion <String>]: Dependency version required.
  [Publisher <String>]: Name of dependency publisher.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.desktopvirtualizationapi/new-azdesktopvirtualizationapimsixpackage
#>
function New-AzDesktopVirtualizationApiMsixPackage {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IMsixPackage])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('MsixPackageFullName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [System.String]
    # The version specific package full name of the MSIX package within specified hostpool
    ${FullName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [System.String]
    # The name of the host pool within the specified resource group
    ${HostPoolName},

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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # User friendly Name to be displayed in the portal.
    ${DisplayName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # VHD/CIM image path on Network Share.
    ${ImagePath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Make this version of the package the active one across the hostpool.
    ${IsActive},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Specifies how to register Package in feed.
    ${IsRegularRegistration},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.DateTime]
    # Date Package was last updated, found in the appxmanifest.xml.
    ${LastUpdated},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IMsixPackageApplications[]]
    # List of package applications.
    # 
    # To construct, see NOTES section for PACKAGEAPPLICATION properties and create a hash table.
    ${PackageApplication},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IMsixPackageDependencies[]]
    # List of package dependencies.
    # 
    # To construct, see NOTES section for PACKAGEDEPENDENCY properties and create a hash table.
    ${PackageDependency},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Package Family Name from appxmanifest.xml.
    # Contains Package Name and Publisher name.
    ${PackageFamilyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Package Name from appxmanifest.xml.
    ${PackageName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Relative Path to the package inside the image.
    ${PackageRelativePath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Package Version found in the appxmanifest.xml.
    ${Version},

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
            CreateExpanded = 'Az.DesktopVirtualizationApi.private\New-AzDesktopVirtualizationApiMsixPackage_CreateExpanded';
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
