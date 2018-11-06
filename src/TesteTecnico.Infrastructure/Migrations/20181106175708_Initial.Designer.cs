﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteTecnico.Infrastructure.Data;

namespace TesteTecnico.Infrastructure.Migrations
{
    [DbContext(typeof(TesteTecnicoContext))]
    [Migration("20181106175708_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Complement");

                    b.Property<string>("Neighborhood");

                    b.Property<string>("Number");

                    b.Property<int>("PersonId");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

                    b.HasKey("AddressId");

                    b.HasIndex("PersonId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.Customer", b =>
                {
                    b.Property<int>("CustomerId");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.LegalPerson", b =>
                {
                    b.Property<int>("LegalPersonId");

                    b.Property<string>("CNPJ");

                    b.Property<string>("FantasyName");

                    b.Property<string>("SocialName");

                    b.Property<string>("StateRegistration");

                    b.HasKey("LegalPersonId");

                    b.ToTable("LegalPeople");
                });

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TypePersonId");

                    b.HasKey("PersonId");

                    b.HasIndex("TypePersonId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.PhysicalPerson", b =>
                {
                    b.Property<int>("PhysicalPersonId");

                    b.Property<string>("CPF");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("RG");

                    b.HasKey("PhysicalPersonId");

                    b.ToTable("PhisicalsPeople");
                });

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.TypePerson", b =>
                {
                    b.Property<int>("TypePersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("TypePersonId");

                    b.ToTable("TypesPeople");
                });

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.Address", b =>
                {
                    b.HasOne("TesteTecnico.ApplicationCore.Entity.Person", "Person")
                        .WithMany("Address")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.Customer", b =>
                {
                    b.HasOne("TesteTecnico.ApplicationCore.Entity.Person", "Person")
                        .WithOne("Customer")
                        .HasForeignKey("TesteTecnico.ApplicationCore.Entity.Customer", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.LegalPerson", b =>
                {
                    b.HasOne("TesteTecnico.ApplicationCore.Entity.Person", "Person")
                        .WithOne("LegalPerson")
                        .HasForeignKey("TesteTecnico.ApplicationCore.Entity.LegalPerson", "LegalPersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.Person", b =>
                {
                    b.HasOne("TesteTecnico.ApplicationCore.Entity.TypePerson", "TypePerson")
                        .WithMany()
                        .HasForeignKey("TypePersonId");
                });

            modelBuilder.Entity("TesteTecnico.ApplicationCore.Entity.PhysicalPerson", b =>
                {
                    b.HasOne("TesteTecnico.ApplicationCore.Entity.Person", "Person")
                        .WithOne("PhysicalPerson")
                        .HasForeignKey("TesteTecnico.ApplicationCore.Entity.PhysicalPerson", "PhysicalPersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
