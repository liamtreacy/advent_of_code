#!/bin/bash

DAY=DayOne # replace with the actual day



pushd 2023
`dotnet new classlib -o $DAY`
`mv $DAY/Class1.cs $DAY/$DAY.cs`
`dotnet sln add ./$DAY/$DAY.csproj`
`dotnet new xunit -o $DAY.Tests`
`dotnet sln add ./$DAY.Tests/$DAY.Tests.csproj`
`dotnet add ./$DAY.Tests/$DAY.Tests.csproj reference ./$DAY/$DAY.csproj`
popd 

echo "Finished adding new project and tests to solution!"