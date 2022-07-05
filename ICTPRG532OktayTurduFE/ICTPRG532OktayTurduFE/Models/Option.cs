using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Models
{
    public class Option
    {
        [Display(Name = "Option ID")]
        public int OptionID { get; set; }
        [Display(Name = "Text")]
        public string OptionText { get; set; }
        [Display(Name = "Letter")]
        public string OptionLetter { get; set; }
        [Display(Name = "Is Correct?")]
        public Boolean IsCorrect { get; set; }

        // Navigation Properties

        public Question question { get; set; }

        // FK
        [Display(Name = "Question ID")]
        public int QuestionID { get; set; }
    }
}
