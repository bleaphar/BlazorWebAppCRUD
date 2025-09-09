using Microsoft.EntityFrameworkCore;

public class MovieDbContext(DbContextOptions<MovieDbContext> options) : DbContext(options)
{
    public DbSet<BlazorWebAppCRUD.Models.Movie> Movie { get; set; } = default!;
}
