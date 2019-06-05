using System;
using Notes.Models;
using System.Collections.Generic;

namespace Notes.Services
{
    public class NoteService
    {   
        private List<Note> _notes = new List<Note>();

        public List<Note> GetNotes()
        {
            return _notes;
        }
    }
}
