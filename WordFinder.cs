using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuBeyondChallenge
{
    public class WordFinder
    {
        private IEnumerable<string> mat;
        public WordFinder(IEnumerable<string> matrix)
        {
            mat = matrix;
            
        }

        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            List<string> foundWords = new List<string>();
            
            if (wordstream.Count() > 0)
            {

                foundWords = wordstream.Where(p => mat.Contains(p)).ToList();
                
                return foundWords.GroupBy(pal => pal).OrderByDescending(pal => pal.Count()).Select(res => res.Key).ToList().Take(10);
            }

            else
            {
                return wordstream;
            }
        }        
    }
}
