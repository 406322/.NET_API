using System.Net.Http.Headers;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

await ProcessRepositoriesAsync(client, args);

static async Task ProcessRepositoriesAsync(HttpClient client, string[] args)


// const movies = [279, 6767, 2488, 32802, 29120]

{
    var url = "https://api.tvmaze.com/shows/279";
    var json = await client.GetStringAsync(url);
    //"https://api.tvmaze.com/search/shows?q=girls");

    Console.Write(json);

    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    app.MapGet("/", () => json);

    app.Run();
}


