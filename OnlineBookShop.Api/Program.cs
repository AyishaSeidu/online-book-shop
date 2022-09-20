using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using OnlineBookShop.Api.Data;
using OnlineBookShop.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextPool<ShopDbContext>(options => options.UseSqlServer(config["OnlineBookShopConnectionString"]));
builder.Services.AddScoped<IBookRepo, BookRepo>();
builder.Services.AddScoped<ICartRepo, CartRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(
    policy => policy.WithOrigins("https://localhost:7064", "http://localhost:5064")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)
    );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
