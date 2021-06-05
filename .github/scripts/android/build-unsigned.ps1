param (
  [Parameter(Mandatory=$true)]
  [string] $configuration
)

$rootPath = $env:GITHUB_WORKSPACE;
$androidPath = $($rootPath + "/src/Android/Android.csproj");

Write-Output "########################################"
Write-Output "##### Build $configuration Configuration"
Write-Output "########################################"

msbuild "$($androidPath)" "/t:SignAndroidPackage" "/p:Configuration=$configuration"
