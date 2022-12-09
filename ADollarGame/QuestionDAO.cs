using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ADollarGame
{
    class QuestionDAO
    {
        HttpClient client = new HttpClient();

        //Faz a requisição para a API e retorna as informações da questão
        public async Task<List<QuestionModel>> get()
        {
            List<QuestionModel> li = new List<QuestionModel>();
            string difficulty = "easy";
            int nQuestions = 5;
             
            for(int i = 1; i <= 3; i++)
            {
                if(i == 2)
                {
                    difficulty = "medium";

                }else if(i == 3)
                {
                    nQuestions = 6;
                    difficulty = "hard";
                }

                string url = "https://the-trivia-api.com/api/questions?limit=" + nQuestions + "&difficulty=" + difficulty;   
                var response = await client.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();
                var questions = JsonConvert.DeserializeObject<Questions[]>(content);

                foreach (var question in questions)
                {
                    QuestionModel aux = new QuestionModel();
                    aux.Text = question.Question;
                    aux.CorrectAnswer = question.CorrectAnswer;
                    aux.WrongAnswers = question.IncorrectAnswers;

                    li.Add(aux);
                }
            }

            return li;
        }
    }
}
