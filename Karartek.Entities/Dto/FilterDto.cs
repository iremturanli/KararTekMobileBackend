using System;
namespace Karartek.Entities.Dto
{
	public class FilterDto
	{
        public string keyword { get; set; } = null!;
        public int? searchTypeId { get; set; }
        public int judgmentTypeId{ get; set; } 
    }
}

