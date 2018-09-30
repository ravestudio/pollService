﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pollService.DataAccess;

namespace pollService.Migrations
{
    [DbContext(typeof(PollContext))]
    partial class PollContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("pollService.DataAccess.AnswerOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Correct");

                    b.Property<int>("QuestionId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("AnswerOption");
                });

            modelBuilder.Entity("pollService.DataAccess.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("QuizId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("pollService.DataAccess.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Permalink");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("QuizSet");
                });

            modelBuilder.Entity("pollService.DataAccess.AnswerOption", b =>
                {
                    b.HasOne("pollService.DataAccess.Question")
                        .WithMany("AnswerOptions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("pollService.DataAccess.Question", b =>
                {
                    b.HasOne("pollService.DataAccess.Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId");
                });
#pragma warning restore 612, 618
        }
    }
}
