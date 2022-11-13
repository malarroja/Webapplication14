using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;

[assembly:log4net.Config.XmlConfigurator(Watch =true)]

namespace WebApplication14
{
    public class Program
    {

        public static void Main(string[] args)

        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

            log.Info("You are succeesfully started");
            log.Warn("Something went wrong");
            try
            {
                string str = null;
                str.ToString();
            }
            catch (Exception ex)
            {
                log.Warn(ex.ToString());
            }

            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
