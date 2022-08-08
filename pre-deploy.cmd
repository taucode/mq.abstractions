dotnet restore

dotnet build --configuration Debug
dotnet build --configuration Release

dotnet test -c Debug .\test\TauCode.Mq.Abstractions.Tests\TauCode.Mq.Abstractions.Tests.csproj
dotnet test -c Release .\test\TauCode.Mq.Abstractions.Tests\TauCode.Mq.Abstractions.Tests.csproj

nuget pack nuget\TauCode.Mq.Abstractions.nuspec
