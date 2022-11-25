using System;
using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class SearchTypeResponseDto:BaseResponseDto
    {

        public List<SearchType> SearchTypes { get; set; } = null!;
    }
}

