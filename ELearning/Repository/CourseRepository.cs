using ELearning.Data;
using Microsoft.EntityFrameworkCore;

namespace ELearning.Repository
{
    public class CourseRepository:GenericRepository<Course>
    {
    
        public CourseRepository(ApplicationDbContext dbContext):base(dbContext) 
        {
            
        }
        public  List<User> GetCourseInstructor()
        {
            return  dbContext.Users.ToList();
        }
        //public int StudentsCount() {
        //    int count = dbContext.Courses.Select(C => C.Payments).Count();
        //    return count;
        
        //}




        public bool Exists(int id) {

            return dbContext.Courses.Any(e => e.Id == id);
        }

    }
}
