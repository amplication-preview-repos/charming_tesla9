using Microsoft.EntityFrameworkCore;

namespace SearchWebService.Infrastructure;

public class SearchWebServiceDbContext : DbContext
{
    public SearchWebServiceDbContext(DbContextOptions<SearchWebServiceDbContext> options)
        : base(options) { }
}
