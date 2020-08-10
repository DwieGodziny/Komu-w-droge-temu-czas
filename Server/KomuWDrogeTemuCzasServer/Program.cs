namespace WebApp
{
    #region Usings

    using Application.WebApp;

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    #endregion

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
