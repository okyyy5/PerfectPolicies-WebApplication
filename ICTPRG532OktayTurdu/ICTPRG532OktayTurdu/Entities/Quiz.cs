using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurdu.Entities
{
    public class Quiz
    {
        public int QuizID { get; set; }
        public string QuizTitle { get; set; }
        public string QuizTopic { get; set; }
        public string QuizAuthor { get; set; }
        public DateTime? QuizDate { get; set; }
        public int QuizPass { get; set; }

        // Navigation Properties

        public ICollection<Question> Questions { get; set; }


    }
}
