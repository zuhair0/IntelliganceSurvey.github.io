using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligenceTestModel
{
    public class QuestionsModel
    {
        public int Id { get; set; }
        public string QuestionDetail { get; set; }
        public string QuestionUrdu { get; set; }
        public int Score { get; set; }
        public int AnswerIndex { get;set; }
        public List<string> choice { get; set; }
        public QuestionsModel()
        {
            choice = new List<string>();
        }
        public int naturalisticScore { get; set; }
        public int musicalScore { get; set; }
        public int logicalScore { get; set; }
        public int existentialScore { get; set; }
        public int interpersonalScore { get; set; }
        public int bodyScore { get; set; }
        public int verbalScore { get; set; }
        public int intrapersonalScore { get; set; }
        public int visualScore { get; set; }
    }
}
