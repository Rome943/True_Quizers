﻿using System;
using System.Collections.Generic;
using True_Quizers.Models;

namespace True_Quizers
{
    public interface IQuestionRepository
    {
        public IEnumerable<Questions> GetAllQuestions();
        public Questions GetQuestion(int id);
    }
}
