﻿// <auto-generated />
using System;
using BlazorServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorServer.Migrations
{
    [DbContext(typeof(TrainingProgramContext))]
    partial class TrainingProgramContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("BlazorServer.Data.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExerciseName")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfRepeats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfSets")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TrainingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("ExerciseId");

                    b.HasIndex("TrainingId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("BlazorServer.Data.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.HasKey("NoteId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("BlazorServer.Data.Training", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TrainingName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TrainingProgramId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TrainingId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("BlazorServer.Data.TrainingProgram", b =>
                {
                    b.Property<int>("TrainingProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TrainingProgramName")
                        .HasColumnType("TEXT");

                    b.HasKey("TrainingProgramId");

                    b.ToTable("TrainingPrograms");
                });

            modelBuilder.Entity("BlazorServer.Data.Exercise", b =>
                {
                    b.HasOne("BlazorServer.Data.Training", null)
                        .WithMany("Exercises")
                        .HasForeignKey("TrainingId");
                });

            modelBuilder.Entity("BlazorServer.Data.Training", b =>
                {
                    b.HasOne("BlazorServer.Data.TrainingProgram", null)
                        .WithMany("Trainings")
                        .HasForeignKey("TrainingProgramId");
                });
#pragma warning restore 612, 618
        }
    }
}
