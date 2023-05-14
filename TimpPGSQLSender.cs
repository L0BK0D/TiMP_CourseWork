using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TiMP_CourseWork
{
    internal class TimpPGSQLSender
    {
        public static async Task InitSend(string[] coeffs, double X0, double Y0, double Z0)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            var optionsBuilder = new DbContextOptionsBuilder<TiMPDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=RungeKutta;Username=postgres;Password=user");
            using (var dbContext = new TiMPDbContext(optionsBuilder.Options))
            {
                // Создание нового объекта
                var newObject = new InitValues
                {
                    Coefficents = coeffs,
                    X0 = X0,
                    Y0 = Y0,
                    Z0 = Z0
                };

                // Добавление нового объекта в контекст
                dbContext.initvalues.Add(newObject);
                await dbContext.SaveChangesAsync();

            }
        }
        public static async Task OutSend(double t, double x, double y, double z)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            var optionsBuilder = new DbContextOptionsBuilder<TiMPDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=RungeKutta;Username=postgres;Password=user");
            using(var dbContext = new TiMPDbContext(optionsBuilder.Options))
            {
                // Создание нового объекта
                var newObject = new OutValues
                {
                    time = t,
                    X = x,
                    Y = y,
                    Z = z
                };
                // Добавление нового объекта в контекст
                dbContext.outvalues.Add(newObject);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
