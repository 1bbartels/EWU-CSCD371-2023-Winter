﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class JokeOutputter : IJokeOutputter
    {
        public JokeOutputter() { }

        public void OutputJoke(string joke)
        {
            Console.WriteLine(joke);
        }
    }
}
