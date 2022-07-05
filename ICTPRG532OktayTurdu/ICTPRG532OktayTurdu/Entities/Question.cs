using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurdu.Entities
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionTopic { get; set; }
        public string QuestionText { get; set; }
        public string? QuestionImage { get; set; }

        // Navigation Properties

        public ICollection<Option> Options { get; set; }

        public Quiz Quiz { get; set; }

        //FK

        public int QuizID { get; set; }
    }
}
