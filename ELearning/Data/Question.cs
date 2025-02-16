namespace ELearning.Data
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }



        //-------------- Obj From Quez Abd Forigen key QuizId ---------------
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }



        //-------------- ICollection From Answer  ---------------
        public ICollection<Answer> Answers { get; set; }
    }
}
