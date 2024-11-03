using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Vallet.Application;
using Vallet.Application.Validators;
using Vallet.Persistence.Configurations;
using Vallet.Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);
 

builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices(builder.Configuration);


builder.Services.AddControllers();
 builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Cors
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(builder => builder
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()));
var app = builder.Build();
#endregion

#region FluentValidator 
//builder.Services.AddValidatorsFromAssemblyContaining<IFluentValidator>().AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

#endregion

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
