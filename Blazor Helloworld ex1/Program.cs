var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
string strMessage = "\nHello World" + "\nThis sample shows string concatation using \'+\' operator.";
app.MapGet("/", () => "Hello World!");

app.Run();
