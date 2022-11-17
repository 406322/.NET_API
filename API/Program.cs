using System.Net.Http.Headers;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

await ProcessRepositoriesAsync(client, args);

static async Task ProcessRepositoriesAsync(HttpClient client, string[] args)
{

    var json = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/279");

    var json2 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/6767");

    var json3 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/2488");

    var json4 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/32802");

    var json5 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/29120");

    var json6 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/17729");

    var json7 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/25414");

    var json8 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/20895");

    var json9 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/37813");

    var json10 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/15112");

    var json11 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/32779");

    var json12 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/618");

    var json13 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/22188");

    var json14 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/6");

    var json15 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/27848");

    var json16 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/1824");

    var json17 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/3590");

    var json18 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/1788");

    var json19 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/4295");

    var json20 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/6796");

    var json21 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/32291");

    var json22 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/9568");

    var json23 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/614");

    var json24 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/3822");

    var json25 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/1850");

    var json26 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/8167");

    var json27 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/5");

    var json28 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/100");

    var json29 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/21845");

    var json30 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/8800");

    var json31 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/30905");

    var json32 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/2225");

    var json33 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/83");

    var json34 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/2176");

    var json35 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/20172");

    var json36 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/1819");

    var json37 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/10822");

    var json38 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/62829");

    var json39 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/84");

    var json40 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/80");

    var json41 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/1715");

    var json42 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/17803");

    var json43 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/8706");

    var json44 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/4276");

    var json45 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/4201");

    var json46 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/28465");

    var json47 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/14657");

    var json48 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/612");

    var json49 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/363");

    var json50 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/997");

    var json51 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/6183");

    var json52 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/30346");

    var json53 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/3101");

    var json54 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/314");

    var json55 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/26198");

    var json56 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/37138");

    var json57 = await client.GetStringAsync(
    "https://api.tvmaze.com/shows/22878");


    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    app.MapGet("/", () => json);
    app.MapGet("/1", () => json2);
    app.MapGet("/2", () => json3);
    app.MapGet("/3", () => json4);
    app.MapGet("/4", () => json5);
    app.MapGet("/5", () => json6);
    app.MapGet("/6", () => json7);
    app.MapGet("/7", () => json8);
    app.MapGet("/8", () => json9);
    app.MapGet("/9", () => json10);
    app.MapGet("/10", () => json11);
    app.MapGet("/11", () => json12);
    app.MapGet("/12", () => json13);
    app.MapGet("/13", () => json14);
    app.MapGet("/14", () => json15);
    app.MapGet("/15", () => json16);
    app.MapGet("/16", () => json17);
    app.MapGet("/17", () => json18);
    app.MapGet("/18", () => json19);
    app.MapGet("/19", () => json20);
    app.MapGet("/20", () => json21);
    app.MapGet("/21", () => json22);
    app.MapGet("/22", () => json23);
    app.MapGet("/23", () => json24);
    app.MapGet("/24", () => json25);
    app.MapGet("/25", () => json26);
    app.MapGet("/26", () => json27);
    app.MapGet("/27", () => json28);
    app.MapGet("/28", () => json29);
    app.MapGet("/29", () => json30);
    app.MapGet("/30", () => json31);
    app.MapGet("/31", () => json32);
    app.MapGet("/32", () => json33);
    app.MapGet("/33", () => json34);
    app.MapGet("/34", () => json35);
    app.MapGet("/35", () => json36);

    app.Run();

}


