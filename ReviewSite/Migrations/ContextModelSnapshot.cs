﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewSite.Models;

namespace ReviewSite.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewSite.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Name = "Bread" },
                        new { Id = 2, Name = "Super" },
                        new { Id = 3, Name = "Hard-Working" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, Content = "Untoasted type Corgis have white fur. It's as if you had a piece of bread and did not put it in a toaster.", ImageUrl = "/Images/whiteCorgi.png", Title = "Corgi Type: Untoasted" },
                        new { Id = 2, CategoryId = 1, Content = "Toasted type Corgis have brown fur. Like if you were to take a white piece of bread and put it in the toaster to toast it.", ImageUrl = "/Images/puppyCorgi.jpg", Title = "Corgi Type: Toasted" },
                        new { Id = 3, CategoryId = 1, Content = "Burnt type Corgis have mostly black fur with partial brown and white mixed in. In other words, you left your piece of bread in the toaster for far too long and it got burnt.", ImageUrl = "/Images/blackCorgi.jpg", Title = "Corgi Type: Burnt" },
                        new { Id = 4, CategoryId = 1, Content = "It's very easy to mistake Untoasted Corgis as loaves of bread, but if you look closely you can see that it's just a Corgi, no worries.", ImageUrl = "/Images/corgiLoaf.jpg", Title = "Corgi Type: Loaf" },
                        new { Id = 5, CategoryId = 2, Content = "You're probably thinking, 'why is Captain America on this site?' But look again, it's Captain Corgi! He fights evil day and night to keep us all safe.", ImageUrl = "/Images/superCorgi.png", Title = "Corgi Type: Hero" },
                        new { Id = 6, CategoryId = 2, Content = "A rare photo of the ancient mythical creature know as the Ninja Turtle Corgi!", ImageUrl = "/Images/turtleCorgi.jpg", Title = "Corgi Type: Turtle" },
                        new { Id = 7, CategoryId = 3, Content = "Need a ride? Call on Cowboy Corgi to get you from point A to point B in record time!", ImageUrl = "/Images/cowboyCorgi.jpg", Title = "Corgi Type: Cowboy Corgi" },
                        new { Id = 8, CategoryId = 3, Content = "A rare species of the Coding Corgi in its natural habitat. For all we know, this Corgi created this entire site from scratch.", ImageUrl = "/Images/codingCorgi.jpg", Title = "Corgi Type: Tech Savvy" },
                        new { Id = 9, CategoryId = 3, Content = "This Corgi learned how to play the guitar when he was only 8 weeks old. He is currently doing a world tour, maybe you'll get lucky enough to snag some tickets!", ImageUrl = "/Images/guitarCorgi.jpg", Title = "Corgi Type: Musical" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.ReviewTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReviewId");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.HasIndex("TagId");

                    b.ToTable("ReviewTags");

                    b.HasData(
                        new { Id = 1, ReviewId = 1, TagId = 3 },
                        new { Id = 2, ReviewId = 2, TagId = 1 },
                        new { Id = 3, ReviewId = 2, TagId = 3 },
                        new { Id = 4, ReviewId = 3, TagId = 3 },
                        new { Id = 5, ReviewId = 4, TagId = 1 },
                        new { Id = 6, ReviewId = 5, TagId = 2 },
                        new { Id = 7, ReviewId = 5, TagId = 1 },
                        new { Id = 8, ReviewId = 6, TagId = 3 },
                        new { Id = 9, ReviewId = 7, TagId = 2 },
                        new { Id = 10, ReviewId = 7, TagId = 3 },
                        new { Id = 11, ReviewId = 8, TagId = 2 },
                        new { Id = 12, ReviewId = 9, TagId = 1 },
                        new { Id = 13, ReviewId = 9, TagId = 2 },
                        new { Id = 14, ReviewId = 9, TagId = 3 }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new { Id = 1, Name = "Adorable" },
                        new { Id = 2, Name = "Overacheiver" },
                        new { Id = 3, Name = "Underappreciated" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.Review", b =>
                {
                    b.HasOne("ReviewSite.Models.Category", "Category")
                        .WithMany("Reviews")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ReviewSite.Models.ReviewTag", b =>
                {
                    b.HasOne("ReviewSite.Models.Review", "Review")
                        .WithMany("ReviewTags")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ReviewSite.Models.Tag", "Tag")
                        .WithMany("ReviewTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
