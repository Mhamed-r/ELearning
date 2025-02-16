namespace ELearning.Data
{
    public class Lesson
    {
        public int Id { get; set; }       
        public string Title { get; set; }
        public string Content { get; set; }
        public string VideoUrl { get; set; }
        public int Order { get; set; }



        //-------------- Obj From Course Abd Forigen key CourseId ---------------
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
