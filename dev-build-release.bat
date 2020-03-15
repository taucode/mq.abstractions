dotnet restore

dotnet build --configuration Debug
dotnet build --configuration Release

dotnet test -c Debug .\tests\TauCode.Mq.Abstractions.Tests\TauCode.Mq.Abstractions.Tests.csproj
dotnet test -c Release .\tests\TauCode.Mq.Abstractions.Tests\TauCode.Mq.Abstractions.Tests.csproj

nuget pack nuget\TauCode.Mq.Abstractions.nuspec
