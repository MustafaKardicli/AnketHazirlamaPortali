using AnketHazırlamaPortalı.API.Dtos;
using AnketHazırlamaPortalı.API.Models;
using AnketHazırlamaPortalı.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AnketHazırlamaPortalı.API.Controllers
{
    [Route("api/Answer")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly AppDbContext _context;
        
        private readonly UserManager<AppUser> _userManager;

        public AnswerController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            
            _userManager = userManager;
        }

        // POST: api/Answer/AddAnswer
        
        
    }
}

