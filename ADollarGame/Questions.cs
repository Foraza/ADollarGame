namespace ADollarGame
{
    using Newtonsoft.Json;

    public partial class Questions
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("correctAnswer")]
        public string CorrectAnswer { get; set; }

        [JsonProperty("incorrectAnswers")]
        public string[] IncorrectAnswers { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("regions")]
        public object[] Regions { get; set; }
    }
}


