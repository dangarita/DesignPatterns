using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Interpreter
{
    public class Context
    {
        private string _input;
        private int _output;

        // Constructor

        public Context(string input)
        {
            this.Input = input;
        }

        public string Input { get => _input; set => _input = value; }
        public int Output { get => _output; set => _output = value; }
    }
}
