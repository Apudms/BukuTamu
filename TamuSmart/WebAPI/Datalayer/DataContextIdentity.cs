using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Datalayer
{
    public class DataContextIdentity : IdentityDbContext
    {
        public DataContextIdentity(DbContextOptions options) : base(options)
        {
        }
    }
}
