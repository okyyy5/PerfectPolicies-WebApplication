using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICTPRG532OktayTurduFE.Models.DTO
{
    public class OptionCreate
    {
        public string OptionText { get; set; }
        public string OptionLetter { get; set; }
        public Boolean IsCorrect { get; set; }

        // FK
        public int QuestionID { get; set; }
    }
}
