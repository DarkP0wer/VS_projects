using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WifiMap.Models;

namespace WifiMap.Models
{
    public class SampleData
    {
        public static void Initialize(DataBaseContext context)
        {
            if (!context.Wifies.Any())
            {
                context.Wifies.AddRange(
                    new Wifi
                    {
                        Time = DateTime.Now.Ticks,
                        SSID = "Wizard",
                        Description = "pass: saga2584744\nadmin:2584744\n\nhttps://www.google.com/maps/@50.3833719,30.4884244,19z?hl=ru-RU\n",
                        GeoLat = 50.3833719,
                        GeoLong = 30.4884244
                    }
                );
                context.SaveChanges();
            }

            if (!context.Persones.Any())
            {
                context.Persones.AddRange(
                    new Person
                    {
                        Login = "admin",
                        Password = "admin",
                        Role = Role.Admin
                    },
                    new Person
                    {
                        Login = "user",
                        Password = "user",
                        Role = Role.Insider
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
