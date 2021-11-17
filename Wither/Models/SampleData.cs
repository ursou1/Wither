using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wither.Models
{
    public class SampleData
    {
        public static void Initialize(KboardContext context)
        {
            if (!context.Kboards.Any())
            {
                context.Kboards.AddRange(
                    new Kboard
                    {
                        Name = "iPhone X",
                        Description = "Apple",
                        Price = 14999
                    },
                    new Kboard
                    {
                        Name = "Samsung Galaxy Edge",
                        Description = "Samsung",
                        Price = 12999
                    },
                    new Kboard
                    {
                        Name = "Pixel 3",
                        Description = "Google",
                        Price = 11999
                    }
                );
                context.SaveChanges();

            }
        }
    }
}
