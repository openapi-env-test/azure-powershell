@{
  GUID = '85289da9-7661-4f49-9219-099a1593f441'
  RootModule = './Az.Confluent.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Confluent cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.Confluent.private.dll'
  FormatsToProcess = './Az.Confluent.format.ps1xml'
  FunctionsToExport = 'Get-AzConfluentMarketplaceAgreement', 'Get-AzConfluentOrganization', 'Get-AzConfluentOrganizationOperation', 'New-AzConfluentMarketplaceAgreement', 'New-AzConfluentOrganization', 'Remove-AzConfluentOrganization', 'Update-AzConfluentOrganization', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Confluent'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
