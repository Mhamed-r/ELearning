using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELearning.Data
{
    public class Course
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        //-------------- Obj From User Abd Forigen keyInstructorId ---------------
        [DisplayName("Instructor")]
        public string InstructorId { get; set; }
        public virtual User? Instructor { get; set; }



        //-------------- ICollection From Lesson  ---------------
        public virtual ICollection<Lesson>? Lessons { get; set; }



        //-------------- ICollection From Quiz  ---------------
        public virtual ICollection<Quiz>? Quizzes { get; set; }



        //-------------- ICollection From Enrollment  ---------------
        public virtual ICollection<Enrollment>? Enrollments { get; set; }



        //-------------- ICollection From Payment  ---------------
        public virtual ICollection<Payment>? Payments { get; set; }



        //-------------- ICollection From Review  ---------------
        public virtual ICollection<Review>? Reviews { get; set; }

    }
}
