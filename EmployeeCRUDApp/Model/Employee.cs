

namespace EmployeeCRUDApp.Model;
public partial class Employee : ObservableObject
{
	private int id;
    [PrimaryKey]
    [AutoIncrement]
    public int Id
	{
		get { return id; }
		set { id = value; OnPropertyChanged(); }
	}

	private string? firstName;

	public string? FirstName
	{
		get { return firstName; }
		set { firstName = value; OnPropertyChanged(); }
	}

	private string? lastName;

	public string? LastName
	{
		get { return lastName; }
		set { lastName = value; OnPropertyChanged(); }
	}

	private string? phoneNumber;

	public string? PhoneNumber
	{
		get { return phoneNumber; }
		set { phoneNumber = value; OnPropertyChanged(); }
	}

	private string? email;

	public string? Email
	{
		get { return email; }
		set { email = value; OnPropertyChanged(); }
	}	


	private string? address;

	public string? Address
	{
		get { return address; }
		set { address = value; OnPropertyChanged(); }
	}











}
