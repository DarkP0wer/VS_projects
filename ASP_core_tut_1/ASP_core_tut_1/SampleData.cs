using System;
using System.Collections.Generic;
using System.Linq;
using ASP_core_tut_1.Models;

namespace ASP_core_tut_1
{
    public static class SampleData
    {
        public static void Intialize(MobileContext context)
        {
            if(!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone 6S",
                        Company = "Apple",
                        Price = 600
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy Edge",
                        Company = "Samsung",
                        Price = 550
                    },
                    new Phone
                    {
                        Name = "Lumia 950",
                        Company = "Microsoft",
                        Price = 500
                    }
                 );
                context.SaveChanges();
            }
        }
    }
}
