using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RealLabBook.Data;
using System;
using System.Linq;

namespace RealLabBook.Models
{
    public static class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Tools.Any())
                {
                    return;   // DB has been seeded
                }
                else
                {
                context.Tools.AddRange(
                                        new Tool
                                        {
                                            ToolID = 1,
                                            Toolname = "Voltmeter",
                                            Quantity = 20
                                        },

                                        new Tool
                                        {
                                            ToolID = 2,
                                            Toolname = "Arduino",
                                            Quantity = 20
                                        },

                                        new Tool
                                        {
                                            ToolID = 3,
                                            Toolname = "Oscilloscope",
                                            Quantity = 20
                                        },

                                        new Tool
                                        {
                                            ToolID = 4,
                                            Toolname = "Soldering Iron",
                                            Quantity = 20
                                        },

                                        new Tool
                                        {
                                            ToolID = 5,
                                            Toolname = "Pliers",
                                            Quantity = 20
                                        }
                                    );
                    context.SaveChanges();
                }

                
                
            }
        }
    }
}