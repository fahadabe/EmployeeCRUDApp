using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

namespace EmployeeCRUDApp.View;

public partial class EmployeesPage : ContentPage
{
    private EmployeeViewModel _viewModel;
    public EmployeesPage(EmployeeViewModel vm)
	{
		InitializeComponent();
        _viewModel = vm;
        BindingContext = vm;

	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        
        _viewModel.GetEmployeesCommand.Execute(null);
    }
}