﻿using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entites.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
        public int SystemPoint { get; set; }



    }
}
