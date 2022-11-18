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


string[] movies = { "279", "6767", "2488", "32802" };
foreach (string i in movies)
{
    var json = await client.GetStringAsync(
       $"https://api.tvmaze.com/shows/{i}");


    //myList.Add(json);


    myList2.Add(json);

    myList.AddRange(myList2);

}






app.UseCors(
  options => options.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
      );

app.MapGet("/", () => myList);

app.Run();
