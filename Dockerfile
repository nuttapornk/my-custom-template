FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine as build-dev

WORKDIR /app

# Copy everything else and build
COPY src/ ./
RUN dotnet restore 

RUN dotnet publish -c Release -o out
# --runtime linux-musl-x64

FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine
# ENV ASPNETCORE_URLS=http://*:7001
WORKDIR /app
COPY --from=build-dev /app/out .
EXPOSE 80

ENTRYPOINT ["dotnet", "WebApi.dll"]
