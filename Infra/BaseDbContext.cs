using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infra
{
    public class BaseDbContext : DbContext
    {
        private IConfiguration _configuration;
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public BaseDbContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration ?? throw new ArgumentException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var typeDatabase = _configuration["TypeDatabase"];
            var connectionString = _configuration.GetConnectionString(typeDatabase);
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}
