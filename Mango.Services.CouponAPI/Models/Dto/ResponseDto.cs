﻿namespace Mango.Services.CouponAPI.Models.Dto
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool isSuccess { get; set; } = true;

        public string Message { get; set; } = "";
    }
}
