using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationIdentity.Models;

namespace WebApplicationIdentity.Data
{
    public class AppDbContext(DbContextOptions options)
        : IdentityDbContext<User> (options);
}
