using AnketHazırlamaPortalı.API.Dtos;
using AnketHazırlamaPortalı.Dtos;
using AnketHazırlamaPortalı.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnketHazırlamaPortalı.API.Controllers
{
    [Route("api/QuestionType")]
    [ApiController]
    public class QuestionTypeController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        ResultDto result = new ResultDto();

        public QuestionTypeController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("List")]
        public List<QuestionTypeDto> GetList()
        {
            var questions = _context.QuestionTypes.ToList();
            var questionsDtos = _mapper.Map<List<QuestionTypeDto>>(questions);
            return questionsDtos;
        }

        [HttpGet]
        [Route("{id}")]
        public QuestionTypeDto Get(int id)
        {
            var survey = _context.QuestionTypes.Where(s => s.Id == id).SingleOrDefault();
            var surveyDto = _mapper.Map<QuestionTypeDto>(survey);
            return surveyDto;
        }
    }
}
