using IntelligenceTestDAL;
using IntelligenceTestModel;
namespace IntelligenceTestMCQS.Services
{
    public class Questions:IQuestions
    {
        private readonly HttpClient _httpClient;
        public Questions(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<QuestionsModel>> GetQuestions()
        {
            return await _httpClient.GetFromJsonAsync<List<QuestionsModel>>("api/controller/GetQuestion");
        }
    }
}
