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
                                            
                                            Toolname = "Voltmeter",
                                            Quantity = 20
                                        },

                                        new Tool
                                        {
                                            
                                            Toolname = "Arduino",
                                            Quantity = 20
                                        },

                                        new Tool
                                        {
                                            
                                            Toolname = "Oscilloscope",
                                            Quantity = 20
                                        },

                                        new Tool
                                        {
                                            
                                            Toolname = "Soldering Iron",
                                            Quantity = 20
                                        },

                                        new Tool
                                        {
                                            
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