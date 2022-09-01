using cointeste.Data;
using Microsoft.EntityFrameworkCore;

namespace cointeste.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new cointesteContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<cointesteContext>>()))
            {
                if (context == null || context.Coin == null)
                {
                    throw new ArgumentNullException("Null cointesteContext");
                }

                if (context.Coin.Any())
                {
                    return;
                }

                context.Coin.AddRange(
                    new Coin
                    {
                        Name = "Bitcoin",
                        Price = 42928
                    },

                    new Coin
                    {
                        Name = "Litecoin",
                        Price = 570
                    },

                    new Coin
                    {
                        Name = "Dogecoin",
                        Price = 23
                    },

                    new Coin
                    {
                        Name = "BNB",
                        Price = 450
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
