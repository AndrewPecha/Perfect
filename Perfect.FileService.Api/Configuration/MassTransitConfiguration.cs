﻿using MassTransit;
using Microsoft.Extensions.Options;
using Perfect.FileService.Api.Configuration.Models;

namespace Perfect.FileService.Api.Configuration
{
    public static class MassTransitConfiguration
    {
        public static void RegisterMassTransit(this IServiceCollection services)
        {
            services.AddMassTransit(x =>
            {
                //x.UsingAzureServiceBus((context, cfg) =>
                //{
                //    var settings = context.GetRequiredService<IOptions<AzureServiceBusSettings>>();
                //    cfg.Host(settings.Value.ConnectionString);
                //});

                x.UsingRabbitMq((context, cfg) =>
                {
                    var settings = context.GetRequiredService<IOptions<RabbitMqSettings>>();
                    cfg.Host(settings.Value.ConnectionString);
                });
            });
        }
    }
}
