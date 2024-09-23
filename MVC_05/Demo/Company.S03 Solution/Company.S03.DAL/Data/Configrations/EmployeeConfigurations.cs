using Company.S03.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.S03.DAL.Data.Configurations;

public class EmployeeConfigurations:IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(e => e.Salary).HasColumnType("decimal(18,2)");
    }
}