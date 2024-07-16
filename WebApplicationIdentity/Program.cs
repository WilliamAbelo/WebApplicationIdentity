using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplicationIdentity.Data;
using WebApplicationIdentity.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<AppDbContext>(
//    options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true"));

var conStrBuilder = new SqlConnectionStringBuilder(
    builder.Configuration.GetValue<string>("ConnectionStrings:IdentityExample"));
var connection = conStrBuilder.ConnectionString;

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connection));

builder.Services.AddAuthorization();
builder.Services.AddAuthentication();

builder.Services
    .AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<AppDbContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapSwagger();


app.MapGet("/", () => "Hello World!").RequireAuthorization();

app.MapIdentityApi<User>();

app.Run();
