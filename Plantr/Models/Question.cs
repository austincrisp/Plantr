using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantr.Models
{
    public class Question
    {
        public int Id { get; set; }

        // List of Questions
        public string QuestionOne { get; set; }
        public string QuestionTwo { get; set; }
        public string QuestionThree { get; set; }
        public string QuestionFour { get; set; }
        public string QuestionFive { get; set; }
        public string QuestionSix { get; set; }
        public string QuestionSeven { get; set; }
        public string QuestionEight { get; set; }
        public string QuestionNine { get; set; }
        public string QuestionTen { get; set; }
        public string QuestionEleven { get; set; }
        public string QuestionTweleve { get; set; }
        public string QuestionThirteen { get; set; }
        public string QuestionFourteen { get; set; }
        public string QuestionFifteen { get; set; }
        public string QuestionSixteen { get; set; }
        public string QuestionSeventeen { get; set; }
        public string QuestionEighteen { get; set; }
        public string QuestionNineteen { get; set; }
        public string QuestionTwenty { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual Course Course { get; set; }
    }
}