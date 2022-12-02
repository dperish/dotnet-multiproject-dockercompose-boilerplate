using dn7.db;
using Microsoft.EntityFrameworkCore;

var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Dn7Context>(options =>
    options.UseNpgsql(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || !app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();
app.MapControllers();

using (var scope = app.Services.CreateScope())
    scope.ServiceProvider.GetRequiredService<Dn7Context>().Database.Migrate();

app.Run();
