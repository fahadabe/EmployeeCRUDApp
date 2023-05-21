namespace EmployeeCRUDApp.View;

public partial class NewEmployeePage : ContentPage
{
	public NewEmployeePage(NewEmployeeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}