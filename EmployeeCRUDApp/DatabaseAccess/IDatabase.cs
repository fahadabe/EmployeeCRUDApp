using CommunityToolkit.Maui.Alerts;

namespace EmployeeCRUDApp.DatabaseAccess;

public interface IDatabase
{
    Task<SQLiteAsyncConnection> GetDatabase();
}