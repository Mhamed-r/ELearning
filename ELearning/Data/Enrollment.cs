namespace ELearning.Data
{
    public class Enrollment
    {
        public int Id { get; set; }      
        public string? Status { get; set; }
        public DateTime EnrolledAt { get; set; }=DateTime.Now;


        //-------------- Obj From Course Abd Forigen key CourseId ---------------
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }


        //-------------- Obj From User Abd Forigen key StudentId ---------------
        public string StudentId { get; set; }
        public virtual User Student { get; set; }
    }

}
