using AutoMapper;
using MaSurvey.Application.DTOs;
using MaSurvey.Application.Features.Commands.Options.CreateOption;
using MaSurvey.Application.Features.Commands.Questions.CreateQuestion;
using MaSurvey.Application.Features.Commands.Surveys.CreateSurvey;
using MaSurvey.Domain.Entities;

namespace StockTracking.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Survey, CreateSurveyRequest>().ReverseMap();
            CreateMap<Survey, SurveyDTO>().ReverseMap();
           
            CreateMap<Question, QuestionDTO>().ForMember(s => s.Options, o => o.MapFrom(a => a.Options)).ReverseMap();
            CreateMap<Question, CreateQuestionRequest>().ReverseMap();

            CreateMap<Option, OptionDTO>().ReverseMap();
            CreateMap<Option, CreateOptionRequest>().ReverseMap();
        }
    }
}
