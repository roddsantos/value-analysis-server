using DotNetEnv;

using Microsoft.EntityFrameworkCore;

using value_analysis_server.Api.Database;

Env.Load("./");
var builder = WebApplication.CreateBuilder(args);

var dbUrl = Environment.GetEnvironmentVariable("MYSQL_HOST");
var dbPort = Environment.GetEnvironmentVariable("MYSQL_PORT");
var dbDatabase = Environment.GetEnvironmentVariable("MYSQL_DATABASE");
var dbUsername = Environment.GetEnvironmentVariable("MYSQL_USER");
var dbPassword = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");
var connectionString = "Server=" + dbUrl + ";Port=" + dbPort + ";Database=" + dbDatabase + ";User=" + dbUsername + ";Password=" + dbPassword;

builder.Services.AddDbContext<DBContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(ServerVersion.AutoDetect(connectionString))));
builder.Services.AddControllers();
builder.Services.AddMvc();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
