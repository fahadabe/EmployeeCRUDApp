using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUDApp.ViewModel;

public partial class NewEmployeeViewModel : ObservableObject
{
    private readonly IEmployeeService _employeeService;
    public NewEmployeeViewModel(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [ObservableProperty]
    private Employee newEmployee = new();


    [RelayCommand]
    private async Task AddEmployee()
    {
        if (await _employeeService.AddEmployee(NewEmployee))
        {
            await Shell.Current.GoToAsync("../", true);
        }
        
    }
}
