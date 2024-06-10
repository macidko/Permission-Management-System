using Core.Utilities.JWT;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core;

public static class CoreServiceRegistration
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services, TokenOptions tokenOptions)
    {
        //ioc ile dependency injection(http isteği başına)
        services.AddScoped<ITokenHelper, JWTHelper>(_ => new JWTHelper(tokenOptions));
        return services;
    }
}
