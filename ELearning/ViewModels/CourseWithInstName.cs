using ELearning.Data;

namespace ELearning.ViewModels
{
    public class CourseWithInstName
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public string InstructorId { get; set; }
        public int CountStudent { get; set; }
     

        User Instructor { get; set; }  

    }
}
