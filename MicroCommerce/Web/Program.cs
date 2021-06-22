using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace MicroCommerce.Web
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    CreateHostBuilder(args).Build().Run();
        //}

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });

        public static void Main(string[] args)
        {
            IHostBuilder h = CreateHostBuilder(args);
            IHost h2 = h.Build();
            h2.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            Action<IWebHostBuilder> d1 = new Action<IWebHostBuilder>(Process);

            IHostBuilder h1 = Host.CreateDefaultBuilder(args);
            IHostBuilder h2 = h1.ConfigureWebHostDefaults(d1);
            return h2;
        }



        public static void Process(IWebHostBuilder iwb)
        {
            iwb.UseStartup<Startup>();
        }
    }
}
