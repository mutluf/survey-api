using AutoMapper;
using MaSurvey.Application.CQRSFeatures.QuestionFeatures.Requests.CreateQuestion;
using MaSurvey.Application.CQRSFeatures.SurveyFeatures.Requests.CreateSurvey;
using MaSurvey.Application.DTOs;
using MaSurvey.Domain.Entities;

namespace StockTracking.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Survey, CreateSurveyRequest>().ReverseMap();
            CreateMap<Survey, SurveyDTO>().ReverseMap();


            CreateMap<Question, QuestionDTO>().ReverseMap();
            CreateMap<Question, CreateQuestionRequest>().ReverseMap();
        }
    }
}
