using SubtitlesParser.Classes.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SubtitlesParser.Classes.Parsers
{
    public class BaseParser
    {
        protected readonly char[] _wordSeparators = { ' ', ',', '.', '!', '?', ';', ':' };

        //public List<SubtitleItem> items = new List<SubtitleItem>();

        //public SortedSet<string> words = new SortedSet<string>();

        protected bool AddWords(SubtitleItem item)
        {
            if(item == null || item.Lines.Count == 0)
            {
                return false;
            }

            bool add = false;

            foreach(string line in item.Lines)
            {
                string[] words;

                if(TryParseWords(line, out words) && words.Length > 0)
                {
                    add = true;

                    foreach(string word in words)
                    {
                        item.Words.Add(word);
                    }
                }
            }
                       
            return add;
        }
        protected bool TryParseWords(string line, out string[] words)
        {
            words = null;

            if (string.IsNullOrEmpty(line))
            {
                return false;
            }

            words = line.Split(_wordSeparators, StringSplitOptions.RemoveEmptyEntries);

            if(words.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
