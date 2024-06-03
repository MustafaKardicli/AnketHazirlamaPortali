using AnketHazırlamaPortalı.API.Models;
using AnketHazırlamaPortalı.Models;

namespace AnketHazırlamaPortalı.API.Dtos
{
    public class AnswerDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        
        public bool YesNoAnswer { get; set; }


        public int QuestionId { get; set; }

        
    }
}
