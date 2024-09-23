using AutoMapper;
using Company.S03.PL.ViewModels.Employee;

namespace Company.S03.PL.Mapping.Employee;

public class EmployeeProfile: Profile
{
    public EmployeeProfile()
    {
        CreateMap<DAL.Models.Employee, EmployeeViewModel>().ReverseMap();
    }
}