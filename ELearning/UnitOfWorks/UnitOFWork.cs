using ELearning.Data;

namespace ELearning.UnitOfWorks
{
    public class UnitOFWork
    {
        ApplicationDbContext dbContext;
        public UnitOFWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            
        }
    }
}
