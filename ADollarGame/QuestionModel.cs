﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADollarGame
{
    class QuestionModel
    {
        private string text;
        private string correctAnswer;
        private string[] wrongAnswers;
        private string difficulty;

        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
        public string[] WrongAnswers { get; set; }

        public string Difficulty { get; set; }
    }
}
