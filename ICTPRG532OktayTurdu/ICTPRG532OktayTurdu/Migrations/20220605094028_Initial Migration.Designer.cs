﻿// <auto-generated />
using System;
using ICTPRG532OktayTurdu.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ICTPRG532OktayTurdu.Migrations
{
    [DbContext(typeof(PerfectPolicyContext))]
    [Migration("20220605094028_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ICTPRG532OktayTurdu.Entities.Option", b =>
                {
                    b.Property<int>("OptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("OptionLetter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("OptionID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Options");

                    b.HasData(
                        new
                        {
                            OptionID = 1,
                            IsCorrect = false,
                            OptionLetter = "1",
                            OptionText = "Obfuscate it so as to make it difficult to interpret",
                            QuestionID = 1
                        },
                        new
                        {
                            OptionID = 2,
                            IsCorrect = false,
                            OptionLetter = "2",
                            OptionText = "Restrict viewing to only admin staff",
                            QuestionID = 1
                        },
                        new
                        {
                            OptionID = 3,
                            IsCorrect = false,
                            OptionLetter = "3",
                            OptionText = "Only store in hard copy in a locked filing cabinet",
                            QuestionID = 1
                        },
                        new
                        {
                            OptionID = 4,
                            IsCorrect = true,
                            OptionLetter = "4",
                            OptionText = "Store such materials only on our secured network",
                            QuestionID = 1
                        },
                        new
                        {
                            OptionID = 5,
                            IsCorrect = false,
                            OptionLetter = "5",
                            OptionText = "Forward to other developers via email",
                            QuestionID = 1
                        },
                        new
                        {
                            OptionID = 6,
                            IsCorrect = false,
                            OptionLetter = "1",
                            OptionText = "Our company's SOP - Working at Heights",
                            QuestionID = 2
                        },
                        new
                        {
                            OptionID = 7,
                            IsCorrect = false,
                            OptionLetter = "2",
                            OptionText = "Our company's SOP - Vehicle Parking",
                            QuestionID = 2
                        },
                        new
                        {
                            OptionID = 8,
                            IsCorrect = false,
                            OptionLetter = "3",
                            OptionText = "Our Chemical Safety Data Sheets",
                            QuestionID = 2
                        },
                        new
                        {
                            OptionID = 9,
                            IsCorrect = false,
                            OptionLetter = "4",
                            OptionText = "Our Company's Copyright Policy",
                            QuestionID = 2
                        },
                        new
                        {
                            OptionID = 10,
                            IsCorrect = true,
                            OptionLetter = "5",
                            OptionText = "Our company's SOP - Working in a Confined Space",
                            QuestionID = 2
                        },
                        new
                        {
                            OptionID = 11,
                            IsCorrect = true,
                            OptionLetter = "1",
                            OptionText = "Store such details only on our secured network",
                            QuestionID = 3
                        },
                        new
                        {
                            OptionID = 12,
                            IsCorrect = false,
                            OptionLetter = "2",
                            OptionText = "Only store in hard copy in a locked filing cabinet",
                            QuestionID = 3
                        },
                        new
                        {
                            OptionID = 13,
                            IsCorrect = false,
                            OptionLetter = "3",
                            OptionText = "Obfuscate it so as to make it difficult to interpret",
                            QuestionID = 3
                        },
                        new
                        {
                            OptionID = 14,
                            IsCorrect = false,
                            OptionLetter = "4",
                            OptionText = "Can only be viewed by admin staff",
                            QuestionID = 3
                        },
                        new
                        {
                            OptionID = 15,
                            IsCorrect = false,
                            OptionLetter = "5",
                            OptionText = "Can be left unsecured",
                            QuestionID = 3
                        });
                });

            modelBuilder.Entity("ICTPRG532OktayTurdu.Entities.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionTopic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizID")
                        .HasColumnType("int");

                    b.HasKey("QuestionID");

                    b.HasIndex("QuizID");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionID = 1,
                            QuestionImage = "No Image",
                            QuestionText = "With our organisation's copyright material:",
                            QuestionTopic = "Internal Copyright Materials",
                            QuizID = 1
                        },
                        new
                        {
                            QuestionID = 2,
                            QuestionImage = "No Image",
                            QuestionText = "When looking to work in a confined space, I need to review:",
                            QuestionTopic = "Confined Space Work",
                            QuizID = 1
                        },
                        new
                        {
                            QuestionID = 3,
                            QuestionImage = "No Image",
                            QuestionText = "With Commercial in Confidence Client Details, we are required to:",
                            QuestionTopic = "Client Details",
                            QuizID = 1
                        });
                });

            modelBuilder.Entity("ICTPRG532OktayTurdu.Entities.Quiz", b =>
                {
                    b.Property<int>("QuizID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuizAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("QuizDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuizPass")
                        .HasColumnType("int");

                    b.Property<string>("QuizTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuizTopic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuizID");

                    b.ToTable("Quizzes");

                    b.HasData(
                        new
                        {
                            QuizID = 1,
                            QuizAuthor = "Perfect Policies",
                            QuizDate = new DateTime(2022, 6, 1, 19, 40, 28, 259, DateTimeKind.Local).AddTicks(4117),
                            QuizPass = 100,
                            QuizTitle = "Sample Quiz",
                            QuizTopic = "General"
                        });
                });

            modelBuilder.Entity("ICTPRG532OktayTurdu.Entities.UserInfo", b =>
                {
                    b.Property<int>("UserInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserInfoId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ICTPRG532OktayTurdu.Entities.Option", b =>
                {
                    b.HasOne("ICTPRG532OktayTurdu.Entities.Question", "question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("question");
                });

            modelBuilder.Entity("ICTPRG532OktayTurdu.Entities.Question", b =>
                {
                    b.HasOne("ICTPRG532OktayTurdu.Entities.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("ICTPRG532OktayTurdu.Entities.Question", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("ICTPRG532OktayTurdu.Entities.Quiz", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
