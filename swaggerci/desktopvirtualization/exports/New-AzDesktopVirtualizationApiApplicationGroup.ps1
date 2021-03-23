
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
Create or update an applicationGroup.
.Description
Create or update an applicationGroup.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IApplicationGroup
.Link
https://docs.microsoft.com/en-us/powershell/module/az.desktopvirtualizationapi/new-azdesktopvirtualizationapiapplicationgroup
#>
function New-AzDesktopVirtualizationApiApplicationGroup {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IApplicationGroup])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('ApplicationGroupName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [System.String]
    # The name of the application group
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
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationGroupType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationGroupType]
    # Resource Type of ApplicationGroup.
    ${ApplicationGroupType},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # HostPool arm path of ApplicationGroup.
    ${HostPoolArmPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Description of ApplicationGroup.
    ${Description},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Friendly name of ApplicationGroup.
    ${FriendlyName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ResourceIdentityType]
    # The identity type.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g.
    # ApiApps are a kind of Microsoft.Web/sites type.
    # If supported, the resource provider must validate and persist this value.
    ${Kind},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The fully qualified resource ID of the resource that manages this resource.
    # Indicates if this resource is managed by another Azure resource.
    # If this is present, complete mode deployment will not delete the resource if it is removed from the template since it is managed by another resource.
    ${ManagedBy},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The path to the legacy object to migrate.
    ${MigrationRequestMigrationPath},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation]
    # The type of operation for migration.
    ${MigrationRequestOperation},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # A user defined name of the 3rd Party Artifact that is being procured.
    ${PlanName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The 3rd Party artifact that is being procured.
    # E.g.
    # NewRelic.
    # Product maps to the OfferID specified for the artifact at the time of Data Market onboarding.
    ${PlanProduct},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
    ${PlanPromotionCode},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The publisher of the 3rd Party Artifact that is being bought.
    # E.g.
    # NewRelic
    ${PlanPublisher},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The version of the desired product/artifact.
    ${PlanVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.Int32]
    # If the SKU supports scale out/in then the capacity integer should be included.
    # If scale out/in is not possible for the resource this may be omitted.
    ${SkuCapacity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # If the service has different generations of hardware, for the same SKU, then that can be captured here.
    ${SkuFamily},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The name of the SKU.
    # Ex - P3.
    # It is typically a letter+number code
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The SKU size.
    # When the name field is the combination of tier and some other value, this would be the standalone code.
    ${SkuSize},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SkuTier])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SkuTier]
    # This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.
    ${SkuTier},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

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
            CreateExpanded = 'Az.DesktopVirtualizationApi.private\New-AzDesktopVirtualizationApiApplicationGroup_CreateExpanded';
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
