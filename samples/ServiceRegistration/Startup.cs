﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CondenserDotNet.Client;
using CondenserDotNet.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceRegistration
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddRouting();
            //services.AddConsulServices();
        }

        public void Configure(IApplicationBuilder app) //, IServiceManager manager)
        {
            app.UseMiddleware<TrailingHeadersMiddleware>();
            //manager.AddHttpHealthCheck("/health",5).AddApiUrl("/testSample/test3/test1").RegisterServiceAsync().Wait();
            app.UseMvcWithDefaultRoute();
        }
    }
}
