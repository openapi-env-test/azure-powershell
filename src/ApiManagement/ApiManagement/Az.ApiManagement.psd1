#
# Module manifest for module 'Az.ApiManagement'
#
# Generated by: Microsoft Corporation
#
# Generated on: 12/12/2018
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '1.0.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '4f58d643-631f-4d13-a205-15292af40748'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Api Management service cmdlets for Azure Resource Manager in Windows PowerShell and PowerShell Core.

For more information Api Management, please visit the following: https://docs.microsoft.com/azure/api-management/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '1.4.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = '.\AutoMapper.dll', 
               '.\Microsoft.Azure.Management.ApiManagement.dll', 
               '.\Microsoft.WindowsAzure.Storage.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('.\Microsoft.Azure.PowerShell.Cmdlets.ApiManagement.dll', 
    '.\Microsoft.Azure.PowerShell.Cmdlets.ApiManagement.ServiceManagement.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Add-AzApiManagementRegion', 'Get-AzApiManagementSsoToken', 
               'New-AzApiManagementCustomHostnameConfiguration', 
               'New-AzApiManagementSystemCertificate', 'New-AzApiManagementRegion', 
               'New-AzApiManagementVirtualNetwork', 'Remove-AzApiManagementRegion', 
               'Update-AzApiManagementRegion', 'Backup-AzApiManagement', 
               'Get-AzApiManagement', 'New-AzApiManagement', 
               'Remove-AzApiManagement', 'Restore-AzApiManagement', 
               'Add-AzApiManagementApiToProduct', 
               'Add-AzApiManagementProductToGroup', 
               'Add-AzApiManagementUserToGroup', 'Export-AzApiManagementApi', 
               'Get-AzApiManagementApi', 'Get-AzApiManagementApiRelease', 
               'Get-AzApiManagementApiRevision', 
               'Get-AzApiManagementApiVersionSet', 
               'Get-AzApiManagementAuthorizationServer', 
               'Get-AzApiManagementCertificate', 'Get-AzApiManagementGroup', 
               'Get-AzApiManagementLogger', 
               'Get-AzApiManagementOpenIdConnectProvider', 
               'Get-AzApiManagementOperation', 'Get-AzApiManagementPolicy', 
               'Get-AzApiManagementProduct', 'Get-AzApiManagementProperty', 
               'Get-AzApiManagementSubscription', 
               'Get-AzApiManagementTenantSyncState', 'Get-AzApiManagementUser', 
               'Get-AzApiManagementUserSsoUrl', 'Get-AzApiManagementTenantAccess', 
               'Get-AzApiManagementTenantGitAccess', 'Import-AzApiManagementApi', 
               'New-AzApiManagementApi', 'New-AzApiManagementApiRevision', 
               'New-AzApiManagementApiRelease', 'New-AzApiManagementApiVersionSet', 
               'New-AzApiManagementAuthorizationServer', 
               'New-AzApiManagementCertificate', 'New-AzApiManagementContext', 
               'New-AzApiManagementGroup', 'New-AzApiManagementLogger', 
               'New-AzApiManagementOpenIdConnectProvider', 
               'New-AzApiManagementOperation', 'New-AzApiManagementProduct', 
               'New-AzApiManagementSubscription', 
               'New-AzApiManagementBackendServiceFabric', 
               'New-AzApiManagementUser', 'New-AzApiManagementProperty', 
               'Publish-AzApiManagementTenantGitConfiguration', 
               'Remove-AzApiManagementApi', 'Remove-AzApiManagementApiRelease', 
               'Remove-AzApiManagementApiRevision', 
               'Remove-AzApiManagementApiVersionSet', 
               'Remove-AzApiManagementApiFromProduct', 
               'Remove-AzApiManagementAuthorizationServer', 
               'Remove-AzApiManagementCertificate', 'Remove-AzApiManagementGroup', 
               'Remove-AzApiManagementLogger', 
               'Remove-AzApiManagementOpenIdConnectProvider', 
               'Remove-AzApiManagementOperation', 'Remove-AzApiManagementPolicy', 
               'Remove-AzApiManagementProduct', 
               'Remove-AzApiManagementProductFromGroup', 
               'Remove-AzApiManagementProperty', 
               'Remove-AzApiManagementSubscription', 'Remove-AzApiManagementUser', 
               'Remove-AzApiManagementUserFromGroup', 
               'Save-AzApiManagementTenantGitConfiguration', 'Set-AzApiManagement', 
               'Set-AzApiManagementApi', 'Update-AzApiManagementApiRelease', 
               'Set-AzApiManagementApiRevision', 
               'Set-AzApiManagementApiVersionSet', 
               'Set-AzApiManagementAuthorizationServer', 
               'Set-AzApiManagementCertificate', 'Set-AzApiManagementGroup', 
               'Set-AzApiManagementLogger', 
               'Set-AzApiManagementOpenIdConnectProvider', 
               'Set-AzApiManagementOperation', 'Set-AzApiManagementPolicy', 
               'Set-AzApiManagementProduct', 'Set-AzApiManagementProperty', 
               'Set-AzApiManagementSubscription', 'Set-AzApiManagementUser', 
               'Set-AzApiManagementTenantAccess', 
               'Get-AzApiManagementIdentityProvider', 
               'New-AzApiManagementIdentityProvider', 
               'Set-AzApiManagementIdentityProvider', 
               'Remove-AzApiManagementIdentityProvider', 
               'Get-AzApiManagementBackend', 'New-AzApiManagementBackend', 
               'New-AzApiManagementBackendCredential', 
               'New-AzApiManagementBackendProxy', 'Set-AzApiManagementBackend', 
               'Remove-AzApiManagementBackend'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ResourceManager','ARM','ApiManagement'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = 'General availability for Az.ApiManagement module.'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

