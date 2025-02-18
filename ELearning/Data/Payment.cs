namespace ELearning.Data
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }= DateTime.Now;
        public string Status { get; set; }



        //-------------- Obj From User Abd Forigen key StudentId ---------------
        public string StudentId { get; set; }
        public virtual User Student { get; set; }



        //-------------- Obj From Course Abd Forigen key CourseId ---------------
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
