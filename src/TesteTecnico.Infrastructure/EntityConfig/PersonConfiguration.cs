//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TesteTecnico.Infrastructure.EntityConfig
//{
//    public class PersonConfiguration : EntityTypeConfiguration<Person>
//    {
//        modelBuilder.Entity<Persons>()
//                .HasMany(e => e.Addresses)
//                .WithRequired(e => e.Persons)
//                .WillCascadeOnDelete(false);

//        modelBuilder.Entity<Persons>()
//                .HasOptional(e => e.Carriers)
//                .WithRequired(e => e.Persons);

//        modelBuilder.Entity<Persons>()
//                .HasOptional(e => e.Customers)
//                .WithRequired(e => e.Persons);

//        modelBuilder.Entity<Persons>()
//                .HasMany(e => e.Emails)
//                .WithRequired(e => e.Persons)
//                .WillCascadeOnDelete(false);

//        modelBuilder.Entity<Persons>()
//                .HasOptional(e => e.LegalPersons)
//                .WithRequired(e => e.Persons);

//        modelBuilder.Entity<Persons>()
//                .HasMany(e => e.Orders)
//                .WithRequired(e => e.Persons)
//                .HasForeignKey(e => e.PersonEmitterId)
//                .WillCascadeOnDelete(false);

//        modelBuilder.Entity<Persons>()
//                .HasMany(e => e.Orders1)
//                .WithRequired(e => e.Persons1)
//                .HasForeignKey(e => e.PersonReceiver)
//                .WillCascadeOnDelete(false);

//        modelBuilder.Entity<Persons>()
//                .HasMany(e => e.Phones)
//                .WithRequired(e => e.Persons)
//                .WillCascadeOnDelete(false);

//        modelBuilder.Entity<Persons>()
//                .HasOptional(e => e.PhysicalPersons)
//                .WithRequired(e => e.Persons);

//        modelBuilder.Entity<Persons>()
//                .HasOptional(e => e.Providers)
//                .WithRequired(e => e.Persons);

//        modelBuilder.Entity<Persons>()
//                .HasOptional(e => e.Subsidiaries)
//                .WithRequired(e => e.Persons);
//    }
//}
