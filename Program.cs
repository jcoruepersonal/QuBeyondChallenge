using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuBeyondChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordstream = new List<string>{
                                     "Chill","Hello", "Great","Bye","Joe Doe",
                                        "Hello","Bye","Hello","Green","Blue","Yellow",
                                        "Dog","Cat","Apple","Apple","Bird","Green","Blue",
                                        "Yellow","Dog","Cat","Bird","Green","Blue","Yellow",
                                        "Dog","Cat","Bird","Green","Blue","Yellow","Dog","Cat",
                                        "Bird","Apple"

                                    };
            
            List<string> matrix = new List<string>{
                                        "Bla","Hello","Ant","Idea",
                                        "Great","Bye","Green",
                                        "Blue","Yellow",
                                        "Dog","Cat",
                                        "Bird","Apple"
                                    };

            WordFinder wf = new WordFinder(matrix);

            IEnumerable<string> result= wf.Find(wordstream);
            

        }
    }
}
