using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingII_QuizFramework
{
    internal class Quiz
    {
        public string QuizName = "Terminology Quiz"; //this can be changed based on what data is loaded in
        public Dictionary<string, string> TermsAndDefinitions = new Dictionary<string, string>();
    }
}
