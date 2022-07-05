using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurdu.Entities
{
    public class PerfectPolicyContext : DbContext
    {
        public PerfectPolicyContext(DbContextOptions options) : base(options)
        {

        }

        // Various functions to set database table
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<UserInfo> Users { get; set; }


        // Initial Data to Add to Database for Testing
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserInfo>().HasData(
               new UserInfo
               {
                   UserInfoId = 1,
                   UserName = "AdminPerfectPolicies",
                   Password = "PerfectPolicies!22"
               });



           builder.Entity<Quiz>().HasData(
                new Quiz
                {
                    QuizID = 1,
                    QuizTopic = "General",
                    QuizAuthor = "Perfect Policies",
                    QuizTitle = "Sample Quiz",
                    QuizDate = DateTime.Now.AddDays(-4),
                    QuizPass = 100
                });

            builder.Entity<Question>().HasData(
                new Question
                {
                    QuestionID = 1,
                    QuestionImage = "No Image",
                    QuestionTopic = "Internal Copyright Materials",
                    QuestionText = "With our organisation's copyright material:",
                    QuizID = 1
                },
                new Question
                {
                    QuestionID = 2,
                    QuestionImage = "No Image",
                    QuestionTopic = "Confined Space Work",
                    QuestionText = "When looking to work in a confined space, I need to review:",
                    QuizID = 1
                },
                new Question
                {
                    QuestionID = 3,
                    QuestionImage = "No Image",
                    QuestionTopic = "Client Details",
                    QuestionText = "With Commercial in Confidence Client Details, we are required to:",
                    QuizID = 1
                });

            builder.Entity<Option>().HasData(
                new Option
                {
                    OptionID = 1,
                    OptionLetter = "1",
                    OptionText = "Obfuscate it so as to make it difficult to interpret",
                    IsCorrect = false,
                    QuestionID = 1
                },
                new Option
                {
                    OptionID = 2,
                    OptionLetter = "2",
                    OptionText = "Restrict viewing to only admin staff",
                    IsCorrect = false,
                    QuestionID = 1
                },
                new Option
                {
                    OptionID = 3,
                    OptionLetter = "3",
                    OptionText = "Only store in hard copy in a locked filing cabinet",
                    IsCorrect = false,
                    QuestionID = 1
                },
                new Option
                {
                    OptionID = 4,
                    OptionLetter = "4",
                    OptionText = "Store such materials only on our secured network",
                    IsCorrect = true,
                    QuestionID = 1
                },
                new Option
                {
                    OptionID = 5,
                    OptionLetter = "5",
                    OptionText = "Forward to other developers via email",
                    IsCorrect = false,
                    QuestionID = 1
                },
                // Question 2
                new Option
                {
                    OptionID = 6,
                    OptionLetter = "1",
                    OptionText = "Our company's SOP - Working at Heights",
                    IsCorrect = false,
                    QuestionID = 2
                },
                new Option
                {
                    OptionID = 7,
                    OptionLetter = "2",
                    OptionText = "Our company's SOP - Vehicle Parking",
                    IsCorrect = false,
                    QuestionID = 2
                },
                new Option
                {
                    OptionID = 8,
                    OptionLetter = "3",
                    OptionText = "Our Chemical Safety Data Sheets",
                    IsCorrect = false,
                    QuestionID = 2
                },
                new Option
                {
                    OptionID = 9,
                    OptionLetter = "4",
                    OptionText = "Our Company's Copyright Policy",
                    IsCorrect = false,
                    QuestionID = 2
                },
                new Option
                {
                    OptionID = 10,
                    OptionLetter = "5",
                    OptionText = "Our company's SOP - Working in a Confined Space",
                    IsCorrect = true,
                    QuestionID = 2
                },
                // Question 3
                new Option
                {
                    OptionID = 11,
                    OptionLetter = "1",
                    OptionText = "Store such details only on our secured network",
                    IsCorrect = true,
                    QuestionID = 3
                },
                new Option
                {
                    OptionID = 12,
                    OptionLetter = "2",
                    OptionText = "Only store in hard copy in a locked filing cabinet",
                    IsCorrect = false,
                    QuestionID = 3
                },
                new Option
                {
                    OptionID = 13,
                    OptionLetter = "3",
                    OptionText = "Obfuscate it so as to make it difficult to interpret",
                    IsCorrect = false,
                    QuestionID = 3
                },
                new Option
                {
                    OptionID = 14,
                    OptionLetter = "4",
                    OptionText = "Can only be viewed by admin staff",
                    IsCorrect = false,
                    QuestionID = 3
                },
                new Option
                {
                    OptionID = 15,
                    OptionLetter = "5",
                    OptionText = "Can be left unsecured",
                    IsCorrect = false,
                    QuestionID = 3
                });
            
        }
    }
}
