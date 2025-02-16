using ELearning.Data;

namespace ELearning.Repository
{
    public class GenericRepository <TEntity> where TEntity : class
    {
        ApplicationDbContext dbContext;

        public GenericRepository( ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<TEntity> Getall()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        public TEntity Getbyid(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }


        public void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        public void Edit(TEntity entity)
        {
            dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void delete(int id)
        {
            TEntity t = Getbyid(id);
            dbContext.Set<TEntity>().Remove(t);
        }

        public void save()
        {
            dbContext.SaveChanges();
        }

    }
}
