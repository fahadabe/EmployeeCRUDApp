

using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

namespace EmployeeCRUDApp.View;

public partial class EmployeeDetailsPage : ContentPage
{
    
    public EmployeeDetailsPage(EmployeeDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}