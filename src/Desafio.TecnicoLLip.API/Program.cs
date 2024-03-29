﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Desafio.TecnicoLLip.API
{
    public static class Program
    {
        public static void Main(string[] args) =>
            BuildWebHost(args).Run();

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("https://*:5001")
                .Build();
    }
}
