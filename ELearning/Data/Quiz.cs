namespace ELearning.Data
{
    public class Quiz
    {
        public int Id { get; set; }        
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        //-------------- Obj From Course Abd Forigen key CourseId ---------------
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }



        //-------------- ICollection From Question  ---------------
        public virtual ICollection<Question> Questions { get; set; }
    }
}
