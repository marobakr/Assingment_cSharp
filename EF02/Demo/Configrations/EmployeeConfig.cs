using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Session_01.Configrations;

public class EmployeeConfig: IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> E)
    {
      
    }
}