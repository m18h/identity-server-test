﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IndentityServerTest.BusinessLayer
{
    public class UserModel
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string LastName { get; set; }
    }
}
