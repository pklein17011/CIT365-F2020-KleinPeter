using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace My_Scripture_Journal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new My_Scripture_JournalContext(
                 serviceProvider.GetRequiredService<
                     DbContextOptions<My_Scripture_JournalContext>>()))
            {
                // Look for any scriptures
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        NoteTitle = "1 Nephi 3:7",
                        Book = "1 Nephi",
                        Chapter = 3,
                        Verse = 7,
                        Note = "I can do hard things",
                        Passage = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
                        DateAdded = DateTime.Parse("2020-5-29")
                    },

                    new Scripture
                    {
                        NoteTitle = "Jacob 6:12",
                        Book = "Jacob",
                        Chapter = 6,
                        Verse = 12,
                        Note = "Don't be dumb",
                        Passage = "O be wise; what can I say more?",
                        DateAdded = DateTime.Parse("2091-10-31")
                    },

                    new Scripture
                    {
                        NoteTitle = "John 15:14",
                        Book = "John",
                        Chapter = 15,
                        Verse = 14,
                        Note = "The question is whether or not you will choose to be Christ's friend",
                        Passage = "Ye are my friends, if ye do whatsoever I command you.",
                        DateAdded = DateTime.Parse("2021-11-1")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}