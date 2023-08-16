using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SecretAlert
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create a HttpClient object
            var client = new HttpClient();

            var client_id = "c53fa4fa-1c56-40a5-8a41-11be70b2337d";
            var client_secret = "ejr8Q~pyH98kCz4gWW5diHZ42GFe~gFD.XU36dAU";

            // Set the request headers
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github+json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", client_id);
            client.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2022-11-28");

            // Set the request URL
            var url = "https://api.github.com/orgs/ORG/actions/secrets/client_secret";

            // Send a DELETE request
            var response = await client.DeleteAsync(url);

            // Print the response status code
            Console.WriteLine(response.StatusCode);
        }
    }
}

