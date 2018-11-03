using Microsoft.EntityFrameworkCore;
using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Context : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ReviewTag> ReviewTags { get; set; }
        public DbSet<Comment> Comments { get; set; }


        //SEED DATA
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, Title = "Corgi Type: Untoasted", CategoryId=1,ImageUrl = "/Images/whiteCorgi.png", Content = "Untoasted type Corgis have white fur. It's as if you had a piece of bread and did not put it in a toaster." },
                new Review() { Id = 2, Title = "Corgi Type: Toasted", CategoryId = 1, ImageUrl = "/Images/puppyCorgi.jpg", Content = "Toasted type Corgis have brown fur. Like if you were to take a white piece of bread and put it in the toaster to toast it." },
                new Review() { Id = 3, Title = "Corgi Type: Burnt", CategoryId = 1, ImageUrl = "/Images/blackCorgi.jpg", Content = "Burnt type Corgis have mostly black fur with partial brown and white mixed in. In other words, you left your piece of bread in the toaster for far too long and it got burnt." },
                new Review() { Id = 4, Title = "Corgi Type: Loaf", CategoryId = 1, ImageUrl = "/Images/corgiLoaf.jpg", Content = "It's very easy to mistake Untoasted Corgis as loaves of bread, but if you look closely you can see that it's just a Corgi, no worries." },
                
                new Review() { Id = 5, Title = "Corgi Type: Hero", CategoryId = 2, ImageUrl = "/Images/superCorgi.png", Content = "You're probably thinking, 'why is Captain America on this site?' But look again, it's Captain Corgi! He fights evil day and night to keep us all safe." },
                new Review() { Id = 6, Title = "Corgi Type: Turtle", CategoryId = 2, ImageUrl = "/Images/turtleCorgi.jpg", Content = "A rare photo of the ancient mythical creature know as the Ninja Turtle Corgi!" },

                new Review() { Id = 7, Title = "Corgi Type: Cowboy Corgi", CategoryId = 3, ImageUrl = "/Images/cowboyCorgi.jpg", Content = "Need a ride? Call on Cowboy Corgi to get you from point A to point B in record time!" },
                new Review() { Id = 8, Title = "Corgi Type: Tech Savvy", CategoryId = 3, ImageUrl = "/Images/codingCorgi.jpg", Content = "A rare species of the Coding Corgi in its natural habitat. For all we know, this Corgi created this entire site from scratch." },
                new Review() { Id = 9, Title = "Corgi Type: Musical", CategoryId = 3, ImageUrl = "/Images/guitarCorgi.jpg", Content = "This Corgi learned how to play the guitar when he was only 8 weeks old. He is currently doing a world tour, maybe you'll get lucky enough to snag some tickets!"}
            );

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name="Bread" },
                new Category() { Id = 2, Name = "Super"},
                new Category() { Id = 3 , Name = "Hard-Working"}
                );

            modelBuilder.Entity<Tag>().HasData(
                new Tag() { Id = 1, Name = "Adorable" },
                new Tag() { Id = 2, Name = "Overacheiver" },
                new Tag() { Id = 3, Name = "Underappreciated" }
                );

            modelBuilder.Entity<ReviewTag>().HasData(
                new ReviewTag() { Id = 1, ReviewId = 1, TagId = 3},
                new ReviewTag() { Id = 2, ReviewId = 2, TagId = 1 },
                new ReviewTag() { Id = 3, ReviewId = 2, TagId = 3 },
                new ReviewTag() { Id = 4, ReviewId = 3, TagId = 3 },
                new ReviewTag() { Id = 5, ReviewId = 4, TagId = 1 },
                new ReviewTag() { Id = 6, ReviewId = 5, TagId = 2 },
                new ReviewTag() { Id = 7, ReviewId = 5, TagId = 1 },
                new ReviewTag() { Id = 8, ReviewId = 6, TagId = 3 },
                new ReviewTag() { Id = 9, ReviewId = 7, TagId = 2 },
                new ReviewTag() { Id = 10, ReviewId = 7, TagId = 3 },
                new ReviewTag() { Id = 11, ReviewId = 8, TagId = 2 },
                new ReviewTag() { Id = 12, ReviewId = 9, TagId = 1 },
                new ReviewTag() { Id = 13, ReviewId = 9, TagId = 2 },
                new ReviewTag() { Id = 14, ReviewId = 9, TagId = 3 }
                );

            modelBuilder.Entity<Comment>().HasData(
               new Comment() { Id = 1, Text = "Wow! I've never seen a white Corgi before.", ReviewId=1, CreatedAt = new DateTime(2018, 11, 2) },
               new Comment() { Id = 2, Text = "Such a cute dog!!", ReviewId = 2, CreatedAt = new DateTime(2018, 11, 1) },
               new Comment() { Id = 3, Text = "I want a burnt Corgi!", ReviewId = 3, CreatedAt = new DateTime(2018, 10, 1) },
               new Comment() { Id = 4, Text = "Did anyone else think this was just a loaf a bread?.. no? just me..?", ReviewId = 4, CreatedAt = new DateTime(2018, 9, 29) },
               new Comment() { Id = 5, Text = "I sure do feel safer when Captain Corgi is around.", ReviewId = 5, CreatedAt = new DateTime(2018, 10, 10) },
               new Comment() { Id = 6, Text = "Captain Corgi once helped get my cat out of a tree. Great doggo.", ReviewId = 5, CreatedAt = new DateTime(2018, 10, 15) },
               new Comment() { Id = 7, Text = "I've been searching for this Corgi in the wild for years.. but no luck!", ReviewId = 6, CreatedAt = new DateTime(2018, 10, 3) },
               new Comment() { Id = 8, Text = "Uber was taking too long, so I went with Cowboy Corgi. Highly recommend their service! Way faster than Uber or Lyft!", ReviewId = 7, CreatedAt = new DateTime(2018, 10, 29) },
               new Comment() { Id = 9, Text = "I had Coding Corgi create my website for my business and I have seen such an increase in online traffic of my site! His work is amzing!!", ReviewId = 8, CreatedAt = new DateTime(2018, 10, 30) },
               new Comment() { Id = 10, Text = "GREATEST CONCERT I'VE EVER BEEN TO!", ReviewId = 9, CreatedAt = new DateTime(2018, 10, 15) },
               new Comment() { Id = 11, Text = "You should highly consider putting this Corgi's concert on your bucket list.", ReviewId = 9, CreatedAt = new DateTime(2018, 11, 2) }
               );

            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MRReviews;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
    }
}