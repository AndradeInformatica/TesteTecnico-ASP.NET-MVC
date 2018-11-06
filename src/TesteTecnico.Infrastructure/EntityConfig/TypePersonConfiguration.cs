//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TesteTecnico.Infrastructure.EntityConfig
//{
//    public class TypePersonConfiguration
//    {
//        modelBuilder.Entity<TypePersons>()
//                .Property(e => e.Description)
//                .IsFixedLength()
//                .IsUnicode(false);

//        modelBuilder.Entity<TypePersons>()
//                .HasMany(e => e.Persons)
//                .WithRequired(e => e.TypePersons)
//                .HasForeignKey(e => e.TypePersonsId)
//                .WillCascadeOnDelete(false);
//    }
//}
