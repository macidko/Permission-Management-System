using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, EfUserRepository>();
        services.AddScoped<IOperationClaimRepository, EfOperationClaimRepository>();
        services.AddScoped<IUserOperationClaimRepository, EfUserOperationClaimRepository>();
        services.AddDbContext<BaseDbContext>();
        return services;
    }
}
