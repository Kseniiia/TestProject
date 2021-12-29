# Navigate to tests folder
#cd C:\TestProject\TestProject1
pwd

# Build
Write-Output "Run tests"

& 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\msbuild' TestProject2\TestProject2.sln "/t:Clean,Build" "/p:Configuration=Release"

# Run tests

dotnet test TestProject2\bin\Release\netcoreapp3.1\TestProject2.dll --logger ReportPortal