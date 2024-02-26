﻿using System;
using System.Collections.Generic;

namespace QLTV.Data.Model
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Deleted { get; set; } = 0;   

        public virtual ICollection<Book> Books { get; set; }
    }
}
