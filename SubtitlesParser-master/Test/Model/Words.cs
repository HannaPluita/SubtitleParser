using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Model
{
    public class Words
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<int> PhrasesId { get; set; }

        public Words()
        {
            PhrasesId = new List<int>();
        }
    }
}
