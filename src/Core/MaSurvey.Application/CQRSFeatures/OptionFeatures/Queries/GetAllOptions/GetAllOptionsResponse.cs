using MaSurvey.Application.DTOs;

namespace MaSurvey.Application.CQRSFeatures.OptionFeatures.Queries.GetAllOptions
{
    public class GetAllOptionsResponse
    {
        public IList<OptionDTO> OptionDTOs { get; set; }
    }
}
