using Blog.Commons.Bootstrapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices(builder.Configuration);


var app = builder.Build();

app.UseAppMidderWares();


app.Run();
