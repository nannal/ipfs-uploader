FROM microsoft/dotnet:latest
LABEL "project.home"="https://github.com/nannal/ipfs-uploader"
RUN git clone git://github.com/nannal/ipfs-uploader
WORKDIR /ipfs-uploader
RUN dotnet publish -c Release
EXPOSE 5001
ENV ASPNETCORE_ENVIRONMENT prod_cpu
CMD ["dotnet", "/ipfs-uploader/Uploader.Web/bin/Release/netcoreapp2.0/publish/Uploader.Web.dll"]
