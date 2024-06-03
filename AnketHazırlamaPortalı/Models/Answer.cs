using AnketHazırlamaPortalı.Models;

namespace AnketHazırlamaPortalı.API.Models
{
    public class Answer
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public AppUser AppUser { get; set; }
        public string OptionText { get; set; }

        public bool OptionValue { get; set; }
        public int QuestionId { get; set; }

        public Question Questions { get; set; }
    }
}
