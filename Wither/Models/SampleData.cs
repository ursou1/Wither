using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wither.Models;

namespace Wither
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
                        Name = "Kboard X",
                        Description = "Kboard",
                        Price = 14999
                    },
                    new Kboard
                    {
                        Name = "Kboard  Edge",
                        Description = "Kboard",
                        Price = 12999
                    },
                    new Kboard
                    {
                        Name = "Kboard 3",
                        Description = "Kboard",
                        Price = 11999
                    }
                );
                context.SaveChanges();

            }
        }
    }
}
