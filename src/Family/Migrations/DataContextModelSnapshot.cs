using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Family;

namespace Family.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20896")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Family.DataModels.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountId");

                    b.Property<int?>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("DateOfDeath");

                    b.Property<int?>("FatherId");

                    b.Property<string>("FirstName");

                    b.Property<string>("MiddleName");

                    b.Property<int?>("ModifiedById");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int?>("MotherId");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("FatherId");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("MotherId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Family.DataModels.Relationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("ModifiedById");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int?>("Person1Id");

                    b.Property<int?>("Person2Id");

                    b.Property<int?>("RelationshipTypeId");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("Person1Id");

                    b.HasIndex("Person2Id");

                    b.HasIndex("RelationshipTypeId");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("Family.DataModels.RelationshipRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Completed");

                    b.Property<int?>("CompletedById");

                    b.Property<DateTime>("CompletedDate");

                    b.Property<int?>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("ModifiedById");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int?>("RelationshipTypeId");

                    b.Property<int?>("RequesterId");

                    b.Property<int>("Result");

                    b.Property<int?>("WithId");

                    b.HasKey("Id");

                    b.HasIndex("CompletedById");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("RelationshipTypeId");

                    b.HasIndex("RequesterId");

                    b.HasIndex("WithId");

                    b.ToTable("RelationshipRequests");
                });

            modelBuilder.Entity("Family.DataModels.RelationshipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<int?>("ModifiedById");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.ToTable("RelationshipTypes");
                });

            modelBuilder.Entity("Family.DataModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<int?>("ModifiedById");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int?>("SelfId");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("SelfId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Family.DataModels.Person", b =>
                {
                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Family.DataModels.Person")
                        .WithOne()
                        .HasForeignKey("Family.DataModels.Person", "FatherId");

                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Family.DataModels.Person")
                        .WithMany()
                        .HasForeignKey("MotherId");
                });

            modelBuilder.Entity("Family.DataModels.Relationship", b =>
                {
                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Family.DataModels.Person")
                        .WithMany()
                        .HasForeignKey("Person1Id");

                    b.HasOne("Family.DataModels.Person")
                        .WithMany()
                        .HasForeignKey("Person2Id");

                    b.HasOne("Family.DataModels.RelationshipType")
                        .WithMany()
                        .HasForeignKey("RelationshipTypeId");
                });

            modelBuilder.Entity("Family.DataModels.RelationshipRequest", b =>
                {
                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("CompletedById");

                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Family.DataModels.RelationshipType")
                        .WithMany()
                        .HasForeignKey("RelationshipTypeId");

                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("RequesterId");

                    b.HasOne("Family.DataModels.Person")
                        .WithMany()
                        .HasForeignKey("WithId");
                });

            modelBuilder.Entity("Family.DataModels.RelationshipType", b =>
                {
                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("ModifiedById");
                });

            modelBuilder.Entity("Family.DataModels.User", b =>
                {
                    b.HasOne("Family.DataModels.User")
                        .WithOne()
                        .HasForeignKey("Family.DataModels.User", "CreatedById");

                    b.HasOne("Family.DataModels.User")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Family.DataModels.Person")
                        .WithMany()
                        .HasForeignKey("SelfId");
                });
        }
    }
}
