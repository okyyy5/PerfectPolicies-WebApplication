using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Models
{
    public class Quiz
    {
        [Display(Name = "Quiz ID")]
        public int QuizID { get; set; }
        [Display(Name = "Title")]
        public string QuizTitle { get; set; }
        [Display(Name = "Topic")]
        public string QuizTopic { get; set; }
        [Display(Name = "Author")]
        public string QuizAuthor { get; set; }
        [Display(Name = "Quiz Creation Date")]
        public DateTime? QuizDate { get; set; }
        [Display(Name = "Quiz Pass Percentage")]
        public int QuizPass { get; set; }

        // Navigation Properties

        public ICollection<Question> Questions { get; set; }
    }
}
