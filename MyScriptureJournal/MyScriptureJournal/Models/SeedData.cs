using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context.Scripture.Any())
                {
                    return;
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "John",
                        Verse = "3:16",
                        Notes = "He so loved the world.",
                        AddedDate = DateTime.Now
                    },

                    new Scripture
                    {
                        Book = "Moroni",
                        Verse = "10:3-5",
                        Notes = "Know the truth of all things",
                        AddedDate = DateTime.Now
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
