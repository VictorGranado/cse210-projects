using System;

namespace Develop02
{
    public class Entry
    {
        public string Prompt { get; set; }  // The prompt for the entry.
        public string Response { get; set; }  // The response given by the user
        public DateTime Date { get; set; }  // The date and time when the entry was created
    }
}