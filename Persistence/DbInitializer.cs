using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Subjects.Any()) return;

        var subjects = new List<Subject>
        {
            new Subject
            {
               Name = "Movie",
               Description = "Its a movie",
               DatePublished = DateTime.Now.AddMonths(8)
            }
        };

        context.Subjects.AddRange(subjects);

        await context.SaveChangesAsync();
    }
}
