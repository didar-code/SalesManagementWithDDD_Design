using Microsoft.EntityFrameworkCore;
using SalesManagement.Handler.Commands.PaymentMethods;
using SalesManagement.Handler.Queries.PaymentMethods;
using SalesManagement.Repository.Data;
using SalesManagement.Repository.Implementations;
using SalesManagement.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>options.UseSqlServer( builder.Configuration.GetConnectionString("Con")));

builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();

builder.Services.AddScoped<CreatePaymentMethodHandler>();
builder.Services.AddScoped<SearchPaymentMethodHandler>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();