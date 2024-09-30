﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Step_footbal.Context;

#nullable disable

namespace Step_footbal.Migrations
{
    [DbContext(typeof(PrimeraContext))]
    partial class PrimeraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Step_footbal.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("MatchDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Team1Goals")
                        .HasColumnType("int");

                    b.Property<int>("Team1Id")
                        .HasColumnType("int");

                    b.Property<int>("Team2Goals")
                        .HasColumnType("int");

                    b.Property<int>("Team2Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Team1Id");

                    b.HasIndex("Team2Id");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MatchDate = new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Team1Goals = 2,
                            Team1Id = 1,
                            Team2Goals = 1,
                            Team2Id = 2
                        },
                        new
                        {
                            Id = 2,
                            MatchDate = new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Team1Goals = 1,
                            Team1Id = 3,
                            Team2Goals = 1,
                            Team2Id = 4
                        },
                        new
                        {
                            Id = 3,
                            MatchDate = new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Team1Goals = 3,
                            Team1Id = 5,
                            Team2Goals = 2,
                            Team2Id = 6
                        },
                        new
                        {
                            Id = 4,
                            MatchDate = new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Team1Goals = 0,
                            Team1Id = 7,
                            Team2Goals = 0,
                            Team2Id = 8
                        },
                        new
                        {
                            Id = 5,
                            MatchDate = new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Team1Goals = 4,
                            Team1Id = 1,
                            Team2Goals = 2,
                            Team2Id = 3
                        },
                        new
                        {
                            Id = 6,
                            MatchDate = new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Team1Goals = 1,
                            Team1Id = 2,
                            Team2Goals = 3,
                            Team2Id = 4
                        },
                        new
                        {
                            Id = 7,
                            MatchDate = new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Team1Goals = 2,
                            Team1Id = 5,
                            Team2Goals = 2,
                            Team2Id = 7
                        },
                        new
                        {
                            Id = 8,
                            MatchDate = new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Team1Goals = 1,
                            Team1Id = 6,
                            Team2Goals = 1,
                            Team2Id = 8
                        });
                });

            modelBuilder.Entity("Step_footbal.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Argentina",
                            FullName = "Lionel Messi",
                            Number = 10,
                            Position = "Forward",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Country = "France",
                            FullName = "Karim Benzema",
                            Number = 9,
                            Position = "Forward",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 3,
                            Country = "Uruguay",
                            FullName = "Luis Suarez",
                            Number = 9,
                            Position = "Forward",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 4,
                            Country = "Croatia",
                            FullName = "Ivan Rakitic",
                            Number = 10,
                            Position = "Midfielder",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 5,
                            Country = "Spain",
                            FullName = "Carlos Soler",
                            Number = 8,
                            Position = "Midfielder",
                            TeamId = 5
                        },
                        new
                        {
                            Id = 6,
                            Country = "France",
                            FullName = "Nabil Fekir",
                            Number = 8,
                            Position = "Midfielder",
                            TeamId = 6
                        },
                        new
                        {
                            Id = 7,
                            Country = "Spain",
                            FullName = "Gerard Moreno",
                            Number = 7,
                            Position = "Forward",
                            TeamId = 7
                        },
                        new
                        {
                            Id = 8,
                            Country = "Spain",
                            FullName = "Mikel Oyarzabal",
                            Number = 10,
                            Position = "Forward",
                            TeamId = 8
                        },
                        new
                        {
                            Id = 9,
                            Country = "France",
                            FullName = "Antoine Griezmann",
                            Number = 7,
                            Position = "Forward",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 10,
                            Country = "Spain",
                            FullName = "Sergio Ramos",
                            Number = 4,
                            Position = "Defender",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 11,
                            Country = "Slovenia",
                            FullName = "Jan Oblak",
                            Number = 1,
                            Position = "Goalkeeper",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 12,
                            Country = "Spain",
                            FullName = "Jesus Navas",
                            Number = 16,
                            Position = "Defender",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 13,
                            Country = "Spain",
                            FullName = "Jose Gaya",
                            Number = 14,
                            Position = "Defender",
                            TeamId = 5
                        },
                        new
                        {
                            Id = 14,
                            Country = "Spain",
                            FullName = "Marc Bartra",
                            Number = 5,
                            Position = "Defender",
                            TeamId = 6
                        },
                        new
                        {
                            Id = 15,
                            Country = "Spain",
                            FullName = "Pau Torres",
                            Number = 4,
                            Position = "Defender",
                            TeamId = 7
                        },
                        new
                        {
                            Id = 16,
                            Country = "Spain",
                            FullName = "David Silva",
                            Number = 21,
                            Position = "Midfielder",
                            TeamId = 8
                        },
                        new
                        {
                            Id = 17,
                            Country = "Netherlands",
                            FullName = "Frenkie de Jong",
                            Number = 21,
                            Position = "Midfielder",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 18,
                            Country = "Croatia",
                            FullName = "Luka Modric",
                            Number = 10,
                            Position = "Midfielder",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 19,
                            Country = "Spain",
                            FullName = "Koke",
                            Number = 6,
                            Position = "Midfielder",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 20,
                            Country = "Argentina",
                            FullName = "Lucas Ocampos",
                            Number = 5,
                            Position = "Midfielder",
                            TeamId = 4
                        });
                });

            modelBuilder.Entity("Step_footbal.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Draws")
                        .HasColumnType("int");

                    b.Property<int>("GoalsConceded")
                        .HasColumnType("int");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("int");

                    b.Property<int>("Losses")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Barcelona",
                            Draws = 8,
                            GoalsConceded = 33,
                            GoalsScored = 85,
                            Losses = 4,
                            Name = "FC Barcelona",
                            Wins = 26
                        },
                        new
                        {
                            Id = 2,
                            City = "Madrid",
                            Draws = 8,
                            GoalsConceded = 36,
                            GoalsScored = 88,
                            Losses = 5,
                            Name = "Real Madrid",
                            Wins = 25
                        },
                        new
                        {
                            Id = 3,
                            City = "Madrid",
                            Draws = 8,
                            GoalsConceded = 30,
                            GoalsScored = 70,
                            Losses = 6,
                            Name = "Atletico Madrid",
                            Wins = 24
                        },
                        new
                        {
                            Id = 4,
                            City = "Sevilla",
                            Draws = 8,
                            GoalsConceded = 40,
                            GoalsScored = 65,
                            Losses = 8,
                            Name = "Sevilla FC",
                            Wins = 22
                        },
                        new
                        {
                            Id = 5,
                            City = "Valencia",
                            Draws = 8,
                            GoalsConceded = 45,
                            GoalsScored = 60,
                            Losses = 10,
                            Name = "Valencia CF",
                            Wins = 20
                        },
                        new
                        {
                            Id = 6,
                            City = "Sevilla",
                            Draws = 8,
                            GoalsConceded = 50,
                            GoalsScored = 55,
                            Losses = 12,
                            Name = "Real Betis",
                            Wins = 18
                        },
                        new
                        {
                            Id = 7,
                            City = "Villarreal",
                            Draws = 8,
                            GoalsConceded = 55,
                            GoalsScored = 50,
                            Losses = 14,
                            Name = "Villarreal CF",
                            Wins = 16
                        },
                        new
                        {
                            Id = 8,
                            City = "San Sebastian",
                            Draws = 8,
                            GoalsConceded = 60,
                            GoalsScored = 45,
                            Losses = 16,
                            Name = "Real Sociedad",
                            Wins = 14
                        });
                });

            modelBuilder.Entity("Step_footbal.Models.Match", b =>
                {
                    b.HasOne("Step_footbal.Models.Team", "Team1")
                        .WithMany()
                        .HasForeignKey("Team1Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Step_footbal.Models.Team", "Team2")
                        .WithMany()
                        .HasForeignKey("Team2Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Team1");

                    b.Navigation("Team2");
                });

            modelBuilder.Entity("Step_footbal.Models.Player", b =>
                {
                    b.HasOne("Step_footbal.Models.Match", null)
                        .WithMany("Scorers")
                        .HasForeignKey("MatchId");

                    b.HasOne("Step_footbal.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Step_footbal.Models.Match", b =>
                {
                    b.Navigation("Scorers");
                });
#pragma warning restore 612, 618
        }
    }
}