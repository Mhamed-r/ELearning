namespace ELearning.Data
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }


        //-------------- Obj From Question Abd Forigen key QuestionId ---------------
        public int QuestionId { get; set; }
        public Question Question { get; set; }



        //-------------- Obj From User Abd Forigen key StudentId ---------------
        public string StudentId { get; set; }
        public User Student { get; set; }
    }

}
