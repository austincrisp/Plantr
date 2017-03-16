using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantr.Models
{
    public class Answer
    {
        public int Id { get; set; }

        // List of Answers
        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public string AnswerThree { get; set; }
        public string AnswerFour { get; set; }
        public string AnswerFive { get; set; }
        public string AnswerSix { get; set; }
        public string AnswerSeven { get; set; }
        public string AnswerEight { get; set; }
        public string AnswerNine { get; set; }
        public string AnswerTen { get; set; }
        public string AnswerEleven { get; set; }
        public string AnswerTwelve { get; set; }
        public string AnswerThirteen { get; set; }
        public string AnswerFourteen { get; set; }
        public string AnswerFifteen { get; set; }
        public string AnswerSixteen { get; set; }
        public string AnswerSeventeen { get; set; }
        public string AnswerEighteen { get; set; }
        public string AnswerNineteen { get; set; }
        public string AnswerTwenty { get; set; }

        public virtual Question Question { get; set; }
    }
}