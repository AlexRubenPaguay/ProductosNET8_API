using Microsoft.EntityFrameworkCore;
using NetCoreAPI_UNO.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString =builder.Configuration.GetConnectionString("conSqlServer") ?? throw new InvalidOperationException("La cadena de conexión 'CadenaSQL' no fue encontrada. ");

builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseSqlServer(connectionString);
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularDev",
        policy => policy
            .WithOrigins("http://localhost:4200", "http://localhost:32768", "http://localhost:5153")            
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAngularDev");
app.UseAuthorization();
app.MapControllers();
app.Run();
