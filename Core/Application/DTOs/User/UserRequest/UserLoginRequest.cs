﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.User.UserRequest
{
    public class UserLoginRequest
    {
        public string User { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
