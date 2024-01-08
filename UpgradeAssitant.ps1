# Commented Start
<#
$upgradeAssistantPath = Read-Host -Prompt "Enter the path to .Net Upgrade Assistant executable"
$solutionPath = Read-Host -Prompt "Enter the  path to the solution file(.sln) to be upgraded"
$logFilePath = Read-Host -Prompt "Enter the  path for error log file"
#>
# Commented End

param(
    [string]$upgradeAssistantPath,
    [string]$solutionPath,
    [string]$skipBackup,
    [string]$nonInteractive,
    [string]$targetFramework,
    [string]$logFilePath
)

# Check if the log file exists, if not create it
if (-not (Test-Path -Path $logFilePath)) {
    New-Item -Path $logFilePath -ItemType File -Force | Out-Null
}

# Check for missing or incorrect parameters
if (-not $upgradeAssistantPath -or -not (Test-Path -Path $upgradeAssistantPath) -or -not $solutionPath) {
    $errorMessage = "Error: .Net Upgrade Assistant Path or Solution path is missing or incorrect."  
    Write-Host $errorMessage
    Add-Content -Path $logFilePath -Value $errorMessage
    exit 1
}

try {
    $argumentList = @()

    # Check if nonInteractive is "Yes"
    if ($nonInteractive -eq "Yes") {
        # Split the comma-separated solution paths
        $solutionPaths = $solutionPath -split ','

        foreach ($solutionPath in $solutionPaths) {
            # Check if each solution file exists
            if (-not (Test-Path -Path $solutionPath)) {
                $errorMessage = "Error: Solution file not found: $solutionPath" 
                Write-Host $errorMessage
                Add-Content -Path $logFilePath -Value $errorMessage
                exit 1
            }

            $argumentList = @("upgrade", "$solutionPath")
            $argumentList += "--non-interactive"
            if ($skipBackup -eq "Yes") {
                $argumentList += "--skip-backup"
            }
            if ($targetFramework -eq "Long Term Support") {
                $argumentList += "--target-tfm-support LTS"
            }
            if ($targetFramework -eq "Standard Term Support") {
                $argumentList += "--target-tfm-support STS"
            }
            if ($targetFramework -eq "Preview") {
                $argumentList += "--target-tfm-support Preview"
            }

            # Start the process for each solution path
            Start-Process -FilePath $upgradeAssistantPath -ArgumentList $argumentList -Wait -ErrorAction Stop
        }
    }
    else {
        #Interactive mode
        $argumentList = @("upgrade", "$solutionPath")

        if ($skipBackup -eq "Yes") {
            $argumentList += "--skip-backup"
        }
        if ($targetFramework -eq "Long Term Support") {
            $argumentList += "--target-tfm-support LTS"
        }
        if ($targetFramework -eq "Standard Term Support") {
            $argumentList += "--target-tfm-support STS"
        }
        if ($targetFramework -eq "Preview") {
            $argumentList += "--target-tfm-support Preview"
        }

        # Start the process for the single solution path
        Start-Process -FilePath $upgradeAssistantPath -ArgumentList $argumentList -Wait -ErrorAction Stop
    }
}
catch {
    $errorMessage = $_.Exception.Message
    Write-Host "Error occurred: $errorMessage"
    Add-Content -Path $logFilePath -Value "Error Occurred: $errorMessage"
}

Read-Host "Press Enter to exit"


# SIG # Begin signature block
# MIIKdwYJKoZIhvcNAQcCoIIKaDCCCmQCAQExCzAJBgUrDgMCGgUAMGkGCisGAQQB
# gjcCAQSgWzBZMDQGCisGAQQBgjcCAR4wJgIDAQAABBAfzDtgWUsITrck0sYpfvNR
# AgEAAgEAAgEAAgEAAgEAMCEwCQYFKw4DAhoFAAQUbDcl+vsHyJXsxXic6IjLzzhC
# iqCgggfNMIIHyTCCBbGgAwIBAgITfgAgCz3Z3MPDcN7A7QAAACALPTANBgkqhkiG
# 9w0BAQsFADBcMRMwEQYKCZImiZPyLGQBGRYDY29tMRcwFQYKCZImiZPyLGQBGRYH
# bXBoYXNpczEUMBIGCgmSJomT8ixkARkWBGNvcnAxFjAUBgNVBAMTDU1waGFzaXNS
# b290Q0EwHhcNMjMxMjE4MDMyNTQyWhcNMjUxMjE3MDMyNTQyWjCBljETMBEGCgmS
# JomT8ixkARkWA2NvbTEXMBUGCgmSJomT8ixkARkWB21waGFzaXMxFDASBgoJkiaJ
# k/IsZAEZFgRjb3JwMRUwEwYDVQQLEwxNcGhhc2lTIEFwcHMxEjAQBgNVBAsTCUh5
# ZGVyYWJhZDEOMAwGA1UECxMFVXNlcnMxFTATBgNVBAMTDFNoaXZhcmVkZHkgTTCC
# ASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAKyvPCQ385Fjz/4U6Tp+KKKb
# EayL/ZPbC24BjdukuPcOgDgBtUE6G+q9xwOJZR/d+qRbYmeAne3nJp76oVjMKMM9
# DI/vLqwHnoI0IW536krgYRw3itaiB7G/FaRgW2ZXIMSbbalpdbgOEtGSB2ql4rOB
# YfLOrardFJE8scxayoorr+Z6/wlNDb6PGH6Jxyq4sLPjdoTy/UGhV3bbqnorkZ/M
# oBv2GeHLV3o0+oY+u+iM0JyeXqvcww3DbOce7iHrHhd2/ITF/3+Ltz3UJCixLzpz
# Bucxc7dTRNSHQRxG1cQc/LmPvF/6cWb9V4w7bkcfVGACjoLg7mqJ05stGLIXcdkC
# AwEAAaOCA0cwggNDMDsGCSsGAQQBgjcVBwQuMCwGJCsGAQQBgjcVCITMgh/PvRuC
# 1Y0bs8c1hobpLIFAhpn3A6yaEwIBZAIBDjATBgNVHSUEDDAKBggrBgEFBQcDAzAL
# BgNVHQ8EBAMCB4AwGwYJKwYBBAGCNxUKBA4wDDAKBggrBgEFBQcDAzAdBgNVHQ4E
# FgQUm0Uq8NbrG7Pjt5k44d1/yYo10gwwHwYDVR0jBBgwFoAUI0Ukc9Y9Vxhp+CPV
# qTHHVKhx7Y0wgdsGA1UdHwSB0zCB0DCBzaCByqCBx4aBxGxkYXA6Ly8vQ049TXBo
# YXNpc1Jvb3RDQSxDTj1TUlZCQU4wOUNSQVVWTTEsQ049Q0RQLENOPVB1YmxpYyUy
# MEtleSUyMFNlcnZpY2VzLENOPVNlcnZpY2VzLENOPUNvbmZpZ3VyYXRpb24sREM9
# Y29ycCxEQz1tcGhhc2lzLERDPWNvbT9jZXJ0aWZpY2F0ZVJldm9jYXRpb25MaXN0
# P2Jhc2U/b2JqZWN0Q2xhc3M9Y1JMRGlzdHJpYnV0aW9uUG9pbnQwggEBBggrBgEF
# BQcBAQSB9DCB8TCBtAYIKwYBBQUHMAKGgadsZGFwOi8vL0NOPU1waGFzaXNSb290
# Q0EsQ049QUlBLENOPVB1YmxpYyUyMEtleSUyMFNlcnZpY2VzLENOPVNlcnZpY2Vz
# LENOPUNvbmZpZ3VyYXRpb24sREM9Y29ycCxEQz1tcGhhc2lzLERDPWNvbT9jQUNl
# cnRpZmljYXRlP2Jhc2U/b2JqZWN0Q2xhc3M9Y2VydGlmaWNhdGlvbkF1dGhvcml0
# eTA4BggrBgEFBQcwAYYsaHR0cDovL1NSVkJBTjA5Q1JBVVZNMS5jb3JwLm1waGFz
# aXMuY29tL29jc3AwTQYDVR0RBEYwRKAoBgorBgEEAYI3FAIDoBoMGHNoaXZhcmVk
# ZHkubUBtcGhhc2lzLmNvbYEYc2hpdmFyZWRkeS5tQG1waGFzaXMuY29tMFMGCSsG
# AQQBgjcZAgRGMESgQgYKKwYBBAGCNxkCAaA0BDJTLTEtNS0yMS0xMDc5NTc2NTIz
# LTM4NTgxMjM1NjUtMTkwOTY3OTkxNS0xMDAyNTIzMjANBgkqhkiG9w0BAQsFAAOC
# AgEA2Avj9jCR7RZhFJtKMnaZfv2GE/aZXyXuMWPqzDTqEreACu1Mptr/TNt7QEFW
# +9XzWmTBn/j7czQwfUFjm4TUuEmDuJWUvqnLYMYmiqU6/Y4ht+VguERaT5GSJpRy
# d5vapy7tcKHchW0n1Jux0qkq2m3/G4d+xg7Fopc4sdpk5tEhGwqPZf8yEx+ExqdX
# C+HNkUiueMLpJrBVXWgx51Udo4HnGaYYjkQ2SiXYQxVm6kyoysBblRjC0g/Kebxb
# EaDtB7RQhrG7MM4Ge0nXF/oFA34SRu8tLdYuCUdoJldj7cXzBVXPAKLX2Zi6ZTcx
# K3WYPIb3oCZcUlOvs5xSOY9cAnVnjVbrX6O9jk0/YHRIhmHU//0cmJEqokGiNDYS
# mY2pHy0BNLPH7j9PXSZV5MjZL0ZsH9rs8tqpxDsSNiy8spZR8m+guPGSodqwjgol
# 2nc6LEy92OJX11FPUJK2Nm9HJsNqP/xSukzH8SMtFlCOS3uROcbMmfoGrB61JFQ1
# 6D2uFOfw97tyqPpsVm8ZnhjD8qhDigovVH/vveoxVOxLbdHxbC5nWLQTv80p0CTS
# aKL5pLF0OIIiv+llvolx0ftcYBw9pBed876MQPJunnTgO52EnvES+4US3uEg2leg
# +UBfMc44Q1GyzqHsz26TPM2AXg1pfv2NHuTKOO5FSwp+CpAxggIUMIICEAIBATBz
# MFwxEzARBgoJkiaJk/IsZAEZFgNjb20xFzAVBgoJkiaJk/IsZAEZFgdtcGhhc2lz
# MRQwEgYKCZImiZPyLGQBGRYEY29ycDEWMBQGA1UEAxMNTXBoYXNpc1Jvb3RDQQIT
# fgAgCz3Z3MPDcN7A7QAAACALPTAJBgUrDgMCGgUAoHgwGAYKKwYBBAGCNwIBDDEK
# MAigAoAAoQKAADAZBgkqhkiG9w0BCQMxDAYKKwYBBAGCNwIBBDAcBgorBgEEAYI3
# AgELMQ4wDAYKKwYBBAGCNwIBFTAjBgkqhkiG9w0BCQQxFgQUNBxLz0nnoggaM/GK
# v+r0iqbPkpkwDQYJKoZIhvcNAQEBBQAEggEAKEJtLoSs1DEEDxceD+PZFVrMrZ6D
# NWVsKdfbdL2sy3cqhuQpOYrhz1WOqHswP0XQPuTJZID39gcRDpTFoR5KdPBSHpug
# +ccmHURGQIv+j4pMMdhJlD2kPA6s3ubl5i8kHYO1y1V1D8GWs9PFDV3efFtoH3kP
# JaFuQXlX3Ysf7CAP3MS2hwsoPz6rFsd90r1Df6G5nEZ0eNC5gq3AbKm2N8uNVhUs
# 7UH5qtAs7tmZ6zyR5tyVB0T9uRd9qTVf6theMureOtvfQ7t6vsnHHgEyA4ypcROL
# C5GtlofPAGA0ATJ/1pkcJIzr8XeEDe8txdOQuO6wCaTVdePFsC0stnMrHg==
# SIG # End signature block
