using Microsoft.EntityFrameworkCore;
using QuickSchedule.Server.Context;
using QuickSchedule.Server.InterfaceService;
using QuickSchedule.Server.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});


builder.Services.AddDbContext<AppDbContext>(options => options
.UseSqlServer(builder.Configuration
    .GetConnectionString("DefaultConnection")));

// Registra o serviço de login para injeção de dependência
builder.Services.AddScoped<ILoginService, LoginService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
//https://localhost:7041/swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowAll");

app.MapControllers();

app.Run();
