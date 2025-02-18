using Microsoft.AspNetCore.Identity;

namespace ELearning.Data
{
    public class User:IdentityUser
    {
        public User()
        {
            Id = Guid.CreateVersion7().ToString();
            SecurityStamp = Guid.CreateVersion7().ToString();
        }

        public string Name { get; set; } = string.Empty;   
        public DateTime CreatedAt { get; set; }=DateTime.Now;


        //-------------- ICollection From Course  ---------------
        public virtual ICollection<Course> Courses { get; set; }


        //-------------- ICollection From Enrollment  ---------------
        public virtual ICollection<Enrollment> Enrollments { get; set; }



        //-------------- ICollection From Answer  ---------------
        public virtual ICollection<Answer> Answers { get; set; }



        //-------------- ICollection From Payment  ---------------
        public virtual ICollection<Payment> Payments { get; set; }



        //-------------- ICollection From Review  ---------------
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
