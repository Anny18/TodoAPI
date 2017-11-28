using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    /// <summary>
    /// add by zhao.yanqin 
    /// database context是为模型提供数据的主要类配合Entity Framework.这个类继承自Microsoft.EntityFrameworkCore.DbContext
    /// </summary>
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) :
           base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
