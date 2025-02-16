using System.ComponentModel.DataAnnotations.Schema;

namespace ELearning.Data
{
    public class Course
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }       
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        //-------------- Obj From User Abd Forigen key InstructorId ---------------       
        public string InstructorId { get; set; }
        public User Instructor { get; set; }



        //-------------- ICollection From Lesson  ---------------
        public ICollection<Lesson> Lessons { get; set; }



        //-------------- ICollection From Quiz  ---------------
        public ICollection<Quiz> Quizzes { get; set; }



        //-------------- ICollection From Enrollment  ---------------
        public ICollection<Enrollment> Enrollments { get; set; }



        //-------------- ICollection From Payment  ---------------
        public ICollection<Payment> Payments { get; set; }



        //-------------- ICollection From Review  ---------------
        public ICollection<Review> Reviews { get; set; }

    }
}
