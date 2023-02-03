﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class Jester
    {
        private readonly IJokeService _jokeService;
        private readonly IJokeOutputter _jokeOutputter;
        
        public Jester(IJokeService? jokeService, IJokeOutputter? jokeOutput)
        {
            if(jokeService is null)
            {
                throw new ArgumentNullException(nameof(jokeService));
            }
            if(jokeOutput is null)
            {
                throw new ArgumentNullException(nameof(jokeOutput));
            }
                _jokeService = jokeService;
                _jokeOutputter = jokeOutput;
        }

        public void TellJoke()
        {
            string joke = _jokeService.GetJoke();
            while(joke.Contains("Chuck Norris"))
            {              
                joke = _jokeService.GetJoke();
            }
            
            _jokeOutputter.OutputJoke(joke);
        }
    }
}
