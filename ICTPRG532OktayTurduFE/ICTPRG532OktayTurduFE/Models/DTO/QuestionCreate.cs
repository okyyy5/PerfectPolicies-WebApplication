using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Models.DTO
{
    public class QuestionCreate
    {
        public string QuestionTopic { get; set; }
        public string QuestionText { get; set; }
        public string? QuestionImage { get; set; }


        // FK
        public int QuizID { get; set; }
    }
}
