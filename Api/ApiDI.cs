using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Api.Commands;
using WebApi.Api.Interfaces;

namespace WebApi.Api
{
    public static class ApiDI
    {
        public static IServiceCollection AddApi(this IServiceCollection services)
        {
            services.AddScoped<ICommandsContacts, CommandsContacts>();
            return services;
        }
    }
}
