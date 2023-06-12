using IntelligenceTestModel;

namespace IntelligenceTestMCQS.Services
{
    public interface IQuestions
    {
        Task<List<QuestionsModel>> GetQuestions();
    }
}
