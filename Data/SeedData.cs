using Microsoft.EntityFrameworkCore;
using BlazorTeamRegistrationApp.Models;

namespace BlazorTeamRegistrationApp.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new BlazorTeamRegistrationContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<BlazorTeamRegistrationContext>>());

        if (context == null || context.Player == null)
        {
            throw new NullReferenceException(
                "Null BlazorTeamRegistrationContext or Movie DbSet");
        }

        if (context.Player.Any())
        {
            return;
        }

        context.Player.AddRange(
            new Player
            {
                FirstName = "Alexander",
                LastName = "Ovechkin",
                Height = 190,
                Weight = 110,
                GamesPlayed = 82,
                Goals = 50,
                Assists = 35,
                Points = 85,
                DoB = new DateOnly(1985 , 5, 5)

            },
            new Player
            {
                FirstName = "Sidney",
                LastName = "Crosby",
                Height = 186,
                Weight = 95,
                GamesPlayed = 72,
                Goals = 38,
                Assists = 47,
                Points = 85,
                DoB = new DateOnly(1986, 9, 23)
            },
            new Player
            {
                FirstName = "Jaromir",
                LastName = "Jagr",
                Height = 201,
                Weight = 130,
                GamesPlayed = 82,
                Goals = 62,
                Assists = 57,
                Points = 119,
                DoB = new DateOnly(1980, 2, 12)
            },
            new Player
            {
                FirstName = "Steve",
                LastName = "Yzerman",
                Height = 184,
                Weight = 86,
                GamesPlayed = 80,
                Goals = 40,
                Assists = 45,
                Points = 95,
                DoB = new DateOnly(1980, 2, 12)
            },
            new Player
            {
                FirstName = "Bobby",
                LastName = "Orr",
                Height = 187,
                Weight = 96,
                GamesPlayed = 76,
                Goals = 32,
                Assists = 67,
                Points = 99,
                DoB = new DateOnly(1972, 11, 18)
            }
            );

        context.SaveChanges();
    }
}