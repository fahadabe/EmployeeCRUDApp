

using CommunityToolkit.Maui.Alerts;

namespace EmployeeCRUDApp.DatabaseAccess;

public class Database : IDatabase
{
    private SQLiteAsyncConnection _dbConnection;

    public async Task<SQLiteAsyncConnection> GetDatabase()
    {
        try
        {
            
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "basiccrud.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                var result = await _dbConnection.CreateTableAsync<Employee>();
                return _dbConnection;
            
        }
        catch (Exception)
        {
            await Toast.Make("An error occurred while setting up the database. Please try again.").Show();
            return null;
        }
    }
}
