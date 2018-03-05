using System;
using System.Collections.Generic;
using System.Text;

namespace MongoExample.Models
{
    public class NoteModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
