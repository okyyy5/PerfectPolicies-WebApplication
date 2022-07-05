using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurdu.Entities
{
    public class Option
    {
        public int OptionID { get; set; }
        public string OptionText { get; set; }
        public string OptionLetter { get; set; }
        public Boolean IsCorrect { get; set; }

        // Navigation Properties

        public Question question { get; set; }

        // FK
        public int QuestionID { get; set; }
    }
}
