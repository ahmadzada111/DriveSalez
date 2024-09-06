using DriveSalez.Domain.Entities;
using DriveSalez.Domain.RepositoryContracts;
using DriveSalez.Persistence.DbContext;

namespace DriveSalez.Persistence.Repositories;

internal class OptionRepository : GenericRepository<Option>, IOptionRepository
{
    public OptionRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        
    }
}