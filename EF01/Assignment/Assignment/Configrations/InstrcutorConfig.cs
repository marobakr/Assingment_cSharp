using Assignment.Intities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Configrations;

public class InstrcutorConfig:IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> I)
    {
        I.HasKey((I) => I.Id); // Add Primary Key
        I.Property((I) => I.Salary).HasColumnType("money").IsRequired().HasDefaultValue(0); // Change Data Type: Add Column Type and Not Null and default value
        I.Property((I) => I.Bouns).IsRequired().HasDefaultValue(18); // Not Null: Add Required constraint and default value
        I.Property((I) => I.HourRate).IsRequired(); // Not Null: Add Required constraint 
        I.Property((I) => I.Dept_id).IsRequired().HasMaxLength(50); // Not Null: Add Required constraint and Maximum Length
        I.Property((I) => I.address).HasMaxLength(100); // Maximum Length
    }
}