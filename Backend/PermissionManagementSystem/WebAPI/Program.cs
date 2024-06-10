using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Business;
using DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Core.Utilities.JWT;
using Core.Utilities.Encryption;
using Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

TokenOptions? tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddBusinessServices();
builder.Services.AddDataAccessServices();
builder.Services.AddCoreServices(tokenOptions);

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidAudience = tokenOptions.Audience,
            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
        };
    });

builder.Services.AddCors(options =>
{
    options.AddPolicy("myPolicy",
    builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionMiddlewareExtensions();

app.UseCors("myPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
