using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Testing Sitecore Discover API");

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

var domainId = config.GetSection("Discover:DomainId").Value;
var apiKey = config.GetSection("Discover:ApiKey").Value;

var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Post, $"https://api.rfksrv.com/search-rec/{domainId}/3");
request.Headers.Add("Authorization", apiKey);

var requestBody = @"
    {
        ""data"": {
            ""context"": {
            ""page"": {
                ""uri"": ""/rea-home""
            },
            ""user"": {
                ""new_user"": true
            }
            },
            ""widget"": {
            ""rfkid"": ""rfkid_92""
            },
            ""content"": {
            ""product"": {}
            },
            ""force_v2_specs"": true
        }
}
";

var content = new StringContent(requestBody, null, "application/json");
request.Content = content;

var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();

var jsonResponse = await response.Content.ReadAsStringAsync();
Console.WriteLine(jsonResponse);