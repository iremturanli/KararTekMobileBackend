﻿namespace Karartek.Entities.Dto
{
    public class ResponseDto
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public string Token { get; set; } = null!;
    }

}
