﻿using Adnc.Infra.Consul.Configuration;
using Adnc.Infra.Consul.Registration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using System;

namespace Adnc.Infra.Consul
{
    public static class ConsulExtensions
    {
        public static void RegisterToConsul(this IApplicationBuilder app)
        {
            ConsulRegistration.Register(app);
        }

        public static Uri GetServiceAddress(this IApplicationBuilder app, ConsulConfig config)
        {
            return ConsulRegistration.GetServiceAddress(app, config);
        }

        public static IConfigurationBuilder AddConsulConfiguration(this IConfigurationBuilder configurationBuilder, ConsulConfig config, bool reloadOnChanges = false)
        {
            return configurationBuilder.Add(new DefaultConsulConfigurationSource(config, reloadOnChanges));
        }
    }
}