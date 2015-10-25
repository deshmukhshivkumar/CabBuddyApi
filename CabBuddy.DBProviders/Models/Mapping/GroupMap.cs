using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CabBuddy.DBProviders.Models.Mapping
{
    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CabModel)
                .HasMaxLength(50);

            this.Property(t => t.CabNumber)
                .HasMaxLength(50);

            this.Property(t => t.DriverName)
                .HasMaxLength(50);

            this.Property(t => t.DriverNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Group");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CabModel).HasColumnName("CabModel");
            this.Property(t => t.CabNumber).HasColumnName("CabNumber");
            this.Property(t => t.DriverName).HasColumnName("DriverName");
            this.Property(t => t.DriverNumber).HasColumnName("DriverNumber");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
        }
    }
}
