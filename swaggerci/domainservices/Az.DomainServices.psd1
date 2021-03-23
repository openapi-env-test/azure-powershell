@{
  GUID = '3b6d0afb-b5b4-46a3-9b37-ebfe50e99a8e'
  RootModule = './Az.DomainServices.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: DomainServices cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.DomainServices.private.dll'
  FormatsToProcess = './Az.DomainServices.format.ps1xml'
  FunctionsToExport = 'Get-AzDomainServicesDomainService', 'Get-AzDomainServicesDomainServiceOperation', 'Get-AzDomainServicesOuContainer', 'Get-AzDomainServicesOuContainerOperation', 'New-AzDomainServicesDomainService', 'New-AzDomainServicesOuContainer', 'Remove-AzDomainServicesDomainService', 'Remove-AzDomainServicesOuContainer', 'Update-AzDomainServicesDomainService', 'Update-AzDomainServicesOuContainer', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'DomainServices'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
