using Microsoft.AspNetCore.Mvc;
using IntelligenceTestModel;
using IntelligenceTestDAL;
namespace IntelligenceTest.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class QuestionController : Controller
    {
        [HttpGet]
        [Route("GetQuestion")]
        public async Task<JsonResult> GetQuestions()
        {
            List<QuestionsModel> questions = new List<QuestionsModel>();
            questions = QuestionsDAL.GetAllQuestions();
            if (questions.Count > 0)
            {
                return new JsonResult(questions);
            }
            else
            {
                return new JsonResult("Not Found");
            }
        }
    }
}
