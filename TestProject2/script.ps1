# Navigate to tests folder
#cd C:\TestProject\TestProject1
pwd

# Build
Write-Output "Run tests"

& 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\msbuild' TestProject2\TestProject2.sln "/t:Clean,Build" "/p:Configuration=Release"

# Run tests
$launch_name ='TEST'
$env:RP_LAUNCH_NAME = $launch_name
$runner_path ='C:\TestProject\TestProject2\TestProject2\nunit\nunit3-console.exe'
$testlibpath = '.\TestProject2\bin\Debug\netcoreapp3.1\TestProject2.dll'
