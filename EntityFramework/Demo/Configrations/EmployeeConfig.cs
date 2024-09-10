using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Session_01.Configrations;

public class EmployeeConfig: IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> E)
    {
      
        E.HasKey((E) => E.Id); // Add Primary Key
        E.Property((E) => E.Salary).HasColumnType("money").IsRequired().HasDefaultValue(0); // Change Data Type: Add Column Type and Not Null and default value
        E.Property((E) => E.Age).IsRequired().HasDefaultValue(18); // Not Null: Add Required constraint and default value
        E.Property((E) => E.Phone).IsRequired().HasMaxLength(15); // Not Null: Add Required constraint and Maximum Length
        E.Property((E) => E.Email).IsRequired().HasMaxLength(50); // Not Null: Add Required constraint and Maximum Length
        E.Property((E) => E.address).HasMaxLength(100); // Maximum Length
    }
}