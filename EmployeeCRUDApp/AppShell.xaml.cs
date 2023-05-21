namespace EmployeeCRUDApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(EmployeesPage), typeof(EmployeesPage));
        Routing.RegisterRoute(nameof(NewEmployeePage), typeof(NewEmployeePage));
        Routing.RegisterRoute(nameof(EmployeeDetailsPage), typeof(EmployeeDetailsPage));
    }
}
