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
        private string url = "https://the-trivia-api.com/api/questions?limit=5&difficulty=";

        //Faz a requisição para a API e retorna as informações da questão
        public async Task<List<QuestionModel>> get(string difficulty)
        {
            var response = await client.GetAsync(url + difficulty);
            var content = await response.Content.ReadAsStringAsync();
            var questions = JsonConvert.DeserializeObject<Questions[]>(content);
            //var question = questions[0];

            List<QuestionModel> li = new List<QuestionModel>();

            foreach (var question in questions)
            {
                QuestionModel aux = new QuestionModel();
                aux.Text = question.Question;
                aux.CorrectAnswer = question.CorrectAnswer;
                aux.WrongAnswers = question.IncorrectAnswers;

                li.Add(aux);
            }

            return li;
        }
    }
}
