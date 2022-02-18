﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Departmet { get; set; }

        //secret data
        public string Password { get; set; }
        public string SecretData { get; set; }


    }
}
