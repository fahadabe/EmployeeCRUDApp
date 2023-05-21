



namespace EmployeeCRUDApp.ViewModel;

public partial class EmployeeViewModel : ObservableObject
{
    private readonly IEmployeeService _employeeService;
    public EmployeeViewModel(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
        
}

    [ObservableProperty]
    private ObservableCollection<Employee> employees =new();

    

    [RelayCommand]
    public async Task GetEmployees()
    {
        Employees = await _employeeService.GetEmployees();
    }

    [RelayCommand]
    private async Task GotoNewEmployeePage()
    {
        await Shell.Current.GoToAsync(nameof(NewEmployeePage), true);
    }

    [RelayCommand]
    private async Task GotoEmployeeDetailsPage(Employee obj)
    {
        if (obj is null)
        {
            return;
        }

        await Shell.Current.GoToAsync(nameof(EmployeeDetailsPage), true, new Dictionary<string, object> { { "employee", obj } });
    }



}
 