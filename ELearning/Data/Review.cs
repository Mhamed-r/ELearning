namespace ELearning.Data
{
    public class Review
    {
        public int Id { get; set; }     
        public int Rating { get; set; }
        public string Comment { get; set; }



        //-------------- Obj From User Abd Forigen key StudentId ---------------
        public string StudentId { get; set; }
        public virtual User Student { get; set; }



        //-------------- Obj From Course Abd Forigen key CourseId ---------------
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
