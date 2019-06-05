﻿using System;

namespace Notes.Models
{
    public class Note
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
