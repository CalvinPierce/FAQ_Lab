﻿// <auto-generated />
using FAQ_Lab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAQ_Lab.Migrations
{
    [DbContext(typeof(FaqsContext))]
    partial class FaqsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAQ_Lab.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "gen",
                            Name = "General"
                        },
                        new
                        {
                            CategoryId = "hist",
                            Name = "History"
                        });
                });

            modelBuilder.Entity("FAQ_Lab.Models.FAQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TopicId");

                    b.ToTable("FAQs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "A general purpose object-oriented language that uses concise java-like syntax",
                            CategoryId = "gen",
                            Question = "What is C#?",
                            TopicId = "cs"
                        },
                        new
                        {
                            Id = 2,
                            Answer = "A general purpose scripting language that executes in a web browser",
                            CategoryId = "gen",
                            Question = "What is JavaScript?",
                            TopicId = "js"
                        },
                        new
                        {
                            Id = 3,
                            Answer = "A CSS framework for creating responsive web apps for multiple screen sizes",
                            CategoryId = "gen",
                            Question = "What is Bootstrap?",
                            TopicId = "boot"
                        },
                        new
                        {
                            Id = 4,
                            Answer = "In 2011",
                            CategoryId = "hist",
                            Question = "When was Boostrap first released?",
                            TopicId = "boot"
                        },
                        new
                        {
                            Id = 5,
                            Answer = "In 2002",
                            CategoryId = "hist",
                            Question = "When was C# first released?",
                            TopicId = "cs"
                        });
                });

            modelBuilder.Entity("FAQ_Lab.Models.Topic", b =>
                {
                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = "cs",
                            Name = "C#"
                        },
                        new
                        {
                            TopicId = "js",
                            Name = "JavaScript"
                        },
                        new
                        {
                            TopicId = "boot",
                            Name = "Bootstrap"
                        });
                });

            modelBuilder.Entity("FAQ_Lab.Models.FAQ", b =>
                {
                    b.HasOne("FAQ_Lab.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("FAQ_Lab.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId");

                    b.Navigation("Category");

                    b.Navigation("Topic");
                });
#pragma warning restore 612, 618
        }
    }
}
