const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
using HttpClient client = new();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:5173/",
                                              "https://localhost:7299/");

                      });
});

var app = builder.Build();


List<string> myList = new List<string>();

List<string> myList2 = new List<string>();

string[] movies = {
    "279",
    "6767",
    "2488",
    "32802",
    "29120",
    "17729",
    "25414",
    "20895",
    "37813",
    "15112",
    "32779",
    "618",
    "22188",
    "6",
    "27848",
    "1824",
    "6775",
    "3590",
    "1788",
    "4295",
    "6796",
    "32291",
    "9568",
    "614",
    "3822",
    "1850",
    "8167",
    "5",
    "100",
    "21845",
    "8800",
    "30905",
    "2225",
    "83",
    "2176",
    "20172",
    "1819",
    "10822",
    "38147",
    "62829",
    "6508",
    "84",
    "80",
    "1715",
    "17803",
    "8706",
    "4276",
    "4201",
    "28465",
    "14657",
    "612",
    "363",
    "997",
    "6183",
    "30346",
    "3101",
    "314",
    "26198",
    "37138",
    "22878"
};


foreach (string i in movies)
{
    var json = await client.GetStringAsync(
       $"https://api.tvmaze.com/shows/{i}");

    myList2.Add(json);

    myList.AddRange(myList2);

}


app.UseCors(
  options => options.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
      );

app.MapGet("/", () => myList2);

app.Run();
