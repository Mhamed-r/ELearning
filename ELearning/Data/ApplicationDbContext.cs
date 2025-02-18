using System.Reflection.Emit;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ELearning.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Course>().Property(c => c.Price).HasPrecision(18, 2);
            builder.Entity<Payment>().Property(p => p.Amount).HasPrecision(18, 2);


            builder.Entity<User>().HasData(
                   new User
                   {
                       Id = "1",
                       Name = "John Doe",
                       Email = "johndoe@example.com",
                       UserName = "johndoe@example.com",
                       CreatedAt = new DateTime(2023, 1, 1),
                       SecurityStamp = "secure_stamp_1",
                       
                   },
                   new User
                   {
                       Id = "2",
                       Name = "Jane Smith",
                       Email = "janesmith@example.com",
                       UserName = "janesmith@example.com",
                       CreatedAt = new DateTime(2023, 2, 1),
                       SecurityStamp = "secure_stamp_2"
                   }
               );

           
            builder.Entity<Course>().HasData(
                new Course { Id = 1, Title = "Course 1", InstructorId="1", Description = "Description for Course 1",Price=150, CreatedAt = new DateTime(2023, 2, 1)},
                new Course { Id = 2, Title = "Course 2", InstructorId="2", Description = "Description for Course 2", Price = 250,CreatedAt = new DateTime(2023, 2, 1)  }
            );

         
            
            builder.Entity<Enrollment>().HasData(
                new Enrollment { Id = 1, StudentId = "1", CourseId = 1, EnrolledAt = new DateTime(2023, 3, 1) },
                new Enrollment { Id = 2, StudentId = "2", CourseId = 2, EnrolledAt = new DateTime(2023, 3, 2) }
            );
            builder.Entity<Quiz>().HasData(
                new Quiz { Id=1,Title="good", CreatedAt = new DateTime(2023, 2, 1) , CourseId =1,},
                new Quiz { Id = 2, Title = "notgood", CreatedAt = new DateTime(2023, 2, 2), CourseId = 2, }
                );

            builder.Entity<Question>().HasData(
             new Question { Id = 1, QuizId = 1, QuestionText = "what is your name", QuestionType = "chose" },
              new Question { Id = 2, QuizId = 2, QuestionText = "what is your country name ", QuestionType = "chose" }
             );

            builder.Entity<Answer>().HasData(
                new Answer { Id = 1, StudentId = "1", QuestionId = 1, AnswerText = "Answer 1" , IsCorrect =true},
                new Answer { Id = 2, StudentId = "2", QuestionId = 2, AnswerText = "Answer 2", IsCorrect=true }
            );

            
            builder.Entity<Payment>().HasData(
                new Payment { Id = 1, StudentId = "1", Amount = 100, PaymentDate = new DateTime(2023, 3, 1) , CourseId =1, Status ="don"},
                new Payment { Id = 2, StudentId = "2", Amount = 200, PaymentDate = new DateTime(2023, 3, 2), CourseId = 2 , Status="don" }
            );

           
            builder.Entity<Review>().HasData(
                new Review { Id = 1, StudentId = "1", CourseId = 1, Rating = 5, Comment = "Great course!" },
                new Review { Id = 2, StudentId = "2", CourseId = 2, Rating = 4, Comment = "Good course, but could be better." }
            );
        }
    }
    
}
