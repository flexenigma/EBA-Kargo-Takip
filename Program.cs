using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;

namespace EBA_Kargo_Takip
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Serilog yap�land�rmas�
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs\\log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            try
            {
                // Dependency Injection (DI) servislerini olu�tur
                var services = new ServiceCollection();
                services.AddLogging(loggingBuilder =>
                {
                    loggingBuilder.ClearProviders();
                    loggingBuilder.AddSerilog(); // Serilog'u ekledik
                });

                // DbContext ve servislerin eklenmesi
                services.AddDbContext<KargoTakipContext>(options =>
                    options.UseSqlServer("Your_Connection_String"));

                services.AddScoped<KullaniciService>();
                services.AddScoped<KargoService>();

                // Uygulamay� �al��t�r
                var serviceProvider = services.BuildServiceProvider();
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Uygulama ba�lat�lamad�.");
            }
            finally
            {
                Log.CloseAndFlush(); // Serilog logger'� kapat
            }
        }
    }
}
