using AnketHazırlamaPortalı.Models;

namespace AnketHazırlamaPortalı.API.Models
{
    public class QuestionType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public List<Question> Questions { get; set; }
    }
}
