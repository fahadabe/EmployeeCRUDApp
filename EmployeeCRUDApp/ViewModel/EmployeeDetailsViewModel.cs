using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUDApp.ViewModel;
[QueryProperty(nameof(SelectedEmployee), "employee")]
public partial class EmployeeDetailsViewModel : ObservableObject
{
    private readonly IEmployeeService _employeeService;
    public EmployeeDetailsViewModel(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
       
    }

    [ObservableProperty]
    private Employee selectedEmployee;


    [RelayCommand]
    private async Task DeleteEmployee()
    {
        bool answer = await Shell.Current.DisplayAlert("Delete Employee", $"Are you sure you want to delete '{SelectedEmployee.FirstName} {SelectedEmployee.LastName}'?", "Yes", "No");
        if (answer)
        {
            if (await _employeeService.DeleteEmployee(SelectedEmployee))
            {
                await Shell.Current.GoToAsync("../", true);
            }
        }

    }

    [RelayCommand]
    private async Task UpdateEmployee()
    {
        if(await _employeeService.UpdateEmployee(SelectedEmployee))
        {
            await Shell.Current.GoToAsync("../", true);
        }
    }
}
