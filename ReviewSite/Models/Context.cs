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
                new Category() { Id=3, Name = "Hard-Working"}
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