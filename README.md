# sc-discvover-dotnet
This is a sample repository showing how you can call the Sitecore Discover API with C# and DotNet.

# Parameters
You will need to populate the following parameters in the `appsettings.json` file.

- `DomainId`: The id of the domain in use, in the format "CompanyId-DomainId"
- `ApiKey`: The generated API Key for the domain

# Request
The request body will need to be tailored to match the Widget definition in your Discover congifuration. 

# Running the Repo

Poulate the `appsettings.json` file with the parameters above, tailor the request body, then run the following commands:

```C#
dotnet restore && dotnet run
```