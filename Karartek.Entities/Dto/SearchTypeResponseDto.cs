using System;
using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class SearchTypeResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; }
        public List<SearchType> SearchTypes { get; set; } = null!;
    }
}

