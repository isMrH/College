﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBook.Model
{
    public class User
    {
        public int Id { get; set; }
        public string LoginId { get; set; }
        public string LoginPwd { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
}
