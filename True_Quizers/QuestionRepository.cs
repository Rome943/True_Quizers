using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using True_Quizers.Models;

namespace True_Quizers
{
    public class QuestionRepository : IQuestionRepository 
    {
        private readonly IDbConnection _conn;

        public QuestionRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Questions> GetAllQuestions()
        {
            return _conn.Query<Questions>("SELECT * FROM Questions;");
        }

        public Questions GetQuestion(int id)
        {
            return (Questions)_conn.QuerySingle<Questions>("SELECT * FROM Questions WHERE QuestionID = @id",
                new { id = id });
        }
        public Questions GetNextQuestion(int id)
        {
            return (Questions)_conn.QuerySingle<Questions>("SELECT * FROM Questions WHERE QuestionID = @id + 1",
                new { id = id });
        }
        public Questions GetPreviousQuestion(int id)
        {
            return (Questions)_conn.QuerySingle<Questions>("SELECT * FROM Questions WHERE QuestionID = @id - 1",
                new { id = id });
        }



    }
}
