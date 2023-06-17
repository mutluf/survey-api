using MaSurvey.Application.DTOs;

namespace MaSurvey.Application.Features.Queries.Options.GetAllOptions
{
    public class GetAllOptionsResponse
    {
        public IList<OptionDTO> OptionDTOs { get; set; }
    }
}
