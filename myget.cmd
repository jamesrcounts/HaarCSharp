.nuget\NuGet.exe restore HaarCSharp.sln -NoCache -NonInteractive

.nuget\NuGet.exe pack HaarCSharp\HaarCSharp.csproj -OutputDirectory .\HaarCSharp -Symbols -Build -Properties Configuration=Debug -Version %PackageVersion%