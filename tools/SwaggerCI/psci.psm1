function Invoke-SwaggerCI {
    param(
        [string] $ConfigFilePath = "./generateInput.json",
        [string] $ResultFilePath = "./generateOutput.json"
        )

    # Get the readme.md files need to be run from config file
    $config = Get-Content $ConfigFilePath | ConvertFrom-Json

    $packages = @()
    $downloadPrefix = $config.installInstructionInput.downloadUrlPrefix
    foreach ($rd in $config.relatedReadmeMdFiles) {
        try {
            $rdFolder = Join-Path $config.specFolder (Split-Path $rd -Parent)
            $rdPath = Join-Path $rdFolder "readme.md"
            $psRdPath = Join-Path $rdFolder "readme.powershell.md"
            $moduleName = $rd.split("/")[1]

            #create the a folder for this RP
            $moduleFolder = Join-Path (Join-Path (pwd).Path swaggerci) $moduleName
            New-Item -Path $moduleFolder -ItemType Directory -Force

            #populate read.md.template
            $rdContent = Get-Content ./tools/SwaggerCI/readme.md.template
            $rdContent = $rdContent.replace('$(readme.md)', $rdPath)
            $rdContent = $rdContent.replace('$(readme.powershell.md)', $psRdPath)
            $rdContent | Out-File -Path (Join-Path $moduleFolder "readme.md") 

            #generate code
            autorest (Join-Path $moduleFolder "readme.md")
            #Build the module
            . (Join-Path $moduleFolder "build-module.ps1")
            #Package
            . (Join-Path $moduleFolder "pack-module.ps1")

            #Generate result
            $downloadUrl = $config.installInstructionInput.downloadUrlPrefix + "Az.$moduleName.0.1.0.nupkg"
            $downloadCmd = "curl -L $downloadUrl -o Az.$moduleName.0.1.0.nupkg"
            $package = @{
                packageName = "Az.$moduleName"
                path = @("swaggerci/$moduleName")
                readmeMd = @($rd)
                artifacts = @("swaggerci/$moduleName/bin/Az.$moduleName.0.1.0.nupkg")
                installInstructions = "Please download the package through the curl command '$downloadCmd', and then you could have a try locally."
                result = "success"
            }
            $packages += $package
        } catch {
            $package = @{
                packageName = "Az.$moduleName"
                path = @("swaggerci/$moduleName")
                readmeMd = @($rd)
                result = "failed"
            }
            $packages += $package
        }
    }

    $result = @{
        packages = $packages
    }
    
    $result | ConvertTo-Json -Depth 5 | Out-File -Path $ResultFilePath
}

Export-ModuleMember -Function Invoke-SwaggerCI