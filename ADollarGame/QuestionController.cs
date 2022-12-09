
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADollarGame
{
    class QuestionController
    {
        private QuestionDAO DAO = new QuestionDAO();
        private List<QuestionModel> questions = new List<QuestionModel>();

        //Armazena as informações da questões retornadas pela API
        public async Task<bool> getQuestions(string difficulty)
        {
            List<QuestionModel> aux = await DAO.get(difficulty);
            this.questions = aux;
            return true;
        }

        public async Task<string> getQuestionTxt(int i)
        {
            if (questions.Count() == 0 || i >= questions.Count())
            {
                if (i < 5)
                {
                    await getQuestions("easy");

                }
                else if (i >= 5 || i < 10)
                {
                    await getQuestions("medium");

                }
                else
                {
                    await getQuestions("hard");
                }
            }

            return questions[i].Text;
        }

        //Coloca todas as resposta em uma lista, ordena a lista em ordem alfabética e retorna a mesma
        public List<string> getAnswers(int i)
        {
            List<string> aux = new List<string>();

            aux.Add(questions[i].CorrectAnswer);

            foreach (string answer in questions[i].WrongAnswers)
            {
                aux.Add(answer);
            }

            aux.Sort((a, b) => a.CompareTo(b));
            return aux;
        }

        //Verifica se a resposta selecionada é a resposta correta
        public bool verifyAnswer(string answer, int i)
        {
            if (answer == questions[i].CorrectAnswer)
            {
                return true;
            }

            return false;
        }

        //Controle da lifeline cards
        static Random _random = new Random();
        public static void Shuffle<T>(T[] array)
        {
            var random = _random;
            for (int i = array.Length; i > 1; i--)
            {
                int j = random.Next(i);
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        }
        static string[] randCard()
        {
            string[] cards =
            {
                "None",
                "1 question",
                "2 questions",
                "3 questions"
            };
            Shuffle(cards);
            return cards;
        }
    }
}
