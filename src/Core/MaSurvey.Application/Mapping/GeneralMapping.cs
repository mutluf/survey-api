using AutoMapper;
using MaSurvey.Application.DTOs;
using MaSurvey.Domain.Entities;

namespace StockTracking.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            
            CreateMap<Survey, SurveyDTO>().ForMember(s => s.Questions, o => o.MapFrom(a => a.Questions)).ReverseMap();

            CreateMap<Question, QuestionDTO>().ForMember(s => s.Options, o => o.MapFrom(a => a.Options)).ReverseMap();

            CreateMap<Option, OptionDTO>().ReverseMap();


            CreateMap<Response, ResponseDTO>().ForMember(s => s.Questions, o => o.MapFrom(a => a.Questions)).ReverseMap();
            CreateMap<AnsweredQuestionDTO, AnsweredQuestion>().ForMember(s => s.Options, o => o.MapFrom(a => a.Options)).ReverseMap();

            CreateMap<AnsweredOption, AnsweredOptionDTO>().ReverseMap();
            
        }
    }
}
