﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndToEnd.Models
{
    public class Upload
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Discription { get; set; }
    }
}