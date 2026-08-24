using Microsoft.EntityFrameworkCore;
using SalesManagement.DTOs.Commands;
using SalesManagement.DTOs.Queries;
using SalesManagement.DTOs.Responses;
using SalesManagement.Handler.Commands;

using SalesManagement.Handler.Queries;
using SalesManagement.Repository.Data;
using SalesManagement.Repository.Implementations;
using SalesManagement.Repository.Interfaces;
using SalesManagement.Shared.Generics;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>options.UseSqlServer( builder.Configuration.GetConnectionString("Con")));

builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();


builder.Services.AddScoped<ICommandHandler<CreatePaymentMethodCommand, PaymentMethodResponseDto>, CreatePaymentMethodHandler>();
builder.Services.AddScoped<IQueryHandler<SearchPaymentMethodQuery, IEnumerable<PaymentMethodResponseDto>>, SearchPaymentMethodHandler>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();