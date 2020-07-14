﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreTest.Data
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Country { get; set; }
        public List<Person> People { get; set; }
    }
}
