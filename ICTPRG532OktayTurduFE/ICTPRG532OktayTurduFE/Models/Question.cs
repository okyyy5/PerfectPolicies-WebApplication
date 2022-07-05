using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Models
{
    public class Question
    {
        [Display(Name = "Question ID")]
        public int QuestionID { get; set; }
        [Display(Name = "Topic")]
        public string QuestionTopic { get; set; }
        [Display(Name = "Text")]
        public string QuestionText { get; set; }
        [Display(Name = "Image")]
        public string? QuestionImage { get; set; }

        // Navigation Properties

        public ICollection<Option> Options { get; set; }

        public Quiz Quiz { get; set; }

        //FK
        [Display(Name = "Quiz ID")]
        public int QuizID { get; set; }
    }
}
