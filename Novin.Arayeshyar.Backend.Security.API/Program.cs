using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Novin.Arayeshyar.Backend.Core.Entities;
using Novin.Arayeshyar.Backend.Infrastructure.Database;
using Novin.Arayeshyar.Backend.Security.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ArayeshyarDB>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainDB"));
});
builder.Services.AddCors
    (options => options.AddDefaultPolicy(builder => builder
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();
app.MapPost("/adminlogin", (ArayeshyarDB db, LoginRequestDTO login) =>
    {
        if (!db.SistemAdmins.Any())
        {
            var firstAdmin = new SistemAdmin("admin", "nimda", "0918");
            db.SistemAdmins.Add(firstAdmin);
            db.SaveChanges();
    }
        var result = db.SistemAdmins
        .Where(m => m.Username == login.Username && m.Password == login.Password)
        .FirstOrDefault();
        if (result!=null)
        {
            return new
            {
                IsOK = true,
                Massage = "مدیر جان سلام!"
            };
        }
        return new
        {
            IsOK = false,
            Massage = "ببخشید! شما؟"

        };
    });
app.MapPost("/admins", (ArayeshyarDB db) =>
{
    return db.SistemAdmins.ToList();
});
app.Run();


