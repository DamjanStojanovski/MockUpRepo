using DataLibrary;

namespace Repositories.Repositories
{
    public class BaseRepository
    {
        protected readonly SchoolsDbContext _dbContext; 
        public BaseRepository(SchoolsDbContext dbContext )
        {
            _dbContext = dbContext;
        }
    }
}
