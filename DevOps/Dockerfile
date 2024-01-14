FROM mcr.microsoft.com/dotnet/sdk:7.0 As build-env
WORKDIR /App

COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App
EXPOSE 80
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "DevOps.dll"]