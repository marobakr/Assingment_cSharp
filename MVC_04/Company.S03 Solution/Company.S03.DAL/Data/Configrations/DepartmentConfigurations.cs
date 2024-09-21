using Company.S03.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.S03.DAL.Data.Configrations;

public class DepartmentConfigurations:IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.Property(D => D.Id).UseIdentityColumn(10, 10);
    }
}