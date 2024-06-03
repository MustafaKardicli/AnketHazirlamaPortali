using AnketHazırlamaPortalı.API.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace AnketHazırlamaPortalı.Models
{
    public class Survey
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string CreatorUserId { get; set; }
        public AppUser AppUser { get; set; }
        public bool IsActive { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public List<Question> Questions { get; set; }
    }
}
