using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Model
{
    public class Phrase
    {
        public int Id { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public List<string> Lines { get; set; }
        public SortedSet<Words> Words { get; set; }
    }
}
