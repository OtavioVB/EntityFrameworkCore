using Microsoft.EntityFrameworkCore;

namespace EFCore.Infra.DataContext;

public class DataContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=127.0.0.1;database=efcore;uid=otavio;pwd=1234;port=3306", ServerVersion.AutoDetect(new MySqlConnector.MySqlConnection("server=127.0.0.1;database=efcore_migrations;uid=otavio;pwd=1234;port=3306")));
    }
}
