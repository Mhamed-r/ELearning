using Microsoft.AspNetCore.Identity;

namespace ELearning.Data
{
    public class User:IdentityUser
    {
        public User()
        {
            Id=Guid.CreateVersion7().ToString();
            SecurityStamp = Guid.CreateVersion7().ToString();
        }

        public string Name { get; set; } = string.Empty;   
        public DateTime CreatedAt { get; set; }= DateTime.Now;


        //-------------- ICollection From Course  ---------------
        public ICollection<Course> Courses { get; set; }


        //-------------- ICollection From Enrollment  ---------------
        public ICollection<Enrollment> Enrollments { get; set; }



        //-------------- ICollection From Answer  ---------------
        public ICollection<Answer> Answers { get; set; }



        //-------------- ICollection From Payment  ---------------
        public ICollection<Payment> Payments { get; set; }



        //-------------- ICollection From Review  ---------------
        public ICollection<Review> Reviews { get; set; }
    }
}
