﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCwithDapper.Models
{
    public class BooksModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public double Price { get; set; }
    }
}