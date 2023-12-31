﻿using MaSurvey.Domain.Entities.Common;

namespace MaSurvey.Domain.Entities
{
    public class Option:BaseEntity
    {
        public string OptionContent { get; set; }
        public int VoteAmount { get; set; }
        public Question? Question { get; set; }
        public int QuestionId { get; set; }
        public ICollection<AnsweredOption> AnsweredOptions { get; set;}
        public ICollection<Vote>? Votes { get; set; }


    }
}
