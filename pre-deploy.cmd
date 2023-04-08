dotnet restore

dotnet build TauCode.Mq.Abstractions.sln -c Debug
dotnet build TauCode.Mq.Abstractions.sln -c Release

dotnet test TauCode.Mq.Abstractions.sln -c Debug
dotnet test TauCode.Mq.Abstractions.sln -c Release

nuget pack nuget\TauCode.Mq.Abstractions.nuspec