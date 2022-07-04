using Microsoft.EntityFrameworkCore;

namespace MTASecond.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Products.db"); //вместо использования сервера решил использовать sqlite по причине
                                                                  //скорости выполнения тестового задания - под рукой был код, использующий sqlite
            base.OnConfiguring(optionsBuilder);
        }
    }
}