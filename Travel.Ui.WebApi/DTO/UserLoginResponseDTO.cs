﻿namespace Travel.Ui.WebApi.DTO
{
    public class UserLoginResponseDTO
    {
        public string Token { get; set; }
        public bool Login { get; set; }
        public List<string> Errors { get; set; }
    }
}
