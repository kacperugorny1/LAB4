using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LAB4_2.Components;

namespace LAB4_2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<LAB4_2.Components.Book> Book { get; set; } = default!;
        public DbSet<LAB4_2.Components.BookRating> BookRating { get; set; } = default!;
    }
}
